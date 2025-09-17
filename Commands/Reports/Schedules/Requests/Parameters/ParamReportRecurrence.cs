using System;
using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameter values for creating a new or updating an existing <see cref="ReportRecurrence"/>.
	/// </summary>
	public class ParamReportRecurrence : ParamMerge {
		/// <summary>
		/// How often the report is automatically run.  Daily, weekly, monthly, etc...
		/// </summary>
		public ReportRecurrenceType? kind;
		/// <summary>
		/// Used only for daily schedules, this 7 item, boolean array, determines if the <see cref="ReportSchedule"/> should recur on that day of the week.
		/// </summary>
		public bool[] weekdays;
		/// <summary>
		/// Used only for weekly schedules, it's a number between 0 and 6 representing the day of the week, with Sunday being the first day of the week.
		/// </summary>
		public byte? weekday;
		/// <summary>
		/// When the <see cref="ReportSchedule"/> is to begin recurring in local-time (not UTC).
		/// </summary>
		public DateTime? start;
		/// <summary>
		/// The optional time when the <see cref="ReportSchedule"/> stops recurring in local-time (not UTC).
		/// </summary>
		public DateTime? end;
	}
}