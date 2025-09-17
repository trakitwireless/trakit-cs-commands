using System;
using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create or update an <see cref="Behaviour"/>.
	/// </summary>
	public class ParamBehaviourMerge : ParamMergeSubscribable {
		/// <summary>
		/// The unique identifier of the <see cref="Behaviour"/> you want to update.
		/// Leave this as <c>null</c> when creating a new <see cref="Behaviour"/>.
		/// </summary>
		public ulong? id;
		/// <summary>
		/// The <see cref="Company"/> to which this <see cref="Behaviour"/> belongs.
		/// After creation, this value is read-only.
		/// </summary>
		public ulong? company;
		/// <summary>
		/// Identifier of the <see cref="BehaviourScript"/> to which this <see cref="Behaviour"/> belongs.
		/// After creation, this value is read-only.
		/// </summary>
		/// <override required="create" />
		public ulong? script;
		/// <summary>
		/// Name for the <see cref="Behaviour"/>.
		/// </summary>
		/// <override required="create" max-length="100" />
		public string name;
		/// <summary>
		/// Notes for the <see cref="Behaviour"/>.
		/// </summary>
		public string notes;
		/// <summary>
		/// The order in which this <see cref="Behaviour"/> is executed.
		/// </summary>
		public byte? priority;
		/// <summary>
		/// A search pattern used to select the assets which will embed this <see cref="Behaviour"/> in their execution context.
		/// </summary>
		public string targets;
		/// <summary>
		/// A search pattern used to select the providers which can implement this <see cref="Behaviour"/>.
		/// </summary>
		public string filters;
		/// <summary>
		/// The values needed to implement the script.  Each key in this object is the name of a required script argument.
		/// </summary>
		public Dictionary<string, BehaviourParameter> parameters;
	}
}