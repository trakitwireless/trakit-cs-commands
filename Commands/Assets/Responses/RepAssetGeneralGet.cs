using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="assetGeneral"/>.
	/// </summary>
	public class RepAssetGeneralGet : Reply {
		/// <summary>
		/// The requested <see cref="Asset"/>.
		/// </summary>
		public AssetGeneral assetGeneral;
	}
}