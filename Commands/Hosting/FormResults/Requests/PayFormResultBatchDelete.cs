using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayFormResultBatchDelete : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> formResults { get; set; }
	}
}