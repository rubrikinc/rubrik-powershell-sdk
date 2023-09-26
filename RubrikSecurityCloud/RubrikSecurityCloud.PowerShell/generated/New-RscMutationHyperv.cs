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
    /// Create a new RscQuery object for any of the 23
    /// operations in the 'Hyperv' API domain:
    /// BatchExportVm, BatchInstantRecoverVm, BatchMountVm, BatchOnDemandBackupVm, CreateVirtualMachineSnapshotMount, DeleteAllSnapshots, DeleteVirtualMachineSnapshot, DeleteVirtualMachineSnapshotMount, DownloadSnapshotFromLocation, DownloadVirtualMachineSnapshot, DownloadVirtualMachineSnapshotFiles, ExportVirtualMachine, InstantRecoverVirtualMachineSnapshot, OnDemandSnapshot, RefreshScvmm, RefreshServer, RegisterAgentVirtualMachine, RegisterScvmm, RestoreVirtualMachineSnapshotFiles, ScvmmDelete, ScvmmUpdate, UpdateVirtualMachine, or UpdateVirtualMachineSnapshotMount.
    /// </summary>
    /// <description>
    /// New-RscMutationHyperv creates a new
    /// mutation object for operations
    /// in the 'Hyperv' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 23 operations
    /// in the 'Hyperv' API domain. Select the operation this
    /// query is for by specifying the appropriate switch parameter;
    /// one of: -BatchExportVm, -BatchInstantRecoverVm, -BatchMountVm, -BatchOnDemandBackupVm, -CreateVirtualMachineSnapshotMount, -DeleteAllSnapshots, -DeleteVirtualMachineSnapshot, -DeleteVirtualMachineSnapshotMount, -DownloadSnapshotFromLocation, -DownloadVirtualMachineSnapshot, -DownloadVirtualMachineSnapshotFiles, -ExportVirtualMachine, -InstantRecoverVirtualMachineSnapshot, -OnDemandSnapshot, -RefreshScvmm, -RefreshServer, -RegisterAgentVirtualMachine, -RegisterScvmm, -RestoreVirtualMachineSnapshotFiles, -ScvmmDelete, -ScvmmUpdate, -UpdateVirtualMachine, -UpdateVirtualMachineSnapshotMount.
    /// Alternatively, you can specify the operation by setting the
    /// -Op parameter, for example: -Op BatchExportVm,
    /// which is equivalent to specifying -BatchExportVm.
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
    /// of the 'Hyperv' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: BatchExportVm
    /// 
    /// $query = New-RscMutationHyperv -BatchExportVm
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
    /// of the 'Hyperv' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: BatchInstantRecoverVm
    /// 
    /// $query = New-RscMutationHyperv -BatchInstantRecoverVm
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
    /// of the 'Hyperv' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: BatchMountVm
    /// 
    /// $query = New-RscMutationHyperv -BatchMountVm
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
    /// of the 'Hyperv' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: BatchOnDemandBackupVm
    /// 
    /// $query = New-RscMutationHyperv -BatchOnDemandBackupVm
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
    /// Runs the CreateVirtualMachineSnapshotMount operation
    /// of the 'Hyperv' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: CreateVirtualMachineSnapshotMount
    /// 
    /// $query = New-RscMutationHyperv -CreateVirtualMachineSnapshotMount
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
    /// of the 'Hyperv' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: DeleteAllSnapshots
    /// 
    /// $query = New-RscMutationHyperv -DeleteAllSnapshots
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
    /// of the 'Hyperv' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: DeleteVirtualMachineSnapshot
    /// 
    /// $query = New-RscMutationHyperv -DeleteVirtualMachineSnapshot
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
    /// of the 'Hyperv' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: DeleteVirtualMachineSnapshotMount
    /// 
    /// $query = New-RscMutationHyperv -DeleteVirtualMachineSnapshotMount
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
    /// of the 'Hyperv' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: DownloadSnapshotFromLocation
    /// 
    /// $query = New-RscMutationHyperv -DownloadSnapshotFromLocation
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
    /// Runs the DownloadVirtualMachineSnapshot operation
    /// of the 'Hyperv' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: DownloadVirtualMachineSnapshot
    /// 
    /// $query = New-RscMutationHyperv -DownloadVirtualMachineSnapshot
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
    /// of the 'Hyperv' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: DownloadVirtualMachineSnapshotFiles
    /// 
    /// $query = New-RscMutationHyperv -DownloadVirtualMachineSnapshotFiles
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
    /// of the 'Hyperv' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: ExportVirtualMachine
    /// 
    /// $query = New-RscMutationHyperv -ExportVirtualMachine
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
    /// Runs the InstantRecoverVirtualMachineSnapshot operation
    /// of the 'Hyperv' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: InstantRecoverVirtualMachineSnapshot
    /// 
    /// $query = New-RscMutationHyperv -InstantRecoverVirtualMachineSnapshot
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
    /// of the 'Hyperv' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: OnDemandSnapshot
    /// 
    /// $query = New-RscMutationHyperv -OnDemandSnapshot
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
    /// of the 'Hyperv' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: RefreshScvmm
    /// 
    /// $query = New-RscMutationHyperv -RefreshScvmm
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
    /// of the 'Hyperv' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: RefreshServer
    /// 
    /// $query = New-RscMutationHyperv -RefreshServer
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
    /// of the 'Hyperv' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: RegisterAgentVirtualMachine
    /// 
    /// $query = New-RscMutationHyperv -RegisterAgentVirtualMachine
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
    /// of the 'Hyperv' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: RegisterScvmm
    /// 
    /// $query = New-RscMutationHyperv -RegisterScvmm
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
    /// of the 'Hyperv' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: RestoreVirtualMachineSnapshotFiles
    /// 
    /// $query = New-RscMutationHyperv -RestoreVirtualMachineSnapshotFiles
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		targetVirtualMachineId = $someString
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
    /// of the 'Hyperv' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: ScvmmDelete
    /// 
    /// $query = New-RscMutationHyperv -ScvmmDelete
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
    /// of the 'Hyperv' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: ScvmmUpdate
    /// 
    /// $query = New-RscMutationHyperv -ScvmmUpdate
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
    /// of the 'Hyperv' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: UpdateVirtualMachine
    /// 
    /// $query = New-RscMutationHyperv -UpdateVirtualMachine
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	vmUpdateProperties = @{
    /// 		# OPTIONAL
    /// 		cloudInstantiationSpec = @{
    /// 			# REQUIRED
    /// 			imageRetentionInSeconds = $someInt64
    /// 		}
    /// 		# OPTIONAL
    /// 		configuredSlaDomainId = $someString
    /// 		# OPTIONAL
    /// 		virtualDiskIdsExcludedFromSnapshot = @(
    /// 			$someString
    /// 		)
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
    /// of the 'Hyperv' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: UpdateVirtualMachineSnapshotMount
    /// 
    /// $query = New-RscMutationHyperv -UpdateVirtualMachineSnapshotMount
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
        DefaultParameterSetName = "ScvmmUpdate")
    ]
    public class New_RscMutationHyperv : RscGqlPSCmdlet
    {
        
        [Parameter(
            ParameterSetName = "BatchExportVm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'BatchExportVm' operation
in the 'Hyperv' API domain.
Description of the operation:
Exports a snapshot from each member of a set of virtual machines

Supported in v7.0+
Export a snapshot from each member of a set of virtual machines.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/batchexporthypervvm.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter BatchExportVm { get; set; }

        
        [Parameter(
            ParameterSetName = "BatchInstantRecoverVm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'BatchInstantRecoverVm' operation
in the 'Hyperv' API domain.
Description of the operation:
Instantly recovers snapshots from multiple virtual machines

Supported in v7.0+
Instantly recovers a batch of snapshots from a group of specified virtual machines.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/batchinstantrecoverhypervvm.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter BatchInstantRecoverVm { get; set; }

        
        [Parameter(
            ParameterSetName = "BatchMountVm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'BatchMountVm' operation
in the 'Hyperv' API domain.
Description of the operation:
Mount snapshots from multiple virtual machines

Supported in v7.0+
Mounts a batch of snapshots from a group of specified virtual machines.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/batchmounthypervvm.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter BatchMountVm { get; set; }

        
        [Parameter(
            ParameterSetName = "BatchOnDemandBackupVm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'BatchOnDemandBackupVm' operation
in the 'Hyperv' API domain.
Description of the operation:
Takes bulk on-demand backup of Hyper-V virtual machines

Supported in v9.0+
Takes on-demand backup of multiple specified Hyper-V virtual machines.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/batchondemandbackuphypervvm.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter BatchOnDemandBackupVm { get; set; }

        
        [Parameter(
            ParameterSetName = "CreateVirtualMachineSnapshotMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreateVirtualMachineSnapshotMount' operation
in the 'Hyperv' API domain.
Description of the operation:
Create a live mount request

Supported in v5.0+
Create a live mount request with given configuration.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createhypervvirtualmachinesnapshotmount.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreateVirtualMachineSnapshotMount { get; set; }

        
        [Parameter(
            ParameterSetName = "DeleteAllSnapshots",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DeleteAllSnapshots' operation
in the 'Hyperv' API domain.
Description of the operation:
Delete all snapshots of VM

Supported in v5.0+
Delete all snapshots of a virtual machine.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/hypervdeleteallsnapshots.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DeleteAllSnapshots { get; set; }

        
        [Parameter(
            ParameterSetName = "DeleteVirtualMachineSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DeleteVirtualMachineSnapshot' operation
in the 'Hyperv' API domain.
Description of the operation:
Delete VM snapshot

Supported in v5.0+
Delete a snapshot by expiring it. Snapshot is expired only if it is a manual snapshot or a snapshot of an unprotected vm.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/deletehypervvirtualmachinesnapshot.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DeleteVirtualMachineSnapshot { get; set; }

        
        [Parameter(
            ParameterSetName = "DeleteVirtualMachineSnapshotMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DeleteVirtualMachineSnapshotMount' operation
in the 'Hyperv' API domain.
Description of the operation:
Requst to delete a live mount

Supported in v5.0+
Create a request to delete a live mount.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/deletehypervvirtualmachinesnapshotmount.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DeleteVirtualMachineSnapshotMount { get; set; }

        
        [Parameter(
            ParameterSetName = "DownloadSnapshotFromLocation",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DownloadSnapshotFromLocation' operation
in the 'Hyperv' API domain.
Description of the operation:
Download a snapshot from a replication target

Supported in v7.0+
Initiates a job to download a snapshot from the specified location when the snapshot does not exist locally. The specified location has to be a replication target connected to this Rubrik cluster. If an SLA Domain is not provided, the snapshot will be retained forever.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/downloadhypervsnapshotfromlocation.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DownloadSnapshotFromLocation { get; set; }

        
        [Parameter(
            ParameterSetName = "DownloadVirtualMachineSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DownloadVirtualMachineSnapshot' operation
in the 'Hyperv' API domain.
Description of the operation:
Creates a download from archival request

Supported in v5.0+
Download a snapshot from archival.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/downloadhypervvirtualmachinesnapshot.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DownloadVirtualMachineSnapshot { get; set; }

        
        [Parameter(
            ParameterSetName = "DownloadVirtualMachineSnapshotFiles",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DownloadVirtualMachineSnapshotFiles' operation
in the 'Hyperv' API domain.
Description of the operation:
Download files from a Hyper-V VM backup

Supported in v5.0+
Start an asynchronous job to download multiple files and folders from a specified Hyper-V VM backup. The response returns an asynchrounous request ID. Get the URL for downloading the ZIP file including the specific files/folders by sending a GET request to 'hyperv/vm/request/{id}'.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/downloadhypervvirtualmachinesnapshotfiles.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DownloadVirtualMachineSnapshotFiles { get; set; }

        
        [Parameter(
            ParameterSetName = "ExportVirtualMachine",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'ExportVirtualMachine' operation
in the 'Hyperv' API domain.
Description of the operation:
Export VM snapshot

Supported in v5.0+
Export snapshot of a vm.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/exporthypervvirtualmachine.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter ExportVirtualMachine { get; set; }

        
        [Parameter(
            ParameterSetName = "InstantRecoverVirtualMachineSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'InstantRecoverVirtualMachineSnapshot' operation
in the 'Hyperv' API domain.
Description of the operation:
Creates an instant recover request that restores a target VM from the given Rubrik-hosted-snapshot

Supported in v5.0+
The VM will be started with networking enabled. If the VM does not exist anymore, a new VM will be created.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/instantrecoverhypervvirtualmachinesnapshot.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter InstantRecoverVirtualMachineSnapshot { get; set; }

        
        [Parameter(
            ParameterSetName = "OnDemandSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'OnDemandSnapshot' operation
in the 'Hyperv' API domain.
Description of the operation:
Create on-demand VM snapshot

Supported in v5.0+
Create an on-demand snapshot for the given VM ID.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/hypervondemandsnapshot.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter OnDemandSnapshot { get; set; }

        
        [Parameter(
            ParameterSetName = "RefreshScvmm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'RefreshScvmm' operation
in the 'Hyperv' API domain.
Description of the operation:
Refresh a given HyperV SCVMM.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/refreshhypervscvmm.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter RefreshScvmm { get; set; }

        
        [Parameter(
            ParameterSetName = "RefreshServer",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'RefreshServer' operation
in the 'Hyperv' API domain.
Description of the operation:
Refresh Hyper-V host metadata

Supported in v5.0+
Create a job to refresh the metadata for the specified Hyper-V host.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/refreshhypervserver.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter RefreshServer { get; set; }

        
        [Parameter(
            ParameterSetName = "RegisterAgentVirtualMachine",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'RegisterAgentVirtualMachine' operation
in the 'Hyperv' API domain.
Description of the operation:
Register the agent installed in VM

Supported in v5.0+
Register the agent that installed in VM.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/registeragenthypervvirtualmachine.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter RegisterAgentVirtualMachine { get; set; }

        
        [Parameter(
            ParameterSetName = "RegisterScvmm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'RegisterScvmm' operation
in the 'Hyperv' API domain.
Description of the operation:
Register HyperV SCVMM to Rubrik Cluster.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/registerhypervscvmm.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter RegisterScvmm { get; set; }

        
        [Parameter(
            ParameterSetName = "RestoreVirtualMachineSnapshotFiles",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'RestoreVirtualMachineSnapshotFiles' operation
in the 'Hyperv' API domain.
Description of the operation:
Restore files from snapshot

Supported in v5.0+
Restore files from a snapshot to the original source location.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/restorehypervvirtualmachinesnapshotfiles.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter RestoreVirtualMachineSnapshotFiles { get; set; }

        
        [Parameter(
            ParameterSetName = "ScvmmDelete",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'ScvmmDelete' operation
in the 'Hyperv' API domain.
Description of the operation:
Delete a given HyperV SCVMM.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/hypervscvmmdelete.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter ScvmmDelete { get; set; }

        
        [Parameter(
            ParameterSetName = "ScvmmUpdate",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'ScvmmUpdate' operation
in the 'Hyperv' API domain.
Description of the operation:
Update properties for a given HyperV SCVMM.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/hypervscvmmupdate.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter ScvmmUpdate { get; set; }

        
        [Parameter(
            ParameterSetName = "UpdateVirtualMachine",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpdateVirtualMachine' operation
in the 'Hyperv' API domain.
Description of the operation:
Update VM

Supported in v5.0+
Update VM with specified properties.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/updatehypervvirtualmachine.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpdateVirtualMachine { get; set; }

        
        [Parameter(
            ParameterSetName = "UpdateVirtualMachineSnapshotMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpdateVirtualMachineSnapshotMount' operation
in the 'Hyperv' API domain.
Description of the operation:
Power a Live Mount on and off

Supported in v5.0+
Power a specified Live Mount virtual machine on or off. Pass **_true_** to power the virtual machine on and pass **_false_** to power the virtual machine off.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/updatehypervvirtualmachinesnapshotmount.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpdateVirtualMachineSnapshotMount { get; set; }



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
                    case "DownloadVirtualMachineSnapshot":
                        this.ProcessRecord_DownloadVirtualMachineSnapshot();
                        break;
                    case "DownloadVirtualMachineSnapshotFiles":
                        this.ProcessRecord_DownloadVirtualMachineSnapshotFiles();
                        break;
                    case "ExportVirtualMachine":
                        this.ProcessRecord_ExportVirtualMachine();
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
                Mutation.BatchExportHypervVm_ObjectFieldSpec,
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
                Mutation.BatchInstantRecoverHypervVm_ObjectFieldSpec,
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
                Mutation.BatchMountHypervVm_ObjectFieldSpec,
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
                Mutation.BatchOnDemandBackupHypervVm_ObjectFieldSpec,
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
                Mutation.CreateHypervVirtualMachineSnapshotMount_ObjectFieldSpec,
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
                Mutation.HypervDeleteAllSnapshots_ObjectFieldSpec,
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
                Mutation.DeleteHypervVirtualMachineSnapshot_ObjectFieldSpec,
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
                Mutation.DeleteHypervVirtualMachineSnapshotMount_ObjectFieldSpec,
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
                Mutation.DownloadHypervSnapshotFromLocation_ObjectFieldSpec,
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
                Mutation.DownloadHypervVirtualMachineSnapshot_ObjectFieldSpec,
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
                Mutation.DownloadHypervVirtualMachineSnapshotFiles_ObjectFieldSpec,
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
                Mutation.ExportHypervVirtualMachine_ObjectFieldSpec,
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
                Mutation.InstantRecoverHypervVirtualMachineSnapshot_ObjectFieldSpec,
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
                Mutation.HypervOnDemandSnapshot_ObjectFieldSpec,
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
                Mutation.RefreshHypervScvmm_ObjectFieldSpec,
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
                Mutation.RefreshHypervServer_ObjectFieldSpec,
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
                Mutation.RegisterAgentHypervVirtualMachine_ObjectFieldSpec,
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
                Mutation.RegisterHypervScvmm_ObjectFieldSpec,
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
                Mutation.RestoreHypervVirtualMachineSnapshotFiles_ObjectFieldSpec,
                Mutation.RestoreHypervVirtualMachineSnapshotFilesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		targetVirtualMachineId = $someString
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
                Mutation.HypervScvmmDelete_ObjectFieldSpec,
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
                Mutation.HypervScvmmUpdate_ObjectFieldSpec,
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
                Mutation.UpdateHypervVirtualMachine_ObjectFieldSpec,
                Mutation.UpdateHypervVirtualMachineFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	vmUpdateProperties = @{
		# OPTIONAL
		cloudInstantiationSpec = @{
			# REQUIRED
			imageRetentionInSeconds = $someInt64
		}
		# OPTIONAL
		configuredSlaDomainId = $someString
		# OPTIONAL
		virtualDiskIdsExcludedFromSnapshot = @(
			$someString
		)
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
                Mutation.UpdateHypervVirtualMachineSnapshotMount_ObjectFieldSpec,
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