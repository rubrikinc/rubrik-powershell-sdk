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
    /// Create a new RscQuery object for any of the 27
    /// operations in the 'Nutanix' API domain:
    /// BatchExportVm, BatchMountVm, BulkOnDemandSnapshotVm, CreateCluster, CreateOnDemandBackup, CreatePrismCentral, DeleteCluster, DeleteMountV1, DeletePrismCentral, DeleteSnapshot, DeleteSnapshots, DownloadFilesSnapshot, DownloadSnapshot, DownloadVdisks, DownloadVmFromLocation, ExportSnapshot, MigrateMountV1, MountSnapshotV1, MountVdisks, PatchMountV1, RefreshCluster, RefreshPrismCentral, RegisterAgentVm, RestoreFilesSnapshot, UpdateCluster, UpdatePrismCentral, or UpdateVm.
    /// </summary>
    /// <description>
    /// New-RscMutationNutanix creates a new
    /// mutation object for operations
    /// in the 'Nutanix' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 27 operations
    /// in the 'Nutanix' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: BatchExportVm, BatchMountVm, BulkOnDemandSnapshotVm, CreateCluster, CreateOnDemandBackup, CreatePrismCentral, DeleteCluster, DeleteMountV1, DeletePrismCentral, DeleteSnapshot, DeleteSnapshots, DownloadFilesSnapshot, DownloadSnapshot, DownloadVdisks, DownloadVmFromLocation, ExportSnapshot, MigrateMountV1, MountSnapshotV1, MountVdisks, PatchMountV1, RefreshCluster, RefreshPrismCentral, RegisterAgentVm, RestoreFilesSnapshot, UpdateCluster, UpdatePrismCentral, or UpdateVm.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationNutanix -BatchExportVm).Info().
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
    /// (New-RscMutationNutanix -BatchExportVm).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the BatchExportVm operation
    /// of the 'Nutanix' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nutanix
    /// # API Operation: BatchExportVm
    /// 
    /// $query = New-RscMutationNutanix -BatchExportVm
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
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
    /// 					nutanixClusterId = $someString
    /// 					# OPTIONAL
    /// 					powerOn = $someBoolean
    /// 					# OPTIONAL
    /// 					removeNetworkDevices = $someBoolean
    /// 					# OPTIONAL
    /// 					vmName = $someString
    /// 					# OPTIONAL
    /// 					keepMacAddresses = $someBoolean
    /// 					# OPTIONAL
    /// 					nicNetworkUuids = @(
    /// 						$someString
    /// 					)
    /// 					# REQUIRED
    /// 					containerNaturalId = $someString
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
    /// Write-Host $result.GetType().Name # prints: BatchExportNutanixVmReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BatchMountVm operation
    /// of the 'Nutanix' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nutanix
    /// # API Operation: BatchMountVm
    /// 
    /// $query = New-RscMutationNutanix -BatchMountVm
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
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
    /// 					containerNaturalId = $someString
    /// 					# OPTIONAL
    /// 					nutanixClusterId = $someString
    /// 					# OPTIONAL
    /// 					shouldMigrateImmediately = $someBoolean
    /// 					# OPTIONAL
    /// 					shouldPowerOn = $someBoolean
    /// 					# OPTIONAL
    /// 					shouldRemoveNetwork = $someBoolean
    /// 					# OPTIONAL
    /// 					targetNetwork = $someString
    /// 					# OPTIONAL
    /// 					vmName = $someString
    /// 					# OPTIONAL
    /// 					keepMacAddresses = $someBoolean
    /// 					# OPTIONAL
    /// 					nicNetworkUuids = @(
    /// 						$someString
    /// 					)
    /// 					# REQUIRED
    /// 					shouldDisableMigration = $someBoolean
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
    /// Write-Host $result.GetType().Name # prints: BatchMountNutanixVmReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BulkOnDemandSnapshotVm operation
    /// of the 'Nutanix' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nutanix
    /// # API Operation: BulkOnDemandSnapshotVm
    /// 
    /// $query = New-RscMutationNutanix -BulkOnDemandSnapshotVm
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# REQUIRED
    /// 		vms = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				backupConfig = @{
    /// 					# OPTIONAL
    /// 					slaId = $someString
    /// 				}
    /// 				# REQUIRED
    /// 				vmId = $someString
    /// 			}
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
    /// Write-Host $result.GetType().Name # prints: BulkOnDemandSnapshotNutanixVmReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateCluster operation
    /// of the 'Nutanix' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nutanix
    /// # API Operation: CreateCluster
    /// 
    /// $query = New-RscMutationNutanix -CreateCluster
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	nutanixClusterConfig = @{
    /// 		# REQUIRED
    /// 		caCerts = $someString
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		nutanixClusterUuid = $someString
    /// 		# REQUIRED
    /// 		password = $someString
    /// 		# REQUIRED
    /// 		username = $someString
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
    /// Runs the CreateOnDemandBackup operation
    /// of the 'Nutanix' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nutanix
    /// # API Operation: CreateOnDemandBackup
    /// 
    /// $query = New-RscMutationNutanix -CreateOnDemandBackup
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
    /// Runs the CreatePrismCentral operation
    /// of the 'Nutanix' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nutanix
    /// # API Operation: CreatePrismCentral
    /// 
    /// $query = New-RscMutationNutanix -CreatePrismCentral
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	prismCentralConfig = @{
    /// 		# REQUIRED
    /// 		caCerts = $someString
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		password = $someString
    /// 		# REQUIRED
    /// 		username = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	prismElementCdmTuple = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			nutanixClusterId = $someString
    /// 			# REQUIRED
    /// 			cdmClusterId = $someString
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	isDrEnabled = $someBoolean
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
    /// Runs the DeleteCluster operation
    /// of the 'Nutanix' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nutanix
    /// # API Operation: DeleteCluster
    /// 
    /// $query = New-RscMutationNutanix -DeleteCluster
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
    /// Runs the DeleteMountV1 operation
    /// of the 'Nutanix' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nutanix
    /// # API Operation: DeleteMountV1
    /// 
    /// $query = New-RscMutationNutanix -DeleteMountV1
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
    /// Runs the DeletePrismCentral operation
    /// of the 'Nutanix' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nutanix
    /// # API Operation: DeletePrismCentral
    /// 
    /// $query = New-RscMutationNutanix -DeletePrismCentral
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
    /// Write-Host $result.GetType().Name # prints: BatchAsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteSnapshot operation
    /// of the 'Nutanix' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nutanix
    /// # API Operation: DeleteSnapshot
    /// 
    /// $query = New-RscMutationNutanix -DeleteSnapshot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	location = $someInternalDeleteNutanixSnapshotRequestLocation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InternalDeleteNutanixSnapshotRequestLocation]) for enum values.
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
    /// Runs the DeleteSnapshots operation
    /// of the 'Nutanix' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nutanix
    /// # API Operation: DeleteSnapshots
    /// 
    /// $query = New-RscMutationNutanix -DeleteSnapshots
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
    /// Runs the DownloadFilesSnapshot operation
    /// of the 'Nutanix' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nutanix
    /// # API Operation: DownloadFilesSnapshot
    /// 
    /// $query = New-RscMutationNutanix -DownloadFilesSnapshot
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
    /// Runs the DownloadSnapshot operation
    /// of the 'Nutanix' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nutanix
    /// # API Operation: DownloadSnapshot
    /// 
    /// $query = New-RscMutationNutanix -DownloadSnapshot
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
    /// Runs the DownloadVdisks operation
    /// of the 'Nutanix' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nutanix
    /// # API Operation: DownloadVdisks
    /// 
    /// $query = New-RscMutationNutanix -DownloadVdisks
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	vdiskIds = @(
    /// 		$someString
    /// 	)
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
    /// Runs the DownloadVmFromLocation operation
    /// of the 'Nutanix' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nutanix
    /// # API Operation: DownloadVmFromLocation
    /// 
    /// $query = New-RscMutationNutanix -DownloadVmFromLocation
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
    /// Runs the ExportSnapshot operation
    /// of the 'Nutanix' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nutanix
    /// # API Operation: ExportSnapshot
    /// 
    /// $query = New-RscMutationNutanix -ExportSnapshot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		nutanixClusterId = $someString
    /// 		# OPTIONAL
    /// 		powerOn = $someBoolean
    /// 		# OPTIONAL
    /// 		removeNetworkDevices = $someBoolean
    /// 		# OPTIONAL
    /// 		vmName = $someString
    /// 		# OPTIONAL
    /// 		keepMacAddresses = $someBoolean
    /// 		# OPTIONAL
    /// 		nicNetworkUuids = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		containerNaturalId = $someString
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
    /// Runs the MigrateMountV1 operation
    /// of the 'Nutanix' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nutanix
    /// # API Operation: MigrateMountV1
    /// 
    /// $query = New-RscMutationNutanix -MigrateMountV1
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
    /// Runs the MountSnapshotV1 operation
    /// of the 'Nutanix' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nutanix
    /// # API Operation: MountSnapshotV1
    /// 
    /// $query = New-RscMutationNutanix -MountSnapshotV1
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		containerNaturalId = $someString
    /// 		# OPTIONAL
    /// 		nutanixClusterId = $someString
    /// 		# OPTIONAL
    /// 		shouldMigrateImmediately = $someBoolean
    /// 		# OPTIONAL
    /// 		shouldPowerOn = $someBoolean
    /// 		# OPTIONAL
    /// 		shouldRemoveNetwork = $someBoolean
    /// 		# OPTIONAL
    /// 		targetNetwork = $someString
    /// 		# OPTIONAL
    /// 		vmName = $someString
    /// 		# OPTIONAL
    /// 		keepMacAddresses = $someBoolean
    /// 		# OPTIONAL
    /// 		nicNetworkUuids = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		shouldDisableMigration = $someBoolean
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
    /// Runs the MountVdisks operation
    /// of the 'Nutanix' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nutanix
    /// # API Operation: MountVdisks
    /// 
    /// $query = New-RscMutationNutanix -MountVdisks
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		shouldMigrateImmediately = $someBoolean
    /// 		# OPTIONAL
    /// 		containerNaturalId = $someString
    /// 		# REQUIRED
    /// 		shouldDisableMigration = $someBoolean
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
    /// Runs the PatchMountV1 operation
    /// of the 'Nutanix' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nutanix
    /// # API Operation: PatchMountV1
    /// 
    /// $query = New-RscMutationNutanix -PatchMountV1
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# REQUIRED
    /// 		shouldPowerOn = $someBoolean
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PatchNutanixMountV1Reply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RefreshCluster operation
    /// of the 'Nutanix' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nutanix
    /// # API Operation: RefreshCluster
    /// 
    /// $query = New-RscMutationNutanix -RefreshCluster
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
    /// Runs the RefreshPrismCentral operation
    /// of the 'Nutanix' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nutanix
    /// # API Operation: RefreshPrismCentral
    /// 
    /// $query = New-RscMutationNutanix -RefreshPrismCentral
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
    /// Write-Host $result.GetType().Name # prints: BatchAsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RegisterAgentVm operation
    /// of the 'Nutanix' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nutanix
    /// # API Operation: RegisterAgentVm
    /// 
    /// $query = New-RscMutationNutanix -RegisterAgentVm
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
    /// Runs the RestoreFilesSnapshot operation
    /// of the 'Nutanix' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nutanix
    /// # API Operation: RestoreFilesSnapshot
    /// 
    /// $query = New-RscMutationNutanix -RestoreFilesSnapshot
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
    /// Runs the UpdateCluster operation
    /// of the 'Nutanix' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nutanix
    /// # API Operation: UpdateCluster
    /// 
    /// $query = New-RscMutationNutanix -UpdateCluster
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	patchProperties = @{
    /// 		# OPTIONAL
    /// 		caCerts = $someString
    /// 		# OPTIONAL
    /// 		configuredSlaDomainId = $someString
    /// 		# OPTIONAL
    /// 		hostname = $someString
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# OPTIONAL
    /// 		username = $someString
    /// 		# OPTIONAL
    /// 		snapshotConsistencyMandate = $someCdmNutanixSnapshotConsistencyMandate # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmNutanixSnapshotConsistencyMandate]) for enum values.
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateNutanixClusterReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdatePrismCentral operation
    /// of the 'Nutanix' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nutanix
    /// # API Operation: UpdatePrismCentral
    /// 
    /// $query = New-RscMutationNutanix -UpdatePrismCentral
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	patchProperties = @{
    /// 		# OPTIONAL
    /// 		caCerts = $someString
    /// 		# OPTIONAL
    /// 		configuredSlaDomainId = $someString
    /// 		# OPTIONAL
    /// 		hostname = $someString
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# OPTIONAL
    /// 		username = $someString
    /// 		# OPTIONAL
    /// 		isDrEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		nutanixClusters = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				name = $someString
    /// 				# REQUIRED
    /// 				clusterUuid = $someString
    /// 			}
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateNutanixPrismCentralReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateVm operation
    /// of the 'Nutanix' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nutanix
    /// # API Operation: UpdateVm
    /// 
    /// $query = New-RscMutationNutanix -UpdateVm
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	vmPatchProperties = @{
    /// 		# OPTIONAL
    /// 		configuredSlaDomainId = $someString
    /// 		# OPTIONAL
    /// 		excludedDiskIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		isPaused = $someBoolean
    /// 		# OPTIONAL
    /// 		snapshotConsistencyMandate = $someCdmNutanixSnapshotConsistencyMandate # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmNutanixSnapshotConsistencyMandate]) for enum values.
    /// 		# OPTIONAL
    /// 		postBackupScript = @{
    /// 			# REQUIRED
    /// 			failureHandling = $someNutanixVirtualMachineScriptDetailFailureHandling # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NutanixVirtualMachineScriptDetailFailureHandling]) for enum values.
    /// 			# REQUIRED
    /// 			scriptPath = $someString
    /// 			# REQUIRED
    /// 			timeoutMs = $someInt64
    /// 		}
    /// 		# OPTIONAL
    /// 		postSnapScript = @{
    /// 			# REQUIRED
    /// 			failureHandling = $someNutanixVirtualMachineScriptDetailFailureHandling # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NutanixVirtualMachineScriptDetailFailureHandling]) for enum values.
    /// 			# REQUIRED
    /// 			scriptPath = $someString
    /// 			# REQUIRED
    /// 			timeoutMs = $someInt64
    /// 		}
    /// 		# OPTIONAL
    /// 		preBackupScript = @{
    /// 			# REQUIRED
    /// 			failureHandling = $someNutanixVirtualMachineScriptDetailFailureHandling # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NutanixVirtualMachineScriptDetailFailureHandling]) for enum values.
    /// 			# REQUIRED
    /// 			scriptPath = $someString
    /// 			# REQUIRED
    /// 			timeoutMs = $someInt64
    /// 		}
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: NutanixVmDetail
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
        "RscMutationNutanix",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationNutanix : RscGqlPSCmdlet
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
                "BatchMountVm",
                "BulkOnDemandSnapshotVm",
                "CreateCluster",
                "CreateOnDemandBackup",
                "CreatePrismCentral",
                "DeleteCluster",
                "DeleteMountV1",
                "DeletePrismCentral",
                "DeleteSnapshot",
                "DeleteSnapshots",
                "DownloadFilesSnapshot",
                "DownloadSnapshot",
                "DownloadVdisks",
                "DownloadVmFromLocation",
                "ExportSnapshot",
                "MigrateMountV1",
                "MountSnapshotV1",
                "MountVdisks",
                "PatchMountV1",
                "RefreshCluster",
                "RefreshPrismCentral",
                "RegisterAgentVm",
                "RestoreFilesSnapshot",
                "UpdateCluster",
                "UpdatePrismCentral",
                "UpdateVm",
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
                    case "BatchMountVm":
                        this.ProcessRecord_BatchMountVm();
                        break;
                    case "BulkOnDemandSnapshotVm":
                        this.ProcessRecord_BulkOnDemandSnapshotVm();
                        break;
                    case "CreateCluster":
                        this.ProcessRecord_CreateCluster();
                        break;
                    case "CreateOnDemandBackup":
                        this.ProcessRecord_CreateOnDemandBackup();
                        break;
                    case "CreatePrismCentral":
                        this.ProcessRecord_CreatePrismCentral();
                        break;
                    case "DeleteCluster":
                        this.ProcessRecord_DeleteCluster();
                        break;
                    case "DeleteMountV1":
                        this.ProcessRecord_DeleteMountV1();
                        break;
                    case "DeletePrismCentral":
                        this.ProcessRecord_DeletePrismCentral();
                        break;
                    case "DeleteSnapshot":
                        this.ProcessRecord_DeleteSnapshot();
                        break;
                    case "DeleteSnapshots":
                        this.ProcessRecord_DeleteSnapshots();
                        break;
                    case "DownloadFilesSnapshot":
                        this.ProcessRecord_DownloadFilesSnapshot();
                        break;
                    case "DownloadSnapshot":
                        this.ProcessRecord_DownloadSnapshot();
                        break;
                    case "DownloadVdisks":
                        this.ProcessRecord_DownloadVdisks();
                        break;
                    case "DownloadVmFromLocation":
                        this.ProcessRecord_DownloadVmFromLocation();
                        break;
                    case "ExportSnapshot":
                        this.ProcessRecord_ExportSnapshot();
                        break;
                    case "MigrateMountV1":
                        this.ProcessRecord_MigrateMountV1();
                        break;
                    case "MountSnapshotV1":
                        this.ProcessRecord_MountSnapshotV1();
                        break;
                    case "MountVdisks":
                        this.ProcessRecord_MountVdisks();
                        break;
                    case "PatchMountV1":
                        this.ProcessRecord_PatchMountV1();
                        break;
                    case "RefreshCluster":
                        this.ProcessRecord_RefreshCluster();
                        break;
                    case "RefreshPrismCentral":
                        this.ProcessRecord_RefreshPrismCentral();
                        break;
                    case "RegisterAgentVm":
                        this.ProcessRecord_RegisterAgentVm();
                        break;
                    case "RestoreFilesSnapshot":
                        this.ProcessRecord_RestoreFilesSnapshot();
                        break;
                    case "UpdateCluster":
                        this.ProcessRecord_UpdateCluster();
                        break;
                    case "UpdatePrismCentral":
                        this.ProcessRecord_UpdatePrismCentral();
                        break;
                    case "UpdateVm":
                        this.ProcessRecord_UpdateVm();
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
        // bulkOnDemandSnapshotNutanixVm.
        internal void ProcessRecord_BulkOnDemandSnapshotVm()
        {
            this._logger.name += " -BulkOnDemandSnapshotVm";
            // Create new graphql operation bulkOnDemandSnapshotNutanixVm
            InitMutationBulkOnDemandSnapshotNutanixVm();
        }

        // This parameter set invokes a single graphql operation:
        // createNutanixCluster.
        internal void ProcessRecord_CreateCluster()
        {
            this._logger.name += " -CreateCluster";
            // Create new graphql operation createNutanixCluster
            InitMutationCreateNutanixCluster();
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
        // createNutanixPrismCentral.
        internal void ProcessRecord_CreatePrismCentral()
        {
            this._logger.name += " -CreatePrismCentral";
            // Create new graphql operation createNutanixPrismCentral
            InitMutationCreateNutanixPrismCentral();
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
        // deleteNutanixMountV1.
        internal void ProcessRecord_DeleteMountV1()
        {
            this._logger.name += " -DeleteMountV1";
            // Create new graphql operation deleteNutanixMountV1
            InitMutationDeleteNutanixMountV1();
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
        // deleteNutanixSnapshot.
        internal void ProcessRecord_DeleteSnapshot()
        {
            this._logger.name += " -DeleteSnapshot";
            // Create new graphql operation deleteNutanixSnapshot
            InitMutationDeleteNutanixSnapshot();
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
        // downloadFilesNutanixSnapshot.
        internal void ProcessRecord_DownloadFilesSnapshot()
        {
            this._logger.name += " -DownloadFilesSnapshot";
            // Create new graphql operation downloadFilesNutanixSnapshot
            InitMutationDownloadFilesNutanixSnapshot();
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
        // downloadNutanixVdisks.
        internal void ProcessRecord_DownloadVdisks()
        {
            this._logger.name += " -DownloadVdisks";
            // Create new graphql operation downloadNutanixVdisks
            InitMutationDownloadNutanixVdisks();
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
        // exportNutanixSnapshot.
        internal void ProcessRecord_ExportSnapshot()
        {
            this._logger.name += " -ExportSnapshot";
            // Create new graphql operation exportNutanixSnapshot
            InitMutationExportNutanixSnapshot();
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
        // mountNutanixSnapshotV1.
        internal void ProcessRecord_MountSnapshotV1()
        {
            this._logger.name += " -MountSnapshotV1";
            // Create new graphql operation mountNutanixSnapshotV1
            InitMutationMountNutanixSnapshotV1();
        }

        // This parameter set invokes a single graphql operation:
        // mountNutanixVdisks.
        internal void ProcessRecord_MountVdisks()
        {
            this._logger.name += " -MountVdisks";
            // Create new graphql operation mountNutanixVdisks
            InitMutationMountNutanixVdisks();
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
        // refreshNutanixCluster.
        internal void ProcessRecord_RefreshCluster()
        {
            this._logger.name += " -RefreshCluster";
            // Create new graphql operation refreshNutanixCluster
            InitMutationRefreshNutanixCluster();
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
        // registerAgentNutanixVm.
        internal void ProcessRecord_RegisterAgentVm()
        {
            this._logger.name += " -RegisterAgentVm";
            // Create new graphql operation registerAgentNutanixVm
            InitMutationRegisterAgentNutanixVm();
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
        // updateNutanixCluster.
        internal void ProcessRecord_UpdateCluster()
        {
            this._logger.name += " -UpdateCluster";
            // Create new graphql operation updateNutanixCluster
            InitMutationUpdateNutanixCluster();
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
        // updateNutanixVm.
        internal void ProcessRecord_UpdateVm()
        {
            this._logger.name += " -UpdateVm";
            // Create new graphql operation updateNutanixVm
            InitMutationUpdateNutanixVm();
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
                Mutation.BatchExportNutanixVm,
                Mutation.BatchExportNutanixVmFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
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
					nutanixClusterId = $someString
					# OPTIONAL
					powerOn = $someBoolean
					# OPTIONAL
					removeNetworkDevices = $someBoolean
					# OPTIONAL
					vmName = $someString
					# OPTIONAL
					keepMacAddresses = $someBoolean
					# OPTIONAL
					nicNetworkUuids = @(
						$someString
					)
					# REQUIRED
					containerNaturalId = $someString
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
                Mutation.BatchMountNutanixVm,
                Mutation.BatchMountNutanixVmFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
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
					containerNaturalId = $someString
					# OPTIONAL
					nutanixClusterId = $someString
					# OPTIONAL
					shouldMigrateImmediately = $someBoolean
					# OPTIONAL
					shouldPowerOn = $someBoolean
					# OPTIONAL
					shouldRemoveNetwork = $someBoolean
					# OPTIONAL
					targetNetwork = $someString
					# OPTIONAL
					vmName = $someString
					# OPTIONAL
					keepMacAddresses = $someBoolean
					# OPTIONAL
					nicNetworkUuids = @(
						$someString
					)
					# REQUIRED
					shouldDisableMigration = $someBoolean
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
                Mutation.BulkOnDemandSnapshotNutanixVm,
                Mutation.BulkOnDemandSnapshotNutanixVmFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		vms = @(
			@{
				# REQUIRED
				backupConfig = @{
					# OPTIONAL
					slaId = $someString
				}
				# REQUIRED
				vmId = $someString
			}
		)
	}
	# OPTIONAL
	userNote = $someString
}"
            );
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
                Mutation.CreateNutanixCluster,
                Mutation.CreateNutanixClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	nutanixClusterConfig = @{
		# REQUIRED
		caCerts = $someString
		# REQUIRED
		hostname = $someString
		# REQUIRED
		nutanixClusterUuid = $someString
		# REQUIRED
		password = $someString
		# REQUIRED
		username = $someString
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
                Mutation.CreateOnDemandNutanixBackup,
                Mutation.CreateOnDemandNutanixBackupFieldSpec,
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
                Mutation.CreateNutanixPrismCentral,
                Mutation.CreateNutanixPrismCentralFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	prismCentralConfig = @{
		# REQUIRED
		caCerts = $someString
		# REQUIRED
		hostname = $someString
		# REQUIRED
		password = $someString
		# REQUIRED
		username = $someString
	}
	# REQUIRED
	prismElementCdmTuple = @(
		@{
			# REQUIRED
			nutanixClusterId = $someString
			# REQUIRED
			cdmClusterId = $someString
		}
	)
	# OPTIONAL
	isDrEnabled = $someBoolean
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
                Mutation.DeleteNutanixCluster,
                Mutation.DeleteNutanixClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
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
                Mutation.DeleteNutanixMountV1,
                Mutation.DeleteNutanixMountV1FieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
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
                Mutation.DeleteNutanixPrismCentral,
                Mutation.DeleteNutanixPrismCentralFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
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
                Mutation.DeleteNutanixSnapshot,
                Mutation.DeleteNutanixSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	location = $someInternalDeleteNutanixSnapshotRequestLocation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InternalDeleteNutanixSnapshotRequestLocation]) for enum values.
	# REQUIRED
	id = $someString
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
                Mutation.DeleteNutanixSnapshots,
                Mutation.DeleteNutanixSnapshotsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
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
                Mutation.DownloadFilesNutanixSnapshot,
                Mutation.DownloadFilesNutanixSnapshotFieldSpec,
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
                Mutation.DownloadNutanixSnapshot,
                Mutation.DownloadNutanixSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadNutanixVdisks(input: DownloadNutanixVmSnapshotVirtualDisksInput!): AsyncRequestStatus!
        internal void InitMutationDownloadNutanixVdisks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadNutanixVmSnapshotVirtualDisksInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadNutanixVdisks",
                "($input: DownloadNutanixVmSnapshotVirtualDisksInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadNutanixVdisks,
                Mutation.DownloadNutanixVdisksFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	vdiskIds = @(
		$someString
	)
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
                Mutation.DownloadNutanixVmFromLocation,
                Mutation.DownloadNutanixVmFromLocationFieldSpec,
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
                Mutation.ExportNutanixSnapshot,
                Mutation.ExportNutanixSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		nutanixClusterId = $someString
		# OPTIONAL
		powerOn = $someBoolean
		# OPTIONAL
		removeNetworkDevices = $someBoolean
		# OPTIONAL
		vmName = $someString
		# OPTIONAL
		keepMacAddresses = $someBoolean
		# OPTIONAL
		nicNetworkUuids = @(
			$someString
		)
		# REQUIRED
		containerNaturalId = $someString
	}
	# REQUIRED
	id = $someString
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
                Mutation.MigrateNutanixMountV1,
                Mutation.MigrateNutanixMountV1FieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
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
                Mutation.MountNutanixSnapshotV1,
                Mutation.MountNutanixSnapshotV1FieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		containerNaturalId = $someString
		# OPTIONAL
		nutanixClusterId = $someString
		# OPTIONAL
		shouldMigrateImmediately = $someBoolean
		# OPTIONAL
		shouldPowerOn = $someBoolean
		# OPTIONAL
		shouldRemoveNetwork = $someBoolean
		# OPTIONAL
		targetNetwork = $someString
		# OPTIONAL
		vmName = $someString
		# OPTIONAL
		keepMacAddresses = $someBoolean
		# OPTIONAL
		nicNetworkUuids = @(
			$someString
		)
		# REQUIRED
		shouldDisableMigration = $someBoolean
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // mountNutanixVdisks(input: CreateNutanixVdisksMountInput!): AsyncRequestStatus!
        internal void InitMutationMountNutanixVdisks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateNutanixVdisksMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationMountNutanixVdisks",
                "($input: CreateNutanixVdisksMountInput!)",
                "AsyncRequestStatus",
                Mutation.MountNutanixVdisks,
                Mutation.MountNutanixVdisksFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		shouldMigrateImmediately = $someBoolean
		# OPTIONAL
		containerNaturalId = $someString
		# REQUIRED
		shouldDisableMigration = $someBoolean
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
                Mutation.PatchNutanixMountV1,
                Mutation.PatchNutanixMountV1FieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		shouldPowerOn = $someBoolean
	}
	# REQUIRED
	id = $someString
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
                Mutation.RefreshNutanixCluster,
                Mutation.RefreshNutanixClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
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
                Mutation.RefreshNutanixPrismCentral,
                Mutation.RefreshNutanixPrismCentralFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
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
                Mutation.RegisterAgentNutanixVm,
                Mutation.RegisterAgentNutanixVmFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
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
                Mutation.RestoreFilesNutanixSnapshot,
                Mutation.RestoreFilesNutanixSnapshotFieldSpec,
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
                Mutation.UpdateNutanixCluster,
                Mutation.UpdateNutanixClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	patchProperties = @{
		# OPTIONAL
		caCerts = $someString
		# OPTIONAL
		configuredSlaDomainId = $someString
		# OPTIONAL
		hostname = $someString
		# OPTIONAL
		password = $someString
		# OPTIONAL
		username = $someString
		# OPTIONAL
		snapshotConsistencyMandate = $someCdmNutanixSnapshotConsistencyMandate # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmNutanixSnapshotConsistencyMandate]) for enum values.
	}
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
                Mutation.UpdateNutanixPrismCentral,
                Mutation.UpdateNutanixPrismCentralFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	patchProperties = @{
		# OPTIONAL
		caCerts = $someString
		# OPTIONAL
		configuredSlaDomainId = $someString
		# OPTIONAL
		hostname = $someString
		# OPTIONAL
		password = $someString
		# OPTIONAL
		username = $someString
		# OPTIONAL
		isDrEnabled = $someBoolean
		# OPTIONAL
		nutanixClusters = @(
			@{
				# OPTIONAL
				name = $someString
				# REQUIRED
				clusterUuid = $someString
			}
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateNutanixVm(input: UpdateNutanixVmInput!): NutanixVmDetail!
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
                "NutanixVmDetail",
                Mutation.UpdateNutanixVm,
                Mutation.UpdateNutanixVmFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	vmPatchProperties = @{
		# OPTIONAL
		configuredSlaDomainId = $someString
		# OPTIONAL
		excludedDiskIds = @(
			$someString
		)
		# OPTIONAL
		isPaused = $someBoolean
		# OPTIONAL
		snapshotConsistencyMandate = $someCdmNutanixSnapshotConsistencyMandate # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmNutanixSnapshotConsistencyMandate]) for enum values.
		# OPTIONAL
		postBackupScript = @{
			# REQUIRED
			failureHandling = $someNutanixVirtualMachineScriptDetailFailureHandling # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NutanixVirtualMachineScriptDetailFailureHandling]) for enum values.
			# REQUIRED
			scriptPath = $someString
			# REQUIRED
			timeoutMs = $someInt64
		}
		# OPTIONAL
		postSnapScript = @{
			# REQUIRED
			failureHandling = $someNutanixVirtualMachineScriptDetailFailureHandling # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NutanixVirtualMachineScriptDetailFailureHandling]) for enum values.
			# REQUIRED
			scriptPath = $someString
			# REQUIRED
			timeoutMs = $someInt64
		}
		# OPTIONAL
		preBackupScript = @{
			# REQUIRED
			failureHandling = $someNutanixVirtualMachineScriptDetailFailureHandling # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NutanixVirtualMachineScriptDetailFailureHandling]) for enum values.
			# REQUIRED
			scriptPath = $someString
			# REQUIRED
			timeoutMs = $someInt64
		}
	}
}"
            );
        }


    } // class New_RscMutationNutanix
}