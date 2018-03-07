using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.CallBacks {

	// Metadata.xml XPath interface reference: path="/api/package[@name='it.icbpi.XPaySDK.CallBacks']/interface[@name='ApiResponseCallback']"
	[Register ("it/icbpi/XPaySDK/CallBacks/ApiResponseCallback", "", "IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallbackInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IApiResponseCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.CallBacks']/interface[@name='ApiResponseCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Errors.ApiErrorResponse']]"
		[Register ("onError", "(Lit/icbpi/XPaySDK/Models/WebApi/Errors/ApiErrorResponse;)V", "GetOnError_Lit_icbpi_XPaySDK_Models_WebApi_Errors_ApiErrorResponse_Handler:IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallbackInvoker, NexiBinding")]
		void OnError (global::IT.Icbpi.XPaySDK.Models.WebApi.Errors.ApiErrorResponse p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.CallBacks']/interface[@name='ApiResponseCallback']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("onSuccess", "(Ljava/lang/Object;)V", "GetOnSuccess_Ljava_lang_Object_Handler:IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallbackInvoker, NexiBinding")]
		void OnSuccess (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/CallBacks/ApiResponseCallback", DoNotGenerateAcw=true)]
	internal class IApiResponseCallbackInvoker : global::Java.Lang.Object, IApiResponseCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("it/icbpi/XPaySDK/CallBacks/ApiResponseCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IApiResponseCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IApiResponseCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApiResponseCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "it.icbpi.XPaySDK.CallBacks.ApiResponseCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApiResponseCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onError_Lit_icbpi_XPaySDK_Models_WebApi_Errors_ApiErrorResponse_;
#pragma warning disable 0169
		static Delegate GetOnError_Lit_icbpi_XPaySDK_Models_WebApi_Errors_ApiErrorResponse_Handler ()
		{
			if (cb_onError_Lit_icbpi_XPaySDK_Models_WebApi_Errors_ApiErrorResponse_ == null)
				cb_onError_Lit_icbpi_XPaySDK_Models_WebApi_Errors_ApiErrorResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Lit_icbpi_XPaySDK_Models_WebApi_Errors_ApiErrorResponse_);
			return cb_onError_Lit_icbpi_XPaySDK_Models_WebApi_Errors_ApiErrorResponse_;
		}

		static void n_OnError_Lit_icbpi_XPaySDK_Models_WebApi_Errors_ApiErrorResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IT.Icbpi.XPaySDK.Models.WebApi.Errors.ApiErrorResponse p0 = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Errors.ApiErrorResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lit_icbpi_XPaySDK_Models_WebApi_Errors_ApiErrorResponse_;
		public unsafe void OnError (global::IT.Icbpi.XPaySDK.Models.WebApi.Errors.ApiErrorResponse p0)
		{
			if (id_onError_Lit_icbpi_XPaySDK_Models_WebApi_Errors_ApiErrorResponse_ == IntPtr.Zero)
				id_onError_Lit_icbpi_XPaySDK_Models_WebApi_Errors_ApiErrorResponse_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lit/icbpi/XPaySDK/Models/WebApi/Errors/ApiErrorResponse;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lit_icbpi_XPaySDK_Models_WebApi_Errors_ApiErrorResponse_, __args);
		}

		static Delegate cb_onSuccess_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_lang_Object_Handler ()
		{
			if (cb_onSuccess_Ljava_lang_Object_ == null)
				cb_onSuccess_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Ljava_lang_Object_);
			return cb_onSuccess_Ljava_lang_Object_;
		}

		static void n_OnSuccess_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Ljava_lang_Object_;
		public unsafe void OnSuccess (global::Java.Lang.Object p0)
		{
			if (id_onSuccess_Ljava_lang_Object_ == IntPtr.Zero)
				id_onSuccess_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
