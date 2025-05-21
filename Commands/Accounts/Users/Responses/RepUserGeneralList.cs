using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="userGenerals"/>.
	/// </summary>
	public abstract class RepUserGeneralList : Reply {
		/// <summary>
		/// The list of requested <see cref="UserGeneral"/>s.
		/// </summary>
		public UserGeneral[] userGenerals;
	}

	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RepUserGeneralListByCompany : RepUserGeneralList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ContentId company;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RepUserGeneralListByCompanyAndLabels : RepUserGeneralListByCompany {
		/// <summary>
		/// The labels given as input.
		/// </summary>
		/// <seealso cref="UserGeneral.labels"/>
		public string[] labels;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RepUserGeneralListByCompanyAndRefPairs : RepUserGeneralListByCompany {
		/// <summary>
		/// The reference string given as input.
		/// </summary>
		/// <seealso cref="UserGeneral.references"/>
		public Dictionary<string, string> references;
	}
}