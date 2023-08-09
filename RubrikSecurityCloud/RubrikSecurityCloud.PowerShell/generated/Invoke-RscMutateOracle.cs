// Invoke-RscMutateOracle.cs
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
        "RscMutateOracle",
        DefaultParameterSetName = "DeleteMount")
    ]
    public class Invoke_RscMutateOracle : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // BulkUpdateHosts parameter set
        //
        // [GraphQL: bulkUpdateOracleHosts]
        //
        [Parameter(
            ParameterSetName = "BulkUpdateHosts",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update Oracle Hosts

Supported in v5.2+
Update properties to Oracle Host objects.
[GraphQL: bulkUpdateOracleHosts]",
            Position = 0
        )]
        public SwitchParameter BulkUpdateHosts { get; set; }

        
        // -------------------------------------------------------------------
        // RefreshDatabase parameter set
        //
        // [GraphQL: refreshOracleDatabase]
        //
        [Parameter(
            ParameterSetName = "RefreshDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refresh an Oracle database

Supported in v6.0+
Starts an asynchronous job to refresh the Oracle database metadata by querying the database instances on all the underlying hosts.
[GraphQL: refreshOracleDatabase]",
            Position = 0
        )]
        public SwitchParameter RefreshDatabase { get; set; }

        
        // -------------------------------------------------------------------
        // UpdateDataGuardGroup parameter set
        //
        // [GraphQL: updateOracleDataGuardGroup]
        //
        [Parameter(
            ParameterSetName = "UpdateDataGuardGroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update an Oracle Data Guard group

Supported in v6.0+
Update properties of an Oracle Data Guard group object.
[GraphQL: updateOracleDataGuardGroup]",
            Position = 0
        )]
        public SwitchParameter UpdateDataGuardGroup { get; set; }

        
        // -------------------------------------------------------------------
        // DeleteAllDatabaseSnapshots parameter set
        //
        // [GraphQL: deleteAllOracleDatabaseSnapshots]
        //
        [Parameter(
            ParameterSetName = "DeleteAllDatabaseSnapshots",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete Oracle database snapshots

Supported in v5.0+
Delete all snapshots for a specified Oracle database object. For the operation to succeed the referenced database must not be assigned to an SLA Domain.
[GraphQL: deleteAllOracleDatabaseSnapshots]",
            Position = 0
        )]
        public SwitchParameter DeleteAllDatabaseSnapshots { get; set; }

        
        // -------------------------------------------------------------------
        // TakeOnDemandDatabaseSnapshot parameter set
        //
        // [GraphQL: takeOnDemandOracleDatabaseSnapshot]
        //
        [Parameter(
            ParameterSetName = "TakeOnDemandDatabaseSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"On-demand backup of an Oracle database

Supported in v5.0+
Create an asynchronous job for an on-demand snapshot of an Oracle database. The response includes an ID for the asynchronous job request. To see the status of the request, poll /oracle/request/{id}.
[GraphQL: takeOnDemandOracleDatabaseSnapshot]",
            Position = 0
        )]
        public SwitchParameter TakeOnDemandDatabaseSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // TakeOnDemandLogSnapshot parameter set
        //
        // [GraphQL: takeOnDemandOracleLogSnapshot]
        //
        [Parameter(
            ParameterSetName = "TakeOnDemandLogSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"On-demand log backup for an Oracle database log

Supported in v5.0+
Create an asynchronous job for an on-demand backup of an Oracle database log. The response includes an ID for the asynchronous job request.  To see the status of the request, poll /oracle/request/{id}.
[GraphQL: takeOnDemandOracleLogSnapshot]",
            Position = 0
        )]
        public SwitchParameter TakeOnDemandLogSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // BulkUpdateRacs parameter set
        //
        // [GraphQL: bulkUpdateOracleRacs]
        //
        [Parameter(
            ParameterSetName = "BulkUpdateRacs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update Oracle RACs

Supported in v5.2+
Update the properties of the objects that represent the specified Oracle RAC.
[GraphQL: bulkUpdateOracleRacs]",
            Position = 0
        )]
        public SwitchParameter BulkUpdateRacs { get; set; }

        
        // -------------------------------------------------------------------
        // ExportTablespace parameter set
        //
        // [GraphQL: exportOracleTablespace]
        //
        [Parameter(
            ParameterSetName = "ExportTablespace",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Export an Oracle tablespace

Supported in v5.0+
Request an asynchronous job to export an Oracle tablespace from a specified snapshot or timestamp.
[GraphQL: exportOracleTablespace]",
            Position = 0
        )]
        public SwitchParameter ExportTablespace { get; set; }

        
        // -------------------------------------------------------------------
        // ValidateAcoFile parameter set
        //
        // [GraphQL: validateOracleAcoFile]
        //
        [Parameter(
            ParameterSetName = "ValidateAcoFile",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Validate Oracle ACO file

Supported in v6.0+
Validate the provided Oracle ACO (Advanced Cloning Options) file.
[GraphQL: validateOracleAcoFile]",
            Position = 0
        )]
        public SwitchParameter ValidateAcoFile { get; set; }

        
        // -------------------------------------------------------------------
        // ValidateDatabaseBackups parameter set
        //
        // [GraphQL: validateOracleDatabaseBackups]
        //
        [Parameter(
            ParameterSetName = "ValidateDatabaseBackups",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Validate Oracle database backups

Supported in v5.3+
Queue a job to validate Oracle backups for a database snapshot or a specified timestamp.
[GraphQL: validateOracleDatabaseBackups]",
            Position = 0
        )]
        public SwitchParameter ValidateDatabaseBackups { get; set; }

        
        // -------------------------------------------------------------------
        // BulkUpdateDatabases parameter set
        //
        // [GraphQL: bulkUpdateOracleDatabases]
        //
        [Parameter(
            ParameterSetName = "BulkUpdateDatabases",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update Oracle Databases

Supported in v5.2+
Update the properties of the objects that represent the specified Oracle Databases.
[GraphQL: bulkUpdateOracleDatabases]",
            Position = 0
        )]
        public SwitchParameter BulkUpdateDatabases { get; set; }

        
        // -------------------------------------------------------------------
        // InstantRecoverSnapshot parameter set
        //
        // [GraphQL: instantRecoverOracleSnapshot]
        //
        [Parameter(
            ParameterSetName = "InstantRecoverSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Instant recovery of a database

Supported in v5.0+
Creates an instant recover request that restores a target database from the given snapshot.
[GraphQL: instantRecoverOracleSnapshot]",
            Position = 0
        )]
        public SwitchParameter InstantRecoverSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // MountDatabase parameter set
        //
        // [GraphQL: mountOracleDatabase]
        //
        [Parameter(
            ParameterSetName = "MountDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Live Mount an Oracle database snapshot

Supported in v5.0+
Create an asynchronous job to Live Mount an Oracle database from a snapshot.
[GraphQL: mountOracleDatabase]",
            Position = 0
        )]
        public SwitchParameter MountDatabase { get; set; }

        
        // -------------------------------------------------------------------
        // ExportDatabase parameter set
        //
        // [GraphQL: exportOracleDatabase]
        //
        [Parameter(
            ParameterSetName = "ExportDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Export an Oracle database

Supported in v5.0+
Request an asynchronous job to export an Oracle database from a specified snapshot or timestamp.
[GraphQL: exportOracleDatabase]",
            Position = 0
        )]
        public SwitchParameter ExportDatabase { get; set; }

        
        // -------------------------------------------------------------------
        // CreatePdbRestore parameter set
        //
        // [GraphQL: createOraclePdbRestore]
        //
        [Parameter(
            ParameterSetName = "CreatePdbRestore",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Restore PDBs on an Oracle database

Supported in v8.0+
Initiates an asynchronous request to restore PDBs on an Oracle database from a specified snapshot or timestamp.
[GraphQL: createOraclePdbRestore]",
            Position = 0
        )]
        public SwitchParameter CreatePdbRestore { get; set; }

        
        // -------------------------------------------------------------------
        // DownloadDatabaseSnapshot parameter set
        //
        // [GraphQL: downloadOracleDatabaseSnapshot]
        //
        [Parameter(
            ParameterSetName = "DownloadDatabaseSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Download Oracle snapshot from cloud

Supported in v5.0+
Create an asynchronous job to download an Oracle database snapshot and associated logs using the snapshot ID. The response includes the ID of the asynchronous job request. To see the status of the request, poll /oracle/request/{id}.
[GraphQL: downloadOracleDatabaseSnapshot]",
            Position = 0
        )]
        public SwitchParameter DownloadDatabaseSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // DeleteMount parameter set
        //
        // [GraphQL: deleteOracleMount]
        //
        [Parameter(
            ParameterSetName = "DeleteMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete an Oracle database Live Mount

Supported in v5.0+
Request an asynchronous job to delete a specified Live Mount of an Oracle database snapshot. Poll the job status by using /oracle/request/{id}.
[GraphQL: deleteOracleMount]",
            Position = 0
        )]
        public SwitchParameter DeleteMount { get; set; }

        
        // -------------------------------------------------------------------
        // RestoreLogs parameter set
        //
        // [GraphQL: restoreOracleLogs]
        //
        [Parameter(
            ParameterSetName = "RestoreLogs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Restore archive logs of an Oracle database

Supported in v6.0+
v6.0: Create an asynchronous job to restore archive logs of an Oracle database.
v7.0+: Starts an asynchronous job to restore archive logs of an Oracle database.
[GraphQL: restoreOracleLogs]",
            Position = 0
        )]
        public SwitchParameter RestoreLogs { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "BulkUpdateHosts":
                        this.ProcessRecord_BulkUpdateHosts();
                        break;
                    case "RefreshDatabase":
                        this.ProcessRecord_RefreshDatabase();
                        break;
                    case "UpdateDataGuardGroup":
                        this.ProcessRecord_UpdateDataGuardGroup();
                        break;
                    case "DeleteAllDatabaseSnapshots":
                        this.ProcessRecord_DeleteAllDatabaseSnapshots();
                        break;
                    case "TakeOnDemandDatabaseSnapshot":
                        this.ProcessRecord_TakeOnDemandDatabaseSnapshot();
                        break;
                    case "TakeOnDemandLogSnapshot":
                        this.ProcessRecord_TakeOnDemandLogSnapshot();
                        break;
                    case "BulkUpdateRacs":
                        this.ProcessRecord_BulkUpdateRacs();
                        break;
                    case "ExportTablespace":
                        this.ProcessRecord_ExportTablespace();
                        break;
                    case "ValidateAcoFile":
                        this.ProcessRecord_ValidateAcoFile();
                        break;
                    case "ValidateDatabaseBackups":
                        this.ProcessRecord_ValidateDatabaseBackups();
                        break;
                    case "BulkUpdateDatabases":
                        this.ProcessRecord_BulkUpdateDatabases();
                        break;
                    case "InstantRecoverSnapshot":
                        this.ProcessRecord_InstantRecoverSnapshot();
                        break;
                    case "MountDatabase":
                        this.ProcessRecord_MountDatabase();
                        break;
                    case "ExportDatabase":
                        this.ProcessRecord_ExportDatabase();
                        break;
                    case "CreatePdbRestore":
                        this.ProcessRecord_CreatePdbRestore();
                        break;
                    case "DownloadDatabaseSnapshot":
                        this.ProcessRecord_DownloadDatabaseSnapshot();
                        break;
                    case "DeleteMount":
                        this.ProcessRecord_DeleteMount();
                        break;
                    case "RestoreLogs":
                        this.ProcessRecord_RestoreLogs();
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
        // bulkUpdateOracleHosts.
        protected void ProcessRecord_BulkUpdateHosts()
        {
            this._logger.name += " -BulkUpdateHosts";
            // Invoke graphql operation bulkUpdateOracleHosts
            InvokeMutationBulkUpdateOracleHosts();
        }

        // This parameter set invokes a single graphql operation:
        // refreshOracleDatabase.
        protected void ProcessRecord_RefreshDatabase()
        {
            this._logger.name += " -RefreshDatabase";
            // Invoke graphql operation refreshOracleDatabase
            InvokeMutationRefreshOracleDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // updateOracleDataGuardGroup.
        protected void ProcessRecord_UpdateDataGuardGroup()
        {
            this._logger.name += " -UpdateDataGuardGroup";
            // Invoke graphql operation updateOracleDataGuardGroup
            InvokeMutationUpdateOracleDataGuardGroup();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAllOracleDatabaseSnapshots.
        protected void ProcessRecord_DeleteAllDatabaseSnapshots()
        {
            this._logger.name += " -DeleteAllDatabaseSnapshots";
            // Invoke graphql operation deleteAllOracleDatabaseSnapshots
            InvokeMutationDeleteAllOracleDatabaseSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // takeOnDemandOracleDatabaseSnapshot.
        protected void ProcessRecord_TakeOnDemandDatabaseSnapshot()
        {
            this._logger.name += " -TakeOnDemandDatabaseSnapshot";
            // Invoke graphql operation takeOnDemandOracleDatabaseSnapshot
            InvokeMutationTakeOnDemandOracleDatabaseSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // takeOnDemandOracleLogSnapshot.
        protected void ProcessRecord_TakeOnDemandLogSnapshot()
        {
            this._logger.name += " -TakeOnDemandLogSnapshot";
            // Invoke graphql operation takeOnDemandOracleLogSnapshot
            InvokeMutationTakeOnDemandOracleLogSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // bulkUpdateOracleRacs.
        protected void ProcessRecord_BulkUpdateRacs()
        {
            this._logger.name += " -BulkUpdateRacs";
            // Invoke graphql operation bulkUpdateOracleRacs
            InvokeMutationBulkUpdateOracleRacs();
        }

        // This parameter set invokes a single graphql operation:
        // exportOracleTablespace.
        protected void ProcessRecord_ExportTablespace()
        {
            this._logger.name += " -ExportTablespace";
            // Invoke graphql operation exportOracleTablespace
            InvokeMutationExportOracleTablespace();
        }

        // This parameter set invokes a single graphql operation:
        // validateOracleAcoFile.
        protected void ProcessRecord_ValidateAcoFile()
        {
            this._logger.name += " -ValidateAcoFile";
            // Invoke graphql operation validateOracleAcoFile
            InvokeMutationValidateOracleAcoFile();
        }

        // This parameter set invokes a single graphql operation:
        // validateOracleDatabaseBackups.
        protected void ProcessRecord_ValidateDatabaseBackups()
        {
            this._logger.name += " -ValidateDatabaseBackups";
            // Invoke graphql operation validateOracleDatabaseBackups
            InvokeMutationValidateOracleDatabaseBackups();
        }

        // This parameter set invokes a single graphql operation:
        // bulkUpdateOracleDatabases.
        protected void ProcessRecord_BulkUpdateDatabases()
        {
            this._logger.name += " -BulkUpdateDatabases";
            // Invoke graphql operation bulkUpdateOracleDatabases
            InvokeMutationBulkUpdateOracleDatabases();
        }

        // This parameter set invokes a single graphql operation:
        // instantRecoverOracleSnapshot.
        protected void ProcessRecord_InstantRecoverSnapshot()
        {
            this._logger.name += " -InstantRecoverSnapshot";
            // Invoke graphql operation instantRecoverOracleSnapshot
            InvokeMutationInstantRecoverOracleSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // mountOracleDatabase.
        protected void ProcessRecord_MountDatabase()
        {
            this._logger.name += " -MountDatabase";
            // Invoke graphql operation mountOracleDatabase
            InvokeMutationMountOracleDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // exportOracleDatabase.
        protected void ProcessRecord_ExportDatabase()
        {
            this._logger.name += " -ExportDatabase";
            // Invoke graphql operation exportOracleDatabase
            InvokeMutationExportOracleDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // createOraclePdbRestore.
        protected void ProcessRecord_CreatePdbRestore()
        {
            this._logger.name += " -CreatePdbRestore";
            // Invoke graphql operation createOraclePdbRestore
            InvokeMutationCreateOraclePdbRestore();
        }

        // This parameter set invokes a single graphql operation:
        // downloadOracleDatabaseSnapshot.
        protected void ProcessRecord_DownloadDatabaseSnapshot()
        {
            this._logger.name += " -DownloadDatabaseSnapshot";
            // Invoke graphql operation downloadOracleDatabaseSnapshot
            InvokeMutationDownloadOracleDatabaseSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // deleteOracleMount.
        protected void ProcessRecord_DeleteMount()
        {
            this._logger.name += " -DeleteMount";
            // Invoke graphql operation deleteOracleMount
            InvokeMutationDeleteOracleMount();
        }

        // This parameter set invokes a single graphql operation:
        // restoreOracleLogs.
        protected void ProcessRecord_RestoreLogs()
        {
            this._logger.name += " -RestoreLogs";
            // Invoke graphql operation restoreOracleLogs
            InvokeMutationRestoreOracleLogs();
        }


        // Invoke GraphQL Mutation:
        // bulkUpdateOracleHosts(input: BulkUpdateOracleHostsInput!): BulkUpdateOracleHostsReply!
        protected void InvokeMutationBulkUpdateOracleHosts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkUpdateOracleHostsInput!"),
            };
            BulkUpdateOracleHostsReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BulkUpdateOracleHostsReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BulkUpdateOracleHostsReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.BulkUpdateOracleHosts(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationBulkUpdateOracleHosts",
                "($input: BulkUpdateOracleHostsInput!)",
                fieldSpecDoc,
                "BulkUpdateOracleHostsReply"
            );
        }

        // Invoke GraphQL Mutation:
        // refreshOracleDatabase(input: RefreshOracleDatabaseInput!): AsyncRequestStatus!
        protected void InvokeMutationRefreshOracleDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshOracleDatabaseInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.RefreshOracleDatabase(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationRefreshOracleDatabase",
                "($input: RefreshOracleDatabaseInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // updateOracleDataGuardGroup(input: UpdateOracleDataGuardGroupInput!): OracleDbDetail!
        protected void InvokeMutationUpdateOracleDataGuardGroup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateOracleDataGuardGroupInput!"),
            };
            OracleDbDetail? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (OracleDbDetail)psObject.BaseObject;
                } else {
                    fieldSpecObj = (OracleDbDetail)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpdateOracleDataGuardGroup(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpdateOracleDataGuardGroup",
                "($input: UpdateOracleDataGuardGroupInput!)",
                fieldSpecDoc,
                "OracleDbDetail"
            );
        }

        // Invoke GraphQL Mutation:
        // deleteAllOracleDatabaseSnapshots(input: DeleteAllOracleDatabaseSnapshotsInput!): Void
        protected void InvokeMutationDeleteAllOracleDatabaseSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAllOracleDatabaseSnapshotsInput!"),
            };
            System.String? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (System.String)psObject.BaseObject;
                } else {
                    fieldSpecObj = (System.String)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DeleteAllOracleDatabaseSnapshots(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDeleteAllOracleDatabaseSnapshots",
                "($input: DeleteAllOracleDatabaseSnapshotsInput!)",
                fieldSpecDoc,
                "System.String"
            );
        }

        // Invoke GraphQL Mutation:
        // takeOnDemandOracleDatabaseSnapshot(input: TakeOnDemandOracleDatabaseSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationTakeOnDemandOracleDatabaseSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "TakeOnDemandOracleDatabaseSnapshotInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.TakeOnDemandOracleDatabaseSnapshot(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationTakeOnDemandOracleDatabaseSnapshot",
                "($input: TakeOnDemandOracleDatabaseSnapshotInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // takeOnDemandOracleLogSnapshot(input: TakeOnDemandOracleLogSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationTakeOnDemandOracleLogSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "TakeOnDemandOracleLogSnapshotInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.TakeOnDemandOracleLogSnapshot(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationTakeOnDemandOracleLogSnapshot",
                "($input: TakeOnDemandOracleLogSnapshotInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // bulkUpdateOracleRacs(input: BulkUpdateOracleRacsInput!): BulkUpdateOracleRacsReply!
        protected void InvokeMutationBulkUpdateOracleRacs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkUpdateOracleRacsInput!"),
            };
            BulkUpdateOracleRacsReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BulkUpdateOracleRacsReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BulkUpdateOracleRacsReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.BulkUpdateOracleRacs(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationBulkUpdateOracleRacs",
                "($input: BulkUpdateOracleRacsInput!)",
                fieldSpecDoc,
                "BulkUpdateOracleRacsReply"
            );
        }

        // Invoke GraphQL Mutation:
        // exportOracleTablespace(input: ExportOracleTablespaceInput!): AsyncRequestStatus!
        protected void InvokeMutationExportOracleTablespace()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportOracleTablespaceInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.ExportOracleTablespace(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationExportOracleTablespace",
                "($input: ExportOracleTablespaceInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // validateOracleAcoFile(input: ValidateOracleAcoFileInput!): ValidateOracleAcoFileReply!
        protected void InvokeMutationValidateOracleAcoFile()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ValidateOracleAcoFileInput!"),
            };
            ValidateOracleAcoFileReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ValidateOracleAcoFileReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ValidateOracleAcoFileReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.ValidateOracleAcoFile(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationValidateOracleAcoFile",
                "($input: ValidateOracleAcoFileInput!)",
                fieldSpecDoc,
                "ValidateOracleAcoFileReply"
            );
        }

        // Invoke GraphQL Mutation:
        // validateOracleDatabaseBackups(input: ValidateOracleDatabaseBackupsInput!): AsyncRequestStatus!
        protected void InvokeMutationValidateOracleDatabaseBackups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ValidateOracleDatabaseBackupsInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.ValidateOracleDatabaseBackups(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationValidateOracleDatabaseBackups",
                "($input: ValidateOracleDatabaseBackupsInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // bulkUpdateOracleDatabases(input: BulkUpdateOracleDatabasesInput!): BulkUpdateOracleDatabasesReply!
        protected void InvokeMutationBulkUpdateOracleDatabases()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkUpdateOracleDatabasesInput!"),
            };
            BulkUpdateOracleDatabasesReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BulkUpdateOracleDatabasesReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BulkUpdateOracleDatabasesReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.BulkUpdateOracleDatabases(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationBulkUpdateOracleDatabases",
                "($input: BulkUpdateOracleDatabasesInput!)",
                fieldSpecDoc,
                "BulkUpdateOracleDatabasesReply"
            );
        }

        // Invoke GraphQL Mutation:
        // instantRecoverOracleSnapshot(input: InstantRecoverOracleSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationInstantRecoverOracleSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "InstantRecoverOracleSnapshotInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.InstantRecoverOracleSnapshot(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationInstantRecoverOracleSnapshot",
                "($input: InstantRecoverOracleSnapshotInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // mountOracleDatabase(input: MountOracleDatabaseInput!): AsyncRequestStatus!
        protected void InvokeMutationMountOracleDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MountOracleDatabaseInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.MountOracleDatabase(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationMountOracleDatabase",
                "($input: MountOracleDatabaseInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // exportOracleDatabase(input: ExportOracleDatabaseInput!): AsyncRequestStatus!
        protected void InvokeMutationExportOracleDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportOracleDatabaseInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.ExportOracleDatabase(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationExportOracleDatabase",
                "($input: ExportOracleDatabaseInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // createOraclePdbRestore(input: CreateOraclePdbRestoreInput!): AsyncRequestStatus!
        protected void InvokeMutationCreateOraclePdbRestore()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateOraclePdbRestoreInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CreateOraclePdbRestore(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCreateOraclePdbRestore",
                "($input: CreateOraclePdbRestoreInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // downloadOracleDatabaseSnapshot(input: DownloadOracleDatabaseSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationDownloadOracleDatabaseSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadOracleDatabaseSnapshotInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DownloadOracleDatabaseSnapshot(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDownloadOracleDatabaseSnapshot",
                "($input: DownloadOracleDatabaseSnapshotInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // deleteOracleMount(input: DeleteOracleMountInput!): AsyncRequestStatus!
        protected void InvokeMutationDeleteOracleMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteOracleMountInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DeleteOracleMount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDeleteOracleMount",
                "($input: DeleteOracleMountInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // restoreOracleLogs(input: RestoreOracleLogsInput!): AsyncRequestStatus!
        protected void InvokeMutationRestoreOracleLogs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreOracleLogsInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.RestoreOracleLogs(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationRestoreOracleLogs",
                "($input: RestoreOracleLogsInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }


    } // class Invoke_RscMutateOracle
}