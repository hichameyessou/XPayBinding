using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice']/class[@name='ApiFrontOfficeXPResponse']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Models/WebApi/Responses/FrontOffice/ApiFrontOfficeXPResponse", DoNotGenerateAcw=true)]
	public partial class ApiFrontOfficeXPResponse : global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeBaseResponse {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Models/WebApi/Responses/FrontOffice/ApiFrontOfficeXPResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApiFrontOfficeXPResponse); }
		}

		protected ApiFrontOfficeXPResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAmount;
#pragma warning disable 0169
		static Delegate GetGetAmountHandler ()
		{
			if (cb_getAmount == null)
				cb_getAmount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAmount);
			return cb_getAmount;
		}

		static IntPtr n_GetAmount (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Amount);
		}
#pragma warning restore 0169

		static IntPtr id_getAmount;
		public virtual unsafe string Amount {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice']/class[@name='ApiFrontOfficeXPResponse']/method[@name='getAmount' and count(parameter)=0]"
			[Register ("getAmount", "()Ljava/lang/String;", "GetGetAmountHandler")]
			get {
				if (id_getAmount == IntPtr.Zero)
					id_getAmount = JNIEnv.GetMethodID (class_ref, "getAmount", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAmount), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAmount", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthCode);
		}
#pragma warning restore 0169

		static IntPtr id_getAuthCode;
		public virtual unsafe string AuthCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice']/class[@name='ApiFrontOfficeXPResponse']/method[@name='getAuthCode' and count(parameter)=0]"
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

		static Delegate cb_getCardType;
#pragma warning disable 0169
		static Delegate GetGetCardTypeHandler ()
		{
			if (cb_getCardType == null)
				cb_getCardType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCardType);
			return cb_getCardType;
		}

		static IntPtr n_GetCardType (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CardType);
		}
#pragma warning restore 0169

		static IntPtr id_getCardType;
		public virtual unsafe string CardType {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice']/class[@name='ApiFrontOfficeXPResponse']/method[@name='getCardType' and count(parameter)=0]"
			[Register ("getCardType", "()Ljava/lang/String;", "GetGetCardTypeHandler")]
			get {
				if (id_getCardType == IntPtr.Zero)
					id_getCardType = JNIEnv.GetMethodID (class_ref, "getCardType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCardType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCardType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Country);
		}
#pragma warning restore 0169

		static IntPtr id_getCountry;
		public virtual unsafe string Country {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice']/class[@name='ApiFrontOfficeXPResponse']/method[@name='getCountry' and count(parameter)=0]"
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
				cb_getCurrency = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrency);
			return cb_getCurrency;
		}

		static int n_GetCurrency (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Currency;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrency;
		public virtual unsafe int Currency {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice']/class[@name='ApiFrontOfficeXPResponse']/method[@name='getCurrency' and count(parameter)=0]"
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Email);
		}
#pragma warning restore 0169

		static IntPtr id_getEmail;
		public virtual unsafe string Email {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice']/class[@name='ApiFrontOfficeXPResponse']/method[@name='getEmail' and count(parameter)=0]"
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

		static Delegate cb_getExtraParameters;
#pragma warning disable 0169
		static Delegate GetGetExtraParametersHandler ()
		{
			if (cb_getExtraParameters == null)
				cb_getExtraParameters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtraParameters);
			return cb_getExtraParameters;
		}

		static IntPtr n_GetExtraParameters (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.ExtraParameters);
		}
#pragma warning restore 0169

		static IntPtr id_getExtraParameters;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> ExtraParameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice']/class[@name='ApiFrontOfficeXPResponse']/method[@name='getExtraParameters' and count(parameter)=0]"
			[Register ("getExtraParameters", "()Ljava/util/HashMap;", "GetGetExtraParametersHandler")]
			get {
				if (id_getExtraParameters == IntPtr.Zero)
					id_getExtraParameters = JNIEnv.GetMethodID (class_ref, "getExtraParameters", "()Ljava/util/HashMap;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExtraParameters), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExtraParameters", "()Ljava/util/HashMap;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLanguage;
#pragma warning disable 0169
		static Delegate GetGetLanguageHandler ()
		{
			if (cb_getLanguage == null)
				cb_getLanguage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLanguage);
			return cb_getLanguage;
		}

		static IntPtr n_GetLanguage (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Language);
		}
#pragma warning restore 0169

		static IntPtr id_getLanguage;
		public virtual unsafe string Language {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice']/class[@name='ApiFrontOfficeXPResponse']/method[@name='getLanguage' and count(parameter)=0]"
			[Register ("getLanguage", "()Ljava/lang/String;", "GetGetLanguageHandler")]
			get {
				if (id_getLanguage == IntPtr.Zero)
					id_getLanguage = JNIEnv.GetMethodID (class_ref, "getLanguage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLanguage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLanguage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLiabilityShift;
#pragma warning disable 0169
		static Delegate GetGetLiabilityShiftHandler ()
		{
			if (cb_getLiabilityShift == null)
				cb_getLiabilityShift = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLiabilityShift);
			return cb_getLiabilityShift;
		}

		static IntPtr n_GetLiabilityShift (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LiabilityShift);
		}
#pragma warning restore 0169

		static IntPtr id_getLiabilityShift;
		public virtual unsafe string LiabilityShift {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice']/class[@name='ApiFrontOfficeXPResponse']/method[@name='getLiabilityShift' and count(parameter)=0]"
			[Register ("getLiabilityShift", "()Ljava/lang/String;", "GetGetLiabilityShiftHandler")]
			get {
				if (id_getLiabilityShift == IntPtr.Zero)
					id_getLiabilityShift = JNIEnv.GetMethodID (class_ref, "getLiabilityShift", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLiabilityShift), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLiabilityShift", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMerchantNumber;
#pragma warning disable 0169
		static Delegate GetGetMerchantNumberHandler ()
		{
			if (cb_getMerchantNumber == null)
				cb_getMerchantNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMerchantNumber);
			return cb_getMerchantNumber;
		}

		static IntPtr n_GetMerchantNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MerchantNumber);
		}
#pragma warning restore 0169

		static IntPtr id_getMerchantNumber;
		public virtual unsafe string MerchantNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice']/class[@name='ApiFrontOfficeXPResponse']/method[@name='getMerchantNumber' and count(parameter)=0]"
			[Register ("getMerchantNumber", "()Ljava/lang/String;", "GetGetMerchantNumberHandler")]
			get {
				if (id_getMerchantNumber == IntPtr.Zero)
					id_getMerchantNumber = JNIEnv.GetMethodID (class_ref, "getMerchantNumber", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMerchantNumber), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMerchantNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNumericAmount;
#pragma warning disable 0169
		static Delegate GetGetNumericAmountHandler ()
		{
			if (cb_getNumericAmount == null)
				cb_getNumericAmount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetNumericAmount);
			return cb_getNumericAmount;
		}

		static long n_GetNumericAmount (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumericAmount;
		}
#pragma warning restore 0169

		static IntPtr id_getNumericAmount;
		public virtual unsafe long NumericAmount {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice']/class[@name='ApiFrontOfficeXPResponse']/method[@name='getNumericAmount' and count(parameter)=0]"
			[Register ("getNumericAmount", "()J", "GetGetNumericAmountHandler")]
			get {
				if (id_getNumericAmount == IntPtr.Zero)
					id_getNumericAmount = JNIEnv.GetMethodID (class_ref, "getNumericAmount", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getNumericAmount);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumericAmount", "()J"));
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProductType);
		}
#pragma warning restore 0169

		static IntPtr id_getProductType;
		public virtual unsafe string ProductType {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice']/class[@name='ApiFrontOfficeXPResponse']/method[@name='getProductType' and count(parameter)=0]"
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

		static Delegate cb_getRegion;
#pragma warning disable 0169
		static Delegate GetGetRegionHandler ()
		{
			if (cb_getRegion == null)
				cb_getRegion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRegion);
			return cb_getRegion;
		}

		static IntPtr n_GetRegion (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Region);
		}
#pragma warning restore 0169

		static IntPtr id_getRegion;
		public virtual unsafe string Region {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice']/class[@name='ApiFrontOfficeXPResponse']/method[@name='getRegion' and count(parameter)=0]"
			[Register ("getRegion", "()Ljava/lang/String;", "GetGetRegionHandler")]
			get {
				if (id_getRegion == IntPtr.Zero)
					id_getRegion = JNIEnv.GetMethodID (class_ref, "getRegion", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRegion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRegion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResponse;
#pragma warning disable 0169
		static Delegate GetGetResponseHandler ()
		{
			if (cb_getResponse == null)
				cb_getResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponse);
			return cb_getResponse;
		}

		static IntPtr n_GetResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Response);
		}
#pragma warning restore 0169

		static IntPtr id_getResponse;
		public virtual unsafe string Response {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice']/class[@name='ApiFrontOfficeXPResponse']/method[@name='getResponse' and count(parameter)=0]"
			[Register ("getResponse", "()Ljava/lang/String;", "GetGetResponseHandler")]
			get {
				if (id_getResponse == IntPtr.Zero)
					id_getResponse = JNIEnv.GetMethodID (class_ref, "getResponse", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponse), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponse", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTerminalId;
#pragma warning disable 0169
		static Delegate GetGetTerminalIdHandler ()
		{
			if (cb_getTerminalId == null)
				cb_getTerminalId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTerminalId);
			return cb_getTerminalId;
		}

		static IntPtr n_GetTerminalId (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TerminalId);
		}
#pragma warning restore 0169

		static IntPtr id_getTerminalId;
		public virtual unsafe string TerminalId {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice']/class[@name='ApiFrontOfficeXPResponse']/method[@name='getTerminalId' and count(parameter)=0]"
			[Register ("getTerminalId", "()Ljava/lang/String;", "GetGetTerminalIdHandler")]
			get {
				if (id_getTerminalId == IntPtr.Zero)
					id_getTerminalId = JNIEnv.GetMethodID (class_ref, "getTerminalId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTerminalId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTerminalId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TransactionDate);
		}
#pragma warning restore 0169

		static IntPtr id_getTransactionDate;
		public virtual unsafe global::Java.Util.Date TransactionDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice']/class[@name='ApiFrontOfficeXPResponse']/method[@name='getTransactionDate' and count(parameter)=0]"
			[Register ("getTransactionDate", "()Ljava/util/Date;", "GetGetTransactionDateHandler")]
			get {
				if (id_getTransactionDate == IntPtr.Zero)
					id_getTransactionDate = JNIEnv.GetMethodID (class_ref, "getTransactionDate", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTransactionDate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransactionDate", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTransactionId;
#pragma warning disable 0169
		static Delegate GetGetTransactionIdHandler ()
		{
			if (cb_getTransactionId == null)
				cb_getTransactionId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransactionId);
			return cb_getTransactionId;
		}

		static IntPtr n_GetTransactionId (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransactionId);
		}
#pragma warning restore 0169

		static IntPtr id_getTransactionId;
		public virtual unsafe string TransactionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice']/class[@name='ApiFrontOfficeXPResponse']/method[@name='getTransactionId' and count(parameter)=0]"
			[Register ("getTransactionId", "()Ljava/lang/String;", "GetGetTransactionIdHandler")]
			get {
				if (id_getTransactionId == IntPtr.Zero)
					id_getTransactionId = JNIEnv.GetMethodID (class_ref, "getTransactionId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTransactionId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransactionId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTransactionType;
#pragma warning disable 0169
		static Delegate GetGetTransactionTypeHandler ()
		{
			if (cb_getTransactionType == null)
				cb_getTransactionType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransactionType);
			return cb_getTransactionType;
		}

		static IntPtr n_GetTransactionType (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeXPResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransactionType);
		}
#pragma warning restore 0169

		static IntPtr id_getTransactionType;
		public virtual unsafe string TransactionType {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice']/class[@name='ApiFrontOfficeXPResponse']/method[@name='getTransactionType' and count(parameter)=0]"
			[Register ("getTransactionType", "()Ljava/lang/String;", "GetGetTransactionTypeHandler")]
			get {
				if (id_getTransactionType == IntPtr.Zero)
					id_getTransactionType = JNIEnv.GetMethodID (class_ref, "getTransactionType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTransactionType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransactionType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
