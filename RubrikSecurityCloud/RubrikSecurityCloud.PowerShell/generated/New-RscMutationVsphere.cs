// New-RscMutationVsphere.cs
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

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Create a new RscQuery object for any of the 8
    /// operations in the 'VMware vSphere' API domain:
    /// BulkOnDemandSnapshot, CreateAdvancedTag, DeleteAdvancedTag, DeleteLiveMount, DownloadVirtualMachineFiles, ExportSnapshotToStandaloneHostV2, OnDemandSnapshot, or UpdateAdvancedTag.
    /// </summary>
    /// <description>
    /// New-RscMutationVsphere creates a new
    /// mutation object for operations
    /// in the 'VMware vSphere' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 8 operations
    /// in the 'VMware vSphere' API domain. Select the operation this
    /// query is for by specifying the appropriate switch parameter;
    /// one of: -BulkOnDemandSnapshot, -CreateAdvancedTag, -DeleteAdvancedTag, -DeleteLiveMount, -DownloadVirtualMachineFiles, -ExportSnapshotToStandaloneHostV2, -OnDemandSnapshot, -UpdateAdvancedTag.
    /// Alternatively, you can specify the operation by setting the
    /// -Op parameter, for example: -Op BulkOnDemandSnapshot,
    /// which is equivalent to specifying -BulkOnDemandSnapshot.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationVsphere -BulkOnDemandSnapshot).Info().
    /// Each operation also has its own set of fields that can be
    /// selected for retrieval. If you do not specify any fields,
    /// a set of default fields will be selected. The selection is
    /// rule-based, and tries to select the most commonly used fields.
    /// For example if a field is named 'id' or 'name', 
    /// it will be selected. If you give -FieldProfile DETAIL, then
    /// another set of rules will be used to select more fields on top
    /// of the default fields. The set of rules for selecting fields
    /// is called a field profile. You can specify a field profile
    /// with the -FieldProfile parameter. You can add or remove fields
    /// from the field profile with the -AddField and -RemoveField
    /// parameters. If you end up with too many -AddField and -RemoveField
    /// parameters, you can list them in a text file, one per line,
    /// with a '+' or '-' prefix, and pass the file name to the
    /// -FilePatch parameter. Profiles and Patches are one way to
    /// customize the fields that are selected. Another way is to
    /// specify the fields by passing the -Field parameter an object
    /// that contains the fields you want to select as properties.
    /// Any property that is not null in that object is interpreted
    /// as a field to select
    /// (and the actual values they are set to do not matter).
    /// The [RubrikSecurityCloud.Types] namespace
    /// contains a set of classes that you can use to specify fields.
    /// To know what [RubrikSecurityCloud.Types] object to use
    /// for a specific operation,
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationVsphere -BulkOnDemandSnapshot).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the BulkOnDemandSnapshot operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: BulkOnDemandSnapshot
    /// 
    /// $query = New-RscMutationVsphere -BulkOnDemandSnapshot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		slaId = $someString
    /// 		# REQUIRED
    /// 		vms = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	userNote = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchAsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateAdvancedTag operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: CreateAdvancedTag
    /// 
    /// $query = New-RscMutationVsphere -CreateAdvancedTag
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	filterInfo = @{
    /// 		# OPTIONAL
    /// 		description = $someString
    /// 		# REQUIRED
    /// 		condition = $someString
    /// 		# REQUIRED
    /// 		name = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateVsphereAdvancedTagReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteAdvancedTag operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: DeleteAdvancedTag
    /// 
    /// $query = New-RscMutationVsphere -DeleteAdvancedTag
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	filterId = $someString
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RequestSuccess
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteLiveMount operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: DeleteLiveMount
    /// 
    /// $query = New-RscMutationVsphere -DeleteLiveMount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	force = $someBoolean
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DownloadVirtualMachineFiles operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: DownloadVirtualMachineFiles
    /// 
    /// $query = New-RscMutationVsphere -DownloadVirtualMachineFiles
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# REQUIRED
    /// 		fileNamesToDownload = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		vmId = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ExportSnapshotToStandaloneHostV2 operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: ExportSnapshotToStandaloneHostV2
    /// 
    /// $query = New-RscMutationVsphere -ExportSnapshotToStandaloneHostV2
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		mountExportSnapshotJobCommonOptions = @{
    /// 			# OPTIONAL
    /// 			disableNetwork = $someBoolean
    /// 			# OPTIONAL
    /// 			keepMacAddresses = $someBoolean
    /// 			# OPTIONAL
    /// 			powerOn = $someBoolean
    /// 			# OPTIONAL
    /// 			removeNetworkDevices = $someBoolean
    /// 			# OPTIONAL
    /// 			vmName = $someString
    /// 		}
    /// 		# REQUIRED
    /// 		datastoreName = $someString
    /// 		# REQUIRED
    /// 		hostIpAddress = $someString
    /// 		# REQUIRED
    /// 		hostPassword = $someString
    /// 		# REQUIRED
    /// 		hostUsername = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the OnDemandSnapshot operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: OnDemandSnapshot
    /// 
    /// $query = New-RscMutationVsphere -OnDemandSnapshot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		slaId = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	userNote = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateAdvancedTag operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: UpdateAdvancedTag
    /// 
    /// $query = New-RscMutationVsphere -UpdateAdvancedTag
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	filterId = $someString
    /// 	# REQUIRED
    /// 	filterInfo = @{
    /// 		# OPTIONAL
    /// 		description = $someString
    /// 		# REQUIRED
    /// 		condition = $someString
    /// 		# REQUIRED
    /// 		name = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateVsphereAdvancedTagReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationVsphere",
        DefaultParameterSetName = "DeleteLiveMount")
    ]
    public class New_RscMutationVsphere : RscGqlPSCmdlet
    {
        
        [Parameter(
            ParameterSetName = "BulkOnDemandSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'BulkOnDemandSnapshot' operation
in the 'VMware vSphere' API domain.
Description of the operation:
Trigger a bulk on demand snapshot.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/vspherebulkondemandsnapshot.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter BulkOnDemandSnapshot { get; set; }

        
        [Parameter(
            ParameterSetName = "CreateAdvancedTag",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreateAdvancedTag' operation
in the 'VMware vSphere' API domain.
Description of the operation:
Create a multi-tag filter for vSphere tags

Supported in v7.0+
Create a filter consisting of vSphere tags joined with logical operators.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createvsphereadvancedtag.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreateAdvancedTag { get; set; }

        
        [Parameter(
            ParameterSetName = "DeleteAdvancedTag",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DeleteAdvancedTag' operation
in the 'VMware vSphere' API domain.
Description of the operation:
Remove the multi-tag filter

Supported in v7.0+
Remove the multi-tag filter.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/deletevsphereadvancedtag.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DeleteAdvancedTag { get; set; }

        
        [Parameter(
            ParameterSetName = "DeleteLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DeleteLiveMount' operation
in the 'VMware vSphere' API domain.
Description of the operation:
Delete a Live Mount VM

Supported in v5.0+
Create a request to delete a Live Mount virtual machine.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/deletevspherelivemount.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DeleteLiveMount { get; set; }

        
        [Parameter(
            ParameterSetName = "DownloadVirtualMachineFiles",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DownloadVirtualMachineFiles' operation
in the 'VMware vSphere' API domain.
Description of the operation:
Download Virtual Machine files from a snapshot

Supported in v9.0+
Start an asynchronous job to download multiple Virtual Machine files, such as .vmdk, .vmx, and .nvram files, from the specified Virtual Machine snapshot.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/downloadvspherevirtualmachinefiles.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DownloadVirtualMachineFiles { get; set; }

        
        [Parameter(
            ParameterSetName = "ExportSnapshotToStandaloneHostV2",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'ExportSnapshotToStandaloneHostV2' operation
in the 'VMware vSphere' API domain.
Description of the operation:
Export snapshot of a virtual machine to standalone ESXi server.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/vsphereexportsnapshottostandalonehostv2.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter ExportSnapshotToStandaloneHostV2 { get; set; }

        
        [Parameter(
            ParameterSetName = "OnDemandSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'OnDemandSnapshot' operation
in the 'VMware vSphere' API domain.
Description of the operation:

[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/vsphereondemandsnapshot.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter OnDemandSnapshot { get; set; }

        
        [Parameter(
            ParameterSetName = "UpdateAdvancedTag",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpdateAdvancedTag' operation
in the 'VMware vSphere' API domain.
Description of the operation:
Update the multi-tag filter

Supported in v7.0+
Updates the name, condition, and description of the specified multi-tag filter.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/updatevsphereadvancedtag.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpdateAdvancedTag { get; set; }



        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "BulkOnDemandSnapshot":
                        this.ProcessRecord_BulkOnDemandSnapshot();
                        break;
                    case "CreateAdvancedTag":
                        this.ProcessRecord_CreateAdvancedTag();
                        break;
                    case "DeleteAdvancedTag":
                        this.ProcessRecord_DeleteAdvancedTag();
                        break;
                    case "DeleteLiveMount":
                        this.ProcessRecord_DeleteLiveMount();
                        break;
                    case "DownloadVirtualMachineFiles":
                        this.ProcessRecord_DownloadVirtualMachineFiles();
                        break;
                    case "ExportSnapshotToStandaloneHostV2":
                        this.ProcessRecord_ExportSnapshotToStandaloneHostV2();
                        break;
                    case "OnDemandSnapshot":
                        this.ProcessRecord_OnDemandSnapshot();
                        break;
                    case "UpdateAdvancedTag":
                        this.ProcessRecord_UpdateAdvancedTag();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + this.GetOp().OpName());
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }

        // This parameter set invokes a single graphql operation:
        // vsphereBulkOnDemandSnapshot.
        internal void ProcessRecord_BulkOnDemandSnapshot()
        {
            this._logger.name += " -BulkOnDemandSnapshot";
            // Create new graphql operation vsphereBulkOnDemandSnapshot
            InitMutationVsphereBulkOnDemandSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // createVsphereAdvancedTag.
        internal void ProcessRecord_CreateAdvancedTag()
        {
            this._logger.name += " -CreateAdvancedTag";
            // Create new graphql operation createVsphereAdvancedTag
            InitMutationCreateVsphereAdvancedTag();
        }

        // This parameter set invokes a single graphql operation:
        // deleteVsphereAdvancedTag.
        internal void ProcessRecord_DeleteAdvancedTag()
        {
            this._logger.name += " -DeleteAdvancedTag";
            // Create new graphql operation deleteVsphereAdvancedTag
            InitMutationDeleteVsphereAdvancedTag();
        }

        // This parameter set invokes a single graphql operation:
        // deleteVsphereLiveMount.
        internal void ProcessRecord_DeleteLiveMount()
        {
            this._logger.name += " -DeleteLiveMount";
            // Create new graphql operation deleteVsphereLiveMount
            InitMutationDeleteVsphereLiveMount();
        }

        // This parameter set invokes a single graphql operation:
        // downloadVsphereVirtualMachineFiles.
        internal void ProcessRecord_DownloadVirtualMachineFiles()
        {
            this._logger.name += " -DownloadVirtualMachineFiles";
            // Create new graphql operation downloadVsphereVirtualMachineFiles
            InitMutationDownloadVsphereVirtualMachineFiles();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereExportSnapshotToStandaloneHostV2.
        internal void ProcessRecord_ExportSnapshotToStandaloneHostV2()
        {
            this._logger.name += " -ExportSnapshotToStandaloneHostV2";
            // Create new graphql operation vsphereExportSnapshotToStandaloneHostV2
            InitMutationVsphereExportSnapshotToStandaloneHostV2();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereOnDemandSnapshot.
        internal void ProcessRecord_OnDemandSnapshot()
        {
            this._logger.name += " -OnDemandSnapshot";
            // Create new graphql operation vsphereOnDemandSnapshot
            InitMutationVsphereOnDemandSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // updateVsphereAdvancedTag.
        internal void ProcessRecord_UpdateAdvancedTag()
        {
            this._logger.name += " -UpdateAdvancedTag";
            // Create new graphql operation updateVsphereAdvancedTag
            InitMutationUpdateVsphereAdvancedTag();
        }


        // Create new GraphQL Mutation:
        // vsphereBulkOnDemandSnapshot(input: VsphereBulkOnDemandSnapshotInput!): BatchAsyncRequestStatus!
        internal void InitMutationVsphereBulkOnDemandSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereBulkOnDemandSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereBulkOnDemandSnapshot",
                "($input: VsphereBulkOnDemandSnapshotInput!)",
                "BatchAsyncRequestStatus",
                Mutation.VsphereBulkOnDemandSnapshot_ObjectFieldSpec,
                Mutation.VsphereBulkOnDemandSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		slaId = $someString
		# REQUIRED
		vms = @(
			$someString
		)
	}
	# OPTIONAL
	userNote = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // createVsphereAdvancedTag(input: CreateVsphereAdvancedTagInput!): CreateVsphereAdvancedTagReply!
        internal void InitMutationCreateVsphereAdvancedTag()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateVsphereAdvancedTagInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateVsphereAdvancedTag",
                "($input: CreateVsphereAdvancedTagInput!)",
                "CreateVsphereAdvancedTagReply",
                Mutation.CreateVsphereAdvancedTag_ObjectFieldSpec,
                Mutation.CreateVsphereAdvancedTagFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	filterInfo = @{
		# OPTIONAL
		description = $someString
		# REQUIRED
		condition = $someString
		# REQUIRED
		name = $someString
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteVsphereAdvancedTag(input: DeleteVsphereAdvancedTagInput!): RequestSuccess!
        internal void InitMutationDeleteVsphereAdvancedTag()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteVsphereAdvancedTagInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteVsphereAdvancedTag",
                "($input: DeleteVsphereAdvancedTagInput!)",
                "RequestSuccess",
                Mutation.DeleteVsphereAdvancedTag_ObjectFieldSpec,
                Mutation.DeleteVsphereAdvancedTagFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	filterId = $someString
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteVsphereLiveMount(input: DeleteVsphereLiveMountInput!): AsyncRequestStatus!
        internal void InitMutationDeleteVsphereLiveMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteVsphereLiveMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteVsphereLiveMount",
                "($input: DeleteVsphereLiveMountInput!)",
                "AsyncRequestStatus",
                Mutation.DeleteVsphereLiveMount_ObjectFieldSpec,
                Mutation.DeleteVsphereLiveMountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	force = $someBoolean
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadVsphereVirtualMachineFiles(input: DownloadVsphereVirtualMachineFilesInput!): AsyncRequestStatus!
        internal void InitMutationDownloadVsphereVirtualMachineFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadVsphereVirtualMachineFilesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadVsphereVirtualMachineFiles",
                "($input: DownloadVsphereVirtualMachineFilesInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadVsphereVirtualMachineFiles_ObjectFieldSpec,
                Mutation.DownloadVsphereVirtualMachineFilesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		fileNamesToDownload = @(
			$someString
		)
		# REQUIRED
		vmId = $someString
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // vsphereExportSnapshotToStandaloneHostV2(input: VsphereExportSnapshotToStandaloneHostV2Input!): AsyncRequestStatus!
        internal void InitMutationVsphereExportSnapshotToStandaloneHostV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereExportSnapshotToStandaloneHostV2Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereExportSnapshotToStandaloneHostV2",
                "($input: VsphereExportSnapshotToStandaloneHostV2Input!)",
                "AsyncRequestStatus",
                Mutation.VsphereExportSnapshotToStandaloneHostV2_ObjectFieldSpec,
                Mutation.VsphereExportSnapshotToStandaloneHostV2FieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		mountExportSnapshotJobCommonOptions = @{
			# OPTIONAL
			disableNetwork = $someBoolean
			# OPTIONAL
			keepMacAddresses = $someBoolean
			# OPTIONAL
			powerOn = $someBoolean
			# OPTIONAL
			removeNetworkDevices = $someBoolean
			# OPTIONAL
			vmName = $someString
		}
		# REQUIRED
		datastoreName = $someString
		# REQUIRED
		hostIpAddress = $someString
		# REQUIRED
		hostPassword = $someString
		# REQUIRED
		hostUsername = $someString
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // vsphereOnDemandSnapshot(input: VsphereOnDemandSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationVsphereOnDemandSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereOnDemandSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereOnDemandSnapshot",
                "($input: VsphereOnDemandSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.VsphereOnDemandSnapshot_ObjectFieldSpec,
                Mutation.VsphereOnDemandSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	config = @{
		# OPTIONAL
		slaId = $someString
	}
	# REQUIRED
	id = $someString
	# OPTIONAL
	userNote = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateVsphereAdvancedTag(input: UpdateVsphereAdvancedTagInput!): UpdateVsphereAdvancedTagReply!
        internal void InitMutationUpdateVsphereAdvancedTag()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateVsphereAdvancedTagInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateVsphereAdvancedTag",
                "($input: UpdateVsphereAdvancedTagInput!)",
                "UpdateVsphereAdvancedTagReply",
                Mutation.UpdateVsphereAdvancedTag_ObjectFieldSpec,
                Mutation.UpdateVsphereAdvancedTagFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	filterId = $someString
	# REQUIRED
	filterInfo = @{
		# OPTIONAL
		description = $someString
		# REQUIRED
		condition = $someString
		# REQUIRED
		name = $someString
	}
	# REQUIRED
	id = $someString
}"
            );
        }


    } // class New_RscMutationVsphere
}