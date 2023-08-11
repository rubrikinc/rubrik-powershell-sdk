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
            // Invoke graphql operation ldapIntegrationConnection
            InvokeQueryLdapIntegrationConnection();
        }

        // This parameter set invokes a single graphql operation:
        // ldapPrincipalConnection.
        internal void ProcessRecord_PrincipalList()
        {
            this._logger.name += " -PrincipalList";
            // Invoke graphql operation ldapPrincipalConnection
            InvokeQueryLdapPrincipalConnection();
        }

        // This parameter set invokes a single graphql operation:
        // ldapAuthorizedPrincipalConnection.
        internal void ProcessRecord_AuthorizedPrincipalList()
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
        internal void InvokeQueryLdapIntegrationConnection()
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
        internal void InvokeQueryLdapPrincipalConnection()
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
        internal void InvokeQueryLdapAuthorizedPrincipalConnection()
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