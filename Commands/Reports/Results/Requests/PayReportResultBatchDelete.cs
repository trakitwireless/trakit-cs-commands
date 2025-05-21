using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayReportResultBatchDelete : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> reportResults { get; set; }
	}
}