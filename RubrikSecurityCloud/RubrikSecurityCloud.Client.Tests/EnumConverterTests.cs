using Newtonsoft.Json;
using RubrikSecurityCloud.Client.Models;
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
            // Reset global config to defaults before each test
            RubrikSecurityCloud.Config.SchemaStrict = false;
            RubrikSecurityCloud.Config.MuteSchemaWarnings = true;
        }

        // ── Basic deserialization ────────────────────────────────────

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

        // ── Logging behavior ─────────────────────────────────────────

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

        // ── MuteSchemaWarnings routing ───────────────────────────────

        [Test]
        public void MutedWarningsRouteToVerbose()
        {
            RubrikSecurityCloud.Config.MuteSchemaWarnings = true;
            var logger = new TestLogger();
            var settings = new JsonSerializerSettings
            {
                Converters = new List<JsonConverter> { new EnumJsonConverter(logger) },
                NullValueHandling = NullValueHandling.Include
            };

            JsonConvert.DeserializeObject<ClusterStatus>("\"SOME_NEW_VALUE\"", settings);

            Assert.AreEqual(1, logger.VerboseMessages.Count);
            Assert.AreEqual(0, logger.WarningMessages.Count);
        }

        [Test]
        public void UnmutedWarningsRouteToWarning()
        {
            RubrikSecurityCloud.Config.MuteSchemaWarnings = false;
            var logger = new TestLogger();
            var settings = new JsonSerializerSettings
            {
                Converters = new List<JsonConverter> { new EnumJsonConverter(logger) },
                NullValueHandling = NullValueHandling.Include
            };

            JsonConvert.DeserializeObject<ClusterStatus>("\"SOME_NEW_VALUE\"", settings);

            Assert.AreEqual(0, logger.VerboseMessages.Count);
            Assert.AreEqual(1, logger.WarningMessages.Count);
        }

        // ── SchemaStrict mode ────────────────────────────────────────

        [Test]
        public void SchemaStrictThrowsOnUnknownValue()
        {
            RubrikSecurityCloud.Config.SchemaStrict = true;

            var ex = Assert.Throws<RscServerSchemaMismatchException>(() =>
                JsonConvert.DeserializeObject<ClusterStatus>(
                    "\"FUTURE_VALUE\"", _jsonSerializerSettings));

            StringAssert.Contains("FUTURE_VALUE", ex.Message);
        }

        [Test]
        public void SchemaStrictDoesNotThrowOnKnownValue()
        {
            RubrikSecurityCloud.Config.SchemaStrict = true;

            var result = JsonConvert.DeserializeObject<ClusterStatus>(
                "\"Connected\"", _jsonSerializerSettings);

            Assert.AreEqual(ClusterStatus.CONNECTED, result);
        }

        // ── Case-insensitive field name matching ─────────────────────

        [Test]
        public void CaseInsensitiveFieldNameMatch_Lowercase()
        {
            string json = "\"connected\"";
            var result = JsonConvert.DeserializeObject<ClusterStatus>(json, _jsonSerializerSettings);

            Assert.AreEqual(ClusterStatus.CONNECTED, result);
        }

        [Test]
        public void CaseInsensitiveFieldNameMatch_Uppercase()
        {
            string json = "\"CONNECTED\"";
            var result = JsonConvert.DeserializeObject<ClusterStatus>(json, _jsonSerializerSettings);

            Assert.AreEqual(ClusterStatus.CONNECTED, result);
        }

        [Test]
        public void CaseInsensitiveFieldNameMatch_MixedCase()
        {
            string json = "\"CoNnEcTeD\"";
            var result = JsonConvert.DeserializeObject<ClusterStatus>(json, _jsonSerializerSettings);

            Assert.AreEqual(ClusterStatus.CONNECTED, result);
        }

        // ── Edge cases: token types ──────────────────────────────────

        [Test]
        public void IntegerTokenFallsBackToUnknown()
        {
            // Server sends an integer instead of a string for an enum field
            string json = "42";
            var result = JsonConvert.DeserializeObject<ClusterStatus>(json, _jsonSerializerSettings);

            Assert.AreEqual(ClusterStatus.UNKNOWN, result);
        }

        [Test]
        public void EmptyStringFallsBackToUnknown()
        {
            string json = "\"\"";
            var result = JsonConvert.DeserializeObject<ClusterStatus>(json, _jsonSerializerSettings);

            Assert.AreEqual(ClusterStatus.UNKNOWN, result);
        }

        // ── Nullable enum with unknown value ─────────────────────────

        [Test]
        public void NullableEnumWithUnknownValue_ReturnsUnknown()
        {
            // Nullable enum property receiving an unrecognized value
            // should map to UNKNOWN, not null
            string json = "\"BRAND_NEW_FEATURE\"";
            var result = JsonConvert.DeserializeObject<ClusterStatus?>(json, _jsonSerializerSettings);

            Assert.IsNotNull(result);
            Assert.AreEqual(ClusterStatus.UNKNOWN, result.Value);
        }

        // ── Empty list ───────────────────────────────────────────────

        [Test]
        public void EmptyList()
        {
            string json = "[]";
            var result = JsonConvert.DeserializeObject<List<ClusterStatus>>(json, _jsonSerializerSettings);

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }

        // ── Enum without UNKNOWN field ───────────────────────────────

        [Test]
        public void EnumWithoutUnknownFieldThrowsClearException()
        {
            var ex = Assert.Throws<JsonSerializationException>(() =>
                JsonConvert.DeserializeObject<StatusNoUnknown>(
                    "\"SomeNewValue\"", _jsonSerializerSettings));

            StringAssert.Contains("does not have an 'UNKNOWN' value", ex.Message);
            StringAssert.Contains("StatusNoUnknown", ex.Message);
        }

        // ── Nested object with enum property ─────────────────────────

        [Test]
        public void NestedObjectWithUnknownEnumValue()
        {
            string json = "{\"Name\": \"cluster-1\", \"Status\": \"FUTURE_STATUS\"}";
            var settings = new JsonSerializerSettings
            {
                Converters = new List<JsonConverter> { new EnumJsonConverter() },
                NullValueHandling = NullValueHandling.Ignore
            };

            var result = JsonConvert.DeserializeObject<ClusterInfo>(json, settings);

            Assert.IsNotNull(result);
            Assert.AreEqual("cluster-1", result.Name);
            Assert.AreEqual(ClusterStatus.UNKNOWN, result.Status);
        }

        [Test]
        public void NestedObjectWithKnownEnumValue()
        {
            string json = "{\"Name\": \"cluster-2\", \"Status\": \"Connected\"}";
            var settings = new JsonSerializerSettings
            {
                Converters = new List<JsonConverter> { new EnumJsonConverter() },
                NullValueHandling = NullValueHandling.Ignore
            };

            var result = JsonConvert.DeserializeObject<ClusterInfo>(json, settings);

            Assert.IsNotNull(result);
            Assert.AreEqual("cluster-2", result.Name);
            Assert.AreEqual(ClusterStatus.CONNECTED, result.Status);
        }

        [Test]
        public void NestedObjectWithEnumListContainingUnknown()
        {
            string json = "{\"Name\": \"c1\", \"Status\": \"Connected\", " +
                "\"Tags\": [\"Connected\", \"NEW_TAG\", \"Disconnected\"]}";
            var settings = new JsonSerializerSettings
            {
                Converters = new List<JsonConverter> { new EnumJsonConverter() },
                NullValueHandling = NullValueHandling.Ignore
            };

            var result = JsonConvert.DeserializeObject<ClusterInfoWithTags>(json, settings);

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Tags.Count);
            Assert.AreEqual(ClusterStatus.CONNECTED, result.Tags[0]);
            Assert.AreEqual(ClusterStatus.UNKNOWN, result.Tags[1]);
            Assert.AreEqual(ClusterStatus.DISCONNECTED, result.Tags[2]);
        }

        // ── Null logger with unknown value (no crash) ────────────────

        [Test]
        public void NullLoggerDoesNotCrashOnUnknown()
        {
            // EnumJsonConverter with no logger — should silently fall back
            var settings = new JsonSerializerSettings
            {
                Converters = new List<JsonConverter> { new EnumJsonConverter(null) },
                NullValueHandling = NullValueHandling.Include
            };

            var result = JsonConvert.DeserializeObject<ClusterStatus>(
                "\"FUTURE_VALUE\"", settings);

            Assert.AreEqual(ClusterStatus.UNKNOWN, result);
        }
    }

    // ── Test helpers ─────────────────────────────────────────────────

    /// <summary>
    /// IRscLogger that captures messages by log level for assertions.
    /// </summary>
    internal class TestLogger : IRscLogger
    {
        public List<string> Messages { get; } = new List<string>();
        public List<string> VerboseMessages { get; } = new List<string>();
        public List<string> WarningMessages { get; } = new List<string>();

        public void Debug(string message, string memberName = "",
            string filePath = "", int lineNumber = 0)
        {
            Messages.Add(message);
        }

        public void Verbose(string message)
        {
            Messages.Add(message);
            VerboseMessages.Add(message);
        }

        public void Info(string message)
        {
            Messages.Add(message);
        }

        public void Warning(string message)
        {
            Messages.Add(message);
            WarningMessages.Add(message);
        }

        public void Error(string message)
        {
            Messages.Add(message);
        }

        public void Flush() { }
    }

    // ── Test enums and types ─────────────────────────────────────────

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

    /// <summary>
    /// Enum intentionally missing UNKNOWN — tests GetDefaultUnknownValue error path.
    /// </summary>
    public enum StatusNoUnknown
    {
        [EnumMember(Value = "Active")]
        ACTIVE,

        [EnumMember(Value = "Inactive")]
        INACTIVE
    }

    /// <summary>
    /// Simple DTO with an enum property for nested-object tests.
    /// </summary>
    public class ClusterInfo
    {
        public string Name { get; set; }
        public ClusterStatus Status { get; set; }
    }

    /// <summary>
    /// DTO with both a single enum and a list of enums.
    /// </summary>
    public class ClusterInfoWithTags
    {
        public string Name { get; set; }
        public ClusterStatus Status { get; set; }
        public List<ClusterStatus> Tags { get; set; }
    }
}
