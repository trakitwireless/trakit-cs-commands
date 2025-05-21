using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="document"/>.
	/// </summary>
	public class RepDocumentBatchDelete : Reply {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="Document"/>.
		/// </summary>
		public ContentIdDeleted[] documents;
	}
}