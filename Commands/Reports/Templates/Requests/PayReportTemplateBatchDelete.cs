using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayReportTemplateBatchDelete : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> reportTemplates { get; set; }
	}
}