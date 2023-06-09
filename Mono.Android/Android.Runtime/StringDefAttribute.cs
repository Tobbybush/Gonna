using System;

namespace Android.Runtime
{
	// Field can be target too, but our toolchain doesn't generate any.
	[AttributeUsage (AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Property, AllowMultiple = true)]
	public class StringDefAttribute : Attribute
	{
		public string? Type { get; set; }
		public string []? Fields { get; set; }
	}
}

