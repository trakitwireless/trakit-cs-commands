using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayCompanyBatchDelete : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> companies { get; set; }
	}
}