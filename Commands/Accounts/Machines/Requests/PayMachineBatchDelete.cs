using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayMachineBatchDelete : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamLogin> machines { get; set; }
	}
}