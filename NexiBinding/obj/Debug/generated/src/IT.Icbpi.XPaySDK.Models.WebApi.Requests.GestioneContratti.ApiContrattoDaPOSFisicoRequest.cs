using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti']/class[@name='ApiContrattoDaPOSFisicoRequest']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Models/WebApi/Requests/GestioneContratti/ApiContrattoDaPOSFisicoRequest", DoNotGenerateAcw=true)]
	public partial class ApiContrattoDaPOSFisicoRequest : global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.ApiBaseRequest {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Models/WebApi/Requests/GestioneContratti/ApiContrattoDaPOSFisicoRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApiContrattoDaPOSFisicoRequest); }
		}

		protected ApiContrattoDaPOSFisicoRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Requests_GestioneContratti_ContractPOS_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti']/class[@name='ApiContrattoDaPOSFisicoRequest']/constructor[@name='ApiContrattoDaPOSFisicoRequest' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ContractPOS']]"
		[Register (".ctor", "(Ljava/lang/String;Lit/icbpi/XPaySDK/Models/WebApi/Requests/GestioneContratti/ContractPOS;)V", "")]
		public unsafe ApiContrattoDaPOSFisicoRequest (string p0, global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ContractPOS p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ApiContrattoDaPOSFisicoRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Lit/icbpi/XPaySDK/Models/WebApi/Requests/GestioneContratti/ContractPOS;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lit/icbpi/XPaySDK/Models/WebApi/Requests/GestioneContratti/ContractPOS;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Requests_GestioneContratti_ContractPOS_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Requests_GestioneContratti_ContractPOS_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lit/icbpi/XPaySDK/Models/WebApi/Requests/GestioneContratti/ContractPOS;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Requests_GestioneContratti_ContractPOS_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lit_icbpi_XPaySDK_Models_WebApi_Requests_GestioneContratti_ContractPOS_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getContractPOS;
#pragma warning disable 0169
		static Delegate GetGetContractPOSHandler ()
		{
			if (cb_getContractPOS == null)
				cb_getContractPOS = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContractPOS);
			return cb_getContractPOS;
		}

		static IntPtr n_GetContractPOS (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ApiContrattoDaPOSFisicoRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ApiContrattoDaPOSFisicoRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContractPOS);
		}
#pragma warning restore 0169

		static IntPtr id_getContractPOS;
		public virtual unsafe global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ContractPOS ContractPOS {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti']/class[@name='ApiContrattoDaPOSFisicoRequest']/method[@name='getContractPOS' and count(parameter)=0]"
			[Register ("getContractPOS", "()Lit/icbpi/XPaySDK/Models/WebApi/Requests/GestioneContratti/ContractPOS;", "GetGetContractPOSHandler")]
			get {
				if (id_getContractPOS == IntPtr.Zero)
					id_getContractPOS = JNIEnv.GetMethodID (class_ref, "getContractPOS", "()Lit/icbpi/XPaySDK/Models/WebApi/Requests/GestioneContratti/ContractPOS;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ContractPOS> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContractPOS), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ContractPOS> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContractPOS", "()Lit/icbpi/XPaySDK/Models/WebApi/Requests/GestioneContratti/ContractPOS;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
