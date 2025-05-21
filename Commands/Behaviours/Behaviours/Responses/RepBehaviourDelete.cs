using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="behaviour"/>.
	/// </summary>
	public class RepBehaviourDelete : Reply {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="Behaviour"/>.
		/// </summary>
		public ContentIdDeleted behaviour;
	}
}