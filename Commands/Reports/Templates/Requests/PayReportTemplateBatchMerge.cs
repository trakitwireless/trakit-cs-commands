using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayReportTemplateBatchMerge : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamReportTemplateMerge> reportTemplates { get; set; }
	}
}