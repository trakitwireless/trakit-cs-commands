using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="maintenanceSchedule"/>.
	/// </summary>
	public class RepMaintenanceScheduleGet : Reply {
		/// <summary>
		/// The requested <see cref="MaintenanceSchedule"/>.
		/// </summary>
		public MaintenanceSchedule maintenanceSchedule;
	}
}