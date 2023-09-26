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
    /// Create a new RscQuery object for any of the 25
    /// operations in the 'Nutanix' API domain:
    /// BatchExportVm, BatchMountVm, BulkOnDemandSnapshotVm, CreateCluster, CreateOnDemandBackup, CreatePrismCentral, DeleteCluster, DeleteMountV1, DeletePrismCentral, DeleteSnapshot, DeleteSnapshots, DownloadFilesSnapshot, DownloadSnapshot, DownloadVmFromLocation, ExportSnapshot, MigrateMountV1, MountSnapshotV1, PatchMountV1, RefreshCluster, RefreshPrismCentral, RegisterAgentVm, RestoreFilesSnapshot, UpdateCluster, UpdatePrismCentral, or UpdateVm.
    /// </summary>
    /// <description>
    /// New-RscMutationNutanix creates a new
    /// mutation object for operations
    /// in the 'Nutanix' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 25 operations
    /// in the 'Nutanix' API domain. Select the operation this
    /// query is for by specifying the appropriate switch parameter;
    /// one of: -BatchExportVm, -BatchMountVm, -BulkOnDemandSnapshotVm, -CreateCluster, -CreateOnDemandBackup, -CreatePrismCentral, -DeleteCluster, -DeleteMountV1, -DeletePrismCentral, -DeleteSnapshot, -DeleteSnapshots, -DownloadFilesSnapshot, -DownloadSnapshot, -DownloadVmFromLocation, -ExportSnapshot, -MigrateMountV1, -MountSnapshotV1, -PatchMountV1, -RefreshCluster, -RefreshPrismCentral, -RegisterAgentVm, -RestoreFilesSnapshot, -UpdateCluster, -UpdatePrismCentral, -UpdateVm.
    /// Alternatively, you can specify the operation by setting the
    /// -Op parameter, for example: -Op BatchExportVm,
    /// which is equivalent to specifying -BatchExportVm.
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
    /// 		# OPTIONAL
    /// 		snapshotConsistencyMandate = $someCdmNutanixSnapshotConsistencyMandate # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmNutanixSnapshotConsistencyMandate]) for enum values.
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
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
        DefaultParameterSetName = "UpdateVm")
    ]
    public class New_RscMutationNutanix : RscGqlPSCmdlet
    {
        
        [Parameter(
            ParameterSetName = "BatchExportVm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'BatchExportVm' operation
in the 'Nutanix' API domain.
Description of the operation:
Exports a snapshot from each member of a set of virtual machines

Supported in v7.0+
Export a snapshot from each member of a set of virtual machines.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/batchexportnutanixvm.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter BatchExportVm { get; set; }

        
        [Parameter(
            ParameterSetName = "BatchMountVm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'BatchMountVm' operation
in the 'Nutanix' API domain.
Description of the operation:
Mount snapshots from multiple virtual machines

Supported in v7.0+
Mounts a batch of snapshots from a group of specified virtual machines.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/batchmountnutanixvm.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter BatchMountVm { get; set; }

        
        [Parameter(
            ParameterSetName = "BulkOnDemandSnapshotVm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'BulkOnDemandSnapshotVm' operation
in the 'Nutanix' API domain.
Description of the operation:
Take an on-demand snapshot for selected Nutanix virtual machines

Supported in v9.0+
Take bulk backups for multiple Nutanix virtual machines.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/bulkondemandsnapshotnutanixvm.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter BulkOnDemandSnapshotVm { get; set; }

        
        [Parameter(
            ParameterSetName = "CreateCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreateCluster' operation
in the 'Nutanix' API domain.
Description of the operation:
Add Nutanix cluster

Supported in v5.0+
Create a Nutanix cluster object by providing an address and account credentials for Prism. Initiates an asynchronous job to establish a connection with the cluster and retrieve all metadata. Use GET /nutanix_cluster/{id}/status to check status.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createnutanixcluster.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreateCluster { get; set; }

        
        [Parameter(
            ParameterSetName = "CreateOnDemandBackup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreateOnDemandBackup' operation
in the 'Nutanix' API domain.
Description of the operation:
v5.0-v8.0: Create on-demand VM snapshot
v8.1+: Create on-demand virtual machine snapshot

Supported in v5.0+
v5.0-v5.3: Create an on-demand snapshot for the given VM ID
v6.0-v8.0: Create an on-demand snapshot for the given VM ID.
v8.1+: Create an on-demand snapshot for the given virtual machine ID.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createondemandnutanixbackup.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreateOnDemandBackup { get; set; }

        
        [Parameter(
            ParameterSetName = "CreatePrismCentral",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreatePrismCentral' operation
in the 'Nutanix' API domain.
Description of the operation:
Add Nutanix Prism Central and it's corresponding Prism Elements

Supported in v9.0+
Create a Nutanix Prism Central object and refresh the Prism Elements present in it.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createnutanixprismcentral.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreatePrismCentral { get; set; }

        
        [Parameter(
            ParameterSetName = "DeleteCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DeleteCluster' operation
in the 'Nutanix' API domain.
Description of the operation:
Remove Nutanix cluster

Supported in v5.0+
Initiates an asynchronous job to remove a Nutanix cluster object. The Nutanix cluster cannot have VMs mounted through the Rubrik cluster.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/deletenutanixcluster.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DeleteCluster { get; set; }

        
        [Parameter(
            ParameterSetName = "DeleteMountV1",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DeleteMountV1' operation
in the 'Nutanix' API domain.
Description of the operation:
Remove a Live Mount of a Nutanix virtual machine snapshot

Supported in v6.0+
Initiates a request to remove a Live Mount of a Nutanix virtual machine snapshot identified by the ID of the Live Mount.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/deletenutanixmountv1.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DeleteMountV1 { get; set; }

        
        [Parameter(
            ParameterSetName = "DeletePrismCentral",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DeletePrismCentral' operation
in the 'Nutanix' API domain.
Description of the operation:
Remove Nutanix Prism Central

Supported in v9.0+
Initiates an asynchronous job to remove a Nutanix Prism Central object. The Nutanix Clusters attached to the Prism Central cannot have Virtual Machines mounted through the Rubrik cluster.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/deletenutanixprismcentral.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DeletePrismCentral { get; set; }

        
        [Parameter(
            ParameterSetName = "DeleteSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DeleteSnapshot' operation
in the 'Nutanix' API domain.
Description of the operation:
v5.0-v8.0: Delete VM snapshot
v8.1+: Delete virtual machine snapshot

Supported in v5.0+
v5.0-v8.0: Delete a snapshot by expiring it. Snapshot is expired only if it is a manual snapshot or a snapshot of an unprotected vm.
v8.1+: Delete a snapshot by expiring it. Snapshot is expired only if it is a manual snapshot or a snapshot of an unprotected virtual machine.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/deletenutanixsnapshot.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DeleteSnapshot { get; set; }

        
        [Parameter(
            ParameterSetName = "DeleteSnapshots",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DeleteSnapshots' operation
in the 'Nutanix' API domain.
Description of the operation:
v5.0-v8.0: Delete all snapshots of VM
v8.1+: Delete all snapshots of virtual machine

Supported in v5.0+
Delete all snapshots of a virtual machine.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/deletenutanixsnapshots.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DeleteSnapshots { get; set; }

        
        [Parameter(
            ParameterSetName = "DownloadFilesSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DownloadFilesSnapshot' operation
in the 'Nutanix' API domain.
Description of the operation:
v5.0-v8.0: Download files from a Nutanix VM backup
v8.1+: Download files from a Nutanix virtual machine backup

Supported in v5.0+
v5.0-v8.0: Start an asynchronous job to download multiple files and folders from a specified Nutanix VM backup. The response returns an asynchronous request ID. Get the URL for downloading the zip file including the specific files/folders by sending a GET request to 'nutanix/vm/request/{id}'.
v8.1+: Start an asynchronous job to download multiple files and folders from a specified Nutanix virtual machine backup. The response returns an asynchronous request ID. Get the URL for downloading the zip file including the specific files/folders by sending a GET request to 'nutanix/vm/request/{id}'.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/downloadfilesnutanixsnapshot.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DownloadFilesSnapshot { get; set; }

        
        [Parameter(
            ParameterSetName = "DownloadSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DownloadSnapshot' operation
in the 'Nutanix' API domain.
Description of the operation:
Creates a download from archival request

Supported in v5.0+
Download a snapshot from archival.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/downloadnutanixsnapshot.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DownloadSnapshot { get; set; }

        
        [Parameter(
            ParameterSetName = "DownloadVmFromLocation",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DownloadVmFromLocation' operation
in the 'Nutanix' API domain.
Description of the operation:
Download a snapshot from a replication target

Supported in v7.0+
Initiates a job to download a snapshot from the specified location when the snapshot does not exist locally. The specified location has to be a replication target connected to this Rubrik cluster. If an SLA Domain is not provided, the snapshot will be retained forever.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/downloadnutanixvmfromlocation.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DownloadVmFromLocation { get; set; }

        
        [Parameter(
            ParameterSetName = "ExportSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'ExportSnapshot' operation
in the 'Nutanix' API domain.
Description of the operation:
v5.0-v8.0: Export VM snapshot
v8.1+: Export virtual machine snapshot

Supported in v5.0+
v5.0-v8.0: Export snapshot of a vm.
v8.1+: Export snapshot of a virtual machine.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/exportnutanixsnapshot.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter ExportSnapshot { get; set; }

        
        [Parameter(
            ParameterSetName = "MigrateMountV1",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'MigrateMountV1' operation
in the 'Nutanix' API domain.
Description of the operation:
Relocate a Nutanix virtual machine to another storage container

Supported in v6.0+
Initiate a request to migrate the virtual disks of a specified Nutanix Live Mount to another storage container. The destination storage container has been specified when the Live Mount was created. The Live Mount will be deleted when the relocation succeeds.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/migratenutanixmountv1.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter MigrateMountV1 { get; set; }

        
        [Parameter(
            ParameterSetName = "MountSnapshotV1",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'MountSnapshotV1' operation
in the 'Nutanix' API domain.
Description of the operation:
Initiate a Live Mount of a Nutanix virtual machine snapshot

Supported in v6.0+
Initiates a request to perform a Live Mount of a Nutanix virtual machine snapshot identified by the snapshot ID.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/mountnutanixsnapshotv1.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter MountSnapshotV1 { get; set; }

        
        [Parameter(
            ParameterSetName = "PatchMountV1",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'PatchMountV1' operation
in the 'Nutanix' API domain.
Description of the operation:
Change Nutanix Live Mount power status

Supported in v6.0+
Changes the power status of a mounted Nutanix virtual machine.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/patchnutanixmountv1.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter PatchMountV1 { get; set; }

        
        [Parameter(
            ParameterSetName = "RefreshCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'RefreshCluster' operation
in the 'Nutanix' API domain.
Description of the operation:
Refresh Nutanix cluster metadata

Supported in v5.0+
Create a job to refresh the metadata for the specified Nutanix cluster.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/refreshnutanixcluster.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter RefreshCluster { get; set; }

        
        [Parameter(
            ParameterSetName = "RefreshPrismCentral",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'RefreshPrismCentral' operation
in the 'Nutanix' API domain.
Description of the operation:
Refresh Nutanix Prism Central metadata

Supported in v9.0+
Initiates a job to refresh the metadata for the specified Nutanix Prism Central and all its associated clusters.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/refreshnutanixprismcentral.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter RefreshPrismCentral { get; set; }

        
        [Parameter(
            ParameterSetName = "RegisterAgentVm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'RegisterAgentVm' operation
in the 'Nutanix' API domain.
Description of the operation:
v5.0-v8.0: Register the agent installed on the Nutanix VM
v8.1+: Register the agent installed on the Nutanix virtual machine

Supported in v5.0+
v5.0-v5.3: Register the agent installed on the Nutanix VM
v6.0-v8.0: Register the agent installed on the Nutanix VM.
v8.1+: Register the agent installed on the Nutanix virtual machine.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/registeragentnutanixvm.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter RegisterAgentVm { get; set; }

        
        [Parameter(
            ParameterSetName = "RestoreFilesSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'RestoreFilesSnapshot' operation
in the 'Nutanix' API domain.
Description of the operation:
Restore files

Supported in v5.0+
Restore files from a snapshot to the source Nutanix virtual machine.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/restorefilesnutanixsnapshot.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter RestoreFilesSnapshot { get; set; }

        
        [Parameter(
            ParameterSetName = "UpdateCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpdateCluster' operation
in the 'Nutanix' API domain.
Description of the operation:
Patch Nutanix cluster

Supported in v5.0+
Patch the host, credentials, and/or CA certs of the specified Nutanix cluster object.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/updatenutanixcluster.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpdateCluster { get; set; }

        
        [Parameter(
            ParameterSetName = "UpdatePrismCentral",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpdatePrismCentral' operation
in the 'Nutanix' API domain.
Description of the operation:
Patch Nutanix Prism Central

Supported in v9.0+
Patch the host and credentials of Nutanix Prism Central.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/updatenutanixprismcentral.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpdatePrismCentral { get; set; }

        
        [Parameter(
            ParameterSetName = "UpdateVm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpdateVm' operation
in the 'Nutanix' API domain.
Description of the operation:
v5.0-v8.0: Patch VM
v8.1+: Patch virtual machine

Supported in v5.0+
v5.0-v5.3: Patch VM with specified properties
v6.0-v8.0: Patch VM with specified properties.
v8.1+: Patch virtual machine with specified properties.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/updatenutanixvm.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpdateVm { get; set; }



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
                Mutation.BatchExportNutanixVm_ObjectFieldSpec,
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
                Mutation.BatchMountNutanixVm_ObjectFieldSpec,
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
                Mutation.BulkOnDemandSnapshotNutanixVm_ObjectFieldSpec,
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
                Mutation.CreateNutanixCluster_ObjectFieldSpec,
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
                Mutation.CreateOnDemandNutanixBackup_ObjectFieldSpec,
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
                Mutation.CreateNutanixPrismCentral_ObjectFieldSpec,
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
                Mutation.DeleteNutanixCluster_ObjectFieldSpec,
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
                Mutation.DeleteNutanixMountV1_ObjectFieldSpec,
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
                Mutation.DeleteNutanixPrismCentral_ObjectFieldSpec,
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
                Mutation.DeleteNutanixSnapshot_ObjectFieldSpec,
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
                Mutation.DeleteNutanixSnapshots_ObjectFieldSpec,
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
                Mutation.DownloadFilesNutanixSnapshot_ObjectFieldSpec,
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
                Mutation.DownloadNutanixSnapshot_ObjectFieldSpec,
                Mutation.DownloadNutanixSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
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
                Mutation.DownloadNutanixVmFromLocation_ObjectFieldSpec,
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
                Mutation.ExportNutanixSnapshot_ObjectFieldSpec,
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
                Mutation.MigrateNutanixMountV1_ObjectFieldSpec,
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
                Mutation.MountNutanixSnapshotV1_ObjectFieldSpec,
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
                Mutation.PatchNutanixMountV1_ObjectFieldSpec,
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
                Mutation.RefreshNutanixCluster_ObjectFieldSpec,
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
                Mutation.RefreshNutanixPrismCentral_ObjectFieldSpec,
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
                Mutation.RegisterAgentNutanixVm_ObjectFieldSpec,
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
                Mutation.RestoreFilesNutanixSnapshot_ObjectFieldSpec,
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
                Mutation.UpdateNutanixCluster_ObjectFieldSpec,
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
                Mutation.UpdateNutanixPrismCentral_ObjectFieldSpec,
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
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateNutanixVm(input: UpdateNutanixVmInput!): Void
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
                "System.String",
                Mutation.UpdateNutanixVm_ObjectFieldSpec,
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
		# OPTIONAL
		snapshotConsistencyMandate = $someCdmNutanixSnapshotConsistencyMandate # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmNutanixSnapshotConsistencyMandate]) for enum values.
	}
}"
            );
        }


    } // class New_RscMutationNutanix
}