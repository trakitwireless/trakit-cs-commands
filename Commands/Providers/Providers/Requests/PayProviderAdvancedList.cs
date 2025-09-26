using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets a list of <see cref="ProviderAdvanced"/>s.
	/// </summary>
	public abstract class PayProviderAdvancedList : Payload, IPayDeletable, IPaySuspendable {
		/// <summary>
		/// When true, the command will also return suspended <see cref="ProviderAdvanced"/>s.
		/// </summary>
		public bool includeSuspended { get; set; }
		/// <summary>
		/// When true, the command will also return a deleted <see cref="ProviderAdvanced"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}

	/// <summary>
	/// Gets the list of <see cref="ProviderAdvanced"/>s for the specified <see cref="Company"/>.
	/// </summary>
	public class PayProviderAdvancedListByCompany : PayProviderAdvancedList, IPayListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="ProviderAdvanced"/>s for the specified <see cref="Company"/>.
	/// </summary>
	public class PayProviderAdvancedListByConfig: PayProviderAdvancedList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId config { get; set; }
	}
}