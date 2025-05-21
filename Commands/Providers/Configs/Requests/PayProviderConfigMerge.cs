using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Creates a new or updates an existing <see cref="ProviderConfig"/>.
	/// </summary>
	public class PayProviderConfigMerge : Payload, IPaySingle {
		/// <summary>
		/// Parameters given to create or update a <see cref="ProviderConfig"/>.
		/// </summary>
		public ParamProviderConfigMerge providerConfig { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.providerConfig?.id?.ToString() ?? "";
	}
}