using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Models.WebApi.Requests.Varie {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.Varie']/class[@name='ApiPagaDCCRequest']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Models/WebApi/Requests/Varie/ApiPagaDCCRequest", DoNotGenerateAcw=true)]
	public partial class ApiPagaDCCRequest : global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.ApiBaseRequest {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Models/WebApi/Requests/Varie/ApiPagaDCCRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApiPagaDCCRequest); }
		}

		protected ApiPagaDCCRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JIJILit_icbpi_XPaySDK_Models_Card_Lit_icbpi_XPaySDK_Utils_Varie_DCCGenericUtils_ExchangeRate_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.Varie']/class[@name='ApiPagaDCCRequest']/constructor[@name='ApiPagaDCCRequest' and count(parameter)=9 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='long'] and parameter[5][@type='int'] and parameter[6][@type='long'] and parameter[7][@type='int'] and parameter[8][@type='it.icbpi.XPaySDK.Models.Card'] and parameter[9][@type='it.icbpi.XPaySDK.Utils.Varie.DCCGenericUtils.ExchangeRate']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JIJILit/icbpi/XPaySDK/Models/Card;Lit/icbpi/XPaySDK/Utils/Varie/DCCGenericUtils$ExchangeRate;)V", "")]
		public unsafe ApiPagaDCCRequest (string p0, string p1, string p2, long p3, int p4, long p5, int p6, global::IT.Icbpi.XPaySDK.Models.Card p7, global::IT.Icbpi.XPaySDK.Utils.Varie.DCCGenericUtils.ExchangeRate p8)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				if (((object) this).GetType () != typeof (ApiPagaDCCRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JIJILit/icbpi/XPaySDK/Models/Card;Lit/icbpi/XPaySDK/Utils/Varie/DCCGenericUtils$ExchangeRate;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JIJILit/icbpi/XPaySDK/Models/Card;Lit/icbpi/XPaySDK/Utils/Varie/DCCGenericUtils$ExchangeRate;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JIJILit_icbpi_XPaySDK_Models_Card_Lit_icbpi_XPaySDK_Utils_Varie_DCCGenericUtils_ExchangeRate_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JIJILit_icbpi_XPaySDK_Models_Card_Lit_icbpi_XPaySDK_Utils_Varie_DCCGenericUtils_ExchangeRate_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JIJILit/icbpi/XPaySDK/Models/Card;Lit/icbpi/XPaySDK/Utils/Varie/DCCGenericUtils$ExchangeRate;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JIJILit_icbpi_XPaySDK_Models_Card_Lit_icbpi_XPaySDK_Utils_Varie_DCCGenericUtils_ExchangeRate_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JIJILit_icbpi_XPaySDK_Models_Card_Lit_icbpi_XPaySDK_Utils_Varie_DCCGenericUtils_ExchangeRate_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JIJILit_icbpi_XPaySDK_Models_Card_Lit_icbpi_XPaySDK_Utils_Varie_DCCGenericUtils_ExchangeRate_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.Varie']/class[@name='ApiPagaDCCRequest']/constructor[@name='ApiPagaDCCRequest' and count(parameter)=10 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='long'] and parameter[5][@type='int'] and parameter[6][@type='long'] and parameter[7][@type='int'] and parameter[8][@type='it.icbpi.XPaySDK.Models.Card'] and parameter[9][@type='it.icbpi.XPaySDK.Utils.Varie.DCCGenericUtils.ExchangeRate'] and parameter[10][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JIJILit/icbpi/XPaySDK/Models/Card;Lit/icbpi/XPaySDK/Utils/Varie/DCCGenericUtils$ExchangeRate;Ljava/lang/String;)V", "")]
		public unsafe ApiPagaDCCRequest (string p0, string p1, string p2, long p3, int p4, long p5, int p6, global::IT.Icbpi.XPaySDK.Models.Card p7, global::IT.Icbpi.XPaySDK.Utils.Varie.DCCGenericUtils.ExchangeRate p8, string p9)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p9 = JNIEnv.NewString (p9);
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (native_p9);
				if (((object) this).GetType () != typeof (ApiPagaDCCRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JIJILit/icbpi/XPaySDK/Models/Card;Lit/icbpi/XPaySDK/Utils/Varie/DCCGenericUtils$ExchangeRate;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JIJILit/icbpi/XPaySDK/Models/Card;Lit/icbpi/XPaySDK/Utils/Varie/DCCGenericUtils$ExchangeRate;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JIJILit_icbpi_XPaySDK_Models_Card_Lit_icbpi_XPaySDK_Utils_Varie_DCCGenericUtils_ExchangeRate_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JIJILit_icbpi_XPaySDK_Models_Card_Lit_icbpi_XPaySDK_Utils_Varie_DCCGenericUtils_ExchangeRate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JIJILit/icbpi/XPaySDK/Models/Card;Lit/icbpi/XPaySDK/Utils/Varie/DCCGenericUtils$ExchangeRate;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JIJILit_icbpi_XPaySDK_Models_Card_Lit_icbpi_XPaySDK_Utils_Varie_DCCGenericUtils_ExchangeRate_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JIJILit_icbpi_XPaySDK_Models_Card_Lit_icbpi_XPaySDK_Utils_Varie_DCCGenericUtils_ExchangeRate_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p9);
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.Varie.ApiPagaDCCRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.Varie.ApiPagaDCCRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Amount;
		}
#pragma warning restore 0169

		static IntPtr id_getAmount;
		public virtual unsafe long Amount {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.Varie']/class[@name='ApiPagaDCCRequest']/method[@name='getAmount' and count(parameter)=0]"
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.Varie.ApiPagaDCCRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.Varie.ApiPagaDCCRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CodTrans);
		}
#pragma warning restore 0169

		static IntPtr id_getCodTrans;
		public virtual unsafe string CodTrans {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.Varie']/class[@name='ApiPagaDCCRequest']/method[@name='getCodTrans' and count(parameter)=0]"
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.Varie.ApiPagaDCCRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.Varie.ApiPagaDCCRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Currency;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrency;
		public virtual unsafe int Currency {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.Varie']/class[@name='ApiPagaDCCRequest']/method[@name='getCurrency' and count(parameter)=0]"
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.Varie.ApiPagaDCCRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.Varie.ApiPagaDCCRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Cvc);
		}
#pragma warning restore 0169

		static IntPtr id_getCvc;
		public virtual unsafe string Cvc {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.Varie']/class[@name='ApiPagaDCCRequest']/method[@name='getCvc' and count(parameter)=0]"
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

		static Delegate cb_getDccAmount;
#pragma warning disable 0169
		static Delegate GetGetDccAmountHandler ()
		{
			if (cb_getDccAmount == null)
				cb_getDccAmount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDccAmount);
			return cb_getDccAmount;
		}

		static long n_GetDccAmount (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.Varie.ApiPagaDCCRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.Varie.ApiPagaDCCRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DccAmount;
		}
#pragma warning restore 0169

		static IntPtr id_getDccAmount;
		public virtual unsafe long DccAmount {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.Varie']/class[@name='ApiPagaDCCRequest']/method[@name='getDccAmount' and count(parameter)=0]"
			[Register ("getDccAmount", "()J", "GetGetDccAmountHandler")]
			get {
				if (id_getDccAmount == IntPtr.Zero)
					id_getDccAmount = JNIEnv.GetMethodID (class_ref, "getDccAmount", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDccAmount);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDccAmount", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getDccCurrency;
#pragma warning disable 0169
		static Delegate GetGetDccCurrencyHandler ()
		{
			if (cb_getDccCurrency == null)
				cb_getDccCurrency = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDccCurrency);
			return cb_getDccCurrency;
		}

		static int n_GetDccCurrency (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.Varie.ApiPagaDCCRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.Varie.ApiPagaDCCRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DccCurrency;
		}
#pragma warning restore 0169

		static IntPtr id_getDccCurrency;
		public virtual unsafe int DccCurrency {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.Varie']/class[@name='ApiPagaDCCRequest']/method[@name='getDccCurrency' and count(parameter)=0]"
			[Register ("getDccCurrency", "()I", "GetGetDccCurrencyHandler")]
			get {
				if (id_getDccCurrency == IntPtr.Zero)
					id_getDccCurrency = JNIEnv.GetMethodID (class_ref, "getDccCurrency", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDccCurrency);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDccCurrency", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getExchangeRateAccepted;
#pragma warning disable 0169
		static Delegate GetGetExchangeRateAcceptedHandler ()
		{
			if (cb_getExchangeRateAccepted == null)
				cb_getExchangeRateAccepted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExchangeRateAccepted);
			return cb_getExchangeRateAccepted;
		}

		static IntPtr n_GetExchangeRateAccepted (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.Varie.ApiPagaDCCRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.Varie.ApiPagaDCCRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExchangeRateAccepted);
		}
#pragma warning restore 0169

		static IntPtr id_getExchangeRateAccepted;
		public virtual unsafe string ExchangeRateAccepted {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.Varie']/class[@name='ApiPagaDCCRequest']/method[@name='getExchangeRateAccepted' and count(parameter)=0]"
			[Register ("getExchangeRateAccepted", "()Ljava/lang/String;", "GetGetExchangeRateAcceptedHandler")]
			get {
				if (id_getExchangeRateAccepted == IntPtr.Zero)
					id_getExchangeRateAccepted = JNIEnv.GetMethodID (class_ref, "getExchangeRateAccepted", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExchangeRateAccepted), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExchangeRateAccepted", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.Varie.ApiPagaDCCRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.Varie.ApiPagaDCCRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Expire);
		}
#pragma warning restore 0169

		static IntPtr id_getExpire;
		public virtual unsafe string Expire {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.Varie']/class[@name='ApiPagaDCCRequest']/method[@name='getExpire' and count(parameter)=0]"
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

		static Delegate cb_getNonce;
#pragma warning disable 0169
		static Delegate GetGetNonceHandler ()
		{
			if (cb_getNonce == null)
				cb_getNonce = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNonce);
			return cb_getNonce;
		}

		static IntPtr n_GetNonce (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.Varie.ApiPagaDCCRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.Varie.ApiPagaDCCRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Nonce);
		}
#pragma warning restore 0169

		static IntPtr id_getNonce;
		public virtual unsafe string Nonce {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.Varie']/class[@name='ApiPagaDCCRequest']/method[@name='getNonce' and count(parameter)=0]"
			[Register ("getNonce", "()Ljava/lang/String;", "GetGetNonceHandler")]
			get {
				if (id_getNonce == IntPtr.Zero)
					id_getNonce = JNIEnv.GetMethodID (class_ref, "getNonce", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNonce), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNonce", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.Varie.ApiPagaDCCRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.Varie.ApiPagaDCCRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Pan);
		}
#pragma warning restore 0169

		static IntPtr id_getPan;
		public virtual unsafe string Pan {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.Varie']/class[@name='ApiPagaDCCRequest']/method[@name='getPan' and count(parameter)=0]"
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

		static Delegate cb_getTicket;
#pragma warning disable 0169
		static Delegate GetGetTicketHandler ()
		{
			if (cb_getTicket == null)
				cb_getTicket = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTicket);
			return cb_getTicket;
		}

		static IntPtr n_GetTicket (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.Varie.ApiPagaDCCRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.Varie.ApiPagaDCCRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Ticket);
		}
#pragma warning restore 0169

		static IntPtr id_getTicket;
		public virtual unsafe string Ticket {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.Varie']/class[@name='ApiPagaDCCRequest']/method[@name='getTicket' and count(parameter)=0]"
			[Register ("getTicket", "()Ljava/lang/String;", "GetGetTicketHandler")]
			get {
				if (id_getTicket == IntPtr.Zero)
					id_getTicket = JNIEnv.GetMethodID (class_ref, "getTicket", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTicket), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTicket", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
