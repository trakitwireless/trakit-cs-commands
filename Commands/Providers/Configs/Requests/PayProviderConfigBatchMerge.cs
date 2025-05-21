using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayProviderConfigBatchMerge : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamProviderConfigMerge> providerConfigs { get; set; }
	}
}