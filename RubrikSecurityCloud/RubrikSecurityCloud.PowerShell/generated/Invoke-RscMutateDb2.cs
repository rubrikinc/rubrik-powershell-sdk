// Invoke-RscMutateDb2.cs
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
    /// Db2 mutations
    /// </summary>
    /// <description>
    /// Invoke-RscMutateDb2 is a master cmdlet for Db2 work that can invoke any of the following subcommands: AddInstance, DeleteInstance, DiscoverInstance, PatchInstance, CreateOnDemandBackup, DownloadSnapshot, DownloadSnapshotsForPointInTimeRecovery, ExpireDownloadedSnapshots, PatchDatabase, RefreshDatabase, DeleteDatabase.
    /// </description>
    /// <example>
    /// <code>Invoke-RscMutateDb2 -AddInstance [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateDb2 -DeleteInstance [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateDb2 -DiscoverInstance [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateDb2 -PatchInstance [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateDb2 -CreateOnDemandBackup [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateDb2 -DownloadSnapshot [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateDb2 -DownloadSnapshotsForPointInTimeRecovery [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateDb2 -ExpireDownloadedSnapshots [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateDb2 -PatchDatabase [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateDb2 -RefreshDatabase [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateDb2 -DeleteDatabase [-Arg ..] [-Field ..]</code>
    /// </example>
    [Cmdlet(
        "Invoke",
        "RscMutateDb2",
        DefaultParameterSetName = "AddInstance")
    ]
    public class Invoke_RscMutateDb2 : RscPSCmdlet
    {
        
        /// <summary>
        /// AddInstance parameter set
        ///
        /// [GraphQL: addDb2Instance]
        /// </summary>
        [Parameter(
            ParameterSetName = "AddInstance",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Mutation to add a new Db2 instance.
[GraphQL: addDb2Instance]",
            Position = 0
        )]
        public SwitchParameter AddInstance { get; set; }

        
        /// <summary>
        /// DeleteInstance parameter set
        ///
        /// [GraphQL: deleteDb2Instance]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteInstance",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Mutation to delete existing Db2 instance.
[GraphQL: deleteDb2Instance]",
            Position = 0
        )]
        public SwitchParameter DeleteInstance { get; set; }

        
        /// <summary>
        /// DiscoverInstance parameter set
        ///
        /// [GraphQL: discoverDb2Instance]
        /// </summary>
        [Parameter(
            ParameterSetName = "DiscoverInstance",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"On-demand discovery of a Db2 instance

Supported in v7.0+
Initiates an on-demand job to discover a Db2 instance.
[GraphQL: discoverDb2Instance]",
            Position = 0
        )]
        public SwitchParameter DiscoverInstance { get; set; }

        
        /// <summary>
        /// PatchInstance parameter set
        ///
        /// [GraphQL: patchDb2Instance]
        /// </summary>
        [Parameter(
            ParameterSetName = "PatchInstance",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Mutation to update an existing Db2 instance.
[GraphQL: patchDb2Instance]",
            Position = 0
        )]
        public SwitchParameter PatchInstance { get; set; }

        
        /// <summary>
        /// CreateOnDemandBackup parameter set
        ///
        /// [GraphQL: createOnDemandDb2Backup]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateOnDemandBackup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create on demand database snapshot

Supported in v8.0+
Initiates a job to take an on demand, full snapshot of a specified Db2 database object. Use the GET /db2/db/request/{id} endpoint to monitor the progress of the job.
[GraphQL: createOnDemandDb2Backup]",
            Position = 0
        )]
        public SwitchParameter CreateOnDemandBackup { get; set; }

        
        /// <summary>
        /// DownloadSnapshot parameter set
        ///
        /// [GraphQL: downloadDb2Snapshot]
        /// </summary>
        [Parameter(
            ParameterSetName = "DownloadSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Download Db2 database snapshot from archive

Supported in v8.0+
Downloads a specific Db2 database snapshot from the specified archival location.
[GraphQL: downloadDb2Snapshot]",
            Position = 0
        )]
        public SwitchParameter DownloadSnapshot { get; set; }

        
        /// <summary>
        /// DownloadSnapshotsForPointInTimeRecovery parameter set
        ///
        /// [GraphQL: downloadDb2SnapshotsForPointInTimeRecovery]
        /// </summary>
        [Parameter(
            ParameterSetName = "DownloadSnapshotsForPointInTimeRecovery",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Download Db2 database snapshots from archive for a point in time recovery

Supported in v8.0+
Downloads the most recent full snapshot and the log snapshots taken after the full snapshot, required for the point in time recovery of a Db2 database.
[GraphQL: downloadDb2SnapshotsForPointInTimeRecovery]",
            Position = 0
        )]
        public SwitchParameter DownloadSnapshotsForPointInTimeRecovery { get; set; }

        
        /// <summary>
        /// ExpireDownloadedSnapshots parameter set
        ///
        /// [GraphQL: expireDownloadedDb2Snapshots]
        /// </summary>
        [Parameter(
            ParameterSetName = "ExpireDownloadedSnapshots",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Expire downloaded snapshots of a Db2 database

Supported in v8.0+
Requests an asynchronous job to expire all downloaded data and log snapshots. You can specify a begin time or an end time or both to provide a time range to expire only the downloaded data and log snapshots that were taken within the specified time range. The time is relative to when the snapshot was originally taken, not when it was downloaded. You can also configure a flag to expire only the log snapshots.
[GraphQL: expireDownloadedDb2Snapshots]",
            Position = 0
        )]
        public SwitchParameter ExpireDownloadedSnapshots { get; set; }

        
        /// <summary>
        /// PatchDatabase parameter set
        ///
        /// [GraphQL: patchDb2Database]
        /// </summary>
        [Parameter(
            ParameterSetName = "PatchDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update a Db2 database

Supported in v9.0+
Updating a Db2 database involves modifying the metadata associated with the Db2 database using the provided input values.
[GraphQL: patchDb2Database]",
            Position = 0
        )]
        public SwitchParameter PatchDatabase { get; set; }

        
        /// <summary>
        /// RefreshDatabase parameter set
        ///
        /// [GraphQL: refreshDb2Database]
        /// </summary>
        [Parameter(
            ParameterSetName = "RefreshDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"On-demand refresh of a Db2 database

Supported in v8.1+
Initiates an on-demand job to refresh a Db2 database. Currently, this is allowed only for Db2 HADR databases.
[GraphQL: refreshDb2Database]",
            Position = 0
        )]
        public SwitchParameter RefreshDatabase { get; set; }

        
        /// <summary>
        /// DeleteDatabase parameter set
        ///
        /// [GraphQL: deleteDb2Database]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete Db2 database

Supported in v8.1+
Deletes a Db2 database.
[GraphQL: deleteDb2Database]",
            Position = 0
        )]
        public SwitchParameter DeleteDatabase { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "AddInstance":
                        this.ProcessRecord_AddInstance();
                        break;
                    case "DeleteInstance":
                        this.ProcessRecord_DeleteInstance();
                        break;
                    case "DiscoverInstance":
                        this.ProcessRecord_DiscoverInstance();
                        break;
                    case "PatchInstance":
                        this.ProcessRecord_PatchInstance();
                        break;
                    case "CreateOnDemandBackup":
                        this.ProcessRecord_CreateOnDemandBackup();
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
                    case "RefreshDatabase":
                        this.ProcessRecord_RefreshDatabase();
                        break;
                    case "DeleteDatabase":
                        this.ProcessRecord_DeleteDatabase();
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
        // addDb2Instance.
        internal void ProcessRecord_AddInstance()
        {
            this._logger.name += " -AddInstance";
            // Invoke graphql operation addDb2Instance
            InvokeMutationAddDb2Instance();
        }

        // This parameter set invokes a single graphql operation:
        // deleteDb2Instance.
        internal void ProcessRecord_DeleteInstance()
        {
            this._logger.name += " -DeleteInstance";
            // Invoke graphql operation deleteDb2Instance
            InvokeMutationDeleteDb2Instance();
        }

        // This parameter set invokes a single graphql operation:
        // discoverDb2Instance.
        internal void ProcessRecord_DiscoverInstance()
        {
            this._logger.name += " -DiscoverInstance";
            // Invoke graphql operation discoverDb2Instance
            InvokeMutationDiscoverDb2Instance();
        }

        // This parameter set invokes a single graphql operation:
        // patchDb2Instance.
        internal void ProcessRecord_PatchInstance()
        {
            this._logger.name += " -PatchInstance";
            // Invoke graphql operation patchDb2Instance
            InvokeMutationPatchDb2Instance();
        }

        // This parameter set invokes a single graphql operation:
        // createOnDemandDb2Backup.
        internal void ProcessRecord_CreateOnDemandBackup()
        {
            this._logger.name += " -CreateOnDemandBackup";
            // Invoke graphql operation createOnDemandDb2Backup
            InvokeMutationCreateOnDemandDb2Backup();
        }

        // This parameter set invokes a single graphql operation:
        // downloadDb2Snapshot.
        internal void ProcessRecord_DownloadSnapshot()
        {
            this._logger.name += " -DownloadSnapshot";
            // Invoke graphql operation downloadDb2Snapshot
            InvokeMutationDownloadDb2Snapshot();
        }

        // This parameter set invokes a single graphql operation:
        // downloadDb2SnapshotsForPointInTimeRecovery.
        internal void ProcessRecord_DownloadSnapshotsForPointInTimeRecovery()
        {
            this._logger.name += " -DownloadSnapshotsForPointInTimeRecovery";
            // Invoke graphql operation downloadDb2SnapshotsForPointInTimeRecovery
            InvokeMutationDownloadDb2SnapshotsForPointInTimeRecovery();
        }

        // This parameter set invokes a single graphql operation:
        // expireDownloadedDb2Snapshots.
        internal void ProcessRecord_ExpireDownloadedSnapshots()
        {
            this._logger.name += " -ExpireDownloadedSnapshots";
            // Invoke graphql operation expireDownloadedDb2Snapshots
            InvokeMutationExpireDownloadedDb2Snapshots();
        }

        // This parameter set invokes a single graphql operation:
        // patchDb2Database.
        internal void ProcessRecord_PatchDatabase()
        {
            this._logger.name += " -PatchDatabase";
            // Invoke graphql operation patchDb2Database
            InvokeMutationPatchDb2Database();
        }

        // This parameter set invokes a single graphql operation:
        // refreshDb2Database.
        internal void ProcessRecord_RefreshDatabase()
        {
            this._logger.name += " -RefreshDatabase";
            // Invoke graphql operation refreshDb2Database
            InvokeMutationRefreshDb2Database();
        }

        // This parameter set invokes a single graphql operation:
        // deleteDb2Database.
        internal void ProcessRecord_DeleteDatabase()
        {
            this._logger.name += " -DeleteDatabase";
            // Invoke graphql operation deleteDb2Database
            InvokeMutationDeleteDb2Database();
        }


        // Invoke GraphQL Mutation:
        // addDb2Instance(input: AddDb2InstanceInput!): AddDb2InstanceReply!
        internal void InvokeMutationAddDb2Instance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddDb2InstanceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddDb2Instance",
                "($input: AddDb2InstanceInput!)",
                "AddDb2InstanceReply"
                );
            AddDb2InstanceReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AddDb2InstanceReply)this.Field;
            }
            string fieldSpecDoc = Mutation.AddDb2Instance(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	db2InstanceRequestConfig = @{
		# REQUIRED
		hostIds = @(
			<System.String>
		)
		# REQUIRED
		instanceName = <System.String>
		# REQUIRED
		password = <System.String>
		# REQUIRED
		username = <System.String>
	}
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // deleteDb2Instance(input: DeleteDb2InstanceInput!): AsyncRequestStatus!
        internal void InvokeMutationDeleteDb2Instance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteDb2InstanceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteDb2Instance",
                "($input: DeleteDb2InstanceInput!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.DeleteDb2Instance(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // discoverDb2Instance(input: DiscoverDb2InstanceInput!): AsyncRequestStatus!
        internal void InvokeMutationDiscoverDb2Instance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DiscoverDb2InstanceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDiscoverDb2Instance",
                "($input: DiscoverDb2InstanceInput!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.DiscoverDb2Instance(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // patchDb2Instance(input: PatchDb2InstanceInput!): PatchDb2InstanceReply!
        internal void InvokeMutationPatchDb2Instance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PatchDb2InstanceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPatchDb2Instance",
                "($input: PatchDb2InstanceInput!)",
                "PatchDb2InstanceReply"
                );
            PatchDb2InstanceReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (PatchDb2InstanceReply)this.Field;
            }
            string fieldSpecDoc = Mutation.PatchDb2Instance(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	db2InstanceRequestConfig = @{
		# OPTIONAL
		hostIds = @(
			<System.String>
		)
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		username = <System.String>
		# OPTIONAL
		instanceName = <System.String>
	}
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // createOnDemandDb2Backup(input: CreateOnDemandDb2BackupInput!): AsyncRequestStatus!
        internal void InvokeMutationCreateOnDemandDb2Backup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateOnDemandDb2BackupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateOnDemandDb2Backup",
                "($input: CreateOnDemandDb2BackupInput!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.CreateOnDemandDb2Backup(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	config = @{
		# OPTIONAL
		slaId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // downloadDb2Snapshot(input: DownloadDb2SnapshotInput!): AsyncRequestStatus!
        internal void InvokeMutationDownloadDb2Snapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadDb2SnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadDb2Snapshot",
                "($input: DownloadDb2SnapshotInput!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.DownloadDb2Snapshot(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	locationId = <System.String>
	# REQUIRED
	snapshotId = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // downloadDb2SnapshotsForPointInTimeRecovery(input: DownloadDb2SnapshotsForPointInTimeRecoveryInput!): AsyncRequestStatus!
        internal void InvokeMutationDownloadDb2SnapshotsForPointInTimeRecovery()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadDb2SnapshotsForPointInTimeRecoveryInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadDb2SnapshotsForPointInTimeRecovery",
                "($input: DownloadDb2SnapshotsForPointInTimeRecoveryInput!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.DownloadDb2SnapshotsForPointInTimeRecovery(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	downloadConfig = @{
		# OPTIONAL
		pointInTime = <DateTime>
		# REQUIRED
		preferredLocationId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // expireDownloadedDb2Snapshots(input: ExpireDownloadedDb2SnapshotsInput!): AsyncRequestStatus!
        internal void InvokeMutationExpireDownloadedDb2Snapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExpireDownloadedDb2SnapshotsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExpireDownloadedDb2Snapshots",
                "($input: ExpireDownloadedDb2SnapshotsInput!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.ExpireDownloadedDb2Snapshots(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	afterTime = <DateTime>
	# OPTIONAL
	beforeTime = <DateTime>
	# OPTIONAL
	shouldExpireLogsOnly = <System.Boolean>
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // patchDb2Database(input: PatchDb2DatabaseInput!): PatchDb2DatabaseReply!
        internal void InvokeMutationPatchDb2Database()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PatchDb2DatabaseInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPatchDb2Database",
                "($input: PatchDb2DatabaseInput!)",
                "PatchDb2DatabaseReply"
                );
            PatchDb2DatabaseReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (PatchDb2DatabaseReply)this.Field;
            }
            string fieldSpecDoc = Mutation.PatchDb2Database(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	db2DatabaseConfig = @{
		# OPTIONAL
		backupParallelism = <System.Int32>
		# OPTIONAL
		backupSessions = <System.Int32>
	}
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // refreshDb2Database(input: RefreshDb2DatabaseInput!): AsyncRequestStatus!
        internal void InvokeMutationRefreshDb2Database()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshDb2DatabaseInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshDb2Database",
                "($input: RefreshDb2DatabaseInput!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.RefreshDb2Database(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // deleteDb2Database(input: DeleteDb2DatabaseInput!): AsyncRequestStatus!
        internal void InvokeMutationDeleteDb2Database()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteDb2DatabaseInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteDb2Database",
                "($input: DeleteDb2DatabaseInput!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.DeleteDb2Database(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }


    } // class Invoke_RscMutateDb2
}