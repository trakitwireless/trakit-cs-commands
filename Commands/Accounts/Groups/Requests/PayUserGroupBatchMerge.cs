using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayUserGroupBatchMerge : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamUserGroupMerge> userGroups { get; set; }
	}
}