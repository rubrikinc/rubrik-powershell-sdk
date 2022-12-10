// Mutate-RscLdap.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:44.
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
using Rubrik.SecurityCloud.NetSDK.Library.HelperClasses;
using Rubrik.SecurityCloud.Operations;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Mutate",
        "RscLdap",
        DefaultParameterSetName = "setMfaSetting")
    ]
    public class Mutate_RscLdap : RscPSCmdlet
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
            HelpMessage = "GraphQL operation: updateLdapIntegration(,   id: UUID,   name: String!,   bindUserName: String!,   bindUserPassword: String!,   baseDn: String,   trustedCerts: String,   dynamicDnsName: String,   ldapServers: [LdapServerInput!],   userSearchFilter: String,   userNameAttr: String,   groupMembershipAttr: String,   groupSearchFilter: String,   groupMemberAttr: String, ):String!",
            Position = 0
        )]
        public SwitchParameter updateIntegration { get; set; }

        [Parameter(
            ParameterSetName = "updateIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument id: UUID"
        )]
        public System.String? Id { get; set; }
        [Parameter(
            ParameterSetName = "updateIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument name: String!"
        )]
        public System.String? Name { get; set; }
        [Parameter(
            ParameterSetName = "updateIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument bindUserName: String!"
        )]
        public System.String? BindUserName { get; set; }
        [Parameter(
            ParameterSetName = "updateIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument bindUserPassword: String!"
        )]
        public System.String? BindUserPassword { get; set; }
        [Parameter(
            ParameterSetName = "updateIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument baseDn: String"
        )]
        public System.String? BaseDn { get; set; }
        [Parameter(
            ParameterSetName = "updateIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument trustedCerts: String"
        )]
        public System.String? TrustedCerts { get; set; }
        [Parameter(
            ParameterSetName = "updateIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument dynamicDnsName: String"
        )]
        public System.String? DynamicDnsName { get; set; }
        [Parameter(
            ParameterSetName = "updateIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument ldapServers: [LdapServerInput!]"
        )]
        public List<LdapServerInput>? LdapServers { get; set; }
        [Parameter(
            ParameterSetName = "updateIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument userSearchFilter: String"
        )]
        public System.String? UserSearchFilter { get; set; }
        [Parameter(
            ParameterSetName = "updateIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument userNameAttr: String"
        )]
        public System.String? UserNameAttr { get; set; }
        [Parameter(
            ParameterSetName = "updateIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument groupMembershipAttr: String"
        )]
        public System.String? GroupMembershipAttr { get; set; }
        [Parameter(
            ParameterSetName = "updateIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument groupSearchFilter: String"
        )]
        public System.String? GroupSearchFilter { get; set; }
        [Parameter(
            ParameterSetName = "updateIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument groupMemberAttr: String"
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
            HelpMessage = "GraphQL operation: removeLdapIntegration(id: UUID!):Boolean!",
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
            HelpMessage = "GraphQL operation: deleteLdapPrincipals(principalIds: [String!]!):Boolean!",
            Position = 0
        )]
        public SwitchParameter deletePrincipal { get; set; }

        [Parameter(
            ParameterSetName = "deletePrincipal",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument principalIds: [String!]!"
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
            HelpMessage = "GraphQL operation: setLdapMfaSetting(input: SetLdapMfaSettingInput!):Boolean!",
            Position = 0
        )]
        public SwitchParameter setMfaSetting { get; set; }

        [Parameter(
            ParameterSetName = "setMfaSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument input: SetLdapMfaSettingInput!"
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
                    "Mutate-RscLdap",
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (System.String)psObject.BaseObject;
                } else {
                    fields = (System.String)this.Field;
                }
            }
            string document = Mutation.UpdateLdapIntegration(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateLdapIntegration");
            string parameters = "($id: UUID,$name: String!,$bindUserName: String!,$bindUserPassword: String!,$baseDn: String,$trustedCerts: String,$dynamicDnsName: String,$ldapServers: [LdapServerInput!],$userSearchFilter: String,$userNameAttr: String,$groupMembershipAttr: String,$groupSearchFilter: String,$groupMemberAttr: String)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateLdapIntegration" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateLdapIntegration",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<System.String> task = this._rbkClient.InvokeGenericCallAsync<System.String>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Mutation.RemoveLdapIntegration(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RemoveLdapIntegration");
            string parameters = "($id: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRemoveLdapIntegration" + parameters + "{" + document + "}",
                OperationName = "MutationRemoveLdapIntegration",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<System.Boolean> task = this._rbkClient.InvokeGenericCallAsync<System.Boolean>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Mutation.DeleteLdapPrincipals(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteLdapPrincipals");
            string parameters = "($principalIds: [String!]!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteLdapPrincipals" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteLdapPrincipals",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<System.Boolean> task = this._rbkClient.InvokeGenericCallAsync<System.Boolean>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Mutation.SetLdapMfaSetting(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.SetLdapMfaSetting");
            string parameters = "($input: SetLdapMfaSettingInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationSetLdapMfaSetting" + parameters + "{" + document + "}",
                OperationName = "MutationSetLdapMfaSetting",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<System.Boolean> task = this._rbkClient.InvokeGenericCallAsync<System.Boolean>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }


    } // class Mutate_RscLdap
}