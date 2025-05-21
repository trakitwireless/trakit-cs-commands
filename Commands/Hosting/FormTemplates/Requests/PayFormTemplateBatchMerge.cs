using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayFormTemplateBatchMerge : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamFormTemplateMerge> formTemplates { get; set; }
	}
}