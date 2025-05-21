using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="companyPolicies"/>.
	/// </summary>
	public abstract class RepCompanyPoliciesList : Reply {
		/// <summary>
		/// The list of requested <see cref="CompanyPolicies"/>s.
		/// </summary>
		public CompanyPolicies[] companyPolicies;
	}

	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RepCompanyPoliciesListByCompany : RepCompanyPoliciesList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ContentId company;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RepCompanyPoliciesListByCompanyAndLabels : RepCompanyPoliciesListByCompany {
		/// <summary>
		/// The labels given as input.
		/// </summary>
		/// <seealso cref="CompanyPolicies.labels"/>
		public string[] labels;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RepCompanyPoliciesListByCompanyAndRefPairs : RepCompanyPoliciesListByCompany {
		/// <summary>
		/// The reference string given as input.
		/// </summary>
		/// <seealso cref="CompanyPolicies.references"/>
		public Dictionary<string, string> references;
	}
}