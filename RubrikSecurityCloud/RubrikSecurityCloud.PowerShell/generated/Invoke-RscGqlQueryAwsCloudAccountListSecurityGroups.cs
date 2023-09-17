// Invoke-RscGqlQueryAwsCloudAccountListSecurityGroups.cs
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
    /// Invoke GraphQL Query awsCloudAccountListSecurityGroups
    /// awsCloudAccountListSecurityGroups(
    ///     cloudAccountUuid: UUID!
    ///     feature: CloudAccountFeature!
    ///     region: AwsRegion!
    ///     vpcID: String!
    ///   ): AwsCloudAccountListSecurityGroupsResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryAwsCloudAccountListSecurityGroups")
    ]
    public class Invoke_RscGqlQueryAwsCloudAccountListSecurityGroups : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("awsCloudAccountListSecurityGroups");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query awsCloudAccountListSecurityGroups
        /// awsCloudAccountListSecurityGroups(
        ///     cloudAccountUuid: UUID!
        ///     feature: CloudAccountFeature!
        ///     region: AwsRegion!
        ///     vpcID: String!
        ///   ): AwsCloudAccountListSecurityGroupsResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_awsCloudAccountListSecurityGroups();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_awsCloudAccountListSecurityGroups()
        {
            this._logger.name += " -awsCloudAccountListSecurityGroups";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountUuid", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("region", "AwsRegion!"),
                Tuple.Create("vpcID", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsCloudAccountListSecurityGroups",
                "($cloudAccountUuid: UUID!,$feature: CloudAccountFeature!,$region: AwsRegion!,$vpcID: String!)",
                "AwsCloudAccountListSecurityGroupsResponse",
                Query.AwsCloudAccountListSecurityGroups_ObjectFieldSpec,
                Query.AwsCloudAccountListSecurityGroupsFieldSpec,
                @"# REQUIRED
$inputs.Var.cloudAccountUuid = <System.String>
# REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$inputs.Var.region = <AwsRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
# REQUIRED
$inputs.Var.vpcID = <System.String>"
            );
        }

    } // class Invoke-RscGqlQueryAwsCloudAccountListSecurityGroups
}