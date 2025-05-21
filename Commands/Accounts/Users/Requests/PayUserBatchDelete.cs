using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayUserBatchDelete : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamLogin> users { get; set; }
	}
}