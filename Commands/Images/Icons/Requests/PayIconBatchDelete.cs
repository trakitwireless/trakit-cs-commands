using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayIconBatchDelete : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> icons { get; set; }
	}
}