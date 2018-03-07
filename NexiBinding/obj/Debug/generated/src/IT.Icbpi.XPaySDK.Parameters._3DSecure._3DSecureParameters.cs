using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Parameters._3DSecure {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters._3DSecure']/class[@name='_3DSecureParameters']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Parameters/_3DSecure/_3DSecureParameters", DoNotGenerateAcw=true)]
	public partial class _3DSecureParameters : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters._3DSecure']/class[@name='_3DSecureParameters']/field[@name='HP_CALLER']"
		[Register ("HP_CALLER")]
		public const string HpCaller = (string) "HP_CALLER";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters._3DSecure']/class[@name='_3DSecureParameters']/field[@name='HTML']"
		[Register ("HTML")]
		public const string Html = (string) "html";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters._3DSecure']/class[@name='_3DSecureParameters']/field[@name='PRIMI_PAGAMENTI_CALLER']"
		[Register ("PRIMI_PAGAMENTI_CALLER")]
		public const string PrimiPagamentiCaller = (string) "HP_CALLER";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters._3DSecure']/class[@name='_3DSecureParameters']/field[@name='RICORRENZE_CALLER']"
		[Register ("RICORRENZE_CALLER")]
		public const string RicorrenzeCaller = (string) "HP_CALLER";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters._3DSecure']/class[@name='_3DSecureParameters']/field[@name='SELECTED_ENVIRONMENT']"
		[Register ("SELECTED_ENVIRONMENT")]
		public const string SelectedEnvironment = (string) "SELECTED_ENVIRONMENT";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Parameters/_3DSecure/_3DSecureParameters", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (_3DSecureParameters); }
		}

		protected _3DSecureParameters (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters._3DSecure']/class[@name='_3DSecureParameters']/constructor[@name='_3DSecureParameters' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe _3DSecureParameters ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (_3DSecureParameters)) {
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
