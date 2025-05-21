using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="picture"/>.
	/// </summary>
	public class RepPictureBatchDelete : Reply {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="Picture"/>.
		/// </summary>
		public ContentIdDeleted[] pictures;
	}
}