using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayReportScheduleBatchMerge : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamReportScheduleMerge> reportSchedules { get; set; }
	}
}