using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="assetMessage"/>.
	/// </summary>
	public class RepAssetMessageDelete : Reply {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="AssetMessage"/>.
		/// </summary>
		public ContentIdDeleted assetMessage;
	}
}