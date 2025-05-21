using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="providerConfig"/>.
	/// </summary>
	public class RepProviderConfigBatchDelete : Reply {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="ProviderConfig"/>.
		/// </summary>
		public ContentIdDeleted[] providerConfigs;
	}
}