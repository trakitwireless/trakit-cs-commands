using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="user"/>.
	/// </summary>
	public class RepUserGet : Reply {
		/// <summary>
		/// The requested <see cref="User"/>.
		/// </summary>
		public User user;
	}
}