using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Models']/class[@name='Card']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Models/Card", DoNotGenerateAcw=true)]
	public partial class Card : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Models/Card", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Card); }
		}

		protected Card (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_IILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models']/class[@name='Card']/constructor[@name='Card' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;IILjava/lang/String;)V", "")]
		public unsafe Card (string p0, int p1, int p2, string p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				if (((object) this).GetType () != typeof (Card)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;IILjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;IILjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_IILjava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_IILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;IILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_IILjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_IILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p3);
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
			global::IT.Icbpi.XPaySDK.Models.Card __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.Card> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Cvc);
		}
#pragma warning restore 0169

		static IntPtr id_getCvc;
		public virtual unsafe string Cvc {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models']/class[@name='Card']/method[@name='getCvc' and count(parameter)=0]"
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
			global::IT.Icbpi.XPaySDK.Models.Card __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.Card> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Expire);
		}
#pragma warning restore 0169

		static IntPtr id_getExpire;
		public virtual unsafe string Expire {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models']/class[@name='Card']/method[@name='getExpire' and count(parameter)=0]"
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

		static Delegate cb_isValid;
#pragma warning disable 0169
		static Delegate GetIsValidHandler ()
		{
			if (cb_isValid == null)
				cb_isValid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsValid);
			return cb_isValid;
		}

		static bool n_IsValid (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.Card __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.Card> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsValid;
		}
#pragma warning restore 0169

		static IntPtr id_isValid;
		public virtual unsafe bool IsValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models']/class[@name='Card']/method[@name='isValid' and count(parameter)=0]"
			[Register ("isValid", "()Z", "GetIsValidHandler")]
			get {
				if (id_isValid == IntPtr.Zero)
					id_isValid = JNIEnv.GetMethodID (class_ref, "isValid", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isValid);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isValid", "()Z"));
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
			global::IT.Icbpi.XPaySDK.Models.Card __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.Card> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Pan);
		}
#pragma warning restore 0169

		static IntPtr id_getPan;
		public virtual unsafe string Pan {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models']/class[@name='Card']/method[@name='getPan' and count(parameter)=0]"
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

	}
}
