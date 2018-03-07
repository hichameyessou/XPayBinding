using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Models.WebApi.Config {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Config']/class[@name='MacConfig']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Models/WebApi/Config/MacConfig", DoNotGenerateAcw=true)]
	public partial class MacConfig : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Models/WebApi/Config/MacConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MacConfig); }
		}

		protected MacConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Config']/class[@name='MacConfig']/constructor[@name='MacConfig' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe MacConfig (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (MacConfig)) {
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

		static Delegate cb_getAlgorithm;
#pragma warning disable 0169
		static Delegate GetGetAlgorithmHandler ()
		{
			if (cb_getAlgorithm == null)
				cb_getAlgorithm = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAlgorithm);
			return cb_getAlgorithm;
		}

		static IntPtr n_GetAlgorithm (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Algorithm);
		}
#pragma warning restore 0169

		static Delegate cb_setAlgorithm_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAlgorithm_Ljava_lang_String_Handler ()
		{
			if (cb_setAlgorithm_Ljava_lang_String_ == null)
				cb_setAlgorithm_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAlgorithm_Ljava_lang_String_);
			return cb_setAlgorithm_Ljava_lang_String_;
		}

		static void n_SetAlgorithm_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Algorithm = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAlgorithm;
		static IntPtr id_setAlgorithm_Ljava_lang_String_;
		public virtual unsafe string Algorithm {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Config']/class[@name='MacConfig']/method[@name='getAlgorithm' and count(parameter)=0]"
			[Register ("getAlgorithm", "()Ljava/lang/String;", "GetGetAlgorithmHandler")]
			get {
				if (id_getAlgorithm == IntPtr.Zero)
					id_getAlgorithm = JNIEnv.GetMethodID (class_ref, "getAlgorithm", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAlgorithm), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAlgorithm", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Config']/class[@name='MacConfig']/method[@name='setAlgorithm' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAlgorithm", "(Ljava/lang/String;)V", "GetSetAlgorithm_Ljava_lang_String_Handler")]
			set {
				if (id_setAlgorithm_Ljava_lang_String_ == IntPtr.Zero)
					id_setAlgorithm_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAlgorithm", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAlgorithm_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlgorithm", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getExternalSeparator;
#pragma warning disable 0169
		static Delegate GetGetExternalSeparatorHandler ()
		{
			if (cb_getExternalSeparator == null)
				cb_getExternalSeparator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExternalSeparator);
			return cb_getExternalSeparator;
		}

		static IntPtr n_GetExternalSeparator (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExternalSeparator);
		}
#pragma warning restore 0169

		static Delegate cb_setExternalSeparator_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetExternalSeparator_Ljava_lang_String_Handler ()
		{
			if (cb_setExternalSeparator_Ljava_lang_String_ == null)
				cb_setExternalSeparator_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExternalSeparator_Ljava_lang_String_);
			return cb_setExternalSeparator_Ljava_lang_String_;
		}

		static void n_SetExternalSeparator_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExternalSeparator = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getExternalSeparator;
		static IntPtr id_setExternalSeparator_Ljava_lang_String_;
		public virtual unsafe string ExternalSeparator {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Config']/class[@name='MacConfig']/method[@name='getExternalSeparator' and count(parameter)=0]"
			[Register ("getExternalSeparator", "()Ljava/lang/String;", "GetGetExternalSeparatorHandler")]
			get {
				if (id_getExternalSeparator == IntPtr.Zero)
					id_getExternalSeparator = JNIEnv.GetMethodID (class_ref, "getExternalSeparator", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExternalSeparator), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExternalSeparator", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Config']/class[@name='MacConfig']/method[@name='setExternalSeparator' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setExternalSeparator", "(Ljava/lang/String;)V", "GetSetExternalSeparator_Ljava_lang_String_Handler")]
			set {
				if (id_setExternalSeparator_Ljava_lang_String_ == IntPtr.Zero)
					id_setExternalSeparator_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setExternalSeparator", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setExternalSeparator_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExternalSeparator", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getInternalSeparator;
#pragma warning disable 0169
		static Delegate GetGetInternalSeparatorHandler ()
		{
			if (cb_getInternalSeparator == null)
				cb_getInternalSeparator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInternalSeparator);
			return cb_getInternalSeparator;
		}

		static IntPtr n_GetInternalSeparator (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.InternalSeparator);
		}
#pragma warning restore 0169

		static Delegate cb_setInternalSeparator_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetInternalSeparator_Ljava_lang_String_Handler ()
		{
			if (cb_setInternalSeparator_Ljava_lang_String_ == null)
				cb_setInternalSeparator_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInternalSeparator_Ljava_lang_String_);
			return cb_setInternalSeparator_Ljava_lang_String_;
		}

		static void n_SetInternalSeparator_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InternalSeparator = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getInternalSeparator;
		static IntPtr id_setInternalSeparator_Ljava_lang_String_;
		public virtual unsafe string InternalSeparator {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Config']/class[@name='MacConfig']/method[@name='getInternalSeparator' and count(parameter)=0]"
			[Register ("getInternalSeparator", "()Ljava/lang/String;", "GetGetInternalSeparatorHandler")]
			get {
				if (id_getInternalSeparator == IntPtr.Zero)
					id_getInternalSeparator = JNIEnv.GetMethodID (class_ref, "getInternalSeparator", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInternalSeparator), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInternalSeparator", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Config']/class[@name='MacConfig']/method[@name='setInternalSeparator' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setInternalSeparator", "(Ljava/lang/String;)V", "GetSetInternalSeparator_Ljava_lang_String_Handler")]
			set {
				if (id_setInternalSeparator_Ljava_lang_String_ == IntPtr.Zero)
					id_setInternalSeparator_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setInternalSeparator", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInternalSeparator_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInternalSeparator", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isOnlyValues;
#pragma warning disable 0169
		static Delegate GetIsOnlyValuesHandler ()
		{
			if (cb_isOnlyValues == null)
				cb_isOnlyValues = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOnlyValues);
			return cb_isOnlyValues;
		}

		static bool n_IsOnlyValues (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnlyValues;
		}
#pragma warning restore 0169

		static Delegate cb_setOnlyValues_Z;
#pragma warning disable 0169
		static Delegate GetSetOnlyValues_ZHandler ()
		{
			if (cb_setOnlyValues_Z == null)
				cb_setOnlyValues_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetOnlyValues_Z);
			return cb_setOnlyValues_Z;
		}

		static void n_SetOnlyValues_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnlyValues = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isOnlyValues;
		static IntPtr id_setOnlyValues_Z;
		public virtual unsafe bool OnlyValues {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Config']/class[@name='MacConfig']/method[@name='isOnlyValues' and count(parameter)=0]"
			[Register ("isOnlyValues", "()Z", "GetIsOnlyValuesHandler")]
			get {
				if (id_isOnlyValues == IntPtr.Zero)
					id_isOnlyValues = JNIEnv.GetMethodID (class_ref, "isOnlyValues", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOnlyValues);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOnlyValues", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Config']/class[@name='MacConfig']/method[@name='setOnlyValues' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setOnlyValues", "(Z)V", "GetSetOnlyValues_ZHandler")]
			set {
				if (id_setOnlyValues_Z == IntPtr.Zero)
					id_setOnlyValues_Z = JNIEnv.GetMethodID (class_ref, "setOnlyValues", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnlyValues_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnlyValues", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSecretKey;
#pragma warning disable 0169
		static Delegate GetGetSecretKeyHandler ()
		{
			if (cb_getSecretKey == null)
				cb_getSecretKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSecretKey);
			return cb_getSecretKey;
		}

		static IntPtr n_GetSecretKey (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SecretKey);
		}
#pragma warning restore 0169

		static IntPtr id_getSecretKey;
		public virtual unsafe string SecretKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Config']/class[@name='MacConfig']/method[@name='getSecretKey' and count(parameter)=0]"
			[Register ("getSecretKey", "()Ljava/lang/String;", "GetGetSecretKeyHandler")]
			get {
				if (id_getSecretKey == IntPtr.Zero)
					id_getSecretKey = JNIEnv.GetMethodID (class_ref, "getSecretKey", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSecretKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSecretKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isUppercase;
#pragma warning disable 0169
		static Delegate GetIsUppercaseHandler ()
		{
			if (cb_isUppercase == null)
				cb_isUppercase = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUppercase);
			return cb_isUppercase;
		}

		static bool n_IsUppercase (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Uppercase;
		}
#pragma warning restore 0169

		static Delegate cb_setUppercase_Z;
#pragma warning disable 0169
		static Delegate GetSetUppercase_ZHandler ()
		{
			if (cb_setUppercase_Z == null)
				cb_setUppercase_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetUppercase_Z);
			return cb_setUppercase_Z;
		}

		static void n_SetUppercase_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Uppercase = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isUppercase;
		static IntPtr id_setUppercase_Z;
		public virtual unsafe bool Uppercase {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Config']/class[@name='MacConfig']/method[@name='isUppercase' and count(parameter)=0]"
			[Register ("isUppercase", "()Z", "GetIsUppercaseHandler")]
			get {
				if (id_isUppercase == IntPtr.Zero)
					id_isUppercase = JNIEnv.GetMethodID (class_ref, "isUppercase", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUppercase);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUppercase", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Config']/class[@name='MacConfig']/method[@name='setUppercase' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUppercase", "(Z)V", "GetSetUppercase_ZHandler")]
			set {
				if (id_setUppercase_Z == IntPtr.Zero)
					id_setUppercase_Z = JNIEnv.GetMethodID (class_ref, "setUppercase", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUppercase_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUppercase", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isUrlEncode;
#pragma warning disable 0169
		static Delegate GetIsUrlEncodeHandler ()
		{
			if (cb_isUrlEncode == null)
				cb_isUrlEncode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUrlEncode);
			return cb_isUrlEncode;
		}

		static bool n_IsUrlEncode (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UrlEncode;
		}
#pragma warning restore 0169

		static Delegate cb_setUrlEncode_Z;
#pragma warning disable 0169
		static Delegate GetSetUrlEncode_ZHandler ()
		{
			if (cb_setUrlEncode_Z == null)
				cb_setUrlEncode_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetUrlEncode_Z);
			return cb_setUrlEncode_Z;
		}

		static void n_SetUrlEncode_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UrlEncode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isUrlEncode;
		static IntPtr id_setUrlEncode_Z;
		public virtual unsafe bool UrlEncode {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Config']/class[@name='MacConfig']/method[@name='isUrlEncode' and count(parameter)=0]"
			[Register ("isUrlEncode", "()Z", "GetIsUrlEncodeHandler")]
			get {
				if (id_isUrlEncode == IntPtr.Zero)
					id_isUrlEncode = JNIEnv.GetMethodID (class_ref, "isUrlEncode", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUrlEncode);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUrlEncode", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Config']/class[@name='MacConfig']/method[@name='setUrlEncode' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUrlEncode", "(Z)V", "GetSetUrlEncode_ZHandler")]
			set {
				if (id_setUrlEncode_Z == IntPtr.Zero)
					id_setUrlEncode_Z = JNIEnv.GetMethodID (class_ref, "setUrlEncode", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUrlEncode_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUrlEncode", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getParametricMAC_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetParametricMAC_Ljava_lang_Object_Handler ()
		{
			if (cb_getParametricMAC_Ljava_lang_Object_ == null)
				cb_getParametricMAC_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetParametricMAC_Ljava_lang_Object_);
			return cb_getParametricMAC_Ljava_lang_Object_;
		}

		static IntPtr n_GetParametricMAC_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetParametricMAC (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getParametricMAC_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Config']/class[@name='MacConfig']/method[@name='getParametricMAC' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("getParametricMAC", "(Ljava/lang/Object;)Ljava/lang/String;", "GetGetParametricMAC_Ljava_lang_Object_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe string GetParametricMAC (global::Java.Lang.Object p0)
		{
			if (id_getParametricMAC_Ljava_lang_Object_ == IntPtr.Zero)
				id_getParametricMAC_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getParametricMAC", "(Ljava/lang/Object;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParametricMAC_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParametricMAC", "(Ljava/lang/Object;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_isbase64Encode;
#pragma warning disable 0169
		static Delegate GetIsbase64EncodeHandler ()
		{
			if (cb_isbase64Encode == null)
				cb_isbase64Encode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Isbase64Encode);
			return cb_isbase64Encode;
		}

		static bool n_Isbase64Encode (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Isbase64Encode ();
		}
#pragma warning restore 0169

		static IntPtr id_isbase64Encode;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Config']/class[@name='MacConfig']/method[@name='isbase64Encode' and count(parameter)=0]"
		[Register ("isbase64Encode", "()Z", "GetIsbase64EncodeHandler")]
		public virtual unsafe bool Isbase64Encode ()
		{
			if (id_isbase64Encode == IntPtr.Zero)
				id_isbase64Encode = JNIEnv.GetMethodID (class_ref, "isbase64Encode", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isbase64Encode);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isbase64Encode", "()Z"));
			} finally {
			}
		}

		static Delegate cb_setBase64Encode_Z;
#pragma warning disable 0169
		static Delegate GetSetBase64Encode_ZHandler ()
		{
			if (cb_setBase64Encode_Z == null)
				cb_setBase64Encode_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetBase64Encode_Z);
			return cb_setBase64Encode_Z;
		}

		static void n_SetBase64Encode_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBase64Encode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBase64Encode_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Config']/class[@name='MacConfig']/method[@name='setBase64Encode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setBase64Encode", "(Z)V", "GetSetBase64Encode_ZHandler")]
		public virtual unsafe void SetBase64Encode (bool p0)
		{
			if (id_setBase64Encode_Z == IntPtr.Zero)
				id_setBase64Encode_Z = JNIEnv.GetMethodID (class_ref, "setBase64Encode", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBase64Encode_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBase64Encode", "(Z)V"), __args);
			} finally {
			}
		}

	}
}
