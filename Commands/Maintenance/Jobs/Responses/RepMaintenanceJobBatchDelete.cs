using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="maintenanceJob"/>.
	/// </summary>
	public class RepMaintenanceJobBatchDelete : Reply {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="MaintenanceJob"/>.
		/// </summary>
		public ContentIdDeleted[] maintenanceJobs;
	}
}