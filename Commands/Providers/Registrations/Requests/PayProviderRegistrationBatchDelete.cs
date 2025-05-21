using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayProviderRegistrationBatchDelete : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamCode> providerRegistrations { get; set; }
	}
}