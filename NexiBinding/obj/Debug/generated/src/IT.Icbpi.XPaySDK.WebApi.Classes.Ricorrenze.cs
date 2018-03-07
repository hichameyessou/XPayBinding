using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.WebApi.Classes {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='Ricorrenze']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/WebApi/Classes/Ricorrenze", DoNotGenerateAcw=true)]
	public sealed partial class Ricorrenze : global::IT.Icbpi.XPaySDK.WebApi.Classes.BaseManagement, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='Ricorrenze']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr creaNoncePagamentoRicorrente3DSCallback_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='Ricorrenze']/field[@name='creaNoncePagamentoRicorrente3DSCallback']"
		[Register ("creaNoncePagamentoRicorrente3DSCallback")]
		public global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback CreaNoncePagamentoRicorrente3DSCallback {
			get {
				if (creaNoncePagamentoRicorrente3DSCallback_jfieldId == IntPtr.Zero)
					creaNoncePagamentoRicorrente3DSCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "creaNoncePagamentoRicorrente3DSCallback", "Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, creaNoncePagamentoRicorrente3DSCallback_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (creaNoncePagamentoRicorrente3DSCallback_jfieldId == IntPtr.Zero)
					creaNoncePagamentoRicorrente3DSCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "creaNoncePagamentoRicorrente3DSCallback", "Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, creaNoncePagamentoRicorrente3DSCallback_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr ricorrenze_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='Ricorrenze']/field[@name='ricorrenze']"
		[Register ("ricorrenze")]
		public static global::IT.Icbpi.XPaySDK.WebApi.Classes.Ricorrenze Ricorrenze {
			get {
				if (ricorrenze_jfieldId == IntPtr.Zero)
					ricorrenze_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ricorrenze", "Lit/icbpi/XPaySDK/WebApi/Classes/Ricorrenze;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ricorrenze_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.WebApi.Classes.Ricorrenze> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ricorrenze_jfieldId == IntPtr.Zero)
					ricorrenze_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ricorrenze", "Lit/icbpi/XPaySDK/WebApi/Classes/Ricorrenze;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, ricorrenze_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/WebApi/Classes/Ricorrenze", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Ricorrenze); }
		}

		internal Ricorrenze (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='Ricorrenze']/constructor[@name='Ricorrenze' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe Ricorrenze (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (Ricorrenze)) {
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

		static IntPtr id_creaNoncePagamentoRicorrente3DS_Lit_icbpi_XPaySDK_Models_WebApi_Requests_Ricorrenze_ApiCreaNoncePagamentoRicorrente3DSRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='Ricorrenze']/method[@name='creaNoncePagamentoRicorrente3DS' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.Ricorrenze.ApiCreaNoncePagamentoRicorrente3DSRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.Ricorrenze.ApiCreaNoncePagamentoRicorrente3DSResponse&gt;']]"
		[Register ("creaNoncePagamentoRicorrente3DS", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/Ricorrenze/ApiCreaNoncePagamentoRicorrente3DSRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void CreaNoncePagamentoRicorrente3DS (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.Ricorrenze.ApiCreaNoncePagamentoRicorrente3DSRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_creaNoncePagamentoRicorrente3DS_Lit_icbpi_XPaySDK_Models_WebApi_Requests_Ricorrenze_ApiCreaNoncePagamentoRicorrente3DSRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_creaNoncePagamentoRicorrente3DS_Lit_icbpi_XPaySDK_Models_WebApi_Requests_Ricorrenze_ApiCreaNoncePagamentoRicorrente3DSRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "creaNoncePagamentoRicorrente3DS", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/Ricorrenze/ApiCreaNoncePagamentoRicorrente3DSRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_creaNoncePagamentoRicorrente3DS_Lit_icbpi_XPaySDK_Models_WebApi_Requests_Ricorrenze_ApiCreaNoncePagamentoRicorrente3DSRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='Ricorrenze']/method[@name='describeContents' and count(parameter)=0]"
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

		static IntPtr id_pagamentoNoShow_Lit_icbpi_XPaySDK_Models_WebApi_Requests_Ricorrenze_ApiPagamentoNoShowRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='Ricorrenze']/method[@name='pagamentoNoShow' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.Ricorrenze.ApiPagamentoNoShowRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.Ricorrenze.ApiPagamentoNoShowResponse&gt;']]"
		[Register ("pagamentoNoShow", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/Ricorrenze/ApiPagamentoNoShowRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void PagamentoNoShow (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.Ricorrenze.ApiPagamentoNoShowRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_pagamentoNoShow_Lit_icbpi_XPaySDK_Models_WebApi_Requests_Ricorrenze_ApiPagamentoNoShowRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_pagamentoNoShow_Lit_icbpi_XPaySDK_Models_WebApi_Requests_Ricorrenze_ApiPagamentoNoShowRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "pagamentoNoShow", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/Ricorrenze/ApiPagamentoNoShowRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pagamentoNoShow_Lit_icbpi_XPaySDK_Models_WebApi_Requests_Ricorrenze_ApiPagamentoNoShowRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_pagamentoRicorrente3DS_Lit_icbpi_XPaySDK_Models_WebApi_Requests_Ricorrenze_ApiPagamentoRicorrente3DSRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='Ricorrenze']/method[@name='pagamentoRicorrente3DS' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.Ricorrenze.ApiPagamentoRicorrente3DSRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.Ricorrenze.ApiPagamentoRicorrente3DSResponse&gt;']]"
		[Register ("pagamentoRicorrente3DS", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/Ricorrenze/ApiPagamentoRicorrente3DSRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void PagamentoRicorrente3DS (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.Ricorrenze.ApiPagamentoRicorrente3DSRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_pagamentoRicorrente3DS_Lit_icbpi_XPaySDK_Models_WebApi_Requests_Ricorrenze_ApiPagamentoRicorrente3DSRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_pagamentoRicorrente3DS_Lit_icbpi_XPaySDK_Models_WebApi_Requests_Ricorrenze_ApiPagamentoRicorrente3DSRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "pagamentoRicorrente3DS", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/Ricorrenze/ApiPagamentoRicorrente3DSRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pagamentoRicorrente3DS_Lit_icbpi_XPaySDK_Models_WebApi_Requests_Ricorrenze_ApiPagamentoRicorrente3DSRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_pagamentoRicorrente_Lit_icbpi_XPaySDK_Models_WebApi_Requests_Ricorrenze_ApiPagamentoRicorrenteRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='Ricorrenze']/method[@name='pagamentoRicorrente' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.Ricorrenze.ApiPagamentoRicorrenteRequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.Ricorrenze.ApiPagamentoRicorrenteResponse&gt;']]"
		[Register ("pagamentoRicorrente", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/Ricorrenze/ApiPagamentoRicorrenteRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void PagamentoRicorrente (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.Ricorrenze.ApiPagamentoRicorrenteRequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_pagamentoRicorrente_Lit_icbpi_XPaySDK_Models_WebApi_Requests_Ricorrenze_ApiPagamentoRicorrenteRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_pagamentoRicorrente_Lit_icbpi_XPaySDK_Models_WebApi_Requests_Ricorrenze_ApiPagamentoRicorrenteRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "pagamentoRicorrente", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/Ricorrenze/ApiPagamentoRicorrenteRequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pagamentoRicorrente_Lit_icbpi_XPaySDK_Models_WebApi_Requests_Ricorrenze_ApiPagamentoRicorrenteRequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_pagamentoRicorrenteMOTO_Lit_icbpi_XPaySDK_Models_WebApi_Requests_Ricorrenze_ApiPagamentoRicorrenteMOTORequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='Ricorrenze']/method[@name='pagamentoRicorrenteMOTO' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.Models.WebApi.Requests.Ricorrenze.ApiPagamentoRicorrenteMOTORequest'] and parameter[2][@type='it.icbpi.XPaySDK.CallBacks.ApiResponseCallback&lt;it.icbpi.XPaySDK.Models.WebApi.Responses.Ricorrenze.ApiPagamentoRicorrenteMOTOResponse&gt;']]"
		[Register ("pagamentoRicorrenteMOTO", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/Ricorrenze/ApiPagamentoRicorrenteMOTORequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V", "")]
		public unsafe void PagamentoRicorrenteMOTO (global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.Ricorrenze.ApiPagamentoRicorrenteMOTORequest p0, global::IT.Icbpi.XPaySDK.CallBacks.IApiResponseCallback p1)
		{
			if (id_pagamentoRicorrenteMOTO_Lit_icbpi_XPaySDK_Models_WebApi_Requests_Ricorrenze_ApiPagamentoRicorrenteMOTORequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ == IntPtr.Zero)
				id_pagamentoRicorrenteMOTO_Lit_icbpi_XPaySDK_Models_WebApi_Requests_Ricorrenze_ApiPagamentoRicorrenteMOTORequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_ = JNIEnv.GetMethodID (class_ref, "pagamentoRicorrenteMOTO", "(Lit/icbpi/XPaySDK/Models/WebApi/Requests/Ricorrenze/ApiPagamentoRicorrenteMOTORequest;Lit/icbpi/XPaySDK/CallBacks/ApiResponseCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pagamentoRicorrenteMOTO_Lit_icbpi_XPaySDK_Models_WebApi_Requests_Ricorrenze_ApiPagamentoRicorrenteMOTORequest_Lit_icbpi_XPaySDK_CallBacks_ApiResponseCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.WebApi.Classes']/class[@name='Ricorrenze']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
