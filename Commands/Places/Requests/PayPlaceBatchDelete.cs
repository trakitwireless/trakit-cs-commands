using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayPlaceBatchDelete : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> places { get; set; }
	}
}