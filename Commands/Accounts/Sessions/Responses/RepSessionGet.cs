using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="User"/> of the current session.
	/// </summary>
	public class RepSessionGet : Reply {
		/// <summary>
		/// The requested <see cref="Session"/> details.
		/// </summary>
		public Session session;
	}
}