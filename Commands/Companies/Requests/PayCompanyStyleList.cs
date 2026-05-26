using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets a list of <see cref="CompanyStyle"/>s.
	/// </summary>
	public abstract class PayCompanyStyleList : Payload, IPayDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="CompanyStyle"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}

	/// <summary>
	/// Gets the list of <see cref="CompanyStyle"/>s for the specified <see cref="Company"/>.
	/// </summary>
	public class PayCompanyStyleListByCompany : PayCompanyStyleList, IPayListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="CompanyStyle"/>s for the specified <see cref="Company"/> only if the <see cref="CompanyStylesStyles.labels"/> matches all of the given <see cref="Parameters.labels"/>.
	/// </summary>
	public class PayCompanyStyleListByCompanyAndLabels : PayCompanyStyleListByCompany, IPayListByLabels {
		/// <summary>
		/// The parsed labels given as input.
		/// </summary>
		/// <seealso cref="CompanyStyle.labels"/>
		public List<string> labels { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="CompanyStyle"/>s for the specified <see cref="Company"/> only if one of the specified <see cref="CompanyStylesStyles.references"/> fields match.
	/// If no references are specified, it will match any <see cref="CompanyStyle"/> with no references.
	/// If a reference value is null, it will match any <see cref="CompanyStyle"/> without that reference key.
	/// </summary>
	public class PayCompanyStyleListByCompanyAndRefPairs : PayCompanyStyleListByCompany, IPayListByReferences {
		/// <summary>
		/// The parsed references given as input.
		/// </summary>
		/// <seealso cref="CompanyStylesStyles.references"/>
		public Dictionary<string, string> references { get; set; }
	}
}