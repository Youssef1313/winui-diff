// <auto-generated>
#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Perception.People
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial struct JointPose
	{
		// Forced skipping of method Windows.Perception.People.JointPose.JointPose()
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public JointPose(global::System.Numerics.Quaternion _Orientation, global::System.Numerics.Vector3 _Position, float _Radius, global::Windows.Perception.People.JointPoseAccuracy _Accuracy)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Perception.People.JointPose", "JointPose.JointPose(Quaternion _Orientation, Vector3 _Position, float _Radius, JointPoseAccuracy _Accuracy)");
		}
#endif
		// Forced skipping of method Windows.Perception.People.JointPose.JointPose(System.Numerics.Quaternion, System.Numerics.Vector3, float, Windows.Perception.People.JointPoseAccuracy)
		// Forced skipping of method Windows.Perception.People.JointPose.operator ==(Windows.Perception.People.JointPose, Windows.Perception.People.JointPose)
		// Forced skipping of method Windows.Perception.People.JointPose.operator !=(Windows.Perception.People.JointPose, Windows.Perception.People.JointPose)
		// Forced skipping of method Windows.Perception.People.JointPose.Equals(Windows.Perception.People.JointPose)
		// Forced skipping of method Windows.Perception.People.JointPose.Equals(object)
		// Forced skipping of method Windows.Perception.People.JointPose.GetHashCode()
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		public global::System.Numerics.Quaternion Orientation;
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		public global::System.Numerics.Vector3 Position;
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		public float Radius;
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		public global::Windows.Perception.People.JointPoseAccuracy Accuracy;
#endif
	}
}
