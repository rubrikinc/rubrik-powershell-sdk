// Invoke-RscGqlMutateO365SaaSSetupKickoff.cs
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
    /// Invoke GraphQL Mutation o365SaaSSetupKickoff
    /// o365SaaSSetupKickoff: O365SaasSetupKickoffReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateO365SaaSSetupKickoff")
    ]
    public class Invoke_RscGqlMutateO365SaaSSetupKickoff : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("o365SaaSSetupKickoff");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation o365SaaSSetupKickoff
        /// o365SaaSSetupKickoff: O365SaasSetupKickoffReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_o365SaaSSetupKickoff();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_o365SaaSSetupKickoff()
        {
            this._logger.name += " -o365SaaSSetupKickoff";
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationO365SaaSsetupKickoff",
                "",
                "O365SaasSetupKickoffReply",
                Mutation.O365SaaSsetupKickoff_ObjectFieldSpec,
                Mutation.O365SaaSsetupKickoffFieldSpec,
                @""
            );
        }

    } // class Invoke-RscGqlMutateO365SaaSSetupKickoff
}