using System;
using System.Collections.Generic;
using NUnit.Framework;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Tests
{
    [TestFixture]
    public class StripFieldsTests
    {
        // ── Leaf field stripping ────────────────────────────────────

        [Test]
        public void StripLeafField()
        {
            string query =
                "query Q {\n" +
                "  a {\n" +
                "    id\n" +
                "    flaggedField\n" +
                "    name\n" +
                "  }\n" +
                "}\n";

            var fields = new HashSet<string> { "flaggedField" };
            string result = StringUtils.StripFieldsFromQuery(query, fields);

            Assert.That(result, Does.Not.Contain("flaggedField"));
            Assert.That(result, Does.Contain("id"));
            Assert.That(result, Does.Contain("name"));
        }

        // ── Nested object field stripping ───────────────────────────

        [Test]
        public void StripNestedField()
        {
            string query =
                "query Q {\n" +
                "  nodes {\n" +
                "    name\n" +
                "    cdmPending {\n" +
                "      status\n" +
                "      reason\n" +
                "    }\n" +
                "    id\n" +
                "  }\n" +
                "}\n";

            var fields = new HashSet<string> { "cdmPending" };
            string result = StringUtils.StripFieldsFromQuery(query, fields);

            Assert.That(result, Does.Not.Contain("cdmPending"));
            Assert.That(result, Does.Not.Contain("status"));
            Assert.That(result, Does.Not.Contain("reason"));
            Assert.That(result, Does.Contain("name"));
            Assert.That(result, Does.Contain("id"));
        }

        // ── Field inside inline fragment ────────────────────────────

        [Test]
        public void StripFieldInsideInlineFragment()
        {
            string query =
                "query Q {\n" +
                "  data {\n" +
                "    ... on VsphereVm {\n" +
                "      name\n" +
                "      flaggedField\n" +
                "      id\n" +
                "    }\n" +
                "  }\n" +
                "}\n";

            var fields = new HashSet<string> { "flaggedField" };
            string result = StringUtils.StripFieldsFromQuery(query, fields);

            Assert.That(result, Does.Not.Contain("flaggedField"));
            Assert.That(result, Does.Contain("name"));
            Assert.That(result, Does.Contain("id"));
            Assert.That(result, Does.Contain("... on VsphereVm"));
        }

        // ── Multiple fields stripped at once ────────────────────────

        [Test]
        public void StripMultipleFields()
        {
            string query =
                "query Q {\n" +
                "  a\n" +
                "  fieldOne\n" +
                "  b\n" +
                "  fieldTwo {\n" +
                "    x\n" +
                "  }\n" +
                "  c\n" +
                "}\n";

            var fields = new HashSet<string> { "fieldOne", "fieldTwo" };
            string result = StringUtils.StripFieldsFromQuery(query, fields);

            Assert.That(result, Does.Not.Contain("fieldOne"));
            Assert.That(result, Does.Not.Contain("fieldTwo"));
            Assert.That(result, Does.Contain("a"));
            Assert.That(result, Does.Contain("b"));
            Assert.That(result, Does.Contain("c"));
        }

        // ── No-op when field not present ────────────────────────────

        [Test]
        public void NoOpWhenFieldNotPresent()
        {
            string query =
                "query Q {\n" +
                "  id\n" +
                "  name\n" +
                "}\n";

            var fields = new HashSet<string> { "nonExistentField" };
            string result = StringUtils.StripFieldsFromQuery(query, fields);

            Assert.AreEqual(query, result);
        }

        // ── Field name inside string literal is NOT stripped ────────

        [Test]
        public void FieldNameInStringLiteralNotStripped()
        {
            string query =
                "mutation M {\n" +
                "  createThing(name: \"flaggedField\") {\n" +
                "    id\n" +
                "  }\n" +
                "}\n";

            var fields = new HashSet<string> { "flaggedField" };
            string result = StringUtils.StripFieldsFromQuery(query, fields);

            // The string literal should be preserved
            Assert.That(result, Does.Contain("\"flaggedField\""));
            Assert.That(result, Does.Contain("id"));
        }

        // ── Field with __typename suffix ────────────────────────────

        [Test]
        public void StripFieldWithTypename()
        {
            // After InsertTypeNamesInGqlQuery, fields inside braces have __typename
            string query =
                "query Q {\n" +
                "  nodes {\n" +
                "    name\n" +
                "    cdmPending {\n" +
                "      status __typename }\n" +
                "    id\n" +
                "  __typename }\n" +
                "__typename }\n";

            var fields = new HashSet<string> { "cdmPending" };
            string result = StringUtils.StripFieldsFromQuery(query, fields);

            Assert.That(result, Does.Not.Contain("cdmPending"));
            Assert.That(result, Does.Not.Contain("status"));
            Assert.That(result, Does.Contain("name"));
            Assert.That(result, Does.Contain("id"));
            // The outer __typename entries should remain
            Assert.That(result, Does.Contain("__typename"));
        }

        // ── Case-insensitive matching ───────────────────────────────

        [Test]
        public void CaseInsensitiveFieldMatch()
        {
            string query =
                "query Q {\n" +
                "  CdmPendingObjectPauseAssignment\n" +
                "  name\n" +
                "}\n";

            // Field in the set is camelCase, query has PascalCase
            var fields = new HashSet<string> { "cdmPendingObjectPauseAssignment" };
            string result = StringUtils.StripFieldsFromQuery(query, fields);

            Assert.That(result, Does.Not.Contain("CdmPendingObjectPauseAssignment"));
            Assert.That(result, Does.Contain("name"));
        }

        // ── Empty/null inputs ───────────────────────────────────────

        [Test]
        public void NullQueryReturnsNull()
        {
            string result = StringUtils.StripFieldsFromQuery(
                null, new HashSet<string> { "x" });
            Assert.IsNull(result);
        }

        [Test]
        public void EmptyFieldSetReturnsQueryUnchanged()
        {
            string query = "query Q { id name }";
            string result = StringUtils.StripFieldsFromQuery(
                query, new HashSet<string>());
            Assert.AreEqual(query, result);
        }

        // ── ToCamelCase helper ──────────────────────────────────────

        [Test]
        public void ToCamelCase_PascalCase()
        {
            Assert.AreEqual(
                "cdmPendingObjectPauseAssignment",
                StringUtils.ToCamelCase("CdmPendingObjectPauseAssignment"));
        }

        [Test]
        public void ToCamelCase_AlreadyCamelCase()
        {
            Assert.AreEqual(
                "fieldName",
                StringUtils.ToCamelCase("fieldName"));
        }

        [Test]
        public void ToCamelCase_Acronym()
        {
            Assert.AreEqual("cdmFoo", StringUtils.ToCamelCase("CDMFoo"));
        }

        [Test]
        public void ToCamelCase_AllCaps()
        {
            Assert.AreEqual("cpu", StringUtils.ToCamelCase("CPU"));
        }
    }
}
