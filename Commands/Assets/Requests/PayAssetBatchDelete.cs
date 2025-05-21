using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayAssetBatchDelete : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> assets { get; set; }
	}
}