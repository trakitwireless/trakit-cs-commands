using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="providerRegistration"/>.
	/// </summary>
	public abstract class PayProviderRegistrationList : Payload, IPayDeletable {
		/// <summary>
		/// When true, the command will also return  deleted <see cref="ProviderRegistration"/>s.
		/// </summary>
		public bool includeDeleted { get; set; }
	}
	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class PayProviderRegistrationListByCompany : PayProviderRegistrationList, IPayListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
}