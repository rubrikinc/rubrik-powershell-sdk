using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace RubrikSecurityCloud.Client.Tests
{
    [TestFixture]
    public class EnumJsonConverterTests
    {
        private JsonSerializerSettings _jsonSerializerSettings;

        [SetUp]
        public void Setup()
        {
            _jsonSerializerSettings = new JsonSerializerSettings
            {
                Converters = new List<JsonConverter> { new EnumJsonConverter() },
                NullValueHandling = NullValueHandling.Include
            };
        }

        [Test]
        public void SingleEnumValue()
        {
            string json = "\"Connected\"";
            var result = JsonConvert.DeserializeObject<ClusterStatus>(json, _jsonSerializerSettings);

            Assert.AreEqual(ClusterStatus.CONNECTED, result);
        }

        [Test]
        public void SingleUnknownValue()
        {
            string json = "\"invalid_value\"";
            var result = JsonConvert.DeserializeObject<ClusterStatus>(json, _jsonSerializerSettings);

            Assert.AreEqual(ClusterStatus.UNKNOWN, result);
        }

        [Test]
        public void SingleEnumValueNull()
        {
            string json = "null";
            var result = JsonConvert.DeserializeObject<ClusterStatus?>(json, _jsonSerializerSettings);

            Assert.IsNull(result);
        }

        [Test]
        public void ListOfEnumValues()
        {
            string json = "[\"Connected\", \"Disconnected\", \"Initializing\"]";
            var result = JsonConvert.DeserializeObject<List<ClusterStatus>>(json, _jsonSerializerSettings);

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(ClusterStatus.CONNECTED, result[0]);
            Assert.AreEqual(ClusterStatus.DISCONNECTED, result[1]);
            Assert.AreEqual(ClusterStatus.INITIALIZING, result[2]);
        }

        [Test]
        public void ListWithNullEnumValues()
        {
            string json = "[\"Connected\", null, \"Initializing\"]";
            var result = JsonConvert.DeserializeObject<List<ClusterStatus?>>(json, _jsonSerializerSettings);

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(ClusterStatus.CONNECTED, result[0]);
            Assert.IsNull(result[1]);
            Assert.AreEqual(ClusterStatus.INITIALIZING, result[2]);
        }
        [Test]
        public void ListWithUnknown()
        {
            string json = "[\"Connected\", \"invalidValue\", \"Initializing\"]";
            var result = JsonConvert.DeserializeObject<List<ClusterStatus?>>(json, _jsonSerializerSettings);

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(ClusterStatus.CONNECTED, result[0]);
            Assert.AreEqual(ClusterStatus.UNKNOWN, result[1]);
            Assert.AreEqual(ClusterStatus.INITIALIZING, result[2]);
        }
    }

    public enum ClusterStatus
    {
        [EnumMember(Value = "Connected")]
        CONNECTED,

        [EnumMember(Value = "Disconnected")]
        DISCONNECTED,

        [EnumMember(Value = "Initializing")]
        INITIALIZING,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN
    }
}