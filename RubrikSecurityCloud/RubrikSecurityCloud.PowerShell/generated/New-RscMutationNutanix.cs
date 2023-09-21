// New-RscMutationNutanix.cs
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
    /// Mutations for the 'Nutanix' API domain.
    /// </summary>
    /// <description>
    /// New-RscMutationNutanix is the cmdlet to work with operations in the {self.noun} API domain. It is a dynamic cmdlet that accepts any {self.noun} API operation as its first parameter:  {sc_names}.
    /// </description>
    /// <example>
    /// <code>New-RscMutationNutanix -CreateCluster [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationNutanix -RefreshCluster [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationNutanix -UpdateCluster [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationNutanix -DeleteCluster [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationNutanix -RegisterAgentVm [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationNutanix -UpdateVm [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationNutanix -CreateOnDemandBackup [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationNutanix -DeleteSnapshots [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationNutanix -MountSnapshotV1 [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationNutanix -PatchMountV1 [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationNutanix -DeleteMountV1 [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationNutanix -MigrateMountV1 [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationNutanix -DeleteSnapshot [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationNutanix -RestoreFilesSnapshot [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationNutanix -DownloadFilesSnapshot [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationNutanix -ExportSnapshot [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationNutanix -DownloadSnapshot [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationNutanix -BatchExportVm [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationNutanix -BatchMountVm [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationNutanix -DownloadVmFromLocation [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationNutanix -CreatePrismCentral [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationNutanix -UpdatePrismCentral [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationNutanix -DeletePrismCentral [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationNutanix -RefreshPrismCentral [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationNutanix -BulkOnDemandSnapshotVm [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationNutanix",
        DefaultParameterSetName = "UpdateVm")
    ]
    public class New_RscMutationNutanix : RscGqlPSCmdlet
    {
        
        /// <summary>
        /// CreateCluster parameter set
        ///
        /// [GraphQL: createNutanixCluster]
        /// </summary>
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

        
        /// <summary>
        /// RefreshCluster parameter set
        ///
        /// [GraphQL: refreshNutanixCluster]
        /// </summary>
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

        
        /// <summary>
        /// UpdateCluster parameter set
        ///
        /// [GraphQL: updateNutanixCluster]
        /// </summary>
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

        
        /// <summary>
        /// DeleteCluster parameter set
        ///
        /// [GraphQL: deleteNutanixCluster]
        /// </summary>
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

        
        /// <summary>
        /// RegisterAgentVm parameter set
        ///
        /// [GraphQL: registerAgentNutanixVm]
        /// </summary>
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

        
        /// <summary>
        /// UpdateVm parameter set
        ///
        /// [GraphQL: updateNutanixVm]
        /// </summary>
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

        
        /// <summary>
        /// CreateOnDemandBackup parameter set
        ///
        /// [GraphQL: createOnDemandNutanixBackup]
        /// </summary>
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

        
        /// <summary>
        /// DeleteSnapshots parameter set
        ///
        /// [GraphQL: deleteNutanixSnapshots]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteSnapshots",
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
        public SwitchParameter DeleteSnapshots { get; set; }

        
        /// <summary>
        /// MountSnapshotV1 parameter set
        ///
        /// [GraphQL: mountNutanixSnapshotV1]
        /// </summary>
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

        
        /// <summary>
        /// PatchMountV1 parameter set
        ///
        /// [GraphQL: patchNutanixMountV1]
        /// </summary>
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

        
        /// <summary>
        /// DeleteMountV1 parameter set
        ///
        /// [GraphQL: deleteNutanixMountV1]
        /// </summary>
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

        
        /// <summary>
        /// MigrateMountV1 parameter set
        ///
        /// [GraphQL: migrateNutanixMountV1]
        /// </summary>
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

        
        /// <summary>
        /// DeleteSnapshot parameter set
        ///
        /// [GraphQL: deleteNutanixSnapshot]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"v5.0-v8.0: Delete VM snapshot
v8.1+: Delete virtual machine snapshot

Supported in v5.0+
v5.0-v8.0: Delete a snapshot by expiring it. Snapshot is expired only if it is a manual snapshot or a snapshot of an unprotected vm.
v8.1+: Delete a snapshot by expiring it. Snapshot is expired only if it is a manual snapshot or a snapshot of an unprotected virtual machine.
[GraphQL: deleteNutanixSnapshot]",
            Position = 0
        )]
        public SwitchParameter DeleteSnapshot { get; set; }

        
        /// <summary>
        /// RestoreFilesSnapshot parameter set
        ///
        /// [GraphQL: restoreFilesNutanixSnapshot]
        /// </summary>
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

        
        /// <summary>
        /// DownloadFilesSnapshot parameter set
        ///
        /// [GraphQL: downloadFilesNutanixSnapshot]
        /// </summary>
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

        
        /// <summary>
        /// ExportSnapshot parameter set
        ///
        /// [GraphQL: exportNutanixSnapshot]
        /// </summary>
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

        
        /// <summary>
        /// DownloadSnapshot parameter set
        ///
        /// [GraphQL: downloadNutanixSnapshot]
        /// </summary>
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

        
        /// <summary>
        /// BatchExportVm parameter set
        ///
        /// [GraphQL: batchExportNutanixVm]
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
[GraphQL: batchExportNutanixVm]",
            Position = 0
        )]
        public SwitchParameter BatchExportVm { get; set; }

        
        /// <summary>
        /// BatchMountVm parameter set
        ///
        /// [GraphQL: batchMountNutanixVm]
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
[GraphQL: batchMountNutanixVm]",
            Position = 0
        )]
        public SwitchParameter BatchMountVm { get; set; }

        
        /// <summary>
        /// DownloadVmFromLocation parameter set
        ///
        /// [GraphQL: downloadNutanixVmFromLocation]
        /// </summary>
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

        
        /// <summary>
        /// CreatePrismCentral parameter set
        ///
        /// [GraphQL: createNutanixPrismCentral]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreatePrismCentral",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Add Nutanix Prism Central and it's corresponding Prism Elements

Supported in v9.0+
Create a Nutanix Prism Central object and refresh the Prism Elements present in it.
[GraphQL: createNutanixPrismCentral]",
            Position = 0
        )]
        public SwitchParameter CreatePrismCentral { get; set; }

        
        /// <summary>
        /// UpdatePrismCentral parameter set
        ///
        /// [GraphQL: updateNutanixPrismCentral]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdatePrismCentral",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Patch Nutanix Prism Central

Supported in v9.0+
Patch the host and credentials of Nutanix Prism Central.
[GraphQL: updateNutanixPrismCentral]",
            Position = 0
        )]
        public SwitchParameter UpdatePrismCentral { get; set; }

        
        /// <summary>
        /// DeletePrismCentral parameter set
        ///
        /// [GraphQL: deleteNutanixPrismCentral]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeletePrismCentral",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Remove Nutanix Prism Central

Supported in v9.0+
Initiates an asynchronous job to remove a Nutanix Prism Central object. The Nutanix Clusters attached to the Prism Central cannot have Virtual Machines mounted through the Rubrik cluster.
[GraphQL: deleteNutanixPrismCentral]",
            Position = 0
        )]
        public SwitchParameter DeletePrismCentral { get; set; }

        
        /// <summary>
        /// RefreshPrismCentral parameter set
        ///
        /// [GraphQL: refreshNutanixPrismCentral]
        /// </summary>
        [Parameter(
            ParameterSetName = "RefreshPrismCentral",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refresh Nutanix Prism Central metadata

Supported in v9.0+
Initiates a job to refresh the metadata for the specified Nutanix Prism Central and all its associated clusters.
[GraphQL: refreshNutanixPrismCentral]",
            Position = 0
        )]
        public SwitchParameter RefreshPrismCentral { get; set; }

        
        /// <summary>
        /// BulkOnDemandSnapshotVm parameter set
        ///
        /// [GraphQL: bulkOnDemandSnapshotNutanixVm]
        /// </summary>
        [Parameter(
            ParameterSetName = "BulkOnDemandSnapshotVm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Take an on-demand snapshot for selected Nutanix virtual machines

Supported in v9.0+
Take bulk backups for multiple Nutanix virtual machines.
[GraphQL: bulkOnDemandSnapshotNutanixVm]",
            Position = 0
        )]
        public SwitchParameter BulkOnDemandSnapshotVm { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
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
                    case "DeleteSnapshots":
                        this.ProcessRecord_DeleteSnapshots();
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
                    case "DeleteSnapshot":
                        this.ProcessRecord_DeleteSnapshot();
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
#pragma warning restore 1591

        // This parameter set invokes a single graphql operation:
        // createNutanixCluster.
        internal void ProcessRecord_CreateCluster()
        {
            this._logger.name += " -CreateCluster";
            // Create new graphql operation createNutanixCluster
            InitMutationCreateNutanixCluster();
        }

        // This parameter set invokes a single graphql operation:
        // refreshNutanixCluster.
        internal void ProcessRecord_RefreshCluster()
        {
            this._logger.name += " -RefreshCluster";
            // Create new graphql operation refreshNutanixCluster
            InitMutationRefreshNutanixCluster();
        }

        // This parameter set invokes a single graphql operation:
        // updateNutanixCluster.
        internal void ProcessRecord_UpdateCluster()
        {
            this._logger.name += " -UpdateCluster";
            // Create new graphql operation updateNutanixCluster
            InitMutationUpdateNutanixCluster();
        }

        // This parameter set invokes a single graphql operation:
        // deleteNutanixCluster.
        internal void ProcessRecord_DeleteCluster()
        {
            this._logger.name += " -DeleteCluster";
            // Create new graphql operation deleteNutanixCluster
            InitMutationDeleteNutanixCluster();
        }

        // This parameter set invokes a single graphql operation:
        // registerAgentNutanixVm.
        internal void ProcessRecord_RegisterAgentVm()
        {
            this._logger.name += " -RegisterAgentVm";
            // Create new graphql operation registerAgentNutanixVm
            InitMutationRegisterAgentNutanixVm();
        }

        // This parameter set invokes a single graphql operation:
        // updateNutanixVm.
        internal void ProcessRecord_UpdateVm()
        {
            this._logger.name += " -UpdateVm";
            // Create new graphql operation updateNutanixVm
            InitMutationUpdateNutanixVm();
        }

        // This parameter set invokes a single graphql operation:
        // createOnDemandNutanixBackup.
        internal void ProcessRecord_CreateOnDemandBackup()
        {
            this._logger.name += " -CreateOnDemandBackup";
            // Create new graphql operation createOnDemandNutanixBackup
            InitMutationCreateOnDemandNutanixBackup();
        }

        // This parameter set invokes a single graphql operation:
        // deleteNutanixSnapshots.
        internal void ProcessRecord_DeleteSnapshots()
        {
            this._logger.name += " -DeleteSnapshots";
            // Create new graphql operation deleteNutanixSnapshots
            InitMutationDeleteNutanixSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // mountNutanixSnapshotV1.
        internal void ProcessRecord_MountSnapshotV1()
        {
            this._logger.name += " -MountSnapshotV1";
            // Create new graphql operation mountNutanixSnapshotV1
            InitMutationMountNutanixSnapshotV1();
        }

        // This parameter set invokes a single graphql operation:
        // patchNutanixMountV1.
        internal void ProcessRecord_PatchMountV1()
        {
            this._logger.name += " -PatchMountV1";
            // Create new graphql operation patchNutanixMountV1
            InitMutationPatchNutanixMountV1();
        }

        // This parameter set invokes a single graphql operation:
        // deleteNutanixMountV1.
        internal void ProcessRecord_DeleteMountV1()
        {
            this._logger.name += " -DeleteMountV1";
            // Create new graphql operation deleteNutanixMountV1
            InitMutationDeleteNutanixMountV1();
        }

        // This parameter set invokes a single graphql operation:
        // migrateNutanixMountV1.
        internal void ProcessRecord_MigrateMountV1()
        {
            this._logger.name += " -MigrateMountV1";
            // Create new graphql operation migrateNutanixMountV1
            InitMutationMigrateNutanixMountV1();
        }

        // This parameter set invokes a single graphql operation:
        // deleteNutanixSnapshot.
        internal void ProcessRecord_DeleteSnapshot()
        {
            this._logger.name += " -DeleteSnapshot";
            // Create new graphql operation deleteNutanixSnapshot
            InitMutationDeleteNutanixSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // restoreFilesNutanixSnapshot.
        internal void ProcessRecord_RestoreFilesSnapshot()
        {
            this._logger.name += " -RestoreFilesSnapshot";
            // Create new graphql operation restoreFilesNutanixSnapshot
            InitMutationRestoreFilesNutanixSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // downloadFilesNutanixSnapshot.
        internal void ProcessRecord_DownloadFilesSnapshot()
        {
            this._logger.name += " -DownloadFilesSnapshot";
            // Create new graphql operation downloadFilesNutanixSnapshot
            InitMutationDownloadFilesNutanixSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // exportNutanixSnapshot.
        internal void ProcessRecord_ExportSnapshot()
        {
            this._logger.name += " -ExportSnapshot";
            // Create new graphql operation exportNutanixSnapshot
            InitMutationExportNutanixSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // downloadNutanixSnapshot.
        internal void ProcessRecord_DownloadSnapshot()
        {
            this._logger.name += " -DownloadSnapshot";
            // Create new graphql operation downloadNutanixSnapshot
            InitMutationDownloadNutanixSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // batchExportNutanixVm.
        internal void ProcessRecord_BatchExportVm()
        {
            this._logger.name += " -BatchExportVm";
            // Create new graphql operation batchExportNutanixVm
            InitMutationBatchExportNutanixVm();
        }

        // This parameter set invokes a single graphql operation:
        // batchMountNutanixVm.
        internal void ProcessRecord_BatchMountVm()
        {
            this._logger.name += " -BatchMountVm";
            // Create new graphql operation batchMountNutanixVm
            InitMutationBatchMountNutanixVm();
        }

        // This parameter set invokes a single graphql operation:
        // downloadNutanixVmFromLocation.
        internal void ProcessRecord_DownloadVmFromLocation()
        {
            this._logger.name += " -DownloadVmFromLocation";
            // Create new graphql operation downloadNutanixVmFromLocation
            InitMutationDownloadNutanixVmFromLocation();
        }

        // This parameter set invokes a single graphql operation:
        // createNutanixPrismCentral.
        internal void ProcessRecord_CreatePrismCentral()
        {
            this._logger.name += " -CreatePrismCentral";
            // Create new graphql operation createNutanixPrismCentral
            InitMutationCreateNutanixPrismCentral();
        }

        // This parameter set invokes a single graphql operation:
        // updateNutanixPrismCentral.
        internal void ProcessRecord_UpdatePrismCentral()
        {
            this._logger.name += " -UpdatePrismCentral";
            // Create new graphql operation updateNutanixPrismCentral
            InitMutationUpdateNutanixPrismCentral();
        }

        // This parameter set invokes a single graphql operation:
        // deleteNutanixPrismCentral.
        internal void ProcessRecord_DeletePrismCentral()
        {
            this._logger.name += " -DeletePrismCentral";
            // Create new graphql operation deleteNutanixPrismCentral
            InitMutationDeleteNutanixPrismCentral();
        }

        // This parameter set invokes a single graphql operation:
        // refreshNutanixPrismCentral.
        internal void ProcessRecord_RefreshPrismCentral()
        {
            this._logger.name += " -RefreshPrismCentral";
            // Create new graphql operation refreshNutanixPrismCentral
            InitMutationRefreshNutanixPrismCentral();
        }

        // This parameter set invokes a single graphql operation:
        // bulkOnDemandSnapshotNutanixVm.
        internal void ProcessRecord_BulkOnDemandSnapshotVm()
        {
            this._logger.name += " -BulkOnDemandSnapshotVm";
            // Create new graphql operation bulkOnDemandSnapshotNutanixVm
            InitMutationBulkOnDemandSnapshotNutanixVm();
        }


        // Create new GraphQL Mutation:
        // createNutanixCluster(input: CreateNutanixClusterInput!): AsyncRequestStatus!
        internal void InitMutationCreateNutanixCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateNutanixClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateNutanixCluster",
                "($input: CreateNutanixClusterInput!)",
                "AsyncRequestStatus",
                Mutation.CreateNutanixCluster_ObjectFieldSpec,
                Mutation.CreateNutanixClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	nutanixClusterConfig = @{
		# REQUIRED
		caCerts = <System.String>
		# REQUIRED
		hostname = <System.String>
		# REQUIRED
		nutanixClusterUuid = <System.String>
		# REQUIRED
		password = <System.String>
		# REQUIRED
		username = <System.String>
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // refreshNutanixCluster(input: RefreshNutanixClusterInput!): AsyncRequestStatus!
        internal void InitMutationRefreshNutanixCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshNutanixClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshNutanixCluster",
                "($input: RefreshNutanixClusterInput!)",
                "AsyncRequestStatus",
                Mutation.RefreshNutanixCluster_ObjectFieldSpec,
                Mutation.RefreshNutanixClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateNutanixCluster(input: UpdateNutanixClusterInput!): UpdateNutanixClusterReply!
        internal void InitMutationUpdateNutanixCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateNutanixClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateNutanixCluster",
                "($input: UpdateNutanixClusterInput!)",
                "UpdateNutanixClusterReply",
                Mutation.UpdateNutanixCluster_ObjectFieldSpec,
                Mutation.UpdateNutanixClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	patchProperties = @{
		# OPTIONAL
		caCerts = <System.String>
		# OPTIONAL
		configuredSlaDomainId = <System.String>
		# OPTIONAL
		hostname = <System.String>
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		username = <System.String>
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteNutanixCluster(input: DeleteNutanixClusterInput!): AsyncRequestStatus!
        internal void InitMutationDeleteNutanixCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteNutanixClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteNutanixCluster",
                "($input: DeleteNutanixClusterInput!)",
                "AsyncRequestStatus",
                Mutation.DeleteNutanixCluster_ObjectFieldSpec,
                Mutation.DeleteNutanixClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // registerAgentNutanixVm(input: RegisterAgentNutanixVmInput!): RequestSuccess!
        internal void InitMutationRegisterAgentNutanixVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RegisterAgentNutanixVmInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRegisterAgentNutanixVm",
                "($input: RegisterAgentNutanixVmInput!)",
                "RequestSuccess",
                Mutation.RegisterAgentNutanixVm_ObjectFieldSpec,
                Mutation.RegisterAgentNutanixVmFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateNutanixVm(input: UpdateNutanixVmInput!): Void
        internal void InitMutationUpdateNutanixVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateNutanixVmInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateNutanixVm",
                "($input: UpdateNutanixVmInput!)",
                "System.String",
                Mutation.UpdateNutanixVm_ObjectFieldSpec,
                Mutation.UpdateNutanixVmFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	vmPatchProperties = @{
		# OPTIONAL
		configuredSlaDomainId = <System.String>
		# OPTIONAL
		excludedDiskIds = @(
			<System.String>
		)
		# OPTIONAL
		isPaused = <System.Boolean>
		# OPTIONAL
		postBackupScript = @{
			# REQUIRED
			failureHandling = <NutanixVirtualMachineScriptDetailFailureHandling> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NutanixVirtualMachineScriptDetailFailureHandling]) for enum values.
			# REQUIRED
			scriptPath = <System.String>
			# REQUIRED
			timeoutMs = <System.Int64>
		}
		# OPTIONAL
		postSnapScript = @{
			# REQUIRED
			failureHandling = <NutanixVirtualMachineScriptDetailFailureHandling> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NutanixVirtualMachineScriptDetailFailureHandling]) for enum values.
			# REQUIRED
			scriptPath = <System.String>
			# REQUIRED
			timeoutMs = <System.Int64>
		}
		# OPTIONAL
		preBackupScript = @{
			# REQUIRED
			failureHandling = <NutanixVirtualMachineScriptDetailFailureHandling> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NutanixVirtualMachineScriptDetailFailureHandling]) for enum values.
			# REQUIRED
			scriptPath = <System.String>
			# REQUIRED
			timeoutMs = <System.Int64>
		}
		# OPTIONAL
		snapshotConsistencyMandate = <CdmNutanixSnapshotConsistencyMandate> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmNutanixSnapshotConsistencyMandate]) for enum values.
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createOnDemandNutanixBackup(input: CreateOnDemandNutanixBackupInput!): AsyncRequestStatus!
        internal void InitMutationCreateOnDemandNutanixBackup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateOnDemandNutanixBackupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateOnDemandNutanixBackup",
                "($input: CreateOnDemandNutanixBackupInput!)",
                "AsyncRequestStatus",
                Mutation.CreateOnDemandNutanixBackup_ObjectFieldSpec,
                Mutation.CreateOnDemandNutanixBackupFieldSpec,
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
        // deleteNutanixSnapshots(input: DeleteNutanixSnapshotsInput!): RequestSuccess!
        internal void InitMutationDeleteNutanixSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteNutanixSnapshotsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteNutanixSnapshots",
                "($input: DeleteNutanixSnapshotsInput!)",
                "RequestSuccess",
                Mutation.DeleteNutanixSnapshots_ObjectFieldSpec,
                Mutation.DeleteNutanixSnapshotsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // mountNutanixSnapshotV1(input: MountNutanixSnapshotV1Input!): AsyncRequestStatus!
        internal void InitMutationMountNutanixSnapshotV1()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MountNutanixSnapshotV1Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationMountNutanixSnapshotV1",
                "($input: MountNutanixSnapshotV1Input!)",
                "AsyncRequestStatus",
                Mutation.MountNutanixSnapshotV1_ObjectFieldSpec,
                Mutation.MountNutanixSnapshotV1FieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		containerNaturalId = <System.String>
		# OPTIONAL
		nutanixClusterId = <System.String>
		# OPTIONAL
		shouldMigrateImmediately = <System.Boolean>
		# OPTIONAL
		shouldPowerOn = <System.Boolean>
		# OPTIONAL
		shouldRemoveNetwork = <System.Boolean>
		# OPTIONAL
		targetNetwork = <System.String>
		# OPTIONAL
		vmName = <System.String>
		# OPTIONAL
		keepMacAddresses = <System.Boolean>
		# OPTIONAL
		nicNetworkUuids = @(
			<System.String>
		)
		# REQUIRED
		shouldDisableMigration = <System.Boolean>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // patchNutanixMountV1(input: PatchNutanixMountV1Input!): PatchNutanixMountV1Reply!
        internal void InitMutationPatchNutanixMountV1()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PatchNutanixMountV1Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPatchNutanixMountV1",
                "($input: PatchNutanixMountV1Input!)",
                "PatchNutanixMountV1Reply",
                Mutation.PatchNutanixMountV1_ObjectFieldSpec,
                Mutation.PatchNutanixMountV1FieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		shouldPowerOn = <System.Boolean>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteNutanixMountV1(input: DeleteNutanixMountV1Input!): AsyncRequestStatus!
        internal void InitMutationDeleteNutanixMountV1()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteNutanixMountV1Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteNutanixMountV1",
                "($input: DeleteNutanixMountV1Input!)",
                "AsyncRequestStatus",
                Mutation.DeleteNutanixMountV1_ObjectFieldSpec,
                Mutation.DeleteNutanixMountV1FieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // migrateNutanixMountV1(input: MigrateNutanixMountV1Input!): AsyncRequestStatus!
        internal void InitMutationMigrateNutanixMountV1()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MigrateNutanixMountV1Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationMigrateNutanixMountV1",
                "($input: MigrateNutanixMountV1Input!)",
                "AsyncRequestStatus",
                Mutation.MigrateNutanixMountV1_ObjectFieldSpec,
                Mutation.MigrateNutanixMountV1FieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteNutanixSnapshot(input: DeleteNutanixSnapshotInput!): RequestSuccess!
        internal void InitMutationDeleteNutanixSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteNutanixSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteNutanixSnapshot",
                "($input: DeleteNutanixSnapshotInput!)",
                "RequestSuccess",
                Mutation.DeleteNutanixSnapshot_ObjectFieldSpec,
                Mutation.DeleteNutanixSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	location = <InternalDeleteNutanixSnapshotRequestLocation> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InternalDeleteNutanixSnapshotRequestLocation]) for enum values.
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // restoreFilesNutanixSnapshot(input: RestoreFilesNutanixSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationRestoreFilesNutanixSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreFilesNutanixSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreFilesNutanixSnapshot",
                "($input: RestoreFilesNutanixSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.RestoreFilesNutanixSnapshot_ObjectFieldSpec,
                Mutation.RestoreFilesNutanixSnapshotFieldSpec,
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
        // downloadFilesNutanixSnapshot(input: DownloadFilesNutanixSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationDownloadFilesNutanixSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadFilesNutanixSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadFilesNutanixSnapshot",
                "($input: DownloadFilesNutanixSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadFilesNutanixSnapshot_ObjectFieldSpec,
                Mutation.DownloadFilesNutanixSnapshotFieldSpec,
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
        // exportNutanixSnapshot(input: ExportNutanixSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationExportNutanixSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportNutanixSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExportNutanixSnapshot",
                "($input: ExportNutanixSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.ExportNutanixSnapshot_ObjectFieldSpec,
                Mutation.ExportNutanixSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		nutanixClusterId = <System.String>
		# OPTIONAL
		powerOn = <System.Boolean>
		# OPTIONAL
		removeNetworkDevices = <System.Boolean>
		# OPTIONAL
		vmName = <System.String>
		# OPTIONAL
		keepMacAddresses = <System.Boolean>
		# OPTIONAL
		nicNetworkUuids = @(
			<System.String>
		)
		# REQUIRED
		containerNaturalId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadNutanixSnapshot(input: DownloadNutanixSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationDownloadNutanixSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadNutanixSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadNutanixSnapshot",
                "($input: DownloadNutanixSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadNutanixSnapshot_ObjectFieldSpec,
                Mutation.DownloadNutanixSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // batchExportNutanixVm(input: BatchExportNutanixVmInput!): BatchExportNutanixVmReply!
        internal void InitMutationBatchExportNutanixVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BatchExportNutanixVmInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBatchExportNutanixVm",
                "($input: BatchExportNutanixVmInput!)",
                "BatchExportNutanixVmReply",
                Mutation.BatchExportNutanixVm_ObjectFieldSpec,
                Mutation.BatchExportNutanixVmFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
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
					nutanixClusterId = <System.String>
					# OPTIONAL
					powerOn = <System.Boolean>
					# OPTIONAL
					removeNetworkDevices = <System.Boolean>
					# OPTIONAL
					vmName = <System.String>
					# OPTIONAL
					keepMacAddresses = <System.Boolean>
					# OPTIONAL
					nicNetworkUuids = @(
						<System.String>
					)
					# REQUIRED
					containerNaturalId = <System.String>
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
        // batchMountNutanixVm(input: BatchMountNutanixVmInput!): BatchMountNutanixVmReply!
        internal void InitMutationBatchMountNutanixVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BatchMountNutanixVmInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBatchMountNutanixVm",
                "($input: BatchMountNutanixVmInput!)",
                "BatchMountNutanixVmReply",
                Mutation.BatchMountNutanixVm_ObjectFieldSpec,
                Mutation.BatchMountNutanixVmFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
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
					containerNaturalId = <System.String>
					# OPTIONAL
					nutanixClusterId = <System.String>
					# OPTIONAL
					shouldMigrateImmediately = <System.Boolean>
					# OPTIONAL
					shouldPowerOn = <System.Boolean>
					# OPTIONAL
					shouldRemoveNetwork = <System.Boolean>
					# OPTIONAL
					targetNetwork = <System.String>
					# OPTIONAL
					vmName = <System.String>
					# OPTIONAL
					keepMacAddresses = <System.Boolean>
					# OPTIONAL
					nicNetworkUuids = @(
						<System.String>
					)
					# REQUIRED
					shouldDisableMigration = <System.Boolean>
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
        // downloadNutanixVmFromLocation(input: DownloadNutanixVmFromLocationInput!): AsyncRequestStatus!
        internal void InitMutationDownloadNutanixVmFromLocation()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadNutanixVmFromLocationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadNutanixVmFromLocation",
                "($input: DownloadNutanixVmFromLocationInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadNutanixVmFromLocation_ObjectFieldSpec,
                Mutation.DownloadNutanixVmFromLocationFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	downloadConfig = @{
		# OPTIONAL
		slaId = <System.String>
	}
	# REQUIRED
	locationId = <System.String>
	# REQUIRED
	snapshotId = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // createNutanixPrismCentral(input: CreateNutanixPrismCentralInput!): BatchAsyncRequestStatus!
        internal void InitMutationCreateNutanixPrismCentral()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateNutanixPrismCentralInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateNutanixPrismCentral",
                "($input: CreateNutanixPrismCentralInput!)",
                "BatchAsyncRequestStatus",
                Mutation.CreateNutanixPrismCentral_ObjectFieldSpec,
                Mutation.CreateNutanixPrismCentralFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	prismCentralConfig = @{
		# REQUIRED
		caCerts = <System.String>
		# REQUIRED
		hostname = <System.String>
		# REQUIRED
		password = <System.String>
		# REQUIRED
		username = <System.String>
	}
	# REQUIRED
	prismElementCdmTuple = @(
		@{
			# REQUIRED
			nutanixClusterId = <System.String>
			# REQUIRED
			cdmClusterId = <System.String>
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateNutanixPrismCentral(input: UpdateNutanixPrismCentralInput!): UpdateNutanixPrismCentralReply!
        internal void InitMutationUpdateNutanixPrismCentral()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateNutanixPrismCentralInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateNutanixPrismCentral",
                "($input: UpdateNutanixPrismCentralInput!)",
                "UpdateNutanixPrismCentralReply",
                Mutation.UpdateNutanixPrismCentral_ObjectFieldSpec,
                Mutation.UpdateNutanixPrismCentralFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	patchProperties = @{
		# OPTIONAL
		caCerts = <System.String>
		# OPTIONAL
		configuredSlaDomainId = <System.String>
		# OPTIONAL
		hostname = <System.String>
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		username = <System.String>
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteNutanixPrismCentral(input: DeleteNutanixPrismCentralInput!): BatchAsyncRequestStatus!
        internal void InitMutationDeleteNutanixPrismCentral()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteNutanixPrismCentralInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteNutanixPrismCentral",
                "($input: DeleteNutanixPrismCentralInput!)",
                "BatchAsyncRequestStatus",
                Mutation.DeleteNutanixPrismCentral_ObjectFieldSpec,
                Mutation.DeleteNutanixPrismCentralFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // refreshNutanixPrismCentral(input: RefreshNutanixPrismCentralInput!): BatchAsyncRequestStatus!
        internal void InitMutationRefreshNutanixPrismCentral()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshNutanixPrismCentralInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshNutanixPrismCentral",
                "($input: RefreshNutanixPrismCentralInput!)",
                "BatchAsyncRequestStatus",
                Mutation.RefreshNutanixPrismCentral_ObjectFieldSpec,
                Mutation.RefreshNutanixPrismCentralFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkOnDemandSnapshotNutanixVm(input: BulkOnDemandSnapshotNutanixVmInput!): BulkOnDemandSnapshotNutanixVmReply!
        internal void InitMutationBulkOnDemandSnapshotNutanixVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkOnDemandSnapshotNutanixVmInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkOnDemandSnapshotNutanixVm",
                "($input: BulkOnDemandSnapshotNutanixVmInput!)",
                "BulkOnDemandSnapshotNutanixVmReply",
                Mutation.BulkOnDemandSnapshotNutanixVm_ObjectFieldSpec,
                Mutation.BulkOnDemandSnapshotNutanixVmFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		vms = @(
			@{
				# REQUIRED
				backupConfig = @{
					# OPTIONAL
					slaId = <System.String>
				}
				# REQUIRED
				vmId = <System.String>
			}
		)
	}
	# OPTIONAL
	userNote = <System.String>
}"
            );
        }


    } // class New_RscMutationNutanix
}