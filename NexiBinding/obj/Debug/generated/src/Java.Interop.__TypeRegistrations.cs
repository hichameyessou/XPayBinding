using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"it/icbpi/XPaySDK/WebApi/Classes",
					},
					new Converter<string, Type>[]{
						lookup_it_icbpi_XPaySDK_WebApi_Classes_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_it_icbpi_XPaySDK_WebApi_Classes_mappings;
		static Type lookup_it_icbpi_XPaySDK_WebApi_Classes_package (string klass)
		{
			if (package_it_icbpi_XPaySDK_WebApi_Classes_mappings == null) {
				package_it_icbpi_XPaySDK_WebApi_Classes_mappings = new string[]{
					"it/icbpi/XPaySDK/WebApi/Classes/HostedPayments:IT.Icbpi.XPaySDK.WebApi.Classes.PaymentHost",
				};
			}

			return Lookup (package_it_icbpi_XPaySDK_WebApi_Classes_mappings, klass);
		}
	}
}
