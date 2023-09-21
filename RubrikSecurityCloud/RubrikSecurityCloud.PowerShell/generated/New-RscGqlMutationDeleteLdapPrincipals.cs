// New-RscGqlMutationDeleteLdapPrincipals.cs
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
    /// Create new GraphQL Mutation deleteLdapPrincipals
    /// deleteLdapPrincipals(principalIds: [String!]!): Boolean!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDeleteLdapPrincipals")
    ]
    public class New_RscGqlMutationDeleteLdapPrincipals : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("deleteLdapPrincipals");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation deleteLdapPrincipals
        /// deleteLdapPrincipals(principalIds: [String!]!): Boolean!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_deleteLdapPrincipals();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_deleteLdapPrincipals()
        {
            this._logger.name += " -deleteLdapPrincipals";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("principalIds", "[String!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteLdapPrincipals",
                "($principalIds: [String!]!)",
                "System.Boolean",
                Mutation.DeleteLdapPrincipals_ObjectFieldSpec,
                Mutation.DeleteLdapPrincipalsFieldSpec,
                @"# REQUIRED
$inputs.Var.principalIds = @(
	<System.String>
)"
            );
        }

    } // class New-RscGqlMutationDeleteLdapPrincipals
}