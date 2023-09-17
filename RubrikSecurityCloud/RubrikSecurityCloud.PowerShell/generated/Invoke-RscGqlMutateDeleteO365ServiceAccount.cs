// Invoke-RscGqlMutateDeleteO365ServiceAccount.cs
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
    /// Invoke GraphQL Mutation deleteO365ServiceAccount
    /// deleteO365ServiceAccount(orgId: UUID!): RequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateDeleteO365ServiceAccount")
    ]
    public class Invoke_RscGqlMutateDeleteO365ServiceAccount : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("deleteO365ServiceAccount");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation deleteO365ServiceAccount
        /// deleteO365ServiceAccount(orgId: UUID!): RequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_deleteO365ServiceAccount();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_deleteO365ServiceAccount()
        {
            this._logger.name += " -deleteO365ServiceAccount";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteO365ServiceAccount",
                "($orgId: UUID!)",
                "RequestStatus",
                Mutation.DeleteO365ServiceAccount_ObjectFieldSpec,
                Mutation.DeleteO365ServiceAccountFieldSpec,
                @"# REQUIRED
$inputs.Var.orgId = <System.String>"
            );
        }

    } // class Invoke-RscGqlMutateDeleteO365ServiceAccount
}