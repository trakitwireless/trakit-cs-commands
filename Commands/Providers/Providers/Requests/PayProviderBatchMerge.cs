using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayProviderBatchMerge : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamProviderMerge> providers { get; set; }
	}
}