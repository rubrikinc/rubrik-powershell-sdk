using System;
using System.Collections.Generic;
using NUnit.Framework;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Tests

{
    [TestFixture]
    public class StringUtilsTests
    {
        [Test]
        public void TestStrictPascalCase()
        {
            var testCases = new Dictionary<string, string>()
            {
                { "foo", "Foo" },
                { "foo_BAR", "FooBar" },
                { "fooBar", "FooBar" },
                { "fooBAR", "FooBar" },
                { "BAR", "Bar" },
                { "BA", "Ba" },
                { "aBA", "Aba" },
                { "fooBARBaz", "FooBarBaz" },
                { "fooBARBazQuX", "FooBarBazQuX" },
                { "foo_bar", "FooBar" },
                { "A__B", "AB" },
                { "_A_B", "AB" },
                { "_A__B", "AB" },
                { "__A_B", "AB" },
                { "__A_B_", "AB" },
                { "CPUCount", "CpuCount" },
                { "CPU", "Cpu" },
                { "VSphereVMs", "VsphereVms" },
                { "vCenterPreAddInfo", "VcenterPreAddInfo" },
            };
            foreach (var testCase in testCases)
            {
                var inputStr = testCase.Key;
                var expectedOutput = testCase.Value;
                var result = StringUtils.StrictPascalCase(inputStr);
                if (result != expectedOutput)
                {
                    throw new Exception(
                        "Test case failed for input: " + inputStr +
                        $". Expected: {expectedOutput}, but got: {result}."
                    );
                }
            }
        }

        [Test]
        public void TestInsertTypeNamesInGqlQuery()
        {
            var testCases = new Dictionary<string, string>() {
                { "query {id}", "query {id}"},
                { "query {id  \n}\n   \t", "query {id  \n}\n   \t"},
                { "query __typename{id}", "query {id}"},
                { "query {id}__typename", "query {id}"},
                { "query {id __typename}", "query {id }"},
                { "query {a{id}}", "query {a{id __typename }}"},
                { "{a{b{c}}}", "{a{b{c __typename } __typename }}"},
                {
                    "op(filter: [{field: NAME, texts: $instance}])",
                    "op(filter: [{field: NAME, texts: $instance}])"
                },
                {
                    @"mutation { createPerson(person: {
                            name: ""John"",
                            address: {
                                zipCode: ""10001""
                            }
                        }) {
                            name address { zipCode }
                        }
                    }",
                    @"mutation { createPerson(person: {
                            name: ""John"",
                            address: {
                                zipCode: ""10001""
                            }
                        }) {
                            name address { zipCode  __typename }
                         __typename }
                    }"
                },
                {
                    @"op(a: "") { x }"") { y }",
                    @"op(a: "") { x }"") { y }"
                },
                {
                    @"mutation { createPerson(person: {
                        name: ""John (Doe)"",
                        hobbies: ""Reading, programming, and sleeping.""
                    }) { id name } }",
                    @"mutation { createPerson(person: {
                        name: ""John (Doe)"",
                        hobbies: ""Reading, programming, and sleeping.""
                    }) { id name  __typename } }"
                },
                {
                    @"query { persons(filter: {
                        name: ""John \""The Duke\"" Doe""}) { id name } }",
                    @"query { persons(filter: {
                        name: ""John \""The Duke\"" Doe""}) { id name  __typename } }"
                },
                // A mutation has exactly one top-level field (Quorum Authorization)
                {
                    "mutation M($input: AssignSlaInput!)\n{\n  assignSla\n  (\n  input: $input\n  )\n  {\n  success\n  }\n}\n",
                    "mutation M($input: AssignSlaInput!)\n{\n  assignSla\n  (\n  input: $input\n  )\n  {\n  success\n   __typename }\n}\n"
                },
                {
                    "mutation M($input: SubmitTprRequestInput!) { submitTprRequest(input: $input) }",
                    "mutation M($input: SubmitTprRequestInput!) { submitTprRequest(input: $input) }"
                },
                // Top-level fragment definitions keep __typename
                {
                    "query { a { ...F } } fragment F on A { id }",
                    "query { a { ...F  __typename } } fragment F on A { id  __typename }"
                },
            };

            foreach (var testCase in testCases)
            {
                var query = testCase.Key;
                var expected = testCase.Value;
                var result = StringUtils.InsertTypeNamesInGqlQuery(query);
                if (result != expected)
                {
                    throw new Exception(
                        "Test case failed for input: " + query +
                        $". Expected: {expected}, but got: {result}."
                    );
                }
            }
        }
    }
}
