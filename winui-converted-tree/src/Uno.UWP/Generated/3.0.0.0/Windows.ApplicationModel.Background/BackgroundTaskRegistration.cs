// <auto-generated>
#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Background
{
#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
#endif
	public partial class BackgroundTaskRegistration : global::Windows.ApplicationModel.Background.IBackgroundTaskRegistration, global::Windows.ApplicationModel.Background.IBackgroundTaskRegistration2, global::Windows.ApplicationModel.Background.IBackgroundTaskRegistration3
	{
		// Skipping already declared property Name
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Guid TaskId
		{
			get
			{
				throw new global::System.NotImplementedException("The member Guid BackgroundTaskRegistration.TaskId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Guid%20BackgroundTaskRegistration.TaskId");
			}
		}
#endif
		// Skipping already declared property Trigger
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Background.BackgroundTaskRegistrationGroup TaskGroup
		{
			get
			{
				throw new global::System.NotImplementedException("The member BackgroundTaskRegistrationGroup BackgroundTaskRegistration.TaskGroup is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=BackgroundTaskRegistrationGroup%20BackgroundTaskRegistration.TaskGroup");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::System.Collections.Generic.IReadOnlyDictionary<global::System.Guid, global::Windows.ApplicationModel.Background.IBackgroundTaskRegistration> AllTasks
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyDictionary<Guid, IBackgroundTaskRegistration> BackgroundTaskRegistration.AllTasks is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyDictionary%3CGuid%2C%20IBackgroundTaskRegistration%3E%20BackgroundTaskRegistration.AllTasks");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::System.Collections.Generic.IReadOnlyDictionary<string, global::Windows.ApplicationModel.Background.BackgroundTaskRegistrationGroup> AllTaskGroups
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyDictionary<string, BackgroundTaskRegistrationGroup> BackgroundTaskRegistration.AllTaskGroups is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyDictionary%3Cstring%2C%20BackgroundTaskRegistrationGroup%3E%20BackgroundTaskRegistration.AllTaskGroups");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskRegistration.TaskId.get
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskRegistration.Name.get
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskRegistration.Progress.add
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskRegistration.Progress.remove
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskRegistration.Completed.add
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskRegistration.Completed.remove
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void Unregister(bool cancelTask)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.BackgroundTaskRegistration", "void BackgroundTaskRegistration.Unregister(bool cancelTask)");
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskRegistration.Trigger.get
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskRegistration.TaskGroup.get
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskRegistration.AllTaskGroups.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.ApplicationModel.Background.BackgroundTaskRegistrationGroup GetTaskGroup(string groupId)
		{
			throw new global::System.NotImplementedException("The member BackgroundTaskRegistrationGroup BackgroundTaskRegistration.GetTaskGroup(string groupId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=BackgroundTaskRegistrationGroup%20BackgroundTaskRegistration.GetTaskGroup%28string%20groupId%29");
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Background.BackgroundTaskRegistration.AllTasks.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public event global::Windows.ApplicationModel.Background.BackgroundTaskCompletedEventHandler Completed
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.BackgroundTaskRegistration", "event BackgroundTaskCompletedEventHandler BackgroundTaskRegistration.Completed");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.BackgroundTaskRegistration", "event BackgroundTaskCompletedEventHandler BackgroundTaskRegistration.Completed");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public event global::Windows.ApplicationModel.Background.BackgroundTaskProgressEventHandler Progress
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.BackgroundTaskRegistration", "event BackgroundTaskProgressEventHandler BackgroundTaskRegistration.Progress");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.BackgroundTaskRegistration", "event BackgroundTaskProgressEventHandler BackgroundTaskRegistration.Progress");
			}
		}
#endif
		// Processing: Windows.ApplicationModel.Background.IBackgroundTaskRegistration
		// Processing: Windows.ApplicationModel.Background.IBackgroundTaskRegistration2
		// Processing: Windows.ApplicationModel.Background.IBackgroundTaskRegistration3
	}
}