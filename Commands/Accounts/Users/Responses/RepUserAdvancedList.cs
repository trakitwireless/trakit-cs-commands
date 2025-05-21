using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="userAdvanceds"/>.
	/// </summary>
	public abstract class RepUserAdvancedList : Reply {
		/// <summary>
		/// The list of requested <see cref="UserAdvanced"/>s.
		/// </summary>
		public UserAdvanced[] userAdvanceds;
	}

	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RepUserAdvancedListByCompany : RepUserAdvancedList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ContentId company;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RepUserAdvancedListByCompanyAndLabels : RepUserAdvancedListByCompany {
		/// <summary>
		/// The labels given as input.
		/// </summary>
		/// <seealso cref="UserGeneral.labels"/>
		public string[] labels;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RepUserAdvancedListByCompanyAndRefPairs : RepUserAdvancedListByCompany {
		/// <summary>
		/// The reference string given as input.
		/// </summary>
		/// <seealso cref="UserGeneral.references"/>
		public Dictionary<string, string> references;
	}
}