using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.BackOffice']/class[@name='Report']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Models/WebApi/Responses/BackOffice/Report", DoNotGenerateAcw=true)]
	public partial class Report : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Models/WebApi/Responses/BackOffice/Report", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Report); }
		}

		protected Report (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAmount;
#pragma warning disable 0169
		static Delegate GetGetAmountHandler ()
		{
			if (cb_getAmount == null)
				cb_getAmount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetAmount);
			return cb_getAmount;
		}

		static double n_GetAmount (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Amount;
		}
#pragma warning restore 0169

		static IntPtr id_getAmount;
		public virtual unsafe double Amount {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.BackOffice']/class[@name='Report']/method[@name='getAmount' and count(parameter)=0]"
			[Register ("getAmount", "()D", "GetGetAmountHandler")]
			get {
				if (id_getAmount == IntPtr.Zero)
					id_getAmount = JNIEnv.GetMethodID (class_ref, "getAmount", "()D");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getAmount);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAmount", "()D"));
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthCode);
		}
#pragma warning restore 0169

		static IntPtr id_getAuthCode;
		public virtual unsafe string AuthCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.BackOffice']/class[@name='Report']/method[@name='getAuthCode' and count(parameter)=0]"
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

		static Delegate cb_getBrand;
#pragma warning disable 0169
		static Delegate GetGetBrandHandler ()
		{
			if (cb_getBrand == null)
				cb_getBrand = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBrand);
			return cb_getBrand;
		}

		static IntPtr n_GetBrand (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Brand);
		}
#pragma warning restore 0169

		static IntPtr id_getBrand;
		public virtual unsafe string Brand {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.BackOffice']/class[@name='Report']/method[@name='getBrand' and count(parameter)=0]"
			[Register ("getBrand", "()Ljava/lang/String;", "GetGetBrandHandler")]
			get {
				if (id_getBrand == IntPtr.Zero)
					id_getBrand = JNIEnv.GetMethodID (class_ref, "getBrand", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBrand), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBrand", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CodTrans);
		}
#pragma warning restore 0169

		static IntPtr id_getCodTrans;
		public virtual unsafe string CodTrans {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.BackOffice']/class[@name='Report']/method[@name='getCodTrans' and count(parameter)=0]"
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

		static Delegate cb_getCountry;
#pragma warning disable 0169
		static Delegate GetGetCountryHandler ()
		{
			if (cb_getCountry == null)
				cb_getCountry = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCountry);
			return cb_getCountry;
		}

		static IntPtr n_GetCountry (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Country);
		}
#pragma warning restore 0169

		static IntPtr id_getCountry;
		public virtual unsafe string Country {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.BackOffice']/class[@name='Report']/method[@name='getCountry' and count(parameter)=0]"
			[Register ("getCountry", "()Ljava/lang/String;", "GetGetCountryHandler")]
			get {
				if (id_getCountry == IntPtr.Zero)
					id_getCountry = JNIEnv.GetMethodID (class_ref, "getCountry", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCountry), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCountry", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCurrency;
#pragma warning disable 0169
		static Delegate GetGetCurrencyHandler ()
		{
			if (cb_getCurrency == null)
				cb_getCurrency = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrency);
			return cb_getCurrency;
		}

		static IntPtr n_GetCurrency (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Currency);
		}
#pragma warning restore 0169

		static IntPtr id_getCurrency;
		public virtual unsafe string Currency {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.BackOffice']/class[@name='Report']/method[@name='getCurrency' and count(parameter)=0]"
			[Register ("getCurrency", "()Ljava/lang/String;", "GetGetCurrencyHandler")]
			get {
				if (id_getCurrency == IntPtr.Zero)
					id_getCurrency = JNIEnv.GetMethodID (class_ref, "getCurrency", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrency), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrency", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Email);
		}
#pragma warning restore 0169

		static IntPtr id_getEmail;
		public virtual unsafe string Email {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.BackOffice']/class[@name='Report']/method[@name='getEmail' and count(parameter)=0]"
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

		static Delegate cb_getNMerchant;
#pragma warning disable 0169
		static Delegate GetGetNMerchantHandler ()
		{
			if (cb_getNMerchant == null)
				cb_getNMerchant = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNMerchant);
			return cb_getNMerchant;
		}

		static IntPtr n_GetNMerchant (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NMerchant);
		}
#pragma warning restore 0169

		static IntPtr id_getNMerchant;
		public virtual unsafe string NMerchant {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.BackOffice']/class[@name='Report']/method[@name='getNMerchant' and count(parameter)=0]"
			[Register ("getNMerchant", "()Ljava/lang/String;", "GetGetNMerchantHandler")]
			get {
				if (id_getNMerchant == IntPtr.Zero)
					id_getNMerchant = JNIEnv.GetMethodID (class_ref, "getNMerchant", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNMerchant), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNMerchant", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.BackOffice']/class[@name='Report']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOperationDate;
#pragma warning disable 0169
		static Delegate GetGetOperationDateHandler ()
		{
			if (cb_getOperationDate == null)
				cb_getOperationDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOperationDate);
			return cb_getOperationDate;
		}

		static IntPtr n_GetOperationDate (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OperationDate);
		}
#pragma warning restore 0169

		static IntPtr id_getOperationDate;
		public virtual unsafe string OperationDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.BackOffice']/class[@name='Report']/method[@name='getOperationDate' and count(parameter)=0]"
			[Register ("getOperationDate", "()Ljava/lang/String;", "GetGetOperationDateHandler")]
			get {
				if (id_getOperationDate == IntPtr.Zero)
					id_getOperationDate = JNIEnv.GetMethodID (class_ref, "getOperationDate", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOperationDate), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOperationDate", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOperationType;
#pragma warning disable 0169
		static Delegate GetGetOperationTypeHandler ()
		{
			if (cb_getOperationType == null)
				cb_getOperationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOperationType);
			return cb_getOperationType;
		}

		static IntPtr n_GetOperationType (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OperationType);
		}
#pragma warning restore 0169

		static IntPtr id_getOperationType;
		public virtual unsafe string OperationType {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.BackOffice']/class[@name='Report']/method[@name='getOperationType' and count(parameter)=0]"
			[Register ("getOperationType", "()Ljava/lang/String;", "GetGetOperationTypeHandler")]
			get {
				if (id_getOperationType == IntPtr.Zero)
					id_getOperationType = JNIEnv.GetMethodID (class_ref, "getOperationType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOperationType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOperationType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Pan);
		}
#pragma warning restore 0169

		static IntPtr id_getPan;
		public virtual unsafe string Pan {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.BackOffice']/class[@name='Report']/method[@name='getPan' and count(parameter)=0]"
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

		static Delegate cb_getParameters;
#pragma warning disable 0169
		static Delegate GetGetParametersHandler ()
		{
			if (cb_getParameters == null)
				cb_getParameters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParameters);
			return cb_getParameters;
		}

		static IntPtr n_GetParameters (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Parameters);
		}
#pragma warning restore 0169

		static IntPtr id_getParameters;
		public virtual unsafe string Parameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.BackOffice']/class[@name='Report']/method[@name='getParameters' and count(parameter)=0]"
			[Register ("getParameters", "()Ljava/lang/String;", "GetGetParametersHandler")]
			get {
				if (id_getParameters == IntPtr.Zero)
					id_getParameters = JNIEnv.GetMethodID (class_ref, "getParameters", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParameters), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParameters", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPaymentType;
#pragma warning disable 0169
		static Delegate GetGetPaymentTypeHandler ()
		{
			if (cb_getPaymentType == null)
				cb_getPaymentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPaymentType);
			return cb_getPaymentType;
		}

		static IntPtr n_GetPaymentType (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PaymentType);
		}
#pragma warning restore 0169

		static IntPtr id_getPaymentType;
		public virtual unsafe string PaymentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.BackOffice']/class[@name='Report']/method[@name='getPaymentType' and count(parameter)=0]"
			[Register ("getPaymentType", "()Ljava/lang/String;", "GetGetPaymentTypeHandler")]
			get {
				if (id_getPaymentType == IntPtr.Zero)
					id_getPaymentType = JNIEnv.GetMethodID (class_ref, "getPaymentType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPaymentType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPaymentType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getProductType;
#pragma warning disable 0169
		static Delegate GetGetProductTypeHandler ()
		{
			if (cb_getProductType == null)
				cb_getProductType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProductType);
			return cb_getProductType;
		}

		static IntPtr n_GetProductType (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProductType);
		}
#pragma warning restore 0169

		static IntPtr id_getProductType;
		public virtual unsafe string ProductType {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.BackOffice']/class[@name='Report']/method[@name='getProductType' and count(parameter)=0]"
			[Register ("getProductType", "()Ljava/lang/String;", "GetGetProductTypeHandler")]
			get {
				if (id_getProductType == IntPtr.Zero)
					id_getProductType = JNIEnv.GetMethodID (class_ref, "getProductType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProductType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProductType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getServiceType;
#pragma warning disable 0169
		static Delegate GetGetServiceTypeHandler ()
		{
			if (cb_getServiceType == null)
				cb_getServiceType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetServiceType);
			return cb_getServiceType;
		}

		static IntPtr n_GetServiceType (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServiceType);
		}
#pragma warning restore 0169

		static IntPtr id_getServiceType;
		public virtual unsafe string ServiceType {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.BackOffice']/class[@name='Report']/method[@name='getServiceType' and count(parameter)=0]"
			[Register ("getServiceType", "()Ljava/lang/String;", "GetGetServiceTypeHandler")]
			get {
				if (id_getServiceType == IntPtr.Zero)
					id_getServiceType = JNIEnv.GetMethodID (class_ref, "getServiceType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServiceType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getServiceType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStatus);
			return cb_getStatus;
		}

		static IntPtr n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Status);
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		public virtual unsafe string Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.BackOffice']/class[@name='Report']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()Ljava/lang/String;", "GetGetStatusHandler")]
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatus", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSurname;
#pragma warning disable 0169
		static Delegate GetGetSurnameHandler ()
		{
			if (cb_getSurname == null)
				cb_getSurname = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSurname);
			return cb_getSurname;
		}

		static IntPtr n_GetSurname (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Surname);
		}
#pragma warning restore 0169

		static IntPtr id_getSurname;
		public virtual unsafe string Surname {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.BackOffice']/class[@name='Report']/method[@name='getSurname' and count(parameter)=0]"
			[Register ("getSurname", "()Ljava/lang/String;", "GetGetSurnameHandler")]
			get {
				if (id_getSurname == IntPtr.Zero)
					id_getSurname = JNIEnv.GetMethodID (class_ref, "getSurname", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSurname), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSurname", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransactionDate);
		}
#pragma warning restore 0169

		static IntPtr id_getTransactionDate;
		public virtual unsafe string TransactionDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.BackOffice']/class[@name='Report']/method[@name='getTransactionDate' and count(parameter)=0]"
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

		static Delegate cb_getDetails;
#pragma warning disable 0169
		static Delegate GetGetDetailsHandler ()
		{
			if (cb_getDetails == null)
				cb_getDetails = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDetails);
			return cb_getDetails;
		}

		static IntPtr n_GetDetails (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDetails ());
		}
#pragma warning restore 0169

		static IntPtr id_getDetails;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.BackOffice']/class[@name='Report']/method[@name='getDetails' and count(parameter)=0]"
		[Register ("getDetails", "()[Lit/icbpi/XPaySDK/Models/WebApi/Responses/BackOffice/Detail;", "GetGetDetailsHandler")]
		public virtual unsafe global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Detail[] GetDetails ()
		{
			if (id_getDetails == IntPtr.Zero)
				id_getDetails = JNIEnv.GetMethodID (class_ref, "getDetails", "()[Lit/icbpi/XPaySDK/Models/WebApi/Responses/BackOffice/Detail;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Detail[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDetails), JniHandleOwnership.TransferLocalRef, typeof (global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Detail));
				else
					return (global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Detail[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDetails", "()[Lit/icbpi/XPaySDK/Models/WebApi/Responses/BackOffice/Detail;")), JniHandleOwnership.TransferLocalRef, typeof (global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.BackOffice.Detail));
			} finally {
			}
		}

	}
}
