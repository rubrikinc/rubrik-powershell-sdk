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
        DefaultParameterSetName = "Principalconnection")
    ]
    public class Invoke_RscQueryLdap : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // Integrationconnection parameter set
        //
        // [GraphQL: ldapIntegrationConnection]
        //
        [Parameter(
            ParameterSetName = "Integrationconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Browse LDAP integrations.
[GraphQL: ldapIntegrationConnection]",
            Position = 0
        )]
        public SwitchParameter Integrationconnection { get; set; }

        [Parameter(
            ParameterSetName = "Integrationconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the first n elements from the list.
GraphQL argument first: Int"
        )]
        public System.Int32? First { get; set; }
        [Parameter(
            ParameterSetName = "Integrationconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the elements in the list that come after the specified cursor.
GraphQL argument after: String"
        )]
        public System.String? After { get; set; }
        [Parameter(
            ParameterSetName = "Integrationconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the last n elements from the list.
GraphQL argument last: Int"
        )]
        public System.Int32? Last { get; set; }
        [Parameter(
            ParameterSetName = "Integrationconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the elements in the list that come before the specified cursor.
GraphQL argument before: String"
        )]
        public System.String? Before { get; set; }
        [Parameter(
            ParameterSetName = "Integrationconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Sorting order for the results.
GraphQL argument sortOrder: SortOrder"
        )]
        public SortOrder? SortOrder { get; set; }
        [Parameter(
            ParameterSetName = "Integrationconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
GraphQL argument sortBy: LdapIntegrationFieldEnum"
        )]
        public LdapIntegrationFieldEnum? SortBy { get; set; }
        
        // -------------------------------------------------------------------
        // Principalconnection parameter set
        //
        // [GraphQL: ldapPrincipalConnection]
        //
        [Parameter(
            ParameterSetName = "Principalconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Search LDAP Principals.
[GraphQL: ldapPrincipalConnection]",
            Position = 0
        )]
        public SwitchParameter Principalconnection { get; set; }

        [Parameter(
            ParameterSetName = "Principalconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"ID for your LDAP integration.
GraphQL argument id: UUID!"
        )]
        public System.String? Id { get; set; }
        [Parameter(
            ParameterSetName = "Principalconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Search Text for LDAP principal.
GraphQL argument searchText: String!"
        )]
        public System.String? SearchText { get; set; }
        
        // -------------------------------------------------------------------
        // Authorizedprincipalconnection parameter set
        //
        // [GraphQL: ldapAuthorizedPrincipalConnection]
        //
        [Parameter(
            ParameterSetName = "Authorizedprincipalconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Browse LDAP-authorized principals.
[GraphQL: ldapAuthorizedPrincipalConnection]",
            Position = 0
        )]
        public SwitchParameter Authorizedprincipalconnection { get; set; }

        [Parameter(
            ParameterSetName = "Authorizedprincipalconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Assigned role IDs for LDAP principal.
GraphQL argument roleIds: [UUID!]"
        )]
        public List<System.String>? RoleIds { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "Integrationconnection":
                        this.ProcessRecord_Integrationconnection();
                        break;
                    case "Principalconnection":
                        this.ProcessRecord_Principalconnection();
                        break;
                    case "Authorizedprincipalconnection":
                        this.ProcessRecord_Authorizedprincipalconnection();
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
        protected void ProcessRecord_Integrationconnection()
        {
            this._logger.name += " -Integrationconnection";
            // Invoke graphql operation ldapIntegrationConnection
            InvokeQueryLdapIntegrationConnection();
        }

        // This parameter set invokes a single graphql operation:
        // ldapPrincipalConnection.
        protected void ProcessRecord_Principalconnection()
        {
            this._logger.name += " -Principalconnection";
            // Invoke graphql operation ldapPrincipalConnection
            InvokeQueryLdapPrincipalConnection();
        }

        // This parameter set invokes a single graphql operation:
        // ldapAuthorizedPrincipalConnection.
        protected void ProcessRecord_Authorizedprincipalconnection()
        {
            this._logger.name += " -Authorizedprincipalconnection";
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
            LdapIntegrationConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (LdapIntegrationConnection)psObject.BaseObject;
                } else {
                    fields = (LdapIntegrationConnection)this.Field;
                }
            }
            string document = Query.LdapIntegrationConnection(ref fields);
            this._input.Initialize(argDefs, fields, "Query.LdapIntegrationConnection");
            var parameters = "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: LdapIntegrationFieldEnum)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryLdapIntegrationConnection" + parameters + "{" + document + "}",
                OperationName = "QueryLdapIntegrationConnection",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "LdapIntegrationConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
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
            PrincipalConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (PrincipalConnection)psObject.BaseObject;
                } else {
                    fields = (PrincipalConnection)this.Field;
                }
            }
            string document = Query.LdapPrincipalConnection(ref fields);
            this._input.Initialize(argDefs, fields, "Query.LdapPrincipalConnection");
            var parameters = "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: LdapPrincipalFieldEnum,$id: UUID!,$searchText: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryLdapPrincipalConnection" + parameters + "{" + document + "}",
                OperationName = "QueryLdapPrincipalConnection",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "PrincipalConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
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
            AuthorizedPrincipalConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AuthorizedPrincipalConnection)psObject.BaseObject;
                } else {
                    fields = (AuthorizedPrincipalConnection)this.Field;
                }
            }
            string document = Query.LdapAuthorizedPrincipalConnection(ref fields);
            this._input.Initialize(argDefs, fields, "Query.LdapAuthorizedPrincipalConnection");
            var parameters = "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: LdapAuthorizedPrincipalFieldEnum,$searchText: String!,$roleIds: [UUID!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryLdapAuthorizedPrincipalConnection" + parameters + "{" + document + "}",
                OperationName = "QueryLdapAuthorizedPrincipalConnection",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AuthorizedPrincipalConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscQueryLdap
}