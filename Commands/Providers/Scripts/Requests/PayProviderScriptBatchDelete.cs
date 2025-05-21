using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayProviderScriptBatchDelete : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> providerScripts { get; set; }
	}
}