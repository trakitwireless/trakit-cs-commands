using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="documents"/>.
	/// </summary>
	public abstract class RepDocumentList : Reply {
		/// <summary>
		/// The list of requested <see cref="Document"/>s.
		/// </summary>
		public Document[] documents;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RepDocumentListByCompany : RepDocumentList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ContentId company;
	}
}