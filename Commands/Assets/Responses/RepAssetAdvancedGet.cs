using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="assetAdvanced"/>.
	/// </summary>
	public class RepAssetAdvancedGet : Reply {
		/// <summary>
		/// The requested <see cref="AssetAdvanced"/>.
		/// </summary>
		public AssetAdvanced assetAdvanced;
	}
}