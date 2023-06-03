// Invoke-RscMutateVsphereVm.cs
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
        "RscMutateVsphereVm",
        DefaultParameterSetName = "Update")
    ]
    public class Invoke_RscMutateVsphereVm : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // RecoverFile parameter set
        //
        // GraphQL operation: vsphereVmRecoverFiles(input: VsphereVmRecoverFilesInput!):VsphereAsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "RecoverFile",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Restores multiple files/directories from snapshot.
                GraphQL operation: vsphereVmRecoverFiles(input: VsphereVmRecoverFilesInput!):VsphereAsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter RecoverFile { get; set; }

        [Parameter(
            ParameterSetName = "RecoverFile",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Vsphere recover files input.
                GraphQL argument input: VsphereVmRecoverFilesInput!
                "
        )]
        public VsphereVmRecoverFilesInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // RecoverFilesNew parameter set
        //
        // GraphQL operation: vsphereVmRecoverFilesNew(input: VsphereVmRecoverFilesNewInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "RecoverFilesNew",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Restores multiple files/directories from snapshot.
                GraphQL operation: vsphereVmRecoverFilesNew(input: VsphereVmRecoverFilesNewInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter RecoverFilesNew { get; set; }

        
        // -------------------------------------------------------------------
        // RegisterAgent parameter set
        //
        // GraphQL operation: vsphereVmRegisterAgent(input: VsphereVmRegisterAgentInput!):RequestSuccess!
        //
        [Parameter(
            ParameterSetName = "RegisterAgent",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Register Rubrik Backup Service

Supported in v5.0+
Register the Rubrik Backup Service that is running on a specified host with the specified Rubrik cluster.
                GraphQL operation: vsphereVmRegisterAgent(input: VsphereVmRegisterAgentInput!):RequestSuccess!
                ",
            Position = 0
        )]
        public SwitchParameter RegisterAgent { get; set; }

        
        // -------------------------------------------------------------------
        // DownloadSnapshot parameter set
        //
        // GraphQL operation: vsphereVmDownloadSnapshot(input: VsphereVmDownloadSnapshotInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "DownloadSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Download snapshot from archive

Supported in v5.0+
Provides a method for retrieving a snapshot, that is not available locally, from an archival location.
                GraphQL operation: vsphereVmDownloadSnapshot(input: VsphereVmDownloadSnapshotInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter DownloadSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // ExportSnapshot parameter set
        //
        // GraphQL operation: vsphereVMExportSnapshot(,   snapshotFid: UUID!,   vmName: String,   disableNetwork: Boolean,   removeNetworkDevices: Boolean,   powerOn: Boolean,   keepMacAddresses: Boolean,   hostID: String,   datastoreId: UUID!,   unregsiterVm: Boolean,   shouldRecoverTags: Boolean, ):VsphereAsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "ExportSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: vsphereVMExportSnapshot(,   snapshotFid: UUID!,   vmName: String,   disableNetwork: Boolean,   removeNetworkDevices: Boolean,   powerOn: Boolean,   keepMacAddresses: Boolean,   hostID: String,   datastoreId: UUID!,   unregsiterVm: Boolean,   shouldRecoverTags: Boolean, ):VsphereAsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter ExportSnapshot { get; set; }

        [Parameter(
            ParameterSetName = "ExportSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Snapshot forever UUID in Rubrik Security Cloud.
                GraphQL argument snapshotFid: UUID!
                "
        )]
        public System.String? SnapshotFid { get; set; }
        [Parameter(
            ParameterSetName = "ExportSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument vmName: String
                "
        )]
        public System.String? VmName { get; set; }
        [Parameter(
            ParameterSetName = "ExportSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument disableNetwork: Boolean
                "
        )]
        public System.Boolean? DisableNetwork { get; set; }
        [Parameter(
            ParameterSetName = "ExportSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument removeNetworkDevices: Boolean
                "
        )]
        public System.Boolean? RemoveNetworkDevices { get; set; }
        [Parameter(
            ParameterSetName = "ExportSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument powerOn: Boolean
                "
        )]
        public System.Boolean? PowerOn { get; set; }
        [Parameter(
            ParameterSetName = "ExportSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument keepMacAddresses: Boolean
                "
        )]
        public System.Boolean? KeepMacAddresses { get; set; }
        [Parameter(
            ParameterSetName = "ExportSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument hostID: String
                "
        )]
        public System.String? HostId { get; set; }
        [Parameter(
            ParameterSetName = "ExportSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument datastoreId: UUID!
                "
        )]
        public System.String? DatastoreId { get; set; }
        [Parameter(
            ParameterSetName = "ExportSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument unregsiterVm: Boolean
                "
        )]
        public System.Boolean? UnregsiterVm { get; set; }
        [Parameter(
            ParameterSetName = "ExportSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument shouldRecoverTags: Boolean
                "
        )]
        public System.Boolean? ShouldRecoverTags { get; set; }
        
        // -------------------------------------------------------------------
        // ExportSnapshotV2 parameter set
        //
        // GraphQL operation: vsphereVmExportSnapshotV2(input: VsphereVmExportSnapshotV2Input!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "ExportSnapshotV2",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Create a vSphere Export from a snapshot or a point-in-time.
                GraphQL operation: vsphereVmExportSnapshotV2(input: VsphereVmExportSnapshotV2Input!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter ExportSnapshotV2 { get; set; }

        
        // -------------------------------------------------------------------
        // ExportSnapshotV3 parameter set
        //
        // GraphQL operation: vsphereVmExportSnapshotV3(input: VsphereVmExportSnapshotV3Input!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "ExportSnapshotV3",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Create a vSphere Export from a snapshot or a point-in-time with datastore cluster and virtual disk mapping support.
                GraphQL operation: vsphereVmExportSnapshotV3(input: VsphereVmExportSnapshotV3Input!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter ExportSnapshotV3 { get; set; }

        
        // -------------------------------------------------------------------
        // BatchExport parameter set
        //
        // GraphQL operation: vsphereVmBatchExport(input: VsphereVmBatchExportInput!):BatchAsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "BatchExport",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Create a mass export for a group of virtual machines.
                GraphQL operation: vsphereVmBatchExport(input: VsphereVmBatchExportInput!):BatchAsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter BatchExport { get; set; }

        
        // -------------------------------------------------------------------
        // BatchExportV3 parameter set
        //
        // GraphQL operation: vsphereVmBatchExportV3(input: VsphereVmBatchExportV3Input!):BatchAsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "BatchExportV3",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Create a batch export for a group of virtual machines with datastore cluster support.
                GraphQL operation: vsphereVmBatchExportV3(input: VsphereVmBatchExportV3Input!):BatchAsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter BatchExportV3 { get; set; }

        
        // -------------------------------------------------------------------
        // InitiateInPlaceRecovery parameter set
        //
        // GraphQL operation: vsphereVmInitiateInPlaceRecovery(input: VsphereVmInitiateInPlaceRecoveryInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "InitiateInPlaceRecovery",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Trigger an in-place recovery from a snapshot or point-in-time.
                GraphQL operation: vsphereVmInitiateInPlaceRecovery(input: VsphereVmInitiateInPlaceRecoveryInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter InitiateInPlaceRecovery { get; set; }

        
        // -------------------------------------------------------------------
        // ExportSnapshotWithDownloadFromCloud parameter set
        //
        // GraphQL operation: vsphereVmExportSnapshotWithDownloadFromCloud(input: VsphereVmExportSnapshotWithDownloadFromCloudInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "ExportSnapshotWithDownloadFromCloud",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Download a snapshot from an archival location, then export a virtual machine using the downloaded snapshot

Supported in v5.3+
Download a snapshot from an archival location and then export a virtual machine using the downloaded snapshot.
                GraphQL operation: vsphereVmExportSnapshotWithDownloadFromCloud(input: VsphereVmExportSnapshotWithDownloadFromCloudInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter ExportSnapshotWithDownloadFromCloud { get; set; }

        
        // -------------------------------------------------------------------
        // BatchInPlaceRecovery parameter set
        //
        // GraphQL operation: vsphereVmBatchInPlaceRecovery(input: VsphereVmBatchInPlaceRecoveryInput!):BatchAsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "BatchInPlaceRecovery",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Supported in v6.0+. Export a snapshot each from a set of virtual machines.
                GraphQL operation: vsphereVmBatchInPlaceRecovery(input: VsphereVmBatchInPlaceRecoveryInput!):BatchAsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter BatchInPlaceRecovery { get; set; }

        
        // -------------------------------------------------------------------
        // DeleteSnapshot parameter set
        //
        // GraphQL operation: vsphereVmDeleteSnapshot(input: VsphereVmDeleteSnapshotInput!):Void
        //
        [Parameter(
            ParameterSetName = "DeleteSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Designate a snapshot as expired and available for garbage collection. The snapshot must be an on-demand snapshot or a snapshot from a virtual machine that is not assigned to an SLA Domain.
                GraphQL operation: vsphereVmDeleteSnapshot(input: VsphereVmDeleteSnapshotInput!):Void
                ",
            Position = 0
        )]
        public SwitchParameter DeleteSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // Update parameter set
        //
        // GraphQL operation: vsphereVMUpdate(,   snappableFid: UUID!,   snapshotConsistencyMandate: String,   preBackupScript: PreBackupScriptInputType,   postBackupScript: PostBackupScriptInputType,   postSnapScript: PostSnapScriptInputType,   isArrayIntegrationEnabled: Boolean, ):RequestSuccess!
        //
        [Parameter(
            ParameterSetName = "Update",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: vsphereVMUpdate(,   snappableFid: UUID!,   snapshotConsistencyMandate: String,   preBackupScript: PreBackupScriptInputType,   postBackupScript: PostBackupScriptInputType,   postSnapScript: PostSnapScriptInputType,   isArrayIntegrationEnabled: Boolean, ):RequestSuccess!
                ",
            Position = 0
        )]
        public SwitchParameter Update { get; set; }

        [Parameter(
            ParameterSetName = "Update",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument snappableFid: UUID!
                "
        )]
        public System.String? SnappableFid { get; set; }
        [Parameter(
            ParameterSetName = "Update",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                The snapshot consistency mandate of the workload.
                GraphQL argument snapshotConsistencyMandate: String
                "
        )]
        public System.String? SnapshotConsistencyMandate { get; set; }
        [Parameter(
            ParameterSetName = "Update",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument preBackupScript: PreBackupScriptInputType
                "
        )]
        public PreBackupScriptInputType? PreBackupScript { get; set; }
        [Parameter(
            ParameterSetName = "Update",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument postBackupScript: PostBackupScriptInputType
                "
        )]
        public PostBackupScriptInputType? PostBackupScript { get; set; }
        [Parameter(
            ParameterSetName = "Update",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument postSnapScript: PostSnapScriptInputType
                "
        )]
        public PostSnapScriptInputType? PostSnapScript { get; set; }
        [Parameter(
            ParameterSetName = "Update",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument isArrayIntegrationEnabled: Boolean
                "
        )]
        public System.Boolean? IsArrayIntegrationEnabled { get; set; }
        
        // -------------------------------------------------------------------
        // InitiateInstantRecovery parameter set
        //
        // GraphQL operation: vsphereVMInitiateInstantRecovery(,   snapshotFid: UUID!,   vmName: String,   disableNetwork: Boolean,   removeNetworkDevices: Boolean,   powerOn: Boolean,   keepMacAddresses: Boolean,   hostID: String,   preserveMOID: Boolean,   vlan: Int,   shouldRecoverTags: Boolean, ):VsphereAsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "InitiateInstantRecovery",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: vsphereVMInitiateInstantRecovery(,   snapshotFid: UUID!,   vmName: String,   disableNetwork: Boolean,   removeNetworkDevices: Boolean,   powerOn: Boolean,   keepMacAddresses: Boolean,   hostID: String,   preserveMOID: Boolean,   vlan: Int,   shouldRecoverTags: Boolean, ):VsphereAsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter InitiateInstantRecovery { get; set; }

        [Parameter(
            ParameterSetName = "InitiateInstantRecovery",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument preserveMOID: Boolean
                "
        )]
        public System.Boolean? PreserveMoid { get; set; }
        [Parameter(
            ParameterSetName = "InitiateInstantRecovery",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument vlan: Int
                "
        )]
        public System.Int32? Vlan { get; set; }
        
        // -------------------------------------------------------------------
        // InitiateInstantRecoveryV2 parameter set
        //
        // GraphQL operation: vsphereVmInitiateInstantRecoveryV2(input: VsphereVmInitiateInstantRecoveryV2Input!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "InitiateInstantRecoveryV2",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Instantly recover a vSphere virtual machine from a snapshot or point-in-time.
                GraphQL operation: vsphereVmInitiateInstantRecoveryV2(input: VsphereVmInitiateInstantRecoveryV2Input!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter InitiateInstantRecoveryV2 { get; set; }

        
        // -------------------------------------------------------------------
        // InitiateBatchInstantRecovery parameter set
        //
        // GraphQL operation: vsphereVmInitiateBatchInstantRecovery(input: VsphereVmInitiateBatchInstantRecoveryInput!):BatchAsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "InitiateBatchInstantRecovery",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Initiate a mass instant recovery for a group of VMs.
                GraphQL operation: vsphereVmInitiateBatchInstantRecovery(input: VsphereVmInitiateBatchInstantRecoveryInput!):BatchAsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter InitiateBatchInstantRecovery { get; set; }

        
        // -------------------------------------------------------------------
        // InitiateDiskMount parameter set
        //
        // GraphQL operation: vsphereVmInitiateDiskMount(input: VsphereVmInitiateDiskMountInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "InitiateDiskMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Attaching disks from a snapshot to an existing virtual machine

Supported in v5.0+
Requests a snapshot mount to attach disks to an existing virtual machine.
                GraphQL operation: vsphereVmInitiateDiskMount(input: VsphereVmInitiateDiskMountInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter InitiateDiskMount { get; set; }

        
        // -------------------------------------------------------------------
        // InitiateLiveMount parameter set
        //
        // GraphQL operation: vsphereVMInitiateLiveMount(,   snapshotFid: UUID!,   vmName: String,   disableNetwork: Boolean,   removeNetworkDevices: Boolean,   powerOn: Boolean,   keepMacAddresses: Boolean,   hostID: String,   datastoreName: String,   createDatastoreOnly: Boolean,   vlan: Int,   shouldRecoverTags: Boolean, ):VsphereAsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "InitiateLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: vsphereVMInitiateLiveMount(,   snapshotFid: UUID!,   vmName: String,   disableNetwork: Boolean,   removeNetworkDevices: Boolean,   powerOn: Boolean,   keepMacAddresses: Boolean,   hostID: String,   datastoreName: String,   createDatastoreOnly: Boolean,   vlan: Int,   shouldRecoverTags: Boolean, ):VsphereAsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter InitiateLiveMount { get; set; }

        [Parameter(
            ParameterSetName = "InitiateLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument datastoreName: String
                "
        )]
        public System.String? DatastoreName { get; set; }
        [Parameter(
            ParameterSetName = "InitiateLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument createDatastoreOnly: Boolean
                "
        )]
        public System.Boolean? CreateDatastoreOnly { get; set; }
        
        // -------------------------------------------------------------------
        // InitiateLiveMountV2 parameter set
        //
        // GraphQL operation: vsphereVmInitiateLiveMountV2(input: VsphereVmInitiateLiveMountV2Input!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "InitiateLiveMountV2",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Create a vSphere Live Mount from a snapshot or point-in-time.
                GraphQL operation: vsphereVmInitiateLiveMountV2(input: VsphereVmInitiateLiveMountV2Input!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter InitiateLiveMountV2 { get; set; }

        
        // -------------------------------------------------------------------
        // BatchLiveMount parameter set
        //
        // GraphQL operation: vSphereVMBatchLiveMount(clusterUuid: UUID!, config: BatchMountSnapshotJobConfigInput!):BatchAsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "BatchLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: vSphereVMBatchLiveMount(clusterUuid: UUID!, config: BatchMountSnapshotJobConfigInput!):BatchAsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter BatchLiveMount { get; set; }

        [Parameter(
            ParameterSetName = "BatchLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument clusterUuid: UUID!
                "
        )]
        public System.String? ClusterUuid { get; set; }
        [Parameter(
            ParameterSetName = "BatchLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Configuration object containing an array of virtual machine IDs, a way to indicate the snapshot to be chosen and mount configs.
                GraphQL argument config: BatchMountSnapshotJobConfigInput!
                "
        )]
        public BatchMountSnapshotJobConfigInput? Config { get; set; }
        
        // -------------------------------------------------------------------
        // InitiateBatchLiveMountV2 parameter set
        //
        // GraphQL operation: vsphereVmInitiateBatchLiveMountV2(input: VsphereVmInitiateBatchLiveMountV2Input!):BatchAsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "InitiateBatchLiveMountV2",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Initiate a mass live mount for a group of VMs.
                GraphQL operation: vsphereVmInitiateBatchLiveMountV2(input: VsphereVmInitiateBatchLiveMountV2Input!):BatchAsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter InitiateBatchLiveMountV2 { get; set; }

        
        // -------------------------------------------------------------------
        // PowerOnOffLiveMount parameter set
        //
        // GraphQL operation: vsphereVmPowerOnOffLiveMount(input: VsphereVmPowerOnOffLiveMountInput!):VsphereVmPowerOnOffLiveMountReply!
        //
        [Parameter(
            ParameterSetName = "PowerOnOffLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Power a Live Mount on and off

Supported in v5.0+
Power a specified Live Mount virtual machine on or off. Pass **_true_** to power the virtual machine on and pass **_false_** to power the virtual machine off.
                GraphQL operation: vsphereVmPowerOnOffLiveMount(input: VsphereVmPowerOnOffLiveMountInput!):VsphereVmPowerOnOffLiveMountReply!
                ",
            Position = 0
        )]
        public SwitchParameter PowerOnOffLiveMount { get; set; }

        
        // -------------------------------------------------------------------
        // DeleteLiveMount parameter set
        //
        // GraphQL operation: vsphereVMDeleteLiveMount(livemountId: UUID!, force: Boolean):VsphereAsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "DeleteLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: vsphereVMDeleteLiveMount(livemountId: UUID!, force: Boolean):VsphereAsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter DeleteLiveMount { get; set; }

        [Parameter(
            ParameterSetName = "DeleteLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument livemountId: UUID!
                "
        )]
        public System.String? LivemountId { get; set; }
        [Parameter(
            ParameterSetName = "DeleteLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument force: Boolean
                "
        )]
        public System.Boolean? Force { get; set; }
        
        // -------------------------------------------------------------------
        // ListEsxiDatastore parameter set
        //
        // GraphQL operation: vsphereVmListEsxiDatastores(input: VsphereVmListEsxiDatastoresInput!):VsphereVmListEsxiDatastoresReply!
        //
        [Parameter(
            ParameterSetName = "ListEsxiDatastore",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                List ESXi datastores

Supported in v5.0+
Retrieve a list of the datastores for a specified ESXi host.
                GraphQL operation: vsphereVmListEsxiDatastores(input: VsphereVmListEsxiDatastoresInput!):VsphereVmListEsxiDatastoresReply!
                ",
            Position = 0
        )]
        public SwitchParameter ListEsxiDatastore { get; set; }

        
        // -------------------------------------------------------------------
        // ListEsXiDatastore parameter set
        //
        // GraphQL operation: vsphereVMListESXiDatastores(,   clusterUuid: UUID!,   ipAddress: String!,   username: String!,   password: String!, ):DatastoresListResponse!
        //
        [Parameter(
            ParameterSetName = "ListEsXiDatastore",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Retrieve a list of the datastores for a specified ESXi host
                GraphQL operation: vsphereVMListESXiDatastores(,   clusterUuid: UUID!,   ipAddress: String!,   username: String!,   password: String!, ):DatastoresListResponse!
                ",
            Position = 0
        )]
        public SwitchParameter ListEsXiDatastore { get; set; }

        [Parameter(
            ParameterSetName = "ListEsXiDatastore",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument ipAddress: String!
                "
        )]
        public System.String? IpAddress { get; set; }
        [Parameter(
            ParameterSetName = "ListEsXiDatastore",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument username: String!
                "
        )]
        public System.String? Username { get; set; }
        [Parameter(
            ParameterSetName = "ListEsXiDatastore",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument password: String!
                "
        )]
        public System.String? Password { get; set; }
        
        // -------------------------------------------------------------------
        // MountRelocate parameter set
        //
        // GraphQL operation: vsphereVmMountRelocate(input: VsphereVmMountRelocateInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "MountRelocate",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Relocate a virtual machine to another datastore

Supported in v5.0+
Run storage VMotion to relocate a specified Live Mount into another data store.
                GraphQL operation: vsphereVmMountRelocate(input: VsphereVmMountRelocateInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter MountRelocate { get; set; }

        
        // -------------------------------------------------------------------
        // MountRelocateV2 parameter set
        //
        // GraphQL operation: vsphereVmMountRelocateV2(input: VsphereVmMountRelocateV2Input!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "MountRelocateV2",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Create a Live Mount migration to a datastore or datastore cluster with virtual disk mapping support.
                GraphQL operation: vsphereVmMountRelocateV2(input: VsphereVmMountRelocateV2Input!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter MountRelocateV2 { get; set; }

        
        // -------------------------------------------------------------------
        // ExcludeVmDisk parameter set
        //
        // GraphQL operation: vsphereExcludeVmDisks(input: [VsphereExcludeVmDisksInput!]!):RequestSuccess!
        //
        [Parameter(
            ParameterSetName = "ExcludeVmDisk",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Exclude or include virtual disks during snapshot.
                GraphQL operation: vsphereExcludeVmDisks(input: [VsphereExcludeVmDisksInput!]!):RequestSuccess!
                ",
            Position = 0
        )]
        public SwitchParameter ExcludeVmDisk { get; set; }

        
        // -------------------------------------------------------------------
        // DownloadSnapshotFile parameter set
        //
        // GraphQL operation: vsphereVmDownloadSnapshotFiles(input: VsphereVmDownloadSnapshotFilesInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "DownloadSnapshotFile",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Download files from snapshot.
                GraphQL operation: vsphereVmDownloadSnapshotFiles(input: VsphereVmDownloadSnapshotFilesInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter DownloadSnapshotFile { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "RecoverFile":
                        this.ProcessRecord_RecoverFile();
                        break;
                    case "RecoverFilesNew":
                        this.ProcessRecord_RecoverFilesNew();
                        break;
                    case "RegisterAgent":
                        this.ProcessRecord_RegisterAgent();
                        break;
                    case "DownloadSnapshot":
                        this.ProcessRecord_DownloadSnapshot();
                        break;
                    case "ExportSnapshot":
                        this.ProcessRecord_ExportSnapshot();
                        break;
                    case "ExportSnapshotV2":
                        this.ProcessRecord_ExportSnapshotV2();
                        break;
                    case "ExportSnapshotV3":
                        this.ProcessRecord_ExportSnapshotV3();
                        break;
                    case "BatchExport":
                        this.ProcessRecord_BatchExport();
                        break;
                    case "BatchExportV3":
                        this.ProcessRecord_BatchExportV3();
                        break;
                    case "InitiateInPlaceRecovery":
                        this.ProcessRecord_InitiateInPlaceRecovery();
                        break;
                    case "ExportSnapshotWithDownloadFromCloud":
                        this.ProcessRecord_ExportSnapshotWithDownloadFromCloud();
                        break;
                    case "BatchInPlaceRecovery":
                        this.ProcessRecord_BatchInPlaceRecovery();
                        break;
                    case "DeleteSnapshot":
                        this.ProcessRecord_DeleteSnapshot();
                        break;
                    case "Update":
                        this.ProcessRecord_Update();
                        break;
                    case "InitiateInstantRecovery":
                        this.ProcessRecord_InitiateInstantRecovery();
                        break;
                    case "InitiateInstantRecoveryV2":
                        this.ProcessRecord_InitiateInstantRecoveryV2();
                        break;
                    case "InitiateBatchInstantRecovery":
                        this.ProcessRecord_InitiateBatchInstantRecovery();
                        break;
                    case "InitiateDiskMount":
                        this.ProcessRecord_InitiateDiskMount();
                        break;
                    case "InitiateLiveMount":
                        this.ProcessRecord_InitiateLiveMount();
                        break;
                    case "InitiateLiveMountV2":
                        this.ProcessRecord_InitiateLiveMountV2();
                        break;
                    case "BatchLiveMount":
                        this.ProcessRecord_BatchLiveMount();
                        break;
                    case "InitiateBatchLiveMountV2":
                        this.ProcessRecord_InitiateBatchLiveMountV2();
                        break;
                    case "PowerOnOffLiveMount":
                        this.ProcessRecord_PowerOnOffLiveMount();
                        break;
                    case "DeleteLiveMount":
                        this.ProcessRecord_DeleteLiveMount();
                        break;
                    case "ListEsxiDatastore":
                        this.ProcessRecord_ListEsxiDatastore();
                        break;
                    case "ListEsXiDatastore":
                        this.ProcessRecord_ListEsXiDatastore();
                        break;
                    case "MountRelocate":
                        this.ProcessRecord_MountRelocate();
                        break;
                    case "MountRelocateV2":
                        this.ProcessRecord_MountRelocateV2();
                        break;
                    case "ExcludeVmDisk":
                        this.ProcessRecord_ExcludeVmDisk();
                        break;
                    case "DownloadSnapshotFile":
                        this.ProcessRecord_DownloadSnapshotFile();
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
                    "Invoke-RscMutateVsphereVm",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
           }
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmRecoverFiles.
        protected void ProcessRecord_RecoverFile()
        {
            this._logger.name += " -RecoverFile";
            // Invoke graphql operation vsphereVmRecoverFiles
            InvokeMutationVsphereVmRecoverFiles();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmRecoverFilesNew.
        protected void ProcessRecord_RecoverFilesNew()
        {
            this._logger.name += " -RecoverFilesNew";
            // Invoke graphql operation vsphereVmRecoverFilesNew
            InvokeMutationVsphereVmRecoverFilesNew();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmRegisterAgent.
        protected void ProcessRecord_RegisterAgent()
        {
            this._logger.name += " -RegisterAgent";
            // Invoke graphql operation vsphereVmRegisterAgent
            InvokeMutationVsphereVmRegisterAgent();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmDownloadSnapshot.
        protected void ProcessRecord_DownloadSnapshot()
        {
            this._logger.name += " -DownloadSnapshot";
            // Invoke graphql operation vsphereVmDownloadSnapshot
            InvokeMutationVsphereVmDownloadSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVMExportSnapshot.
        protected void ProcessRecord_ExportSnapshot()
        {
            this._logger.name += " -ExportSnapshot";
            // Invoke graphql operation vsphereVMExportSnapshot
            InvokeMutationVsphereVmExportSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmExportSnapshotV2.
        protected void ProcessRecord_ExportSnapshotV2()
        {
            this._logger.name += " -ExportSnapshotV2";
            // Invoke graphql operation vsphereVmExportSnapshotV2
            InvokeMutationVsphereVmExportSnapshotV2();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmExportSnapshotV3.
        protected void ProcessRecord_ExportSnapshotV3()
        {
            this._logger.name += " -ExportSnapshotV3";
            // Invoke graphql operation vsphereVmExportSnapshotV3
            InvokeMutationVsphereVmExportSnapshotV3();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmBatchExport.
        protected void ProcessRecord_BatchExport()
        {
            this._logger.name += " -BatchExport";
            // Invoke graphql operation vsphereVmBatchExport
            InvokeMutationVsphereVmBatchExport();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmBatchExportV3.
        protected void ProcessRecord_BatchExportV3()
        {
            this._logger.name += " -BatchExportV3";
            // Invoke graphql operation vsphereVmBatchExportV3
            InvokeMutationVsphereVmBatchExportV3();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmInitiateInPlaceRecovery.
        protected void ProcessRecord_InitiateInPlaceRecovery()
        {
            this._logger.name += " -InitiateInPlaceRecovery";
            // Invoke graphql operation vsphereVmInitiateInPlaceRecovery
            InvokeMutationVsphereVmInitiateInPlaceRecovery();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmExportSnapshotWithDownloadFromCloud.
        protected void ProcessRecord_ExportSnapshotWithDownloadFromCloud()
        {
            this._logger.name += " -ExportSnapshotWithDownloadFromCloud";
            // Invoke graphql operation vsphereVmExportSnapshotWithDownloadFromCloud
            InvokeMutationVsphereVmExportSnapshotWithDownloadFromCloud();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmBatchInPlaceRecovery.
        protected void ProcessRecord_BatchInPlaceRecovery()
        {
            this._logger.name += " -BatchInPlaceRecovery";
            // Invoke graphql operation vsphereVmBatchInPlaceRecovery
            InvokeMutationVsphereVmBatchInPlaceRecovery();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmDeleteSnapshot.
        protected void ProcessRecord_DeleteSnapshot()
        {
            this._logger.name += " -DeleteSnapshot";
            // Invoke graphql operation vsphereVmDeleteSnapshot
            InvokeMutationVsphereVmDeleteSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVMUpdate.
        protected void ProcessRecord_Update()
        {
            this._logger.name += " -Update";
            // Invoke graphql operation vsphereVMUpdate
            InvokeMutationVsphereVmUpdate();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVMInitiateInstantRecovery.
        protected void ProcessRecord_InitiateInstantRecovery()
        {
            this._logger.name += " -InitiateInstantRecovery";
            // Invoke graphql operation vsphereVMInitiateInstantRecovery
            InvokeMutationVsphereVmInitiateInstantRecovery();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmInitiateInstantRecoveryV2.
        protected void ProcessRecord_InitiateInstantRecoveryV2()
        {
            this._logger.name += " -InitiateInstantRecoveryV2";
            // Invoke graphql operation vsphereVmInitiateInstantRecoveryV2
            InvokeMutationVsphereVmInitiateInstantRecoveryV2();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmInitiateBatchInstantRecovery.
        protected void ProcessRecord_InitiateBatchInstantRecovery()
        {
            this._logger.name += " -InitiateBatchInstantRecovery";
            // Invoke graphql operation vsphereVmInitiateBatchInstantRecovery
            InvokeMutationVsphereVmInitiateBatchInstantRecovery();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmInitiateDiskMount.
        protected void ProcessRecord_InitiateDiskMount()
        {
            this._logger.name += " -InitiateDiskMount";
            // Invoke graphql operation vsphereVmInitiateDiskMount
            InvokeMutationVsphereVmInitiateDiskMount();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVMInitiateLiveMount.
        protected void ProcessRecord_InitiateLiveMount()
        {
            this._logger.name += " -InitiateLiveMount";
            // Invoke graphql operation vsphereVMInitiateLiveMount
            InvokeMutationVsphereVmInitiateLiveMount();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmInitiateLiveMountV2.
        protected void ProcessRecord_InitiateLiveMountV2()
        {
            this._logger.name += " -InitiateLiveMountV2";
            // Invoke graphql operation vsphereVmInitiateLiveMountV2
            InvokeMutationVsphereVmInitiateLiveMountV2();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereVMBatchLiveMount.
        protected void ProcessRecord_BatchLiveMount()
        {
            this._logger.name += " -BatchLiveMount";
            // Invoke graphql operation vSphereVMBatchLiveMount
            InvokeMutationVsphereVmBatchLiveMount();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmInitiateBatchLiveMountV2.
        protected void ProcessRecord_InitiateBatchLiveMountV2()
        {
            this._logger.name += " -InitiateBatchLiveMountV2";
            // Invoke graphql operation vsphereVmInitiateBatchLiveMountV2
            InvokeMutationVsphereVmInitiateBatchLiveMountV2();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmPowerOnOffLiveMount.
        protected void ProcessRecord_PowerOnOffLiveMount()
        {
            this._logger.name += " -PowerOnOffLiveMount";
            // Invoke graphql operation vsphereVmPowerOnOffLiveMount
            InvokeMutationVsphereVmPowerOnOffLiveMount();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVMDeleteLiveMount.
        protected void ProcessRecord_DeleteLiveMount()
        {
            this._logger.name += " -DeleteLiveMount";
            // Invoke graphql operation vsphereVMDeleteLiveMount
            InvokeMutationVsphereVmDeleteLiveMount();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmListEsxiDatastores.
        protected void ProcessRecord_ListEsxiDatastore()
        {
            this._logger.name += " -ListEsxiDatastore";
            // Invoke graphql operation vsphereVmListEsxiDatastores
            InvokeMutationVsphereVmListEsxiDatastores();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVMListESXiDatastores.
        protected void ProcessRecord_ListEsXiDatastore()
        {
            this._logger.name += " -ListEsXiDatastore";
            // Invoke graphql operation vsphereVMListESXiDatastores
            InvokeMutationVsphereVmListEsXiDatastores();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmMountRelocate.
        protected void ProcessRecord_MountRelocate()
        {
            this._logger.name += " -MountRelocate";
            // Invoke graphql operation vsphereVmMountRelocate
            InvokeMutationVsphereVmMountRelocate();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmMountRelocateV2.
        protected void ProcessRecord_MountRelocateV2()
        {
            this._logger.name += " -MountRelocateV2";
            // Invoke graphql operation vsphereVmMountRelocateV2
            InvokeMutationVsphereVmMountRelocateV2();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereExcludeVmDisks.
        protected void ProcessRecord_ExcludeVmDisk()
        {
            this._logger.name += " -ExcludeVmDisk";
            // Invoke graphql operation vsphereExcludeVmDisks
            InvokeMutationVsphereExcludeVmDisks();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmDownloadSnapshotFiles.
        protected void ProcessRecord_DownloadSnapshotFile()
        {
            this._logger.name += " -DownloadSnapshotFile";
            // Invoke graphql operation vsphereVmDownloadSnapshotFiles
            InvokeMutationVsphereVmDownloadSnapshotFiles();
        }


        // Invoke GraphQL Mutation:
        // vsphereVmRecoverFiles(input: VsphereVmRecoverFilesInput!): VsphereAsyncRequestStatus!
        protected void InvokeMutationVsphereVmRecoverFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmRecoverFilesInput!"),
            };
            VsphereAsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VsphereAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (VsphereAsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereVmRecoverFiles(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmRecoverFiles");
            var parameters = "($input: VsphereVmRecoverFilesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmRecoverFiles" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmRecoverFiles",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VsphereAsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // vsphereVmRecoverFilesNew(input: VsphereVmRecoverFilesNewInput!): AsyncRequestStatus!
        protected void InvokeMutationVsphereVmRecoverFilesNew()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmRecoverFilesNewInput!"),
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
            string document = Mutation.VsphereVmRecoverFilesNew(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmRecoverFilesNew");
            var parameters = "($input: VsphereVmRecoverFilesNewInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmRecoverFilesNew" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmRecoverFilesNew",
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
        // vsphereVmRegisterAgent(input: VsphereVmRegisterAgentInput!): RequestSuccess!
        protected void InvokeMutationVsphereVmRegisterAgent()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmRegisterAgentInput!"),
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
            string document = Mutation.VsphereVmRegisterAgent(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmRegisterAgent");
            var parameters = "($input: VsphereVmRegisterAgentInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmRegisterAgent" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmRegisterAgent",
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
        // vsphereVmDownloadSnapshot(input: VsphereVmDownloadSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationVsphereVmDownloadSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmDownloadSnapshotInput!"),
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
            string document = Mutation.VsphereVmDownloadSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmDownloadSnapshot");
            var parameters = "($input: VsphereVmDownloadSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmDownloadSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmDownloadSnapshot",
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
        // vsphereVMExportSnapshot(
        //     snapshotFid: UUID!
        //     vmName: String
        //     disableNetwork: Boolean
        //     removeNetworkDevices: Boolean
        //     powerOn: Boolean
        //     keepMacAddresses: Boolean
        //     hostID: String
        //     datastoreId: UUID!
        //     unregsiterVm: Boolean
        //     shouldRecoverTags: Boolean
        //   ): VsphereAsyncRequestStatus!
        protected void InvokeMutationVsphereVmExportSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snapshotFid", "UUID!"),
                Tuple.Create("vmName", "String"),
                Tuple.Create("disableNetwork", "Boolean"),
                Tuple.Create("removeNetworkDevices", "Boolean"),
                Tuple.Create("powerOn", "Boolean"),
                Tuple.Create("keepMacAddresses", "Boolean"),
                Tuple.Create("hostID", "String"),
                Tuple.Create("datastoreId", "UUID!"),
                Tuple.Create("unregsiterVm", "Boolean"),
                Tuple.Create("shouldRecoverTags", "Boolean"),
            };
            VsphereAsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VsphereAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (VsphereAsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereVmExportSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmExportSnapshot");
            var parameters = "($snapshotFid: UUID!,$vmName: String,$disableNetwork: Boolean,$removeNetworkDevices: Boolean,$powerOn: Boolean,$keepMacAddresses: Boolean,$hostID: String,$datastoreId: UUID!,$unregsiterVm: Boolean,$shouldRecoverTags: Boolean)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmExportSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmExportSnapshot",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VsphereAsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // vsphereVmExportSnapshotV2(input: VsphereVmExportSnapshotV2Input!): AsyncRequestStatus!
        protected void InvokeMutationVsphereVmExportSnapshotV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmExportSnapshotV2Input!"),
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
            string document = Mutation.VsphereVmExportSnapshotV2(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmExportSnapshotV2");
            var parameters = "($input: VsphereVmExportSnapshotV2Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmExportSnapshotV2" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmExportSnapshotV2",
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
        // vsphereVmExportSnapshotV3(input: VsphereVmExportSnapshotV3Input!): AsyncRequestStatus!
        protected void InvokeMutationVsphereVmExportSnapshotV3()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmExportSnapshotV3Input!"),
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
            string document = Mutation.VsphereVmExportSnapshotV3(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmExportSnapshotV3");
            var parameters = "($input: VsphereVmExportSnapshotV3Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmExportSnapshotV3" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmExportSnapshotV3",
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
        // vsphereVmBatchExport(input: VsphereVmBatchExportInput!): BatchAsyncRequestStatus!
        protected void InvokeMutationVsphereVmBatchExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmBatchExportInput!"),
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
            string document = Mutation.VsphereVmBatchExport(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmBatchExport");
            var parameters = "($input: VsphereVmBatchExportInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmBatchExport" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmBatchExport",
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
        // vsphereVmBatchExportV3(input: VsphereVmBatchExportV3Input!): BatchAsyncRequestStatus!
        protected void InvokeMutationVsphereVmBatchExportV3()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmBatchExportV3Input!"),
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
            string document = Mutation.VsphereVmBatchExportV3(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmBatchExportV3");
            var parameters = "($input: VsphereVmBatchExportV3Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmBatchExportV3" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmBatchExportV3",
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
        // vsphereVmInitiateInPlaceRecovery(input: VsphereVmInitiateInPlaceRecoveryInput!): AsyncRequestStatus!
        protected void InvokeMutationVsphereVmInitiateInPlaceRecovery()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmInitiateInPlaceRecoveryInput!"),
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
            string document = Mutation.VsphereVmInitiateInPlaceRecovery(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmInitiateInPlaceRecovery");
            var parameters = "($input: VsphereVmInitiateInPlaceRecoveryInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmInitiateInPlaceRecovery" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmInitiateInPlaceRecovery",
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
        // vsphereVmExportSnapshotWithDownloadFromCloud(input: VsphereVmExportSnapshotWithDownloadFromCloudInput!): AsyncRequestStatus!
        protected void InvokeMutationVsphereVmExportSnapshotWithDownloadFromCloud()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmExportSnapshotWithDownloadFromCloudInput!"),
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
            string document = Mutation.VsphereVmExportSnapshotWithDownloadFromCloud(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmExportSnapshotWithDownloadFromCloud");
            var parameters = "($input: VsphereVmExportSnapshotWithDownloadFromCloudInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmExportSnapshotWithDownloadFromCloud" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmExportSnapshotWithDownloadFromCloud",
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
        // vsphereVmBatchInPlaceRecovery(input: VsphereVmBatchInPlaceRecoveryInput!): BatchAsyncRequestStatus!
        protected void InvokeMutationVsphereVmBatchInPlaceRecovery()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmBatchInPlaceRecoveryInput!"),
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
            string document = Mutation.VsphereVmBatchInPlaceRecovery(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmBatchInPlaceRecovery");
            var parameters = "($input: VsphereVmBatchInPlaceRecoveryInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmBatchInPlaceRecovery" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmBatchInPlaceRecovery",
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
        // vsphereVmDeleteSnapshot(input: VsphereVmDeleteSnapshotInput!): Void
        protected void InvokeMutationVsphereVmDeleteSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmDeleteSnapshotInput!"),
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
            string document = Mutation.VsphereVmDeleteSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmDeleteSnapshot");
            var parameters = "($input: VsphereVmDeleteSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmDeleteSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmDeleteSnapshot",
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
        // vsphereVMUpdate(
        //     snappableFid: UUID!
        //     snapshotConsistencyMandate: String
        //     preBackupScript: PreBackupScriptInputType
        //     postBackupScript: PostBackupScriptInputType
        //     postSnapScript: PostSnapScriptInputType
        //     isArrayIntegrationEnabled: Boolean
        //   ): RequestSuccess!
        protected void InvokeMutationVsphereVmUpdate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("snapshotConsistencyMandate", "String"),
                Tuple.Create("preBackupScript", "PreBackupScriptInputType"),
                Tuple.Create("postBackupScript", "PostBackupScriptInputType"),
                Tuple.Create("postSnapScript", "PostSnapScriptInputType"),
                Tuple.Create("isArrayIntegrationEnabled", "Boolean"),
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
            string document = Mutation.VsphereVmUpdate(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmUpdate");
            var parameters = "($snappableFid: UUID!,$snapshotConsistencyMandate: String,$preBackupScript: PreBackupScriptInputType,$postBackupScript: PostBackupScriptInputType,$postSnapScript: PostSnapScriptInputType,$isArrayIntegrationEnabled: Boolean)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmUpdate" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmUpdate",
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
        // vsphereVMInitiateInstantRecovery(
        //     snapshotFid: UUID!
        //     vmName: String
        //     disableNetwork: Boolean
        //     removeNetworkDevices: Boolean
        //     powerOn: Boolean
        //     keepMacAddresses: Boolean
        //     hostID: String
        //     preserveMOID: Boolean
        //     vlan: Int
        //     shouldRecoverTags: Boolean
        //   ): VsphereAsyncRequestStatus!
        protected void InvokeMutationVsphereVmInitiateInstantRecovery()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snapshotFid", "UUID!"),
                Tuple.Create("vmName", "String"),
                Tuple.Create("disableNetwork", "Boolean"),
                Tuple.Create("removeNetworkDevices", "Boolean"),
                Tuple.Create("powerOn", "Boolean"),
                Tuple.Create("keepMacAddresses", "Boolean"),
                Tuple.Create("hostID", "String"),
                Tuple.Create("preserveMOID", "Boolean"),
                Tuple.Create("vlan", "Int"),
                Tuple.Create("shouldRecoverTags", "Boolean"),
            };
            VsphereAsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VsphereAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (VsphereAsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereVmInitiateInstantRecovery(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmInitiateInstantRecovery");
            var parameters = "($snapshotFid: UUID!,$vmName: String,$disableNetwork: Boolean,$removeNetworkDevices: Boolean,$powerOn: Boolean,$keepMacAddresses: Boolean,$hostID: String,$preserveMOID: Boolean,$vlan: Int,$shouldRecoverTags: Boolean)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmInitiateInstantRecovery" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmInitiateInstantRecovery",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VsphereAsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // vsphereVmInitiateInstantRecoveryV2(input: VsphereVmInitiateInstantRecoveryV2Input!): AsyncRequestStatus!
        protected void InvokeMutationVsphereVmInitiateInstantRecoveryV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmInitiateInstantRecoveryV2Input!"),
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
            string document = Mutation.VsphereVmInitiateInstantRecoveryV2(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmInitiateInstantRecoveryV2");
            var parameters = "($input: VsphereVmInitiateInstantRecoveryV2Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmInitiateInstantRecoveryV2" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmInitiateInstantRecoveryV2",
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
        // vsphereVmInitiateBatchInstantRecovery(input: VsphereVmInitiateBatchInstantRecoveryInput!): BatchAsyncRequestStatus!
        protected void InvokeMutationVsphereVmInitiateBatchInstantRecovery()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmInitiateBatchInstantRecoveryInput!"),
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
            string document = Mutation.VsphereVmInitiateBatchInstantRecovery(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmInitiateBatchInstantRecovery");
            var parameters = "($input: VsphereVmInitiateBatchInstantRecoveryInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmInitiateBatchInstantRecovery" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmInitiateBatchInstantRecovery",
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
        // vsphereVmInitiateDiskMount(input: VsphereVmInitiateDiskMountInput!): AsyncRequestStatus!
        protected void InvokeMutationVsphereVmInitiateDiskMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmInitiateDiskMountInput!"),
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
            string document = Mutation.VsphereVmInitiateDiskMount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmInitiateDiskMount");
            var parameters = "($input: VsphereVmInitiateDiskMountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmInitiateDiskMount" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmInitiateDiskMount",
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
        // vsphereVMInitiateLiveMount(
        //     snapshotFid: UUID!
        //     vmName: String
        //     disableNetwork: Boolean
        //     removeNetworkDevices: Boolean
        //     powerOn: Boolean
        //     keepMacAddresses: Boolean
        //     hostID: String
        //     datastoreName: String
        //     createDatastoreOnly: Boolean
        //     vlan: Int
        //     shouldRecoverTags: Boolean
        //   ): VsphereAsyncRequestStatus!
        protected void InvokeMutationVsphereVmInitiateLiveMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snapshotFid", "UUID!"),
                Tuple.Create("vmName", "String"),
                Tuple.Create("disableNetwork", "Boolean"),
                Tuple.Create("removeNetworkDevices", "Boolean"),
                Tuple.Create("powerOn", "Boolean"),
                Tuple.Create("keepMacAddresses", "Boolean"),
                Tuple.Create("hostID", "String"),
                Tuple.Create("datastoreName", "String"),
                Tuple.Create("createDatastoreOnly", "Boolean"),
                Tuple.Create("vlan", "Int"),
                Tuple.Create("shouldRecoverTags", "Boolean"),
            };
            VsphereAsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VsphereAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (VsphereAsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereVmInitiateLiveMount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmInitiateLiveMount");
            var parameters = "($snapshotFid: UUID!,$vmName: String,$disableNetwork: Boolean,$removeNetworkDevices: Boolean,$powerOn: Boolean,$keepMacAddresses: Boolean,$hostID: String,$datastoreName: String,$createDatastoreOnly: Boolean,$vlan: Int,$shouldRecoverTags: Boolean)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmInitiateLiveMount" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmInitiateLiveMount",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VsphereAsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // vsphereVmInitiateLiveMountV2(input: VsphereVmInitiateLiveMountV2Input!): AsyncRequestStatus!
        protected void InvokeMutationVsphereVmInitiateLiveMountV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmInitiateLiveMountV2Input!"),
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
            string document = Mutation.VsphereVmInitiateLiveMountV2(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmInitiateLiveMountV2");
            var parameters = "($input: VsphereVmInitiateLiveMountV2Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmInitiateLiveMountV2" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmInitiateLiveMountV2",
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
        // vSphereVMBatchLiveMount(clusterUuid: UUID!, config: BatchMountSnapshotJobConfigInput!): BatchAsyncRequestStatus!
        protected void InvokeMutationVsphereVmBatchLiveMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
                Tuple.Create("config", "BatchMountSnapshotJobConfigInput!"),
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
            string document = Mutation.VsphereVmBatchLiveMount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmBatchLiveMount");
            var parameters = "($clusterUuid: UUID!,$config: BatchMountSnapshotJobConfigInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmBatchLiveMount" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmBatchLiveMount",
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
        // vsphereVmInitiateBatchLiveMountV2(input: VsphereVmInitiateBatchLiveMountV2Input!): BatchAsyncRequestStatus!
        protected void InvokeMutationVsphereVmInitiateBatchLiveMountV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmInitiateBatchLiveMountV2Input!"),
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
            string document = Mutation.VsphereVmInitiateBatchLiveMountV2(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmInitiateBatchLiveMountV2");
            var parameters = "($input: VsphereVmInitiateBatchLiveMountV2Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmInitiateBatchLiveMountV2" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmInitiateBatchLiveMountV2",
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
        // vsphereVmPowerOnOffLiveMount(input: VsphereVmPowerOnOffLiveMountInput!): VsphereVmPowerOnOffLiveMountReply!
        protected void InvokeMutationVsphereVmPowerOnOffLiveMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmPowerOnOffLiveMountInput!"),
            };
            VsphereVmPowerOnOffLiveMountReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VsphereVmPowerOnOffLiveMountReply)psObject.BaseObject;
                } else {
                    fields = (VsphereVmPowerOnOffLiveMountReply)this.Field;
                }
            }
            string document = Mutation.VsphereVmPowerOnOffLiveMount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmPowerOnOffLiveMount");
            var parameters = "($input: VsphereVmPowerOnOffLiveMountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmPowerOnOffLiveMount" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmPowerOnOffLiveMount",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VsphereVmPowerOnOffLiveMountReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // vsphereVMDeleteLiveMount(livemountId: UUID!, force: Boolean): VsphereAsyncRequestStatus!
        protected void InvokeMutationVsphereVmDeleteLiveMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("livemountId", "UUID!"),
                Tuple.Create("force", "Boolean"),
            };
            VsphereAsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VsphereAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (VsphereAsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereVmDeleteLiveMount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmDeleteLiveMount");
            var parameters = "($livemountId: UUID!,$force: Boolean)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmDeleteLiveMount" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmDeleteLiveMount",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VsphereAsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // vsphereVmListEsxiDatastores(input: VsphereVmListEsxiDatastoresInput!): VsphereVmListEsxiDatastoresReply!
        protected void InvokeMutationVsphereVmListEsxiDatastores()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmListEsxiDatastoresInput!"),
            };
            VsphereVmListEsxiDatastoresReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VsphereVmListEsxiDatastoresReply)psObject.BaseObject;
                } else {
                    fields = (VsphereVmListEsxiDatastoresReply)this.Field;
                }
            }
            string document = Mutation.VsphereVmListEsxiDatastores(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmListEsxiDatastores");
            var parameters = "($input: VsphereVmListEsxiDatastoresInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmListEsxiDatastores" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmListEsxiDatastores",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VsphereVmListEsxiDatastoresReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // vsphereVMListESXiDatastores(
        //     clusterUuid: UUID!
        //     ipAddress: String!
        //     username: String!
        //     password: String!
        //   ): DatastoresListResponse!
        protected void InvokeMutationVsphereVmListEsXiDatastores()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
                Tuple.Create("ipAddress", "String!"),
                Tuple.Create("username", "String!"),
                Tuple.Create("password", "String!"),
            };
            DatastoresListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (DatastoresListResponse)psObject.BaseObject;
                } else {
                    fields = (DatastoresListResponse)this.Field;
                }
            }
            string document = Mutation.VsphereVmListEsXiDatastores(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmListEsXiDatastores");
            var parameters = "($clusterUuid: UUID!,$ipAddress: String!,$username: String!,$password: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmListEsXiDatastores" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmListEsXiDatastores",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "DatastoresListResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // vsphereVmMountRelocate(input: VsphereVmMountRelocateInput!): AsyncRequestStatus!
        protected void InvokeMutationVsphereVmMountRelocate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmMountRelocateInput!"),
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
            string document = Mutation.VsphereVmMountRelocate(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmMountRelocate");
            var parameters = "($input: VsphereVmMountRelocateInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmMountRelocate" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmMountRelocate",
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
        // vsphereVmMountRelocateV2(input: VsphereVmMountRelocateV2Input!): AsyncRequestStatus!
        protected void InvokeMutationVsphereVmMountRelocateV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmMountRelocateV2Input!"),
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
            string document = Mutation.VsphereVmMountRelocateV2(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmMountRelocateV2");
            var parameters = "($input: VsphereVmMountRelocateV2Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmMountRelocateV2" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmMountRelocateV2",
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
        // vsphereExcludeVmDisks(input: [VsphereExcludeVmDisksInput!]!): RequestSuccess!
        protected void InvokeMutationVsphereExcludeVmDisks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "[VsphereExcludeVmDisksInput!]!"),
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
            string document = Mutation.VsphereExcludeVmDisks(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereExcludeVmDisks");
            var parameters = "($input: [VsphereExcludeVmDisksInput!]!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereExcludeVmDisks" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereExcludeVmDisks",
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
        // vsphereVmDownloadSnapshotFiles(input: VsphereVmDownloadSnapshotFilesInput!): AsyncRequestStatus!
        protected void InvokeMutationVsphereVmDownloadSnapshotFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmDownloadSnapshotFilesInput!"),
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
            string document = Mutation.VsphereVmDownloadSnapshotFiles(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmDownloadSnapshotFiles");
            var parameters = "($input: VsphereVmDownloadSnapshotFilesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmDownloadSnapshotFiles" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmDownloadSnapshotFiles",
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


    } // class Invoke_RscMutateVsphereVm
}