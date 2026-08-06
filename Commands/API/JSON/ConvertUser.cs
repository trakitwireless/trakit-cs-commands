using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Trakit.Objects;

namespace Trakit.Tools {
	/// <summary>
	/// 
	/// </summary>
	public class ConvertUser : TrakitConverter<User> {
		public ConvertUser() : base(canRead: true, canWrite: true) { }

		public override User ConvertFrom(JsonReader reader, Type type, User user, JsonSerializer serializer) {
			var obj = JObject.Load(reader);
			user = new User() {
				General = obj.ToObject<UserGeneral>(serializer),
				Advanced = obj.ToObject<UserAdvanced>(serializer),
				Authentication = obj.ToObject<UserAuthentication>(serializer),
				State = obj.ToObject<UserState>(serializer),
			};
			user.v = obj["v"].Select(p => (int)p).ToArray();
			return user;
		}
		public override void ConvertTo(JsonWriter writer, User value, JsonSerializer serializer) {
			var obj = new JObject();
			foreach (var pair in JObject.FromObject(value.General, serializer)) {
				obj[pair.Key] = pair.Value;
			}
			foreach (var pair in JObject.FromObject(value.Advanced, serializer)) {
				obj[pair.Key] = pair.Value;
			}
			foreach (var pair in JObject.FromObject(value.Authentication, serializer)) {
				obj[pair.Key] = pair.Value;
			}
			foreach (var pair in JObject.FromObject(value.State, serializer)) {
				obj[pair.Key] = pair.Value;
			}
			obj["v"] = JArray.FromObject(value.v, serializer);
			obj.WriteTo(writer);
		}
	}
}