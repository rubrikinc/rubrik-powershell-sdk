// New-RscGqlQueryLdapAuthorizedPrincipalConnection.cs
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
    /// Create new GraphQL Query ldapAuthorizedPrincipalConnection
    /// ldapAuthorizedPrincipalConnection(
    ///     first: Int
    ///     after: String
    ///     last: Int
    ///     before: String
    ///     sortOrder: SortOrder
    ///     sortBy: LdapAuthorizedPrincipalFieldEnum = Name
    ///     searchText: String!
    ///     roleIds: [UUID!]
    ///   ): AuthorizedPrincipalConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryLdapAuthorizedPrincipalConnection")
    ]
    public class New_RscGqlQueryLdapAuthorizedPrincipalConnection : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("ldapAuthorizedPrincipalConnection");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query ldapAuthorizedPrincipalConnection
        /// ldapAuthorizedPrincipalConnection(
        ///     first: Int
        ///     after: String
        ///     last: Int
        ///     before: String
        ///     sortOrder: SortOrder
        ///     sortBy: LdapAuthorizedPrincipalFieldEnum = Name
        ///     searchText: String!
        ///     roleIds: [UUID!]
        ///   ): AuthorizedPrincipalConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_ldapAuthorizedPrincipalConnection();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_ldapAuthorizedPrincipalConnection()
        {
            this._logger.name += " -ldapAuthorizedPrincipalConnection";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "LdapAuthorizedPrincipalFieldEnum"),
                Tuple.Create("searchText", "String!"),
                Tuple.Create("roleIds", "[UUID!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryLdapAuthorizedPrincipalConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: LdapAuthorizedPrincipalFieldEnum,$searchText: String!,$roleIds: [UUID!])",
                "AuthorizedPrincipalConnection",
                Query.LdapAuthorizedPrincipalConnection_ObjectFieldSpec,
                Query.LdapAuthorizedPrincipalConnectionFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.sortBy = <LdapAuthorizedPrincipalFieldEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LdapAuthorizedPrincipalFieldEnum]) for enum values.
# REQUIRED
$inputs.Var.searchText = <System.String>
# OPTIONAL
$inputs.Var.roleIds = @(
	<System.String>
)"
            );
        }

    } // class New-RscGqlQueryLdapAuthorizedPrincipalConnection
}