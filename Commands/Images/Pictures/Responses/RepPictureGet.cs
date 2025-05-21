using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="picture"/>.
	/// </summary>
	public class RepPictureGet : Reply {
		/// <summary>
		/// The requested <see cref="Picture"/>.
		/// </summary>
		public Picture picture;
	}
}