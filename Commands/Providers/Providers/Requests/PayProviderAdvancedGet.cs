using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="ProviderAdvanced"/>.
	/// </summary>
	public class PayProviderAdvancedGet : PayProvider, IPayDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="ProviderAdvanced"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}