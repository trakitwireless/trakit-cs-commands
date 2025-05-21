using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="companyStyless"/>.
	/// </summary>
	public abstract class RepCompanyStylesList : Reply {
		/// <summary>
		/// The list of requested <see cref="CompanyStyles"/>s.
		/// </summary>
		public CompanyStyles[] companyStyless;
	}

	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RepCompanyStylesListByCompany : RepCompanyStylesList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ContentId company;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RepCompanyStylesListByCompanyAndLabels : RepCompanyStylesListByCompany {
		/// <summary>
		/// The labels given as input.
		/// </summary>
		/// <seealso cref="CompanyStyles.labels"/>
		public string[] labels;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RepCompanyStylesListByCompanyAndRefPairs : RepCompanyStylesListByCompany {
		/// <summary>
		/// The reference string given as input.
		/// </summary>
		/// <seealso cref="CompanyStyles.references"/>
		public Dictionary<string, string> references;
	}
}