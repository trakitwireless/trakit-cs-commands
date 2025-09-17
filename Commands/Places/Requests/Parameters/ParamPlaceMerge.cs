using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create or update an <see cref="Place"/>.
	/// </summary>
	public class ParamPlaceMerge : ParamMergeSubscribable {
		/// <summary>
		/// The unique identifier of the <see cref="Place"/> you want to update.
		/// Leave this as <c>null</c> when creating a new <see cref="Place"/>.
		/// </summary>
		public ulong? id;
		/// <summary>
		/// The <see cref="Company"/> to which this <see cref="Place"/> belongs.
		/// After creation, this value is read-only.
		/// </summary>
		public ulong? company;
		/// <summary>
		/// Name for the <see cref="Place"/>.
		/// </summary>
		public string name;
		/// <summary>
		/// Notes for the <see cref="Place"/>.
		/// </summary>
		public string notes;
		/// <summary>
		/// The kind of shape being created.
		/// </summary>
		/// <override required="create" />
		public PlaceType? kind;
		/// <summary>
		/// Full street address including province/state, country, and postal/zip code.
		/// </summary>
		public string address;
		/// <summary>
		/// The <see cref="Icon"/> used to display this POI in lists and on the map.
		/// </summary>
		/// <override required="create" />
		/// <seealso cref="Icon.id" />
		public ulong? icon;
		/// <summary>
		/// The codified names of labels
		/// </summary>
		/// <override>
		/// <values format="codified">
		/// <seealso cref="LabelStyle.code" />
		/// </values>
		/// </override>
		public List<string> labels;
		/// <summary>
		/// The fill colour given to this <see cref="Place"/> for easy visual identification on the map.
		/// </summary>
		/// <override max-length="22" format="colour" />
		public string colour;
		/// <summary>
		/// Central lat/long coordinates.
		/// When not present, the shape centre is used for routing.
		/// </summary>
		public LatLng anchor;
		/// <summary>
		/// Boundary threshold (in meters)
		/// </summary>
		/// <override required="create (radial)" />
		public double? radius;
		/// <summary>
		/// For a <see cref="ShapeType.rectangle"/>, the input contains the north east and south west corner coordinates.
		/// For a <see cref="ShapeType.polygon"/>, the input lists all coordinates (oriented as counter-clockwise) needed to draw the geofence.
		/// </summary>
		/// <override required="create (rectangle or polygon)" />
		public List<LatLng> shape;
		/// <summary>
		/// The identifiers of <see cref="Picture"/>s of this <see cref="Place"/>.
		/// </summary>
		/// <override>
		/// <values>
		/// <seealso cref="Picture.id" />
		/// </values>
		/// </override>
		public List<ulong> pictures;
		/// <summary>
		/// A custom field used to refer to an external system.
		/// </summary>
		/// <override max-length="100" />
		public string reference;

		/// <summary>
		/// True when a <see cref="ShapeType.polygon"/> or <see cref="ShapeType.rectangle"/> shape has enough coordinates given.
		/// </summary>
		public bool validPoints() {
			return this.kind == PlaceType.polygon
				? this.shape?.Count >= 3
				: this.kind == PlaceType.rectangle
					? this.shape?.Count == 2
					: this.anchor?.isValid() ?? false;
		}
		/// <summary>
		/// True when a <see cref="ShapeType.radial"/> radius is within the allowed size range.
		/// </summary>
		public bool validRadius() {
			return this.kind == PlaceType.radial
				&& this.radius.HasValue
				&& this.radius.Value != double.NaN
				&& !double.IsInfinity(this.radius.Value);
		}
	}
}