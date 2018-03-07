using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Utils.Varie {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.Varie']/class[@name='DCCGenericUtils']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Utils/Varie/DCCGenericUtils", DoNotGenerateAcw=true)]
	public partial class DCCGenericUtils : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.Varie']/class[@name='DCCGenericUtils.ExchangeRate']"
		[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Utils/Varie/DCCGenericUtils$ExchangeRate", DoNotGenerateAcw=true)]
		public sealed partial class ExchangeRate : global::Java.Lang.Enum {


			static IntPtr ACCEPTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.Varie']/class[@name='DCCGenericUtils.ExchangeRate']/field[@name='ACCEPTED']"
			[Register ("ACCEPTED")]
			public static global::IT.Icbpi.XPaySDK.Utils.Varie.DCCGenericUtils.ExchangeRate Accepted {
				get {
					if (ACCEPTED_jfieldId == IntPtr.Zero)
						ACCEPTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACCEPTED", "Lit/icbpi/XPaySDK/Utils/Varie/DCCGenericUtils$ExchangeRate;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACCEPTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.Varie.DCCGenericUtils.ExchangeRate> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NOT_ACCEPTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.Varie']/class[@name='DCCGenericUtils.ExchangeRate']/field[@name='NOT_ACCEPTED']"
			[Register ("NOT_ACCEPTED")]
			public static global::IT.Icbpi.XPaySDK.Utils.Varie.DCCGenericUtils.ExchangeRate NotAccepted {
				get {
					if (NOT_ACCEPTED_jfieldId == IntPtr.Zero)
						NOT_ACCEPTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_ACCEPTED", "Lit/icbpi/XPaySDK/Utils/Varie/DCCGenericUtils$ExchangeRate;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOT_ACCEPTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.Varie.DCCGenericUtils.ExchangeRate> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("it/icbpi/XPaySDK/Utils/Varie/DCCGenericUtils$ExchangeRate", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ExchangeRate); }
			}

			internal ExchangeRate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.Varie']/class[@name='DCCGenericUtils.ExchangeRate']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lit/icbpi/XPaySDK/Utils/Varie/DCCGenericUtils$ExchangeRate;", "")]
			public static unsafe global::IT.Icbpi.XPaySDK.Utils.Varie.DCCGenericUtils.ExchangeRate ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lit/icbpi/XPaySDK/Utils/Varie/DCCGenericUtils$ExchangeRate;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::IT.Icbpi.XPaySDK.Utils.Varie.DCCGenericUtils.ExchangeRate __ret = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.Varie.DCCGenericUtils.ExchangeRate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.Varie']/class[@name='DCCGenericUtils.ExchangeRate']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lit/icbpi/XPaySDK/Utils/Varie/DCCGenericUtils$ExchangeRate;", "")]
			public static unsafe global::IT.Icbpi.XPaySDK.Utils.Varie.DCCGenericUtils.ExchangeRate[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lit/icbpi/XPaySDK/Utils/Varie/DCCGenericUtils$ExchangeRate;");
				try {
					return (global::IT.Icbpi.XPaySDK.Utils.Varie.DCCGenericUtils.ExchangeRate[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IT.Icbpi.XPaySDK.Utils.Varie.DCCGenericUtils.ExchangeRate));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Utils/Varie/DCCGenericUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DCCGenericUtils); }
		}

		protected DCCGenericUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.Varie']/class[@name='DCCGenericUtils']/constructor[@name='DCCGenericUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DCCGenericUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DCCGenericUtils)) {
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

	}
}
