using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="userGroup"/>.
	/// </summary>
	public class RepUserGroupBatchDelete : Reply {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="UserGroup"/>.
		/// </summary>
		public ContentIdDeleted[] userGroups;
	}
}