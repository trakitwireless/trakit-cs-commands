using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayBehaviourScriptBatchMerge : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamBehaviourScriptMerge> behaviourScripts { get; set; }
	}
}