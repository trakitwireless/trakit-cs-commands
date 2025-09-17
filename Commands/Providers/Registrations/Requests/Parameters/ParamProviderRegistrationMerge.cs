using System;
using Newtonsoft.Json;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create or update an <see cref="ProviderRegistration"/>.
	/// </summary>
	public class ParamProviderRegistrationMerge : ParamMergeSubscribable {
		/// <summary>
		/// The identifier of the <see cref="ProviderConfig"/>/<see cref="ProviderConfiguration"/> that will be loaded onto the new <see cref="Provider"/>.
		/// </summary>
		/// <override required="create" />
		public ulong config;
		/// <summary>
		/// An optional <see cref="Asset"/> to which the new <see cref="Provider"/> will be assigned.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ulong? asset;
		/// <summary>
		/// Identifier of the <see cref="Provider"/> to setup.
		/// This is helpful for long-term deployments, but will be overwritten during provisioning.
		/// </summary>
		/// <seealso cref="Provider.id" />
		/// <override max-length="50" />
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string identifier;
		/// <summary>
		/// If known beforehand, a phone number can be specified for new <see cref="Provider"/>s.
		/// </summary>
		/// <override format="phone" />
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ulong? phone;
		/// <summary>
		/// The lifetime of the <see cref="ProviderRegistration"/>.
		/// The default value (if not specified) is 10 minutes.
		/// It can be specified as up to 2 months to allow for longer deployments.
		/// </summary>
		public TimeSpan lifetime;
		/// <summary>
		/// A nickname given to the <see cref="Provider"/> once it has been provisioned.
		/// </summary>
		/// <override max-length="100" />
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string name;
		/// <summary>
		/// Notes about the <see cref="Provider"/> for after it's been programmed.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string notes;
		/// <summary>
		/// The password programmed on the <see cref="Provider"/> used to ensure the system is the only client authorized to make changes.
		/// </summary>
		/// <override max-length="50" />
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string password;
	}
}