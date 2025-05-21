using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="reportSchedule"/>.
	/// </summary>
	public class RepReportScheduleBatchDelete : Reply {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="ReportSchedule"/>.
		/// </summary>
		public ContentIdDeleted[] reportSchedules;
	}
}