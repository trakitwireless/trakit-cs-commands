using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="companyDirectory"/>.
	/// </summary>
	public class RepCompanyDirectoryGet : Reply {
		/// <summary>
		/// The requested <see cref="CompanyDirectory"/>.
		/// </summary>
		public CompanyDirectory companyDirectory;
	}
}