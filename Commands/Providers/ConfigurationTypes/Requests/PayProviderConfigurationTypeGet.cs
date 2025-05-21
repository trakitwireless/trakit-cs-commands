using System;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="ProviderConfigurationType"/>.
	/// </summary>
	[Obsolete("Use ReqProviderScriptGet instead")]
	public class PayProviderConfigurationTypeGet : PayProviderConfigurationType, IPayDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="ProviderConfigurationType"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}