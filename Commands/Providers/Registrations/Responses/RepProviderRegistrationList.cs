using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="providerRegistrations"/>.
	/// </summary>
	public abstract class RepProviderRegistrationList : Reply {
		/// <summary>
		/// The list of requested <see cref="ProviderRegistration"/>s.
		/// </summary>
		public ProviderRegistration[] providerRegistrations;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RepProviderRegistrationListByCompany : RepProviderRegistrationList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ContentId company;
	}
}