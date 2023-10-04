#nullable enable

using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using Uno.Extensions;
using Uno.Roslyn;
using Uno.UI.SourceGenerators.Helpers;

namespace Uno.UI.SourceGenerators.RemoteControl
{
	[Generator]
	public class RemoteControlGenerator : ISourceGenerator
	{
		const string LibraryXamlSearchPathAssemblyMetadata = "Uno.RemoteControl.XamlSearchPaths";

		/// <summary>
		/// This list of properties used to capture the environment of the building project
		/// so it can be propagated to the remote control server's hot reload workspace.
		/// The list is derived from a extract of a build log inside Visual Studio and may
		/// need to be updated if new properties are required.
		/// </summary>
		private static readonly string[] AdditionalMSProperties = new[] {
			"SolutionFileName",
			"LangName",
			"Configuration",
			"LangID",
			"SolutionDir",
			"SolutionExt",
			"BuildingInsideVisualStudio",
			"UnoRemoteControlPort",
			"UseHostCompilerIfAvailable",
			"TargetFramework",
			"DefineExplicitDefaults",
			"Platform",
			"RuntimeIdentifier",
			"SolutionPath",
			"SolutionName",
			"VSIDEResolvedNonMSBuildProjectOutputs",
			"DevEnvDir",
		};

		public void Initialize(GeneratorInitializationContext context)
		{
		}

		public void Execute(GeneratorExecutionContext context)
		{
			if (!DesignTimeHelper.IsDesignTime(context)
				&& context.GetMSBuildPropertyValue("Configuration") == "Debug")
			{
				if ((IsRemoteControlClientInstalled(context)

					// Inside the uno solution we generate the attributes anyways, so 
					// we can test the remote control tooling explicitly.
					|| IsInsideUnoSolution(context))

					&& PlatformHelper.IsApplication(context))
				{
					var sb = new IndentedStringBuilder();

					BuildGeneratedFileHeader(sb);

					BuildEndPointAttribute(context, sb);
					BuildProjectConfiguration(context, sb);
					BuildServerProcessorsPaths(context, sb);

					context.AddSource("RemoteControl", sb.ToString());
				}
				else if (PlatformHelper.IsValidPlatform(context))
				{
					var sb = new IndentedStringBuilder();

					BuildGeneratedFileHeader(sb);

					BuildLibrarySearchPath(context, sb);

					context.AddSource("RemoteControl", sb.ToString());
				}
			}
		}

		private static bool IsInsideUnoSolution(GeneratorExecutionContext context)
			=> context.GetMSBuildPropertyValue("_IsUnoUISolution") == "true";

		private static void BuildGeneratedFileHeader(IndentedStringBuilder sb)
		{
			sb.AppendLineIndented("// <auto-generated>");
			sb.AppendLineIndented("// ***************************************************************************************");
			sb.AppendLineIndented("// This file has been generated by the package Uno.UI.DevServer - for Xaml Hot Reload.");
			sb.AppendLineIndented("// Documentation: https://platform.uno/docs/articles/features/working-with-xaml-hot-reload.html");
			sb.AppendLineIndented("// ***************************************************************************************");
			sb.AppendLineIndented("// </auto-generated>");
			sb.AppendLineIndented("// <autogenerated />");
			sb.AppendLineIndented("#pragma warning disable // Ignore code analysis warnings");

			sb.AppendLineIndented("");
		}

		private void BuildServerProcessorsPaths(GeneratorExecutionContext context, IndentedStringBuilder sb)
		{
			sb.AppendLineIndented($"[assembly: global::Uno.UI.RemoteControl.ServerProcessorsConfigurationAttribute(" +
				$"@\"{context.GetMSBuildPropertyValue("UnoRemoteControlProcessorsPath")}\"" +
				$")]");
		}

		private static bool IsRemoteControlClientInstalled(GeneratorExecutionContext context)
			=> context.Compilation.GetTypeByMetadataName("Uno.UI.RemoteControl.RemoteControlClient") != null;


		/// <summary>
		/// Generates the attribute used by the remotecontrol client to configure the server.
		/// </summary>
		private static void BuildProjectConfiguration(GeneratorExecutionContext context, IndentedStringBuilder sb)
		{
			sb.AppendLineIndented($"[assembly: global::Uno.UI.RemoteControl.ProjectConfigurationAttribute(");
			sb.AppendLineIndented($"@\"{context.GetMSBuildPropertyValue("MSBuildProjectFullPath")}\",\n");

			var xamlPaths = EnumerateLocalSearchPaths(context)
				.Concat(EnumerateLibrarySearchPaths(context));

			var distinctPaths = string.Join(",\n", xamlPaths.Select(p => $"@\"{p}\""));

			sb.AppendLineIndented($"new string[]{{{distinctPaths}}},");

			// Provide additional properties so that our hot reload workspace can properly
			// replicate the original build environment that was used (e.g. VS or dotnet build)
			var additionalPropertiesValue = string.Join(
				", ",
				AdditionalMSProperties.Select(p => $"@\"{p}={Convert.ToBase64String(Encoding.UTF8.GetBytes(context.GetMSBuildPropertyValue(p)))}\""));

			sb.AppendLineIndented($"new [] {{ {additionalPropertiesValue} }}");

			sb.AppendLineIndented(")]");
		}

		/// <summary>
		/// Generates the list of paths used by the current project, to be used by the main project
		/// to create the "ProjectConfigurationAttribute". This avoids relying on msbuild to determine
		/// paths to search for hot-reloadable files files.
		/// </summary>
		private static void BuildLibrarySearchPath(GeneratorExecutionContext context, IndentedStringBuilder sb)
		{
			var xamlPaths = EnumerateLocalSearchPaths(context);

			if (xamlPaths.Any())
			{
				var distictPaths = string.Join(Path.PathSeparator.ToString(), xamlPaths);

				sb.AppendLineIndented($"""
					[assembly: global::System.Reflection.AssemblyMetadata(
						"{LibraryXamlSearchPathAssemblyMetadata}",
						@"{distictPaths}"
					)]
					""");
			}
		}

		private static IEnumerable<string> EnumerateLibrarySearchPaths(GeneratorExecutionContext context)
		{
			var assemblyMetadataSymbol = context.Compilation.GetTypeByMetadataName("System.Reflection.AssemblyMetadataAttribute");

			foreach (var reference in context.Compilation.References)
			{
				if (context.Compilation.GetAssemblyOrModuleSymbol(reference) is IAssemblySymbol assembly)
				{
					var xamlSearchPathAttribute = assembly.GetAttributes().FirstOrDefault(a =>
						SymbolEqualityComparer.Default.Equals(a.AttributeClass, assemblyMetadataSymbol)
						&& a.ConstructorArguments.Length == 2
						&& a.ConstructorArguments[0].Value is LibraryXamlSearchPathAssemblyMetadata);

					if (xamlSearchPathAttribute is not null)
					{
						var rawPaths = xamlSearchPathAttribute
							?.ConstructorArguments[1]
							.Value
							?.ToString();

						if (rawPaths is not null)
						{
							foreach (var path in rawPaths.Split(new[] { Path.PathSeparator }, StringSplitOptions.RemoveEmptyEntries))
							{
								yield return path;
							}
						}
					}
				}
			}
		}

		private static IEnumerable<string> EnumerateLocalSearchPaths(GeneratorExecutionContext context)
		{
			var msBuildProjectDirectory = context.GetMSBuildPropertyValue("MSBuildProjectDirectory");
			var sources = new[] {
					"Page",
					"ApplicationDefinition"
				};

			IEnumerable<string> BuildSearchPath(string s)
				=> context
					.GetMSBuildItemsWithAdditionalFiles(s)
					.Select(v => Path.IsPathRooted(v.Identity) ? v.Identity : Path.Combine(msBuildProjectDirectory, v.Identity));

			var xamlPaths = from item in sources.SelectMany(BuildSearchPath)
							select Path.GetDirectoryName(item);

			return xamlPaths.Distinct().Where(x => !string.IsNullOrEmpty(x));
		}

		private static void BuildEndPointAttribute(GeneratorExecutionContext context, IndentedStringBuilder sb)
		{
			var unoRemoteControlPort = context.GetMSBuildPropertyValue("UnoRemoteControlPort");

			if (string.IsNullOrEmpty(unoRemoteControlPort))
			{
				unoRemoteControlPort = "0";
			}

			var unoRemoteControlHost = context.GetMSBuildPropertyValue("UnoRemoteControlHost");

			if (string.IsNullOrEmpty(unoRemoteControlHost))
			{
				// Inside the Uno Solution we do not start the remote control
				// client, as the location of the RC server is not coming from 
				// a nuget package.
				if (!IsInsideUnoSolution(context))
				{
					var addresses = NetworkInterface.GetAllNetworkInterfaces()
						.SelectMany(x => x.GetIPProperties().UnicastAddresses)
						.Where(x => !IPAddress.IsLoopback(x.Address));
					//This is not supported on linux yet: .Where(x => x.DuplicateAddressDetectionState == DuplicateAddressDetectionState.Preferred);

					foreach (var addressInfo in addresses)
					{
						var address = addressInfo.Address;

						string addressStr;
						if (address.AddressFamily == AddressFamily.InterNetworkV6)
						{
							address.ScopeId = 0; // remove annoying "%xx" on IPv6 addresses
							addressStr = $"[{address}]";
						}
						else
						{
							addressStr = address.ToString();
						}
						sb.AppendLineIndented($"[assembly: global::Uno.UI.RemoteControl.ServerEndpointAttribute(\"{addressStr}\", {unoRemoteControlPort})]");
					}
				}
			}
			else
			{
				sb.AppendLineIndented($"[assembly: global::Uno.UI.RemoteControl.ServerEndpointAttribute(\"{unoRemoteControlHost}\", {unoRemoteControlPort})]");
			}
		}
	}
}
