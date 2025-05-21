using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="formTemplates"/>.
	/// </summary>
	public abstract class RepFormTemplateList : Reply {
		/// <summary>
		/// The list of requested <see cref="FormTemplate"/>s.
		/// </summary>
		public FormTemplate[] formTemplates;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RepFormTemplateListByCompany : RepFormTemplateList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ContentId company;
	}
}