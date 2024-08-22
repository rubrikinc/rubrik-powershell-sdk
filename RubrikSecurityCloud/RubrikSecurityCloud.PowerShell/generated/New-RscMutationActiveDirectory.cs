// New-RscMutationActiveDirectory.cs
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
    /// Create a new RscQuery object for any of the 4
    /// operations in the 'Active Directory' API domain:
    /// CreateLiveMount, CreateUnmount, ModifyLiveMount, or RestoreObjects.
    /// </summary>
    /// <description>
    /// New-RscMutationActiveDirectory creates a new
    /// mutation object for operations
    /// in the 'Active Directory' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 4 operations
    /// in the 'Active Directory' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: CreateLiveMount, CreateUnmount, ModifyLiveMount, or RestoreObjects.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationActiveDirectory -CreateLiveMount).Info().
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
    /// (New-RscMutationActiveDirectory -CreateLiveMount).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the CreateLiveMount operation
    /// of the 'Active Directory' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActiveDirectory
    /// # API Operation: CreateLiveMount
    /// 
    /// $query = New-RscMutationActiveDirectory -CreateLiveMount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		validUsers = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		validIps = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		mountExpiryInMinutes = $someInt
    /// 		# OPTIONAL
    /// 		domainControllerId = $someString
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# OPTIONAL
    /// 		shouldBeWritable = $someBoolean
    /// 		# OPTIONAL
    /// 		domainName = $someString
    /// 		# OPTIONAL
    /// 		subnet = $someString
    /// 		# OPTIONAL
    /// 		shouldMountVhdx = $someBoolean
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateUnmount operation
    /// of the 'Active Directory' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActiveDirectory
    /// # API Operation: CreateUnmount
    /// 
    /// $query = New-RscMutationActiveDirectory -CreateUnmount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ModifyLiveMount operation
    /// of the 'Active Directory' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActiveDirectory
    /// # API Operation: ModifyLiveMount
    /// 
    /// $query = New-RscMutationActiveDirectory -ModifyLiveMount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		validIps = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# OPTIONAL
    /// 		subnet = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
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
    /// Runs the RestoreObjects operation
    /// of the 'Active Directory' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActiveDirectory
    /// # API Operation: RestoreObjects
    /// 
    /// $query = New-RscMutationActiveDirectory -RestoreObjects
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		shouldMergeLinkedAttrs = $someBoolean
    /// 		# OPTIONAL
    /// 		restoreToDifferentContainer = $someString
    /// 		# OPTIONAL
    /// 		shouldContinueOnError = $someBoolean
    /// 		# OPTIONAL
    /// 		clearUpAttrsIfNullInBackup = $someBoolean
    /// 		# OPTIONAL
    /// 		shouldCreateMissingParents = $someBoolean
    /// 		# OPTIONAL
    /// 		locationId = $someString
    /// 		# OPTIONAL
    /// 		hostId = $someString
    /// 		# OPTIONAL
    /// 		nameConflict = $someActiveDirectoryObjectNameConflictOption # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActiveDirectoryObjectNameConflictOption]) for enum values.
    /// 		# OPTIONAL
    /// 		objectMovedOptions = $someActiveDirectoryObjectMovedOption # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActiveDirectoryObjectMovedOption]) for enum values.
    /// 		# OPTIONAL
    /// 		containerRestoreOptions = @{
    /// 			# OPTIONAL
    /// 			shouldDeleteExtraObjects = $someBoolean
    /// 			# OPTIONAL
    /// 			shouldOnlyRecreateMissingObjects = $someBoolean
    /// 		}
    /// 		# OPTIONAL
    /// 		credsForRestore = @{
    /// 			# REQUIRED
    /// 			password = $someString
    /// 			# REQUIRED
    /// 			username = $someString
    /// 		}
    /// 		# REQUIRED
    /// 		domainControllerRecoveryObjects = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				attributes = @(
    /// 					$someString
    /// 				)
    /// 				# OPTIONAL
    /// 				objectType = $someActiveDirectoryObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActiveDirectoryObjectType]) for enum values.
    /// 				# REQUIRED
    /// 				dnt = $someInt64
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		userRestoreOptions = @{
    /// 			# OPTIONAL
    /// 			shouldEnableUser = $someBoolean
    /// 			# OPTIONAL
    /// 			shouldChangePassword = $someBoolean
    /// 			# OPTIONAL
    /// 			password = $someString
    /// 			# OPTIONAL
    /// 			passwordOptions = $someActiveDirectoryUserPasswordRecoveryOption # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActiveDirectoryUserPasswordRecoveryOption]) for enum values.
    /// 		}
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
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
        "RscMutationActiveDirectory",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationActiveDirectory : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "CreateLiveMount",
                "CreateUnmount",
                "ModifyLiveMount",
                "RestoreObjects",
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
                    case "CreateLiveMount":
                        this.ProcessRecord_CreateLiveMount();
                        break;
                    case "CreateUnmount":
                        this.ProcessRecord_CreateUnmount();
                        break;
                    case "ModifyLiveMount":
                        this.ProcessRecord_ModifyLiveMount();
                        break;
                    case "RestoreObjects":
                        this.ProcessRecord_RestoreObjects();
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
        // createActiveDirectoryLiveMount.
        internal void ProcessRecord_CreateLiveMount()
        {
            this._logger.name += " -CreateLiveMount";
            // Create new graphql operation createActiveDirectoryLiveMount
            InitMutationCreateActiveDirectoryLiveMount();
        }

        // This parameter set invokes a single graphql operation:
        // createActiveDirectoryUnmount.
        internal void ProcessRecord_CreateUnmount()
        {
            this._logger.name += " -CreateUnmount";
            // Create new graphql operation createActiveDirectoryUnmount
            InitMutationCreateActiveDirectoryUnmount();
        }

        // This parameter set invokes a single graphql operation:
        // modifyActiveDirectoryLiveMount.
        internal void ProcessRecord_ModifyLiveMount()
        {
            this._logger.name += " -ModifyLiveMount";
            // Create new graphql operation modifyActiveDirectoryLiveMount
            InitMutationModifyActiveDirectoryLiveMount();
        }

        // This parameter set invokes a single graphql operation:
        // restoreActiveDirectoryObjects.
        internal void ProcessRecord_RestoreObjects()
        {
            this._logger.name += " -RestoreObjects";
            // Create new graphql operation restoreActiveDirectoryObjects
            InitMutationRestoreActiveDirectoryObjects();
        }


        // Create new GraphQL Mutation:
        // createActiveDirectoryLiveMount(input: CreateActiveDirectoryLiveMountInput!): AsyncRequestStatus!
        internal void InitMutationCreateActiveDirectoryLiveMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateActiveDirectoryLiveMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateActiveDirectoryLiveMount",
                "($input: CreateActiveDirectoryLiveMountInput!)",
                "AsyncRequestStatus",
                Mutation.CreateActiveDirectoryLiveMount,
                Mutation.CreateActiveDirectoryLiveMountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		validUsers = @(
			$someString
		)
		# OPTIONAL
		validIps = @(
			$someString
		)
		# OPTIONAL
		mountExpiryInMinutes = $someInt
		# OPTIONAL
		domainControllerId = $someString
		# OPTIONAL
		password = $someString
		# OPTIONAL
		shouldBeWritable = $someBoolean
		# OPTIONAL
		domainName = $someString
		# OPTIONAL
		subnet = $someString
		# OPTIONAL
		shouldMountVhdx = $someBoolean
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // createActiveDirectoryUnmount(input: CreateActiveDirectoryUnmountInput!): AsyncRequestStatus!
        internal void InitMutationCreateActiveDirectoryUnmount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateActiveDirectoryUnmountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateActiveDirectoryUnmount",
                "($input: CreateActiveDirectoryUnmountInput!)",
                "AsyncRequestStatus",
                Mutation.CreateActiveDirectoryUnmount,
                Mutation.CreateActiveDirectoryUnmountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // modifyActiveDirectoryLiveMount(input: ModifyActiveDirectoryLiveMountInput!): Void
        internal void InitMutationModifyActiveDirectoryLiveMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ModifyActiveDirectoryLiveMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationModifyActiveDirectoryLiveMount",
                "($input: ModifyActiveDirectoryLiveMountInput!)",
                "System.String",
                Mutation.ModifyActiveDirectoryLiveMount,
                Mutation.ModifyActiveDirectoryLiveMountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		validIps = @(
			$someString
		)
		# OPTIONAL
		password = $someString
		# OPTIONAL
		subnet = $someString
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // restoreActiveDirectoryObjects(input: RestoreActiveDirectoryObjectsInput!): AsyncRequestStatus!
        internal void InitMutationRestoreActiveDirectoryObjects()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreActiveDirectoryObjectsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreActiveDirectoryObjects",
                "($input: RestoreActiveDirectoryObjectsInput!)",
                "AsyncRequestStatus",
                Mutation.RestoreActiveDirectoryObjects,
                Mutation.RestoreActiveDirectoryObjectsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		shouldMergeLinkedAttrs = $someBoolean
		# OPTIONAL
		restoreToDifferentContainer = $someString
		# OPTIONAL
		shouldContinueOnError = $someBoolean
		# OPTIONAL
		clearUpAttrsIfNullInBackup = $someBoolean
		# OPTIONAL
		shouldCreateMissingParents = $someBoolean
		# OPTIONAL
		locationId = $someString
		# OPTIONAL
		hostId = $someString
		# OPTIONAL
		nameConflict = $someActiveDirectoryObjectNameConflictOption # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActiveDirectoryObjectNameConflictOption]) for enum values.
		# OPTIONAL
		objectMovedOptions = $someActiveDirectoryObjectMovedOption # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActiveDirectoryObjectMovedOption]) for enum values.
		# OPTIONAL
		containerRestoreOptions = @{
			# OPTIONAL
			shouldDeleteExtraObjects = $someBoolean
			# OPTIONAL
			shouldOnlyRecreateMissingObjects = $someBoolean
		}
		# OPTIONAL
		credsForRestore = @{
			# REQUIRED
			password = $someString
			# REQUIRED
			username = $someString
		}
		# REQUIRED
		domainControllerRecoveryObjects = @(
			@{
				# OPTIONAL
				attributes = @(
					$someString
				)
				# OPTIONAL
				objectType = $someActiveDirectoryObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActiveDirectoryObjectType]) for enum values.
				# REQUIRED
				dnt = $someInt64
			}
		)
		# OPTIONAL
		userRestoreOptions = @{
			# OPTIONAL
			shouldEnableUser = $someBoolean
			# OPTIONAL
			shouldChangePassword = $someBoolean
			# OPTIONAL
			password = $someString
			# OPTIONAL
			passwordOptions = $someActiveDirectoryUserPasswordRecoveryOption # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActiveDirectoryUserPasswordRecoveryOption]) for enum values.
		}
	}
	# REQUIRED
	id = $someString
}"
            );
        }


    } // class New_RscMutationActiveDirectory
}