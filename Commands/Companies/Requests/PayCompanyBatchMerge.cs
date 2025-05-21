using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayCompanyBatchMerge : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamCompanyMerge> companies { get; set; }
	}
}