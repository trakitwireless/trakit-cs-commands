using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create or update an <see cref="Icon"/>.
	/// </summary>
	public class ParamIconMerge : ParamMergeSubscribable {
		/// <summary>
		/// The unique identifier of the <see cref="Icon"/> you want to update.
		/// Leave this as <c>null</c> when creating a new <see cref="Icon"/>.
		/// </summary>
		public ulong? id;
		/// <summary>
		/// The <see cref="Company"/> to which this <see cref="Icon"/> belongs.
		/// After creation, this value is read-only.
		/// </summary>
		public ulong? company;
		/// <summary>
		/// Name for the <see cref="Icon"/>.
		/// </summary>
		public string name;
		/// <summary>
		/// Notes for the <see cref="Icon"/>.
		/// </summary>
		public string notes;
		/// <summary>
		/// A noun to describe the type of thing represented.  Like Truck, Car, Trailer, Hot-Air Balloon, etc...
		/// </summary>
		public string category;
		/// <summary>
		/// Indicates whether this <see cref="Icon"/> is available to child companies.
		/// </summary>
		public bool? global;
		/// <summary>
		/// A list of things that this <see cref="Icon"/> can be used to represent.  Like <c>asset</c>, <c>place</c>, <c>user</c>, etc...
		/// </summary>
		public List<string> usage;
		/// <summary>
		/// Definition for the name bubble above the <see cref="Icon"/> on a map.
		/// </summary>
		public IconLabel label;
		/// <summary>
		/// Definition for the name badge beside the <see cref="Icon"/> on a map.
		/// </summary>
		public IconLabel badge;
		/// <summary>
		/// The images used to show the detail of this <see cref="Icon"/>.
		/// </summary>
		public List<IconGlyph> glyphs;
	}
}