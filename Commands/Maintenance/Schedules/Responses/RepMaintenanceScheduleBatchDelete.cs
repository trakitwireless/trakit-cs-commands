using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="maintenanceSchedule"/>.
	/// </summary>
	public class RepMaintenanceScheduleBatchDelete : Reply {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="MaintenanceSchedule"/>.
		/// </summary>
		public ContentIdDeleted[] maintenanceSchedules;
	}
}