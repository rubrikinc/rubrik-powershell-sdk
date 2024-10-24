// New-RscMutationHyperv.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Linq;
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
    /// Create a new RscQuery object for any of the 26
    /// operations in the 'Microsoft Hyper-V' API domain:
    /// BatchExportVm, BatchInstantRecoverVm, BatchMountVm, BatchOnDemandBackupVm, CreateVirtualMachineSnapshotDiskMount, CreateVirtualMachineSnapshotMount, DeleteAllSnapshots, DeleteVirtualMachineSnapshot, DeleteVirtualMachineSnapshotMount, DownloadSnapshotFromLocation, DownloadVirtualMachineLevelFiles, DownloadVirtualMachineSnapshot, DownloadVirtualMachineSnapshotFiles, ExportVirtualMachine, InplaceExportVirtualMachine, InstantRecoverVirtualMachineSnapshot, OnDemandSnapshot, RefreshScvmm, RefreshServer, RegisterAgentVirtualMachine, RegisterScvmm, RestoreVirtualMachineSnapshotFiles, ScvmmDelete, ScvmmUpdate, UpdateVirtualMachine, or UpdateVirtualMachineSnapshotMount.
    /// </summary>
    /// <description>
    /// New-RscMutationHyperv creates a new
    /// mutation object for operations
    /// in the 'Microsoft Hyper-V' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 26 operations
    /// in the 'Microsoft Hyper-V' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: BatchExportVm, BatchInstantRecoverVm, BatchMountVm, BatchOnDemandBackupVm, CreateVirtualMachineSnapshotDiskMount, CreateVirtualMachineSnapshotMount, DeleteAllSnapshots, DeleteVirtualMachineSnapshot, DeleteVirtualMachineSnapshotMount, DownloadSnapshotFromLocation, DownloadVirtualMachineLevelFiles, DownloadVirtualMachineSnapshot, DownloadVirtualMachineSnapshotFiles, ExportVirtualMachine, InplaceExportVirtualMachine, InstantRecoverVirtualMachineSnapshot, OnDemandSnapshot, RefreshScvmm, RefreshServer, RegisterAgentVirtualMachine, RegisterScvmm, RestoreVirtualMachineSnapshotFiles, ScvmmDelete, ScvmmUpdate, UpdateVirtualMachine, or UpdateVirtualMachineSnapshotMount.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationHyperv -BatchExportVm).Info().
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
    /// (New-RscMutationHyperv -BatchExportVm).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the BatchExportVm operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: BatchExportVm
    /// 
    /// $query = New-RscMutationHyperv -Operation BatchExportVm
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# REQUIRED
    /// 		snapshots = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				snapshotAfterDate = $someDateTime
    /// 				# OPTIONAL
    /// 				snapshotBeforeDate = $someDateTime
    /// 				# OPTIONAL
    /// 				snapshotId = $someString
    /// 				# OPTIONAL
    /// 				vmNamePrefix = $someString
    /// 				# REQUIRED
    /// 				exportConfig = @{
    /// 					# OPTIONAL
    /// 					disableNetwork = $someBoolean
    /// 					# OPTIONAL
    /// 					hostId = $someString
    /// 					# OPTIONAL
    /// 					powerOn = $someBoolean
    /// 					# OPTIONAL
    /// 					removeNetworkDevices = $someBoolean
    /// 					# OPTIONAL
    /// 					vmName = $someString
    /// 					# REQUIRED
    /// 					path = $someString
    /// 				}
    /// 				# REQUIRED
    /// 				vmId = $someString
    /// 			}
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchExportHypervVmReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BatchInstantRecoverVm operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: BatchInstantRecoverVm
    /// 
    /// $query = New-RscMutationHyperv -Operation BatchInstantRecoverVm
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# REQUIRED
    /// 		snapshots = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				snapshotAfterDate = $someDateTime
    /// 				# OPTIONAL
    /// 				snapshotBeforeDate = $someDateTime
    /// 				# OPTIONAL
    /// 				snapshotId = $someString
    /// 				# REQUIRED
    /// 				instantRecoveryConfig = @{
    /// 					# OPTIONAL
    /// 					hostId = $someString
    /// 					# OPTIONAL
    /// 					vmName = $someString
    /// 				}
    /// 				# REQUIRED
    /// 				vmId = $someString
    /// 			}
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchInstantRecoverHypervVmReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BatchMountVm operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: BatchMountVm
    /// 
    /// $query = New-RscMutationHyperv -Operation BatchMountVm
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# REQUIRED
    /// 		snapshots = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				snapshotAfterDate = $someDateTime
    /// 				# OPTIONAL
    /// 				snapshotBeforeDate = $someDateTime
    /// 				# OPTIONAL
    /// 				snapshotId = $someString
    /// 				# OPTIONAL
    /// 				vmNamePrefix = $someString
    /// 				# REQUIRED
    /// 				mountConfig = @{
    /// 					# OPTIONAL
    /// 					disableNetwork = $someBoolean
    /// 					# OPTIONAL
    /// 					hostId = $someString
    /// 					# OPTIONAL
    /// 					powerOn = $someBoolean
    /// 					# OPTIONAL
    /// 					removeNetworkDevices = $someBoolean
    /// 					# OPTIONAL
    /// 					vmName = $someString
    /// 				}
    /// 				# REQUIRED
    /// 				vmId = $someString
    /// 			}
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchMountHypervVmReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BatchOnDemandBackupVm operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: BatchOnDemandBackupVm
    /// 
    /// $query = New-RscMutationHyperv -Operation BatchOnDemandBackupVm
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	userNote = $someString
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# REQUIRED
    /// 		vms = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				backupConfig = @{
    /// 					# OPTIONAL
    /// 					slaId = $someString
    /// 				}
    /// 				# OPTIONAL
    /// 				vmId = $someString
    /// 			}
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchOnDemandBackupHypervVmReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateVirtualMachineSnapshotDiskMount operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: CreateVirtualMachineSnapshotDiskMount
    /// 
    /// $query = New-RscMutationHyperv -Operation CreateVirtualMachineSnapshotDiskMount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# REQUIRED
    /// 		targetVirtualMachineId = $someString
    /// 		# REQUIRED
    /// 		virtualDiskIds = @(
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
    /// Runs the CreateVirtualMachineSnapshotMount operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: CreateVirtualMachineSnapshotMount
    /// 
    /// $query = New-RscMutationHyperv -Operation CreateVirtualMachineSnapshotMount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		disableNetwork = $someBoolean
    /// 		# OPTIONAL
    /// 		hostId = $someString
    /// 		# OPTIONAL
    /// 		powerOn = $someBoolean
    /// 		# OPTIONAL
    /// 		removeNetworkDevices = $someBoolean
    /// 		# OPTIONAL
    /// 		vmName = $someString
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
    /// Runs the DeleteAllSnapshots operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: DeleteAllSnapshots
    /// 
    /// $query = New-RscMutationHyperv -Operation DeleteAllSnapshots
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
    /// Write-Host $result.GetType().Name # prints: RequestSuccess
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteVirtualMachineSnapshot operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: DeleteVirtualMachineSnapshot
    /// 
    /// $query = New-RscMutationHyperv -Operation DeleteVirtualMachineSnapshot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	location = $someInternalDeleteHypervVirtualMachineSnapshotRequestLocation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InternalDeleteHypervVirtualMachineSnapshotRequestLocation]) for enum values.
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
    /// Runs the DeleteVirtualMachineSnapshotMount operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: DeleteVirtualMachineSnapshotMount
    /// 
    /// $query = New-RscMutationHyperv -Operation DeleteVirtualMachineSnapshotMount
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
    /// Runs the DownloadSnapshotFromLocation operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: DownloadSnapshotFromLocation
    /// 
    /// $query = New-RscMutationHyperv -Operation DownloadSnapshotFromLocation
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	locationId = $someString
    /// 	# REQUIRED
    /// 	snapshotId = $someString
    /// 	# REQUIRED
    /// 	downloadConfig = @{
    /// 		# OPTIONAL
    /// 		slaId = $someString
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
    /// Runs the DownloadVirtualMachineLevelFiles operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: DownloadVirtualMachineLevelFiles
    /// 
    /// $query = New-RscMutationHyperv -Operation DownloadVirtualMachineLevelFiles
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# REQUIRED
    /// 		configFileExtensions = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		virtualDiskIds = @(
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
    /// Runs the DownloadVirtualMachineSnapshot operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: DownloadVirtualMachineSnapshot
    /// 
    /// $query = New-RscMutationHyperv -Operation DownloadVirtualMachineSnapshot
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
    /// Runs the DownloadVirtualMachineSnapshotFiles operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: DownloadVirtualMachineSnapshotFiles
    /// 
    /// $query = New-RscMutationHyperv -Operation DownloadVirtualMachineSnapshotFiles
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
    /// Runs the ExportVirtualMachine operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: ExportVirtualMachine
    /// 
    /// $query = New-RscMutationHyperv -Operation ExportVirtualMachine
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		disableNetwork = $someBoolean
    /// 		# OPTIONAL
    /// 		hostId = $someString
    /// 		# OPTIONAL
    /// 		powerOn = $someBoolean
    /// 		# OPTIONAL
    /// 		removeNetworkDevices = $someBoolean
    /// 		# OPTIONAL
    /// 		vmName = $someString
    /// 		# REQUIRED
    /// 		path = $someString
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
    /// Runs the InplaceExportVirtualMachine operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: InplaceExportVirtualMachine
    /// 
    /// $query = New-RscMutationHyperv -Operation InplaceExportVirtualMachine
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		exportVmPath = $someString
    /// 		# OPTIONAL
    /// 		hostId = $someString
    /// 		# OPTIONAL
    /// 		shouldKeepHypervVmCopyAfterRecovery = $someBoolean
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
    /// Runs the InstantRecoverVirtualMachineSnapshot operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: InstantRecoverVirtualMachineSnapshot
    /// 
    /// $query = New-RscMutationHyperv -Operation InstantRecoverVirtualMachineSnapshot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		hostId = $someString
    /// 		# OPTIONAL
    /// 		vmName = $someString
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
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: OnDemandSnapshot
    /// 
    /// $query = New-RscMutationHyperv -Operation OnDemandSnapshot
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
    /// Runs the RefreshScvmm operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: RefreshScvmm
    /// 
    /// $query = New-RscMutationHyperv -Operation RefreshScvmm
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
    /// Runs the RefreshServer operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: RefreshServer
    /// 
    /// $query = New-RscMutationHyperv -Operation RefreshServer
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
    /// Runs the RegisterAgentVirtualMachine operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: RegisterAgentVirtualMachine
    /// 
    /// $query = New-RscMutationHyperv -Operation RegisterAgentVirtualMachine
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
    /// Write-Host $result.GetType().Name # prints: RequestSuccess
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RegisterScvmm operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: RegisterScvmm
    /// 
    /// $query = New-RscMutationHyperv -Operation RegisterScvmm
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	scvmm = @{
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		runAsAccount = $someString
    /// 		# REQUIRED
    /// 		shouldDeployAgent = $someBoolean
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
    /// Runs the RestoreVirtualMachineSnapshotFiles operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: RestoreVirtualMachineSnapshotFiles
    /// 
    /// $query = New-RscMutationHyperv -Operation RestoreVirtualMachineSnapshotFiles
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		targetVirtualMachineId = $someString
    /// 		# OPTIONAL
    /// 		shouldIgnoreError = $someBoolean
    /// 		# REQUIRED
    /// 		restoreConfig = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				path = $someString
    /// 				# REQUIRED
    /// 				restorePath = $someString
    /// 			}
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
    /// Runs the ScvmmDelete operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: ScvmmDelete
    /// 
    /// $query = New-RscMutationHyperv -Operation ScvmmDelete
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
    /// Write-Host $result.GetType().Name # prints: ResponseSuccess
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ScvmmUpdate operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: ScvmmUpdate
    /// 
    /// $query = New-RscMutationHyperv -Operation ScvmmUpdate
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	updateProperties = @{
    /// 		# OPTIONAL
    /// 		configuredSlaDomainId = $someString
    /// 		# OPTIONAL
    /// 		hostname = $someString
    /// 		# OPTIONAL
    /// 		runAsAccount = $someString
    /// 		# OPTIONAL
    /// 		shouldDeployAgent = $someBoolean
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: HypervScvmmUpdateReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateVirtualMachine operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: UpdateVirtualMachine
    /// 
    /// $query = New-RscMutationHyperv -Operation UpdateVirtualMachine
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	vmUpdateProperties = @{
    /// 		# OPTIONAL
    /// 		configuredSlaDomainId = $someString
    /// 		# OPTIONAL
    /// 		virtualDiskIdsExcludedFromSnapshot = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		cloudInstantiationSpec = @{
    /// 			# REQUIRED
    /// 			imageRetentionInSeconds = $someInt64
    /// 		}
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateHypervVirtualMachineReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateVirtualMachineSnapshotMount operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: UpdateVirtualMachineSnapshotMount
    /// 
    /// $query = New-RscMutationHyperv -Operation UpdateVirtualMachineSnapshotMount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# REQUIRED
    /// 		powerStatus = $someBoolean
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateHypervVirtualMachineSnapshotMountReply
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
        "RscMutationHyperv",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationHyperv : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "BatchExportVm",
                "BatchInstantRecoverVm",
                "BatchMountVm",
                "BatchOnDemandBackupVm",
                "CreateVirtualMachineSnapshotDiskMount",
                "CreateVirtualMachineSnapshotMount",
                "DeleteAllSnapshots",
                "DeleteVirtualMachineSnapshot",
                "DeleteVirtualMachineSnapshotMount",
                "DownloadSnapshotFromLocation",
                "DownloadVirtualMachineLevelFiles",
                "DownloadVirtualMachineSnapshot",
                "DownloadVirtualMachineSnapshotFiles",
                "ExportVirtualMachine",
                "InplaceExportVirtualMachine",
                "InstantRecoverVirtualMachineSnapshot",
                "OnDemandSnapshot",
                "RefreshScvmm",
                "RefreshServer",
                "RegisterAgentVirtualMachine",
                "RegisterScvmm",
                "RestoreVirtualMachineSnapshotFiles",
                "ScvmmDelete",
                "ScvmmUpdate",
                "UpdateVirtualMachine",
                "UpdateVirtualMachineSnapshotMount",
                IgnoreCase = true)]
        public string Operation { get; set; } = "";

        internal override string GetOperationParameter()
        {
            return this.Operation;
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "BatchExportVm":
                        this.ProcessRecord_BatchExportVm();
                        break;
                    case "BatchInstantRecoverVm":
                        this.ProcessRecord_BatchInstantRecoverVm();
                        break;
                    case "BatchMountVm":
                        this.ProcessRecord_BatchMountVm();
                        break;
                    case "BatchOnDemandBackupVm":
                        this.ProcessRecord_BatchOnDemandBackupVm();
                        break;
                    case "CreateVirtualMachineSnapshotDiskMount":
                        this.ProcessRecord_CreateVirtualMachineSnapshotDiskMount();
                        break;
                    case "CreateVirtualMachineSnapshotMount":
                        this.ProcessRecord_CreateVirtualMachineSnapshotMount();
                        break;
                    case "DeleteAllSnapshots":
                        this.ProcessRecord_DeleteAllSnapshots();
                        break;
                    case "DeleteVirtualMachineSnapshot":
                        this.ProcessRecord_DeleteVirtualMachineSnapshot();
                        break;
                    case "DeleteVirtualMachineSnapshotMount":
                        this.ProcessRecord_DeleteVirtualMachineSnapshotMount();
                        break;
                    case "DownloadSnapshotFromLocation":
                        this.ProcessRecord_DownloadSnapshotFromLocation();
                        break;
                    case "DownloadVirtualMachineLevelFiles":
                        this.ProcessRecord_DownloadVirtualMachineLevelFiles();
                        break;
                    case "DownloadVirtualMachineSnapshot":
                        this.ProcessRecord_DownloadVirtualMachineSnapshot();
                        break;
                    case "DownloadVirtualMachineSnapshotFiles":
                        this.ProcessRecord_DownloadVirtualMachineSnapshotFiles();
                        break;
                    case "ExportVirtualMachine":
                        this.ProcessRecord_ExportVirtualMachine();
                        break;
                    case "InplaceExportVirtualMachine":
                        this.ProcessRecord_InplaceExportVirtualMachine();
                        break;
                    case "InstantRecoverVirtualMachineSnapshot":
                        this.ProcessRecord_InstantRecoverVirtualMachineSnapshot();
                        break;
                    case "OnDemandSnapshot":
                        this.ProcessRecord_OnDemandSnapshot();
                        break;
                    case "RefreshScvmm":
                        this.ProcessRecord_RefreshScvmm();
                        break;
                    case "RefreshServer":
                        this.ProcessRecord_RefreshServer();
                        break;
                    case "RegisterAgentVirtualMachine":
                        this.ProcessRecord_RegisterAgentVirtualMachine();
                        break;
                    case "RegisterScvmm":
                        this.ProcessRecord_RegisterScvmm();
                        break;
                    case "RestoreVirtualMachineSnapshotFiles":
                        this.ProcessRecord_RestoreVirtualMachineSnapshotFiles();
                        break;
                    case "ScvmmDelete":
                        this.ProcessRecord_ScvmmDelete();
                        break;
                    case "ScvmmUpdate":
                        this.ProcessRecord_ScvmmUpdate();
                        break;
                    case "UpdateVirtualMachine":
                        this.ProcessRecord_UpdateVirtualMachine();
                        break;
                    case "UpdateVirtualMachineSnapshotMount":
                        this.ProcessRecord_UpdateVirtualMachineSnapshotMount();
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
        // batchExportHypervVm.
        internal void ProcessRecord_BatchExportVm()
        {
            this._logger.name += " -BatchExportVm";
            // Create new graphql operation batchExportHypervVm
            InitMutationBatchExportHypervVm();
        }

        // This parameter set invokes a single graphql operation:
        // batchInstantRecoverHypervVm.
        internal void ProcessRecord_BatchInstantRecoverVm()
        {
            this._logger.name += " -BatchInstantRecoverVm";
            // Create new graphql operation batchInstantRecoverHypervVm
            InitMutationBatchInstantRecoverHypervVm();
        }

        // This parameter set invokes a single graphql operation:
        // batchMountHypervVm.
        internal void ProcessRecord_BatchMountVm()
        {
            this._logger.name += " -BatchMountVm";
            // Create new graphql operation batchMountHypervVm
            InitMutationBatchMountHypervVm();
        }

        // This parameter set invokes a single graphql operation:
        // batchOnDemandBackupHypervVm.
        internal void ProcessRecord_BatchOnDemandBackupVm()
        {
            this._logger.name += " -BatchOnDemandBackupVm";
            // Create new graphql operation batchOnDemandBackupHypervVm
            InitMutationBatchOnDemandBackupHypervVm();
        }

        // This parameter set invokes a single graphql operation:
        // createHypervVirtualMachineSnapshotDiskMount.
        internal void ProcessRecord_CreateVirtualMachineSnapshotDiskMount()
        {
            this._logger.name += " -CreateVirtualMachineSnapshotDiskMount";
            // Create new graphql operation createHypervVirtualMachineSnapshotDiskMount
            InitMutationCreateHypervVirtualMachineSnapshotDiskMount();
        }

        // This parameter set invokes a single graphql operation:
        // createHypervVirtualMachineSnapshotMount.
        internal void ProcessRecord_CreateVirtualMachineSnapshotMount()
        {
            this._logger.name += " -CreateVirtualMachineSnapshotMount";
            // Create new graphql operation createHypervVirtualMachineSnapshotMount
            InitMutationCreateHypervVirtualMachineSnapshotMount();
        }

        // This parameter set invokes a single graphql operation:
        // hypervDeleteAllSnapshots.
        internal void ProcessRecord_DeleteAllSnapshots()
        {
            this._logger.name += " -DeleteAllSnapshots";
            // Create new graphql operation hypervDeleteAllSnapshots
            InitMutationHypervDeleteAllSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // deleteHypervVirtualMachineSnapshot.
        internal void ProcessRecord_DeleteVirtualMachineSnapshot()
        {
            this._logger.name += " -DeleteVirtualMachineSnapshot";
            // Create new graphql operation deleteHypervVirtualMachineSnapshot
            InitMutationDeleteHypervVirtualMachineSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // deleteHypervVirtualMachineSnapshotMount.
        internal void ProcessRecord_DeleteVirtualMachineSnapshotMount()
        {
            this._logger.name += " -DeleteVirtualMachineSnapshotMount";
            // Create new graphql operation deleteHypervVirtualMachineSnapshotMount
            InitMutationDeleteHypervVirtualMachineSnapshotMount();
        }

        // This parameter set invokes a single graphql operation:
        // downloadHypervSnapshotFromLocation.
        internal void ProcessRecord_DownloadSnapshotFromLocation()
        {
            this._logger.name += " -DownloadSnapshotFromLocation";
            // Create new graphql operation downloadHypervSnapshotFromLocation
            InitMutationDownloadHypervSnapshotFromLocation();
        }

        // This parameter set invokes a single graphql operation:
        // downloadHypervVirtualMachineLevelFiles.
        internal void ProcessRecord_DownloadVirtualMachineLevelFiles()
        {
            this._logger.name += " -DownloadVirtualMachineLevelFiles";
            // Create new graphql operation downloadHypervVirtualMachineLevelFiles
            InitMutationDownloadHypervVirtualMachineLevelFiles();
        }

        // This parameter set invokes a single graphql operation:
        // downloadHypervVirtualMachineSnapshot.
        internal void ProcessRecord_DownloadVirtualMachineSnapshot()
        {
            this._logger.name += " -DownloadVirtualMachineSnapshot";
            // Create new graphql operation downloadHypervVirtualMachineSnapshot
            InitMutationDownloadHypervVirtualMachineSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // downloadHypervVirtualMachineSnapshotFiles.
        internal void ProcessRecord_DownloadVirtualMachineSnapshotFiles()
        {
            this._logger.name += " -DownloadVirtualMachineSnapshotFiles";
            // Create new graphql operation downloadHypervVirtualMachineSnapshotFiles
            InitMutationDownloadHypervVirtualMachineSnapshotFiles();
        }

        // This parameter set invokes a single graphql operation:
        // exportHypervVirtualMachine.
        internal void ProcessRecord_ExportVirtualMachine()
        {
            this._logger.name += " -ExportVirtualMachine";
            // Create new graphql operation exportHypervVirtualMachine
            InitMutationExportHypervVirtualMachine();
        }

        // This parameter set invokes a single graphql operation:
        // inplaceExportHypervVirtualMachine.
        internal void ProcessRecord_InplaceExportVirtualMachine()
        {
            this._logger.name += " -InplaceExportVirtualMachine";
            // Create new graphql operation inplaceExportHypervVirtualMachine
            InitMutationInplaceExportHypervVirtualMachine();
        }

        // This parameter set invokes a single graphql operation:
        // instantRecoverHypervVirtualMachineSnapshot.
        internal void ProcessRecord_InstantRecoverVirtualMachineSnapshot()
        {
            this._logger.name += " -InstantRecoverVirtualMachineSnapshot";
            // Create new graphql operation instantRecoverHypervVirtualMachineSnapshot
            InitMutationInstantRecoverHypervVirtualMachineSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // hypervOnDemandSnapshot.
        internal void ProcessRecord_OnDemandSnapshot()
        {
            this._logger.name += " -OnDemandSnapshot";
            // Create new graphql operation hypervOnDemandSnapshot
            InitMutationHypervOnDemandSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // refreshHypervScvmm.
        internal void ProcessRecord_RefreshScvmm()
        {
            this._logger.name += " -RefreshScvmm";
            // Create new graphql operation refreshHypervScvmm
            InitMutationRefreshHypervScvmm();
        }

        // This parameter set invokes a single graphql operation:
        // refreshHypervServer.
        internal void ProcessRecord_RefreshServer()
        {
            this._logger.name += " -RefreshServer";
            // Create new graphql operation refreshHypervServer
            InitMutationRefreshHypervServer();
        }

        // This parameter set invokes a single graphql operation:
        // registerAgentHypervVirtualMachine.
        internal void ProcessRecord_RegisterAgentVirtualMachine()
        {
            this._logger.name += " -RegisterAgentVirtualMachine";
            // Create new graphql operation registerAgentHypervVirtualMachine
            InitMutationRegisterAgentHypervVirtualMachine();
        }

        // This parameter set invokes a single graphql operation:
        // registerHypervScvmm.
        internal void ProcessRecord_RegisterScvmm()
        {
            this._logger.name += " -RegisterScvmm";
            // Create new graphql operation registerHypervScvmm
            InitMutationRegisterHypervScvmm();
        }

        // This parameter set invokes a single graphql operation:
        // restoreHypervVirtualMachineSnapshotFiles.
        internal void ProcessRecord_RestoreVirtualMachineSnapshotFiles()
        {
            this._logger.name += " -RestoreVirtualMachineSnapshotFiles";
            // Create new graphql operation restoreHypervVirtualMachineSnapshotFiles
            InitMutationRestoreHypervVirtualMachineSnapshotFiles();
        }

        // This parameter set invokes a single graphql operation:
        // hypervScvmmDelete.
        internal void ProcessRecord_ScvmmDelete()
        {
            this._logger.name += " -ScvmmDelete";
            // Create new graphql operation hypervScvmmDelete
            InitMutationHypervScvmmDelete();
        }

        // This parameter set invokes a single graphql operation:
        // hypervScvmmUpdate.
        internal void ProcessRecord_ScvmmUpdate()
        {
            this._logger.name += " -ScvmmUpdate";
            // Create new graphql operation hypervScvmmUpdate
            InitMutationHypervScvmmUpdate();
        }

        // This parameter set invokes a single graphql operation:
        // updateHypervVirtualMachine.
        internal void ProcessRecord_UpdateVirtualMachine()
        {
            this._logger.name += " -UpdateVirtualMachine";
            // Create new graphql operation updateHypervVirtualMachine
            InitMutationUpdateHypervVirtualMachine();
        }

        // This parameter set invokes a single graphql operation:
        // updateHypervVirtualMachineSnapshotMount.
        internal void ProcessRecord_UpdateVirtualMachineSnapshotMount()
        {
            this._logger.name += " -UpdateVirtualMachineSnapshotMount";
            // Create new graphql operation updateHypervVirtualMachineSnapshotMount
            InitMutationUpdateHypervVirtualMachineSnapshotMount();
        }


        // Create new GraphQL Mutation:
        // batchExportHypervVm(input: BatchExportHypervVmInput!): BatchExportHypervVmReply!
        internal void InitMutationBatchExportHypervVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BatchExportHypervVmInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBatchExportHypervVm",
                "($input: BatchExportHypervVmInput!)",
                "BatchExportHypervVmReply",
                Mutation.BatchExportHypervVm,
                Mutation.BatchExportHypervVmFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	config = @{
		# REQUIRED
		snapshots = @(
			@{
				# OPTIONAL
				snapshotAfterDate = $someDateTime
				# OPTIONAL
				snapshotBeforeDate = $someDateTime
				# OPTIONAL
				snapshotId = $someString
				# OPTIONAL
				vmNamePrefix = $someString
				# REQUIRED
				exportConfig = @{
					# OPTIONAL
					disableNetwork = $someBoolean
					# OPTIONAL
					hostId = $someString
					# OPTIONAL
					powerOn = $someBoolean
					# OPTIONAL
					removeNetworkDevices = $someBoolean
					# OPTIONAL
					vmName = $someString
					# REQUIRED
					path = $someString
				}
				# REQUIRED
				vmId = $someString
			}
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // batchInstantRecoverHypervVm(input: BatchInstantRecoverHypervVmInput!): BatchInstantRecoverHypervVmReply!
        internal void InitMutationBatchInstantRecoverHypervVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BatchInstantRecoverHypervVmInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBatchInstantRecoverHypervVm",
                "($input: BatchInstantRecoverHypervVmInput!)",
                "BatchInstantRecoverHypervVmReply",
                Mutation.BatchInstantRecoverHypervVm,
                Mutation.BatchInstantRecoverHypervVmFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	config = @{
		# REQUIRED
		snapshots = @(
			@{
				# OPTIONAL
				snapshotAfterDate = $someDateTime
				# OPTIONAL
				snapshotBeforeDate = $someDateTime
				# OPTIONAL
				snapshotId = $someString
				# REQUIRED
				instantRecoveryConfig = @{
					# OPTIONAL
					hostId = $someString
					# OPTIONAL
					vmName = $someString
				}
				# REQUIRED
				vmId = $someString
			}
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // batchMountHypervVm(input: BatchMountHypervVmInput!): BatchMountHypervVmReply!
        internal void InitMutationBatchMountHypervVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BatchMountHypervVmInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBatchMountHypervVm",
                "($input: BatchMountHypervVmInput!)",
                "BatchMountHypervVmReply",
                Mutation.BatchMountHypervVm,
                Mutation.BatchMountHypervVmFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	config = @{
		# REQUIRED
		snapshots = @(
			@{
				# OPTIONAL
				snapshotAfterDate = $someDateTime
				# OPTIONAL
				snapshotBeforeDate = $someDateTime
				# OPTIONAL
				snapshotId = $someString
				# OPTIONAL
				vmNamePrefix = $someString
				# REQUIRED
				mountConfig = @{
					# OPTIONAL
					disableNetwork = $someBoolean
					# OPTIONAL
					hostId = $someString
					# OPTIONAL
					powerOn = $someBoolean
					# OPTIONAL
					removeNetworkDevices = $someBoolean
					# OPTIONAL
					vmName = $someString
				}
				# REQUIRED
				vmId = $someString
			}
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // batchOnDemandBackupHypervVm(input: BatchOnDemandBackupHypervVmInput!): BatchOnDemandBackupHypervVmReply!
        internal void InitMutationBatchOnDemandBackupHypervVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BatchOnDemandBackupHypervVmInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBatchOnDemandBackupHypervVm",
                "($input: BatchOnDemandBackupHypervVmInput!)",
                "BatchOnDemandBackupHypervVmReply",
                Mutation.BatchOnDemandBackupHypervVm,
                Mutation.BatchOnDemandBackupHypervVmFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	userNote = $someString
	# REQUIRED
	config = @{
		# REQUIRED
		vms = @(
			@{
				# OPTIONAL
				backupConfig = @{
					# OPTIONAL
					slaId = $someString
				}
				# OPTIONAL
				vmId = $someString
			}
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createHypervVirtualMachineSnapshotDiskMount(input: CreateMountHypervVirtualDisksInput!): AsyncRequestStatus!
        internal void InitMutationCreateHypervVirtualMachineSnapshotDiskMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateMountHypervVirtualDisksInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateHypervVirtualMachineSnapshotDiskMount",
                "($input: CreateMountHypervVirtualDisksInput!)",
                "AsyncRequestStatus",
                Mutation.CreateHypervVirtualMachineSnapshotDiskMount,
                Mutation.CreateHypervVirtualMachineSnapshotDiskMountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		targetVirtualMachineId = $someString
		# REQUIRED
		virtualDiskIds = @(
			$someString
		)
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // createHypervVirtualMachineSnapshotMount(input: CreateHypervVirtualMachineSnapshotMountInput!): AsyncRequestStatus!
        internal void InitMutationCreateHypervVirtualMachineSnapshotMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateHypervVirtualMachineSnapshotMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateHypervVirtualMachineSnapshotMount",
                "($input: CreateHypervVirtualMachineSnapshotMountInput!)",
                "AsyncRequestStatus",
                Mutation.CreateHypervVirtualMachineSnapshotMount,
                Mutation.CreateHypervVirtualMachineSnapshotMountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	config = @{
		# OPTIONAL
		disableNetwork = $someBoolean
		# OPTIONAL
		hostId = $someString
		# OPTIONAL
		powerOn = $someBoolean
		# OPTIONAL
		removeNetworkDevices = $someBoolean
		# OPTIONAL
		vmName = $someString
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // hypervDeleteAllSnapshots(input: HypervDeleteAllSnapshotsInput!): RequestSuccess!
        internal void InitMutationHypervDeleteAllSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "HypervDeleteAllSnapshotsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationHypervDeleteAllSnapshots",
                "($input: HypervDeleteAllSnapshotsInput!)",
                "RequestSuccess",
                Mutation.HypervDeleteAllSnapshots,
                Mutation.HypervDeleteAllSnapshotsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteHypervVirtualMachineSnapshot(input: DeleteHypervVirtualMachineSnapshotInput!): RequestSuccess!
        internal void InitMutationDeleteHypervVirtualMachineSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteHypervVirtualMachineSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteHypervVirtualMachineSnapshot",
                "($input: DeleteHypervVirtualMachineSnapshotInput!)",
                "RequestSuccess",
                Mutation.DeleteHypervVirtualMachineSnapshot,
                Mutation.DeleteHypervVirtualMachineSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	location = $someInternalDeleteHypervVirtualMachineSnapshotRequestLocation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InternalDeleteHypervVirtualMachineSnapshotRequestLocation]) for enum values.
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteHypervVirtualMachineSnapshotMount(input: DeleteHypervVirtualMachineSnapshotMountInput!): AsyncRequestStatus!
        internal void InitMutationDeleteHypervVirtualMachineSnapshotMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteHypervVirtualMachineSnapshotMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteHypervVirtualMachineSnapshotMount",
                "($input: DeleteHypervVirtualMachineSnapshotMountInput!)",
                "AsyncRequestStatus",
                Mutation.DeleteHypervVirtualMachineSnapshotMount,
                Mutation.DeleteHypervVirtualMachineSnapshotMountFieldSpec,
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
        // downloadHypervSnapshotFromLocation(input: DownloadHypervSnapshotFromLocationInput!): AsyncRequestStatus!
        internal void InitMutationDownloadHypervSnapshotFromLocation()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadHypervSnapshotFromLocationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadHypervSnapshotFromLocation",
                "($input: DownloadHypervSnapshotFromLocationInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadHypervSnapshotFromLocation,
                Mutation.DownloadHypervSnapshotFromLocationFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	locationId = $someString
	# REQUIRED
	snapshotId = $someString
	# REQUIRED
	downloadConfig = @{
		# OPTIONAL
		slaId = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadHypervVirtualMachineLevelFiles(input: DownloadHypervVirtualMachineVmLevelFilesInput!): AsyncRequestStatus!
        internal void InitMutationDownloadHypervVirtualMachineLevelFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadHypervVirtualMachineVmLevelFilesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadHypervVirtualMachineLevelFiles",
                "($input: DownloadHypervVirtualMachineVmLevelFilesInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadHypervVirtualMachineLevelFiles,
                Mutation.DownloadHypervVirtualMachineLevelFilesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		configFileExtensions = @(
			$someString
		)
		# REQUIRED
		virtualDiskIds = @(
			$someString
		)
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadHypervVirtualMachineSnapshot(input: DownloadHypervVirtualMachineSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationDownloadHypervVirtualMachineSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadHypervVirtualMachineSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadHypervVirtualMachineSnapshot",
                "($input: DownloadHypervVirtualMachineSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadHypervVirtualMachineSnapshot,
                Mutation.DownloadHypervVirtualMachineSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadHypervVirtualMachineSnapshotFiles(input: DownloadHypervVirtualMachineSnapshotFilesInput!): AsyncRequestStatus!
        internal void InitMutationDownloadHypervVirtualMachineSnapshotFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadHypervVirtualMachineSnapshotFilesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadHypervVirtualMachineSnapshotFiles",
                "($input: DownloadHypervVirtualMachineSnapshotFilesInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadHypervVirtualMachineSnapshotFiles,
                Mutation.DownloadHypervVirtualMachineSnapshotFilesFieldSpec,
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
	# OPTIONAL
	userNote = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // exportHypervVirtualMachine(input: ExportHypervVirtualMachineInput!): AsyncRequestStatus!
        internal void InitMutationExportHypervVirtualMachine()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportHypervVirtualMachineInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExportHypervVirtualMachine",
                "($input: ExportHypervVirtualMachineInput!)",
                "AsyncRequestStatus",
                Mutation.ExportHypervVirtualMachine,
                Mutation.ExportHypervVirtualMachineFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		disableNetwork = $someBoolean
		# OPTIONAL
		hostId = $someString
		# OPTIONAL
		powerOn = $someBoolean
		# OPTIONAL
		removeNetworkDevices = $someBoolean
		# OPTIONAL
		vmName = $someString
		# REQUIRED
		path = $someString
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // inplaceExportHypervVirtualMachine(input: InplaceExportHypervVirtualMachineInput!): AsyncRequestStatus!
        internal void InitMutationInplaceExportHypervVirtualMachine()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "InplaceExportHypervVirtualMachineInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationInplaceExportHypervVirtualMachine",
                "($input: InplaceExportHypervVirtualMachineInput!)",
                "AsyncRequestStatus",
                Mutation.InplaceExportHypervVirtualMachine,
                Mutation.InplaceExportHypervVirtualMachineFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		exportVmPath = $someString
		# OPTIONAL
		hostId = $someString
		# OPTIONAL
		shouldKeepHypervVmCopyAfterRecovery = $someBoolean
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // instantRecoverHypervVirtualMachineSnapshot(input: InstantRecoverHypervVirtualMachineSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationInstantRecoverHypervVirtualMachineSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "InstantRecoverHypervVirtualMachineSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationInstantRecoverHypervVirtualMachineSnapshot",
                "($input: InstantRecoverHypervVirtualMachineSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.InstantRecoverHypervVirtualMachineSnapshot,
                Mutation.InstantRecoverHypervVirtualMachineSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		hostId = $someString
		# OPTIONAL
		vmName = $someString
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // hypervOnDemandSnapshot(input: HypervOnDemandSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationHypervOnDemandSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "HypervOnDemandSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationHypervOnDemandSnapshot",
                "($input: HypervOnDemandSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.HypervOnDemandSnapshot,
                Mutation.HypervOnDemandSnapshotFieldSpec,
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
        // refreshHypervScvmm(input: RefreshHypervScvmmInput!): AsyncRequestStatus!
        internal void InitMutationRefreshHypervScvmm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshHypervScvmmInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshHypervScvmm",
                "($input: RefreshHypervScvmmInput!)",
                "AsyncRequestStatus",
                Mutation.RefreshHypervScvmm,
                Mutation.RefreshHypervScvmmFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // refreshHypervServer(input: RefreshHypervServerInput!): AsyncRequestStatus!
        internal void InitMutationRefreshHypervServer()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshHypervServerInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshHypervServer",
                "($input: RefreshHypervServerInput!)",
                "AsyncRequestStatus",
                Mutation.RefreshHypervServer,
                Mutation.RefreshHypervServerFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // registerAgentHypervVirtualMachine(input: RegisterAgentHypervVirtualMachineInput!): RequestSuccess!
        internal void InitMutationRegisterAgentHypervVirtualMachine()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RegisterAgentHypervVirtualMachineInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRegisterAgentHypervVirtualMachine",
                "($input: RegisterAgentHypervVirtualMachineInput!)",
                "RequestSuccess",
                Mutation.RegisterAgentHypervVirtualMachine,
                Mutation.RegisterAgentHypervVirtualMachineFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // registerHypervScvmm(input: RegisterHypervScvmmInput!): AsyncRequestStatus!
        internal void InitMutationRegisterHypervScvmm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RegisterHypervScvmmInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRegisterHypervScvmm",
                "($input: RegisterHypervScvmmInput!)",
                "AsyncRequestStatus",
                Mutation.RegisterHypervScvmm,
                Mutation.RegisterHypervScvmmFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	scvmm = @{
		# REQUIRED
		hostname = $someString
		# REQUIRED
		runAsAccount = $someString
		# REQUIRED
		shouldDeployAgent = $someBoolean
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // restoreHypervVirtualMachineSnapshotFiles(input: RestoreHypervVirtualMachineSnapshotFilesInput!): AsyncRequestStatus!
        internal void InitMutationRestoreHypervVirtualMachineSnapshotFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreHypervVirtualMachineSnapshotFilesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreHypervVirtualMachineSnapshotFiles",
                "($input: RestoreHypervVirtualMachineSnapshotFilesInput!)",
                "AsyncRequestStatus",
                Mutation.RestoreHypervVirtualMachineSnapshotFiles,
                Mutation.RestoreHypervVirtualMachineSnapshotFilesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		targetVirtualMachineId = $someString
		# OPTIONAL
		shouldIgnoreError = $someBoolean
		# REQUIRED
		restoreConfig = @(
			@{
				# REQUIRED
				path = $someString
				# REQUIRED
				restorePath = $someString
			}
		)
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // hypervScvmmDelete(input: HypervScvmmDeleteInput!): ResponseSuccess!
        internal void InitMutationHypervScvmmDelete()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "HypervScvmmDeleteInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationHypervScvmmDelete",
                "($input: HypervScvmmDeleteInput!)",
                "ResponseSuccess",
                Mutation.HypervScvmmDelete,
                Mutation.HypervScvmmDeleteFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // hypervScvmmUpdate(input: HypervScvmmUpdateInput!): HypervScvmmUpdateReply!
        internal void InitMutationHypervScvmmUpdate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "HypervScvmmUpdateInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationHypervScvmmUpdate",
                "($input: HypervScvmmUpdateInput!)",
                "HypervScvmmUpdateReply",
                Mutation.HypervScvmmUpdate,
                Mutation.HypervScvmmUpdateFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	updateProperties = @{
		# OPTIONAL
		configuredSlaDomainId = $someString
		# OPTIONAL
		hostname = $someString
		# OPTIONAL
		runAsAccount = $someString
		# OPTIONAL
		shouldDeployAgent = $someBoolean
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateHypervVirtualMachine(input: UpdateHypervVirtualMachineInput!): UpdateHypervVirtualMachineReply!
        internal void InitMutationUpdateHypervVirtualMachine()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateHypervVirtualMachineInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateHypervVirtualMachine",
                "($input: UpdateHypervVirtualMachineInput!)",
                "UpdateHypervVirtualMachineReply",
                Mutation.UpdateHypervVirtualMachine,
                Mutation.UpdateHypervVirtualMachineFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	vmUpdateProperties = @{
		# OPTIONAL
		configuredSlaDomainId = $someString
		# OPTIONAL
		virtualDiskIdsExcludedFromSnapshot = @(
			$someString
		)
		# OPTIONAL
		cloudInstantiationSpec = @{
			# REQUIRED
			imageRetentionInSeconds = $someInt64
		}
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateHypervVirtualMachineSnapshotMount(input: UpdateHypervVirtualMachineSnapshotMountInput!): UpdateHypervVirtualMachineSnapshotMountReply!
        internal void InitMutationUpdateHypervVirtualMachineSnapshotMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateHypervVirtualMachineSnapshotMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateHypervVirtualMachineSnapshotMount",
                "($input: UpdateHypervVirtualMachineSnapshotMountInput!)",
                "UpdateHypervVirtualMachineSnapshotMountReply",
                Mutation.UpdateHypervVirtualMachineSnapshotMount,
                Mutation.UpdateHypervVirtualMachineSnapshotMountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		powerStatus = $someBoolean
	}
	# REQUIRED
	id = $someString
}"
            );
        }


    } // class New_RscMutationHyperv
}