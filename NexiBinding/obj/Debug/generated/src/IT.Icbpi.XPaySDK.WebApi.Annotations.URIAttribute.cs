using System;

namespace IT.Icbpi.XPaySDK.WebApi.Annotations {

	[global::Android.Runtime.Annotation ("it.icbpi.XPaySDK.WebApi.Annotations.URI")]
	public partial class URIAttribute : Attribute
	{
		[global::Android.Runtime.Register ("uriName")]
		public string UriName { get; set; }

	}
}
