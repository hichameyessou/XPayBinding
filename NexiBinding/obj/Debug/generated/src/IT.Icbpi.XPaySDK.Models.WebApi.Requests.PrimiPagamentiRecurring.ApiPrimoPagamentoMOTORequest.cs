using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring']/class[@name='ApiPrimoPagamentoMOTORequest']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Models/WebApi/Requests/PrimiPagamentiRecurring/ApiPrimoPagamentoMOTORequest", DoNotGenerateAcw=true)]
	public partial class ApiPrimoPagamentoMOTORequest : global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.ApiBaseRequest {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Models/WebApi/Requests/PrimiPagamentiRecurring/ApiPrimoPagamentoMOTORequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApiPrimoPagamentoMOTORequest); }
		}

		protected ApiPrimoPagamentoMOTORequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JILit_icbpi_XPaySDK_Models_Card_Ljava_util_Date_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring']/class[@name='ApiPrimoPagamentoMOTORequest']/constructor[@name='ApiPrimoPagamentoMOTORequest' and count(parameter)=11 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='long'] and parameter[6][@type='int'] and parameter[7][@type='it.icbpi.XPaySDK.Models.Card'] and parameter[8][@type='java.util.Date'] and parameter[9][@type='java.lang.String'] and parameter[10][@type='java.lang.String'] and parameter[11][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JILit/icbpi/XPaySDK/Models/Card;Ljava/util/Date;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe ApiPrimoPagamentoMOTORequest (string p0, string p1, string p2, string p3, long p4, int p5, global::IT.Icbpi.XPaySDK.Models.Card p6, global::Java.Util.Date p7, string p8, string p9, string p10)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p8 = JNIEnv.NewString (p8);
			IntPtr native_p9 = JNIEnv.NewString (p9);
			IntPtr native_p10 = JNIEnv.NewString (p10);
			try {
				JValue* __args = stackalloc JValue [11];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (native_p8);
				__args [9] = new JValue (native_p9);
				__args [10] = new JValue (native_p10);
				if (((object) this).GetType () != typeof (ApiPrimoPagamentoMOTORequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JILit/icbpi/XPaySDK/Models/Card;Ljava/util/Date;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JILit/icbpi/XPaySDK/Models/Card;Ljava/util/Date;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JILit_icbpi_XPaySDK_Models_Card_Ljava_util_Date_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JILit_icbpi_XPaySDK_Models_Card_Ljava_util_Date_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JILit/icbpi/XPaySDK/Models/Card;Ljava/util/Date;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JILit_icbpi_XPaySDK_Models_Card_Ljava_util_Date_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JILit_icbpi_XPaySDK_Models_Card_Ljava_util_Date_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p8);
				JNIEnv.DeleteLocalRef (native_p9);
				JNIEnv.DeleteLocalRef (native_p10);
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTORequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Amount;
		}
#pragma warning restore 0169

		static IntPtr id_getAmount;
		public virtual unsafe long Amount {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring']/class[@name='ApiPrimoPagamentoMOTORequest']/method[@name='getAmount' and count(parameter)=0]"
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

		static Delegate cb_getCodTrans;
#pragma warning disable 0169
		static Delegate GetGetCodTransHandler ()
		{
			if (cb_getCodTrans == null)
				cb_getCodTrans = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCodTrans);
			return cb_getCodTrans;
		}

		static IntPtr n_GetCodTrans (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTORequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CodTrans);
		}
#pragma warning restore 0169

		static IntPtr id_getCodTrans;
		public virtual unsafe string CodTrans {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring']/class[@name='ApiPrimoPagamentoMOTORequest']/method[@name='getCodTrans' and count(parameter)=0]"
			[Register ("getCodTrans", "()Ljava/lang/String;", "GetGetCodTransHandler")]
			get {
				if (id_getCodTrans == IntPtr.Zero)
					id_getCodTrans = JNIEnv.GetMethodID (class_ref, "getCodTrans", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCodTrans), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCodTrans", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContractExpires;
#pragma warning disable 0169
		static Delegate GetGetContractExpiresHandler ()
		{
			if (cb_getContractExpires == null)
				cb_getContractExpires = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContractExpires);
			return cb_getContractExpires;
		}

		static IntPtr n_GetContractExpires (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTORequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContractExpires);
		}
#pragma warning restore 0169

		static IntPtr id_getContractExpires;
		public virtual unsafe string ContractExpires {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring']/class[@name='ApiPrimoPagamentoMOTORequest']/method[@name='getContractExpires' and count(parameter)=0]"
			[Register ("getContractExpires", "()Ljava/lang/String;", "GetGetContractExpiresHandler")]
			get {
				if (id_getContractExpires == IntPtr.Zero)
					id_getContractExpires = JNIEnv.GetMethodID (class_ref, "getContractExpires", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContractExpires), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContractExpires", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCurrency;
#pragma warning disable 0169
		static Delegate GetGetCurrencyHandler ()
		{
			if (cb_getCurrency == null)
				cb_getCurrency = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrency);
			return cb_getCurrency;
		}

		static int n_GetCurrency (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTORequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Currency;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrency;
		public virtual unsafe int Currency {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring']/class[@name='ApiPrimoPagamentoMOTORequest']/method[@name='getCurrency' and count(parameter)=0]"
			[Register ("getCurrency", "()I", "GetGetCurrencyHandler")]
			get {
				if (id_getCurrency == IntPtr.Zero)
					id_getCurrency = JNIEnv.GetMethodID (class_ref, "getCurrency", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrency);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrency", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getCvc;
#pragma warning disable 0169
		static Delegate GetGetCvcHandler ()
		{
			if (cb_getCvc == null)
				cb_getCvc = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCvc);
			return cb_getCvc;
		}

		static IntPtr n_GetCvc (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTORequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Cvc);
		}
#pragma warning restore 0169

		static IntPtr id_getCvc;
		public virtual unsafe string Cvc {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring']/class[@name='ApiPrimoPagamentoMOTORequest']/method[@name='getCvc' and count(parameter)=0]"
			[Register ("getCvc", "()Ljava/lang/String;", "GetGetCvcHandler")]
			get {
				if (id_getCvc == IntPtr.Zero)
					id_getCvc = JNIEnv.GetMethodID (class_ref, "getCvc", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCvc), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCvc", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler ()
		{
			if (cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTORequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Description);
		}
#pragma warning restore 0169

		static IntPtr id_getDescription;
		public virtual unsafe string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring']/class[@name='ApiPrimoPagamentoMOTORequest']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
			get {
				if (id_getDescription == IntPtr.Zero)
					id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDescription", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTORequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Email);
		}
#pragma warning restore 0169

		static IntPtr id_getEmail;
		public virtual unsafe string Email {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring']/class[@name='ApiPrimoPagamentoMOTORequest']/method[@name='getEmail' and count(parameter)=0]"
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

		static Delegate cb_getExpire;
#pragma warning disable 0169
		static Delegate GetGetExpireHandler ()
		{
			if (cb_getExpire == null)
				cb_getExpire = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExpire);
			return cb_getExpire;
		}

		static IntPtr n_GetExpire (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTORequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Expire);
		}
#pragma warning restore 0169

		static IntPtr id_getExpire;
		public virtual unsafe string Expire {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring']/class[@name='ApiPrimoPagamentoMOTORequest']/method[@name='getExpire' and count(parameter)=0]"
			[Register ("getExpire", "()Ljava/lang/String;", "GetGetExpireHandler")]
			get {
				if (id_getExpire == IntPtr.Zero)
					id_getExpire = JNIEnv.GetMethodID (class_ref, "getExpire", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExpire), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExpire", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getGroupCode;
#pragma warning disable 0169
		static Delegate GetGetGroupCodeHandler ()
		{
			if (cb_getGroupCode == null)
				cb_getGroupCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGroupCode);
			return cb_getGroupCode;
		}

		static IntPtr n_GetGroupCode (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTORequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GroupCode);
		}
#pragma warning restore 0169

		static IntPtr id_getGroupCode;
		public virtual unsafe string GroupCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring']/class[@name='ApiPrimoPagamentoMOTORequest']/method[@name='getGroupCode' and count(parameter)=0]"
			[Register ("getGroupCode", "()Ljava/lang/String;", "GetGetGroupCodeHandler")]
			get {
				if (id_getGroupCode == IntPtr.Zero)
					id_getGroupCode = JNIEnv.GetMethodID (class_ref, "getGroupCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGroupCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGroupCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTORequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NContract);
		}
#pragma warning restore 0169

		static IntPtr id_getNContract;
		public virtual unsafe string NContract {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring']/class[@name='ApiPrimoPagamentoMOTORequest']/method[@name='getNContract' and count(parameter)=0]"
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

		static Delegate cb_getPan;
#pragma warning disable 0169
		static Delegate GetGetPanHandler ()
		{
			if (cb_getPan == null)
				cb_getPan = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPan);
			return cb_getPan;
		}

		static IntPtr n_GetPan (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTORequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Pan);
		}
#pragma warning restore 0169

		static IntPtr id_getPan;
		public virtual unsafe string Pan {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring']/class[@name='ApiPrimoPagamentoMOTORequest']/method[@name='getPan' and count(parameter)=0]"
			[Register ("getPan", "()Ljava/lang/String;", "GetGetPanHandler")]
			get {
				if (id_getPan == IntPtr.Zero)
					id_getPan = JNIEnv.GetMethodID (class_ref, "getPan", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPan), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPan", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTORequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TaxCode);
		}
#pragma warning restore 0169

		static IntPtr id_getTaxCode;
		public virtual unsafe string TaxCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.PrimiPagamentiRecurring']/class[@name='ApiPrimoPagamentoMOTORequest']/method[@name='getTaxCode' and count(parameter)=0]"
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
