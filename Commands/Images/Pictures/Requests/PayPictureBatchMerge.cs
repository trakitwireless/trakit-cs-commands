using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayPictureBatchMerge : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamPictureMerge> pictures { get; set; }
	}
}