using System;
using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create or update an <see cref="Provider"/>.
	/// </summary>
	public class ParamProviderMerge : ParamMergeSubscribable {
		/// <summary>
		/// Unique identifier of the <see cref="Provider"/>.
		/// </summary>
		/// <override min-length="10" max-length="50" required="always" />
		public string id;
		/// <summary>
		/// A name for the <see cref="Provider"/>.
		/// </summary>
		/// <override required="create" max-length="100" />
		public string name;
		/// <summary>
		/// Notes for this <see cref="Provider"/>.
		/// </summary>
		public string notes;
		/// <summary>
		/// The type of <see cref="Provider"/>.
		/// </summary>
		/// <override required="create" />
		public ProviderType? kind;
		/// <summary>
		/// A reference to the <see cref="Asset"/> with which to provide events.
		/// </summary>
		public ulong? asset;
		/// <summary>
		/// Identifier of the <see cref="ProviderConfig"/>/<see cref="ProviderConfiguration"/> this <see cref="Provider"/> will use.
		/// </summary>
		/// <override required="create" />
		public ulong? config;
		/// <summary>
		/// The phone number this <see cref="Provider"/> uses (if known).
		/// </summary>
		/// <override format="phone" />
		public ulong? phone;
		/// <summary>
		/// The password required to communicate and program this <see cref="Provider"/>.
		/// </summary>
		public string password;
	}
}