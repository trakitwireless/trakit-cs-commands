using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="asset"/>.
	/// </summary>
	public class RepAssetGet : Reply {
		/// <summary>
		/// The requested <see cref="Asset"/>.
		/// </summary>
		public Asset asset;
	}
}