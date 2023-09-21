// New-RscGqlMutationAzureOauthConsentKickoff.cs
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
    /// Create new GraphQL Mutation azureOauthConsentKickoff
    /// azureOauthConsentKickoff: AzureOauthConsentKickoffReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationAzureOauthConsentKickoff")
    ]
    public class New_RscGqlMutationAzureOauthConsentKickoff : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureOauthConsentKickoff");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation azureOauthConsentKickoff
        /// azureOauthConsentKickoff: AzureOauthConsentKickoffReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureOauthConsentKickoff();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureOauthConsentKickoff()
        {
            this._logger.name += " -azureOauthConsentKickoff";
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAzureOauthConsentKickoff",
                "",
                "AzureOauthConsentKickoffReply",
                Mutation.AzureOauthConsentKickoff_ObjectFieldSpec,
                Mutation.AzureOauthConsentKickoffFieldSpec,
                @""
            );
        }

    } // class New-RscGqlMutationAzureOauthConsentKickoff
}