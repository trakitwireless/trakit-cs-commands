using System;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="providerConfiguration"/>.
	/// </summary>
	[Obsolete("Use RespProviderConfigDelete instead")]
	public class RepProviderConfigurationDelete : Reply {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="ProviderConfiguration"/>.
		/// </summary>
		public ContentIdDeleted providerConfiguration;
	}
}