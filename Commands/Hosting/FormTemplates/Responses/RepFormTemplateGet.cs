using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="formTemplate"/>.
	/// </summary>
	public class RepFormTemplateGet : Reply {
		/// <summary>
		/// The requested <see cref="FormTemplate"/>.
		/// </summary>
		public FormTemplate formTemplate;
	}
}