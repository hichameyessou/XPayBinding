using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.WebApi.Classes {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='FrontOffice']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/WebApi/Classes/FrontOffice", DoNotGenerateAcw=true)]
	public sealed partial class FrontOffice : global::IT.Icbpi.XPaySDK.WebApi.Classes.BaseManagement, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='FrontOffice']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr frontOfficeQPCallback_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='FrontOffice']/field[@name='frontOfficeQPCallback']"
		[Register ("frontOfficeQPCallback")]
		public global::IT.Icbpi.XPaySDK.CallBacks.IFrontOfficeQPCallback FrontOfficeQPCallback {
			get {
				if (frontOfficeQPCallback_jfieldId == IntPtr.Zero)
					frontOfficeQPCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "frontOfficeQPCallback", "Lit/icbpi/XPaySDK/CallBacks/FrontOfficeQPCallback;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, frontOfficeQPCallback_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.CallBacks.IFrontOfficeQPCallback> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (frontOfficeQPCallback_jfieldId == IntPtr.Zero)
					frontOfficeQPCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "frontOfficeQPCallback", "Lit/icbpi/XPaySDK/CallBacks/FrontOfficeQPCallback;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, frontOfficeQPCallback_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr frontOfficeXPCallback_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='FrontOffice']/field[@name='frontOfficeXPCallback']"
		[Register ("frontOfficeXPCallback")]
		public global::IT.Icbpi.XPaySDK.CallBacks.IFrontOfficeXPCallback FrontOfficeXPCallback {
			get {
				if (frontOfficeXPCallback_jfieldId == IntPtr.Zero)
					frontOfficeXPCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "frontOfficeXPCallback", "Lit/icbpi/XPaySDK/CallBacks/FrontOfficeXPCallback;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, frontOfficeXPCallback_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.CallBacks.IFrontOfficeXPCallback> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (frontOfficeXPCallback_jfieldId == IntPtr.Zero)
					frontOfficeXPCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "frontOfficeXPCallback", "Lit/icbpi/XPaySDK/CallBacks/FrontOfficeXPCallback;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, frontOfficeXPCallback_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/WebApi/Classes/FrontOffice", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FrontOffice); }
		}

		internal FrontOffice (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='FrontOffice']/constructor[@name='FrontOffice' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe FrontOffice (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (FrontOffice)) {
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

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='FrontOffice']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
			} finally {
			}
		}

		static IntPtr id_paga_Lit_icbpi_XPaySDK_Models_WebApi_Requests_FrontOffice_ApiFrontOfficeQPRequest_Lit_icbpi_XPaySDK_CallBacks_FrontOfficeQPCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='FrontOffice']/method[@name='paga' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeQPRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.FrontOfficeQPCallback']]"
		[Register ("paga", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/FrontOffice/ApiFrontOfficeQPRequest;Lit/icbpi/XPaySDK/CallBacks/FrontOfficeQPCallback;)V", "")]
		public unsafe void Paga (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeQPRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IFrontOfficeQPCallback p1)
		{
			if (id_paga_Lit_icbpi_XPaySDK_Models_WebApi_Requests_FrontOffice_ApiFrontOfficeQPRequest_Lit_icbpi_XPaySDK_CallBacks_FrontOfficeQPCallback_ == IntPtr.Zero)
				id_paga_Lit_icbpi_XPaySDK_Models_WebApi_Requests_FrontOffice_ApiFrontOfficeQPRequest_Lit_icbpi_XPaySDK_CallBacks_FrontOfficeQPCallback_ = JNIEnv.GetMethodID (class_ref, "paga", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/FrontOffice/ApiFrontOfficeQPRequest;Lit/icbpi/XPaySDK/CallBacks/FrontOfficeQPCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_paga_Lit_icbpi_XPaySDK_Models_WebApi_Requests_FrontOffice_ApiFrontOfficeQPRequest_Lit_icbpi_XPaySDK_CallBacks_FrontOfficeQPCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_paga_Lit_icbpi_XPaySDK_Models_WebApi_Requests_FrontOffice_ApiFrontOfficeXPRequest_Lit_icbpi_XPaySDK_CallBacks_FrontOfficeXPCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='FrontOffice']/method[@name='paga' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.FrontOfficeXPCallback']]"
		[Register ("paga", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/FrontOffice/ApiFrontOfficeXPRequest;Lit/icbpi/XPaySDK/CallBacks/FrontOfficeXPCallback;)V", "")]
		public unsafe void Paga (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.FrontOffice.ApiFrontOfficeXPRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IFrontOfficeXPCallback p1)
		{
			if (id_paga_Lit_icbpi_XPaySDK_Models_WebApi_Requests_FrontOffice_ApiFrontOfficeXPRequest_Lit_icbpi_XPaySDK_CallBacks_FrontOfficeXPCallback_ == IntPtr.Zero)
				id_paga_Lit_icbpi_XPaySDK_Models_WebApi_Requests_FrontOffice_ApiFrontOfficeXPRequest_Lit_icbpi_XPaySDK_CallBacks_FrontOfficeXPCallback_ = JNIEnv.GetMethodID (class_ref, "paga", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/FrontOffice/ApiFrontOfficeXPRequest;Lit/icbpi/XPaySDK/CallBacks/FrontOfficeXPCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_paga_Lit_icbpi_XPaySDK_Models_WebApi_Requests_FrontOffice_ApiFrontOfficeXPRequest_Lit_icbpi_XPaySDK_CallBacks_FrontOfficeXPCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='FrontOffice']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
			} finally {
			}
		}

	}
}
