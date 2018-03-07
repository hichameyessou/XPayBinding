using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti']/class[@name='ApiQueryContrattiRequest']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Models/WebApi/Requests/GestioneContratti/ApiQueryContrattiRequest", DoNotGenerateAcw=true)]
	public partial class ApiQueryContrattiRequest : global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.ApiBaseRequest {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Models/WebApi/Requests/GestioneContratti/ApiQueryContrattiRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApiQueryContrattiRequest); }
		}

		protected ApiQueryContrattiRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti']/class[@name='ApiQueryContrattiRequest']/constructor[@name='ApiQueryContrattiRequest' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe ApiQueryContrattiRequest (string p0, string p1, string p2, string p3, string p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				if (((object) this).GetType () != typeof (ApiQueryContrattiRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_getDRegistrationFrom;
#pragma warning disable 0169
		static Delegate GetGetDRegistrationFromHandler ()
		{
			if (cb_getDRegistrationFrom == null)
				cb_getDRegistrationFrom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDRegistrationFrom);
			return cb_getDRegistrationFrom;
		}

		static IntPtr n_GetDRegistrationFrom (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ApiQueryContrattiRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ApiQueryContrattiRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DRegistrationFrom);
		}
#pragma warning restore 0169

		static IntPtr id_getDRegistrationFrom;
		public virtual unsafe string DRegistrationFrom {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti']/class[@name='ApiQueryContrattiRequest']/method[@name='getDRegistrationFrom' and count(parameter)=0]"
			[Register ("getDRegistrationFrom", "()Ljava/lang/String;", "GetGetDRegistrationFromHandler")]
			get {
				if (id_getDRegistrationFrom == IntPtr.Zero)
					id_getDRegistrationFrom = JNIEnv.GetMethodID (class_ref, "getDRegistrationFrom", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDRegistrationFrom), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDRegistrationFrom", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDRegistrationTo;
#pragma warning disable 0169
		static Delegate GetGetDRegistrationToHandler ()
		{
			if (cb_getDRegistrationTo == null)
				cb_getDRegistrationTo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDRegistrationTo);
			return cb_getDRegistrationTo;
		}

		static IntPtr n_GetDRegistrationTo (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ApiQueryContrattiRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ApiQueryContrattiRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DRegistrationTo);
		}
#pragma warning restore 0169

		static IntPtr id_getDRegistrationTo;
		public virtual unsafe string DRegistrationTo {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti']/class[@name='ApiQueryContrattiRequest']/method[@name='getDRegistrationTo' and count(parameter)=0]"
			[Register ("getDRegistrationTo", "()Ljava/lang/String;", "GetGetDRegistrationToHandler")]
			get {
				if (id_getDRegistrationTo == IntPtr.Zero)
					id_getDRegistrationTo = JNIEnv.GetMethodID (class_ref, "getDRegistrationTo", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDRegistrationTo), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDRegistrationTo", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNContract;
#pragma warning disable 0169
		static Delegate GetGetNContractHandler ()
		{
			if (cb_getNContract == null)
				cb_getNContract = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNContract);
			return cb_getNContract;
		}

		static IntPtr n_GetNContract (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ApiQueryContrattiRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ApiQueryContrattiRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NContract);
		}
#pragma warning restore 0169

		static IntPtr id_getNContract;
		public virtual unsafe string NContract {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti']/class[@name='ApiQueryContrattiRequest']/method[@name='getNContract' and count(parameter)=0]"
			[Register ("getNContract", "()Ljava/lang/String;", "GetGetNContractHandler")]
			get {
				if (id_getNContract == IntPtr.Zero)
					id_getNContract = JNIEnv.GetMethodID (class_ref, "getNContract", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNContract), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNContract", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTaxCode;
#pragma warning disable 0169
		static Delegate GetGetTaxCodeHandler ()
		{
			if (cb_getTaxCode == null)
				cb_getTaxCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTaxCode);
			return cb_getTaxCode;
		}

		static IntPtr n_GetTaxCode (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ApiQueryContrattiRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ApiQueryContrattiRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TaxCode);
		}
#pragma warning restore 0169

		static IntPtr id_getTaxCode;
		public virtual unsafe string TaxCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti']/class[@name='ApiQueryContrattiRequest']/method[@name='getTaxCode' and count(parameter)=0]"
			[Register ("getTaxCode", "()Ljava/lang/String;", "GetGetTaxCodeHandler")]
			get {
				if (id_getTaxCode == IntPtr.Zero)
					id_getTaxCode = JNIEnv.GetMethodID (class_ref, "getTaxCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTaxCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTaxCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
