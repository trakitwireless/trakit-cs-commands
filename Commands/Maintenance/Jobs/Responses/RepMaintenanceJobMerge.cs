namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="maintenanceJob"/>.
	/// </summary>
	public class RepMaintenanceJobMerge : Reply {
		/// <summary>
		/// An object which contains the <c>id</c> and <c>company</c> keys when there is no error.
		/// </summary>
		public ContentIdCompany maintenanceJob;
	}
}