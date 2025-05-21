using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayUserBatchMerge : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamUserMerge> users { get; set; }
	}
}