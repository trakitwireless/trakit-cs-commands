using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayProviderScriptBatchMerge : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamProviderScriptMerge> providerScripts { get; set; }
	}
}