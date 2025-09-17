using System;
using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create or update an <see cref="Picture"/>.
	/// </summary>
	public class ParamPictureMerge : ParamMergeSubscribable {
		/// <summary>
		/// The unique identifier of the <see cref="Picture"/> you want to update.
		/// Leave this as <c>null</c> when creating a new <see cref="Picture"/>.
		/// </summary>
		public ulong? id;
		/// <summary>
		/// The <see cref="Company"/> to which this <see cref="Picture"/> belongs.
		/// After creation, this value is read-only.
		/// </summary>
		public ulong? company;
		/// <summary>
		/// Name for the <see cref="Picture"/>.
		/// </summary>
		public string name;
		/// <summary>
		/// Notes for the <see cref="Picture"/>.
		/// </summary>
		public string notes;
		/// <summary>
		/// A list of focal points in the <see cref="Picture"/> like faces.
		/// </summary>
		public List<Square> focals;
	}
}