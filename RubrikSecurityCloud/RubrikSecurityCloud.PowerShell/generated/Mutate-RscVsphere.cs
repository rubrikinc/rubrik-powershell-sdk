// Mutate-RscVsphere.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:43.
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
using Rubrik.SecurityCloud.NetSDK.Library.HelperClasses;
using Rubrik.SecurityCloud.Operations;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Mutate",
        "RscVsphere",
        DefaultParameterSetName = "updateVm")
    ]
    public class Mutate_RscVsphere : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // VmRecoverFile parameter set
        //
        // GraphQL operation: vsphereVmRecoverFiles(input: VsphereVmRecoverFilesInput!):VsphereAsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "VmRecoverFile",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereVmRecoverFiles(input: VsphereVmRecoverFilesInput!):VsphereAsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter VmRecoverFile { get; set; }

        [Parameter(
            ParameterSetName = "VmRecoverFile",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument input: VsphereVmRecoverFilesInput!"
        )]
        public VsphereVmRecoverFilesInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // VmRecoverFilesNew parameter set
        //
        // GraphQL operation: vsphereVmRecoverFilesNew(input: VsphereVmRecoverFilesNewInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "VmRecoverFilesNew",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereVmRecoverFilesNew(input: VsphereVmRecoverFilesNewInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter VmRecoverFilesNew { get; set; }

        
        // -------------------------------------------------------------------
        // VmRegisterAgent parameter set
        //
        // GraphQL operation: vsphereVmRegisterAgent(input: VsphereVmRegisterAgentInput!):RequestSuccess!
        //
        [Parameter(
            ParameterSetName = "VmRegisterAgent",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereVmRegisterAgent(input: VsphereVmRegisterAgentInput!):RequestSuccess!",
            Position = 0
        )]
        public SwitchParameter VmRegisterAgent { get; set; }

        
        // -------------------------------------------------------------------
        // OnDemandSnapshot parameter set
        //
        // GraphQL operation: vsphereOnDemandSnapshot(input: VsphereOnDemandSnapshotInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "OnDemandSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereOnDemandSnapshot(input: VsphereOnDemandSnapshotInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter OnDemandSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // BulkOnDemandSnapshot parameter set
        //
        // GraphQL operation: vsphereBulkOnDemandSnapshot(input: VsphereBulkOnDemandSnapshotInput!):BatchAsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "BulkOnDemandSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereBulkOnDemandSnapshot(input: VsphereBulkOnDemandSnapshotInput!):BatchAsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter BulkOnDemandSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // VmDownloadSnapshot parameter set
        //
        // GraphQL operation: vsphereVmDownloadSnapshot(input: VsphereVmDownloadSnapshotInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "VmDownloadSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereVmDownloadSnapshot(input: VsphereVmDownloadSnapshotInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter VmDownloadSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // VmExportSnapshotV2 parameter set
        //
        // GraphQL operation: vsphereVmExportSnapshotV2(input: VsphereVmExportSnapshotV2Input!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "VmExportSnapshotV2",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereVmExportSnapshotV2(input: VsphereVmExportSnapshotV2Input!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter VmExportSnapshotV2 { get; set; }

        
        // -------------------------------------------------------------------
        // VmExportSnapshotV3 parameter set
        //
        // GraphQL operation: vsphereVmExportSnapshotV3(input: VsphereVmExportSnapshotV3Input!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "VmExportSnapshotV3",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereVmExportSnapshotV3(input: VsphereVmExportSnapshotV3Input!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter VmExportSnapshotV3 { get; set; }

        
        // -------------------------------------------------------------------
        // VmBatchExport parameter set
        //
        // GraphQL operation: vsphereVmBatchExport(input: VsphereVmBatchExportInput!):BatchAsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "VmBatchExport",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereVmBatchExport(input: VsphereVmBatchExportInput!):BatchAsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter VmBatchExport { get; set; }

        
        // -------------------------------------------------------------------
        // VmInitiateInPlaceRecovery parameter set
        //
        // GraphQL operation: vsphereVmInitiateInPlaceRecovery(input: VsphereVmInitiateInPlaceRecoveryInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "VmInitiateInPlaceRecovery",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereVmInitiateInPlaceRecovery(input: VsphereVmInitiateInPlaceRecoveryInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter VmInitiateInPlaceRecovery { get; set; }

        
        // -------------------------------------------------------------------
        // VmExportSnapshotWithDownloadFromCloud parameter set
        //
        // GraphQL operation: vsphereVmExportSnapshotWithDownloadFromCloud(input: VsphereVmExportSnapshotWithDownloadFromCloudInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "VmExportSnapshotWithDownloadFromCloud",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereVmExportSnapshotWithDownloadFromCloud(input: VsphereVmExportSnapshotWithDownloadFromCloudInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter VmExportSnapshotWithDownloadFromCloud { get; set; }

        
        // -------------------------------------------------------------------
        // VmBatchInPlaceRecovery parameter set
        //
        // GraphQL operation: vsphereVmBatchInPlaceRecovery(input: VsphereVmBatchInPlaceRecoveryInput!):BatchAsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "VmBatchInPlaceRecovery",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereVmBatchInPlaceRecovery(input: VsphereVmBatchInPlaceRecoveryInput!):BatchAsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter VmBatchInPlaceRecovery { get; set; }

        
        // -------------------------------------------------------------------
        // VmDeleteSnapshot parameter set
        //
        // GraphQL operation: vsphereVmDeleteSnapshot(input: VsphereVmDeleteSnapshotInput!):Void
        //
        [Parameter(
            ParameterSetName = "VmDeleteSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereVmDeleteSnapshot(input: VsphereVmDeleteSnapshotInput!):Void",
            Position = 0
        )]
        public SwitchParameter VmDeleteSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // VmInitiateInstantRecoveryV2 parameter set
        //
        // GraphQL operation: vsphereVmInitiateInstantRecoveryV2(input: VsphereVmInitiateInstantRecoveryV2Input!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "VmInitiateInstantRecoveryV2",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereVmInitiateInstantRecoveryV2(input: VsphereVmInitiateInstantRecoveryV2Input!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter VmInitiateInstantRecoveryV2 { get; set; }

        
        // -------------------------------------------------------------------
        // VmInitiateBatchInstantRecovery parameter set
        //
        // GraphQL operation: vsphereVmInitiateBatchInstantRecovery(input: VsphereVmInitiateBatchInstantRecoveryInput!):BatchAsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "VmInitiateBatchInstantRecovery",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereVmInitiateBatchInstantRecovery(input: VsphereVmInitiateBatchInstantRecoveryInput!):BatchAsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter VmInitiateBatchInstantRecovery { get; set; }

        
        // -------------------------------------------------------------------
        // VmInitiateDiskMount parameter set
        //
        // GraphQL operation: vsphereVmInitiateDiskMount(input: VsphereVmInitiateDiskMountInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "VmInitiateDiskMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereVmInitiateDiskMount(input: VsphereVmInitiateDiskMountInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter VmInitiateDiskMount { get; set; }

        
        // -------------------------------------------------------------------
        // VmInitiateLiveMountV2 parameter set
        //
        // GraphQL operation: vsphereVmInitiateLiveMountV2(input: VsphereVmInitiateLiveMountV2Input!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "VmInitiateLiveMountV2",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereVmInitiateLiveMountV2(input: VsphereVmInitiateLiveMountV2Input!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter VmInitiateLiveMountV2 { get; set; }

        
        // -------------------------------------------------------------------
        // VmInitiateBatchLiveMountV2 parameter set
        //
        // GraphQL operation: vsphereVmInitiateBatchLiveMountV2(input: VsphereVmInitiateBatchLiveMountV2Input!):BatchAsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "VmInitiateBatchLiveMountV2",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereVmInitiateBatchLiveMountV2(input: VsphereVmInitiateBatchLiveMountV2Input!):BatchAsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter VmInitiateBatchLiveMountV2 { get; set; }

        
        // -------------------------------------------------------------------
        // VmPowerOnOffLiveMount parameter set
        //
        // GraphQL operation: vsphereVmPowerOnOffLiveMount(input: VsphereVmPowerOnOffLiveMountInput!):VsphereVmPowerOnOffLiveMountReply!
        //
        [Parameter(
            ParameterSetName = "VmPowerOnOffLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereVmPowerOnOffLiveMount(input: VsphereVmPowerOnOffLiveMountInput!):VsphereVmPowerOnOffLiveMountReply!",
            Position = 0
        )]
        public SwitchParameter VmPowerOnOffLiveMount { get; set; }

        
        // -------------------------------------------------------------------
        // deleteLiveMount parameter set
        //
        // GraphQL operation: deleteVsphereLiveMount(input: DeleteVsphereLiveMountInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "deleteLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: deleteVsphereLiveMount(input: DeleteVsphereLiveMountInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter deleteLiveMount { get; set; }

        
        // -------------------------------------------------------------------
        // VmListEsxiDatastore parameter set
        //
        // GraphQL operation: vsphereVmListEsxiDatastores(input: VsphereVmListEsxiDatastoresInput!):VsphereVmListEsxiDatastoresReply!
        //
        [Parameter(
            ParameterSetName = "VmListEsxiDatastore",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereVmListEsxiDatastores(input: VsphereVmListEsxiDatastoresInput!):VsphereVmListEsxiDatastoresReply!",
            Position = 0
        )]
        public SwitchParameter VmListEsxiDatastore { get; set; }

        
        // -------------------------------------------------------------------
        // ExportSnapshotToStandaloneHostV2 parameter set
        //
        // GraphQL operation: vsphereExportSnapshotToStandaloneHostV2(input: VsphereExportSnapshotToStandaloneHostV2Input!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "ExportSnapshotToStandaloneHostV2",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereExportSnapshotToStandaloneHostV2(input: VsphereExportSnapshotToStandaloneHostV2Input!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter ExportSnapshotToStandaloneHostV2 { get; set; }

        
        // -------------------------------------------------------------------
        // createVcenter parameter set
        //
        // GraphQL operation: createVsphereVcenter(input: CreateVsphereVcenterInput!):CreateVsphereVcenterReply!
        //
        [Parameter(
            ParameterSetName = "createVcenter",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: createVsphereVcenter(input: CreateVsphereVcenterInput!):CreateVsphereVcenterReply!",
            Position = 0
        )]
        public SwitchParameter createVcenter { get; set; }

        
        // -------------------------------------------------------------------
        // DeleteVcenter parameter set
        //
        // GraphQL operation: vsphereDeleteVcenter(input: VsphereDeleteVcenterInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "DeleteVcenter",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereDeleteVcenter(input: VsphereDeleteVcenterInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter DeleteVcenter { get; set; }

        
        // -------------------------------------------------------------------
        // refreshVcenter parameter set
        //
        // GraphQL operation: refreshVsphereVcenter(input: RefreshVsphereVcenterInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "refreshVcenter",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: refreshVsphereVcenter(input: RefreshVsphereVcenterInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter refreshVcenter { get; set; }

        
        // -------------------------------------------------------------------
        // VmMountRelocate parameter set
        //
        // GraphQL operation: vsphereVmMountRelocate(input: VsphereVmMountRelocateInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "VmMountRelocate",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereVmMountRelocate(input: VsphereVmMountRelocateInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter VmMountRelocate { get; set; }

        
        // -------------------------------------------------------------------
        // VmMountRelocateV2 parameter set
        //
        // GraphQL operation: vsphereVmMountRelocateV2(input: VsphereVmMountRelocateV2Input!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "VmMountRelocateV2",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereVmMountRelocateV2(input: VsphereVmMountRelocateV2Input!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter VmMountRelocateV2 { get; set; }

        
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
            HelpMessage = "GraphQL operation: vsphereExcludeVmDisks(input: [VsphereExcludeVmDisksInput!]!):RequestSuccess!",
            Position = 0
        )]
        public SwitchParameter ExcludeVmDisk { get; set; }

        
        // -------------------------------------------------------------------
        // VmDownloadSnapshotFile parameter set
        //
        // GraphQL operation: vsphereVmDownloadSnapshotFiles(input: VsphereVmDownloadSnapshotFilesInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "VmDownloadSnapshotFile",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereVmDownloadSnapshotFiles(input: VsphereVmDownloadSnapshotFilesInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter VmDownloadSnapshotFile { get; set; }

        
        // -------------------------------------------------------------------
        // updateVm parameter set
        //
        // GraphQL operation: updateVsphereVm(input: UpdateVsphereVmInput!):RequestSuccess!
        //
        [Parameter(
            ParameterSetName = "updateVm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: updateVsphereVm(input: UpdateVsphereVmInput!):RequestSuccess!",
            Position = 0
        )]
        public SwitchParameter updateVm { get; set; }

        
        // -------------------------------------------------------------------
        // createAdvancedTag parameter set
        //
        // GraphQL operation: createVsphereAdvancedTag(input: CreateVsphereAdvancedTagInput!):CreateVsphereAdvancedTagReply!
        //
        [Parameter(
            ParameterSetName = "createAdvancedTag",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: createVsphereAdvancedTag(input: CreateVsphereAdvancedTagInput!):CreateVsphereAdvancedTagReply!",
            Position = 0
        )]
        public SwitchParameter createAdvancedTag { get; set; }

        
        // -------------------------------------------------------------------
        // deleteAdvancedTag parameter set
        //
        // GraphQL operation: deleteVsphereAdvancedTag(input: DeleteVsphereAdvancedTagInput!):RequestSuccess!
        //
        [Parameter(
            ParameterSetName = "deleteAdvancedTag",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: deleteVsphereAdvancedTag(input: DeleteVsphereAdvancedTagInput!):RequestSuccess!",
            Position = 0
        )]
        public SwitchParameter deleteAdvancedTag { get; set; }

        
        // -------------------------------------------------------------------
        // updateAdvancedTag parameter set
        //
        // GraphQL operation: updateVsphereAdvancedTag(input: UpdateVsphereAdvancedTagInput!):UpdateVsphereAdvancedTagReply!
        //
        [Parameter(
            ParameterSetName = "updateAdvancedTag",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: updateVsphereAdvancedTag(input: UpdateVsphereAdvancedTagInput!):UpdateVsphereAdvancedTagReply!",
            Position = 0
        )]
        public SwitchParameter updateAdvancedTag { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "VmRecoverFile":
                        this.ProcessRecord_VmRecoverFile();
                        break;
                    case "VmRecoverFilesNew":
                        this.ProcessRecord_VmRecoverFilesNew();
                        break;
                    case "VmRegisterAgent":
                        this.ProcessRecord_VmRegisterAgent();
                        break;
                    case "OnDemandSnapshot":
                        this.ProcessRecord_OnDemandSnapshot();
                        break;
                    case "BulkOnDemandSnapshot":
                        this.ProcessRecord_BulkOnDemandSnapshot();
                        break;
                    case "VmDownloadSnapshot":
                        this.ProcessRecord_VmDownloadSnapshot();
                        break;
                    case "VmExportSnapshotV2":
                        this.ProcessRecord_VmExportSnapshotV2();
                        break;
                    case "VmExportSnapshotV3":
                        this.ProcessRecord_VmExportSnapshotV3();
                        break;
                    case "VmBatchExport":
                        this.ProcessRecord_VmBatchExport();
                        break;
                    case "VmInitiateInPlaceRecovery":
                        this.ProcessRecord_VmInitiateInPlaceRecovery();
                        break;
                    case "VmExportSnapshotWithDownloadFromCloud":
                        this.ProcessRecord_VmExportSnapshotWithDownloadFromCloud();
                        break;
                    case "VmBatchInPlaceRecovery":
                        this.ProcessRecord_VmBatchInPlaceRecovery();
                        break;
                    case "VmDeleteSnapshot":
                        this.ProcessRecord_VmDeleteSnapshot();
                        break;
                    case "VmInitiateInstantRecoveryV2":
                        this.ProcessRecord_VmInitiateInstantRecoveryV2();
                        break;
                    case "VmInitiateBatchInstantRecovery":
                        this.ProcessRecord_VmInitiateBatchInstantRecovery();
                        break;
                    case "VmInitiateDiskMount":
                        this.ProcessRecord_VmInitiateDiskMount();
                        break;
                    case "VmInitiateLiveMountV2":
                        this.ProcessRecord_VmInitiateLiveMountV2();
                        break;
                    case "VmInitiateBatchLiveMountV2":
                        this.ProcessRecord_VmInitiateBatchLiveMountV2();
                        break;
                    case "VmPowerOnOffLiveMount":
                        this.ProcessRecord_VmPowerOnOffLiveMount();
                        break;
                    case "deleteLiveMount":
                        this.ProcessRecord_deleteLiveMount();
                        break;
                    case "VmListEsxiDatastore":
                        this.ProcessRecord_VmListEsxiDatastore();
                        break;
                    case "ExportSnapshotToStandaloneHostV2":
                        this.ProcessRecord_ExportSnapshotToStandaloneHostV2();
                        break;
                    case "createVcenter":
                        this.ProcessRecord_createVcenter();
                        break;
                    case "DeleteVcenter":
                        this.ProcessRecord_DeleteVcenter();
                        break;
                    case "refreshVcenter":
                        this.ProcessRecord_refreshVcenter();
                        break;
                    case "VmMountRelocate":
                        this.ProcessRecord_VmMountRelocate();
                        break;
                    case "VmMountRelocateV2":
                        this.ProcessRecord_VmMountRelocateV2();
                        break;
                    case "ExcludeVmDisk":
                        this.ProcessRecord_ExcludeVmDisk();
                        break;
                    case "VmDownloadSnapshotFile":
                        this.ProcessRecord_VmDownloadSnapshotFile();
                        break;
                    case "updateVm":
                        this.ProcessRecord_updateVm();
                        break;
                    case "createAdvancedTag":
                        this.ProcessRecord_createAdvancedTag();
                        break;
                    case "deleteAdvancedTag":
                        this.ProcessRecord_deleteAdvancedTag();
                        break;
                    case "updateAdvancedTag":
                        this.ProcessRecord_updateAdvancedTag();
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
                    "Mutate-RscVsphere",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
           }
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmRecoverFiles.
        protected void ProcessRecord_VmRecoverFile()
        {
            this._logger.name += " -VmRecoverFile";
            // Invoke graphql operation vsphereVmRecoverFiles
            InvokeMutationVsphereVmRecoverFiles();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmRecoverFilesNew.
        protected void ProcessRecord_VmRecoverFilesNew()
        {
            this._logger.name += " -VmRecoverFilesNew";
            // Invoke graphql operation vsphereVmRecoverFilesNew
            InvokeMutationVsphereVmRecoverFilesNew();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmRegisterAgent.
        protected void ProcessRecord_VmRegisterAgent()
        {
            this._logger.name += " -VmRegisterAgent";
            // Invoke graphql operation vsphereVmRegisterAgent
            InvokeMutationVsphereVmRegisterAgent();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereOnDemandSnapshot.
        protected void ProcessRecord_OnDemandSnapshot()
        {
            this._logger.name += " -OnDemandSnapshot";
            // Invoke graphql operation vsphereOnDemandSnapshot
            InvokeMutationVsphereOnDemandSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereBulkOnDemandSnapshot.
        protected void ProcessRecord_BulkOnDemandSnapshot()
        {
            this._logger.name += " -BulkOnDemandSnapshot";
            // Invoke graphql operation vsphereBulkOnDemandSnapshot
            InvokeMutationVsphereBulkOnDemandSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmDownloadSnapshot.
        protected void ProcessRecord_VmDownloadSnapshot()
        {
            this._logger.name += " -VmDownloadSnapshot";
            // Invoke graphql operation vsphereVmDownloadSnapshot
            InvokeMutationVsphereVmDownloadSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmExportSnapshotV2.
        protected void ProcessRecord_VmExportSnapshotV2()
        {
            this._logger.name += " -VmExportSnapshotV2";
            // Invoke graphql operation vsphereVmExportSnapshotV2
            InvokeMutationVsphereVmExportSnapshotV2();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmExportSnapshotV3.
        protected void ProcessRecord_VmExportSnapshotV3()
        {
            this._logger.name += " -VmExportSnapshotV3";
            // Invoke graphql operation vsphereVmExportSnapshotV3
            InvokeMutationVsphereVmExportSnapshotV3();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmBatchExport.
        protected void ProcessRecord_VmBatchExport()
        {
            this._logger.name += " -VmBatchExport";
            // Invoke graphql operation vsphereVmBatchExport
            InvokeMutationVsphereVmBatchExport();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmInitiateInPlaceRecovery.
        protected void ProcessRecord_VmInitiateInPlaceRecovery()
        {
            this._logger.name += " -VmInitiateInPlaceRecovery";
            // Invoke graphql operation vsphereVmInitiateInPlaceRecovery
            InvokeMutationVsphereVmInitiateInPlaceRecovery();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmExportSnapshotWithDownloadFromCloud.
        protected void ProcessRecord_VmExportSnapshotWithDownloadFromCloud()
        {
            this._logger.name += " -VmExportSnapshotWithDownloadFromCloud";
            // Invoke graphql operation vsphereVmExportSnapshotWithDownloadFromCloud
            InvokeMutationVsphereVmExportSnapshotWithDownloadFromCloud();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmBatchInPlaceRecovery.
        protected void ProcessRecord_VmBatchInPlaceRecovery()
        {
            this._logger.name += " -VmBatchInPlaceRecovery";
            // Invoke graphql operation vsphereVmBatchInPlaceRecovery
            InvokeMutationVsphereVmBatchInPlaceRecovery();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmDeleteSnapshot.
        protected void ProcessRecord_VmDeleteSnapshot()
        {
            this._logger.name += " -VmDeleteSnapshot";
            // Invoke graphql operation vsphereVmDeleteSnapshot
            InvokeMutationVsphereVmDeleteSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmInitiateInstantRecoveryV2.
        protected void ProcessRecord_VmInitiateInstantRecoveryV2()
        {
            this._logger.name += " -VmInitiateInstantRecoveryV2";
            // Invoke graphql operation vsphereVmInitiateInstantRecoveryV2
            InvokeMutationVsphereVmInitiateInstantRecoveryV2();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmInitiateBatchInstantRecovery.
        protected void ProcessRecord_VmInitiateBatchInstantRecovery()
        {
            this._logger.name += " -VmInitiateBatchInstantRecovery";
            // Invoke graphql operation vsphereVmInitiateBatchInstantRecovery
            InvokeMutationVsphereVmInitiateBatchInstantRecovery();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmInitiateDiskMount.
        protected void ProcessRecord_VmInitiateDiskMount()
        {
            this._logger.name += " -VmInitiateDiskMount";
            // Invoke graphql operation vsphereVmInitiateDiskMount
            InvokeMutationVsphereVmInitiateDiskMount();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmInitiateLiveMountV2.
        protected void ProcessRecord_VmInitiateLiveMountV2()
        {
            this._logger.name += " -VmInitiateLiveMountV2";
            // Invoke graphql operation vsphereVmInitiateLiveMountV2
            InvokeMutationVsphereVmInitiateLiveMountV2();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmInitiateBatchLiveMountV2.
        protected void ProcessRecord_VmInitiateBatchLiveMountV2()
        {
            this._logger.name += " -VmInitiateBatchLiveMountV2";
            // Invoke graphql operation vsphereVmInitiateBatchLiveMountV2
            InvokeMutationVsphereVmInitiateBatchLiveMountV2();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmPowerOnOffLiveMount.
        protected void ProcessRecord_VmPowerOnOffLiveMount()
        {
            this._logger.name += " -VmPowerOnOffLiveMount";
            // Invoke graphql operation vsphereVmPowerOnOffLiveMount
            InvokeMutationVsphereVmPowerOnOffLiveMount();
        }

        // This parameter set invokes a single graphql operation:
        // deleteVsphereLiveMount.
        protected void ProcessRecord_deleteLiveMount()
        {
            this._logger.name += " -deleteLiveMount";
            // Invoke graphql operation deleteVsphereLiveMount
            InvokeMutationDeleteVsphereLiveMount();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmListEsxiDatastores.
        protected void ProcessRecord_VmListEsxiDatastore()
        {
            this._logger.name += " -VmListEsxiDatastore";
            // Invoke graphql operation vsphereVmListEsxiDatastores
            InvokeMutationVsphereVmListEsxiDatastores();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereExportSnapshotToStandaloneHostV2.
        protected void ProcessRecord_ExportSnapshotToStandaloneHostV2()
        {
            this._logger.name += " -ExportSnapshotToStandaloneHostV2";
            // Invoke graphql operation vsphereExportSnapshotToStandaloneHostV2
            InvokeMutationVsphereExportSnapshotToStandaloneHostV2();
        }

        // This parameter set invokes a single graphql operation:
        // createVsphereVcenter.
        protected void ProcessRecord_createVcenter()
        {
            this._logger.name += " -createVcenter";
            // Invoke graphql operation createVsphereVcenter
            InvokeMutationCreateVsphereVcenter();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereDeleteVcenter.
        protected void ProcessRecord_DeleteVcenter()
        {
            this._logger.name += " -DeleteVcenter";
            // Invoke graphql operation vsphereDeleteVcenter
            InvokeMutationVsphereDeleteVcenter();
        }

        // This parameter set invokes a single graphql operation:
        // refreshVsphereVcenter.
        protected void ProcessRecord_refreshVcenter()
        {
            this._logger.name += " -refreshVcenter";
            // Invoke graphql operation refreshVsphereVcenter
            InvokeMutationRefreshVsphereVcenter();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmMountRelocate.
        protected void ProcessRecord_VmMountRelocate()
        {
            this._logger.name += " -VmMountRelocate";
            // Invoke graphql operation vsphereVmMountRelocate
            InvokeMutationVsphereVmMountRelocate();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmMountRelocateV2.
        protected void ProcessRecord_VmMountRelocateV2()
        {
            this._logger.name += " -VmMountRelocateV2";
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
        protected void ProcessRecord_VmDownloadSnapshotFile()
        {
            this._logger.name += " -VmDownloadSnapshotFile";
            // Invoke graphql operation vsphereVmDownloadSnapshotFiles
            InvokeMutationVsphereVmDownloadSnapshotFiles();
        }

        // This parameter set invokes a single graphql operation:
        // updateVsphereVm.
        protected void ProcessRecord_updateVm()
        {
            this._logger.name += " -updateVm";
            // Invoke graphql operation updateVsphereVm
            InvokeMutationUpdateVsphereVm();
        }

        // This parameter set invokes a single graphql operation:
        // createVsphereAdvancedTag.
        protected void ProcessRecord_createAdvancedTag()
        {
            this._logger.name += " -createAdvancedTag";
            // Invoke graphql operation createVsphereAdvancedTag
            InvokeMutationCreateVsphereAdvancedTag();
        }

        // This parameter set invokes a single graphql operation:
        // deleteVsphereAdvancedTag.
        protected void ProcessRecord_deleteAdvancedTag()
        {
            this._logger.name += " -deleteAdvancedTag";
            // Invoke graphql operation deleteVsphereAdvancedTag
            InvokeMutationDeleteVsphereAdvancedTag();
        }

        // This parameter set invokes a single graphql operation:
        // updateVsphereAdvancedTag.
        protected void ProcessRecord_updateAdvancedTag()
        {
            this._logger.name += " -updateAdvancedTag";
            // Invoke graphql operation updateVsphereAdvancedTag
            InvokeMutationUpdateVsphereAdvancedTag();
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VsphereAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (VsphereAsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereVmRecoverFiles(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmRecoverFiles");
            string parameters = "($input: VsphereVmRecoverFilesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmRecoverFiles" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmRecoverFiles",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VsphereAsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<VsphereAsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereVmRecoverFilesNew(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmRecoverFilesNew");
            string parameters = "($input: VsphereVmRecoverFilesNewInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmRecoverFilesNew" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmRecoverFilesNew",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (RequestSuccess)psObject.BaseObject;
                } else {
                    fields = (RequestSuccess)this.Field;
                }
            }
            string document = Mutation.VsphereVmRegisterAgent(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmRegisterAgent");
            string parameters = "($input: VsphereVmRegisterAgentInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmRegisterAgent" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmRegisterAgent",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<RequestSuccess> task = this._rbkClient.InvokeGenericCallAsync<RequestSuccess>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // vsphereOnDemandSnapshot(input: VsphereOnDemandSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationVsphereOnDemandSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereOnDemandSnapshotInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereOnDemandSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereOnDemandSnapshot");
            string parameters = "($input: VsphereOnDemandSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereOnDemandSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereOnDemandSnapshot",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // vsphereBulkOnDemandSnapshot(input: VsphereBulkOnDemandSnapshotInput!): BatchAsyncRequestStatus!
        protected void InvokeMutationVsphereBulkOnDemandSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereBulkOnDemandSnapshotInput!"),
            };
            BatchAsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BatchAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereBulkOnDemandSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereBulkOnDemandSnapshot");
            string parameters = "($input: VsphereBulkOnDemandSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereBulkOnDemandSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereBulkOnDemandSnapshot",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BatchAsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<BatchAsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereVmDownloadSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmDownloadSnapshot");
            string parameters = "($input: VsphereVmDownloadSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmDownloadSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmDownloadSnapshot",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereVmExportSnapshotV2(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmExportSnapshotV2");
            string parameters = "($input: VsphereVmExportSnapshotV2Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmExportSnapshotV2" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmExportSnapshotV2",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereVmExportSnapshotV3(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmExportSnapshotV3");
            string parameters = "($input: VsphereVmExportSnapshotV3Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmExportSnapshotV3" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmExportSnapshotV3",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BatchAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereVmBatchExport(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmBatchExport");
            string parameters = "($input: VsphereVmBatchExportInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmBatchExport" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmBatchExport",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BatchAsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<BatchAsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereVmInitiateInPlaceRecovery(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmInitiateInPlaceRecovery");
            string parameters = "($input: VsphereVmInitiateInPlaceRecoveryInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmInitiateInPlaceRecovery" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmInitiateInPlaceRecovery",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereVmExportSnapshotWithDownloadFromCloud(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmExportSnapshotWithDownloadFromCloud");
            string parameters = "($input: VsphereVmExportSnapshotWithDownloadFromCloudInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmExportSnapshotWithDownloadFromCloud" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmExportSnapshotWithDownloadFromCloud",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BatchAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereVmBatchInPlaceRecovery(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmBatchInPlaceRecovery");
            string parameters = "($input: VsphereVmBatchInPlaceRecoveryInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmBatchInPlaceRecovery" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmBatchInPlaceRecovery",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BatchAsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<BatchAsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (System.String)psObject.BaseObject;
                } else {
                    fields = (System.String)this.Field;
                }
            }
            string document = Mutation.VsphereVmDeleteSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmDeleteSnapshot");
            string parameters = "($input: VsphereVmDeleteSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmDeleteSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmDeleteSnapshot",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<System.String> task = this._rbkClient.InvokeGenericCallAsync<System.String>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereVmInitiateInstantRecoveryV2(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmInitiateInstantRecoveryV2");
            string parameters = "($input: VsphereVmInitiateInstantRecoveryV2Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmInitiateInstantRecoveryV2" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmInitiateInstantRecoveryV2",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BatchAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereVmInitiateBatchInstantRecovery(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmInitiateBatchInstantRecovery");
            string parameters = "($input: VsphereVmInitiateBatchInstantRecoveryInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmInitiateBatchInstantRecovery" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmInitiateBatchInstantRecovery",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BatchAsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<BatchAsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereVmInitiateDiskMount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmInitiateDiskMount");
            string parameters = "($input: VsphereVmInitiateDiskMountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmInitiateDiskMount" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmInitiateDiskMount",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereVmInitiateLiveMountV2(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmInitiateLiveMountV2");
            string parameters = "($input: VsphereVmInitiateLiveMountV2Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmInitiateLiveMountV2" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmInitiateLiveMountV2",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BatchAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereVmInitiateBatchLiveMountV2(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmInitiateBatchLiveMountV2");
            string parameters = "($input: VsphereVmInitiateBatchLiveMountV2Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmInitiateBatchLiveMountV2" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmInitiateBatchLiveMountV2",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BatchAsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<BatchAsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VsphereVmPowerOnOffLiveMountReply)psObject.BaseObject;
                } else {
                    fields = (VsphereVmPowerOnOffLiveMountReply)this.Field;
                }
            }
            string document = Mutation.VsphereVmPowerOnOffLiveMount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmPowerOnOffLiveMount");
            string parameters = "($input: VsphereVmPowerOnOffLiveMountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmPowerOnOffLiveMount" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmPowerOnOffLiveMount",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VsphereVmPowerOnOffLiveMountReply> task = this._rbkClient.InvokeGenericCallAsync<VsphereVmPowerOnOffLiveMountReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteVsphereLiveMount(input: DeleteVsphereLiveMountInput!): AsyncRequestStatus!
        protected void InvokeMutationDeleteVsphereLiveMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteVsphereLiveMountInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.DeleteVsphereLiveMount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteVsphereLiveMount");
            string parameters = "($input: DeleteVsphereLiveMountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteVsphereLiveMount" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteVsphereLiveMount",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VsphereVmListEsxiDatastoresReply)psObject.BaseObject;
                } else {
                    fields = (VsphereVmListEsxiDatastoresReply)this.Field;
                }
            }
            string document = Mutation.VsphereVmListEsxiDatastores(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmListEsxiDatastores");
            string parameters = "($input: VsphereVmListEsxiDatastoresInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmListEsxiDatastores" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmListEsxiDatastores",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VsphereVmListEsxiDatastoresReply> task = this._rbkClient.InvokeGenericCallAsync<VsphereVmListEsxiDatastoresReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // vsphereExportSnapshotToStandaloneHostV2(input: VsphereExportSnapshotToStandaloneHostV2Input!): AsyncRequestStatus!
        protected void InvokeMutationVsphereExportSnapshotToStandaloneHostV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereExportSnapshotToStandaloneHostV2Input!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereExportSnapshotToStandaloneHostV2(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereExportSnapshotToStandaloneHostV2");
            string parameters = "($input: VsphereExportSnapshotToStandaloneHostV2Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereExportSnapshotToStandaloneHostV2" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereExportSnapshotToStandaloneHostV2",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // createVsphereVcenter(input: CreateVsphereVcenterInput!): CreateVsphereVcenterReply!
        protected void InvokeMutationCreateVsphereVcenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateVsphereVcenterInput!"),
            };
            CreateVsphereVcenterReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (CreateVsphereVcenterReply)psObject.BaseObject;
                } else {
                    fields = (CreateVsphereVcenterReply)this.Field;
                }
            }
            string document = Mutation.CreateVsphereVcenter(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateVsphereVcenter");
            string parameters = "($input: CreateVsphereVcenterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateVsphereVcenter" + parameters + "{" + document + "}",
                OperationName = "MutationCreateVsphereVcenter",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<CreateVsphereVcenterReply> task = this._rbkClient.InvokeGenericCallAsync<CreateVsphereVcenterReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // vsphereDeleteVcenter(input: VsphereDeleteVcenterInput!): AsyncRequestStatus!
        protected void InvokeMutationVsphereDeleteVcenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereDeleteVcenterInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereDeleteVcenter(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereDeleteVcenter");
            string parameters = "($input: VsphereDeleteVcenterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereDeleteVcenter" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereDeleteVcenter",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // refreshVsphereVcenter(input: RefreshVsphereVcenterInput!): AsyncRequestStatus!
        protected void InvokeMutationRefreshVsphereVcenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshVsphereVcenterInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.RefreshVsphereVcenter(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RefreshVsphereVcenter");
            string parameters = "($input: RefreshVsphereVcenterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRefreshVsphereVcenter" + parameters + "{" + document + "}",
                OperationName = "MutationRefreshVsphereVcenter",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereVmMountRelocate(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmMountRelocate");
            string parameters = "($input: VsphereVmMountRelocateInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmMountRelocate" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmMountRelocate",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereVmMountRelocateV2(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmMountRelocateV2");
            string parameters = "($input: VsphereVmMountRelocateV2Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmMountRelocateV2" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmMountRelocateV2",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (RequestSuccess)psObject.BaseObject;
                } else {
                    fields = (RequestSuccess)this.Field;
                }
            }
            string document = Mutation.VsphereExcludeVmDisks(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereExcludeVmDisks");
            string parameters = "($input: [VsphereExcludeVmDisksInput!]!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereExcludeVmDisks" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereExcludeVmDisks",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<RequestSuccess> task = this._rbkClient.InvokeGenericCallAsync<RequestSuccess>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereVmDownloadSnapshotFiles(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereVmDownloadSnapshotFiles");
            string parameters = "($input: VsphereVmDownloadSnapshotFilesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereVmDownloadSnapshotFiles" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereVmDownloadSnapshotFiles",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // updateVsphereVm(input: UpdateVsphereVmInput!): RequestSuccess!
        protected void InvokeMutationUpdateVsphereVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateVsphereVmInput!"),
            };
            RequestSuccess? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (RequestSuccess)psObject.BaseObject;
                } else {
                    fields = (RequestSuccess)this.Field;
                }
            }
            string document = Mutation.UpdateVsphereVm(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateVsphereVm");
            string parameters = "($input: UpdateVsphereVmInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateVsphereVm" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateVsphereVm",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<RequestSuccess> task = this._rbkClient.InvokeGenericCallAsync<RequestSuccess>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // createVsphereAdvancedTag(input: CreateVsphereAdvancedTagInput!): CreateVsphereAdvancedTagReply!
        protected void InvokeMutationCreateVsphereAdvancedTag()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateVsphereAdvancedTagInput!"),
            };
            CreateVsphereAdvancedTagReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (CreateVsphereAdvancedTagReply)psObject.BaseObject;
                } else {
                    fields = (CreateVsphereAdvancedTagReply)this.Field;
                }
            }
            string document = Mutation.CreateVsphereAdvancedTag(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateVsphereAdvancedTag");
            string parameters = "($input: CreateVsphereAdvancedTagInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateVsphereAdvancedTag" + parameters + "{" + document + "}",
                OperationName = "MutationCreateVsphereAdvancedTag",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<CreateVsphereAdvancedTagReply> task = this._rbkClient.InvokeGenericCallAsync<CreateVsphereAdvancedTagReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteVsphereAdvancedTag(input: DeleteVsphereAdvancedTagInput!): RequestSuccess!
        protected void InvokeMutationDeleteVsphereAdvancedTag()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteVsphereAdvancedTagInput!"),
            };
            RequestSuccess? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (RequestSuccess)psObject.BaseObject;
                } else {
                    fields = (RequestSuccess)this.Field;
                }
            }
            string document = Mutation.DeleteVsphereAdvancedTag(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteVsphereAdvancedTag");
            string parameters = "($input: DeleteVsphereAdvancedTagInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteVsphereAdvancedTag" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteVsphereAdvancedTag",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<RequestSuccess> task = this._rbkClient.InvokeGenericCallAsync<RequestSuccess>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // updateVsphereAdvancedTag(input: UpdateVsphereAdvancedTagInput!): UpdateVsphereAdvancedTagReply!
        protected void InvokeMutationUpdateVsphereAdvancedTag()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateVsphereAdvancedTagInput!"),
            };
            UpdateVsphereAdvancedTagReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (UpdateVsphereAdvancedTagReply)psObject.BaseObject;
                } else {
                    fields = (UpdateVsphereAdvancedTagReply)this.Field;
                }
            }
            string document = Mutation.UpdateVsphereAdvancedTag(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateVsphereAdvancedTag");
            string parameters = "($input: UpdateVsphereAdvancedTagInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateVsphereAdvancedTag" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateVsphereAdvancedTag",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<UpdateVsphereAdvancedTagReply> task = this._rbkClient.InvokeGenericCallAsync<UpdateVsphereAdvancedTagReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }


    } // class Mutate_RscVsphere
}