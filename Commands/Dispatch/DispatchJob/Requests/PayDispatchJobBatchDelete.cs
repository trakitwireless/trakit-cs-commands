using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Deletes multiple <see cref="DispatchJob"/>s.
	/// </summary>
	public class PayDispatchJobBatchDelete : Payload {
		/// <summary>
		/// List of <see cref="DispatchJob.id"/>s to delete.
		/// </summary>
		public List<ParamId> dispatchJobs { get; set; }
	}
}