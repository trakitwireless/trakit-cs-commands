using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayProviderBatchDelete : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamIdentifier> providers { get; set; }
	}
}