using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Models.WebApi.Requests.BackOffice {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.BackOffice']/class[@name='ApiReportOrdiniRequest']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Models/WebApi/Requests/BackOffice/ApiReportOrdiniRequest", DoNotGenerateAcw=true)]
	public partial class ApiReportOrdiniRequest : global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.ApiBaseRequest {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Models/WebApi/Requests/BackOffice/ApiReportOrdiniRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApiReportOrdiniRequest); }
		}

		protected ApiReportOrdiniRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_util_Date_Ljava_util_Date_Lit_icbpi_XPaySDK_Utils_BackOffice_ReportOrdiniUtils_Channel_arrayLit_icbpi_XPaySDK_Utils_BackOffice_ReportOrdiniUtils_Status_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.BackOffice']/class[@name='ApiReportOrdiniRequest']/constructor[@name='ApiReportOrdiniRequest' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Date'] and parameter[3][@type='java.util.Date'] and parameter[4][@type='it.icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Channel'] and parameter[5][@type='it.icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Status[]'] and parameter[6][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/Date;Ljava/util/Date;Lit/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Channel;[Lit/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Status;Ljava/lang/String;)V", "")]
		public unsafe ApiReportOrdiniRequest (string p0, global::Java.Util.Date p1, global::Java.Util.Date p2, global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Channel p3, global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Status[] p4, string p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				if (((object) this).GetType () != typeof (ApiReportOrdiniRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/util/Date;Ljava/util/Date;Lit/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Channel;[Lit/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Status;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/util/Date;Ljava/util/Date;Lit/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Channel;[Lit/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Status;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_util_Date_Ljava_util_Date_Lit_icbpi_XPaySDK_Utils_BackOffice_ReportOrdiniUtils_Channel_arrayLit_icbpi_XPaySDK_Utils_BackOffice_ReportOrdiniUtils_Status_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_util_Date_Ljava_util_Date_Lit_icbpi_XPaySDK_Utils_BackOffice_ReportOrdiniUtils_Channel_arrayLit_icbpi_XPaySDK_Utils_BackOffice_ReportOrdiniUtils_Status_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/util/Date;Ljava/util/Date;Lit/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Channel;[Lit/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Status;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_util_Date_Ljava_util_Date_Lit_icbpi_XPaySDK_Utils_BackOffice_ReportOrdiniUtils_Channel_arrayLit_icbpi_XPaySDK_Utils_BackOffice_ReportOrdiniUtils_Status_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_util_Date_Ljava_util_Date_Lit_icbpi_XPaySDK_Utils_BackOffice_ReportOrdiniUtils_Channel_arrayLit_icbpi_XPaySDK_Utils_BackOffice_ReportOrdiniUtils_Status_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_getChannel;
#pragma warning disable 0169
		static Delegate GetGetChannelHandler ()
		{
			if (cb_getChannel == null)
				cb_getChannel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChannel);
			return cb_getChannel;
		}

		static IntPtr n_GetChannel (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.BackOffice.ApiReportOrdiniRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.BackOffice.ApiReportOrdiniRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Channel);
		}
#pragma warning restore 0169

		static IntPtr id_getChannel;
		public virtual unsafe string Channel {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.BackOffice']/class[@name='ApiReportOrdiniRequest']/method[@name='getChannel' and count(parameter)=0]"
			[Register ("getChannel", "()Ljava/lang/String;", "GetGetChannelHandler")]
			get {
				if (id_getChannel == IntPtr.Zero)
					id_getChannel = JNIEnv.GetMethodID (class_ref, "getChannel", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannel), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannel", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCodTrans;
#pragma warning disable 0169
		static Delegate GetGetCodTransHandler ()
		{
			if (cb_getCodTrans == null)
				cb_getCodTrans = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCodTrans);
			return cb_getCodTrans;
		}

		static IntPtr n_GetCodTrans (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.BackOffice.ApiReportOrdiniRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.BackOffice.ApiReportOrdiniRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CodTrans);
		}
#pragma warning restore 0169

		static IntPtr id_getCodTrans;
		public virtual unsafe string CodTrans {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.BackOffice']/class[@name='ApiReportOrdiniRequest']/method[@name='getCodTrans' and count(parameter)=0]"
			[Register ("getCodTrans", "()Ljava/lang/String;", "GetGetCodTransHandler")]
			get {
				if (id_getCodTrans == IntPtr.Zero)
					id_getCodTrans = JNIEnv.GetMethodID (class_ref, "getCodTrans", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCodTrans), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCodTrans", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getInterval;
#pragma warning disable 0169
		static Delegate GetGetIntervalHandler ()
		{
			if (cb_getInterval == null)
				cb_getInterval = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInterval);
			return cb_getInterval;
		}

		static IntPtr n_GetInterval (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.BackOffice.ApiReportOrdiniRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.BackOffice.ApiReportOrdiniRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Interval);
		}
#pragma warning restore 0169

		static IntPtr id_getInterval;
		public virtual unsafe string Interval {
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.BackOffice']/class[@name='ApiReportOrdiniRequest']/method[@name='getInterval' and count(parameter)=0]"
			[Register ("getInterval", "()Ljava/lang/String;", "GetGetIntervalHandler")]
			get {
				if (id_getInterval == IntPtr.Zero)
					id_getInterval = JNIEnv.GetMethodID (class_ref, "getInterval", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInterval), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInterval", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStatuses;
#pragma warning disable 0169
		static Delegate GetGetStatusesHandler ()
		{
			if (cb_getStatuses == null)
				cb_getStatuses = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStatuses);
			return cb_getStatuses;
		}

		static IntPtr n_GetStatuses (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.BackOffice.ApiReportOrdiniRequest __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Requests.BackOffice.ApiReportOrdiniRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetStatuses ());
		}
#pragma warning restore 0169

		static IntPtr id_getStatuses;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebApi.Requests.BackOffice']/class[@name='ApiReportOrdiniRequest']/method[@name='getStatuses' and count(parameter)=0]"
		[Register ("getStatuses", "()[Ljava/lang/String;", "GetGetStatusesHandler")]
		public virtual unsafe string[] GetStatuses ()
		{
			if (id_getStatuses == IntPtr.Zero)
				id_getStatuses = JNIEnv.GetMethodID (class_ref, "getStatuses", "()[Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStatuses), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatuses", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

	}
}
