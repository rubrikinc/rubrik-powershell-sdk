// Invoke-RscMutateOracle.cs
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
using Rubrik.SecurityCloud.NetSDK.Library.HelperClasses;
using Rubrik.SecurityCloud.Operations;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Invoke",
        "RscMutateOracle",
        DefaultParameterSetName = "restoreLog")
    ]
    public class Invoke_RscMutateOracle : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // bulkUpdateHost parameter set
        //
        // GraphQL operation: bulkUpdateOracleHosts(input: BulkUpdateOracleHostsInput!):BulkUpdateOracleHostsReply!
        //
        [Parameter(
            ParameterSetName = "bulkUpdateHost",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: bulkUpdateOracleHosts(input: BulkUpdateOracleHostsInput!):BulkUpdateOracleHostsReply!",
            Position = 0
        )]
        public SwitchParameter bulkUpdateHost { get; set; }

        [Parameter(
            ParameterSetName = "bulkUpdateHost",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument input: BulkUpdateOracleHostsInput!"
        )]
        public BulkUpdateOracleHostsInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // refreshDatabase parameter set
        //
        // GraphQL operation: refreshOracleDatabase(input: RefreshOracleDatabaseInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "refreshDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: refreshOracleDatabase(input: RefreshOracleDatabaseInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter refreshDatabase { get; set; }

        
        // -------------------------------------------------------------------
        // updateDataGuardGroup parameter set
        //
        // GraphQL operation: updateOracleDataGuardGroup(input: UpdateOracleDataGuardGroupInput!):OracleDbDetail!
        //
        [Parameter(
            ParameterSetName = "updateDataGuardGroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: updateOracleDataGuardGroup(input: UpdateOracleDataGuardGroupInput!):OracleDbDetail!",
            Position = 0
        )]
        public SwitchParameter updateDataGuardGroup { get; set; }

        
        // -------------------------------------------------------------------
        // deleteAllDatabaseSnapshot parameter set
        //
        // GraphQL operation: deleteAllOracleDatabaseSnapshots(input: DeleteAllOracleDatabaseSnapshotsInput!):Void
        //
        [Parameter(
            ParameterSetName = "deleteAllDatabaseSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: deleteAllOracleDatabaseSnapshots(input: DeleteAllOracleDatabaseSnapshotsInput!):Void",
            Position = 0
        )]
        public SwitchParameter deleteAllDatabaseSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // takeOnDemandDatabaseSnapshot parameter set
        //
        // GraphQL operation: takeOnDemandOracleDatabaseSnapshot(input: TakeOnDemandOracleDatabaseSnapshotInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "takeOnDemandDatabaseSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: takeOnDemandOracleDatabaseSnapshot(input: TakeOnDemandOracleDatabaseSnapshotInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter takeOnDemandDatabaseSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // takeOnDemandLogSnapshot parameter set
        //
        // GraphQL operation: takeOnDemandOracleLogSnapshot(input: TakeOnDemandOracleLogSnapshotInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "takeOnDemandLogSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: takeOnDemandOracleLogSnapshot(input: TakeOnDemandOracleLogSnapshotInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter takeOnDemandLogSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // bulkUpdateRac parameter set
        //
        // GraphQL operation: bulkUpdateOracleRacs(input: BulkUpdateOracleRacsInput!):BulkUpdateOracleRacsReply!
        //
        [Parameter(
            ParameterSetName = "bulkUpdateRac",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: bulkUpdateOracleRacs(input: BulkUpdateOracleRacsInput!):BulkUpdateOracleRacsReply!",
            Position = 0
        )]
        public SwitchParameter bulkUpdateRac { get; set; }

        
        // -------------------------------------------------------------------
        // exportTablespace parameter set
        //
        // GraphQL operation: exportOracleTablespace(input: ExportOracleTablespaceInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "exportTablespace",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: exportOracleTablespace(input: ExportOracleTablespaceInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter exportTablespace { get; set; }

        
        // -------------------------------------------------------------------
        // validateAcoFile parameter set
        //
        // GraphQL operation: validateOracleAcoFile(input: ValidateOracleAcoFileInput!):ValidateOracleAcoFileReply!
        //
        [Parameter(
            ParameterSetName = "validateAcoFile",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: validateOracleAcoFile(input: ValidateOracleAcoFileInput!):ValidateOracleAcoFileReply!",
            Position = 0
        )]
        public SwitchParameter validateAcoFile { get; set; }

        
        // -------------------------------------------------------------------
        // validateDatabaseBackup parameter set
        //
        // GraphQL operation: validateOracleDatabaseBackups(input: ValidateOracleDatabaseBackupsInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "validateDatabaseBackup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: validateOracleDatabaseBackups(input: ValidateOracleDatabaseBackupsInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter validateDatabaseBackup { get; set; }

        
        // -------------------------------------------------------------------
        // bulkUpdateDatabase parameter set
        //
        // GraphQL operation: bulkUpdateOracleDatabases(input: BulkUpdateOracleDatabasesInput!):BulkUpdateOracleDatabasesReply!
        //
        [Parameter(
            ParameterSetName = "bulkUpdateDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: bulkUpdateOracleDatabases(input: BulkUpdateOracleDatabasesInput!):BulkUpdateOracleDatabasesReply!",
            Position = 0
        )]
        public SwitchParameter bulkUpdateDatabase { get; set; }

        
        // -------------------------------------------------------------------
        // instantRecoverSnapshot parameter set
        //
        // GraphQL operation: instantRecoverOracleSnapshot(input: InstantRecoverOracleSnapshotInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "instantRecoverSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: instantRecoverOracleSnapshot(input: InstantRecoverOracleSnapshotInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter instantRecoverSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // mountDatabase parameter set
        //
        // GraphQL operation: mountOracleDatabase(input: MountOracleDatabaseInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "mountDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: mountOracleDatabase(input: MountOracleDatabaseInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter mountDatabase { get; set; }

        
        // -------------------------------------------------------------------
        // exportDatabase parameter set
        //
        // GraphQL operation: exportOracleDatabase(input: ExportOracleDatabaseInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "exportDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: exportOracleDatabase(input: ExportOracleDatabaseInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter exportDatabase { get; set; }

        
        // -------------------------------------------------------------------
        // createPdbRestore parameter set
        //
        // GraphQL operation: createOraclePdbRestore(input: CreateOraclePdbRestoreInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "createPdbRestore",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: createOraclePdbRestore(input: CreateOraclePdbRestoreInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter createPdbRestore { get; set; }

        
        // -------------------------------------------------------------------
        // downloadDatabaseSnapshot parameter set
        //
        // GraphQL operation: downloadOracleDatabaseSnapshot(input: DownloadOracleDatabaseSnapshotInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "downloadDatabaseSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: downloadOracleDatabaseSnapshot(input: DownloadOracleDatabaseSnapshotInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter downloadDatabaseSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // deleteMount parameter set
        //
        // GraphQL operation: deleteOracleMount(input: DeleteOracleMountInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "deleteMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: deleteOracleMount(input: DeleteOracleMountInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter deleteMount { get; set; }

        
        // -------------------------------------------------------------------
        // restoreLog parameter set
        //
        // GraphQL operation: restoreOracleLogs(input: RestoreOracleLogsInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "restoreLog",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: restoreOracleLogs(input: RestoreOracleLogsInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter restoreLog { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "bulkUpdateHost":
                        this.ProcessRecord_bulkUpdateHost();
                        break;
                    case "refreshDatabase":
                        this.ProcessRecord_refreshDatabase();
                        break;
                    case "updateDataGuardGroup":
                        this.ProcessRecord_updateDataGuardGroup();
                        break;
                    case "deleteAllDatabaseSnapshot":
                        this.ProcessRecord_deleteAllDatabaseSnapshot();
                        break;
                    case "takeOnDemandDatabaseSnapshot":
                        this.ProcessRecord_takeOnDemandDatabaseSnapshot();
                        break;
                    case "takeOnDemandLogSnapshot":
                        this.ProcessRecord_takeOnDemandLogSnapshot();
                        break;
                    case "bulkUpdateRac":
                        this.ProcessRecord_bulkUpdateRac();
                        break;
                    case "exportTablespace":
                        this.ProcessRecord_exportTablespace();
                        break;
                    case "validateAcoFile":
                        this.ProcessRecord_validateAcoFile();
                        break;
                    case "validateDatabaseBackup":
                        this.ProcessRecord_validateDatabaseBackup();
                        break;
                    case "bulkUpdateDatabase":
                        this.ProcessRecord_bulkUpdateDatabase();
                        break;
                    case "instantRecoverSnapshot":
                        this.ProcessRecord_instantRecoverSnapshot();
                        break;
                    case "mountDatabase":
                        this.ProcessRecord_mountDatabase();
                        break;
                    case "exportDatabase":
                        this.ProcessRecord_exportDatabase();
                        break;
                    case "createPdbRestore":
                        this.ProcessRecord_createPdbRestore();
                        break;
                    case "downloadDatabaseSnapshot":
                        this.ProcessRecord_downloadDatabaseSnapshot();
                        break;
                    case "deleteMount":
                        this.ProcessRecord_deleteMount();
                        break;
                    case "restoreLog":
                        this.ProcessRecord_restoreLog();
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
                    "Invoke-RscMutateOracle",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
           }
        }

        // This parameter set invokes a single graphql operation:
        // bulkUpdateOracleHosts.
        protected void ProcessRecord_bulkUpdateHost()
        {
            this._logger.name += " -bulkUpdateHost";
            // Invoke graphql operation bulkUpdateOracleHosts
            InvokeMutationBulkUpdateOracleHosts();
        }

        // This parameter set invokes a single graphql operation:
        // refreshOracleDatabase.
        protected void ProcessRecord_refreshDatabase()
        {
            this._logger.name += " -refreshDatabase";
            // Invoke graphql operation refreshOracleDatabase
            InvokeMutationRefreshOracleDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // updateOracleDataGuardGroup.
        protected void ProcessRecord_updateDataGuardGroup()
        {
            this._logger.name += " -updateDataGuardGroup";
            // Invoke graphql operation updateOracleDataGuardGroup
            InvokeMutationUpdateOracleDataGuardGroup();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAllOracleDatabaseSnapshots.
        protected void ProcessRecord_deleteAllDatabaseSnapshot()
        {
            this._logger.name += " -deleteAllDatabaseSnapshot";
            // Invoke graphql operation deleteAllOracleDatabaseSnapshots
            InvokeMutationDeleteAllOracleDatabaseSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // takeOnDemandOracleDatabaseSnapshot.
        protected void ProcessRecord_takeOnDemandDatabaseSnapshot()
        {
            this._logger.name += " -takeOnDemandDatabaseSnapshot";
            // Invoke graphql operation takeOnDemandOracleDatabaseSnapshot
            InvokeMutationTakeOnDemandOracleDatabaseSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // takeOnDemandOracleLogSnapshot.
        protected void ProcessRecord_takeOnDemandLogSnapshot()
        {
            this._logger.name += " -takeOnDemandLogSnapshot";
            // Invoke graphql operation takeOnDemandOracleLogSnapshot
            InvokeMutationTakeOnDemandOracleLogSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // bulkUpdateOracleRacs.
        protected void ProcessRecord_bulkUpdateRac()
        {
            this._logger.name += " -bulkUpdateRac";
            // Invoke graphql operation bulkUpdateOracleRacs
            InvokeMutationBulkUpdateOracleRacs();
        }

        // This parameter set invokes a single graphql operation:
        // exportOracleTablespace.
        protected void ProcessRecord_exportTablespace()
        {
            this._logger.name += " -exportTablespace";
            // Invoke graphql operation exportOracleTablespace
            InvokeMutationExportOracleTablespace();
        }

        // This parameter set invokes a single graphql operation:
        // validateOracleAcoFile.
        protected void ProcessRecord_validateAcoFile()
        {
            this._logger.name += " -validateAcoFile";
            // Invoke graphql operation validateOracleAcoFile
            InvokeMutationValidateOracleAcoFile();
        }

        // This parameter set invokes a single graphql operation:
        // validateOracleDatabaseBackups.
        protected void ProcessRecord_validateDatabaseBackup()
        {
            this._logger.name += " -validateDatabaseBackup";
            // Invoke graphql operation validateOracleDatabaseBackups
            InvokeMutationValidateOracleDatabaseBackups();
        }

        // This parameter set invokes a single graphql operation:
        // bulkUpdateOracleDatabases.
        protected void ProcessRecord_bulkUpdateDatabase()
        {
            this._logger.name += " -bulkUpdateDatabase";
            // Invoke graphql operation bulkUpdateOracleDatabases
            InvokeMutationBulkUpdateOracleDatabases();
        }

        // This parameter set invokes a single graphql operation:
        // instantRecoverOracleSnapshot.
        protected void ProcessRecord_instantRecoverSnapshot()
        {
            this._logger.name += " -instantRecoverSnapshot";
            // Invoke graphql operation instantRecoverOracleSnapshot
            InvokeMutationInstantRecoverOracleSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // mountOracleDatabase.
        protected void ProcessRecord_mountDatabase()
        {
            this._logger.name += " -mountDatabase";
            // Invoke graphql operation mountOracleDatabase
            InvokeMutationMountOracleDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // exportOracleDatabase.
        protected void ProcessRecord_exportDatabase()
        {
            this._logger.name += " -exportDatabase";
            // Invoke graphql operation exportOracleDatabase
            InvokeMutationExportOracleDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // createOraclePdbRestore.
        protected void ProcessRecord_createPdbRestore()
        {
            this._logger.name += " -createPdbRestore";
            // Invoke graphql operation createOraclePdbRestore
            InvokeMutationCreateOraclePdbRestore();
        }

        // This parameter set invokes a single graphql operation:
        // downloadOracleDatabaseSnapshot.
        protected void ProcessRecord_downloadDatabaseSnapshot()
        {
            this._logger.name += " -downloadDatabaseSnapshot";
            // Invoke graphql operation downloadOracleDatabaseSnapshot
            InvokeMutationDownloadOracleDatabaseSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // deleteOracleMount.
        protected void ProcessRecord_deleteMount()
        {
            this._logger.name += " -deleteMount";
            // Invoke graphql operation deleteOracleMount
            InvokeMutationDeleteOracleMount();
        }

        // This parameter set invokes a single graphql operation:
        // restoreOracleLogs.
        protected void ProcessRecord_restoreLog()
        {
            this._logger.name += " -restoreLog";
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
            BulkUpdateOracleHostsReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BulkUpdateOracleHostsReply)psObject.BaseObject;
                } else {
                    fields = (BulkUpdateOracleHostsReply)this.Field;
                }
            }
            string document = Mutation.BulkUpdateOracleHosts(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BulkUpdateOracleHosts");
            string parameters = "($input: BulkUpdateOracleHostsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBulkUpdateOracleHosts" + parameters + "{" + document + "}",
                OperationName = "MutationBulkUpdateOracleHosts",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BulkUpdateOracleHostsReply> task = this._rbkClient.InvokeGenericCallAsync<BulkUpdateOracleHostsReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // refreshOracleDatabase(input: RefreshOracleDatabaseInput!): AsyncRequestStatus!
        protected void InvokeMutationRefreshOracleDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshOracleDatabaseInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.RefreshOracleDatabase(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RefreshOracleDatabase");
            string parameters = "($input: RefreshOracleDatabaseInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRefreshOracleDatabase" + parameters + "{" + document + "}",
                OperationName = "MutationRefreshOracleDatabase",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // updateOracleDataGuardGroup(input: UpdateOracleDataGuardGroupInput!): OracleDbDetail!
        protected void InvokeMutationUpdateOracleDataGuardGroup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateOracleDataGuardGroupInput!"),
            };
            OracleDbDetail? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (OracleDbDetail)psObject.BaseObject;
                } else {
                    fields = (OracleDbDetail)this.Field;
                }
            }
            string document = Mutation.UpdateOracleDataGuardGroup(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateOracleDataGuardGroup");
            string parameters = "($input: UpdateOracleDataGuardGroupInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateOracleDataGuardGroup" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateOracleDataGuardGroup",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<OracleDbDetail> task = this._rbkClient.InvokeGenericCallAsync<OracleDbDetail>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteAllOracleDatabaseSnapshots(input: DeleteAllOracleDatabaseSnapshotsInput!): Void
        protected void InvokeMutationDeleteAllOracleDatabaseSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAllOracleDatabaseSnapshotsInput!"),
            };
            System.String? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (System.String)psObject.BaseObject;
                } else {
                    fields = (System.String)this.Field;
                }
            }
            string document = Mutation.DeleteAllOracleDatabaseSnapshots(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteAllOracleDatabaseSnapshots");
            string parameters = "($input: DeleteAllOracleDatabaseSnapshotsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteAllOracleDatabaseSnapshots" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteAllOracleDatabaseSnapshots",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<System.String> task = this._rbkClient.InvokeGenericCallAsync<System.String>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // takeOnDemandOracleDatabaseSnapshot(input: TakeOnDemandOracleDatabaseSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationTakeOnDemandOracleDatabaseSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "TakeOnDemandOracleDatabaseSnapshotInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.TakeOnDemandOracleDatabaseSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.TakeOnDemandOracleDatabaseSnapshot");
            string parameters = "($input: TakeOnDemandOracleDatabaseSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationTakeOnDemandOracleDatabaseSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationTakeOnDemandOracleDatabaseSnapshot",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // takeOnDemandOracleLogSnapshot(input: TakeOnDemandOracleLogSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationTakeOnDemandOracleLogSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "TakeOnDemandOracleLogSnapshotInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.TakeOnDemandOracleLogSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.TakeOnDemandOracleLogSnapshot");
            string parameters = "($input: TakeOnDemandOracleLogSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationTakeOnDemandOracleLogSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationTakeOnDemandOracleLogSnapshot",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // bulkUpdateOracleRacs(input: BulkUpdateOracleRacsInput!): BulkUpdateOracleRacsReply!
        protected void InvokeMutationBulkUpdateOracleRacs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkUpdateOracleRacsInput!"),
            };
            BulkUpdateOracleRacsReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BulkUpdateOracleRacsReply)psObject.BaseObject;
                } else {
                    fields = (BulkUpdateOracleRacsReply)this.Field;
                }
            }
            string document = Mutation.BulkUpdateOracleRacs(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BulkUpdateOracleRacs");
            string parameters = "($input: BulkUpdateOracleRacsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBulkUpdateOracleRacs" + parameters + "{" + document + "}",
                OperationName = "MutationBulkUpdateOracleRacs",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BulkUpdateOracleRacsReply> task = this._rbkClient.InvokeGenericCallAsync<BulkUpdateOracleRacsReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // exportOracleTablespace(input: ExportOracleTablespaceInput!): AsyncRequestStatus!
        protected void InvokeMutationExportOracleTablespace()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportOracleTablespaceInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.ExportOracleTablespace(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.ExportOracleTablespace");
            string parameters = "($input: ExportOracleTablespaceInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationExportOracleTablespace" + parameters + "{" + document + "}",
                OperationName = "MutationExportOracleTablespace",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // validateOracleAcoFile(input: ValidateOracleAcoFileInput!): ValidateOracleAcoFileReply!
        protected void InvokeMutationValidateOracleAcoFile()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ValidateOracleAcoFileInput!"),
            };
            ValidateOracleAcoFileReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (ValidateOracleAcoFileReply)psObject.BaseObject;
                } else {
                    fields = (ValidateOracleAcoFileReply)this.Field;
                }
            }
            string document = Mutation.ValidateOracleAcoFile(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.ValidateOracleAcoFile");
            string parameters = "($input: ValidateOracleAcoFileInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationValidateOracleAcoFile" + parameters + "{" + document + "}",
                OperationName = "MutationValidateOracleAcoFile",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<ValidateOracleAcoFileReply> task = this._rbkClient.InvokeGenericCallAsync<ValidateOracleAcoFileReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // validateOracleDatabaseBackups(input: ValidateOracleDatabaseBackupsInput!): AsyncRequestStatus!
        protected void InvokeMutationValidateOracleDatabaseBackups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ValidateOracleDatabaseBackupsInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.ValidateOracleDatabaseBackups(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.ValidateOracleDatabaseBackups");
            string parameters = "($input: ValidateOracleDatabaseBackupsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationValidateOracleDatabaseBackups" + parameters + "{" + document + "}",
                OperationName = "MutationValidateOracleDatabaseBackups",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // bulkUpdateOracleDatabases(input: BulkUpdateOracleDatabasesInput!): BulkUpdateOracleDatabasesReply!
        protected void InvokeMutationBulkUpdateOracleDatabases()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkUpdateOracleDatabasesInput!"),
            };
            BulkUpdateOracleDatabasesReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BulkUpdateOracleDatabasesReply)psObject.BaseObject;
                } else {
                    fields = (BulkUpdateOracleDatabasesReply)this.Field;
                }
            }
            string document = Mutation.BulkUpdateOracleDatabases(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BulkUpdateOracleDatabases");
            string parameters = "($input: BulkUpdateOracleDatabasesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBulkUpdateOracleDatabases" + parameters + "{" + document + "}",
                OperationName = "MutationBulkUpdateOracleDatabases",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BulkUpdateOracleDatabasesReply> task = this._rbkClient.InvokeGenericCallAsync<BulkUpdateOracleDatabasesReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // instantRecoverOracleSnapshot(input: InstantRecoverOracleSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationInstantRecoverOracleSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "InstantRecoverOracleSnapshotInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.InstantRecoverOracleSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.InstantRecoverOracleSnapshot");
            string parameters = "($input: InstantRecoverOracleSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationInstantRecoverOracleSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationInstantRecoverOracleSnapshot",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // mountOracleDatabase(input: MountOracleDatabaseInput!): AsyncRequestStatus!
        protected void InvokeMutationMountOracleDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MountOracleDatabaseInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.MountOracleDatabase(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.MountOracleDatabase");
            string parameters = "($input: MountOracleDatabaseInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationMountOracleDatabase" + parameters + "{" + document + "}",
                OperationName = "MutationMountOracleDatabase",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // exportOracleDatabase(input: ExportOracleDatabaseInput!): AsyncRequestStatus!
        protected void InvokeMutationExportOracleDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportOracleDatabaseInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.ExportOracleDatabase(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.ExportOracleDatabase");
            string parameters = "($input: ExportOracleDatabaseInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationExportOracleDatabase" + parameters + "{" + document + "}",
                OperationName = "MutationExportOracleDatabase",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // createOraclePdbRestore(input: CreateOraclePdbRestoreInput!): AsyncRequestStatus!
        protected void InvokeMutationCreateOraclePdbRestore()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateOraclePdbRestoreInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.CreateOraclePdbRestore(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateOraclePdbRestore");
            string parameters = "($input: CreateOraclePdbRestoreInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateOraclePdbRestore" + parameters + "{" + document + "}",
                OperationName = "MutationCreateOraclePdbRestore",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // downloadOracleDatabaseSnapshot(input: DownloadOracleDatabaseSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationDownloadOracleDatabaseSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadOracleDatabaseSnapshotInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.DownloadOracleDatabaseSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DownloadOracleDatabaseSnapshot");
            string parameters = "($input: DownloadOracleDatabaseSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDownloadOracleDatabaseSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationDownloadOracleDatabaseSnapshot",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteOracleMount(input: DeleteOracleMountInput!): AsyncRequestStatus!
        protected void InvokeMutationDeleteOracleMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteOracleMountInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.DeleteOracleMount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteOracleMount");
            string parameters = "($input: DeleteOracleMountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteOracleMount" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteOracleMount",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // restoreOracleLogs(input: RestoreOracleLogsInput!): AsyncRequestStatus!
        protected void InvokeMutationRestoreOracleLogs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreOracleLogsInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.RestoreOracleLogs(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RestoreOracleLogs");
            string parameters = "($input: RestoreOracleLogsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRestoreOracleLogs" + parameters + "{" + document + "}",
                OperationName = "MutationRestoreOracleLogs",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }


    } // class Invoke_RscMutateOracle
}