using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Trakit.Objects;

namespace Trakit.Tools {
	/// <summary>
	/// 
	/// </summary>
	public class ConvertPlace : TrakitConverter<Place> {
		public ConvertPlace() : base(canRead: true, canWrite: true) { }

		public override Place ConvertFrom(JsonReader reader, Type type, Place place, JsonSerializer serializer) {
			var obj = JObject.Load(reader);
			if (!Enum.TryParse(obj["kind"].ToString(), true, out PlaceType kind)) throw new JsonException();

			switch (obj["points"]?.Type) {
				case JTokenType.String:
					// overwrite object
					obj["points"] = JArray.FromObject(Polyline.Decode(obj["points"].ToString()));
					break;
			}
			place = obj.ToObject<Place>(serializer);
			return place;
		}
		public override void ConvertTo(JsonWriter writer, Place value, JsonSerializer serializer) {
			var obj = JObject.FromObject(value, serializer);
			if (value.points?.Length > 0) obj["points"] = Polyline.Encode(value.points);
			obj.WriteTo(writer);
		}
	}
}