using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayDocumentBatchDelete : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> documents { get; set; }
	}
}