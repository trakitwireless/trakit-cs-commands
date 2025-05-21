using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="Place"/>.
	/// </summary>
	public class PayPlaceGet : PayPlace, IPayDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="Place"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}