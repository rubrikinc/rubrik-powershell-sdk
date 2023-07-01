// Invoke-RscMutateNutanix.cs
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
        "RscMutateNutanix",
        DefaultParameterSetName = "UpdateVm")
    ]
    public class Invoke_RscMutateNutanix : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // CreateCluster parameter set
        //
        // [GraphQL: createNutanixCluster]
        //
        [Parameter(
            ParameterSetName = "CreateCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Add Nutanix cluster

Supported in v5.0+
Create a Nutanix cluster object by providing an address and account credentials for Prism. Initiates an asynchronous job to establish a connection with the cluster and retrieve all metadata. Use GET /nutanix_cluster/{id}/status to check status.
[GraphQL: createNutanixCluster]",
            Position = 0
        )]
        public SwitchParameter CreateCluster { get; set; }

        
        // -------------------------------------------------------------------
        // RefreshCluster parameter set
        //
        // [GraphQL: refreshNutanixCluster]
        //
        [Parameter(
            ParameterSetName = "RefreshCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refresh Nutanix cluster metadata

Supported in v5.0+
Create a job to refresh the metadata for the specified Nutanix cluster.
[GraphQL: refreshNutanixCluster]",
            Position = 0
        )]
        public SwitchParameter RefreshCluster { get; set; }

        
        // -------------------------------------------------------------------
        // UpdateCluster parameter set
        //
        // [GraphQL: updateNutanixCluster]
        //
        [Parameter(
            ParameterSetName = "UpdateCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Patch Nutanix cluster

Supported in v5.0+
Patch the host, credentials, and/or CA certs of the specified Nutanix cluster object.
[GraphQL: updateNutanixCluster]",
            Position = 0
        )]
        public SwitchParameter UpdateCluster { get; set; }

        
        // -------------------------------------------------------------------
        // DeleteCluster parameter set
        //
        // [GraphQL: deleteNutanixCluster]
        //
        [Parameter(
            ParameterSetName = "DeleteCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Remove Nutanix cluster

Supported in v5.0+
Initiates an asynchronous job to remove a Nutanix cluster object. The Nutanix cluster cannot have VMs mounted through the Rubrik cluster.
[GraphQL: deleteNutanixCluster]",
            Position = 0
        )]
        public SwitchParameter DeleteCluster { get; set; }

        
        // -------------------------------------------------------------------
        // RegisterAgentVm parameter set
        //
        // [GraphQL: registerAgentNutanixVm]
        //
        [Parameter(
            ParameterSetName = "RegisterAgentVm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"v5.0-v8.0: Register the agent installed on the Nutanix VM
v8.1+: Register the agent installed on the Nutanix virtual machine

Supported in v5.0+
v5.0-v5.3: Register the agent installed on the Nutanix VM
v6.0-v8.0: Register the agent installed on the Nutanix VM.
v8.1+: Register the agent installed on the Nutanix virtual machine.
[GraphQL: registerAgentNutanixVm]",
            Position = 0
        )]
        public SwitchParameter RegisterAgentVm { get; set; }

        
        // -------------------------------------------------------------------
        // UpdateVm parameter set
        //
        // [GraphQL: updateNutanixVm]
        //
        [Parameter(
            ParameterSetName = "UpdateVm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"v5.0-v8.0: Patch VM
v8.1+: Patch virtual machine

Supported in v5.0+
v5.0-v5.3: Patch VM with specified properties
v6.0-v8.0: Patch VM with specified properties.
v8.1+: Patch virtual machine with specified properties.
[GraphQL: updateNutanixVm]",
            Position = 0
        )]
        public SwitchParameter UpdateVm { get; set; }

        
        // -------------------------------------------------------------------
        // CreateOnDemandBackup parameter set
        //
        // [GraphQL: createOnDemandNutanixBackup]
        //
        [Parameter(
            ParameterSetName = "CreateOnDemandBackup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"v5.0-v8.0: Create on-demand VM snapshot
v8.1+: Create on-demand virtual machine snapshot

Supported in v5.0+
v5.0-v5.3: Create an on-demand snapshot for the given VM ID
v6.0-v8.0: Create an on-demand snapshot for the given VM ID.
v8.1+: Create an on-demand snapshot for the given virtual machine ID.
[GraphQL: createOnDemandNutanixBackup]",
            Position = 0
        )]
        public SwitchParameter CreateOnDemandBackup { get; set; }

        
        // -------------------------------------------------------------------
        // DeleteSnapshot parameter set
        //
        // [GraphQL: deleteNutanixSnapshots]
        //
        [Parameter(
            ParameterSetName = "DeleteSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"v5.0-v8.0: Delete all snapshots of VM
v8.1+: Delete all snapshots of virtual machine

Supported in v5.0+
Delete all snapshots of a virtual machine.
[GraphQL: deleteNutanixSnapshots]",
            Position = 0
        )]
        public SwitchParameter DeleteSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // MountSnapshotV1 parameter set
        //
        // [GraphQL: mountNutanixSnapshotV1]
        //
        [Parameter(
            ParameterSetName = "MountSnapshotV1",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Initiate a Live Mount of a Nutanix virtual machine snapshot

Supported in v6.0+
Initiates a request to perform a Live Mount of a Nutanix virtual machine snapshot identified by the snapshot ID.
[GraphQL: mountNutanixSnapshotV1]",
            Position = 0
        )]
        public SwitchParameter MountSnapshotV1 { get; set; }

        
        // -------------------------------------------------------------------
        // PatchMountV1 parameter set
        //
        // [GraphQL: patchNutanixMountV1]
        //
        [Parameter(
            ParameterSetName = "PatchMountV1",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Change Nutanix Live Mount power status

Supported in v6.0+
Changes the power status of a mounted Nutanix virtual machine.
[GraphQL: patchNutanixMountV1]",
            Position = 0
        )]
        public SwitchParameter PatchMountV1 { get; set; }

        
        // -------------------------------------------------------------------
        // DeleteMountV1 parameter set
        //
        // [GraphQL: deleteNutanixMountV1]
        //
        [Parameter(
            ParameterSetName = "DeleteMountV1",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Remove a Live Mount of a Nutanix virtual machine snapshot

Supported in v6.0+
Initiates a request to remove a Live Mount of a Nutanix virtual machine snapshot identified by the ID of the Live Mount.
[GraphQL: deleteNutanixMountV1]",
            Position = 0
        )]
        public SwitchParameter DeleteMountV1 { get; set; }

        
        // -------------------------------------------------------------------
        // MigrateMountV1 parameter set
        //
        // [GraphQL: migrateNutanixMountV1]
        //
        [Parameter(
            ParameterSetName = "MigrateMountV1",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Relocate a Nutanix virtual machine to another storage container

Supported in v6.0+
Initiate a request to migrate the virtual disks of a specified Nutanix Live Mount to another storage container. The destination storage container has been specified when the Live Mount was created. The Live Mount will be deleted when the relocation succeeds.
[GraphQL: migrateNutanixMountV1]",
            Position = 0
        )]
        public SwitchParameter MigrateMountV1 { get; set; }

        
        // -------------------------------------------------------------------
        // RestoreFilesSnapshot parameter set
        //
        // [GraphQL: restoreFilesNutanixSnapshot]
        //
        [Parameter(
            ParameterSetName = "RestoreFilesSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Restore files

Supported in v5.0+
Restore files from a snapshot to the source Nutanix virtual machine.
[GraphQL: restoreFilesNutanixSnapshot]",
            Position = 0
        )]
        public SwitchParameter RestoreFilesSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // DownloadFilesSnapshot parameter set
        //
        // [GraphQL: downloadFilesNutanixSnapshot]
        //
        [Parameter(
            ParameterSetName = "DownloadFilesSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"v5.0-v8.0: Download files from a Nutanix VM backup
v8.1+: Download files from a Nutanix virtual machine backup

Supported in v5.0+
v5.0-v8.0: Start an asynchronous job to download multiple files and folders from a specified Nutanix VM backup. The response returns an asynchronous request ID. Get the URL for downloading the zip file including the specific files/folders by sending a GET request to 'nutanix/vm/request/{id}'.
v8.1+: Start an asynchronous job to download multiple files and folders from a specified Nutanix virtual machine backup. The response returns an asynchronous request ID. Get the URL for downloading the zip file including the specific files/folders by sending a GET request to 'nutanix/vm/request/{id}'.
[GraphQL: downloadFilesNutanixSnapshot]",
            Position = 0
        )]
        public SwitchParameter DownloadFilesSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // ExportSnapshot parameter set
        //
        // [GraphQL: exportNutanixSnapshot]
        //
        [Parameter(
            ParameterSetName = "ExportSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"v5.0-v8.0: Export VM snapshot
v8.1+: Export virtual machine snapshot

Supported in v5.0+
v5.0-v8.0: Export snapshot of a vm.
v8.1+: Export snapshot of a virtual machine.
[GraphQL: exportNutanixSnapshot]",
            Position = 0
        )]
        public SwitchParameter ExportSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // DownloadSnapshot parameter set
        //
        // [GraphQL: downloadNutanixSnapshot]
        //
        [Parameter(
            ParameterSetName = "DownloadSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Creates a download from archival request

Supported in v5.0+
Download a snapshot from archival.
[GraphQL: downloadNutanixSnapshot]",
            Position = 0
        )]
        public SwitchParameter DownloadSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // BatchExportVm parameter set
        //
        // [GraphQL: batchExportNutanixVm]
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
[GraphQL: batchExportNutanixVm]",
            Position = 0
        )]
        public SwitchParameter BatchExportVm { get; set; }

        
        // -------------------------------------------------------------------
        // BatchMountVm parameter set
        //
        // [GraphQL: batchMountNutanixVm]
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
[GraphQL: batchMountNutanixVm]",
            Position = 0
        )]
        public SwitchParameter BatchMountVm { get; set; }

        
        // -------------------------------------------------------------------
        // DownloadVmFromLocation parameter set
        //
        // [GraphQL: downloadNutanixVmFromLocation]
        //
        [Parameter(
            ParameterSetName = "DownloadVmFromLocation",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Download a snapshot from a replication target

Supported in v7.0+
Initiates a job to download a snapshot from the specified location when the snapshot does not exist locally. The specified location has to be a replication target connected to this Rubrik cluster. If an SLA Domain is not provided, the snapshot will be retained forever.
[GraphQL: downloadNutanixVmFromLocation]",
            Position = 0
        )]
        public SwitchParameter DownloadVmFromLocation { get; set; }

        
        // -------------------------------------------------------------------
        // CreatePrismCentral parameter set
        //
        // [GraphQL: createNutanixPrismCentral]
        //
        [Parameter(
            ParameterSetName = "CreatePrismCentral",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Add Nutanix Prism Central and it's corresponding Prism Elements

Supported in v9.0
Create a Nutanix Prism Central object and refresh the Prism Elements present in it.
[GraphQL: createNutanixPrismCentral]",
            Position = 0
        )]
        public SwitchParameter CreatePrismCentral { get; set; }

        
        // -------------------------------------------------------------------
        // UpdatePrismCentral parameter set
        //
        // [GraphQL: updateNutanixPrismCentral]
        //
        [Parameter(
            ParameterSetName = "UpdatePrismCentral",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Patch Nutanix Prism Central

Supported in v9.0
Patch the host and credentials of Nutanix Prism Central.
[GraphQL: updateNutanixPrismCentral]",
            Position = 0
        )]
        public SwitchParameter UpdatePrismCentral { get; set; }

        
        // -------------------------------------------------------------------
        // DeletePrismCentral parameter set
        //
        // [GraphQL: deleteNutanixPrismCentral]
        //
        [Parameter(
            ParameterSetName = "DeletePrismCentral",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Remove Nutanix Prism Central

Supported in v9.0
Initiates an asynchronous job to remove a Nutanix Prism Central object. The Nutanix Clusters attached to the Prism Central cannot have Virtual Machines mounted through the Rubrik cluster.
[GraphQL: deleteNutanixPrismCentral]",
            Position = 0
        )]
        public SwitchParameter DeletePrismCentral { get; set; }

        
        // -------------------------------------------------------------------
        // RefreshPrismCentral parameter set
        //
        // [GraphQL: refreshNutanixPrismCentral]
        //
        [Parameter(
            ParameterSetName = "RefreshPrismCentral",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refresh Nutanix Prism Central metadata

Supported in v9.0
Initiates a job to refresh the metadata for the specified Nutanix Prism Central and all its associated clusters.
[GraphQL: refreshNutanixPrismCentral]",
            Position = 0
        )]
        public SwitchParameter RefreshPrismCentral { get; set; }

        
        // -------------------------------------------------------------------
        // BulkOnDemandSnapshotVm parameter set
        //
        // [GraphQL: bulkOnDemandSnapshotNutanixVm]
        //
        [Parameter(
            ParameterSetName = "BulkOnDemandSnapshotVm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Take an on-demand snapshot for selected Nutanix virtual machines

Supported in v9.0
Take bulk backups for multiple Nutanix virtual machines.
[GraphQL: bulkOnDemandSnapshotNutanixVm]",
            Position = 0
        )]
        public SwitchParameter BulkOnDemandSnapshotVm { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "CreateCluster":
                        this.ProcessRecord_CreateCluster();
                        break;
                    case "RefreshCluster":
                        this.ProcessRecord_RefreshCluster();
                        break;
                    case "UpdateCluster":
                        this.ProcessRecord_UpdateCluster();
                        break;
                    case "DeleteCluster":
                        this.ProcessRecord_DeleteCluster();
                        break;
                    case "RegisterAgentVm":
                        this.ProcessRecord_RegisterAgentVm();
                        break;
                    case "UpdateVm":
                        this.ProcessRecord_UpdateVm();
                        break;
                    case "CreateOnDemandBackup":
                        this.ProcessRecord_CreateOnDemandBackup();
                        break;
                    case "DeleteSnapshot":
                        this.ProcessRecord_DeleteSnapshot();
                        break;
                    case "MountSnapshotV1":
                        this.ProcessRecord_MountSnapshotV1();
                        break;
                    case "PatchMountV1":
                        this.ProcessRecord_PatchMountV1();
                        break;
                    case "DeleteMountV1":
                        this.ProcessRecord_DeleteMountV1();
                        break;
                    case "MigrateMountV1":
                        this.ProcessRecord_MigrateMountV1();
                        break;
                    case "RestoreFilesSnapshot":
                        this.ProcessRecord_RestoreFilesSnapshot();
                        break;
                    case "DownloadFilesSnapshot":
                        this.ProcessRecord_DownloadFilesSnapshot();
                        break;
                    case "ExportSnapshot":
                        this.ProcessRecord_ExportSnapshot();
                        break;
                    case "DownloadSnapshot":
                        this.ProcessRecord_DownloadSnapshot();
                        break;
                    case "BatchExportVm":
                        this.ProcessRecord_BatchExportVm();
                        break;
                    case "BatchMountVm":
                        this.ProcessRecord_BatchMountVm();
                        break;
                    case "DownloadVmFromLocation":
                        this.ProcessRecord_DownloadVmFromLocation();
                        break;
                    case "CreatePrismCentral":
                        this.ProcessRecord_CreatePrismCentral();
                        break;
                    case "UpdatePrismCentral":
                        this.ProcessRecord_UpdatePrismCentral();
                        break;
                    case "DeletePrismCentral":
                        this.ProcessRecord_DeletePrismCentral();
                        break;
                    case "RefreshPrismCentral":
                        this.ProcessRecord_RefreshPrismCentral();
                        break;
                    case "BulkOnDemandSnapshotVm":
                        this.ProcessRecord_BulkOnDemandSnapshotVm();
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
        // createNutanixCluster.
        protected void ProcessRecord_CreateCluster()
        {
            this._logger.name += " -CreateCluster";
            // Invoke graphql operation createNutanixCluster
            InvokeMutationCreateNutanixCluster();
        }

        // This parameter set invokes a single graphql operation:
        // refreshNutanixCluster.
        protected void ProcessRecord_RefreshCluster()
        {
            this._logger.name += " -RefreshCluster";
            // Invoke graphql operation refreshNutanixCluster
            InvokeMutationRefreshNutanixCluster();
        }

        // This parameter set invokes a single graphql operation:
        // updateNutanixCluster.
        protected void ProcessRecord_UpdateCluster()
        {
            this._logger.name += " -UpdateCluster";
            // Invoke graphql operation updateNutanixCluster
            InvokeMutationUpdateNutanixCluster();
        }

        // This parameter set invokes a single graphql operation:
        // deleteNutanixCluster.
        protected void ProcessRecord_DeleteCluster()
        {
            this._logger.name += " -DeleteCluster";
            // Invoke graphql operation deleteNutanixCluster
            InvokeMutationDeleteNutanixCluster();
        }

        // This parameter set invokes a single graphql operation:
        // registerAgentNutanixVm.
        protected void ProcessRecord_RegisterAgentVm()
        {
            this._logger.name += " -RegisterAgentVm";
            // Invoke graphql operation registerAgentNutanixVm
            InvokeMutationRegisterAgentNutanixVm();
        }

        // This parameter set invokes a single graphql operation:
        // updateNutanixVm.
        protected void ProcessRecord_UpdateVm()
        {
            this._logger.name += " -UpdateVm";
            // Invoke graphql operation updateNutanixVm
            InvokeMutationUpdateNutanixVm();
        }

        // This parameter set invokes a single graphql operation:
        // createOnDemandNutanixBackup.
        protected void ProcessRecord_CreateOnDemandBackup()
        {
            this._logger.name += " -CreateOnDemandBackup";
            // Invoke graphql operation createOnDemandNutanixBackup
            InvokeMutationCreateOnDemandNutanixBackup();
        }

        // This parameter set invokes a single graphql operation:
        // deleteNutanixSnapshots.
        protected void ProcessRecord_DeleteSnapshot()
        {
            this._logger.name += " -DeleteSnapshot";
            // Invoke graphql operation deleteNutanixSnapshots
            InvokeMutationDeleteNutanixSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // mountNutanixSnapshotV1.
        protected void ProcessRecord_MountSnapshotV1()
        {
            this._logger.name += " -MountSnapshotV1";
            // Invoke graphql operation mountNutanixSnapshotV1
            InvokeMutationMountNutanixSnapshotV1();
        }

        // This parameter set invokes a single graphql operation:
        // patchNutanixMountV1.
        protected void ProcessRecord_PatchMountV1()
        {
            this._logger.name += " -PatchMountV1";
            // Invoke graphql operation patchNutanixMountV1
            InvokeMutationPatchNutanixMountV1();
        }

        // This parameter set invokes a single graphql operation:
        // deleteNutanixMountV1.
        protected void ProcessRecord_DeleteMountV1()
        {
            this._logger.name += " -DeleteMountV1";
            // Invoke graphql operation deleteNutanixMountV1
            InvokeMutationDeleteNutanixMountV1();
        }

        // This parameter set invokes a single graphql operation:
        // migrateNutanixMountV1.
        protected void ProcessRecord_MigrateMountV1()
        {
            this._logger.name += " -MigrateMountV1";
            // Invoke graphql operation migrateNutanixMountV1
            InvokeMutationMigrateNutanixMountV1();
        }

        // This parameter set invokes a single graphql operation:
        // restoreFilesNutanixSnapshot.
        protected void ProcessRecord_RestoreFilesSnapshot()
        {
            this._logger.name += " -RestoreFilesSnapshot";
            // Invoke graphql operation restoreFilesNutanixSnapshot
            InvokeMutationRestoreFilesNutanixSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // downloadFilesNutanixSnapshot.
        protected void ProcessRecord_DownloadFilesSnapshot()
        {
            this._logger.name += " -DownloadFilesSnapshot";
            // Invoke graphql operation downloadFilesNutanixSnapshot
            InvokeMutationDownloadFilesNutanixSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // exportNutanixSnapshot.
        protected void ProcessRecord_ExportSnapshot()
        {
            this._logger.name += " -ExportSnapshot";
            // Invoke graphql operation exportNutanixSnapshot
            InvokeMutationExportNutanixSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // downloadNutanixSnapshot.
        protected void ProcessRecord_DownloadSnapshot()
        {
            this._logger.name += " -DownloadSnapshot";
            // Invoke graphql operation downloadNutanixSnapshot
            InvokeMutationDownloadNutanixSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // batchExportNutanixVm.
        protected void ProcessRecord_BatchExportVm()
        {
            this._logger.name += " -BatchExportVm";
            // Invoke graphql operation batchExportNutanixVm
            InvokeMutationBatchExportNutanixVm();
        }

        // This parameter set invokes a single graphql operation:
        // batchMountNutanixVm.
        protected void ProcessRecord_BatchMountVm()
        {
            this._logger.name += " -BatchMountVm";
            // Invoke graphql operation batchMountNutanixVm
            InvokeMutationBatchMountNutanixVm();
        }

        // This parameter set invokes a single graphql operation:
        // downloadNutanixVmFromLocation.
        protected void ProcessRecord_DownloadVmFromLocation()
        {
            this._logger.name += " -DownloadVmFromLocation";
            // Invoke graphql operation downloadNutanixVmFromLocation
            InvokeMutationDownloadNutanixVmFromLocation();
        }

        // This parameter set invokes a single graphql operation:
        // createNutanixPrismCentral.
        protected void ProcessRecord_CreatePrismCentral()
        {
            this._logger.name += " -CreatePrismCentral";
            // Invoke graphql operation createNutanixPrismCentral
            InvokeMutationCreateNutanixPrismCentral();
        }

        // This parameter set invokes a single graphql operation:
        // updateNutanixPrismCentral.
        protected void ProcessRecord_UpdatePrismCentral()
        {
            this._logger.name += " -UpdatePrismCentral";
            // Invoke graphql operation updateNutanixPrismCentral
            InvokeMutationUpdateNutanixPrismCentral();
        }

        // This parameter set invokes a single graphql operation:
        // deleteNutanixPrismCentral.
        protected void ProcessRecord_DeletePrismCentral()
        {
            this._logger.name += " -DeletePrismCentral";
            // Invoke graphql operation deleteNutanixPrismCentral
            InvokeMutationDeleteNutanixPrismCentral();
        }

        // This parameter set invokes a single graphql operation:
        // refreshNutanixPrismCentral.
        protected void ProcessRecord_RefreshPrismCentral()
        {
            this._logger.name += " -RefreshPrismCentral";
            // Invoke graphql operation refreshNutanixPrismCentral
            InvokeMutationRefreshNutanixPrismCentral();
        }

        // This parameter set invokes a single graphql operation:
        // bulkOnDemandSnapshotNutanixVm.
        protected void ProcessRecord_BulkOnDemandSnapshotVm()
        {
            this._logger.name += " -BulkOnDemandSnapshotVm";
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
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.CreateNutanixCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateNutanixCluster");
            var parameters = "($input: CreateNutanixClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateNutanixCluster" + parameters + "{" + document + "}",
                OperationName = "MutationCreateNutanixCluster",
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
        // refreshNutanixCluster(input: RefreshNutanixClusterInput!): AsyncRequestStatus!
        protected void InvokeMutationRefreshNutanixCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshNutanixClusterInput!"),
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
            string document = Mutation.RefreshNutanixCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RefreshNutanixCluster");
            var parameters = "($input: RefreshNutanixClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRefreshNutanixCluster" + parameters + "{" + document + "}",
                OperationName = "MutationRefreshNutanixCluster",
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
        // updateNutanixCluster(input: UpdateNutanixClusterInput!): UpdateNutanixClusterReply!
        protected void InvokeMutationUpdateNutanixCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateNutanixClusterInput!"),
            };
            UpdateNutanixClusterReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (UpdateNutanixClusterReply)psObject.BaseObject;
                } else {
                    fields = (UpdateNutanixClusterReply)this.Field;
                }
            }
            string document = Mutation.UpdateNutanixCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateNutanixCluster");
            var parameters = "($input: UpdateNutanixClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateNutanixCluster" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateNutanixCluster",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "UpdateNutanixClusterReply", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.DeleteNutanixCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteNutanixCluster");
            var parameters = "($input: DeleteNutanixClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteNutanixCluster" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteNutanixCluster",
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
        // registerAgentNutanixVm(input: RegisterAgentNutanixVmInput!): RequestSuccess!
        protected void InvokeMutationRegisterAgentNutanixVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RegisterAgentNutanixVmInput!"),
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
            string document = Mutation.RegisterAgentNutanixVm(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RegisterAgentNutanixVm");
            var parameters = "($input: RegisterAgentNutanixVmInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRegisterAgentNutanixVm" + parameters + "{" + document + "}",
                OperationName = "MutationRegisterAgentNutanixVm",
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
        // updateNutanixVm(input: UpdateNutanixVmInput!): Void
        protected void InvokeMutationUpdateNutanixVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateNutanixVmInput!"),
            };
            System.String? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (System.String)psObject.BaseObject;
                } else {
                    fields = (System.String)this.Field;
                }
            }
            string document = Mutation.UpdateNutanixVm(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateNutanixVm");
            var parameters = "($input: UpdateNutanixVmInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateNutanixVm" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateNutanixVm",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "System.String", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.CreateOnDemandNutanixBackup(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateOnDemandNutanixBackup");
            var parameters = "($input: CreateOnDemandNutanixBackupInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateOnDemandNutanixBackup" + parameters + "{" + document + "}",
                OperationName = "MutationCreateOnDemandNutanixBackup",
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
        // deleteNutanixSnapshots(input: DeleteNutanixSnapshotsInput!): RequestSuccess!
        protected void InvokeMutationDeleteNutanixSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteNutanixSnapshotsInput!"),
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
            string document = Mutation.DeleteNutanixSnapshots(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteNutanixSnapshots");
            var parameters = "($input: DeleteNutanixSnapshotsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteNutanixSnapshots" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteNutanixSnapshots",
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
        // mountNutanixSnapshotV1(input: MountNutanixSnapshotV1Input!): AsyncRequestStatus!
        protected void InvokeMutationMountNutanixSnapshotV1()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MountNutanixSnapshotV1Input!"),
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
            string document = Mutation.MountNutanixSnapshotV1(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.MountNutanixSnapshotV1");
            var parameters = "($input: MountNutanixSnapshotV1Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationMountNutanixSnapshotV1" + parameters + "{" + document + "}",
                OperationName = "MutationMountNutanixSnapshotV1",
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
        // patchNutanixMountV1(input: PatchNutanixMountV1Input!): PatchNutanixMountV1Reply!
        protected void InvokeMutationPatchNutanixMountV1()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PatchNutanixMountV1Input!"),
            };
            PatchNutanixMountV1Reply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (PatchNutanixMountV1Reply)psObject.BaseObject;
                } else {
                    fields = (PatchNutanixMountV1Reply)this.Field;
                }
            }
            string document = Mutation.PatchNutanixMountV1(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.PatchNutanixMountV1");
            var parameters = "($input: PatchNutanixMountV1Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationPatchNutanixMountV1" + parameters + "{" + document + "}",
                OperationName = "MutationPatchNutanixMountV1",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "PatchNutanixMountV1Reply", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.DeleteNutanixMountV1(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteNutanixMountV1");
            var parameters = "($input: DeleteNutanixMountV1Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteNutanixMountV1" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteNutanixMountV1",
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
        // migrateNutanixMountV1(input: MigrateNutanixMountV1Input!): AsyncRequestStatus!
        protected void InvokeMutationMigrateNutanixMountV1()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MigrateNutanixMountV1Input!"),
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
            string document = Mutation.MigrateNutanixMountV1(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.MigrateNutanixMountV1");
            var parameters = "($input: MigrateNutanixMountV1Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationMigrateNutanixMountV1" + parameters + "{" + document + "}",
                OperationName = "MutationMigrateNutanixMountV1",
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
        // restoreFilesNutanixSnapshot(input: RestoreFilesNutanixSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationRestoreFilesNutanixSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreFilesNutanixSnapshotInput!"),
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
            string document = Mutation.RestoreFilesNutanixSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RestoreFilesNutanixSnapshot");
            var parameters = "($input: RestoreFilesNutanixSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRestoreFilesNutanixSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationRestoreFilesNutanixSnapshot",
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
        // downloadFilesNutanixSnapshot(input: DownloadFilesNutanixSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationDownloadFilesNutanixSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadFilesNutanixSnapshotInput!"),
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
            string document = Mutation.DownloadFilesNutanixSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DownloadFilesNutanixSnapshot");
            var parameters = "($input: DownloadFilesNutanixSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDownloadFilesNutanixSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationDownloadFilesNutanixSnapshot",
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
        // exportNutanixSnapshot(input: ExportNutanixSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationExportNutanixSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportNutanixSnapshotInput!"),
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
            string document = Mutation.ExportNutanixSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.ExportNutanixSnapshot");
            var parameters = "($input: ExportNutanixSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationExportNutanixSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationExportNutanixSnapshot",
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
        // downloadNutanixSnapshot(input: DownloadNutanixSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationDownloadNutanixSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadNutanixSnapshotInput!"),
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
            string document = Mutation.DownloadNutanixSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DownloadNutanixSnapshot");
            var parameters = "($input: DownloadNutanixSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDownloadNutanixSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationDownloadNutanixSnapshot",
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
        // batchExportNutanixVm(input: BatchExportNutanixVmInput!): BatchExportNutanixVmReply!
        protected void InvokeMutationBatchExportNutanixVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BatchExportNutanixVmInput!"),
            };
            BatchExportNutanixVmReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (BatchExportNutanixVmReply)psObject.BaseObject;
                } else {
                    fields = (BatchExportNutanixVmReply)this.Field;
                }
            }
            string document = Mutation.BatchExportNutanixVm(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BatchExportNutanixVm");
            var parameters = "($input: BatchExportNutanixVmInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBatchExportNutanixVm" + parameters + "{" + document + "}",
                OperationName = "MutationBatchExportNutanixVm",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BatchExportNutanixVmReply", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (BatchMountNutanixVmReply)psObject.BaseObject;
                } else {
                    fields = (BatchMountNutanixVmReply)this.Field;
                }
            }
            string document = Mutation.BatchMountNutanixVm(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BatchMountNutanixVm");
            var parameters = "($input: BatchMountNutanixVmInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBatchMountNutanixVm" + parameters + "{" + document + "}",
                OperationName = "MutationBatchMountNutanixVm",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BatchMountNutanixVmReply", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.DownloadNutanixVmFromLocation(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DownloadNutanixVmFromLocation");
            var parameters = "($input: DownloadNutanixVmFromLocationInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDownloadNutanixVmFromLocation" + parameters + "{" + document + "}",
                OperationName = "MutationDownloadNutanixVmFromLocation",
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
        // createNutanixPrismCentral(input: CreateNutanixPrismCentralInput!): BatchAsyncRequestStatus!
        protected void InvokeMutationCreateNutanixPrismCentral()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateNutanixPrismCentralInput!"),
            };
            BatchAsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (BatchAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.CreateNutanixPrismCentral(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateNutanixPrismCentral");
            var parameters = "($input: CreateNutanixPrismCentralInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateNutanixPrismCentral" + parameters + "{" + document + "}",
                OperationName = "MutationCreateNutanixPrismCentral",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BatchAsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // updateNutanixPrismCentral(input: UpdateNutanixPrismCentralInput!): UpdateNutanixPrismCentralReply!
        protected void InvokeMutationUpdateNutanixPrismCentral()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateNutanixPrismCentralInput!"),
            };
            UpdateNutanixPrismCentralReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (UpdateNutanixPrismCentralReply)psObject.BaseObject;
                } else {
                    fields = (UpdateNutanixPrismCentralReply)this.Field;
                }
            }
            string document = Mutation.UpdateNutanixPrismCentral(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateNutanixPrismCentral");
            var parameters = "($input: UpdateNutanixPrismCentralInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateNutanixPrismCentral" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateNutanixPrismCentral",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "UpdateNutanixPrismCentralReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteNutanixPrismCentral(input: DeleteNutanixPrismCentralInput!): BatchAsyncRequestStatus!
        protected void InvokeMutationDeleteNutanixPrismCentral()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteNutanixPrismCentralInput!"),
            };
            BatchAsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (BatchAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.DeleteNutanixPrismCentral(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteNutanixPrismCentral");
            var parameters = "($input: DeleteNutanixPrismCentralInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteNutanixPrismCentral" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteNutanixPrismCentral",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BatchAsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // refreshNutanixPrismCentral(input: RefreshNutanixPrismCentralInput!): BatchAsyncRequestStatus!
        protected void InvokeMutationRefreshNutanixPrismCentral()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshNutanixPrismCentralInput!"),
            };
            BatchAsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (BatchAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.RefreshNutanixPrismCentral(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RefreshNutanixPrismCentral");
            var parameters = "($input: RefreshNutanixPrismCentralInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRefreshNutanixPrismCentral" + parameters + "{" + document + "}",
                OperationName = "MutationRefreshNutanixPrismCentral",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BatchAsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (BulkOnDemandSnapshotNutanixVmReply)psObject.BaseObject;
                } else {
                    fields = (BulkOnDemandSnapshotNutanixVmReply)this.Field;
                }
            }
            string document = Mutation.BulkOnDemandSnapshotNutanixVm(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BulkOnDemandSnapshotNutanixVm");
            var parameters = "($input: BulkOnDemandSnapshotNutanixVmInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBulkOnDemandSnapshotNutanixVm" + parameters + "{" + document + "}",
                OperationName = "MutationBulkOnDemandSnapshotNutanixVm",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BulkOnDemandSnapshotNutanixVmReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscMutateNutanix
}