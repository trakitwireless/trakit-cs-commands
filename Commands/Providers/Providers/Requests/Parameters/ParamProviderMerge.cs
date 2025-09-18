using System;
using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create or update an <see cref="Provider"/>.
	/// </summary>
	public class ParamProviderMerge : ParamMergeSubscribable {
		/// <summary>
		/// The unique identifier of the <see cref="Provider"/> you want to update.
		/// Leave this as <c>null</c> when creating a new <see cref="Provider"/>.
		/// </summary>
		public ulong? id;
		/// <summary>
		/// The <see cref="Company"/> to which this <see cref="Provider"/> belongs.
		/// After creation, this value is read-only.
		/// </summary>
		public ulong? company;
		/// <summary>
		/// Name for the <see cref="Provider"/>.
		/// </summary>
		public string name;
		/// <summary>
		/// Notes for the <see cref="Provider"/>.
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