using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="reportSchedule"/>.
	/// </summary>
	public class RepReportScheduleGet : Reply {
		/// <summary>
		/// The requested <see cref="ReportSchedule"/>.
		/// </summary>
		public ReportSchedule reportSchedule;
	}
}