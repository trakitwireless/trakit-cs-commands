using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="ProviderGeneral"/>.
	/// </summary>
	public class PayProviderGeneralGet : PayProvider, IPayDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="ProviderGeneral"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}