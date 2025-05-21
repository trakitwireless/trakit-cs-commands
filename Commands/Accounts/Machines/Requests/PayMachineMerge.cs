using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Creates a new or updates an existing <see cref="Machine"/>.
	/// </summary>
	public class PayMachineMerge : Payload, IPaySingle {
		/// <summary>
		/// Parameters given to create or update a <see cref="Machine"/>.
		/// </summary>
		public ParamMachineMerge machine { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.machine?.key ?? "";
	}
}