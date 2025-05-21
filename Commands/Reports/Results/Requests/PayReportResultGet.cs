using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="ReportResult"/>.
	/// </summary>
	public class PayReportResultGet : PayReportResult, IPayDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="ReportResult"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}