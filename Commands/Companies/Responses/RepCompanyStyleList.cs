using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="companyStyless"/>.
	/// </summary>
	public abstract class RepCompanyStyleList : Reply {
		/// <summary>
		/// The list of requested <see cref="CompanyStyle"/>s.
		/// </summary>
		public CompanyStyle[] companyStyless;
	}

	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RepCompanyStyleListByCompany : RepCompanyStyleList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ContentId company;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RepCompanyStyleListByCompanyAndLabels : RepCompanyStyleListByCompany {
		/// <summary>
		/// The labels given as input.
		/// </summary>
		/// <seealso cref="CompanyStyle.labels"/>
		public string[] labels;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RepCompanyStyleListByCompanyAndRefPairs : RepCompanyStyleListByCompany {
		/// <summary>
		/// The reference string given as input.
		/// </summary>
		/// <seealso cref="CompanyStyle.references"/>
		public Dictionary<string, string> references;
	}
}