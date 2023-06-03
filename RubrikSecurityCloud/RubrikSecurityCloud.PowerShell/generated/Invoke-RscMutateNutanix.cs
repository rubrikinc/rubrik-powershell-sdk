// Invoke-RscMutateNutanix.cs
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
        "RscMutateNutanix",
        DefaultParameterSetName = "updateVm")
    ]
    public class Invoke_RscMutateNutanix : RscPSCmdlet
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
            HelpMessage =
                @"
                Add Nutanix cluster

Supported in v5.0+
Create a Nutanix cluster object by providing an address and account credentials for Prism. Initiates an asynchronous job to establish a connection with the cluster and retrieve all metadata. Use GET /nutanix_cluster/{id}/status to check status.
                GraphQL operation: createNutanixCluster(input: CreateNutanixClusterInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter createCluster { get; set; }

        [Parameter(
            ParameterSetName = "createCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Input for InternalCreateNutanixCluster.
                GraphQL argument input: CreateNutanixClusterInput!
                "
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
            HelpMessage =
                @"
                Refresh Nutanix cluster metadata

Supported in v5.0+
Create a job to refresh the metadata for the specified Nutanix cluster.
                GraphQL operation: refreshNutanixCluster(input: RefreshNutanixClusterInput!):AsyncRequestStatus!
                ",
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
            HelpMessage =
                @"
                Patch Nutanix cluster

Supported in v5.0+
Patch the host, credentials, and/or CA certs of the specified Nutanix cluster object.
                GraphQL operation: updateNutanixCluster(input: UpdateNutanixClusterInput!):UpdateNutanixClusterReply!
                ",
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
            HelpMessage =
                @"
                Remove Nutanix cluster

Supported in v5.0+
Initiates an asynchronous job to remove a Nutanix cluster object. The Nutanix cluster cannot have VMs mounted through the Rubrik cluster.
                GraphQL operation: deleteNutanixCluster(input: DeleteNutanixClusterInput!):AsyncRequestStatus!
                ",
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
            HelpMessage =
                @"
                v5.0-v8.0: Register the agent installed on the Nutanix VM
v8.1+: Register the agent installed on the Nutanix virtual machine

Supported in v5.0+
v5.0-v5.3: Register the agent installed on the Nutanix VM
v6.0-v8.0: Register the agent installed on the Nutanix VM.
v8.1+: Register the agent installed on the Nutanix virtual machine.
                GraphQL operation: registerAgentNutanixVm(input: RegisterAgentNutanixVmInput!):RequestSuccess!
                ",
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
            HelpMessage =
                @"
                v5.0-v8.0: Patch VM
v8.1+: Patch virtual machine

Supported in v5.0+
v5.0-v5.3: Patch VM with specified properties
v6.0-v8.0: Patch VM with specified properties.
v8.1+: Patch virtual machine with specified properties.
                GraphQL operation: updateNutanixVm(input: UpdateNutanixVmInput!):Void
                ",
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
            HelpMessage =
                @"
                v5.0-v8.0: Create on-demand VM snapshot
v8.1+: Create on-demand virtual machine snapshot

Supported in v5.0+
v5.0-v5.3: Create an on-demand snapshot for the given VM ID
v6.0-v8.0: Create an on-demand snapshot for the given VM ID.
v8.1+: Create an on-demand snapshot for the given virtual machine ID.
                GraphQL operation: createOnDemandNutanixBackup(input: CreateOnDemandNutanixBackupInput!):AsyncRequestStatus!
                ",
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
            HelpMessage =
                @"
                v5.0-v8.0: Delete all snapshots of VM
v8.1+: Delete all snapshots of virtual machine

Supported in v5.0+
Delete all snapshots of a virtual machine.
                GraphQL operation: deleteNutanixSnapshots(input: DeleteNutanixSnapshotsInput!):RequestSuccess!
                ",
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
            HelpMessage =
                @"
                Initiate a Live Mount of a Nutanix virtual machine snapshot

Supported in v6.0+
Initiates a request to perform a Live Mount of a Nutanix virtual machine snapshot identified by the snapshot ID.
                GraphQL operation: mountNutanixSnapshotV1(input: MountNutanixSnapshotV1Input!):AsyncRequestStatus!
                ",
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
            HelpMessage =
                @"
                Change Nutanix Live Mount power status

Supported in v6.0+
Changes the power status of a mounted Nutanix virtual machine.
                GraphQL operation: patchNutanixMountV1(input: PatchNutanixMountV1Input!):PatchNutanixMountV1Reply!
                ",
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
            HelpMessage =
                @"
                Remove a Live Mount of a Nutanix virtual machine snapshot

Supported in v6.0+
Initiates a request to remove a Live Mount of a Nutanix virtual machine snapshot identified by the ID of the Live Mount.
                GraphQL operation: deleteNutanixMountV1(input: DeleteNutanixMountV1Input!):AsyncRequestStatus!
                ",
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
            HelpMessage =
                @"
                Relocate a Nutanix virtual machine to another storage container

Supported in v6.0+
Initiate a request to migrate the virtual disks of a specified Nutanix Live Mount to another storage container. The destination storage container has been specified when the Live Mount was created. The Live Mount will be deleted when the relocation succeeds.
                GraphQL operation: migrateNutanixMountV1(input: MigrateNutanixMountV1Input!):AsyncRequestStatus!
                ",
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
            HelpMessage =
                @"
                Restore files

Supported in v5.0+
Restore files from a snapshot to the source Nutanix virtual machine.
                GraphQL operation: restoreFilesNutanixSnapshot(input: RestoreFilesNutanixSnapshotInput!):AsyncRequestStatus!
                ",
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
            HelpMessage =
                @"
                v5.0-v8.0: Download files from a Nutanix VM backup
v8.1+: Download files from a Nutanix virtual machine backup

Supported in v5.0+
v5.0-v8.0: Start an asynchronous job to download multiple files and folders from a specified Nutanix VM backup. The response returns an asynchronous request ID. Get the URL for downloading the zip file including the specific files/folders by sending a GET request to 'nutanix/vm/request/{id}'.
v8.1+: Start an asynchronous job to download multiple files and folders from a specified Nutanix virtual machine backup. The response returns an asynchronous request ID. Get the URL for downloading the zip file including the specific files/folders by sending a GET request to 'nutanix/vm/request/{id}'.
                GraphQL operation: downloadFilesNutanixSnapshot(input: DownloadFilesNutanixSnapshotInput!):AsyncRequestStatus!
                ",
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
            HelpMessage =
                @"
                v5.0-v8.0: Export VM snapshot
v8.1+: Export virtual machine snapshot

Supported in v5.0+
v5.0-v8.0: Export snapshot of a vm.
v8.1+: Export snapshot of a virtual machine.
                GraphQL operation: exportNutanixSnapshot(input: ExportNutanixSnapshotInput!):AsyncRequestStatus!
                ",
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
            HelpMessage =
                @"
                Creates a download from archival request

Supported in v5.0+
Download a snapshot from archival.
                GraphQL operation: downloadNutanixSnapshot(input: DownloadNutanixSnapshotInput!):AsyncRequestStatus!
                ",
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
            HelpMessage =
                @"
                Exports a snapshot from each member of a set of virtual machines

Supported in v7.0+
Export a snapshot from each member of a set of virtual machines.
                GraphQL operation: batchExportNutanixVm(input: BatchExportNutanixVmInput!):BatchExportNutanixVmReply!
                ",
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
            HelpMessage =
                @"
                Mount snapshots from multiple virtual machines

Supported in v7.0+
Mounts a batch of snapshots from a group of specified virtual machines.
                GraphQL operation: batchMountNutanixVm(input: BatchMountNutanixVmInput!):BatchMountNutanixVmReply!
                ",
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
            HelpMessage =
                @"
                Download a snapshot from a replication target

Supported in v7.0+
Initiates a job to download a snapshot from the specified location when the snapshot does not exist locally. The specified location has to be a replication target connected to this Rubrik cluster. If an SLA Domain is not provided, the snapshot will be retained forever.
                GraphQL operation: downloadNutanixVmFromLocation(input: DownloadNutanixVmFromLocationInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter downloadVmFromLocation { get; set; }

        
        // -------------------------------------------------------------------
        // createPrismCentral parameter set
        //
        // GraphQL operation: createNutanixPrismCentral(input: CreateNutanixPrismCentralInput!):BatchAsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "createPrismCentral",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Add Nutanix Prism Central and it's corresponding Prism Elements

Supported in v9.0
Create a Nutanix Prism Central object and refresh the Prism Elements present in it.
                GraphQL operation: createNutanixPrismCentral(input: CreateNutanixPrismCentralInput!):BatchAsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter createPrismCentral { get; set; }

        
        // -------------------------------------------------------------------
        // updatePrismCentral parameter set
        //
        // GraphQL operation: updateNutanixPrismCentral(input: UpdateNutanixPrismCentralInput!):UpdateNutanixPrismCentralReply!
        //
        [Parameter(
            ParameterSetName = "updatePrismCentral",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Patch Nutanix Prism Central

Supported in v9.0
Patch the host and credentials of Nutanix Prism Central.
                GraphQL operation: updateNutanixPrismCentral(input: UpdateNutanixPrismCentralInput!):UpdateNutanixPrismCentralReply!
                ",
            Position = 0
        )]
        public SwitchParameter updatePrismCentral { get; set; }

        
        // -------------------------------------------------------------------
        // deletePrismCentral parameter set
        //
        // GraphQL operation: deleteNutanixPrismCentral(input: DeleteNutanixPrismCentralInput!):BatchAsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "deletePrismCentral",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Remove Nutanix Prism Central

Supported in v9.0
Initiates an asynchronous job to remove a Nutanix Prism Central object. The Nutanix Clusters attached to the Prism Central cannot have Virtual Machines mounted through the Rubrik cluster.
                GraphQL operation: deleteNutanixPrismCentral(input: DeleteNutanixPrismCentralInput!):BatchAsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter deletePrismCentral { get; set; }

        
        // -------------------------------------------------------------------
        // refreshPrismCentral parameter set
        //
        // GraphQL operation: refreshNutanixPrismCentral(input: RefreshNutanixPrismCentralInput!):BatchAsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "refreshPrismCentral",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Refresh Nutanix Prism Central metadata

Supported in v9.0
Initiates a job to refresh the metadata for the specified Nutanix Prism Central and all its associated clusters.
                GraphQL operation: refreshNutanixPrismCentral(input: RefreshNutanixPrismCentralInput!):BatchAsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter refreshPrismCentral { get; set; }

        
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
            HelpMessage =
                @"
                Take an on-demand snapshot for selected Nutanix virtual machines

Supported in v9.0
Take bulk backups for multiple Nutanix virtual machines.
                GraphQL operation: bulkOnDemandSnapshotNutanixVm(input: BulkOnDemandSnapshotNutanixVmInput!):BulkOnDemandSnapshotNutanixVmReply!
                ",
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
                    case "createPrismCentral":
                        this.ProcessRecord_createPrismCentral();
                        break;
                    case "updatePrismCentral":
                        this.ProcessRecord_updatePrismCentral();
                        break;
                    case "deletePrismCentral":
                        this.ProcessRecord_deletePrismCentral();
                        break;
                    case "refreshPrismCentral":
                        this.ProcessRecord_refreshPrismCentral();
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
                    "Invoke-RscMutateNutanix",
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
        // createNutanixPrismCentral.
        protected void ProcessRecord_createPrismCentral()
        {
            this._logger.name += " -createPrismCentral";
            // Invoke graphql operation createNutanixPrismCentral
            InvokeMutationCreateNutanixPrismCentral();
        }

        // This parameter set invokes a single graphql operation:
        // updateNutanixPrismCentral.
        protected void ProcessRecord_updatePrismCentral()
        {
            this._logger.name += " -updatePrismCentral";
            // Invoke graphql operation updateNutanixPrismCentral
            InvokeMutationUpdateNutanixPrismCentral();
        }

        // This parameter set invokes a single graphql operation:
        // deleteNutanixPrismCentral.
        protected void ProcessRecord_deletePrismCentral()
        {
            this._logger.name += " -deletePrismCentral";
            // Invoke graphql operation deleteNutanixPrismCentral
            InvokeMutationDeleteNutanixPrismCentral();
        }

        // This parameter set invokes a single graphql operation:
        // refreshNutanixPrismCentral.
        protected void ProcessRecord_refreshPrismCentral()
        {
            this._logger.name += " -refreshPrismCentral";
            // Invoke graphql operation refreshNutanixPrismCentral
            InvokeMutationRefreshNutanixPrismCentral();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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