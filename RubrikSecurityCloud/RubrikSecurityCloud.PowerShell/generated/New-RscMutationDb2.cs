// New-RscMutationDb2.cs
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
    /// Create a new RscQuery object for any of the 11
    /// operations in the 'Db2' API domain:
    /// AddInstance, CreateOnDemandBackup, DeleteDatabase, DeleteInstance, DiscoverInstance, DownloadSnapshot, DownloadSnapshotsForPointInTimeRecovery, ExpireDownloadedSnapshots, PatchDatabase, PatchInstance, or RefreshDatabase.
    /// </summary>
    /// <description>
    /// New-RscMutationDb2 creates a new
    /// mutation object for operations
    /// in the 'Db2' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 11 operations
    /// in the 'Db2' API domain. Select the operation this
    /// query is for by specifying the appropriate switch parameter;
    /// one of: -AddInstance, -CreateOnDemandBackup, -DeleteDatabase, -DeleteInstance, -DiscoverInstance, -DownloadSnapshot, -DownloadSnapshotsForPointInTimeRecovery, -ExpireDownloadedSnapshots, -PatchDatabase, -PatchInstance, -RefreshDatabase.
    /// Alternatively, you can specify the operation by setting the
    /// -Op parameter, for example: -Op AddInstance,
    /// which is equivalent to specifying -AddInstance.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationDb2 -AddInstance).Info().
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
    /// (New-RscMutationDb2 -AddInstance).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AddInstance operation
    /// of the 'Db2' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Db2
    /// # API Operation: AddInstance
    /// 
    /// $query = New-RscMutationDb2 -AddInstance
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	db2InstanceRequestConfig = @{
    /// 		# REQUIRED
    /// 		hostIds = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		instanceName = $someString
    /// 		# REQUIRED
    /// 		password = $someString
    /// 		# REQUIRED
    /// 		username = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddDb2InstanceReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateOnDemandBackup operation
    /// of the 'Db2' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Db2
    /// # API Operation: CreateOnDemandBackup
    /// 
    /// $query = New-RscMutationDb2 -CreateOnDemandBackup
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		slaId = $someString
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
    /// Runs the DeleteDatabase operation
    /// of the 'Db2' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Db2
    /// # API Operation: DeleteDatabase
    /// 
    /// $query = New-RscMutationDb2 -DeleteDatabase
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
    /// Runs the DeleteInstance operation
    /// of the 'Db2' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Db2
    /// # API Operation: DeleteInstance
    /// 
    /// $query = New-RscMutationDb2 -DeleteInstance
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
    /// Runs the DiscoverInstance operation
    /// of the 'Db2' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Db2
    /// # API Operation: DiscoverInstance
    /// 
    /// $query = New-RscMutationDb2 -DiscoverInstance
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
    /// Runs the DownloadSnapshot operation
    /// of the 'Db2' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Db2
    /// # API Operation: DownloadSnapshot
    /// 
    /// $query = New-RscMutationDb2 -DownloadSnapshot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	locationId = $someString
    /// 	# REQUIRED
    /// 	snapshotId = $someString
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
    /// Runs the DownloadSnapshotsForPointInTimeRecovery operation
    /// of the 'Db2' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Db2
    /// # API Operation: DownloadSnapshotsForPointInTimeRecovery
    /// 
    /// $query = New-RscMutationDb2 -DownloadSnapshotsForPointInTimeRecovery
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	downloadConfig = @{
    /// 		# OPTIONAL
    /// 		pointInTime = $someDateTime
    /// 		# REQUIRED
    /// 		preferredLocationId = $someString
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
    /// Runs the ExpireDownloadedSnapshots operation
    /// of the 'Db2' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Db2
    /// # API Operation: ExpireDownloadedSnapshots
    /// 
    /// $query = New-RscMutationDb2 -ExpireDownloadedSnapshots
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	afterTime = $someDateTime
    /// 	# OPTIONAL
    /// 	beforeTime = $someDateTime
    /// 	# OPTIONAL
    /// 	shouldExpireLogsOnly = $someBoolean
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
    /// Runs the PatchDatabase operation
    /// of the 'Db2' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Db2
    /// # API Operation: PatchDatabase
    /// 
    /// $query = New-RscMutationDb2 -PatchDatabase
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	db2DatabaseConfig = @{
    /// 		# OPTIONAL
    /// 		backupParallelism = $someInt
    /// 		# OPTIONAL
    /// 		backupSessions = $someInt
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PatchDb2DatabaseReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PatchInstance operation
    /// of the 'Db2' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Db2
    /// # API Operation: PatchInstance
    /// 
    /// $query = New-RscMutationDb2 -PatchInstance
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	db2InstanceRequestConfig = @{
    /// 		# OPTIONAL
    /// 		hostIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# OPTIONAL
    /// 		username = $someString
    /// 		# OPTIONAL
    /// 		instanceName = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PatchDb2InstanceReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RefreshDatabase operation
    /// of the 'Db2' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Db2
    /// # API Operation: RefreshDatabase
    /// 
    /// $query = New-RscMutationDb2 -RefreshDatabase
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
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationDb2",
        DefaultParameterSetName = "Instances")
    ]
    public class New_RscMutationDb2 : RscGqlPSCmdlet
    {
        
        [Parameter(
            ParameterSetName = "AddInstance",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'AddInstance' operation
in the 'Db2' API domain.
Description of the operation:
Mutation to add a new Db2 instance.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/adddb2instance.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AddInstance { get; set; }

        
        [Parameter(
            ParameterSetName = "CreateOnDemandBackup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreateOnDemandBackup' operation
in the 'Db2' API domain.
Description of the operation:
Create on demand database snapshot

Supported in v8.0+
Initiates a job to take an on demand, full snapshot of a specified Db2 database object. Use the GET /db2/db/request/{id} endpoint to monitor the progress of the job.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createondemanddb2backup.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreateOnDemandBackup { get; set; }

        
        [Parameter(
            ParameterSetName = "DeleteDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DeleteDatabase' operation
in the 'Db2' API domain.
Description of the operation:
Delete Db2 database

Supported in v8.1+
Deletes a Db2 database.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/deletedb2database.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DeleteDatabase { get; set; }

        
        [Parameter(
            ParameterSetName = "DeleteInstance",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DeleteInstance' operation
in the 'Db2' API domain.
Description of the operation:
Mutation to delete existing Db2 instance.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/deletedb2instance.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DeleteInstance { get; set; }

        
        [Parameter(
            ParameterSetName = "DiscoverInstance",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DiscoverInstance' operation
in the 'Db2' API domain.
Description of the operation:
On-demand discovery of a Db2 instance

Supported in v7.0+
Initiates an on-demand job to discover a Db2 instance.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/discoverdb2instance.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DiscoverInstance { get; set; }

        
        [Parameter(
            ParameterSetName = "DownloadSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DownloadSnapshot' operation
in the 'Db2' API domain.
Description of the operation:
Download Db2 database snapshot from archive

Supported in v8.0+
Downloads a specific Db2 database snapshot from the specified archival location.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/downloaddb2snapshot.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DownloadSnapshot { get; set; }

        
        [Parameter(
            ParameterSetName = "DownloadSnapshotsForPointInTimeRecovery",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DownloadSnapshotsForPointInTimeRecovery' operation
in the 'Db2' API domain.
Description of the operation:
Download Db2 database snapshots from archive for a point in time recovery

Supported in v8.0+
Downloads the most recent full snapshot and the log snapshots taken after the full snapshot, required for the point in time recovery of a Db2 database.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/downloaddb2snapshotsforpointintimerecovery.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DownloadSnapshotsForPointInTimeRecovery { get; set; }

        
        [Parameter(
            ParameterSetName = "ExpireDownloadedSnapshots",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'ExpireDownloadedSnapshots' operation
in the 'Db2' API domain.
Description of the operation:
Expire downloaded snapshots of a Db2 database

Supported in v8.0+
Requests an asynchronous job to expire all downloaded data and log snapshots. You can specify a begin time or an end time or both to provide a time range to expire only the downloaded data and log snapshots that were taken within the specified time range. The time is relative to when the snapshot was originally taken, not when it was downloaded. You can also configure a flag to expire only the log snapshots.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/expiredownloadeddb2snapshots.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter ExpireDownloadedSnapshots { get; set; }

        
        [Parameter(
            ParameterSetName = "PatchDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'PatchDatabase' operation
in the 'Db2' API domain.
Description of the operation:
Update a Db2 database

Supported in v9.0+
Updating a Db2 database involves modifying the metadata associated with the Db2 database using the provided input values.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/patchdb2database.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter PatchDatabase { get; set; }

        
        [Parameter(
            ParameterSetName = "PatchInstance",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'PatchInstance' operation
in the 'Db2' API domain.
Description of the operation:
Mutation to update an existing Db2 instance.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/patchdb2instance.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter PatchInstance { get; set; }

        
        [Parameter(
            ParameterSetName = "RefreshDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'RefreshDatabase' operation
in the 'Db2' API domain.
Description of the operation:
On-demand refresh of a Db2 database

Supported in v8.1+
Initiates an on-demand job to refresh a Db2 database. Currently, this is allowed only for Db2 HADR databases.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/refreshdb2database.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter RefreshDatabase { get; set; }



        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "AddInstance":
                        this.ProcessRecord_AddInstance();
                        break;
                    case "CreateOnDemandBackup":
                        this.ProcessRecord_CreateOnDemandBackup();
                        break;
                    case "DeleteDatabase":
                        this.ProcessRecord_DeleteDatabase();
                        break;
                    case "DeleteInstance":
                        this.ProcessRecord_DeleteInstance();
                        break;
                    case "DiscoverInstance":
                        this.ProcessRecord_DiscoverInstance();
                        break;
                    case "DownloadSnapshot":
                        this.ProcessRecord_DownloadSnapshot();
                        break;
                    case "DownloadSnapshotsForPointInTimeRecovery":
                        this.ProcessRecord_DownloadSnapshotsForPointInTimeRecovery();
                        break;
                    case "ExpireDownloadedSnapshots":
                        this.ProcessRecord_ExpireDownloadedSnapshots();
                        break;
                    case "PatchDatabase":
                        this.ProcessRecord_PatchDatabase();
                        break;
                    case "PatchInstance":
                        this.ProcessRecord_PatchInstance();
                        break;
                    case "RefreshDatabase":
                        this.ProcessRecord_RefreshDatabase();
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
        // addDb2Instance.
        internal void ProcessRecord_AddInstance()
        {
            this._logger.name += " -AddInstance";
            // Create new graphql operation addDb2Instance
            InitMutationAddDb2Instance();
        }

        // This parameter set invokes a single graphql operation:
        // createOnDemandDb2Backup.
        internal void ProcessRecord_CreateOnDemandBackup()
        {
            this._logger.name += " -CreateOnDemandBackup";
            // Create new graphql operation createOnDemandDb2Backup
            InitMutationCreateOnDemandDb2Backup();
        }

        // This parameter set invokes a single graphql operation:
        // deleteDb2Database.
        internal void ProcessRecord_DeleteDatabase()
        {
            this._logger.name += " -DeleteDatabase";
            // Create new graphql operation deleteDb2Database
            InitMutationDeleteDb2Database();
        }

        // This parameter set invokes a single graphql operation:
        // deleteDb2Instance.
        internal void ProcessRecord_DeleteInstance()
        {
            this._logger.name += " -DeleteInstance";
            // Create new graphql operation deleteDb2Instance
            InitMutationDeleteDb2Instance();
        }

        // This parameter set invokes a single graphql operation:
        // discoverDb2Instance.
        internal void ProcessRecord_DiscoverInstance()
        {
            this._logger.name += " -DiscoverInstance";
            // Create new graphql operation discoverDb2Instance
            InitMutationDiscoverDb2Instance();
        }

        // This parameter set invokes a single graphql operation:
        // downloadDb2Snapshot.
        internal void ProcessRecord_DownloadSnapshot()
        {
            this._logger.name += " -DownloadSnapshot";
            // Create new graphql operation downloadDb2Snapshot
            InitMutationDownloadDb2Snapshot();
        }

        // This parameter set invokes a single graphql operation:
        // downloadDb2SnapshotsForPointInTimeRecovery.
        internal void ProcessRecord_DownloadSnapshotsForPointInTimeRecovery()
        {
            this._logger.name += " -DownloadSnapshotsForPointInTimeRecovery";
            // Create new graphql operation downloadDb2SnapshotsForPointInTimeRecovery
            InitMutationDownloadDb2SnapshotsForPointInTimeRecovery();
        }

        // This parameter set invokes a single graphql operation:
        // expireDownloadedDb2Snapshots.
        internal void ProcessRecord_ExpireDownloadedSnapshots()
        {
            this._logger.name += " -ExpireDownloadedSnapshots";
            // Create new graphql operation expireDownloadedDb2Snapshots
            InitMutationExpireDownloadedDb2Snapshots();
        }

        // This parameter set invokes a single graphql operation:
        // patchDb2Database.
        internal void ProcessRecord_PatchDatabase()
        {
            this._logger.name += " -PatchDatabase";
            // Create new graphql operation patchDb2Database
            InitMutationPatchDb2Database();
        }

        // This parameter set invokes a single graphql operation:
        // patchDb2Instance.
        internal void ProcessRecord_PatchInstance()
        {
            this._logger.name += " -PatchInstance";
            // Create new graphql operation patchDb2Instance
            InitMutationPatchDb2Instance();
        }

        // This parameter set invokes a single graphql operation:
        // refreshDb2Database.
        internal void ProcessRecord_RefreshDatabase()
        {
            this._logger.name += " -RefreshDatabase";
            // Create new graphql operation refreshDb2Database
            InitMutationRefreshDb2Database();
        }


        // Create new GraphQL Mutation:
        // addDb2Instance(input: AddDb2InstanceInput!): AddDb2InstanceReply!
        internal void InitMutationAddDb2Instance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddDb2InstanceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddDb2Instance",
                "($input: AddDb2InstanceInput!)",
                "AddDb2InstanceReply",
                Mutation.AddDb2Instance_ObjectFieldSpec,
                Mutation.AddDb2InstanceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	db2InstanceRequestConfig = @{
		# REQUIRED
		hostIds = @(
			$someString
		)
		# REQUIRED
		instanceName = $someString
		# REQUIRED
		password = $someString
		# REQUIRED
		username = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createOnDemandDb2Backup(input: CreateOnDemandDb2BackupInput!): AsyncRequestStatus!
        internal void InitMutationCreateOnDemandDb2Backup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateOnDemandDb2BackupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateOnDemandDb2Backup",
                "($input: CreateOnDemandDb2BackupInput!)",
                "AsyncRequestStatus",
                Mutation.CreateOnDemandDb2Backup_ObjectFieldSpec,
                Mutation.CreateOnDemandDb2BackupFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	config = @{
		# OPTIONAL
		slaId = $someString
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteDb2Database(input: DeleteDb2DatabaseInput!): AsyncRequestStatus!
        internal void InitMutationDeleteDb2Database()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteDb2DatabaseInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteDb2Database",
                "($input: DeleteDb2DatabaseInput!)",
                "AsyncRequestStatus",
                Mutation.DeleteDb2Database_ObjectFieldSpec,
                Mutation.DeleteDb2DatabaseFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteDb2Instance(input: DeleteDb2InstanceInput!): AsyncRequestStatus!
        internal void InitMutationDeleteDb2Instance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteDb2InstanceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteDb2Instance",
                "($input: DeleteDb2InstanceInput!)",
                "AsyncRequestStatus",
                Mutation.DeleteDb2Instance_ObjectFieldSpec,
                Mutation.DeleteDb2InstanceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // discoverDb2Instance(input: DiscoverDb2InstanceInput!): AsyncRequestStatus!
        internal void InitMutationDiscoverDb2Instance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DiscoverDb2InstanceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDiscoverDb2Instance",
                "($input: DiscoverDb2InstanceInput!)",
                "AsyncRequestStatus",
                Mutation.DiscoverDb2Instance_ObjectFieldSpec,
                Mutation.DiscoverDb2InstanceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadDb2Snapshot(input: DownloadDb2SnapshotInput!): AsyncRequestStatus!
        internal void InitMutationDownloadDb2Snapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadDb2SnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadDb2Snapshot",
                "($input: DownloadDb2SnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadDb2Snapshot_ObjectFieldSpec,
                Mutation.DownloadDb2SnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	locationId = $someString
	# REQUIRED
	snapshotId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadDb2SnapshotsForPointInTimeRecovery(input: DownloadDb2SnapshotsForPointInTimeRecoveryInput!): AsyncRequestStatus!
        internal void InitMutationDownloadDb2SnapshotsForPointInTimeRecovery()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadDb2SnapshotsForPointInTimeRecoveryInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadDb2SnapshotsForPointInTimeRecovery",
                "($input: DownloadDb2SnapshotsForPointInTimeRecoveryInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadDb2SnapshotsForPointInTimeRecovery_ObjectFieldSpec,
                Mutation.DownloadDb2SnapshotsForPointInTimeRecoveryFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	downloadConfig = @{
		# OPTIONAL
		pointInTime = $someDateTime
		# REQUIRED
		preferredLocationId = $someString
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // expireDownloadedDb2Snapshots(input: ExpireDownloadedDb2SnapshotsInput!): AsyncRequestStatus!
        internal void InitMutationExpireDownloadedDb2Snapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExpireDownloadedDb2SnapshotsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExpireDownloadedDb2Snapshots",
                "($input: ExpireDownloadedDb2SnapshotsInput!)",
                "AsyncRequestStatus",
                Mutation.ExpireDownloadedDb2Snapshots_ObjectFieldSpec,
                Mutation.ExpireDownloadedDb2SnapshotsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	afterTime = $someDateTime
	# OPTIONAL
	beforeTime = $someDateTime
	# OPTIONAL
	shouldExpireLogsOnly = $someBoolean
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // patchDb2Database(input: PatchDb2DatabaseInput!): PatchDb2DatabaseReply!
        internal void InitMutationPatchDb2Database()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PatchDb2DatabaseInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPatchDb2Database",
                "($input: PatchDb2DatabaseInput!)",
                "PatchDb2DatabaseReply",
                Mutation.PatchDb2Database_ObjectFieldSpec,
                Mutation.PatchDb2DatabaseFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	db2DatabaseConfig = @{
		# OPTIONAL
		backupParallelism = $someInt
		# OPTIONAL
		backupSessions = $someInt
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // patchDb2Instance(input: PatchDb2InstanceInput!): PatchDb2InstanceReply!
        internal void InitMutationPatchDb2Instance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PatchDb2InstanceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPatchDb2Instance",
                "($input: PatchDb2InstanceInput!)",
                "PatchDb2InstanceReply",
                Mutation.PatchDb2Instance_ObjectFieldSpec,
                Mutation.PatchDb2InstanceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	db2InstanceRequestConfig = @{
		# OPTIONAL
		hostIds = @(
			$someString
		)
		# OPTIONAL
		password = $someString
		# OPTIONAL
		username = $someString
		# OPTIONAL
		instanceName = $someString
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // refreshDb2Database(input: RefreshDb2DatabaseInput!): AsyncRequestStatus!
        internal void InitMutationRefreshDb2Database()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshDb2DatabaseInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshDb2Database",
                "($input: RefreshDb2DatabaseInput!)",
                "AsyncRequestStatus",
                Mutation.RefreshDb2Database_ObjectFieldSpec,
                Mutation.RefreshDb2DatabaseFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }


    } // class New_RscMutationDb2
}