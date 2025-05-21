using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="providerScript"/>.
	/// </summary>
	public class RepProviderScriptGet : Reply {
		/// <summary>
		/// The requested <see cref="ProviderScript"/>.
		/// </summary>
		public ProviderScript providerScript;
	}
}