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

        [Test]
        public void UnknownValueLogsWarning()
        {
            var logger = new TestLogger();
            var settings = new JsonSerializerSettings
            {
                Converters = new List<JsonConverter> { new EnumJsonConverter(logger) },
                NullValueHandling = NullValueHandling.Include
            };

            string json = "\"NEW_SERVER_VALUE\"";
            var result = JsonConvert.DeserializeObject<ClusterStatus>(json, settings);

            Assert.AreEqual(ClusterStatus.UNKNOWN, result);
            Assert.AreEqual(1, logger.Messages.Count);
            StringAssert.Contains("NEW_SERVER_VALUE", logger.Messages[0]);
            StringAssert.Contains("ClusterStatus", logger.Messages[0]);
        }

        [Test]
        public void UnknownValueInListLogsWarning()
        {
            var logger = new TestLogger();
            var settings = new JsonSerializerSettings
            {
                Converters = new List<JsonConverter> { new EnumJsonConverter(logger) },
                NullValueHandling = NullValueHandling.Include
            };

            string json = "[\"Connected\", \"BRAND_NEW_VALUE\", \"Disconnected\"]";
            var result = JsonConvert.DeserializeObject<List<ClusterStatus>>(json, settings);

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(ClusterStatus.UNKNOWN, result[1]);
            Assert.AreEqual(1, logger.Messages.Count);
            StringAssert.Contains("BRAND_NEW_VALUE", logger.Messages[0]);
        }

        [Test]
        public void KnownValueDoesNotLog()
        {
            var logger = new TestLogger();
            var settings = new JsonSerializerSettings
            {
                Converters = new List<JsonConverter> { new EnumJsonConverter(logger) },
                NullValueHandling = NullValueHandling.Include
            };

            string json = "\"Connected\"";
            var result = JsonConvert.DeserializeObject<ClusterStatus>(json, settings);

            Assert.AreEqual(ClusterStatus.CONNECTED, result);
            Assert.AreEqual(0, logger.Messages.Count);
        }

        [Test]
        public void MultipleUnknownValuesLogMultipleWarnings()
        {
            var logger = new TestLogger();
            var settings = new JsonSerializerSettings
            {
                Converters = new List<JsonConverter> { new EnumJsonConverter(logger) },
                NullValueHandling = NullValueHandling.Include
            };

            string json = "[\"ALPHA\", \"Connected\", \"BETA\"]";
            var result = JsonConvert.DeserializeObject<List<ClusterStatus>>(json, settings);

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(ClusterStatus.UNKNOWN, result[0]);
            Assert.AreEqual(ClusterStatus.CONNECTED, result[1]);
            Assert.AreEqual(ClusterStatus.UNKNOWN, result[2]);
            Assert.AreEqual(2, logger.Messages.Count);
            StringAssert.Contains("ALPHA", logger.Messages[0]);
            StringAssert.Contains("BETA", logger.Messages[1]);
        }
    }

    /// <summary>
    /// Minimal IRscLogger for testing. Captures all messages.
    /// </summary>
    internal class TestLogger : IRscLogger
    {
        public List<string> Messages { get; } = new List<string>();

        public void Debug(string message, string memberName = "", string filePath = "", int lineNumber = 0)
        {
            Messages.Add(message);
        }

        public void Verbose(string message)
        {
            Messages.Add(message);
        }

        public void Info(string message)
        {
            Messages.Add(message);
        }

        public void Warning(string message)
        {
            Messages.Add(message);
        }

        public void Error(string message)
        {
            Messages.Add(message);
        }

        public void Flush() { }
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
