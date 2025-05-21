using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayBehaviourBatchMerge : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamBehaviourMerge> behaviours { get; set; }
	}
}