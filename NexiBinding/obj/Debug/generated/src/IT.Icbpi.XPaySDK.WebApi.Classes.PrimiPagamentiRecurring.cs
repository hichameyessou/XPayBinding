using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.WebApi.Classes {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='PrimiPagamentiRecurring']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/WebApi/Classes/PrimiPagamentiRecurring", DoNotGenerateAcw=true)]
	public sealed partial class PrimiPagamentiRecurring : global::IT.Icbpi.XPaySDK.WebApi.Classes.BaseManagement, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='PrimiPagamentiRecurring']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr creaNoncePrimoPagamento3DSCallback_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='PrimiPagamentiRecurring']/field[@name='creaNoncePrimoPagamento3DSCallback']"
		[Register ("creaNoncePrimoPagamento3DSCallback")]
		public global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback CreaNoncePrimoPagamento3DSCallback {
			get {
				if (creaNoncePrimoPagamento3DSCallback_jfieldId == IntPtr.Zero)
					creaNoncePrimoPagamento3DSCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "creaNoncePrimoPagamento3DSCallback", "Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, creaNoncePrimoPagamento3DSCallback_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (creaNoncePrimoPagamento3DSCallback_jfieldId == IntPtr.Zero)
					creaNoncePrimoPagamento3DSCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "creaNoncePrimoPagamento3DSCallback", "Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, creaNoncePrimoPagamento3DSCallback_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr creaNonceVerificaCartaResponseApiResponseCallback_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='PrimiPagamentiRecurring']/field[@name='creaNonceVerificaCartaResponseApiResponseCallback']"
		[Register ("creaNonceVerificaCartaResponseApiResponseCallback")]
		public global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback CreaNonceVerificaCartaResponseApiResponseCallback {
			get {
				if (creaNonceVerificaCartaResponseApiResponseCallback_jfieldId == IntPtr.Zero)
					creaNonceVerificaCartaResponseApiResponseCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "creaNonceVerificaCartaResponseApiResponseCallback", "Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, creaNonceVerificaCartaResponseApiResponseCallback_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (creaNonceVerificaCartaResponseApiResponseCallback_jfieldId == IntPtr.Zero)
					creaNonceVerificaCartaResponseApiResponseCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "creaNonceVerificaCartaResponseApiResponseCallback", "Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, creaNonceVerificaCartaResponseApiResponseCallback_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr primiPagamentiRecurring_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='PrimiPagamentiRecurring']/field[@name='primiPagamentiRecurring']"
		[Register ("primiPagamentiRecurring")]
		public static global::IT.Icbpi.XPaySDK.WebApi.Classes.PrimiPagamentiRecurring PrimiPagamentiRecurring {
			get {
				if (primiPagamentiRecurring_jfieldId == IntPtr.Zero)
					primiPagamentiRecurring_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "primiPagamentiRecurring", "Lit/icbpi/XPaySDK/WebApi/Classes/PrimiPagamentiRecurring;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, primiPagamentiRecurring_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.WebApi.Classes.PrimiPagamentiRecurring> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (primiPagamentiRecurring_jfieldId == IntPtr.Zero)
					primiPagamentiRecurring_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "primiPagamentiRecurring", "Lit/icbpi/XPaySDK/WebApi/Classes/PrimiPagamentiRecurring;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, primiPagamentiRecurring_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/WebApi/Classes/PrimiPagamentiRecurring", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PrimiPagamentiRecurring); }
		}

		internal PrimiPagamentiRecurring (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='PrimiPagamentiRecurring']/constructor[@name='PrimiPagamentiRecurring' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe PrimiPagamentiRecurring (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (PrimiPagamentiRecurring)) {
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

		static IntPtr id_creaNoncePrimoPagamento3DS_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PrimiPagamentiRecurring_ApiCreaNoncePrimoPagamento3DSRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='PrimiPagamentiRecurring']/method[@name='creaNoncePrimoPagamento3DS' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiCreaNoncePrimoPagamento3DSRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiCreaNoncePrimoPagamento3DSResponse&gt;']]"
		[Register ("creaNoncePrimoPagamento3DS", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/PrimiPagamentiRecurring/ApiCreaNoncePrimoPagamento3DSRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void CreaNoncePrimoPagamento3DS (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiCreaNoncePrimoPagamento3DSRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_creaNoncePrimoPagamento3DS_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PrimiPagamentiRecurring_ApiCreaNoncePrimoPagamento3DSRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_creaNoncePrimoPagamento3DS_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PrimiPagamentiRecurring_ApiCreaNoncePrimoPagamento3DSRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "creaNoncePrimoPagamento3DS", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/PrimiPagamentiRecurring/ApiCreaNoncePrimoPagamento3DSRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_creaNoncePrimoPagamento3DS_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PrimiPagamentiRecurring_ApiCreaNoncePrimoPagamento3DSRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_creaNonceVerificaCarta_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PrimiPagamentiRecurring_ApiCreaNonceVerificaCartaRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='PrimiPagamentiRecurring']/method[@name='creaNonceVerificaCarta' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiCreaNonceVerificaCartaRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiCreaNonceVerificaCartaResponse&gt;']]"
		[Register ("creaNonceVerificaCarta", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/PrimiPagamentiRecurring/ApiCreaNonceVerificaCartaRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void CreaNonceVerificaCarta (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiCreaNonceVerificaCartaRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_creaNonceVerificaCarta_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PrimiPagamentiRecurring_ApiCreaNonceVerificaCartaRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_creaNonceVerificaCarta_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PrimiPagamentiRecurring_ApiCreaNonceVerificaCartaRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "creaNonceVerificaCarta", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/PrimiPagamentiRecurring/ApiCreaNonceVerificaCartaRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_creaNonceVerificaCarta_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PrimiPagamentiRecurring_ApiCreaNonceVerificaCartaRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='PrimiPagamentiRecurring']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
			} finally {
			}
		}

		static IntPtr id_primoPagamento3DS_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PrimiPagamentiRecurring_ApiPrimoPagamento3DSRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='PrimiPagamentiRecurring']/method[@name='primoPagamento3DS' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiPrimoPagamento3DSRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiPrimoPagamento3DSResponse&gt;']]"
		[Register ("primoPagamento3DS", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/PrimiPagamentiRecurring/ApiPrimoPagamento3DSRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void PrimoPagamento3DS (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiPrimoPagamento3DSRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_primoPagamento3DS_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PrimiPagamentiRecurring_ApiPrimoPagamento3DSRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_primoPagamento3DS_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PrimiPagamentiRecurring_ApiPrimoPagamento3DSRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "primoPagamento3DS", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/PrimiPagamentiRecurring/ApiPrimoPagamento3DSRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_primoPagamento3DS_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PrimiPagamentiRecurring_ApiPrimoPagamento3DSRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_primoPagamentoMOTO_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PrimiPagamentiRecurring_ApiPrimoPagamentoMOTORequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='PrimiPagamentiRecurring']/method[@name='primoPagamentoMOTO' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTORequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTOResponse&gt;']]"
		[Register ("primoPagamentoMOTO", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/PrimiPagamentiRecurring/ApiPrimoPagamentoMOTORequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void PrimoPagamentoMOTO (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTORequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_primoPagamentoMOTO_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PrimiPagamentiRecurring_ApiPrimoPagamentoMOTORequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_primoPagamentoMOTO_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PrimiPagamentiRecurring_ApiPrimoPagamentoMOTORequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "primoPagamentoMOTO", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/PrimiPagamentiRecurring/ApiPrimoPagamentoMOTORequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_primoPagamentoMOTO_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PrimiPagamentiRecurring_ApiPrimoPagamentoMOTORequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_primoPagamentoSSL_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PrimiPagamentiRecurring_ApiPrimoPagamentoSSLRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='PrimiPagamentiRecurring']/method[@name='primoPagamentoSSL' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiPrimoPagamentoSSLRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiPrimoPagamentoSSLResponse&gt;']]"
		[Register ("primoPagamentoSSL", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/PrimiPagamentiRecurring/ApiPrimoPagamentoSSLRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void PrimoPagamentoSSL (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiPrimoPagamentoSSLRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_primoPagamentoSSL_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PrimiPagamentiRecurring_ApiPrimoPagamentoSSLRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_primoPagamentoSSL_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PrimiPagamentiRecurring_ApiPrimoPagamentoSSLRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "primoPagamentoSSL", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/PrimiPagamentiRecurring/ApiPrimoPagamentoSSLRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_primoPagamentoSSL_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PrimiPagamentiRecurring_ApiPrimoPagamentoSSLRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_verificaCarta3DS_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PrimiPagamentiRecurring_ApiVerificaCarta3DSRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='PrimiPagamentiRecurring']/method[@name='verificaCarta3DS' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiVerificaCarta3DSRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiVerificaCarta3DSResponse&gt;']]"
		[Register ("verificaCarta3DS", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/PrimiPagamentiRecurring/ApiVerificaCarta3DSRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void VerificaCarta3DS (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiVerificaCarta3DSRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_verificaCarta3DS_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PrimiPagamentiRecurring_ApiVerificaCarta3DSRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_verificaCarta3DS_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PrimiPagamentiRecurring_ApiVerificaCarta3DSRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "verificaCarta3DS", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/PrimiPagamentiRecurring/ApiVerificaCarta3DSRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_verificaCarta3DS_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PrimiPagamentiRecurring_ApiVerificaCarta3DSRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_verificaCartaSSL_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PrimiPagamentiRecurring_ApiVerificaCartaSSLRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='PrimiPagamentiRecurring']/method[@name='verificaCartaSSL' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiVerificaCartaSSLRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiVerificaCartaSSLResponse&gt;']]"
		[Register ("verificaCartaSSL", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/PrimiPagamentiRecurring/ApiVerificaCartaSSLRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void VerificaCartaSSL (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiVerificaCartaSSLRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_verificaCartaSSL_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PrimiPagamentiRecurring_ApiVerificaCartaSSLRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_verificaCartaSSL_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PrimiPagamentiRecurring_ApiVerificaCartaSSLRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "verificaCartaSSL", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/PrimiPagamentiRecurring/ApiVerificaCartaSSLRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_verificaCartaSSL_Lit_icbpi_XPaySDK_Models_WebApi_Requests_PrimiPagamentiRecurring_ApiVerificaCartaSSLRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='PrimiPagamentiRecurring']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
			} finally {
			}
		}

	}
}
