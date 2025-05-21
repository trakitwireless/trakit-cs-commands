using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="document"/>.
	/// </summary>
	public class RepDocumentGet : Reply {
		/// <summary>
		/// The requested <see cref="Document"/>.
		/// </summary>
		public Document document;
	}
}