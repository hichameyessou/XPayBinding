using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.WebApi.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Utils']/class[@name='CFPanTypes']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/WebApi/Utils/CFPanTypes", DoNotGenerateAcw=true)]
	public sealed partial class CFPanTypes : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Utils']/class[@name='CFPanTypes']/field[@name='HASH_PAN']"
		[Register ("HASH_PAN")]
		public const string HashPan = (string) "HashPan";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Utils']/class[@name='CFPanTypes']/field[@name='TAX_CODE']"
		[Register ("TAX_CODE")]
		public const string TaxCode = (string) "CodiceFiscale";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/WebApi/Utils/CFPanTypes", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CFPanTypes); }
		}

		internal CFPanTypes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Utils']/class[@name='CFPanTypes']/constructor[@name='CFPanTypes' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CFPanTypes ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CFPanTypes)) {
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
