using System;
using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create or update an <see cref="ReportResult"/>.
	/// </summary>
	public class ParamReportScorecardRules : ParamMerge {
		/// <summary>
		/// Base score for the <see cref="ReportDataScorecard"/>.
		/// </summary>
		public double baseScore;
		/// <summary>
		/// Infraction parameters used to generate the final <see cref="ReportDataScorecard.score"/>.
		/// </summary>
		public List<ReportScorecardParameter> parameters;
	}
}