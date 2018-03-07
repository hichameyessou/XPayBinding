using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils']/class[@name='ResponseCodes']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Utils/ResponseCodes", DoNotGenerateAcw=true)]
	public partial class ResponseCodes : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils']/class[@name='ResponseCodes']/field[@name='ALIAS_NOT_VALID']"
		[Register ("ALIAS_NOT_VALID")]
		public const string AliasNotValid = (string) "50";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils']/class[@name='ResponseCodes']/field[@name='MAC_ERROR']"
		[Register ("MAC_ERROR")]
		public const string MacError = (string) "MAC_ERROR";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils']/class[@name='ResponseCodes']/field[@name='MERCHANT_OR_CARD_NOT_3DS']"
		[Register ("MERCHANT_OR_CARD_NOT_3DS")]
		public const string MerchantOrCardNot3ds = (string) "99";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils']/class[@name='ResponseCodes']/field[@name='RESPONSE_KO']"
		[Register ("RESPONSE_KO")]
		public const string ResponseKo = (string) "KO";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils']/class[@name='ResponseCodes']/field[@name='RESPONSE_OK']"
		[Register ("RESPONSE_OK")]
		public const string ResponseOk = (string) "OK";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils']/class[@name='ResponseCodes']/field[@name='SERVER_ERROR_INT']"
		[Register ("SERVER_ERROR_INT")]
		public const int ServerErrorInt = (int) 500;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Utils/ResponseCodes", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResponseCodes); }
		}

		protected ResponseCodes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Utils']/class[@name='ResponseCodes']/constructor[@name='ResponseCodes' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResponseCodes ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ResponseCodes)) {
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
