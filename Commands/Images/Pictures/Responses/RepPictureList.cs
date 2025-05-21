using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="pictures"/>.
	/// </summary>
	public abstract class RepPictureList : Reply {
		/// <summary>
		/// The list of requested <see cref="Picture"/>s.
		/// </summary>
		public Picture[] pictures;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RepPictureListByCompany : RepPictureList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ContentId company;
	}
}