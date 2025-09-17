using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create or update an <see cref="FormTemplate"/>.
	/// </summary>
	public class ParamFormTemplateMerge : ParamMergeSubscribable {
		/// <summary>
		/// The unique identifier of the <see cref="FormTemplate"/> you want to update.
		/// </summary>
		public ulong? id;
		/// <summary>
		/// The <see cref="Company"/> to which this <see cref="FormTemplate"/> belongs.
		/// After creation, this value is read-only.
		/// </summary>
		public ulong? company;
		/// <summary>
		/// Name for the <see cref="FormTemplate"/>.
		/// </summary>
		public string name;
		/// <summary>
		/// Notes for the <see cref="FormTemplate"/>.
		/// </summary>
		public string notes;
		/// <summary>
		/// Codified label names used to relate forms to <see cref="Asset"/>s.
		/// </summary>
		public List<string> labels;
		/// <summary>
		/// A collection of all the <see cref="FormTemplate.fields"/>.
		/// Any field not given in the collection will be removed.
		/// </summary>
		public List<ParamFormField> fields;
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