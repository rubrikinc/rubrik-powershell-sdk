// New-RscGqlQueryAwsCloudAccountWithFeatures.cs
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
    /// Create new GraphQL Query awsCloudAccountWithFeatures
    /// awsCloudAccountWithFeatures(cloudAccountId: UUID!, awsCloudAccountArg: AwsCloudAccountWithFeaturesInput!): AwsCloudAccountWithFeatures!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAwsCloudAccountWithFeatures")
    ]
    public class New_RscGqlQueryAwsCloudAccountWithFeatures : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("awsCloudAccountWithFeatures");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query awsCloudAccountWithFeatures
        /// awsCloudAccountWithFeatures(cloudAccountId: UUID!, awsCloudAccountArg: AwsCloudAccountWithFeaturesInput!): AwsCloudAccountWithFeatures!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_awsCloudAccountWithFeatures();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_awsCloudAccountWithFeatures()
        {
            this._logger.name += " -awsCloudAccountWithFeatures";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
                Tuple.Create("awsCloudAccountArg", "AwsCloudAccountWithFeaturesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsCloudAccountWithFeatures",
                "($cloudAccountId: UUID!,$awsCloudAccountArg: AwsCloudAccountWithFeaturesInput!)",
                "AwsCloudAccountWithFeatures",
                Query.AwsCloudAccountWithFeatures_ObjectFieldSpec,
                Query.AwsCloudAccountWithFeaturesFieldSpec,
                @"# REQUIRED
$inputs.Var.cloudAccountId = <System.String>
# REQUIRED
$inputs.Var.awsCloudAccountArg = @{
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
}"
            );
        }

    } // class New-RscGqlQueryAwsCloudAccountWithFeatures
}