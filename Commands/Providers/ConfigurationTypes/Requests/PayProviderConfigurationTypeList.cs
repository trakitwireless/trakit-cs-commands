using System;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="providerConfigurationType"/>.
	/// </summary>
	[Obsolete("Use ReqProviderScriptList instead")]
	public abstract class PayProviderConfigurationTypeList : Payload, IPayDeletable {
		/// <summary>
		/// When true, the command will also return  deleted <see cref="ProviderConfigurationType"/>s.
		/// </summary>
		public bool includeDeleted { get; set; }
	}
	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	[Obsolete("Use ReqProviderScriptListByCompany instead")]
	public class PayProviderConfigurationTypeListByCompany : PayProviderConfigurationTypeList, IPayListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
}