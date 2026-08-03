// New-RscMutationStorageArray.cs
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
    /// Create a new RscQuery object for any of the 6
    /// operations in the 'Storage Arrays' API domain:
    /// Add, AddV1, Delete, Refresh, Update, or UpdateV1.
    /// </summary>
    /// <description>
    /// New-RscMutationStorageArray creates a new
    /// mutation object for operations
    /// in the 'Storage Arrays' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 6 operations
    /// in the 'Storage Arrays' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: Add, AddV1, Delete, Refresh, Update, or UpdateV1.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationStorageArray -Add).Info().
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
    /// (New-RscMutationStorageArray -Add).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the Add operation
    /// of the 'Storage Arrays' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    StorageArray
    /// # API Operation: Add
    /// 
    /// $query = New-RscMutationStorageArray -Operation Add
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	configs = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			definition = @{
    /// 				# REQUIRED
    /// 				arrayType = $someStorageArrayType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StorageArrayType]) for enum values.
    /// 				# OPTIONAL
    /// 				caCerts = $someString
    /// 				# REQUIRED
    /// 				hostname = $someString
    /// 				# REQUIRED
    /// 				password = $someString
    /// 				# REQUIRED
    /// 				username = $someString
    /// 				# OPTIONAL
    /// 				certificateId = $someString
    /// 			}
    /// 			# REQUIRED
    /// 			clusterUuid = $someString
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddStorageArraysReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AddV1 operation
    /// of the 'Storage Arrays' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    StorageArray
    /// # API Operation: AddV1
    /// 
    /// $query = New-RscMutationStorageArray -Operation AddV1
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	definition = @{
    /// 		# OPTIONAL
    /// 		apiToken = $someString
    /// 		# OPTIONAL
    /// 		isVolumeProtectionEnabled = $someBoolean
    /// 		# REQUIRED
    /// 		arrayType = $someStorageArrayType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StorageArrayType]) for enum values.
    /// 		# OPTIONAL
    /// 		caCerts = $someString
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# OPTIONAL
    /// 		isSnapshotOffloadingEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# OPTIONAL
    /// 		username = $someString
    /// 	}
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
    /// Runs the Delete operation
    /// of the 'Storage Arrays' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    StorageArray
    /// # API Operation: Delete
    /// 
    /// $query = New-RscMutationStorageArray -Operation Delete
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	inputs = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			clusterUuid = $someString
    /// 			# REQUIRED
    /// 			id = $someString
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DeleteStorageArraysReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Refresh operation
    /// of the 'Storage Arrays' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    StorageArray
    /// # API Operation: Refresh
    /// 
    /// $query = New-RscMutationStorageArray -Operation Refresh
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	inputs = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			clusterUuid = $someString
    /// 			# REQUIRED
    /// 			id = $someString
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RefreshStorageArraysReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Update operation
    /// of the 'Storage Arrays' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    StorageArray
    /// # API Operation: Update
    /// 
    /// $query = New-RscMutationStorageArray -Operation Update
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	configs = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			definition = @{
    /// 				# REQUIRED
    /// 				arrayType = $someStorageArrayType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StorageArrayType]) for enum values.
    /// 				# OPTIONAL
    /// 				caCerts = $someString
    /// 				# REQUIRED
    /// 				hostname = $someString
    /// 				# REQUIRED
    /// 				password = $someString
    /// 				# REQUIRED
    /// 				username = $someString
    /// 				# OPTIONAL
    /// 				certificateId = $someString
    /// 			}
    /// 			# REQUIRED
    /// 			clusterUuid = $someString
    /// 			# REQUIRED
    /// 			id = $someString
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateStorageArraysReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateV1 operation
    /// of the 'Storage Arrays' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    StorageArray
    /// # API Operation: UpdateV1
    /// 
    /// $query = New-RscMutationStorageArray -Operation UpdateV1
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	definition = @{
    /// 		# OPTIONAL
    /// 		apiToken = $someString
    /// 		# REQUIRED
    /// 		isVolumeProtectionEnabled = $someBoolean
    /// 		# REQUIRED
    /// 		arrayType = $someStorageArrayType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StorageArrayType]) for enum values.
    /// 		# OPTIONAL
    /// 		caCerts = $someString
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		isSnapshotOffloadingEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# OPTIONAL
    /// 		username = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateStorageArrayV1Reply
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
        "RscMutationStorageArray",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationStorageArray : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "Add",
                "AddV1",
                "Delete",
                "Refresh",
                "Update",
                "UpdateV1",
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
                    case "Add":
                        this.ProcessRecord_Add();
                        break;
                    case "AddV1":
                        this.ProcessRecord_AddV1();
                        break;
                    case "Delete":
                        this.ProcessRecord_Delete();
                        break;
                    case "Refresh":
                        this.ProcessRecord_Refresh();
                        break;
                    case "Update":
                        this.ProcessRecord_Update();
                        break;
                    case "UpdateV1":
                        this.ProcessRecord_UpdateV1();
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
        // addStorageArrays.
        internal void ProcessRecord_Add()
        {
            this._logger.name += " -Add";
            // Create new graphql operation addStorageArrays
            InitMutationAddStorageArrays();
        }

        // This parameter set invokes a single graphql operation:
        // addStorageArrayV1.
        internal void ProcessRecord_AddV1()
        {
            this._logger.name += " -AddV1";
            // Create new graphql operation addStorageArrayV1
            InitMutationAddStorageArrayV1();
        }

        // This parameter set invokes a single graphql operation:
        // deleteStorageArrays.
        internal void ProcessRecord_Delete()
        {
            this._logger.name += " -Delete";
            // Create new graphql operation deleteStorageArrays
            InitMutationDeleteStorageArrays();
        }

        // This parameter set invokes a single graphql operation:
        // refreshStorageArrays.
        internal void ProcessRecord_Refresh()
        {
            this._logger.name += " -Refresh";
            // Create new graphql operation refreshStorageArrays
            InitMutationRefreshStorageArrays();
        }

        // This parameter set invokes a single graphql operation:
        // updateStorageArrays.
        internal void ProcessRecord_Update()
        {
            this._logger.name += " -Update";
            // Create new graphql operation updateStorageArrays
            InitMutationUpdateStorageArrays();
        }

        // This parameter set invokes a single graphql operation:
        // updateStorageArrayV1.
        internal void ProcessRecord_UpdateV1()
        {
            this._logger.name += " -UpdateV1";
            // Create new graphql operation updateStorageArrayV1
            InitMutationUpdateStorageArrayV1();
        }


        // Create new GraphQL Mutation:
        // addStorageArrays(input: AddStorageArraysInput!): AddStorageArraysReply!
        internal void InitMutationAddStorageArrays()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddStorageArraysInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddStorageArrays",
                "($input: AddStorageArraysInput!)",
                "AddStorageArraysReply",
                Mutation.AddStorageArrays,
                Mutation.AddStorageArraysFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	configs = @(
		@{
			# REQUIRED
			definition = @{
				# REQUIRED
				arrayType = $someStorageArrayType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StorageArrayType]) for enum values.
				# OPTIONAL
				caCerts = $someString
				# REQUIRED
				hostname = $someString
				# REQUIRED
				password = $someString
				# REQUIRED
				username = $someString
				# OPTIONAL
				certificateId = $someString
			}
			# REQUIRED
			clusterUuid = $someString
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // addStorageArrayV1(input: AddStorageArrayV1Input!): AsyncRequestStatus!
        internal void InitMutationAddStorageArrayV1()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddStorageArrayV1Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddStorageArrayV1",
                "($input: AddStorageArrayV1Input!)",
                "AsyncRequestStatus",
                Mutation.AddStorageArrayV1,
                Mutation.AddStorageArrayV1FieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	definition = @{
		# OPTIONAL
		apiToken = $someString
		# OPTIONAL
		isVolumeProtectionEnabled = $someBoolean
		# REQUIRED
		arrayType = $someStorageArrayType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StorageArrayType]) for enum values.
		# OPTIONAL
		caCerts = $someString
		# OPTIONAL
		certificateId = $someString
		# OPTIONAL
		isSnapshotOffloadingEnabled = $someBoolean
		# OPTIONAL
		password = $someString
		# REQUIRED
		hostname = $someString
		# OPTIONAL
		username = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteStorageArrays(input: DeleteStorageArraysInput!): DeleteStorageArraysReply!
        internal void InitMutationDeleteStorageArrays()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteStorageArraysInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteStorageArrays",
                "($input: DeleteStorageArraysInput!)",
                "DeleteStorageArraysReply",
                Mutation.DeleteStorageArrays,
                Mutation.DeleteStorageArraysFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	inputs = @(
		@{
			# REQUIRED
			clusterUuid = $someString
			# REQUIRED
			id = $someString
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // refreshStorageArrays(input: RefreshStorageArraysInput!): RefreshStorageArraysReply!
        internal void InitMutationRefreshStorageArrays()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshStorageArraysInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshStorageArrays",
                "($input: RefreshStorageArraysInput!)",
                "RefreshStorageArraysReply",
                Mutation.RefreshStorageArrays,
                Mutation.RefreshStorageArraysFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	inputs = @(
		@{
			# REQUIRED
			clusterUuid = $someString
			# REQUIRED
			id = $someString
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateStorageArrays(input: UpdateStorageArraysInput!): UpdateStorageArraysReply!
        internal void InitMutationUpdateStorageArrays()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateStorageArraysInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateStorageArrays",
                "($input: UpdateStorageArraysInput!)",
                "UpdateStorageArraysReply",
                Mutation.UpdateStorageArrays,
                Mutation.UpdateStorageArraysFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	configs = @(
		@{
			# REQUIRED
			definition = @{
				# REQUIRED
				arrayType = $someStorageArrayType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StorageArrayType]) for enum values.
				# OPTIONAL
				caCerts = $someString
				# REQUIRED
				hostname = $someString
				# REQUIRED
				password = $someString
				# REQUIRED
				username = $someString
				# OPTIONAL
				certificateId = $someString
			}
			# REQUIRED
			clusterUuid = $someString
			# REQUIRED
			id = $someString
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateStorageArrayV1(input: UpdateStorageArrayV1Input!): UpdateStorageArrayV1Reply!
        internal void InitMutationUpdateStorageArrayV1()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateStorageArrayV1Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateStorageArrayV1",
                "($input: UpdateStorageArrayV1Input!)",
                "UpdateStorageArrayV1Reply",
                Mutation.UpdateStorageArrayV1,
                Mutation.UpdateStorageArrayV1FieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	definition = @{
		# OPTIONAL
		apiToken = $someString
		# REQUIRED
		isVolumeProtectionEnabled = $someBoolean
		# REQUIRED
		arrayType = $someStorageArrayType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StorageArrayType]) for enum values.
		# OPTIONAL
		caCerts = $someString
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		isSnapshotOffloadingEnabled = $someBoolean
		# OPTIONAL
		password = $someString
		# REQUIRED
		hostname = $someString
		# OPTIONAL
		username = $someString
	}
}"
            );
        }


    } // class New_RscMutationStorageArray
}