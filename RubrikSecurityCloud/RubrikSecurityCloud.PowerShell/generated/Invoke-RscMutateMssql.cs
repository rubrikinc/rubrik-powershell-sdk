// Invoke-RscMutateMssql.cs
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
        "RscMutateMssql",
        DefaultParameterSetName = "BulkUpdateDbs")
    ]
    public class Invoke_RscMutateMssql : RscPSCmdlet
    {
        
        /// <summary>
        /// BrowseDatabaseSnapshot parameter set
        ///
        /// [GraphQL: browseMssqlDatabaseSnapshot]
        /// </summary>
        [Parameter(
            ParameterSetName = "BrowseDatabaseSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List snapshots and logs from a Mssql Database. This endpoint is only used to fetch data, but uses a mutation instead of a query due to limitations with the CDM API.
[GraphQL: browseMssqlDatabaseSnapshot]",
            Position = 0
        )]
        public SwitchParameter BrowseDatabaseSnapshot { get; set; }

        
        /// <summary>
        /// ExportDatabase parameter set
        ///
        /// [GraphQL: exportMssqlDatabase]
        /// </summary>
        [Parameter(
            ParameterSetName = "ExportDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a request to export a Microsoft SQL database.
[GraphQL: exportMssqlDatabase]",
            Position = 0
        )]
        public SwitchParameter ExportDatabase { get; set; }

        
        /// <summary>
        /// RestoreDatabase parameter set
        ///
        /// [GraphQL: restoreMssqlDatabase]
        /// </summary>
        [Parameter(
            ParameterSetName = "RestoreDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a request to restore a Microsoft SQL database.
[GraphQL: restoreMssqlDatabase]",
            Position = 0
        )]
        public SwitchParameter RestoreDatabase { get; set; }

        
        /// <summary>
        /// BulkUpdateDbs parameter set
        ///
        /// [GraphQL: bulkUpdateMssqlDbs]
        /// </summary>
        [Parameter(
            ParameterSetName = "BulkUpdateDbs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update multiple Microsoft SQL databases with the specified properties.
[GraphQL: bulkUpdateMssqlDbs]",
            Position = 0
        )]
        public SwitchParameter BulkUpdateDbs { get; set; }

        
        /// <summary>
        /// TakeLogBackup parameter set
        ///
        /// [GraphQL: takeMssqlLogBackup]
        /// </summary>
        [Parameter(
            ParameterSetName = "TakeLogBackup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Take an on-demand log backup for a Microsoft SQL database.
[GraphQL: takeMssqlLogBackup]",
            Position = 0
        )]
        public SwitchParameter TakeLogBackup { get; set; }

        
        /// <summary>
        /// CreateOnDemandBackup parameter set
        ///
        /// [GraphQL: createOnDemandMssqlBackup]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateOnDemandBackup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Take an on-demand backup of a Microsoft SQL Database
[GraphQL: createOnDemandMssqlBackup]",
            Position = 0
        )]
        public SwitchParameter CreateOnDemandBackup { get; set; }

        
        /// <summary>
        /// DeleteDbSnapshots parameter set
        ///
        /// [GraphQL: deleteMssqlDbSnapshots]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteDbSnapshots",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete snapshots of a Microsoft SQL Database.
[GraphQL: deleteMssqlDbSnapshots]",
            Position = 0
        )]
        public SwitchParameter DeleteDbSnapshots { get; set; }

        
        /// <summary>
        /// DeleteLiveMount parameter set
        ///
        /// [GraphQL: deleteMssqlLiveMount]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete a Live Mount of a SQL Server database

Supported in v5.0+
Create an async request to delete a Live Mount of a SQL Server database. Poll the task status by using /mssql/request/{id}.
[GraphQL: deleteMssqlLiveMount]",
            Position = 0
        )]
        public SwitchParameter DeleteLiveMount { get; set; }

        
        /// <summary>
        /// BulkCreateOnDemandBackup parameter set
        ///
        /// [GraphQL: bulkCreateOnDemandMssqlBackup]
        /// </summary>
        [Parameter(
            ParameterSetName = "BulkCreateOnDemandBackup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Take a bulk on-demand backup of a Microsoft SQL Database.
[GraphQL: bulkCreateOnDemandMssqlBackup]",
            Position = 0
        )]
        public SwitchParameter BulkCreateOnDemandBackup { get; set; }

        
        /// <summary>
        /// CreateLiveMount parameter set
        ///
        /// [GraphQL: createMssqlLiveMount]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create live mount of a Microsoft SQL Database.
[GraphQL: createMssqlLiveMount]",
            Position = 0
        )]
        public SwitchParameter CreateLiveMount { get; set; }

        
        /// <summary>
        /// UpdateLogShippingConfiguration parameter set
        ///
        /// [GraphQL: updateMssqlLogShippingConfiguration]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateLogShippingConfiguration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update log shipping configuration of a Microsoft SQL Database.
[GraphQL: updateMssqlLogShippingConfiguration]",
            Position = 0
        )]
        public SwitchParameter UpdateLogShippingConfiguration { get; set; }

        
        /// <summary>
        /// DownloadDatabaseFilesFromArchivalLocation parameter set
        ///
        /// [GraphQL: downloadMssqlDatabaseFilesFromArchivalLocation]
        /// </summary>
        [Parameter(
            ParameterSetName = "DownloadDatabaseFilesFromArchivalLocation",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Download Microsoft SQL Database backup files from archival location.
[GraphQL: downloadMssqlDatabaseFilesFromArchivalLocation]",
            Position = 0
        )]
        public SwitchParameter DownloadDatabaseFilesFromArchivalLocation { get; set; }

        
        /// <summary>
        /// DownloadDatabaseBackupFiles parameter set
        ///
        /// [GraphQL: downloadMssqlDatabaseBackupFiles]
        /// </summary>
        [Parameter(
            ParameterSetName = "DownloadDatabaseBackupFiles",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Downloads a list of snapshot and log backups from a Microsoft SQL database

Supported in v5.2+
Downloads a list of snapshot and log backups from a Microsoft SQL database.
[GraphQL: downloadMssqlDatabaseBackupFiles]",
            Position = 0
        )]
        public SwitchParameter DownloadDatabaseBackupFiles { get; set; }

        
        /// <summary>
        /// AssignSlaDomainProperties parameter set
        ///
        /// [GraphQL: assignMssqlSlaDomainProperties]
        /// </summary>
        [Parameter(
            ParameterSetName = "AssignSlaDomainProperties",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Assign SLA domain properties to Mssql objects.
[GraphQL: assignMssqlSlaDomainProperties]",
            Position = 0
        )]
        public SwitchParameter AssignSlaDomainProperties { get; set; }

        
        /// <summary>
        /// UpdateDefaultProperties parameter set
        ///
        /// [GraphQL: updateMssqlDefaultProperties]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateDefaultProperties",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update the default properties for Microsoft SQL databases.
[GraphQL: updateMssqlDefaultProperties]",
            Position = 0
        )]
        public SwitchParameter UpdateDefaultProperties { get; set; }

        
        /// <summary>
        /// CreateLogShippingConfiguration parameter set
        ///
        /// [GraphQL: createMssqlLogShippingConfiguration]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateLogShippingConfiguration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create log shipping configuration of a Microsoft SQL Database.
[GraphQL: createMssqlLogShippingConfiguration]",
            Position = 0
        )]
        public SwitchParameter CreateLogShippingConfiguration { get; set; }

        
        /// <summary>
        /// AssignSlaDomainPropertiesAsync parameter set
        ///
        /// [GraphQL: assignMssqlSlaDomainPropertiesAsync]
        /// </summary>
        [Parameter(
            ParameterSetName = "AssignSlaDomainPropertiesAsync",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Assign SLA domain properties to Mssql objects.
[GraphQL: assignMssqlSlaDomainPropertiesAsync]",
            Position = 0
        )]
        public SwitchParameter AssignSlaDomainPropertiesAsync { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "BrowseDatabaseSnapshot":
                        this.ProcessRecord_BrowseDatabaseSnapshot();
                        break;
                    case "ExportDatabase":
                        this.ProcessRecord_ExportDatabase();
                        break;
                    case "RestoreDatabase":
                        this.ProcessRecord_RestoreDatabase();
                        break;
                    case "BulkUpdateDbs":
                        this.ProcessRecord_BulkUpdateDbs();
                        break;
                    case "TakeLogBackup":
                        this.ProcessRecord_TakeLogBackup();
                        break;
                    case "CreateOnDemandBackup":
                        this.ProcessRecord_CreateOnDemandBackup();
                        break;
                    case "DeleteDbSnapshots":
                        this.ProcessRecord_DeleteDbSnapshots();
                        break;
                    case "DeleteLiveMount":
                        this.ProcessRecord_DeleteLiveMount();
                        break;
                    case "BulkCreateOnDemandBackup":
                        this.ProcessRecord_BulkCreateOnDemandBackup();
                        break;
                    case "CreateLiveMount":
                        this.ProcessRecord_CreateLiveMount();
                        break;
                    case "UpdateLogShippingConfiguration":
                        this.ProcessRecord_UpdateLogShippingConfiguration();
                        break;
                    case "DownloadDatabaseFilesFromArchivalLocation":
                        this.ProcessRecord_DownloadDatabaseFilesFromArchivalLocation();
                        break;
                    case "DownloadDatabaseBackupFiles":
                        this.ProcessRecord_DownloadDatabaseBackupFiles();
                        break;
                    case "AssignSlaDomainProperties":
                        this.ProcessRecord_AssignSlaDomainProperties();
                        break;
                    case "UpdateDefaultProperties":
                        this.ProcessRecord_UpdateDefaultProperties();
                        break;
                    case "CreateLogShippingConfiguration":
                        this.ProcessRecord_CreateLogShippingConfiguration();
                        break;
                    case "AssignSlaDomainPropertiesAsync":
                        this.ProcessRecord_AssignSlaDomainPropertiesAsync();
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
        // browseMssqlDatabaseSnapshot.
        internal void ProcessRecord_BrowseDatabaseSnapshot()
        {
            this._logger.name += " -BrowseDatabaseSnapshot";
            // Invoke graphql operation browseMssqlDatabaseSnapshot
            InvokeMutationBrowseMssqlDatabaseSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // exportMssqlDatabase.
        internal void ProcessRecord_ExportDatabase()
        {
            this._logger.name += " -ExportDatabase";
            // Invoke graphql operation exportMssqlDatabase
            InvokeMutationExportMssqlDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // restoreMssqlDatabase.
        internal void ProcessRecord_RestoreDatabase()
        {
            this._logger.name += " -RestoreDatabase";
            // Invoke graphql operation restoreMssqlDatabase
            InvokeMutationRestoreMssqlDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // bulkUpdateMssqlDbs.
        internal void ProcessRecord_BulkUpdateDbs()
        {
            this._logger.name += " -BulkUpdateDbs";
            // Invoke graphql operation bulkUpdateMssqlDbs
            InvokeMutationBulkUpdateMssqlDbs();
        }

        // This parameter set invokes a single graphql operation:
        // takeMssqlLogBackup.
        internal void ProcessRecord_TakeLogBackup()
        {
            this._logger.name += " -TakeLogBackup";
            // Invoke graphql operation takeMssqlLogBackup
            InvokeMutationTakeMssqlLogBackup();
        }

        // This parameter set invokes a single graphql operation:
        // createOnDemandMssqlBackup.
        internal void ProcessRecord_CreateOnDemandBackup()
        {
            this._logger.name += " -CreateOnDemandBackup";
            // Invoke graphql operation createOnDemandMssqlBackup
            InvokeMutationCreateOnDemandMssqlBackup();
        }

        // This parameter set invokes a single graphql operation:
        // deleteMssqlDbSnapshots.
        internal void ProcessRecord_DeleteDbSnapshots()
        {
            this._logger.name += " -DeleteDbSnapshots";
            // Invoke graphql operation deleteMssqlDbSnapshots
            InvokeMutationDeleteMssqlDbSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // deleteMssqlLiveMount.
        internal void ProcessRecord_DeleteLiveMount()
        {
            this._logger.name += " -DeleteLiveMount";
            // Invoke graphql operation deleteMssqlLiveMount
            InvokeMutationDeleteMssqlLiveMount();
        }

        // This parameter set invokes a single graphql operation:
        // bulkCreateOnDemandMssqlBackup.
        internal void ProcessRecord_BulkCreateOnDemandBackup()
        {
            this._logger.name += " -BulkCreateOnDemandBackup";
            // Invoke graphql operation bulkCreateOnDemandMssqlBackup
            InvokeMutationBulkCreateOnDemandMssqlBackup();
        }

        // This parameter set invokes a single graphql operation:
        // createMssqlLiveMount.
        internal void ProcessRecord_CreateLiveMount()
        {
            this._logger.name += " -CreateLiveMount";
            // Invoke graphql operation createMssqlLiveMount
            InvokeMutationCreateMssqlLiveMount();
        }

        // This parameter set invokes a single graphql operation:
        // updateMssqlLogShippingConfiguration.
        internal void ProcessRecord_UpdateLogShippingConfiguration()
        {
            this._logger.name += " -UpdateLogShippingConfiguration";
            // Invoke graphql operation updateMssqlLogShippingConfiguration
            InvokeMutationUpdateMssqlLogShippingConfiguration();
        }

        // This parameter set invokes a single graphql operation:
        // downloadMssqlDatabaseFilesFromArchivalLocation.
        internal void ProcessRecord_DownloadDatabaseFilesFromArchivalLocation()
        {
            this._logger.name += " -DownloadDatabaseFilesFromArchivalLocation";
            // Invoke graphql operation downloadMssqlDatabaseFilesFromArchivalLocation
            InvokeMutationDownloadMssqlDatabaseFilesFromArchivalLocation();
        }

        // This parameter set invokes a single graphql operation:
        // downloadMssqlDatabaseBackupFiles.
        internal void ProcessRecord_DownloadDatabaseBackupFiles()
        {
            this._logger.name += " -DownloadDatabaseBackupFiles";
            // Invoke graphql operation downloadMssqlDatabaseBackupFiles
            InvokeMutationDownloadMssqlDatabaseBackupFiles();
        }

        // This parameter set invokes a single graphql operation:
        // assignMssqlSlaDomainProperties.
        internal void ProcessRecord_AssignSlaDomainProperties()
        {
            this._logger.name += " -AssignSlaDomainProperties";
            // Invoke graphql operation assignMssqlSlaDomainProperties
            InvokeMutationAssignMssqlSlaDomainProperties();
        }

        // This parameter set invokes a single graphql operation:
        // updateMssqlDefaultProperties.
        internal void ProcessRecord_UpdateDefaultProperties()
        {
            this._logger.name += " -UpdateDefaultProperties";
            // Invoke graphql operation updateMssqlDefaultProperties
            InvokeMutationUpdateMssqlDefaultProperties();
        }

        // This parameter set invokes a single graphql operation:
        // createMssqlLogShippingConfiguration.
        internal void ProcessRecord_CreateLogShippingConfiguration()
        {
            this._logger.name += " -CreateLogShippingConfiguration";
            // Invoke graphql operation createMssqlLogShippingConfiguration
            InvokeMutationCreateMssqlLogShippingConfiguration();
        }

        // This parameter set invokes a single graphql operation:
        // assignMssqlSlaDomainPropertiesAsync.
        internal void ProcessRecord_AssignSlaDomainPropertiesAsync()
        {
            this._logger.name += " -AssignSlaDomainPropertiesAsync";
            // Invoke graphql operation assignMssqlSlaDomainPropertiesAsync
            InvokeMutationAssignMssqlSlaDomainPropertiesAsync();
        }


        // Invoke GraphQL Mutation:
        // browseMssqlDatabaseSnapshot(input: BrowseMssqlDatabaseSnapshotInput!): BrowseMssqlDatabaseSnapshotReply!
        internal void InvokeMutationBrowseMssqlDatabaseSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BrowseMssqlDatabaseSnapshotInput!"),
            };
            BrowseMssqlDatabaseSnapshotReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BrowseMssqlDatabaseSnapshotReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BrowseMssqlDatabaseSnapshotReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.BrowseMssqlDatabaseSnapshot(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationBrowseMssqlDatabaseSnapshot",
                "($input: BrowseMssqlDatabaseSnapshotInput!)",
                fieldSpecDoc,
                "BrowseMssqlDatabaseSnapshotReply"
            );
        }

        // Invoke GraphQL Mutation:
        // exportMssqlDatabase(input: ExportMssqlDatabaseInput!): AsyncRequestStatus!
        internal void InvokeMutationExportMssqlDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportMssqlDatabaseInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.ExportMssqlDatabase(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationExportMssqlDatabase",
                "($input: ExportMssqlDatabaseInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // restoreMssqlDatabase(input: RestoreMssqlDatabaseInput!): AsyncRequestStatus!
        internal void InvokeMutationRestoreMssqlDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreMssqlDatabaseInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.RestoreMssqlDatabase(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationRestoreMssqlDatabase",
                "($input: RestoreMssqlDatabaseInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // bulkUpdateMssqlDbs(input: BulkUpdateMssqlDbsInput!): BulkUpdateMssqlDbsReply!
        internal void InvokeMutationBulkUpdateMssqlDbs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkUpdateMssqlDbsInput!"),
            };
            BulkUpdateMssqlDbsReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BulkUpdateMssqlDbsReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BulkUpdateMssqlDbsReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.BulkUpdateMssqlDbs(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationBulkUpdateMssqlDbs",
                "($input: BulkUpdateMssqlDbsInput!)",
                fieldSpecDoc,
                "BulkUpdateMssqlDbsReply"
            );
        }

        // Invoke GraphQL Mutation:
        // takeMssqlLogBackup(input: TakeMssqlLogBackupInput!): AsyncRequestStatus!
        internal void InvokeMutationTakeMssqlLogBackup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "TakeMssqlLogBackupInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.TakeMssqlLogBackup(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationTakeMssqlLogBackup",
                "($input: TakeMssqlLogBackupInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // createOnDemandMssqlBackup(input: CreateOnDemandMssqlBackupInput!): AsyncRequestStatus!
        internal void InvokeMutationCreateOnDemandMssqlBackup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateOnDemandMssqlBackupInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CreateOnDemandMssqlBackup(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCreateOnDemandMssqlBackup",
                "($input: CreateOnDemandMssqlBackupInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // deleteMssqlDbSnapshots(input: DeleteMssqlDbSnapshotsInput!): ResponseSuccess!
        internal void InvokeMutationDeleteMssqlDbSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteMssqlDbSnapshotsInput!"),
            };
            ResponseSuccess? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ResponseSuccess)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ResponseSuccess)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DeleteMssqlDbSnapshots(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDeleteMssqlDbSnapshots",
                "($input: DeleteMssqlDbSnapshotsInput!)",
                fieldSpecDoc,
                "ResponseSuccess"
            );
        }

        // Invoke GraphQL Mutation:
        // deleteMssqlLiveMount(input: DeleteMssqlLiveMountInput!): AsyncRequestStatus!
        internal void InvokeMutationDeleteMssqlLiveMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteMssqlLiveMountInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DeleteMssqlLiveMount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDeleteMssqlLiveMount",
                "($input: DeleteMssqlLiveMountInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // bulkCreateOnDemandMssqlBackup(input: BulkCreateOnDemandMssqlBackupInput!): AsyncRequestStatus!
        internal void InvokeMutationBulkCreateOnDemandMssqlBackup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkCreateOnDemandMssqlBackupInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.BulkCreateOnDemandMssqlBackup(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationBulkCreateOnDemandMssqlBackup",
                "($input: BulkCreateOnDemandMssqlBackupInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // createMssqlLiveMount(input: CreateMssqlLiveMountInput!): AsyncRequestStatus!
        internal void InvokeMutationCreateMssqlLiveMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateMssqlLiveMountInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CreateMssqlLiveMount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCreateMssqlLiveMount",
                "($input: CreateMssqlLiveMountInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // updateMssqlLogShippingConfiguration(input: UpdateMssqlLogShippingConfigurationInput!): UpdateMssqlLogShippingConfigurationReply!
        internal void InvokeMutationUpdateMssqlLogShippingConfiguration()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateMssqlLogShippingConfigurationInput!"),
            };
            UpdateMssqlLogShippingConfigurationReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (UpdateMssqlLogShippingConfigurationReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (UpdateMssqlLogShippingConfigurationReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpdateMssqlLogShippingConfiguration(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpdateMssqlLogShippingConfiguration",
                "($input: UpdateMssqlLogShippingConfigurationInput!)",
                fieldSpecDoc,
                "UpdateMssqlLogShippingConfigurationReply"
            );
        }

        // Invoke GraphQL Mutation:
        // downloadMssqlDatabaseFilesFromArchivalLocation(input: DownloadMssqlDatabaseFilesFromArchivalLocationInput!): AsyncRequestStatus!
        internal void InvokeMutationDownloadMssqlDatabaseFilesFromArchivalLocation()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadMssqlDatabaseFilesFromArchivalLocationInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DownloadMssqlDatabaseFilesFromArchivalLocation(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDownloadMssqlDatabaseFilesFromArchivalLocation",
                "($input: DownloadMssqlDatabaseFilesFromArchivalLocationInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // downloadMssqlDatabaseBackupFiles(input: DownloadMssqlDatabaseBackupFilesInput!): AsyncRequestStatus!
        internal void InvokeMutationDownloadMssqlDatabaseBackupFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadMssqlDatabaseBackupFilesInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DownloadMssqlDatabaseBackupFiles(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDownloadMssqlDatabaseBackupFiles",
                "($input: DownloadMssqlDatabaseBackupFilesInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // assignMssqlSlaDomainProperties(input: AssignMssqlSlaDomainPropertiesInput!): ResponseSuccess!
        internal void InvokeMutationAssignMssqlSlaDomainProperties()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AssignMssqlSlaDomainPropertiesInput!"),
            };
            ResponseSuccess? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ResponseSuccess)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ResponseSuccess)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.AssignMssqlSlaDomainProperties(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationAssignMssqlSlaDomainProperties",
                "($input: AssignMssqlSlaDomainPropertiesInput!)",
                fieldSpecDoc,
                "ResponseSuccess"
            );
        }

        // Invoke GraphQL Mutation:
        // updateMssqlDefaultProperties(input: UpdateMssqlDefaultPropertiesInput!): UpdateMssqlDefaultPropertiesReply!
        internal void InvokeMutationUpdateMssqlDefaultProperties()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateMssqlDefaultPropertiesInput!"),
            };
            UpdateMssqlDefaultPropertiesReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (UpdateMssqlDefaultPropertiesReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (UpdateMssqlDefaultPropertiesReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpdateMssqlDefaultProperties(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpdateMssqlDefaultProperties",
                "($input: UpdateMssqlDefaultPropertiesInput!)",
                fieldSpecDoc,
                "UpdateMssqlDefaultPropertiesReply"
            );
        }

        // Invoke GraphQL Mutation:
        // createMssqlLogShippingConfiguration(input: CreateMssqlLogShippingConfigurationInput!): AsyncRequestStatus!
        internal void InvokeMutationCreateMssqlLogShippingConfiguration()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateMssqlLogShippingConfigurationInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CreateMssqlLogShippingConfiguration(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCreateMssqlLogShippingConfiguration",
                "($input: CreateMssqlLogShippingConfigurationInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // assignMssqlSlaDomainPropertiesAsync(input: AssignMssqlSlaDomainPropertiesAsyncInput!): AssignMssqlSlaDomainPropertiesAsyncReply!
        internal void InvokeMutationAssignMssqlSlaDomainPropertiesAsync()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AssignMssqlSlaDomainPropertiesAsyncInput!"),
            };
            AssignMssqlSlaDomainPropertiesAsyncReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AssignMssqlSlaDomainPropertiesAsyncReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AssignMssqlSlaDomainPropertiesAsyncReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.AssignMssqlSlaDomainPropertiesAsync(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationAssignMssqlSlaDomainPropertiesAsync",
                "($input: AssignMssqlSlaDomainPropertiesAsyncInput!)",
                fieldSpecDoc,
                "AssignMssqlSlaDomainPropertiesAsyncReply"
            );
        }


    } // class Invoke_RscMutateMssql
}