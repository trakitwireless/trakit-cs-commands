using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="providerControl"/>.
	/// </summary>
	public class RepProviderControlGet : Reply {
		/// <summary>
		/// The requested <see cref="ProviderControl"/>.
		/// </summary>
		public ProviderControl providerControl;
	}
}