using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Models.WebViewClients._3DSecureClients {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients._3DSecureClients']/class[@name='Secure3DWebClient']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Models/WebViewClients/_3DSecureClients/Secure3DWebClient", DoNotGenerateAcw=true)]
	public partial class Secure3DWebClient : global::IT.Icbpi.XPaySDK.Models.WebViewClients.BaseWebViewClientQP {


		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients._3DSecureClients']/class[@name='Secure3DWebClient']/field[@name='CALLBACK_ERROR']"
		[Register ("CALLBACK_ERROR")]
		public const string CallbackError = (string) "Callback error!";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients._3DSecureClients']/class[@name='Secure3DWebClient']/field[@name='GENERIC_ERROR']"
		[Register ("GENERIC_ERROR")]
		public const string GenericError = (string) "Errore generico";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients._3DSecureClients']/class[@name='Secure3DWebClient']/field[@name='MAC_NOT_MATCH']"
		[Register ("MAC_NOT_MATCH")]
		public const string MacNotMatch = (string) "I codici MAC calcolati non corrispondono!";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Models/WebViewClients/_3DSecureClients/Secure3DWebClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Secure3DWebClient); }
		}

		protected Secure3DWebClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_Ricorrenze_Landroid_app_Activity_Lit_icbpi_XPaySDK_Utils_HostedPayments_ParcelUtils_RicorrenzeCaller_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients._3DSecureClients']/class[@name='Secure3DWebClient']/constructor[@name='Secure3DWebClient' and count(parameter)=3 and parameter[1][@type='it.icbpi.XPaySDK.WebApi.Classes.Ricorrenze'] and parameter[2][@type='android.app.Activity'] and parameter[3][@type='it.icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.RicorrenzeCaller']]"
		[Register (".ctor", "(Lit/icbpi/XPaySDK/WebApi/Classes/Ricorrenze;Landroid/app/Activity;Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$RicorrenzeCaller;)V", "")]
		public unsafe Secure3DWebClient (global::IT.Icbpi.XPaySDK.WebApi.Classes.Ricorrenze p0, global::Android.App.Activity p1, global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.RicorrenzeCaller p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (Secure3DWebClient)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients._3DSecureClients']/class[@name='Secure3DWebClient']/constructor[@name='Secure3DWebClient' and count(parameter)=3 and parameter[1][@type='it.icbpi.XPaySDK.WebApi.Classes.PrimiPagamentiRecurring'] and parameter[2][@type='android.app.Activity'] and parameter[3][@type='it.icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.PrimiPagamentiCaller']]"
		[Register (".ctor", "(Lit/icbpi/XPaySDK/WebApi/Classes/PrimiPagamentiRecurring;Landroid/app/Activity;Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$PrimiPagamentiCaller;)V", "")]
		public unsafe Secure3DWebClient (global::IT.Icbpi.XPaySDK.WebApi.Classes.PrimiPagamentiRecurring p0, global::Android.App.Activity p1, global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.PrimiPagamentiCaller p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (Secure3DWebClient)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients._3DSecureClients']/class[@name='Secure3DWebClient']/constructor[@name='Secure3DWebClient' and count(parameter)=3 and parameter[1][@type='it.icbpi.XPaySDK.WebApi.Classes.HostedPayments'] and parameter[2][@type='android.app.Activity'] and parameter[3][@type='it.icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.HPCaller']]"
		[Register (".ctor", "(Lit/icbpi/XPaySDK/WebApi/Classes/HostedPayments;Landroid/app/Activity;Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$HPCaller;)V", "")]
		public unsafe Secure3DWebClient (global::IT.Icbpi.XPaySDK.WebApi.Classes.PaymentHost p0, global::Android.App.Activity p1, global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.HPCaller p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (Secure3DWebClient)) {
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

		static Delegate cb_castToBaseResponse_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCastToBaseResponse_Ljava_lang_String_Handler ()
		{
			if (cb_castToBaseResponse_Ljava_lang_String_ == null)
				cb_castToBaseResponse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CastToBaseResponse_Ljava_lang_String_);
			return cb_castToBaseResponse_Ljava_lang_String_;
		}

		static IntPtr n_CastToBaseResponse_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IT.Icbpi.XPaySDK.Models.WebViewClients._3DSecureClients.Secure3DWebClient __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebViewClients._3DSecureClients.Secure3DWebClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CastToBaseResponse (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_castToBaseResponse_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients._3DSecureClients']/class[@name='Secure3DWebClient']/method[@name='castToBaseResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("castToBaseResponse", "(Ljava/lang/String;)Lit/icbpi/XPaySDK/Models/WebApi/Responses/ApiBaseResponse;", "GetCastToBaseResponse_Ljava_lang_String_Handler")]
		protected virtual unsafe global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ApiBaseResponse CastToBaseResponse (string p0)
		{
			if (id_castToBaseResponse_Ljava_lang_String_ == IntPtr.Zero)
				id_castToBaseResponse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "castToBaseResponse", "(Ljava/lang/String;)Lit/icbpi/XPaySDK/Models/WebApi/Responses/ApiBaseResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ApiBaseResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ApiBaseResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_castToBaseResponse_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ApiBaseResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "castToBaseResponse", "(Ljava/lang/String;)Lit/icbpi/XPaySDK/Models/WebApi/Responses/ApiBaseResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_castToResponseError_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_;
#pragma warning disable 0169
		static Delegate GetCastToResponseError_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_Handler ()
		{
			if (cb_castToResponseError_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_ == null)
				cb_castToResponseError_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CastToResponseError_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_);
			return cb_castToResponseError_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_;
		}

		static IntPtr n_CastToResponseError_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::IT.Icbpi.XPaySDK.Models.WebViewClients._3DSecureClients.Secure3DWebClient __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebViewClients._3DSecureClients.Secure3DWebClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ApiBaseResponse p1 = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ApiBaseResponse> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CastToResponseError (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_castToResponseError_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients._3DSecureClients']/class[@name='Secure3DWebClient']/method[@name='castToResponseError' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='it.icbpi.XPaySDK.Models.WebApi.Responses.ApiBaseResponse']]"
		[Register ("castToResponseError", "(Ljava/lang/String;Lit/icbpi/XPaySDK/Models/WebApi/Responses/ApiBaseResponse;)Lit/icbpi/XPaySDK/Models/WebApi/Errors/ApiErrorResponse;", "GetCastToResponseError_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_Handler")]
		protected virtual unsafe global::IT.Icbpi.XPaySDK.Models.WebApi.Errors.ApiErrorResponse CastToResponseError (string p0, global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ApiBaseResponse p1)
		{
			if (id_castToResponseError_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_ == IntPtr.Zero)
				id_castToResponseError_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_ = JNIEnv.GetMethodID (class_ref, "castToResponseError", "(Ljava/lang/String;Lit/icbpi/XPaySDK/Models/WebApi/Responses/ApiBaseResponse;)Lit/icbpi/XPaySDK/Models/WebApi/Errors/ApiErrorResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::IT.Icbpi.XPaySDK.Models.WebApi.Errors.ApiErrorResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Errors.ApiErrorResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_castToResponseError_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Errors.ApiErrorResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "castToResponseError", "(Ljava/lang/String;Lit/icbpi/XPaySDK/Models/WebApi/Responses/ApiBaseResponse;)Lit/icbpi/XPaySDK/Models/WebApi/Errors/ApiErrorResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_castToResponseNonce_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_;
#pragma warning disable 0169
		static Delegate GetCastToResponseNonce_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_Handler ()
		{
			if (cb_castToResponseNonce_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_ == null)
				cb_castToResponseNonce_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CastToResponseNonce_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_);
			return cb_castToResponseNonce_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_;
		}

		static IntPtr n_CastToResponseNonce_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::IT.Icbpi.XPaySDK.Models.WebViewClients._3DSecureClients.Secure3DWebClient __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebViewClients._3DSecureClients.Secure3DWebClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ApiBaseResponse p1 = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ApiBaseResponse> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CastToResponseNonce (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_castToResponseNonce_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients._3DSecureClients']/class[@name='Secure3DWebClient']/method[@name='castToResponseNonce' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='it.icbpi.XPaySDK.Models.WebApi.Responses.ApiBaseResponse']]"
		[Register ("castToResponseNonce", "(Ljava/lang/String;Lit/icbpi/XPaySDK/Models/WebApi/Responses/ApiBaseResponse;)Lit/icbpi/XPaySDK/Models/WebApi/Responses/HostedPayments/ApiCreaNonceResponse;", "GetCastToResponseNonce_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_Handler")]
		protected virtual unsafe global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.HostedPayments.ApiCreaNonceResponse CastToResponseNonce (string p0, global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ApiBaseResponse p1)
		{
			if (id_castToResponseNonce_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_ == IntPtr.Zero)
				id_castToResponseNonce_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_ = JNIEnv.GetMethodID (class_ref, "castToResponseNonce", "(Ljava/lang/String;Lit/icbpi/XPaySDK/Models/WebApi/Responses/ApiBaseResponse;)Lit/icbpi/XPaySDK/Models/WebApi/Responses/HostedPayments/ApiCreaNonceResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.HostedPayments.ApiCreaNonceResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.HostedPayments.ApiCreaNonceResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_castToResponseNonce_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.HostedPayments.ApiCreaNonceResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "castToResponseNonce", "(Ljava/lang/String;Lit/icbpi/XPaySDK/Models/WebApi/Responses/ApiBaseResponse;)Lit/icbpi/XPaySDK/Models/WebApi/Responses/HostedPayments/ApiCreaNonceResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_castToResponseNonceCarta_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_;
#pragma warning disable 0169
		static Delegate GetCastToResponseNonceCarta_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_Handler ()
		{
			if (cb_castToResponseNonceCarta_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_ == null)
				cb_castToResponseNonceCarta_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CastToResponseNonceCarta_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_);
			return cb_castToResponseNonceCarta_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_;
		}

		static IntPtr n_CastToResponseNonceCarta_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::IT.Icbpi.XPaySDK.Models.WebViewClients._3DSecureClients.Secure3DWebClient __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebViewClients._3DSecureClients.Secure3DWebClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ApiBaseResponse p1 = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ApiBaseResponse> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CastToResponseNonceCarta (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_castToResponseNonceCarta_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients._3DSecureClients']/class[@name='Secure3DWebClient']/method[@name='castToResponseNonceCarta' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='it.icbpi.XPaySDK.Models.WebApi.Responses.ApiBaseResponse']]"
		[Register ("castToResponseNonceCarta", "(Ljava/lang/String;Lit/icbpi/XPaySDK/Models/WebApi/Responses/ApiBaseResponse;)Lit/icbpi/XPaySDK/Models/WebApi/Responses/PrimiPagamentiRecurring/ApiCreaNonceVerificaCartaResponse;", "GetCastToResponseNonceCarta_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_Handler")]
		protected virtual unsafe global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiCreaNonceVerificaCartaResponse CastToResponseNonceCarta (string p0, global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ApiBaseResponse p1)
		{
			if (id_castToResponseNonceCarta_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_ == IntPtr.Zero)
				id_castToResponseNonceCarta_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_ = JNIEnv.GetMethodID (class_ref, "castToResponseNonceCarta", "(Ljava/lang/String;Lit/icbpi/XPaySDK/Models/WebApi/Responses/ApiBaseResponse;)Lit/icbpi/XPaySDK/Models/WebApi/Responses/PrimiPagamentiRecurring/ApiCreaNonceVerificaCartaResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiCreaNonceVerificaCartaResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiCreaNonceVerificaCartaResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_castToResponseNonceCarta_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiCreaNonceVerificaCartaResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "castToResponseNonceCarta", "(Ljava/lang/String;Lit/icbpi/XPaySDK/Models/WebApi/Responses/ApiBaseResponse;)Lit/icbpi/XPaySDK/Models/WebApi/Responses/PrimiPagamentiRecurring/ApiCreaNonceVerificaCartaResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_castToResponseNoncePagaRico3DS_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_;
#pragma warning disable 0169
		static Delegate GetCastToResponseNoncePagaRico3DS_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_Handler ()
		{
			if (cb_castToResponseNoncePagaRico3DS_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_ == null)
				cb_castToResponseNoncePagaRico3DS_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CastToResponseNoncePagaRico3DS_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_);
			return cb_castToResponseNoncePagaRico3DS_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_;
		}

		static IntPtr n_CastToResponseNoncePagaRico3DS_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::IT.Icbpi.XPaySDK.Models.WebViewClients._3DSecureClients.Secure3DWebClient __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebViewClients._3DSecureClients.Secure3DWebClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ApiBaseResponse p1 = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ApiBaseResponse> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CastToResponseNoncePagaRico3DS (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_castToResponseNoncePagaRico3DS_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients._3DSecureClients']/class[@name='Secure3DWebClient']/method[@name='castToResponseNoncePagaRico3DS' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='it.icbpi.XPaySDK.Models.WebApi.Responses.ApiBaseResponse']]"
		[Register ("castToResponseNoncePagaRico3DS", "(Ljava/lang/String;Lit/icbpi/XPaySDK/Models/WebApi/Responses/ApiBaseResponse;)Lit/icbpi/XPaySDK/Models/WebApi/Responses/Ricorrenze/ApiCreaNoncePagamentoRicorrente3DSResponse;", "GetCastToResponseNoncePagaRico3DS_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_Handler")]
		protected virtual unsafe global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.Ricorrenze.ApiCreaNoncePagamentoRicorrente3DSResponse CastToResponseNoncePagaRico3DS (string p0, global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ApiBaseResponse p1)
		{
			if (id_castToResponseNoncePagaRico3DS_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_ == IntPtr.Zero)
				id_castToResponseNoncePagaRico3DS_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_ = JNIEnv.GetMethodID (class_ref, "castToResponseNoncePagaRico3DS", "(Ljava/lang/String;Lit/icbpi/XPaySDK/Models/WebApi/Responses/ApiBaseResponse;)Lit/icbpi/XPaySDK/Models/WebApi/Responses/Ricorrenze/ApiCreaNoncePagamentoRicorrente3DSResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.Ricorrenze.ApiCreaNoncePagamentoRicorrente3DSResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.Ricorrenze.ApiCreaNoncePagamentoRicorrente3DSResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_castToResponseNoncePagaRico3DS_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.Ricorrenze.ApiCreaNoncePagamentoRicorrente3DSResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "castToResponseNoncePagaRico3DS", "(Ljava/lang/String;Lit/icbpi/XPaySDK/Models/WebApi/Responses/ApiBaseResponse;)Lit/icbpi/XPaySDK/Models/WebApi/Responses/Ricorrenze/ApiCreaNoncePagamentoRicorrente3DSResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_castToResponseNoncePrimoPagamento3DS_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_;
#pragma warning disable 0169
		static Delegate GetCastToResponseNoncePrimoPagamento3DS_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_Handler ()
		{
			if (cb_castToResponseNoncePrimoPagamento3DS_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_ == null)
				cb_castToResponseNoncePrimoPagamento3DS_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CastToResponseNoncePrimoPagamento3DS_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_);
			return cb_castToResponseNoncePrimoPagamento3DS_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_;
		}

		static IntPtr n_CastToResponseNoncePrimoPagamento3DS_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::IT.Icbpi.XPaySDK.Models.WebViewClients._3DSecureClients.Secure3DWebClient __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebViewClients._3DSecureClients.Secure3DWebClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ApiBaseResponse p1 = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ApiBaseResponse> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CastToResponseNoncePrimoPagamento3DS (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_castToResponseNoncePrimoPagamento3DS_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients._3DSecureClients']/class[@name='Secure3DWebClient']/method[@name='castToResponseNoncePrimoPagamento3DS' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='it.icbpi.XPaySDK.Models.WebApi.Responses.ApiBaseResponse']]"
		[Register ("castToResponseNoncePrimoPagamento3DS", "(Ljava/lang/String;Lit/icbpi/XPaySDK/Models/WebApi/Responses/ApiBaseResponse;)Lit/icbpi/XPaySDK/Models/WebApi/Responses/PrimiPagamentiRecurring/ApiCreaNoncePrimoPagamento3DSResponse;", "GetCastToResponseNoncePrimoPagamento3DS_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_Handler")]
		protected virtual unsafe global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiCreaNoncePrimoPagamento3DSResponse CastToResponseNoncePrimoPagamento3DS (string p0, global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ApiBaseResponse p1)
		{
			if (id_castToResponseNoncePrimoPagamento3DS_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_ == IntPtr.Zero)
				id_castToResponseNoncePrimoPagamento3DS_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_ = JNIEnv.GetMethodID (class_ref, "castToResponseNoncePrimoPagamento3DS", "(Ljava/lang/String;Lit/icbpi/XPaySDK/Models/WebApi/Responses/ApiBaseResponse;)Lit/icbpi/XPaySDK/Models/WebApi/Responses/PrimiPagamentiRecurring/ApiCreaNoncePrimoPagamento3DSResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiCreaNoncePrimoPagamento3DSResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiCreaNoncePrimoPagamento3DSResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_castToResponseNoncePrimoPagamento3DS_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiCreaNoncePrimoPagamento3DSResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "castToResponseNoncePrimoPagamento3DS", "(Ljava/lang/String;Lit/icbpi/XPaySDK/Models/WebApi/Responses/ApiBaseResponse;)Lit/icbpi/XPaySDK/Models/WebApi/Responses/PrimiPagamentiRecurring/ApiCreaNoncePrimoPagamento3DSResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
