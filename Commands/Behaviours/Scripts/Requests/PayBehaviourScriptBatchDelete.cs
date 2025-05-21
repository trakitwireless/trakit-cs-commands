using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayBehaviourScriptBatchDelete : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> behaviourScripts { get; set; }
	}
}