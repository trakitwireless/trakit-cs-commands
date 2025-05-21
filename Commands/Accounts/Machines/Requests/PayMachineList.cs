using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="machine"/>.
	/// </summary>
	public abstract class PayMachineList : Payload, IPayDeletable {
		/// <summary>
		/// When true, the command will also return  deleted <see cref="Machine"/>s.
		/// </summary>
		public bool includeDeleted { get; set; }
	}
	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class PayMachineListByCompany : PayMachineList, IPayListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
}