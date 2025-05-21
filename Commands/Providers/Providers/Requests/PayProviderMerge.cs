using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Creates a new or updates an existing <see cref="Provider"/>.
	/// </summary>
	public class PayProviderMerge : Payload, IPaySingle {
		/// <summary>
		/// Parameters given to create or update a <see cref="Provider"/>.
		/// </summary>
		public ParamProviderMerge provider { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.provider?.id?.ToString() ?? "";
	}
}