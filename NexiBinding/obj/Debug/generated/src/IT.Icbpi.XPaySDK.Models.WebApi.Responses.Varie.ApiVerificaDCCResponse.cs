using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Models.WebApi.Responses.Varie {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.Varie']/class[@name='ApiVerificaDCCResponse']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Models/WebApi/Responses/Varie/ApiVerificaDCCResponse", DoNotGenerateAcw=true)]
	public partial class ApiVerificaDCCResponse : global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ApiBaseResponse {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Models/WebApi/Responses/Varie/ApiVerificaDCCResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApiVerificaDCCResponse); }
		}

		protected ApiVerificaDCCResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.Varie']/class[@name='ApiVerificaDCCResponse']/constructor[@name='ApiVerificaDCCResponse' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe ApiVerificaDCCResponse (string p0, string p1, string p2, string p3)
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
				if (((object) this).GetType () != typeof (ApiVerificaDCCResponse)) {
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

		static Delegate cb_getDCCamount;
#pragma warning disable 0169
		static Delegate GetGetDCCamountHandler ()
		{
			if (cb_getDCCamount == null)
				cb_getDCCamount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDCCamount);
			return cb_getDCCamount;
		}

		static long n_GetDCCamount (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.Varie.ApiVerificaDCCResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.Varie.ApiVerificaDCCResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DCCamount;
		}
#pragma warning restore 0169

		static IntPtr id_getDCCamount;
		public virtual unsafe long DCCamount {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.Varie']/class[@name='ApiVerificaDCCResponse']/method[@name='getDCCamount' and count(parameter)=0]"
			[Register ("getDCCamount", "()J", "GetGetDCCamountHandler")]
			get {
				if (id_getDCCamount == IntPtr.Zero)
					id_getDCCamount = JNIEnv.GetMethodID (class_ref, "getDCCamount", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDCCamount);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDCCamount", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getDCCcurrency;
#pragma warning disable 0169
		static Delegate GetGetDCCcurrencyHandler ()
		{
			if (cb_getDCCcurrency == null)
				cb_getDCCcurrency = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDCCcurrency);
			return cb_getDCCcurrency;
		}

		static int n_GetDCCcurrency (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.Varie.ApiVerificaDCCResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.Varie.ApiVerificaDCCResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DCCcurrency;
		}
#pragma warning restore 0169

		static IntPtr id_getDCCcurrency;
		public virtual unsafe int DCCcurrency {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.Varie']/class[@name='ApiVerificaDCCResponse']/method[@name='getDCCcurrency' and count(parameter)=0]"
			[Register ("getDCCcurrency", "()I", "GetGetDCCcurrencyHandler")]
			get {
				if (id_getDCCcurrency == IntPtr.Zero)
					id_getDCCcurrency = JNIEnv.GetMethodID (class_ref, "getDCCcurrency", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDCCcurrency);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDCCcurrency", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getDCCdecimalAmount;
#pragma warning disable 0169
		static Delegate GetGetDCCdecimalAmountHandler ()
		{
			if (cb_getDCCdecimalAmount == null)
				cb_getDCCdecimalAmount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDCCdecimalAmount);
			return cb_getDCCdecimalAmount;
		}

		static long n_GetDCCdecimalAmount (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.Varie.ApiVerificaDCCResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.Varie.ApiVerificaDCCResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DCCdecimalAmount;
		}
#pragma warning restore 0169

		static IntPtr id_getDCCdecimalAmount;
		public virtual unsafe long DCCdecimalAmount {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.Varie']/class[@name='ApiVerificaDCCResponse']/method[@name='getDCCdecimalAmount' and count(parameter)=0]"
			[Register ("getDCCdecimalAmount", "()J", "GetGetDCCdecimalAmountHandler")]
			get {
				if (id_getDCCdecimalAmount == IntPtr.Zero)
					id_getDCCdecimalAmount = JNIEnv.GetMethodID (class_ref, "getDCCdecimalAmount", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDCCdecimalAmount);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDCCdecimalAmount", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getDecimalMarkUp;
#pragma warning disable 0169
		static Delegate GetGetDecimalMarkUpHandler ()
		{
			if (cb_getDecimalMarkUp == null)
				cb_getDecimalMarkUp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDecimalMarkUp);
			return cb_getDecimalMarkUp;
		}

		static IntPtr n_GetDecimalMarkUp (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.Varie.ApiVerificaDCCResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.Varie.ApiVerificaDCCResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DecimalMarkUp);
		}
#pragma warning restore 0169

		static IntPtr id_getDecimalMarkUp;
		public virtual unsafe string DecimalMarkUp {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.Varie']/class[@name='ApiVerificaDCCResponse']/method[@name='getDecimalMarkUp' and count(parameter)=0]"
			[Register ("getDecimalMarkUp", "()Ljava/lang/String;", "GetGetDecimalMarkUpHandler")]
			get {
				if (id_getDecimalMarkUp == IntPtr.Zero)
					id_getDecimalMarkUp = JNIEnv.GetMethodID (class_ref, "getDecimalMarkUp", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDecimalMarkUp), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDecimalMarkUp", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExchangeRate;
#pragma warning disable 0169
		static Delegate GetGetExchangeRateHandler ()
		{
			if (cb_getExchangeRate == null)
				cb_getExchangeRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExchangeRate);
			return cb_getExchangeRate;
		}

		static IntPtr n_GetExchangeRate (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.Varie.ApiVerificaDCCResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.Varie.ApiVerificaDCCResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExchangeRate);
		}
#pragma warning restore 0169

		static IntPtr id_getExchangeRate;
		public virtual unsafe string ExchangeRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.Varie']/class[@name='ApiVerificaDCCResponse']/method[@name='getExchangeRate' and count(parameter)=0]"
			[Register ("getExchangeRate", "()Ljava/lang/String;", "GetGetExchangeRateHandler")]
			get {
				if (id_getExchangeRate == IntPtr.Zero)
					id_getExchangeRate = JNIEnv.GetMethodID (class_ref, "getExchangeRate", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExchangeRate), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExchangeRate", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExchangeRateExpires;
#pragma warning disable 0169
		static Delegate GetGetExchangeRateExpiresHandler ()
		{
			if (cb_getExchangeRateExpires == null)
				cb_getExchangeRateExpires = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExchangeRateExpires);
			return cb_getExchangeRateExpires;
		}

		static IntPtr n_GetExchangeRateExpires (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.Varie.ApiVerificaDCCResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.Varie.ApiVerificaDCCResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExchangeRateExpires);
		}
#pragma warning restore 0169

		static IntPtr id_getExchangeRateExpires;
		public virtual unsafe global::Java.Util.Date ExchangeRateExpires {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.Varie']/class[@name='ApiVerificaDCCResponse']/method[@name='getExchangeRateExpires' and count(parameter)=0]"
			[Register ("getExchangeRateExpires", "()Ljava/util/Date;", "GetGetExchangeRateExpiresHandler")]
			get {
				if (id_getExchangeRateExpires == IntPtr.Zero)
					id_getExchangeRateExpires = JNIEnv.GetMethodID (class_ref, "getExchangeRateExpires", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExchangeRateExpires), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExchangeRateExpires", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMarkUp;
#pragma warning disable 0169
		static Delegate GetGetMarkUpHandler ()
		{
			if (cb_getMarkUp == null)
				cb_getMarkUp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMarkUp);
			return cb_getMarkUp;
		}

		static IntPtr n_GetMarkUp (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.Varie.ApiVerificaDCCResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.Varie.ApiVerificaDCCResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MarkUp);
		}
#pragma warning restore 0169

		static IntPtr id_getMarkUp;
		public virtual unsafe string MarkUp {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.Varie']/class[@name='ApiVerificaDCCResponse']/method[@name='getMarkUp' and count(parameter)=0]"
			[Register ("getMarkUp", "()Ljava/lang/String;", "GetGetMarkUpHandler")]
			get {
				if (id_getMarkUp == IntPtr.Zero)
					id_getMarkUp = JNIEnv.GetMethodID (class_ref, "getMarkUp", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMarkUp), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMarkUp", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.Varie.ApiVerificaDCCResponse __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.Varie.ApiVerificaDCCResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Ticket);
		}
#pragma warning restore 0169

		static IntPtr id_getTicket;
		public virtual unsafe string Ticket {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.Varie']/class[@name='ApiVerificaDCCResponse']/method[@name='getTicket' and count(parameter)=0]"
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
