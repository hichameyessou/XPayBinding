using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils']/class[@name='GenericUtils']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Utils/GenericUtils", DoNotGenerateAcw=true)]
	public partial class GenericUtils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Utils/GenericUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GenericUtils); }
		}

		protected GenericUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils']/class[@name='GenericUtils']/constructor[@name='GenericUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GenericUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GenericUtils)) {
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

		static IntPtr id_addZeroToDate_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils']/class[@name='GenericUtils']/method[@name='addZeroToDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addZeroToDate", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string AddZeroToDate (string p0)
		{
			if (id_addZeroToDate_Ljava_lang_String_ == IntPtr.Zero)
				id_addZeroToDate_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "addZeroToDate", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_addZeroToDate_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_isXPaySDK_Ljava_lang_reflect_Field_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils']/class[@name='GenericUtils']/method[@name='isXPaySDK' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Field']]"
		[Register ("isXPaySDK", "(Ljava/lang/reflect/Field;)Z", "")]
		public static unsafe bool IsXPaySDK (global::Java.Lang.Reflect.Field p0)
		{
			if (id_isXPaySDK_Ljava_lang_reflect_Field_ == IntPtr.Zero)
				id_isXPaySDK_Ljava_lang_reflect_Field_ = JNIEnv.GetStaticMethodID (class_ref, "isXPaySDK", "(Ljava/lang/reflect/Field;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isXPaySDK_Ljava_lang_reflect_Field_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
