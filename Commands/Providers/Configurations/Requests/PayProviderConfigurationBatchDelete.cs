using System;
using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	[Obsolete("Use ReqProviderConfigBatchDelete instead")]
	public class PayProviderConfigurationBatchDelete : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> providerConfigurations { get; set; }
	}
}