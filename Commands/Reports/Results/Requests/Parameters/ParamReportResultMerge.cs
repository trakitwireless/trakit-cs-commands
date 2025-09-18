using System;
using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create or update an <see cref="ReportResult"/>.
	/// </summary>
	public class ParamReportResultMerge : ParamMergeSubscribable {
		/// <summary>
		/// The unique identifier of the <see cref="ReportResult"/> you want to update.
		/// Leave this as <c>null</c> when creating a new <see cref="ReportResult"/>.
		/// </summary>
		public ulong? id;
		/// <summary>
		/// Identifier of the <see cref="ReportTemplate"/> used to help create these <see cref="ReportResult"/>.
		/// </summary>
		public ulong? template;
		/// <summary>
		/// The <see cref="Company"/> to which these report <see cref="ReportResult"/> belongs.
		/// </summary>
		public ulong? company;
		/// <summary>
		/// The kind of logic used to build the report <see cref="ReportResult"/>.
		/// </summary>
		public ReportType? kind;
		/// <summary>
		/// Name for the report <see cref="ReportResult"/>.
		/// </summary>
		public string name;
		/// <summary>
		/// Notes for these report <see cref="ReportResult"/>.
		/// </summary>
		public string notes;
		/// <summary>
		/// Indicates whether this report should be archived.
		/// Archived report <see cref="ReportResult"/> are stored for six months.
		/// Non-archive reports are purged after 24 hours.
		/// </summary>
		public bool? archive;
		/// <summary>
		/// Specified parameters for the report logic, targeted <see cref="Asset"/>s, and filtering <see cref="Place"/>s and/or regions.
		/// </summary>
		public ParamReportOptions options;
		/// <summary>
		/// The <see cref="Timezone.code"/> of the local timezone used to calculate times.
		/// </summary>
		/// <seealso cref="Timezone.code" />
		public TimeZoneInfo timezone;
	}
}