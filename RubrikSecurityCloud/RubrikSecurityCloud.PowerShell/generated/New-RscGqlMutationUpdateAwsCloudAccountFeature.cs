// New-RscGqlMutationUpdateAwsCloudAccountFeature.cs
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
    /// Create new GraphQL Mutation updateAwsCloudAccountFeature
    /// updateAwsCloudAccountFeature(input: UpdateAwsCloudAccountFeatureInput!): UpdateAwsCloudAccountFeatureReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationUpdateAwsCloudAccountFeature")
    ]
    public class New_RscGqlMutationUpdateAwsCloudAccountFeature : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("updateAwsCloudAccountFeature");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation updateAwsCloudAccountFeature
        /// updateAwsCloudAccountFeature(input: UpdateAwsCloudAccountFeatureInput!): UpdateAwsCloudAccountFeatureReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_updateAwsCloudAccountFeature();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_updateAwsCloudAccountFeature()
        {
            this._logger.name += " -updateAwsCloudAccountFeature";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAwsCloudAccountFeatureInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAwsCloudAccountFeature",
                "($input: UpdateAwsCloudAccountFeatureInput!)",
                "UpdateAwsCloudAccountFeatureReply",
                Mutation.UpdateAwsCloudAccountFeature_ObjectFieldSpec,
                Mutation.UpdateAwsCloudAccountFeatureFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	action = <CloudAccountAction> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountAction]) for enum values.
	# REQUIRED
	feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	# OPTIONAL
	awsRegions = @(
		<AwsCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudAccountRegion]) for enum values.
	)
	# OPTIONAL
	roleArn = <System.String>
	# OPTIONAL
	stackArn = <System.String>
	# OPTIONAL
	awsAccountName = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationUpdateAwsCloudAccountFeature
}