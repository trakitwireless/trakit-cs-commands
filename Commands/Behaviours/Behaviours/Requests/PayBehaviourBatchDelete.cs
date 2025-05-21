using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayBehaviourBatchDelete : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> behaviours { get; set; }
	}
}