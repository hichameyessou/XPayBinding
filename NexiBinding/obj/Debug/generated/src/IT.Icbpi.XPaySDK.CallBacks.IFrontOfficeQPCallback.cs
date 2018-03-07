using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.CallBacks {

	// Metadata.xml XPath interface reference: path="/api/package[@name='it.icbpi.XPaySDK.CallBacks']/interface[@name='FrontOfficeQPCallback']"
	[Register ("it/icbpi/XPaySDK/CallBacks/FrontOfficeQPCallback", "", "IT.Icbpi.XPaySDK.CallBacks.IFrontOfficeQPCallbackInvoker")]
	public partial interface IFrontOfficeQPCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.CallBacks']/interface[@name='FrontOfficeQPCallback']/method[@name='onCancel' and count(parameter)=1 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeQPResponse']]"
		[Register ("onCancel", "(Lit/icbpi/XPaySDK/Models/WebApi/Responses/FrontOffice/ApiFrontOfficeQPResponse;)V", "GetOnCancel_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeQPResponse_Handler:IT.Icbpi.XPaySDK.CallBacks.IFrontOfficeQPCallbackInvoker, NexiBinding")]
		void OnCancel (global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeQPResponse p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.CallBacks']/interface[@name='FrontOfficeQPCallback']/method[@name='onConfirm' and count(parameter)=1 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeQPResponse']]"
		[Register ("onConfirm", "(Lit/icbpi/XPaySDK/Models/WebApi/Responses/FrontOffice/ApiFrontOfficeQPResponse;)V", "GetOnConfirm_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeQPResponse_Handler:IT.Icbpi.XPaySDK.CallBacks.IFrontOfficeQPCallbackInvoker, NexiBinding")]
		void OnConfirm (global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeQPResponse p0);

	}

	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/CallBacks/FrontOfficeQPCallback", DoNotGenerateAcw=true)]
	internal class IFrontOfficeQPCallbackInvoker : global::Java.Lang.Object, IFrontOfficeQPCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("it/icbpi/XPaySDK/CallBacks/FrontOfficeQPCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFrontOfficeQPCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IFrontOfficeQPCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFrontOfficeQPCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "it.icbpi.XPaySDK.CallBacks.FrontOfficeQPCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFrontOfficeQPCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCancel_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeQPResponse_;
#pragma warning disable 0169
		static Delegate GetOnCancel_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeQPResponse_Handler ()
		{
			if (cb_onCancel_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeQPResponse_ == null)
				cb_onCancel_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeQPResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCancel_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeQPResponse_);
			return cb_onCancel_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeQPResponse_;
		}

		static void n_OnCancel_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeQPResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IT.Icbpi.XPaySDK.CallBacks.IFrontOfficeQPCallback __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.CallBacks.IFrontOfficeQPCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeQPResponse p0 = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeQPResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCancel (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCancel_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeQPResponse_;
		public unsafe void OnCancel (global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeQPResponse p0)
		{
			if (id_onCancel_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeQPResponse_ == IntPtr.Zero)
				id_onCancel_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeQPResponse_ = JNIEnv.GetMethodID (class_ref, "onCancel", "(Lit/icbpi/XPaySDK/Models/WebApi/Responses/FrontOffice/ApiFrontOfficeQPResponse;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCancel_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeQPResponse_, __args);
		}

		static Delegate cb_onConfirm_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeQPResponse_;
#pragma warning disable 0169
		static Delegate GetOnConfirm_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeQPResponse_Handler ()
		{
			if (cb_onConfirm_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeQPResponse_ == null)
				cb_onConfirm_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeQPResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConfirm_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeQPResponse_);
			return cb_onConfirm_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeQPResponse_;
		}

		static void n_OnConfirm_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeQPResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IT.Icbpi.XPaySDK.CallBacks.IFrontOfficeQPCallback __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.CallBacks.IFrontOfficeQPCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeQPResponse p0 = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeQPResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConfirm (p0);
		}
#pragma warning restore 0169

		IntPtr id_onConfirm_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeQPResponse_;
		public unsafe void OnConfirm (global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeQPResponse p0)
		{
			if (id_onConfirm_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeQPResponse_ == IntPtr.Zero)
				id_onConfirm_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeQPResponse_ = JNIEnv.GetMethodID (class_ref, "onConfirm", "(Lit/icbpi/XPaySDK/Models/WebApi/Responses/FrontOffice/ApiFrontOfficeQPResponse;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConfirm_Lit_icbpi_XPaySDK_Models_WebApi_Responses_FrontOffice_ApiFrontOfficeQPResponse_, __args);
		}

	}

}
