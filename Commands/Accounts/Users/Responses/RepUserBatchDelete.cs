using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="user"/>.
	/// </summary>
	public class RepUserBatchDelete : Reply {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="User"/>.
		/// </summary>
		public ContentIdDeleted[] users;
	}
}