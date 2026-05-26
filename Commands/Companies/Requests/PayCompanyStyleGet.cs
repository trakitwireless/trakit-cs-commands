using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="CompanyStyle"/>.
	/// </summary>
	public class PayCompanyStyleGet : PayCompany, IPayDeletable {
		/// <summary>
		/// When true, the command will also return  deleted <see cref="CompanyStyle"/>s.
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}