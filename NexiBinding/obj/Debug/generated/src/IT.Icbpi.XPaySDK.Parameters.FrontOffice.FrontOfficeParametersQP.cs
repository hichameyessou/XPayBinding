using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IT.Icbpi.XPaySDK.Parameters.FrontOffice {

	// Metadata.xml XPath class reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters.FrontOffice']/class[@name='FrontOfficeParametersQP']"
	[global::Android.Runtime.Register ("it/icbpi/XPaySDK/Parameters/FrontOffice/FrontOfficeParametersQP", DoNotGenerateAcw=true)]
	public partial class FrontOfficeParametersQP : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters.FrontOffice']/class[@name='FrontOfficeParametersQP']/field[@name='ALIAS']"
		[Register ("ALIAS")]
		public const string Alias = (string) "alias";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters.FrontOffice']/class[@name='FrontOfficeParametersQP']/field[@name='BRAND']"
		[Register ("BRAND")]
		public const string Brand = (string) "brand";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters.FrontOffice']/class[@name='FrontOfficeParametersQP']/field[@name='CALLBACK']"
		[Register ("CALLBACK")]
		public const string Callback = (string) "callback";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters.FrontOffice']/class[@name='FrontOfficeParametersQP']/field[@name='COD_AUTH']"
		[Register ("COD_AUTH")]
		public const string CodAuth = (string) "codAut";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters.FrontOffice']/class[@name='FrontOfficeParametersQP']/field[@name='COD_TRANS']"
		[Register ("COD_TRANS")]
		public const string CodTrans = (string) "codTrans";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters.FrontOffice']/class[@name='FrontOfficeParametersQP']/field[@name='DATA']"
		[Register ("DATA")]
		public const string Data = (string) "data";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters.FrontOffice']/class[@name='FrontOfficeParametersQP']/field[@name='DIVISA']"
		[Register ("DIVISA")]
		public const string Divisa = (string) "divisa";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters.FrontOffice']/class[@name='FrontOfficeParametersQP']/field[@name='ENVIRONMENT']"
		[Register ("ENVIRONMENT")]
		public const string Environment = (string) "environment";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters.FrontOffice']/class[@name='FrontOfficeParametersQP']/field[@name='ESITO']"
		[Register ("ESITO")]
		public const string Esito = (string) "esito";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters.FrontOffice']/class[@name='FrontOfficeParametersQP']/field[@name='EXTRA_KEYS']"
		[Register ("EXTRA_KEYS")]
		public const string ExtraKeys = (string) "extraKeys";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters.FrontOffice']/class[@name='FrontOfficeParametersQP']/field[@name='IMPORTO']"
		[Register ("IMPORTO")]
		public const string Importo = (string) "importo";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters.FrontOffice']/class[@name='FrontOfficeParametersQP']/field[@name='MAC']"
		[Register ("MAC")]
		public const string Mac = (string) "mac";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters.FrontOffice']/class[@name='FrontOfficeParametersQP']/field[@name='NAV_ENABLED']"
		[Register ("NAV_ENABLED")]
		public const string NavEnabled = (string) "navigationEnabled";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters.FrontOffice']/class[@name='FrontOfficeParametersQP']/field[@name='ORARIO']"
		[Register ("ORARIO")]
		public const string Orario = (string) "orario";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters.FrontOffice']/class[@name='FrontOfficeParametersQP']/field[@name='URL']"
		[Register ("URL")]
		public const string Url = (string) "https://xpay.softeam.it/result";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters.FrontOffice']/class[@name='FrontOfficeParametersQP']/field[@name='URL_BACK']"
		[Register ("URL_BACK")]
		public const string UrlBack = (string) "https://xpay.softeam.it/annullment";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters.FrontOffice']/class[@name='FrontOfficeParametersQP']/field[@name='URL_BACK_KEY']"
		[Register ("URL_BACK_KEY")]
		public const string UrlBackKey = (string) "url_back";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters.FrontOffice']/class[@name='FrontOfficeParametersQP']/field[@name='URL_KEY']"
		[Register ("URL_KEY")]
		public const string UrlKey = (string) "url";

		// Metadata.xml XPath field reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters.FrontOffice']/class[@name='FrontOfficeParametersQP']/field[@name='XPAY_PROTOCOL']"
		[Register ("XPAY_PROTOCOL")]
		public const string XpayProtocol = (string) "https://xpay.softeam.it";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("it/icbpi/XPaySDK/Parameters/FrontOffice/FrontOfficeParametersQP", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FrontOfficeParametersQP); }
		}

		protected FrontOfficeParametersQP (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='it.icbpi.XPaySDK.Parameters.FrontOffice']/class[@name='FrontOfficeParametersQP']/constructor[@name='FrontOfficeParametersQP' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FrontOfficeParametersQP ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (FrontOfficeParametersQP)) {
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
