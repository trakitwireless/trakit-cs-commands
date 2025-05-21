using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayDocumentBatchMerge : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamDocumentMerge> documents { get; set; }
	}
}