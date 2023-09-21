// New-RscGqlQueryAwsCloudAccountListVpcs.cs
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
    /// Create new GraphQL Query awsCloudAccountListVpcs
    /// awsCloudAccountListVpcs(cloudAccountUuid: UUID!, feature: CloudAccountFeature!, region: AwsRegion!): AwsCloudAccountListVpcResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAwsCloudAccountListVpcs")
    ]
    public class New_RscGqlQueryAwsCloudAccountListVpcs : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("awsCloudAccountListVpcs");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query awsCloudAccountListVpcs
        /// awsCloudAccountListVpcs(cloudAccountUuid: UUID!, feature: CloudAccountFeature!, region: AwsRegion!): AwsCloudAccountListVpcResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_awsCloudAccountListVpcs();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_awsCloudAccountListVpcs()
        {
            this._logger.name += " -awsCloudAccountListVpcs";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountUuid", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("region", "AwsRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsCloudAccountListVpcs",
                "($cloudAccountUuid: UUID!,$feature: CloudAccountFeature!,$region: AwsRegion!)",
                "AwsCloudAccountListVpcResponse",
                Query.AwsCloudAccountListVpcs_ObjectFieldSpec,
                Query.AwsCloudAccountListVpcsFieldSpec,
                @"# REQUIRED
$inputs.Var.cloudAccountUuid = <System.String>
# REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$inputs.Var.region = <AwsRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values."
            );
        }

    } // class New-RscGqlQueryAwsCloudAccountListVpcs
}