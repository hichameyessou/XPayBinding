using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.WebApi.Classes {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='PagamentiSincroni']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/WebApi/Classes/PagamentiSincroni", DoNotGenerateAcw=true)]
	public sealed partial class PagamentiSincroni : global::IT.Icbpi.XPaySDK.WebApi.Classes.BaseManagement {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/WebApi/Classes/PagamentiSincroni", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PagamentiSincroni); }
		}

		internal PagamentiSincroni (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='PagamentiSincroni']/constructor[@name='PagamentiSincroni' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe PagamentiSincroni (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (PagamentiSincroni)) {
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

		static IntPtr id_pagaMOTO_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PagamentiSincroni_ApiPagaMOTORequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='PagamentiSincroni']/method[@name='pagaMOTO' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.PagamentiSincroni.ApiPagaMOTORequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.PagamentiSincroni.ApiPagaMOTOResponse&gt;']]"
		[Register ("pagaMOTO", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/PagamentiSincroni/ApiPagaMOTORequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void PagaMOTO (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PagamentiSincroni.ApiPagaMOTORequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_pagaMOTO_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PagamentiSincroni_ApiPagaMOTORequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_pagaMOTO_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PagamentiSincroni_ApiPagaMOTORequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "pagaMOTO", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/PagamentiSincroni/ApiPagaMOTORequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pagaMOTO_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PagamentiSincroni_ApiPagaMOTORequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_pagaMPI_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PagamentiSincroni_ApiPagaMPIRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='PagamentiSincroni']/method[@name='pagaMPI' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.PagamentiSincroni.ApiPagaMPIRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.PagamentiSincroni.ApiPagaMPIResponse&gt;']]"
		[Register ("pagaMPI", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/PagamentiSincroni/ApiPagaMPIRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void PagaMPI (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PagamentiSincroni.ApiPagaMPIRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_pagaMPI_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PagamentiSincroni_ApiPagaMPIRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_pagaMPI_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PagamentiSincroni_ApiPagaMPIRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "pagaMPI", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/PagamentiSincroni/ApiPagaMPIRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pagaMPI_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PagamentiSincroni_ApiPagaMPIRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_pagaSSL_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PagamentiSincroni_ApiPagaSSLRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='PagamentiSincroni']/method[@name='pagaSSL' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.PagamentiSincroni.ApiPagaSSLRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.PagamentiSincroni.ApiPagaSSLResponse&gt;']]"
		[Register ("pagaSSL", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/PagamentiSincroni/ApiPagaSSLRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void PagaSSL (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PagamentiSincroni.ApiPagaSSLRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_pagaSSL_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PagamentiSincroni_ApiPagaSSLRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_pagaSSL_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PagamentiSincroni_ApiPagaSSLRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "pagaSSL", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/PagamentiSincroni/ApiPagaSSLRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pagaSSL_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PagamentiSincroni_ApiPagaSSLRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

	}
}
