using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK']/class[@name='ActivityFrontOfficeQP']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/ActivityFrontOfficeQP", DoNotGenerateAcw=true)]
	public partial class ActivityFrontOfficeQP : global::Android.App.Activity {


		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK']/class[@name='ActivityFrontOfficeQP']/field[@name='UTF_8']"
		[Register ("UTF_8")]
		public const string Utf8 = (string) "UTF-8";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/ActivityFrontOfficeQP", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ActivityFrontOfficeQP); }
		}

		protected ActivityFrontOfficeQP (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK']/class[@name='ActivityFrontOfficeQP']/constructor[@name='ActivityFrontOfficeQP' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ActivityFrontOfficeQP ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ActivityFrontOfficeQP)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

	}
}
