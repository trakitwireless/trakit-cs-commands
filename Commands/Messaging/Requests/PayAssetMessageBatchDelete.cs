using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayAssetMessageBatchDelete : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> assetMessages { get; set; }
	}
}