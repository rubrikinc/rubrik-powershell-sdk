// New-RscGqlMutationUpdateLdapIntegration.cs
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
    /// Create new GraphQL Mutation updateLdapIntegration
    /// updateLdapIntegration(
    ///     id: UUID
    ///     name: String!
    ///     bindUserName: String!
    ///     bindUserPassword: String!
    ///     baseDn: String
    ///     trustedCerts: String
    ///     dynamicDnsName: String
    ///     ldapServers: [LdapServerInput!]
    ///     userSearchFilter: String
    ///     userNameAttr: String
    ///     groupMembershipAttr: String
    ///     groupSearchFilter: String
    ///     groupMemberAttr: String
    ///   ): String!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationUpdateLdapIntegration")
    ]
    public class New_RscGqlMutationUpdateLdapIntegration : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("updateLdapIntegration");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation updateLdapIntegration
        /// updateLdapIntegration(
        ///     id: UUID
        ///     name: String!
        ///     bindUserName: String!
        ///     bindUserPassword: String!
        ///     baseDn: String
        ///     trustedCerts: String
        ///     dynamicDnsName: String
        ///     ldapServers: [LdapServerInput!]
        ///     userSearchFilter: String
        ///     userNameAttr: String
        ///     groupMembershipAttr: String
        ///     groupSearchFilter: String
        ///     groupMemberAttr: String
        ///   ): String!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_updateLdapIntegration();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_updateLdapIntegration()
        {
            this._logger.name += " -updateLdapIntegration";
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

    } // class New-RscGqlMutationUpdateLdapIntegration
}