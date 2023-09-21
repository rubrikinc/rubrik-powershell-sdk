// New-RscGqlMutationUpgradeAwsCloudAccountFeaturesWithoutCft.cs
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
    /// Create new GraphQL Mutation upgradeAwsCloudAccountFeaturesWithoutCft
    /// upgradeAwsCloudAccountFeaturesWithoutCft(input: UpgradeAwsCloudAccountFeaturesWithoutCftInput!): Boolean!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationUpgradeAwsCloudAccountFeaturesWithoutCft")
    ]
    public class New_RscGqlMutationUpgradeAwsCloudAccountFeaturesWithoutCft : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("upgradeAwsCloudAccountFeaturesWithoutCft");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation upgradeAwsCloudAccountFeaturesWithoutCft
        /// upgradeAwsCloudAccountFeaturesWithoutCft(input: UpgradeAwsCloudAccountFeaturesWithoutCftInput!): Boolean!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_upgradeAwsCloudAccountFeaturesWithoutCft();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_upgradeAwsCloudAccountFeaturesWithoutCft()
        {
            this._logger.name += " -upgradeAwsCloudAccountFeaturesWithoutCft";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpgradeAwsCloudAccountFeaturesWithoutCftInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpgradeAwsCloudAccountFeaturesWithoutCft",
                "($input: UpgradeAwsCloudAccountFeaturesWithoutCftInput!)",
                "System.Boolean",
                Mutation.UpgradeAwsCloudAccountFeaturesWithoutCft_ObjectFieldSpec,
                Mutation.UpgradeAwsCloudAccountFeaturesWithoutCftFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	awsCloudAccountId = <System.String>
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
}"
            );
        }

    } // class New-RscGqlMutationUpgradeAwsCloudAccountFeaturesWithoutCft
}