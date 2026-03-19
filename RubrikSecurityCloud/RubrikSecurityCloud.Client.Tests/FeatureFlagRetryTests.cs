using GraphQL;
using NUnit.Framework;
using RubrikSecurityCloud.NetSDK.Client;
using System.Collections.Generic;

namespace RubrikSecurityCloud.Client.Tests
{
    [TestFixture]
    public class FeatureFlagRetryTests
    {
        [SetUp]
        public void Setup()
        {
            // Reset FieldsToSkip to defaults before each test
            Config.FieldsToSkip = new HashSet<string>(
                System.StringComparer.OrdinalIgnoreCase)
            {
                "CdmPendingObjectPauseAssignment",
                "RscPendingObjectPauseAssignment"
            };
        }

        // ── Helper to create GraphQLError ──────────────────────────

        private static GraphQLError MakeError(
            string message,
            object code = null,
            object[] path = null)
        {
            var error = new GraphQLError { Message = message };
            if (code != null)
            {
                var map = new Map { { "code", code } };
                error.Extensions = map;
            }
            if (path != null)
            {
                error.Path = new ErrorPath(path);
            }
            return error;
        }

        // ── IsFeatureFlagError ──────────────────────────────────────

        [Test]
        public void IsFeatureFlagError_IntCode403()
        {
            var error = MakeError("forbidden", code: 403);
            Assert.IsTrue(RscGraphQLClient.IsFeatureFlagError(error));
        }

        [Test]
        public void IsFeatureFlagError_StringCode403()
        {
            var error = MakeError("forbidden", code: "403");
            Assert.IsTrue(RscGraphQLClient.IsFeatureFlagError(error));
        }

        [Test]
        public void IsFeatureFlagError_Code500_ReturnsFalse()
        {
            var error = MakeError("server error", code: 500);
            Assert.IsFalse(RscGraphQLClient.IsFeatureFlagError(error));
        }

        [Test]
        public void IsFeatureFlagError_NoExtensions_ReturnsFalse()
        {
            var error = new GraphQLError { Message = "some error" };
            Assert.IsFalse(RscGraphQLClient.IsFeatureFlagError(error));
        }

        [Test]
        public void IsFeatureFlagError_NullError_ReturnsFalse()
        {
            Assert.IsFalse(RscGraphQLClient.IsFeatureFlagError(null));
        }

        // ── ClassifyErrors ──────────────────────────────────────────

        [Test]
        public void ClassifyErrors_AllFeatureFlag()
        {
            var errors = new[]
            {
                MakeError("ff1", code: 403),
                MakeError("ff2", code: "403"),
            };

            RscGraphQLClient.ClassifyErrors(
                errors,
                out var featureFlagErrors,
                out var otherErrors);

            Assert.AreEqual(2, featureFlagErrors.Count);
            Assert.AreEqual(0, otherErrors.Count);
        }

        [Test]
        public void ClassifyErrors_MixedErrors()
        {
            var errors = new[]
            {
                MakeError("ff1", code: 403),
                MakeError("real error", code: 500),
            };

            RscGraphQLClient.ClassifyErrors(
                errors,
                out var featureFlagErrors,
                out var otherErrors);

            Assert.AreEqual(1, featureFlagErrors.Count);
            Assert.AreEqual(1, otherErrors.Count);
        }

        [Test]
        public void ClassifyErrors_NoErrors()
        {
            RscGraphQLClient.ClassifyErrors(
                null,
                out var featureFlagErrors,
                out var otherErrors);

            Assert.AreEqual(0, featureFlagErrors.Count);
            Assert.AreEqual(0, otherErrors.Count);
        }

        // ── ExtractFieldNamesFromErrors ─────────────────────────────

        [Test]
        public void ExtractFieldNames_SimpleLeafPath()
        {
            var errors = new List<GraphQLError>
            {
                MakeError("forbidden", code: 403,
                    path: new object[] {
                        "mssqlDatabaseLiveMounts", "nodes", "0",
                        "sourceDatabase", "cdmPendingObjectPauseAssignment"
                    })
            };

            var fields = RscGraphQLClient.ExtractFieldNamesFromErrors(errors);

            Assert.AreEqual(1, fields.Count);
            Assert.IsTrue(fields.Contains("cdmPendingObjectPauseAssignment"));
        }

        [Test]
        public void ExtractFieldNames_PathEndingInNumericIndex()
        {
            var errors = new List<GraphQLError>
            {
                MakeError("forbidden", code: 403,
                    path: new object[] { "items", "someField", "3" })
            };

            var fields = RscGraphQLClient.ExtractFieldNamesFromErrors(errors);

            Assert.AreEqual(1, fields.Count);
            Assert.IsTrue(fields.Contains("someField"));
        }

        [Test]
        public void ExtractFieldNames_MultipleErrorsSameField()
        {
            var errors = new List<GraphQLError>
            {
                MakeError("ff1", code: 403,
                    path: new object[] { "a", "0", "flagged" }),
                MakeError("ff2", code: 403,
                    path: new object[] { "b", "1", "flagged" }),
            };

            var fields = RscGraphQLClient.ExtractFieldNamesFromErrors(errors);

            // Deduplicated
            Assert.AreEqual(1, fields.Count);
            Assert.IsTrue(fields.Contains("flagged"));
        }

        [Test]
        public void ExtractFieldNames_MultipleDifferentFields()
        {
            var errors = new List<GraphQLError>
            {
                MakeError("ff1", code: 403,
                    path: new object[] { "a", "fieldA" }),
                MakeError("ff2", code: 403,
                    path: new object[] { "b", "fieldB" }),
            };

            var fields = RscGraphQLClient.ExtractFieldNamesFromErrors(errors);

            Assert.AreEqual(2, fields.Count);
            Assert.IsTrue(fields.Contains("fieldA"));
            Assert.IsTrue(fields.Contains("fieldB"));
        }

        [Test]
        public void ExtractFieldNames_NullPath_Skipped()
        {
            var errors = new List<GraphQLError>
            {
                MakeError("ff1", code: 403, path: null)
            };

            var fields = RscGraphQLClient.ExtractFieldNamesFromErrors(errors);

            Assert.AreEqual(0, fields.Count);
        }

        // ── Config.AddFieldToSkip integration ───────────────────────

        [Test]
        public void AddFieldToSkip_AddsToSet()
        {
            Assert.IsFalse(Config.FieldsToSkip.Contains("newField"));

            Config.AddFieldToSkip("newField");

            Assert.IsTrue(Config.FieldsToSkip.Contains("newField"));
        }

        [Test]
        public void AddFieldToSkip_CaseInsensitive()
        {
            Config.AddFieldToSkip("MyField");

            Assert.IsTrue(Config.FieldsToSkip.Contains("myfield"));
            Assert.IsTrue(Config.FieldsToSkip.Contains("MYFIELD"));
        }

        [Test]
        public void AddFieldToSkip_NullOrEmpty_NoOp()
        {
            int countBefore = Config.FieldsToSkip.Count;

            Config.AddFieldToSkip(null);
            Config.AddFieldToSkip("");

            Assert.AreEqual(countBefore, Config.FieldsToSkip.Count);
        }
    }
}
