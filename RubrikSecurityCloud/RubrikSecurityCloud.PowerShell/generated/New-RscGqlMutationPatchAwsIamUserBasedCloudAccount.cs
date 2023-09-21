// New-RscGqlMutationPatchAwsIamUserBasedCloudAccount.cs
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
    /// Create new GraphQL Mutation patchAwsIamUserBasedCloudAccount
    /// patchAwsIamUserBasedCloudAccount(input: PatchAwsIamUserBasedCloudAccountInput!): Boolean!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationPatchAwsIamUserBasedCloudAccount")
    ]
    public class New_RscGqlMutationPatchAwsIamUserBasedCloudAccount : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("patchAwsIamUserBasedCloudAccount");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation patchAwsIamUserBasedCloudAccount
        /// patchAwsIamUserBasedCloudAccount(input: PatchAwsIamUserBasedCloudAccountInput!): Boolean!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_patchAwsIamUserBasedCloudAccount();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_patchAwsIamUserBasedCloudAccount()
        {
            this._logger.name += " -patchAwsIamUserBasedCloudAccount";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PatchAwsIamUserBasedCloudAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPatchAwsIamUserBasedCloudAccount",
                "($input: PatchAwsIamUserBasedCloudAccountInput!)",
                "System.Boolean",
                Mutation.PatchAwsIamUserBasedCloudAccount_ObjectFieldSpec,
                Mutation.PatchAwsIamUserBasedCloudAccountFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	awsCloudAccountId = <System.String>
	# REQUIRED
	feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	# OPTIONAL
	awsRegions = @{
		# REQUIRED
		regions = @(
			<AwsCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudAccountRegion]) for enum values.
		)
	}
	# OPTIONAL
	awsUserKeys = @{
		# REQUIRED
		accessKey = <System.String>
		# REQUIRED
		secretKey = <System.String>
	}
	# OPTIONAL
	awsRoleArn = @{
		# REQUIRED
		roleArn = <System.String>
	}
}"
            );
        }

    } // class New-RscGqlMutationPatchAwsIamUserBasedCloudAccount
}