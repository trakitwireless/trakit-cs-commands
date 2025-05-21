using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="contact"/>.
	/// </summary>
	public class RepContactDelete : Reply {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="Contact"/>.
		/// </summary>
		public ContentIdDeleted contact;
	}
}