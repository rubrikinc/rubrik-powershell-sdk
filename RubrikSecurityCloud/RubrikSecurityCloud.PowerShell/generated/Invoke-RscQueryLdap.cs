// Invoke-RscQueryLdap.cs
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
    [Cmdlet(
        "Invoke",
        "RscQueryLdap",
        DefaultParameterSetName = "PrincipalList")
    ]
    public class Invoke_RscQueryLdap : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // IntegrationList parameter set
        //
        // [GraphQL: ldapIntegrationConnection]
        //
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

        
        // -------------------------------------------------------------------
        // PrincipalList parameter set
        //
        // [GraphQL: ldapPrincipalConnection]
        //
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

        
        // -------------------------------------------------------------------
        // AuthorizedPrincipalList parameter set
        //
        // [GraphQL: ldapAuthorizedPrincipalConnection]
        //
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


        protected override void ProcessRecord()
        {
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

        // This parameter set invokes a single graphql operation:
        // ldapIntegrationConnection.
        protected void ProcessRecord_IntegrationList()
        {
            this._logger.name += " -IntegrationList";
            // Invoke graphql operation ldapIntegrationConnection
            InvokeQueryLdapIntegrationConnection();
        }

        // This parameter set invokes a single graphql operation:
        // ldapPrincipalConnection.
        protected void ProcessRecord_PrincipalList()
        {
            this._logger.name += " -PrincipalList";
            // Invoke graphql operation ldapPrincipalConnection
            InvokeQueryLdapPrincipalConnection();
        }

        // This parameter set invokes a single graphql operation:
        // ldapAuthorizedPrincipalConnection.
        protected void ProcessRecord_AuthorizedPrincipalList()
        {
            this._logger.name += " -AuthorizedPrincipalList";
            // Invoke graphql operation ldapAuthorizedPrincipalConnection
            InvokeQueryLdapAuthorizedPrincipalConnection();
        }


        // Invoke GraphQL Query:
        // ldapIntegrationConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     sortBy: LdapIntegrationFieldEnum = Name
        //   ): LdapIntegrationConnection!
        protected void InvokeQueryLdapIntegrationConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "LdapIntegrationFieldEnum"),
            };
            LdapIntegrationConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (LdapIntegrationConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (LdapIntegrationConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.LdapIntegrationConnection(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryLdapIntegrationConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: LdapIntegrationFieldEnum)",
                fieldSpecDoc,
                "LdapIntegrationConnection"
            );
        }

        // Invoke GraphQL Query:
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
        protected void InvokeQueryLdapPrincipalConnection()
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
            PrincipalConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (PrincipalConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (PrincipalConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.LdapPrincipalConnection(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryLdapPrincipalConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: LdapPrincipalFieldEnum,$id: UUID!,$searchText: String!)",
                fieldSpecDoc,
                "PrincipalConnection"
            );
        }

        // Invoke GraphQL Query:
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
        protected void InvokeQueryLdapAuthorizedPrincipalConnection()
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
            AuthorizedPrincipalConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AuthorizedPrincipalConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AuthorizedPrincipalConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.LdapAuthorizedPrincipalConnection(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryLdapAuthorizedPrincipalConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: LdapAuthorizedPrincipalFieldEnum,$searchText: String!,$roleIds: [UUID!])",
                fieldSpecDoc,
                "AuthorizedPrincipalConnection"
            );
        }


    } // class Invoke_RscQueryLdap
}