using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayFormResultBatchMerge : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamFormResultMerge> formResults { get; set; }
	}
}