using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create or update an <see cref="FormResult"/>.
	/// </summary>
	public class ParamFormResultMerge : ParamMergeSubscribable {
		/// <summary>
		/// The unique identifier of the <see cref="FormResult"/> you want to update.
		/// </summary>
		public ulong? id;
		/// <summary>
		/// The unique identifier of the <see cref="Asset"/> filling out this form.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Include)]
		public ulong? asset;
		/// <summary>
		/// The unique identifier of the <see cref="FormTemplate"/> for this form.
		/// </summary>
		public ulong? template;
		/// <summary>
		/// Name for the <see cref="FormResult"/>.
		/// </summary>
		public string name;
		/// <summary>
		/// Notes for the <see cref="FormResult"/>.
		/// </summary>
		public string notes;
		/// <summary>
		/// Codified label names used to relate forms to <see cref="Asset"/>s.
		/// </summary>
		public List<string> labels;
		/// <summary>
		/// A collection of values for the <see cref="FormResult.fields"/>.
		/// You can update parts of the collection, the <see cref="FormResult"/> must have a value for all fields in order to complete it.
		/// </summary>
		public Dictionary<ulong, string> fields;
		/// <summary>
		/// A timestamp from when the <see cref="FormResult"/> was completed.
		/// </summary>
		public DateTime? completed;
		/// <summary>
		/// Coordinates from when the <see cref="FormResult"/> was completed.
		/// </summary>
		public LatLng latlng;
	}
}