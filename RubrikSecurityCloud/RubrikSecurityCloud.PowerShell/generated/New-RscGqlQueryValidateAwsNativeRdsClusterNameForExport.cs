// New-RscGqlQueryValidateAwsNativeRdsClusterNameForExport.cs
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
    /// Create new GraphQL Query validateAwsNativeRdsClusterNameForExport
    /// validateAwsNativeRdsClusterNameForExport(awsAccountRubrikId: UUID!, region: AwsNativeRegion!, rdsClusterName: String!): ValidateAwsNativeRdsClusterNameForExportReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryValidateAwsNativeRdsClusterNameForExport")
    ]
    public class New_RscGqlQueryValidateAwsNativeRdsClusterNameForExport : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("validateAwsNativeRdsClusterNameForExport");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query validateAwsNativeRdsClusterNameForExport
        /// validateAwsNativeRdsClusterNameForExport(awsAccountRubrikId: UUID!, region: AwsNativeRegion!, rdsClusterName: String!): ValidateAwsNativeRdsClusterNameForExportReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_validateAwsNativeRdsClusterNameForExport();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_validateAwsNativeRdsClusterNameForExport()
        {
            this._logger.name += " -validateAwsNativeRdsClusterNameForExport";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("rdsClusterName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryValidateAwsNativeRdsClusterNameForExport",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$rdsClusterName: String!)",
                "ValidateAwsNativeRdsClusterNameForExportReply",
                Query.ValidateAwsNativeRdsClusterNameForExport_ObjectFieldSpec,
                Query.ValidateAwsNativeRdsClusterNameForExportFieldSpec,
                @"# REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$inputs.Var.rdsClusterName = <System.String>"
            );
        }

    } // class New-RscGqlQueryValidateAwsNativeRdsClusterNameForExport
}