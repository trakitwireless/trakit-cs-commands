using System;
using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create or update an <see cref="ProviderScript"/>.
	/// </summary>
	public class ParamProviderScriptMerge : ParamMergeSubscribable {
		/// <summary>
		/// The unique identifier of the <see cref="ProviderScript"/> you want to update.
		/// Leave this as <c>null</c> when creating a new <see cref="ProviderScript"/>.
		/// </summary>
		public ulong? id;
		/// <summary>
		/// The <see cref="Company"/> to which this <see cref="ProviderScript"/> belongs.
		/// After creation, this value is read-only.
		/// </summary>
		public ulong? company;
		/// <summary>
		/// Name for the <see cref="ProviderScript"/>.
		/// </summary>
		public string name;
		/// <summary>
		/// Notes for the <see cref="ProviderScript"/>.
		/// </summary>
		public string notes;
		/// <summary>
		/// Indicates whether this <see cref="ProviderScript"/> is available to child companies.
		/// </summary>
		public bool? global;
		/// <summary>
		/// The type of provider for which this <see cref="ProviderScript"/> can be used.
		/// Limiting to a specific model from a manufacturer is accomplished through the block conditions.
		/// </summary>
		public ProviderType? kind;
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
		/// <summary>
		/// Blocks of file data which are (optionally) included in the <see cref="ProviderScript"/> data file.
		/// </summary>
		/// <values min-count="1" />
		/// </override>
		public List<ProviderScriptBlock> blocks;
		/// <summary>
		/// Parameter definitions for this <see cref="ProviderScript"/>, including type-hints and default values.
		/// </summary>
		public Dictionary<string, ProviderScriptParameter> parameters;
	}
}