using System;
using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create or update an <see cref="BehaviourScript"/>.
	/// </summary>
	public class ParamBehaviourScriptMerge : ParamMergeSubscribable {
		/// <summary>
		/// The unique identifier of the <see cref="BehaviourScript"/> you want to update.
		/// Leave this as <c>null</c> when creating a new <see cref="BehaviourScript"/>.
		/// </summary>
		public ulong? id;
		/// <summary>
		/// The <see cref="Company"/> to which this <see cref="BehaviourScript"/> belongs.
		/// After creation, this value is read-only.
		/// </summary>
		public ulong? company;
		/// <summary>
		/// Name for the <see cref="BehaviourScript"/>.
		/// </summary>
		public string name;
		/// <summary>
		/// Notes for the <see cref="BehaviourScript"/>.
		/// </summary>
		public string notes;
		/// <summary>
		/// Source code of the <see cref="BehaviourScript"/>.
		/// </summary>
		/// <remarks>
		/// See the <external href="https://apis.trakit.ca/bs/article/getting-started">Behaviours reference</external> for help in writing and debugging scripts.
		/// </remarks>
		/// <override required="create" />
		public string source;
		/// <summary>
		/// When set to true, this <see cref="Company"/> as well as all child companies will be able to implement this <see cref="BehaviourScript"/> for that companies assets.
		/// </summary>
		public bool? global;
		/// <summary>
		/// A search pattern used to select the providers.
		/// </summary>
		public string filters;
		/// <summary>
		/// The defined arguments for this <see cref="BehaviourScript"/>.
		/// Each key in the object is the name of an argument.
		/// </summary>
		public Dictionary<string, BehaviourParameter> parameters;
		/// <summary>
		/// Background and fill colour in the UI.
		/// </summary>
		public string fill;
		/// <summary>
		/// Text and outline colour in the UI.
		/// </summary>
		public string stroke;
		/// <summary>
		/// The name of the symbol shown in the UI.
		/// </summary>
		public string graphic;
	}
}