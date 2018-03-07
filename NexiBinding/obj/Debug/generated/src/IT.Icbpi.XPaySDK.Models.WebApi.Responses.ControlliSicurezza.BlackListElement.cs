using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza']/class[@name='BlackListElement']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Models/WebApi/Responses/ControlliSicurezza/BlackListElement", DoNotGenerateAcw=true)]
	public partial class BlackListElement : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Models/WebApi/Responses/ControlliSicurezza/BlackListElement", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BlackListElement); }
		}

		protected BlackListElement (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza']/class[@name='BlackListElement']/constructor[@name='BlackListElement' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe BlackListElement (string p0, string p1, string p2, string p3, string p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				if (((object) this).GetType () != typeof (BlackListElement)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_getDCreation;
#pragma warning disable 0169
		static Delegate GetGetDCreationHandler ()
		{
			if (cb_getDCreation == null)
				cb_getDCreation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDCreation);
			return cb_getDCreation;
		}

		static IntPtr n_GetDCreation (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza.BlackListElement __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza.BlackListElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DCreation);
		}
#pragma warning restore 0169

		static IntPtr id_getDCreation;
		public virtual unsafe string DCreation {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza']/class[@name='BlackListElement']/method[@name='getDCreation' and count(parameter)=0]"
			[Register ("getDCreation", "()Ljava/lang/String;", "GetGetDCreationHandler")]
			get {
				if (id_getDCreation == IntPtr.Zero)
					id_getDCreation = JNIEnv.GetMethodID (class_ref, "getDCreation", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDCreation), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDCreation", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDataType;
#pragma warning disable 0169
		static Delegate GetGetDataTypeHandler ()
		{
			if (cb_getDataType == null)
				cb_getDataType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataType);
			return cb_getDataType;
		}

		static IntPtr n_GetDataType (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza.BlackListElement __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza.BlackListElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DataType);
		}
#pragma warning restore 0169

		static IntPtr id_getDataType;
		public virtual unsafe string DataType {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza']/class[@name='BlackListElement']/method[@name='getDataType' and count(parameter)=0]"
			[Register ("getDataType", "()Ljava/lang/String;", "GetGetDataTypeHandler")]
			get {
				if (id_getDataType == IntPtr.Zero)
					id_getDataType = JNIEnv.GetMethodID (class_ref, "getDataType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDataType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler ()
		{
			if (cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza.BlackListElement __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza.BlackListElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Description);
		}
#pragma warning restore 0169

		static IntPtr id_getDescription;
		public virtual unsafe string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza']/class[@name='BlackListElement']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
			get {
				if (id_getDescription == IntPtr.Zero)
					id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDescription", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getListedValue;
#pragma warning disable 0169
		static Delegate GetGetListedValueHandler ()
		{
			if (cb_getListedValue == null)
				cb_getListedValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetListedValue);
			return cb_getListedValue;
		}

		static IntPtr n_GetListedValue (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza.BlackListElement __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza.BlackListElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ListedValue);
		}
#pragma warning restore 0169

		static IntPtr id_getListedValue;
		public virtual unsafe string ListedValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza']/class[@name='BlackListElement']/method[@name='getListedValue' and count(parameter)=0]"
			[Register ("getListedValue", "()Ljava/lang/String;", "GetGetListedValueHandler")]
			get {
				if (id_getListedValue == IntPtr.Zero)
					id_getListedValue = JNIEnv.GetMethodID (class_ref, "getListedValue", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getListedValue), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getListedValue", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza.BlackListElement __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza.BlackListElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NMerchant);
		}
#pragma warning restore 0169

		static IntPtr id_getNMerchant;
		public virtual unsafe string NMerchant {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Responses.ControlliSicurezza']/class[@name='BlackListElement']/method[@name='getNMerchant' and count(parameter)=0]"
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

	}
}
