using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="company"/>.
	/// </summary>
	public class RepCompanyBatchDelete : Reply {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="Company"/>.
		/// </summary>
		public ContentIdDeleted[] companies;
	}
}