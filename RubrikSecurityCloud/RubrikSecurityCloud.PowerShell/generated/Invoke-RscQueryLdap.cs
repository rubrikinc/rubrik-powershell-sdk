// Invoke-RscQueryLdap.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using Rubrik.SecurityCloud.Types;
using Rubrik.SecurityCloud.NetSDK.Client;
using Rubrik.SecurityCloud.PowerShell.Private;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using RubrikSecurityCloud.Schema.Utils;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
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
        // GraphQL operation: ldapIntegrationConnection(,   first: Int,   after: String,   last: Int,   before: String,   sortOrder: SortOrder,   sortBy: LdapIntegrationFieldEnum = Name, ):LdapIntegrationConnection!
        //
        [Parameter(
            ParameterSetName = "IntegrationList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Browse LDAP integrations.
                GraphQL operation: ldapIntegrationConnection(,   first: Int,   after: String,   last: Int,   before: String,   sortOrder: SortOrder,   sortBy: LdapIntegrationFieldEnum = Name, ):LdapIntegrationConnection!
                ",
            Position = 0
        )]
        public SwitchParameter IntegrationList { get; set; }

        [Parameter(
            ParameterSetName = "IntegrationList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Returns the first n elements from the list.
                GraphQL argument first: Int
                "
        )]
        public System.Int32? First { get; set; }
        [Parameter(
            ParameterSetName = "IntegrationList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Returns the elements in the list that come after the specified cursor.
                GraphQL argument after: String
                "
        )]
        public System.String? After { get; set; }
        [Parameter(
            ParameterSetName = "IntegrationList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Returns the last n elements from the list.
                GraphQL argument last: Int
                "
        )]
        public System.Int32? Last { get; set; }
        [Parameter(
            ParameterSetName = "IntegrationList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Returns the elements in the list that come before the specified cursor.
                GraphQL argument before: String
                "
        )]
        public System.String? Before { get; set; }
        [Parameter(
            ParameterSetName = "IntegrationList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Sorting order for the results.
                GraphQL argument sortOrder: SortOrder
                "
        )]
        public SortOrder? SortOrder { get; set; }
        [Parameter(
            ParameterSetName = "IntegrationList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument sortBy: LdapIntegrationFieldEnum
                "
        )]
        public LdapIntegrationFieldEnum? SortBy { get; set; }
        
        // -------------------------------------------------------------------
        // PrincipalList parameter set
        //
        // GraphQL operation: ldapPrincipalConnection(,   first: Int,   after: String,   last: Int,   before: String,   sortOrder: SortOrder,   sortBy: LdapPrincipalFieldEnum = Name,   id: UUID!,   searchText: String!, ):PrincipalConnection!
        //
        [Parameter(
            ParameterSetName = "PrincipalList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Search LDAP Principals.
                GraphQL operation: ldapPrincipalConnection(,   first: Int,   after: String,   last: Int,   before: String,   sortOrder: SortOrder,   sortBy: LdapPrincipalFieldEnum = Name,   id: UUID!,   searchText: String!, ):PrincipalConnection!
                ",
            Position = 0
        )]
        public SwitchParameter PrincipalList { get; set; }

        [Parameter(
            ParameterSetName = "PrincipalList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                ID for your LDAP integration.
                GraphQL argument id: UUID!
                "
        )]
        public System.String? Id { get; set; }
        [Parameter(
            ParameterSetName = "PrincipalList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Search Text for LDAP principal.
                GraphQL argument searchText: String!
                "
        )]
        public System.String? SearchText { get; set; }
        
        // -------------------------------------------------------------------
        // AuthorizedPrincipalList parameter set
        //
        // GraphQL operation: ldapAuthorizedPrincipalConnection(,   first: Int,   after: String,   last: Int,   before: String,   sortOrder: SortOrder,   sortBy: LdapAuthorizedPrincipalFieldEnum = Name,   searchText: String!,   roleIds: [UUID!], ):AuthorizedPrincipalConnection!
        //
        [Parameter(
            ParameterSetName = "AuthorizedPrincipalList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Browse LDAP-authorized principals.
                GraphQL operation: ldapAuthorizedPrincipalConnection(,   first: Int,   after: String,   last: Int,   before: String,   sortOrder: SortOrder,   sortBy: LdapAuthorizedPrincipalFieldEnum = Name,   searchText: String!,   roleIds: [UUID!], ):AuthorizedPrincipalConnection!
                ",
            Position = 0
        )]
        public SwitchParameter AuthorizedPrincipalList { get; set; }

        [Parameter(
            ParameterSetName = "AuthorizedPrincipalList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Assigned role IDs for LDAP principal.
                GraphQL argument roleIds: [UUID!]
                "
        )]
        public List<System.String>? RoleIds { get; set; }

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
                this._logger.Flush();
                var error = new ErrorRecord(
                    ex,
                    "Invoke-RscQueryLdap",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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