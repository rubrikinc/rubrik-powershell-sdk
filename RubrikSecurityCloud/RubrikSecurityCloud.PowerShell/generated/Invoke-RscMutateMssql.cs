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
        DefaultParameterSetName = "Bulkupdatedb")
    ]
    public class Invoke_RscMutateMssql : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // Browsedatabasesnapshot parameter set
        //
        // [GraphQL: browseMssqlDatabaseSnapshot]
        //
        [Parameter(
            ParameterSetName = "Browsedatabasesnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List snapshots and logs from a Mssql Database. This endpoint is only used to fetch data, but uses a mutation instead of a query due to limitations with the CDM API.
[GraphQL: browseMssqlDatabaseSnapshot]",
            Position = 0
        )]
        public SwitchParameter Browsedatabasesnapshot { get; set; }

        [Parameter(
            ParameterSetName = "Browsedatabasesnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Input for V1BrowseMssqlBackupFiles.
GraphQL argument input: BrowseMssqlDatabaseSnapshotInput!"
        )]
        public BrowseMssqlDatabaseSnapshotInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // Exportdatabase parameter set
        //
        // [GraphQL: exportMssqlDatabase]
        //
        [Parameter(
            ParameterSetName = "Exportdatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a request to export a Microsoft SQL database.
[GraphQL: exportMssqlDatabase]",
            Position = 0
        )]
        public SwitchParameter Exportdatabase { get; set; }

        
        // -------------------------------------------------------------------
        // Restoredatabase parameter set
        //
        // [GraphQL: restoreMssqlDatabase]
        //
        [Parameter(
            ParameterSetName = "Restoredatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a request to restore a Microsoft SQL database.
[GraphQL: restoreMssqlDatabase]",
            Position = 0
        )]
        public SwitchParameter Restoredatabase { get; set; }

        
        // -------------------------------------------------------------------
        // Bulkupdatedb parameter set
        //
        // [GraphQL: bulkUpdateMssqlDbs]
        //
        [Parameter(
            ParameterSetName = "Bulkupdatedb",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update multiple Microsoft SQL databases with the specified properties.
[GraphQL: bulkUpdateMssqlDbs]",
            Position = 0
        )]
        public SwitchParameter Bulkupdatedb { get; set; }

        
        // -------------------------------------------------------------------
        // Takelogbackup parameter set
        //
        // [GraphQL: takeMssqlLogBackup]
        //
        [Parameter(
            ParameterSetName = "Takelogbackup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Take an on-demand log backup for a Microsoft SQL database.
[GraphQL: takeMssqlLogBackup]",
            Position = 0
        )]
        public SwitchParameter Takelogbackup { get; set; }

        
        // -------------------------------------------------------------------
        // Createondemandbackup parameter set
        //
        // [GraphQL: createOnDemandMssqlBackup]
        //
        [Parameter(
            ParameterSetName = "Createondemandbackup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Take an on-demand backup of a Microsoft SQL Database
[GraphQL: createOnDemandMssqlBackup]",
            Position = 0
        )]
        public SwitchParameter Createondemandbackup { get; set; }

        
        // -------------------------------------------------------------------
        // Deletedbsnapshot parameter set
        //
        // [GraphQL: deleteMssqlDbSnapshots]
        //
        [Parameter(
            ParameterSetName = "Deletedbsnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete snapshots of a Microsoft SQL Database.
[GraphQL: deleteMssqlDbSnapshots]",
            Position = 0
        )]
        public SwitchParameter Deletedbsnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // Deletelivemount parameter set
        //
        // [GraphQL: deleteMssqlLiveMount]
        //
        [Parameter(
            ParameterSetName = "Deletelivemount",
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
        public SwitchParameter Deletelivemount { get; set; }

        
        // -------------------------------------------------------------------
        // Bulkcreateondemandbackup parameter set
        //
        // [GraphQL: bulkCreateOnDemandMssqlBackup]
        //
        [Parameter(
            ParameterSetName = "Bulkcreateondemandbackup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Take a bulk on-demand backup of a Microsoft SQL Database.
[GraphQL: bulkCreateOnDemandMssqlBackup]",
            Position = 0
        )]
        public SwitchParameter Bulkcreateondemandbackup { get; set; }

        
        // -------------------------------------------------------------------
        // Createlivemount parameter set
        //
        // [GraphQL: createMssqlLiveMount]
        //
        [Parameter(
            ParameterSetName = "Createlivemount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create live mount of a Microsoft SQL Database.
[GraphQL: createMssqlLiveMount]",
            Position = 0
        )]
        public SwitchParameter Createlivemount { get; set; }

        
        // -------------------------------------------------------------------
        // Updatelogshippingconfiguration parameter set
        //
        // [GraphQL: updateMssqlLogShippingConfiguration]
        //
        [Parameter(
            ParameterSetName = "Updatelogshippingconfiguration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update log shipping configuration of a Microsoft SQL Database.
[GraphQL: updateMssqlLogShippingConfiguration]",
            Position = 0
        )]
        public SwitchParameter Updatelogshippingconfiguration { get; set; }

        
        // -------------------------------------------------------------------
        // Downloaddatabasefilesfromarchivallocation parameter set
        //
        // [GraphQL: downloadMssqlDatabaseFilesFromArchivalLocation]
        //
        [Parameter(
            ParameterSetName = "Downloaddatabasefilesfromarchivallocation",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Download Microsoft SQL Database backup files from archival location.
[GraphQL: downloadMssqlDatabaseFilesFromArchivalLocation]",
            Position = 0
        )]
        public SwitchParameter Downloaddatabasefilesfromarchivallocation { get; set; }

        
        // -------------------------------------------------------------------
        // Downloaddatabasebackupfile parameter set
        //
        // [GraphQL: downloadMssqlDatabaseBackupFiles]
        //
        [Parameter(
            ParameterSetName = "Downloaddatabasebackupfile",
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
        public SwitchParameter Downloaddatabasebackupfile { get; set; }

        
        // -------------------------------------------------------------------
        // Assignsladomainpropertie parameter set
        //
        // [GraphQL: assignMssqlSlaDomainProperties]
        //
        [Parameter(
            ParameterSetName = "Assignsladomainpropertie",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Assign SLA domain properties to Mssql objects.
[GraphQL: assignMssqlSlaDomainProperties]",
            Position = 0
        )]
        public SwitchParameter Assignsladomainpropertie { get; set; }

        
        // -------------------------------------------------------------------
        // Updatedefaultpropertie parameter set
        //
        // [GraphQL: updateMssqlDefaultProperties]
        //
        [Parameter(
            ParameterSetName = "Updatedefaultpropertie",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update the default properties for Microsoft SQL databases.
[GraphQL: updateMssqlDefaultProperties]",
            Position = 0
        )]
        public SwitchParameter Updatedefaultpropertie { get; set; }

        
        // -------------------------------------------------------------------
        // Createlogshippingconfiguration parameter set
        //
        // [GraphQL: createMssqlLogShippingConfiguration]
        //
        [Parameter(
            ParameterSetName = "Createlogshippingconfiguration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create log shipping configuration of a Microsoft SQL Database.
[GraphQL: createMssqlLogShippingConfiguration]",
            Position = 0
        )]
        public SwitchParameter Createlogshippingconfiguration { get; set; }

        
        // -------------------------------------------------------------------
        // Assignsladomainpropertiesasync parameter set
        //
        // [GraphQL: assignMssqlSlaDomainPropertiesAsync]
        //
        [Parameter(
            ParameterSetName = "Assignsladomainpropertiesasync",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Assign SLA domain properties to Mssql objects.
[GraphQL: assignMssqlSlaDomainPropertiesAsync]",
            Position = 0
        )]
        public SwitchParameter Assignsladomainpropertiesasync { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "Browsedatabasesnapshot":
                        this.ProcessRecord_Browsedatabasesnapshot();
                        break;
                    case "Exportdatabase":
                        this.ProcessRecord_Exportdatabase();
                        break;
                    case "Restoredatabase":
                        this.ProcessRecord_Restoredatabase();
                        break;
                    case "Bulkupdatedb":
                        this.ProcessRecord_Bulkupdatedb();
                        break;
                    case "Takelogbackup":
                        this.ProcessRecord_Takelogbackup();
                        break;
                    case "Createondemandbackup":
                        this.ProcessRecord_Createondemandbackup();
                        break;
                    case "Deletedbsnapshot":
                        this.ProcessRecord_Deletedbsnapshot();
                        break;
                    case "Deletelivemount":
                        this.ProcessRecord_Deletelivemount();
                        break;
                    case "Bulkcreateondemandbackup":
                        this.ProcessRecord_Bulkcreateondemandbackup();
                        break;
                    case "Createlivemount":
                        this.ProcessRecord_Createlivemount();
                        break;
                    case "Updatelogshippingconfiguration":
                        this.ProcessRecord_Updatelogshippingconfiguration();
                        break;
                    case "Downloaddatabasefilesfromarchivallocation":
                        this.ProcessRecord_Downloaddatabasefilesfromarchivallocation();
                        break;
                    case "Downloaddatabasebackupfile":
                        this.ProcessRecord_Downloaddatabasebackupfile();
                        break;
                    case "Assignsladomainpropertie":
                        this.ProcessRecord_Assignsladomainpropertie();
                        break;
                    case "Updatedefaultpropertie":
                        this.ProcessRecord_Updatedefaultpropertie();
                        break;
                    case "Createlogshippingconfiguration":
                        this.ProcessRecord_Createlogshippingconfiguration();
                        break;
                    case "Assignsladomainpropertiesasync":
                        this.ProcessRecord_Assignsladomainpropertiesasync();
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
        // browseMssqlDatabaseSnapshot.
        protected void ProcessRecord_Browsedatabasesnapshot()
        {
            this._logger.name += " -Browsedatabasesnapshot";
            // Invoke graphql operation browseMssqlDatabaseSnapshot
            InvokeMutationBrowseMssqlDatabaseSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // exportMssqlDatabase.
        protected void ProcessRecord_Exportdatabase()
        {
            this._logger.name += " -Exportdatabase";
            // Invoke graphql operation exportMssqlDatabase
            InvokeMutationExportMssqlDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // restoreMssqlDatabase.
        protected void ProcessRecord_Restoredatabase()
        {
            this._logger.name += " -Restoredatabase";
            // Invoke graphql operation restoreMssqlDatabase
            InvokeMutationRestoreMssqlDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // bulkUpdateMssqlDbs.
        protected void ProcessRecord_Bulkupdatedb()
        {
            this._logger.name += " -Bulkupdatedb";
            // Invoke graphql operation bulkUpdateMssqlDbs
            InvokeMutationBulkUpdateMssqlDbs();
        }

        // This parameter set invokes a single graphql operation:
        // takeMssqlLogBackup.
        protected void ProcessRecord_Takelogbackup()
        {
            this._logger.name += " -Takelogbackup";
            // Invoke graphql operation takeMssqlLogBackup
            InvokeMutationTakeMssqlLogBackup();
        }

        // This parameter set invokes a single graphql operation:
        // createOnDemandMssqlBackup.
        protected void ProcessRecord_Createondemandbackup()
        {
            this._logger.name += " -Createondemandbackup";
            // Invoke graphql operation createOnDemandMssqlBackup
            InvokeMutationCreateOnDemandMssqlBackup();
        }

        // This parameter set invokes a single graphql operation:
        // deleteMssqlDbSnapshots.
        protected void ProcessRecord_Deletedbsnapshot()
        {
            this._logger.name += " -Deletedbsnapshot";
            // Invoke graphql operation deleteMssqlDbSnapshots
            InvokeMutationDeleteMssqlDbSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // deleteMssqlLiveMount.
        protected void ProcessRecord_Deletelivemount()
        {
            this._logger.name += " -Deletelivemount";
            // Invoke graphql operation deleteMssqlLiveMount
            InvokeMutationDeleteMssqlLiveMount();
        }

        // This parameter set invokes a single graphql operation:
        // bulkCreateOnDemandMssqlBackup.
        protected void ProcessRecord_Bulkcreateondemandbackup()
        {
            this._logger.name += " -Bulkcreateondemandbackup";
            // Invoke graphql operation bulkCreateOnDemandMssqlBackup
            InvokeMutationBulkCreateOnDemandMssqlBackup();
        }

        // This parameter set invokes a single graphql operation:
        // createMssqlLiveMount.
        protected void ProcessRecord_Createlivemount()
        {
            this._logger.name += " -Createlivemount";
            // Invoke graphql operation createMssqlLiveMount
            InvokeMutationCreateMssqlLiveMount();
        }

        // This parameter set invokes a single graphql operation:
        // updateMssqlLogShippingConfiguration.
        protected void ProcessRecord_Updatelogshippingconfiguration()
        {
            this._logger.name += " -Updatelogshippingconfiguration";
            // Invoke graphql operation updateMssqlLogShippingConfiguration
            InvokeMutationUpdateMssqlLogShippingConfiguration();
        }

        // This parameter set invokes a single graphql operation:
        // downloadMssqlDatabaseFilesFromArchivalLocation.
        protected void ProcessRecord_Downloaddatabasefilesfromarchivallocation()
        {
            this._logger.name += " -Downloaddatabasefilesfromarchivallocation";
            // Invoke graphql operation downloadMssqlDatabaseFilesFromArchivalLocation
            InvokeMutationDownloadMssqlDatabaseFilesFromArchivalLocation();
        }

        // This parameter set invokes a single graphql operation:
        // downloadMssqlDatabaseBackupFiles.
        protected void ProcessRecord_Downloaddatabasebackupfile()
        {
            this._logger.name += " -Downloaddatabasebackupfile";
            // Invoke graphql operation downloadMssqlDatabaseBackupFiles
            InvokeMutationDownloadMssqlDatabaseBackupFiles();
        }

        // This parameter set invokes a single graphql operation:
        // assignMssqlSlaDomainProperties.
        protected void ProcessRecord_Assignsladomainpropertie()
        {
            this._logger.name += " -Assignsladomainpropertie";
            // Invoke graphql operation assignMssqlSlaDomainProperties
            InvokeMutationAssignMssqlSlaDomainProperties();
        }

        // This parameter set invokes a single graphql operation:
        // updateMssqlDefaultProperties.
        protected void ProcessRecord_Updatedefaultpropertie()
        {
            this._logger.name += " -Updatedefaultpropertie";
            // Invoke graphql operation updateMssqlDefaultProperties
            InvokeMutationUpdateMssqlDefaultProperties();
        }

        // This parameter set invokes a single graphql operation:
        // createMssqlLogShippingConfiguration.
        protected void ProcessRecord_Createlogshippingconfiguration()
        {
            this._logger.name += " -Createlogshippingconfiguration";
            // Invoke graphql operation createMssqlLogShippingConfiguration
            InvokeMutationCreateMssqlLogShippingConfiguration();
        }

        // This parameter set invokes a single graphql operation:
        // assignMssqlSlaDomainPropertiesAsync.
        protected void ProcessRecord_Assignsladomainpropertiesasync()
        {
            this._logger.name += " -Assignsladomainpropertiesasync";
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