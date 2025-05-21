using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="userAdvanced"/>.
	/// </summary>
	public class RepUserAdvancedGet : Reply {
		/// <summary>
		/// The requested <see cref="UserAdvanced"/>.
		/// </summary>
		public UserAdvanced userAdvanced;
	}
}