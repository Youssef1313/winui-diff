// <auto-generated>
#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation.Provider
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial interface ITextProvider
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.Xaml.Automation.Provider.ITextRangeProvider DocumentRange
		{
			get;
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.Xaml.Automation.SupportedTextSelection SupportedTextSelection
		{
			get;
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.Xaml.Automation.Provider.ITextRangeProvider[] GetSelection();
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.Xaml.Automation.Provider.ITextRangeProvider[] GetVisibleRanges();
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.Xaml.Automation.Provider.ITextRangeProvider RangeFromChild(global::Microsoft.UI.Xaml.Automation.Provider.IRawElementProviderSimple childElement);
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.Xaml.Automation.Provider.ITextRangeProvider RangeFromPoint(global::Windows.Foundation.Point screenLocation);
#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Provider.ITextProvider.DocumentRange.get
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Provider.ITextProvider.SupportedTextSelection.get
	}
}
