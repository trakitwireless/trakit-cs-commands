using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="dispatchJob"/>.
	/// </summary>
	public class RepDispatchJobGet : Reply {
		/// <summary>
		/// The requested <see cref="DispatchJob"/>.
		/// </summary>
		public DispatchJob dispatchJob;
	}
}