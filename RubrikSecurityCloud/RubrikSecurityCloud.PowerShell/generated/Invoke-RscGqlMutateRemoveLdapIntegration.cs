// Invoke-RscGqlMutateRemoveLdapIntegration.cs
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
    /// Invoke GraphQL Mutation removeLdapIntegration
    /// removeLdapIntegration(id: UUID!): Boolean!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateRemoveLdapIntegration")
    ]
    public class Invoke_RscGqlMutateRemoveLdapIntegration : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("removeLdapIntegration");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation removeLdapIntegration
        /// removeLdapIntegration(id: UUID!): Boolean!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_removeLdapIntegration();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_removeLdapIntegration()
        {
            this._logger.name += " -removeLdapIntegration";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("id", "UUID!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRemoveLdapIntegration",
                "($id: UUID!)",
                "System.Boolean",
                Mutation.RemoveLdapIntegration_ObjectFieldSpec,
                Mutation.RemoveLdapIntegrationFieldSpec,
                @"# REQUIRED
$inputs.Var.id = <System.String>"
            );
        }

    } // class Invoke-RscGqlMutateRemoveLdapIntegration
}