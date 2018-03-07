using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.WebApi.Classes {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='ControlliSicurezza']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/WebApi/Classes/ControlliSicurezza", DoNotGenerateAcw=true)]
	public sealed partial class ControlliSicurezza : global::IT.Icbpi.XPaySDK.WebApi.Classes.BaseManagement {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/WebApi/Classes/ControlliSicurezza", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ControlliSicurezza); }
		}

		internal ControlliSicurezza (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='ControlliSicurezza']/constructor[@name='ControlliSicurezza' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ControlliSicurezza (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ControlliSicurezza)) {
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

		static IntPtr id_aggiungiBlackList_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ControlliSicurezza_ApiAggiungiBlackListRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='ControlliSicurezza']/method[@name='aggiungiBlackList' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.ControlliSicurezza.ApiAggiungiBlackListRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza.ApiAggiungiBlackListResponse&gt;']]"
		[Register ("aggiungiBlackList", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/ControlliSicurezza/ApiAggiungiBlackListRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void AggiungiBlackList (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.ControlliSicurezza.ApiAggiungiBlackListRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_aggiungiBlackList_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ControlliSicurezza_ApiAggiungiBlackListRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_aggiungiBlackList_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ControlliSicurezza_ApiAggiungiBlackListRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "aggiungiBlackList", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/ControlliSicurezza/ApiAggiungiBlackListRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_aggiungiBlackList_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ControlliSicurezza_ApiAggiungiBlackListRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_controllaBlackList_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ControlliSicurezza_ApiControllaBlackListRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='ControlliSicurezza']/method[@name='controllaBlackList' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.ControlliSicurezza.ApiControllaBlackListRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza.ApiControllaBlackListResponse&gt;']]"
		[Register ("controllaBlackList", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/ControlliSicurezza/ApiControllaBlackListRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void ControllaBlackList (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.ControlliSicurezza.ApiControllaBlackListRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_controllaBlackList_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ControlliSicurezza_ApiControllaBlackListRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_controllaBlackList_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ControlliSicurezza_ApiControllaBlackListRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "controllaBlackList", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/ControlliSicurezza/ApiControllaBlackListRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_controllaBlackList_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ControlliSicurezza_ApiControllaBlackListRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_controllaEsistenzaCFPan_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ControlliSicurezza_ApiControllaEsistenzaCFPanRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='ControlliSicurezza']/method[@name='controllaEsistenzaCFPan' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.ControlliSicurezza.ApiControllaEsistenzaCFPanRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza.ApiControllaEsistenzaCFPanResponse&gt;']]"
		[Register ("controllaEsistenzaCFPan", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/ControlliSicurezza/ApiControllaEsistenzaCFPanRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void ControllaEsistenzaCFPan (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.ControlliSicurezza.ApiControllaEsistenzaCFPanRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_controllaEsistenzaCFPan_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ControlliSicurezza_ApiControllaEsistenzaCFPanRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_controllaEsistenzaCFPan_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ControlliSicurezza_ApiControllaEsistenzaCFPanRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "controllaEsistenzaCFPan", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/ControlliSicurezza/ApiControllaEsistenzaCFPanRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_controllaEsistenzaCFPan_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ControlliSicurezza_ApiControllaEsistenzaCFPanRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_reportAssociazioniCFPan_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ControlliSicurezza_ApiReportAssociazioniCFPanRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='ControlliSicurezza']/method[@name='reportAssociazioniCFPan' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.ControlliSicurezza.ApiReportAssociazioniCFPanRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza.ApiReportAssociazioniCFPanResponse&gt;']]"
		[Register ("reportAssociazioniCFPan", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/ControlliSicurezza/ApiReportAssociazioniCFPanRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void ReportAssociazioniCFPan (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.ControlliSicurezza.ApiReportAssociazioniCFPanRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_reportAssociazioniCFPan_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ControlliSicurezza_ApiReportAssociazioniCFPanRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_reportAssociazioniCFPan_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ControlliSicurezza_ApiReportAssociazioniCFPanRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "reportAssociazioniCFPan", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/ControlliSicurezza/ApiReportAssociazioniCFPanRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reportAssociazioniCFPan_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ControlliSicurezza_ApiReportAssociazioniCFPanRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_reportBlackList_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ControlliSicurezza_ApiReportBlackListRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='ControlliSicurezza']/method[@name='reportBlackList' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.ControlliSicurezza.ApiReportBlackListRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza.ApiReportBlackListResponse&gt;']]"
		[Register ("reportBlackList", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/ControlliSicurezza/ApiReportBlackListRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void ReportBlackList (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.ControlliSicurezza.ApiReportBlackListRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_reportBlackList_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ControlliSicurezza_ApiReportBlackListRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_reportBlackList_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ControlliSicurezza_ApiReportBlackListRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "reportBlackList", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/ControlliSicurezza/ApiReportBlackListRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reportBlackList_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ControlliSicurezza_ApiReportBlackListRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_rimuoviBlackList_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ControlliSicurezza_ApiRimuoviBlackListRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='ControlliSicurezza']/method[@name='rimuoviBlackList' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.ControlliSicurezza.ApiRimuoviBlackListRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza.ApiRimuoviBlackListResponse&gt;']]"
		[Register ("rimuoviBlackList", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/ControlliSicurezza/ApiRimuoviBlackListRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void RimuoviBlackList (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.ControlliSicurezza.ApiRimuoviBlackListRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_rimuoviBlackList_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ControlliSicurezza_ApiRimuoviBlackListRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_rimuoviBlackList_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ControlliSicurezza_ApiRimuoviBlackListRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "rimuoviBlackList", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/ControlliSicurezza/ApiRimuoviBlackListRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_rimuoviBlackList_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ControlliSicurezza_ApiRimuoviBlackListRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_rimuoviCFPan_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ControlliSicurezza_ApiRimuoviCFPanRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='ControlliSicurezza']/method[@name='rimuoviCFPan' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.ControlliSicurezza.ApiRimuoviCFPanRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza.ApiRimuoviCFPanResponse&gt;']]"
		[Register ("rimuoviCFPan", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/ControlliSicurezza/ApiRimuoviCFPanRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void RimuoviCFPan (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.ControlliSicurezza.ApiRimuoviCFPanRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_rimuoviCFPan_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ControlliSicurezza_ApiRimuoviCFPanRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_rimuoviCFPan_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ControlliSicurezza_ApiRimuoviCFPanRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "rimuoviCFPan", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/ControlliSicurezza/ApiRimuoviCFPanRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_rimuoviCFPan_Lit_icbpi_XPaySDK_Models_WebApi_Requests_ControlliSicurezza_ApiRimuoviCFPanRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

	}
}
