using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Models.WebViewClients {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients']/class[@name='BaseWebViewClientQP']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Models/WebViewClients/BaseWebViewClientQP", DoNotGenerateAcw=true)]
	public partial class BaseWebViewClientQP : global::Android.Webkit.WebViewClient {


		static IntPtr activity_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients']/class[@name='BaseWebViewClientQP']/field[@name='activity']"
		[Register ("activity")]
		protected global::Android.App.Activity Activity {
			get {
				if (activity_jfieldId == IntPtr.Zero)
					activity_jfieldId = JNIEnv.GetFieldID (class_ref, "activity", "Landroid/app/Activity;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, activity_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (activity_jfieldId == IntPtr.Zero)
					activity_jfieldId = JNIEnv.GetFieldID (class_ref, "activity", "Landroid/app/Activity;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, activity_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr frontOffice_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients']/class[@name='BaseWebViewClientQP']/field[@name='frontOffice']"
		[Register ("frontOffice")]
		protected global::IT.Icbpi.XPaySDK.WebApi.Classes.FrontOffice FrontOffice {
			get {
				if (frontOffice_jfieldId == IntPtr.Zero)
					frontOffice_jfieldId = JNIEnv.GetFieldID (class_ref, "frontOffice", "Lit/icbpi/XPaySDK/WebApi/Classes/FrontOffice;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, frontOffice_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.WebApi.Classes.FrontOffice> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (frontOffice_jfieldId == IntPtr.Zero)
					frontOffice_jfieldId = JNIEnv.GetFieldID (class_ref, "frontOffice", "Lit/icbpi/XPaySDK/WebApi/Classes/FrontOffice;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, frontOffice_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr hostedPayments_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients']/class[@name='BaseWebViewClientQP']/field[@name='hostedPayments']"
		[Register ("hostedPayments")]
		protected global::IT.Icbpi.XPaySDK.WebApi.Classes.PaymentHost HostedPayments {
			get {
				if (hostedPayments_jfieldId == IntPtr.Zero)
					hostedPayments_jfieldId = JNIEnv.GetFieldID (class_ref, "hostedPayments", "Lit/icbpi/XPaySDK/WebApi/Classes/HostedPayments;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, hostedPayments_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.WebApi.Classes.PaymentHost> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (hostedPayments_jfieldId == IntPtr.Zero)
					hostedPayments_jfieldId = JNIEnv.GetFieldID (class_ref, "hostedPayments", "Lit/icbpi/XPaySDK/WebApi/Classes/HostedPayments;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, hostedPayments_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr primiPagamentiRecurring_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients']/class[@name='BaseWebViewClientQP']/field[@name='primiPagamentiRecurring']"
		[Register ("primiPagamentiRecurring")]
		protected global::IT.Icbpi.XPaySDK.WebApi.Classes.PrimiPagamentiRecurring PrimiPagamentiRecurring {
			get {
				if (primiPagamentiRecurring_jfieldId == IntPtr.Zero)
					primiPagamentiRecurring_jfieldId = JNIEnv.GetFieldID (class_ref, "primiPagamentiRecurring", "Lit/icbpi/XPaySDK/WebApi/Classes/PrimiPagamentiRecurring;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, primiPagamentiRecurring_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.WebApi.Classes.PrimiPagamentiRecurring> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (primiPagamentiRecurring_jfieldId == IntPtr.Zero)
					primiPagamentiRecurring_jfieldId = JNIEnv.GetFieldID (class_ref, "primiPagamentiRecurring", "Lit/icbpi/XPaySDK/WebApi/Classes/PrimiPagamentiRecurring;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, primiPagamentiRecurring_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr ricorrenze_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients']/class[@name='BaseWebViewClientQP']/field[@name='ricorrenze']"
		[Register ("ricorrenze")]
		protected global::IT.Icbpi.XPaySDK.WebApi.Classes.Ricorrenze Ricorrenze {
			get {
				if (ricorrenze_jfieldId == IntPtr.Zero)
					ricorrenze_jfieldId = JNIEnv.GetFieldID (class_ref, "ricorrenze", "Lit/icbpi/XPaySDK/WebApi/Classes/Ricorrenze;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, ricorrenze_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.WebApi.Classes.Ricorrenze> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ricorrenze_jfieldId == IntPtr.Zero)
					ricorrenze_jfieldId = JNIEnv.GetFieldID (class_ref, "ricorrenze", "Lit/icbpi/XPaySDK/WebApi/Classes/Ricorrenze;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, ricorrenze_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Models/WebViewClients/BaseWebViewClientQP", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseWebViewClientQP); }
		}

		protected BaseWebViewClientQP (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_Ricorrenze_Landroid_app_Activity_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients']/class[@name='BaseWebViewClientQP']/constructor[@name='BaseWebViewClientQP' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.WebApi.Classes.Ricorrenze'] and parameter[2][@type='android.app.Activity']]"
		[Register (".ctor", "(Lit/icbpi/XPaySDK/WebApi/Classes/Ricorrenze;Landroid/app/Activity;)V", "")]
		public unsafe BaseWebViewClientQP (global::IT.Icbpi.XPaySDK.WebApi.Classes.Ricorrenze p0, global::Android.App.Activity p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (BaseWebViewClientQP)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lit/icbpi/XPaySDK/WebApi/Classes/Ricorrenze;Landroid/app/Activity;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lit/icbpi/XPaySDK/WebApi/Classes/Ricorrenze;Landroid/app/Activity;)V", __args);
					return;
				}

				if (id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_Ricorrenze_Landroid_app_Activity_ == IntPtr.Zero)
					id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_Ricorrenze_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lit/icbpi/XPaySDK/WebApi/Classes/Ricorrenze;Landroid/app/Activity;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_Ricorrenze_Landroid_app_Activity_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_Ricorrenze_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_PrimiPagamentiRecurring_Landroid_app_Activity_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients']/class[@name='BaseWebViewClientQP']/constructor[@name='BaseWebViewClientQP' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.WebApi.Classes.PrimiPagamentiRecurring'] and parameter[2][@type='android.app.Activity']]"
		[Register (".ctor", "(Lit/icbpi/XPaySDK/WebApi/Classes/PrimiPagamentiRecurring;Landroid/app/Activity;)V", "")]
		public unsafe BaseWebViewClientQP (global::IT.Icbpi.XPaySDK.WebApi.Classes.PrimiPagamentiRecurring p0, global::Android.App.Activity p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (BaseWebViewClientQP)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lit/icbpi/XPaySDK/WebApi/Classes/PrimiPagamentiRecurring;Landroid/app/Activity;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lit/icbpi/XPaySDK/WebApi/Classes/PrimiPagamentiRecurring;Landroid/app/Activity;)V", __args);
					return;
				}

				if (id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_PrimiPagamentiRecurring_Landroid_app_Activity_ == IntPtr.Zero)
					id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_PrimiPagamentiRecurring_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lit/icbpi/XPaySDK/WebApi/Classes/PrimiPagamentiRecurring;Landroid/app/Activity;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_PrimiPagamentiRecurring_Landroid_app_Activity_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_PrimiPagamentiRecurring_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_HostedPayments_Landroid_app_Activity_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients']/class[@name='BaseWebViewClientQP']/constructor[@name='BaseWebViewClientQP' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.WebApi.Classes.HostedPayments'] and parameter[2][@type='android.app.Activity']]"
		[Register (".ctor", "(Lit/icbpi/XPaySDK/WebApi/Classes/HostedPayments;Landroid/app/Activity;)V", "")]
		public unsafe BaseWebViewClientQP (global::IT.Icbpi.XPaySDK.WebApi.Classes.PaymentHost p0, global::Android.App.Activity p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (BaseWebViewClientQP)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lit/icbpi/XPaySDK/WebApi/Classes/HostedPayments;Landroid/app/Activity;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lit/icbpi/XPaySDK/WebApi/Classes/HostedPayments;Landroid/app/Activity;)V", __args);
					return;
				}

				if (id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_HostedPayments_Landroid_app_Activity_ == IntPtr.Zero)
					id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_HostedPayments_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lit/icbpi/XPaySDK/WebApi/Classes/HostedPayments;Landroid/app/Activity;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_HostedPayments_Landroid_app_Activity_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_HostedPayments_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_FrontOffice_Landroid_app_Activity_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients']/class[@name='BaseWebViewClientQP']/constructor[@name='BaseWebViewClientQP' and count(parameter)=2 and parameter[1][@type='it.icbpi.XPaySDK.WebApi.Classes.FrontOffice'] and parameter[2][@type='android.app.Activity']]"
		[Register (".ctor", "(Lit/icbpi/XPaySDK/WebApi/Classes/FrontOffice;Landroid/app/Activity;)V", "")]
		public unsafe BaseWebViewClientQP (global::IT.Icbpi.XPaySDK.WebApi.Classes.FrontOffice p0, global::Android.App.Activity p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (BaseWebViewClientQP)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lit/icbpi/XPaySDK/WebApi/Classes/FrontOffice;Landroid/app/Activity;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lit/icbpi/XPaySDK/WebApi/Classes/FrontOffice;Landroid/app/Activity;)V", __args);
					return;
				}

				if (id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_FrontOffice_Landroid_app_Activity_ == IntPtr.Zero)
					id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_FrontOffice_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lit/icbpi/XPaySDK/WebApi/Classes/FrontOffice;Landroid/app/Activity;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_FrontOffice_Landroid_app_Activity_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lit_icbpi_XPaySDK_WebApi_Classes_FrontOffice_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static Delegate cb_castToResponse_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCastToResponse_Ljava_lang_String_Handler ()
		{
			if (cb_castToResponse_Ljava_lang_String_ == null)
				cb_castToResponse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CastToResponse_Ljava_lang_String_);
			return cb_castToResponse_Ljava_lang_String_;
		}

		static IntPtr n_CastToResponse_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IT.Icbpi.XPaySDK.Models.WebViewClients.BaseWebViewClientQP __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebViewClients.BaseWebViewClientQP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CastToResponse (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_castToResponse_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients']/class[@name='BaseWebViewClientQP']/method[@name='castToResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("castToResponse", "(Ljava/lang/String;)Lit/icbpi/XPaySDK/Models/WebApi/Responses/FrontOffice/ApiFrontOfficeQPResponse;", "GetCastToResponse_Ljava_lang_String_Handler")]
		protected virtual unsafe global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeQPResponse CastToResponse (string p0)
		{
			if (id_castToResponse_Ljava_lang_String_ == IntPtr.Zero)
				id_castToResponse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "castToResponse", "(Ljava/lang/String;)Lit/icbpi/XPaySDK/Models/WebApi/Responses/FrontOffice/ApiFrontOfficeQPResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeQPResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeQPResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_castToResponse_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Responses.FrontOffice.ApiFrontOfficeQPResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "castToResponse", "(Ljava/lang/String;)Lit/icbpi/XPaySDK/Models/WebApi/Responses/FrontOffice/ApiFrontOfficeQPResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_castXPayProtocol_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCastXPayProtocol_Ljava_lang_String_Handler ()
		{
			if (cb_castXPayProtocol_Ljava_lang_String_ == null)
				cb_castXPayProtocol_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CastXPayProtocol_Ljava_lang_String_);
			return cb_castXPayProtocol_Ljava_lang_String_;
		}

		static void n_CastXPayProtocol_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IT.Icbpi.XPaySDK.Models.WebViewClients.BaseWebViewClientQP __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebViewClients.BaseWebViewClientQP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CastXPayProtocol (p0);
		}
#pragma warning restore 0169

		static IntPtr id_castXPayProtocol_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Models.WebViewClients']/class[@name='BaseWebViewClientQP']/method[@name='castXPayProtocol' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("castXPayProtocol", "(Ljava/lang/String;)V", "GetCastXPayProtocol_Ljava_lang_String_Handler")]
		protected virtual unsafe void CastXPayProtocol (string p0)
		{
			if (id_castXPayProtocol_Ljava_lang_String_ == IntPtr.Zero)
				id_castXPayProtocol_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "castXPayProtocol", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_castXPayProtocol_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "castXPayProtocol", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
