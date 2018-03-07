using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti']/class[@name='ContractPOS']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Models/WebApi/Requests/GestioneContratti/ContractPOS", DoNotGenerateAcw=true)]
	public partial class ContractPOS : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Models/WebApi/Requests/GestioneContratti/ContractPOS", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContractPOS); }
		}

		protected ContractPOS (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_util_Date_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti']/class[@name='ContractPOS']/constructor[@name='ContractPOS' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='long'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.util.Date']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Ljava/util/Date;)V", "")]
		public unsafe ContractPOS (string p0, string p1, string p2, string p3, long p4, string p5, string p6, global::Java.Util.Date p7)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);
				__args [7] = new JValue (p7);
				if (((object) this).GetType () != typeof (ContractPOS)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Ljava/util/Date;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Ljava/util/Date;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_util_Date_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Ljava/util/Date;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_util_Date_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_util_Date_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static Delegate cb_getAmount;
#pragma warning disable 0169
		static Delegate GetGetAmountHandler ()
		{
			if (cb_getAmount == null)
				cb_getAmount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAmount);
			return cb_getAmount;
		}

		static long n_GetAmount (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ContractPOS __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ContractPOS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Amount;
		}
#pragma warning restore 0169

		static IntPtr id_getAmount;
		public virtual unsafe long Amount {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti']/class[@name='ContractPOS']/method[@name='getAmount' and count(parameter)=0]"
			[Register ("getAmount", "()J", "GetGetAmountHandler")]
			get {
				if (id_getAmount == IntPtr.Zero)
					id_getAmount = JNIEnv.GetMethodID (class_ref, "getAmount", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getAmount);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAmount", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getAuthCode;
#pragma warning disable 0169
		static Delegate GetGetAuthCodeHandler ()
		{
			if (cb_getAuthCode == null)
				cb_getAuthCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthCode);
			return cb_getAuthCode;
		}

		static IntPtr n_GetAuthCode (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ContractPOS __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ContractPOS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthCode);
		}
#pragma warning restore 0169

		static IntPtr id_getAuthCode;
		public virtual unsafe string AuthCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti']/class[@name='ContractPOS']/method[@name='getAuthCode' and count(parameter)=0]"
			[Register ("getAuthCode", "()Ljava/lang/String;", "GetGetAuthCodeHandler")]
			get {
				if (id_getAuthCode == IntPtr.Zero)
					id_getAuthCode = JNIEnv.GetMethodID (class_ref, "getAuthCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuthCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEmail;
#pragma warning disable 0169
		static Delegate GetGetEmailHandler ()
		{
			if (cb_getEmail == null)
				cb_getEmail = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmail);
			return cb_getEmail;
		}

		static IntPtr n_GetEmail (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ContractPOS __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ContractPOS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Email);
		}
#pragma warning restore 0169

		static IntPtr id_getEmail;
		public virtual unsafe string Email {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti']/class[@name='ContractPOS']/method[@name='getEmail' and count(parameter)=0]"
			[Register ("getEmail", "()Ljava/lang/String;", "GetGetEmailHandler")]
			get {
				if (id_getEmail == IntPtr.Zero)
					id_getEmail = JNIEnv.GetMethodID (class_ref, "getEmail", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEmail), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEmail", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIdPhysicalPOS;
#pragma warning disable 0169
		static Delegate GetGetIdPhysicalPOSHandler ()
		{
			if (cb_getIdPhysicalPOS == null)
				cb_getIdPhysicalPOS = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIdPhysicalPOS);
			return cb_getIdPhysicalPOS;
		}

		static IntPtr n_GetIdPhysicalPOS (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ContractPOS __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ContractPOS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IdPhysicalPOS);
		}
#pragma warning restore 0169

		static IntPtr id_getIdPhysicalPOS;
		public virtual unsafe string IdPhysicalPOS {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti']/class[@name='ContractPOS']/method[@name='getIdPhysicalPOS' and count(parameter)=0]"
			[Register ("getIdPhysicalPOS", "()Ljava/lang/String;", "GetGetIdPhysicalPOSHandler")]
			get {
				if (id_getIdPhysicalPOS == IntPtr.Zero)
					id_getIdPhysicalPOS = JNIEnv.GetMethodID (class_ref, "getIdPhysicalPOS", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIdPhysicalPOS), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIdPhysicalPOS", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ContractPOS __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ContractPOS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NContract);
		}
#pragma warning restore 0169

		static IntPtr id_getNContract;
		public virtual unsafe string NContract {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti']/class[@name='ContractPOS']/method[@name='getNContract' and count(parameter)=0]"
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

		static Delegate cb_getServiceDescription;
#pragma warning disable 0169
		static Delegate GetGetServiceDescriptionHandler ()
		{
			if (cb_getServiceDescription == null)
				cb_getServiceDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetServiceDescription);
			return cb_getServiceDescription;
		}

		static IntPtr n_GetServiceDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ContractPOS __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ContractPOS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServiceDescription);
		}
#pragma warning restore 0169

		static IntPtr id_getServiceDescription;
		public virtual unsafe string ServiceDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti']/class[@name='ContractPOS']/method[@name='getServiceDescription' and count(parameter)=0]"
			[Register ("getServiceDescription", "()Ljava/lang/String;", "GetGetServiceDescriptionHandler")]
			get {
				if (id_getServiceDescription == IntPtr.Zero)
					id_getServiceDescription = JNIEnv.GetMethodID (class_ref, "getServiceDescription", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServiceDescription), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getServiceDescription", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStan;
#pragma warning disable 0169
		static Delegate GetGetStanHandler ()
		{
			if (cb_getStan == null)
				cb_getStan = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStan);
			return cb_getStan;
		}

		static IntPtr n_GetStan (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ContractPOS __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ContractPOS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Stan);
		}
#pragma warning restore 0169

		static IntPtr id_getStan;
		public virtual unsafe string Stan {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti']/class[@name='ContractPOS']/method[@name='getStan' and count(parameter)=0]"
			[Register ("getStan", "()Ljava/lang/String;", "GetGetStanHandler")]
			get {
				if (id_getStan == IntPtr.Zero)
					id_getStan = JNIEnv.GetMethodID (class_ref, "getStan", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStan), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStan", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTransactionDate;
#pragma warning disable 0169
		static Delegate GetGetTransactionDateHandler ()
		{
			if (cb_getTransactionDate == null)
				cb_getTransactionDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransactionDate);
			return cb_getTransactionDate;
		}

		static IntPtr n_GetTransactionDate (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ContractPOS __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti.ContractPOS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransactionDate);
		}
#pragma warning restore 0169

		static IntPtr id_getTransactionDate;
		public virtual unsafe string TransactionDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.GestioneContratti']/class[@name='ContractPOS']/method[@name='getTransactionDate' and count(parameter)=0]"
			[Register ("getTransactionDate", "()Ljava/lang/String;", "GetGetTransactionDateHandler")]
			get {
				if (id_getTransactionDate == IntPtr.Zero)
					id_getTransactionDate = JNIEnv.GetMethodID (class_ref, "getTransactionDate", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTransactionDate), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransactionDate", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
