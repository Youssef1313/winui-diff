﻿using System;
using System.Threading.Tasks;

namespace Uno.UWPSyncGenerator
{
	class Program
	{
		const string SyncMode = "sync";
		const string DocMode = "doc";
		const string AllMode = "all";

		static async Task Main(string[] args)
		{
			if (args.Length == 0)
			{
				Console.WriteLine("No mode selected. Supported modes: doc, sync & all.");
				return;
			}

			var mode = args[0].ToLowerInvariant();

			if (mode == SyncMode || mode == AllMode)
			{
#if HAS_UNO_WINUI
				await new SyncGenerator().Build();
#else
				await new SyncGenerator().Build("Uno.Foundation", "Windows.Foundation.FoundationContract");
				await new SyncGenerator().Build("Uno", "Windows.Foundation.UniversalApiContract");
				await new SyncGenerator().Build("Uno", "Windows.Phone.PhoneContract");
				await new SyncGenerator().Build("Uno", "Windows.Networking.Connectivity.WwanContract");
				await new SyncGenerator().Build("Uno", "Windows.ApplicationModel.Calls.CallsPhoneContract");
				await new SyncGenerator().Build("Uno", "Windows.Services.Store.StoreContract");

				// When adding support for a new WinRT contract here, ensure to add it to the list of origins in Generator.cs
				// and to the list of supported contracts in ApiInformation.shared.cs

				await new SyncGenerator().Build("Uno.UI.Composition", "Windows.Foundation.UniversalApiContract");
				await new SyncGenerator().Build("Uno.UI.Dispatching", "Windows.Foundation.UniversalApiContract");
				await new SyncGenerator().Build("Uno.UI", "Windows.Foundation.UniversalApiContract");
				await new SyncGenerator().Build("Uno.UI", "Microsoft.UI.Xaml.Hosting.HostingContract");
				await new SyncGenerator().Build("Uno.UI", "Microsoft.UI.Xaml");
				await new SyncGenerator().Build("Uno.UI", "Microsoft.Web.WebView2.Core");
#endif
			}

			if (mode == DocMode || mode == AllMode)
			{
#if HAS_UNO_WINUI
				await new DocGenerator().Build();
#else
				await new DocGenerator().Build("Uno.UI", "Windows.Foundation.UniversalApiContract");
#endif

			}
		}
	}
}
