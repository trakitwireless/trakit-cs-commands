using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="MaintenanceSchedule"/>.
	/// </summary>
	public class PayMaintenanceScheduleGet : PayMaintenanceSchedule, IPayDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="MaintenanceSchedule"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}