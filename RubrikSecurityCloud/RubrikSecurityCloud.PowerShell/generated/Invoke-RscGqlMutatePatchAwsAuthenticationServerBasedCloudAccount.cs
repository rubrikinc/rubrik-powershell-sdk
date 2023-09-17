// Invoke-RscGqlMutatePatchAwsAuthenticationServerBasedCloudAccount.cs
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
    /// Invoke GraphQL Mutation patchAwsAuthenticationServerBasedCloudAccount
    /// patchAwsAuthenticationServerBasedCloudAccount(input: PatchAwsAuthenticationServerBasedCloudAccountInput!): Boolean!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutatePatchAwsAuthenticationServerBasedCloudAccount")
    ]
    public class Invoke_RscGqlMutatePatchAwsAuthenticationServerBasedCloudAccount : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("patchAwsAuthenticationServerBasedCloudAccount");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation patchAwsAuthenticationServerBasedCloudAccount
        /// patchAwsAuthenticationServerBasedCloudAccount(input: PatchAwsAuthenticationServerBasedCloudAccountInput!): Boolean!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_patchAwsAuthenticationServerBasedCloudAccount();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_patchAwsAuthenticationServerBasedCloudAccount()
        {
            this._logger.name += " -patchAwsAuthenticationServerBasedCloudAccount";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PatchAwsAuthenticationServerBasedCloudAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPatchAwsAuthenticationServerBasedCloudAccount",
                "($input: PatchAwsAuthenticationServerBasedCloudAccountInput!)",
                "System.Boolean",
                Mutation.PatchAwsAuthenticationServerBasedCloudAccount_ObjectFieldSpec,
                Mutation.PatchAwsAuthenticationServerBasedCloudAccountFieldSpec,
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
			<AwsAuthServerBasedCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsAuthServerBasedCloudAccountRegion]) for enum values.
		)
	}
	# OPTIONAL
	roleName = @{
		# REQUIRED
		name = <System.String>
	}
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
}"
            );
        }

    } // class Invoke-RscGqlMutatePatchAwsAuthenticationServerBasedCloudAccount
}