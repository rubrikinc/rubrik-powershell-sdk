// New-RscGqlQueryAwsCloudAccountListSubnets.cs
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
    /// Create new GraphQL Query awsCloudAccountListSubnets
    /// awsCloudAccountListSubnets(
    ///     cloudAccountUuid: UUID!
    ///     feature: CloudAccountFeature!
    ///     region: AwsRegion!
    ///     vpcID: String!
    ///   ): AwsCloudAccountListSubnetsResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAwsCloudAccountListSubnets")
    ]
    public class New_RscGqlQueryAwsCloudAccountListSubnets : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("awsCloudAccountListSubnets");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query awsCloudAccountListSubnets
        /// awsCloudAccountListSubnets(
        ///     cloudAccountUuid: UUID!
        ///     feature: CloudAccountFeature!
        ///     region: AwsRegion!
        ///     vpcID: String!
        ///   ): AwsCloudAccountListSubnetsResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_awsCloudAccountListSubnets();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_awsCloudAccountListSubnets()
        {
            this._logger.name += " -awsCloudAccountListSubnets";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountUuid", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("region", "AwsRegion!"),
                Tuple.Create("vpcID", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsCloudAccountListSubnets",
                "($cloudAccountUuid: UUID!,$feature: CloudAccountFeature!,$region: AwsRegion!,$vpcID: String!)",
                "AwsCloudAccountListSubnetsResponse",
                Query.AwsCloudAccountListSubnets_ObjectFieldSpec,
                Query.AwsCloudAccountListSubnetsFieldSpec,
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

    } // class New-RscGqlQueryAwsCloudAccountListSubnets
}