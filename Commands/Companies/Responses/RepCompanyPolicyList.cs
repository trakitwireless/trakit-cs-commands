using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="companyPolicy"/>.
	/// </summary>
	public abstract class RepCompanyPolicyList : Reply {
		/// <summary>
		/// The list of requested <see cref="CompanyPolicy"/>s.
		/// </summary>
		public CompanyPolicy[] companyPolicy;
	}

	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RepCompanyPolicyListByCompany : RepCompanyPolicyList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ContentId company;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RepCompanyPolicyListByCompanyAndLabels : RepCompanyPolicyListByCompany {
		/// <summary>
		/// The labels given as input.
		/// </summary>
		/// <seealso cref="CompanyPolicies.labels"/>
		public string[] labels;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RepCompanyPolicyListByCompanyAndRefPairs : RepCompanyPolicyListByCompany {
		/// <summary>
		/// The reference string given as input.
		/// </summary>
		/// <seealso cref="CompanyPolicies.references"/>
		public Dictionary<string, string> references;
	}
}