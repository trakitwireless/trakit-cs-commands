using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayReportResultBatchMerge : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamReportOptions> reportResults { get; set; }
	}
}