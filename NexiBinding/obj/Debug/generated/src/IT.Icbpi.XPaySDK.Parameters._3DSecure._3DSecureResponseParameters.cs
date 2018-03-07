using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Parameters._3DSecure {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters._3DSecure']/class[@name='_3DSecureResponseParameters']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Parameters/_3DSecure/_3DSecureResponseParameters", DoNotGenerateAcw=true)]
	public partial class _3DSecureResponseParameters : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters._3DSecure']/class[@name='_3DSecureResponseParameters']/field[@name='CODE']"
		[Register ("CODE")]
		public const string Code = (string) "codice";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters._3DSecure']/class[@name='_3DSecureResponseParameters']/field[@name='ID_OPERATION']"
		[Register ("ID_OPERATION")]
		public const string IdOperation = (string) "idOperazione";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters._3DSecure']/class[@name='_3DSecureResponseParameters']/field[@name='MAC']"
		[Register ("MAC")]
		public const string Mac = (string) "mac";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters._3DSecure']/class[@name='_3DSecureResponseParameters']/field[@name='MESSAGE']"
		[Register ("MESSAGE")]
		public const string Message = (string) "messaggio";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters._3DSecure']/class[@name='_3DSecureResponseParameters']/field[@name='NONCE']"
		[Register ("NONCE")]
		public const string Nonce = (string) "xpayNonce";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters._3DSecure']/class[@name='_3DSecureResponseParameters']/field[@name='RESULT']"
		[Register ("RESULT")]
		public const string Result = (string) "esito";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters._3DSecure']/class[@name='_3DSecureResponseParameters']/field[@name='TIME_STAMP']"
		[Register ("TIME_STAMP")]
		public const string TimeStamp = (string) "timeStamp";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters._3DSecure']/class[@name='_3DSecureResponseParameters']/field[@name='URL_RESULT']"
		[Register ("URL_RESULT")]
		public const string UrlResult = (string) "https://xpay.softeam.it/result";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters._3DSecure']/class[@name='_3DSecureResponseParameters']/field[@name='XPAY_PROTOCOL']"
		[Register ("XPAY_PROTOCOL")]
		public const string XpayProtocol = (string) "https://xpay.softeam.it";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Parameters/_3DSecure/_3DSecureResponseParameters", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (_3DSecureResponseParameters); }
		}

		protected _3DSecureResponseParameters (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters._3DSecure']/class[@name='_3DSecureResponseParameters']/constructor[@name='_3DSecureResponseParameters' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe _3DSecureResponseParameters ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (_3DSecureResponseParameters)) {
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
