using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Models.WebApi.Errors {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Errors']/class[@name='ApiErrorResponse']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Models/WebApi/Errors/ApiErrorResponse", DoNotGenerateAcw=true)]
	public partial class ApiErrorResponse : global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ApiBaseResponse {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Models/WebApi/Errors/ApiErrorResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApiErrorResponse); }
		}

		protected ApiErrorResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lit_icbpi_XPaySDK_Models_Error_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Errors']/class[@name='ApiErrorResponse']/constructor[@name='ApiErrorResponse' and count(parameter)=1 and parameter[1][@type='it.icbpi.XPaySDK.Models.Error']]"
		[Register (".ctor", "(Lit/icbpi/XPaySDK/Models/Error;)V", "")]
		public unsafe ApiErrorResponse (global::IT.Icbpi.XPaySDK.Models.Error p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ApiErrorResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lit/icbpi/XPaySDK/Models/Error;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lit/icbpi/XPaySDK/Models/Error;)V", __args);
					return;
				}

				if (id_ctor_Lit_icbpi_XPaySDK_Models_Error_ == IntPtr.Zero)
					id_ctor_Lit_icbpi_XPaySDK_Models_Error_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lit/icbpi/XPaySDK/Models/Error;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lit_icbpi_XPaySDK_Models_Error_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lit_icbpi_XPaySDK_Models_Error_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_Error_Ljava_util_HashMap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Errors']/class[@name='ApiErrorResponse']/constructor[@name='ApiErrorResponse' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='it.icbpi.XPaySDK.Models.Error'] and parameter[6][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lit/icbpi/XPaySDK/Models/Error;Ljava/util/HashMap;)V", "")]
		public unsafe ApiErrorResponse (string p0, string p1, string p2, string p3, global::IT.Icbpi.XPaySDK.Models.Error p4, global::System.Collections.Generic.IDictionary<string, string> p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p5 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				if (((object) this).GetType () != typeof (ApiErrorResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lit/icbpi/XPaySDK/Models/Error;Ljava/util/HashMap;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lit/icbpi/XPaySDK/Models/Error;Ljava/util/HashMap;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_Error_Ljava_util_HashMap_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_Error_Ljava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lit/icbpi/XPaySDK/Models/Error;Ljava/util/HashMap;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_Error_Ljava_util_HashMap_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_Error_Ljava_util_HashMap_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_Error_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Errors']/class[@name='ApiErrorResponse']/constructor[@name='ApiErrorResponse' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='it.icbpi.XPaySDK.Models.Error']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lit/icbpi/XPaySDK/Models/Error;)V", "")]
		public unsafe ApiErrorResponse (string p0, string p1, string p2, string p3, global::IT.Icbpi.XPaySDK.Models.Error p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				if (((object) this).GetType () != typeof (ApiErrorResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lit/icbpi/XPaySDK/Models/Error;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lit/icbpi/XPaySDK/Models/Error;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_Error_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_Error_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lit/icbpi/XPaySDK/Models/Error;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_Error_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_Error_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_getExtraParameters;
#pragma warning disable 0169
		static Delegate GetGetExtraParametersHandler ()
		{
			if (cb_getExtraParameters == null)
				cb_getExtraParameters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtraParameters);
			return cb_getExtraParameters;
		}

		static IntPtr n_GetExtraParameters (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Errors.ApiErrorResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Errors.ApiErrorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.ExtraParameters);
		}
#pragma warning restore 0169

		static IntPtr id_getExtraParameters;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> ExtraParameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Errors']/class[@name='ApiErrorResponse']/method[@name='getExtraParameters' and count(parameter)=0]"
			[Register ("getExtraParameters", "()Ljava/util/Map;", "GetGetExtraParametersHandler")]
			get {
				if (id_getExtraParameters == IntPtr.Zero)
					id_getExtraParameters = JNIEnv.GetMethodID (class_ref, "getExtraParameters", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExtraParameters), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExtraParameters", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
