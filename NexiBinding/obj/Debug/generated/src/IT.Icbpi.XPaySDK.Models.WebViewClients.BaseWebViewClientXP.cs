using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Models.WebViewClients {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients']/class[@name='BaseWebViewClientXP']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Models/WebViewClients/BaseWebViewClientXP", DoNotGenerateAcw=true)]
	public partial class BaseWebViewClientXP : global::IT.Icbpi.XPaySDK.Models.WebViewClients.BaseWebViewClientQP {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Models/WebViewClients/BaseWebViewClientXP", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseWebViewClientXP); }
		}

		protected BaseWebViewClientXP (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_FrontOffice_Landroid_app_Activity_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients']/class[@name='BaseWebViewClientXP']/constructor[@name='BaseWebViewClientXP' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.WebApi.Classes.FrontOffice'] and parameter[2][@type='android.app.Activity']]"
		[Register (".ctor", "(Lit/icbpi/XPaySDK/WebApi/Classes/FrontOffice;Landroid/app/Activity;)V", "")]
		public unsafe BaseWebViewClientXP (global::IT.Icbpi.XPaySDK.WebApi.Classes.FrontOffice p0, global::Android.App.Activity p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (BaseWebViewClientXP)) {
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

		static Delegate cb_castToError_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCastToError_Ljava_lang_String_Handler ()
		{
			if (cb_castToError_Ljava_lang_String_ == null)
				cb_castToError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CastToError_Ljava_lang_String_);
			return cb_castToError_Ljava_lang_String_;
		}

		static IntPtr n_CastToError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IT.Icbpi.XPaySDK.Models.WebViewClients.BaseWebViewClientXP __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebViewClients.BaseWebViewClientXP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CastToError (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_castToError_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients']/class[@name='BaseWebViewClientXP']/method[@name='castToError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("castToError", "(Ljava/lang/String;)Lit/icbpi/XPaySDK/Models/WebApi/Errors/ApiErrorResponse;", "GetCastToError_Ljava_lang_String_Handler")]
		protected virtual unsafe global::IT.Icbpi.XPaySDK.Models.WebApi.Errors.ApiErrorResponse CastToError (string p0)
		{
			if (id_castToError_Ljava_lang_String_ == IntPtr.Zero)
				id_castToError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "castToError", "(Ljava/lang/String;)Lit/icbpi/XPaySDK/Models/WebApi/Errors/ApiErrorResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::IT.Icbpi.XPaySDK.Models.WebApi.Errors.ApiErrorResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Errors.ApiErrorResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_castToError_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Errors.ApiErrorResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "castToError", "(Ljava/lang/String;)Lit/icbpi/XPaySDK/Models/WebApi/Errors/ApiErrorResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_castToResponseXP_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCastToResponseXP_Ljava_lang_String_Handler ()
		{
			if (cb_castToResponseXP_Ljava_lang_String_ == null)
				cb_castToResponseXP_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CastToResponseXP_Ljava_lang_String_);
			return cb_castToResponseXP_Ljava_lang_String_;
		}

		static IntPtr n_CastToResponseXP_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IT.Icbpi.XPaySDK.Models.WebViewClients.BaseWebViewClientXP __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebViewClients.BaseWebViewClientXP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CastToResponseXP (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_castToResponseXP_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients']/class[@name='BaseWebViewClientXP']/method[@name='castToResponseXP' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("castToResponseXP", "(Ljava/lang/String;)Lit/icbpi/XPaySDK/Models/WebApi/Responses/FrontOffice/ApiFrontOfficeXPResponse;", "GetCastToResponseXP_Ljava_lang_String_Handler")]
		protected virtual unsafe global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse CastToResponseXP (string p0)
		{
			if (id_castToResponseXP_Ljava_lang_String_ == IntPtr.Zero)
				id_castToResponseXP_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "castToResponseXP", "(Ljava/lang/String;)Lit/icbpi/XPaySDK/Models/WebApi/Responses/FrontOffice/ApiFrontOfficeXPResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_castToResponseXP_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "castToResponseXP", "(Ljava/lang/String;)Lit/icbpi/XPaySDK/Models/WebApi/Responses/FrontOffice/ApiFrontOfficeXPResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
