using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring']/class[@name='ApiPrimoPagamentoMOTOResponse']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Models/WebApi/Responses/PrimiPagamentiRecurring/ApiPrimoPagamentoMOTOResponse", DoNotGenerateAcw=true)]
	public partial class ApiPrimoPagamentoMOTOResponse : global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ApiBaseResponse {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Models/WebApi/Responses/PrimiPagamentiRecurring/ApiPrimoPagamentoMOTOResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApiPrimoPagamentoMOTOResponse); }
		}

		protected ApiPrimoPagamentoMOTOResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring']/class[@name='ApiPrimoPagamentoMOTOResponse']/constructor[@name='ApiPrimoPagamentoMOTOResponse' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe ApiPrimoPagamentoMOTOResponse (string p0, string p1, string p2, string p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				if (((object) this).GetType () != typeof (ApiPrimoPagamentoMOTOResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTOResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTOResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthCode);
		}
#pragma warning restore 0169

		static IntPtr id_getAuthCode;
		public virtual unsafe string AuthCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring']/class[@name='ApiPrimoPagamentoMOTOResponse']/method[@name='getAuthCode' and count(parameter)=0]"
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTOResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTOResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Brand);
		}
#pragma warning restore 0169

		static IntPtr id_getBrand;
		public virtual unsafe string Brand {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring']/class[@name='ApiPrimoPagamentoMOTOResponse']/method[@name='getBrand' and count(parameter)=0]"
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

		static Delegate cb_getConvCode;
#pragma warning disable 0169
		static Delegate GetGetConvCodeHandler ()
		{
			if (cb_getConvCode == null)
				cb_getConvCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConvCode);
			return cb_getConvCode;
		}

		static IntPtr n_GetConvCode (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTOResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTOResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConvCode);
		}
#pragma warning restore 0169

		static IntPtr id_getConvCode;
		public virtual unsafe string ConvCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring']/class[@name='ApiPrimoPagamentoMOTOResponse']/method[@name='getConvCode' and count(parameter)=0]"
			[Register ("getConvCode", "()Ljava/lang/String;", "GetGetConvCodeHandler")]
			get {
				if (id_getConvCode == IntPtr.Zero)
					id_getConvCode = JNIEnv.GetMethodID (class_ref, "getConvCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConvCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConvCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTOResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTOResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Country);
		}
#pragma warning restore 0169

		static IntPtr id_getCountry;
		public virtual unsafe string Country {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring']/class[@name='ApiPrimoPagamentoMOTOResponse']/method[@name='getCountry' and count(parameter)=0]"
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

		static Delegate cb_getDate;
#pragma warning disable 0169
		static Delegate GetGetDateHandler ()
		{
			if (cb_getDate == null)
				cb_getDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDate);
			return cb_getDate;
		}

		static IntPtr n_GetDate (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTOResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTOResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Date);
		}
#pragma warning restore 0169

		static IntPtr id_getDate;
		public virtual unsafe string Date {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring']/class[@name='ApiPrimoPagamentoMOTOResponse']/method[@name='getDate' and count(parameter)=0]"
			[Register ("getDate", "()Ljava/lang/String;", "GetGetDateHandler")]
			get {
				if (id_getDate == IntPtr.Zero)
					id_getDate = JNIEnv.GetMethodID (class_ref, "getDate", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDate), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDate", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPpo;
#pragma warning disable 0169
		static Delegate GetGetPpoHandler ()
		{
			if (cb_getPpo == null)
				cb_getPpo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPpo);
			return cb_getPpo;
		}

		static IntPtr n_GetPpo (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTOResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTOResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Ppo);
		}
#pragma warning restore 0169

		static IntPtr id_getPpo;
		public virtual unsafe string Ppo {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring']/class[@name='ApiPrimoPagamentoMOTOResponse']/method[@name='getPpo' and count(parameter)=0]"
			[Register ("getPpo", "()Ljava/lang/String;", "GetGetPpoHandler")]
			get {
				if (id_getPpo == IntPtr.Zero)
					id_getPpo = JNIEnv.GetMethodID (class_ref, "getPpo", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPpo), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPpo", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTOResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTOResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProductType);
		}
#pragma warning restore 0169

		static IntPtr id_getProductType;
		public virtual unsafe string ProductType {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring']/class[@name='ApiPrimoPagamentoMOTOResponse']/method[@name='getProductType' and count(parameter)=0]"
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTOResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTOResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Region);
		}
#pragma warning restore 0169

		static IntPtr id_getRegion;
		public virtual unsafe string Region {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring']/class[@name='ApiPrimoPagamentoMOTOResponse']/method[@name='getRegion' and count(parameter)=0]"
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

		static Delegate cb_getTime;
#pragma warning disable 0169
		static Delegate GetGetTimeHandler ()
		{
			if (cb_getTime == null)
				cb_getTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTime);
			return cb_getTime;
		}

		static IntPtr n_GetTime (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTOResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTOResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Time);
		}
#pragma warning restore 0169

		static IntPtr id_getTime;
		public virtual unsafe string Time {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring']/class[@name='ApiPrimoPagamentoMOTOResponse']/method[@name='getTime' and count(parameter)=0]"
			[Register ("getTime", "()Ljava/lang/String;", "GetGetTimeHandler")]
			get {
				if (id_getTime == IntPtr.Zero)
					id_getTime = JNIEnv.GetMethodID (class_ref, "getTime", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTime), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTime", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTOResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring.ApiPrimoPagamentoMOTOResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransactionType);
		}
#pragma warning restore 0169

		static IntPtr id_getTransactionType;
		public virtual unsafe string TransactionType {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.PrimiPagamentiRecurring']/class[@name='ApiPrimoPagamentoMOTOResponse']/method[@name='getTransactionType' and count(parameter)=0]"
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
