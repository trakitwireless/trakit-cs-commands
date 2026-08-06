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
		public ConvertSelfUser() : base(canRead: true, canWrite: false) { }

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
	}
}