using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayReportResultBatchMerge : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamReportResultMerge> reportResults { get; set; }
	}
}