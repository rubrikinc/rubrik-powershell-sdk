// New-RscQueryLdap.cs
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
    /// Queries for the 'Ldap' API domain.
    /// </summary>
    /// <description>
    /// New-RscQueryLdap is the cmdlet to work with operations in the {self.noun} API domain. It is a dynamic cmdlet that accepts any {self.noun} API operation as its first parameter:  {sc_names}.
    /// </description>
    /// <example>
    /// <code>New-RscQueryLdap -IntegrationList [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryLdap -PrincipalList [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryLdap -AuthorizedPrincipalList [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscQueryLdap",
        DefaultParameterSetName = "PrincipalList")
    ]
    public class New_RscQueryLdap : RscGqlPSCmdlet
    {
        
        /// <summary>
        /// IntegrationList parameter set
        ///
        /// [GraphQL: ldapIntegrationConnection]
        /// </summary>
        [Parameter(
            ParameterSetName = "IntegrationList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Browse LDAP integrations.
[GraphQL: ldapIntegrationConnection]",
            Position = 0
        )]
        public SwitchParameter IntegrationList { get; set; }

        
        /// <summary>
        /// PrincipalList parameter set
        ///
        /// [GraphQL: ldapPrincipalConnection]
        /// </summary>
        [Parameter(
            ParameterSetName = "PrincipalList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Search LDAP Principals.
[GraphQL: ldapPrincipalConnection]",
            Position = 0
        )]
        public SwitchParameter PrincipalList { get; set; }

        
        /// <summary>
        /// AuthorizedPrincipalList parameter set
        ///
        /// [GraphQL: ldapAuthorizedPrincipalConnection]
        /// </summary>
        [Parameter(
            ParameterSetName = "AuthorizedPrincipalList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Browse LDAP-authorized principals.
[GraphQL: ldapAuthorizedPrincipalConnection]",
            Position = 0
        )]
        public SwitchParameter AuthorizedPrincipalList { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(Op)
                {
                    case "IntegrationList":
                        this.ProcessRecord_IntegrationList();
                        break;
                    case "PrincipalList":
                        this.ProcessRecord_PrincipalList();
                        break;
                    case "AuthorizedPrincipalList":
                        this.ProcessRecord_AuthorizedPrincipalList();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }
#pragma warning restore 1591

        // This parameter set invokes a single graphql operation:
        // ldapIntegrationConnection.
        internal void ProcessRecord_IntegrationList()
        {
            this._logger.name += " -IntegrationList";
            // Create new graphql operation ldapIntegrationConnection
            InitQueryLdapIntegrationConnection();
        }

        // This parameter set invokes a single graphql operation:
        // ldapPrincipalConnection.
        internal void ProcessRecord_PrincipalList()
        {
            this._logger.name += " -PrincipalList";
            // Create new graphql operation ldapPrincipalConnection
            InitQueryLdapPrincipalConnection();
        }

        // This parameter set invokes a single graphql operation:
        // ldapAuthorizedPrincipalConnection.
        internal void ProcessRecord_AuthorizedPrincipalList()
        {
            this._logger.name += " -AuthorizedPrincipalList";
            // Create new graphql operation ldapAuthorizedPrincipalConnection
            InitQueryLdapAuthorizedPrincipalConnection();
        }


        // Create new GraphQL Query:
        // ldapIntegrationConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     sortBy: LdapIntegrationFieldEnum = Name
        //   ): LdapIntegrationConnection!
        internal void InitQueryLdapIntegrationConnection()
        {
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

        // Create new GraphQL Query:
        // ldapPrincipalConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     sortBy: LdapPrincipalFieldEnum = Name
        //     id: UUID!
        //     searchText: String!
        //   ): PrincipalConnection!
        internal void InitQueryLdapPrincipalConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "LdapPrincipalFieldEnum"),
                Tuple.Create("id", "UUID!"),
                Tuple.Create("searchText", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryLdapPrincipalConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: LdapPrincipalFieldEnum,$id: UUID!,$searchText: String!)",
                "PrincipalConnection",
                Query.LdapPrincipalConnection_ObjectFieldSpec,
                Query.LdapPrincipalConnectionFieldSpec,
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
$inputs.Var.sortBy = <LdapPrincipalFieldEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LdapPrincipalFieldEnum]) for enum values.
# REQUIRED
$inputs.Var.id = <System.String>
# REQUIRED
$inputs.Var.searchText = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // ldapAuthorizedPrincipalConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     sortBy: LdapAuthorizedPrincipalFieldEnum = Name
        //     searchText: String!
        //     roleIds: [UUID!]
        //   ): AuthorizedPrincipalConnection!
        internal void InitQueryLdapAuthorizedPrincipalConnection()
        {
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


    } // class New_RscQueryLdap
}