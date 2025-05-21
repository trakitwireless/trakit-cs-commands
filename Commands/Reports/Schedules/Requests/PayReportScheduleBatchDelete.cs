using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayReportScheduleBatchDelete : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> reportSchedules { get; set; }
	}
}