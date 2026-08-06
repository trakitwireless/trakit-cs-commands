using System;
using Newtonsoft.Json;

namespace Trakit.Tools {
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// Inspiration for this approach was taken from https://github.com/JamesNK/Newtonsoft.Json/issues/719#issuecomment-2103805140
	/// Which was itself inspired by https://stackoverflow.com/questions/16085805/recursively-call-jsonserializer-in-a-jsonconverter/76705937#76705937
	/// </remarks>
	public abstract class TrakitConverter<T> : JsonConverter {
		/// Flag to indicate if the converter is currently reading JSON.
		/// This prevents recursive calls to use this converter to read.
		bool _isReading;
		/// Flag to indicate if the converter is currently writing JSON.
		/// This prevents recursive calls to use this converter to write.
		bool _isWriting;

		/// Flag to indicate if the converter can deserialize JSON.
		readonly bool _canRead;
		/// Flag to indicate if the converter can serialize JSON.
		readonly bool _canWrite;

		/// <summary>
		/// Indicates that this converter can be used to deserialize JSON.
		/// </summary>
		public override sealed bool CanRead => _canRead && !_isReading;
		/// <summary>
		/// Indicates that this converter can be used to serialize JSON.
		/// </summary>
		public override sealed bool CanWrite => _canWrite && !_isWriting;
		/// <summary>
		/// Checks to see if the specified type is assignable from the generic type parameter <typeparamref name="T"/>.
		/// </summary>
		/// <param name="objectType"></param>
		/// <returns></returns>
		public override bool CanConvert(Type objectType)
			=> !(_isReading || _isWriting)     // not currently in use
			&& typeof(T).IsAssignableFrom(objectType);

		public TrakitConverter(bool canRead, bool canWrite) : base() {
			// by setting these defaults, we can control the read/write behaviour globally for this instance.
			_canRead = canRead;
			_canWrite = canWrite;
		}

		/// <summary>
		/// Internal function used by Newtonsoft to convert JSON to an object of the specified type.
		/// This sets a flag to indicate that the converter is currently reading JSON,
		/// preventing recursive calls to use this converter to read.
		/// </summary>
		/// <param name="reader">The JSON reader used to read the JSON data.</param>
		/// <param name="type">The type to which the JSON data will be converted.</param>
		/// <param name="value">The existing value to update or null if no value exists.</param>
		/// <param name="serializer">The serializer used for converting the JSON data.</param>
		/// <returns>The converted object of the specified type.</returns>
		/// <exception cref="InvalidOperationException">Thrown when a recursive read is detected.</exception>
		public override sealed object ReadJson(
			JsonReader reader,
			Type type,
			object value,
			JsonSerializer serializer
		) {
			if (_isReading) {
				// Protect against any changes to Newtonsoft that somehow cause concurrent access in the same thread recursively
				throw new InvalidOperationException($"Recursive read detected on {this.GetType().Name}");
			}
			_isReading = true;
			try {
				return this.ConvertFrom(reader, type, (T)value, serializer);
			} finally {
				_isReading = false;
			}
		}
		/// <summary>
		/// Internal function used by Newtonsoft to convert an object to JSON.
		/// This sets a flag to indicate that the converter is currently writing JSON,
		/// preventing recursive calls to use this converter to write.
		/// </summary>
		/// <param name="writer">The JSON writer used to write the JSON data.</param>
		/// <param name="value">The object to be converted to JSON.</param>
		/// <param name="serializer">The serializer used for converting the object to JSON.</param>
		/// <exception cref="InvalidOperationException">Thrown when a recursive write is detected.</exception>
		public override sealed void WriteJson(
			JsonWriter writer,
			object value,
			JsonSerializer serializer
		) {
			if (_isWriting) {
				// Protect against any changes to Newtonsoft that somehow cause concurrent access in the same thread recursively
				throw new InvalidOperationException($"Recursive write detected on {this.GetType().Name}");
			}
			_isWriting = true;
			try {
				this.ConvertTo(writer, (T)value, serializer);
			} finally {
				_isWriting = false;
			}
		}

		/// <summary>
		/// Reads JSON data and converts it to the specified type.
		/// </summary>
		/// <param name="reader">The JSON reader used to read the JSON data.</param>
		/// <param name="type">The type to which the JSON data will be converted.</param>
		/// <param name="value">The existing value to update or null if no value exists.</param>
		/// <param name="serializer">The serializer used for converting the JSON data.</param>
		/// <returns></returns>
		public virtual T ConvertFrom(
			JsonReader reader,
			Type type,
			T value,
			JsonSerializer serializer
		) => throw new NotImplementedException($"ConvertFrom is not implemented for {this.GetType().Name}");
		/// <summary>
		/// Writes the specified object as JSON using the provided writer and serializer.
		/// </summary>
		/// <param name="writer">The JSON writer used to write the JSON data.</param>
		/// <param name="value">The object to be converted to JSON.</param>
		/// <param name="serializer">The serializer used for converting the object to JSON.</param>
		public virtual void ConvertTo(
			JsonWriter writer,
			T value,
			JsonSerializer serializer
		) => throw new NotImplementedException($"ConvertTo is not implemented for {this.GetType().Name}");
	}
}