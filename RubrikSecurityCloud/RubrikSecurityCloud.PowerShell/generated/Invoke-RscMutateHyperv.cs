// Invoke-RscMutateHyperv.cs
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
        "RscMutateHyperv",
        DefaultParameterSetName = "ScvmmUpdate")
    ]
    public class Invoke_RscMutateHyperv : RscPSCmdlet
    {
        
        /// <summary>
        /// RegisterScvmm parameter set
        ///
        /// [GraphQL: registerHypervScvmm]
        /// </summary>
        [Parameter(
            ParameterSetName = "RegisterScvmm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Register HyperV SCVMM to Rubrik Cluster.
[GraphQL: registerHypervScvmm]",
            Position = 0
        )]
        public SwitchParameter RegisterScvmm { get; set; }

        
        /// <summary>
        /// ScvmmUpdate parameter set
        ///
        /// [GraphQL: hypervScvmmUpdate]
        /// </summary>
        [Parameter(
            ParameterSetName = "ScvmmUpdate",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update properties for a given HyperV SCVMM.
[GraphQL: hypervScvmmUpdate]",
            Position = 0
        )]
        public SwitchParameter ScvmmUpdate { get; set; }

        
        /// <summary>
        /// ScvmmDelete parameter set
        ///
        /// [GraphQL: hypervScvmmDelete]
        /// </summary>
        [Parameter(
            ParameterSetName = "ScvmmDelete",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete a given HyperV SCVMM.
[GraphQL: hypervScvmmDelete]",
            Position = 0
        )]
        public SwitchParameter ScvmmDelete { get; set; }

        
        /// <summary>
        /// RefreshScvmm parameter set
        ///
        /// [GraphQL: refreshHypervScvmm]
        /// </summary>
        [Parameter(
            ParameterSetName = "RefreshScvmm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refresh a given HyperV SCVMM.
[GraphQL: refreshHypervScvmm]",
            Position = 0
        )]
        public SwitchParameter RefreshScvmm { get; set; }

        
        /// <summary>
        /// OnDemandSnapshot parameter set
        ///
        /// [GraphQL: hypervOnDemandSnapshot]
        /// </summary>
        [Parameter(
            ParameterSetName = "OnDemandSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create on-demand VM snapshot

Supported in v5.0+
Create an on-demand snapshot for the given VM ID.
[GraphQL: hypervOnDemandSnapshot]",
            Position = 0
        )]
        public SwitchParameter OnDemandSnapshot { get; set; }

        
        /// <summary>
        /// DeleteAllSnapshots parameter set
        ///
        /// [GraphQL: hypervDeleteAllSnapshots]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteAllSnapshots",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete all snapshots of VM

Supported in v5.0+
Delete all snapshots of a virtual machine.
[GraphQL: hypervDeleteAllSnapshots]",
            Position = 0
        )]
        public SwitchParameter DeleteAllSnapshots { get; set; }

        
        /// <summary>
        /// ExportVirtualMachine parameter set
        ///
        /// [GraphQL: exportHypervVirtualMachine]
        /// </summary>
        [Parameter(
            ParameterSetName = "ExportVirtualMachine",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Export VM snapshot

Supported in v5.0+
Export snapshot of a vm.
[GraphQL: exportHypervVirtualMachine]",
            Position = 0
        )]
        public SwitchParameter ExportVirtualMachine { get; set; }

        
        /// <summary>
        /// DownloadVirtualMachineSnapshotFiles parameter set
        ///
        /// [GraphQL: downloadHypervVirtualMachineSnapshotFiles]
        /// </summary>
        [Parameter(
            ParameterSetName = "DownloadVirtualMachineSnapshotFiles",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Download files from a Hyper-V VM backup

Supported in v5.0+
Start an asynchronous job to download multiple files and folders from a specified Hyper-V VM backup. The response returns an asynchrounous request ID. Get the URL for downloading the ZIP file including the specific files/folders by sending a GET request to 'hyperv/vm/request/{id}'.
[GraphQL: downloadHypervVirtualMachineSnapshotFiles]",
            Position = 0
        )]
        public SwitchParameter DownloadVirtualMachineSnapshotFiles { get; set; }

        
        /// <summary>
        /// InstantRecoverVirtualMachineSnapshot parameter set
        ///
        /// [GraphQL: instantRecoverHypervVirtualMachineSnapshot]
        /// </summary>
        [Parameter(
            ParameterSetName = "InstantRecoverVirtualMachineSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Creates an instant recover request that restores a target VM from the given Rubrik-hosted-snapshot

Supported in v5.0+
The VM will be started with networking enabled. If the VM does not exist anymore, a new VM will be created.
[GraphQL: instantRecoverHypervVirtualMachineSnapshot]",
            Position = 0
        )]
        public SwitchParameter InstantRecoverVirtualMachineSnapshot { get; set; }

        
        /// <summary>
        /// RestoreVirtualMachineSnapshotFiles parameter set
        ///
        /// [GraphQL: restoreHypervVirtualMachineSnapshotFiles]
        /// </summary>
        [Parameter(
            ParameterSetName = "RestoreVirtualMachineSnapshotFiles",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Restore files from snapshot

Supported in v5.0+
Restore files from a snapshot to the original source location.
[GraphQL: restoreHypervVirtualMachineSnapshotFiles]",
            Position = 0
        )]
        public SwitchParameter RestoreVirtualMachineSnapshotFiles { get; set; }

        
        /// <summary>
        /// RegisterAgentVirtualMachine parameter set
        ///
        /// [GraphQL: registerAgentHypervVirtualMachine]
        /// </summary>
        [Parameter(
            ParameterSetName = "RegisterAgentVirtualMachine",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Register the agent installed in VM

Supported in v5.0+
Register the agent that installed in VM.
[GraphQL: registerAgentHypervVirtualMachine]",
            Position = 0
        )]
        public SwitchParameter RegisterAgentVirtualMachine { get; set; }

        
        /// <summary>
        /// DeleteVirtualMachineSnapshot parameter set
        ///
        /// [GraphQL: deleteHypervVirtualMachineSnapshot]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteVirtualMachineSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete VM snapshot

Supported in v5.0+
Delete a snapshot by expiring it. Snapshot is expired only if it is a manual snapshot or a snapshot of an unprotected vm.
[GraphQL: deleteHypervVirtualMachineSnapshot]",
            Position = 0
        )]
        public SwitchParameter DeleteVirtualMachineSnapshot { get; set; }

        
        /// <summary>
        /// DownloadVirtualMachineSnapshot parameter set
        ///
        /// [GraphQL: downloadHypervVirtualMachineSnapshot]
        /// </summary>
        [Parameter(
            ParameterSetName = "DownloadVirtualMachineSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Creates a download from archival request

Supported in v5.0+
Download a snapshot from archival.
[GraphQL: downloadHypervVirtualMachineSnapshot]",
            Position = 0
        )]
        public SwitchParameter DownloadVirtualMachineSnapshot { get; set; }

        
        /// <summary>
        /// CreateVirtualMachineSnapshotMount parameter set
        ///
        /// [GraphQL: createHypervVirtualMachineSnapshotMount]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateVirtualMachineSnapshotMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a live mount request

Supported in v5.0+
Create a live mount request with given configuration.
[GraphQL: createHypervVirtualMachineSnapshotMount]",
            Position = 0
        )]
        public SwitchParameter CreateVirtualMachineSnapshotMount { get; set; }

        
        /// <summary>
        /// UpdateVirtualMachineSnapshotMount parameter set
        ///
        /// [GraphQL: updateHypervVirtualMachineSnapshotMount]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateVirtualMachineSnapshotMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Power a Live Mount on and off

Supported in v5.0+
Power a specified Live Mount virtual machine on or off. Pass **_true_** to power the virtual machine on and pass **_false_** to power the virtual machine off.
[GraphQL: updateHypervVirtualMachineSnapshotMount]",
            Position = 0
        )]
        public SwitchParameter UpdateVirtualMachineSnapshotMount { get; set; }

        
        /// <summary>
        /// DeleteVirtualMachineSnapshotMount parameter set
        ///
        /// [GraphQL: deleteHypervVirtualMachineSnapshotMount]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteVirtualMachineSnapshotMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Requst to delete a live mount

Supported in v5.0+
Create a request to delete a live mount.
[GraphQL: deleteHypervVirtualMachineSnapshotMount]",
            Position = 0
        )]
        public SwitchParameter DeleteVirtualMachineSnapshotMount { get; set; }

        
        /// <summary>
        /// RefreshServer parameter set
        ///
        /// [GraphQL: refreshHypervServer]
        /// </summary>
        [Parameter(
            ParameterSetName = "RefreshServer",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refresh Hyper-V host metadata

Supported in v5.0+
Create a job to refresh the metadata for the specified Hyper-V host.
[GraphQL: refreshHypervServer]",
            Position = 0
        )]
        public SwitchParameter RefreshServer { get; set; }

        
        /// <summary>
        /// BatchOnDemandBackupVm parameter set
        ///
        /// [GraphQL: batchOnDemandBackupHypervVm]
        /// </summary>
        [Parameter(
            ParameterSetName = "BatchOnDemandBackupVm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Takes bulk on-demand backup of Hyper-V virtual machines

Supported in v9.0+
Takes on-demand backup of multiple specified Hyper-V virtual machines.
[GraphQL: batchOnDemandBackupHypervVm]",
            Position = 0
        )]
        public SwitchParameter BatchOnDemandBackupVm { get; set; }

        
        /// <summary>
        /// BatchExportVm parameter set
        ///
        /// [GraphQL: batchExportHypervVm]
        /// </summary>
        [Parameter(
            ParameterSetName = "BatchExportVm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Exports a snapshot from each member of a set of virtual machines

Supported in v7.0+
Export a snapshot from each member of a set of virtual machines.
[GraphQL: batchExportHypervVm]",
            Position = 0
        )]
        public SwitchParameter BatchExportVm { get; set; }

        
        /// <summary>
        /// BatchMountVm parameter set
        ///
        /// [GraphQL: batchMountHypervVm]
        /// </summary>
        [Parameter(
            ParameterSetName = "BatchMountVm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Mount snapshots from multiple virtual machines

Supported in v7.0+
Mounts a batch of snapshots from a group of specified virtual machines.
[GraphQL: batchMountHypervVm]",
            Position = 0
        )]
        public SwitchParameter BatchMountVm { get; set; }

        
        /// <summary>
        /// BatchInstantRecoverVm parameter set
        ///
        /// [GraphQL: batchInstantRecoverHypervVm]
        /// </summary>
        [Parameter(
            ParameterSetName = "BatchInstantRecoverVm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Instantly recovers snapshots from multiple virtual machines

Supported in v7.0+
Instantly recovers a batch of snapshots from a group of specified virtual machines.
[GraphQL: batchInstantRecoverHypervVm]",
            Position = 0
        )]
        public SwitchParameter BatchInstantRecoverVm { get; set; }

        
        /// <summary>
        /// UpdateVirtualMachine parameter set
        ///
        /// [GraphQL: updateHypervVirtualMachine]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateVirtualMachine",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update VM

Supported in v5.0+
Update VM with specified properties.
[GraphQL: updateHypervVirtualMachine]",
            Position = 0
        )]
        public SwitchParameter UpdateVirtualMachine { get; set; }

        
        /// <summary>
        /// DownloadSnapshotFromLocation parameter set
        ///
        /// [GraphQL: downloadHypervSnapshotFromLocation]
        /// </summary>
        [Parameter(
            ParameterSetName = "DownloadSnapshotFromLocation",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Download a snapshot from a replication target

Supported in v7.0+
Initiates a job to download a snapshot from the specified location when the snapshot does not exist locally. The specified location has to be a replication target connected to this Rubrik cluster. If an SLA Domain is not provided, the snapshot will be retained forever.
[GraphQL: downloadHypervSnapshotFromLocation]",
            Position = 0
        )]
        public SwitchParameter DownloadSnapshotFromLocation { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "RegisterScvmm":
                        this.ProcessRecord_RegisterScvmm();
                        break;
                    case "ScvmmUpdate":
                        this.ProcessRecord_ScvmmUpdate();
                        break;
                    case "ScvmmDelete":
                        this.ProcessRecord_ScvmmDelete();
                        break;
                    case "RefreshScvmm":
                        this.ProcessRecord_RefreshScvmm();
                        break;
                    case "OnDemandSnapshot":
                        this.ProcessRecord_OnDemandSnapshot();
                        break;
                    case "DeleteAllSnapshots":
                        this.ProcessRecord_DeleteAllSnapshots();
                        break;
                    case "ExportVirtualMachine":
                        this.ProcessRecord_ExportVirtualMachine();
                        break;
                    case "DownloadVirtualMachineSnapshotFiles":
                        this.ProcessRecord_DownloadVirtualMachineSnapshotFiles();
                        break;
                    case "InstantRecoverVirtualMachineSnapshot":
                        this.ProcessRecord_InstantRecoverVirtualMachineSnapshot();
                        break;
                    case "RestoreVirtualMachineSnapshotFiles":
                        this.ProcessRecord_RestoreVirtualMachineSnapshotFiles();
                        break;
                    case "RegisterAgentVirtualMachine":
                        this.ProcessRecord_RegisterAgentVirtualMachine();
                        break;
                    case "DeleteVirtualMachineSnapshot":
                        this.ProcessRecord_DeleteVirtualMachineSnapshot();
                        break;
                    case "DownloadVirtualMachineSnapshot":
                        this.ProcessRecord_DownloadVirtualMachineSnapshot();
                        break;
                    case "CreateVirtualMachineSnapshotMount":
                        this.ProcessRecord_CreateVirtualMachineSnapshotMount();
                        break;
                    case "UpdateVirtualMachineSnapshotMount":
                        this.ProcessRecord_UpdateVirtualMachineSnapshotMount();
                        break;
                    case "DeleteVirtualMachineSnapshotMount":
                        this.ProcessRecord_DeleteVirtualMachineSnapshotMount();
                        break;
                    case "RefreshServer":
                        this.ProcessRecord_RefreshServer();
                        break;
                    case "BatchOnDemandBackupVm":
                        this.ProcessRecord_BatchOnDemandBackupVm();
                        break;
                    case "BatchExportVm":
                        this.ProcessRecord_BatchExportVm();
                        break;
                    case "BatchMountVm":
                        this.ProcessRecord_BatchMountVm();
                        break;
                    case "BatchInstantRecoverVm":
                        this.ProcessRecord_BatchInstantRecoverVm();
                        break;
                    case "UpdateVirtualMachine":
                        this.ProcessRecord_UpdateVirtualMachine();
                        break;
                    case "DownloadSnapshotFromLocation":
                        this.ProcessRecord_DownloadSnapshotFromLocation();
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
        // registerHypervScvmm.
        internal void ProcessRecord_RegisterScvmm()
        {
            this._logger.name += " -RegisterScvmm";
            // Invoke graphql operation registerHypervScvmm
            InvokeMutationRegisterHypervScvmm();
        }

        // This parameter set invokes a single graphql operation:
        // hypervScvmmUpdate.
        internal void ProcessRecord_ScvmmUpdate()
        {
            this._logger.name += " -ScvmmUpdate";
            // Invoke graphql operation hypervScvmmUpdate
            InvokeMutationHypervScvmmUpdate();
        }

        // This parameter set invokes a single graphql operation:
        // hypervScvmmDelete.
        internal void ProcessRecord_ScvmmDelete()
        {
            this._logger.name += " -ScvmmDelete";
            // Invoke graphql operation hypervScvmmDelete
            InvokeMutationHypervScvmmDelete();
        }

        // This parameter set invokes a single graphql operation:
        // refreshHypervScvmm.
        internal void ProcessRecord_RefreshScvmm()
        {
            this._logger.name += " -RefreshScvmm";
            // Invoke graphql operation refreshHypervScvmm
            InvokeMutationRefreshHypervScvmm();
        }

        // This parameter set invokes a single graphql operation:
        // hypervOnDemandSnapshot.
        internal void ProcessRecord_OnDemandSnapshot()
        {
            this._logger.name += " -OnDemandSnapshot";
            // Invoke graphql operation hypervOnDemandSnapshot
            InvokeMutationHypervOnDemandSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // hypervDeleteAllSnapshots.
        internal void ProcessRecord_DeleteAllSnapshots()
        {
            this._logger.name += " -DeleteAllSnapshots";
            // Invoke graphql operation hypervDeleteAllSnapshots
            InvokeMutationHypervDeleteAllSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // exportHypervVirtualMachine.
        internal void ProcessRecord_ExportVirtualMachine()
        {
            this._logger.name += " -ExportVirtualMachine";
            // Invoke graphql operation exportHypervVirtualMachine
            InvokeMutationExportHypervVirtualMachine();
        }

        // This parameter set invokes a single graphql operation:
        // downloadHypervVirtualMachineSnapshotFiles.
        internal void ProcessRecord_DownloadVirtualMachineSnapshotFiles()
        {
            this._logger.name += " -DownloadVirtualMachineSnapshotFiles";
            // Invoke graphql operation downloadHypervVirtualMachineSnapshotFiles
            InvokeMutationDownloadHypervVirtualMachineSnapshotFiles();
        }

        // This parameter set invokes a single graphql operation:
        // instantRecoverHypervVirtualMachineSnapshot.
        internal void ProcessRecord_InstantRecoverVirtualMachineSnapshot()
        {
            this._logger.name += " -InstantRecoverVirtualMachineSnapshot";
            // Invoke graphql operation instantRecoverHypervVirtualMachineSnapshot
            InvokeMutationInstantRecoverHypervVirtualMachineSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // restoreHypervVirtualMachineSnapshotFiles.
        internal void ProcessRecord_RestoreVirtualMachineSnapshotFiles()
        {
            this._logger.name += " -RestoreVirtualMachineSnapshotFiles";
            // Invoke graphql operation restoreHypervVirtualMachineSnapshotFiles
            InvokeMutationRestoreHypervVirtualMachineSnapshotFiles();
        }

        // This parameter set invokes a single graphql operation:
        // registerAgentHypervVirtualMachine.
        internal void ProcessRecord_RegisterAgentVirtualMachine()
        {
            this._logger.name += " -RegisterAgentVirtualMachine";
            // Invoke graphql operation registerAgentHypervVirtualMachine
            InvokeMutationRegisterAgentHypervVirtualMachine();
        }

        // This parameter set invokes a single graphql operation:
        // deleteHypervVirtualMachineSnapshot.
        internal void ProcessRecord_DeleteVirtualMachineSnapshot()
        {
            this._logger.name += " -DeleteVirtualMachineSnapshot";
            // Invoke graphql operation deleteHypervVirtualMachineSnapshot
            InvokeMutationDeleteHypervVirtualMachineSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // downloadHypervVirtualMachineSnapshot.
        internal void ProcessRecord_DownloadVirtualMachineSnapshot()
        {
            this._logger.name += " -DownloadVirtualMachineSnapshot";
            // Invoke graphql operation downloadHypervVirtualMachineSnapshot
            InvokeMutationDownloadHypervVirtualMachineSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // createHypervVirtualMachineSnapshotMount.
        internal void ProcessRecord_CreateVirtualMachineSnapshotMount()
        {
            this._logger.name += " -CreateVirtualMachineSnapshotMount";
            // Invoke graphql operation createHypervVirtualMachineSnapshotMount
            InvokeMutationCreateHypervVirtualMachineSnapshotMount();
        }

        // This parameter set invokes a single graphql operation:
        // updateHypervVirtualMachineSnapshotMount.
        internal void ProcessRecord_UpdateVirtualMachineSnapshotMount()
        {
            this._logger.name += " -UpdateVirtualMachineSnapshotMount";
            // Invoke graphql operation updateHypervVirtualMachineSnapshotMount
            InvokeMutationUpdateHypervVirtualMachineSnapshotMount();
        }

        // This parameter set invokes a single graphql operation:
        // deleteHypervVirtualMachineSnapshotMount.
        internal void ProcessRecord_DeleteVirtualMachineSnapshotMount()
        {
            this._logger.name += " -DeleteVirtualMachineSnapshotMount";
            // Invoke graphql operation deleteHypervVirtualMachineSnapshotMount
            InvokeMutationDeleteHypervVirtualMachineSnapshotMount();
        }

        // This parameter set invokes a single graphql operation:
        // refreshHypervServer.
        internal void ProcessRecord_RefreshServer()
        {
            this._logger.name += " -RefreshServer";
            // Invoke graphql operation refreshHypervServer
            InvokeMutationRefreshHypervServer();
        }

        // This parameter set invokes a single graphql operation:
        // batchOnDemandBackupHypervVm.
        internal void ProcessRecord_BatchOnDemandBackupVm()
        {
            this._logger.name += " -BatchOnDemandBackupVm";
            // Invoke graphql operation batchOnDemandBackupHypervVm
            InvokeMutationBatchOnDemandBackupHypervVm();
        }

        // This parameter set invokes a single graphql operation:
        // batchExportHypervVm.
        internal void ProcessRecord_BatchExportVm()
        {
            this._logger.name += " -BatchExportVm";
            // Invoke graphql operation batchExportHypervVm
            InvokeMutationBatchExportHypervVm();
        }

        // This parameter set invokes a single graphql operation:
        // batchMountHypervVm.
        internal void ProcessRecord_BatchMountVm()
        {
            this._logger.name += " -BatchMountVm";
            // Invoke graphql operation batchMountHypervVm
            InvokeMutationBatchMountHypervVm();
        }

        // This parameter set invokes a single graphql operation:
        // batchInstantRecoverHypervVm.
        internal void ProcessRecord_BatchInstantRecoverVm()
        {
            this._logger.name += " -BatchInstantRecoverVm";
            // Invoke graphql operation batchInstantRecoverHypervVm
            InvokeMutationBatchInstantRecoverHypervVm();
        }

        // This parameter set invokes a single graphql operation:
        // updateHypervVirtualMachine.
        internal void ProcessRecord_UpdateVirtualMachine()
        {
            this._logger.name += " -UpdateVirtualMachine";
            // Invoke graphql operation updateHypervVirtualMachine
            InvokeMutationUpdateHypervVirtualMachine();
        }

        // This parameter set invokes a single graphql operation:
        // downloadHypervSnapshotFromLocation.
        internal void ProcessRecord_DownloadSnapshotFromLocation()
        {
            this._logger.name += " -DownloadSnapshotFromLocation";
            // Invoke graphql operation downloadHypervSnapshotFromLocation
            InvokeMutationDownloadHypervSnapshotFromLocation();
        }


        // Invoke GraphQL Mutation:
        // registerHypervScvmm(input: RegisterHypervScvmmInput!): AsyncRequestStatus!
        internal void InvokeMutationRegisterHypervScvmm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RegisterHypervScvmmInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.RegisterHypervScvmm(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationRegisterHypervScvmm",
                "($input: RegisterHypervScvmmInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // hypervScvmmUpdate(input: HypervScvmmUpdateInput!): HypervScvmmUpdateReply!
        internal void InvokeMutationHypervScvmmUpdate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "HypervScvmmUpdateInput!"),
            };
            HypervScvmmUpdateReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (HypervScvmmUpdateReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (HypervScvmmUpdateReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.HypervScvmmUpdate(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationHypervScvmmUpdate",
                "($input: HypervScvmmUpdateInput!)",
                fieldSpecDoc,
                "HypervScvmmUpdateReply"
            );
        }

        // Invoke GraphQL Mutation:
        // hypervScvmmDelete(input: HypervScvmmDeleteInput!): ResponseSuccess!
        internal void InvokeMutationHypervScvmmDelete()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "HypervScvmmDeleteInput!"),
            };
            ResponseSuccess? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ResponseSuccess)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ResponseSuccess)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.HypervScvmmDelete(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationHypervScvmmDelete",
                "($input: HypervScvmmDeleteInput!)",
                fieldSpecDoc,
                "ResponseSuccess"
            );
        }

        // Invoke GraphQL Mutation:
        // refreshHypervScvmm(input: RefreshHypervScvmmInput!): AsyncRequestStatus!
        internal void InvokeMutationRefreshHypervScvmm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshHypervScvmmInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.RefreshHypervScvmm(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationRefreshHypervScvmm",
                "($input: RefreshHypervScvmmInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // hypervOnDemandSnapshot(input: HypervOnDemandSnapshotInput!): AsyncRequestStatus!
        internal void InvokeMutationHypervOnDemandSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "HypervOnDemandSnapshotInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.HypervOnDemandSnapshot(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationHypervOnDemandSnapshot",
                "($input: HypervOnDemandSnapshotInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // hypervDeleteAllSnapshots(input: HypervDeleteAllSnapshotsInput!): RequestSuccess!
        internal void InvokeMutationHypervDeleteAllSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "HypervDeleteAllSnapshotsInput!"),
            };
            RequestSuccess? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (RequestSuccess)psObject.BaseObject;
                } else {
                    fieldSpecObj = (RequestSuccess)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.HypervDeleteAllSnapshots(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationHypervDeleteAllSnapshots",
                "($input: HypervDeleteAllSnapshotsInput!)",
                fieldSpecDoc,
                "RequestSuccess"
            );
        }

        // Invoke GraphQL Mutation:
        // exportHypervVirtualMachine(input: ExportHypervVirtualMachineInput!): AsyncRequestStatus!
        internal void InvokeMutationExportHypervVirtualMachine()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportHypervVirtualMachineInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.ExportHypervVirtualMachine(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationExportHypervVirtualMachine",
                "($input: ExportHypervVirtualMachineInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // downloadHypervVirtualMachineSnapshotFiles(input: DownloadHypervVirtualMachineSnapshotFilesInput!): AsyncRequestStatus!
        internal void InvokeMutationDownloadHypervVirtualMachineSnapshotFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadHypervVirtualMachineSnapshotFilesInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DownloadHypervVirtualMachineSnapshotFiles(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDownloadHypervVirtualMachineSnapshotFiles",
                "($input: DownloadHypervVirtualMachineSnapshotFilesInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // instantRecoverHypervVirtualMachineSnapshot(input: InstantRecoverHypervVirtualMachineSnapshotInput!): AsyncRequestStatus!
        internal void InvokeMutationInstantRecoverHypervVirtualMachineSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "InstantRecoverHypervVirtualMachineSnapshotInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.InstantRecoverHypervVirtualMachineSnapshot(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationInstantRecoverHypervVirtualMachineSnapshot",
                "($input: InstantRecoverHypervVirtualMachineSnapshotInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // restoreHypervVirtualMachineSnapshotFiles(input: RestoreHypervVirtualMachineSnapshotFilesInput!): AsyncRequestStatus!
        internal void InvokeMutationRestoreHypervVirtualMachineSnapshotFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreHypervVirtualMachineSnapshotFilesInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.RestoreHypervVirtualMachineSnapshotFiles(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationRestoreHypervVirtualMachineSnapshotFiles",
                "($input: RestoreHypervVirtualMachineSnapshotFilesInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // registerAgentHypervVirtualMachine(input: RegisterAgentHypervVirtualMachineInput!): RequestSuccess!
        internal void InvokeMutationRegisterAgentHypervVirtualMachine()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RegisterAgentHypervVirtualMachineInput!"),
            };
            RequestSuccess? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (RequestSuccess)psObject.BaseObject;
                } else {
                    fieldSpecObj = (RequestSuccess)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.RegisterAgentHypervVirtualMachine(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationRegisterAgentHypervVirtualMachine",
                "($input: RegisterAgentHypervVirtualMachineInput!)",
                fieldSpecDoc,
                "RequestSuccess"
            );
        }

        // Invoke GraphQL Mutation:
        // deleteHypervVirtualMachineSnapshot(input: DeleteHypervVirtualMachineSnapshotInput!): RequestSuccess!
        internal void InvokeMutationDeleteHypervVirtualMachineSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteHypervVirtualMachineSnapshotInput!"),
            };
            RequestSuccess? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (RequestSuccess)psObject.BaseObject;
                } else {
                    fieldSpecObj = (RequestSuccess)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DeleteHypervVirtualMachineSnapshot(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDeleteHypervVirtualMachineSnapshot",
                "($input: DeleteHypervVirtualMachineSnapshotInput!)",
                fieldSpecDoc,
                "RequestSuccess"
            );
        }

        // Invoke GraphQL Mutation:
        // downloadHypervVirtualMachineSnapshot(input: DownloadHypervVirtualMachineSnapshotInput!): AsyncRequestStatus!
        internal void InvokeMutationDownloadHypervVirtualMachineSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadHypervVirtualMachineSnapshotInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DownloadHypervVirtualMachineSnapshot(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDownloadHypervVirtualMachineSnapshot",
                "($input: DownloadHypervVirtualMachineSnapshotInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // createHypervVirtualMachineSnapshotMount(input: CreateHypervVirtualMachineSnapshotMountInput!): AsyncRequestStatus!
        internal void InvokeMutationCreateHypervVirtualMachineSnapshotMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateHypervVirtualMachineSnapshotMountInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CreateHypervVirtualMachineSnapshotMount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCreateHypervVirtualMachineSnapshotMount",
                "($input: CreateHypervVirtualMachineSnapshotMountInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // updateHypervVirtualMachineSnapshotMount(input: UpdateHypervVirtualMachineSnapshotMountInput!): UpdateHypervVirtualMachineSnapshotMountReply!
        internal void InvokeMutationUpdateHypervVirtualMachineSnapshotMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateHypervVirtualMachineSnapshotMountInput!"),
            };
            UpdateHypervVirtualMachineSnapshotMountReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (UpdateHypervVirtualMachineSnapshotMountReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (UpdateHypervVirtualMachineSnapshotMountReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpdateHypervVirtualMachineSnapshotMount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpdateHypervVirtualMachineSnapshotMount",
                "($input: UpdateHypervVirtualMachineSnapshotMountInput!)",
                fieldSpecDoc,
                "UpdateHypervVirtualMachineSnapshotMountReply"
            );
        }

        // Invoke GraphQL Mutation:
        // deleteHypervVirtualMachineSnapshotMount(input: DeleteHypervVirtualMachineSnapshotMountInput!): AsyncRequestStatus!
        internal void InvokeMutationDeleteHypervVirtualMachineSnapshotMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteHypervVirtualMachineSnapshotMountInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DeleteHypervVirtualMachineSnapshotMount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDeleteHypervVirtualMachineSnapshotMount",
                "($input: DeleteHypervVirtualMachineSnapshotMountInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // refreshHypervServer(input: RefreshHypervServerInput!): AsyncRequestStatus!
        internal void InvokeMutationRefreshHypervServer()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshHypervServerInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.RefreshHypervServer(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationRefreshHypervServer",
                "($input: RefreshHypervServerInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // batchOnDemandBackupHypervVm(input: BatchOnDemandBackupHypervVmInput!): BatchOnDemandBackupHypervVmReply!
        internal void InvokeMutationBatchOnDemandBackupHypervVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BatchOnDemandBackupHypervVmInput!"),
            };
            BatchOnDemandBackupHypervVmReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BatchOnDemandBackupHypervVmReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BatchOnDemandBackupHypervVmReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.BatchOnDemandBackupHypervVm(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationBatchOnDemandBackupHypervVm",
                "($input: BatchOnDemandBackupHypervVmInput!)",
                fieldSpecDoc,
                "BatchOnDemandBackupHypervVmReply"
            );
        }

        // Invoke GraphQL Mutation:
        // batchExportHypervVm(input: BatchExportHypervVmInput!): BatchExportHypervVmReply!
        internal void InvokeMutationBatchExportHypervVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BatchExportHypervVmInput!"),
            };
            BatchExportHypervVmReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BatchExportHypervVmReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BatchExportHypervVmReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.BatchExportHypervVm(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationBatchExportHypervVm",
                "($input: BatchExportHypervVmInput!)",
                fieldSpecDoc,
                "BatchExportHypervVmReply"
            );
        }

        // Invoke GraphQL Mutation:
        // batchMountHypervVm(input: BatchMountHypervVmInput!): BatchMountHypervVmReply!
        internal void InvokeMutationBatchMountHypervVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BatchMountHypervVmInput!"),
            };
            BatchMountHypervVmReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BatchMountHypervVmReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BatchMountHypervVmReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.BatchMountHypervVm(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationBatchMountHypervVm",
                "($input: BatchMountHypervVmInput!)",
                fieldSpecDoc,
                "BatchMountHypervVmReply"
            );
        }

        // Invoke GraphQL Mutation:
        // batchInstantRecoverHypervVm(input: BatchInstantRecoverHypervVmInput!): BatchInstantRecoverHypervVmReply!
        internal void InvokeMutationBatchInstantRecoverHypervVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BatchInstantRecoverHypervVmInput!"),
            };
            BatchInstantRecoverHypervVmReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BatchInstantRecoverHypervVmReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BatchInstantRecoverHypervVmReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.BatchInstantRecoverHypervVm(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationBatchInstantRecoverHypervVm",
                "($input: BatchInstantRecoverHypervVmInput!)",
                fieldSpecDoc,
                "BatchInstantRecoverHypervVmReply"
            );
        }

        // Invoke GraphQL Mutation:
        // updateHypervVirtualMachine(input: UpdateHypervVirtualMachineInput!): UpdateHypervVirtualMachineReply!
        internal void InvokeMutationUpdateHypervVirtualMachine()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateHypervVirtualMachineInput!"),
            };
            UpdateHypervVirtualMachineReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (UpdateHypervVirtualMachineReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (UpdateHypervVirtualMachineReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpdateHypervVirtualMachine(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpdateHypervVirtualMachine",
                "($input: UpdateHypervVirtualMachineInput!)",
                fieldSpecDoc,
                "UpdateHypervVirtualMachineReply"
            );
        }

        // Invoke GraphQL Mutation:
        // downloadHypervSnapshotFromLocation(input: DownloadHypervSnapshotFromLocationInput!): AsyncRequestStatus!
        internal void InvokeMutationDownloadHypervSnapshotFromLocation()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadHypervSnapshotFromLocationInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DownloadHypervSnapshotFromLocation(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDownloadHypervSnapshotFromLocation",
                "($input: DownloadHypervSnapshotFromLocationInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }


    } // class Invoke_RscMutateHyperv
}