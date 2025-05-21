using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="CompanyPolicies"/>.
	/// </summary>
	public class PayCompanyPoliciesGet : PayCompany, IPayDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="CompanyPolicies"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}