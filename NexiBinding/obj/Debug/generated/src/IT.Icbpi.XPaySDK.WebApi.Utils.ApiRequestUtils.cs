using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.WebApi.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Utils']/class[@name='ApiRequestUtils']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/WebApi/Utils/ApiRequestUtils", DoNotGenerateAcw=true)]
	public sealed partial class ApiRequestUtils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/WebApi/Utils/ApiRequestUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApiRequestUtils); }
		}

		internal ApiRequestUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Utils']/class[@name='ApiRequestUtils']/constructor[@name='ApiRequestUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ApiRequestUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ApiRequestUtils)) {
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

		static IntPtr id_doRequest_Landroid_content_Context_ILit_icbpi_XPaySDK_Utils_EnvironmentUtils_Environment_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ApiBaseRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Utils']/class[@name='ApiRequestUtils']/method[@name='doRequest' and count(parameter)=7 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='it.icbpi.XPaySDK.Utils.EnvironmentUtils.Environment'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='REQUEST'] and parameter[6][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;RESPONSE&gt;'] and parameter[7][@type='java.lang.Class&lt;RESPONSE&gt;']]"
		[Register ("doRequest", "(Landroid/content/Context;ILit/icbpi/XPaySDK/Utils/EnvironmentUtils$Environment;Ljava/lang/String;Lit/icbpi/XPaySDK/Models/WebApi/Requests/ApiBaseRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;Ljava/lang/Class;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"RESPONSE extends it.icbpi.XPaySDK.Models.WebApi.Responses.ApiBaseResponse", "REQUEST extends it.icbpi.XPaySDK.Models.WebApi.Requests.ApiBaseRequest"})]
		public static unsafe void DoRequest (global::Android.Content.Context p0, int p1, global::IT.Icbpi.XPaySDK.Utils.EnvironmentUtils.Environment p2, string p3, global::Java.Lang.Object p4, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p5, global::Java.Lang.Class p6)
		{
			if (id_doRequest_Landroid_content_Context_ILit_icbpi_XPaySDK_Utils_EnvironmentUtils_Environment_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ApiBaseRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_Ljava_lang_Class_ == IntPtr.Zero)
				id_doRequest_Landroid_content_Context_ILit_icbpi_XPaySDK_Utils_EnvironmentUtils_Environment_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ApiBaseRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "doRequest", "(Landroid/content/Context;ILit/icbpi/XPaySDK/Utils/EnvironmentUtils$Environment;Ljava/lang/String;Lit/icbpi/XPaySDK/Models/WebApi/Requests/ApiBaseRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;Ljava/lang/Class;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.ToLocalJniHandle (p4);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_doRequest_Landroid_content_Context_ILit_icbpi_XPaySDK_Utils_EnvironmentUtils_Environment_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ApiBaseRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_Ljava_lang_Class_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_getJsonRequest_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ApiBaseRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Utils']/class[@name='ApiRequestUtils']/method[@name='getJsonRequest' and count(parameter)=1 and parameter[1][@type='REQUEST']]"
		[Register ("getJsonRequest", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/ApiBaseRequest;)Ljava/lang/String;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"REQUEST extends it.icbpi.XPaySDK.Models.WebApi.Requests.ApiBaseRequest"})]
		public static unsafe string GetJsonRequest (global::Java.Lang.Object p0)
		{
			if (id_getJsonRequest_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ApiBaseRequest_ == IntPtr.Zero)
				id_getJsonRequest_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ApiBaseRequest_ = JNIEnv.GetStaticMethodID (class_ref, "getJsonRequest", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/ApiBaseRequest;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getJsonRequest_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ApiBaseRequest_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_isMacValid_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Utils']/class[@name='ApiRequestUtils']/method[@name='isMacValid' and count(parameter)=1 and parameter[1][@type='RESPONSE']]"
		[Register ("isMacValid", "(Lit/icbpi/XPaySDK/Models/WebApi/Responses/ApiBaseResponse;)Z", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"RESPONSE extends it.icbpi.XPaySDK.Models.WebApi.Responses.ApiBaseResponse"})]
		public static unsafe bool IsMacValid (global::Java.Lang.Object p0)
		{
			if (id_isMacValid_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_ == IntPtr.Zero)
				id_isMacValid_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_ = JNIEnv.GetStaticMethodID (class_ref, "isMacValid", "(Lit/icbpi/XPaySDK/Models/WebApi/Responses/ApiBaseResponse;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isMacValid_Lit_icbpi_XPaySDK_Models_WebApi_Responses_ApiBaseResponse_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_isMacValidFrontOffice_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeBaseResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Utils']/class[@name='ApiRequestUtils']/method[@name='isMacValidFrontOffice' and count(parameter)=1 and parameter[1][@type='RESPONSE']]"
		[Register ("isMacValidFrontOffice", "(Lit/icbpi/XPaySDK/Models/WebApi/Responses/FrontOffice/ApiFrontOfficeBaseResponse;)Z", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"RESPONSE extends it.icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeBaseResponse"})]
		public static unsafe bool IsMacValidFrontOffice (global::Java.Lang.Object p0)
		{
			if (id_isMacValidFrontOffice_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeBaseResponse_ == IntPtr.Zero)
				id_isMacValidFrontOffice_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeBaseResponse_ = JNIEnv.GetStaticMethodID (class_ref, "isMacValidFrontOffice", "(Lit/icbpi/XPaySDK/Models/WebApi/Responses/FrontOffice/ApiFrontOfficeBaseResponse;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isMacValidFrontOffice_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeBaseResponse_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
