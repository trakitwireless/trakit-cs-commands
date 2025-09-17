using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create or update an <see cref="Asset"/>.
	/// </summary>
	public class ParamAssetMerge : ParamMergeSubscribable {
		/// <summary>
		/// The unique identifier of the <see cref="Asset"/> you want to update.
		/// </summary>
		public ulong? id;
		/// <summary>
		/// The identifier of the <see cref="Company"/> to which this <see cref="Asset"/> belongs.
		/// After creation, this value is read-only.
		/// </summary>
		public ulong? company;
		/// <summary>
		/// The kind of <see cref="Asset"/> being created.
		/// After creation, this value is read-only.
		/// </summary>
		public AssetType? kind;
		/// <summary>
		/// Name for the <see cref="Asset"/>.
		/// </summary>
		public string name;
		/// <summary>
		/// Notes for the <see cref="Asset"/>.
		/// </summary>
		public string notes;
		/// <summary>
		/// The identifier of the <see cref="Icon"/> used to represent this <see cref="Asset"/> in the UI.
		/// </summary>
		/// <seealso cref="Icon.id" />
		public ulong? icon;
		/// <summary>
		/// A list of <format id="codified"/>&amp;nbsp;<see cref="CompanyStyles.labels">label</see> names to categorize/organize this <see cref="Asset"/>.
		/// </summary>
		public List<ulong> relationships;
	}
}