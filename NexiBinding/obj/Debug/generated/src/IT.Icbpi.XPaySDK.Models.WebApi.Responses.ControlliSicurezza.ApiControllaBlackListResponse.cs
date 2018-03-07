using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza']/class[@name='ApiControllaBlackListResponse']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Models/WebApi/Responses/ControlliSicurezza/ApiControllaBlackListResponse", DoNotGenerateAcw=true)]
	public partial class ApiControllaBlackListResponse : global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ApiBaseResponse {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Models/WebApi/Responses/ControlliSicurezza/ApiControllaBlackListResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApiControllaBlackListResponse); }
		}

		protected ApiControllaBlackListResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza']/class[@name='ApiControllaBlackListResponse']/constructor[@name='ApiControllaBlackListResponse' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe ApiControllaBlackListResponse (string p0, string p1, string p2, string p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				if (((object) this).GetType () != typeof (ApiControllaBlackListResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_getBlackListElements;
#pragma warning disable 0169
		static Delegate GetGetBlackListElementsHandler ()
		{
			if (cb_getBlackListElements == null)
				cb_getBlackListElements = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBlackListElements);
			return cb_getBlackListElements;
		}

		static IntPtr n_GetBlackListElements (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza.ApiControllaBlackListResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza.ApiControllaBlackListResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBlackListElements ());
		}
#pragma warning restore 0169

		static IntPtr id_getBlackListElements;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza']/class[@name='ApiControllaBlackListResponse']/method[@name='getBlackListElements' and count(parameter)=0]"
		[Register ("getBlackListElements", "()[Lit/icbpi/XPaySDK/Models/WebApi/Responses/ControlliSicurezza/BlackListElement;", "GetGetBlackListElementsHandler")]
		public virtual unsafe global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza.BlackListElement[] GetBlackListElements ()
		{
			if (id_getBlackListElements == IntPtr.Zero)
				id_getBlackListElements = JNIEnv.GetMethodID (class_ref, "getBlackListElements", "()[Lit/icbpi/XPaySDK/Models/WebApi/Responses/ControlliSicurezza/BlackListElement;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza.BlackListElement[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBlackListElements), JniHandleOwnership.TransferLocalRef, typeof (global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza.BlackListElement));
				else
					return (global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza.BlackListElement[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBlackListElements", "()[Lit/icbpi/XPaySDK/Models/WebApi/Responses/ControlliSicurezza/BlackListElement;")), JniHandleOwnership.TransferLocalRef, typeof (global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza.BlackListElement));
			} finally {
			}
		}

	}
}
