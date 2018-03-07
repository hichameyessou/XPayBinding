using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.WebApi.Classes {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='Varie']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/WebApi/Classes/Varie", DoNotGenerateAcw=true)]
	public sealed partial class Varie : global::IT.Icbpi.XPaySDK.WebApi.Classes.BaseManagement {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/WebApi/Classes/Varie", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Varie); }
		}

		internal Varie (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='Varie']/constructor[@name='Varie' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe Varie (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (Varie)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_pagaDCC_Lit_icbpi_XPaySDK_Models_WebApi_Requests_Varie_ApiPagaDCCRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='Varie']/method[@name='pagaDCC' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.Varie.ApiPagaDCCRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.Varie.ApiPagaDCCResponse&gt;']]"
		[Register ("pagaDCC", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/Varie/ApiPagaDCCRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void PagaDCC (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.Varie.ApiPagaDCCRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_pagaDCC_Lit_icbpi_XPaySDK_Models_WebApi_Requests_Varie_ApiPagaDCCRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_pagaDCC_Lit_icbpi_XPaySDK_Models_WebApi_Requests_Varie_ApiPagaDCCRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "pagaDCC", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/Varie/ApiPagaDCCRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pagaDCC_Lit_icbpi_XPaySDK_Models_WebApi_Requests_Varie_ApiPagaDCCRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_verificaDCC_Lit_icbpi_XPaySDK_Models_WebApi_Requests_Varie_ApiVerificaDCCRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='Varie']/method[@name='verificaDCC' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.Varie.ApiVerificaDCCRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.Varie.ApiVerificaDCCResponse&gt;']]"
		[Register ("verificaDCC", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/Varie/ApiVerificaDCCRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void VerificaDCC (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.Varie.ApiVerificaDCCRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_verificaDCC_Lit_icbpi_XPaySDK_Models_WebApi_Requests_Varie_ApiVerificaDCCRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_verificaDCC_Lit_icbpi_XPaySDK_Models_WebApi_Requests_Varie_ApiVerificaDCCRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "verificaDCC", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/Varie/ApiVerificaDCCRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_verificaDCC_Lit_icbpi_XPaySDK_Models_WebApi_Requests_Varie_ApiVerificaDCCRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

	}
}
