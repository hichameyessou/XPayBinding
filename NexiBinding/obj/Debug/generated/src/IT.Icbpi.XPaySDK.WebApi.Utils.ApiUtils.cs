using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.WebApi.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Utils']/class[@name='ApiUtils']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/WebApi/Utils/ApiUtils", DoNotGenerateAcw=true)]
	public sealed partial class ApiUtils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/WebApi/Utils/ApiUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApiUtils); }
		}

		internal ApiUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Utils']/class[@name='ApiUtils']/constructor[@name='ApiUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ApiUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ApiUtils)) {
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

		static IntPtr id_getParametersByAPI_arrayLjava_lang_reflect_Field_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Utils']/class[@name='ApiUtils']/method[@name='getParametersByAPI' and count(parameter)=2 and parameter[1][@type='java.lang.reflect.Field[]'] and parameter[2][@type='T']]"
		[Register ("getParametersByAPI", "([Ljava/lang/reflect/Field;Ljava/lang/Object;)[Lit/icbpi/XPaySDK/Models/WebApi/Config/MacPair;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacPair[] GetParametersByAPI (global::Java.Lang.Reflect.Field[] p0, global::Java.Lang.Object p1)
		{
			if (id_getParametersByAPI_arrayLjava_lang_reflect_Field_Ljava_lang_Object_ == IntPtr.Zero)
				id_getParametersByAPI_arrayLjava_lang_reflect_Field_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "getParametersByAPI", "([Ljava/lang/reflect/Field;Ljava/lang/Object;)[Lit/icbpi/XPaySDK/Models/WebApi/Config/MacPair;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacPair[] __ret = (global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacPair[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getParametersByAPI_arrayLjava_lang_reflect_Field_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacPair));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getURIByAPI_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Utils']/class[@name='ApiUtils']/method[@name='getURIByAPI' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class[]']]"
		[Register ("getURIByAPI", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/String;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe string GetURIByAPI (global::Java.Lang.Class p0, string p1, global::Java.Lang.Class[] p2)
		{
			if (id_getURIByAPI_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Class_ == IntPtr.Zero)
				id_getURIByAPI_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getURIByAPI", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getURIByAPI_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

	}
}
