using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="providerAdvanceds"/>.
	/// </summary>
	public abstract class RepProviderAdvancedList : Reply {
		/// <summary>
		/// The list of requested <see cref="ProviderAdvanced"/>s.
		/// </summary>
		public ProviderAdvanced[] providerAdvanceds;
	}

	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RepProviderAdvancedListByCompany : RepProviderAdvancedList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ContentId company;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RepProviderAdvancedListByConfig: RepProviderAdvancedList {
		/// <summary>
		/// Identifier of the <see cref="ProviderConfig"/> (or <see cref="ProviderConfiguration"/>) to which this collection belongs.
		/// </summary>
		public ContentId config;
	}
}