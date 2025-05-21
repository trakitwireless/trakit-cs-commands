using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayMaintenanceJobBatchDelete : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> maintenanceJobs { get; set; }
	}
}