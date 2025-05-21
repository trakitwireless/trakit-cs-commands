using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="icons"/>.
	/// </summary>
	public abstract class RepIconList : Reply {
		/// <summary>
		/// The list of requested <see cref="Icon"/>s.
		/// </summary>
		public Icon[] icons;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RepIconListByCompany : RepIconList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ContentId company;
	}
}