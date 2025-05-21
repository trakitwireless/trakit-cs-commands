using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="formResult"/>.
	/// </summary>
	public class RepFormResultGet : Reply {
		/// <summary>
		/// The requested <see cref="FormResult"/>.
		/// </summary>
		public FormResult formResult;
	}
}