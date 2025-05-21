using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayAssetMessageBatchMerge : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamAssetMessageMerge> assetMessages { get; set; }
	}
}