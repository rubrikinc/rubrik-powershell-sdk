// New-RscGqlMutationDeleteAzureCloudAccountWithoutOauth.cs
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
    /// Create new GraphQL Mutation deleteAzureCloudAccountWithoutOauth
    /// deleteAzureCloudAccountWithoutOauth(input: DeleteAzureCloudAccountWithoutOauthInput!): DeleteAzureCloudAccountWithoutOauthReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDeleteAzureCloudAccountWithoutOauth")
    ]
    public class New_RscGqlMutationDeleteAzureCloudAccountWithoutOauth : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("deleteAzureCloudAccountWithoutOauth");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation deleteAzureCloudAccountWithoutOauth
        /// deleteAzureCloudAccountWithoutOauth(input: DeleteAzureCloudAccountWithoutOauthInput!): DeleteAzureCloudAccountWithoutOauthReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_deleteAzureCloudAccountWithoutOauth();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_deleteAzureCloudAccountWithoutOauth()
        {
            this._logger.name += " -deleteAzureCloudAccountWithoutOauth";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAzureCloudAccountWithoutOauthInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteAzureCloudAccountWithoutOauth",
                "($input: DeleteAzureCloudAccountWithoutOauthInput!)",
                "DeleteAzureCloudAccountWithoutOauthReply",
                Mutation.DeleteAzureCloudAccountWithoutOauth_ObjectFieldSpec,
                Mutation.DeleteAzureCloudAccountWithoutOauthFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# REQUIRED
	azureSubscriptionRubrikIds = @(
		<System.String>
	)
}"
            );
        }

    } // class New-RscGqlMutationDeleteAzureCloudAccountWithoutOauth
}