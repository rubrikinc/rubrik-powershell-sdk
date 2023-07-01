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
        DefaultParameterSetName = "SetMfaSetting")
    ]
    public class Invoke_RscMutateLdap : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // UpdateIntegration parameter set
        //
        // [GraphQL: updateLdapIntegration]
        //
        [Parameter(
            ParameterSetName = "UpdateIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Mutate LDAP integration.
[GraphQL: updateLdapIntegration]",
            Position = 0
        )]
        public SwitchParameter UpdateIntegration { get; set; }

        
        // -------------------------------------------------------------------
        // RemoveIntegration parameter set
        //
        // [GraphQL: removeLdapIntegration]
        //
        [Parameter(
            ParameterSetName = "RemoveIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Remove LDAP integration.
[GraphQL: removeLdapIntegration]",
            Position = 0
        )]
        public SwitchParameter RemoveIntegration { get; set; }

        
        // -------------------------------------------------------------------
        // DeletePrincipal parameter set
        //
        // [GraphQL: deleteLdapPrincipals]
        //
        [Parameter(
            ParameterSetName = "DeletePrincipal",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: deleteLdapPrincipals]",
            Position = 0
        )]
        public SwitchParameter DeletePrincipal { get; set; }

        
        // -------------------------------------------------------------------
        // SetMfaSetting parameter set
        //
        // [GraphQL: setLdapMfaSetting]
        //
        [Parameter(
            ParameterSetName = "SetMfaSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update the MFA settings for the given LDAP integration. Return true when the operation succeeds.
[GraphQL: setLdapMfaSetting]",
            Position = 0
        )]
        public SwitchParameter SetMfaSetting { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "UpdateIntegration":
                        this.ProcessRecord_UpdateIntegration();
                        break;
                    case "RemoveIntegration":
                        this.ProcessRecord_RemoveIntegration();
                        break;
                    case "DeletePrincipal":
                        this.ProcessRecord_DeletePrincipal();
                        break;
                    case "SetMfaSetting":
                        this.ProcessRecord_SetMfaSetting();
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
        protected void ProcessRecord_UpdateIntegration()
        {
            this._logger.name += " -UpdateIntegration";
            // Invoke graphql operation updateLdapIntegration
            InvokeMutationUpdateLdapIntegration();
        }

        // This parameter set invokes a single graphql operation:
        // removeLdapIntegration.
        protected void ProcessRecord_RemoveIntegration()
        {
            this._logger.name += " -RemoveIntegration";
            // Invoke graphql operation removeLdapIntegration
            InvokeMutationRemoveLdapIntegration();
        }

        // This parameter set invokes a single graphql operation:
        // deleteLdapPrincipals.
        protected void ProcessRecord_DeletePrincipal()
        {
            this._logger.name += " -DeletePrincipal";
            // Invoke graphql operation deleteLdapPrincipals
            InvokeMutationDeleteLdapPrincipals();
        }

        // This parameter set invokes a single graphql operation:
        // setLdapMfaSetting.
        protected void ProcessRecord_SetMfaSetting()
        {
            this._logger.name += " -SetMfaSetting";
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
            var vars = new OperationVariableSet();
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
            var vars = new OperationVariableSet();
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
            var vars = new OperationVariableSet();
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
            var vars = new OperationVariableSet();
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