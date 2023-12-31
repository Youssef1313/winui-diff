// <auto-generated>
#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Services.Store
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial struct StorePackageUpdateStatus
	{
		// Forced skipping of method Windows.Services.Store.StorePackageUpdateStatus.StorePackageUpdateStatus()
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public StorePackageUpdateStatus(string _PackageFamilyName, ulong _PackageDownloadSizeInBytes, ulong _PackageBytesDownloaded, double _PackageDownloadProgress, double _TotalDownloadProgress, global::Windows.Services.Store.StorePackageUpdateState _PackageUpdateState)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Services.Store.StorePackageUpdateStatus", "StorePackageUpdateStatus.StorePackageUpdateStatus(string _PackageFamilyName, ulong _PackageDownloadSizeInBytes, ulong _PackageBytesDownloaded, double _PackageDownloadProgress, double _TotalDownloadProgress, StorePackageUpdateState _PackageUpdateState)");
		}
#endif
		// Forced skipping of method Windows.Services.Store.StorePackageUpdateStatus.StorePackageUpdateStatus(string, ulong, ulong, double, double, Windows.Services.Store.StorePackageUpdateState)
		// Forced skipping of method Windows.Services.Store.StorePackageUpdateStatus.operator ==(Windows.Services.Store.StorePackageUpdateStatus, Windows.Services.Store.StorePackageUpdateStatus)
		// Forced skipping of method Windows.Services.Store.StorePackageUpdateStatus.operator !=(Windows.Services.Store.StorePackageUpdateStatus, Windows.Services.Store.StorePackageUpdateStatus)
		// Forced skipping of method Windows.Services.Store.StorePackageUpdateStatus.Equals(Windows.Services.Store.StorePackageUpdateStatus)
		// Forced skipping of method Windows.Services.Store.StorePackageUpdateStatus.Equals(object)
		// Forced skipping of method Windows.Services.Store.StorePackageUpdateStatus.GetHashCode()
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		public string PackageFamilyName;
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		public ulong PackageDownloadSizeInBytes;
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		public ulong PackageBytesDownloaded;
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		public double PackageDownloadProgress;
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		public double TotalDownloadProgress;
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		public global::Windows.Services.Store.StorePackageUpdateState PackageUpdateState;
#endif
	}
}
