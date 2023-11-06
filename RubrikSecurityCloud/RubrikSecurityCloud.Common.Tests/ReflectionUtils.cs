using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Tests
{
    public class TypeA
    {
        public string Foo { get; set; } = "foo";
        public string Bar { get; set; } = "bar";
    }

    public class TypeB
    {
        public TypeA A { get; set; } = new TypeA();
        public string Baz { get; set; } = "baz";
    }

    public interface InfName
    {
        string Name { get; set; }
    }

    public class NameFoo : InfName
    {
        public string Name { get; set; } = "name";
        public string Foo { get; set; } = "foo";
    }

    public class NameBar : InfName
    {
        public string Name { get; set; } = "name";
        public string Bar { get; set; } = "bar";
    }

    public class TypeC
    {
        public string Baz { get; set; } = "baz";
        public InfName Inf { get; set; } = new NameFoo();
        public TypeB B { get; set; } = new TypeB();
    }


    [TestFixture]
    public class ReflectionUtilsTests
    {
        [Test]
        public void TestFlattenField()
        {
            var testCases = new Dictionary<Type, string>() {
            {
                typeof(TypeA),
                "Foo\nBar"
            },
            {
                typeof(TypeB),
                "A.Foo\nA.Bar\nBaz"
            },
            {
                typeof(TypeC),
                "Baz\nB.A.Foo\nB.A.Bar\nB.Baz\nInf"
            },
            };
            foreach (var testCase in testCases)
            {
                string inputType = testCase.Key.ToString();
                if ( ReflectionUtils.GetType(inputType) != testCase.Key)
                {
                    throw new Exception(
                        $"Test case failed for input: {inputType}.\n" +
                        $"Expected: {testCase.Key}, but got: {ReflectionUtils.GetType(inputType)}."
                    );
                }
                
                List<string> expectedOutput = testCase.Value.Split("\n").ToList();
                expectedOutput.Sort();
                List<string> result = ReflectionUtils.FlattenField(inputType);
                result.Sort();
                if (!expectedOutput.SequenceEqual(result))
                {
                    string expectedStr = string.Join(", ", expectedOutput);
                    string resultStr = string.Join(", ", result);
                    throw new Exception(
                        $"Test case failed for input: {inputType}.\n" +
                        $"Expected: [{expectedStr}], but got: [{resultStr}]."
                    );
                }
            }
        }
    }
}