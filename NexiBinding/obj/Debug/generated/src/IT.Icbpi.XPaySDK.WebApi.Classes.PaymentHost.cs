using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.WebApi.Classes {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='HostedPayments']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/WebApi/Classes/HostedPayments", DoNotGenerateAcw=true)]
	public sealed partial class PaymentHost : global::IT.Icbpi.XPaySDK.WebApi.Classes.BaseManagement, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='HostedPayments']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr creaNonceResponseApiResponseCallback_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='HostedPayments']/field[@name='creaNonceResponseApiResponseCallback']"
		[Register ("creaNonceResponseApiResponseCallback")]
		public global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback CreaNonceResponseApiResponseCallback {
			get {
				if (creaNonceResponseApiResponseCallback_jfieldId == IntPtr.Zero)
					creaNonceResponseApiResponseCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "creaNonceResponseApiResponseCallback", "Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, creaNonceResponseApiResponseCallback_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (creaNonceResponseApiResponseCallback_jfieldId == IntPtr.Zero)
					creaNonceResponseApiResponseCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "creaNonceResponseApiResponseCallback", "Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, creaNonceResponseApiResponseCallback_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr hostedPayments_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='HostedPayments']/field[@name='hostedPayments']"
		[Register ("hostedPayments")]
		public static global::IT.Icbpi.XPaySDK.WebApi.Classes.PaymentHost HostedPayments {
			get {
				if (hostedPayments_jfieldId == IntPtr.Zero)
					hostedPayments_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "hostedPayments", "Lit/icbpi/XPaySDK/WebApi/Classes/HostedPayments;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, hostedPayments_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.WebApi.Classes.PaymentHost> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (hostedPayments_jfieldId == IntPtr.Zero)
					hostedPayments_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "hostedPayments", "Lit/icbpi/XPaySDK/WebApi/Classes/HostedPayments;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, hostedPayments_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/WebApi/Classes/HostedPayments", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PaymentHost); }
		}

		internal PaymentHost (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='HostedPayments']/constructor[@name='HostedPayments' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe PaymentHost (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (PaymentHost)) {
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

		static IntPtr id_creaNonce_Lit_icbpi_XPaySDK_Models_WebApi_Requests_HostedPayments_ApiCreaNonceRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='HostedPayments']/method[@name='creaNonce' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.HostedPayments.ApiCreaNonceRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.HostedPayments.ApiCreaNonceResponse&gt;']]"
		[Register ("creaNonce", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/HostedPayments/ApiCreaNonceRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void CreaNonce (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.HostedPayments.ApiCreaNonceRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_creaNonce_Lit_icbpi_XPaySDK_Models_WebApi_Requests_HostedPayments_ApiCreaNonceRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_creaNonce_Lit_icbpi_XPaySDK_Models_WebApi_Requests_HostedPayments_ApiCreaNonceRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "creaNonce", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/HostedPayments/ApiCreaNonceRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_creaNonce_Lit_icbpi_XPaySDK_Models_WebApi_Requests_HostedPayments_ApiCreaNonceRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='HostedPayments']/method[@name='describeContents' and count(parameter)=0]"
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

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='HostedPayments']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
