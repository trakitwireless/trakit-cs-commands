using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="maintenanceJob"/>.
	/// </summary>
	public class RepMaintenanceJobGet : Reply {
		/// <summary>
		/// The requested <see cref="MaintenanceJob"/>.
		/// </summary>
		public MaintenanceJob maintenanceJob;
	}
}