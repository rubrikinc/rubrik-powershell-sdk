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
        
        // -------------------------------------------------------------------
        // RegisterScvmm parameter set
        //
        // [GraphQL: registerHypervScvmm]
        //
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

        
        // -------------------------------------------------------------------
        // ScvmmUpdate parameter set
        //
        // [GraphQL: hypervScvmmUpdate]
        //
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

        
        // -------------------------------------------------------------------
        // ScvmmDelete parameter set
        //
        // [GraphQL: hypervScvmmDelete]
        //
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

        
        // -------------------------------------------------------------------
        // RefreshScvmm parameter set
        //
        // [GraphQL: refreshHypervScvmm]
        //
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

        
        // -------------------------------------------------------------------
        // OnDemandSnapshot parameter set
        //
        // [GraphQL: hypervOnDemandSnapshot]
        //
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

        
        // -------------------------------------------------------------------
        // DeleteAllSnapshot parameter set
        //
        // [GraphQL: hypervDeleteAllSnapshots]
        //
        [Parameter(
            ParameterSetName = "DeleteAllSnapshot",
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
        public SwitchParameter DeleteAllSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // ExportVirtualMachine parameter set
        //
        // [GraphQL: exportHypervVirtualMachine]
        //
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

        
        // -------------------------------------------------------------------
        // DownloadVirtualMachineSnapshotFile parameter set
        //
        // [GraphQL: downloadHypervVirtualMachineSnapshotFiles]
        //
        [Parameter(
            ParameterSetName = "DownloadVirtualMachineSnapshotFile",
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
        public SwitchParameter DownloadVirtualMachineSnapshotFile { get; set; }

        
        // -------------------------------------------------------------------
        // InstantRecoverVirtualMachineSnapshot parameter set
        //
        // [GraphQL: instantRecoverHypervVirtualMachineSnapshot]
        //
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

        
        // -------------------------------------------------------------------
        // RestoreVirtualMachineSnapshotFile parameter set
        //
        // [GraphQL: restoreHypervVirtualMachineSnapshotFiles]
        //
        [Parameter(
            ParameterSetName = "RestoreVirtualMachineSnapshotFile",
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
        public SwitchParameter RestoreVirtualMachineSnapshotFile { get; set; }

        
        // -------------------------------------------------------------------
        // RegisterAgentVirtualMachine parameter set
        //
        // [GraphQL: registerAgentHypervVirtualMachine]
        //
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

        
        // -------------------------------------------------------------------
        // DeleteVirtualMachineSnapshot parameter set
        //
        // [GraphQL: deleteHypervVirtualMachineSnapshot]
        //
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

        
        // -------------------------------------------------------------------
        // DownloadVirtualMachineSnapshot parameter set
        //
        // [GraphQL: downloadHypervVirtualMachineSnapshot]
        //
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

        
        // -------------------------------------------------------------------
        // CreateVirtualMachineSnapshotMount parameter set
        //
        // [GraphQL: createHypervVirtualMachineSnapshotMount]
        //
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

        
        // -------------------------------------------------------------------
        // UpdateVirtualMachineSnapshotMount parameter set
        //
        // [GraphQL: updateHypervVirtualMachineSnapshotMount]
        //
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

        
        // -------------------------------------------------------------------
        // DeleteVirtualMachineSnapshotMount parameter set
        //
        // [GraphQL: deleteHypervVirtualMachineSnapshotMount]
        //
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

        
        // -------------------------------------------------------------------
        // RefreshServer parameter set
        //
        // [GraphQL: refreshHypervServer]
        //
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

        
        // -------------------------------------------------------------------
        // BatchOnDemandBackupVm parameter set
        //
        // [GraphQL: batchOnDemandBackupHypervVm]
        //
        [Parameter(
            ParameterSetName = "BatchOnDemandBackupVm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Takes bulk on-demand backup of Hyper-V virtual machines

Supported in v9.0
Takes on-demand backup of multiple specified Hyper-V virtual machines.
[GraphQL: batchOnDemandBackupHypervVm]",
            Position = 0
        )]
        public SwitchParameter BatchOnDemandBackupVm { get; set; }

        
        // -------------------------------------------------------------------
        // BatchExportVm parameter set
        //
        // [GraphQL: batchExportHypervVm]
        //
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

        
        // -------------------------------------------------------------------
        // BatchMountVm parameter set
        //
        // [GraphQL: batchMountHypervVm]
        //
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

        
        // -------------------------------------------------------------------
        // BatchInstantRecoverVm parameter set
        //
        // [GraphQL: batchInstantRecoverHypervVm]
        //
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

        
        // -------------------------------------------------------------------
        // UpdateVirtualMachine parameter set
        //
        // [GraphQL: updateHypervVirtualMachine]
        //
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

        
        // -------------------------------------------------------------------
        // DownloadSnapshotFromLocation parameter set
        //
        // [GraphQL: downloadHypervSnapshotFromLocation]
        //
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
                    case "DeleteAllSnapshot":
                        this.ProcessRecord_DeleteAllSnapshot();
                        break;
                    case "ExportVirtualMachine":
                        this.ProcessRecord_ExportVirtualMachine();
                        break;
                    case "DownloadVirtualMachineSnapshotFile":
                        this.ProcessRecord_DownloadVirtualMachineSnapshotFile();
                        break;
                    case "InstantRecoverVirtualMachineSnapshot":
                        this.ProcessRecord_InstantRecoverVirtualMachineSnapshot();
                        break;
                    case "RestoreVirtualMachineSnapshotFile":
                        this.ProcessRecord_RestoreVirtualMachineSnapshotFile();
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

        // This parameter set invokes a single graphql operation:
        // registerHypervScvmm.
        protected void ProcessRecord_RegisterScvmm()
        {
            this._logger.name += " -RegisterScvmm";
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
        protected void ProcessRecord_RefreshScvmm()
        {
            this._logger.name += " -RefreshScvmm";
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
        protected void ProcessRecord_ExportVirtualMachine()
        {
            this._logger.name += " -ExportVirtualMachine";
            // Invoke graphql operation exportHypervVirtualMachine
            InvokeMutationExportHypervVirtualMachine();
        }

        // This parameter set invokes a single graphql operation:
        // downloadHypervVirtualMachineSnapshotFiles.
        protected void ProcessRecord_DownloadVirtualMachineSnapshotFile()
        {
            this._logger.name += " -DownloadVirtualMachineSnapshotFile";
            // Invoke graphql operation downloadHypervVirtualMachineSnapshotFiles
            InvokeMutationDownloadHypervVirtualMachineSnapshotFiles();
        }

        // This parameter set invokes a single graphql operation:
        // instantRecoverHypervVirtualMachineSnapshot.
        protected void ProcessRecord_InstantRecoverVirtualMachineSnapshot()
        {
            this._logger.name += " -InstantRecoverVirtualMachineSnapshot";
            // Invoke graphql operation instantRecoverHypervVirtualMachineSnapshot
            InvokeMutationInstantRecoverHypervVirtualMachineSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // restoreHypervVirtualMachineSnapshotFiles.
        protected void ProcessRecord_RestoreVirtualMachineSnapshotFile()
        {
            this._logger.name += " -RestoreVirtualMachineSnapshotFile";
            // Invoke graphql operation restoreHypervVirtualMachineSnapshotFiles
            InvokeMutationRestoreHypervVirtualMachineSnapshotFiles();
        }

        // This parameter set invokes a single graphql operation:
        // registerAgentHypervVirtualMachine.
        protected void ProcessRecord_RegisterAgentVirtualMachine()
        {
            this._logger.name += " -RegisterAgentVirtualMachine";
            // Invoke graphql operation registerAgentHypervVirtualMachine
            InvokeMutationRegisterAgentHypervVirtualMachine();
        }

        // This parameter set invokes a single graphql operation:
        // deleteHypervVirtualMachineSnapshot.
        protected void ProcessRecord_DeleteVirtualMachineSnapshot()
        {
            this._logger.name += " -DeleteVirtualMachineSnapshot";
            // Invoke graphql operation deleteHypervVirtualMachineSnapshot
            InvokeMutationDeleteHypervVirtualMachineSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // downloadHypervVirtualMachineSnapshot.
        protected void ProcessRecord_DownloadVirtualMachineSnapshot()
        {
            this._logger.name += " -DownloadVirtualMachineSnapshot";
            // Invoke graphql operation downloadHypervVirtualMachineSnapshot
            InvokeMutationDownloadHypervVirtualMachineSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // createHypervVirtualMachineSnapshotMount.
        protected void ProcessRecord_CreateVirtualMachineSnapshotMount()
        {
            this._logger.name += " -CreateVirtualMachineSnapshotMount";
            // Invoke graphql operation createHypervVirtualMachineSnapshotMount
            InvokeMutationCreateHypervVirtualMachineSnapshotMount();
        }

        // This parameter set invokes a single graphql operation:
        // updateHypervVirtualMachineSnapshotMount.
        protected void ProcessRecord_UpdateVirtualMachineSnapshotMount()
        {
            this._logger.name += " -UpdateVirtualMachineSnapshotMount";
            // Invoke graphql operation updateHypervVirtualMachineSnapshotMount
            InvokeMutationUpdateHypervVirtualMachineSnapshotMount();
        }

        // This parameter set invokes a single graphql operation:
        // deleteHypervVirtualMachineSnapshotMount.
        protected void ProcessRecord_DeleteVirtualMachineSnapshotMount()
        {
            this._logger.name += " -DeleteVirtualMachineSnapshotMount";
            // Invoke graphql operation deleteHypervVirtualMachineSnapshotMount
            InvokeMutationDeleteHypervVirtualMachineSnapshotMount();
        }

        // This parameter set invokes a single graphql operation:
        // refreshHypervServer.
        protected void ProcessRecord_RefreshServer()
        {
            this._logger.name += " -RefreshServer";
            // Invoke graphql operation refreshHypervServer
            InvokeMutationRefreshHypervServer();
        }

        // This parameter set invokes a single graphql operation:
        // batchOnDemandBackupHypervVm.
        protected void ProcessRecord_BatchOnDemandBackupVm()
        {
            this._logger.name += " -BatchOnDemandBackupVm";
            // Invoke graphql operation batchOnDemandBackupHypervVm
            InvokeMutationBatchOnDemandBackupHypervVm();
        }

        // This parameter set invokes a single graphql operation:
        // batchExportHypervVm.
        protected void ProcessRecord_BatchExportVm()
        {
            this._logger.name += " -BatchExportVm";
            // Invoke graphql operation batchExportHypervVm
            InvokeMutationBatchExportHypervVm();
        }

        // This parameter set invokes a single graphql operation:
        // batchMountHypervVm.
        protected void ProcessRecord_BatchMountVm()
        {
            this._logger.name += " -BatchMountVm";
            // Invoke graphql operation batchMountHypervVm
            InvokeMutationBatchMountHypervVm();
        }

        // This parameter set invokes a single graphql operation:
        // batchInstantRecoverHypervVm.
        protected void ProcessRecord_BatchInstantRecoverVm()
        {
            this._logger.name += " -BatchInstantRecoverVm";
            // Invoke graphql operation batchInstantRecoverHypervVm
            InvokeMutationBatchInstantRecoverHypervVm();
        }

        // This parameter set invokes a single graphql operation:
        // updateHypervVirtualMachine.
        protected void ProcessRecord_UpdateVirtualMachine()
        {
            this._logger.name += " -UpdateVirtualMachine";
            // Invoke graphql operation updateHypervVirtualMachine
            InvokeMutationUpdateHypervVirtualMachine();
        }

        // This parameter set invokes a single graphql operation:
        // downloadHypervSnapshotFromLocation.
        protected void ProcessRecord_DownloadSnapshotFromLocation()
        {
            this._logger.name += " -DownloadSnapshotFromLocation";
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
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.RegisterHypervScvmm(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RegisterHypervScvmm");
            var parameters = "($input: RegisterHypervScvmmInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRegisterHypervScvmm" + parameters + "{" + document + "}",
                OperationName = "MutationRegisterHypervScvmm",
            };
            var vars = new OperationVariableSet();
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
        // hypervScvmmUpdate(input: HypervScvmmUpdateInput!): HypervScvmmUpdateReply!
        protected void InvokeMutationHypervScvmmUpdate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "HypervScvmmUpdateInput!"),
            };
            HypervScvmmUpdateReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (HypervScvmmUpdateReply)psObject.BaseObject;
                } else {
                    fields = (HypervScvmmUpdateReply)this.Field;
                }
            }
            string document = Mutation.HypervScvmmUpdate(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.HypervScvmmUpdate");
            var parameters = "($input: HypervScvmmUpdateInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationHypervScvmmUpdate" + parameters + "{" + document + "}",
                OperationName = "MutationHypervScvmmUpdate",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "HypervScvmmUpdateReply", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (ResponseSuccess)psObject.BaseObject;
                } else {
                    fields = (ResponseSuccess)this.Field;
                }
            }
            string document = Mutation.HypervScvmmDelete(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.HypervScvmmDelete");
            var parameters = "($input: HypervScvmmDeleteInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationHypervScvmmDelete" + parameters + "{" + document + "}",
                OperationName = "MutationHypervScvmmDelete",
            };
            var vars = new OperationVariableSet();
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
        // refreshHypervScvmm(input: RefreshHypervScvmmInput!): AsyncRequestStatus!
        protected void InvokeMutationRefreshHypervScvmm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshHypervScvmmInput!"),
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
            string document = Mutation.RefreshHypervScvmm(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RefreshHypervScvmm");
            var parameters = "($input: RefreshHypervScvmmInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRefreshHypervScvmm" + parameters + "{" + document + "}",
                OperationName = "MutationRefreshHypervScvmm",
            };
            var vars = new OperationVariableSet();
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
        // hypervOnDemandSnapshot(input: HypervOnDemandSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationHypervOnDemandSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "HypervOnDemandSnapshotInput!"),
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
            string document = Mutation.HypervOnDemandSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.HypervOnDemandSnapshot");
            var parameters = "($input: HypervOnDemandSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationHypervOnDemandSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationHypervOnDemandSnapshot",
            };
            var vars = new OperationVariableSet();
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
        // hypervDeleteAllSnapshots(input: HypervDeleteAllSnapshotsInput!): RequestSuccess!
        protected void InvokeMutationHypervDeleteAllSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "HypervDeleteAllSnapshotsInput!"),
            };
            RequestSuccess? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (RequestSuccess)psObject.BaseObject;
                } else {
                    fields = (RequestSuccess)this.Field;
                }
            }
            string document = Mutation.HypervDeleteAllSnapshots(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.HypervDeleteAllSnapshots");
            var parameters = "($input: HypervDeleteAllSnapshotsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationHypervDeleteAllSnapshots" + parameters + "{" + document + "}",
                OperationName = "MutationHypervDeleteAllSnapshots",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "RequestSuccess", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.ExportHypervVirtualMachine(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.ExportHypervVirtualMachine");
            var parameters = "($input: ExportHypervVirtualMachineInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationExportHypervVirtualMachine" + parameters + "{" + document + "}",
                OperationName = "MutationExportHypervVirtualMachine",
            };
            var vars = new OperationVariableSet();
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
        // downloadHypervVirtualMachineSnapshotFiles(input: DownloadHypervVirtualMachineSnapshotFilesInput!): AsyncRequestStatus!
        protected void InvokeMutationDownloadHypervVirtualMachineSnapshotFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadHypervVirtualMachineSnapshotFilesInput!"),
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
            string document = Mutation.DownloadHypervVirtualMachineSnapshotFiles(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DownloadHypervVirtualMachineSnapshotFiles");
            var parameters = "($input: DownloadHypervVirtualMachineSnapshotFilesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDownloadHypervVirtualMachineSnapshotFiles" + parameters + "{" + document + "}",
                OperationName = "MutationDownloadHypervVirtualMachineSnapshotFiles",
            };
            var vars = new OperationVariableSet();
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
        // instantRecoverHypervVirtualMachineSnapshot(input: InstantRecoverHypervVirtualMachineSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationInstantRecoverHypervVirtualMachineSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "InstantRecoverHypervVirtualMachineSnapshotInput!"),
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
            string document = Mutation.InstantRecoverHypervVirtualMachineSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.InstantRecoverHypervVirtualMachineSnapshot");
            var parameters = "($input: InstantRecoverHypervVirtualMachineSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationInstantRecoverHypervVirtualMachineSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationInstantRecoverHypervVirtualMachineSnapshot",
            };
            var vars = new OperationVariableSet();
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
        // restoreHypervVirtualMachineSnapshotFiles(input: RestoreHypervVirtualMachineSnapshotFilesInput!): AsyncRequestStatus!
        protected void InvokeMutationRestoreHypervVirtualMachineSnapshotFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreHypervVirtualMachineSnapshotFilesInput!"),
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
            string document = Mutation.RestoreHypervVirtualMachineSnapshotFiles(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RestoreHypervVirtualMachineSnapshotFiles");
            var parameters = "($input: RestoreHypervVirtualMachineSnapshotFilesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRestoreHypervVirtualMachineSnapshotFiles" + parameters + "{" + document + "}",
                OperationName = "MutationRestoreHypervVirtualMachineSnapshotFiles",
            };
            var vars = new OperationVariableSet();
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
        // registerAgentHypervVirtualMachine(input: RegisterAgentHypervVirtualMachineInput!): RequestSuccess!
        protected void InvokeMutationRegisterAgentHypervVirtualMachine()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RegisterAgentHypervVirtualMachineInput!"),
            };
            RequestSuccess? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (RequestSuccess)psObject.BaseObject;
                } else {
                    fields = (RequestSuccess)this.Field;
                }
            }
            string document = Mutation.RegisterAgentHypervVirtualMachine(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RegisterAgentHypervVirtualMachine");
            var parameters = "($input: RegisterAgentHypervVirtualMachineInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRegisterAgentHypervVirtualMachine" + parameters + "{" + document + "}",
                OperationName = "MutationRegisterAgentHypervVirtualMachine",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "RequestSuccess", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (RequestSuccess)psObject.BaseObject;
                } else {
                    fields = (RequestSuccess)this.Field;
                }
            }
            string document = Mutation.DeleteHypervVirtualMachineSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteHypervVirtualMachineSnapshot");
            var parameters = "($input: DeleteHypervVirtualMachineSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteHypervVirtualMachineSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteHypervVirtualMachineSnapshot",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "RequestSuccess", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.DownloadHypervVirtualMachineSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DownloadHypervVirtualMachineSnapshot");
            var parameters = "($input: DownloadHypervVirtualMachineSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDownloadHypervVirtualMachineSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationDownloadHypervVirtualMachineSnapshot",
            };
            var vars = new OperationVariableSet();
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
        // createHypervVirtualMachineSnapshotMount(input: CreateHypervVirtualMachineSnapshotMountInput!): AsyncRequestStatus!
        protected void InvokeMutationCreateHypervVirtualMachineSnapshotMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateHypervVirtualMachineSnapshotMountInput!"),
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
            string document = Mutation.CreateHypervVirtualMachineSnapshotMount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateHypervVirtualMachineSnapshotMount");
            var parameters = "($input: CreateHypervVirtualMachineSnapshotMountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateHypervVirtualMachineSnapshotMount" + parameters + "{" + document + "}",
                OperationName = "MutationCreateHypervVirtualMachineSnapshotMount",
            };
            var vars = new OperationVariableSet();
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
        // updateHypervVirtualMachineSnapshotMount(input: UpdateHypervVirtualMachineSnapshotMountInput!): UpdateHypervVirtualMachineSnapshotMountReply!
        protected void InvokeMutationUpdateHypervVirtualMachineSnapshotMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateHypervVirtualMachineSnapshotMountInput!"),
            };
            UpdateHypervVirtualMachineSnapshotMountReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (UpdateHypervVirtualMachineSnapshotMountReply)psObject.BaseObject;
                } else {
                    fields = (UpdateHypervVirtualMachineSnapshotMountReply)this.Field;
                }
            }
            string document = Mutation.UpdateHypervVirtualMachineSnapshotMount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateHypervVirtualMachineSnapshotMount");
            var parameters = "($input: UpdateHypervVirtualMachineSnapshotMountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateHypervVirtualMachineSnapshotMount" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateHypervVirtualMachineSnapshotMount",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "UpdateHypervVirtualMachineSnapshotMountReply", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.DeleteHypervVirtualMachineSnapshotMount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteHypervVirtualMachineSnapshotMount");
            var parameters = "($input: DeleteHypervVirtualMachineSnapshotMountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteHypervVirtualMachineSnapshotMount" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteHypervVirtualMachineSnapshotMount",
            };
            var vars = new OperationVariableSet();
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
        // refreshHypervServer(input: RefreshHypervServerInput!): AsyncRequestStatus!
        protected void InvokeMutationRefreshHypervServer()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshHypervServerInput!"),
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
            string document = Mutation.RefreshHypervServer(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RefreshHypervServer");
            var parameters = "($input: RefreshHypervServerInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRefreshHypervServer" + parameters + "{" + document + "}",
                OperationName = "MutationRefreshHypervServer",
            };
            var vars = new OperationVariableSet();
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
        // batchOnDemandBackupHypervVm(input: BatchOnDemandBackupHypervVmInput!): BatchOnDemandBackupHypervVmReply!
        protected void InvokeMutationBatchOnDemandBackupHypervVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BatchOnDemandBackupHypervVmInput!"),
            };
            BatchOnDemandBackupHypervVmReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (BatchOnDemandBackupHypervVmReply)psObject.BaseObject;
                } else {
                    fields = (BatchOnDemandBackupHypervVmReply)this.Field;
                }
            }
            string document = Mutation.BatchOnDemandBackupHypervVm(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BatchOnDemandBackupHypervVm");
            var parameters = "($input: BatchOnDemandBackupHypervVmInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBatchOnDemandBackupHypervVm" + parameters + "{" + document + "}",
                OperationName = "MutationBatchOnDemandBackupHypervVm",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BatchOnDemandBackupHypervVmReply", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (BatchExportHypervVmReply)psObject.BaseObject;
                } else {
                    fields = (BatchExportHypervVmReply)this.Field;
                }
            }
            string document = Mutation.BatchExportHypervVm(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BatchExportHypervVm");
            var parameters = "($input: BatchExportHypervVmInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBatchExportHypervVm" + parameters + "{" + document + "}",
                OperationName = "MutationBatchExportHypervVm",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BatchExportHypervVmReply", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (BatchMountHypervVmReply)psObject.BaseObject;
                } else {
                    fields = (BatchMountHypervVmReply)this.Field;
                }
            }
            string document = Mutation.BatchMountHypervVm(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BatchMountHypervVm");
            var parameters = "($input: BatchMountHypervVmInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBatchMountHypervVm" + parameters + "{" + document + "}",
                OperationName = "MutationBatchMountHypervVm",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BatchMountHypervVmReply", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (BatchInstantRecoverHypervVmReply)psObject.BaseObject;
                } else {
                    fields = (BatchInstantRecoverHypervVmReply)this.Field;
                }
            }
            string document = Mutation.BatchInstantRecoverHypervVm(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BatchInstantRecoverHypervVm");
            var parameters = "($input: BatchInstantRecoverHypervVmInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBatchInstantRecoverHypervVm" + parameters + "{" + document + "}",
                OperationName = "MutationBatchInstantRecoverHypervVm",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BatchInstantRecoverHypervVmReply", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (UpdateHypervVirtualMachineReply)psObject.BaseObject;
                } else {
                    fields = (UpdateHypervVirtualMachineReply)this.Field;
                }
            }
            string document = Mutation.UpdateHypervVirtualMachine(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateHypervVirtualMachine");
            var parameters = "($input: UpdateHypervVirtualMachineInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateHypervVirtualMachine" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateHypervVirtualMachine",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "UpdateHypervVirtualMachineReply", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.DownloadHypervSnapshotFromLocation(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DownloadHypervSnapshotFromLocation");
            var parameters = "($input: DownloadHypervSnapshotFromLocationInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDownloadHypervSnapshotFromLocation" + parameters + "{" + document + "}",
                OperationName = "MutationDownloadHypervSnapshotFromLocation",
            };
            var vars = new OperationVariableSet();
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


    } // class Invoke_RscMutateHyperv
}