// New-RscGqlMutationAddAwsIamUserBasedCloudAccount.cs
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
    /// Create new GraphQL Mutation addAwsIamUserBasedCloudAccount
    /// addAwsIamUserBasedCloudAccount(input: AddAwsIamUserBasedCloudAccountInput!): AddAwsIamUserBasedCloudAccountReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationAddAwsIamUserBasedCloudAccount")
    ]
    public class New_RscGqlMutationAddAwsIamUserBasedCloudAccount : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("addAwsIamUserBasedCloudAccount");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation addAwsIamUserBasedCloudAccount
        /// addAwsIamUserBasedCloudAccount(input: AddAwsIamUserBasedCloudAccountInput!): AddAwsIamUserBasedCloudAccountReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_addAwsIamUserBasedCloudAccount();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_addAwsIamUserBasedCloudAccount()
        {
            this._logger.name += " -addAwsIamUserBasedCloudAccount";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddAwsIamUserBasedCloudAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddAwsIamUserBasedCloudAccount",
                "($input: AddAwsIamUserBasedCloudAccountInput!)",
                "AddAwsIamUserBasedCloudAccountReply",
                Mutation.AddAwsIamUserBasedCloudAccount_ObjectFieldSpec,
                Mutation.AddAwsIamUserBasedCloudAccountFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# OPTIONAL
	accessKey = <System.String>
	# OPTIONAL
	secretKey = <System.String>
	# REQUIRED
	nativeId = <System.String>
	# REQUIRED
	cloudAccountName = <System.String>
	# OPTIONAL
	cloudType = <AwsCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
	# OPTIONAL
	awsRegions = @(
		<AwsCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudAccountRegion]) for enum values.
	)
	# OPTIONAL
	roleArn = <System.String>
	# OPTIONAL
	externalArtifactMap = @(
		@{
			# OPTIONAL
			externalArtifactKey = <AwsCloudExternalArtifact> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudExternalArtifact]) for enum values.
			# OPTIONAL
			externalArtifactValue = <System.String>
		}
	)
}"
            );
        }

    } // class New-RscGqlMutationAddAwsIamUserBasedCloudAccount
}