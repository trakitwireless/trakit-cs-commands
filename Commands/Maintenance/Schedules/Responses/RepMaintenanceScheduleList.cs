using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="maintenanceSchedules"/>.
	/// </summary>
	public abstract class RepMaintenanceScheduleList : Reply {
		/// <summary>
		/// The list of requested <see cref="MaintenanceSchedule"/>s.
		/// </summary>
		public MaintenanceSchedule[] maintenanceSchedules;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RepMaintenanceScheduleListByCompany : RepMaintenanceScheduleList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ContentId company;
	}
}