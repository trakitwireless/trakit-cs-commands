using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="company"/>.
	/// </summary>
	public class RepCompanyGet : Reply {
		/// <summary>
		/// The requested <see cref="Company"/>.
		/// </summary>
		public Company company;
	}
}