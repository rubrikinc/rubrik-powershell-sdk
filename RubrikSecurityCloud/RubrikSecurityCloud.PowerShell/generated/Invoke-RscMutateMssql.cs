// Invoke-RscMutateMssql.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using Rubrik.SecurityCloud.Types;
using Rubrik.SecurityCloud.NetSDK.Client;
using Rubrik.SecurityCloud.PowerShell.Private;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using RubrikSecurityCloud.Schema.Utils;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Invoke",
        "RscMutateMssql",
        DefaultParameterSetName = "bulkUpdateDb")
    ]
    public class Invoke_RscMutateMssql : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // browseDatabaseSnapshot parameter set
        //
        // GraphQL operation: browseMssqlDatabaseSnapshot(input: BrowseMssqlDatabaseSnapshotInput!):BrowseMssqlDatabaseSnapshotReply!
        //
        [Parameter(
            ParameterSetName = "browseDatabaseSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                List snapshots and logs from a Mssql Database. This endpoint is only used to fetch data, but uses a mutation instead of a query due to limitations with the CDM API.
                GraphQL operation: browseMssqlDatabaseSnapshot(input: BrowseMssqlDatabaseSnapshotInput!):BrowseMssqlDatabaseSnapshotReply!
                ",
            Position = 0
        )]
        public SwitchParameter browseDatabaseSnapshot { get; set; }

        [Parameter(
            ParameterSetName = "browseDatabaseSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Input for V1BrowseMssqlBackupFiles.
                GraphQL argument input: BrowseMssqlDatabaseSnapshotInput!
                "
        )]
        public BrowseMssqlDatabaseSnapshotInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // exportDatabase parameter set
        //
        // GraphQL operation: exportMssqlDatabase(input: ExportMssqlDatabaseInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "exportDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Create a request to export a Microsoft SQL database.
                GraphQL operation: exportMssqlDatabase(input: ExportMssqlDatabaseInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter exportDatabase { get; set; }

        
        // -------------------------------------------------------------------
        // restoreDatabase parameter set
        //
        // GraphQL operation: restoreMssqlDatabase(input: RestoreMssqlDatabaseInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "restoreDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Create a request to restore a Microsoft SQL database.
                GraphQL operation: restoreMssqlDatabase(input: RestoreMssqlDatabaseInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter restoreDatabase { get; set; }

        
        // -------------------------------------------------------------------
        // bulkUpdateDb parameter set
        //
        // GraphQL operation: bulkUpdateMssqlDbs(input: BulkUpdateMssqlDbsInput!):BulkUpdateMssqlDbsReply!
        //
        [Parameter(
            ParameterSetName = "bulkUpdateDb",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Update multiple Microsoft SQL databases with the specified properties.
                GraphQL operation: bulkUpdateMssqlDbs(input: BulkUpdateMssqlDbsInput!):BulkUpdateMssqlDbsReply!
                ",
            Position = 0
        )]
        public SwitchParameter bulkUpdateDb { get; set; }

        
        // -------------------------------------------------------------------
        // takeLogBackup parameter set
        //
        // GraphQL operation: takeMssqlLogBackup(input: TakeMssqlLogBackupInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "takeLogBackup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Take an on-demand log backup for a Microsoft SQL database.
                GraphQL operation: takeMssqlLogBackup(input: TakeMssqlLogBackupInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter takeLogBackup { get; set; }

        
        // -------------------------------------------------------------------
        // createOnDemandBackup parameter set
        //
        // GraphQL operation: createOnDemandMssqlBackup(input: CreateOnDemandMssqlBackupInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "createOnDemandBackup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Take an on-demand backup of a Microsoft SQL Database
                GraphQL operation: createOnDemandMssqlBackup(input: CreateOnDemandMssqlBackupInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter createOnDemandBackup { get; set; }

        
        // -------------------------------------------------------------------
        // deleteDbSnapshot parameter set
        //
        // GraphQL operation: deleteMssqlDbSnapshots(input: DeleteMssqlDbSnapshotsInput!):ResponseSuccess!
        //
        [Parameter(
            ParameterSetName = "deleteDbSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Delete snapshots of a Microsoft SQL Database.
                GraphQL operation: deleteMssqlDbSnapshots(input: DeleteMssqlDbSnapshotsInput!):ResponseSuccess!
                ",
            Position = 0
        )]
        public SwitchParameter deleteDbSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // deleteLiveMount parameter set
        //
        // GraphQL operation: deleteMssqlLiveMount(input: DeleteMssqlLiveMountInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "deleteLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Delete a Live Mount of a SQL Server database

Supported in v5.0+
Create an async request to delete a Live Mount of a SQL Server database. Poll the task status by using /mssql/request/{id}.
                GraphQL operation: deleteMssqlLiveMount(input: DeleteMssqlLiveMountInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter deleteLiveMount { get; set; }

        
        // -------------------------------------------------------------------
        // bulkCreateOnDemandBackup parameter set
        //
        // GraphQL operation: bulkCreateOnDemandMssqlBackup(input: BulkCreateOnDemandMssqlBackupInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "bulkCreateOnDemandBackup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Take a bulk on-demand backup of a Microsoft SQL Database.
                GraphQL operation: bulkCreateOnDemandMssqlBackup(input: BulkCreateOnDemandMssqlBackupInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter bulkCreateOnDemandBackup { get; set; }

        
        // -------------------------------------------------------------------
        // createLiveMount parameter set
        //
        // GraphQL operation: createMssqlLiveMount(input: CreateMssqlLiveMountInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "createLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Create live mount of a Microsoft SQL Database.
                GraphQL operation: createMssqlLiveMount(input: CreateMssqlLiveMountInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter createLiveMount { get; set; }

        
        // -------------------------------------------------------------------
        // updateLogShippingConfiguration parameter set
        //
        // GraphQL operation: updateMssqlLogShippingConfiguration(input: UpdateMssqlLogShippingConfigurationInput!):UpdateMssqlLogShippingConfigurationReply!
        //
        [Parameter(
            ParameterSetName = "updateLogShippingConfiguration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Update log shipping configuration of a Microsoft SQL Database.
                GraphQL operation: updateMssqlLogShippingConfiguration(input: UpdateMssqlLogShippingConfigurationInput!):UpdateMssqlLogShippingConfigurationReply!
                ",
            Position = 0
        )]
        public SwitchParameter updateLogShippingConfiguration { get; set; }

        
        // -------------------------------------------------------------------
        // downloadDatabaseFilesFromArchivalLocation parameter set
        //
        // GraphQL operation: downloadMssqlDatabaseFilesFromArchivalLocation(input: DownloadMssqlDatabaseFilesFromArchivalLocationInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "downloadDatabaseFilesFromArchivalLocation",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Download Microsoft SQL Database backup files from archival location.
                GraphQL operation: downloadMssqlDatabaseFilesFromArchivalLocation(input: DownloadMssqlDatabaseFilesFromArchivalLocationInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter downloadDatabaseFilesFromArchivalLocation { get; set; }

        
        // -------------------------------------------------------------------
        // downloadDatabaseBackupFile parameter set
        //
        // GraphQL operation: downloadMssqlDatabaseBackupFiles(input: DownloadMssqlDatabaseBackupFilesInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "downloadDatabaseBackupFile",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Downloads a list of snapshot and log backups from a Microsoft SQL database

Supported in v5.2+
Downloads a list of snapshot and log backups from a Microsoft SQL database.
                GraphQL operation: downloadMssqlDatabaseBackupFiles(input: DownloadMssqlDatabaseBackupFilesInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter downloadDatabaseBackupFile { get; set; }

        
        // -------------------------------------------------------------------
        // assignSlaDomainPropertie parameter set
        //
        // GraphQL operation: assignMssqlSlaDomainProperties(input: AssignMssqlSlaDomainPropertiesInput!):ResponseSuccess!
        //
        [Parameter(
            ParameterSetName = "assignSlaDomainPropertie",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Assign SLA domain properties to Mssql objects.
                GraphQL operation: assignMssqlSlaDomainProperties(input: AssignMssqlSlaDomainPropertiesInput!):ResponseSuccess!
                ",
            Position = 0
        )]
        public SwitchParameter assignSlaDomainPropertie { get; set; }

        
        // -------------------------------------------------------------------
        // updateDefaultPropertie parameter set
        //
        // GraphQL operation: updateMssqlDefaultProperties(input: UpdateMssqlDefaultPropertiesInput!):UpdateMssqlDefaultPropertiesReply!
        //
        [Parameter(
            ParameterSetName = "updateDefaultPropertie",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Update the default properties for Microsoft SQL databases.
                GraphQL operation: updateMssqlDefaultProperties(input: UpdateMssqlDefaultPropertiesInput!):UpdateMssqlDefaultPropertiesReply!
                ",
            Position = 0
        )]
        public SwitchParameter updateDefaultPropertie { get; set; }

        
        // -------------------------------------------------------------------
        // createLogShippingConfiguration parameter set
        //
        // GraphQL operation: createMssqlLogShippingConfiguration(input: CreateMssqlLogShippingConfigurationInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "createLogShippingConfiguration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Create log shipping configuration of a Microsoft SQL Database.
                GraphQL operation: createMssqlLogShippingConfiguration(input: CreateMssqlLogShippingConfigurationInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter createLogShippingConfiguration { get; set; }

        
        // -------------------------------------------------------------------
        // assignSlaDomainPropertiesAsync parameter set
        //
        // GraphQL operation: assignMssqlSlaDomainPropertiesAsync(input: AssignMssqlSlaDomainPropertiesAsyncInput!):AssignMssqlSlaDomainPropertiesAsyncReply!
        //
        [Parameter(
            ParameterSetName = "assignSlaDomainPropertiesAsync",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Assign SLA domain properties to Mssql objects.
                GraphQL operation: assignMssqlSlaDomainPropertiesAsync(input: AssignMssqlSlaDomainPropertiesAsyncInput!):AssignMssqlSlaDomainPropertiesAsyncReply!
                ",
            Position = 0
        )]
        public SwitchParameter assignSlaDomainPropertiesAsync { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "browseDatabaseSnapshot":
                        this.ProcessRecord_browseDatabaseSnapshot();
                        break;
                    case "exportDatabase":
                        this.ProcessRecord_exportDatabase();
                        break;
                    case "restoreDatabase":
                        this.ProcessRecord_restoreDatabase();
                        break;
                    case "bulkUpdateDb":
                        this.ProcessRecord_bulkUpdateDb();
                        break;
                    case "takeLogBackup":
                        this.ProcessRecord_takeLogBackup();
                        break;
                    case "createOnDemandBackup":
                        this.ProcessRecord_createOnDemandBackup();
                        break;
                    case "deleteDbSnapshot":
                        this.ProcessRecord_deleteDbSnapshot();
                        break;
                    case "deleteLiveMount":
                        this.ProcessRecord_deleteLiveMount();
                        break;
                    case "bulkCreateOnDemandBackup":
                        this.ProcessRecord_bulkCreateOnDemandBackup();
                        break;
                    case "createLiveMount":
                        this.ProcessRecord_createLiveMount();
                        break;
                    case "updateLogShippingConfiguration":
                        this.ProcessRecord_updateLogShippingConfiguration();
                        break;
                    case "downloadDatabaseFilesFromArchivalLocation":
                        this.ProcessRecord_downloadDatabaseFilesFromArchivalLocation();
                        break;
                    case "downloadDatabaseBackupFile":
                        this.ProcessRecord_downloadDatabaseBackupFile();
                        break;
                    case "assignSlaDomainPropertie":
                        this.ProcessRecord_assignSlaDomainPropertie();
                        break;
                    case "updateDefaultPropertie":
                        this.ProcessRecord_updateDefaultPropertie();
                        break;
                    case "createLogShippingConfiguration":
                        this.ProcessRecord_createLogShippingConfiguration();
                        break;
                    case "assignSlaDomainPropertiesAsync":
                        this.ProcessRecord_assignSlaDomainPropertiesAsync();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                this._logger.Flush();
                var error = new ErrorRecord(
                    ex,
                    "Invoke-RscMutateMssql",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
           }
        }

        // This parameter set invokes a single graphql operation:
        // browseMssqlDatabaseSnapshot.
        protected void ProcessRecord_browseDatabaseSnapshot()
        {
            this._logger.name += " -browseDatabaseSnapshot";
            // Invoke graphql operation browseMssqlDatabaseSnapshot
            InvokeMutationBrowseMssqlDatabaseSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // exportMssqlDatabase.
        protected void ProcessRecord_exportDatabase()
        {
            this._logger.name += " -exportDatabase";
            // Invoke graphql operation exportMssqlDatabase
            InvokeMutationExportMssqlDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // restoreMssqlDatabase.
        protected void ProcessRecord_restoreDatabase()
        {
            this._logger.name += " -restoreDatabase";
            // Invoke graphql operation restoreMssqlDatabase
            InvokeMutationRestoreMssqlDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // bulkUpdateMssqlDbs.
        protected void ProcessRecord_bulkUpdateDb()
        {
            this._logger.name += " -bulkUpdateDb";
            // Invoke graphql operation bulkUpdateMssqlDbs
            InvokeMutationBulkUpdateMssqlDbs();
        }

        // This parameter set invokes a single graphql operation:
        // takeMssqlLogBackup.
        protected void ProcessRecord_takeLogBackup()
        {
            this._logger.name += " -takeLogBackup";
            // Invoke graphql operation takeMssqlLogBackup
            InvokeMutationTakeMssqlLogBackup();
        }

        // This parameter set invokes a single graphql operation:
        // createOnDemandMssqlBackup.
        protected void ProcessRecord_createOnDemandBackup()
        {
            this._logger.name += " -createOnDemandBackup";
            // Invoke graphql operation createOnDemandMssqlBackup
            InvokeMutationCreateOnDemandMssqlBackup();
        }

        // This parameter set invokes a single graphql operation:
        // deleteMssqlDbSnapshots.
        protected void ProcessRecord_deleteDbSnapshot()
        {
            this._logger.name += " -deleteDbSnapshot";
            // Invoke graphql operation deleteMssqlDbSnapshots
            InvokeMutationDeleteMssqlDbSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // deleteMssqlLiveMount.
        protected void ProcessRecord_deleteLiveMount()
        {
            this._logger.name += " -deleteLiveMount";
            // Invoke graphql operation deleteMssqlLiveMount
            InvokeMutationDeleteMssqlLiveMount();
        }

        // This parameter set invokes a single graphql operation:
        // bulkCreateOnDemandMssqlBackup.
        protected void ProcessRecord_bulkCreateOnDemandBackup()
        {
            this._logger.name += " -bulkCreateOnDemandBackup";
            // Invoke graphql operation bulkCreateOnDemandMssqlBackup
            InvokeMutationBulkCreateOnDemandMssqlBackup();
        }

        // This parameter set invokes a single graphql operation:
        // createMssqlLiveMount.
        protected void ProcessRecord_createLiveMount()
        {
            this._logger.name += " -createLiveMount";
            // Invoke graphql operation createMssqlLiveMount
            InvokeMutationCreateMssqlLiveMount();
        }

        // This parameter set invokes a single graphql operation:
        // updateMssqlLogShippingConfiguration.
        protected void ProcessRecord_updateLogShippingConfiguration()
        {
            this._logger.name += " -updateLogShippingConfiguration";
            // Invoke graphql operation updateMssqlLogShippingConfiguration
            InvokeMutationUpdateMssqlLogShippingConfiguration();
        }

        // This parameter set invokes a single graphql operation:
        // downloadMssqlDatabaseFilesFromArchivalLocation.
        protected void ProcessRecord_downloadDatabaseFilesFromArchivalLocation()
        {
            this._logger.name += " -downloadDatabaseFilesFromArchivalLocation";
            // Invoke graphql operation downloadMssqlDatabaseFilesFromArchivalLocation
            InvokeMutationDownloadMssqlDatabaseFilesFromArchivalLocation();
        }

        // This parameter set invokes a single graphql operation:
        // downloadMssqlDatabaseBackupFiles.
        protected void ProcessRecord_downloadDatabaseBackupFile()
        {
            this._logger.name += " -downloadDatabaseBackupFile";
            // Invoke graphql operation downloadMssqlDatabaseBackupFiles
            InvokeMutationDownloadMssqlDatabaseBackupFiles();
        }

        // This parameter set invokes a single graphql operation:
        // assignMssqlSlaDomainProperties.
        protected void ProcessRecord_assignSlaDomainPropertie()
        {
            this._logger.name += " -assignSlaDomainPropertie";
            // Invoke graphql operation assignMssqlSlaDomainProperties
            InvokeMutationAssignMssqlSlaDomainProperties();
        }

        // This parameter set invokes a single graphql operation:
        // updateMssqlDefaultProperties.
        protected void ProcessRecord_updateDefaultPropertie()
        {
            this._logger.name += " -updateDefaultPropertie";
            // Invoke graphql operation updateMssqlDefaultProperties
            InvokeMutationUpdateMssqlDefaultProperties();
        }

        // This parameter set invokes a single graphql operation:
        // createMssqlLogShippingConfiguration.
        protected void ProcessRecord_createLogShippingConfiguration()
        {
            this._logger.name += " -createLogShippingConfiguration";
            // Invoke graphql operation createMssqlLogShippingConfiguration
            InvokeMutationCreateMssqlLogShippingConfiguration();
        }

        // This parameter set invokes a single graphql operation:
        // assignMssqlSlaDomainPropertiesAsync.
        protected void ProcessRecord_assignSlaDomainPropertiesAsync()
        {
            this._logger.name += " -assignSlaDomainPropertiesAsync";
            // Invoke graphql operation assignMssqlSlaDomainPropertiesAsync
            InvokeMutationAssignMssqlSlaDomainPropertiesAsync();
        }


        // Invoke GraphQL Mutation:
        // browseMssqlDatabaseSnapshot(input: BrowseMssqlDatabaseSnapshotInput!): BrowseMssqlDatabaseSnapshotReply!
        protected void InvokeMutationBrowseMssqlDatabaseSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BrowseMssqlDatabaseSnapshotInput!"),
            };
            BrowseMssqlDatabaseSnapshotReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (BrowseMssqlDatabaseSnapshotReply)psObject.BaseObject;
                } else {
                    fields = (BrowseMssqlDatabaseSnapshotReply)this.Field;
                }
            }
            string document = Mutation.BrowseMssqlDatabaseSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BrowseMssqlDatabaseSnapshot");
            var parameters = "($input: BrowseMssqlDatabaseSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBrowseMssqlDatabaseSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationBrowseMssqlDatabaseSnapshot",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BrowseMssqlDatabaseSnapshotReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // exportMssqlDatabase(input: ExportMssqlDatabaseInput!): AsyncRequestStatus!
        protected void InvokeMutationExportMssqlDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportMssqlDatabaseInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.ExportMssqlDatabase(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.ExportMssqlDatabase");
            var parameters = "($input: ExportMssqlDatabaseInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationExportMssqlDatabase" + parameters + "{" + document + "}",
                OperationName = "MutationExportMssqlDatabase",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // restoreMssqlDatabase(input: RestoreMssqlDatabaseInput!): AsyncRequestStatus!
        protected void InvokeMutationRestoreMssqlDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreMssqlDatabaseInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.RestoreMssqlDatabase(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RestoreMssqlDatabase");
            var parameters = "($input: RestoreMssqlDatabaseInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRestoreMssqlDatabase" + parameters + "{" + document + "}",
                OperationName = "MutationRestoreMssqlDatabase",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // bulkUpdateMssqlDbs(input: BulkUpdateMssqlDbsInput!): BulkUpdateMssqlDbsReply!
        protected void InvokeMutationBulkUpdateMssqlDbs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkUpdateMssqlDbsInput!"),
            };
            BulkUpdateMssqlDbsReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (BulkUpdateMssqlDbsReply)psObject.BaseObject;
                } else {
                    fields = (BulkUpdateMssqlDbsReply)this.Field;
                }
            }
            string document = Mutation.BulkUpdateMssqlDbs(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BulkUpdateMssqlDbs");
            var parameters = "($input: BulkUpdateMssqlDbsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBulkUpdateMssqlDbs" + parameters + "{" + document + "}",
                OperationName = "MutationBulkUpdateMssqlDbs",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BulkUpdateMssqlDbsReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // takeMssqlLogBackup(input: TakeMssqlLogBackupInput!): AsyncRequestStatus!
        protected void InvokeMutationTakeMssqlLogBackup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "TakeMssqlLogBackupInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.TakeMssqlLogBackup(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.TakeMssqlLogBackup");
            var parameters = "($input: TakeMssqlLogBackupInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationTakeMssqlLogBackup" + parameters + "{" + document + "}",
                OperationName = "MutationTakeMssqlLogBackup",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // createOnDemandMssqlBackup(input: CreateOnDemandMssqlBackupInput!): AsyncRequestStatus!
        protected void InvokeMutationCreateOnDemandMssqlBackup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateOnDemandMssqlBackupInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.CreateOnDemandMssqlBackup(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateOnDemandMssqlBackup");
            var parameters = "($input: CreateOnDemandMssqlBackupInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateOnDemandMssqlBackup" + parameters + "{" + document + "}",
                OperationName = "MutationCreateOnDemandMssqlBackup",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteMssqlDbSnapshots(input: DeleteMssqlDbSnapshotsInput!): ResponseSuccess!
        protected void InvokeMutationDeleteMssqlDbSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteMssqlDbSnapshotsInput!"),
            };
            ResponseSuccess? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (ResponseSuccess)psObject.BaseObject;
                } else {
                    fields = (ResponseSuccess)this.Field;
                }
            }
            string document = Mutation.DeleteMssqlDbSnapshots(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteMssqlDbSnapshots");
            var parameters = "($input: DeleteMssqlDbSnapshotsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteMssqlDbSnapshots" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteMssqlDbSnapshots",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ResponseSuccess", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteMssqlLiveMount(input: DeleteMssqlLiveMountInput!): AsyncRequestStatus!
        protected void InvokeMutationDeleteMssqlLiveMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteMssqlLiveMountInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.DeleteMssqlLiveMount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteMssqlLiveMount");
            var parameters = "($input: DeleteMssqlLiveMountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteMssqlLiveMount" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteMssqlLiveMount",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // bulkCreateOnDemandMssqlBackup(input: BulkCreateOnDemandMssqlBackupInput!): AsyncRequestStatus!
        protected void InvokeMutationBulkCreateOnDemandMssqlBackup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkCreateOnDemandMssqlBackupInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.BulkCreateOnDemandMssqlBackup(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BulkCreateOnDemandMssqlBackup");
            var parameters = "($input: BulkCreateOnDemandMssqlBackupInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBulkCreateOnDemandMssqlBackup" + parameters + "{" + document + "}",
                OperationName = "MutationBulkCreateOnDemandMssqlBackup",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // createMssqlLiveMount(input: CreateMssqlLiveMountInput!): AsyncRequestStatus!
        protected void InvokeMutationCreateMssqlLiveMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateMssqlLiveMountInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.CreateMssqlLiveMount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateMssqlLiveMount");
            var parameters = "($input: CreateMssqlLiveMountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateMssqlLiveMount" + parameters + "{" + document + "}",
                OperationName = "MutationCreateMssqlLiveMount",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // updateMssqlLogShippingConfiguration(input: UpdateMssqlLogShippingConfigurationInput!): UpdateMssqlLogShippingConfigurationReply!
        protected void InvokeMutationUpdateMssqlLogShippingConfiguration()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateMssqlLogShippingConfigurationInput!"),
            };
            UpdateMssqlLogShippingConfigurationReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (UpdateMssqlLogShippingConfigurationReply)psObject.BaseObject;
                } else {
                    fields = (UpdateMssqlLogShippingConfigurationReply)this.Field;
                }
            }
            string document = Mutation.UpdateMssqlLogShippingConfiguration(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateMssqlLogShippingConfiguration");
            var parameters = "($input: UpdateMssqlLogShippingConfigurationInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateMssqlLogShippingConfiguration" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateMssqlLogShippingConfiguration",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "UpdateMssqlLogShippingConfigurationReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // downloadMssqlDatabaseFilesFromArchivalLocation(input: DownloadMssqlDatabaseFilesFromArchivalLocationInput!): AsyncRequestStatus!
        protected void InvokeMutationDownloadMssqlDatabaseFilesFromArchivalLocation()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadMssqlDatabaseFilesFromArchivalLocationInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.DownloadMssqlDatabaseFilesFromArchivalLocation(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DownloadMssqlDatabaseFilesFromArchivalLocation");
            var parameters = "($input: DownloadMssqlDatabaseFilesFromArchivalLocationInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDownloadMssqlDatabaseFilesFromArchivalLocation" + parameters + "{" + document + "}",
                OperationName = "MutationDownloadMssqlDatabaseFilesFromArchivalLocation",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // downloadMssqlDatabaseBackupFiles(input: DownloadMssqlDatabaseBackupFilesInput!): AsyncRequestStatus!
        protected void InvokeMutationDownloadMssqlDatabaseBackupFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadMssqlDatabaseBackupFilesInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.DownloadMssqlDatabaseBackupFiles(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DownloadMssqlDatabaseBackupFiles");
            var parameters = "($input: DownloadMssqlDatabaseBackupFilesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDownloadMssqlDatabaseBackupFiles" + parameters + "{" + document + "}",
                OperationName = "MutationDownloadMssqlDatabaseBackupFiles",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // assignMssqlSlaDomainProperties(input: AssignMssqlSlaDomainPropertiesInput!): ResponseSuccess!
        protected void InvokeMutationAssignMssqlSlaDomainProperties()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AssignMssqlSlaDomainPropertiesInput!"),
            };
            ResponseSuccess? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (ResponseSuccess)psObject.BaseObject;
                } else {
                    fields = (ResponseSuccess)this.Field;
                }
            }
            string document = Mutation.AssignMssqlSlaDomainProperties(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AssignMssqlSlaDomainProperties");
            var parameters = "($input: AssignMssqlSlaDomainPropertiesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAssignMssqlSlaDomainProperties" + parameters + "{" + document + "}",
                OperationName = "MutationAssignMssqlSlaDomainProperties",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ResponseSuccess", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // updateMssqlDefaultProperties(input: UpdateMssqlDefaultPropertiesInput!): UpdateMssqlDefaultPropertiesReply!
        protected void InvokeMutationUpdateMssqlDefaultProperties()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateMssqlDefaultPropertiesInput!"),
            };
            UpdateMssqlDefaultPropertiesReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (UpdateMssqlDefaultPropertiesReply)psObject.BaseObject;
                } else {
                    fields = (UpdateMssqlDefaultPropertiesReply)this.Field;
                }
            }
            string document = Mutation.UpdateMssqlDefaultProperties(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateMssqlDefaultProperties");
            var parameters = "($input: UpdateMssqlDefaultPropertiesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateMssqlDefaultProperties" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateMssqlDefaultProperties",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "UpdateMssqlDefaultPropertiesReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // createMssqlLogShippingConfiguration(input: CreateMssqlLogShippingConfigurationInput!): AsyncRequestStatus!
        protected void InvokeMutationCreateMssqlLogShippingConfiguration()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateMssqlLogShippingConfigurationInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.CreateMssqlLogShippingConfiguration(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateMssqlLogShippingConfiguration");
            var parameters = "($input: CreateMssqlLogShippingConfigurationInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateMssqlLogShippingConfiguration" + parameters + "{" + document + "}",
                OperationName = "MutationCreateMssqlLogShippingConfiguration",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // assignMssqlSlaDomainPropertiesAsync(input: AssignMssqlSlaDomainPropertiesAsyncInput!): AssignMssqlSlaDomainPropertiesAsyncReply!
        protected void InvokeMutationAssignMssqlSlaDomainPropertiesAsync()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AssignMssqlSlaDomainPropertiesAsyncInput!"),
            };
            AssignMssqlSlaDomainPropertiesAsyncReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AssignMssqlSlaDomainPropertiesAsyncReply)psObject.BaseObject;
                } else {
                    fields = (AssignMssqlSlaDomainPropertiesAsyncReply)this.Field;
                }
            }
            string document = Mutation.AssignMssqlSlaDomainPropertiesAsync(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AssignMssqlSlaDomainPropertiesAsync");
            var parameters = "($input: AssignMssqlSlaDomainPropertiesAsyncInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAssignMssqlSlaDomainPropertiesAsync" + parameters + "{" + document + "}",
                OperationName = "MutationAssignMssqlSlaDomainPropertiesAsync",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AssignMssqlSlaDomainPropertiesAsyncReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscMutateMssql
}