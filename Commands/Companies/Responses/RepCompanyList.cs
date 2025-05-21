using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="companies"/>.
	/// </summary>
	public abstract class RepCompanyList : Reply {
		/// <summary>
		/// The list of requested <see cref="Company"/>s.
		/// </summary>
		public Company[] companies;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RepCompanyListByCompany : RepCompanyList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ContentId company;
	}
	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RepCompanyListByCompanyAndRefPairs : RepCompanyListByCompany, IPayListByReferences {
		/// <summary>
		/// The parsed references given as input.
		/// </summary>
		/// <seealso cref="CompanyGeneral.references"/>
		public Dictionary<string, string> references { get; set; }
	}
}