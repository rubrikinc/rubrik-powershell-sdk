// New-RscMutationSmb.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Linq;
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
    /// Create a new RscQuery object for any of the 7
    /// operations in the 'SMB' API domain:
    /// AddAndJoinDomain, CloudDirectDeleteGlobalUser, CloudDirectSetGlobalAuth, DeleteDomain, JoinDomain, PutConfiguration, or SetCloudDirectGlobalSettings.
    /// </summary>
    /// <description>
    /// New-RscMutationSmb creates a new
    /// mutation object for operations
    /// in the 'SMB' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 7 operations
    /// in the 'SMB' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AddAndJoinDomain, CloudDirectDeleteGlobalUser, CloudDirectSetGlobalAuth, DeleteDomain, JoinDomain, PutConfiguration, or SetCloudDirectGlobalSettings.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationSmb -AddAndJoinDomain).Info().
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
    /// (New-RscMutationSmb -AddAndJoinDomain).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AddAndJoinDomain operation
    /// of the 'SMB' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Smb
    /// # API Operation: AddAndJoinDomain
    /// 
    /// $query = New-RscMutationSmb -Operation AddAndJoinDomain
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# REQUIRED
    /// 		name = $someString
    /// 		# OPTIONAL
    /// 		smbDomainJoinRequest = @{
    /// 			# OPTIONAL
    /// 			computerAccountName = $someString
    /// 			# OPTIONAL
    /// 			creationOrganizationUnit = $someString
    /// 			# OPTIONAL
    /// 			domainControllers = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			isStickySmbService = $someBoolean
    /// 			# OPTIONAL
    /// 			orgNetworkId = $someString
    /// 			# REQUIRED
    /// 			password = $someString
    /// 			# REQUIRED
    /// 			username = $someString
    /// 		}
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddAndJoinSmbDomainReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudDirectDeleteGlobalUser operation
    /// of the 'SMB' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Smb
    /// # API Operation: CloudDirectDeleteGlobalUser
    /// 
    /// $query = New-RscMutationSmb -Operation CloudDirectDeleteGlobalUser
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	username = $someString
    /// }
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
    /// <example>
    /// Runs the CloudDirectSetGlobalAuth operation
    /// of the 'SMB' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Smb
    /// # API Operation: CloudDirectSetGlobalAuth
    /// 
    /// $query = New-RscMutationSmb -Operation CloudDirectSetGlobalAuth
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	username = $someString
    /// 	# REQUIRED
    /// 	password = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CloudDirectSetGlobalSmbAuthReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteDomain operation
    /// of the 'SMB' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Smb
    /// # API Operation: DeleteDomain
    /// 
    /// $query = New-RscMutationSmb -Operation DeleteDomain
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	domainName = $someString
    /// }
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
    /// <example>
    /// Runs the JoinDomain operation
    /// of the 'SMB' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Smb
    /// # API Operation: JoinDomain
    /// 
    /// $query = New-RscMutationSmb -Operation JoinDomain
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		computerAccountName = $someString
    /// 		# OPTIONAL
    /// 		creationOrganizationUnit = $someString
    /// 		# OPTIONAL
    /// 		domainControllers = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		isStickySmbService = $someBoolean
    /// 		# OPTIONAL
    /// 		orgNetworkId = $someString
    /// 		# REQUIRED
    /// 		password = $someString
    /// 		# REQUIRED
    /// 		username = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	domainName = $someString
    /// }
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
    /// <example>
    /// Runs the PutConfiguration operation
    /// of the 'SMB' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Smb
    /// # API Operation: PutConfiguration
    /// 
    /// $query = New-RscMutationSmb -Operation PutConfiguration
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# REQUIRED
    /// 		enforceSmbSecurity = $someBoolean
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PutSmbConfigurationReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetCloudDirectGlobalSettings operation
    /// of the 'SMB' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Smb
    /// # API Operation: SetCloudDirectGlobalSettings
    /// 
    /// $query = New-RscMutationSmb -Operation SetCloudDirectGlobalSettings
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	shouldSupportSystemFiles = $someBoolean
    /// 	# REQUIRED
    /// 	offlineFilesBehaviour = $someCloudDirectOfflineFilesBehaviour # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudDirectOfflineFilesBehaviour]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SetCloudDirectGlobalSmbSettingsReply
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
        "RscMutationSmb",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationSmb : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "AddAndJoinDomain",
                "CloudDirectDeleteGlobalUser",
                "CloudDirectSetGlobalAuth",
                "DeleteDomain",
                "JoinDomain",
                "PutConfiguration",
                "SetCloudDirectGlobalSettings",
                IgnoreCase = true)]
        public string Operation { get; set; } = "";

        internal override string GetOperationParameter()
        {
            return this.Operation;
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "AddAndJoinDomain":
                        this.ProcessRecord_AddAndJoinDomain();
                        break;
                    case "CloudDirectDeleteGlobalUser":
                        this.ProcessRecord_CloudDirectDeleteGlobalUser();
                        break;
                    case "CloudDirectSetGlobalAuth":
                        this.ProcessRecord_CloudDirectSetGlobalAuth();
                        break;
                    case "DeleteDomain":
                        this.ProcessRecord_DeleteDomain();
                        break;
                    case "JoinDomain":
                        this.ProcessRecord_JoinDomain();
                        break;
                    case "PutConfiguration":
                        this.ProcessRecord_PutConfiguration();
                        break;
                    case "SetCloudDirectGlobalSettings":
                        this.ProcessRecord_SetCloudDirectGlobalSettings();
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
        // addAndJoinSmbDomain.
        internal void ProcessRecord_AddAndJoinDomain()
        {
            this._logger.name += " -AddAndJoinDomain";
            // Create new graphql operation addAndJoinSmbDomain
            InitMutationAddAndJoinSmbDomain();
        }

        // This parameter set invokes a single graphql operation:
        // cloudDirectDeleteGlobalSmbUser.
        internal void ProcessRecord_CloudDirectDeleteGlobalUser()
        {
            this._logger.name += " -CloudDirectDeleteGlobalUser";
            // Create new graphql operation cloudDirectDeleteGlobalSmbUser
            InitMutationCloudDirectDeleteGlobalSmbUser();
        }

        // This parameter set invokes a single graphql operation:
        // cloudDirectSetGlobalSmbAuth.
        internal void ProcessRecord_CloudDirectSetGlobalAuth()
        {
            this._logger.name += " -CloudDirectSetGlobalAuth";
            // Create new graphql operation cloudDirectSetGlobalSmbAuth
            InitMutationCloudDirectSetGlobalSmbAuth();
        }

        // This parameter set invokes a single graphql operation:
        // deleteSmbDomain.
        internal void ProcessRecord_DeleteDomain()
        {
            this._logger.name += " -DeleteDomain";
            // Create new graphql operation deleteSmbDomain
            InitMutationDeleteSmbDomain();
        }

        // This parameter set invokes a single graphql operation:
        // joinSmbDomain.
        internal void ProcessRecord_JoinDomain()
        {
            this._logger.name += " -JoinDomain";
            // Create new graphql operation joinSmbDomain
            InitMutationJoinSmbDomain();
        }

        // This parameter set invokes a single graphql operation:
        // putSmbConfiguration.
        internal void ProcessRecord_PutConfiguration()
        {
            this._logger.name += " -PutConfiguration";
            // Create new graphql operation putSmbConfiguration
            InitMutationPutSmbConfiguration();
        }

        // This parameter set invokes a single graphql operation:
        // setCloudDirectGlobalSmbSettings.
        internal void ProcessRecord_SetCloudDirectGlobalSettings()
        {
            this._logger.name += " -SetCloudDirectGlobalSettings";
            // Create new graphql operation setCloudDirectGlobalSmbSettings
            InitMutationSetCloudDirectGlobalSmbSettings();
        }


        // Create new GraphQL Mutation:
        // addAndJoinSmbDomain(input: AddAndJoinSmbDomainInput!): AddAndJoinSmbDomainReply!
        internal void InitMutationAddAndJoinSmbDomain()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddAndJoinSmbDomainInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddAndJoinSmbDomain",
                "($input: AddAndJoinSmbDomainInput!)",
                "AddAndJoinSmbDomainReply",
                Mutation.AddAndJoinSmbDomain,
                Mutation.AddAndJoinSmbDomainFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	config = @{
		# REQUIRED
		name = $someString
		# OPTIONAL
		smbDomainJoinRequest = @{
			# OPTIONAL
			computerAccountName = $someString
			# OPTIONAL
			creationOrganizationUnit = $someString
			# OPTIONAL
			domainControllers = @(
				$someString
			)
			# OPTIONAL
			isStickySmbService = $someBoolean
			# OPTIONAL
			orgNetworkId = $someString
			# REQUIRED
			password = $someString
			# REQUIRED
			username = $someString
		}
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // cloudDirectDeleteGlobalSmbUser(input: CloudDirectDeleteGlobalSmbUserInput!): Void
        internal void InitMutationCloudDirectDeleteGlobalSmbUser()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CloudDirectDeleteGlobalSmbUserInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCloudDirectDeleteGlobalSmbUser",
                "($input: CloudDirectDeleteGlobalSmbUserInput!)",
                "System.String",
                Mutation.CloudDirectDeleteGlobalSmbUser,
                Mutation.CloudDirectDeleteGlobalSmbUserFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	username = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // cloudDirectSetGlobalSmbAuth(input: CloudDirectSetGlobalSmbAuthInput!): CloudDirectSetGlobalSmbAuthReply!
        internal void InitMutationCloudDirectSetGlobalSmbAuth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CloudDirectSetGlobalSmbAuthInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCloudDirectSetGlobalSmbAuth",
                "($input: CloudDirectSetGlobalSmbAuthInput!)",
                "CloudDirectSetGlobalSmbAuthReply",
                Mutation.CloudDirectSetGlobalSmbAuth,
                Mutation.CloudDirectSetGlobalSmbAuthFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	username = $someString
	# REQUIRED
	password = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteSmbDomain(input: DeleteSmbDomainInput!): Void
        internal void InitMutationDeleteSmbDomain()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteSmbDomainInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteSmbDomain",
                "($input: DeleteSmbDomainInput!)",
                "System.String",
                Mutation.DeleteSmbDomain,
                Mutation.DeleteSmbDomainFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	domainName = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // joinSmbDomain(input: JoinSmbDomainInput!): Void
        internal void InitMutationJoinSmbDomain()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "JoinSmbDomainInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationJoinSmbDomain",
                "($input: JoinSmbDomainInput!)",
                "System.String",
                Mutation.JoinSmbDomain,
                Mutation.JoinSmbDomainFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		computerAccountName = $someString
		# OPTIONAL
		creationOrganizationUnit = $someString
		# OPTIONAL
		domainControllers = @(
			$someString
		)
		# OPTIONAL
		isStickySmbService = $someBoolean
		# OPTIONAL
		orgNetworkId = $someString
		# REQUIRED
		password = $someString
		# REQUIRED
		username = $someString
	}
	# REQUIRED
	domainName = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // putSmbConfiguration(input: PutSmbConfigurationInput!): PutSmbConfigurationReply!
        internal void InitMutationPutSmbConfiguration()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PutSmbConfigurationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPutSmbConfiguration",
                "($input: PutSmbConfigurationInput!)",
                "PutSmbConfigurationReply",
                Mutation.PutSmbConfiguration,
                Mutation.PutSmbConfigurationFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	config = @{
		# REQUIRED
		enforceSmbSecurity = $someBoolean
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // setCloudDirectGlobalSmbSettings(input: SetCloudDirectGlobalSmbSettingsInput!): SetCloudDirectGlobalSmbSettingsReply!
        internal void InitMutationSetCloudDirectGlobalSmbSettings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetCloudDirectGlobalSmbSettingsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetCloudDirectGlobalSmbSettings",
                "($input: SetCloudDirectGlobalSmbSettingsInput!)",
                "SetCloudDirectGlobalSmbSettingsReply",
                Mutation.SetCloudDirectGlobalSmbSettings,
                Mutation.SetCloudDirectGlobalSmbSettingsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	shouldSupportSystemFiles = $someBoolean
	# REQUIRED
	offlineFilesBehaviour = $someCloudDirectOfflineFilesBehaviour # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudDirectOfflineFilesBehaviour]) for enum values.
}"
            );
        }


    } // class New_RscMutationSmb
}