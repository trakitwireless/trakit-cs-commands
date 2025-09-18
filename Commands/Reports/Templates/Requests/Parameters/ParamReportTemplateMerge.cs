using System;
using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create or update an <see cref="ReportTemplate"/>.
	/// </summary>
	public class ParamReportTemplateMerge : ParamMergeSubscribable {
		/// <summary>
		/// The unique identifier of the <see cref="ReportTemplate"/> you want to update.
		/// Leave this as <c>null</c> when creating a new <see cref="ReportTemplate"/>.
		/// </summary>
		public ulong? id;
		/// <summary>
		/// The <see cref="Company"/> to which this <see cref="ReportTemplate"/> belongs.
		/// After creation, this value is read-only.
		/// </summary>
		public ulong? company;
		/// <summary>
		/// Name for the <see cref="ReportTemplate"/>.
		/// </summary>
		public string name;
		/// <summary>
		/// Notes for the <see cref="ReportTemplate"/>.
		/// </summary>
		public string notes;
		/// <summary>
		/// The kind of logic used to build the report results.
		/// </summary>
		public ReportType? kind;
		/// <summary>
		/// Specified parameters for the report logic, targeted <see cref="Asset"/>s, and filtering <see cref="Place"/>s and/or regions.
		/// </summary>
		public ParamReportOptions options;
		/// <summary>
		/// Background and fill colour in the UI.
		/// </summary>
		public string fill;
		/// <summary>
		/// Text and outline colour in the UI.
		/// </summary>
		public string stroke;
		/// <summary>
		/// The name of the symbol shown in the UI.
		/// </summary>
		public string graphic;
	}
}