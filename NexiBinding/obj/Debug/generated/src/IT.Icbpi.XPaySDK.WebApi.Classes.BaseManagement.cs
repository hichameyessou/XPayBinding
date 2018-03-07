using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.WebApi.Classes {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='BaseManagement']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/WebApi/Classes/BaseManagement", DoNotGenerateAcw=true)]
	public abstract partial class BaseManagement : global::Java.Lang.Object {


		static IntPtr context_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='BaseManagement']/field[@name='context']"
		[Register ("context")]
		protected global::Android.Content.Context Context {
			get {
				if (context_jfieldId == IntPtr.Zero)
					context_jfieldId = JNIEnv.GetFieldID (class_ref, "context", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, context_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (context_jfieldId == IntPtr.Zero)
					context_jfieldId = JNIEnv.GetFieldID (class_ref, "context", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, context_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr selectedEnvironment_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='BaseManagement']/field[@name='selectedEnvironment']"
		[Register ("selectedEnvironment")]
		protected global::IT.Icbpi.XPaySDK.Utils.EnvironmentUtils.Environment SelectedEnvironment {
			get {
				if (selectedEnvironment_jfieldId == IntPtr.Zero)
					selectedEnvironment_jfieldId = JNIEnv.GetFieldID (class_ref, "selectedEnvironment", "Lit/icbpi/XPaySDK/Utils/EnvironmentUtils$Environment;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, selectedEnvironment_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.EnvironmentUtils.Environment> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (selectedEnvironment_jfieldId == IntPtr.Zero)
					selectedEnvironment_jfieldId = JNIEnv.GetFieldID (class_ref, "selectedEnvironment", "Lit/icbpi/XPaySDK/Utils/EnvironmentUtils$Environment;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, selectedEnvironment_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr timeout_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='BaseManagement']/field[@name='timeout']"
		[Register ("timeout")]
		protected int Timeout {
			get {
				if (timeout_jfieldId == IntPtr.Zero)
					timeout_jfieldId = JNIEnv.GetFieldID (class_ref, "timeout", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, timeout_jfieldId);
			}
			set {
				if (timeout_jfieldId == IntPtr.Zero)
					timeout_jfieldId = JNIEnv.GetFieldID (class_ref, "timeout", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, timeout_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/WebApi/Classes/BaseManagement", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseManagement); }
		}

		protected BaseManagement (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='BaseManagement']/constructor[@name='BaseManagement' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe BaseManagement (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (BaseManagement)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/os/Parcel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/os/Parcel;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
					id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_os_Parcel_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='BaseManagement']/constructor[@name='BaseManagement' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		protected unsafe BaseManagement (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (BaseManagement)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_setEnvironment_Lit_icbpi_XPaySDK_Utils_EnvironmentUtils_Environment_;
#pragma warning disable 0169
		static Delegate GetSetEnvironment_Lit_icbpi_XPaySDK_Utils_EnvironmentUtils_Environment_Handler ()
		{
			if (cb_setEnvironment_Lit_icbpi_XPaySDK_Utils_EnvironmentUtils_Environment_ == null)
				cb_setEnvironment_Lit_icbpi_XPaySDK_Utils_EnvironmentUtils_Environment_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEnvironment_Lit_icbpi_XPaySDK_Utils_EnvironmentUtils_Environment_);
			return cb_setEnvironment_Lit_icbpi_XPaySDK_Utils_EnvironmentUtils_Environment_;
		}

		static void n_SetEnvironment_Lit_icbpi_XPaySDK_Utils_EnvironmentUtils_Environment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IT.Icbpi.XPaySDK.WebApi.Classes.BaseManagement __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.WebApi.Classes.BaseManagement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IT.Icbpi.XPaySDK.Utils.EnvironmentUtils.Environment p0 = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.EnvironmentUtils.Environment> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetEnvironment (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setEnvironment_Lit_icbpi_XPaySDK_Utils_EnvironmentUtils_Environment_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='BaseManagement']/method[@name='setEnvironment' and count(parameter)=1 and parameter[1][@type='it.icbpi.XPaySDK.Utils.EnvironmentUtils.Environment']]"
		[Register ("setEnvironment", "(Lit/icbpi/XPaySDK/Utils/EnvironmentUtils$Environment;)V", "GetSetEnvironment_Lit_icbpi_XPaySDK_Utils_EnvironmentUtils_Environment_Handler")]
		public virtual unsafe void SetEnvironment (global::IT.Icbpi.XPaySDK.Utils.EnvironmentUtils.Environment p0)
		{
			if (id_setEnvironment_Lit_icbpi_XPaySDK_Utils_EnvironmentUtils_Environment_ == IntPtr.Zero)
				id_setEnvironment_Lit_icbpi_XPaySDK_Utils_EnvironmentUtils_Environment_ = JNIEnv.GetMethodID (class_ref, "setEnvironment", "(Lit/icbpi/XPaySDK/Utils/EnvironmentUtils$Environment;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEnvironment_Lit_icbpi_XPaySDK_Utils_EnvironmentUtils_Environment_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEnvironment", "(Lit/icbpi/XPaySDK/Utils/EnvironmentUtils$Environment;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetTimeout_IHandler ()
		{
			if (cb_setTimeout_I == null)
				cb_setTimeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTimeout_I);
			return cb_setTimeout_I;
		}

		static void n_SetTimeout_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::IT.Icbpi.XPaySDK.WebApi.Classes.BaseManagement __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.WebApi.Classes.BaseManagement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTimeout (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTimeout_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='BaseManagement']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTimeout", "(I)V", "GetSetTimeout_IHandler")]
		public virtual unsafe void SetTimeout (int p0)
		{
			if (id_setTimeout_I == IntPtr.Zero)
				id_setTimeout_I = JNIEnv.GetMethodID (class_ref, "setTimeout", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTimeout_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimeout", "(I)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/WebApi/Classes/BaseManagement", DoNotGenerateAcw=true)]
	internal partial class BaseManagementInvoker : BaseManagement {

		public BaseManagementInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseManagementInvoker); }
		}

	}

}
