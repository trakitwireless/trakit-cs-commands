using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Trakit.Tools {
	/// <summary>
	/// 
	/// </summary>
	public class ConvertDateTime : TrakitConverter<DateTime> {
		IsoDateTimeConverter _internal = new IsoDateTimeConverter();

		public ConvertDateTime() : base(canRead: true, canWrite: true) { }

		public override DateTime ConvertFrom(
			JsonReader reader,
			Type type,
			DateTime value,
			JsonSerializer serializer
		) => (DateTime)_internal.ReadJson(
			reader,
			type,
			value,
			serializer
		);
		public override void ConvertTo(JsonWriter writer, DateTime value, JsonSerializer serializer) {
			if (value.Kind == DateTimeKind.Local) value = value.ToUniversalTime();
			/// specifically only write <see cref="DateTime"/>s with only 3 digits of presicion, not 7
			writer.WriteValue(value.ToString(Text.DATETIME_FORMAT_ISO8601));
		}
	}
}