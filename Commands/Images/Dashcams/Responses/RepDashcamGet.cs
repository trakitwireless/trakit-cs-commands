using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="dashcam"/>.
	/// </summary>
	public class RepDashcamGet : Reply {
		/// <summary>
		/// The requested <see cref="Dashcam"/>.
		/// </summary>
		public Dashcam dashcam;
	}
}