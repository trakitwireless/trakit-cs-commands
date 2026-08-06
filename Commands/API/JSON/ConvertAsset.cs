using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Trakit.Objects;

namespace Trakit.Tools {
	/// <summary>
	/// 
	/// </summary>
	public class ConvertAsset : TrakitConverter<Asset> {
		public ConvertAsset() : base(canRead: true, canWrite: false) { }

		public override Asset ConvertFrom(JsonReader reader, Type type, Asset asset, JsonSerializer serializer) {
			var obj = JObject.Load(reader);
			if (
				bool.TryParse(obj["deleted"]?.ToString(), out _)
				|| bool.TryParse(obj["suspended"]?.ToString(), out _)
			) {
				asset = new Asset() {
					General = obj.ToObject<AssetGeneral>(serializer),
				};
			} else {
				asset = new Asset() {
					General = obj.ToObject<AssetGeneral>(serializer),
					Advanced = obj.ToObject<AssetAdvanced>(serializer),
					dispatch = obj["dispatch"].ToObject<AssetDispatch>(serializer),
				};
				asset.dispatch.id = asset.id;
				asset.dispatch.company = asset.company;
				asset.v = obj["v"].Select(p => (int)p).ToArray();
			}
			return asset;
		}
	}
}