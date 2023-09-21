// New-RscGqlMutationValidateAndCreateAwsCloudAccount.cs
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
    /// Create new GraphQL Mutation validateAndCreateAwsCloudAccount
    /// validateAndCreateAwsCloudAccount(input: ValidateAndCreateAwsCloudAccountInput!): ValidateAndCreateAwsCloudAccountReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationValidateAndCreateAwsCloudAccount")
    ]
    public class New_RscGqlMutationValidateAndCreateAwsCloudAccount : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("validateAndCreateAwsCloudAccount");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation validateAndCreateAwsCloudAccount
        /// validateAndCreateAwsCloudAccount(input: ValidateAndCreateAwsCloudAccountInput!): ValidateAndCreateAwsCloudAccountReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_validateAndCreateAwsCloudAccount();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_validateAndCreateAwsCloudAccount()
        {
            this._logger.name += " -validateAndCreateAwsCloudAccount";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ValidateAndCreateAwsCloudAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationValidateAndCreateAwsCloudAccount",
                "($input: ValidateAndCreateAwsCloudAccountInput!)",
                "ValidateAndCreateAwsCloudAccountReply",
                Mutation.ValidateAndCreateAwsCloudAccount_ObjectFieldSpec,
                Mutation.ValidateAndCreateAwsCloudAccountFieldSpec,
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
	awsRoleCustomization = @{
		# OPTIONAL
		crossAccountRoleName = <System.String>
		# OPTIONAL
		crossAccountRolePath = <System.String>
		# OPTIONAL
		masterRoleName = <System.String>
		# OPTIONAL
		masterRolePath = <System.String>
		# OPTIONAL
		workerRoleName = <System.String>
		# OPTIONAL
		workerRolePath = <System.String>
		# OPTIONAL
		instanceProfileName = <System.String>
		# OPTIONAL
		instanceProfilePath = <System.String>
		# OPTIONAL
		ec2RecoveryRolePath = <System.String>
	}
}"
            );
        }

    } // class New-RscGqlMutationValidateAndCreateAwsCloudAccount
}