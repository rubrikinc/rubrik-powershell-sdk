// Mutate-RscNutanix.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:44.
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
        "Mutate",
        "RscNutanix",
        DefaultParameterSetName = "updateVm")
    ]
    public class Mutate_RscNutanix : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // createCluster parameter set
        //
        // GraphQL operation: createNutanixCluster(input: CreateNutanixClusterInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "createCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: createNutanixCluster(input: CreateNutanixClusterInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter createCluster { get; set; }

        [Parameter(
            ParameterSetName = "createCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument input: CreateNutanixClusterInput!"
        )]
        public CreateNutanixClusterInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // refreshCluster parameter set
        //
        // GraphQL operation: refreshNutanixCluster(input: RefreshNutanixClusterInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "refreshCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: refreshNutanixCluster(input: RefreshNutanixClusterInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter refreshCluster { get; set; }

        
        // -------------------------------------------------------------------
        // updateCluster parameter set
        //
        // GraphQL operation: updateNutanixCluster(input: UpdateNutanixClusterInput!):UpdateNutanixClusterReply!
        //
        [Parameter(
            ParameterSetName = "updateCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: updateNutanixCluster(input: UpdateNutanixClusterInput!):UpdateNutanixClusterReply!",
            Position = 0
        )]
        public SwitchParameter updateCluster { get; set; }

        
        // -------------------------------------------------------------------
        // deleteCluster parameter set
        //
        // GraphQL operation: deleteNutanixCluster(input: DeleteNutanixClusterInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "deleteCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: deleteNutanixCluster(input: DeleteNutanixClusterInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter deleteCluster { get; set; }

        
        // -------------------------------------------------------------------
        // registerAgentVm parameter set
        //
        // GraphQL operation: registerAgentNutanixVm(input: RegisterAgentNutanixVmInput!):RequestSuccess!
        //
        [Parameter(
            ParameterSetName = "registerAgentVm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: registerAgentNutanixVm(input: RegisterAgentNutanixVmInput!):RequestSuccess!",
            Position = 0
        )]
        public SwitchParameter registerAgentVm { get; set; }

        
        // -------------------------------------------------------------------
        // updateVm parameter set
        //
        // GraphQL operation: updateNutanixVm(input: UpdateNutanixVmInput!):Void
        //
        [Parameter(
            ParameterSetName = "updateVm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: updateNutanixVm(input: UpdateNutanixVmInput!):Void",
            Position = 0
        )]
        public SwitchParameter updateVm { get; set; }

        
        // -------------------------------------------------------------------
        // createOnDemandBackup parameter set
        //
        // GraphQL operation: createOnDemandNutanixBackup(input: CreateOnDemandNutanixBackupInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "createOnDemandBackup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: createOnDemandNutanixBackup(input: CreateOnDemandNutanixBackupInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter createOnDemandBackup { get; set; }

        
        // -------------------------------------------------------------------
        // deleteSnapshot parameter set
        //
        // GraphQL operation: deleteNutanixSnapshots(input: DeleteNutanixSnapshotsInput!):RequestSuccess!
        //
        [Parameter(
            ParameterSetName = "deleteSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: deleteNutanixSnapshots(input: DeleteNutanixSnapshotsInput!):RequestSuccess!",
            Position = 0
        )]
        public SwitchParameter deleteSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // mountSnapshotV1 parameter set
        //
        // GraphQL operation: mountNutanixSnapshotV1(input: MountNutanixSnapshotV1Input!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "mountSnapshotV1",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: mountNutanixSnapshotV1(input: MountNutanixSnapshotV1Input!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter mountSnapshotV1 { get; set; }

        
        // -------------------------------------------------------------------
        // patchMountV1 parameter set
        //
        // GraphQL operation: patchNutanixMountV1(input: PatchNutanixMountV1Input!):PatchNutanixMountV1Reply!
        //
        [Parameter(
            ParameterSetName = "patchMountV1",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: patchNutanixMountV1(input: PatchNutanixMountV1Input!):PatchNutanixMountV1Reply!",
            Position = 0
        )]
        public SwitchParameter patchMountV1 { get; set; }

        
        // -------------------------------------------------------------------
        // deleteMountV1 parameter set
        //
        // GraphQL operation: deleteNutanixMountV1(input: DeleteNutanixMountV1Input!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "deleteMountV1",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: deleteNutanixMountV1(input: DeleteNutanixMountV1Input!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter deleteMountV1 { get; set; }

        
        // -------------------------------------------------------------------
        // migrateMountV1 parameter set
        //
        // GraphQL operation: migrateNutanixMountV1(input: MigrateNutanixMountV1Input!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "migrateMountV1",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: migrateNutanixMountV1(input: MigrateNutanixMountV1Input!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter migrateMountV1 { get; set; }

        
        // -------------------------------------------------------------------
        // restoreFilesSnapshot parameter set
        //
        // GraphQL operation: restoreFilesNutanixSnapshot(input: RestoreFilesNutanixSnapshotInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "restoreFilesSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: restoreFilesNutanixSnapshot(input: RestoreFilesNutanixSnapshotInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter restoreFilesSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // downloadFilesSnapshot parameter set
        //
        // GraphQL operation: downloadFilesNutanixSnapshot(input: DownloadFilesNutanixSnapshotInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "downloadFilesSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: downloadFilesNutanixSnapshot(input: DownloadFilesNutanixSnapshotInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter downloadFilesSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // exportSnapshot parameter set
        //
        // GraphQL operation: exportNutanixSnapshot(input: ExportNutanixSnapshotInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "exportSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: exportNutanixSnapshot(input: ExportNutanixSnapshotInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter exportSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // downloadSnapshot parameter set
        //
        // GraphQL operation: downloadNutanixSnapshot(input: DownloadNutanixSnapshotInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "downloadSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: downloadNutanixSnapshot(input: DownloadNutanixSnapshotInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter downloadSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // batchExportVm parameter set
        //
        // GraphQL operation: batchExportNutanixVm(input: BatchExportNutanixVmInput!):BatchExportNutanixVmReply!
        //
        [Parameter(
            ParameterSetName = "batchExportVm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: batchExportNutanixVm(input: BatchExportNutanixVmInput!):BatchExportNutanixVmReply!",
            Position = 0
        )]
        public SwitchParameter batchExportVm { get; set; }

        
        // -------------------------------------------------------------------
        // batchMountVm parameter set
        //
        // GraphQL operation: batchMountNutanixVm(input: BatchMountNutanixVmInput!):BatchMountNutanixVmReply!
        //
        [Parameter(
            ParameterSetName = "batchMountVm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: batchMountNutanixVm(input: BatchMountNutanixVmInput!):BatchMountNutanixVmReply!",
            Position = 0
        )]
        public SwitchParameter batchMountVm { get; set; }

        
        // -------------------------------------------------------------------
        // downloadVmFromLocation parameter set
        //
        // GraphQL operation: downloadNutanixVmFromLocation(input: DownloadNutanixVmFromLocationInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "downloadVmFromLocation",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: downloadNutanixVmFromLocation(input: DownloadNutanixVmFromLocationInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter downloadVmFromLocation { get; set; }

        
        // -------------------------------------------------------------------
        // bulkOnDemandSnapshotVm parameter set
        //
        // GraphQL operation: bulkOnDemandSnapshotNutanixVm(input: BulkOnDemandSnapshotNutanixVmInput!):BulkOnDemandSnapshotNutanixVmReply!
        //
        [Parameter(
            ParameterSetName = "bulkOnDemandSnapshotVm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: bulkOnDemandSnapshotNutanixVm(input: BulkOnDemandSnapshotNutanixVmInput!):BulkOnDemandSnapshotNutanixVmReply!",
            Position = 0
        )]
        public SwitchParameter bulkOnDemandSnapshotVm { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "createCluster":
                        this.ProcessRecord_createCluster();
                        break;
                    case "refreshCluster":
                        this.ProcessRecord_refreshCluster();
                        break;
                    case "updateCluster":
                        this.ProcessRecord_updateCluster();
                        break;
                    case "deleteCluster":
                        this.ProcessRecord_deleteCluster();
                        break;
                    case "registerAgentVm":
                        this.ProcessRecord_registerAgentVm();
                        break;
                    case "updateVm":
                        this.ProcessRecord_updateVm();
                        break;
                    case "createOnDemandBackup":
                        this.ProcessRecord_createOnDemandBackup();
                        break;
                    case "deleteSnapshot":
                        this.ProcessRecord_deleteSnapshot();
                        break;
                    case "mountSnapshotV1":
                        this.ProcessRecord_mountSnapshotV1();
                        break;
                    case "patchMountV1":
                        this.ProcessRecord_patchMountV1();
                        break;
                    case "deleteMountV1":
                        this.ProcessRecord_deleteMountV1();
                        break;
                    case "migrateMountV1":
                        this.ProcessRecord_migrateMountV1();
                        break;
                    case "restoreFilesSnapshot":
                        this.ProcessRecord_restoreFilesSnapshot();
                        break;
                    case "downloadFilesSnapshot":
                        this.ProcessRecord_downloadFilesSnapshot();
                        break;
                    case "exportSnapshot":
                        this.ProcessRecord_exportSnapshot();
                        break;
                    case "downloadSnapshot":
                        this.ProcessRecord_downloadSnapshot();
                        break;
                    case "batchExportVm":
                        this.ProcessRecord_batchExportVm();
                        break;
                    case "batchMountVm":
                        this.ProcessRecord_batchMountVm();
                        break;
                    case "downloadVmFromLocation":
                        this.ProcessRecord_downloadVmFromLocation();
                        break;
                    case "bulkOnDemandSnapshotVm":
                        this.ProcessRecord_bulkOnDemandSnapshotVm();
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
                    "Mutate-RscNutanix",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
           }
        }

        // This parameter set invokes a single graphql operation:
        // createNutanixCluster.
        protected void ProcessRecord_createCluster()
        {
            this._logger.name += " -createCluster";
            // Invoke graphql operation createNutanixCluster
            InvokeMutationCreateNutanixCluster();
        }

        // This parameter set invokes a single graphql operation:
        // refreshNutanixCluster.
        protected void ProcessRecord_refreshCluster()
        {
            this._logger.name += " -refreshCluster";
            // Invoke graphql operation refreshNutanixCluster
            InvokeMutationRefreshNutanixCluster();
        }

        // This parameter set invokes a single graphql operation:
        // updateNutanixCluster.
        protected void ProcessRecord_updateCluster()
        {
            this._logger.name += " -updateCluster";
            // Invoke graphql operation updateNutanixCluster
            InvokeMutationUpdateNutanixCluster();
        }

        // This parameter set invokes a single graphql operation:
        // deleteNutanixCluster.
        protected void ProcessRecord_deleteCluster()
        {
            this._logger.name += " -deleteCluster";
            // Invoke graphql operation deleteNutanixCluster
            InvokeMutationDeleteNutanixCluster();
        }

        // This parameter set invokes a single graphql operation:
        // registerAgentNutanixVm.
        protected void ProcessRecord_registerAgentVm()
        {
            this._logger.name += " -registerAgentVm";
            // Invoke graphql operation registerAgentNutanixVm
            InvokeMutationRegisterAgentNutanixVm();
        }

        // This parameter set invokes a single graphql operation:
        // updateNutanixVm.
        protected void ProcessRecord_updateVm()
        {
            this._logger.name += " -updateVm";
            // Invoke graphql operation updateNutanixVm
            InvokeMutationUpdateNutanixVm();
        }

        // This parameter set invokes a single graphql operation:
        // createOnDemandNutanixBackup.
        protected void ProcessRecord_createOnDemandBackup()
        {
            this._logger.name += " -createOnDemandBackup";
            // Invoke graphql operation createOnDemandNutanixBackup
            InvokeMutationCreateOnDemandNutanixBackup();
        }

        // This parameter set invokes a single graphql operation:
        // deleteNutanixSnapshots.
        protected void ProcessRecord_deleteSnapshot()
        {
            this._logger.name += " -deleteSnapshot";
            // Invoke graphql operation deleteNutanixSnapshots
            InvokeMutationDeleteNutanixSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // mountNutanixSnapshotV1.
        protected void ProcessRecord_mountSnapshotV1()
        {
            this._logger.name += " -mountSnapshotV1";
            // Invoke graphql operation mountNutanixSnapshotV1
            InvokeMutationMountNutanixSnapshotV1();
        }

        // This parameter set invokes a single graphql operation:
        // patchNutanixMountV1.
        protected void ProcessRecord_patchMountV1()
        {
            this._logger.name += " -patchMountV1";
            // Invoke graphql operation patchNutanixMountV1
            InvokeMutationPatchNutanixMountV1();
        }

        // This parameter set invokes a single graphql operation:
        // deleteNutanixMountV1.
        protected void ProcessRecord_deleteMountV1()
        {
            this._logger.name += " -deleteMountV1";
            // Invoke graphql operation deleteNutanixMountV1
            InvokeMutationDeleteNutanixMountV1();
        }

        // This parameter set invokes a single graphql operation:
        // migrateNutanixMountV1.
        protected void ProcessRecord_migrateMountV1()
        {
            this._logger.name += " -migrateMountV1";
            // Invoke graphql operation migrateNutanixMountV1
            InvokeMutationMigrateNutanixMountV1();
        }

        // This parameter set invokes a single graphql operation:
        // restoreFilesNutanixSnapshot.
        protected void ProcessRecord_restoreFilesSnapshot()
        {
            this._logger.name += " -restoreFilesSnapshot";
            // Invoke graphql operation restoreFilesNutanixSnapshot
            InvokeMutationRestoreFilesNutanixSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // downloadFilesNutanixSnapshot.
        protected void ProcessRecord_downloadFilesSnapshot()
        {
            this._logger.name += " -downloadFilesSnapshot";
            // Invoke graphql operation downloadFilesNutanixSnapshot
            InvokeMutationDownloadFilesNutanixSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // exportNutanixSnapshot.
        protected void ProcessRecord_exportSnapshot()
        {
            this._logger.name += " -exportSnapshot";
            // Invoke graphql operation exportNutanixSnapshot
            InvokeMutationExportNutanixSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // downloadNutanixSnapshot.
        protected void ProcessRecord_downloadSnapshot()
        {
            this._logger.name += " -downloadSnapshot";
            // Invoke graphql operation downloadNutanixSnapshot
            InvokeMutationDownloadNutanixSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // batchExportNutanixVm.
        protected void ProcessRecord_batchExportVm()
        {
            this._logger.name += " -batchExportVm";
            // Invoke graphql operation batchExportNutanixVm
            InvokeMutationBatchExportNutanixVm();
        }

        // This parameter set invokes a single graphql operation:
        // batchMountNutanixVm.
        protected void ProcessRecord_batchMountVm()
        {
            this._logger.name += " -batchMountVm";
            // Invoke graphql operation batchMountNutanixVm
            InvokeMutationBatchMountNutanixVm();
        }

        // This parameter set invokes a single graphql operation:
        // downloadNutanixVmFromLocation.
        protected void ProcessRecord_downloadVmFromLocation()
        {
            this._logger.name += " -downloadVmFromLocation";
            // Invoke graphql operation downloadNutanixVmFromLocation
            InvokeMutationDownloadNutanixVmFromLocation();
        }

        // This parameter set invokes a single graphql operation:
        // bulkOnDemandSnapshotNutanixVm.
        protected void ProcessRecord_bulkOnDemandSnapshotVm()
        {
            this._logger.name += " -bulkOnDemandSnapshotVm";
            // Invoke graphql operation bulkOnDemandSnapshotNutanixVm
            InvokeMutationBulkOnDemandSnapshotNutanixVm();
        }


        // Invoke GraphQL Mutation:
        // createNutanixCluster(input: CreateNutanixClusterInput!): AsyncRequestStatus!
        protected void InvokeMutationCreateNutanixCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateNutanixClusterInput!"),
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
            string document = Mutation.CreateNutanixCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateNutanixCluster");
            string parameters = "($input: CreateNutanixClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateNutanixCluster" + parameters + "{" + document + "}",
                OperationName = "MutationCreateNutanixCluster",
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
        // refreshNutanixCluster(input: RefreshNutanixClusterInput!): AsyncRequestStatus!
        protected void InvokeMutationRefreshNutanixCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshNutanixClusterInput!"),
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
            string document = Mutation.RefreshNutanixCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RefreshNutanixCluster");
            string parameters = "($input: RefreshNutanixClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRefreshNutanixCluster" + parameters + "{" + document + "}",
                OperationName = "MutationRefreshNutanixCluster",
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
        // updateNutanixCluster(input: UpdateNutanixClusterInput!): UpdateNutanixClusterReply!
        protected void InvokeMutationUpdateNutanixCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateNutanixClusterInput!"),
            };
            UpdateNutanixClusterReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (UpdateNutanixClusterReply)psObject.BaseObject;
                } else {
                    fields = (UpdateNutanixClusterReply)this.Field;
                }
            }
            string document = Mutation.UpdateNutanixCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateNutanixCluster");
            string parameters = "($input: UpdateNutanixClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateNutanixCluster" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateNutanixCluster",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<UpdateNutanixClusterReply> task = this._rbkClient.InvokeGenericCallAsync<UpdateNutanixClusterReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteNutanixCluster(input: DeleteNutanixClusterInput!): AsyncRequestStatus!
        protected void InvokeMutationDeleteNutanixCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteNutanixClusterInput!"),
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
            string document = Mutation.DeleteNutanixCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteNutanixCluster");
            string parameters = "($input: DeleteNutanixClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteNutanixCluster" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteNutanixCluster",
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
        // registerAgentNutanixVm(input: RegisterAgentNutanixVmInput!): RequestSuccess!
        protected void InvokeMutationRegisterAgentNutanixVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RegisterAgentNutanixVmInput!"),
            };
            RequestSuccess? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (RequestSuccess)psObject.BaseObject;
                } else {
                    fields = (RequestSuccess)this.Field;
                }
            }
            string document = Mutation.RegisterAgentNutanixVm(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RegisterAgentNutanixVm");
            string parameters = "($input: RegisterAgentNutanixVmInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRegisterAgentNutanixVm" + parameters + "{" + document + "}",
                OperationName = "MutationRegisterAgentNutanixVm",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<RequestSuccess> task = this._rbkClient.InvokeGenericCallAsync<RequestSuccess>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // updateNutanixVm(input: UpdateNutanixVmInput!): Void
        protected void InvokeMutationUpdateNutanixVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateNutanixVmInput!"),
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
            string document = Mutation.UpdateNutanixVm(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateNutanixVm");
            string parameters = "($input: UpdateNutanixVmInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateNutanixVm" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateNutanixVm",
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
        // createOnDemandNutanixBackup(input: CreateOnDemandNutanixBackupInput!): AsyncRequestStatus!
        protected void InvokeMutationCreateOnDemandNutanixBackup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateOnDemandNutanixBackupInput!"),
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
            string document = Mutation.CreateOnDemandNutanixBackup(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateOnDemandNutanixBackup");
            string parameters = "($input: CreateOnDemandNutanixBackupInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateOnDemandNutanixBackup" + parameters + "{" + document + "}",
                OperationName = "MutationCreateOnDemandNutanixBackup",
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
        // deleteNutanixSnapshots(input: DeleteNutanixSnapshotsInput!): RequestSuccess!
        protected void InvokeMutationDeleteNutanixSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteNutanixSnapshotsInput!"),
            };
            RequestSuccess? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (RequestSuccess)psObject.BaseObject;
                } else {
                    fields = (RequestSuccess)this.Field;
                }
            }
            string document = Mutation.DeleteNutanixSnapshots(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteNutanixSnapshots");
            string parameters = "($input: DeleteNutanixSnapshotsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteNutanixSnapshots" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteNutanixSnapshots",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<RequestSuccess> task = this._rbkClient.InvokeGenericCallAsync<RequestSuccess>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // mountNutanixSnapshotV1(input: MountNutanixSnapshotV1Input!): AsyncRequestStatus!
        protected void InvokeMutationMountNutanixSnapshotV1()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MountNutanixSnapshotV1Input!"),
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
            string document = Mutation.MountNutanixSnapshotV1(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.MountNutanixSnapshotV1");
            string parameters = "($input: MountNutanixSnapshotV1Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationMountNutanixSnapshotV1" + parameters + "{" + document + "}",
                OperationName = "MutationMountNutanixSnapshotV1",
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
        // patchNutanixMountV1(input: PatchNutanixMountV1Input!): PatchNutanixMountV1Reply!
        protected void InvokeMutationPatchNutanixMountV1()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PatchNutanixMountV1Input!"),
            };
            PatchNutanixMountV1Reply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (PatchNutanixMountV1Reply)psObject.BaseObject;
                } else {
                    fields = (PatchNutanixMountV1Reply)this.Field;
                }
            }
            string document = Mutation.PatchNutanixMountV1(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.PatchNutanixMountV1");
            string parameters = "($input: PatchNutanixMountV1Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationPatchNutanixMountV1" + parameters + "{" + document + "}",
                OperationName = "MutationPatchNutanixMountV1",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<PatchNutanixMountV1Reply> task = this._rbkClient.InvokeGenericCallAsync<PatchNutanixMountV1Reply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteNutanixMountV1(input: DeleteNutanixMountV1Input!): AsyncRequestStatus!
        protected void InvokeMutationDeleteNutanixMountV1()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteNutanixMountV1Input!"),
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
            string document = Mutation.DeleteNutanixMountV1(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteNutanixMountV1");
            string parameters = "($input: DeleteNutanixMountV1Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteNutanixMountV1" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteNutanixMountV1",
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
        // migrateNutanixMountV1(input: MigrateNutanixMountV1Input!): AsyncRequestStatus!
        protected void InvokeMutationMigrateNutanixMountV1()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MigrateNutanixMountV1Input!"),
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
            string document = Mutation.MigrateNutanixMountV1(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.MigrateNutanixMountV1");
            string parameters = "($input: MigrateNutanixMountV1Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationMigrateNutanixMountV1" + parameters + "{" + document + "}",
                OperationName = "MutationMigrateNutanixMountV1",
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
        // restoreFilesNutanixSnapshot(input: RestoreFilesNutanixSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationRestoreFilesNutanixSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreFilesNutanixSnapshotInput!"),
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
            string document = Mutation.RestoreFilesNutanixSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RestoreFilesNutanixSnapshot");
            string parameters = "($input: RestoreFilesNutanixSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRestoreFilesNutanixSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationRestoreFilesNutanixSnapshot",
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
        // downloadFilesNutanixSnapshot(input: DownloadFilesNutanixSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationDownloadFilesNutanixSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadFilesNutanixSnapshotInput!"),
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
            string document = Mutation.DownloadFilesNutanixSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DownloadFilesNutanixSnapshot");
            string parameters = "($input: DownloadFilesNutanixSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDownloadFilesNutanixSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationDownloadFilesNutanixSnapshot",
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
        // exportNutanixSnapshot(input: ExportNutanixSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationExportNutanixSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportNutanixSnapshotInput!"),
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
            string document = Mutation.ExportNutanixSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.ExportNutanixSnapshot");
            string parameters = "($input: ExportNutanixSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationExportNutanixSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationExportNutanixSnapshot",
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
        // downloadNutanixSnapshot(input: DownloadNutanixSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationDownloadNutanixSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadNutanixSnapshotInput!"),
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
            string document = Mutation.DownloadNutanixSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DownloadNutanixSnapshot");
            string parameters = "($input: DownloadNutanixSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDownloadNutanixSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationDownloadNutanixSnapshot",
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
        // batchExportNutanixVm(input: BatchExportNutanixVmInput!): BatchExportNutanixVmReply!
        protected void InvokeMutationBatchExportNutanixVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BatchExportNutanixVmInput!"),
            };
            BatchExportNutanixVmReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BatchExportNutanixVmReply)psObject.BaseObject;
                } else {
                    fields = (BatchExportNutanixVmReply)this.Field;
                }
            }
            string document = Mutation.BatchExportNutanixVm(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BatchExportNutanixVm");
            string parameters = "($input: BatchExportNutanixVmInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBatchExportNutanixVm" + parameters + "{" + document + "}",
                OperationName = "MutationBatchExportNutanixVm",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BatchExportNutanixVmReply> task = this._rbkClient.InvokeGenericCallAsync<BatchExportNutanixVmReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // batchMountNutanixVm(input: BatchMountNutanixVmInput!): BatchMountNutanixVmReply!
        protected void InvokeMutationBatchMountNutanixVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BatchMountNutanixVmInput!"),
            };
            BatchMountNutanixVmReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BatchMountNutanixVmReply)psObject.BaseObject;
                } else {
                    fields = (BatchMountNutanixVmReply)this.Field;
                }
            }
            string document = Mutation.BatchMountNutanixVm(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BatchMountNutanixVm");
            string parameters = "($input: BatchMountNutanixVmInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBatchMountNutanixVm" + parameters + "{" + document + "}",
                OperationName = "MutationBatchMountNutanixVm",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BatchMountNutanixVmReply> task = this._rbkClient.InvokeGenericCallAsync<BatchMountNutanixVmReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // downloadNutanixVmFromLocation(input: DownloadNutanixVmFromLocationInput!): AsyncRequestStatus!
        protected void InvokeMutationDownloadNutanixVmFromLocation()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadNutanixVmFromLocationInput!"),
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
            string document = Mutation.DownloadNutanixVmFromLocation(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DownloadNutanixVmFromLocation");
            string parameters = "($input: DownloadNutanixVmFromLocationInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDownloadNutanixVmFromLocation" + parameters + "{" + document + "}",
                OperationName = "MutationDownloadNutanixVmFromLocation",
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
        // bulkOnDemandSnapshotNutanixVm(input: BulkOnDemandSnapshotNutanixVmInput!): BulkOnDemandSnapshotNutanixVmReply!
        protected void InvokeMutationBulkOnDemandSnapshotNutanixVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkOnDemandSnapshotNutanixVmInput!"),
            };
            BulkOnDemandSnapshotNutanixVmReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BulkOnDemandSnapshotNutanixVmReply)psObject.BaseObject;
                } else {
                    fields = (BulkOnDemandSnapshotNutanixVmReply)this.Field;
                }
            }
            string document = Mutation.BulkOnDemandSnapshotNutanixVm(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BulkOnDemandSnapshotNutanixVm");
            string parameters = "($input: BulkOnDemandSnapshotNutanixVmInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBulkOnDemandSnapshotNutanixVm" + parameters + "{" + document + "}",
                OperationName = "MutationBulkOnDemandSnapshotNutanixVm",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BulkOnDemandSnapshotNutanixVmReply> task = this._rbkClient.InvokeGenericCallAsync<BulkOnDemandSnapshotNutanixVmReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }


    } // class Mutate_RscNutanix
}