using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="UserGeneral"/>.
	/// </summary>
	public class PayUserGeneralGet : PayUser, IPayDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="UserGeneral"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}