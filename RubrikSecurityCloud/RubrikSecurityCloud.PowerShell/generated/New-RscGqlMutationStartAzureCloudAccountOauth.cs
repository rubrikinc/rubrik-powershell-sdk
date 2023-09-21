// New-RscGqlMutationStartAzureCloudAccountOauth.cs
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
    /// Create new GraphQL Mutation startAzureCloudAccountOauth
    /// startAzureCloudAccountOauth(input: StartAzureCloudAccountOauthInput!): StartAzureCloudAccountOauthReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationStartAzureCloudAccountOauth")
    ]
    public class New_RscGqlMutationStartAzureCloudAccountOauth : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("startAzureCloudAccountOauth");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation startAzureCloudAccountOauth
        /// startAzureCloudAccountOauth(input: StartAzureCloudAccountOauthInput!): StartAzureCloudAccountOauthReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_startAzureCloudAccountOauth();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_startAzureCloudAccountOauth()
        {
            this._logger.name += " -startAzureCloudAccountOauth";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartAzureCloudAccountOauthInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartAzureCloudAccountOauth",
                "($input: StartAzureCloudAccountOauthInput!)",
                "StartAzureCloudAccountOauthReply",
                Mutation.StartAzureCloudAccountOauth_ObjectFieldSpec,
                Mutation.StartAzureCloudAccountOauthFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	tenantDomainName = <System.String>
	# OPTIONAL
	azureCloudType = <AzureCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
}"
            );
        }

    } // class New-RscGqlMutationStartAzureCloudAccountOauth
}