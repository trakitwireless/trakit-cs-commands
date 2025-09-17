using System;
using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create or update an <see cref="ReportResult"/>.
	/// </summary>
	public class ParamReportOptions : ParamMerge {
		/// <summary>
		/// A list of parameters to better shape the <see cref="ReportResult"/>.
		/// </summary>
		public List<ReportParameter> parameters;
		/// <summary>
		/// A targeting expression for including/excluding <see cref="Asset"/>s.
		/// </summary>
		public string targets;
		/// <summary>
		/// The mechanism to use for filtering based on <see cref="Place"/>s and regions.
		/// </summary>
		public ReportFilterMode? filtering;
		/// <summary>
		/// A targeting expression for limiting results which only include data from <see cref="Asset"/>s interacting with the targeted <see cref="Place"/>s.
		/// </summary>
		public string places;
		/// <summary>
		/// A list of provinces and states, where only <see cref="Asset"/>s within those regions will be included in the <see cref="ReportResult"/>.
		/// </summary>
		public List<string> regions;
		/// <summary>
		/// Rules used to generate <see cref="ReportDataScorecard"/> for the <see cref="ReportResult"/>.
		/// </summary>
		public ParamReportScorecardRules scorecardRules;
	}
}