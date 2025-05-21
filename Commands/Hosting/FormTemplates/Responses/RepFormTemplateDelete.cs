using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="formTemplate"/>.
	/// </summary>
	public class RepFormTemplateDelete : Reply {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="FormTemplate"/>.
		/// </summary>
		public ContentIdDeleted formTemplate;
	}
}