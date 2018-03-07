using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Models.WebApi.Requests {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests']/class[@name='ApiBaseRequest']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Models/WebApi/Requests/ApiBaseRequest", DoNotGenerateAcw=true)]
	public abstract partial class ApiBaseRequest : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Models/WebApi/Requests/ApiBaseRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApiBaseRequest); }
		}

		protected ApiBaseRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests']/class[@name='ApiBaseRequest']/constructor[@name='ApiBaseRequest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		protected unsafe ApiBaseRequest (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (ApiBaseRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getAlias;
#pragma warning disable 0169
		static Delegate GetGetAliasHandler ()
		{
			if (cb_getAlias == null)
				cb_getAlias = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAlias);
			return cb_getAlias;
		}

		static IntPtr n_GetAlias (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.ApiBaseRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.ApiBaseRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Alias);
		}
#pragma warning restore 0169

		static IntPtr id_getAlias;
		public virtual unsafe string Alias {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests']/class[@name='ApiBaseRequest']/method[@name='getAlias' and count(parameter)=0]"
			[Register ("getAlias", "()Ljava/lang/String;", "GetGetAliasHandler")]
			get {
				if (id_getAlias == IntPtr.Zero)
					id_getAlias = JNIEnv.GetMethodID (class_ref, "getAlias", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAlias), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAlias", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCustomSerializer;
#pragma warning disable 0169
		static Delegate GetGetCustomSerializerHandler ()
		{
			if (cb_getCustomSerializer == null)
				cb_getCustomSerializer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomSerializer);
			return cb_getCustomSerializer;
		}

		static IntPtr n_GetCustomSerializer (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.ApiBaseRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.ApiBaseRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CustomSerializer);
		}
#pragma warning restore 0169

		static IntPtr id_getCustomSerializer;
		public virtual unsafe global::IT.Icbpi.XPaySDK.Utils.Serializers.SerializerEnum CustomSerializer {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests']/class[@name='ApiBaseRequest']/method[@name='getCustomSerializer' and count(parameter)=0]"
			[Register ("getCustomSerializer", "()Lit/icbpi/XPaySDK/Utils/Serializers/SerializerEnum;", "GetGetCustomSerializerHandler")]
			get {
				if (id_getCustomSerializer == IntPtr.Zero)
					id_getCustomSerializer = JNIEnv.GetMethodID (class_ref, "getCustomSerializer", "()Lit/icbpi/XPaySDK/Utils/Serializers/SerializerEnum;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.Serializers.SerializerEnum> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCustomSerializer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.Serializers.SerializerEnum> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCustomSerializer", "()Lit/icbpi/XPaySDK/Utils/Serializers/SerializerEnum;")), JniHandleOwnership.TransferLocalRef);
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.ApiBaseRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.ApiBaseRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.ExtraKeys);
		}
#pragma warning restore 0169

		static IntPtr id_getExtraKeys;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> ExtraKeys {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests']/class[@name='ApiBaseRequest']/method[@name='getExtraKeys' and count(parameter)=0]"
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.ApiBaseRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.ApiBaseRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Mac);
		}
#pragma warning restore 0169

		static Delegate cb_setMac_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMac_Ljava_lang_String_Handler ()
		{
			if (cb_setMac_Ljava_lang_String_ == null)
				cb_setMac_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMac_Ljava_lang_String_);
			return cb_setMac_Ljava_lang_String_;
		}

		static void n_SetMac_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.ApiBaseRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.ApiBaseRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Mac = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMac;
		static IntPtr id_setMac_Ljava_lang_String_;
		public virtual unsafe string Mac {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests']/class[@name='ApiBaseRequest']/method[@name='getMac' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests']/class[@name='ApiBaseRequest']/method[@name='setMac' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMac", "(Ljava/lang/String;)V", "GetSetMac_Ljava_lang_String_Handler")]
			set {
				if (id_setMac_Ljava_lang_String_ == IntPtr.Zero)
					id_setMac_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMac", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMac_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMac", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTimeStamp;
#pragma warning disable 0169
		static Delegate GetGetTimeStampHandler ()
		{
			if (cb_getTimeStamp == null)
				cb_getTimeStamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimeStamp);
			return cb_getTimeStamp;
		}

		static IntPtr n_GetTimeStamp (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.ApiBaseRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.ApiBaseRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TimeStamp);
		}
#pragma warning restore 0169

		static IntPtr id_getTimeStamp;
		public virtual unsafe string TimeStamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests']/class[@name='ApiBaseRequest']/method[@name='getTimeStamp' and count(parameter)=0]"
			[Register ("getTimeStamp", "()Ljava/lang/String;", "GetGetTimeStampHandler")]
			get {
				if (id_getTimeStamp == IntPtr.Zero)
					id_getTimeStamp = JNIEnv.GetMethodID (class_ref, "getTimeStamp", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTimeStamp), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeStamp", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.ApiBaseRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.ApiBaseRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddExtraKey (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addExtraKey_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests']/class[@name='ApiBaseRequest']/method[@name='addExtraKey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
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

	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Models/WebApi/Requests/ApiBaseRequest", DoNotGenerateAcw=true)]
	internal partial class ApiBaseRequestInvoker : ApiBaseRequest {

		public ApiBaseRequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApiBaseRequestInvoker); }
		}

	}

}
