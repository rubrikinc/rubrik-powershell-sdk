// New-RscMutationLdap.cs
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
    /// Mutations for the 'Ldap' API domain.
    /// </summary>
    /// <description>
    /// New-RscMutationLdap is a master cmdlet for Ldap work that can invoke any of the following subcommands: UpdateIntegration, RemoveIntegration, DeletePrincipals, SetMfaSetting.
    /// </description>
    /// <example>
    /// <code>New-RscMutationLdap -UpdateIntegration [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationLdap -RemoveIntegration [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationLdap -DeletePrincipals [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationLdap -SetMfaSetting [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationLdap",
        DefaultParameterSetName = "SetMfaSetting")
    ]
    public class New_RscMutationLdap : RscGqlPSCmdlet
    {
        
        /// <summary>
        /// UpdateIntegration parameter set
        ///
        /// [GraphQL: updateLdapIntegration]
        /// </summary>
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

        
        /// <summary>
        /// RemoveIntegration parameter set
        ///
        /// [GraphQL: removeLdapIntegration]
        /// </summary>
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

        
        /// <summary>
        /// DeletePrincipals parameter set
        ///
        /// [GraphQL: deleteLdapPrincipals]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeletePrincipals",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: deleteLdapPrincipals]",
            Position = 0
        )]
        public SwitchParameter DeletePrincipals { get; set; }

        
        /// <summary>
        /// SetMfaSetting parameter set
        ///
        /// [GraphQL: setLdapMfaSetting]
        /// </summary>
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


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
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
                    case "DeletePrincipals":
                        this.ProcessRecord_DeletePrincipals();
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
#pragma warning restore 1591

        // This parameter set invokes a single graphql operation:
        // updateLdapIntegration.
        internal void ProcessRecord_UpdateIntegration()
        {
            this._logger.name += " -UpdateIntegration";
            // Create new graphql operation updateLdapIntegration
            InitMutationUpdateLdapIntegration();
        }

        // This parameter set invokes a single graphql operation:
        // removeLdapIntegration.
        internal void ProcessRecord_RemoveIntegration()
        {
            this._logger.name += " -RemoveIntegration";
            // Create new graphql operation removeLdapIntegration
            InitMutationRemoveLdapIntegration();
        }

        // This parameter set invokes a single graphql operation:
        // deleteLdapPrincipals.
        internal void ProcessRecord_DeletePrincipals()
        {
            this._logger.name += " -DeletePrincipals";
            // Create new graphql operation deleteLdapPrincipals
            InitMutationDeleteLdapPrincipals();
        }

        // This parameter set invokes a single graphql operation:
        // setLdapMfaSetting.
        internal void ProcessRecord_SetMfaSetting()
        {
            this._logger.name += " -SetMfaSetting";
            // Create new graphql operation setLdapMfaSetting
            InitMutationSetLdapMfaSetting();
        }


        // Create new GraphQL Mutation:
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
        internal void InitMutationUpdateLdapIntegration()
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
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateLdapIntegration",
                "($id: UUID,$name: String!,$bindUserName: String!,$bindUserPassword: String!,$baseDn: String,$trustedCerts: String,$dynamicDnsName: String,$ldapServers: [LdapServerInput!],$userSearchFilter: String,$userNameAttr: String,$groupMembershipAttr: String,$groupSearchFilter: String,$groupMemberAttr: String)",
                "System.String",
                Mutation.UpdateLdapIntegration_ObjectFieldSpec,
                Mutation.UpdateLdapIntegrationFieldSpec,
                @"# OPTIONAL
$inputs.Var.id = <System.String>
# REQUIRED
$inputs.Var.name = <System.String>
# REQUIRED
$inputs.Var.bindUserName = <System.String>
# REQUIRED
$inputs.Var.bindUserPassword = <System.String>
# OPTIONAL
$inputs.Var.baseDn = <System.String>
# OPTIONAL
$inputs.Var.trustedCerts = <System.String>
# OPTIONAL
$inputs.Var.dynamicDnsName = <System.String>
# OPTIONAL
$inputs.Var.ldapServers = @(
	@{
		# OPTIONAL
		hostname = <System.String>
		# OPTIONAL
		port = <System.Int32>
		# OPTIONAL
		useTls = <System.Boolean>
}
)
# OPTIONAL
$inputs.Var.userSearchFilter = <System.String>
# OPTIONAL
$inputs.Var.userNameAttr = <System.String>
# OPTIONAL
$inputs.Var.groupMembershipAttr = <System.String>
# OPTIONAL
$inputs.Var.groupSearchFilter = <System.String>
# OPTIONAL
$inputs.Var.groupMemberAttr = <System.String>"
            );
        }

        // Create new GraphQL Mutation:
        // removeLdapIntegration(id: UUID!): Boolean!
        internal void InitMutationRemoveLdapIntegration()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("id", "UUID!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRemoveLdapIntegration",
                "($id: UUID!)",
                "System.Boolean",
                Mutation.RemoveLdapIntegration_ObjectFieldSpec,
                Mutation.RemoveLdapIntegrationFieldSpec,
                @"# REQUIRED
$inputs.Var.id = <System.String>"
            );
        }

        // Create new GraphQL Mutation:
        // deleteLdapPrincipals(principalIds: [String!]!): Boolean!
        internal void InitMutationDeleteLdapPrincipals()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("principalIds", "[String!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteLdapPrincipals",
                "($principalIds: [String!]!)",
                "System.Boolean",
                Mutation.DeleteLdapPrincipals_ObjectFieldSpec,
                Mutation.DeleteLdapPrincipalsFieldSpec,
                @"# REQUIRED
$inputs.Var.principalIds = @(
	<System.String>
)"
            );
        }

        // Create new GraphQL Mutation:
        // setLdapMfaSetting(input: SetLdapMfaSettingInput!): Boolean!
        internal void InitMutationSetLdapMfaSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetLdapMfaSettingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetLdapMfaSetting",
                "($input: SetLdapMfaSettingInput!)",
                "System.Boolean",
                Mutation.SetLdapMfaSetting_ObjectFieldSpec,
                Mutation.SetLdapMfaSettingFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	ldapId = <System.String>
	# OPTIONAL
	isTotpEnforced = <System.Boolean>
}"
            );
        }


    } // class New_RscMutationLdap
}