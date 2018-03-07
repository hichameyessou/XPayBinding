using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.WebApi.Classes {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='GestioneContratti']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/WebApi/Classes/GestioneContratti", DoNotGenerateAcw=true)]
	public sealed partial class GestioneContratti : global::IT.Icbpi.XPaySDK.WebApi.Classes.BaseManagement {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/WebApi/Classes/GestioneContratti", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GestioneContratti); }
		}

		internal GestioneContratti (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='GestioneContratti']/constructor[@name='GestioneContratti' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe GestioneContratti (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (GestioneContratti)) {
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

		static IntPtr id_abilitaContratto_Lit_icbpi_XPaySDK_Models_WebApi_Requests_GestioneContratti_ApiAbilitaContrattoRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='GestioneContratti']/method[@name='abilitaContratto' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ApiAbilitaContrattoRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.GestioneContratti.ApiAbilitaContrattoResponse&gt;']]"
		[Register ("abilitaContratto", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/GestioneContratti/ApiAbilitaContrattoRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void AbilitaContratto (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ApiAbilitaContrattoRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_abilitaContratto_Lit_icbpi_XPaySDK_Models_WebApi_Requests_GestioneContratti_ApiAbilitaContrattoRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_abilitaContratto_Lit_icbpi_XPaySDK_Models_WebApi_Requests_GestioneContratti_ApiAbilitaContrattoRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "abilitaContratto", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/GestioneContratti/ApiAbilitaContrattoRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_abilitaContratto_Lit_icbpi_XPaySDK_Models_WebApi_Requests_GestioneContratti_ApiAbilitaContrattoRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_cancellaContratto_Lit_icbpi_XPaySDK_Models_WebApi_Requests_GestioneContratti_ApiCancellaContrattoRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='GestioneContratti']/method[@name='cancellaContratto' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ApiCancellaContrattoRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.GestioneContratti.ApiCancellaContrattoResponse&gt;']]"
		[Register ("cancellaContratto", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/GestioneContratti/ApiCancellaContrattoRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void CancellaContratto (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ApiCancellaContrattoRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_cancellaContratto_Lit_icbpi_XPaySDK_Models_WebApi_Requests_GestioneContratti_ApiCancellaContrattoRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_cancellaContratto_Lit_icbpi_XPaySDK_Models_WebApi_Requests_GestioneContratti_ApiCancellaContrattoRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "cancellaContratto", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/GestioneContratti/ApiCancellaContrattoRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancellaContratto_Lit_icbpi_XPaySDK_Models_WebApi_Requests_GestioneContratti_ApiCancellaContrattoRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_creaContrattoDaPOSFisico_Lit_icbpi_XPaySDK_Models_WebApi_Requests_GestioneContratti_ApiContrattoDaPOSFisicoRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='GestioneContratti']/method[@name='creaContrattoDaPOSFisico' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ApiContrattoDaPOSFisicoRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.GestioneContratti.ApiContrattoDaPOSFisicoResponse&gt;']]"
		[Register ("creaContrattoDaPOSFisico", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/GestioneContratti/ApiContrattoDaPOSFisicoRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void CreaContrattoDaPOSFisico (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ApiContrattoDaPOSFisicoRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_creaContrattoDaPOSFisico_Lit_icbpi_XPaySDK_Models_WebApi_Requests_GestioneContratti_ApiContrattoDaPOSFisicoRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_creaContrattoDaPOSFisico_Lit_icbpi_XPaySDK_Models_WebApi_Requests_GestioneContratti_ApiContrattoDaPOSFisicoRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "creaContrattoDaPOSFisico", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/GestioneContratti/ApiContrattoDaPOSFisicoRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_creaContrattoDaPOSFisico_Lit_icbpi_XPaySDK_Models_WebApi_Requests_GestioneContratti_ApiContrattoDaPOSFisicoRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_dettagliContratto_Lit_icbpi_XPaySDK_Models_WebApi_Requests_GestioneContratti_ApiDettagliContrattoRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='GestioneContratti']/method[@name='dettagliContratto' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ApiDettagliContrattoRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.GestioneContratti.ApiDettagliContrattiResponse&gt;']]"
		[Register ("dettagliContratto", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/GestioneContratti/ApiDettagliContrattoRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void DettagliContratto (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ApiDettagliContrattoRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_dettagliContratto_Lit_icbpi_XPaySDK_Models_WebApi_Requests_GestioneContratti_ApiDettagliContrattoRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_dettagliContratto_Lit_icbpi_XPaySDK_Models_WebApi_Requests_GestioneContratti_ApiDettagliContrattoRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "dettagliContratto", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/GestioneContratti/ApiDettagliContrattoRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dettagliContratto_Lit_icbpi_XPaySDK_Models_WebApi_Requests_GestioneContratti_ApiDettagliContrattoRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_disabilitaContratto_Lit_icbpi_XPaySDK_Models_WebApi_Requests_GestioneContratti_ApiDisabilitaContrattoRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='GestioneContratti']/method[@name='disabilitaContratto' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ApiDisabilitaContrattoRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.GestioneContratti.ApiDisabilitaContrattoResponse&gt;']]"
		[Register ("disabilitaContratto", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/GestioneContratti/ApiDisabilitaContrattoRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void DisabilitaContratto (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ApiDisabilitaContrattoRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_disabilitaContratto_Lit_icbpi_XPaySDK_Models_WebApi_Requests_GestioneContratti_ApiDisabilitaContrattoRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_disabilitaContratto_Lit_icbpi_XPaySDK_Models_WebApi_Requests_GestioneContratti_ApiDisabilitaContrattoRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "disabilitaContratto", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/GestioneContratti/ApiDisabilitaContrattoRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disabilitaContratto_Lit_icbpi_XPaySDK_Models_WebApi_Requests_GestioneContratti_ApiDisabilitaContrattoRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_queryContratti_Lit_icbpi_XPaySDK_Models_WebApi_Requests_GestioneContratti_ApiQueryContrattiRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='GestioneContratti']/method[@name='queryContratti' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ApiQueryContrattiRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.GestioneContratti.ApiQueryContrattiResponse&gt;']]"
		[Register ("queryContratti", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/GestioneContratti/ApiQueryContrattiRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void QueryContratti (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ApiQueryContrattiRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_queryContratti_Lit_icbpi_XPaySDK_Models_WebApi_Requests_GestioneContratti_ApiQueryContrattiRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_queryContratti_Lit_icbpi_XPaySDK_Models_WebApi_Requests_GestioneContratti_ApiQueryContrattiRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "queryContratti", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/GestioneContratti/ApiQueryContrattiRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_queryContratti_Lit_icbpi_XPaySDK_Models_WebApi_Requests_GestioneContratti_ApiQueryContrattiRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

	}
}
