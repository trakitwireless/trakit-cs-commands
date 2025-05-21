using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="providerConfig"/>.
	/// </summary>
	public class RepProviderConfigGet : Reply {
		/// <summary>
		/// The requested <see cref="ProviderConfig"/>.
		/// </summary>
		public ProviderConfig providerConfig;
	}
}