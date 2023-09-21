// New-RscGqlMutationSetO365ServiceAccount.cs
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
    /// Create new GraphQL Mutation setO365ServiceAccount
    /// setO365ServiceAccount(username: String!, appPassword: String!, orgId: UUID!): RequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationSetO365ServiceAccount")
    ]
    public class New_RscGqlMutationSetO365ServiceAccount : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("setO365ServiceAccount");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation setO365ServiceAccount
        /// setO365ServiceAccount(username: String!, appPassword: String!, orgId: UUID!): RequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_setO365ServiceAccount();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_setO365ServiceAccount()
        {
            this._logger.name += " -setO365ServiceAccount";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("username", "String!"),
                Tuple.Create("appPassword", "String!"),
                Tuple.Create("orgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetO365ServiceAccount",
                "($username: String!,$appPassword: String!,$orgId: UUID!)",
                "RequestStatus",
                Mutation.SetO365ServiceAccount_ObjectFieldSpec,
                Mutation.SetO365ServiceAccountFieldSpec,
                @"# REQUIRED
$inputs.Var.username = <System.String>
# REQUIRED
$inputs.Var.appPassword = <System.String>
# REQUIRED
$inputs.Var.orgId = <System.String>"
            );
        }

    } // class New-RscGqlMutationSetO365ServiceAccount
}