using System;
using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameter values for creating a new or updating an existing <see cref="ReportRecurrence"/>.
	/// </summary>
	public class ParamReportNotify : ParamMerge {
		/// <summary>
		/// List of <see cref="User"/>s to send emailed report.
		/// Each email will only contain the <see cref="ReportResult"/> for the <see cref="Asset"/>s each <see cref="User"/> is allowed to view.
		/// </summary>
		public List<string> users;
		/// <summary>
		/// A targeting expression to identify which <see cref="Asset"/>s receive the <see cref="ReportResult"/>.
		/// </summary>
		public string assets;
	}
}