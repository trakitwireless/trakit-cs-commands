using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="providerScript"/>.
	/// </summary>
	public class RepProviderScriptBatchDelete : Reply {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="ProviderScript"/>.
		/// </summary>
		public ContentIdDeleted[] providerScripts;
	}
}