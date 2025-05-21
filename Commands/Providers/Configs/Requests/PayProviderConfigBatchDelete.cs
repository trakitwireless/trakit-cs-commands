using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayProviderConfigBatchDelete : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> providerConfigs { get; set; }
	}
}