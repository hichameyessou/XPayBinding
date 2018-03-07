using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice']/class[@name='ApiFrontOfficeXPRequest']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Models/WebApi/Requests/FrontOffice/ApiFrontOfficeXPRequest", DoNotGenerateAcw=true)]
	public partial class ApiFrontOfficeXPRequest : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Models/WebApi/Requests/FrontOffice/ApiFrontOfficeXPRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApiFrontOfficeXPRequest); }
		}

		protected ApiFrontOfficeXPRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice']/class[@name='ApiFrontOfficeXPRequest']/constructor[@name='ApiFrontOfficeXPRequest' and count(parameter)=12 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='long'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='java.lang.String'] and parameter[10][@type='java.lang.String'] and parameter[11][@type='java.lang.String'] and parameter[12][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe ApiFrontOfficeXPRequest (string p0, string p1, string p2, long p3, int p4, string p5, string p6, string p7, string p8, string p9, string p10, string p11)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			IntPtr native_p7 = JNIEnv.NewString (p7);
			IntPtr native_p8 = JNIEnv.NewString (p8);
			IntPtr native_p9 = JNIEnv.NewString (p9);
			IntPtr native_p10 = JNIEnv.NewString (p10);
			IntPtr native_p11 = JNIEnv.NewString (p11);
			try {
				JValue* __args = stackalloc JValue [12];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);
				__args [7] = new JValue (native_p7);
				__args [8] = new JValue (native_p8);
				__args [9] = new JValue (native_p9);
				__args [10] = new JValue (native_p10);
				__args [11] = new JValue (native_p11);
				if (((object) this).GetType () != typeof (ApiFrontOfficeXPRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
				JNIEnv.DeleteLocalRef (native_p7);
				JNIEnv.DeleteLocalRef (native_p8);
				JNIEnv.DeleteLocalRef (native_p9);
				JNIEnv.DeleteLocalRef (native_p10);
				JNIEnv.DeleteLocalRef (native_p11);
			}
		}

		static Delegate cb_getActionCode;
#pragma warning disable 0169
		static Delegate GetGetActionCodeHandler ()
		{
			if (cb_getActionCode == null)
				cb_getActionCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActionCode);
			return cb_getActionCode;
		}

		static IntPtr n_GetActionCode (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ActionCode);
		}
#pragma warning restore 0169

		static IntPtr id_getActionCode;
		public virtual unsafe string ActionCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice']/class[@name='ApiFrontOfficeXPRequest']/method[@name='getActionCode' and count(parameter)=0]"
			[Register ("getActionCode", "()Ljava/lang/String;", "GetGetActionCodeHandler")]
			get {
				if (id_getActionCode == IntPtr.Zero)
					id_getActionCode = JNIEnv.GetMethodID (class_ref, "getActionCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getActionCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActionCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Amount);
		}
#pragma warning restore 0169

		static IntPtr id_getAmount;
		public virtual unsafe string Amount {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice']/class[@name='ApiFrontOfficeXPRequest']/method[@name='getAmount' and count(parameter)=0]"
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

		static Delegate cb_getCoPlatform;
#pragma warning disable 0169
		static Delegate GetGetCoPlatformHandler ()
		{
			if (cb_getCoPlatform == null)
				cb_getCoPlatform = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCoPlatform);
			return cb_getCoPlatform;
		}

		static IntPtr n_GetCoPlatform (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CoPlatform);
		}
#pragma warning restore 0169

		static IntPtr id_getCoPlatform;
		public virtual unsafe string CoPlatform {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice']/class[@name='ApiFrontOfficeXPRequest']/method[@name='getCoPlatform' and count(parameter)=0]"
			[Register ("getCoPlatform", "()Ljava/lang/String;", "GetGetCoPlatformHandler")]
			get {
				if (id_getCoPlatform == IntPtr.Zero)
					id_getCoPlatform = JNIEnv.GetMethodID (class_ref, "getCoPlatform", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCoPlatform), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCoPlatform", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Currency;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrency;
		public virtual unsafe int Currency {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice']/class[@name='ApiFrontOfficeXPRequest']/method[@name='getCurrency' and count(parameter)=0]"
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Email);
		}
#pragma warning restore 0169

		static IntPtr id_getEmail;
		public virtual unsafe string Email {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice']/class[@name='ApiFrontOfficeXPRequest']/method[@name='getEmail' and count(parameter)=0]"
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

		static Delegate cb_getExtraKeys;
#pragma warning disable 0169
		static Delegate GetGetExtraKeysHandler ()
		{
			if (cb_getExtraKeys == null)
				cb_getExtraKeys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtraKeys);
			return cb_getExtraKeys;
		}

		static IntPtr n_GetExtraKeys (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.ExtraKeys);
		}
#pragma warning restore 0169

		static IntPtr id_getExtraKeys;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> ExtraKeys {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice']/class[@name='ApiFrontOfficeXPRequest']/method[@name='getExtraKeys' and count(parameter)=0]"
			[Register ("getExtraKeys", "()Ljava/util/HashMap;", "GetGetExtraKeysHandler")]
			get {
				if (id_getExtraKeys == IntPtr.Zero)
					id_getExtraKeys = JNIEnv.GetMethodID (class_ref, "getExtraKeys", "()Ljava/util/HashMap;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExtraKeys), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExtraKeys", "()Ljava/util/HashMap;")), JniHandleOwnership.TransferLocalRef);
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Language);
		}
#pragma warning restore 0169

		static IntPtr id_getLanguage;
		public virtual unsafe string Language {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice']/class[@name='ApiFrontOfficeXPRequest']/method[@name='getLanguage' and count(parameter)=0]"
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

		static Delegate cb_getMac;
#pragma warning disable 0169
		static Delegate GetGetMacHandler ()
		{
			if (cb_getMac == null)
				cb_getMac = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMac);
			return cb_getMac;
		}

		static IntPtr n_GetMac (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Mac);
		}
#pragma warning restore 0169

		static IntPtr id_getMac;
		public virtual unsafe string Mac {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice']/class[@name='ApiFrontOfficeXPRequest']/method[@name='getMac' and count(parameter)=0]"
			[Register ("getMac", "()Ljava/lang/String;", "GetGetMacHandler")]
			get {
				if (id_getMac == IntPtr.Zero)
					id_getMac = JNIEnv.GetMethodID (class_ref, "getMac", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMac), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMac", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMsgType;
#pragma warning disable 0169
		static Delegate GetGetMsgTypeHandler ()
		{
			if (cb_getMsgType == null)
				cb_getMsgType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMsgType);
			return cb_getMsgType;
		}

		static IntPtr n_GetMsgType (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MsgType);
		}
#pragma warning restore 0169

		static IntPtr id_getMsgType;
		public virtual unsafe string MsgType {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice']/class[@name='ApiFrontOfficeXPRequest']/method[@name='getMsgType' and count(parameter)=0]"
			[Register ("getMsgType", "()Ljava/lang/String;", "GetGetMsgTypeHandler")]
			get {
				if (id_getMsgType == IntPtr.Zero)
					id_getMsgType = JNIEnv.GetMethodID (class_ref, "getMsgType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMsgType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMsgType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isNaviagationEnabled;
#pragma warning disable 0169
		static Delegate GetIsNaviagationEnabledHandler ()
		{
			if (cb_isNaviagationEnabled == null)
				cb_isNaviagationEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNaviagationEnabled);
			return cb_isNaviagationEnabled;
		}

		static bool n_IsNaviagationEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NaviagationEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setNaviagationEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetNaviagationEnabled_ZHandler ()
		{
			if (cb_setNaviagationEnabled_Z == null)
				cb_setNaviagationEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetNaviagationEnabled_Z);
			return cb_setNaviagationEnabled_Z;
		}

		static void n_SetNaviagationEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NaviagationEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isNaviagationEnabled;
		static IntPtr id_setNaviagationEnabled_Z;
		public virtual unsafe bool NaviagationEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice']/class[@name='ApiFrontOfficeXPRequest']/method[@name='isNaviagationEnabled' and count(parameter)=0]"
			[Register ("isNaviagationEnabled", "()Z", "GetIsNaviagationEnabledHandler")]
			get {
				if (id_isNaviagationEnabled == IntPtr.Zero)
					id_isNaviagationEnabled = JNIEnv.GetMethodID (class_ref, "isNaviagationEnabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isNaviagationEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isNaviagationEnabled", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice']/class[@name='ApiFrontOfficeXPRequest']/method[@name='setNaviagationEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setNaviagationEnabled", "(Z)V", "GetSetNaviagationEnabled_ZHandler")]
			set {
				if (id_setNaviagationEnabled_Z == IntPtr.Zero)
					id_setNaviagationEnabled_Z = JNIEnv.GetMethodID (class_ref, "setNaviagationEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNaviagationEnabled_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNaviagationEnabled", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNotificationUrl;
#pragma warning disable 0169
		static Delegate GetGetNotificationUrlHandler ()
		{
			if (cb_getNotificationUrl == null)
				cb_getNotificationUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNotificationUrl);
			return cb_getNotificationUrl;
		}

		static IntPtr n_GetNotificationUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NotificationUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getNotificationUrl;
		public virtual unsafe string NotificationUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice']/class[@name='ApiFrontOfficeXPRequest']/method[@name='getNotificationUrl' and count(parameter)=0]"
			[Register ("getNotificationUrl", "()Ljava/lang/String;", "GetGetNotificationUrlHandler")]
			get {
				if (id_getNotificationUrl == IntPtr.Zero)
					id_getNotificationUrl = JNIEnv.GetMethodID (class_ref, "getNotificationUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNotificationUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNotificationUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOrderDesc;
#pragma warning disable 0169
		static Delegate GetGetOrderDescHandler ()
		{
			if (cb_getOrderDesc == null)
				cb_getOrderDesc = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOrderDesc);
			return cb_getOrderDesc;
		}

		static IntPtr n_GetOrderDesc (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OrderDesc);
		}
#pragma warning restore 0169

		static IntPtr id_getOrderDesc;
		public virtual unsafe string OrderDesc {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice']/class[@name='ApiFrontOfficeXPRequest']/method[@name='getOrderDesc' and count(parameter)=0]"
			[Register ("getOrderDesc", "()Ljava/lang/String;", "GetGetOrderDescHandler")]
			get {
				if (id_getOrderDesc == IntPtr.Zero)
					id_getOrderDesc = JNIEnv.GetMethodID (class_ref, "getOrderDesc", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOrderDesc), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOrderDesc", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TerminalId);
		}
#pragma warning restore 0169

		static IntPtr id_getTerminalId;
		public virtual unsafe string TerminalId {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice']/class[@name='ApiFrontOfficeXPRequest']/method[@name='getTerminalId' and count(parameter)=0]"
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

		static Delegate cb_getTransId;
#pragma warning disable 0169
		static Delegate GetGetTransIdHandler ()
		{
			if (cb_getTransId == null)
				cb_getTransId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransId);
			return cb_getTransId;
		}

		static IntPtr n_GetTransId (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransId);
		}
#pragma warning restore 0169

		static IntPtr id_getTransId;
		public virtual unsafe string TransId {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice']/class[@name='ApiFrontOfficeXPRequest']/method[@name='getTransId' and count(parameter)=0]"
			[Register ("getTransId", "()Ljava/lang/String;", "GetGetTransIdHandler")]
			get {
				if (id_getTransId == IntPtr.Zero)
					id_getTransId = JNIEnv.GetMethodID (class_ref, "getTransId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTransId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVersCode;
#pragma warning disable 0169
		static Delegate GetGetVersCodeHandler ()
		{
			if (cb_getVersCode == null)
				cb_getVersCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVersCode);
			return cb_getVersCode;
		}

		static IntPtr n_GetVersCode (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VersCode);
		}
#pragma warning restore 0169

		static IntPtr id_getVersCode;
		public virtual unsafe string VersCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice']/class[@name='ApiFrontOfficeXPRequest']/method[@name='getVersCode' and count(parameter)=0]"
			[Register ("getVersCode", "()Ljava/lang/String;", "GetGetVersCodeHandler")]
			get {
				if (id_getVersCode == IntPtr.Zero)
					id_getVersCode = JNIEnv.GetMethodID (class_ref, "getVersCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVersCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVersCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addExtraKey_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddExtraKey_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addExtraKey_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addExtraKey_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddExtraKey_Ljava_lang_String_Ljava_lang_String_);
			return cb_addExtraKey_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddExtraKey_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddExtraKey (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addExtraKey_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice']/class[@name='ApiFrontOfficeXPRequest']/method[@name='addExtraKey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addExtraKey", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddExtraKey_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void AddExtraKey (string p0, string p1)
		{
			if (id_addExtraKey_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addExtraKey_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addExtraKey", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addExtraKey_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addExtraKey", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
