using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayFormTemplateBatchDelete : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> formTemplates { get; set; }
	}
}