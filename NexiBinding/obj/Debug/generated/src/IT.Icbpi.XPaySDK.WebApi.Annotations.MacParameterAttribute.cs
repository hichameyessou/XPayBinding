using System;

namespace IT.Icbpi.XPaySDK.WebApi.Annotations {

	[global::Android.Runtime.Annotation ("it.icbpi.XPaySDK.WebApi.Annotations.MacParameter")]
	public partial class MacParameterAttribute : Attribute
	{
		[global::Android.Runtime.Register ("priority")]
		public int Priority { get; set; }

		[global::Android.Runtime.Register ("skipIfNull")]
		public bool SkipIfNull { get; set; }

	}
}
