using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="Icon"/>.
	/// </summary>
	public class PayIconGet : PayIcon, IPayDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="Icon"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}