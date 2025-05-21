using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="provider"/>.
	/// </summary>
	public class RepProviderGet : Reply {
		/// <summary>
		/// The requested <see cref="Provider"/>.
		/// </summary>
		public Provider provider;
	}
}