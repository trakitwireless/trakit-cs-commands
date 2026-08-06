using System;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Trakit.Tools {
	/// <summary>
	/// 
	/// </summary>
	public class ConvertIPAddress : TrakitConverter<IPAddress> {
		public ConvertIPAddress() : base(true, true) { }

		public override IPAddress ConvertFrom(JsonReader reader, Type type, IPAddress ipEnd, JsonSerializer serializer)
			=> IPAddress.Parse(JToken.Load(reader).Value<string>());
		public override void ConvertTo(JsonWriter writer, IPAddress value, JsonSerializer serializer)
			=> writer.WriteValue(value.ToString());
	}
}