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

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Create a new RscQuery object for any of the 4
    /// operations in the 'LDAP' API domain:
    /// DeletePrincipals, RemoveIntegration, SetMfaSetting, or UpdateIntegration.
    /// </summary>
    /// <description>
    /// New-RscMutationLdap creates a new
    /// mutation object for operations
    /// in the 'LDAP' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 4 operations
    /// in the 'LDAP' API domain. Select the operation this
    /// query is for by specifying the appropriate switch parameter;
    /// one of: -DeletePrincipals, -RemoveIntegration, -SetMfaSetting, -UpdateIntegration.
    /// Alternatively, you can specify the operation by setting the
    /// -Op parameter, for example: -Op DeletePrincipals,
    /// which is equivalent to specifying -DeletePrincipals.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationLdap -DeletePrincipals).Info().
    /// Each operation also has its own set of fields that can be
    /// selected for retrieval. If you do not specify any fields,
    /// a set of default fields will be selected. The selection is
    /// rule-based, and tries to select the most commonly used fields.
    /// For example if a field is named 'id' or 'name', 
    /// it will be selected. If you give -FieldProfile DETAIL, then
    /// another set of rules will be used to select more fields on top
    /// of the default fields. The set of rules for selecting fields
    /// is called a field profile. You can specify a field profile
    /// with the -FieldProfile parameter. You can add or remove fields
    /// from the field profile with the -AddField and -RemoveField
    /// parameters. If you end up with too many -AddField and -RemoveField
    /// parameters, you can list them in a text file, one per line,
    /// with a '+' or '-' prefix, and pass the file name to the
    /// -FilePatch parameter. Profiles and Patches are one way to
    /// customize the fields that are selected. Another way is to
    /// specify the fields by passing the -Field parameter an object
    /// that contains the fields you want to select as properties.
    /// Any property that is not null in that object is interpreted
    /// as a field to select
    /// (and the actual values they are set to do not matter).
    /// The [RubrikSecurityCloud.Types] namespace
    /// contains a set of classes that you can use to specify fields.
    /// To know what [RubrikSecurityCloud.Types] object to use
    /// for a specific operation,
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationLdap -DeletePrincipals).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the DeletePrincipals operation
    /// of the 'LDAP' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    LDAP
    /// # API Operation: DeletePrincipals
    /// 
    /// $query = New-RscMutationLdap -DeletePrincipals
    /// 
    /// # REQUIRED
    /// $query.Var.principalIds = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RemoveIntegration operation
    /// of the 'LDAP' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    LDAP
    /// # API Operation: RemoveIntegration
    /// 
    /// $query = New-RscMutationLdap -RemoveIntegration
    /// 
    /// # REQUIRED
    /// $query.Var.id = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetMfaSetting operation
    /// of the 'LDAP' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    LDAP
    /// # API Operation: SetMfaSetting
    /// 
    /// $query = New-RscMutationLdap -SetMfaSetting
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	ldapId = $someString
    /// 	# OPTIONAL
    /// 	isTotpEnforced = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateIntegration operation
    /// of the 'LDAP' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    LDAP
    /// # API Operation: UpdateIntegration
    /// 
    /// $query = New-RscMutationLdap -UpdateIntegration
    /// 
    /// # OPTIONAL
    /// $query.Var.id = $someString
    /// # REQUIRED
    /// $query.Var.name = $someString
    /// # REQUIRED
    /// $query.Var.bindUserName = $someString
    /// # REQUIRED
    /// $query.Var.bindUserPassword = $someString
    /// # OPTIONAL
    /// $query.Var.baseDn = $someString
    /// # OPTIONAL
    /// $query.Var.trustedCerts = $someString
    /// # OPTIONAL
    /// $query.Var.dynamicDnsName = $someString
    /// # OPTIONAL
    /// $query.Var.ldapServers = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		hostname = $someString
    /// 		# OPTIONAL
    /// 		port = $someInt
    /// 		# OPTIONAL
    /// 		useTls = $someBoolean
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.userSearchFilter = $someString
    /// # OPTIONAL
    /// $query.Var.userNameAttr = $someString
    /// # OPTIONAL
    /// $query.Var.groupMembershipAttr = $someString
    /// # OPTIONAL
    /// $query.Var.groupSearchFilter = $someString
    /// # OPTIONAL
    /// $query.Var.groupMemberAttr = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationLdap",
        DefaultParameterSetName = "SetMfaSetting")
    ]
    public class New_RscMutationLdap : RscGqlPSCmdlet
    {
        
        [Parameter(
            ParameterSetName = "DeletePrincipals",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DeletePrincipals' operation
in the 'LDAP' API domain.
Description of the operation:

[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/deleteldapprincipals.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DeletePrincipals { get; set; }

        
        [Parameter(
            ParameterSetName = "RemoveIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'RemoveIntegration' operation
in the 'LDAP' API domain.
Description of the operation:
Remove LDAP integration.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/removeldapintegration.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter RemoveIntegration { get; set; }

        
        [Parameter(
            ParameterSetName = "SetMfaSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'SetMfaSetting' operation
in the 'LDAP' API domain.
Description of the operation:
Update the MFA settings for the given LDAP integration. Return true when the operation succeeds.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/setldapmfasetting.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter SetMfaSetting { get; set; }

        
        [Parameter(
            ParameterSetName = "UpdateIntegration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpdateIntegration' operation
in the 'LDAP' API domain.
Description of the operation:
Mutate LDAP integration.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/updateldapintegration.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpdateIntegration { get; set; }



        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "DeletePrincipals":
                        this.ProcessRecord_DeletePrincipals();
                        break;
                    case "RemoveIntegration":
                        this.ProcessRecord_RemoveIntegration();
                        break;
                    case "SetMfaSetting":
                        this.ProcessRecord_SetMfaSetting();
                        break;
                    case "UpdateIntegration":
                        this.ProcessRecord_UpdateIntegration();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + this.GetOp().OpName());
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
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
        // removeLdapIntegration.
        internal void ProcessRecord_RemoveIntegration()
        {
            this._logger.name += " -RemoveIntegration";
            // Create new graphql operation removeLdapIntegration
            InitMutationRemoveLdapIntegration();
        }

        // This parameter set invokes a single graphql operation:
        // setLdapMfaSetting.
        internal void ProcessRecord_SetMfaSetting()
        {
            this._logger.name += " -SetMfaSetting";
            // Create new graphql operation setLdapMfaSetting
            InitMutationSetLdapMfaSetting();
        }

        // This parameter set invokes a single graphql operation:
        // updateLdapIntegration.
        internal void ProcessRecord_UpdateIntegration()
        {
            this._logger.name += " -UpdateIntegration";
            // Create new graphql operation updateLdapIntegration
            InitMutationUpdateLdapIntegration();
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
$query.Var.principalIds = @(
	$someString
)"
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
$query.Var.id = $someString"
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
$query.Var.input = @{
	# OPTIONAL
	ldapId = $someString
	# OPTIONAL
	isTotpEnforced = $someBoolean
}"
            );
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
$query.Var.id = $someString
# REQUIRED
$query.Var.name = $someString
# REQUIRED
$query.Var.bindUserName = $someString
# REQUIRED
$query.Var.bindUserPassword = $someString
# OPTIONAL
$query.Var.baseDn = $someString
# OPTIONAL
$query.Var.trustedCerts = $someString
# OPTIONAL
$query.Var.dynamicDnsName = $someString
# OPTIONAL
$query.Var.ldapServers = @(
	@{
		# OPTIONAL
		hostname = $someString
		# OPTIONAL
		port = $someInt
		# OPTIONAL
		useTls = $someBoolean
}
)
# OPTIONAL
$query.Var.userSearchFilter = $someString
# OPTIONAL
$query.Var.userNameAttr = $someString
# OPTIONAL
$query.Var.groupMembershipAttr = $someString
# OPTIONAL
$query.Var.groupSearchFilter = $someString
# OPTIONAL
$query.Var.groupMemberAttr = $someString"
            );
        }


    } // class New_RscMutationLdap
}