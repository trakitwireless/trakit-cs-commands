using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="providerControls"/>.
	/// </summary>
	public abstract class RepProviderControlList : Reply {
		/// <summary>
		/// The list of requested <see cref="ProviderControl"/>s.
		/// </summary>
		public ProviderControl[] providerControls;
	}

	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RepProviderControlListByCompany : RepProviderControlList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ContentId company;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RepProviderControlListByConfig: RepProviderControlList {
		/// <summary>
		/// Identifier of the <see cref="ProviderConfig"/> (or <see cref="ProviderConfiguration"/>) to which this collection belongs.
		/// </summary>
		public ContentId config;
	}
}