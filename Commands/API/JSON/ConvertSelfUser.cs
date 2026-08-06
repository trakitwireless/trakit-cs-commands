using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Trakit.Commands;
using Trakit.Objects;

namespace Trakit.Tools {
	/// <summary>
	/// 
	/// </summary>
	public class ConvertSelfUser : TrakitConverter<SelfUser> {
		public ConvertSelfUser() : base(canRead: true, canWrite: true) { }

		public override SelfUser ConvertFrom(JsonReader reader, Type type, SelfUser user, JsonSerializer serializer) {
			var obj = JObject.Load(reader);
			user = new SelfUser() {
				General = obj.ToObject<SelfUserGeneral>(serializer),
				Advanced = obj.ToObject<SelfUserAdvanced>(serializer),
				Authentication = obj.ToObject<UserAuthentication>(serializer),
				State = obj.ToObject<UserState>(serializer),
				policy = obj["policies"].ToObject<CompanyPolicy>(serializer),
			};
			user.v = obj["v"].Select(p => (int)p).ToArray();
			return user;
		}
		public override void ConvertTo(JsonWriter writer, SelfUser value, JsonSerializer serializer) {
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
			obj["policies"] = JObject.FromObject(value.policy, serializer);
			obj["v"] = JArray.FromObject(value.v, serializer);
			obj.WriteTo(writer);

		}
	}
}