// <auto-generated>
#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Security.Isolation
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public static partial class IsolatedWindowsEnvironmentOwnerRegistration
	{
		// Forced skipping of method Windows.Security.Isolation.IsolatedWindowsEnvironmentOwnerRegistration.As<I>()
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Security.Isolation.IsolatedWindowsEnvironmentOwnerRegistrationResult Register(string ownerName, global::Windows.Security.Isolation.IsolatedWindowsEnvironmentOwnerRegistrationData ownerRegistrationData)
		{
			throw new global::System.NotImplementedException("The member IsolatedWindowsEnvironmentOwnerRegistrationResult IsolatedWindowsEnvironmentOwnerRegistration.Register(string ownerName, IsolatedWindowsEnvironmentOwnerRegistrationData ownerRegistrationData) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IsolatedWindowsEnvironmentOwnerRegistrationResult%20IsolatedWindowsEnvironmentOwnerRegistration.Register%28string%20ownerName%2C%20IsolatedWindowsEnvironmentOwnerRegistrationData%20ownerRegistrationData%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static void Unregister(string ownerName)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Security.Isolation.IsolatedWindowsEnvironmentOwnerRegistration", "void IsolatedWindowsEnvironmentOwnerRegistration.Unregister(string ownerName)");
		}
#endif
	}
}
