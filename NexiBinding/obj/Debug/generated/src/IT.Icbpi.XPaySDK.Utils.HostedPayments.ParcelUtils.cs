using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Utils.HostedPayments {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.HostedPayments']/class[@name='ParcelUtils']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils", DoNotGenerateAcw=true)]
	public partial class ParcelUtils : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.HostedPayments']/class[@name='ParcelUtils.HPCaller']"
		[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$HPCaller", DoNotGenerateAcw=true)]
		public sealed partial class HPCaller : global::Java.Lang.Enum {


			static IntPtr API_CREA_NONCE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.HostedPayments']/class[@name='ParcelUtils.HPCaller']/field[@name='API_CREA_NONCE']"
			[Register ("API_CREA_NONCE")]
			public static global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.HPCaller ApiCreaNonce {
				get {
					if (API_CREA_NONCE_jfieldId == IntPtr.Zero)
						API_CREA_NONCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "API_CREA_NONCE", "Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$HPCaller;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, API_CREA_NONCE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.HPCaller> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("it/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$HPCaller", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HPCaller); }
			}

			internal HPCaller (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.HostedPayments']/class[@name='ParcelUtils.HPCaller']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$HPCaller;", "")]
			public static unsafe global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.HPCaller ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$HPCaller;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.HPCaller __ret = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.HPCaller> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.HostedPayments']/class[@name='ParcelUtils.HPCaller']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$HPCaller;", "")]
			public static unsafe global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.HPCaller[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$HPCaller;");
				try {
					return (global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.HPCaller[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.HPCaller));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.HostedPayments']/class[@name='ParcelUtils.PrimiPagamentiCaller']"
		[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$PrimiPagamentiCaller", DoNotGenerateAcw=true)]
		public sealed partial class PrimiPagamentiCaller : global::Java.Lang.Enum {


			static IntPtr API_CREA_NONCE_PRIMO_PAGAMENTO_3DS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.HostedPayments']/class[@name='ParcelUtils.PrimiPagamentiCaller']/field[@name='API_CREA_NONCE_PRIMO_PAGAMENTO_3DS']"
			[Register ("API_CREA_NONCE_PRIMO_PAGAMENTO_3DS")]
			public static global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.PrimiPagamentiCaller ApiCreaNoncePrimoPagamento3ds {
				get {
					if (API_CREA_NONCE_PRIMO_PAGAMENTO_3DS_jfieldId == IntPtr.Zero)
						API_CREA_NONCE_PRIMO_PAGAMENTO_3DS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "API_CREA_NONCE_PRIMO_PAGAMENTO_3DS", "Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$PrimiPagamentiCaller;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, API_CREA_NONCE_PRIMO_PAGAMENTO_3DS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.PrimiPagamentiCaller> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr API_CREA_NONCE_VERIFICA_CARTA_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.HostedPayments']/class[@name='ParcelUtils.PrimiPagamentiCaller']/field[@name='API_CREA_NONCE_VERIFICA_CARTA']"
			[Register ("API_CREA_NONCE_VERIFICA_CARTA")]
			public static global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.PrimiPagamentiCaller ApiCreaNonceVerificaCarta {
				get {
					if (API_CREA_NONCE_VERIFICA_CARTA_jfieldId == IntPtr.Zero)
						API_CREA_NONCE_VERIFICA_CARTA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "API_CREA_NONCE_VERIFICA_CARTA", "Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$PrimiPagamentiCaller;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, API_CREA_NONCE_VERIFICA_CARTA_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.PrimiPagamentiCaller> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("it/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$PrimiPagamentiCaller", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PrimiPagamentiCaller); }
			}

			internal PrimiPagamentiCaller (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.HostedPayments']/class[@name='ParcelUtils.PrimiPagamentiCaller']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$PrimiPagamentiCaller;", "")]
			public static unsafe global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.PrimiPagamentiCaller ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$PrimiPagamentiCaller;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.PrimiPagamentiCaller __ret = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.PrimiPagamentiCaller> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.HostedPayments']/class[@name='ParcelUtils.PrimiPagamentiCaller']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$PrimiPagamentiCaller;", "")]
			public static unsafe global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.PrimiPagamentiCaller[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$PrimiPagamentiCaller;");
				try {
					return (global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.PrimiPagamentiCaller[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.PrimiPagamentiCaller));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.HostedPayments']/class[@name='ParcelUtils.RicorrenzeCaller']"
		[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$RicorrenzeCaller", DoNotGenerateAcw=true)]
		public sealed partial class RicorrenzeCaller : global::Java.Lang.Enum {


			static IntPtr API_CREA_NONCE_PAGA_RICO_3DS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.HostedPayments']/class[@name='ParcelUtils.RicorrenzeCaller']/field[@name='API_CREA_NONCE_PAGA_RICO_3DS']"
			[Register ("API_CREA_NONCE_PAGA_RICO_3DS")]
			public static global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.RicorrenzeCaller ApiCreaNoncePagaRico3ds {
				get {
					if (API_CREA_NONCE_PAGA_RICO_3DS_jfieldId == IntPtr.Zero)
						API_CREA_NONCE_PAGA_RICO_3DS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "API_CREA_NONCE_PAGA_RICO_3DS", "Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$RicorrenzeCaller;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, API_CREA_NONCE_PAGA_RICO_3DS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.RicorrenzeCaller> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("it/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$RicorrenzeCaller", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RicorrenzeCaller); }
			}

			internal RicorrenzeCaller (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.HostedPayments']/class[@name='ParcelUtils.RicorrenzeCaller']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$RicorrenzeCaller;", "")]
			public static unsafe global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.RicorrenzeCaller ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$RicorrenzeCaller;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.RicorrenzeCaller __ret = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.RicorrenzeCaller> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.HostedPayments']/class[@name='ParcelUtils.RicorrenzeCaller']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$RicorrenzeCaller;", "")]
			public static unsafe global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.RicorrenzeCaller[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lit/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils$RicorrenzeCaller;");
				try {
					return (global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.RicorrenzeCaller[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IT.Icbpi.XPaySDK.Utils.HostedPayments.ParcelUtils.RicorrenzeCaller));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Utils/HostedPayments/ParcelUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParcelUtils); }
		}

		protected ParcelUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.HostedPayments']/class[@name='ParcelUtils']/constructor[@name='ParcelUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ParcelUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ParcelUtils)) {
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
