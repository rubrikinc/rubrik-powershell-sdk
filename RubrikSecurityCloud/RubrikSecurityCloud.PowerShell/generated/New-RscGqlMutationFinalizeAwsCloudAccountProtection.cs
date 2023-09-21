// New-RscGqlMutationFinalizeAwsCloudAccountProtection.cs
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
    /// Create new GraphQL Mutation finalizeAwsCloudAccountProtection
    /// finalizeAwsCloudAccountProtection(input: FinalizeAwsCloudAccountProtectionInput!): FinalizeAwsCloudAccountProtectionReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationFinalizeAwsCloudAccountProtection")
    ]
    public class New_RscGqlMutationFinalizeAwsCloudAccountProtection : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("finalizeAwsCloudAccountProtection");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation finalizeAwsCloudAccountProtection
        /// finalizeAwsCloudAccountProtection(input: FinalizeAwsCloudAccountProtectionInput!): FinalizeAwsCloudAccountProtectionReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_finalizeAwsCloudAccountProtection();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_finalizeAwsCloudAccountProtection()
        {
            this._logger.name += " -finalizeAwsCloudAccountProtection";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "FinalizeAwsCloudAccountProtectionInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationFinalizeAwsCloudAccountProtection",
                "($input: FinalizeAwsCloudAccountProtectionInput!)",
                "FinalizeAwsCloudAccountProtectionReply",
                Mutation.FinalizeAwsCloudAccountProtection_ObjectFieldSpec,
                Mutation.FinalizeAwsCloudAccountProtectionFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	action = <CloudAccountAction> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountAction]) for enum values.
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# OPTIONAL
	awsAdminAccount = @{
		# OPTIONAL
		id = <System.String>
		# OPTIONAL
		nativeId = <System.String>
		# OPTIONAL
		accountName = <System.String>
		# OPTIONAL
		seamlessFlowEnabled = <System.Boolean>
		# OPTIONAL
		cloudType = <AwsCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
	}
	# REQUIRED
	awsChildAccounts = @(
		@{
			# OPTIONAL
			id = <System.String>
			# OPTIONAL
			nativeId = <System.String>
			# OPTIONAL
			accountName = <System.String>
			# OPTIONAL
			seamlessFlowEnabled = <System.Boolean>
			# OPTIONAL
			cloudType = <AwsCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
		}
	)
	# OPTIONAL
	awsRegions = @(
		<AwsCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudAccountRegion]) for enum values.
	)
	# OPTIONAL
	stackName = <System.String>
	# OPTIONAL
	stackSetName = <System.String>
	# OPTIONAL
	externalId = <System.String>
	# OPTIONAL
	featureVersion = @(
		@{
			# REQUIRED
			feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
			# REQUIRED
			version = <System.Int32>
		}
	)
}"
            );
        }

    } // class New-RscGqlMutationFinalizeAwsCloudAccountProtection
}