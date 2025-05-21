using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayMaintenanceScheduleBatchDelete : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> maintenanceSchedules { get; set; }
	}
}