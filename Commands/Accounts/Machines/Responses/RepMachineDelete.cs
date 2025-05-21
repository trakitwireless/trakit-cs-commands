using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="machine"/>.
	/// </summary>
	public class RepMachineDelete : Reply {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="Machine"/>.
		/// </summary>
		public ContentIdDeleted machine;
	}
}