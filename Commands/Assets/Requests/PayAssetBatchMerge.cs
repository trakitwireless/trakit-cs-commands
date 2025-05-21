using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayAssetBatchMerge : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamAssetMerge> assets { get; set; }
	}
}