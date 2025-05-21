using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayMachineBatchMerge : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamMachineMerge> machines { get; set; }
	}
}