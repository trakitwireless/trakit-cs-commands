using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="provider"/>.
	/// </summary>
	public class RepProviderDelete : Reply {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="Provider"/>.
		/// </summary>
		public ContentIdendifierDeleted provider;
	}
}