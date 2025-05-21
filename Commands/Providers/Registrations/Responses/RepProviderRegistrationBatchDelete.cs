using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="providerRegistration"/>.
	/// </summary>
	public class RepProviderRegistrationBatchDelete : Reply {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="ProviderRegistration"/>.
		/// </summary>
		public ContentCodeDeleted[] providerRegistrations;
	}
}