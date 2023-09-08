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
    /// <summary>
    /// vSphere VM mutations
    /// </summary>
    /// <description>
    /// Invoke-RscMutateVsphereVm is a master cmdlet for VsphereVm work that can invoke any of the following subcommands: RecoverFiles, RecoverFilesNew, RegisterAgent, DownloadSnapshot, ExportSnapshotV2, ExportSnapshotV3, BatchExport, BatchExportV3, InitiateInPlaceRecovery, ExportSnapshotWithDownloadFromCloud, BatchInPlaceRecovery, DeleteSnapshot, InitiateInstantRecoveryV2, InitiateBatchInstantRecovery, InitiateDiskMount, InitiateLiveMountV2, InitiateBatchLiveMountV2, PowerOnOffLiveMount, ListEsxiDatastores, MountRelocate, MountRelocateV2, ExcludeVmDisks, DownloadSnapshotFiles, Update.
    /// </description>
    /// <example>
    /// <code>Invoke-RscMutateVsphereVm -RecoverFiles [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphereVm -RecoverFilesNew [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphereVm -RegisterAgent [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphereVm -DownloadSnapshot [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphereVm -ExportSnapshotV2 [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphereVm -ExportSnapshotV3 [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphereVm -BatchExport [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphereVm -BatchExportV3 [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphereVm -InitiateInPlaceRecovery [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphereVm -ExportSnapshotWithDownloadFromCloud [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphereVm -BatchInPlaceRecovery [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphereVm -DeleteSnapshot [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphereVm -InitiateInstantRecoveryV2 [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphereVm -InitiateBatchInstantRecovery [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphereVm -InitiateDiskMount [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphereVm -InitiateLiveMountV2 [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphereVm -InitiateBatchLiveMountV2 [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphereVm -PowerOnOffLiveMount [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphereVm -ListEsxiDatastores [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphereVm -MountRelocate [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphereVm -MountRelocateV2 [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphereVm -ExcludeVmDisks [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphereVm -DownloadSnapshotFiles [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphereVm -Update [-Arg ..] [-Field ..]</code>
    /// </example>
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

        
        /// <summary>
        /// Update parameter set
        ///
        /// [GraphQL: updateVsphereVm]
        /// </summary>
        [Parameter(
            ParameterSetName = "Update",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update VM

Supported in v5.0+
Update a virtual machine with specified properties. Use the guestCredential field to update the guest credential for a specified virtual machine.
[GraphQL: updateVsphereVm]",
            Position = 0
        )]
        public SwitchParameter Update { get; set; }


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
                    case "InitiateInstantRecoveryV2":
                        this.ProcessRecord_InitiateInstantRecoveryV2();
                        break;
                    case "InitiateBatchInstantRecovery":
                        this.ProcessRecord_InitiateBatchInstantRecovery();
                        break;
                    case "InitiateDiskMount":
                        this.ProcessRecord_InitiateDiskMount();
                        break;
                    case "InitiateLiveMountV2":
                        this.ProcessRecord_InitiateLiveMountV2();
                        break;
                    case "InitiateBatchLiveMountV2":
                        this.ProcessRecord_InitiateBatchLiveMountV2();
                        break;
                    case "PowerOnOffLiveMount":
                        this.ProcessRecord_PowerOnOffLiveMount();
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
                    case "Update":
                        this.ProcessRecord_Update();
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
        // vsphereVmInitiateLiveMountV2.
        internal void ProcessRecord_InitiateLiveMountV2()
        {
            this._logger.name += " -InitiateLiveMountV2";
            // Invoke graphql operation vsphereVmInitiateLiveMountV2
            InvokeMutationVsphereVmInitiateLiveMountV2();
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

        // This parameter set invokes a single graphql operation:
        // updateVsphereVm.
        internal void ProcessRecord_Update()
        {
            this._logger.name += " -Update";
            // Invoke graphql operation updateVsphereVm
            InvokeMutationUpdateVsphereVm();
        }


        // Invoke GraphQL Mutation:
        // vsphereVmRecoverFiles(input: VsphereVmRecoverFilesInput!): VsphereAsyncRequestStatus!
        internal void InvokeMutationVsphereVmRecoverFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmRecoverFilesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmRecoverFiles",
                "($input: VsphereVmRecoverFilesInput!)",
                "VsphereAsyncRequestStatus"
                );
            VsphereAsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (VsphereAsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereVmRecoverFiles(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snapshotFid = <System.String>
	# REQUIRED
	restoreConfig = @{
		# OPTIONAL
		restoreFilesConfig = @(
			@{
				# OPTIONAL
				path = <System.String>
				# OPTIONAL
				restorePath = <System.String>
			}
		)
		# OPTIONAL
		domainName = <System.String>
		# OPTIONAL
		username = <System.String>
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		shouldIgnoreErrors = <System.Boolean>
		# OPTIONAL
		shouldSaveCredentials = <System.Boolean>
		# OPTIONAL
		shouldUseAgent = <System.Boolean>
		# OPTIONAL
		shouldRestoreXAttrs = <System.Boolean>
		# OPTIONAL
		deltaTypeFilter = @(
			<DeltaType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeltaType]) for enum values.
		)
		# OPTIONAL
		nextSnapshotFid = <System.String>
	}
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // vsphereVmRecoverFilesNew(input: VsphereVmRecoverFilesNewInput!): AsyncRequestStatus!
        internal void InvokeMutationVsphereVmRecoverFilesNew()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmRecoverFilesNewInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmRecoverFilesNew",
                "($input: VsphereVmRecoverFilesNewInput!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereVmRecoverFilesNew(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	config = @{
		# OPTIONAL
		domainName = <System.String>
		# OPTIONAL
		ignoreErrors = <System.Boolean>
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		shouldSaveCredentials = <System.Boolean>
		# OPTIONAL
		username = <System.String>
		# OPTIONAL
		destObjectId = <System.String>
		# OPTIONAL
		shouldRestoreXAttrs = <System.Boolean>
		# OPTIONAL
		shouldUseAgent = <System.Boolean>
		# OPTIONAL
		guestCredentialId = <System.String>
		# REQUIRED
		restoreConfig = @(
			@{
				# OPTIONAL
				restorePathPair = @{
					# OPTIONAL
					restorePath = <System.String>
					# REQUIRED
					path = <System.String>
				}
			}
		)
	}
	# OPTIONAL
	deltaRequest = @{
		# REQUIRED
		nextSnapshotFid = <System.String>
		# REQUIRED
		deltaTypeFilter = @(
			<DeltaType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeltaType]) for enum values.
		)
	}
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // vsphereVmRegisterAgent(input: VsphereVmRegisterAgentInput!): RequestSuccess!
        internal void InvokeMutationVsphereVmRegisterAgent()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmRegisterAgentInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmRegisterAgent",
                "($input: VsphereVmRegisterAgentInput!)",
                "RequestSuccess"
                );
            RequestSuccess? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (RequestSuccess)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereVmRegisterAgent(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // vsphereVmDownloadSnapshot(input: VsphereVmDownloadSnapshotInput!): AsyncRequestStatus!
        internal void InvokeMutationVsphereVmDownloadSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmDownloadSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmDownloadSnapshot",
                "($input: VsphereVmDownloadSnapshotInput!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereVmDownloadSnapshot(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // vsphereVmExportSnapshotV2(input: VsphereVmExportSnapshotV2Input!): AsyncRequestStatus!
        internal void InvokeMutationVsphereVmExportSnapshotV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmExportSnapshotV2Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmExportSnapshotV2",
                "($input: VsphereVmExportSnapshotV2Input!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereVmExportSnapshotV2(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		hostId = <System.String>
		# OPTIONAL
		shouldRecoverTags = <System.Boolean>
		# OPTIONAL
		unregisterVm = <System.Boolean>
		# OPTIONAL
		clusterId = <System.String>
		# OPTIONAL
		resourcePoolId = <System.String>
		# OPTIONAL
		vNicBindings = @(
			@{
				# REQUIRED
				backingNetworkInfo = @{
					# REQUIRED
					moid = <System.String>
					# REQUIRED
					name = <System.String>
				}
				# REQUIRED
				networkDeviceInfo = @{
					# REQUIRED
					key = <System.Int32>
					# REQUIRED
					name = <System.String>
				}
			}
		)
		# OPTIONAL
		shouldUseHotAddProxy = <System.Boolean>
		# OPTIONAL
		mountExportSnapshotJobCommonOptionsV2 = @{
			# OPTIONAL
			disableNetwork = <System.Boolean>
			# OPTIONAL
			keepMacAddresses = <System.Boolean>
			# OPTIONAL
			powerOn = <System.Boolean>
			# OPTIONAL
			removeNetworkDevices = <System.Boolean>
			# OPTIONAL
			vmName = <System.String>
		}
		# OPTIONAL
		requiredRecoveryParameters = @{
			# OPTIONAL
			recoveryPoint = <DateTime>
			# OPTIONAL
			snapshotId = <System.String>
		}
		# OPTIONAL
		folderId = <System.String>
		# REQUIRED
		datastoreId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // vsphereVmExportSnapshotV3(input: VsphereVmExportSnapshotV3Input!): AsyncRequestStatus!
        internal void InvokeMutationVsphereVmExportSnapshotV3()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmExportSnapshotV3Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmExportSnapshotV3",
                "($input: VsphereVmExportSnapshotV3Input!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereVmExportSnapshotV3(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		clusterId = <System.String>
		# OPTIONAL
		diskDeviceKeyToStorageId = @(
			@{
				# OPTIONAL
				storageLocationId = <System.String>
				# REQUIRED
				deviceKey = <System.Int32>
			}
		)
		# OPTIONAL
		hostId = <System.String>
		# OPTIONAL
		resourcePoolId = <System.String>
		# OPTIONAL
		shouldRecoverTags = <System.Boolean>
		# OPTIONAL
		shouldUseHotAddProxy = <System.Boolean>
		# OPTIONAL
		storageLocationId = <System.String>
		# OPTIONAL
		unregisterVm = <System.Boolean>
		# OPTIONAL
		vNicBindings = @(
			@{
				# REQUIRED
				backingNetworkInfo = @{
					# REQUIRED
					moid = <System.String>
					# REQUIRED
					name = <System.String>
				}
				# REQUIRED
				networkDeviceInfo = @{
					# REQUIRED
					key = <System.Int32>
					# REQUIRED
					name = <System.String>
				}
			}
		)
		# OPTIONAL
		mountExportSnapshotJobCommonOptionsV2 = @{
			# OPTIONAL
			disableNetwork = <System.Boolean>
			# OPTIONAL
			keepMacAddresses = <System.Boolean>
			# OPTIONAL
			powerOn = <System.Boolean>
			# OPTIONAL
			removeNetworkDevices = <System.Boolean>
			# OPTIONAL
			vmName = <System.String>
		}
		# OPTIONAL
		requiredRecoveryParameters = @{
			# OPTIONAL
			recoveryPoint = <DateTime>
			# OPTIONAL
			snapshotId = <System.String>
		}
		# OPTIONAL
		folderId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // vsphereVmBatchExport(input: VsphereVmBatchExportInput!): BatchAsyncRequestStatus!
        internal void InvokeMutationVsphereVmBatchExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmBatchExportInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmBatchExport",
                "($input: VsphereVmBatchExportInput!)",
                "BatchAsyncRequestStatus"
                );
            BatchAsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (BatchAsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereVmBatchExport(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
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
				config = @{
					# OPTIONAL
					hostId = <System.String>
					# OPTIONAL
					shouldRecoverTags = <System.Boolean>
					# OPTIONAL
					unregisterVm = <System.Boolean>
					# OPTIONAL
					clusterId = <System.String>
					# OPTIONAL
					resourcePoolId = <System.String>
					# OPTIONAL
					vNicBindings = @(
						@{
							# REQUIRED
							backingNetworkInfo = @{
								# REQUIRED
								moid = <System.String>
								# REQUIRED
								name = <System.String>
							}
							# REQUIRED
							networkDeviceInfo = @{
								# REQUIRED
								key = <System.Int32>
								# REQUIRED
								name = <System.String>
							}
						}
					)
					# OPTIONAL
					shouldUseHotAddProxy = <System.Boolean>
					# OPTIONAL
					mountExportSnapshotJobCommonOptionsV2 = @{
						# OPTIONAL
						disableNetwork = <System.Boolean>
						# OPTIONAL
						keepMacAddresses = <System.Boolean>
						# OPTIONAL
						powerOn = <System.Boolean>
						# OPTIONAL
						removeNetworkDevices = <System.Boolean>
						# OPTIONAL
						vmName = <System.String>
					}
					# OPTIONAL
					requiredRecoveryParameters = @{
						# OPTIONAL
						recoveryPoint = <DateTime>
						# OPTIONAL
						snapshotId = <System.String>
					}
					# OPTIONAL
					folderId = <System.String>
					# REQUIRED
					datastoreId = <System.String>
				}
				# REQUIRED
				vmId = <System.String>
			}
		)
	}
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // vsphereVmBatchExportV3(input: VsphereVmBatchExportV3Input!): BatchAsyncRequestStatus!
        internal void InvokeMutationVsphereVmBatchExportV3()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmBatchExportV3Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmBatchExportV3",
                "($input: VsphereVmBatchExportV3Input!)",
                "BatchAsyncRequestStatus"
                );
            BatchAsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (BatchAsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereVmBatchExportV3(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
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
				config = @{
					# OPTIONAL
					clusterId = <System.String>
					# OPTIONAL
					diskDeviceKeyToStorageId = @(
						@{
							# OPTIONAL
							storageLocationId = <System.String>
							# REQUIRED
							deviceKey = <System.Int32>
						}
					)
					# OPTIONAL
					hostId = <System.String>
					# OPTIONAL
					resourcePoolId = <System.String>
					# OPTIONAL
					shouldRecoverTags = <System.Boolean>
					# OPTIONAL
					shouldUseHotAddProxy = <System.Boolean>
					# OPTIONAL
					storageLocationId = <System.String>
					# OPTIONAL
					unregisterVm = <System.Boolean>
					# OPTIONAL
					vNicBindings = @(
						@{
							# REQUIRED
							backingNetworkInfo = @{
								# REQUIRED
								moid = <System.String>
								# REQUIRED
								name = <System.String>
							}
							# REQUIRED
							networkDeviceInfo = @{
								# REQUIRED
								key = <System.Int32>
								# REQUIRED
								name = <System.String>
							}
						}
					)
					# OPTIONAL
					mountExportSnapshotJobCommonOptionsV2 = @{
						# OPTIONAL
						disableNetwork = <System.Boolean>
						# OPTIONAL
						keepMacAddresses = <System.Boolean>
						# OPTIONAL
						powerOn = <System.Boolean>
						# OPTIONAL
						removeNetworkDevices = <System.Boolean>
						# OPTIONAL
						vmName = <System.String>
					}
					# OPTIONAL
					requiredRecoveryParameters = @{
						# OPTIONAL
						recoveryPoint = <DateTime>
						# OPTIONAL
						snapshotId = <System.String>
					}
					# OPTIONAL
					folderId = <System.String>
				}
				# REQUIRED
				vmId = <System.String>
			}
		)
	}
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // vsphereVmInitiateInPlaceRecovery(input: VsphereVmInitiateInPlaceRecoveryInput!): AsyncRequestStatus!
        internal void InvokeMutationVsphereVmInitiateInPlaceRecovery()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmInitiateInPlaceRecoveryInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmInitiateInPlaceRecovery",
                "($input: VsphereVmInitiateInPlaceRecoveryInput!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereVmInitiateInPlaceRecovery(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		shouldKeepVsphereSnapshotAfterRecovery = <System.Boolean>
		# OPTIONAL
		requiredRecoveryParameters = @{
			# OPTIONAL
			recoveryPoint = <DateTime>
			# OPTIONAL
			snapshotId = <System.String>
		}
	}
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // vsphereVmExportSnapshotWithDownloadFromCloud(input: VsphereVmExportSnapshotWithDownloadFromCloudInput!): AsyncRequestStatus!
        internal void InvokeMutationVsphereVmExportSnapshotWithDownloadFromCloud()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmExportSnapshotWithDownloadFromCloudInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmExportSnapshotWithDownloadFromCloud",
                "($input: VsphereVmExportSnapshotWithDownloadFromCloudInput!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereVmExportSnapshotWithDownloadFromCloud(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		hostId = <System.String>
		# OPTIONAL
		shouldRecoverTags = <System.Boolean>
		# OPTIONAL
		unregisterVm = <System.Boolean>
		# OPTIONAL
		clusterId = <System.String>
		# OPTIONAL
		resourcePoolId = <System.String>
		# OPTIONAL
		vNicBindings = @(
			@{
				# REQUIRED
				backingNetworkInfo = @{
					# REQUIRED
					moid = <System.String>
					# REQUIRED
					name = <System.String>
				}
				# REQUIRED
				networkDeviceInfo = @{
					# REQUIRED
					key = <System.Int32>
					# REQUIRED
					name = <System.String>
				}
			}
		)
		# OPTIONAL
		shouldUseHotAddProxy = <System.Boolean>
		# OPTIONAL
		mountExportSnapshotJobCommonOptionsV2 = @{
			# OPTIONAL
			disableNetwork = <System.Boolean>
			# OPTIONAL
			keepMacAddresses = <System.Boolean>
			# OPTIONAL
			powerOn = <System.Boolean>
			# OPTIONAL
			removeNetworkDevices = <System.Boolean>
			# OPTIONAL
			vmName = <System.String>
		}
		# OPTIONAL
		requiredRecoveryParameters = @{
			# OPTIONAL
			recoveryPoint = <DateTime>
			# OPTIONAL
			snapshotId = <System.String>
		}
		# OPTIONAL
		folderId = <System.String>
		# REQUIRED
		datastoreId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // vsphereVmBatchInPlaceRecovery(input: VsphereVmBatchInPlaceRecoveryInput!): BatchAsyncRequestStatus!
        internal void InvokeMutationVsphereVmBatchInPlaceRecovery()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmBatchInPlaceRecoveryInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmBatchInPlaceRecovery",
                "($input: VsphereVmBatchInPlaceRecoveryInput!)",
                "BatchAsyncRequestStatus"
                );
            BatchAsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (BatchAsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereVmBatchInPlaceRecovery(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
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
				config = @{
					# OPTIONAL
					shouldKeepVsphereSnapshotAfterRecovery = <System.Boolean>
					# OPTIONAL
					requiredRecoveryParameters = @{
						# OPTIONAL
						recoveryPoint = <DateTime>
						# OPTIONAL
						snapshotId = <System.String>
					}
				}
				# REQUIRED
				vmId = <System.String>
			}
		)
	}
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // vsphereVmDeleteSnapshot(input: VsphereVmDeleteSnapshotInput!): Void
        internal void InvokeMutationVsphereVmDeleteSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmDeleteSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmDeleteSnapshot",
                "($input: VsphereVmDeleteSnapshotInput!)",
                "System.String"
                );
            System.String? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (System.String)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereVmDeleteSnapshot(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	location = <DeleteVmwareSnapshotRequestLocation> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeleteVmwareSnapshotRequestLocation]) for enum values.
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // vsphereVmInitiateInstantRecoveryV2(input: VsphereVmInitiateInstantRecoveryV2Input!): AsyncRequestStatus!
        internal void InvokeMutationVsphereVmInitiateInstantRecoveryV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmInitiateInstantRecoveryV2Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmInitiateInstantRecoveryV2",
                "($input: VsphereVmInitiateInstantRecoveryV2Input!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereVmInitiateInstantRecoveryV2(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		hostId = <System.String>
		# OPTIONAL
		preserveMoid = <System.Boolean>
		# OPTIONAL
		shouldRecoverTags = <System.Boolean>
		# OPTIONAL
		vlan = <System.Int32>
		# OPTIONAL
		clusterId = <System.String>
		# OPTIONAL
		resourcePoolId = <System.String>
		# OPTIONAL
		vNicBindings = @(
			@{
				# REQUIRED
				backingNetworkInfo = @{
					# REQUIRED
					moid = <System.String>
					# REQUIRED
					name = <System.String>
				}
				# REQUIRED
				networkDeviceInfo = @{
					# REQUIRED
					key = <System.Int32>
					# REQUIRED
					name = <System.String>
				}
			}
		)
		# OPTIONAL
		mountExportSnapshotJobCommonOptionsV2 = @{
			# OPTIONAL
			disableNetwork = <System.Boolean>
			# OPTIONAL
			keepMacAddresses = <System.Boolean>
			# OPTIONAL
			powerOn = <System.Boolean>
			# OPTIONAL
			removeNetworkDevices = <System.Boolean>
			# OPTIONAL
			vmName = <System.String>
		}
		# OPTIONAL
		requiredRecoveryParameters = @{
			# OPTIONAL
			recoveryPoint = <DateTime>
			# OPTIONAL
			snapshotId = <System.String>
		}
		# OPTIONAL
		migrationConfig = @{
			# OPTIONAL
			diskDeviceKeyToStorageId = @(
				@{
					# OPTIONAL
					storageLocationId = <System.String>
					# REQUIRED
					deviceKey = <System.Int32>
				}
			)
			# OPTIONAL
			storageLocationId = <System.String>
			# OPTIONAL
			computeClusterId = <System.String>
			# OPTIONAL
			hostId = <System.String>
			# OPTIONAL
			networkDeviceKeyToNetworkName = @(
				@{
					# REQUIRED
					deviceKey = <System.Int32>
					# REQUIRED
					networkName = <System.String>
				}
			)
			# OPTIONAL
			resourcePoolId = <System.String>
		}
		# OPTIONAL
		shouldMigrateImmediately = <System.Boolean>
	}
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // vsphereVmInitiateBatchInstantRecovery(input: VsphereVmInitiateBatchInstantRecoveryInput!): BatchAsyncRequestStatus!
        internal void InvokeMutationVsphereVmInitiateBatchInstantRecovery()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmInitiateBatchInstantRecoveryInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmInitiateBatchInstantRecovery",
                "($input: VsphereVmInitiateBatchInstantRecoveryInput!)",
                "BatchAsyncRequestStatus"
                );
            BatchAsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (BatchAsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereVmInitiateBatchInstantRecovery(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
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
				config = @{
					# OPTIONAL
					hostId = <System.String>
					# OPTIONAL
					preserveMoid = <System.Boolean>
					# OPTIONAL
					shouldRecoverTags = <System.Boolean>
					# OPTIONAL
					vlan = <System.Int32>
					# OPTIONAL
					clusterId = <System.String>
					# OPTIONAL
					resourcePoolId = <System.String>
					# OPTIONAL
					vNicBindings = @(
						@{
							# REQUIRED
							backingNetworkInfo = @{
								# REQUIRED
								moid = <System.String>
								# REQUIRED
								name = <System.String>
							}
							# REQUIRED
							networkDeviceInfo = @{
								# REQUIRED
								key = <System.Int32>
								# REQUIRED
								name = <System.String>
							}
						}
					)
					# OPTIONAL
					mountExportSnapshotJobCommonOptionsV2 = @{
						# OPTIONAL
						disableNetwork = <System.Boolean>
						# OPTIONAL
						keepMacAddresses = <System.Boolean>
						# OPTIONAL
						powerOn = <System.Boolean>
						# OPTIONAL
						removeNetworkDevices = <System.Boolean>
						# OPTIONAL
						vmName = <System.String>
					}
					# OPTIONAL
					requiredRecoveryParameters = @{
						# OPTIONAL
						recoveryPoint = <DateTime>
						# OPTIONAL
						snapshotId = <System.String>
					}
					# OPTIONAL
					migrationConfig = @{
						# OPTIONAL
						diskDeviceKeyToStorageId = @(
							@{
								# OPTIONAL
								storageLocationId = <System.String>
								# REQUIRED
								deviceKey = <System.Int32>
							}
						)
						# OPTIONAL
						storageLocationId = <System.String>
						# OPTIONAL
						computeClusterId = <System.String>
						# OPTIONAL
						hostId = <System.String>
						# OPTIONAL
						networkDeviceKeyToNetworkName = @(
							@{
								# REQUIRED
								deviceKey = <System.Int32>
								# REQUIRED
								networkName = <System.String>
							}
						)
						# OPTIONAL
						resourcePoolId = <System.String>
					}
					# OPTIONAL
					shouldMigrateImmediately = <System.Boolean>
				}
				# REQUIRED
				vmId = <System.String>
			}
		)
	}
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // vsphereVmInitiateDiskMount(input: VsphereVmInitiateDiskMountInput!): AsyncRequestStatus!
        internal void InvokeMutationVsphereVmInitiateDiskMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmInitiateDiskMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmInitiateDiskMount",
                "($input: VsphereVmInitiateDiskMountInput!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereVmInitiateDiskMount(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		targetVmId = <System.String>
		# OPTIONAL
		vlan = <System.Int32>
		# OPTIONAL
		vmdkIds = @(
			<System.String>
		)
	}
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // vsphereVmInitiateLiveMountV2(input: VsphereVmInitiateLiveMountV2Input!): AsyncRequestStatus!
        internal void InvokeMutationVsphereVmInitiateLiveMountV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmInitiateLiveMountV2Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmInitiateLiveMountV2",
                "($input: VsphereVmInitiateLiveMountV2Input!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereVmInitiateLiveMountV2(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	config = @{
		# OPTIONAL
		createDatastoreOnly = <System.Boolean>
		# OPTIONAL
		dataStoreName = <System.String>
		# OPTIONAL
		hostId = <System.String>
		# OPTIONAL
		shouldRecoverTags = <System.Boolean>
		# OPTIONAL
		vlan = <System.Int32>
		# OPTIONAL
		clusterId = <System.String>
		# OPTIONAL
		resourcePoolId = <System.String>
		# OPTIONAL
		vNicBindings = @(
			@{
				# REQUIRED
				backingNetworkInfo = @{
					# REQUIRED
					moid = <System.String>
					# REQUIRED
					name = <System.String>
				}
				# REQUIRED
				networkDeviceInfo = @{
					# REQUIRED
					key = <System.Int32>
					# REQUIRED
					name = <System.String>
				}
			}
		)
		# OPTIONAL
		migrationConfig = @{
			# OPTIONAL
			diskDeviceKeyToStorageId = @(
				@{
					# OPTIONAL
					storageLocationId = <System.String>
					# REQUIRED
					deviceKey = <System.Int32>
				}
			)
			# OPTIONAL
			storageLocationId = <System.String>
			# OPTIONAL
			computeClusterId = <System.String>
			# OPTIONAL
			hostId = <System.String>
			# OPTIONAL
			networkDeviceKeyToNetworkName = @(
				@{
					# REQUIRED
					deviceKey = <System.Int32>
					# REQUIRED
					networkName = <System.String>
				}
			)
			# OPTIONAL
			resourcePoolId = <System.String>
		}
		# OPTIONAL
		shouldMigrateImmediately = <System.Boolean>
		# OPTIONAL
		mountExportSnapshotJobCommonOptionsV2 = @{
			# OPTIONAL
			disableNetwork = <System.Boolean>
			# OPTIONAL
			keepMacAddresses = <System.Boolean>
			# OPTIONAL
			powerOn = <System.Boolean>
			# OPTIONAL
			removeNetworkDevices = <System.Boolean>
			# OPTIONAL
			vmName = <System.String>
		}
		# OPTIONAL
		requiredRecoveryParameters = @{
			# OPTIONAL
			recoveryPoint = <DateTime>
			# OPTIONAL
			snapshotId = <System.String>
		}
		# OPTIONAL
		folderId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // vsphereVmInitiateBatchLiveMountV2(input: VsphereVmInitiateBatchLiveMountV2Input!): BatchAsyncRequestStatus!
        internal void InvokeMutationVsphereVmInitiateBatchLiveMountV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmInitiateBatchLiveMountV2Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmInitiateBatchLiveMountV2",
                "($input: VsphereVmInitiateBatchLiveMountV2Input!)",
                "BatchAsyncRequestStatus"
                );
            BatchAsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (BatchAsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereVmInitiateBatchLiveMountV2(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
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
				config = @{
					# OPTIONAL
					createDatastoreOnly = <System.Boolean>
					# OPTIONAL
					dataStoreName = <System.String>
					# OPTIONAL
					hostId = <System.String>
					# OPTIONAL
					shouldRecoverTags = <System.Boolean>
					# OPTIONAL
					vlan = <System.Int32>
					# OPTIONAL
					clusterId = <System.String>
					# OPTIONAL
					resourcePoolId = <System.String>
					# OPTIONAL
					vNicBindings = @(
						@{
							# REQUIRED
							backingNetworkInfo = @{
								# REQUIRED
								moid = <System.String>
								# REQUIRED
								name = <System.String>
							}
							# REQUIRED
							networkDeviceInfo = @{
								# REQUIRED
								key = <System.Int32>
								# REQUIRED
								name = <System.String>
							}
						}
					)
					# OPTIONAL
					migrationConfig = @{
						# OPTIONAL
						diskDeviceKeyToStorageId = @(
							@{
								# OPTIONAL
								storageLocationId = <System.String>
								# REQUIRED
								deviceKey = <System.Int32>
							}
						)
						# OPTIONAL
						storageLocationId = <System.String>
						# OPTIONAL
						computeClusterId = <System.String>
						# OPTIONAL
						hostId = <System.String>
						# OPTIONAL
						networkDeviceKeyToNetworkName = @(
							@{
								# REQUIRED
								deviceKey = <System.Int32>
								# REQUIRED
								networkName = <System.String>
							}
						)
						# OPTIONAL
						resourcePoolId = <System.String>
					}
					# OPTIONAL
					shouldMigrateImmediately = <System.Boolean>
					# OPTIONAL
					mountExportSnapshotJobCommonOptionsV2 = @{
						# OPTIONAL
						disableNetwork = <System.Boolean>
						# OPTIONAL
						keepMacAddresses = <System.Boolean>
						# OPTIONAL
						powerOn = <System.Boolean>
						# OPTIONAL
						removeNetworkDevices = <System.Boolean>
						# OPTIONAL
						vmName = <System.String>
					}
					# OPTIONAL
					requiredRecoveryParameters = @{
						# OPTIONAL
						recoveryPoint = <DateTime>
						# OPTIONAL
						snapshotId = <System.String>
					}
					# OPTIONAL
					folderId = <System.String>
				}
				# REQUIRED
				vmId = <System.String>
			}
		)
	}
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // vsphereVmPowerOnOffLiveMount(input: VsphereVmPowerOnOffLiveMountInput!): VsphereVmPowerOnOffLiveMountReply!
        internal void InvokeMutationVsphereVmPowerOnOffLiveMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmPowerOnOffLiveMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmPowerOnOffLiveMount",
                "($input: VsphereVmPowerOnOffLiveMountInput!)",
                "VsphereVmPowerOnOffLiveMountReply"
                );
            VsphereVmPowerOnOffLiveMountReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (VsphereVmPowerOnOffLiveMountReply)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereVmPowerOnOffLiveMount(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		shouldForce = <System.Boolean>
		# REQUIRED
		powerStatus = <System.Boolean>
	}
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // vsphereVmListEsxiDatastores(input: VsphereVmListEsxiDatastoresInput!): VsphereVmListEsxiDatastoresReply!
        internal void InvokeMutationVsphereVmListEsxiDatastores()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmListEsxiDatastoresInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmListEsxiDatastores",
                "($input: VsphereVmListEsxiDatastoresInput!)",
                "VsphereVmListEsxiDatastoresReply"
                );
            VsphereVmListEsxiDatastoresReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (VsphereVmListEsxiDatastoresReply)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereVmListEsxiDatastores(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	loginInfo = @{
		# REQUIRED
		ip = <System.String>
		# REQUIRED
		password = <System.String>
		# REQUIRED
		username = <System.String>
	}
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // vsphereVmMountRelocate(input: VsphereVmMountRelocateInput!): AsyncRequestStatus!
        internal void InvokeMutationVsphereVmMountRelocate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmMountRelocateInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmMountRelocate",
                "($input: VsphereVmMountRelocateInput!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereVmMountRelocate(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		datastoreId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // vsphereVmMountRelocateV2(input: VsphereVmMountRelocateV2Input!): AsyncRequestStatus!
        internal void InvokeMutationVsphereVmMountRelocateV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmMountRelocateV2Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmMountRelocateV2",
                "($input: VsphereVmMountRelocateV2Input!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereVmMountRelocateV2(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		diskDeviceKeyToStorageId = @(
			@{
				# OPTIONAL
				storageLocationId = <System.String>
				# REQUIRED
				deviceKey = <System.Int32>
			}
		)
		# OPTIONAL
		storageLocationId = <System.String>
		# OPTIONAL
		computeClusterId = <System.String>
		# OPTIONAL
		hostId = <System.String>
		# OPTIONAL
		networkDeviceKeyToNetworkName = @(
			@{
				# REQUIRED
				deviceKey = <System.Int32>
				# REQUIRED
				networkName = <System.String>
			}
		)
		# OPTIONAL
		resourcePoolId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // vsphereExcludeVmDisks(input: [VsphereExcludeVmDisksInput!]!): RequestSuccess!
        internal void InvokeMutationVsphereExcludeVmDisks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "[VsphereExcludeVmDisksInput!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereExcludeVmDisks",
                "($input: [VsphereExcludeVmDisksInput!]!)",
                "RequestSuccess"
                );
            RequestSuccess? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (RequestSuccess)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereExcludeVmDisks(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @(
	@{
		# REQUIRED
		virtualDiskFid = <System.String>
		# OPTIONAL
		excludeFromSnapshots = <System.Boolean>
}
)";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // vsphereVmDownloadSnapshotFiles(input: VsphereVmDownloadSnapshotFilesInput!): AsyncRequestStatus!
        internal void InvokeMutationVsphereVmDownloadSnapshotFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmDownloadSnapshotFilesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmDownloadSnapshotFiles",
                "($input: VsphereVmDownloadSnapshotFilesInput!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereVmDownloadSnapshotFiles(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snapshotFid = <System.String>
	# REQUIRED
	paths = @(
		<System.String>
	)
	# OPTIONAL
	deltaTypeFilter = @(
		<DeltaType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeltaType]) for enum values.
	)
	# OPTIONAL
	nextSnapshotFid = <System.String>
	# OPTIONAL
	isLegalHoldDownload = <System.Boolean>
	# OPTIONAL
	userNote = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // updateVsphereVm(input: UpdateVsphereVmInput!): RequestSuccess!
        internal void InvokeMutationUpdateVsphereVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateVsphereVmInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateVsphereVm",
                "($input: UpdateVsphereVmInput!)",
                "RequestSuccess"
                );
            RequestSuccess? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (RequestSuccess)this.Field;
            }
            string fieldSpecDoc = Mutation.UpdateVsphereVm(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	vmUpdateProperties = @{
		# OPTIONAL
		guestCredential = @{
			# REQUIRED
			password = <System.String>
			# REQUIRED
			username = <System.String>
		}
		# OPTIONAL
		shouldRefreshCacheAfterUpdate = <System.Boolean>
		# OPTIONAL
		guestCredentialId = <System.String>
		# OPTIONAL
		virtualMachineUpdate = @{
			# OPTIONAL
			cloudInstantiationSpec = @{
				# REQUIRED
				imageRetentionInSeconds = <System.Int64>
			}
			# OPTIONAL
			configuredSlaDomainId = <System.String>
			# OPTIONAL
			isArrayIntegrationEnabled = <System.Boolean>
			# OPTIONAL
			isVmPaused = <System.Boolean>
			# OPTIONAL
			maxNestedVsphereSnapshots = <System.Int32>
			# OPTIONAL
			postBackupScript = @{
				# REQUIRED
				failureHandling = <VirtualMachineScriptDetailFailureHandling> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VirtualMachineScriptDetailFailureHandling]) for enum values.
				# REQUIRED
				scriptPath = <System.String>
				# REQUIRED
				timeoutMs = <System.Int64>
			}
			# OPTIONAL
			postSnapScript = @{
				# REQUIRED
				failureHandling = <VirtualMachineScriptDetailFailureHandling> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VirtualMachineScriptDetailFailureHandling]) for enum values.
				# REQUIRED
				scriptPath = <System.String>
				# REQUIRED
				timeoutMs = <System.Int64>
			}
			# OPTIONAL
			preBackupScript = @{
				# REQUIRED
				failureHandling = <VirtualMachineScriptDetailFailureHandling> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VirtualMachineScriptDetailFailureHandling]) for enum values.
				# REQUIRED
				scriptPath = <System.String>
				# REQUIRED
				timeoutMs = <System.Int64>
			}
			# OPTIONAL
			throttlingSettings = @{
				# OPTIONAL
				cpuUtilizationThreshold = <System.Int32>
				# OPTIONAL
				datastoreIoLatencyThreshold = <System.Int32>
				# OPTIONAL
				ioLatencyThreshold = <System.Int32>
			}
			# OPTIONAL
			snapshotConsistencyMandate = <VirtualMachineUpdateSnapshotConsistencyMandate> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VirtualMachineUpdateSnapshotConsistencyMandate]) for enum values.
		}
	}
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }


    } // class Invoke_RscMutateVsphereVm
}