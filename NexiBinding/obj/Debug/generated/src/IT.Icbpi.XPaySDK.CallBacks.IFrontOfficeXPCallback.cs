using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.CallBacks {

	// Metadata.xml XPath interface reference: path="/api/package[@name='it.icbpi.XPaySDK.CallBacks']/interface[@name='FrontOfficeXPCallback']"
	[Register ("it/icbpi/XPaySDK/CallBacks/FrontOfficeXPCallback", "", "IT.Icbpi.XPaySDK.CallBacks.IFrontOfficeXPCallbackInvoker")]
	public partial interface IFrontOfficeXPCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.CallBacks']/interface[@name='FrontOfficeXPCallback']/method[@name='onCancel' and count(parameter)=0]"
		[Register ("onCancel", "()V", "GetOnCancelHandler:IT.Icbpi.XPaySDK.CallBacks.IFrontOfficeXPCallbackInvoker, NexiBinding")]
		void OnCancel ();

		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.CallBacks']/interface[@name='FrontOfficeXPCallback']/method[@name='onConfirm' and count(parameter)=1 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse']]"
		[Register ("onConfirm", "(Lit/icbpi/XPaySDK/Models/WebApi/Responses/FrontOffice/ApiFrontOfficeXPResponse;)V", "GetOnConfirm_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeXPResponse_Handler:IT.Icbpi.XPaySDK.CallBacks.IFrontOfficeXPCallbackInvoker, NexiBinding")]
		void OnConfirm (global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.CallBacks']/interface[@name='FrontOfficeXPCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Errors.ApiErrorResponse']]"
		[Register ("onError", "(Lit/icbpi/XPaySDK/Models/WebApi/Errors/ApiErrorResponse;)V", "GetOnError_Lit_icbpi_XPaySDK_Models_WebApi_Errors_ApiErrorResponse_Handler:IT.Icbpi.XPaySDK.CallBacks.IFrontOfficeXPCallbackInvoker, NexiBinding")]
		void OnError (global::IT.Icbpi.XPaySDK.Models.WebApi.Errors.ApiErrorResponse p0);

	}

	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/CallBacks/FrontOfficeXPCallback", DoNotGenerateAcw=true)]
	internal class IFrontOfficeXPCallbackInvoker : global::Java.Lang.Object, IFrontOfficeXPCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("it/icbpi/XPaySDK/CallBacks/FrontOfficeXPCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFrontOfficeXPCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IFrontOfficeXPCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFrontOfficeXPCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "it.icbpi.XPaySDK.CallBacks.FrontOfficeXPCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFrontOfficeXPCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCancel;
#pragma warning disable 0169
		static Delegate GetOnCancelHandler ()
		{
			if (cb_onCancel == null)
				cb_onCancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCancel);
			return cb_onCancel;
		}

		static void n_OnCancel (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.CallBacks.IFrontOfficeXPCallback __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.CallBacks.IFrontOfficeXPCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCancel ();
		}
#pragma warning restore 0169

		IntPtr id_onCancel;
		public unsafe void OnCancel ()
		{
			if (id_onCancel == IntPtr.Zero)
				id_onCancel = JNIEnv.GetMethodID (class_ref, "onCancel", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCancel);
		}

		static Delegate cb_onConfirm_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeXPResponse_;
#pragma warning disable 0169
		static Delegate GetOnConfirm_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeXPResponse_Handler ()
		{
			if (cb_onConfirm_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeXPResponse_ == null)
				cb_onConfirm_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeXPResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConfirm_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeXPResponse_);
			return cb_onConfirm_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeXPResponse_;
		}

		static void n_OnConfirm_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeXPResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IT.Icbpi.XPaySDK.CallBacks.IFrontOfficeXPCallback __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.CallBacks.IFrontOfficeXPCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse p0 = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConfirm (p0);
		}
#pragma warning restore 0169

		IntPtr id_onConfirm_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeXPResponse_;
		public unsafe void OnConfirm (global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse p0)
		{
			if (id_onConfirm_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeXPResponse_ == IntPtr.Zero)
				id_onConfirm_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeXPResponse_ = JNIEnv.GetMethodID (class_ref, "onConfirm", "(Lit/icbpi/XPaySDK/Models/WebApi/Responses/FrontOffice/ApiFrontOfficeXPResponse;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConfirm_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeXPResponse_, __args);
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
			global::IT.Icbpi.XPaySDK.CallBacks.IFrontOfficeXPCallback __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.CallBacks.IFrontOfficeXPCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	}

}
