// Invoke-RscMutateHyperv.cs
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
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Invoke",
        "RscMutateHyperv",
        DefaultParameterSetName = "ScvmmUpdate")
    ]
    public class Invoke_RscMutateHyperv : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // registerScvmm parameter set
        //
        // GraphQL operation: registerHypervScvmm(input: RegisterHypervScvmmInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "registerScvmm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: registerHypervScvmm(input: RegisterHypervScvmmInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter registerScvmm { get; set; }

        [Parameter(
            ParameterSetName = "registerScvmm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument input: RegisterHypervScvmmInput!"
        )]
        public RegisterHypervScvmmInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // ScvmmUpdate parameter set
        //
        // GraphQL operation: hypervScvmmUpdate(input: HypervScvmmUpdateInput!):HypervScvmmUpdateReply!
        //
        [Parameter(
            ParameterSetName = "ScvmmUpdate",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: hypervScvmmUpdate(input: HypervScvmmUpdateInput!):HypervScvmmUpdateReply!",
            Position = 0
        )]
        public SwitchParameter ScvmmUpdate { get; set; }

        
        // -------------------------------------------------------------------
        // ScvmmDelete parameter set
        //
        // GraphQL operation: hypervScvmmDelete(input: HypervScvmmDeleteInput!):ResponseSuccess!
        //
        [Parameter(
            ParameterSetName = "ScvmmDelete",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: hypervScvmmDelete(input: HypervScvmmDeleteInput!):ResponseSuccess!",
            Position = 0
        )]
        public SwitchParameter ScvmmDelete { get; set; }

        
        // -------------------------------------------------------------------
        // refreshScvmm parameter set
        //
        // GraphQL operation: refreshHypervScvmm(input: RefreshHypervScvmmInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "refreshScvmm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: refreshHypervScvmm(input: RefreshHypervScvmmInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter refreshScvmm { get; set; }

        
        // -------------------------------------------------------------------
        // OnDemandSnapshot parameter set
        //
        // GraphQL operation: hypervOnDemandSnapshot(input: HypervOnDemandSnapshotInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "OnDemandSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: hypervOnDemandSnapshot(input: HypervOnDemandSnapshotInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter OnDemandSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // DeleteAllSnapshot parameter set
        //
        // GraphQL operation: hypervDeleteAllSnapshots(input: HypervDeleteAllSnapshotsInput!):RequestSuccess!
        //
        [Parameter(
            ParameterSetName = "DeleteAllSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: hypervDeleteAllSnapshots(input: HypervDeleteAllSnapshotsInput!):RequestSuccess!",
            Position = 0
        )]
        public SwitchParameter DeleteAllSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // exportVirtualMachine parameter set
        //
        // GraphQL operation: exportHypervVirtualMachine(input: ExportHypervVirtualMachineInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "exportVirtualMachine",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: exportHypervVirtualMachine(input: ExportHypervVirtualMachineInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter exportVirtualMachine { get; set; }

        
        // -------------------------------------------------------------------
        // downloadVirtualMachineSnapshotFile parameter set
        //
        // GraphQL operation: downloadHypervVirtualMachineSnapshotFiles(input: DownloadHypervVirtualMachineSnapshotFilesInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "downloadVirtualMachineSnapshotFile",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: downloadHypervVirtualMachineSnapshotFiles(input: DownloadHypervVirtualMachineSnapshotFilesInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter downloadVirtualMachineSnapshotFile { get; set; }

        
        // -------------------------------------------------------------------
        // instantRecoverVirtualMachineSnapshot parameter set
        //
        // GraphQL operation: instantRecoverHypervVirtualMachineSnapshot(input: InstantRecoverHypervVirtualMachineSnapshotInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "instantRecoverVirtualMachineSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: instantRecoverHypervVirtualMachineSnapshot(input: InstantRecoverHypervVirtualMachineSnapshotInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter instantRecoverVirtualMachineSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // restoreVirtualMachineSnapshotFile parameter set
        //
        // GraphQL operation: restoreHypervVirtualMachineSnapshotFiles(input: RestoreHypervVirtualMachineSnapshotFilesInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "restoreVirtualMachineSnapshotFile",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: restoreHypervVirtualMachineSnapshotFiles(input: RestoreHypervVirtualMachineSnapshotFilesInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter restoreVirtualMachineSnapshotFile { get; set; }

        
        // -------------------------------------------------------------------
        // registerAgentVirtualMachine parameter set
        //
        // GraphQL operation: registerAgentHypervVirtualMachine(input: RegisterAgentHypervVirtualMachineInput!):RequestSuccess!
        //
        [Parameter(
            ParameterSetName = "registerAgentVirtualMachine",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: registerAgentHypervVirtualMachine(input: RegisterAgentHypervVirtualMachineInput!):RequestSuccess!",
            Position = 0
        )]
        public SwitchParameter registerAgentVirtualMachine { get; set; }

        
        // -------------------------------------------------------------------
        // deleteVirtualMachineSnapshot parameter set
        //
        // GraphQL operation: deleteHypervVirtualMachineSnapshot(input: DeleteHypervVirtualMachineSnapshotInput!):RequestSuccess!
        //
        [Parameter(
            ParameterSetName = "deleteVirtualMachineSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: deleteHypervVirtualMachineSnapshot(input: DeleteHypervVirtualMachineSnapshotInput!):RequestSuccess!",
            Position = 0
        )]
        public SwitchParameter deleteVirtualMachineSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // downloadVirtualMachineSnapshot parameter set
        //
        // GraphQL operation: downloadHypervVirtualMachineSnapshot(input: DownloadHypervVirtualMachineSnapshotInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "downloadVirtualMachineSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: downloadHypervVirtualMachineSnapshot(input: DownloadHypervVirtualMachineSnapshotInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter downloadVirtualMachineSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // createVirtualMachineSnapshotMount parameter set
        //
        // GraphQL operation: createHypervVirtualMachineSnapshotMount(input: CreateHypervVirtualMachineSnapshotMountInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "createVirtualMachineSnapshotMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: createHypervVirtualMachineSnapshotMount(input: CreateHypervVirtualMachineSnapshotMountInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter createVirtualMachineSnapshotMount { get; set; }

        
        // -------------------------------------------------------------------
        // updateVirtualMachineSnapshotMount parameter set
        //
        // GraphQL operation: updateHypervVirtualMachineSnapshotMount(input: UpdateHypervVirtualMachineSnapshotMountInput!):UpdateHypervVirtualMachineSnapshotMountReply!
        //
        [Parameter(
            ParameterSetName = "updateVirtualMachineSnapshotMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: updateHypervVirtualMachineSnapshotMount(input: UpdateHypervVirtualMachineSnapshotMountInput!):UpdateHypervVirtualMachineSnapshotMountReply!",
            Position = 0
        )]
        public SwitchParameter updateVirtualMachineSnapshotMount { get; set; }

        
        // -------------------------------------------------------------------
        // deleteVirtualMachineSnapshotMount parameter set
        //
        // GraphQL operation: deleteHypervVirtualMachineSnapshotMount(input: DeleteHypervVirtualMachineSnapshotMountInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "deleteVirtualMachineSnapshotMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: deleteHypervVirtualMachineSnapshotMount(input: DeleteHypervVirtualMachineSnapshotMountInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter deleteVirtualMachineSnapshotMount { get; set; }

        
        // -------------------------------------------------------------------
        // refreshServer parameter set
        //
        // GraphQL operation: refreshHypervServer(input: RefreshHypervServerInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "refreshServer",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: refreshHypervServer(input: RefreshHypervServerInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter refreshServer { get; set; }

        
        // -------------------------------------------------------------------
        // batchOnDemandBackupVm parameter set
        //
        // GraphQL operation: batchOnDemandBackupHypervVm(input: BatchOnDemandBackupHypervVmInput!):BatchOnDemandBackupHypervVmReply!
        //
        [Parameter(
            ParameterSetName = "batchOnDemandBackupVm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: batchOnDemandBackupHypervVm(input: BatchOnDemandBackupHypervVmInput!):BatchOnDemandBackupHypervVmReply!",
            Position = 0
        )]
        public SwitchParameter batchOnDemandBackupVm { get; set; }

        
        // -------------------------------------------------------------------
        // batchExportVm parameter set
        //
        // GraphQL operation: batchExportHypervVm(input: BatchExportHypervVmInput!):BatchExportHypervVmReply!
        //
        [Parameter(
            ParameterSetName = "batchExportVm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: batchExportHypervVm(input: BatchExportHypervVmInput!):BatchExportHypervVmReply!",
            Position = 0
        )]
        public SwitchParameter batchExportVm { get; set; }

        
        // -------------------------------------------------------------------
        // batchMountVm parameter set
        //
        // GraphQL operation: batchMountHypervVm(input: BatchMountHypervVmInput!):BatchMountHypervVmReply!
        //
        [Parameter(
            ParameterSetName = "batchMountVm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: batchMountHypervVm(input: BatchMountHypervVmInput!):BatchMountHypervVmReply!",
            Position = 0
        )]
        public SwitchParameter batchMountVm { get; set; }

        
        // -------------------------------------------------------------------
        // batchInstantRecoverVm parameter set
        //
        // GraphQL operation: batchInstantRecoverHypervVm(input: BatchInstantRecoverHypervVmInput!):BatchInstantRecoverHypervVmReply!
        //
        [Parameter(
            ParameterSetName = "batchInstantRecoverVm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: batchInstantRecoverHypervVm(input: BatchInstantRecoverHypervVmInput!):BatchInstantRecoverHypervVmReply!",
            Position = 0
        )]
        public SwitchParameter batchInstantRecoverVm { get; set; }

        
        // -------------------------------------------------------------------
        // updateVirtualMachine parameter set
        //
        // GraphQL operation: updateHypervVirtualMachine(input: UpdateHypervVirtualMachineInput!):UpdateHypervVirtualMachineReply!
        //
        [Parameter(
            ParameterSetName = "updateVirtualMachine",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: updateHypervVirtualMachine(input: UpdateHypervVirtualMachineInput!):UpdateHypervVirtualMachineReply!",
            Position = 0
        )]
        public SwitchParameter updateVirtualMachine { get; set; }

        
        // -------------------------------------------------------------------
        // downloadSnapshotFromLocation parameter set
        //
        // GraphQL operation: downloadHypervSnapshotFromLocation(input: DownloadHypervSnapshotFromLocationInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "downloadSnapshotFromLocation",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: downloadHypervSnapshotFromLocation(input: DownloadHypervSnapshotFromLocationInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter downloadSnapshotFromLocation { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "registerScvmm":
                        this.ProcessRecord_registerScvmm();
                        break;
                    case "ScvmmUpdate":
                        this.ProcessRecord_ScvmmUpdate();
                        break;
                    case "ScvmmDelete":
                        this.ProcessRecord_ScvmmDelete();
                        break;
                    case "refreshScvmm":
                        this.ProcessRecord_refreshScvmm();
                        break;
                    case "OnDemandSnapshot":
                        this.ProcessRecord_OnDemandSnapshot();
                        break;
                    case "DeleteAllSnapshot":
                        this.ProcessRecord_DeleteAllSnapshot();
                        break;
                    case "exportVirtualMachine":
                        this.ProcessRecord_exportVirtualMachine();
                        break;
                    case "downloadVirtualMachineSnapshotFile":
                        this.ProcessRecord_downloadVirtualMachineSnapshotFile();
                        break;
                    case "instantRecoverVirtualMachineSnapshot":
                        this.ProcessRecord_instantRecoverVirtualMachineSnapshot();
                        break;
                    case "restoreVirtualMachineSnapshotFile":
                        this.ProcessRecord_restoreVirtualMachineSnapshotFile();
                        break;
                    case "registerAgentVirtualMachine":
                        this.ProcessRecord_registerAgentVirtualMachine();
                        break;
                    case "deleteVirtualMachineSnapshot":
                        this.ProcessRecord_deleteVirtualMachineSnapshot();
                        break;
                    case "downloadVirtualMachineSnapshot":
                        this.ProcessRecord_downloadVirtualMachineSnapshot();
                        break;
                    case "createVirtualMachineSnapshotMount":
                        this.ProcessRecord_createVirtualMachineSnapshotMount();
                        break;
                    case "updateVirtualMachineSnapshotMount":
                        this.ProcessRecord_updateVirtualMachineSnapshotMount();
                        break;
                    case "deleteVirtualMachineSnapshotMount":
                        this.ProcessRecord_deleteVirtualMachineSnapshotMount();
                        break;
                    case "refreshServer":
                        this.ProcessRecord_refreshServer();
                        break;
                    case "batchOnDemandBackupVm":
                        this.ProcessRecord_batchOnDemandBackupVm();
                        break;
                    case "batchExportVm":
                        this.ProcessRecord_batchExportVm();
                        break;
                    case "batchMountVm":
                        this.ProcessRecord_batchMountVm();
                        break;
                    case "batchInstantRecoverVm":
                        this.ProcessRecord_batchInstantRecoverVm();
                        break;
                    case "updateVirtualMachine":
                        this.ProcessRecord_updateVirtualMachine();
                        break;
                    case "downloadSnapshotFromLocation":
                        this.ProcessRecord_downloadSnapshotFromLocation();
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
                    "Invoke-RscMutateHyperv",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
           }
        }

        // This parameter set invokes a single graphql operation:
        // registerHypervScvmm.
        protected void ProcessRecord_registerScvmm()
        {
            this._logger.name += " -registerScvmm";
            // Invoke graphql operation registerHypervScvmm
            InvokeMutationRegisterHypervScvmm();
        }

        // This parameter set invokes a single graphql operation:
        // hypervScvmmUpdate.
        protected void ProcessRecord_ScvmmUpdate()
        {
            this._logger.name += " -ScvmmUpdate";
            // Invoke graphql operation hypervScvmmUpdate
            InvokeMutationHypervScvmmUpdate();
        }

        // This parameter set invokes a single graphql operation:
        // hypervScvmmDelete.
        protected void ProcessRecord_ScvmmDelete()
        {
            this._logger.name += " -ScvmmDelete";
            // Invoke graphql operation hypervScvmmDelete
            InvokeMutationHypervScvmmDelete();
        }

        // This parameter set invokes a single graphql operation:
        // refreshHypervScvmm.
        protected void ProcessRecord_refreshScvmm()
        {
            this._logger.name += " -refreshScvmm";
            // Invoke graphql operation refreshHypervScvmm
            InvokeMutationRefreshHypervScvmm();
        }

        // This parameter set invokes a single graphql operation:
        // hypervOnDemandSnapshot.
        protected void ProcessRecord_OnDemandSnapshot()
        {
            this._logger.name += " -OnDemandSnapshot";
            // Invoke graphql operation hypervOnDemandSnapshot
            InvokeMutationHypervOnDemandSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // hypervDeleteAllSnapshots.
        protected void ProcessRecord_DeleteAllSnapshot()
        {
            this._logger.name += " -DeleteAllSnapshot";
            // Invoke graphql operation hypervDeleteAllSnapshots
            InvokeMutationHypervDeleteAllSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // exportHypervVirtualMachine.
        protected void ProcessRecord_exportVirtualMachine()
        {
            this._logger.name += " -exportVirtualMachine";
            // Invoke graphql operation exportHypervVirtualMachine
            InvokeMutationExportHypervVirtualMachine();
        }

        // This parameter set invokes a single graphql operation:
        // downloadHypervVirtualMachineSnapshotFiles.
        protected void ProcessRecord_downloadVirtualMachineSnapshotFile()
        {
            this._logger.name += " -downloadVirtualMachineSnapshotFile";
            // Invoke graphql operation downloadHypervVirtualMachineSnapshotFiles
            InvokeMutationDownloadHypervVirtualMachineSnapshotFiles();
        }

        // This parameter set invokes a single graphql operation:
        // instantRecoverHypervVirtualMachineSnapshot.
        protected void ProcessRecord_instantRecoverVirtualMachineSnapshot()
        {
            this._logger.name += " -instantRecoverVirtualMachineSnapshot";
            // Invoke graphql operation instantRecoverHypervVirtualMachineSnapshot
            InvokeMutationInstantRecoverHypervVirtualMachineSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // restoreHypervVirtualMachineSnapshotFiles.
        protected void ProcessRecord_restoreVirtualMachineSnapshotFile()
        {
            this._logger.name += " -restoreVirtualMachineSnapshotFile";
            // Invoke graphql operation restoreHypervVirtualMachineSnapshotFiles
            InvokeMutationRestoreHypervVirtualMachineSnapshotFiles();
        }

        // This parameter set invokes a single graphql operation:
        // registerAgentHypervVirtualMachine.
        protected void ProcessRecord_registerAgentVirtualMachine()
        {
            this._logger.name += " -registerAgentVirtualMachine";
            // Invoke graphql operation registerAgentHypervVirtualMachine
            InvokeMutationRegisterAgentHypervVirtualMachine();
        }

        // This parameter set invokes a single graphql operation:
        // deleteHypervVirtualMachineSnapshot.
        protected void ProcessRecord_deleteVirtualMachineSnapshot()
        {
            this._logger.name += " -deleteVirtualMachineSnapshot";
            // Invoke graphql operation deleteHypervVirtualMachineSnapshot
            InvokeMutationDeleteHypervVirtualMachineSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // downloadHypervVirtualMachineSnapshot.
        protected void ProcessRecord_downloadVirtualMachineSnapshot()
        {
            this._logger.name += " -downloadVirtualMachineSnapshot";
            // Invoke graphql operation downloadHypervVirtualMachineSnapshot
            InvokeMutationDownloadHypervVirtualMachineSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // createHypervVirtualMachineSnapshotMount.
        protected void ProcessRecord_createVirtualMachineSnapshotMount()
        {
            this._logger.name += " -createVirtualMachineSnapshotMount";
            // Invoke graphql operation createHypervVirtualMachineSnapshotMount
            InvokeMutationCreateHypervVirtualMachineSnapshotMount();
        }

        // This parameter set invokes a single graphql operation:
        // updateHypervVirtualMachineSnapshotMount.
        protected void ProcessRecord_updateVirtualMachineSnapshotMount()
        {
            this._logger.name += " -updateVirtualMachineSnapshotMount";
            // Invoke graphql operation updateHypervVirtualMachineSnapshotMount
            InvokeMutationUpdateHypervVirtualMachineSnapshotMount();
        }

        // This parameter set invokes a single graphql operation:
        // deleteHypervVirtualMachineSnapshotMount.
        protected void ProcessRecord_deleteVirtualMachineSnapshotMount()
        {
            this._logger.name += " -deleteVirtualMachineSnapshotMount";
            // Invoke graphql operation deleteHypervVirtualMachineSnapshotMount
            InvokeMutationDeleteHypervVirtualMachineSnapshotMount();
        }

        // This parameter set invokes a single graphql operation:
        // refreshHypervServer.
        protected void ProcessRecord_refreshServer()
        {
            this._logger.name += " -refreshServer";
            // Invoke graphql operation refreshHypervServer
            InvokeMutationRefreshHypervServer();
        }

        // This parameter set invokes a single graphql operation:
        // batchOnDemandBackupHypervVm.
        protected void ProcessRecord_batchOnDemandBackupVm()
        {
            this._logger.name += " -batchOnDemandBackupVm";
            // Invoke graphql operation batchOnDemandBackupHypervVm
            InvokeMutationBatchOnDemandBackupHypervVm();
        }

        // This parameter set invokes a single graphql operation:
        // batchExportHypervVm.
        protected void ProcessRecord_batchExportVm()
        {
            this._logger.name += " -batchExportVm";
            // Invoke graphql operation batchExportHypervVm
            InvokeMutationBatchExportHypervVm();
        }

        // This parameter set invokes a single graphql operation:
        // batchMountHypervVm.
        protected void ProcessRecord_batchMountVm()
        {
            this._logger.name += " -batchMountVm";
            // Invoke graphql operation batchMountHypervVm
            InvokeMutationBatchMountHypervVm();
        }

        // This parameter set invokes a single graphql operation:
        // batchInstantRecoverHypervVm.
        protected void ProcessRecord_batchInstantRecoverVm()
        {
            this._logger.name += " -batchInstantRecoverVm";
            // Invoke graphql operation batchInstantRecoverHypervVm
            InvokeMutationBatchInstantRecoverHypervVm();
        }

        // This parameter set invokes a single graphql operation:
        // updateHypervVirtualMachine.
        protected void ProcessRecord_updateVirtualMachine()
        {
            this._logger.name += " -updateVirtualMachine";
            // Invoke graphql operation updateHypervVirtualMachine
            InvokeMutationUpdateHypervVirtualMachine();
        }

        // This parameter set invokes a single graphql operation:
        // downloadHypervSnapshotFromLocation.
        protected void ProcessRecord_downloadSnapshotFromLocation()
        {
            this._logger.name += " -downloadSnapshotFromLocation";
            // Invoke graphql operation downloadHypervSnapshotFromLocation
            InvokeMutationDownloadHypervSnapshotFromLocation();
        }


        // Invoke GraphQL Mutation:
        // registerHypervScvmm(input: RegisterHypervScvmmInput!): AsyncRequestStatus!
        protected void InvokeMutationRegisterHypervScvmm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RegisterHypervScvmmInput!"),
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
            string document = Mutation.RegisterHypervScvmm(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RegisterHypervScvmm");
            string parameters = "($input: RegisterHypervScvmmInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRegisterHypervScvmm" + parameters + "{" + document + "}",
                OperationName = "MutationRegisterHypervScvmm",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // hypervScvmmUpdate(input: HypervScvmmUpdateInput!): HypervScvmmUpdateReply!
        protected void InvokeMutationHypervScvmmUpdate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "HypervScvmmUpdateInput!"),
            };
            HypervScvmmUpdateReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (HypervScvmmUpdateReply)psObject.BaseObject;
                } else {
                    fields = (HypervScvmmUpdateReply)this.Field;
                }
            }
            string document = Mutation.HypervScvmmUpdate(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.HypervScvmmUpdate");
            string parameters = "($input: HypervScvmmUpdateInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationHypervScvmmUpdate" + parameters + "{" + document + "}",
                OperationName = "MutationHypervScvmmUpdate",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<HypervScvmmUpdateReply> task = this._rbkClient.InvokeGenericCallAsync<HypervScvmmUpdateReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // hypervScvmmDelete(input: HypervScvmmDeleteInput!): ResponseSuccess!
        protected void InvokeMutationHypervScvmmDelete()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "HypervScvmmDeleteInput!"),
            };
            ResponseSuccess? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (ResponseSuccess)psObject.BaseObject;
                } else {
                    fields = (ResponseSuccess)this.Field;
                }
            }
            string document = Mutation.HypervScvmmDelete(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.HypervScvmmDelete");
            string parameters = "($input: HypervScvmmDeleteInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationHypervScvmmDelete" + parameters + "{" + document + "}",
                OperationName = "MutationHypervScvmmDelete",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<ResponseSuccess> task = this._rbkClient.InvokeGenericCallAsync<ResponseSuccess>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // refreshHypervScvmm(input: RefreshHypervScvmmInput!): AsyncRequestStatus!
        protected void InvokeMutationRefreshHypervScvmm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshHypervScvmmInput!"),
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
            string document = Mutation.RefreshHypervScvmm(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RefreshHypervScvmm");
            string parameters = "($input: RefreshHypervScvmmInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRefreshHypervScvmm" + parameters + "{" + document + "}",
                OperationName = "MutationRefreshHypervScvmm",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // hypervOnDemandSnapshot(input: HypervOnDemandSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationHypervOnDemandSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "HypervOnDemandSnapshotInput!"),
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
            string document = Mutation.HypervOnDemandSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.HypervOnDemandSnapshot");
            string parameters = "($input: HypervOnDemandSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationHypervOnDemandSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationHypervOnDemandSnapshot",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // hypervDeleteAllSnapshots(input: HypervDeleteAllSnapshotsInput!): RequestSuccess!
        protected void InvokeMutationHypervDeleteAllSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "HypervDeleteAllSnapshotsInput!"),
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
            string document = Mutation.HypervDeleteAllSnapshots(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.HypervDeleteAllSnapshots");
            string parameters = "($input: HypervDeleteAllSnapshotsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationHypervDeleteAllSnapshots" + parameters + "{" + document + "}",
                OperationName = "MutationHypervDeleteAllSnapshots",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<RequestSuccess> task = this._rbkClient.InvokeGenericCallAsync<RequestSuccess>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // exportHypervVirtualMachine(input: ExportHypervVirtualMachineInput!): AsyncRequestStatus!
        protected void InvokeMutationExportHypervVirtualMachine()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportHypervVirtualMachineInput!"),
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
            string document = Mutation.ExportHypervVirtualMachine(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.ExportHypervVirtualMachine");
            string parameters = "($input: ExportHypervVirtualMachineInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationExportHypervVirtualMachine" + parameters + "{" + document + "}",
                OperationName = "MutationExportHypervVirtualMachine",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // downloadHypervVirtualMachineSnapshotFiles(input: DownloadHypervVirtualMachineSnapshotFilesInput!): AsyncRequestStatus!
        protected void InvokeMutationDownloadHypervVirtualMachineSnapshotFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadHypervVirtualMachineSnapshotFilesInput!"),
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
            string document = Mutation.DownloadHypervVirtualMachineSnapshotFiles(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DownloadHypervVirtualMachineSnapshotFiles");
            string parameters = "($input: DownloadHypervVirtualMachineSnapshotFilesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDownloadHypervVirtualMachineSnapshotFiles" + parameters + "{" + document + "}",
                OperationName = "MutationDownloadHypervVirtualMachineSnapshotFiles",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // instantRecoverHypervVirtualMachineSnapshot(input: InstantRecoverHypervVirtualMachineSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationInstantRecoverHypervVirtualMachineSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "InstantRecoverHypervVirtualMachineSnapshotInput!"),
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
            string document = Mutation.InstantRecoverHypervVirtualMachineSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.InstantRecoverHypervVirtualMachineSnapshot");
            string parameters = "($input: InstantRecoverHypervVirtualMachineSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationInstantRecoverHypervVirtualMachineSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationInstantRecoverHypervVirtualMachineSnapshot",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // restoreHypervVirtualMachineSnapshotFiles(input: RestoreHypervVirtualMachineSnapshotFilesInput!): AsyncRequestStatus!
        protected void InvokeMutationRestoreHypervVirtualMachineSnapshotFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreHypervVirtualMachineSnapshotFilesInput!"),
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
            string document = Mutation.RestoreHypervVirtualMachineSnapshotFiles(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RestoreHypervVirtualMachineSnapshotFiles");
            string parameters = "($input: RestoreHypervVirtualMachineSnapshotFilesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRestoreHypervVirtualMachineSnapshotFiles" + parameters + "{" + document + "}",
                OperationName = "MutationRestoreHypervVirtualMachineSnapshotFiles",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // registerAgentHypervVirtualMachine(input: RegisterAgentHypervVirtualMachineInput!): RequestSuccess!
        protected void InvokeMutationRegisterAgentHypervVirtualMachine()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RegisterAgentHypervVirtualMachineInput!"),
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
            string document = Mutation.RegisterAgentHypervVirtualMachine(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RegisterAgentHypervVirtualMachine");
            string parameters = "($input: RegisterAgentHypervVirtualMachineInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRegisterAgentHypervVirtualMachine" + parameters + "{" + document + "}",
                OperationName = "MutationRegisterAgentHypervVirtualMachine",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<RequestSuccess> task = this._rbkClient.InvokeGenericCallAsync<RequestSuccess>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteHypervVirtualMachineSnapshot(input: DeleteHypervVirtualMachineSnapshotInput!): RequestSuccess!
        protected void InvokeMutationDeleteHypervVirtualMachineSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteHypervVirtualMachineSnapshotInput!"),
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
            string document = Mutation.DeleteHypervVirtualMachineSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteHypervVirtualMachineSnapshot");
            string parameters = "($input: DeleteHypervVirtualMachineSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteHypervVirtualMachineSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteHypervVirtualMachineSnapshot",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<RequestSuccess> task = this._rbkClient.InvokeGenericCallAsync<RequestSuccess>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // downloadHypervVirtualMachineSnapshot(input: DownloadHypervVirtualMachineSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationDownloadHypervVirtualMachineSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadHypervVirtualMachineSnapshotInput!"),
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
            string document = Mutation.DownloadHypervVirtualMachineSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DownloadHypervVirtualMachineSnapshot");
            string parameters = "($input: DownloadHypervVirtualMachineSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDownloadHypervVirtualMachineSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationDownloadHypervVirtualMachineSnapshot",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // createHypervVirtualMachineSnapshotMount(input: CreateHypervVirtualMachineSnapshotMountInput!): AsyncRequestStatus!
        protected void InvokeMutationCreateHypervVirtualMachineSnapshotMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateHypervVirtualMachineSnapshotMountInput!"),
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
            string document = Mutation.CreateHypervVirtualMachineSnapshotMount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateHypervVirtualMachineSnapshotMount");
            string parameters = "($input: CreateHypervVirtualMachineSnapshotMountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateHypervVirtualMachineSnapshotMount" + parameters + "{" + document + "}",
                OperationName = "MutationCreateHypervVirtualMachineSnapshotMount",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // updateHypervVirtualMachineSnapshotMount(input: UpdateHypervVirtualMachineSnapshotMountInput!): UpdateHypervVirtualMachineSnapshotMountReply!
        protected void InvokeMutationUpdateHypervVirtualMachineSnapshotMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateHypervVirtualMachineSnapshotMountInput!"),
            };
            UpdateHypervVirtualMachineSnapshotMountReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (UpdateHypervVirtualMachineSnapshotMountReply)psObject.BaseObject;
                } else {
                    fields = (UpdateHypervVirtualMachineSnapshotMountReply)this.Field;
                }
            }
            string document = Mutation.UpdateHypervVirtualMachineSnapshotMount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateHypervVirtualMachineSnapshotMount");
            string parameters = "($input: UpdateHypervVirtualMachineSnapshotMountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateHypervVirtualMachineSnapshotMount" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateHypervVirtualMachineSnapshotMount",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<UpdateHypervVirtualMachineSnapshotMountReply> task = this._rbkClient.InvokeGenericCallAsync<UpdateHypervVirtualMachineSnapshotMountReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteHypervVirtualMachineSnapshotMount(input: DeleteHypervVirtualMachineSnapshotMountInput!): AsyncRequestStatus!
        protected void InvokeMutationDeleteHypervVirtualMachineSnapshotMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteHypervVirtualMachineSnapshotMountInput!"),
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
            string document = Mutation.DeleteHypervVirtualMachineSnapshotMount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteHypervVirtualMachineSnapshotMount");
            string parameters = "($input: DeleteHypervVirtualMachineSnapshotMountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteHypervVirtualMachineSnapshotMount" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteHypervVirtualMachineSnapshotMount",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // refreshHypervServer(input: RefreshHypervServerInput!): AsyncRequestStatus!
        protected void InvokeMutationRefreshHypervServer()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshHypervServerInput!"),
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
            string document = Mutation.RefreshHypervServer(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RefreshHypervServer");
            string parameters = "($input: RefreshHypervServerInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRefreshHypervServer" + parameters + "{" + document + "}",
                OperationName = "MutationRefreshHypervServer",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // batchOnDemandBackupHypervVm(input: BatchOnDemandBackupHypervVmInput!): BatchOnDemandBackupHypervVmReply!
        protected void InvokeMutationBatchOnDemandBackupHypervVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BatchOnDemandBackupHypervVmInput!"),
            };
            BatchOnDemandBackupHypervVmReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BatchOnDemandBackupHypervVmReply)psObject.BaseObject;
                } else {
                    fields = (BatchOnDemandBackupHypervVmReply)this.Field;
                }
            }
            string document = Mutation.BatchOnDemandBackupHypervVm(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BatchOnDemandBackupHypervVm");
            string parameters = "($input: BatchOnDemandBackupHypervVmInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBatchOnDemandBackupHypervVm" + parameters + "{" + document + "}",
                OperationName = "MutationBatchOnDemandBackupHypervVm",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BatchOnDemandBackupHypervVmReply> task = this._rbkClient.InvokeGenericCallAsync<BatchOnDemandBackupHypervVmReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // batchExportHypervVm(input: BatchExportHypervVmInput!): BatchExportHypervVmReply!
        protected void InvokeMutationBatchExportHypervVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BatchExportHypervVmInput!"),
            };
            BatchExportHypervVmReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BatchExportHypervVmReply)psObject.BaseObject;
                } else {
                    fields = (BatchExportHypervVmReply)this.Field;
                }
            }
            string document = Mutation.BatchExportHypervVm(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BatchExportHypervVm");
            string parameters = "($input: BatchExportHypervVmInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBatchExportHypervVm" + parameters + "{" + document + "}",
                OperationName = "MutationBatchExportHypervVm",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BatchExportHypervVmReply> task = this._rbkClient.InvokeGenericCallAsync<BatchExportHypervVmReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // batchMountHypervVm(input: BatchMountHypervVmInput!): BatchMountHypervVmReply!
        protected void InvokeMutationBatchMountHypervVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BatchMountHypervVmInput!"),
            };
            BatchMountHypervVmReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BatchMountHypervVmReply)psObject.BaseObject;
                } else {
                    fields = (BatchMountHypervVmReply)this.Field;
                }
            }
            string document = Mutation.BatchMountHypervVm(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BatchMountHypervVm");
            string parameters = "($input: BatchMountHypervVmInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBatchMountHypervVm" + parameters + "{" + document + "}",
                OperationName = "MutationBatchMountHypervVm",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BatchMountHypervVmReply> task = this._rbkClient.InvokeGenericCallAsync<BatchMountHypervVmReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // batchInstantRecoverHypervVm(input: BatchInstantRecoverHypervVmInput!): BatchInstantRecoverHypervVmReply!
        protected void InvokeMutationBatchInstantRecoverHypervVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BatchInstantRecoverHypervVmInput!"),
            };
            BatchInstantRecoverHypervVmReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BatchInstantRecoverHypervVmReply)psObject.BaseObject;
                } else {
                    fields = (BatchInstantRecoverHypervVmReply)this.Field;
                }
            }
            string document = Mutation.BatchInstantRecoverHypervVm(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BatchInstantRecoverHypervVm");
            string parameters = "($input: BatchInstantRecoverHypervVmInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBatchInstantRecoverHypervVm" + parameters + "{" + document + "}",
                OperationName = "MutationBatchInstantRecoverHypervVm",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BatchInstantRecoverHypervVmReply> task = this._rbkClient.InvokeGenericCallAsync<BatchInstantRecoverHypervVmReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // updateHypervVirtualMachine(input: UpdateHypervVirtualMachineInput!): UpdateHypervVirtualMachineReply!
        protected void InvokeMutationUpdateHypervVirtualMachine()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateHypervVirtualMachineInput!"),
            };
            UpdateHypervVirtualMachineReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (UpdateHypervVirtualMachineReply)psObject.BaseObject;
                } else {
                    fields = (UpdateHypervVirtualMachineReply)this.Field;
                }
            }
            string document = Mutation.UpdateHypervVirtualMachine(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateHypervVirtualMachine");
            string parameters = "($input: UpdateHypervVirtualMachineInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateHypervVirtualMachine" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateHypervVirtualMachine",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<UpdateHypervVirtualMachineReply> task = this._rbkClient.InvokeGenericCallAsync<UpdateHypervVirtualMachineReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // downloadHypervSnapshotFromLocation(input: DownloadHypervSnapshotFromLocationInput!): AsyncRequestStatus!
        protected void InvokeMutationDownloadHypervSnapshotFromLocation()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadHypervSnapshotFromLocationInput!"),
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
            string document = Mutation.DownloadHypervSnapshotFromLocation(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DownloadHypervSnapshotFromLocation");
            string parameters = "($input: DownloadHypervSnapshotFromLocationInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDownloadHypervSnapshotFromLocation" + parameters + "{" + document + "}",
                OperationName = "MutationDownloadHypervSnapshotFromLocation",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }


    } // class Invoke_RscMutateHyperv
}