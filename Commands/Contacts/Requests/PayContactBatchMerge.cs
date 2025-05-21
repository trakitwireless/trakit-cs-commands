using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class PayContactBatchMerge : Payload {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamContactMerge> contacts { get; set; }
	}
}