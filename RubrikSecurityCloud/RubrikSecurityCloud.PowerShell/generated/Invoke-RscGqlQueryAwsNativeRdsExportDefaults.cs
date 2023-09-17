// Invoke-RscGqlQueryAwsNativeRdsExportDefaults.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Invoke GraphQL Query awsNativeRdsExportDefaults
    /// awsNativeRdsExportDefaults(rdsInstanceRubrikId: UUID!, snapshotId: String, isPointInTime: Boolean!): RdsInstanceExportDefaults!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryAwsNativeRdsExportDefaults")
    ]
    public class Invoke_RscGqlQueryAwsNativeRdsExportDefaults : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("awsNativeRdsExportDefaults");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query awsNativeRdsExportDefaults
        /// awsNativeRdsExportDefaults(rdsInstanceRubrikId: UUID!, snapshotId: String, isPointInTime: Boolean!): RdsInstanceExportDefaults!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_awsNativeRdsExportDefaults();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_awsNativeRdsExportDefaults()
        {
            this._logger.name += " -awsNativeRdsExportDefaults";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("rdsInstanceRubrikId", "UUID!"),
                Tuple.Create("snapshotId", "String"),
                Tuple.Create("isPointInTime", "Boolean!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeRdsExportDefaults",
                "($rdsInstanceRubrikId: UUID!,$snapshotId: String,$isPointInTime: Boolean!)",
                "RdsInstanceExportDefaults",
                Query.AwsNativeRdsExportDefaults_ObjectFieldSpec,
                Query.AwsNativeRdsExportDefaultsFieldSpec,
                @"# REQUIRED
$inputs.Var.rdsInstanceRubrikId = <System.String>
# OPTIONAL
$inputs.Var.snapshotId = <System.String>
# REQUIRED
$inputs.Var.isPointInTime = <System.Boolean>"
            );
        }

    } // class Invoke-RscGqlQueryAwsNativeRdsExportDefaults
}