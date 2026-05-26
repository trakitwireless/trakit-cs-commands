using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="companyPolicies"/>.
	/// </summary>
	public class RepCompanyPolicyGet : Reply {
		/// <summary>
		/// The requested <see cref="CompanyPolicy"/>.
		/// </summary>
		public CompanyPolicy companyPolicy;
	}
}