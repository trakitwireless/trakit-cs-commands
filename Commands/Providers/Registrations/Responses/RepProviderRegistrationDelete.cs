using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="providerRegistration"/>.
	/// </summary>
	public class RepProviderRegistrationDelete : Reply {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="ProviderRegistration"/>.
		/// </summary>
		public ContentIdDeleted providerRegistration;
	}
}