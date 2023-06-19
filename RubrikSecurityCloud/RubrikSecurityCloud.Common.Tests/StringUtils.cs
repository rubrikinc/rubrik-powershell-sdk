using System;
using System.Collections.Generic;
using NUnit.Framework;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Schema.Tests

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
                        $"Test case failed for input: {inputStr}. Expected: {expectedOutput}, but got: {result}."
                    );
                }
            }
        }
    }
}
