using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayPlaceBatchMerge : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamPlaceMerge> places { get; set; }
	}
}