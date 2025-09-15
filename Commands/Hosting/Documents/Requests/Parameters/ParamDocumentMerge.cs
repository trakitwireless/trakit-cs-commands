using System;
using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create or update an <see cref="Document"/>.
	/// </summary>
	public class ParamDocumentMerge : ParamMergeSubscribable {
		/// <summary>
		/// The unique identifier of the <see cref="Document"/> you want to update.
		/// </summary>
		public ulong? id;
		/// <summary>
		/// The <see cref="Company"/> to which this <see cref="Document"/> belongs.
		/// After creation, this value is read-only.
		/// </summary>
		public ulong? company;
		/// <summary>
		/// The file name of this <see cref="Document"/>.
		/// </summary>
		public string name;
		/// <summary>
		/// Notes about this <see cref="Document"/>.
		/// </summary>
		public string notes;
		/// <summary>
		/// The time at which the <see cref="Document"/> will automatically be purged from the system.
		/// </summary>
		public DateTime? expiry;
		/// <summary>
		/// Name/value collections of custom fields used to refer to external systems.
		/// If the value is null, the references are removed from the <see cref="Document"/>.
		/// </summary>
		public Dictionary<string, string> references;
	}
}