using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Trakit.Objects;

namespace Trakit.Tools {
	/// <summary>
	/// 
	/// </summary>
	public class ConvertCompany : TrakitConverter<Company> {
		public ConvertCompany() : base(canRead: true, canWrite: false) { }

		public override Company ConvertFrom(JsonReader reader, Type type, Company company, JsonSerializer serializer) {
			var obj = JObject.Load(reader);
			if (bool.TryParse(obj["deleted"]?.ToString(), out _)) {
				company = new Company() {
					General = obj.ToObject<CompanyGeneral>(serializer),
				};
			} else {
				company = new Company() {
					General = obj.ToObject<CompanyGeneral>(serializer),
					Directory = obj.ToObject<CompanyDirectory>(serializer),
					Policy = obj.ToObject<CompanyPolicy>(serializer),
					Style = obj.ToObject<CompanyStyle>(serializer),
				};
				if (obj["reseller"]?.Type == JTokenType.Object) {
					company.Reseller = obj["reseller"].ToObject<CompanyReseller>(serializer);
				}
				company.v = obj["v"].Select(p => (int)p).ToArray();
			}
			return company;
		}
		public override void ConvertTo(JsonWriter writer, Company value, JsonSerializer serializer) {
			var obj = new JObject();
			foreach (var pair in JObject.FromObject(value.General, serializer)) {
				obj[pair.Key] = pair.Value;
			}
			foreach (var pair in JObject.FromObject(value.Directory, serializer)) {
				obj[pair.Key] = pair.Value;
			}
			foreach (var pair in JObject.FromObject(value.Policy, serializer)) {
				obj[pair.Key] = pair.Value;
			}
			foreach (var pair in JObject.FromObject(value.Style, serializer)) {
				obj[pair.Key] = pair.Value;
			}
			obj["reseller"] = JObject.FromObject(value.Reseller, serializer);
			obj["v"] = JArray.FromObject(value.v, serializer);
			obj.WriteTo(writer);
		}
	}
}