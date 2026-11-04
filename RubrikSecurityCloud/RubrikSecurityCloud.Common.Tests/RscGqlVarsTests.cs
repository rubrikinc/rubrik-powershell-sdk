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
        public void UnsetSingleScalarSubfieldArgRendersNull()
        {
            var vm = new VsphereVm { NewestSnapshot = new CdmSnapshot { Id = "x" } };

            string spec = vm.AsFieldSpec();

            Assert.That(spec, Does.Contain("beforeTime:null"));
            Assert.That(spec, Does.Not.Contain("{}"));
        }

        [Test]
        public void AssignedSingleScalarSubfieldArgIsSent()
        {
            var vars = Make("beforeTime", "DateTime");
            vars["beforeTime"] = new DateTime(2026, 11, 1, 0, 0, 0, DateTimeKind.Utc);

            Assert.That(vars.ToInlineArguments(),
                Is.EqualTo("beforeTime:\"2026-11-01T00:00:00+00:00\""));
        }

        [Test]
        public void UnsetSingleOptionalScalarVarIsOmitted()
        {
            Assert.That(AsJson(Make("first", "Int")), Is.EqualTo("{}"));
            Assert.That(AsJson(Make("ids", "[String!]")), Is.EqualTo("{}"));
        }

        [Test]
        public void UnsetSingleRequiredScalarVarIsReportedMissing()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => Make("clusterUuid", "UUID!").Finalize());
            Assert.That(ex!.Message, Does.Contain("clusterUuid"));
        }

        [Test]
        public void UnsetSingleEnumVarIsOmitted()
        {
            Assert.That(AsJson(Make("sortOrder", "SortOrder")), Is.EqualTo("{}"));
        }

        [TestCase("BeginManagedVolumeSnapshotInput!")]
        [TestCase("TakeOnDemandPostgreSQLDbClusterSnapshotInput!")]
        [TestCase("CreateK8sVMExportJobInput!")]
        [TestCase("AppItemRestoreConfig!")]
        public void SingleInputObjectVarKeepsFillablePlaceholder(string gqlType)
        {
            var vars = Make("input", gqlType);
            ((VarDict)vars["input"]!)["id"] = "abc";

            Assert.That(AsJson(vars), Is.EqualTo("{\"input\":{\"id\":\"abc\"}}"));
        }
    }
}
