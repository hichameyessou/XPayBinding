using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils']/class[@name='ClientSSLSocketFactory']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Utils/ClientSSLSocketFactory", DoNotGenerateAcw=true)]
	public partial class ClientSSLSocketFactory : global::Android.Net.SSLCertificateSocketFactory {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Utils/ClientSSLSocketFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClientSSLSocketFactory); }
		}

		protected ClientSSLSocketFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils']/class[@name='ClientSSLSocketFactory']/constructor[@name='ClientSSLSocketFactory' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe ClientSSLSocketFactory (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ClientSSLSocketFactory)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

	}
}
