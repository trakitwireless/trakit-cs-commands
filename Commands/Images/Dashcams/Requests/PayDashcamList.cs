using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="dashcam"/>.
	/// </summary>
	public abstract class PayDashcamList : Payload, IPayDeletable {
		/// <summary>
		/// When true, the command will also return  deleted <see cref="Dashcam"/>s.
		/// </summary>
		public bool includeDeleted { get; set; }
	}
	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class PayDashcamListByCompany : PayDashcamList, IPayListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
}