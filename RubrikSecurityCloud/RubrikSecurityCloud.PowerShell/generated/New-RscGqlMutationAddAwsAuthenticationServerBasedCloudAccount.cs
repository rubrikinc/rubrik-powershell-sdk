// New-RscGqlMutationAddAwsAuthenticationServerBasedCloudAccount.cs
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
    /// Create new GraphQL Mutation addAwsAuthenticationServerBasedCloudAccount
    /// addAwsAuthenticationServerBasedCloudAccount(input: AddAwsAuthenticationServerBasedCloudAccountInput!): AddAwsAuthenticationServerBasedCloudAccountReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationAddAwsAuthenticationServerBasedCloudAccount")
    ]
    public class New_RscGqlMutationAddAwsAuthenticationServerBasedCloudAccount : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("addAwsAuthenticationServerBasedCloudAccount");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation addAwsAuthenticationServerBasedCloudAccount
        /// addAwsAuthenticationServerBasedCloudAccount(input: AddAwsAuthenticationServerBasedCloudAccountInput!): AddAwsAuthenticationServerBasedCloudAccountReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_addAwsAuthenticationServerBasedCloudAccount();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_addAwsAuthenticationServerBasedCloudAccount()
        {
            this._logger.name += " -addAwsAuthenticationServerBasedCloudAccount";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddAwsAuthenticationServerBasedCloudAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddAwsAuthenticationServerBasedCloudAccount",
                "($input: AddAwsAuthenticationServerBasedCloudAccountInput!)",
                "AddAwsAuthenticationServerBasedCloudAccountReply",
                Mutation.AddAwsAuthenticationServerBasedCloudAccount_ObjectFieldSpec,
                Mutation.AddAwsAuthenticationServerBasedCloudAccountFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudType = <AwsCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
	# REQUIRED
	awsAccountName = <System.String>
	# OPTIONAL
	awsRegions = @(
		<AwsAuthServerBasedCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsAuthServerBasedCloudAccountRegion]) for enum values.
	)
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# OPTIONAL
	nativeId = <System.String>
	# OPTIONAL
	agencyName = <System.String>
	# OPTIONAL
	roleName = <System.String>
	# OPTIONAL
	authServerHostName = <System.String>
	# OPTIONAL
	authServerUserClientCertId = @{
		# REQUIRED
		id = <System.Int64>
	}
	# OPTIONAL
	authServerCaCertId = @{
		# REQUIRED
		id = <System.Int64>
	}
	# OPTIONAL
	awsCaCertId = @{
		# REQUIRED
		id = <System.Int64>
	}
}"
            );
        }

    } // class New-RscGqlMutationAddAwsAuthenticationServerBasedCloudAccount
}