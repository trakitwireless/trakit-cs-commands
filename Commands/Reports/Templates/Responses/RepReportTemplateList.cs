using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="reportTemplates"/>.
	/// </summary>
	public abstract class RepReportTemplateList : Reply {
		/// <summary>
		/// The list of requested <see cref="ReportTemplate"/>s.
		/// </summary>
		public ReportTemplate[] reportTemplates;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RepReportTemplateListByCompany : RepReportTemplateList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ContentId company;
	}
}