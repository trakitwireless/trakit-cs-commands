using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayContactBatchDelete : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> contacts { get; set; }
	}
}