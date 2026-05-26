using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="companyStyles"/>.
	/// </summary>
	public class RepCompanyStyleGet : Reply {
		/// <summary>
		/// The requested <see cref="CompanyStyle"/>.
		/// </summary>
		public CompanyStyle companyStyles;
	}
}