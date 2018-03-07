using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Models.WebViewClients {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients']/class[@name='SSLSkipWebViewClientXP']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Models/WebViewClients/SSLSkipWebViewClientXP", DoNotGenerateAcw=true)]
	public partial class SSLSkipWebViewClientXP : global::IT.Icbpi.XPaySDK.Models.WebViewClients.BaseWebViewClientXP {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Models/WebViewClients/SSLSkipWebViewClientXP", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SSLSkipWebViewClientXP); }
		}

		protected SSLSkipWebViewClientXP (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_FrontOffice_Landroid_app_Activity_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients']/class[@name='SSLSkipWebViewClientXP']/constructor[@name='SSLSkipWebViewClientXP' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.WebApi.Classes.FrontOffice'] and parameter[2][@type='android.app.Activity']]"
		[Register (".ctor", "(Lit/icbpi/XPaySDK/WebApi/Classes/FrontOffice;Landroid/app/Activity;)V", "")]
		public unsafe SSLSkipWebViewClientXP (global::IT.Icbpi.XPaySDK.WebApi.Classes.FrontOffice p0, global::Android.App.Activity p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (SSLSkipWebViewClientXP)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lit/icbpi/XPaySDK/WebApi/Classes/FrontOffice;Landroid/app/Activity;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lit/icbpi/XPaySDK/WebApi/Classes/FrontOffice;Landroid/app/Activity;)V", __args);
					return;
				}

				if (id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_FrontOffice_Landroid_app_Activity_ == IntPtr.Zero)
					id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_FrontOffice_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lit/icbpi/XPaySDK/WebApi/Classes/FrontOffice;Landroid/app/Activity;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_FrontOffice_Landroid_app_Activity_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_FrontOffice_Landroid_app_Activity_, __args);
			} finally {
			}
		}

	}
}
