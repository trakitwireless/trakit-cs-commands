using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="formResults"/>.
	/// </summary>
	public abstract class RepFormResultList : Reply {
		/// <summary>
		/// The list of requested <see cref="FormResult"/>s.
		/// </summary>
		public FormResult[] formResults;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RepFormResultListByCompany : RepFormResultList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ContentId company;
	}
}