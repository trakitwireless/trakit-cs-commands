using System;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	[Obsolete("Use RespProviderConfigBatchMerge instead")]
	public class RepProviderConfigurationBatchMerge : Reply {
		/// <summary>
		/// 
		/// </summary>
		public ContentIdCompany[] providerConfigurations;
	}
}