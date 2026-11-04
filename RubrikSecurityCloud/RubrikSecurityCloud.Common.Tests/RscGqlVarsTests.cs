using System;
using NUnit.Framework;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;

namespace RubrikSecurityCloud.Tests
{
    [TestFixture]
    public class RscGqlVarsTests
    {
        private static RscGqlVars Make(string name, string gqlType)
        {
            return new RscGqlVars(
                null, new[] { Tuple.Create(name, gqlType) }, null, true);
        }

        private static string AsJson(RscGqlVars vars)
        {
            var set = new OperationVariableSet { Variables = vars.Finalize()! };
            return set.AsJson();
        }

        [Test]
        public void UnsetSubfieldArgRendersNull()
        {
            var vm = new VsphereVm { NewestSnapshot = new CdmSnapshot { Id = "x" } };

            string spec = vm.AsFieldSpec();

            Assert.That(spec, Does.Contain("beforeTime:null"));
            Assert.That(spec, Does.Not.Contain("{}"));
        }

        [Test]
        public void AssignedSubfieldArgIsSent()
        {
            var vars = Make("beforeTime", "DateTime");
            vars["beforeTime"] = new DateTime(2026, 11, 1, 0, 0, 0, DateTimeKind.Utc);

            Assert.That(vars.ToInlineArguments(),
                Is.EqualTo("beforeTime:\"2026-11-01T00:00:00+00:00\""));
        }

        [TestCase("String")]
        [TestCase("UUID")]
        [TestCase("ClusterTypeEnum")]
        [TestCase("[String!]")]
        [TestCase("SomeFilterInput")]
        public void UnsetOptionalVarIsOmitted(string gqlType)
        {
            Assert.That(AsJson(Make("arg", gqlType)), Is.EqualTo("{}"));
        }

        [Test]
        public void RequiredInputObjectKeepsFillablePlaceholder()
        {
            var vars = Make("input", "SomeInput!");
            ((VarDict)vars["input"]!)["id"] = "abc";

            Assert.That(AsJson(vars), Is.EqualTo("{\"input\":{\"id\":\"abc\"}}"));
        }

        [Test]
        public void UnsetRequiredInputObjectIsStillSentEmpty()
        {
            Assert.That(AsJson(Make("input", "SomeInput!")),
                Is.EqualTo("{\"input\":{}}"));
        }
    }
}
