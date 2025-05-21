using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="behaviourScript"/>.
	/// </summary>
	public class RepBehaviourScriptBatchDelete : Reply {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="BehaviourScript"/>.
		/// </summary>
		public ContentIdDeleted[] behaviourScripts;
	}
}