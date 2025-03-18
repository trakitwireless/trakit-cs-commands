using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Trakit.Tools {
	/// <summary>
	/// JSON serialization helper that abides by the rules and settings of the Trak-iT APIs.
	/// </summary>
	public class TrakitSerializer {
		// settings used by Trak-iT's APIs
		JsonSerializerSettings _reading, _writing;
		// used to convert JObjects into Trak-iT classes
		JsonSerializer _reader, _writer;

		public TrakitSerializer() {
			_reading = new JsonSerializerSettings() {
				Formatting = Formatting.None,
				DateParseHandling = DateParseHandling.None,
				DateFormatHandling = DateFormatHandling.IsoDateFormat,
				DateTimeZoneHandling = DateTimeZoneHandling.Utc,
				NullValueHandling = NullValueHandling.Ignore,
			};

			// in general
			_reading.Converters.Add(new StringEnumConverter());
			// Trakit.Objects
			_reading.Converters.Add(new ConvertAsset());
			_reading.Converters.Add(new ConvertCompany());
			_reading.Converters.Add(new ConvertProvider());
			_reading.Converters.Add(new ConvertPlace());
			_reading.Converters.Add(new ConvertUser());
			_reading.Converters.Add(new ConvertTimezone());
			_reading.Converters.Add(new ConvertIPAddress());
			_reading.Converters.Add(new ConvertIPEndPoint());
			// Trakit.Commands
			_reading.Converters.Add(new ConvertSelfUser());
			_reading.Converters.Add(new ConvertErrorDetail());
			_reader = JsonSerializer.CreateDefault(_reading);

			// specifically only send DateTimes with 3 digits of presicion, not 7
			_writing = new JsonSerializerSettings(_reading) {
				DateFormatString = Text.DATETIME_FORMAT_ISO8601,
			};
			_writing.Converters.Add(new IsoDateTimeConverter() {
				DateTimeFormat = Text.DATETIME_FORMAT_ISO8601,
			});
			_writer = JsonSerializer.CreateDefault(_writing);
		}

		/// <summary>
		/// Serializes the given value that abides the rules of Trak-iT's APIs.
		/// </summary>
		/// <typeparam name="T">Any object or struct.</typeparam>
		/// <param name="value">The value to serialize.</param>
		/// <returns>The serialized value.</returns>
		public string Serialize<T>(T value) => JsonConvert.SerializeObject(value, _writing);
		/// <summary>
		/// Attempts to serialize the given value that abides the rules of Trak-iT's APIs.
		/// </summary>
		/// <param name="value">The value to serialize.</param>
		/// <param name="text">The serialized value.</param>
		/// <returns>True when successful.</returns>
		public bool TrySerialize<T>(T value, out string text) {
			bool success;
			try {
				text = this.Serialize<T>(value);
				success = true;
			} catch {
				text = default;
				success = false;
			}
			return success;
		}

		/// <summary>
		/// Deserializes the given text into an object abiding by the rules of Trak-iT's APIs.
		/// </summary>
		/// <typeparam name="T">Any object or struct.</typeparam>
		/// <param name="text">The serialized value.</param>
		/// <returns>The <typeparamref name="T">object or struct</typeparamref>.</returns>
		public T Deserialize<T>(string text) => JsonConvert.DeserializeObject<T>(text, _reading);
		/// <summary>
		/// Attempts to deserializes the given text into an object abiding by the rules of Trak-iT's APIs.
		/// </summary>
		/// <typeparam name="T">Any object or struct.</typeparam>
		/// <param name="text">The serialized value.</param>
		/// <param name="value">The <typeparamref name="T">object or struct</typeparamref>.</param>
		/// <returns>True when successful.</returns>
		public bool TryDeserialize<T>(string text, out T value) {
			bool success;
			try {
				value = this.Deserialize<T>(text);
				success = true;
			} catch {
				value = default;
				success = false;
			}
			return success;
		}

		/// <summary>
		/// Converts the given <see cref="JToken"/> into an object abiding by the rules of Trak-iT's APIs.
		/// </summary>
		/// <typeparam name="T">Any type of object, not compatible with structs.</typeparam>
		/// <param name="token">JSON of the desired <typeparamref name="T">value</typeparamref>.</param>
		/// <returns>The desired <typeparamref name="T">value</typeparamref>.</returns>
		public T ConvertFrom<T>(JToken token) => token.ToObject<T>(_reader);
		/// <summary>
		/// Attempts to converts the given <see cref="JToken"/> into an object abiding by the rules of Trak-iT's APIs.
		/// </summary>
		/// <typeparam name="T">Any type of object, not compatible with structs.</typeparam>
		/// <param name="token">JSON of the desired <typeparamref name="T">value</typeparamref>.</param>
		/// <param name="value">The desired <typeparamref name="T">value</typeparamref>.</param>
		/// <returns>True when successful.</returns>
		public bool TryConvertFrom<T>(JToken token, out T value) {
			bool success;
			try {
				value = this.ConvertFrom<T>(token);
				success = true;
			} catch {
				value = default;
				success = false;
			}
			return success;
		}
		/// <summary>
		/// Converts the given <paramref name="value"/> into a <see cref="JToken"/> abiding by the rules of Trak-iT's APIs.
		/// </summary>
		/// <typeparam name="J">The kind of JSON token being returned.</typeparam>
		/// <param name="value">The object or struct.</param>
		/// <returns>The desired <see cref="JToken"/>.</returns>
		public J ConvertTo<J>(object value) where J : JToken => (J)JToken.FromObject(value, _writer);
		/// <summary>
		/// Attempts to converts the given <paramref name="value"/> into <see cref="JToken"/> abiding by the rules of Trak-iT's APIs.
		/// </summary>
		/// <typeparam name="J">The kind of JSON token being returned.</typeparam>
		/// <param name="value">The object or struct.</param>
		/// <param name="token">The desired <see cref="JToken"/>.</param>
		/// <returns>True when successful.</returns>
		public bool TryConvertTo<J>(object value, out J token) where J : JToken {
			bool success;
			try {
				token = this.ConvertTo<J>(value);
				success = true;
			} catch {
				token = default;
				success = false;
			}
			return success;
		}
	}
}