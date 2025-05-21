using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="dispatchTask"/>.
	/// </summary>
	public class RepDispatchTaskBatchDeleted : Reply {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="DispatchTask"/>.
		/// </summary>
		public ContentIdDeleted[] dispatchTasks;
	}
}