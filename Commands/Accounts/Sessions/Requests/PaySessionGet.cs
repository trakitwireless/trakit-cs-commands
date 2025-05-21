using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="Session"/>.
	/// </summary>
	public class PaySessionGet : Payload {
		/// <summary>
		/// An object to contain the "handle" of the <see cref="Session"/>.
		/// </summary>
		public ParamHandle session;
	}
}