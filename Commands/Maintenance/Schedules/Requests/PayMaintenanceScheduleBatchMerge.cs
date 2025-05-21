using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayMaintenanceScheduleBatchMerge : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamMaintenanceScheduleMerge> maintenanceSchedules { get; set; }
	}
}