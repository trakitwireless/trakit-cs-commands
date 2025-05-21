using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="maintenanceJobs"/>.
	/// </summary>
	public abstract class RepMaintenanceJobList : Reply {
		/// <summary>
		/// The list of requested <see cref="MaintenanceJob"/>s.
		/// </summary>
		public MaintenanceJob[] maintenanceJobs;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RepMaintenanceJobListByCompany : RepMaintenanceJobList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ContentId company;
	}
}