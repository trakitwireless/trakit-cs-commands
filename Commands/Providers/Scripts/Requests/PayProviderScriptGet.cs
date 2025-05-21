using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="ProviderScript"/>.
	/// </summary>
	public class PayProviderScriptGet : PayProviderScript, IPayDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="ProviderScript"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}