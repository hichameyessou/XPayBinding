using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Utils.Serializers {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.Serializers']/class[@name='SerializerEnum']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Utils/Serializers/SerializerEnum", DoNotGenerateAcw=true)]
	public sealed partial class SerializerEnum : global::Java.Lang.Enum {


		static IntPtr CREA_NONCE_SERIALIZER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.Serializers']/class[@name='SerializerEnum']/field[@name='CREA_NONCE_SERIALIZER']"
		[Register ("CREA_NONCE_SERIALIZER")]
		public static global::IT.Icbpi.XPaySDK.Utils.Serializers.SerializerEnum CreaNonceSerializer {
			get {
				if (CREA_NONCE_SERIALIZER_jfieldId == IntPtr.Zero)
					CREA_NONCE_SERIALIZER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREA_NONCE_SERIALIZER", "Lit/icbpi/XPaySDK/Utils/Serializers/SerializerEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREA_NONCE_SERIALIZER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.Serializers.SerializerEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DEFAULT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.Serializers']/class[@name='SerializerEnum']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public static global::IT.Icbpi.XPaySDK.Utils.Serializers.SerializerEnum Default {
			get {
				if (DEFAULT_jfieldId == IntPtr.Zero)
					DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT", "Lit/icbpi/XPaySDK/Utils/Serializers/SerializerEnum;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.Serializers.SerializerEnum> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Utils/Serializers/SerializerEnum", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SerializerEnum); }
		}

		internal SerializerEnum (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.Serializers']/class[@name='SerializerEnum']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lit/icbpi/XPaySDK/Utils/Serializers/SerializerEnum;", "")]
		public static unsafe global::IT.Icbpi.XPaySDK.Utils.Serializers.SerializerEnum ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lit/icbpi/XPaySDK/Utils/Serializers/SerializerEnum;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IT.Icbpi.XPaySDK.Utils.Serializers.SerializerEnum __ret = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.Serializers.SerializerEnum> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.Serializers']/class[@name='SerializerEnum']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lit/icbpi/XPaySDK/Utils/Serializers/SerializerEnum;", "")]
		public static unsafe global::IT.Icbpi.XPaySDK.Utils.Serializers.SerializerEnum[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lit/icbpi/XPaySDK/Utils/Serializers/SerializerEnum;");
			try {
				return (global::IT.Icbpi.XPaySDK.Utils.Serializers.SerializerEnum[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IT.Icbpi.XPaySDK.Utils.Serializers.SerializerEnum));
			} finally {
			}
		}

	}
}
