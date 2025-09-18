using System;
using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create or update an <see cref="ReportSchedule"/>.
	/// </summary>
	public class ParamReportScheduleMerge : ParamMergeSubscribable {
		/// <summary>
		/// The unique identifier of the <see cref="ReportSchedule"/> you want to update.
		/// Leave this as <c>null</c> when creating a new <see cref="ReportSchedule"/>.
		/// </summary>
		public ulong? id;
		/// <summary>
		/// Identifier of the <see cref="ReportTemplate"/> used to help create results.
		/// </summary>
		/// <override required="create" />
		public ulong? template;
		/// <summary>
		/// Name for the <see cref="ReportSchedule"/>.
		/// </summary>
		/// <override required="create" max-length="100" />
		public string name;
		/// <summary>
		/// Notes for the <see cref="ReportSchedule"/>.
		/// </summary>
		public string notes;
		/// <summary>
		/// The user which owns the schedule.
		/// When report results are created, they will be created with this user's <see cref="Asset"/> permissions.
		/// </summary>
		/// <override required="create" format="email" />
		public string owner;
		/// <summary>
		/// Indicates whether this schedule is allowed to run.
		/// </summary>
		public bool? enabled;
		/// <summary>
		/// The recurring schedule to generate report results.
		/// </summary>
		/// <override required="create" />
		public ParamReportRecurrence repetition;
		/// <summary>
		/// Specified parameters for the report logic, targeted <see cref="Asset"/>s, and filtering Places.
		/// </summary>
		public ParamReportOptions options;
		/// <summary>
		/// A list of users and a targeting expression for <see cref="Asset"/>s which receive report results notifications.
		/// </summary>
		public ParamReportNotify notify;
	}
}