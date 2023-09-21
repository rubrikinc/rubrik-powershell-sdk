// New-RscGqlQueryO365ServiceAccount.cs
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
    /// Create new GraphQL Query o365ServiceAccount
    /// o365ServiceAccount(orgId: UUID!): O365ServiceAccountStatusResp!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryO365ServiceAccount")
    ]
    public class New_RscGqlQueryO365ServiceAccount : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("o365ServiceAccount");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query o365ServiceAccount
        /// o365ServiceAccount(orgId: UUID!): O365ServiceAccountStatusResp!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_o365ServiceAccount();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_o365ServiceAccount()
        {
            this._logger.name += " -o365ServiceAccount";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365ServiceAccount",
                "($orgId: UUID!)",
                "O365ServiceAccountStatusResp",
                Query.O365ServiceAccount_ObjectFieldSpec,
                Query.O365ServiceAccountFieldSpec,
                @"# REQUIRED
$inputs.Var.orgId = <System.String>"
            );
        }

    } // class New-RscGqlQueryO365ServiceAccount
}