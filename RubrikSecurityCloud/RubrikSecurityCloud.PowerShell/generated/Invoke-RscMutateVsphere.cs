// Invoke-RscMutateVsphere.cs
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
    /// vSphere mutations
    /// </summary>
    /// <description>
    /// Invoke-RscMutateVsphere is a master cmdlet for Vsphere work that can invoke any of the following subcommands: OnDemandSnapshot, BulkOnDemandSnapshot, DeleteLiveMount, ExportSnapshotToStandaloneHostV2, ExportSnapshotToStandaloneHost, DownloadVirtualMachineFiles, CreateAdvancedTag, DeleteAdvancedTag, UpdateAdvancedTag.
    /// </description>
    /// <example>
    /// <code>Invoke-RscMutateVsphere -OnDemandSnapshot [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphere -BulkOnDemandSnapshot [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphere -DeleteLiveMount [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphere -ExportSnapshotToStandaloneHostV2 [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphere -ExportSnapshotToStandaloneHost [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphere -DownloadVirtualMachineFiles [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphere -CreateAdvancedTag [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphere -DeleteAdvancedTag [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVsphere -UpdateAdvancedTag [-Arg ..] [-Field ..]</code>
    /// </example>
    [Cmdlet(
        "Invoke",
        "RscMutateVsphere",
        DefaultParameterSetName = "DeleteLiveMount")
    ]
    public class Invoke_RscMutateVsphere : RscPSCmdlet
    {
        
        /// <summary>
        /// OnDemandSnapshot parameter set
        ///
        /// [GraphQL: vsphereOnDemandSnapshot]
        /// </summary>
        [Parameter(
            ParameterSetName = "OnDemandSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vsphereOnDemandSnapshot]",
            Position = 0
        )]
        public SwitchParameter OnDemandSnapshot { get; set; }

        
        /// <summary>
        /// BulkOnDemandSnapshot parameter set
        ///
        /// [GraphQL: vsphereBulkOnDemandSnapshot]
        /// </summary>
        [Parameter(
            ParameterSetName = "BulkOnDemandSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Trigger a bulk on demand snapshot.
[GraphQL: vsphereBulkOnDemandSnapshot]",
            Position = 0
        )]
        public SwitchParameter BulkOnDemandSnapshot { get; set; }

        
        /// <summary>
        /// DeleteLiveMount parameter set
        ///
        /// [GraphQL: deleteVsphereLiveMount]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete a Live Mount VM

Supported in v5.0+
Create a request to delete a Live Mount virtual machine.
[GraphQL: deleteVsphereLiveMount]",
            Position = 0
        )]
        public SwitchParameter DeleteLiveMount { get; set; }

        
        /// <summary>
        /// ExportSnapshotToStandaloneHostV2 parameter set
        ///
        /// [GraphQL: vsphereExportSnapshotToStandaloneHostV2]
        /// </summary>
        [Parameter(
            ParameterSetName = "ExportSnapshotToStandaloneHostV2",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Export snapshot of a virtual machine to standalone ESXi server.
[GraphQL: vsphereExportSnapshotToStandaloneHostV2]",
            Position = 0
        )]
        public SwitchParameter ExportSnapshotToStandaloneHostV2 { get; set; }

        
        /// <summary>
        /// ExportSnapshotToStandaloneHost parameter set
        ///
        /// [GraphQL: vsphereExportSnapshotToStandaloneHost]
        /// </summary>
        [Parameter(
            ParameterSetName = "ExportSnapshotToStandaloneHost",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vsphereExportSnapshotToStandaloneHost]",
            Position = 0
        )]
        public SwitchParameter ExportSnapshotToStandaloneHost { get; set; }

        
        /// <summary>
        /// DownloadVirtualMachineFiles parameter set
        ///
        /// [GraphQL: downloadVsphereVirtualMachineFiles]
        /// </summary>
        [Parameter(
            ParameterSetName = "DownloadVirtualMachineFiles",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Download Virtual Machine files from a snapshot

Supported in v9.0+
Start an asynchronous job to download multiple Virtual Machine files, such as .vmdk, .vmx, and .nvram files, from the specified Virtual Machine snapshot.
[GraphQL: downloadVsphereVirtualMachineFiles]",
            Position = 0
        )]
        public SwitchParameter DownloadVirtualMachineFiles { get; set; }

        
        /// <summary>
        /// CreateAdvancedTag parameter set
        ///
        /// [GraphQL: createVsphereAdvancedTag]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateAdvancedTag",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a multi-tag filter for vSphere tags

Supported in v7.0+
Create a filter consisting of vSphere tags joined with logical operators.
[GraphQL: createVsphereAdvancedTag]",
            Position = 0
        )]
        public SwitchParameter CreateAdvancedTag { get; set; }

        
        /// <summary>
        /// DeleteAdvancedTag parameter set
        ///
        /// [GraphQL: deleteVsphereAdvancedTag]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteAdvancedTag",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Remove the multi-tag filter

Supported in v7.0+
Remove the multi-tag filter.
[GraphQL: deleteVsphereAdvancedTag]",
            Position = 0
        )]
        public SwitchParameter DeleteAdvancedTag { get; set; }

        
        /// <summary>
        /// UpdateAdvancedTag parameter set
        ///
        /// [GraphQL: updateVsphereAdvancedTag]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateAdvancedTag",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update the multi-tag filter

Supported in v7.0+
Updates the name, condition, and description of the specified multi-tag filter.
[GraphQL: updateVsphereAdvancedTag]",
            Position = 0
        )]
        public SwitchParameter UpdateAdvancedTag { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "OnDemandSnapshot":
                        this.ProcessRecord_OnDemandSnapshot();
                        break;
                    case "BulkOnDemandSnapshot":
                        this.ProcessRecord_BulkOnDemandSnapshot();
                        break;
                    case "DeleteLiveMount":
                        this.ProcessRecord_DeleteLiveMount();
                        break;
                    case "ExportSnapshotToStandaloneHostV2":
                        this.ProcessRecord_ExportSnapshotToStandaloneHostV2();
                        break;
                    case "ExportSnapshotToStandaloneHost":
                        this.ProcessRecord_ExportSnapshotToStandaloneHost();
                        break;
                    case "DownloadVirtualMachineFiles":
                        this.ProcessRecord_DownloadVirtualMachineFiles();
                        break;
                    case "CreateAdvancedTag":
                        this.ProcessRecord_CreateAdvancedTag();
                        break;
                    case "DeleteAdvancedTag":
                        this.ProcessRecord_DeleteAdvancedTag();
                        break;
                    case "UpdateAdvancedTag":
                        this.ProcessRecord_UpdateAdvancedTag();
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
        // vsphereOnDemandSnapshot.
        internal void ProcessRecord_OnDemandSnapshot()
        {
            this._logger.name += " -OnDemandSnapshot";
            // Invoke graphql operation vsphereOnDemandSnapshot
            InvokeMutationVsphereOnDemandSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereBulkOnDemandSnapshot.
        internal void ProcessRecord_BulkOnDemandSnapshot()
        {
            this._logger.name += " -BulkOnDemandSnapshot";
            // Invoke graphql operation vsphereBulkOnDemandSnapshot
            InvokeMutationVsphereBulkOnDemandSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // deleteVsphereLiveMount.
        internal void ProcessRecord_DeleteLiveMount()
        {
            this._logger.name += " -DeleteLiveMount";
            // Invoke graphql operation deleteVsphereLiveMount
            InvokeMutationDeleteVsphereLiveMount();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereExportSnapshotToStandaloneHostV2.
        internal void ProcessRecord_ExportSnapshotToStandaloneHostV2()
        {
            this._logger.name += " -ExportSnapshotToStandaloneHostV2";
            // Invoke graphql operation vsphereExportSnapshotToStandaloneHostV2
            InvokeMutationVsphereExportSnapshotToStandaloneHostV2();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereExportSnapshotToStandaloneHost.
        internal void ProcessRecord_ExportSnapshotToStandaloneHost()
        {
            this._logger.name += " -ExportSnapshotToStandaloneHost";
            // Invoke graphql operation vsphereExportSnapshotToStandaloneHost
            InvokeMutationVsphereExportSnapshotToStandaloneHost();
        }

        // This parameter set invokes a single graphql operation:
        // downloadVsphereVirtualMachineFiles.
        internal void ProcessRecord_DownloadVirtualMachineFiles()
        {
            this._logger.name += " -DownloadVirtualMachineFiles";
            // Invoke graphql operation downloadVsphereVirtualMachineFiles
            InvokeMutationDownloadVsphereVirtualMachineFiles();
        }

        // This parameter set invokes a single graphql operation:
        // createVsphereAdvancedTag.
        internal void ProcessRecord_CreateAdvancedTag()
        {
            this._logger.name += " -CreateAdvancedTag";
            // Invoke graphql operation createVsphereAdvancedTag
            InvokeMutationCreateVsphereAdvancedTag();
        }

        // This parameter set invokes a single graphql operation:
        // deleteVsphereAdvancedTag.
        internal void ProcessRecord_DeleteAdvancedTag()
        {
            this._logger.name += " -DeleteAdvancedTag";
            // Invoke graphql operation deleteVsphereAdvancedTag
            InvokeMutationDeleteVsphereAdvancedTag();
        }

        // This parameter set invokes a single graphql operation:
        // updateVsphereAdvancedTag.
        internal void ProcessRecord_UpdateAdvancedTag()
        {
            this._logger.name += " -UpdateAdvancedTag";
            // Invoke graphql operation updateVsphereAdvancedTag
            InvokeMutationUpdateVsphereAdvancedTag();
        }


        // Invoke GraphQL Mutation:
        // vsphereOnDemandSnapshot(input: VsphereOnDemandSnapshotInput!): AsyncRequestStatus!
        internal void InvokeMutationVsphereOnDemandSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereOnDemandSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereOnDemandSnapshot",
                "($input: VsphereOnDemandSnapshotInput!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereOnDemandSnapshot(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
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
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // vsphereBulkOnDemandSnapshot(input: VsphereBulkOnDemandSnapshotInput!): BatchAsyncRequestStatus!
        internal void InvokeMutationVsphereBulkOnDemandSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereBulkOnDemandSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereBulkOnDemandSnapshot",
                "($input: VsphereBulkOnDemandSnapshotInput!)",
                "BatchAsyncRequestStatus"
                );
            BatchAsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (BatchAsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereBulkOnDemandSnapshot(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		slaId = <System.String>
		# REQUIRED
		vms = @(
			<System.String>
		)
	}
	# OPTIONAL
	userNote = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // deleteVsphereLiveMount(input: DeleteVsphereLiveMountInput!): AsyncRequestStatus!
        internal void InvokeMutationDeleteVsphereLiveMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteVsphereLiveMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteVsphereLiveMount",
                "($input: DeleteVsphereLiveMountInput!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.DeleteVsphereLiveMount(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	force = <System.Boolean>
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // vsphereExportSnapshotToStandaloneHostV2(input: VsphereExportSnapshotToStandaloneHostV2Input!): AsyncRequestStatus!
        internal void InvokeMutationVsphereExportSnapshotToStandaloneHostV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereExportSnapshotToStandaloneHostV2Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereExportSnapshotToStandaloneHostV2",
                "($input: VsphereExportSnapshotToStandaloneHostV2Input!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereExportSnapshotToStandaloneHostV2(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		mountExportSnapshotJobCommonOptions = @{
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
		# REQUIRED
		datastoreName = <System.String>
		# REQUIRED
		hostIpAddress = <System.String>
		# REQUIRED
		hostPassword = <System.String>
		# REQUIRED
		hostUsername = <System.String>
	}
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // vsphereExportSnapshotToStandaloneHost(
        //     snapshotFid: UUID!
        //     vmName: String
        //     disableNetwork: Boolean
        //     removeNetworkDevices: Boolean
        //     powerOn: Boolean
        //     keepMacAddresses: Boolean
        //     hostIpAddress: String!
        //     datastoreName: String!
        //     hostUsername: String!
        //     hostPassword: String!
        //   ): VsphereAsyncRequestStatus!
        internal void InvokeMutationVsphereExportSnapshotToStandaloneHost()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snapshotFid", "UUID!"),
                Tuple.Create("vmName", "String"),
                Tuple.Create("disableNetwork", "Boolean"),
                Tuple.Create("removeNetworkDevices", "Boolean"),
                Tuple.Create("powerOn", "Boolean"),
                Tuple.Create("keepMacAddresses", "Boolean"),
                Tuple.Create("hostIpAddress", "String!"),
                Tuple.Create("datastoreName", "String!"),
                Tuple.Create("hostUsername", "String!"),
                Tuple.Create("hostPassword", "String!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereExportSnapshotToStandaloneHost",
                "($snapshotFid: UUID!,$vmName: String,$disableNetwork: Boolean,$removeNetworkDevices: Boolean,$powerOn: Boolean,$keepMacAddresses: Boolean,$hostIpAddress: String!,$datastoreName: String!,$hostUsername: String!,$hostPassword: String!)",
                "VsphereAsyncRequestStatus"
                );
            VsphereAsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (VsphereAsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereExportSnapshotToStandaloneHost(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.snapshotFid = <System.String>
# OPTIONAL
$inputs.Var.vmName = <System.String>
# OPTIONAL
$inputs.Var.disableNetwork = <System.Boolean>
# OPTIONAL
$inputs.Var.removeNetworkDevices = <System.Boolean>
# OPTIONAL
$inputs.Var.powerOn = <System.Boolean>
# OPTIONAL
$inputs.Var.keepMacAddresses = <System.Boolean>
# REQUIRED
$inputs.Var.hostIpAddress = <System.String>
# REQUIRED
$inputs.Var.datastoreName = <System.String>
# REQUIRED
$inputs.Var.hostUsername = <System.String>
# REQUIRED
$inputs.Var.hostPassword = <System.String>";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // downloadVsphereVirtualMachineFiles(input: DownloadVsphereVirtualMachineFilesInput!): AsyncRequestStatus!
        internal void InvokeMutationDownloadVsphereVirtualMachineFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadVsphereVirtualMachineFilesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadVsphereVirtualMachineFiles",
                "($input: DownloadVsphereVirtualMachineFilesInput!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.DownloadVsphereVirtualMachineFiles(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		fileNamesToDownload = @(
			<System.String>
		)
		# REQUIRED
		vmId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // createVsphereAdvancedTag(input: CreateVsphereAdvancedTagInput!): CreateVsphereAdvancedTagReply!
        internal void InvokeMutationCreateVsphereAdvancedTag()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateVsphereAdvancedTagInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateVsphereAdvancedTag",
                "($input: CreateVsphereAdvancedTagInput!)",
                "CreateVsphereAdvancedTagReply"
                );
            CreateVsphereAdvancedTagReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (CreateVsphereAdvancedTagReply)this.Field;
            }
            string fieldSpecDoc = Mutation.CreateVsphereAdvancedTag(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	filterInfo = @{
		# OPTIONAL
		description = <System.String>
		# REQUIRED
		condition = <System.String>
		# REQUIRED
		name = <System.String>
	}
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // deleteVsphereAdvancedTag(input: DeleteVsphereAdvancedTagInput!): RequestSuccess!
        internal void InvokeMutationDeleteVsphereAdvancedTag()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteVsphereAdvancedTagInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteVsphereAdvancedTag",
                "($input: DeleteVsphereAdvancedTagInput!)",
                "RequestSuccess"
                );
            RequestSuccess? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (RequestSuccess)this.Field;
            }
            string fieldSpecDoc = Mutation.DeleteVsphereAdvancedTag(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	filterId = <System.String>
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // updateVsphereAdvancedTag(input: UpdateVsphereAdvancedTagInput!): UpdateVsphereAdvancedTagReply!
        internal void InvokeMutationUpdateVsphereAdvancedTag()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateVsphereAdvancedTagInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateVsphereAdvancedTag",
                "($input: UpdateVsphereAdvancedTagInput!)",
                "UpdateVsphereAdvancedTagReply"
                );
            UpdateVsphereAdvancedTagReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (UpdateVsphereAdvancedTagReply)this.Field;
            }
            string fieldSpecDoc = Mutation.UpdateVsphereAdvancedTag(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	filterId = <System.String>
	# REQUIRED
	filterInfo = @{
		# OPTIONAL
		description = <System.String>
		# REQUIRED
		condition = <System.String>
		# REQUIRED
		name = <System.String>
	}
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }


    } // class Invoke_RscMutateVsphere
}