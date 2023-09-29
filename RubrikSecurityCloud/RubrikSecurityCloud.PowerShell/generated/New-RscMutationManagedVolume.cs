// New-RscMutationManagedVolume.cs
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
    /// Create a new RscQuery object for any of the 11
    /// operations in the 'Managed Volume' API domain:
    /// Add, BeginSnapshot, Delete, DeleteSnapshotExport, DownloadFiles, DownloadFromLocation, EndSnapshot, ExportSnapshot, Resize, TakeOnDemandSnapshot, or Update.
    /// </summary>
    /// <description>
    /// New-RscMutationManagedVolume creates a new
    /// mutation object for operations
    /// in the 'Managed Volume' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 11 operations
    /// in the 'Managed Volume' API domain. Select the operation this
    /// query is for by specifying the appropriate switch parameter;
    /// one of: -Add, -BeginSnapshot, -Delete, -DeleteSnapshotExport, -DownloadFiles, -DownloadFromLocation, -EndSnapshot, -ExportSnapshot, -Resize, -TakeOnDemandSnapshot, -Update.
    /// Alternatively, you can specify the operation by setting the
    /// -Op parameter, for example: -Op Add,
    /// which is equivalent to specifying -Add.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationManagedVolume -Add).Info().
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
    /// (New-RscMutationManagedVolume -Add).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the Add operation
    /// of the 'Managed Volume' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ManagedVolume
    /// # API Operation: Add
    /// 
    /// $query = New-RscMutationManagedVolume -Add
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	managedVolumeConfig = @{
    /// 		# OPTIONAL
    /// 		numChannels = $someInt
    /// 		# OPTIONAL
    /// 		subnet = $someString
    /// 		# OPTIONAL
    /// 		slaClientConfig = @{
    /// 			# OPTIONAL
    /// 			postBackupScriptOnBackupFailure = @{
    /// 				# OPTIONAL
    /// 				timeout = $someInt64
    /// 				# REQUIRED
    /// 				scriptCommand = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			postBackupScriptOnBackupSuccess = @{
    /// 				# OPTIONAL
    /// 				timeout = $someInt64
    /// 				# REQUIRED
    /// 				scriptCommand = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			preBackupScript = @{
    /// 				# OPTIONAL
    /// 				timeout = $someInt64
    /// 				# REQUIRED
    /// 				scriptCommand = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			shouldCancelBackupOnPreBackupScriptFailure = $someBoolean
    /// 			# OPTIONAL
    /// 			shouldEnableLogExport = $someBoolean
    /// 			# REQUIRED
    /// 			backupScript = @{
    /// 				# OPTIONAL
    /// 				timeout = $someInt64
    /// 				# REQUIRED
    /// 				scriptCommand = $someString
    /// 			}
    /// 			# REQUIRED
    /// 			channelHostMountPaths = @(
    /// 				$someString
    /// 			)
    /// 			# REQUIRED
    /// 			clientHostId = $someString
    /// 			# REQUIRED
    /// 			username = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		applicationTag = $someManagedVolumeApplicationTag # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedVolumeApplicationTag]) for enum values.
    /// 		# OPTIONAL
    /// 		mvType = $someCdmManagedVolumeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmManagedVolumeType]) for enum values.
    /// 		# REQUIRED
    /// 		exportConfig = @{
    /// 			# OPTIONAL
    /// 			subnet = $someString
    /// 			# OPTIONAL
    /// 			managedVolumePatchConfig = @{
    /// 				# OPTIONAL
    /// 				hostPatterns = @(
    /// 					$someString
    /// 				)
    /// 				# OPTIONAL
    /// 				nodeHint = @(
    /// 					$someString
    /// 				)
    /// 				# OPTIONAL
    /// 				smbDomainName = $someString
    /// 				# OPTIONAL
    /// 				smbValidIps = @(
    /// 					$someString
    /// 				)
    /// 				# OPTIONAL
    /// 				smbValidUsers = @(
    /// 					$someString
    /// 				)
    /// 			}
    /// 			# OPTIONAL
    /// 			shareType = $someManagedVolumeShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedVolumeShareType]) for enum values.
    /// 		}
    /// 		# REQUIRED
    /// 		name = $someString
    /// 		# REQUIRED
    /// 		volumeSize = $someInt64
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddManagedVolumeReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BeginSnapshot operation
    /// of the 'Managed Volume' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ManagedVolume
    /// # API Operation: BeginSnapshot
    /// 
    /// $query = New-RscMutationManagedVolume -BeginSnapshot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		isAsync = $someBoolean
    /// 		# OPTIONAL
    /// 		managedVolumeSnapshotReferenceWrapper = @{
    /// 			# OPTIONAL
    /// 			reference = @{
    /// 				# OPTIONAL
    /// 				managedVolumeSnapshotReferenceDefinition = @{
    /// 					# OPTIONAL
    /// 					managedVolumeSnapshotReferencePatch = @{
    /// 						# OPTIONAL
    /// 						expiryDurationInMinutes = $someInt
    /// 					}
    /// 					# REQUIRED
    /// 					ownerId = $someString
    /// 				}
    /// 				# REQUIRED
    /// 				refId = $someString
    /// 			}
    /// 		}
    /// 	}
    /// 	# OPTIONAL
    /// 	ownerId = $someString
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BeginManagedVolumeSnapshotReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Delete operation
    /// of the 'Managed Volume' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ManagedVolume
    /// # API Operation: Delete
    /// 
    /// $query = New-RscMutationManagedVolume -Delete
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	preserveSnapshots = $someBoolean
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DeleteManagedVolumeReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteSnapshotExport operation
    /// of the 'Managed Volume' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ManagedVolume
    /// # API Operation: DeleteSnapshotExport
    /// 
    /// $query = New-RscMutationManagedVolume -DeleteSnapshotExport
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
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
    /// Runs the DownloadFiles operation
    /// of the 'Managed Volume' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ManagedVolume
    /// # API Operation: DownloadFiles
    /// 
    /// $query = New-RscMutationManagedVolume -DownloadFiles
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		legalHoldDownloadConfig = @{
    /// 			# REQUIRED
    /// 			isLegalHoldDownload = $someBoolean
    /// 		}
    /// 		# REQUIRED
    /// 		paths = @(
    /// 			$someString
    /// 		)
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
    /// Runs the DownloadFromLocation operation
    /// of the 'Managed Volume' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ManagedVolume
    /// # API Operation: DownloadFromLocation
    /// 
    /// $query = New-RscMutationManagedVolume -DownloadFromLocation
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	downloadConfig = @{
    /// 		# OPTIONAL
    /// 		slaId = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	locationId = $someString
    /// 	# REQUIRED
    /// 	snapshotId = $someString
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
    /// Runs the EndSnapshot operation
    /// of the 'Managed Volume' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ManagedVolume
    /// # API Operation: EndSnapshot
    /// 
    /// $query = New-RscMutationManagedVolume -EndSnapshot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	params = @{
    /// 		# OPTIONAL
    /// 		isAsync = $someBoolean
    /// 		# OPTIONAL
    /// 		retentionConfig = @{
    /// 			# OPTIONAL
    /// 			slaId = $someString
    /// 		}
    /// 	}
    /// 	# OPTIONAL
    /// 	endSnapshotDelayInSeconds = $someInt
    /// 	# OPTIONAL
    /// 	ownerId = $someString
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: EndManagedVolumeSnapshotReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ExportSnapshot operation
    /// of the 'Managed Volume' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ManagedVolume
    /// # API Operation: ExportSnapshot
    /// 
    /// $query = New-RscMutationManagedVolume -ExportSnapshot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	params = @{
    /// 		# OPTIONAL
    /// 		shouldDownloadToLocal = $someBoolean
    /// 		# OPTIONAL
    /// 		managedVolumeExportConfig = @{
    /// 			# OPTIONAL
    /// 			subnet = $someString
    /// 			# OPTIONAL
    /// 			managedVolumePatchConfig = @{
    /// 				# OPTIONAL
    /// 				hostPatterns = @(
    /// 					$someString
    /// 				)
    /// 				# OPTIONAL
    /// 				nodeHint = @(
    /// 					$someString
    /// 				)
    /// 				# OPTIONAL
    /// 				smbDomainName = $someString
    /// 				# OPTIONAL
    /// 				smbValidIps = @(
    /// 					$someString
    /// 				)
    /// 				# OPTIONAL
    /// 				smbValidUsers = @(
    /// 					$someString
    /// 				)
    /// 			}
    /// 			# OPTIONAL
    /// 			shareType = $someManagedVolumeShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedVolumeShareType]) for enum values.
    /// 		}
    /// 	}
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
    /// Runs the Resize operation
    /// of the 'Managed Volume' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ManagedVolume
    /// # API Operation: Resize
    /// 
    /// $query = New-RscMutationManagedVolume -Resize
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	size = @{
    /// 		# OPTIONAL
    /// 		newSize = $someInt64
    /// 	}
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
    /// Runs the TakeOnDemandSnapshot operation
    /// of the 'Managed Volume' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ManagedVolume
    /// # API Operation: TakeOnDemandSnapshot
    /// 
    /// $query = New-RscMutationManagedVolume -TakeOnDemandSnapshot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		retentionConfig = @{
    /// 			# OPTIONAL
    /// 			slaId = $someString
    /// 		}
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
    /// Runs the Update operation
    /// of the 'Managed Volume' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ManagedVolume
    /// # API Operation: Update
    /// 
    /// $query = New-RscMutationManagedVolume -Update
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	update = @{
    /// 		# OPTIONAL
    /// 		config = @{
    /// 			# OPTIONAL
    /// 			hostPatterns = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			nodeHint = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			smbDomainName = $someString
    /// 			# OPTIONAL
    /// 			smbValidIps = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			smbValidUsers = @(
    /// 				$someString
    /// 			)
    /// 		}
    /// 		# OPTIONAL
    /// 		configuredSlaDomainId = $someString
    /// 		# OPTIONAL
    /// 		name = $someString
    /// 		# OPTIONAL
    /// 		volumeSize = $someInt64
    /// 		# OPTIONAL
    /// 		slaClientConfig = @{
    /// 			# OPTIONAL
    /// 			backupScriptCommand = $someString
    /// 			# OPTIONAL
    /// 			backupScriptTimeout = $someInt64
    /// 			# OPTIONAL
    /// 			channelHostMountPaths = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			clientHostId = $someString
    /// 			# OPTIONAL
    /// 			postBackupScriptOnBackupFailureCommand = $someString
    /// 			# OPTIONAL
    /// 			postBackupScriptOnBackupFailureTimeout = $someInt64
    /// 			# OPTIONAL
    /// 			postBackupScriptOnBackupSuccessCommand = $someString
    /// 			# OPTIONAL
    /// 			postBackupScriptOnBackupSuccessTimeout = $someInt64
    /// 			# OPTIONAL
    /// 			preBackupScriptCommand = $someString
    /// 			# OPTIONAL
    /// 			preBackupScriptTimeout = $someInt64
    /// 			# OPTIONAL
    /// 			shouldCancelBackupOnPreBackupScriptFailure = $someBoolean
    /// 			# OPTIONAL
    /// 			username = $someString
    /// 			# REQUIRED
    /// 			shouldDisablePostBackupScriptOnBackupFailure = $someBoolean
    /// 			# REQUIRED
    /// 			shouldDisablePostBackupScriptOnBackupSuccess = $someBoolean
    /// 			# REQUIRED
    /// 			shouldDisablePreBackupScript = $someBoolean
    /// 		}
    /// 		# OPTIONAL
    /// 		subnet = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateManagedVolumeReply
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
        "RscMutationManagedVolume",
        DefaultParameterSetName = "Add")
    ]
    public class New_RscMutationManagedVolume : RscGqlPSCmdlet
    {
        
        [Parameter(
            ParameterSetName = "Add",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'Add' operation
in the 'Managed Volume' API domain.
Description of the operation:
Create a Managed Volume

Supported in v7.0+
v7.0: Initiates an asynchronous job to create a Managed Volume stack.
v8.0+: Start an asynchronous job to create a Managed Volume stack.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/addmanagedvolume.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter Add { get; set; }

        
        [Parameter(
            ParameterSetName = "BeginSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'BeginSnapshot' operation
in the 'Managed Volume' API domain.
Description of the operation:
Begin Managed Volume snapshot

Supported in v7.0+
Opens the Managed Volume for writes. All data written to the Managed Volume until the next end-snapshot call will be part of this snapshot.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/beginmanagedvolumesnapshot.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter BeginSnapshot { get; set; }

        
        [Parameter(
            ParameterSetName = "Delete",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'Delete' operation
in the 'Managed Volume' API domain.
Description of the operation:
Delete a Managed Volume

Supported in v7.0+
Delete a Managed Volume.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/deletemanagedvolume.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter Delete { get; set; }

        
        [Parameter(
            ParameterSetName = "DeleteSnapshotExport",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DeleteSnapshotExport' operation
in the 'Managed Volume' API domain.
Description of the operation:
Delete an exported Managed Volume snapshot

Supported in v7.0+
Deletes an exported Managed Volume snapshot, identified by the snapshot ID.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/deletemanagedvolumesnapshotexport.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DeleteSnapshotExport { get; set; }

        
        [Parameter(
            ParameterSetName = "DownloadFiles",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DownloadFiles' operation
in the 'Managed Volume' API domain.
Description of the operation:
Download files from a managed volume backup

Supported in v5.0+
Start an asynchronous job to download multiple files and folders from a specified managed volume backup. The response returns an asynchronous request ID. Get the URL for downloading the ZIP file including the specific files/folders by sending a GET request to 'managed-volume/request/{id}'.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/downloadmanagedvolumefiles.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DownloadFiles { get; set; }

        
        [Parameter(
            ParameterSetName = "DownloadFromLocation",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DownloadFromLocation' operation
in the 'Managed Volume' API domain.
Description of the operation:
Download a snapshot from a remote target

Supported in v7.0+
Initiates a job to download a snapshot from the specified
location when the snapshot does not exist locally.
The specified location has to be a remote target connected to this Rubrik cluster.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/downloadmanagedvolumefromlocation.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DownloadFromLocation { get; set; }

        
        [Parameter(
            ParameterSetName = "EndSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'EndSnapshot' operation
in the 'Managed Volume' API domain.
Description of the operation:
End Managed Volume snapshot

Supported in v7.0+
Close a Managed Volume for writes. A snapshot will be created containing all writes since the last begin-snapshot call.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/endmanagedvolumesnapshot.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter EndSnapshot { get; set; }

        
        [Parameter(
            ParameterSetName = "ExportSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'ExportSnapshot' operation
in the 'Managed Volume' API domain.
Description of the operation:
Create a request to export a snapshot

Supported in v5.0+
Export a managed volume snapshot as a share.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/exportmanagedvolumesnapshot.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter ExportSnapshot { get; set; }

        
        [Parameter(
            ParameterSetName = "Resize",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'Resize' operation
in the 'Managed Volume' API domain.
Description of the operation:
Resize managed volume

Supported in v5.3+
Resize the managed volume to a larger size. Once a volume size has been increased, it can not be decreased.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/resizemanagedvolume.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter Resize { get; set; }

        
        [Parameter(
            ParameterSetName = "TakeOnDemandSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'TakeOnDemandSnapshot' operation
in the 'Managed Volume' API domain.
Description of the operation:
Take an on-demand snapshot of an SLA Managed Volume

Supported in v5.3+
Create a job for an on-demand snapshot of an SLA Managed Volume. The response returns a request ID. To see the status of the request, poll 'managed-volume/request/{id}' with the request ID obtained in the response.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/takemanagedvolumeondemandsnapshot.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter TakeOnDemandSnapshot { get; set; }

        
        [Parameter(
            ParameterSetName = "Update",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'Update' operation
in the 'Managed Volume' API domain.
Description of the operation:
Mutation to update an existing Managed Volume.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/updatemanagedvolume.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter Update { get; set; }



        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "Add":
                        this.ProcessRecord_Add();
                        break;
                    case "BeginSnapshot":
                        this.ProcessRecord_BeginSnapshot();
                        break;
                    case "Delete":
                        this.ProcessRecord_Delete();
                        break;
                    case "DeleteSnapshotExport":
                        this.ProcessRecord_DeleteSnapshotExport();
                        break;
                    case "DownloadFiles":
                        this.ProcessRecord_DownloadFiles();
                        break;
                    case "DownloadFromLocation":
                        this.ProcessRecord_DownloadFromLocation();
                        break;
                    case "EndSnapshot":
                        this.ProcessRecord_EndSnapshot();
                        break;
                    case "ExportSnapshot":
                        this.ProcessRecord_ExportSnapshot();
                        break;
                    case "Resize":
                        this.ProcessRecord_Resize();
                        break;
                    case "TakeOnDemandSnapshot":
                        this.ProcessRecord_TakeOnDemandSnapshot();
                        break;
                    case "Update":
                        this.ProcessRecord_Update();
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
        // addManagedVolume.
        internal void ProcessRecord_Add()
        {
            this._logger.name += " -Add";
            // Create new graphql operation addManagedVolume
            InitMutationAddManagedVolume();
        }

        // This parameter set invokes a single graphql operation:
        // beginManagedVolumeSnapshot.
        internal void ProcessRecord_BeginSnapshot()
        {
            this._logger.name += " -BeginSnapshot";
            // Create new graphql operation beginManagedVolumeSnapshot
            InitMutationBeginManagedVolumeSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // deleteManagedVolume.
        internal void ProcessRecord_Delete()
        {
            this._logger.name += " -Delete";
            // Create new graphql operation deleteManagedVolume
            InitMutationDeleteManagedVolume();
        }

        // This parameter set invokes a single graphql operation:
        // deleteManagedVolumeSnapshotExport.
        internal void ProcessRecord_DeleteSnapshotExport()
        {
            this._logger.name += " -DeleteSnapshotExport";
            // Create new graphql operation deleteManagedVolumeSnapshotExport
            InitMutationDeleteManagedVolumeSnapshotExport();
        }

        // This parameter set invokes a single graphql operation:
        // downloadManagedVolumeFiles.
        internal void ProcessRecord_DownloadFiles()
        {
            this._logger.name += " -DownloadFiles";
            // Create new graphql operation downloadManagedVolumeFiles
            InitMutationDownloadManagedVolumeFiles();
        }

        // This parameter set invokes a single graphql operation:
        // downloadManagedVolumeFromLocation.
        internal void ProcessRecord_DownloadFromLocation()
        {
            this._logger.name += " -DownloadFromLocation";
            // Create new graphql operation downloadManagedVolumeFromLocation
            InitMutationDownloadManagedVolumeFromLocation();
        }

        // This parameter set invokes a single graphql operation:
        // endManagedVolumeSnapshot.
        internal void ProcessRecord_EndSnapshot()
        {
            this._logger.name += " -EndSnapshot";
            // Create new graphql operation endManagedVolumeSnapshot
            InitMutationEndManagedVolumeSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // exportManagedVolumeSnapshot.
        internal void ProcessRecord_ExportSnapshot()
        {
            this._logger.name += " -ExportSnapshot";
            // Create new graphql operation exportManagedVolumeSnapshot
            InitMutationExportManagedVolumeSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // resizeManagedVolume.
        internal void ProcessRecord_Resize()
        {
            this._logger.name += " -Resize";
            // Create new graphql operation resizeManagedVolume
            InitMutationResizeManagedVolume();
        }

        // This parameter set invokes a single graphql operation:
        // takeManagedVolumeOnDemandSnapshot.
        internal void ProcessRecord_TakeOnDemandSnapshot()
        {
            this._logger.name += " -TakeOnDemandSnapshot";
            // Create new graphql operation takeManagedVolumeOnDemandSnapshot
            InitMutationTakeManagedVolumeOnDemandSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // updateManagedVolume.
        internal void ProcessRecord_Update()
        {
            this._logger.name += " -Update";
            // Create new graphql operation updateManagedVolume
            InitMutationUpdateManagedVolume();
        }


        // Create new GraphQL Mutation:
        // addManagedVolume(input: AddManagedVolumeInput!): AddManagedVolumeReply!
        internal void InitMutationAddManagedVolume()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddManagedVolumeInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddManagedVolume",
                "($input: AddManagedVolumeInput!)",
                "AddManagedVolumeReply",
                Mutation.AddManagedVolume_ObjectFieldSpec,
                Mutation.AddManagedVolumeFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	managedVolumeConfig = @{
		# OPTIONAL
		numChannels = $someInt
		# OPTIONAL
		subnet = $someString
		# OPTIONAL
		slaClientConfig = @{
			# OPTIONAL
			postBackupScriptOnBackupFailure = @{
				# OPTIONAL
				timeout = $someInt64
				# REQUIRED
				scriptCommand = $someString
			}
			# OPTIONAL
			postBackupScriptOnBackupSuccess = @{
				# OPTIONAL
				timeout = $someInt64
				# REQUIRED
				scriptCommand = $someString
			}
			# OPTIONAL
			preBackupScript = @{
				# OPTIONAL
				timeout = $someInt64
				# REQUIRED
				scriptCommand = $someString
			}
			# OPTIONAL
			shouldCancelBackupOnPreBackupScriptFailure = $someBoolean
			# OPTIONAL
			shouldEnableLogExport = $someBoolean
			# REQUIRED
			backupScript = @{
				# OPTIONAL
				timeout = $someInt64
				# REQUIRED
				scriptCommand = $someString
			}
			# REQUIRED
			channelHostMountPaths = @(
				$someString
			)
			# REQUIRED
			clientHostId = $someString
			# REQUIRED
			username = $someString
		}
		# OPTIONAL
		applicationTag = $someManagedVolumeApplicationTag # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedVolumeApplicationTag]) for enum values.
		# OPTIONAL
		mvType = $someCdmManagedVolumeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmManagedVolumeType]) for enum values.
		# REQUIRED
		exportConfig = @{
			# OPTIONAL
			subnet = $someString
			# OPTIONAL
			managedVolumePatchConfig = @{
				# OPTIONAL
				hostPatterns = @(
					$someString
				)
				# OPTIONAL
				nodeHint = @(
					$someString
				)
				# OPTIONAL
				smbDomainName = $someString
				# OPTIONAL
				smbValidIps = @(
					$someString
				)
				# OPTIONAL
				smbValidUsers = @(
					$someString
				)
			}
			# OPTIONAL
			shareType = $someManagedVolumeShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedVolumeShareType]) for enum values.
		}
		# REQUIRED
		name = $someString
		# REQUIRED
		volumeSize = $someInt64
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // beginManagedVolumeSnapshot(input: BeginManagedVolumeSnapshotInput!): BeginManagedVolumeSnapshotReply!
        internal void InitMutationBeginManagedVolumeSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BeginManagedVolumeSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBeginManagedVolumeSnapshot",
                "($input: BeginManagedVolumeSnapshotInput!)",
                "BeginManagedVolumeSnapshotReply",
                Mutation.BeginManagedVolumeSnapshot_ObjectFieldSpec,
                Mutation.BeginManagedVolumeSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	config = @{
		# OPTIONAL
		isAsync = $someBoolean
		# OPTIONAL
		managedVolumeSnapshotReferenceWrapper = @{
			# OPTIONAL
			reference = @{
				# OPTIONAL
				managedVolumeSnapshotReferenceDefinition = @{
					# OPTIONAL
					managedVolumeSnapshotReferencePatch = @{
						# OPTIONAL
						expiryDurationInMinutes = $someInt
					}
					# REQUIRED
					ownerId = $someString
				}
				# REQUIRED
				refId = $someString
			}
		}
	}
	# OPTIONAL
	ownerId = $someString
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteManagedVolume(input: DeleteManagedVolumeInput!): DeleteManagedVolumeReply!
        internal void InitMutationDeleteManagedVolume()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteManagedVolumeInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteManagedVolume",
                "($input: DeleteManagedVolumeInput!)",
                "DeleteManagedVolumeReply",
                Mutation.DeleteManagedVolume_ObjectFieldSpec,
                Mutation.DeleteManagedVolumeFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	preserveSnapshots = $someBoolean
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteManagedVolumeSnapshotExport(input: DeleteManagedVolumeSnapshotExportInput!): AsyncRequestStatus!
        internal void InitMutationDeleteManagedVolumeSnapshotExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteManagedVolumeSnapshotExportInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteManagedVolumeSnapshotExport",
                "($input: DeleteManagedVolumeSnapshotExportInput!)",
                "AsyncRequestStatus",
                Mutation.DeleteManagedVolumeSnapshotExport_ObjectFieldSpec,
                Mutation.DeleteManagedVolumeSnapshotExportFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadManagedVolumeFiles(input: DownloadManagedVolumeFilesInput!): AsyncRequestStatus!
        internal void InitMutationDownloadManagedVolumeFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadManagedVolumeFilesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadManagedVolumeFiles",
                "($input: DownloadManagedVolumeFilesInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadManagedVolumeFiles_ObjectFieldSpec,
                Mutation.DownloadManagedVolumeFilesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		legalHoldDownloadConfig = @{
			# REQUIRED
			isLegalHoldDownload = $someBoolean
		}
		# REQUIRED
		paths = @(
			$someString
		)
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadManagedVolumeFromLocation(input: DownloadManagedVolumeFromLocationInput!): AsyncRequestStatus!
        internal void InitMutationDownloadManagedVolumeFromLocation()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadManagedVolumeFromLocationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadManagedVolumeFromLocation",
                "($input: DownloadManagedVolumeFromLocationInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadManagedVolumeFromLocation_ObjectFieldSpec,
                Mutation.DownloadManagedVolumeFromLocationFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	downloadConfig = @{
		# OPTIONAL
		slaId = $someString
	}
	# REQUIRED
	locationId = $someString
	# REQUIRED
	snapshotId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // endManagedVolumeSnapshot(input: EndManagedVolumeSnapshotInput!): EndManagedVolumeSnapshotReply!
        internal void InitMutationEndManagedVolumeSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "EndManagedVolumeSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationEndManagedVolumeSnapshot",
                "($input: EndManagedVolumeSnapshotInput!)",
                "EndManagedVolumeSnapshotReply",
                Mutation.EndManagedVolumeSnapshot_ObjectFieldSpec,
                Mutation.EndManagedVolumeSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	params = @{
		# OPTIONAL
		isAsync = $someBoolean
		# OPTIONAL
		retentionConfig = @{
			# OPTIONAL
			slaId = $someString
		}
	}
	# OPTIONAL
	endSnapshotDelayInSeconds = $someInt
	# OPTIONAL
	ownerId = $someString
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // exportManagedVolumeSnapshot(input: ExportManagedVolumeSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationExportManagedVolumeSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportManagedVolumeSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExportManagedVolumeSnapshot",
                "($input: ExportManagedVolumeSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.ExportManagedVolumeSnapshot_ObjectFieldSpec,
                Mutation.ExportManagedVolumeSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	params = @{
		# OPTIONAL
		shouldDownloadToLocal = $someBoolean
		# OPTIONAL
		managedVolumeExportConfig = @{
			# OPTIONAL
			subnet = $someString
			# OPTIONAL
			managedVolumePatchConfig = @{
				# OPTIONAL
				hostPatterns = @(
					$someString
				)
				# OPTIONAL
				nodeHint = @(
					$someString
				)
				# OPTIONAL
				smbDomainName = $someString
				# OPTIONAL
				smbValidIps = @(
					$someString
				)
				# OPTIONAL
				smbValidUsers = @(
					$someString
				)
			}
			# OPTIONAL
			shareType = $someManagedVolumeShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedVolumeShareType]) for enum values.
		}
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // resizeManagedVolume(input: ResizeManagedVolumeInput!): AsyncRequestStatus!
        internal void InitMutationResizeManagedVolume()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ResizeManagedVolumeInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationResizeManagedVolume",
                "($input: ResizeManagedVolumeInput!)",
                "AsyncRequestStatus",
                Mutation.ResizeManagedVolume_ObjectFieldSpec,
                Mutation.ResizeManagedVolumeFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	size = @{
		# OPTIONAL
		newSize = $someInt64
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // takeManagedVolumeOnDemandSnapshot(input: TakeManagedVolumeOnDemandSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationTakeManagedVolumeOnDemandSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "TakeManagedVolumeOnDemandSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationTakeManagedVolumeOnDemandSnapshot",
                "($input: TakeManagedVolumeOnDemandSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.TakeManagedVolumeOnDemandSnapshot_ObjectFieldSpec,
                Mutation.TakeManagedVolumeOnDemandSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	config = @{
		# OPTIONAL
		retentionConfig = @{
			# OPTIONAL
			slaId = $someString
		}
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateManagedVolume(input: UpdateManagedVolumeInput!): UpdateManagedVolumeReply!
        internal void InitMutationUpdateManagedVolume()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateManagedVolumeInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateManagedVolume",
                "($input: UpdateManagedVolumeInput!)",
                "UpdateManagedVolumeReply",
                Mutation.UpdateManagedVolume_ObjectFieldSpec,
                Mutation.UpdateManagedVolumeFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	update = @{
		# OPTIONAL
		config = @{
			# OPTIONAL
			hostPatterns = @(
				$someString
			)
			# OPTIONAL
			nodeHint = @(
				$someString
			)
			# OPTIONAL
			smbDomainName = $someString
			# OPTIONAL
			smbValidIps = @(
				$someString
			)
			# OPTIONAL
			smbValidUsers = @(
				$someString
			)
		}
		# OPTIONAL
		configuredSlaDomainId = $someString
		# OPTIONAL
		name = $someString
		# OPTIONAL
		volumeSize = $someInt64
		# OPTIONAL
		slaClientConfig = @{
			# OPTIONAL
			backupScriptCommand = $someString
			# OPTIONAL
			backupScriptTimeout = $someInt64
			# OPTIONAL
			channelHostMountPaths = @(
				$someString
			)
			# OPTIONAL
			clientHostId = $someString
			# OPTIONAL
			postBackupScriptOnBackupFailureCommand = $someString
			# OPTIONAL
			postBackupScriptOnBackupFailureTimeout = $someInt64
			# OPTIONAL
			postBackupScriptOnBackupSuccessCommand = $someString
			# OPTIONAL
			postBackupScriptOnBackupSuccessTimeout = $someInt64
			# OPTIONAL
			preBackupScriptCommand = $someString
			# OPTIONAL
			preBackupScriptTimeout = $someInt64
			# OPTIONAL
			shouldCancelBackupOnPreBackupScriptFailure = $someBoolean
			# OPTIONAL
			username = $someString
			# REQUIRED
			shouldDisablePostBackupScriptOnBackupFailure = $someBoolean
			# REQUIRED
			shouldDisablePostBackupScriptOnBackupSuccess = $someBoolean
			# REQUIRED
			shouldDisablePreBackupScript = $someBoolean
		}
		# OPTIONAL
		subnet = $someString
	}
}"
            );
        }


    } // class New_RscMutationManagedVolume
}