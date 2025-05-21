using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Creates a new or updates an existing <see cref="Behaviour"/>.
	/// </summary>
	public class PayBehaviourMerge : Payload, IPaySingle {
		/// <summary>
		/// Parameters given to create or update a <see cref="Behaviour"/>.
		/// </summary>
		public ParamBehaviourMerge behaviour { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.behaviour?.id?.ToString() ?? "";
	}
}