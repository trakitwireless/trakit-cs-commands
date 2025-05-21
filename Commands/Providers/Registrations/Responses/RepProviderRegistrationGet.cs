using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="providerRegistration"/>.
	/// </summary>
	public class RepProviderRegistrationGet : Reply {
		/// <summary>
		/// The requested <see cref="ProviderRegistration"/>.
		/// </summary>
		public ProviderRegistration providerRegistration;
	}
}