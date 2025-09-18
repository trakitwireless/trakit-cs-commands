using System;
using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create or update an <see cref="ProviderConfiguration"/>.
	/// </summary>
	[Obsolete("Use ParamProviderConfigMerge instead")]
	public class ParamProviderConfigurationMerge : ParamMergeSubscribable {
		/// <summary>
		/// The unique identifier of the <see cref="ProviderConfiguration"/> you want to update.
		/// Leave this as <c>null</c> when creating a new <see cref="ProviderConfiguration"/>.
		/// </summary>
		public ulong? id;
		/// <summary>
		/// The <see cref="Company"/> to which this <see cref="ProviderConfiguration"/> belongs.
		/// After creation, this value is read-only.
		/// </summary>
		public ulong? company;
		/// <summary>
		/// The <see cref="ProviderConfigurationType"/> that the <see cref="ProviderConfiguration"/> implements.
		/// After creation, this value is read-only.
		/// </summary>
		public ulong? type;
		/// <summary>
		/// Name for the <see cref="ProviderConfiguration"/>.
		/// </summary>
		public string name;
		/// <summary>
		/// Notes for the <see cref="ProviderConfiguration"/>.
		/// </summary>
		public string notes;
		/// <summary>
		/// The values needed to implement the <see cref="ProviderConfigurationType"/>.
		/// Each key in this object is the identifier of a required <see cref="ProviderConfigurationNode"/>.
		/// This command does not support patch semantics; all keys must be sent if any are sent.
		/// </summary>
		public Dictionary<string, object> scriptParameters;
		/// <summary>
		/// A list of <see cref="Place"/>s whose shape is programmed directly onto <see cref="Provider"/>s to raise instant boundary events.
		/// </summary>
		public List<ulong> geofences;
	}
}