// New-RscMutationVsphereVm.cs
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
    /// operations in the 'VMware vSphere VM' API domain:
    /// BatchExport, BatchExportV3, BatchInPlaceRecovery, DeleteSnapshot, DownloadSnapshot, DownloadSnapshotFiles, ExcludeVmDisks, ExportSnapshotV2, ExportSnapshotV3, ExportSnapshotWithDownloadFromCloud, InitiateBatchInstantRecovery, InitiateBatchLiveMountV2, InitiateDiskMount, InitiateInPlaceRecovery, InitiateInstantRecoveryV2, InitiateLiveMountV2, ListEsxiDatastores, MountRelocate, MountRelocateV2, PowerOnOffLiveMount, RecoverFiles, RecoverFilesNew, RegisterAgent, RegisterAgentWithOrg, Update, or UpdateUnmountTime.
    /// </summary>
    /// <description>
    /// New-RscMutationVsphereVm creates a new
    /// mutation object for operations
    /// in the 'VMware vSphere VM' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 26 operations
    /// in the 'VMware vSphere VM' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: BatchExport, BatchExportV3, BatchInPlaceRecovery, DeleteSnapshot, DownloadSnapshot, DownloadSnapshotFiles, ExcludeVmDisks, ExportSnapshotV2, ExportSnapshotV3, ExportSnapshotWithDownloadFromCloud, InitiateBatchInstantRecovery, InitiateBatchLiveMountV2, InitiateDiskMount, InitiateInPlaceRecovery, InitiateInstantRecoveryV2, InitiateLiveMountV2, ListEsxiDatastores, MountRelocate, MountRelocateV2, PowerOnOffLiveMount, RecoverFiles, RecoverFilesNew, RegisterAgent, RegisterAgentWithOrg, Update, or UpdateUnmountTime.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationVsphereVm -BatchExport).Info().
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
    /// (New-RscMutationVsphereVm -BatchExport).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the BatchExport operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: BatchExport
    /// 
    /// $query = New-RscMutationVsphereVm -Operation BatchExport
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
    /// 				config = @{
    /// 					# OPTIONAL
    /// 					hostId = $someString
    /// 					# OPTIONAL
    /// 					shouldRecoverTags = $someBoolean
    /// 					# OPTIONAL
    /// 					unregisterVm = $someBoolean
    /// 					# OPTIONAL
    /// 					clusterId = $someString
    /// 					# OPTIONAL
    /// 					resourcePoolId = $someString
    /// 					# OPTIONAL
    /// 					shouldUseHotAddProxy = $someBoolean
    /// 					# OPTIONAL
    /// 					folderId = $someString
    /// 					# OPTIONAL
    /// 					contentLibraryId = $someString
    /// 					# OPTIONAL
    /// 					shouldConvertToTemplate = $someBoolean
    /// 					# REQUIRED
    /// 					datastoreId = $someString
    /// 					# OPTIONAL
    /// 					mountExportSnapshotJobCommonOptionsV2 = @{
    /// 						# OPTIONAL
    /// 						disableNetwork = $someBoolean
    /// 						# OPTIONAL
    /// 						keepMacAddresses = $someBoolean
    /// 						# OPTIONAL
    /// 						powerOn = $someBoolean
    /// 						# OPTIONAL
    /// 						removeNetworkDevices = $someBoolean
    /// 						# OPTIONAL
    /// 						vmName = $someString
    /// 					}
    /// 					# OPTIONAL
    /// 					requiredRecoveryParameters = @{
    /// 						# OPTIONAL
    /// 						recoveryPoint = $someDateTime
    /// 						# OPTIONAL
    /// 						snapshotId = $someString
    /// 					}
    /// 					# OPTIONAL
    /// 					vNicBindings = @(
    /// 						@{
    /// 							# REQUIRED
    /// 							backingNetworkInfo = @{
    /// 								# REQUIRED
    /// 								moid = $someString
    /// 								# REQUIRED
    /// 								name = $someString
    /// 							}
    /// 							# REQUIRED
    /// 							networkDeviceInfo = @{
    /// 								# REQUIRED
    /// 								key = $someInt
    /// 								# REQUIRED
    /// 								name = $someString
    /// 							}
    /// 						}
    /// 					)
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
    /// Write-Host $result.GetType().Name # prints: BatchAsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BatchExportV3 operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: BatchExportV3
    /// 
    /// $query = New-RscMutationVsphereVm -Operation BatchExportV3
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
    /// 				config = @{
    /// 					# OPTIONAL
    /// 					clusterId = $someString
    /// 					# OPTIONAL
    /// 					hostId = $someString
    /// 					# OPTIONAL
    /// 					resourcePoolId = $someString
    /// 					# OPTIONAL
    /// 					shouldRecoverTags = $someBoolean
    /// 					# OPTIONAL
    /// 					shouldUseHotAddProxy = $someBoolean
    /// 					# OPTIONAL
    /// 					storageLocationId = $someString
    /// 					# OPTIONAL
    /// 					unregisterVm = $someBoolean
    /// 					# OPTIONAL
    /// 					folderId = $someString
    /// 					# OPTIONAL
    /// 					contentLibraryId = $someString
    /// 					# OPTIONAL
    /// 					shouldConvertToTemplate = $someBoolean
    /// 					# OPTIONAL
    /// 					diskDeviceKeyToStorageId = @(
    /// 						@{
    /// 							# OPTIONAL
    /// 							storageLocationId = $someString
    /// 							# REQUIRED
    /// 							deviceKey = $someInt
    /// 						}
    /// 					)
    /// 					# OPTIONAL
    /// 					mountExportSnapshotJobCommonOptionsV2 = @{
    /// 						# OPTIONAL
    /// 						disableNetwork = $someBoolean
    /// 						# OPTIONAL
    /// 						keepMacAddresses = $someBoolean
    /// 						# OPTIONAL
    /// 						powerOn = $someBoolean
    /// 						# OPTIONAL
    /// 						removeNetworkDevices = $someBoolean
    /// 						# OPTIONAL
    /// 						vmName = $someString
    /// 					}
    /// 					# OPTIONAL
    /// 					requiredRecoveryParameters = @{
    /// 						# OPTIONAL
    /// 						recoveryPoint = $someDateTime
    /// 						# OPTIONAL
    /// 						snapshotId = $someString
    /// 					}
    /// 					# OPTIONAL
    /// 					vNicBindings = @(
    /// 						@{
    /// 							# REQUIRED
    /// 							backingNetworkInfo = @{
    /// 								# REQUIRED
    /// 								moid = $someString
    /// 								# REQUIRED
    /// 								name = $someString
    /// 							}
    /// 							# REQUIRED
    /// 							networkDeviceInfo = @{
    /// 								# REQUIRED
    /// 								key = $someInt
    /// 								# REQUIRED
    /// 								name = $someString
    /// 							}
    /// 						}
    /// 					)
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
    /// Write-Host $result.GetType().Name # prints: BatchAsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BatchInPlaceRecovery operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: BatchInPlaceRecovery
    /// 
    /// $query = New-RscMutationVsphereVm -Operation BatchInPlaceRecovery
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
    /// 				config = @{
    /// 					# OPTIONAL
    /// 					shouldKeepVsphereSnapshotAfterRecovery = $someBoolean
    /// 					# OPTIONAL
    /// 					requiredRecoveryParameters = @{
    /// 						# OPTIONAL
    /// 						recoveryPoint = $someDateTime
    /// 						# OPTIONAL
    /// 						snapshotId = $someString
    /// 					}
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
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: DeleteSnapshot
    /// 
    /// $query = New-RscMutationVsphereVm -Operation DeleteSnapshot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	location = $someDeleteVmwareSnapshotRequestLocation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeleteVmwareSnapshotRequestLocation]) for enum values.
    /// 	# REQUIRED
    /// 	id = $someString
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
    /// <example>
    /// Runs the DownloadSnapshot operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: DownloadSnapshot
    /// 
    /// $query = New-RscMutationVsphereVm -Operation DownloadSnapshot
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
    /// Runs the DownloadSnapshotFiles operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: DownloadSnapshotFiles
    /// 
    /// $query = New-RscMutationVsphereVm -Operation DownloadSnapshotFiles
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotFid = $someString
    /// 	# REQUIRED
    /// 	paths = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	deltaTypeFilter = @(
    /// 		$someDeltaType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeltaType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	nextSnapshotFid = $someString
    /// 	# OPTIONAL
    /// 	isLegalHoldDownload = $someBoolean
    /// 	# OPTIONAL
    /// 	userNote = $someString
    /// 	# OPTIONAL
    /// 	zipPassword = $someString
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
    /// Runs the ExcludeVmDisks operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: ExcludeVmDisks
    /// 
    /// $query = New-RscMutationVsphereVm -Operation ExcludeVmDisks
    /// 
    /// # REQUIRED
    /// $query.Var.input = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		virtualDiskFid = $someString
    /// 		# OPTIONAL
    /// 		excludeFromSnapshots = $someBoolean
    /// }
    /// )
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
    /// Runs the ExportSnapshotV2 operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: ExportSnapshotV2
    /// 
    /// $query = New-RscMutationVsphereVm -Operation ExportSnapshotV2
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		hostId = $someString
    /// 		# OPTIONAL
    /// 		shouldRecoverTags = $someBoolean
    /// 		# OPTIONAL
    /// 		unregisterVm = $someBoolean
    /// 		# OPTIONAL
    /// 		clusterId = $someString
    /// 		# OPTIONAL
    /// 		resourcePoolId = $someString
    /// 		# OPTIONAL
    /// 		shouldUseHotAddProxy = $someBoolean
    /// 		# OPTIONAL
    /// 		folderId = $someString
    /// 		# OPTIONAL
    /// 		contentLibraryId = $someString
    /// 		# OPTIONAL
    /// 		shouldConvertToTemplate = $someBoolean
    /// 		# REQUIRED
    /// 		datastoreId = $someString
    /// 		# OPTIONAL
    /// 		mountExportSnapshotJobCommonOptionsV2 = @{
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
    /// 		# OPTIONAL
    /// 		requiredRecoveryParameters = @{
    /// 			# OPTIONAL
    /// 			recoveryPoint = $someDateTime
    /// 			# OPTIONAL
    /// 			snapshotId = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		vNicBindings = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				backingNetworkInfo = @{
    /// 					# REQUIRED
    /// 					moid = $someString
    /// 					# REQUIRED
    /// 					name = $someString
    /// 				}
    /// 				# REQUIRED
    /// 				networkDeviceInfo = @{
    /// 					# REQUIRED
    /// 					key = $someInt
    /// 					# REQUIRED
    /// 					name = $someString
    /// 				}
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
    /// Runs the ExportSnapshotV3 operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: ExportSnapshotV3
    /// 
    /// $query = New-RscMutationVsphereVm -Operation ExportSnapshotV3
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		clusterId = $someString
    /// 		# OPTIONAL
    /// 		hostId = $someString
    /// 		# OPTIONAL
    /// 		resourcePoolId = $someString
    /// 		# OPTIONAL
    /// 		shouldRecoverTags = $someBoolean
    /// 		# OPTIONAL
    /// 		shouldUseHotAddProxy = $someBoolean
    /// 		# OPTIONAL
    /// 		storageLocationId = $someString
    /// 		# OPTIONAL
    /// 		unregisterVm = $someBoolean
    /// 		# OPTIONAL
    /// 		folderId = $someString
    /// 		# OPTIONAL
    /// 		contentLibraryId = $someString
    /// 		# OPTIONAL
    /// 		shouldConvertToTemplate = $someBoolean
    /// 		# OPTIONAL
    /// 		diskDeviceKeyToStorageId = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				storageLocationId = $someString
    /// 				# REQUIRED
    /// 				deviceKey = $someInt
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		mountExportSnapshotJobCommonOptionsV2 = @{
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
    /// 		# OPTIONAL
    /// 		requiredRecoveryParameters = @{
    /// 			# OPTIONAL
    /// 			recoveryPoint = $someDateTime
    /// 			# OPTIONAL
    /// 			snapshotId = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		vNicBindings = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				backingNetworkInfo = @{
    /// 					# REQUIRED
    /// 					moid = $someString
    /// 					# REQUIRED
    /// 					name = $someString
    /// 				}
    /// 				# REQUIRED
    /// 				networkDeviceInfo = @{
    /// 					# REQUIRED
    /// 					key = $someInt
    /// 					# REQUIRED
    /// 					name = $someString
    /// 				}
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
    /// Runs the ExportSnapshotWithDownloadFromCloud operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: ExportSnapshotWithDownloadFromCloud
    /// 
    /// $query = New-RscMutationVsphereVm -Operation ExportSnapshotWithDownloadFromCloud
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		hostId = $someString
    /// 		# OPTIONAL
    /// 		shouldRecoverTags = $someBoolean
    /// 		# OPTIONAL
    /// 		unregisterVm = $someBoolean
    /// 		# OPTIONAL
    /// 		clusterId = $someString
    /// 		# OPTIONAL
    /// 		resourcePoolId = $someString
    /// 		# OPTIONAL
    /// 		shouldUseHotAddProxy = $someBoolean
    /// 		# OPTIONAL
    /// 		folderId = $someString
    /// 		# OPTIONAL
    /// 		contentLibraryId = $someString
    /// 		# OPTIONAL
    /// 		shouldConvertToTemplate = $someBoolean
    /// 		# REQUIRED
    /// 		datastoreId = $someString
    /// 		# OPTIONAL
    /// 		mountExportSnapshotJobCommonOptionsV2 = @{
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
    /// 		# OPTIONAL
    /// 		requiredRecoveryParameters = @{
    /// 			# OPTIONAL
    /// 			recoveryPoint = $someDateTime
    /// 			# OPTIONAL
    /// 			snapshotId = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		vNicBindings = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				backingNetworkInfo = @{
    /// 					# REQUIRED
    /// 					moid = $someString
    /// 					# REQUIRED
    /// 					name = $someString
    /// 				}
    /// 				# REQUIRED
    /// 				networkDeviceInfo = @{
    /// 					# REQUIRED
    /// 					key = $someInt
    /// 					# REQUIRED
    /// 					name = $someString
    /// 				}
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
    /// Runs the InitiateBatchInstantRecovery operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: InitiateBatchInstantRecovery
    /// 
    /// $query = New-RscMutationVsphereVm -Operation InitiateBatchInstantRecovery
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
    /// 				config = @{
    /// 					# OPTIONAL
    /// 					hostId = $someString
    /// 					# OPTIONAL
    /// 					preserveMoid = $someBoolean
    /// 					# OPTIONAL
    /// 					shouldRecoverTags = $someBoolean
    /// 					# OPTIONAL
    /// 					vlan = $someInt
    /// 					# OPTIONAL
    /// 					clusterId = $someString
    /// 					# OPTIONAL
    /// 					resourcePoolId = $someString
    /// 					# OPTIONAL
    /// 					shouldMigrateImmediately = $someBoolean
    /// 					# OPTIONAL
    /// 					migrationConfig = @{
    /// 						# OPTIONAL
    /// 						storageLocationId = $someString
    /// 						# OPTIONAL
    /// 						computeClusterId = $someString
    /// 						# OPTIONAL
    /// 						hostId = $someString
    /// 						# OPTIONAL
    /// 						resourcePoolId = $someString
    /// 						# OPTIONAL
    /// 						diskDeviceKeyToStorageId = @(
    /// 							@{
    /// 								# OPTIONAL
    /// 								storageLocationId = $someString
    /// 								# REQUIRED
    /// 								deviceKey = $someInt
    /// 							}
    /// 						)
    /// 						# OPTIONAL
    /// 						networkDeviceKeyToNetworkName = @(
    /// 							@{
    /// 								# REQUIRED
    /// 								deviceKey = $someInt
    /// 								# REQUIRED
    /// 								networkName = $someString
    /// 							}
    /// 						)
    /// 					}
    /// 					# OPTIONAL
    /// 					mountExportSnapshotJobCommonOptionsV2 = @{
    /// 						# OPTIONAL
    /// 						disableNetwork = $someBoolean
    /// 						# OPTIONAL
    /// 						keepMacAddresses = $someBoolean
    /// 						# OPTIONAL
    /// 						powerOn = $someBoolean
    /// 						# OPTIONAL
    /// 						removeNetworkDevices = $someBoolean
    /// 						# OPTIONAL
    /// 						vmName = $someString
    /// 					}
    /// 					# OPTIONAL
    /// 					requiredRecoveryParameters = @{
    /// 						# OPTIONAL
    /// 						recoveryPoint = $someDateTime
    /// 						# OPTIONAL
    /// 						snapshotId = $someString
    /// 					}
    /// 					# OPTIONAL
    /// 					vNicBindings = @(
    /// 						@{
    /// 							# REQUIRED
    /// 							backingNetworkInfo = @{
    /// 								# REQUIRED
    /// 								moid = $someString
    /// 								# REQUIRED
    /// 								name = $someString
    /// 							}
    /// 							# REQUIRED
    /// 							networkDeviceInfo = @{
    /// 								# REQUIRED
    /// 								key = $someInt
    /// 								# REQUIRED
    /// 								name = $someString
    /// 							}
    /// 						}
    /// 					)
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
    /// Write-Host $result.GetType().Name # prints: BatchAsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the InitiateBatchLiveMountV2 operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: InitiateBatchLiveMountV2
    /// 
    /// $query = New-RscMutationVsphereVm -Operation InitiateBatchLiveMountV2
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
    /// 				config = @{
    /// 					# OPTIONAL
    /// 					createDatastoreOnly = $someBoolean
    /// 					# OPTIONAL
    /// 					dataStoreName = $someString
    /// 					# OPTIONAL
    /// 					hostId = $someString
    /// 					# OPTIONAL
    /// 					shouldRecoverTags = $someBoolean
    /// 					# OPTIONAL
    /// 					vlan = $someInt
    /// 					# OPTIONAL
    /// 					clusterId = $someString
    /// 					# OPTIONAL
    /// 					resourcePoolId = $someString
    /// 					# OPTIONAL
    /// 					shouldMigrateImmediately = $someBoolean
    /// 					# OPTIONAL
    /// 					folderId = $someString
    /// 					# OPTIONAL
    /// 					unmountTimeOpt = $someInt64
    /// 					# OPTIONAL
    /// 					migrationConfig = @{
    /// 						# OPTIONAL
    /// 						storageLocationId = $someString
    /// 						# OPTIONAL
    /// 						computeClusterId = $someString
    /// 						# OPTIONAL
    /// 						hostId = $someString
    /// 						# OPTIONAL
    /// 						resourcePoolId = $someString
    /// 						# OPTIONAL
    /// 						diskDeviceKeyToStorageId = @(
    /// 							@{
    /// 								# OPTIONAL
    /// 								storageLocationId = $someString
    /// 								# REQUIRED
    /// 								deviceKey = $someInt
    /// 							}
    /// 						)
    /// 						# OPTIONAL
    /// 						networkDeviceKeyToNetworkName = @(
    /// 							@{
    /// 								# REQUIRED
    /// 								deviceKey = $someInt
    /// 								# REQUIRED
    /// 								networkName = $someString
    /// 							}
    /// 						)
    /// 					}
    /// 					# OPTIONAL
    /// 					mountExportSnapshotJobCommonOptionsV2 = @{
    /// 						# OPTIONAL
    /// 						disableNetwork = $someBoolean
    /// 						# OPTIONAL
    /// 						keepMacAddresses = $someBoolean
    /// 						# OPTIONAL
    /// 						powerOn = $someBoolean
    /// 						# OPTIONAL
    /// 						removeNetworkDevices = $someBoolean
    /// 						# OPTIONAL
    /// 						vmName = $someString
    /// 					}
    /// 					# OPTIONAL
    /// 					requiredRecoveryParameters = @{
    /// 						# OPTIONAL
    /// 						recoveryPoint = $someDateTime
    /// 						# OPTIONAL
    /// 						snapshotId = $someString
    /// 					}
    /// 					# OPTIONAL
    /// 					vNicBindings = @(
    /// 						@{
    /// 							# REQUIRED
    /// 							backingNetworkInfo = @{
    /// 								# REQUIRED
    /// 								moid = $someString
    /// 								# REQUIRED
    /// 								name = $someString
    /// 							}
    /// 							# REQUIRED
    /// 							networkDeviceInfo = @{
    /// 								# REQUIRED
    /// 								key = $someInt
    /// 								# REQUIRED
    /// 								name = $someString
    /// 							}
    /// 						}
    /// 					)
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
    /// Write-Host $result.GetType().Name # prints: BatchAsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the InitiateDiskMount operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: InitiateDiskMount
    /// 
    /// $query = New-RscMutationVsphereVm -Operation InitiateDiskMount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		targetVmId = $someString
    /// 		# OPTIONAL
    /// 		vlan = $someInt
    /// 		# OPTIONAL
    /// 		vmdkIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		unmountTimeOpt = $someInt64
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
    /// Runs the InitiateInPlaceRecovery operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: InitiateInPlaceRecovery
    /// 
    /// $query = New-RscMutationVsphereVm -Operation InitiateInPlaceRecovery
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		shouldKeepVsphereSnapshotAfterRecovery = $someBoolean
    /// 		# OPTIONAL
    /// 		requiredRecoveryParameters = @{
    /// 			# OPTIONAL
    /// 			recoveryPoint = $someDateTime
    /// 			# OPTIONAL
    /// 			snapshotId = $someString
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
    /// Runs the InitiateInstantRecoveryV2 operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: InitiateInstantRecoveryV2
    /// 
    /// $query = New-RscMutationVsphereVm -Operation InitiateInstantRecoveryV2
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		hostId = $someString
    /// 		# OPTIONAL
    /// 		preserveMoid = $someBoolean
    /// 		# OPTIONAL
    /// 		shouldRecoverTags = $someBoolean
    /// 		# OPTIONAL
    /// 		vlan = $someInt
    /// 		# OPTIONAL
    /// 		clusterId = $someString
    /// 		# OPTIONAL
    /// 		resourcePoolId = $someString
    /// 		# OPTIONAL
    /// 		shouldMigrateImmediately = $someBoolean
    /// 		# OPTIONAL
    /// 		migrationConfig = @{
    /// 			# OPTIONAL
    /// 			storageLocationId = $someString
    /// 			# OPTIONAL
    /// 			computeClusterId = $someString
    /// 			# OPTIONAL
    /// 			hostId = $someString
    /// 			# OPTIONAL
    /// 			resourcePoolId = $someString
    /// 			# OPTIONAL
    /// 			diskDeviceKeyToStorageId = @(
    /// 				@{
    /// 					# OPTIONAL
    /// 					storageLocationId = $someString
    /// 					# REQUIRED
    /// 					deviceKey = $someInt
    /// 				}
    /// 			)
    /// 			# OPTIONAL
    /// 			networkDeviceKeyToNetworkName = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					deviceKey = $someInt
    /// 					# REQUIRED
    /// 					networkName = $someString
    /// 				}
    /// 			)
    /// 		}
    /// 		# OPTIONAL
    /// 		mountExportSnapshotJobCommonOptionsV2 = @{
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
    /// 		# OPTIONAL
    /// 		requiredRecoveryParameters = @{
    /// 			# OPTIONAL
    /// 			recoveryPoint = $someDateTime
    /// 			# OPTIONAL
    /// 			snapshotId = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		vNicBindings = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				backingNetworkInfo = @{
    /// 					# REQUIRED
    /// 					moid = $someString
    /// 					# REQUIRED
    /// 					name = $someString
    /// 				}
    /// 				# REQUIRED
    /// 				networkDeviceInfo = @{
    /// 					# REQUIRED
    /// 					key = $someInt
    /// 					# REQUIRED
    /// 					name = $someString
    /// 				}
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
    /// Runs the InitiateLiveMountV2 operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: InitiateLiveMountV2
    /// 
    /// $query = New-RscMutationVsphereVm -Operation InitiateLiveMountV2
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		createDatastoreOnly = $someBoolean
    /// 		# OPTIONAL
    /// 		dataStoreName = $someString
    /// 		# OPTIONAL
    /// 		hostId = $someString
    /// 		# OPTIONAL
    /// 		shouldRecoverTags = $someBoolean
    /// 		# OPTIONAL
    /// 		vlan = $someInt
    /// 		# OPTIONAL
    /// 		clusterId = $someString
    /// 		# OPTIONAL
    /// 		resourcePoolId = $someString
    /// 		# OPTIONAL
    /// 		shouldMigrateImmediately = $someBoolean
    /// 		# OPTIONAL
    /// 		folderId = $someString
    /// 		# OPTIONAL
    /// 		unmountTimeOpt = $someInt64
    /// 		# OPTIONAL
    /// 		migrationConfig = @{
    /// 			# OPTIONAL
    /// 			storageLocationId = $someString
    /// 			# OPTIONAL
    /// 			computeClusterId = $someString
    /// 			# OPTIONAL
    /// 			hostId = $someString
    /// 			# OPTIONAL
    /// 			resourcePoolId = $someString
    /// 			# OPTIONAL
    /// 			diskDeviceKeyToStorageId = @(
    /// 				@{
    /// 					# OPTIONAL
    /// 					storageLocationId = $someString
    /// 					# REQUIRED
    /// 					deviceKey = $someInt
    /// 				}
    /// 			)
    /// 			# OPTIONAL
    /// 			networkDeviceKeyToNetworkName = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					deviceKey = $someInt
    /// 					# REQUIRED
    /// 					networkName = $someString
    /// 				}
    /// 			)
    /// 		}
    /// 		# OPTIONAL
    /// 		mountExportSnapshotJobCommonOptionsV2 = @{
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
    /// 		# OPTIONAL
    /// 		requiredRecoveryParameters = @{
    /// 			# OPTIONAL
    /// 			recoveryPoint = $someDateTime
    /// 			# OPTIONAL
    /// 			snapshotId = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		vNicBindings = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				backingNetworkInfo = @{
    /// 					# REQUIRED
    /// 					moid = $someString
    /// 					# REQUIRED
    /// 					name = $someString
    /// 				}
    /// 				# REQUIRED
    /// 				networkDeviceInfo = @{
    /// 					# REQUIRED
    /// 					key = $someInt
    /// 					# REQUIRED
    /// 					name = $someString
    /// 				}
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
    /// Runs the ListEsxiDatastores operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: ListEsxiDatastores
    /// 
    /// $query = New-RscMutationVsphereVm -Operation ListEsxiDatastores
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	loginInfo = @{
    /// 		# REQUIRED
    /// 		ip = $someString
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
    /// Write-Host $result.GetType().Name # prints: VsphereVmListEsxiDatastoresReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MountRelocate operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: MountRelocate
    /// 
    /// $query = New-RscMutationVsphereVm -Operation MountRelocate
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# REQUIRED
    /// 		datastoreId = $someString
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
    /// Runs the MountRelocateV2 operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: MountRelocateV2
    /// 
    /// $query = New-RscMutationVsphereVm -Operation MountRelocateV2
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		storageLocationId = $someString
    /// 		# OPTIONAL
    /// 		computeClusterId = $someString
    /// 		# OPTIONAL
    /// 		hostId = $someString
    /// 		# OPTIONAL
    /// 		resourcePoolId = $someString
    /// 		# OPTIONAL
    /// 		diskDeviceKeyToStorageId = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				storageLocationId = $someString
    /// 				# REQUIRED
    /// 				deviceKey = $someInt
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		networkDeviceKeyToNetworkName = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				deviceKey = $someInt
    /// 				# REQUIRED
    /// 				networkName = $someString
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
    /// Runs the PowerOnOffLiveMount operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: PowerOnOffLiveMount
    /// 
    /// $query = New-RscMutationVsphereVm -Operation PowerOnOffLiveMount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		shouldForce = $someBoolean
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
    /// Write-Host $result.GetType().Name # prints: VsphereVmPowerOnOffLiveMountReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RecoverFiles operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: RecoverFiles
    /// 
    /// $query = New-RscMutationVsphereVm -Operation RecoverFiles
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotFid = $someString
    /// 	# REQUIRED
    /// 	restoreConfig = @{
    /// 		# OPTIONAL
    /// 		restoreFilesConfig = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				path = $someString
    /// 				# OPTIONAL
    /// 				restorePath = $someString
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		domainName = $someString
    /// 		# OPTIONAL
    /// 		username = $someString
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# OPTIONAL
    /// 		shouldIgnoreErrors = $someBoolean
    /// 		# OPTIONAL
    /// 		shouldSaveCredentials = $someBoolean
    /// 		# OPTIONAL
    /// 		shouldUseAgent = $someBoolean
    /// 		# OPTIONAL
    /// 		shouldRestoreXAttrs = $someBoolean
    /// 		# OPTIONAL
    /// 		deltaTypeFilter = @(
    /// 			$someDeltaType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeltaType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		nextSnapshotFid = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VsphereAsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RecoverFilesNew operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: RecoverFilesNew
    /// 
    /// $query = New-RscMutationVsphereVm -Operation RecoverFilesNew
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		domainName = $someString
    /// 		# OPTIONAL
    /// 		ignoreErrors = $someBoolean
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# OPTIONAL
    /// 		shouldSaveCredentials = $someBoolean
    /// 		# OPTIONAL
    /// 		username = $someString
    /// 		# OPTIONAL
    /// 		destObjectId = $someString
    /// 		# OPTIONAL
    /// 		shouldRestoreXAttrs = $someBoolean
    /// 		# OPTIONAL
    /// 		shouldUseAgent = $someBoolean
    /// 		# OPTIONAL
    /// 		guestCredentialId = $someString
    /// 		# OPTIONAL
    /// 		description = $someString
    /// 		# OPTIONAL
    /// 		shouldUseMountDisks = $someBoolean
    /// 		# REQUIRED
    /// 		restoreConfig = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				restorePathPair = @{
    /// 					# OPTIONAL
    /// 					restorePath = $someString
    /// 					# REQUIRED
    /// 					path = $someString
    /// 				}
    /// 			}
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	deltaRequest = @{
    /// 		# REQUIRED
    /// 		nextSnapshotFid = $someString
    /// 		# REQUIRED
    /// 		deltaTypeFilter = @(
    /// 			$someDeltaType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeltaType]) for enum values.
    /// 		)
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
    /// Runs the RegisterAgent operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: RegisterAgent
    /// 
    /// $query = New-RscMutationVsphereVm -Operation RegisterAgent
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	orgNetworkId = $someString
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
    /// Runs the RegisterAgentWithOrg operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: RegisterAgentWithOrg
    /// 
    /// $query = New-RscMutationVsphereVm -Operation RegisterAgentWithOrg
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	orgNetworkIdOpt = $someString
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
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
    /// Runs the Update operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: Update
    /// 
    /// $query = New-RscMutationVsphereVm -Operation Update
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	vmUpdateProperties = @{
    /// 		# OPTIONAL
    /// 		shouldRefreshCacheAfterUpdate = $someBoolean
    /// 		# OPTIONAL
    /// 		guestCredentialId = $someString
    /// 		# OPTIONAL
    /// 		shouldUseAgent = $someBoolean
    /// 		# OPTIONAL
    /// 		guestCredential = @{
    /// 			# REQUIRED
    /// 			password = $someString
    /// 			# REQUIRED
    /// 			username = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		virtualMachineUpdate = @{
    /// 			# OPTIONAL
    /// 			configuredSlaDomainId = $someString
    /// 			# OPTIONAL
    /// 			isArrayIntegrationEnabled = $someBoolean
    /// 			# OPTIONAL
    /// 			isVmPaused = $someBoolean
    /// 			# OPTIONAL
    /// 			maxNestedVsphereSnapshots = $someInt
    /// 			# OPTIONAL
    /// 			multiNodeBackupMode = $someMultiNodeBackupMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MultiNodeBackupMode]) for enum values.
    /// 			# OPTIONAL
    /// 			snapshotConsistencyMandate = $someVirtualMachineUpdateSnapshotConsistencyMandate # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VirtualMachineUpdateSnapshotConsistencyMandate]) for enum values.
    /// 			# OPTIONAL
    /// 			cloudInstantiationSpec = @{
    /// 				# REQUIRED
    /// 				imageRetentionInSeconds = $someInt64
    /// 			}
    /// 			# OPTIONAL
    /// 			postBackupScript = @{
    /// 				# REQUIRED
    /// 				failureHandling = $someVirtualMachineScriptDetailFailureHandling # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VirtualMachineScriptDetailFailureHandling]) for enum values.
    /// 				# REQUIRED
    /// 				scriptPath = $someString
    /// 				# REQUIRED
    /// 				timeoutMs = $someInt64
    /// 			}
    /// 			# OPTIONAL
    /// 			postSnapScript = @{
    /// 				# REQUIRED
    /// 				failureHandling = $someVirtualMachineScriptDetailFailureHandling # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VirtualMachineScriptDetailFailureHandling]) for enum values.
    /// 				# REQUIRED
    /// 				scriptPath = $someString
    /// 				# REQUIRED
    /// 				timeoutMs = $someInt64
    /// 			}
    /// 			# OPTIONAL
    /// 			preBackupScript = @{
    /// 				# REQUIRED
    /// 				failureHandling = $someVirtualMachineScriptDetailFailureHandling # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VirtualMachineScriptDetailFailureHandling]) for enum values.
    /// 				# REQUIRED
    /// 				scriptPath = $someString
    /// 				# REQUIRED
    /// 				timeoutMs = $someInt64
    /// 			}
    /// 			# OPTIONAL
    /// 			throttlingSettings = @{
    /// 				# OPTIONAL
    /// 				cpuUtilizationThreshold = $someInt
    /// 				# OPTIONAL
    /// 				datastoreIoLatencyThreshold = $someInt
    /// 				# OPTIONAL
    /// 				ioLatencyThreshold = $someInt
    /// 			}
    /// 		}
    /// 	}
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
    /// Runs the UpdateUnmountTime operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: UpdateUnmountTime
    /// 
    /// $query = New-RscMutationVsphereVm -Operation UpdateUnmountTime
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# REQUIRED
    /// 		newUnmountTime = $someInt64
    /// 	}
    /// 	# REQUIRED
    /// 	mountId = $someString
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
        "RscMutationVsphereVm",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationVsphereVm : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "BatchExport",
                "BatchExportV3",
                "BatchInPlaceRecovery",
                "DeleteSnapshot",
                "DownloadSnapshot",
                "DownloadSnapshotFiles",
                "ExcludeVmDisks",
                "ExportSnapshotV2",
                "ExportSnapshotV3",
                "ExportSnapshotWithDownloadFromCloud",
                "InitiateBatchInstantRecovery",
                "InitiateBatchLiveMountV2",
                "InitiateDiskMount",
                "InitiateInPlaceRecovery",
                "InitiateInstantRecoveryV2",
                "InitiateLiveMountV2",
                "ListEsxiDatastores",
                "MountRelocate",
                "MountRelocateV2",
                "PowerOnOffLiveMount",
                "RecoverFiles",
                "RecoverFilesNew",
                "RegisterAgent",
                "RegisterAgentWithOrg",
                "Update",
                "UpdateUnmountTime",
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
                    case "BatchExport":
                        this.ProcessRecord_BatchExport();
                        break;
                    case "BatchExportV3":
                        this.ProcessRecord_BatchExportV3();
                        break;
                    case "BatchInPlaceRecovery":
                        this.ProcessRecord_BatchInPlaceRecovery();
                        break;
                    case "DeleteSnapshot":
                        this.ProcessRecord_DeleteSnapshot();
                        break;
                    case "DownloadSnapshot":
                        this.ProcessRecord_DownloadSnapshot();
                        break;
                    case "DownloadSnapshotFiles":
                        this.ProcessRecord_DownloadSnapshotFiles();
                        break;
                    case "ExcludeVmDisks":
                        this.ProcessRecord_ExcludeVmDisks();
                        break;
                    case "ExportSnapshotV2":
                        this.ProcessRecord_ExportSnapshotV2();
                        break;
                    case "ExportSnapshotV3":
                        this.ProcessRecord_ExportSnapshotV3();
                        break;
                    case "ExportSnapshotWithDownloadFromCloud":
                        this.ProcessRecord_ExportSnapshotWithDownloadFromCloud();
                        break;
                    case "InitiateBatchInstantRecovery":
                        this.ProcessRecord_InitiateBatchInstantRecovery();
                        break;
                    case "InitiateBatchLiveMountV2":
                        this.ProcessRecord_InitiateBatchLiveMountV2();
                        break;
                    case "InitiateDiskMount":
                        this.ProcessRecord_InitiateDiskMount();
                        break;
                    case "InitiateInPlaceRecovery":
                        this.ProcessRecord_InitiateInPlaceRecovery();
                        break;
                    case "InitiateInstantRecoveryV2":
                        this.ProcessRecord_InitiateInstantRecoveryV2();
                        break;
                    case "InitiateLiveMountV2":
                        this.ProcessRecord_InitiateLiveMountV2();
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
                    case "PowerOnOffLiveMount":
                        this.ProcessRecord_PowerOnOffLiveMount();
                        break;
                    case "RecoverFiles":
                        this.ProcessRecord_RecoverFiles();
                        break;
                    case "RecoverFilesNew":
                        this.ProcessRecord_RecoverFilesNew();
                        break;
                    case "RegisterAgent":
                        this.ProcessRecord_RegisterAgent();
                        break;
                    case "RegisterAgentWithOrg":
                        this.ProcessRecord_RegisterAgentWithOrg();
                        break;
                    case "Update":
                        this.ProcessRecord_Update();
                        break;
                    case "UpdateUnmountTime":
                        this.ProcessRecord_UpdateUnmountTime();
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
        // vsphereVmBatchExport.
        internal void ProcessRecord_BatchExport()
        {
            this._logger.name += " -BatchExport";
            // Create new graphql operation vsphereVmBatchExport
            InitMutationVsphereVmBatchExport();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmBatchExportV3.
        internal void ProcessRecord_BatchExportV3()
        {
            this._logger.name += " -BatchExportV3";
            // Create new graphql operation vsphereVmBatchExportV3
            InitMutationVsphereVmBatchExportV3();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmBatchInPlaceRecovery.
        internal void ProcessRecord_BatchInPlaceRecovery()
        {
            this._logger.name += " -BatchInPlaceRecovery";
            // Create new graphql operation vsphereVmBatchInPlaceRecovery
            InitMutationVsphereVmBatchInPlaceRecovery();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmDeleteSnapshot.
        internal void ProcessRecord_DeleteSnapshot()
        {
            this._logger.name += " -DeleteSnapshot";
            // Create new graphql operation vsphereVmDeleteSnapshot
            InitMutationVsphereVmDeleteSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmDownloadSnapshot.
        internal void ProcessRecord_DownloadSnapshot()
        {
            this._logger.name += " -DownloadSnapshot";
            // Create new graphql operation vsphereVmDownloadSnapshot
            InitMutationVsphereVmDownloadSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmDownloadSnapshotFiles.
        internal void ProcessRecord_DownloadSnapshotFiles()
        {
            this._logger.name += " -DownloadSnapshotFiles";
            // Create new graphql operation vsphereVmDownloadSnapshotFiles
            InitMutationVsphereVmDownloadSnapshotFiles();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereExcludeVmDisks.
        internal void ProcessRecord_ExcludeVmDisks()
        {
            this._logger.name += " -ExcludeVmDisks";
            // Create new graphql operation vsphereExcludeVmDisks
            InitMutationVsphereExcludeVmDisks();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmExportSnapshotV2.
        internal void ProcessRecord_ExportSnapshotV2()
        {
            this._logger.name += " -ExportSnapshotV2";
            // Create new graphql operation vsphereVmExportSnapshotV2
            InitMutationVsphereVmExportSnapshotV2();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmExportSnapshotV3.
        internal void ProcessRecord_ExportSnapshotV3()
        {
            this._logger.name += " -ExportSnapshotV3";
            // Create new graphql operation vsphereVmExportSnapshotV3
            InitMutationVsphereVmExportSnapshotV3();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmExportSnapshotWithDownloadFromCloud.
        internal void ProcessRecord_ExportSnapshotWithDownloadFromCloud()
        {
            this._logger.name += " -ExportSnapshotWithDownloadFromCloud";
            // Create new graphql operation vsphereVmExportSnapshotWithDownloadFromCloud
            InitMutationVsphereVmExportSnapshotWithDownloadFromCloud();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmInitiateBatchInstantRecovery.
        internal void ProcessRecord_InitiateBatchInstantRecovery()
        {
            this._logger.name += " -InitiateBatchInstantRecovery";
            // Create new graphql operation vsphereVmInitiateBatchInstantRecovery
            InitMutationVsphereVmInitiateBatchInstantRecovery();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmInitiateBatchLiveMountV2.
        internal void ProcessRecord_InitiateBatchLiveMountV2()
        {
            this._logger.name += " -InitiateBatchLiveMountV2";
            // Create new graphql operation vsphereVmInitiateBatchLiveMountV2
            InitMutationVsphereVmInitiateBatchLiveMountV2();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmInitiateDiskMount.
        internal void ProcessRecord_InitiateDiskMount()
        {
            this._logger.name += " -InitiateDiskMount";
            // Create new graphql operation vsphereVmInitiateDiskMount
            InitMutationVsphereVmInitiateDiskMount();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmInitiateInPlaceRecovery.
        internal void ProcessRecord_InitiateInPlaceRecovery()
        {
            this._logger.name += " -InitiateInPlaceRecovery";
            // Create new graphql operation vsphereVmInitiateInPlaceRecovery
            InitMutationVsphereVmInitiateInPlaceRecovery();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmInitiateInstantRecoveryV2.
        internal void ProcessRecord_InitiateInstantRecoveryV2()
        {
            this._logger.name += " -InitiateInstantRecoveryV2";
            // Create new graphql operation vsphereVmInitiateInstantRecoveryV2
            InitMutationVsphereVmInitiateInstantRecoveryV2();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmInitiateLiveMountV2.
        internal void ProcessRecord_InitiateLiveMountV2()
        {
            this._logger.name += " -InitiateLiveMountV2";
            // Create new graphql operation vsphereVmInitiateLiveMountV2
            InitMutationVsphereVmInitiateLiveMountV2();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmListEsxiDatastores.
        internal void ProcessRecord_ListEsxiDatastores()
        {
            this._logger.name += " -ListEsxiDatastores";
            // Create new graphql operation vsphereVmListEsxiDatastores
            InitMutationVsphereVmListEsxiDatastores();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmMountRelocate.
        internal void ProcessRecord_MountRelocate()
        {
            this._logger.name += " -MountRelocate";
            // Create new graphql operation vsphereVmMountRelocate
            InitMutationVsphereVmMountRelocate();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmMountRelocateV2.
        internal void ProcessRecord_MountRelocateV2()
        {
            this._logger.name += " -MountRelocateV2";
            // Create new graphql operation vsphereVmMountRelocateV2
            InitMutationVsphereVmMountRelocateV2();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmPowerOnOffLiveMount.
        internal void ProcessRecord_PowerOnOffLiveMount()
        {
            this._logger.name += " -PowerOnOffLiveMount";
            // Create new graphql operation vsphereVmPowerOnOffLiveMount
            InitMutationVsphereVmPowerOnOffLiveMount();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmRecoverFiles.
        internal void ProcessRecord_RecoverFiles()
        {
            this._logger.name += " -RecoverFiles";
            // Create new graphql operation vsphereVmRecoverFiles
            InitMutationVsphereVmRecoverFiles();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmRecoverFilesNew.
        internal void ProcessRecord_RecoverFilesNew()
        {
            this._logger.name += " -RecoverFilesNew";
            // Create new graphql operation vsphereVmRecoverFilesNew
            InitMutationVsphereVmRecoverFilesNew();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmRegisterAgent.
        internal void ProcessRecord_RegisterAgent()
        {
            this._logger.name += " -RegisterAgent";
            // Create new graphql operation vsphereVmRegisterAgent
            InitMutationVsphereVmRegisterAgent();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmRegisterAgentWithOrg.
        internal void ProcessRecord_RegisterAgentWithOrg()
        {
            this._logger.name += " -RegisterAgentWithOrg";
            // Create new graphql operation vsphereVmRegisterAgentWithOrg
            InitMutationVsphereVmRegisterAgentWithOrg();
        }

        // This parameter set invokes a single graphql operation:
        // updateVsphereVm.
        internal void ProcessRecord_Update()
        {
            this._logger.name += " -Update";
            // Create new graphql operation updateVsphereVm
            InitMutationUpdateVsphereVm();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmUpdateUnmountTime.
        internal void ProcessRecord_UpdateUnmountTime()
        {
            this._logger.name += " -UpdateUnmountTime";
            // Create new graphql operation vsphereVmUpdateUnmountTime
            InitMutationVsphereVmUpdateUnmountTime();
        }


        // Create new GraphQL Mutation:
        // vsphereVmBatchExport(input: VsphereVmBatchExportInput!): BatchAsyncRequestStatus!
        internal void InitMutationVsphereVmBatchExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmBatchExportInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmBatchExport",
                "($input: VsphereVmBatchExportInput!)",
                "BatchAsyncRequestStatus",
                Mutation.VsphereVmBatchExport,
                Mutation.VsphereVmBatchExportFieldSpec,
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
				config = @{
					# OPTIONAL
					hostId = $someString
					# OPTIONAL
					shouldRecoverTags = $someBoolean
					# OPTIONAL
					unregisterVm = $someBoolean
					# OPTIONAL
					clusterId = $someString
					# OPTIONAL
					resourcePoolId = $someString
					# OPTIONAL
					shouldUseHotAddProxy = $someBoolean
					# OPTIONAL
					folderId = $someString
					# OPTIONAL
					contentLibraryId = $someString
					# OPTIONAL
					shouldConvertToTemplate = $someBoolean
					# REQUIRED
					datastoreId = $someString
					# OPTIONAL
					mountExportSnapshotJobCommonOptionsV2 = @{
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
					# OPTIONAL
					requiredRecoveryParameters = @{
						# OPTIONAL
						recoveryPoint = $someDateTime
						# OPTIONAL
						snapshotId = $someString
					}
					# OPTIONAL
					vNicBindings = @(
						@{
							# REQUIRED
							backingNetworkInfo = @{
								# REQUIRED
								moid = $someString
								# REQUIRED
								name = $someString
							}
							# REQUIRED
							networkDeviceInfo = @{
								# REQUIRED
								key = $someInt
								# REQUIRED
								name = $someString
							}
						}
					)
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
        // vsphereVmBatchExportV3(input: VsphereVmBatchExportV3Input!): BatchAsyncRequestStatus!
        internal void InitMutationVsphereVmBatchExportV3()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmBatchExportV3Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmBatchExportV3",
                "($input: VsphereVmBatchExportV3Input!)",
                "BatchAsyncRequestStatus",
                Mutation.VsphereVmBatchExportV3,
                Mutation.VsphereVmBatchExportV3FieldSpec,
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
				config = @{
					# OPTIONAL
					clusterId = $someString
					# OPTIONAL
					hostId = $someString
					# OPTIONAL
					resourcePoolId = $someString
					# OPTIONAL
					shouldRecoverTags = $someBoolean
					# OPTIONAL
					shouldUseHotAddProxy = $someBoolean
					# OPTIONAL
					storageLocationId = $someString
					# OPTIONAL
					unregisterVm = $someBoolean
					# OPTIONAL
					folderId = $someString
					# OPTIONAL
					contentLibraryId = $someString
					# OPTIONAL
					shouldConvertToTemplate = $someBoolean
					# OPTIONAL
					diskDeviceKeyToStorageId = @(
						@{
							# OPTIONAL
							storageLocationId = $someString
							# REQUIRED
							deviceKey = $someInt
						}
					)
					# OPTIONAL
					mountExportSnapshotJobCommonOptionsV2 = @{
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
					# OPTIONAL
					requiredRecoveryParameters = @{
						# OPTIONAL
						recoveryPoint = $someDateTime
						# OPTIONAL
						snapshotId = $someString
					}
					# OPTIONAL
					vNicBindings = @(
						@{
							# REQUIRED
							backingNetworkInfo = @{
								# REQUIRED
								moid = $someString
								# REQUIRED
								name = $someString
							}
							# REQUIRED
							networkDeviceInfo = @{
								# REQUIRED
								key = $someInt
								# REQUIRED
								name = $someString
							}
						}
					)
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
        // vsphereVmBatchInPlaceRecovery(input: VsphereVmBatchInPlaceRecoveryInput!): BatchAsyncRequestStatus!
        internal void InitMutationVsphereVmBatchInPlaceRecovery()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmBatchInPlaceRecoveryInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmBatchInPlaceRecovery",
                "($input: VsphereVmBatchInPlaceRecoveryInput!)",
                "BatchAsyncRequestStatus",
                Mutation.VsphereVmBatchInPlaceRecovery,
                Mutation.VsphereVmBatchInPlaceRecoveryFieldSpec,
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
				config = @{
					# OPTIONAL
					shouldKeepVsphereSnapshotAfterRecovery = $someBoolean
					# OPTIONAL
					requiredRecoveryParameters = @{
						# OPTIONAL
						recoveryPoint = $someDateTime
						# OPTIONAL
						snapshotId = $someString
					}
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
        // vsphereVmDeleteSnapshot(input: VsphereVmDeleteSnapshotInput!): Void
        internal void InitMutationVsphereVmDeleteSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmDeleteSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmDeleteSnapshot",
                "($input: VsphereVmDeleteSnapshotInput!)",
                "System.String",
                Mutation.VsphereVmDeleteSnapshot,
                Mutation.VsphereVmDeleteSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	location = $someDeleteVmwareSnapshotRequestLocation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeleteVmwareSnapshotRequestLocation]) for enum values.
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // vsphereVmDownloadSnapshot(input: VsphereVmDownloadSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationVsphereVmDownloadSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmDownloadSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmDownloadSnapshot",
                "($input: VsphereVmDownloadSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.VsphereVmDownloadSnapshot,
                Mutation.VsphereVmDownloadSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // vsphereVmDownloadSnapshotFiles(input: VsphereVmDownloadSnapshotFilesInput!): AsyncRequestStatus!
        internal void InitMutationVsphereVmDownloadSnapshotFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmDownloadSnapshotFilesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmDownloadSnapshotFiles",
                "($input: VsphereVmDownloadSnapshotFilesInput!)",
                "AsyncRequestStatus",
                Mutation.VsphereVmDownloadSnapshotFiles,
                Mutation.VsphereVmDownloadSnapshotFilesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotFid = $someString
	# REQUIRED
	paths = @(
		$someString
	)
	# OPTIONAL
	deltaTypeFilter = @(
		$someDeltaType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeltaType]) for enum values.
	)
	# OPTIONAL
	nextSnapshotFid = $someString
	# OPTIONAL
	isLegalHoldDownload = $someBoolean
	# OPTIONAL
	userNote = $someString
	# OPTIONAL
	zipPassword = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // vsphereExcludeVmDisks(input: [VsphereExcludeVmDisksInput!]!): RequestSuccess!
        internal void InitMutationVsphereExcludeVmDisks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "[VsphereExcludeVmDisksInput!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereExcludeVmDisks",
                "($input: [VsphereExcludeVmDisksInput!]!)",
                "RequestSuccess",
                Mutation.VsphereExcludeVmDisks,
                Mutation.VsphereExcludeVmDisksFieldSpec,
                @"# REQUIRED
$query.Var.input = @(
	@{
		# REQUIRED
		virtualDiskFid = $someString
		# OPTIONAL
		excludeFromSnapshots = $someBoolean
}
)"
            );
        }

        // Create new GraphQL Mutation:
        // vsphereVmExportSnapshotV2(input: VsphereVmExportSnapshotV2Input!): AsyncRequestStatus!
        internal void InitMutationVsphereVmExportSnapshotV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmExportSnapshotV2Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmExportSnapshotV2",
                "($input: VsphereVmExportSnapshotV2Input!)",
                "AsyncRequestStatus",
                Mutation.VsphereVmExportSnapshotV2,
                Mutation.VsphereVmExportSnapshotV2FieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		hostId = $someString
		# OPTIONAL
		shouldRecoverTags = $someBoolean
		# OPTIONAL
		unregisterVm = $someBoolean
		# OPTIONAL
		clusterId = $someString
		# OPTIONAL
		resourcePoolId = $someString
		# OPTIONAL
		shouldUseHotAddProxy = $someBoolean
		# OPTIONAL
		folderId = $someString
		# OPTIONAL
		contentLibraryId = $someString
		# OPTIONAL
		shouldConvertToTemplate = $someBoolean
		# REQUIRED
		datastoreId = $someString
		# OPTIONAL
		mountExportSnapshotJobCommonOptionsV2 = @{
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
		# OPTIONAL
		requiredRecoveryParameters = @{
			# OPTIONAL
			recoveryPoint = $someDateTime
			# OPTIONAL
			snapshotId = $someString
		}
		# OPTIONAL
		vNicBindings = @(
			@{
				# REQUIRED
				backingNetworkInfo = @{
					# REQUIRED
					moid = $someString
					# REQUIRED
					name = $someString
				}
				# REQUIRED
				networkDeviceInfo = @{
					# REQUIRED
					key = $someInt
					# REQUIRED
					name = $someString
				}
			}
		)
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // vsphereVmExportSnapshotV3(input: VsphereVmExportSnapshotV3Input!): AsyncRequestStatus!
        internal void InitMutationVsphereVmExportSnapshotV3()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmExportSnapshotV3Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmExportSnapshotV3",
                "($input: VsphereVmExportSnapshotV3Input!)",
                "AsyncRequestStatus",
                Mutation.VsphereVmExportSnapshotV3,
                Mutation.VsphereVmExportSnapshotV3FieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		clusterId = $someString
		# OPTIONAL
		hostId = $someString
		# OPTIONAL
		resourcePoolId = $someString
		# OPTIONAL
		shouldRecoverTags = $someBoolean
		# OPTIONAL
		shouldUseHotAddProxy = $someBoolean
		# OPTIONAL
		storageLocationId = $someString
		# OPTIONAL
		unregisterVm = $someBoolean
		# OPTIONAL
		folderId = $someString
		# OPTIONAL
		contentLibraryId = $someString
		# OPTIONAL
		shouldConvertToTemplate = $someBoolean
		# OPTIONAL
		diskDeviceKeyToStorageId = @(
			@{
				# OPTIONAL
				storageLocationId = $someString
				# REQUIRED
				deviceKey = $someInt
			}
		)
		# OPTIONAL
		mountExportSnapshotJobCommonOptionsV2 = @{
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
		# OPTIONAL
		requiredRecoveryParameters = @{
			# OPTIONAL
			recoveryPoint = $someDateTime
			# OPTIONAL
			snapshotId = $someString
		}
		# OPTIONAL
		vNicBindings = @(
			@{
				# REQUIRED
				backingNetworkInfo = @{
					# REQUIRED
					moid = $someString
					# REQUIRED
					name = $someString
				}
				# REQUIRED
				networkDeviceInfo = @{
					# REQUIRED
					key = $someInt
					# REQUIRED
					name = $someString
				}
			}
		)
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // vsphereVmExportSnapshotWithDownloadFromCloud(input: VsphereVmExportSnapshotWithDownloadFromCloudInput!): AsyncRequestStatus!
        internal void InitMutationVsphereVmExportSnapshotWithDownloadFromCloud()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmExportSnapshotWithDownloadFromCloudInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmExportSnapshotWithDownloadFromCloud",
                "($input: VsphereVmExportSnapshotWithDownloadFromCloudInput!)",
                "AsyncRequestStatus",
                Mutation.VsphereVmExportSnapshotWithDownloadFromCloud,
                Mutation.VsphereVmExportSnapshotWithDownloadFromCloudFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		hostId = $someString
		# OPTIONAL
		shouldRecoverTags = $someBoolean
		# OPTIONAL
		unregisterVm = $someBoolean
		# OPTIONAL
		clusterId = $someString
		# OPTIONAL
		resourcePoolId = $someString
		# OPTIONAL
		shouldUseHotAddProxy = $someBoolean
		# OPTIONAL
		folderId = $someString
		# OPTIONAL
		contentLibraryId = $someString
		# OPTIONAL
		shouldConvertToTemplate = $someBoolean
		# REQUIRED
		datastoreId = $someString
		# OPTIONAL
		mountExportSnapshotJobCommonOptionsV2 = @{
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
		# OPTIONAL
		requiredRecoveryParameters = @{
			# OPTIONAL
			recoveryPoint = $someDateTime
			# OPTIONAL
			snapshotId = $someString
		}
		# OPTIONAL
		vNicBindings = @(
			@{
				# REQUIRED
				backingNetworkInfo = @{
					# REQUIRED
					moid = $someString
					# REQUIRED
					name = $someString
				}
				# REQUIRED
				networkDeviceInfo = @{
					# REQUIRED
					key = $someInt
					# REQUIRED
					name = $someString
				}
			}
		)
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // vsphereVmInitiateBatchInstantRecovery(input: VsphereVmInitiateBatchInstantRecoveryInput!): BatchAsyncRequestStatus!
        internal void InitMutationVsphereVmInitiateBatchInstantRecovery()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmInitiateBatchInstantRecoveryInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmInitiateBatchInstantRecovery",
                "($input: VsphereVmInitiateBatchInstantRecoveryInput!)",
                "BatchAsyncRequestStatus",
                Mutation.VsphereVmInitiateBatchInstantRecovery,
                Mutation.VsphereVmInitiateBatchInstantRecoveryFieldSpec,
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
				config = @{
					# OPTIONAL
					hostId = $someString
					# OPTIONAL
					preserveMoid = $someBoolean
					# OPTIONAL
					shouldRecoverTags = $someBoolean
					# OPTIONAL
					vlan = $someInt
					# OPTIONAL
					clusterId = $someString
					# OPTIONAL
					resourcePoolId = $someString
					# OPTIONAL
					shouldMigrateImmediately = $someBoolean
					# OPTIONAL
					migrationConfig = @{
						# OPTIONAL
						storageLocationId = $someString
						# OPTIONAL
						computeClusterId = $someString
						# OPTIONAL
						hostId = $someString
						# OPTIONAL
						resourcePoolId = $someString
						# OPTIONAL
						diskDeviceKeyToStorageId = @(
							@{
								# OPTIONAL
								storageLocationId = $someString
								# REQUIRED
								deviceKey = $someInt
							}
						)
						# OPTIONAL
						networkDeviceKeyToNetworkName = @(
							@{
								# REQUIRED
								deviceKey = $someInt
								# REQUIRED
								networkName = $someString
							}
						)
					}
					# OPTIONAL
					mountExportSnapshotJobCommonOptionsV2 = @{
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
					# OPTIONAL
					requiredRecoveryParameters = @{
						# OPTIONAL
						recoveryPoint = $someDateTime
						# OPTIONAL
						snapshotId = $someString
					}
					# OPTIONAL
					vNicBindings = @(
						@{
							# REQUIRED
							backingNetworkInfo = @{
								# REQUIRED
								moid = $someString
								# REQUIRED
								name = $someString
							}
							# REQUIRED
							networkDeviceInfo = @{
								# REQUIRED
								key = $someInt
								# REQUIRED
								name = $someString
							}
						}
					)
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
        // vsphereVmInitiateBatchLiveMountV2(input: VsphereVmInitiateBatchLiveMountV2Input!): BatchAsyncRequestStatus!
        internal void InitMutationVsphereVmInitiateBatchLiveMountV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmInitiateBatchLiveMountV2Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmInitiateBatchLiveMountV2",
                "($input: VsphereVmInitiateBatchLiveMountV2Input!)",
                "BatchAsyncRequestStatus",
                Mutation.VsphereVmInitiateBatchLiveMountV2,
                Mutation.VsphereVmInitiateBatchLiveMountV2FieldSpec,
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
				config = @{
					# OPTIONAL
					createDatastoreOnly = $someBoolean
					# OPTIONAL
					dataStoreName = $someString
					# OPTIONAL
					hostId = $someString
					# OPTIONAL
					shouldRecoverTags = $someBoolean
					# OPTIONAL
					vlan = $someInt
					# OPTIONAL
					clusterId = $someString
					# OPTIONAL
					resourcePoolId = $someString
					# OPTIONAL
					shouldMigrateImmediately = $someBoolean
					# OPTIONAL
					folderId = $someString
					# OPTIONAL
					unmountTimeOpt = $someInt64
					# OPTIONAL
					migrationConfig = @{
						# OPTIONAL
						storageLocationId = $someString
						# OPTIONAL
						computeClusterId = $someString
						# OPTIONAL
						hostId = $someString
						# OPTIONAL
						resourcePoolId = $someString
						# OPTIONAL
						diskDeviceKeyToStorageId = @(
							@{
								# OPTIONAL
								storageLocationId = $someString
								# REQUIRED
								deviceKey = $someInt
							}
						)
						# OPTIONAL
						networkDeviceKeyToNetworkName = @(
							@{
								# REQUIRED
								deviceKey = $someInt
								# REQUIRED
								networkName = $someString
							}
						)
					}
					# OPTIONAL
					mountExportSnapshotJobCommonOptionsV2 = @{
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
					# OPTIONAL
					requiredRecoveryParameters = @{
						# OPTIONAL
						recoveryPoint = $someDateTime
						# OPTIONAL
						snapshotId = $someString
					}
					# OPTIONAL
					vNicBindings = @(
						@{
							# REQUIRED
							backingNetworkInfo = @{
								# REQUIRED
								moid = $someString
								# REQUIRED
								name = $someString
							}
							# REQUIRED
							networkDeviceInfo = @{
								# REQUIRED
								key = $someInt
								# REQUIRED
								name = $someString
							}
						}
					)
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
        // vsphereVmInitiateDiskMount(input: VsphereVmInitiateDiskMountInput!): AsyncRequestStatus!
        internal void InitMutationVsphereVmInitiateDiskMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmInitiateDiskMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmInitiateDiskMount",
                "($input: VsphereVmInitiateDiskMountInput!)",
                "AsyncRequestStatus",
                Mutation.VsphereVmInitiateDiskMount,
                Mutation.VsphereVmInitiateDiskMountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		targetVmId = $someString
		# OPTIONAL
		vlan = $someInt
		# OPTIONAL
		vmdkIds = @(
			$someString
		)
		# OPTIONAL
		unmountTimeOpt = $someInt64
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // vsphereVmInitiateInPlaceRecovery(input: VsphereVmInitiateInPlaceRecoveryInput!): AsyncRequestStatus!
        internal void InitMutationVsphereVmInitiateInPlaceRecovery()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmInitiateInPlaceRecoveryInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmInitiateInPlaceRecovery",
                "($input: VsphereVmInitiateInPlaceRecoveryInput!)",
                "AsyncRequestStatus",
                Mutation.VsphereVmInitiateInPlaceRecovery,
                Mutation.VsphereVmInitiateInPlaceRecoveryFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		shouldKeepVsphereSnapshotAfterRecovery = $someBoolean
		# OPTIONAL
		requiredRecoveryParameters = @{
			# OPTIONAL
			recoveryPoint = $someDateTime
			# OPTIONAL
			snapshotId = $someString
		}
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // vsphereVmInitiateInstantRecoveryV2(input: VsphereVmInitiateInstantRecoveryV2Input!): AsyncRequestStatus!
        internal void InitMutationVsphereVmInitiateInstantRecoveryV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmInitiateInstantRecoveryV2Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmInitiateInstantRecoveryV2",
                "($input: VsphereVmInitiateInstantRecoveryV2Input!)",
                "AsyncRequestStatus",
                Mutation.VsphereVmInitiateInstantRecoveryV2,
                Mutation.VsphereVmInitiateInstantRecoveryV2FieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		hostId = $someString
		# OPTIONAL
		preserveMoid = $someBoolean
		# OPTIONAL
		shouldRecoverTags = $someBoolean
		# OPTIONAL
		vlan = $someInt
		# OPTIONAL
		clusterId = $someString
		# OPTIONAL
		resourcePoolId = $someString
		# OPTIONAL
		shouldMigrateImmediately = $someBoolean
		# OPTIONAL
		migrationConfig = @{
			# OPTIONAL
			storageLocationId = $someString
			# OPTIONAL
			computeClusterId = $someString
			# OPTIONAL
			hostId = $someString
			# OPTIONAL
			resourcePoolId = $someString
			# OPTIONAL
			diskDeviceKeyToStorageId = @(
				@{
					# OPTIONAL
					storageLocationId = $someString
					# REQUIRED
					deviceKey = $someInt
				}
			)
			# OPTIONAL
			networkDeviceKeyToNetworkName = @(
				@{
					# REQUIRED
					deviceKey = $someInt
					# REQUIRED
					networkName = $someString
				}
			)
		}
		# OPTIONAL
		mountExportSnapshotJobCommonOptionsV2 = @{
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
		# OPTIONAL
		requiredRecoveryParameters = @{
			# OPTIONAL
			recoveryPoint = $someDateTime
			# OPTIONAL
			snapshotId = $someString
		}
		# OPTIONAL
		vNicBindings = @(
			@{
				# REQUIRED
				backingNetworkInfo = @{
					# REQUIRED
					moid = $someString
					# REQUIRED
					name = $someString
				}
				# REQUIRED
				networkDeviceInfo = @{
					# REQUIRED
					key = $someInt
					# REQUIRED
					name = $someString
				}
			}
		)
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // vsphereVmInitiateLiveMountV2(input: VsphereVmInitiateLiveMountV2Input!): AsyncRequestStatus!
        internal void InitMutationVsphereVmInitiateLiveMountV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmInitiateLiveMountV2Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmInitiateLiveMountV2",
                "($input: VsphereVmInitiateLiveMountV2Input!)",
                "AsyncRequestStatus",
                Mutation.VsphereVmInitiateLiveMountV2,
                Mutation.VsphereVmInitiateLiveMountV2FieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	config = @{
		# OPTIONAL
		createDatastoreOnly = $someBoolean
		# OPTIONAL
		dataStoreName = $someString
		# OPTIONAL
		hostId = $someString
		# OPTIONAL
		shouldRecoverTags = $someBoolean
		# OPTIONAL
		vlan = $someInt
		# OPTIONAL
		clusterId = $someString
		# OPTIONAL
		resourcePoolId = $someString
		# OPTIONAL
		shouldMigrateImmediately = $someBoolean
		# OPTIONAL
		folderId = $someString
		# OPTIONAL
		unmountTimeOpt = $someInt64
		# OPTIONAL
		migrationConfig = @{
			# OPTIONAL
			storageLocationId = $someString
			# OPTIONAL
			computeClusterId = $someString
			# OPTIONAL
			hostId = $someString
			# OPTIONAL
			resourcePoolId = $someString
			# OPTIONAL
			diskDeviceKeyToStorageId = @(
				@{
					# OPTIONAL
					storageLocationId = $someString
					# REQUIRED
					deviceKey = $someInt
				}
			)
			# OPTIONAL
			networkDeviceKeyToNetworkName = @(
				@{
					# REQUIRED
					deviceKey = $someInt
					# REQUIRED
					networkName = $someString
				}
			)
		}
		# OPTIONAL
		mountExportSnapshotJobCommonOptionsV2 = @{
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
		# OPTIONAL
		requiredRecoveryParameters = @{
			# OPTIONAL
			recoveryPoint = $someDateTime
			# OPTIONAL
			snapshotId = $someString
		}
		# OPTIONAL
		vNicBindings = @(
			@{
				# REQUIRED
				backingNetworkInfo = @{
					# REQUIRED
					moid = $someString
					# REQUIRED
					name = $someString
				}
				# REQUIRED
				networkDeviceInfo = @{
					# REQUIRED
					key = $someInt
					# REQUIRED
					name = $someString
				}
			}
		)
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // vsphereVmListEsxiDatastores(input: VsphereVmListEsxiDatastoresInput!): VsphereVmListEsxiDatastoresReply!
        internal void InitMutationVsphereVmListEsxiDatastores()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmListEsxiDatastoresInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmListEsxiDatastores",
                "($input: VsphereVmListEsxiDatastoresInput!)",
                "VsphereVmListEsxiDatastoresReply",
                Mutation.VsphereVmListEsxiDatastores,
                Mutation.VsphereVmListEsxiDatastoresFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	loginInfo = @{
		# REQUIRED
		ip = $someString
		# REQUIRED
		password = $someString
		# REQUIRED
		username = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // vsphereVmMountRelocate(input: VsphereVmMountRelocateInput!): AsyncRequestStatus!
        internal void InitMutationVsphereVmMountRelocate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmMountRelocateInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmMountRelocate",
                "($input: VsphereVmMountRelocateInput!)",
                "AsyncRequestStatus",
                Mutation.VsphereVmMountRelocate,
                Mutation.VsphereVmMountRelocateFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		datastoreId = $someString
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // vsphereVmMountRelocateV2(input: VsphereVmMountRelocateV2Input!): AsyncRequestStatus!
        internal void InitMutationVsphereVmMountRelocateV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmMountRelocateV2Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmMountRelocateV2",
                "($input: VsphereVmMountRelocateV2Input!)",
                "AsyncRequestStatus",
                Mutation.VsphereVmMountRelocateV2,
                Mutation.VsphereVmMountRelocateV2FieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		storageLocationId = $someString
		# OPTIONAL
		computeClusterId = $someString
		# OPTIONAL
		hostId = $someString
		# OPTIONAL
		resourcePoolId = $someString
		# OPTIONAL
		diskDeviceKeyToStorageId = @(
			@{
				# OPTIONAL
				storageLocationId = $someString
				# REQUIRED
				deviceKey = $someInt
			}
		)
		# OPTIONAL
		networkDeviceKeyToNetworkName = @(
			@{
				# REQUIRED
				deviceKey = $someInt
				# REQUIRED
				networkName = $someString
			}
		)
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // vsphereVmPowerOnOffLiveMount(input: VsphereVmPowerOnOffLiveMountInput!): VsphereVmPowerOnOffLiveMountReply!
        internal void InitMutationVsphereVmPowerOnOffLiveMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmPowerOnOffLiveMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmPowerOnOffLiveMount",
                "($input: VsphereVmPowerOnOffLiveMountInput!)",
                "VsphereVmPowerOnOffLiveMountReply",
                Mutation.VsphereVmPowerOnOffLiveMount,
                Mutation.VsphereVmPowerOnOffLiveMountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		shouldForce = $someBoolean
		# REQUIRED
		powerStatus = $someBoolean
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // vsphereVmRecoverFiles(input: VsphereVmRecoverFilesInput!): VsphereAsyncRequestStatus!
        internal void InitMutationVsphereVmRecoverFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmRecoverFilesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmRecoverFiles",
                "($input: VsphereVmRecoverFilesInput!)",
                "VsphereAsyncRequestStatus",
                Mutation.VsphereVmRecoverFiles,
                Mutation.VsphereVmRecoverFilesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotFid = $someString
	# REQUIRED
	restoreConfig = @{
		# OPTIONAL
		restoreFilesConfig = @(
			@{
				# OPTIONAL
				path = $someString
				# OPTIONAL
				restorePath = $someString
			}
		)
		# OPTIONAL
		domainName = $someString
		# OPTIONAL
		username = $someString
		# OPTIONAL
		password = $someString
		# OPTIONAL
		shouldIgnoreErrors = $someBoolean
		# OPTIONAL
		shouldSaveCredentials = $someBoolean
		# OPTIONAL
		shouldUseAgent = $someBoolean
		# OPTIONAL
		shouldRestoreXAttrs = $someBoolean
		# OPTIONAL
		deltaTypeFilter = @(
			$someDeltaType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeltaType]) for enum values.
		)
		# OPTIONAL
		nextSnapshotFid = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // vsphereVmRecoverFilesNew(input: VsphereVmRecoverFilesNewInput!): AsyncRequestStatus!
        internal void InitMutationVsphereVmRecoverFilesNew()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmRecoverFilesNewInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmRecoverFilesNew",
                "($input: VsphereVmRecoverFilesNewInput!)",
                "AsyncRequestStatus",
                Mutation.VsphereVmRecoverFilesNew,
                Mutation.VsphereVmRecoverFilesNewFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	config = @{
		# OPTIONAL
		domainName = $someString
		# OPTIONAL
		ignoreErrors = $someBoolean
		# OPTIONAL
		password = $someString
		# OPTIONAL
		shouldSaveCredentials = $someBoolean
		# OPTIONAL
		username = $someString
		# OPTIONAL
		destObjectId = $someString
		# OPTIONAL
		shouldRestoreXAttrs = $someBoolean
		# OPTIONAL
		shouldUseAgent = $someBoolean
		# OPTIONAL
		guestCredentialId = $someString
		# OPTIONAL
		description = $someString
		# OPTIONAL
		shouldUseMountDisks = $someBoolean
		# REQUIRED
		restoreConfig = @(
			@{
				# OPTIONAL
				restorePathPair = @{
					# OPTIONAL
					restorePath = $someString
					# REQUIRED
					path = $someString
				}
			}
		)
	}
	# OPTIONAL
	deltaRequest = @{
		# REQUIRED
		nextSnapshotFid = $someString
		# REQUIRED
		deltaTypeFilter = @(
			$someDeltaType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeltaType]) for enum values.
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // vsphereVmRegisterAgent(input: VsphereVmRegisterAgentInput!): RequestSuccess!
        internal void InitMutationVsphereVmRegisterAgent()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmRegisterAgentInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmRegisterAgent",
                "($input: VsphereVmRegisterAgentInput!)",
                "RequestSuccess",
                Mutation.VsphereVmRegisterAgent,
                Mutation.VsphereVmRegisterAgentFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	orgNetworkId = $someString
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // vsphereVmRegisterAgentWithOrg(input: VsphereVmRegisterAgentWithOrgInput!): RequestSuccess!
        internal void InitMutationVsphereVmRegisterAgentWithOrg()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmRegisterAgentWithOrgInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmRegisterAgentWithOrg",
                "($input: VsphereVmRegisterAgentWithOrgInput!)",
                "RequestSuccess",
                Mutation.VsphereVmRegisterAgentWithOrg,
                Mutation.VsphereVmRegisterAgentWithOrgFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	orgNetworkIdOpt = $someString
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateVsphereVm(input: UpdateVsphereVmInput!): RequestSuccess!
        internal void InitMutationUpdateVsphereVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateVsphereVmInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateVsphereVm",
                "($input: UpdateVsphereVmInput!)",
                "RequestSuccess",
                Mutation.UpdateVsphereVm,
                Mutation.UpdateVsphereVmFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	vmUpdateProperties = @{
		# OPTIONAL
		shouldRefreshCacheAfterUpdate = $someBoolean
		# OPTIONAL
		guestCredentialId = $someString
		# OPTIONAL
		shouldUseAgent = $someBoolean
		# OPTIONAL
		guestCredential = @{
			# REQUIRED
			password = $someString
			# REQUIRED
			username = $someString
		}
		# OPTIONAL
		virtualMachineUpdate = @{
			# OPTIONAL
			configuredSlaDomainId = $someString
			# OPTIONAL
			isArrayIntegrationEnabled = $someBoolean
			# OPTIONAL
			isVmPaused = $someBoolean
			# OPTIONAL
			maxNestedVsphereSnapshots = $someInt
			# OPTIONAL
			multiNodeBackupMode = $someMultiNodeBackupMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MultiNodeBackupMode]) for enum values.
			# OPTIONAL
			snapshotConsistencyMandate = $someVirtualMachineUpdateSnapshotConsistencyMandate # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VirtualMachineUpdateSnapshotConsistencyMandate]) for enum values.
			# OPTIONAL
			cloudInstantiationSpec = @{
				# REQUIRED
				imageRetentionInSeconds = $someInt64
			}
			# OPTIONAL
			postBackupScript = @{
				# REQUIRED
				failureHandling = $someVirtualMachineScriptDetailFailureHandling # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VirtualMachineScriptDetailFailureHandling]) for enum values.
				# REQUIRED
				scriptPath = $someString
				# REQUIRED
				timeoutMs = $someInt64
			}
			# OPTIONAL
			postSnapScript = @{
				# REQUIRED
				failureHandling = $someVirtualMachineScriptDetailFailureHandling # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VirtualMachineScriptDetailFailureHandling]) for enum values.
				# REQUIRED
				scriptPath = $someString
				# REQUIRED
				timeoutMs = $someInt64
			}
			# OPTIONAL
			preBackupScript = @{
				# REQUIRED
				failureHandling = $someVirtualMachineScriptDetailFailureHandling # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VirtualMachineScriptDetailFailureHandling]) for enum values.
				# REQUIRED
				scriptPath = $someString
				# REQUIRED
				timeoutMs = $someInt64
			}
			# OPTIONAL
			throttlingSettings = @{
				# OPTIONAL
				cpuUtilizationThreshold = $someInt
				# OPTIONAL
				datastoreIoLatencyThreshold = $someInt
				# OPTIONAL
				ioLatencyThreshold = $someInt
			}
		}
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // vsphereVmUpdateUnmountTime(input: VsphereVmUpdateUnmountTimeInput!): Void
        internal void InitMutationVsphereVmUpdateUnmountTime()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmUpdateUnmountTimeInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmUpdateUnmountTime",
                "($input: VsphereVmUpdateUnmountTimeInput!)",
                "System.String",
                Mutation.VsphereVmUpdateUnmountTime,
                Mutation.VsphereVmUpdateUnmountTimeFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		newUnmountTime = $someInt64
	}
	# REQUIRED
	mountId = $someString
}"
            );
        }


    } // class New_RscMutationVsphereVm
}