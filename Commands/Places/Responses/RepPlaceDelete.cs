using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="place"/>.
	/// </summary>
	public class RepPlaceDelete : Reply {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="Place"/>.
		/// </summary>
		public ContentIdDeleted place;
	}
}