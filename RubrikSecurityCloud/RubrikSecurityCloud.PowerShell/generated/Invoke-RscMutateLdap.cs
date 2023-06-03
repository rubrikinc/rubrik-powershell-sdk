// Invoke-RscMutateLdap.cs
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
        "RscMutateLdap",
        DefaultParameterSetName = "setMfaSetting")
    ]
    public class Invoke_RscMutateLdap : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // updateIntegration parameter set
        //
        // GraphQL operation: updateLdapIntegration(,   id: UUID,   name: String!,   bindUserName: String!,   bindUserPassword: String!,   baseDn: String,   trustedCerts: String,   dynamicDnsName: String,   ldapServers: [LdapServerInput!],   userSearchFilter: String,   userNameAttr: String,   groupMembershipAttr: String,   groupSearchFilter: String,   groupMemberAttr: String, ):String!
        //
        [Parameter(
            ParameterSetName = "updateIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Mutate LDAP integration.
                GraphQL operation: updateLdapIntegration(,   id: UUID,   name: String!,   bindUserName: String!,   bindUserPassword: String!,   baseDn: String,   trustedCerts: String,   dynamicDnsName: String,   ldapServers: [LdapServerInput!],   userSearchFilter: String,   userNameAttr: String,   groupMembershipAttr: String,   groupSearchFilter: String,   groupMemberAttr: String, ):String!
                ",
            Position = 0
        )]
        public SwitchParameter updateIntegration { get; set; }

        [Parameter(
            ParameterSetName = "updateIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                ID for your LDAP integration.
                GraphQL argument id: UUID
                "
        )]
        public System.String? Id { get; set; }
        [Parameter(
            ParameterSetName = "updateIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Name for your LDAP integration.
                GraphQL argument name: String!
                "
        )]
        public System.String? Name { get; set; }
        [Parameter(
            ParameterSetName = "updateIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                BindUserName for your LDAP integration.
                GraphQL argument bindUserName: String!
                "
        )]
        public System.String? BindUserName { get; set; }
        [Parameter(
            ParameterSetName = "updateIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                BindUserPassword for your LDAP integration.
                GraphQL argument bindUserPassword: String!
                "
        )]
        public System.String? BindUserPassword { get; set; }
        [Parameter(
            ParameterSetName = "updateIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                BaseDn for your LDAP integration.
                GraphQL argument baseDn: String
                "
        )]
        public System.String? BaseDn { get; set; }
        [Parameter(
            ParameterSetName = "updateIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                TrustedCerts for your LDAP integration.
                GraphQL argument trustedCerts: String
                "
        )]
        public System.String? TrustedCerts { get; set; }
        [Parameter(
            ParameterSetName = "updateIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Dynamic DNS name for your LDAP integration.
                GraphQL argument dynamicDnsName: String
                "
        )]
        public System.String? DynamicDnsName { get; set; }
        [Parameter(
            ParameterSetName = "updateIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                LdapServers for your LDAP integration.
                GraphQL argument ldapServers: [LdapServerInput!]
                "
        )]
        public List<LdapServerInput>? LdapServers { get; set; }
        [Parameter(
            ParameterSetName = "updateIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                User search filter for your LDAP integration.
                GraphQL argument userSearchFilter: String
                "
        )]
        public System.String? UserSearchFilter { get; set; }
        [Parameter(
            ParameterSetName = "updateIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                User name attribute for your LDAP integration.
                GraphQL argument userNameAttr: String
                "
        )]
        public System.String? UserNameAttr { get; set; }
        [Parameter(
            ParameterSetName = "updateIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Group membership attribute for your LDAP integration.
                GraphQL argument groupMembershipAttr: String
                "
        )]
        public System.String? GroupMembershipAttr { get; set; }
        [Parameter(
            ParameterSetName = "updateIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Group search filter for your LDAP integration.
                GraphQL argument groupSearchFilter: String
                "
        )]
        public System.String? GroupSearchFilter { get; set; }
        [Parameter(
            ParameterSetName = "updateIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Group member attribute for your LDAP integration.
                GraphQL argument groupMemberAttr: String
                "
        )]
        public System.String? GroupMemberAttr { get; set; }
        
        // -------------------------------------------------------------------
        // removeIntegration parameter set
        //
        // GraphQL operation: removeLdapIntegration(id: UUID!):Boolean!
        //
        [Parameter(
            ParameterSetName = "removeIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Remove LDAP integration.
                GraphQL operation: removeLdapIntegration(id: UUID!):Boolean!
                ",
            Position = 0
        )]
        public SwitchParameter removeIntegration { get; set; }

        
        // -------------------------------------------------------------------
        // deletePrincipal parameter set
        //
        // GraphQL operation: deleteLdapPrincipals(principalIds: [String!]!):Boolean!
        //
        [Parameter(
            ParameterSetName = "deletePrincipal",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: deleteLdapPrincipals(principalIds: [String!]!):Boolean!
                ",
            Position = 0
        )]
        public SwitchParameter deletePrincipal { get; set; }

        [Parameter(
            ParameterSetName = "deletePrincipal",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument principalIds: [String!]!
                "
        )]
        public List<System.String>? PrincipalIds { get; set; }
        
        // -------------------------------------------------------------------
        // setMfaSetting parameter set
        //
        // GraphQL operation: setLdapMfaSetting(input: SetLdapMfaSettingInput!):Boolean!
        //
        [Parameter(
            ParameterSetName = "setMfaSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Update the MFA settings for the given LDAP integration. Return true when the operation succeeds.
                GraphQL operation: setLdapMfaSetting(input: SetLdapMfaSettingInput!):Boolean!
                ",
            Position = 0
        )]
        public SwitchParameter setMfaSetting { get; set; }

        [Parameter(
            ParameterSetName = "setMfaSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Input required for updating LDAP MFA settings.
                GraphQL argument input: SetLdapMfaSettingInput!
                "
        )]
        public SetLdapMfaSettingInput? Input { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "updateIntegration":
                        this.ProcessRecord_updateIntegration();
                        break;
                    case "removeIntegration":
                        this.ProcessRecord_removeIntegration();
                        break;
                    case "deletePrincipal":
                        this.ProcessRecord_deletePrincipal();
                        break;
                    case "setMfaSetting":
                        this.ProcessRecord_setMfaSetting();
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
                    "Invoke-RscMutateLdap",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
           }
        }

        // This parameter set invokes a single graphql operation:
        // updateLdapIntegration.
        protected void ProcessRecord_updateIntegration()
        {
            this._logger.name += " -updateIntegration";
            // Invoke graphql operation updateLdapIntegration
            InvokeMutationUpdateLdapIntegration();
        }

        // This parameter set invokes a single graphql operation:
        // removeLdapIntegration.
        protected void ProcessRecord_removeIntegration()
        {
            this._logger.name += " -removeIntegration";
            // Invoke graphql operation removeLdapIntegration
            InvokeMutationRemoveLdapIntegration();
        }

        // This parameter set invokes a single graphql operation:
        // deleteLdapPrincipals.
        protected void ProcessRecord_deletePrincipal()
        {
            this._logger.name += " -deletePrincipal";
            // Invoke graphql operation deleteLdapPrincipals
            InvokeMutationDeleteLdapPrincipals();
        }

        // This parameter set invokes a single graphql operation:
        // setLdapMfaSetting.
        protected void ProcessRecord_setMfaSetting()
        {
            this._logger.name += " -setMfaSetting";
            // Invoke graphql operation setLdapMfaSetting
            InvokeMutationSetLdapMfaSetting();
        }


        // Invoke GraphQL Mutation:
        // updateLdapIntegration(
        //     id: UUID
        //     name: String!
        //     bindUserName: String!
        //     bindUserPassword: String!
        //     baseDn: String
        //     trustedCerts: String
        //     dynamicDnsName: String
        //     ldapServers: [LdapServerInput!]
        //     userSearchFilter: String
        //     userNameAttr: String
        //     groupMembershipAttr: String
        //     groupSearchFilter: String
        //     groupMemberAttr: String
        //   ): String!
        protected void InvokeMutationUpdateLdapIntegration()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("id", "UUID"),
                Tuple.Create("name", "String!"),
                Tuple.Create("bindUserName", "String!"),
                Tuple.Create("bindUserPassword", "String!"),
                Tuple.Create("baseDn", "String"),
                Tuple.Create("trustedCerts", "String"),
                Tuple.Create("dynamicDnsName", "String"),
                Tuple.Create("ldapServers", "[LdapServerInput!]"),
                Tuple.Create("userSearchFilter", "String"),
                Tuple.Create("userNameAttr", "String"),
                Tuple.Create("groupMembershipAttr", "String"),
                Tuple.Create("groupSearchFilter", "String"),
                Tuple.Create("groupMemberAttr", "String"),
            };
            System.String? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (System.String)psObject.BaseObject;
                } else {
                    fields = (System.String)this.Field;
                }
            }
            string document = Mutation.UpdateLdapIntegration(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateLdapIntegration");
            var parameters = "($id: UUID,$name: String!,$bindUserName: String!,$bindUserPassword: String!,$baseDn: String,$trustedCerts: String,$dynamicDnsName: String,$ldapServers: [LdapServerInput!],$userSearchFilter: String,$userNameAttr: String,$groupMembershipAttr: String,$groupSearchFilter: String,$groupMemberAttr: String)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateLdapIntegration" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateLdapIntegration",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "System.String", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // removeLdapIntegration(id: UUID!): Boolean!
        protected void InvokeMutationRemoveLdapIntegration()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("id", "UUID!"),
            };
            System.Boolean? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Mutation.RemoveLdapIntegration(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RemoveLdapIntegration");
            var parameters = "($id: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRemoveLdapIntegration" + parameters + "{" + document + "}",
                OperationName = "MutationRemoveLdapIntegration",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "System.Boolean", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteLdapPrincipals(principalIds: [String!]!): Boolean!
        protected void InvokeMutationDeleteLdapPrincipals()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("principalIds", "[String!]!"),
            };
            System.Boolean? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Mutation.DeleteLdapPrincipals(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteLdapPrincipals");
            var parameters = "($principalIds: [String!]!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteLdapPrincipals" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteLdapPrincipals",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "System.Boolean", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // setLdapMfaSetting(input: SetLdapMfaSettingInput!): Boolean!
        protected void InvokeMutationSetLdapMfaSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetLdapMfaSettingInput!"),
            };
            System.Boolean? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Mutation.SetLdapMfaSetting(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.SetLdapMfaSetting");
            var parameters = "($input: SetLdapMfaSettingInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationSetLdapMfaSetting" + parameters + "{" + document + "}",
                OperationName = "MutationSetLdapMfaSetting",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "System.Boolean", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscMutateLdap
}