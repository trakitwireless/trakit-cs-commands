using System;
using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create or update an <see cref="ProviderConfig"/>.
	/// </summary>
	public class ParamProviderConfigMerge : ParamMergeSubscribable {
		/// <summary>
		/// The unique identifier of the <see cref="ProviderConfig"/> you want to update.
		/// Leave this as <c>null</c> when creating a new <see cref="ProviderConfig"/>.
		/// </summary>
		public ulong? id;
		/// <summary>
		/// The <see cref="ProviderScript"/> to the <see cref="ProviderConfig"/> implements.
		/// After creation, this value is read-only.
		/// </summary>
		/// <override required="create" />
		public ulong? script;
		/// <summary>
		/// The <see cref="Company"/> to which the <see cref="ProviderConfig"/> belongs.
		/// </summary>
		/// <override required="create" />
		public ulong? company;
		/// <summary>
		/// Name for the <see cref="ProviderConfig"/>.
		/// </summary>
		/// <override required="create" max-length="100" />
		public string name;
		/// <summary>
		/// Notes for the <see cref="ProviderConfig"/>.
		/// </summary>
		public string notes;
		/// <summary>
		/// The values needed to implement the script.
		/// Each key in this object is the name of a required script variable.
		/// </summary>
		public Dictionary<string, string> parameters;
		/// <summary>
		/// A search pattern used to filter which Places' geometry are used as geofences.
		/// Use null or blank string to disable.
		/// Use "*" to match all the Places the Provider's Asset can match.
		/// Or use "#123456" or "label:term" like other Place search patterns.
		/// </summary>
		/// <override type="System.String" format="expression" />
		public string geofences;
	}
}