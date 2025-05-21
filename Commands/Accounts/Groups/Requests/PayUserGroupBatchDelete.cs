using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayUserGroupBatchDelete : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> userGroups { get; set; }
	}
}