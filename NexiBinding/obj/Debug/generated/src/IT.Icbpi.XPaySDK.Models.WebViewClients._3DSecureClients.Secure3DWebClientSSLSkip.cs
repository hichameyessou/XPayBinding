using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Models.WebViewClients._3DSecureClients {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients._3DSecureClients']/class[@name='Secure3DWebClientSSLSkip']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Models/WebViewClients/_3DSecureClients/Secure3DWebClientSSLSkip", DoNotGenerateAcw=true)]
	public partial class Secure3DWebClientSSLSkip : global::IT.Icbpi.XPaySDK.Models.WebViewClients._3DSecureClients.Secure3DWebClient {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Models/WebViewClients/_3DSecureClients/Secure3DWebClientSSLSkip", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Secure3DWebClientSSLSkip); }
		}

		protected Secure3DWebClientSSLSkip (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_Ricorrenze_Landroid_app_Activity_Lit_icbpi_XPaySDK_Utils_HostedPayments_ParcelUtils_RicorrenzeCaller_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients._3DSecureClients']/class[@name='Secure3DWebClientSSLSkip']/constructor[@name='Secure3DWebClientSSLSkip' and count(parameter)=3 and parameter[1][@type='it.icbpi.XPaySDK.WebApi.Classes.Ricorrenze'] and parameter[2][@type='android.app.Activity'] and parameter[3][@type='it.icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.RicorrenzeCaller']]"
		[Register (".ctor", "(Lit/icbpi/XPaySDK/WebApi/Classes/Ricorrenze;Landroid/app/Activity;Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$RicorrenzeCaller;)V", "")]
		public unsafe Secure3DWebClientSSLSkip (global::IT.Icbpi.XPaySDK.WebApi.Classes.Ricorrenze p0, global::Android.App.Activity p1, global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.RicorrenzeCaller p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (Secure3DWebClientSSLSkip)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lit/icbpi/XPaySDK/WebApi/Classes/Ricorrenze;Landroid/app/Activity;Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$RicorrenzeCaller;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lit/icbpi/XPaySDK/WebApi/Classes/Ricorrenze;Landroid/app/Activity;Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$RicorrenzeCaller;)V", __args);
					return;
				}

				if (id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_Ricorrenze_Landroid_app_Activity_Lit_icbpi_XPaySDK_Utils_HostedPayments_ParcelUtils_RicorrenzeCaller_ == IntPtr.Zero)
					id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_Ricorrenze_Landroid_app_Activity_Lit_icbpi_XPaySDK_Utils_HostedPayments_ParcelUtils_RicorrenzeCaller_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lit/icbpi/XPaySDK/WebApi/Classes/Ricorrenze;Landroid/app/Activity;Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$RicorrenzeCaller;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_Ricorrenze_Landroid_app_Activity_Lit_icbpi_XPaySDK_Utils_HostedPayments_ParcelUtils_RicorrenzeCaller_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_Ricorrenze_Landroid_app_Activity_Lit_icbpi_XPaySDK_Utils_HostedPayments_ParcelUtils_RicorrenzeCaller_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_PrimiPagamentiRecurring_Landroid_app_Activity_Lit_icbpi_XPaySDK_Utils_HostedPayments_ParcelUtils_PrimiPagamentiCaller_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients._3DSecureClients']/class[@name='Secure3DWebClientSSLSkip']/constructor[@name='Secure3DWebClientSSLSkip' and count(parameter)=3 and parameter[1][@type='it.icbpi.XPaySDK.WebApi.Classes.PrimiPagamentiRecurring'] and parameter[2][@type='android.app.Activity'] and parameter[3][@type='it.icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.PrimiPagamentiCaller']]"
		[Register (".ctor", "(Lit/icbpi/XPaySDK/WebApi/Classes/PrimiPagamentiRecurring;Landroid/app/Activity;Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$PrimiPagamentiCaller;)V", "")]
		public unsafe Secure3DWebClientSSLSkip (global::IT.Icbpi.XPaySDK.WebApi.Classes.PrimiPagamentiRecurring p0, global::Android.App.Activity p1, global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.PrimiPagamentiCaller p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (Secure3DWebClientSSLSkip)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lit/icbpi/XPaySDK/WebApi/Classes/PrimiPagamentiRecurring;Landroid/app/Activity;Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$PrimiPagamentiCaller;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lit/icbpi/XPaySDK/WebApi/Classes/PrimiPagamentiRecurring;Landroid/app/Activity;Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$PrimiPagamentiCaller;)V", __args);
					return;
				}

				if (id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_PrimiPagamentiRecurring_Landroid_app_Activity_Lit_icbpi_XPaySDK_Utils_HostedPayments_ParcelUtils_PrimiPagamentiCaller_ == IntPtr.Zero)
					id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_PrimiPagamentiRecurring_Landroid_app_Activity_Lit_icbpi_XPaySDK_Utils_HostedPayments_ParcelUtils_PrimiPagamentiCaller_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lit/icbpi/XPaySDK/WebApi/Classes/PrimiPagamentiRecurring;Landroid/app/Activity;Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$PrimiPagamentiCaller;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_PrimiPagamentiRecurring_Landroid_app_Activity_Lit_icbpi_XPaySDK_Utils_HostedPayments_ParcelUtils_PrimiPagamentiCaller_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_PrimiPagamentiRecurring_Landroid_app_Activity_Lit_icbpi_XPaySDK_Utils_HostedPayments_ParcelUtils_PrimiPagamentiCaller_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_HostedPayments_Landroid_app_Activity_Lit_icbpi_XPaySDK_Utils_HostedPayments_ParcelUtils_HPCaller_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients._3DSecureClients']/class[@name='Secure3DWebClientSSLSkip']/constructor[@name='Secure3DWebClientSSLSkip' and count(parameter)=3 and parameter[1][@type='it.icbpi.XPaySDK.WebApi.Classes.HostedPayments'] and parameter[2][@type='android.app.Activity'] and parameter[3][@type='it.icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.HPCaller']]"
		[Register (".ctor", "(Lit/icbpi/XPaySDK/WebApi/Classes/HostedPayments;Landroid/app/Activity;Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$HPCaller;)V", "")]
		public unsafe Secure3DWebClientSSLSkip (global::IT.Icbpi.XPaySDK.WebApi.Classes.PaymentHost p0, global::Android.App.Activity p1, global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.HPCaller p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (Secure3DWebClientSSLSkip)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lit/icbpi/XPaySDK/WebApi/Classes/HostedPayments;Landroid/app/Activity;Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$HPCaller;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lit/icbpi/XPaySDK/WebApi/Classes/HostedPayments;Landroid/app/Activity;Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$HPCaller;)V", __args);
					return;
				}

				if (id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_HostedPayments_Landroid_app_Activity_Lit_icbpi_XPaySDK_Utils_HostedPayments_ParcelUtils_HPCaller_ == IntPtr.Zero)
					id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_HostedPayments_Landroid_app_Activity_Lit_icbpi_XPaySDK_Utils_HostedPayments_ParcelUtils_HPCaller_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lit/icbpi/XPaySDK/WebApi/Classes/HostedPayments;Landroid/app/Activity;Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$HPCaller;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_HostedPayments_Landroid_app_Activity_Lit_icbpi_XPaySDK_Utils_HostedPayments_ParcelUtils_HPCaller_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_HostedPayments_Landroid_app_Activity_Lit_icbpi_XPaySDK_Utils_HostedPayments_ParcelUtils_HPCaller_, __args);
			} finally {
			}
		}

	}
}
