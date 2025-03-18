using Trakit.Tools;

namespace Tests {
	[TestClass]
	public sealed class Test_TrakitSerializer {
		public static readonly TrakitSerializer cereal = new TrakitSerializer();
		public static readonly DateTime DateUtc = DateTime.UtcNow;
		public static readonly DateTime DateLocal = DateTime.Now;
		public static readonly DateTime DateUnknown = new DateTime(DateUtc.Ticks);

		[TestMethod]
		public void Serialize_DateTime() {
			Assert.AreEqual(DateUtc.ToString(Text.DATETIME_FORMAT_ISO8601), cereal.Serialize(DateUtc));
			Assert.AreEqual(DateLocal.ToString(Text.DATETIME_FORMAT_ISO8601), cereal.Serialize(DateLocal));
			Assert.AreEqual(DateUnknown.ToString(Text.DATETIME_FORMAT_ISO8601), cereal.Serialize(DateUnknown));
		}
	}
}