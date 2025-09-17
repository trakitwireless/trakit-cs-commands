using System;
using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create or update an <see cref="Contact"/>.
	/// </summary>
	public class ParamContactMerge : ParamSelfContactMerge {
		/// <summary>
		/// The unique identifier of the <see cref="Contact"/> you want to update.
		/// Leave this as <c>null</c> when creating a new <see cref="Contact"/>.
		/// </summary>
		public ulong? id;
		/// <summary>
		/// The <see cref="Company"/> to which this <see cref="Contact"/> belongs.
		/// After creation, this value is read-only.
		/// </summary>
		public ulong? company;
	}
}