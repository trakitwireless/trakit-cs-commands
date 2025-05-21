using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="providerAdvanced"/>.
	/// </summary>
	public class RepProviderAdvancedGet : Reply {
		/// <summary>
		/// The requested <see cref="ProviderAdvanced"/>.
		/// </summary>
		public ProviderAdvanced providerAdvanced;
	}
}