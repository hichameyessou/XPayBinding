using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils']/class[@name='EnvironmentUtils']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Utils/EnvironmentUtils", DoNotGenerateAcw=true)]
	public partial class EnvironmentUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils']/class[@name='EnvironmentUtils']/field[@name='ACTIVITY_CALLER']"
		[Register ("ACTIVITY_CALLER")]
		public const string ActivityCaller = (string) "ActivityCaller";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils']/class[@name='EnvironmentUtils']/field[@name='ACTIVITY_HP']"
		[Register ("ACTIVITY_HP")]
		public const string ActivityHp = (string) "ActivityHP";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils']/class[@name='EnvironmentUtils']/field[@name='ACTIVITY_PRIMI_PAGAMENTI']"
		[Register ("ACTIVITY_PRIMI_PAGAMENTI")]
		public const string ActivityPrimiPagamenti = (string) "ActivityPrimiPagamenti";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils']/class[@name='EnvironmentUtils']/field[@name='ACTIVITY_RICORRENZE']"
		[Register ("ACTIVITY_RICORRENZE")]
		public const string ActivityRicorrenze = (string) "ActivityRicorrenze";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils']/class[@name='EnvironmentUtils']/field[@name='DEFAULT_TIMEOUT']"
		[Register ("DEFAULT_TIMEOUT")]
		public const int DefaultTimeout = (int) 30000;
		// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils']/class[@name='EnvironmentUtils.Environment']"
		[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Utils/EnvironmentUtils$Environment", DoNotGenerateAcw=true)]
		public sealed partial class Environment : global::Java.Lang.Enum {


			static IntPtr INTEG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils']/class[@name='EnvironmentUtils.Environment']/field[@name='INTEG']"
			[Register ("INTEG")]
			public static global::IT.Icbpi.XPaySDK.Utils.EnvironmentUtils.Environment Integ {
				get {
					if (INTEG_jfieldId == IntPtr.Zero)
						INTEG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTEG", "Lit/icbpi/XPaySDK/Utils/EnvironmentUtils$Environment;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTEG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.EnvironmentUtils.Environment> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PROD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils']/class[@name='EnvironmentUtils.Environment']/field[@name='PROD']"
			[Register ("PROD")]
			public static global::IT.Icbpi.XPaySDK.Utils.EnvironmentUtils.Environment Prod {
				get {
					if (PROD_jfieldId == IntPtr.Zero)
						PROD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROD", "Lit/icbpi/XPaySDK/Utils/EnvironmentUtils$Environment;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PROD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.EnvironmentUtils.Environment> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TEST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils']/class[@name='EnvironmentUtils.Environment']/field[@name='TEST']"
			[Register ("TEST")]
			public static global::IT.Icbpi.XPaySDK.Utils.EnvironmentUtils.Environment Test {
				get {
					if (TEST_jfieldId == IntPtr.Zero)
						TEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEST", "Lit/icbpi/XPaySDK/Utils/EnvironmentUtils$Environment;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.EnvironmentUtils.Environment> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("it/icbpi/XPaySDK/Utils/EnvironmentUtils$Environment", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Environment); }
			}

			internal Environment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils']/class[@name='EnvironmentUtils.Environment']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lit/icbpi/XPaySDK/Utils/EnvironmentUtils$Environment;", "")]
			public static unsafe global::IT.Icbpi.XPaySDK.Utils.EnvironmentUtils.Environment ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lit/icbpi/XPaySDK/Utils/EnvironmentUtils$Environment;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::IT.Icbpi.XPaySDK.Utils.EnvironmentUtils.Environment __ret = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.EnvironmentUtils.Environment> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils']/class[@name='EnvironmentUtils.Environment']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lit/icbpi/XPaySDK/Utils/EnvironmentUtils$Environment;", "")]
			public static unsafe global::IT.Icbpi.XPaySDK.Utils.EnvironmentUtils.Environment[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lit/icbpi/XPaySDK/Utils/EnvironmentUtils$Environment;");
				try {
					return (global::IT.Icbpi.XPaySDK.Utils.EnvironmentUtils.Environment[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IT.Icbpi.XPaySDK.Utils.EnvironmentUtils.Environment));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Utils/EnvironmentUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EnvironmentUtils); }
		}

		protected EnvironmentUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils']/class[@name='EnvironmentUtils']/constructor[@name='EnvironmentUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EnvironmentUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (EnvironmentUtils)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_isStringLong_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils']/class[@name='EnvironmentUtils']/method[@name='isStringLong' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isStringLong", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsStringLong (string p0)
		{
			if (id_isStringLong_Ljava_lang_String_ == IntPtr.Zero)
				id_isStringLong_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isStringLong", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isStringLong_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
