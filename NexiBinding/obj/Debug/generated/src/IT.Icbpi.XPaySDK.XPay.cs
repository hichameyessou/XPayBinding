using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK']/class[@name='XPay']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/XPay", DoNotGenerateAcw=true)]
	public partial class XPay : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr BackOffice_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK']/class[@name='XPay']/field[@name='BackOffice']"
		[Register ("BackOffice")]
		public global::IT.Icbpi.XPaySDK.WebApi.Classes.BackOffice BackOffice {
			get {
				if (BackOffice_jfieldId == IntPtr.Zero)
					BackOffice_jfieldId = JNIEnv.GetFieldID (class_ref, "BackOffice", "Lit/icbpi/XPaySDK/WebApi/Classes/BackOffice;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, BackOffice_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.WebApi.Classes.BackOffice> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (BackOffice_jfieldId == IntPtr.Zero)
					BackOffice_jfieldId = JNIEnv.GetFieldID (class_ref, "BackOffice", "Lit/icbpi/XPaySDK/WebApi/Classes/BackOffice;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, BackOffice_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK']/class[@name='XPay']/field[@name='CONTENT_TYPE']"
		[Register ("CONTENT_TYPE")]
		public const string ContentType = (string) "application/json";

		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK']/class[@name='XPay']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ControlliSicurezza_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK']/class[@name='XPay']/field[@name='ControlliSicurezza']"
		[Register ("ControlliSicurezza")]
		public global::IT.Icbpi.XPaySDK.WebApi.Classes.ControlliSicurezza ControlliSicurezza {
			get {
				if (ControlliSicurezza_jfieldId == IntPtr.Zero)
					ControlliSicurezza_jfieldId = JNIEnv.GetFieldID (class_ref, "ControlliSicurezza", "Lit/icbpi/XPaySDK/WebApi/Classes/ControlliSicurezza;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, ControlliSicurezza_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.WebApi.Classes.ControlliSicurezza> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ControlliSicurezza_jfieldId == IntPtr.Zero)
					ControlliSicurezza_jfieldId = JNIEnv.GetFieldID (class_ref, "ControlliSicurezza", "Lit/icbpi/XPaySDK/WebApi/Classes/ControlliSicurezza;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, ControlliSicurezza_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr FrontOffice_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK']/class[@name='XPay']/field[@name='FrontOffice']"
		[Register ("FrontOffice")]
		public global::IT.Icbpi.XPaySDK.WebApi.Classes.FrontOffice FrontOffice {
			get {
				if (FrontOffice_jfieldId == IntPtr.Zero)
					FrontOffice_jfieldId = JNIEnv.GetFieldID (class_ref, "FrontOffice", "Lit/icbpi/XPaySDK/WebApi/Classes/FrontOffice;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, FrontOffice_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.WebApi.Classes.FrontOffice> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (FrontOffice_jfieldId == IntPtr.Zero)
					FrontOffice_jfieldId = JNIEnv.GetFieldID (class_ref, "FrontOffice", "Lit/icbpi/XPaySDK/WebApi/Classes/FrontOffice;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, FrontOffice_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr GestioneContratti_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK']/class[@name='XPay']/field[@name='GestioneContratti']"
		[Register ("GestioneContratti")]
		public global::IT.Icbpi.XPaySDK.WebApi.Classes.GestioneContratti GestioneContratti {
			get {
				if (GestioneContratti_jfieldId == IntPtr.Zero)
					GestioneContratti_jfieldId = JNIEnv.GetFieldID (class_ref, "GestioneContratti", "Lit/icbpi/XPaySDK/WebApi/Classes/GestioneContratti;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, GestioneContratti_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.WebApi.Classes.GestioneContratti> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (GestioneContratti_jfieldId == IntPtr.Zero)
					GestioneContratti_jfieldId = JNIEnv.GetFieldID (class_ref, "GestioneContratti", "Lit/icbpi/XPaySDK/WebApi/Classes/GestioneContratti;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, GestioneContratti_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr HostedPayments_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK']/class[@name='XPay']/field[@name='HostedPayments']"
		[Register ("HostedPayments")]
		public global::IT.Icbpi.XPaySDK.WebApi.Classes.PaymentHost HostedPayments {
			get {
				if (HostedPayments_jfieldId == IntPtr.Zero)
					HostedPayments_jfieldId = JNIEnv.GetFieldID (class_ref, "HostedPayments", "Lit/icbpi/XPaySDK/WebApi/Classes/HostedPayments;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, HostedPayments_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.WebApi.Classes.PaymentHost> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (HostedPayments_jfieldId == IntPtr.Zero)
					HostedPayments_jfieldId = JNIEnv.GetFieldID (class_ref, "HostedPayments", "Lit/icbpi/XPaySDK/WebApi/Classes/HostedPayments;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, HostedPayments_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr PagamentiSincroni_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK']/class[@name='XPay']/field[@name='PagamentiSincroni']"
		[Register ("PagamentiSincroni")]
		public global::IT.Icbpi.XPaySDK.WebApi.Classes.PagamentiSincroni PagamentiSincroni {
			get {
				if (PagamentiSincroni_jfieldId == IntPtr.Zero)
					PagamentiSincroni_jfieldId = JNIEnv.GetFieldID (class_ref, "PagamentiSincroni", "Lit/icbpi/XPaySDK/WebApi/Classes/PagamentiSincroni;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, PagamentiSincroni_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.WebApi.Classes.PagamentiSincroni> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PagamentiSincroni_jfieldId == IntPtr.Zero)
					PagamentiSincroni_jfieldId = JNIEnv.GetFieldID (class_ref, "PagamentiSincroni", "Lit/icbpi/XPaySDK/WebApi/Classes/PagamentiSincroni;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, PagamentiSincroni_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr PrimiPagamentiRecurring_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK']/class[@name='XPay']/field[@name='PrimiPagamentiRecurring']"
		[Register ("PrimiPagamentiRecurring")]
		public global::IT.Icbpi.XPaySDK.WebApi.Classes.PrimiPagamentiRecurring PrimiPagamentiRecurring {
			get {
				if (PrimiPagamentiRecurring_jfieldId == IntPtr.Zero)
					PrimiPagamentiRecurring_jfieldId = JNIEnv.GetFieldID (class_ref, "PrimiPagamentiRecurring", "Lit/icbpi/XPaySDK/WebApi/Classes/PrimiPagamentiRecurring;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, PrimiPagamentiRecurring_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.WebApi.Classes.PrimiPagamentiRecurring> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PrimiPagamentiRecurring_jfieldId == IntPtr.Zero)
					PrimiPagamentiRecurring_jfieldId = JNIEnv.GetFieldID (class_ref, "PrimiPagamentiRecurring", "Lit/icbpi/XPaySDK/WebApi/Classes/PrimiPagamentiRecurring;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, PrimiPagamentiRecurring_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr Ricorrenze_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK']/class[@name='XPay']/field[@name='Ricorrenze']"
		[Register ("Ricorrenze")]
		public global::IT.Icbpi.XPaySDK.WebApi.Classes.Ricorrenze Ricorrenze {
			get {
				if (Ricorrenze_jfieldId == IntPtr.Zero)
					Ricorrenze_jfieldId = JNIEnv.GetFieldID (class_ref, "Ricorrenze", "Lit/icbpi/XPaySDK/WebApi/Classes/Ricorrenze;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, Ricorrenze_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.WebApi.Classes.Ricorrenze> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (Ricorrenze_jfieldId == IntPtr.Zero)
					Ricorrenze_jfieldId = JNIEnv.GetFieldID (class_ref, "Ricorrenze", "Lit/icbpi/XPaySDK/WebApi/Classes/Ricorrenze;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, Ricorrenze_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr Varie_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK']/class[@name='XPay']/field[@name='Varie']"
		[Register ("Varie")]
		public global::IT.Icbpi.XPaySDK.WebApi.Classes.Varie Varie {
			get {
				if (Varie_jfieldId == IntPtr.Zero)
					Varie_jfieldId = JNIEnv.GetFieldID (class_ref, "Varie", "Lit/icbpi/XPaySDK/WebApi/Classes/Varie;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, Varie_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.WebApi.Classes.Varie> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (Varie_jfieldId == IntPtr.Zero)
					Varie_jfieldId = JNIEnv.GetFieldID (class_ref, "Varie", "Lit/icbpi/XPaySDK/WebApi/Classes/Varie;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, Varie_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr macConfig_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK']/class[@name='XPay']/field[@name='macConfig']"
		[Register ("macConfig")]
		public static global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig MacConfig {
			get {
				if (macConfig_jfieldId == IntPtr.Zero)
					macConfig_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "macConfig", "Lit/icbpi/XPaySDK/Models/WebApi/Config/MacConfig;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, macConfig_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Models.WebApi.Config.MacConfig> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (macConfig_jfieldId == IntPtr.Zero)
					macConfig_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "macConfig", "Lit/icbpi/XPaySDK/Models/WebApi/Config/MacConfig;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, macConfig_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/XPay", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (XPay); }
		}

		protected XPay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK']/class[@name='XPay']/constructor[@name='XPay' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe XPay (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (XPay)) {
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

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK']/class[@name='XPay']/constructor[@name='XPay' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public unsafe XPay (global::Android.Content.Context p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (XPay)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::IT.Icbpi.XPaySDK.XPay __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.XPay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK']/class[@name='XPay']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::IT.Icbpi.XPaySDK.XPay __this = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.XPay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK']/class[@name='XPay']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
			} finally {
			}
		}

	}
}
