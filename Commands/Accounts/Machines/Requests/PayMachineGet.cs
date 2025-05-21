using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="Machine"/>.
	/// </summary>
	public class PayMachineGet : PayMachine, IPayDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="Machine"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}