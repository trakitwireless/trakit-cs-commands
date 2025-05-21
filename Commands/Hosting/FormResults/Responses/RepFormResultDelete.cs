using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="formResult"/>.
	/// </summary>
	public class RepFormResultDelete : Reply {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="FormResult"/>.
		/// </summary>
		public ContentIdDeleted formResult;
	}
}