using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.WebApi.Classes {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='BackOffice']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/WebApi/Classes/BackOffice", DoNotGenerateAcw=true)]
	public sealed partial class BackOffice : global::IT.Icbpi.XPaySDK.WebApi.Classes.BaseManagement {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/WebApi/Classes/BackOffice", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BackOffice); }
		}

		internal BackOffice (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='BackOffice']/constructor[@name='BackOffice' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BackOffice (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (BackOffice)) {
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

		static IntPtr id_contabilizza_Lit_icbpi_XPaySDK_Models_WebApi_Requests_BackOffice_ApiContabilizzaRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='BackOffice']/method[@name='contabilizza' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.BackOffice.ApiContabilizzaRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.ApiContabilizzaResponse&gt;']]"
		[Register ("contabilizza", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/BackOffice/ApiContabilizzaRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void Contabilizza (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.BackOffice.ApiContabilizzaRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_contabilizza_Lit_icbpi_XPaySDK_Models_WebApi_Requests_BackOffice_ApiContabilizzaRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_contabilizza_Lit_icbpi_XPaySDK_Models_WebApi_Requests_BackOffice_ApiContabilizzaRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "contabilizza", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/BackOffice/ApiContabilizzaRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_contabilizza_Lit_icbpi_XPaySDK_Models_WebApi_Requests_BackOffice_ApiContabilizzaRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_reportOrdini_Lit_icbpi_XPaySDK_Models_WebApi_Requests_BackOffice_ApiReportOrdiniRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='BackOffice']/method[@name='reportOrdini' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.BackOffice.ApiReportOrdiniRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.ApiReportOrdiniResponse&gt;']]"
		[Register ("reportOrdini", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/BackOffice/ApiReportOrdiniRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void ReportOrdini (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.BackOffice.ApiReportOrdiniRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_reportOrdini_Lit_icbpi_XPaySDK_Models_WebApi_Requests_BackOffice_ApiReportOrdiniRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_reportOrdini_Lit_icbpi_XPaySDK_Models_WebApi_Requests_BackOffice_ApiReportOrdiniRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "reportOrdini", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/BackOffice/ApiReportOrdiniRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reportOrdini_Lit_icbpi_XPaySDK_Models_WebApi_Requests_BackOffice_ApiReportOrdiniRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_richiestaPayMail_Lit_icbpi_XPaySDK_Models_WebApi_Requests_BackOffice_ApiPayMailRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='BackOffice']/method[@name='richiestaPayMail' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.BackOffice.ApiPayMailRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.ApiPayMailResponse&gt;']]"
		[Register ("richiestaPayMail", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/BackOffice/ApiPayMailRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void RichiestaPayMail (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.BackOffice.ApiPayMailRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_richiestaPayMail_Lit_icbpi_XPaySDK_Models_WebApi_Requests_BackOffice_ApiPayMailRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_richiestaPayMail_Lit_icbpi_XPaySDK_Models_WebApi_Requests_BackOffice_ApiPayMailRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "richiestaPayMail", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/BackOffice/ApiPayMailRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_richiestaPayMail_Lit_icbpi_XPaySDK_Models_WebApi_Requests_BackOffice_ApiPayMailRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_situazioneOrdine_Lit_icbpi_XPaySDK_Models_WebApi_Requests_BackOffice_ApiSituazioneOrdineRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='BackOffice']/method[@name='situazioneOrdine' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.BackOffice.ApiSituazioneOrdineRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.ApiSituazioneOrdineResponse&gt;']]"
		[Register ("situazioneOrdine", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/BackOffice/ApiSituazioneOrdineRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void SituazioneOrdine (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.BackOffice.ApiSituazioneOrdineRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_situazioneOrdine_Lit_icbpi_XPaySDK_Models_WebApi_Requests_BackOffice_ApiSituazioneOrdineRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_situazioneOrdine_Lit_icbpi_XPaySDK_Models_WebApi_Requests_BackOffice_ApiSituazioneOrdineRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "situazioneOrdine", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/BackOffice/ApiSituazioneOrdineRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_situazioneOrdine_Lit_icbpi_XPaySDK_Models_WebApi_Requests_BackOffice_ApiSituazioneOrdineRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_storna_Lit_icbpi_XPaySDK_Models_WebApi_Requests_BackOffice_ApiStornaRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='BackOffice']/method[@name='storna' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.BackOffice.ApiStornaRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.ApiStornaResponse&gt;']]"
		[Register ("storna", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/BackOffice/ApiStornaRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void Storna (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.BackOffice.ApiStornaRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_storna_Lit_icbpi_XPaySDK_Models_WebApi_Requests_BackOffice_ApiStornaRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_storna_Lit_icbpi_XPaySDK_Models_WebApi_Requests_BackOffice_ApiStornaRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "storna", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/BackOffice/ApiStornaRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_storna_Lit_icbpi_XPaySDK_Models_WebApi_Requests_BackOffice_ApiStornaRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

	}
}
