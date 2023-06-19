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
        DefaultParameterSetName = "Scvmmupdate")
    ]
    public class Invoke_RscMutateHyperv : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // Registerscvmm parameter set
        //
        // [GraphQL: registerHypervScvmm]
        //
        [Parameter(
            ParameterSetName = "Registerscvmm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Register HyperV SCVMM to Rubrik Cluster.
[GraphQL: registerHypervScvmm]",
            Position = 0
        )]
        public SwitchParameter Registerscvmm { get; set; }

        [Parameter(
            ParameterSetName = "Registerscvmm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Input for register Hyper-V SCVMM.
GraphQL argument input: RegisterHypervScvmmInput!"
        )]
        public RegisterHypervScvmmInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // Scvmmupdate parameter set
        //
        // [GraphQL: hypervScvmmUpdate]
        //
        [Parameter(
            ParameterSetName = "Scvmmupdate",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update properties for a given HyperV SCVMM.
[GraphQL: hypervScvmmUpdate]",
            Position = 0
        )]
        public SwitchParameter Scvmmupdate { get; set; }

        
        // -------------------------------------------------------------------
        // Scvmmdelete parameter set
        //
        // [GraphQL: hypervScvmmDelete]
        //
        [Parameter(
            ParameterSetName = "Scvmmdelete",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete a given HyperV SCVMM.
[GraphQL: hypervScvmmDelete]",
            Position = 0
        )]
        public SwitchParameter Scvmmdelete { get; set; }

        
        // -------------------------------------------------------------------
        // Refreshscvmm parameter set
        //
        // [GraphQL: refreshHypervScvmm]
        //
        [Parameter(
            ParameterSetName = "Refreshscvmm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refresh a given HyperV SCVMM.
[GraphQL: refreshHypervScvmm]",
            Position = 0
        )]
        public SwitchParameter Refreshscvmm { get; set; }

        
        // -------------------------------------------------------------------
        // Ondemandsnapshot parameter set
        //
        // [GraphQL: hypervOnDemandSnapshot]
        //
        [Parameter(
            ParameterSetName = "Ondemandsnapshot",
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
        public SwitchParameter Ondemandsnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // Deleteallsnapshot parameter set
        //
        // [GraphQL: hypervDeleteAllSnapshots]
        //
        [Parameter(
            ParameterSetName = "Deleteallsnapshot",
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
        public SwitchParameter Deleteallsnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // Exportvirtualmachine parameter set
        //
        // [GraphQL: exportHypervVirtualMachine]
        //
        [Parameter(
            ParameterSetName = "Exportvirtualmachine",
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
        public SwitchParameter Exportvirtualmachine { get; set; }

        
        // -------------------------------------------------------------------
        // Downloadvirtualmachinesnapshotfile parameter set
        //
        // [GraphQL: downloadHypervVirtualMachineSnapshotFiles]
        //
        [Parameter(
            ParameterSetName = "Downloadvirtualmachinesnapshotfile",
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
        public SwitchParameter Downloadvirtualmachinesnapshotfile { get; set; }

        
        // -------------------------------------------------------------------
        // Instantrecovervirtualmachinesnapshot parameter set
        //
        // [GraphQL: instantRecoverHypervVirtualMachineSnapshot]
        //
        [Parameter(
            ParameterSetName = "Instantrecovervirtualmachinesnapshot",
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
        public SwitchParameter Instantrecovervirtualmachinesnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // Restorevirtualmachinesnapshotfile parameter set
        //
        // [GraphQL: restoreHypervVirtualMachineSnapshotFiles]
        //
        [Parameter(
            ParameterSetName = "Restorevirtualmachinesnapshotfile",
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
        public SwitchParameter Restorevirtualmachinesnapshotfile { get; set; }

        
        // -------------------------------------------------------------------
        // Registeragentvirtualmachine parameter set
        //
        // [GraphQL: registerAgentHypervVirtualMachine]
        //
        [Parameter(
            ParameterSetName = "Registeragentvirtualmachine",
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
        public SwitchParameter Registeragentvirtualmachine { get; set; }

        
        // -------------------------------------------------------------------
        // Deletevirtualmachinesnapshot parameter set
        //
        // [GraphQL: deleteHypervVirtualMachineSnapshot]
        //
        [Parameter(
            ParameterSetName = "Deletevirtualmachinesnapshot",
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
        public SwitchParameter Deletevirtualmachinesnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // Downloadvirtualmachinesnapshot parameter set
        //
        // [GraphQL: downloadHypervVirtualMachineSnapshot]
        //
        [Parameter(
            ParameterSetName = "Downloadvirtualmachinesnapshot",
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
        public SwitchParameter Downloadvirtualmachinesnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // Createvirtualmachinesnapshotmount parameter set
        //
        // [GraphQL: createHypervVirtualMachineSnapshotMount]
        //
        [Parameter(
            ParameterSetName = "Createvirtualmachinesnapshotmount",
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
        public SwitchParameter Createvirtualmachinesnapshotmount { get; set; }

        
        // -------------------------------------------------------------------
        // Updatevirtualmachinesnapshotmount parameter set
        //
        // [GraphQL: updateHypervVirtualMachineSnapshotMount]
        //
        [Parameter(
            ParameterSetName = "Updatevirtualmachinesnapshotmount",
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
        public SwitchParameter Updatevirtualmachinesnapshotmount { get; set; }

        
        // -------------------------------------------------------------------
        // Deletevirtualmachinesnapshotmount parameter set
        //
        // [GraphQL: deleteHypervVirtualMachineSnapshotMount]
        //
        [Parameter(
            ParameterSetName = "Deletevirtualmachinesnapshotmount",
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
        public SwitchParameter Deletevirtualmachinesnapshotmount { get; set; }

        
        // -------------------------------------------------------------------
        // Refreshserver parameter set
        //
        // [GraphQL: refreshHypervServer]
        //
        [Parameter(
            ParameterSetName = "Refreshserver",
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
        public SwitchParameter Refreshserver { get; set; }

        
        // -------------------------------------------------------------------
        // Batchondemandbackupvm parameter set
        //
        // [GraphQL: batchOnDemandBackupHypervVm]
        //
        [Parameter(
            ParameterSetName = "Batchondemandbackupvm",
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
        public SwitchParameter Batchondemandbackupvm { get; set; }

        
        // -------------------------------------------------------------------
        // Batchexportvm parameter set
        //
        // [GraphQL: batchExportHypervVm]
        //
        [Parameter(
            ParameterSetName = "Batchexportvm",
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
        public SwitchParameter Batchexportvm { get; set; }

        
        // -------------------------------------------------------------------
        // Batchmountvm parameter set
        //
        // [GraphQL: batchMountHypervVm]
        //
        [Parameter(
            ParameterSetName = "Batchmountvm",
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
        public SwitchParameter Batchmountvm { get; set; }

        
        // -------------------------------------------------------------------
        // Batchinstantrecovervm parameter set
        //
        // [GraphQL: batchInstantRecoverHypervVm]
        //
        [Parameter(
            ParameterSetName = "Batchinstantrecovervm",
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
        public SwitchParameter Batchinstantrecovervm { get; set; }

        
        // -------------------------------------------------------------------
        // Updatevirtualmachine parameter set
        //
        // [GraphQL: updateHypervVirtualMachine]
        //
        [Parameter(
            ParameterSetName = "Updatevirtualmachine",
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
        public SwitchParameter Updatevirtualmachine { get; set; }

        
        // -------------------------------------------------------------------
        // Downloadsnapshotfromlocation parameter set
        //
        // [GraphQL: downloadHypervSnapshotFromLocation]
        //
        [Parameter(
            ParameterSetName = "Downloadsnapshotfromlocation",
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
        public SwitchParameter Downloadsnapshotfromlocation { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "Registerscvmm":
                        this.ProcessRecord_Registerscvmm();
                        break;
                    case "Scvmmupdate":
                        this.ProcessRecord_Scvmmupdate();
                        break;
                    case "Scvmmdelete":
                        this.ProcessRecord_Scvmmdelete();
                        break;
                    case "Refreshscvmm":
                        this.ProcessRecord_Refreshscvmm();
                        break;
                    case "Ondemandsnapshot":
                        this.ProcessRecord_Ondemandsnapshot();
                        break;
                    case "Deleteallsnapshot":
                        this.ProcessRecord_Deleteallsnapshot();
                        break;
                    case "Exportvirtualmachine":
                        this.ProcessRecord_Exportvirtualmachine();
                        break;
                    case "Downloadvirtualmachinesnapshotfile":
                        this.ProcessRecord_Downloadvirtualmachinesnapshotfile();
                        break;
                    case "Instantrecovervirtualmachinesnapshot":
                        this.ProcessRecord_Instantrecovervirtualmachinesnapshot();
                        break;
                    case "Restorevirtualmachinesnapshotfile":
                        this.ProcessRecord_Restorevirtualmachinesnapshotfile();
                        break;
                    case "Registeragentvirtualmachine":
                        this.ProcessRecord_Registeragentvirtualmachine();
                        break;
                    case "Deletevirtualmachinesnapshot":
                        this.ProcessRecord_Deletevirtualmachinesnapshot();
                        break;
                    case "Downloadvirtualmachinesnapshot":
                        this.ProcessRecord_Downloadvirtualmachinesnapshot();
                        break;
                    case "Createvirtualmachinesnapshotmount":
                        this.ProcessRecord_Createvirtualmachinesnapshotmount();
                        break;
                    case "Updatevirtualmachinesnapshotmount":
                        this.ProcessRecord_Updatevirtualmachinesnapshotmount();
                        break;
                    case "Deletevirtualmachinesnapshotmount":
                        this.ProcessRecord_Deletevirtualmachinesnapshotmount();
                        break;
                    case "Refreshserver":
                        this.ProcessRecord_Refreshserver();
                        break;
                    case "Batchondemandbackupvm":
                        this.ProcessRecord_Batchondemandbackupvm();
                        break;
                    case "Batchexportvm":
                        this.ProcessRecord_Batchexportvm();
                        break;
                    case "Batchmountvm":
                        this.ProcessRecord_Batchmountvm();
                        break;
                    case "Batchinstantrecovervm":
                        this.ProcessRecord_Batchinstantrecovervm();
                        break;
                    case "Updatevirtualmachine":
                        this.ProcessRecord_Updatevirtualmachine();
                        break;
                    case "Downloadsnapshotfromlocation":
                        this.ProcessRecord_Downloadsnapshotfromlocation();
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
        protected void ProcessRecord_Registerscvmm()
        {
            this._logger.name += " -Registerscvmm";
            // Invoke graphql operation registerHypervScvmm
            InvokeMutationRegisterHypervScvmm();
        }

        // This parameter set invokes a single graphql operation:
        // hypervScvmmUpdate.
        protected void ProcessRecord_Scvmmupdate()
        {
            this._logger.name += " -Scvmmupdate";
            // Invoke graphql operation hypervScvmmUpdate
            InvokeMutationHypervScvmmUpdate();
        }

        // This parameter set invokes a single graphql operation:
        // hypervScvmmDelete.
        protected void ProcessRecord_Scvmmdelete()
        {
            this._logger.name += " -Scvmmdelete";
            // Invoke graphql operation hypervScvmmDelete
            InvokeMutationHypervScvmmDelete();
        }

        // This parameter set invokes a single graphql operation:
        // refreshHypervScvmm.
        protected void ProcessRecord_Refreshscvmm()
        {
            this._logger.name += " -Refreshscvmm";
            // Invoke graphql operation refreshHypervScvmm
            InvokeMutationRefreshHypervScvmm();
        }

        // This parameter set invokes a single graphql operation:
        // hypervOnDemandSnapshot.
        protected void ProcessRecord_Ondemandsnapshot()
        {
            this._logger.name += " -Ondemandsnapshot";
            // Invoke graphql operation hypervOnDemandSnapshot
            InvokeMutationHypervOnDemandSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // hypervDeleteAllSnapshots.
        protected void ProcessRecord_Deleteallsnapshot()
        {
            this._logger.name += " -Deleteallsnapshot";
            // Invoke graphql operation hypervDeleteAllSnapshots
            InvokeMutationHypervDeleteAllSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // exportHypervVirtualMachine.
        protected void ProcessRecord_Exportvirtualmachine()
        {
            this._logger.name += " -Exportvirtualmachine";
            // Invoke graphql operation exportHypervVirtualMachine
            InvokeMutationExportHypervVirtualMachine();
        }

        // This parameter set invokes a single graphql operation:
        // downloadHypervVirtualMachineSnapshotFiles.
        protected void ProcessRecord_Downloadvirtualmachinesnapshotfile()
        {
            this._logger.name += " -Downloadvirtualmachinesnapshotfile";
            // Invoke graphql operation downloadHypervVirtualMachineSnapshotFiles
            InvokeMutationDownloadHypervVirtualMachineSnapshotFiles();
        }

        // This parameter set invokes a single graphql operation:
        // instantRecoverHypervVirtualMachineSnapshot.
        protected void ProcessRecord_Instantrecovervirtualmachinesnapshot()
        {
            this._logger.name += " -Instantrecovervirtualmachinesnapshot";
            // Invoke graphql operation instantRecoverHypervVirtualMachineSnapshot
            InvokeMutationInstantRecoverHypervVirtualMachineSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // restoreHypervVirtualMachineSnapshotFiles.
        protected void ProcessRecord_Restorevirtualmachinesnapshotfile()
        {
            this._logger.name += " -Restorevirtualmachinesnapshotfile";
            // Invoke graphql operation restoreHypervVirtualMachineSnapshotFiles
            InvokeMutationRestoreHypervVirtualMachineSnapshotFiles();
        }

        // This parameter set invokes a single graphql operation:
        // registerAgentHypervVirtualMachine.
        protected void ProcessRecord_Registeragentvirtualmachine()
        {
            this._logger.name += " -Registeragentvirtualmachine";
            // Invoke graphql operation registerAgentHypervVirtualMachine
            InvokeMutationRegisterAgentHypervVirtualMachine();
        }

        // This parameter set invokes a single graphql operation:
        // deleteHypervVirtualMachineSnapshot.
        protected void ProcessRecord_Deletevirtualmachinesnapshot()
        {
            this._logger.name += " -Deletevirtualmachinesnapshot";
            // Invoke graphql operation deleteHypervVirtualMachineSnapshot
            InvokeMutationDeleteHypervVirtualMachineSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // downloadHypervVirtualMachineSnapshot.
        protected void ProcessRecord_Downloadvirtualmachinesnapshot()
        {
            this._logger.name += " -Downloadvirtualmachinesnapshot";
            // Invoke graphql operation downloadHypervVirtualMachineSnapshot
            InvokeMutationDownloadHypervVirtualMachineSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // createHypervVirtualMachineSnapshotMount.
        protected void ProcessRecord_Createvirtualmachinesnapshotmount()
        {
            this._logger.name += " -Createvirtualmachinesnapshotmount";
            // Invoke graphql operation createHypervVirtualMachineSnapshotMount
            InvokeMutationCreateHypervVirtualMachineSnapshotMount();
        }

        // This parameter set invokes a single graphql operation:
        // updateHypervVirtualMachineSnapshotMount.
        protected void ProcessRecord_Updatevirtualmachinesnapshotmount()
        {
            this._logger.name += " -Updatevirtualmachinesnapshotmount";
            // Invoke graphql operation updateHypervVirtualMachineSnapshotMount
            InvokeMutationUpdateHypervVirtualMachineSnapshotMount();
        }

        // This parameter set invokes a single graphql operation:
        // deleteHypervVirtualMachineSnapshotMount.
        protected void ProcessRecord_Deletevirtualmachinesnapshotmount()
        {
            this._logger.name += " -Deletevirtualmachinesnapshotmount";
            // Invoke graphql operation deleteHypervVirtualMachineSnapshotMount
            InvokeMutationDeleteHypervVirtualMachineSnapshotMount();
        }

        // This parameter set invokes a single graphql operation:
        // refreshHypervServer.
        protected void ProcessRecord_Refreshserver()
        {
            this._logger.name += " -Refreshserver";
            // Invoke graphql operation refreshHypervServer
            InvokeMutationRefreshHypervServer();
        }

        // This parameter set invokes a single graphql operation:
        // batchOnDemandBackupHypervVm.
        protected void ProcessRecord_Batchondemandbackupvm()
        {
            this._logger.name += " -Batchondemandbackupvm";
            // Invoke graphql operation batchOnDemandBackupHypervVm
            InvokeMutationBatchOnDemandBackupHypervVm();
        }

        // This parameter set invokes a single graphql operation:
        // batchExportHypervVm.
        protected void ProcessRecord_Batchexportvm()
        {
            this._logger.name += " -Batchexportvm";
            // Invoke graphql operation batchExportHypervVm
            InvokeMutationBatchExportHypervVm();
        }

        // This parameter set invokes a single graphql operation:
        // batchMountHypervVm.
        protected void ProcessRecord_Batchmountvm()
        {
            this._logger.name += " -Batchmountvm";
            // Invoke graphql operation batchMountHypervVm
            InvokeMutationBatchMountHypervVm();
        }

        // This parameter set invokes a single graphql operation:
        // batchInstantRecoverHypervVm.
        protected void ProcessRecord_Batchinstantrecovervm()
        {
            this._logger.name += " -Batchinstantrecovervm";
            // Invoke graphql operation batchInstantRecoverHypervVm
            InvokeMutationBatchInstantRecoverHypervVm();
        }

        // This parameter set invokes a single graphql operation:
        // updateHypervVirtualMachine.
        protected void ProcessRecord_Updatevirtualmachine()
        {
            this._logger.name += " -Updatevirtualmachine";
            // Invoke graphql operation updateHypervVirtualMachine
            InvokeMutationUpdateHypervVirtualMachine();
        }

        // This parameter set invokes a single graphql operation:
        // downloadHypervSnapshotFromLocation.
        protected void ProcessRecord_Downloadsnapshotfromlocation()
        {
            this._logger.name += " -Downloadsnapshotfromlocation";
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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


    } // class Invoke_RscMutateHyperv
}