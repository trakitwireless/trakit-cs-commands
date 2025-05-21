using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayMaintenanceJobBatchMerge : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamMaintenanceJobMerge> maintenanceJobs { get; set; }
	}
}