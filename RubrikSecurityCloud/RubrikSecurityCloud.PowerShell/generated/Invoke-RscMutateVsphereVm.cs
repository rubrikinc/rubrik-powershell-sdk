// Invoke-RscMutateVsphereVm.cs
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
        "RscMutateVsphereVm",
        DefaultParameterSetName = "Update")
    ]
    public class Invoke_RscMutateVsphereVm : RscPSCmdlet
    {
        
        /// <summary>
        /// RecoverFiles parameter set
        ///
        /// [GraphQL: vsphereVmRecoverFiles]
        /// </summary>
        [Parameter(
            ParameterSetName = "RecoverFiles",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Restores multiple files/directories from snapshot.
[GraphQL: vsphereVmRecoverFiles]",
            Position = 0
        )]
        public SwitchParameter RecoverFiles { get; set; }

        
        /// <summary>
        /// RecoverFilesNew parameter set
        ///
        /// [GraphQL: vsphereVmRecoverFilesNew]
        /// </summary>
        [Parameter(
            ParameterSetName = "RecoverFilesNew",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Restores multiple files/directories from snapshot.
[GraphQL: vsphereVmRecoverFilesNew]",
            Position = 0
        )]
        public SwitchParameter RecoverFilesNew { get; set; }

        
        /// <summary>
        /// RegisterAgent parameter set
        ///
        /// [GraphQL: vsphereVmRegisterAgent]
        /// </summary>
        [Parameter(
            ParameterSetName = "RegisterAgent",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Register Rubrik Backup Service

Supported in v5.0+
Register the Rubrik Backup Service that is running on a specified host with the specified Rubrik cluster.
[GraphQL: vsphereVmRegisterAgent]",
            Position = 0
        )]
        public SwitchParameter RegisterAgent { get; set; }

        
        /// <summary>
        /// DownloadSnapshot parameter set
        ///
        /// [GraphQL: vsphereVmDownloadSnapshot]
        /// </summary>
        [Parameter(
            ParameterSetName = "DownloadSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Download snapshot from archive

Supported in v5.0+
Provides a method for retrieving a snapshot, that is not available locally, from an archival location.
[GraphQL: vsphereVmDownloadSnapshot]",
            Position = 0
        )]
        public SwitchParameter DownloadSnapshot { get; set; }

        
        /// <summary>
        /// ExportSnapshot parameter set
        ///
        /// [GraphQL: vsphereVMExportSnapshot]
        /// </summary>
        [Parameter(
            ParameterSetName = "ExportSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vsphereVMExportSnapshot]",
            Position = 0
        )]
        public SwitchParameter ExportSnapshot { get; set; }

        
        /// <summary>
        /// ExportSnapshotV2 parameter set
        ///
        /// [GraphQL: vsphereVmExportSnapshotV2]
        /// </summary>
        [Parameter(
            ParameterSetName = "ExportSnapshotV2",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a vSphere Export from a snapshot or a point-in-time.
[GraphQL: vsphereVmExportSnapshotV2]",
            Position = 0
        )]
        public SwitchParameter ExportSnapshotV2 { get; set; }

        
        /// <summary>
        /// ExportSnapshotV3 parameter set
        ///
        /// [GraphQL: vsphereVmExportSnapshotV3]
        /// </summary>
        [Parameter(
            ParameterSetName = "ExportSnapshotV3",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a vSphere Export from a snapshot or a point-in-time with datastore cluster and virtual disk mapping support.
[GraphQL: vsphereVmExportSnapshotV3]",
            Position = 0
        )]
        public SwitchParameter ExportSnapshotV3 { get; set; }

        
        /// <summary>
        /// BatchExport parameter set
        ///
        /// [GraphQL: vsphereVmBatchExport]
        /// </summary>
        [Parameter(
            ParameterSetName = "BatchExport",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mass export for a group of virtual machines.
[GraphQL: vsphereVmBatchExport]",
            Position = 0
        )]
        public SwitchParameter BatchExport { get; set; }

        
        /// <summary>
        /// BatchExportV3 parameter set
        ///
        /// [GraphQL: vsphereVmBatchExportV3]
        /// </summary>
        [Parameter(
            ParameterSetName = "BatchExportV3",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a batch export for a group of virtual machines with datastore cluster support.
[GraphQL: vsphereVmBatchExportV3]",
            Position = 0
        )]
        public SwitchParameter BatchExportV3 { get; set; }

        
        /// <summary>
        /// InitiateInPlaceRecovery parameter set
        ///
        /// [GraphQL: vsphereVmInitiateInPlaceRecovery]
        /// </summary>
        [Parameter(
            ParameterSetName = "InitiateInPlaceRecovery",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Trigger an in-place recovery from a snapshot or point-in-time.
[GraphQL: vsphereVmInitiateInPlaceRecovery]",
            Position = 0
        )]
        public SwitchParameter InitiateInPlaceRecovery { get; set; }

        
        /// <summary>
        /// ExportSnapshotWithDownloadFromCloud parameter set
        ///
        /// [GraphQL: vsphereVmExportSnapshotWithDownloadFromCloud]
        /// </summary>
        [Parameter(
            ParameterSetName = "ExportSnapshotWithDownloadFromCloud",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Download a snapshot from an archival location, then export a virtual machine using the downloaded snapshot

Supported in v5.3+
Download a snapshot from an archival location and then export a virtual machine using the downloaded snapshot.
[GraphQL: vsphereVmExportSnapshotWithDownloadFromCloud]",
            Position = 0
        )]
        public SwitchParameter ExportSnapshotWithDownloadFromCloud { get; set; }

        
        /// <summary>
        /// BatchInPlaceRecovery parameter set
        ///
        /// [GraphQL: vsphereVmBatchInPlaceRecovery]
        /// </summary>
        [Parameter(
            ParameterSetName = "BatchInPlaceRecovery",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Supported in v6.0+. Export a snapshot each from a set of virtual machines.
[GraphQL: vsphereVmBatchInPlaceRecovery]",
            Position = 0
        )]
        public SwitchParameter BatchInPlaceRecovery { get; set; }

        
        /// <summary>
        /// DeleteSnapshot parameter set
        ///
        /// [GraphQL: vsphereVmDeleteSnapshot]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Designate a snapshot as expired and available for garbage collection. The snapshot must be an on-demand snapshot or a snapshot from a virtual machine that is not assigned to an SLA Domain.
[GraphQL: vsphereVmDeleteSnapshot]",
            Position = 0
        )]
        public SwitchParameter DeleteSnapshot { get; set; }

        
        /// <summary>
        /// Update parameter set
        ///
        /// [GraphQL: vsphereVMUpdate]
        /// </summary>
        [Parameter(
            ParameterSetName = "Update",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vsphereVMUpdate]",
            Position = 0
        )]
        public SwitchParameter Update { get; set; }

        
        /// <summary>
        /// InitiateInstantRecovery parameter set
        ///
        /// [GraphQL: vsphereVMInitiateInstantRecovery]
        /// </summary>
        [Parameter(
            ParameterSetName = "InitiateInstantRecovery",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vsphereVMInitiateInstantRecovery]",
            Position = 0
        )]
        public SwitchParameter InitiateInstantRecovery { get; set; }

        
        /// <summary>
        /// InitiateInstantRecoveryV2 parameter set
        ///
        /// [GraphQL: vsphereVmInitiateInstantRecoveryV2]
        /// </summary>
        [Parameter(
            ParameterSetName = "InitiateInstantRecoveryV2",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Instantly recover a vSphere virtual machine from a snapshot or point-in-time.
[GraphQL: vsphereVmInitiateInstantRecoveryV2]",
            Position = 0
        )]
        public SwitchParameter InitiateInstantRecoveryV2 { get; set; }

        
        /// <summary>
        /// InitiateBatchInstantRecovery parameter set
        ///
        /// [GraphQL: vsphereVmInitiateBatchInstantRecovery]
        /// </summary>
        [Parameter(
            ParameterSetName = "InitiateBatchInstantRecovery",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Initiate a mass instant recovery for a group of VMs.
[GraphQL: vsphereVmInitiateBatchInstantRecovery]",
            Position = 0
        )]
        public SwitchParameter InitiateBatchInstantRecovery { get; set; }

        
        /// <summary>
        /// InitiateDiskMount parameter set
        ///
        /// [GraphQL: vsphereVmInitiateDiskMount]
        /// </summary>
        [Parameter(
            ParameterSetName = "InitiateDiskMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Attaching disks from a snapshot to an existing virtual machine

Supported in v5.0+
Requests a snapshot mount to attach disks to an existing virtual machine.
[GraphQL: vsphereVmInitiateDiskMount]",
            Position = 0
        )]
        public SwitchParameter InitiateDiskMount { get; set; }

        
        /// <summary>
        /// InitiateLiveMount parameter set
        ///
        /// [GraphQL: vsphereVMInitiateLiveMount]
        /// </summary>
        [Parameter(
            ParameterSetName = "InitiateLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vsphereVMInitiateLiveMount]",
            Position = 0
        )]
        public SwitchParameter InitiateLiveMount { get; set; }

        
        /// <summary>
        /// InitiateLiveMountV2 parameter set
        ///
        /// [GraphQL: vsphereVmInitiateLiveMountV2]
        /// </summary>
        [Parameter(
            ParameterSetName = "InitiateLiveMountV2",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a vSphere Live Mount from a snapshot or point-in-time.
[GraphQL: vsphereVmInitiateLiveMountV2]",
            Position = 0
        )]
        public SwitchParameter InitiateLiveMountV2 { get; set; }

        
        /// <summary>
        /// BatchLiveMount parameter set
        ///
        /// [GraphQL: vSphereVMBatchLiveMount]
        /// </summary>
        [Parameter(
            ParameterSetName = "BatchLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vSphereVMBatchLiveMount]",
            Position = 0
        )]
        public SwitchParameter BatchLiveMount { get; set; }

        
        /// <summary>
        /// InitiateBatchLiveMountV2 parameter set
        ///
        /// [GraphQL: vsphereVmInitiateBatchLiveMountV2]
        /// </summary>
        [Parameter(
            ParameterSetName = "InitiateBatchLiveMountV2",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Initiate a mass live mount for a group of VMs.
[GraphQL: vsphereVmInitiateBatchLiveMountV2]",
            Position = 0
        )]
        public SwitchParameter InitiateBatchLiveMountV2 { get; set; }

        
        /// <summary>
        /// PowerOnOffLiveMount parameter set
        ///
        /// [GraphQL: vsphereVmPowerOnOffLiveMount]
        /// </summary>
        [Parameter(
            ParameterSetName = "PowerOnOffLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Power a Live Mount on and off

Supported in v5.0+
Power a specified Live Mount virtual machine on or off. Pass **_true_** to power the virtual machine on and pass **_false_** to power the virtual machine off.
[GraphQL: vsphereVmPowerOnOffLiveMount]",
            Position = 0
        )]
        public SwitchParameter PowerOnOffLiveMount { get; set; }

        
        /// <summary>
        /// DeleteLiveMount parameter set
        ///
        /// [GraphQL: vsphereVMDeleteLiveMount]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vsphereVMDeleteLiveMount]",
            Position = 0
        )]
        public SwitchParameter DeleteLiveMount { get; set; }

        
        /// <summary>
        /// ListEsxiDatastores parameter set
        ///
        /// [GraphQL: vsphereVmListEsxiDatastores]
        /// </summary>
        [Parameter(
            ParameterSetName = "ListEsxiDatastores",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List ESXi datastores

Supported in v5.0+
Retrieve a list of the datastores for a specified ESXi host.
[GraphQL: vsphereVmListEsxiDatastores]",
            Position = 0
        )]
        public SwitchParameter ListEsxiDatastores { get; set; }

        
        /// <summary>
        /// MountRelocate parameter set
        ///
        /// [GraphQL: vsphereVmMountRelocate]
        /// </summary>
        [Parameter(
            ParameterSetName = "MountRelocate",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Relocate a virtual machine to another datastore

Supported in v5.0+
Run storage VMotion to relocate a specified Live Mount into another data store.
[GraphQL: vsphereVmMountRelocate]",
            Position = 0
        )]
        public SwitchParameter MountRelocate { get; set; }

        
        /// <summary>
        /// MountRelocateV2 parameter set
        ///
        /// [GraphQL: vsphereVmMountRelocateV2]
        /// </summary>
        [Parameter(
            ParameterSetName = "MountRelocateV2",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a Live Mount migration to a datastore or datastore cluster with virtual disk mapping support.
[GraphQL: vsphereVmMountRelocateV2]",
            Position = 0
        )]
        public SwitchParameter MountRelocateV2 { get; set; }

        
        /// <summary>
        /// ExcludeVmDisks parameter set
        ///
        /// [GraphQL: vsphereExcludeVmDisks]
        /// </summary>
        [Parameter(
            ParameterSetName = "ExcludeVmDisks",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Exclude or include virtual disks during snapshot.
[GraphQL: vsphereExcludeVmDisks]",
            Position = 0
        )]
        public SwitchParameter ExcludeVmDisks { get; set; }

        
        /// <summary>
        /// DownloadSnapshotFiles parameter set
        ///
        /// [GraphQL: vsphereVmDownloadSnapshotFiles]
        /// </summary>
        [Parameter(
            ParameterSetName = "DownloadSnapshotFiles",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Download files from snapshot.
[GraphQL: vsphereVmDownloadSnapshotFiles]",
            Position = 0
        )]
        public SwitchParameter DownloadSnapshotFiles { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "RecoverFiles":
                        this.ProcessRecord_RecoverFiles();
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
                    case "ListEsxiDatastores":
                        this.ProcessRecord_ListEsxiDatastores();
                        break;
                    case "MountRelocate":
                        this.ProcessRecord_MountRelocate();
                        break;
                    case "MountRelocateV2":
                        this.ProcessRecord_MountRelocateV2();
                        break;
                    case "ExcludeVmDisks":
                        this.ProcessRecord_ExcludeVmDisks();
                        break;
                    case "DownloadSnapshotFiles":
                        this.ProcessRecord_DownloadSnapshotFiles();
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
        // vsphereVmRecoverFiles.
        internal void ProcessRecord_RecoverFiles()
        {
            this._logger.name += " -RecoverFiles";
            // Invoke graphql operation vsphereVmRecoverFiles
            InvokeMutationVsphereVmRecoverFiles();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmRecoverFilesNew.
        internal void ProcessRecord_RecoverFilesNew()
        {
            this._logger.name += " -RecoverFilesNew";
            // Invoke graphql operation vsphereVmRecoverFilesNew
            InvokeMutationVsphereVmRecoverFilesNew();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmRegisterAgent.
        internal void ProcessRecord_RegisterAgent()
        {
            this._logger.name += " -RegisterAgent";
            // Invoke graphql operation vsphereVmRegisterAgent
            InvokeMutationVsphereVmRegisterAgent();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmDownloadSnapshot.
        internal void ProcessRecord_DownloadSnapshot()
        {
            this._logger.name += " -DownloadSnapshot";
            // Invoke graphql operation vsphereVmDownloadSnapshot
            InvokeMutationVsphereVmDownloadSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVMExportSnapshot.
        internal void ProcessRecord_ExportSnapshot()
        {
            this._logger.name += " -ExportSnapshot";
            // Invoke graphql operation vsphereVMExportSnapshot
            InvokeMutationVsphereVmExportSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmExportSnapshotV2.
        internal void ProcessRecord_ExportSnapshotV2()
        {
            this._logger.name += " -ExportSnapshotV2";
            // Invoke graphql operation vsphereVmExportSnapshotV2
            InvokeMutationVsphereVmExportSnapshotV2();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmExportSnapshotV3.
        internal void ProcessRecord_ExportSnapshotV3()
        {
            this._logger.name += " -ExportSnapshotV3";
            // Invoke graphql operation vsphereVmExportSnapshotV3
            InvokeMutationVsphereVmExportSnapshotV3();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmBatchExport.
        internal void ProcessRecord_BatchExport()
        {
            this._logger.name += " -BatchExport";
            // Invoke graphql operation vsphereVmBatchExport
            InvokeMutationVsphereVmBatchExport();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmBatchExportV3.
        internal void ProcessRecord_BatchExportV3()
        {
            this._logger.name += " -BatchExportV3";
            // Invoke graphql operation vsphereVmBatchExportV3
            InvokeMutationVsphereVmBatchExportV3();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmInitiateInPlaceRecovery.
        internal void ProcessRecord_InitiateInPlaceRecovery()
        {
            this._logger.name += " -InitiateInPlaceRecovery";
            // Invoke graphql operation vsphereVmInitiateInPlaceRecovery
            InvokeMutationVsphereVmInitiateInPlaceRecovery();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmExportSnapshotWithDownloadFromCloud.
        internal void ProcessRecord_ExportSnapshotWithDownloadFromCloud()
        {
            this._logger.name += " -ExportSnapshotWithDownloadFromCloud";
            // Invoke graphql operation vsphereVmExportSnapshotWithDownloadFromCloud
            InvokeMutationVsphereVmExportSnapshotWithDownloadFromCloud();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmBatchInPlaceRecovery.
        internal void ProcessRecord_BatchInPlaceRecovery()
        {
            this._logger.name += " -BatchInPlaceRecovery";
            // Invoke graphql operation vsphereVmBatchInPlaceRecovery
            InvokeMutationVsphereVmBatchInPlaceRecovery();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmDeleteSnapshot.
        internal void ProcessRecord_DeleteSnapshot()
        {
            this._logger.name += " -DeleteSnapshot";
            // Invoke graphql operation vsphereVmDeleteSnapshot
            InvokeMutationVsphereVmDeleteSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVMUpdate.
        internal void ProcessRecord_Update()
        {
            this._logger.name += " -Update";
            // Invoke graphql operation vsphereVMUpdate
            InvokeMutationVsphereVmUpdate();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVMInitiateInstantRecovery.
        internal void ProcessRecord_InitiateInstantRecovery()
        {
            this._logger.name += " -InitiateInstantRecovery";
            // Invoke graphql operation vsphereVMInitiateInstantRecovery
            InvokeMutationVsphereVmInitiateInstantRecovery();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmInitiateInstantRecoveryV2.
        internal void ProcessRecord_InitiateInstantRecoveryV2()
        {
            this._logger.name += " -InitiateInstantRecoveryV2";
            // Invoke graphql operation vsphereVmInitiateInstantRecoveryV2
            InvokeMutationVsphereVmInitiateInstantRecoveryV2();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmInitiateBatchInstantRecovery.
        internal void ProcessRecord_InitiateBatchInstantRecovery()
        {
            this._logger.name += " -InitiateBatchInstantRecovery";
            // Invoke graphql operation vsphereVmInitiateBatchInstantRecovery
            InvokeMutationVsphereVmInitiateBatchInstantRecovery();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmInitiateDiskMount.
        internal void ProcessRecord_InitiateDiskMount()
        {
            this._logger.name += " -InitiateDiskMount";
            // Invoke graphql operation vsphereVmInitiateDiskMount
            InvokeMutationVsphereVmInitiateDiskMount();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVMInitiateLiveMount.
        internal void ProcessRecord_InitiateLiveMount()
        {
            this._logger.name += " -InitiateLiveMount";
            // Invoke graphql operation vsphereVMInitiateLiveMount
            InvokeMutationVsphereVmInitiateLiveMount();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmInitiateLiveMountV2.
        internal void ProcessRecord_InitiateLiveMountV2()
        {
            this._logger.name += " -InitiateLiveMountV2";
            // Invoke graphql operation vsphereVmInitiateLiveMountV2
            InvokeMutationVsphereVmInitiateLiveMountV2();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereVMBatchLiveMount.
        internal void ProcessRecord_BatchLiveMount()
        {
            this._logger.name += " -BatchLiveMount";
            // Invoke graphql operation vSphereVMBatchLiveMount
            InvokeMutationVsphereVmBatchLiveMount();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmInitiateBatchLiveMountV2.
        internal void ProcessRecord_InitiateBatchLiveMountV2()
        {
            this._logger.name += " -InitiateBatchLiveMountV2";
            // Invoke graphql operation vsphereVmInitiateBatchLiveMountV2
            InvokeMutationVsphereVmInitiateBatchLiveMountV2();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmPowerOnOffLiveMount.
        internal void ProcessRecord_PowerOnOffLiveMount()
        {
            this._logger.name += " -PowerOnOffLiveMount";
            // Invoke graphql operation vsphereVmPowerOnOffLiveMount
            InvokeMutationVsphereVmPowerOnOffLiveMount();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVMDeleteLiveMount.
        internal void ProcessRecord_DeleteLiveMount()
        {
            this._logger.name += " -DeleteLiveMount";
            // Invoke graphql operation vsphereVMDeleteLiveMount
            InvokeMutationVsphereVmDeleteLiveMount();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmListEsxiDatastores.
        internal void ProcessRecord_ListEsxiDatastores()
        {
            this._logger.name += " -ListEsxiDatastores";
            // Invoke graphql operation vsphereVmListEsxiDatastores
            InvokeMutationVsphereVmListEsxiDatastores();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmMountRelocate.
        internal void ProcessRecord_MountRelocate()
        {
            this._logger.name += " -MountRelocate";
            // Invoke graphql operation vsphereVmMountRelocate
            InvokeMutationVsphereVmMountRelocate();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmMountRelocateV2.
        internal void ProcessRecord_MountRelocateV2()
        {
            this._logger.name += " -MountRelocateV2";
            // Invoke graphql operation vsphereVmMountRelocateV2
            InvokeMutationVsphereVmMountRelocateV2();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereExcludeVmDisks.
        internal void ProcessRecord_ExcludeVmDisks()
        {
            this._logger.name += " -ExcludeVmDisks";
            // Invoke graphql operation vsphereExcludeVmDisks
            InvokeMutationVsphereExcludeVmDisks();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmDownloadSnapshotFiles.
        internal void ProcessRecord_DownloadSnapshotFiles()
        {
            this._logger.name += " -DownloadSnapshotFiles";
            // Invoke graphql operation vsphereVmDownloadSnapshotFiles
            InvokeMutationVsphereVmDownloadSnapshotFiles();
        }


        // Invoke GraphQL Mutation:
        // vsphereVmRecoverFiles(input: VsphereVmRecoverFilesInput!): VsphereAsyncRequestStatus!
        internal void InvokeMutationVsphereVmRecoverFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmRecoverFilesInput!"),
            };
            VsphereAsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereAsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereVmRecoverFiles(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereVmRecoverFiles",
                "($input: VsphereVmRecoverFilesInput!)",
                fieldSpecDoc,
                "VsphereAsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // vsphereVmRecoverFilesNew(input: VsphereVmRecoverFilesNewInput!): AsyncRequestStatus!
        internal void InvokeMutationVsphereVmRecoverFilesNew()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmRecoverFilesNewInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereVmRecoverFilesNew(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereVmRecoverFilesNew",
                "($input: VsphereVmRecoverFilesNewInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // vsphereVmRegisterAgent(input: VsphereVmRegisterAgentInput!): RequestSuccess!
        internal void InvokeMutationVsphereVmRegisterAgent()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmRegisterAgentInput!"),
            };
            RequestSuccess? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (RequestSuccess)psObject.BaseObject;
                } else {
                    fieldSpecObj = (RequestSuccess)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereVmRegisterAgent(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereVmRegisterAgent",
                "($input: VsphereVmRegisterAgentInput!)",
                fieldSpecDoc,
                "RequestSuccess"
            );
        }

        // Invoke GraphQL Mutation:
        // vsphereVmDownloadSnapshot(input: VsphereVmDownloadSnapshotInput!): AsyncRequestStatus!
        internal void InvokeMutationVsphereVmDownloadSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmDownloadSnapshotInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereVmDownloadSnapshot(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereVmDownloadSnapshot",
                "($input: VsphereVmDownloadSnapshotInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
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
        internal void InvokeMutationVsphereVmExportSnapshot()
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
            VsphereAsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereAsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereVmExportSnapshot(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereVmExportSnapshot",
                "($snapshotFid: UUID!,$vmName: String,$disableNetwork: Boolean,$removeNetworkDevices: Boolean,$powerOn: Boolean,$keepMacAddresses: Boolean,$hostID: String,$datastoreId: UUID!,$unregsiterVm: Boolean,$shouldRecoverTags: Boolean)",
                fieldSpecDoc,
                "VsphereAsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // vsphereVmExportSnapshotV2(input: VsphereVmExportSnapshotV2Input!): AsyncRequestStatus!
        internal void InvokeMutationVsphereVmExportSnapshotV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmExportSnapshotV2Input!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereVmExportSnapshotV2(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereVmExportSnapshotV2",
                "($input: VsphereVmExportSnapshotV2Input!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // vsphereVmExportSnapshotV3(input: VsphereVmExportSnapshotV3Input!): AsyncRequestStatus!
        internal void InvokeMutationVsphereVmExportSnapshotV3()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmExportSnapshotV3Input!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereVmExportSnapshotV3(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereVmExportSnapshotV3",
                "($input: VsphereVmExportSnapshotV3Input!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // vsphereVmBatchExport(input: VsphereVmBatchExportInput!): BatchAsyncRequestStatus!
        internal void InvokeMutationVsphereVmBatchExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmBatchExportInput!"),
            };
            BatchAsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BatchAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BatchAsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereVmBatchExport(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereVmBatchExport",
                "($input: VsphereVmBatchExportInput!)",
                fieldSpecDoc,
                "BatchAsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // vsphereVmBatchExportV3(input: VsphereVmBatchExportV3Input!): BatchAsyncRequestStatus!
        internal void InvokeMutationVsphereVmBatchExportV3()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmBatchExportV3Input!"),
            };
            BatchAsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BatchAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BatchAsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereVmBatchExportV3(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereVmBatchExportV3",
                "($input: VsphereVmBatchExportV3Input!)",
                fieldSpecDoc,
                "BatchAsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // vsphereVmInitiateInPlaceRecovery(input: VsphereVmInitiateInPlaceRecoveryInput!): AsyncRequestStatus!
        internal void InvokeMutationVsphereVmInitiateInPlaceRecovery()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmInitiateInPlaceRecoveryInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereVmInitiateInPlaceRecovery(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereVmInitiateInPlaceRecovery",
                "($input: VsphereVmInitiateInPlaceRecoveryInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // vsphereVmExportSnapshotWithDownloadFromCloud(input: VsphereVmExportSnapshotWithDownloadFromCloudInput!): AsyncRequestStatus!
        internal void InvokeMutationVsphereVmExportSnapshotWithDownloadFromCloud()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmExportSnapshotWithDownloadFromCloudInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereVmExportSnapshotWithDownloadFromCloud(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereVmExportSnapshotWithDownloadFromCloud",
                "($input: VsphereVmExportSnapshotWithDownloadFromCloudInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // vsphereVmBatchInPlaceRecovery(input: VsphereVmBatchInPlaceRecoveryInput!): BatchAsyncRequestStatus!
        internal void InvokeMutationVsphereVmBatchInPlaceRecovery()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmBatchInPlaceRecoveryInput!"),
            };
            BatchAsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BatchAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BatchAsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereVmBatchInPlaceRecovery(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereVmBatchInPlaceRecovery",
                "($input: VsphereVmBatchInPlaceRecoveryInput!)",
                fieldSpecDoc,
                "BatchAsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // vsphereVmDeleteSnapshot(input: VsphereVmDeleteSnapshotInput!): Void
        internal void InvokeMutationVsphereVmDeleteSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmDeleteSnapshotInput!"),
            };
            System.String? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (System.String)psObject.BaseObject;
                } else {
                    fieldSpecObj = (System.String)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereVmDeleteSnapshot(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereVmDeleteSnapshot",
                "($input: VsphereVmDeleteSnapshotInput!)",
                fieldSpecDoc,
                "System.String"
            );
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
        internal void InvokeMutationVsphereVmUpdate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("snapshotConsistencyMandate", "String"),
                Tuple.Create("preBackupScript", "PreBackupScriptInputType"),
                Tuple.Create("postBackupScript", "PostBackupScriptInputType"),
                Tuple.Create("postSnapScript", "PostSnapScriptInputType"),
                Tuple.Create("isArrayIntegrationEnabled", "Boolean"),
            };
            RequestSuccess? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (RequestSuccess)psObject.BaseObject;
                } else {
                    fieldSpecObj = (RequestSuccess)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereVmUpdate(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereVmUpdate",
                "($snappableFid: UUID!,$snapshotConsistencyMandate: String,$preBackupScript: PreBackupScriptInputType,$postBackupScript: PostBackupScriptInputType,$postSnapScript: PostSnapScriptInputType,$isArrayIntegrationEnabled: Boolean)",
                fieldSpecDoc,
                "RequestSuccess"
            );
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
        internal void InvokeMutationVsphereVmInitiateInstantRecovery()
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
            VsphereAsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereAsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereVmInitiateInstantRecovery(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereVmInitiateInstantRecovery",
                "($snapshotFid: UUID!,$vmName: String,$disableNetwork: Boolean,$removeNetworkDevices: Boolean,$powerOn: Boolean,$keepMacAddresses: Boolean,$hostID: String,$preserveMOID: Boolean,$vlan: Int,$shouldRecoverTags: Boolean)",
                fieldSpecDoc,
                "VsphereAsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // vsphereVmInitiateInstantRecoveryV2(input: VsphereVmInitiateInstantRecoveryV2Input!): AsyncRequestStatus!
        internal void InvokeMutationVsphereVmInitiateInstantRecoveryV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmInitiateInstantRecoveryV2Input!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereVmInitiateInstantRecoveryV2(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereVmInitiateInstantRecoveryV2",
                "($input: VsphereVmInitiateInstantRecoveryV2Input!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // vsphereVmInitiateBatchInstantRecovery(input: VsphereVmInitiateBatchInstantRecoveryInput!): BatchAsyncRequestStatus!
        internal void InvokeMutationVsphereVmInitiateBatchInstantRecovery()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmInitiateBatchInstantRecoveryInput!"),
            };
            BatchAsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BatchAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BatchAsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereVmInitiateBatchInstantRecovery(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereVmInitiateBatchInstantRecovery",
                "($input: VsphereVmInitiateBatchInstantRecoveryInput!)",
                fieldSpecDoc,
                "BatchAsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // vsphereVmInitiateDiskMount(input: VsphereVmInitiateDiskMountInput!): AsyncRequestStatus!
        internal void InvokeMutationVsphereVmInitiateDiskMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmInitiateDiskMountInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereVmInitiateDiskMount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereVmInitiateDiskMount",
                "($input: VsphereVmInitiateDiskMountInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
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
        internal void InvokeMutationVsphereVmInitiateLiveMount()
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
            VsphereAsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereAsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereVmInitiateLiveMount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereVmInitiateLiveMount",
                "($snapshotFid: UUID!,$vmName: String,$disableNetwork: Boolean,$removeNetworkDevices: Boolean,$powerOn: Boolean,$keepMacAddresses: Boolean,$hostID: String,$datastoreName: String,$createDatastoreOnly: Boolean,$vlan: Int,$shouldRecoverTags: Boolean)",
                fieldSpecDoc,
                "VsphereAsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // vsphereVmInitiateLiveMountV2(input: VsphereVmInitiateLiveMountV2Input!): AsyncRequestStatus!
        internal void InvokeMutationVsphereVmInitiateLiveMountV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmInitiateLiveMountV2Input!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereVmInitiateLiveMountV2(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereVmInitiateLiveMountV2",
                "($input: VsphereVmInitiateLiveMountV2Input!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // vSphereVMBatchLiveMount(clusterUuid: UUID!, config: BatchMountSnapshotJobConfigInput!): BatchAsyncRequestStatus!
        internal void InvokeMutationVsphereVmBatchLiveMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
                Tuple.Create("config", "BatchMountSnapshotJobConfigInput!"),
            };
            BatchAsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BatchAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BatchAsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereVmBatchLiveMount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereVmBatchLiveMount",
                "($clusterUuid: UUID!,$config: BatchMountSnapshotJobConfigInput!)",
                fieldSpecDoc,
                "BatchAsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // vsphereVmInitiateBatchLiveMountV2(input: VsphereVmInitiateBatchLiveMountV2Input!): BatchAsyncRequestStatus!
        internal void InvokeMutationVsphereVmInitiateBatchLiveMountV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmInitiateBatchLiveMountV2Input!"),
            };
            BatchAsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BatchAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BatchAsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereVmInitiateBatchLiveMountV2(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereVmInitiateBatchLiveMountV2",
                "($input: VsphereVmInitiateBatchLiveMountV2Input!)",
                fieldSpecDoc,
                "BatchAsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // vsphereVmPowerOnOffLiveMount(input: VsphereVmPowerOnOffLiveMountInput!): VsphereVmPowerOnOffLiveMountReply!
        internal void InvokeMutationVsphereVmPowerOnOffLiveMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmPowerOnOffLiveMountInput!"),
            };
            VsphereVmPowerOnOffLiveMountReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereVmPowerOnOffLiveMountReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereVmPowerOnOffLiveMountReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereVmPowerOnOffLiveMount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereVmPowerOnOffLiveMount",
                "($input: VsphereVmPowerOnOffLiveMountInput!)",
                fieldSpecDoc,
                "VsphereVmPowerOnOffLiveMountReply"
            );
        }

        // Invoke GraphQL Mutation:
        // vsphereVMDeleteLiveMount(livemountId: UUID!, force: Boolean): VsphereAsyncRequestStatus!
        internal void InvokeMutationVsphereVmDeleteLiveMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("livemountId", "UUID!"),
                Tuple.Create("force", "Boolean"),
            };
            VsphereAsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereAsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereVmDeleteLiveMount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereVmDeleteLiveMount",
                "($livemountId: UUID!,$force: Boolean)",
                fieldSpecDoc,
                "VsphereAsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // vsphereVmListEsxiDatastores(input: VsphereVmListEsxiDatastoresInput!): VsphereVmListEsxiDatastoresReply!
        internal void InvokeMutationVsphereVmListEsxiDatastores()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmListEsxiDatastoresInput!"),
            };
            VsphereVmListEsxiDatastoresReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereVmListEsxiDatastoresReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereVmListEsxiDatastoresReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereVmListEsxiDatastores(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereVmListEsxiDatastores",
                "($input: VsphereVmListEsxiDatastoresInput!)",
                fieldSpecDoc,
                "VsphereVmListEsxiDatastoresReply"
            );
        }

        // Invoke GraphQL Mutation:
        // vsphereVmMountRelocate(input: VsphereVmMountRelocateInput!): AsyncRequestStatus!
        internal void InvokeMutationVsphereVmMountRelocate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmMountRelocateInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereVmMountRelocate(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereVmMountRelocate",
                "($input: VsphereVmMountRelocateInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // vsphereVmMountRelocateV2(input: VsphereVmMountRelocateV2Input!): AsyncRequestStatus!
        internal void InvokeMutationVsphereVmMountRelocateV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmMountRelocateV2Input!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereVmMountRelocateV2(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereVmMountRelocateV2",
                "($input: VsphereVmMountRelocateV2Input!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // vsphereExcludeVmDisks(input: [VsphereExcludeVmDisksInput!]!): RequestSuccess!
        internal void InvokeMutationVsphereExcludeVmDisks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "[VsphereExcludeVmDisksInput!]!"),
            };
            RequestSuccess? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (RequestSuccess)psObject.BaseObject;
                } else {
                    fieldSpecObj = (RequestSuccess)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereExcludeVmDisks(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereExcludeVmDisks",
                "($input: [VsphereExcludeVmDisksInput!]!)",
                fieldSpecDoc,
                "RequestSuccess"
            );
        }

        // Invoke GraphQL Mutation:
        // vsphereVmDownloadSnapshotFiles(input: VsphereVmDownloadSnapshotFilesInput!): AsyncRequestStatus!
        internal void InvokeMutationVsphereVmDownloadSnapshotFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmDownloadSnapshotFilesInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereVmDownloadSnapshotFiles(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereVmDownloadSnapshotFiles",
                "($input: VsphereVmDownloadSnapshotFilesInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }


    } // class Invoke_RscMutateVsphereVm
}