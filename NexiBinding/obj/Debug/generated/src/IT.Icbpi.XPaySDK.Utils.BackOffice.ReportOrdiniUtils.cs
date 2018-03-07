using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Utils.BackOffice {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.BackOffice']/class[@name='ReportOrdiniUtils']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils", DoNotGenerateAcw=true)]
	public partial class ReportOrdiniUtils : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.BackOffice']/class[@name='ReportOrdiniUtils.Channel']"
		[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Channel", DoNotGenerateAcw=true)]
		public sealed partial class Channel : global::Java.Lang.Enum {


			static IntPtr ALL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.BackOffice']/class[@name='ReportOrdiniUtils.Channel']/field[@name='ALL']"
			[Register ("ALL")]
			public static global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Channel All {
				get {
					if (ALL_jfieldId == IntPtr.Zero)
						ALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALL", "Lit/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Channel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Channel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CREDIT_CARD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.BackOffice']/class[@name='ReportOrdiniUtils.Channel']/field[@name='CREDIT_CARD']"
			[Register ("CREDIT_CARD")]
			public static global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Channel CreditCard {
				get {
					if (CREDIT_CARD_jfieldId == IntPtr.Zero)
						CREDIT_CARD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREDIT_CARD", "Lit/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Channel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREDIT_CARD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Channel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MYBANK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.BackOffice']/class[@name='ReportOrdiniUtils.Channel']/field[@name='MYBANK']"
			[Register ("MYBANK")]
			public static global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Channel Mybank {
				get {
					if (MYBANK_jfieldId == IntPtr.Zero)
						MYBANK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MYBANK", "Lit/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Channel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MYBANK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Channel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MYSI_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.BackOffice']/class[@name='ReportOrdiniUtils.Channel']/field[@name='MYSI']"
			[Register ("MYSI")]
			public static global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Channel Mysi {
				get {
					if (MYSI_jfieldId == IntPtr.Zero)
						MYSI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MYSI", "Lit/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Channel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MYSI_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Channel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PAYPAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.BackOffice']/class[@name='ReportOrdiniUtils.Channel']/field[@name='PAYPAL']"
			[Register ("PAYPAL")]
			public static global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Channel Paypal {
				get {
					if (PAYPAL_jfieldId == IntPtr.Zero)
						PAYPAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAYPAL", "Lit/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Channel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PAYPAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Channel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("it/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Channel", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Channel); }
			}

			internal Channel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.BackOffice']/class[@name='ReportOrdiniUtils.Channel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lit/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Channel;", "")]
			public static unsafe global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Channel ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lit/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Channel;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Channel __ret = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Channel> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.BackOffice']/class[@name='ReportOrdiniUtils.Channel']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lit/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Channel;", "")]
			public static unsafe global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Channel[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lit/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Channel;");
				try {
					return (global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Channel[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Channel));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.BackOffice']/class[@name='ReportOrdiniUtils.Status']"
		[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Status", DoNotGenerateAcw=true)]
		public sealed partial class Status : global::Java.Lang.Enum {


			static IntPtr AUTHORIZED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.BackOffice']/class[@name='ReportOrdiniUtils.Status']/field[@name='AUTHORIZED']"
			[Register ("AUTHORIZED")]
			public static global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Status Authorized {
				get {
					if (AUTHORIZED_jfieldId == IntPtr.Zero)
						AUTHORIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTHORIZED", "Lit/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTHORIZED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BUILT_IN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.BackOffice']/class[@name='ReportOrdiniUtils.Status']/field[@name='BUILT_IN']"
			[Register ("BUILT_IN")]
			public static global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Status BuiltIn {
				get {
					if (BUILT_IN_jfieldId == IntPtr.Zero)
						BUILT_IN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BUILT_IN", "Lit/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BUILT_IN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BUILT_PARTIAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.BackOffice']/class[@name='ReportOrdiniUtils.Status']/field[@name='BUILT_PARTIAL']"
			[Register ("BUILT_PARTIAL")]
			public static global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Status BuiltPartial {
				get {
					if (BUILT_PARTIAL_jfieldId == IntPtr.Zero)
						BUILT_PARTIAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BUILT_PARTIAL", "Lit/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BUILT_PARTIAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CANCELED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.BackOffice']/class[@name='ReportOrdiniUtils.Status']/field[@name='CANCELED']"
			[Register ("CANCELED")]
			public static global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Status Canceled {
				get {
					if (CANCELED_jfieldId == IntPtr.Zero)
						CANCELED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANCELED", "Lit/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CANCELED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NOT_CREATED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.BackOffice']/class[@name='ReportOrdiniUtils.Status']/field[@name='NOT_CREATED']"
			[Register ("NOT_CREATED")]
			public static global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Status NotCreated {
				get {
					if (NOT_CREATED_jfieldId == IntPtr.Zero)
						NOT_CREATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_CREATED", "Lit/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOT_CREATED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PARTIAL_REFUND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.BackOffice']/class[@name='ReportOrdiniUtils.Status']/field[@name='PARTIAL_REFUND']"
			[Register ("PARTIAL_REFUND")]
			public static global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Status PartialRefund {
				get {
					if (PARTIAL_REFUND_jfieldId == IntPtr.Zero)
						PARTIAL_REFUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PARTIAL_REFUND", "Lit/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PARTIAL_REFUND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REFUNDED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.BackOffice']/class[@name='ReportOrdiniUtils.Status']/field[@name='REFUNDED']"
			[Register ("REFUNDED")]
			public static global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Status Refunded {
				get {
					if (REFUNDED_jfieldId == IntPtr.Zero)
						REFUNDED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REFUNDED", "Lit/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REFUNDED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNAUTHORIZED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.BackOffice']/class[@name='ReportOrdiniUtils.Status']/field[@name='UNAUTHORIZED']"
			[Register ("UNAUTHORIZED")]
			public static global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Status Unauthorized {
				get {
					if (UNAUTHORIZED_jfieldId == IntPtr.Zero)
						UNAUTHORIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNAUTHORIZED", "Lit/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNAUTHORIZED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("it/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Status", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Status); }
			}

			internal Status (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.BackOffice']/class[@name='ReportOrdiniUtils.Status']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lit/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Status;", "")]
			public static unsafe global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Status ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lit/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Status;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Status __ret = global::Java.Lang.Object.GetObject<global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Status> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.BackOffice']/class[@name='ReportOrdiniUtils.Status']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lit/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Status;", "")]
			public static unsafe global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Status[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lit/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils$Status;");
				try {
					return (global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Status[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IT.Icbpi.XPaySDK.Utils.BackOffice.ReportOrdiniUtils.Status));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Utils/BackOffice/ReportOrdiniUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ReportOrdiniUtils); }
		}

		protected ReportOrdiniUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils.BackOffice']/class[@name='ReportOrdiniUtils']/constructor[@name='ReportOrdiniUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ReportOrdiniUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ReportOrdiniUtils)) {
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
