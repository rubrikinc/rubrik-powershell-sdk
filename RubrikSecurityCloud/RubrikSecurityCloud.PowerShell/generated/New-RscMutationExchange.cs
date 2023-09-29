// New-RscMutationExchange.cs
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
    /// operations in the 'Microsoft Exchange' API domain:
    /// BulkUpdateDag, CreateMount, CreateOnDemandBackup, or DeleteSnapshotMount.
    /// </summary>
    /// <description>
    /// New-RscMutationExchange creates a new
    /// mutation object for operations
    /// in the 'Microsoft Exchange' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 4 operations
    /// in the 'Microsoft Exchange' API domain. Select the operation this
    /// query is for by specifying the appropriate switch parameter;
    /// one of: -BulkUpdateDag, -CreateMount, -CreateOnDemandBackup, -DeleteSnapshotMount.
    /// Alternatively, you can specify the operation by setting the
    /// -Op parameter, for example: -Op BulkUpdateDag,
    /// which is equivalent to specifying -BulkUpdateDag.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationExchange -BulkUpdateDag).Info().
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
    /// (New-RscMutationExchange -BulkUpdateDag).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the BulkUpdateDag operation
    /// of the 'Microsoft Exchange' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Exchange
    /// # API Operation: BulkUpdateDag
    /// 
    /// $query = New-RscMutationExchange -BulkUpdateDag
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	dagUpdateProperties = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			id = $someString
    /// 			# REQUIRED
    /// 			updateProperties = @{
    /// 				# REQUIRED
    /// 				backupPreference = $someExchangeBackupPreference # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ExchangeBackupPreference]) for enum values.
    /// 			}
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: V1BulkUpdateExchangeDagResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateMount operation
    /// of the 'Microsoft Exchange' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Exchange
    /// # API Operation: CreateMount
    /// 
    /// $query = New-RscMutationExchange -CreateMount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		smbDomainName = $someString
    /// 		# OPTIONAL
    /// 		smbValidIps = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		smbValidUsers = @(
    /// 			$someString
    /// 		)
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
    /// Runs the CreateOnDemandBackup operation
    /// of the 'Microsoft Exchange' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Exchange
    /// # API Operation: CreateOnDemandBackup
    /// 
    /// $query = New-RscMutationExchange -CreateOnDemandBackup
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		forceFullSnapshot = $someBoolean
    /// 		# OPTIONAL
    /// 		baseOnDemandSnapshotConfig = @{
    /// 			# OPTIONAL
    /// 			slaId = $someString
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
    /// <example>
    /// Runs the DeleteSnapshotMount operation
    /// of the 'Microsoft Exchange' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Exchange
    /// # API Operation: DeleteSnapshotMount
    /// 
    /// $query = New-RscMutationExchange -DeleteSnapshotMount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
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
        "RscMutationExchange",
        DefaultParameterSetName = "CreateMount")
    ]
    public class New_RscMutationExchange : RscGqlPSCmdlet
    {
        
        [Parameter(
            ParameterSetName = "BulkUpdateDag",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'BulkUpdateDag' operation
in the 'Microsoft Exchange' API domain.
Description of the operation:
Update multiple Exchange DAGs

Supported in v8.0+
Update multiple Exchange DAGs with the specified properties.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/bulkupdateexchangedag.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter BulkUpdateDag { get; set; }

        
        [Parameter(
            ParameterSetName = "CreateMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreateMount' operation
in the 'Microsoft Exchange' API domain.
Description of the operation:
Create a request to mount a Microsoft Exchange database snapshot

Supported in v8.0+
Create a request to mount a Microsoft Exchange database snapshot.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createexchangemount.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreateMount { get; set; }

        
        [Parameter(
            ParameterSetName = "CreateOnDemandBackup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreateOnDemandBackup' operation
in the 'Microsoft Exchange' API domain.
Description of the operation:
Take an on-demand backup of a Microsoft Exchange database

Supported in v8.0+
Takes an on-demand backup of a Microsoft Exchange database. The forceFullSnapshot property can be set to true to force a full snapshot. To check the result of the request, poll /exchange/request/{id}.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createondemandexchangebackup.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreateOnDemandBackup { get; set; }

        
        [Parameter(
            ParameterSetName = "DeleteSnapshotMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DeleteSnapshotMount' operation
in the 'Microsoft Exchange' API domain.
Description of the operation:
Request to delete a mount for the Microsoft Exchange database snapshot

Supported in v8.0+
Request to delete a mount for Microsoft Exchange database snapshot.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/deleteexchangesnapshotmount.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DeleteSnapshotMount { get; set; }



        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "BulkUpdateDag":
                        this.ProcessRecord_BulkUpdateDag();
                        break;
                    case "CreateMount":
                        this.ProcessRecord_CreateMount();
                        break;
                    case "CreateOnDemandBackup":
                        this.ProcessRecord_CreateOnDemandBackup();
                        break;
                    case "DeleteSnapshotMount":
                        this.ProcessRecord_DeleteSnapshotMount();
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
        // bulkUpdateExchangeDag.
        internal void ProcessRecord_BulkUpdateDag()
        {
            this._logger.name += " -BulkUpdateDag";
            // Create new graphql operation bulkUpdateExchangeDag
            InitMutationBulkUpdateExchangeDag();
        }

        // This parameter set invokes a single graphql operation:
        // createExchangeMount.
        internal void ProcessRecord_CreateMount()
        {
            this._logger.name += " -CreateMount";
            // Create new graphql operation createExchangeMount
            InitMutationCreateExchangeMount();
        }

        // This parameter set invokes a single graphql operation:
        // createOnDemandExchangeBackup.
        internal void ProcessRecord_CreateOnDemandBackup()
        {
            this._logger.name += " -CreateOnDemandBackup";
            // Create new graphql operation createOnDemandExchangeBackup
            InitMutationCreateOnDemandExchangeBackup();
        }

        // This parameter set invokes a single graphql operation:
        // deleteExchangeSnapshotMount.
        internal void ProcessRecord_DeleteSnapshotMount()
        {
            this._logger.name += " -DeleteSnapshotMount";
            // Create new graphql operation deleteExchangeSnapshotMount
            InitMutationDeleteExchangeSnapshotMount();
        }


        // Create new GraphQL Mutation:
        // bulkUpdateExchangeDag(input: BulkUpdateExchangeDagInput!): V1BulkUpdateExchangeDagResponse!
        internal void InitMutationBulkUpdateExchangeDag()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkUpdateExchangeDagInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkUpdateExchangeDag",
                "($input: BulkUpdateExchangeDagInput!)",
                "V1BulkUpdateExchangeDagResponse",
                Mutation.BulkUpdateExchangeDag_ObjectFieldSpec,
                Mutation.BulkUpdateExchangeDagFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	dagUpdateProperties = @(
		@{
			# REQUIRED
			id = $someString
			# REQUIRED
			updateProperties = @{
				# REQUIRED
				backupPreference = $someExchangeBackupPreference # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ExchangeBackupPreference]) for enum values.
			}
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // createExchangeMount(input: CreateExchangeSnapshotMountInput!): AsyncRequestStatus!
        internal void InitMutationCreateExchangeMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateExchangeSnapshotMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateExchangeMount",
                "($input: CreateExchangeSnapshotMountInput!)",
                "AsyncRequestStatus",
                Mutation.CreateExchangeMount_ObjectFieldSpec,
                Mutation.CreateExchangeMountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	config = @{
		# OPTIONAL
		smbDomainName = $someString
		# OPTIONAL
		smbValidIps = @(
			$someString
		)
		# OPTIONAL
		smbValidUsers = @(
			$someString
		)
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // createOnDemandExchangeBackup(input: CreateOnDemandExchangeDatabaseBackupInput!): AsyncRequestStatus!
        internal void InitMutationCreateOnDemandExchangeBackup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateOnDemandExchangeDatabaseBackupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateOnDemandExchangeBackup",
                "($input: CreateOnDemandExchangeDatabaseBackupInput!)",
                "AsyncRequestStatus",
                Mutation.CreateOnDemandExchangeBackup_ObjectFieldSpec,
                Mutation.CreateOnDemandExchangeBackupFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		forceFullSnapshot = $someBoolean
		# OPTIONAL
		baseOnDemandSnapshotConfig = @{
			# OPTIONAL
			slaId = $someString
		}
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteExchangeSnapshotMount(input: DeleteExchangeSnapshotMountInput!): AsyncRequestStatus!
        internal void InitMutationDeleteExchangeSnapshotMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteExchangeSnapshotMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteExchangeSnapshotMount",
                "($input: DeleteExchangeSnapshotMountInput!)",
                "AsyncRequestStatus",
                Mutation.DeleteExchangeSnapshotMount_ObjectFieldSpec,
                Mutation.DeleteExchangeSnapshotMountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	id = $someString
}"
            );
        }


    } // class New_RscMutationExchange
}