using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Models.WebApi.Requests.BackOffice {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.BackOffice']/class[@name='ApiStornaRequest']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Models/WebApi/Requests/BackOffice/ApiStornaRequest", DoNotGenerateAcw=true)]
	public partial class ApiStornaRequest : global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.ApiBaseRequest {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Models/WebApi/Requests/BackOffice/ApiStornaRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApiStornaRequest); }
		}

		protected ApiStornaRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.BackOffice']/class[@name='ApiStornaRequest']/constructor[@name='ApiStornaRequest' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;II)V", "")]
		public unsafe ApiStornaRequest (string p0, string p1, int p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (ApiStornaRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;II)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_II == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_II, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getAmount;
#pragma warning disable 0169
		static Delegate GetGetAmountHandler ()
		{
			if (cb_getAmount == null)
				cb_getAmount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAmount);
			return cb_getAmount;
		}

		static int n_GetAmount (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.BackOffice.ApiStornaRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.BackOffice.ApiStornaRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Amount;
		}
#pragma warning restore 0169

		static IntPtr id_getAmount;
		public virtual unsafe int Amount {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.BackOffice']/class[@name='ApiStornaRequest']/method[@name='getAmount' and count(parameter)=0]"
			[Register ("getAmount", "()I", "GetGetAmountHandler")]
			get {
				if (id_getAmount == IntPtr.Zero)
					id_getAmount = JNIEnv.GetMethodID (class_ref, "getAmount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAmount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAmount", "()I"));
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.BackOffice.ApiStornaRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.BackOffice.ApiStornaRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CodTrans);
		}
#pragma warning restore 0169

		static IntPtr id_getCodTrans;
		public virtual unsafe string CodTrans {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.BackOffice']/class[@name='ApiStornaRequest']/method[@name='getCodTrans' and count(parameter)=0]"
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.BackOffice.ApiStornaRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.BackOffice.ApiStornaRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Currency;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrency;
		public virtual unsafe int Currency {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.BackOffice']/class[@name='ApiStornaRequest']/method[@name='getCurrency' and count(parameter)=0]"
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

	}
}
