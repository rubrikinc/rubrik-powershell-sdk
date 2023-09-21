// New-RscMutationHyperv.cs
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
    /// Mutations for the 'Hyperv' API domain.
    /// </summary>
    /// <description>
    /// New-RscMutationHyperv is a master cmdlet for Hyperv work that can invoke any of the following subcommands: RegisterScvmm, ScvmmUpdate, ScvmmDelete, RefreshScvmm, OnDemandSnapshot, DeleteAllSnapshots, ExportVirtualMachine, DownloadVirtualMachineSnapshotFiles, InstantRecoverVirtualMachineSnapshot, RestoreVirtualMachineSnapshotFiles, RegisterAgentVirtualMachine, DeleteVirtualMachineSnapshot, DownloadVirtualMachineSnapshot, CreateVirtualMachineSnapshotMount, UpdateVirtualMachineSnapshotMount, DeleteVirtualMachineSnapshotMount, RefreshServer, BatchOnDemandBackupVm, BatchExportVm, BatchMountVm, BatchInstantRecoverVm, UpdateVirtualMachine, DownloadSnapshotFromLocation.
    /// </description>
    /// <example>
    /// <code>New-RscMutationHyperv -RegisterScvmm [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationHyperv -ScvmmUpdate [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationHyperv -ScvmmDelete [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationHyperv -RefreshScvmm [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationHyperv -OnDemandSnapshot [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationHyperv -DeleteAllSnapshots [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationHyperv -ExportVirtualMachine [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationHyperv -DownloadVirtualMachineSnapshotFiles [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationHyperv -InstantRecoverVirtualMachineSnapshot [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationHyperv -RestoreVirtualMachineSnapshotFiles [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationHyperv -RegisterAgentVirtualMachine [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationHyperv -DeleteVirtualMachineSnapshot [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationHyperv -DownloadVirtualMachineSnapshot [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationHyperv -CreateVirtualMachineSnapshotMount [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationHyperv -UpdateVirtualMachineSnapshotMount [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationHyperv -DeleteVirtualMachineSnapshotMount [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationHyperv -RefreshServer [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationHyperv -BatchOnDemandBackupVm [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationHyperv -BatchExportVm [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationHyperv -BatchMountVm [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationHyperv -BatchInstantRecoverVm [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationHyperv -UpdateVirtualMachine [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationHyperv -DownloadSnapshotFromLocation [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationHyperv",
        DefaultParameterSetName = "ScvmmUpdate")
    ]
    public class New_RscMutationHyperv : RscGqlPSCmdlet
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
            base.ProcessRecord();
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
            // Create new graphql operation registerHypervScvmm
            InitMutationRegisterHypervScvmm();
        }

        // This parameter set invokes a single graphql operation:
        // hypervScvmmUpdate.
        internal void ProcessRecord_ScvmmUpdate()
        {
            this._logger.name += " -ScvmmUpdate";
            // Create new graphql operation hypervScvmmUpdate
            InitMutationHypervScvmmUpdate();
        }

        // This parameter set invokes a single graphql operation:
        // hypervScvmmDelete.
        internal void ProcessRecord_ScvmmDelete()
        {
            this._logger.name += " -ScvmmDelete";
            // Create new graphql operation hypervScvmmDelete
            InitMutationHypervScvmmDelete();
        }

        // This parameter set invokes a single graphql operation:
        // refreshHypervScvmm.
        internal void ProcessRecord_RefreshScvmm()
        {
            this._logger.name += " -RefreshScvmm";
            // Create new graphql operation refreshHypervScvmm
            InitMutationRefreshHypervScvmm();
        }

        // This parameter set invokes a single graphql operation:
        // hypervOnDemandSnapshot.
        internal void ProcessRecord_OnDemandSnapshot()
        {
            this._logger.name += " -OnDemandSnapshot";
            // Create new graphql operation hypervOnDemandSnapshot
            InitMutationHypervOnDemandSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // hypervDeleteAllSnapshots.
        internal void ProcessRecord_DeleteAllSnapshots()
        {
            this._logger.name += " -DeleteAllSnapshots";
            // Create new graphql operation hypervDeleteAllSnapshots
            InitMutationHypervDeleteAllSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // exportHypervVirtualMachine.
        internal void ProcessRecord_ExportVirtualMachine()
        {
            this._logger.name += " -ExportVirtualMachine";
            // Create new graphql operation exportHypervVirtualMachine
            InitMutationExportHypervVirtualMachine();
        }

        // This parameter set invokes a single graphql operation:
        // downloadHypervVirtualMachineSnapshotFiles.
        internal void ProcessRecord_DownloadVirtualMachineSnapshotFiles()
        {
            this._logger.name += " -DownloadVirtualMachineSnapshotFiles";
            // Create new graphql operation downloadHypervVirtualMachineSnapshotFiles
            InitMutationDownloadHypervVirtualMachineSnapshotFiles();
        }

        // This parameter set invokes a single graphql operation:
        // instantRecoverHypervVirtualMachineSnapshot.
        internal void ProcessRecord_InstantRecoverVirtualMachineSnapshot()
        {
            this._logger.name += " -InstantRecoverVirtualMachineSnapshot";
            // Create new graphql operation instantRecoverHypervVirtualMachineSnapshot
            InitMutationInstantRecoverHypervVirtualMachineSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // restoreHypervVirtualMachineSnapshotFiles.
        internal void ProcessRecord_RestoreVirtualMachineSnapshotFiles()
        {
            this._logger.name += " -RestoreVirtualMachineSnapshotFiles";
            // Create new graphql operation restoreHypervVirtualMachineSnapshotFiles
            InitMutationRestoreHypervVirtualMachineSnapshotFiles();
        }

        // This parameter set invokes a single graphql operation:
        // registerAgentHypervVirtualMachine.
        internal void ProcessRecord_RegisterAgentVirtualMachine()
        {
            this._logger.name += " -RegisterAgentVirtualMachine";
            // Create new graphql operation registerAgentHypervVirtualMachine
            InitMutationRegisterAgentHypervVirtualMachine();
        }

        // This parameter set invokes a single graphql operation:
        // deleteHypervVirtualMachineSnapshot.
        internal void ProcessRecord_DeleteVirtualMachineSnapshot()
        {
            this._logger.name += " -DeleteVirtualMachineSnapshot";
            // Create new graphql operation deleteHypervVirtualMachineSnapshot
            InitMutationDeleteHypervVirtualMachineSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // downloadHypervVirtualMachineSnapshot.
        internal void ProcessRecord_DownloadVirtualMachineSnapshot()
        {
            this._logger.name += " -DownloadVirtualMachineSnapshot";
            // Create new graphql operation downloadHypervVirtualMachineSnapshot
            InitMutationDownloadHypervVirtualMachineSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // createHypervVirtualMachineSnapshotMount.
        internal void ProcessRecord_CreateVirtualMachineSnapshotMount()
        {
            this._logger.name += " -CreateVirtualMachineSnapshotMount";
            // Create new graphql operation createHypervVirtualMachineSnapshotMount
            InitMutationCreateHypervVirtualMachineSnapshotMount();
        }

        // This parameter set invokes a single graphql operation:
        // updateHypervVirtualMachineSnapshotMount.
        internal void ProcessRecord_UpdateVirtualMachineSnapshotMount()
        {
            this._logger.name += " -UpdateVirtualMachineSnapshotMount";
            // Create new graphql operation updateHypervVirtualMachineSnapshotMount
            InitMutationUpdateHypervVirtualMachineSnapshotMount();
        }

        // This parameter set invokes a single graphql operation:
        // deleteHypervVirtualMachineSnapshotMount.
        internal void ProcessRecord_DeleteVirtualMachineSnapshotMount()
        {
            this._logger.name += " -DeleteVirtualMachineSnapshotMount";
            // Create new graphql operation deleteHypervVirtualMachineSnapshotMount
            InitMutationDeleteHypervVirtualMachineSnapshotMount();
        }

        // This parameter set invokes a single graphql operation:
        // refreshHypervServer.
        internal void ProcessRecord_RefreshServer()
        {
            this._logger.name += " -RefreshServer";
            // Create new graphql operation refreshHypervServer
            InitMutationRefreshHypervServer();
        }

        // This parameter set invokes a single graphql operation:
        // batchOnDemandBackupHypervVm.
        internal void ProcessRecord_BatchOnDemandBackupVm()
        {
            this._logger.name += " -BatchOnDemandBackupVm";
            // Create new graphql operation batchOnDemandBackupHypervVm
            InitMutationBatchOnDemandBackupHypervVm();
        }

        // This parameter set invokes a single graphql operation:
        // batchExportHypervVm.
        internal void ProcessRecord_BatchExportVm()
        {
            this._logger.name += " -BatchExportVm";
            // Create new graphql operation batchExportHypervVm
            InitMutationBatchExportHypervVm();
        }

        // This parameter set invokes a single graphql operation:
        // batchMountHypervVm.
        internal void ProcessRecord_BatchMountVm()
        {
            this._logger.name += " -BatchMountVm";
            // Create new graphql operation batchMountHypervVm
            InitMutationBatchMountHypervVm();
        }

        // This parameter set invokes a single graphql operation:
        // batchInstantRecoverHypervVm.
        internal void ProcessRecord_BatchInstantRecoverVm()
        {
            this._logger.name += " -BatchInstantRecoverVm";
            // Create new graphql operation batchInstantRecoverHypervVm
            InitMutationBatchInstantRecoverHypervVm();
        }

        // This parameter set invokes a single graphql operation:
        // updateHypervVirtualMachine.
        internal void ProcessRecord_UpdateVirtualMachine()
        {
            this._logger.name += " -UpdateVirtualMachine";
            // Create new graphql operation updateHypervVirtualMachine
            InitMutationUpdateHypervVirtualMachine();
        }

        // This parameter set invokes a single graphql operation:
        // downloadHypervSnapshotFromLocation.
        internal void ProcessRecord_DownloadSnapshotFromLocation()
        {
            this._logger.name += " -DownloadSnapshotFromLocation";
            // Create new graphql operation downloadHypervSnapshotFromLocation
            InitMutationDownloadHypervSnapshotFromLocation();
        }


        // Create new GraphQL Mutation:
        // registerHypervScvmm(input: RegisterHypervScvmmInput!): AsyncRequestStatus!
        internal void InitMutationRegisterHypervScvmm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RegisterHypervScvmmInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRegisterHypervScvmm",
                "($input: RegisterHypervScvmmInput!)",
                "AsyncRequestStatus",
                Mutation.RegisterHypervScvmm_ObjectFieldSpec,
                Mutation.RegisterHypervScvmmFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	scvmm = @{
		# REQUIRED
		hostname = <System.String>
		# REQUIRED
		runAsAccount = <System.String>
		# REQUIRED
		shouldDeployAgent = <System.Boolean>
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // hypervScvmmUpdate(input: HypervScvmmUpdateInput!): HypervScvmmUpdateReply!
        internal void InitMutationHypervScvmmUpdate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "HypervScvmmUpdateInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationHypervScvmmUpdate",
                "($input: HypervScvmmUpdateInput!)",
                "HypervScvmmUpdateReply",
                Mutation.HypervScvmmUpdate_ObjectFieldSpec,
                Mutation.HypervScvmmUpdateFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	updateProperties = @{
		# OPTIONAL
		configuredSlaDomainId = <System.String>
		# OPTIONAL
		hostname = <System.String>
		# OPTIONAL
		runAsAccount = <System.String>
		# OPTIONAL
		shouldDeployAgent = <System.Boolean>
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // hypervScvmmDelete(input: HypervScvmmDeleteInput!): ResponseSuccess!
        internal void InitMutationHypervScvmmDelete()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "HypervScvmmDeleteInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationHypervScvmmDelete",
                "($input: HypervScvmmDeleteInput!)",
                "ResponseSuccess",
                Mutation.HypervScvmmDelete_ObjectFieldSpec,
                Mutation.HypervScvmmDeleteFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // refreshHypervScvmm(input: RefreshHypervScvmmInput!): AsyncRequestStatus!
        internal void InitMutationRefreshHypervScvmm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshHypervScvmmInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshHypervScvmm",
                "($input: RefreshHypervScvmmInput!)",
                "AsyncRequestStatus",
                Mutation.RefreshHypervScvmm_ObjectFieldSpec,
                Mutation.RefreshHypervScvmmFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // hypervOnDemandSnapshot(input: HypervOnDemandSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationHypervOnDemandSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "HypervOnDemandSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationHypervOnDemandSnapshot",
                "($input: HypervOnDemandSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.HypervOnDemandSnapshot_ObjectFieldSpec,
                Mutation.HypervOnDemandSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	config = @{
		# OPTIONAL
		slaId = <System.String>
	}
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	userNote = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // hypervDeleteAllSnapshots(input: HypervDeleteAllSnapshotsInput!): RequestSuccess!
        internal void InitMutationHypervDeleteAllSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "HypervDeleteAllSnapshotsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationHypervDeleteAllSnapshots",
                "($input: HypervDeleteAllSnapshotsInput!)",
                "RequestSuccess",
                Mutation.HypervDeleteAllSnapshots_ObjectFieldSpec,
                Mutation.HypervDeleteAllSnapshotsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // exportHypervVirtualMachine(input: ExportHypervVirtualMachineInput!): AsyncRequestStatus!
        internal void InitMutationExportHypervVirtualMachine()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportHypervVirtualMachineInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExportHypervVirtualMachine",
                "($input: ExportHypervVirtualMachineInput!)",
                "AsyncRequestStatus",
                Mutation.ExportHypervVirtualMachine_ObjectFieldSpec,
                Mutation.ExportHypervVirtualMachineFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		disableNetwork = <System.Boolean>
		# OPTIONAL
		hostId = <System.String>
		# OPTIONAL
		powerOn = <System.Boolean>
		# OPTIONAL
		removeNetworkDevices = <System.Boolean>
		# OPTIONAL
		vmName = <System.String>
		# REQUIRED
		path = <System.String>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadHypervVirtualMachineSnapshotFiles(input: DownloadHypervVirtualMachineSnapshotFilesInput!): AsyncRequestStatus!
        internal void InitMutationDownloadHypervVirtualMachineSnapshotFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadHypervVirtualMachineSnapshotFilesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadHypervVirtualMachineSnapshotFiles",
                "($input: DownloadHypervVirtualMachineSnapshotFilesInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadHypervVirtualMachineSnapshotFiles_ObjectFieldSpec,
                Mutation.DownloadHypervVirtualMachineSnapshotFilesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		legalHoldDownloadConfig = @{
			# REQUIRED
			isLegalHoldDownload = <System.Boolean>
		}
		# REQUIRED
		paths = @(
			<System.String>
		)
	}
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	userNote = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // instantRecoverHypervVirtualMachineSnapshot(input: InstantRecoverHypervVirtualMachineSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationInstantRecoverHypervVirtualMachineSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "InstantRecoverHypervVirtualMachineSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationInstantRecoverHypervVirtualMachineSnapshot",
                "($input: InstantRecoverHypervVirtualMachineSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.InstantRecoverHypervVirtualMachineSnapshot_ObjectFieldSpec,
                Mutation.InstantRecoverHypervVirtualMachineSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		hostId = <System.String>
		# OPTIONAL
		vmName = <System.String>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // restoreHypervVirtualMachineSnapshotFiles(input: RestoreHypervVirtualMachineSnapshotFilesInput!): AsyncRequestStatus!
        internal void InitMutationRestoreHypervVirtualMachineSnapshotFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreHypervVirtualMachineSnapshotFilesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreHypervVirtualMachineSnapshotFiles",
                "($input: RestoreHypervVirtualMachineSnapshotFilesInput!)",
                "AsyncRequestStatus",
                Mutation.RestoreHypervVirtualMachineSnapshotFiles_ObjectFieldSpec,
                Mutation.RestoreHypervVirtualMachineSnapshotFilesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		targetVirtualMachineId = <System.String>
		# REQUIRED
		restoreConfig = @(
			@{
				# REQUIRED
				path = <System.String>
				# REQUIRED
				restorePath = <System.String>
			}
		)
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // registerAgentHypervVirtualMachine(input: RegisterAgentHypervVirtualMachineInput!): RequestSuccess!
        internal void InitMutationRegisterAgentHypervVirtualMachine()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RegisterAgentHypervVirtualMachineInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRegisterAgentHypervVirtualMachine",
                "($input: RegisterAgentHypervVirtualMachineInput!)",
                "RequestSuccess",
                Mutation.RegisterAgentHypervVirtualMachine_ObjectFieldSpec,
                Mutation.RegisterAgentHypervVirtualMachineFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteHypervVirtualMachineSnapshot(input: DeleteHypervVirtualMachineSnapshotInput!): RequestSuccess!
        internal void InitMutationDeleteHypervVirtualMachineSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteHypervVirtualMachineSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteHypervVirtualMachineSnapshot",
                "($input: DeleteHypervVirtualMachineSnapshotInput!)",
                "RequestSuccess",
                Mutation.DeleteHypervVirtualMachineSnapshot_ObjectFieldSpec,
                Mutation.DeleteHypervVirtualMachineSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	location = <InternalDeleteHypervVirtualMachineSnapshotRequestLocation> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InternalDeleteHypervVirtualMachineSnapshotRequestLocation]) for enum values.
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadHypervVirtualMachineSnapshot(input: DownloadHypervVirtualMachineSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationDownloadHypervVirtualMachineSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadHypervVirtualMachineSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadHypervVirtualMachineSnapshot",
                "($input: DownloadHypervVirtualMachineSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadHypervVirtualMachineSnapshot_ObjectFieldSpec,
                Mutation.DownloadHypervVirtualMachineSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // createHypervVirtualMachineSnapshotMount(input: CreateHypervVirtualMachineSnapshotMountInput!): AsyncRequestStatus!
        internal void InitMutationCreateHypervVirtualMachineSnapshotMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateHypervVirtualMachineSnapshotMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateHypervVirtualMachineSnapshotMount",
                "($input: CreateHypervVirtualMachineSnapshotMountInput!)",
                "AsyncRequestStatus",
                Mutation.CreateHypervVirtualMachineSnapshotMount_ObjectFieldSpec,
                Mutation.CreateHypervVirtualMachineSnapshotMountFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	config = @{
		# OPTIONAL
		disableNetwork = <System.Boolean>
		# OPTIONAL
		hostId = <System.String>
		# OPTIONAL
		powerOn = <System.Boolean>
		# OPTIONAL
		removeNetworkDevices = <System.Boolean>
		# OPTIONAL
		vmName = <System.String>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateHypervVirtualMachineSnapshotMount(input: UpdateHypervVirtualMachineSnapshotMountInput!): UpdateHypervVirtualMachineSnapshotMountReply!
        internal void InitMutationUpdateHypervVirtualMachineSnapshotMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateHypervVirtualMachineSnapshotMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateHypervVirtualMachineSnapshotMount",
                "($input: UpdateHypervVirtualMachineSnapshotMountInput!)",
                "UpdateHypervVirtualMachineSnapshotMountReply",
                Mutation.UpdateHypervVirtualMachineSnapshotMount_ObjectFieldSpec,
                Mutation.UpdateHypervVirtualMachineSnapshotMountFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		powerStatus = <System.Boolean>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteHypervVirtualMachineSnapshotMount(input: DeleteHypervVirtualMachineSnapshotMountInput!): AsyncRequestStatus!
        internal void InitMutationDeleteHypervVirtualMachineSnapshotMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteHypervVirtualMachineSnapshotMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteHypervVirtualMachineSnapshotMount",
                "($input: DeleteHypervVirtualMachineSnapshotMountInput!)",
                "AsyncRequestStatus",
                Mutation.DeleteHypervVirtualMachineSnapshotMount_ObjectFieldSpec,
                Mutation.DeleteHypervVirtualMachineSnapshotMountFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	force = <System.Boolean>
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // refreshHypervServer(input: RefreshHypervServerInput!): AsyncRequestStatus!
        internal void InitMutationRefreshHypervServer()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshHypervServerInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshHypervServer",
                "($input: RefreshHypervServerInput!)",
                "AsyncRequestStatus",
                Mutation.RefreshHypervServer_ObjectFieldSpec,
                Mutation.RefreshHypervServerFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // batchOnDemandBackupHypervVm(input: BatchOnDemandBackupHypervVmInput!): BatchOnDemandBackupHypervVmReply!
        internal void InitMutationBatchOnDemandBackupHypervVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BatchOnDemandBackupHypervVmInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBatchOnDemandBackupHypervVm",
                "($input: BatchOnDemandBackupHypervVmInput!)",
                "BatchOnDemandBackupHypervVmReply",
                Mutation.BatchOnDemandBackupHypervVm_ObjectFieldSpec,
                Mutation.BatchOnDemandBackupHypervVmFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	userNote = <System.String>
	# REQUIRED
	config = @{
		# REQUIRED
		vms = @(
			@{
				# OPTIONAL
				backupConfig = @{
					# OPTIONAL
					slaId = <System.String>
				}
				# OPTIONAL
				vmId = <System.String>
			}
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // batchExportHypervVm(input: BatchExportHypervVmInput!): BatchExportHypervVmReply!
        internal void InitMutationBatchExportHypervVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BatchExportHypervVmInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBatchExportHypervVm",
                "($input: BatchExportHypervVmInput!)",
                "BatchExportHypervVmReply",
                Mutation.BatchExportHypervVm_ObjectFieldSpec,
                Mutation.BatchExportHypervVmFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	config = @{
		# REQUIRED
		snapshots = @(
			@{
				# OPTIONAL
				snapshotAfterDate = <DateTime>
				# OPTIONAL
				snapshotBeforeDate = <DateTime>
				# OPTIONAL
				snapshotId = <System.String>
				# OPTIONAL
				vmNamePrefix = <System.String>
				# REQUIRED
				exportConfig = @{
					# OPTIONAL
					disableNetwork = <System.Boolean>
					# OPTIONAL
					hostId = <System.String>
					# OPTIONAL
					powerOn = <System.Boolean>
					# OPTIONAL
					removeNetworkDevices = <System.Boolean>
					# OPTIONAL
					vmName = <System.String>
					# REQUIRED
					path = <System.String>
				}
				# REQUIRED
				vmId = <System.String>
			}
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // batchMountHypervVm(input: BatchMountHypervVmInput!): BatchMountHypervVmReply!
        internal void InitMutationBatchMountHypervVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BatchMountHypervVmInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBatchMountHypervVm",
                "($input: BatchMountHypervVmInput!)",
                "BatchMountHypervVmReply",
                Mutation.BatchMountHypervVm_ObjectFieldSpec,
                Mutation.BatchMountHypervVmFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	config = @{
		# REQUIRED
		snapshots = @(
			@{
				# OPTIONAL
				snapshotAfterDate = <DateTime>
				# OPTIONAL
				snapshotBeforeDate = <DateTime>
				# OPTIONAL
				snapshotId = <System.String>
				# OPTIONAL
				vmNamePrefix = <System.String>
				# REQUIRED
				mountConfig = @{
					# OPTIONAL
					disableNetwork = <System.Boolean>
					# OPTIONAL
					hostId = <System.String>
					# OPTIONAL
					powerOn = <System.Boolean>
					# OPTIONAL
					removeNetworkDevices = <System.Boolean>
					# OPTIONAL
					vmName = <System.String>
				}
				# REQUIRED
				vmId = <System.String>
			}
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // batchInstantRecoverHypervVm(input: BatchInstantRecoverHypervVmInput!): BatchInstantRecoverHypervVmReply!
        internal void InitMutationBatchInstantRecoverHypervVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BatchInstantRecoverHypervVmInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBatchInstantRecoverHypervVm",
                "($input: BatchInstantRecoverHypervVmInput!)",
                "BatchInstantRecoverHypervVmReply",
                Mutation.BatchInstantRecoverHypervVm_ObjectFieldSpec,
                Mutation.BatchInstantRecoverHypervVmFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	config = @{
		# REQUIRED
		snapshots = @(
			@{
				# OPTIONAL
				snapshotAfterDate = <DateTime>
				# OPTIONAL
				snapshotBeforeDate = <DateTime>
				# OPTIONAL
				snapshotId = <System.String>
				# REQUIRED
				instantRecoveryConfig = @{
					# OPTIONAL
					hostId = <System.String>
					# OPTIONAL
					vmName = <System.String>
				}
				# REQUIRED
				vmId = <System.String>
			}
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateHypervVirtualMachine(input: UpdateHypervVirtualMachineInput!): UpdateHypervVirtualMachineReply!
        internal void InitMutationUpdateHypervVirtualMachine()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateHypervVirtualMachineInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateHypervVirtualMachine",
                "($input: UpdateHypervVirtualMachineInput!)",
                "UpdateHypervVirtualMachineReply",
                Mutation.UpdateHypervVirtualMachine_ObjectFieldSpec,
                Mutation.UpdateHypervVirtualMachineFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	vmUpdateProperties = @{
		# OPTIONAL
		cloudInstantiationSpec = @{
			# REQUIRED
			imageRetentionInSeconds = <System.Int64>
		}
		# OPTIONAL
		configuredSlaDomainId = <System.String>
		# OPTIONAL
		virtualDiskIdsExcludedFromSnapshot = @(
			<System.String>
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadHypervSnapshotFromLocation(input: DownloadHypervSnapshotFromLocationInput!): AsyncRequestStatus!
        internal void InitMutationDownloadHypervSnapshotFromLocation()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadHypervSnapshotFromLocationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadHypervSnapshotFromLocation",
                "($input: DownloadHypervSnapshotFromLocationInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadHypervSnapshotFromLocation_ObjectFieldSpec,
                Mutation.DownloadHypervSnapshotFromLocationFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	locationId = <System.String>
	# REQUIRED
	snapshotId = <System.String>
	# REQUIRED
	downloadConfig = @{
		# OPTIONAL
		slaId = <System.String>
	}
}"
            );
        }


    } // class New_RscMutationHyperv
}