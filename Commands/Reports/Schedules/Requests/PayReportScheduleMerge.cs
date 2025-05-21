using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Creates a new or updates an existing <see cref="ReportSchedule"/>.
	/// </summary>
	public class PayReportScheduleMerge : Payload, IPaySingle {
		/// <summary>
		/// Parameters given to create or update a <see cref="ReportSchedule"/>.
		/// </summary>
		public ParamReportScheduleMerge reportSchedule { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.reportSchedule?.id?.ToString() ?? "";
	}
}