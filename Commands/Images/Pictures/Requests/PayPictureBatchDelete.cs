using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayPictureBatchDelete : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> pictures { get; set; }
	}
}