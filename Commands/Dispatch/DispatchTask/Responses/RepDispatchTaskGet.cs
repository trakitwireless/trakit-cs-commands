using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="dispatchTask"/>.
	/// </summary>
	public class RepDispatchTaskGet : Reply {
		/// <summary>
		/// The requested <see cref="DispatchTask"/>.
		/// </summary>
		public DispatchTask dispatchTask;
	}
}