// New-RscGqlQueryLdapIntegrationConnection.cs
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
    /// Create new GraphQL Query ldapIntegrationConnection
    /// ldapIntegrationConnection(
    ///     first: Int
    ///     after: String
    ///     last: Int
    ///     before: String
    ///     sortOrder: SortOrder
    ///     sortBy: LdapIntegrationFieldEnum = Name
    ///   ): LdapIntegrationConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryLdapIntegrationConnection")
    ]
    public class New_RscGqlQueryLdapIntegrationConnection : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("ldapIntegrationConnection");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query ldapIntegrationConnection
        /// ldapIntegrationConnection(
        ///     first: Int
        ///     after: String
        ///     last: Int
        ///     before: String
        ///     sortOrder: SortOrder
        ///     sortBy: LdapIntegrationFieldEnum = Name
        ///   ): LdapIntegrationConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_ldapIntegrationConnection();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_ldapIntegrationConnection()
        {
            this._logger.name += " -ldapIntegrationConnection";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "LdapIntegrationFieldEnum"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryLdapIntegrationConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: LdapIntegrationFieldEnum)",
                "LdapIntegrationConnection",
                Query.LdapIntegrationConnection_ObjectFieldSpec,
                Query.LdapIntegrationConnectionFieldSpec,
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
$inputs.Var.sortBy = <LdapIntegrationFieldEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LdapIntegrationFieldEnum]) for enum values."
            );
        }

    } // class New-RscGqlQueryLdapIntegrationConnection
}