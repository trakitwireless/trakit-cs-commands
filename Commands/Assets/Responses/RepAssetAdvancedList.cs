using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="assetAdvanceds"/>.
	/// </summary>
	public abstract class RepAssetAdvancedList : Reply {
		/// <summary>
		/// The list of requested <see cref="AssetAdvanced"/>s.
		/// </summary>
		public AssetAdvanced[] assetAdvanceds;
	}

	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RepAssetAdvancedListByCompany : RepAssetAdvancedList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ContentId company;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RepAssetAdvancedListByCompanyAndLabels : RepAssetAdvancedListByCompany {
		/// <summary>
		/// The labels given as input.
		/// </summary>
		/// <seealso cref="AssetGeneral.labels"/>
		public string[] labels;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RepAssetAdvancedListByCompanyAndRefPairs : RepAssetAdvancedListByCompany {
		/// <summary>
		/// The reference string given as input.
		/// </summary>
		/// <seealso cref="AssetGeneral.references"/>
		public Dictionary<string, string> references;
	}
}