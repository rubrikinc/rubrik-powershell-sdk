// Invoke-RscMutateLdap.cs
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
        "RscMutateLdap",
        DefaultParameterSetName = "Setmfasetting")
    ]
    public class Invoke_RscMutateLdap : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // Updateintegration parameter set
        //
        // [GraphQL: updateLdapIntegration]
        //
        [Parameter(
            ParameterSetName = "Updateintegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Mutate LDAP integration.
[GraphQL: updateLdapIntegration]",
            Position = 0
        )]
        public SwitchParameter Updateintegration { get; set; }

        [Parameter(
            ParameterSetName = "Updateintegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"ID for your LDAP integration.
GraphQL argument id: UUID"
        )]
        public System.String? Id { get; set; }
        [Parameter(
            ParameterSetName = "Updateintegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Name for your LDAP integration.
GraphQL argument name: String!"
        )]
        public System.String? Name { get; set; }
        [Parameter(
            ParameterSetName = "Updateintegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"BindUserName for your LDAP integration.
GraphQL argument bindUserName: String!"
        )]
        public System.String? BindUserName { get; set; }
        [Parameter(
            ParameterSetName = "Updateintegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"BindUserPassword for your LDAP integration.
GraphQL argument bindUserPassword: String!"
        )]
        public System.String? BindUserPassword { get; set; }
        [Parameter(
            ParameterSetName = "Updateintegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"BaseDn for your LDAP integration.
GraphQL argument baseDn: String"
        )]
        public System.String? BaseDn { get; set; }
        [Parameter(
            ParameterSetName = "Updateintegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"TrustedCerts for your LDAP integration.
GraphQL argument trustedCerts: String"
        )]
        public System.String? TrustedCerts { get; set; }
        [Parameter(
            ParameterSetName = "Updateintegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Dynamic DNS name for your LDAP integration.
GraphQL argument dynamicDnsName: String"
        )]
        public System.String? DynamicDnsName { get; set; }
        [Parameter(
            ParameterSetName = "Updateintegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"LdapServers for your LDAP integration.
GraphQL argument ldapServers: [LdapServerInput!]"
        )]
        public List<LdapServerInput>? LdapServers { get; set; }
        [Parameter(
            ParameterSetName = "Updateintegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"User search filter for your LDAP integration.
GraphQL argument userSearchFilter: String"
        )]
        public System.String? UserSearchFilter { get; set; }
        [Parameter(
            ParameterSetName = "Updateintegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"User name attribute for your LDAP integration.
GraphQL argument userNameAttr: String"
        )]
        public System.String? UserNameAttr { get; set; }
        [Parameter(
            ParameterSetName = "Updateintegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Group membership attribute for your LDAP integration.
GraphQL argument groupMembershipAttr: String"
        )]
        public System.String? GroupMembershipAttr { get; set; }
        [Parameter(
            ParameterSetName = "Updateintegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Group search filter for your LDAP integration.
GraphQL argument groupSearchFilter: String"
        )]
        public System.String? GroupSearchFilter { get; set; }
        [Parameter(
            ParameterSetName = "Updateintegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Group member attribute for your LDAP integration.
GraphQL argument groupMemberAttr: String"
        )]
        public System.String? GroupMemberAttr { get; set; }
        
        // -------------------------------------------------------------------
        // Removeintegration parameter set
        //
        // [GraphQL: removeLdapIntegration]
        //
        [Parameter(
            ParameterSetName = "Removeintegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Remove LDAP integration.
[GraphQL: removeLdapIntegration]",
            Position = 0
        )]
        public SwitchParameter Removeintegration { get; set; }

        
        // -------------------------------------------------------------------
        // Deleteprincipal parameter set
        //
        // [GraphQL: deleteLdapPrincipals]
        //
        [Parameter(
            ParameterSetName = "Deleteprincipal",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: deleteLdapPrincipals]",
            Position = 0
        )]
        public SwitchParameter Deleteprincipal { get; set; }

        [Parameter(
            ParameterSetName = "Deleteprincipal",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
GraphQL argument principalIds: [String!]!"
        )]
        public List<System.String>? PrincipalIds { get; set; }
        
        // -------------------------------------------------------------------
        // Setmfasetting parameter set
        //
        // [GraphQL: setLdapMfaSetting]
        //
        [Parameter(
            ParameterSetName = "Setmfasetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update the MFA settings for the given LDAP integration. Return true when the operation succeeds.
[GraphQL: setLdapMfaSetting]",
            Position = 0
        )]
        public SwitchParameter Setmfasetting { get; set; }

        [Parameter(
            ParameterSetName = "Setmfasetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Input required for updating LDAP MFA settings.
GraphQL argument input: SetLdapMfaSettingInput!"
        )]
        public SetLdapMfaSettingInput? Input { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "Updateintegration":
                        this.ProcessRecord_Updateintegration();
                        break;
                    case "Removeintegration":
                        this.ProcessRecord_Removeintegration();
                        break;
                    case "Deleteprincipal":
                        this.ProcessRecord_Deleteprincipal();
                        break;
                    case "Setmfasetting":
                        this.ProcessRecord_Setmfasetting();
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
        // updateLdapIntegration.
        protected void ProcessRecord_Updateintegration()
        {
            this._logger.name += " -Updateintegration";
            // Invoke graphql operation updateLdapIntegration
            InvokeMutationUpdateLdapIntegration();
        }

        // This parameter set invokes a single graphql operation:
        // removeLdapIntegration.
        protected void ProcessRecord_Removeintegration()
        {
            this._logger.name += " -Removeintegration";
            // Invoke graphql operation removeLdapIntegration
            InvokeMutationRemoveLdapIntegration();
        }

        // This parameter set invokes a single graphql operation:
        // deleteLdapPrincipals.
        protected void ProcessRecord_Deleteprincipal()
        {
            this._logger.name += " -Deleteprincipal";
            // Invoke graphql operation deleteLdapPrincipals
            InvokeMutationDeleteLdapPrincipals();
        }

        // This parameter set invokes a single graphql operation:
        // setLdapMfaSetting.
        protected void ProcessRecord_Setmfasetting()
        {
            this._logger.name += " -Setmfasetting";
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