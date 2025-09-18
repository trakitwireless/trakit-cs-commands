using System;
using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create or update an <see cref="AssetMessage"/>.
	/// </summary>
	public class ParamAssetMessageMerge : ParamMergeSubscribable {
		/// <summary>
		/// The unique identifier of the <see cref="AssetMessage"/> you want to update.
		/// Leave this as <c>null</c> when creating a new <see cref="AssetMessage"/>.
		/// </summary>
		public ulong? id;
		/// <summary>
		/// The <see cref="Asset"/> that this <see cref="Message"/> was sent from or to.
		/// After creation, this value is read-only.
		/// </summary>
		public ulong? asset;
		/// <summary>
		/// The kind of protocol used for this <see cref="Message"/>.
		/// After creation, this value is read-only.
		/// </summary>
		public MessageType? kind;
		/// <summary>
		/// The folder where this <see cref="Message"/> is stored.
		/// </summary>
		public MessageFolder? folder;
		/// <summary>
		/// Optional to address used when creating the <see cref="Message"/> if no messaging address is available.
		/// After creation, this value is read-only.
		/// </summary>
		public string to;
		/// <summary>
		/// The <see cref="Message"/> subject field.
		/// After creation, this value is read-only.
		/// This is used exclusively with <see cref="MemoType.email"/> type <see cref="Message"/>s.
		/// </summary>
		public string subject;
		/// <summary>
		/// The body of the <see cref="Message"/>.
		/// After creation, this value is read-only.
		/// </summary>
		public string body;
		/// <summary>
		/// Set to true to log that the <see cref="Message"/> was received and read by yourself.
		/// Once set, the <see cref="Message.readBy"/> value will be your login, and cannot be set by anyone else.
		/// </summary>
		public bool? read;
	}
}