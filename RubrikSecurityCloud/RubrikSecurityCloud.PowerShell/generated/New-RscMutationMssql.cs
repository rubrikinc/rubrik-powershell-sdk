// New-RscMutationMssql.cs
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
    /// Create a new RscQuery object for any of the 17
    /// operations in the 'Microsoft SQL Server' API domain:
    /// AssignSlaDomainProperties, AssignSlaDomainPropertiesAsync, BrowseDatabaseSnapshot, BulkCreateOnDemandBackup, BulkUpdateDbs, CreateLiveMount, CreateLogShippingConfiguration, CreateOnDemandBackup, DeleteDbSnapshots, DeleteLiveMount, DownloadDatabaseBackupFiles, DownloadDatabaseFilesFromArchivalLocation, ExportDatabase, RestoreDatabase, TakeLogBackup, UpdateDefaultProperties, or UpdateLogShippingConfiguration.
    /// </summary>
    /// <description>
    /// New-RscMutationMssql creates a new
    /// mutation object for operations
    /// in the 'Microsoft SQL Server' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 17 operations
    /// in the 'Microsoft SQL Server' API domain. Select the operation this
    /// query is for by specifying the appropriate switch parameter;
    /// one of: -AssignSlaDomainProperties, -AssignSlaDomainPropertiesAsync, -BrowseDatabaseSnapshot, -BulkCreateOnDemandBackup, -BulkUpdateDbs, -CreateLiveMount, -CreateLogShippingConfiguration, -CreateOnDemandBackup, -DeleteDbSnapshots, -DeleteLiveMount, -DownloadDatabaseBackupFiles, -DownloadDatabaseFilesFromArchivalLocation, -ExportDatabase, -RestoreDatabase, -TakeLogBackup, -UpdateDefaultProperties, -UpdateLogShippingConfiguration.
    /// Alternatively, you can specify the operation by setting the
    /// -Op parameter, for example: -Op AssignSlaDomainProperties,
    /// which is equivalent to specifying -AssignSlaDomainProperties.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationMssql -AssignSlaDomainProperties).Info().
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
    /// (New-RscMutationMssql -AssignSlaDomainProperties).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AssignSlaDomainProperties operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: AssignSlaDomainProperties
    /// 
    /// $query = New-RscMutationMssql -AssignSlaDomainProperties
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	updateInfo = @{
    /// 		# OPTIONAL
    /// 		shouldApplyToExistingSnapshots = $someBoolean
    /// 		# OPTIONAL
    /// 		shouldApplyToNonPolicySnapshots = $someBoolean
    /// 		# OPTIONAL
    /// 		mssqlSlaPatchProperties = @{
    /// 			# OPTIONAL
    /// 			configuredSlaDomainId = $someString
    /// 			# OPTIONAL
    /// 			useConfiguredDefaultLogRetention = $someBoolean
    /// 			# OPTIONAL
    /// 			mssqlSlaRelatedProperties = @{
    /// 				# OPTIONAL
    /// 				copyOnly = $someBoolean
    /// 				# OPTIONAL
    /// 				logBackupFrequencyInSeconds = $someInt
    /// 				# OPTIONAL
    /// 				logRetentionHours = $someInt
    /// 				# OPTIONAL
    /// 				hasLogConfigFromSla = $someBoolean
    /// 				# OPTIONAL
    /// 				hostLogRetention = $someInt
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		existingSnapshotRetention = $someExistingSnapshotRetention # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ExistingSnapshotRetention]) for enum values.
    /// 		# REQUIRED
    /// 		ids = @(
    /// 			$someString
    /// 		)
    /// 	}
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
    /// Runs the AssignSlaDomainPropertiesAsync operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: AssignSlaDomainPropertiesAsync
    /// 
    /// $query = New-RscMutationMssql -AssignSlaDomainPropertiesAsync
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	updateInfo = @{
    /// 		# OPTIONAL
    /// 		shouldApplyToExistingSnapshots = $someBoolean
    /// 		# OPTIONAL
    /// 		shouldApplyToNonPolicySnapshots = $someBoolean
    /// 		# OPTIONAL
    /// 		mssqlSlaPatchProperties = @{
    /// 			# OPTIONAL
    /// 			configuredSlaDomainId = $someString
    /// 			# OPTIONAL
    /// 			useConfiguredDefaultLogRetention = $someBoolean
    /// 			# OPTIONAL
    /// 			mssqlSlaRelatedProperties = @{
    /// 				# OPTIONAL
    /// 				copyOnly = $someBoolean
    /// 				# OPTIONAL
    /// 				logBackupFrequencyInSeconds = $someInt
    /// 				# OPTIONAL
    /// 				logRetentionHours = $someInt
    /// 				# OPTIONAL
    /// 				hasLogConfigFromSla = $someBoolean
    /// 				# OPTIONAL
    /// 				hostLogRetention = $someInt
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		existingSnapshotRetention = $someExistingSnapshotRetention # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ExistingSnapshotRetention]) for enum values.
    /// 		# REQUIRED
    /// 		ids = @(
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
    /// Write-Host $result.GetType().Name # prints: AssignMssqlSlaDomainPropertiesAsyncReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BrowseDatabaseSnapshot operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: BrowseDatabaseSnapshot
    /// 
    /// $query = New-RscMutationMssql -BrowseDatabaseSnapshot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		endPoint = @{
    /// 			# OPTIONAL
    /// 			lsnPoint = @{
    /// 				# OPTIONAL
    /// 				recoveryForkGuid = $someString
    /// 				# REQUIRED
    /// 				lsn = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			timestampMs = $someInt64
    /// 			# OPTIONAL
    /// 			date = $someDateTime
    /// 		}
    /// 		# OPTIONAL
    /// 		legalHoldDownloadConfig = @{
    /// 			# REQUIRED
    /// 			isLegalHoldDownload = $someBoolean
    /// 		}
    /// 		# OPTIONAL
    /// 		recoveryPoint = @{
    /// 			# OPTIONAL
    /// 			lsnPoint = @{
    /// 				# OPTIONAL
    /// 				recoveryForkGuid = $someString
    /// 				# REQUIRED
    /// 				lsn = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			timestampMs = $someInt64
    /// 			# OPTIONAL
    /// 			date = $someDateTime
    /// 		}
    /// 		# OPTIONAL
    /// 		startPoint = @{
    /// 			# OPTIONAL
    /// 			lsnPoint = @{
    /// 				# OPTIONAL
    /// 				recoveryForkGuid = $someString
    /// 				# REQUIRED
    /// 				lsn = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			timestampMs = $someInt64
    /// 			# OPTIONAL
    /// 			date = $someDateTime
    /// 		}
    /// 		# OPTIONAL
    /// 		backupType = $someMssqlBackupType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlBackupType]) for enum values.
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BrowseMssqlDatabaseSnapshotReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BulkCreateOnDemandBackup operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: BulkCreateOnDemandBackup
    /// 
    /// $query = New-RscMutationMssql -BulkCreateOnDemandBackup
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		availabilityGroupIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		databaseIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		forceFullSnapshot = $someBoolean
    /// 		# OPTIONAL
    /// 		hostIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		instanceIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		windowsClusterIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		baseOnDemandSnapshotConfig = @{
    /// 			# OPTIONAL
    /// 			slaId = $someString
    /// 		}
    /// 	}
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
    /// Runs the BulkUpdateDbs operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: BulkUpdateDbs
    /// 
    /// $query = New-RscMutationMssql -BulkUpdateDbs
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	dbsUpdateProperties = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			databaseId = $someString
    /// 			# REQUIRED
    /// 			updateProperties = @{
    /// 				# OPTIONAL
    /// 				configuredSlaDomainId = $someString
    /// 				# OPTIONAL
    /// 				maxDataStreams = $someInt
    /// 				# OPTIONAL
    /// 				postBackupScript = @{
    /// 					# REQUIRED
    /// 					scriptErrorAction = $someScriptErrorAction # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ScriptErrorAction]) for enum values.
    /// 					# REQUIRED
    /// 					scriptPath = $someString
    /// 					# REQUIRED
    /// 					timeoutMs = $someInt64
    /// 				}
    /// 				# OPTIONAL
    /// 				preBackupScript = @{
    /// 					# REQUIRED
    /// 					scriptErrorAction = $someScriptErrorAction # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ScriptErrorAction]) for enum values.
    /// 					# REQUIRED
    /// 					scriptPath = $someString
    /// 					# REQUIRED
    /// 					timeoutMs = $someInt64
    /// 				}
    /// 				# OPTIONAL
    /// 				isPaused = $someBoolean
    /// 				# OPTIONAL
    /// 				shouldForceFull = $someBoolean
    /// 				# OPTIONAL
    /// 				mssqlNonSlaProperties = @{
    /// 					# OPTIONAL
    /// 					copyOnly = $someBoolean
    /// 					# OPTIONAL
    /// 					logBackupFrequencyInSeconds = $someInt
    /// 					# OPTIONAL
    /// 					logRetentionHours = $someInt
    /// 				}
    /// 				# OPTIONAL
    /// 				mssqlSlaPatchProperties = @{
    /// 					# OPTIONAL
    /// 					configuredSlaDomainId = $someString
    /// 					# OPTIONAL
    /// 					useConfiguredDefaultLogRetention = $someBoolean
    /// 					# OPTIONAL
    /// 					mssqlSlaRelatedProperties = @{
    /// 						# OPTIONAL
    /// 						copyOnly = $someBoolean
    /// 						# OPTIONAL
    /// 						logBackupFrequencyInSeconds = $someInt
    /// 						# OPTIONAL
    /// 						logRetentionHours = $someInt
    /// 						# OPTIONAL
    /// 						hasLogConfigFromSla = $someBoolean
    /// 						# OPTIONAL
    /// 						hostLogRetention = $someInt
    /// 					}
    /// 				}
    /// 				# OPTIONAL
    /// 				mssqlSlaRelatedProperties = @{
    /// 					# OPTIONAL
    /// 					copyOnly = $someBoolean
    /// 					# OPTIONAL
    /// 					logBackupFrequencyInSeconds = $someInt
    /// 					# OPTIONAL
    /// 					logRetentionHours = $someInt
    /// 					# OPTIONAL
    /// 					hasLogConfigFromSla = $someBoolean
    /// 					# OPTIONAL
    /// 					hostLogRetention = $someInt
    /// 				}
    /// 			}
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BulkUpdateMssqlDbsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateLiveMount operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: CreateLiveMount
    /// 
    /// $query = New-RscMutationMssql -CreateLiveMount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		targetInstanceId = $someString
    /// 		# OPTIONAL
    /// 		recoveryModel = $someMssqlDatabaseRecoveryModel # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlDatabaseRecoveryModel]) for enum values.
    /// 		# REQUIRED
    /// 		mountedDatabaseName = $someString
    /// 		# REQUIRED
    /// 		recoveryPoint = @{
    /// 			# OPTIONAL
    /// 			lsnPoint = @{
    /// 				# OPTIONAL
    /// 				recoveryForkGuid = $someString
    /// 				# REQUIRED
    /// 				lsn = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			timestampMs = $someInt64
    /// 			# OPTIONAL
    /// 			date = $someDateTime
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
    /// Runs the CreateLogShippingConfiguration operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: CreateLogShippingConfiguration
    /// 
    /// $query = New-RscMutationMssql -CreateLogShippingConfiguration
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		makeupReseedLimit = $someInt
    /// 		# OPTIONAL
    /// 		mssqlLogShippingCreateConfig = @{
    /// 			# OPTIONAL
    /// 			maxDataStreams = $someInt
    /// 			# OPTIONAL
    /// 			targetDataFilePath = $someString
    /// 			# OPTIONAL
    /// 			targetFilePaths = @(
    /// 				@{
    /// 					# OPTIONAL
    /// 					newFilename = $someString
    /// 					# OPTIONAL
    /// 					newLogicalName = $someString
    /// 					# REQUIRED
    /// 					exportPath = $someString
    /// 					# REQUIRED
    /// 					logicalName = $someString
    /// 				}
    /// 			)
    /// 			# OPTIONAL
    /// 			targetLogFilePath = $someString
    /// 			# OPTIONAL
    /// 			mssqlLogShippingTargetStateOptions = @{
    /// 				# OPTIONAL
    /// 				shouldDisconnectStandbyUsers = $someBoolean
    /// 				# REQUIRED
    /// 				state = $someMssqlLogShippingOkState # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlLogShippingOkState]) for enum values.
    /// 			}
    /// 			# REQUIRED
    /// 			targetDatabaseName = $someString
    /// 			# REQUIRED
    /// 			targetInstanceId = $someString
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
    /// Runs the CreateOnDemandBackup operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: CreateOnDemandBackup
    /// 
    /// $query = New-RscMutationMssql -CreateOnDemandBackup
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		forceFullSnapshot = $someBoolean
    /// 		# OPTIONAL
    /// 		baseOnDemandSnapshotConfig = @{
    /// 			# OPTIONAL
    /// 			slaId = $someString
    /// 		}
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
    /// Runs the DeleteDbSnapshots operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: DeleteDbSnapshots
    /// 
    /// $query = New-RscMutationMssql -DeleteDbSnapshots
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
    /// Runs the DeleteLiveMount operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: DeleteLiveMount
    /// 
    /// $query = New-RscMutationMssql -DeleteLiveMount
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
    /// Runs the DownloadDatabaseBackupFiles operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: DownloadDatabaseBackupFiles
    /// 
    /// $query = New-RscMutationMssql -DownloadDatabaseBackupFiles
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
    /// 		items = @(
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
    /// Runs the DownloadDatabaseFilesFromArchivalLocation operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: DownloadDatabaseFilesFromArchivalLocation
    /// 
    /// $query = New-RscMutationMssql -DownloadDatabaseFilesFromArchivalLocation
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# REQUIRED
    /// 		recoveryPoint = @{
    /// 			# OPTIONAL
    /// 			lsnPoint = @{
    /// 				# OPTIONAL
    /// 				recoveryForkGuid = $someString
    /// 				# REQUIRED
    /// 				lsn = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			timestampMs = $someInt64
    /// 			# OPTIONAL
    /// 			date = $someDateTime
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
    /// Runs the ExportDatabase operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: ExportDatabase
    /// 
    /// $query = New-RscMutationMssql -ExportDatabase
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		allowOverwrite = $someBoolean
    /// 		# OPTIONAL
    /// 		finishRecovery = $someBoolean
    /// 		# OPTIONAL
    /// 		maxDataStreams = $someInt
    /// 		# OPTIONAL
    /// 		targetDataFilePath = $someString
    /// 		# OPTIONAL
    /// 		targetFilePaths = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				newFilename = $someString
    /// 				# OPTIONAL
    /// 				newLogicalName = $someString
    /// 				# REQUIRED
    /// 				exportPath = $someString
    /// 				# REQUIRED
    /// 				logicalName = $someString
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		targetLogFilePath = $someString
    /// 		# REQUIRED
    /// 		recoveryPoint = @{
    /// 			# OPTIONAL
    /// 			lsnPoint = @{
    /// 				# OPTIONAL
    /// 				recoveryForkGuid = $someString
    /// 				# REQUIRED
    /// 				lsn = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			timestampMs = $someInt64
    /// 			# OPTIONAL
    /// 			date = $someDateTime
    /// 		}
    /// 		# REQUIRED
    /// 		targetDatabaseName = $someString
    /// 		# REQUIRED
    /// 		targetInstanceId = $someString
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
    /// Runs the RestoreDatabase operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: RestoreDatabase
    /// 
    /// $query = New-RscMutationMssql -RestoreDatabase
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		finishRecovery = $someBoolean
    /// 		# OPTIONAL
    /// 		maxDataStreams = $someInt
    /// 		# REQUIRED
    /// 		recoveryPoint = @{
    /// 			# OPTIONAL
    /// 			lsnPoint = @{
    /// 				# OPTIONAL
    /// 				recoveryForkGuid = $someString
    /// 				# REQUIRED
    /// 				lsn = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			timestampMs = $someInt64
    /// 			# OPTIONAL
    /// 			date = $someDateTime
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
    /// Runs the TakeLogBackup operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: TakeLogBackup
    /// 
    /// $query = New-RscMutationMssql -TakeLogBackup
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
    /// Runs the UpdateDefaultProperties operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: UpdateDefaultProperties
    /// 
    /// $query = New-RscMutationMssql -UpdateDefaultProperties
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	defaultProperties = @{
    /// 		# OPTIONAL
    /// 		cbtStatus = $someBoolean
    /// 		# OPTIONAL
    /// 		logBackupFrequencyInSeconds = $someInt64
    /// 		# OPTIONAL
    /// 		logRetentionTimeInHours = $someInt
    /// 		# OPTIONAL
    /// 		shouldUseDefaultBackupLocation = $someBoolean
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateMssqlDefaultPropertiesReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateLogShippingConfiguration operation
    /// of the 'Microsoft SQL Server' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mssql
    /// # API Operation: UpdateLogShippingConfiguration
    /// 
    /// $query = New-RscMutationMssql -UpdateLogShippingConfiguration
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		makeupReseedLimit = $someInt
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateMssqlLogShippingConfigurationReply
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
        "RscMutationMssql",
        DefaultParameterSetName = "BulkUpdateDbs")
    ]
    public class New_RscMutationMssql : RscGqlPSCmdlet
    {
        
        [Parameter(
            ParameterSetName = "AssignSlaDomainProperties",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'AssignSlaDomainProperties' operation
in the 'Microsoft SQL Server' API domain.
Description of the operation:
Assign SLA domain properties to Mssql objects.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/assignmssqlsladomainproperties.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AssignSlaDomainProperties { get; set; }

        
        [Parameter(
            ParameterSetName = "AssignSlaDomainPropertiesAsync",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'AssignSlaDomainPropertiesAsync' operation
in the 'Microsoft SQL Server' API domain.
Description of the operation:
Assign SLA domain properties to Mssql objects.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/assignmssqlsladomainpropertiesasync.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AssignSlaDomainPropertiesAsync { get; set; }

        
        [Parameter(
            ParameterSetName = "BrowseDatabaseSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'BrowseDatabaseSnapshot' operation
in the 'Microsoft SQL Server' API domain.
Description of the operation:
List snapshots and logs from a Mssql Database. This endpoint is only used to fetch data, but uses a mutation instead of a query due to limitations with the CDM API.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/browsemssqldatabasesnapshot.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter BrowseDatabaseSnapshot { get; set; }

        
        [Parameter(
            ParameterSetName = "BulkCreateOnDemandBackup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'BulkCreateOnDemandBackup' operation
in the 'Microsoft SQL Server' API domain.
Description of the operation:
Take a bulk on-demand backup of a Microsoft SQL Database.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/bulkcreateondemandmssqlbackup.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter BulkCreateOnDemandBackup { get; set; }

        
        [Parameter(
            ParameterSetName = "BulkUpdateDbs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'BulkUpdateDbs' operation
in the 'Microsoft SQL Server' API domain.
Description of the operation:
Update multiple Microsoft SQL databases with the specified properties.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/bulkupdatemssqldbs.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter BulkUpdateDbs { get; set; }

        
        [Parameter(
            ParameterSetName = "CreateLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreateLiveMount' operation
in the 'Microsoft SQL Server' API domain.
Description of the operation:
Create live mount of a Microsoft SQL Database.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createmssqllivemount.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreateLiveMount { get; set; }

        
        [Parameter(
            ParameterSetName = "CreateLogShippingConfiguration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreateLogShippingConfiguration' operation
in the 'Microsoft SQL Server' API domain.
Description of the operation:
Create log shipping configuration of a Microsoft SQL Database.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createmssqllogshippingconfiguration.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreateLogShippingConfiguration { get; set; }

        
        [Parameter(
            ParameterSetName = "CreateOnDemandBackup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreateOnDemandBackup' operation
in the 'Microsoft SQL Server' API domain.
Description of the operation:
Take an on-demand backup of a Microsoft SQL Database
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createondemandmssqlbackup.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreateOnDemandBackup { get; set; }

        
        [Parameter(
            ParameterSetName = "DeleteDbSnapshots",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DeleteDbSnapshots' operation
in the 'Microsoft SQL Server' API domain.
Description of the operation:
Delete snapshots of a Microsoft SQL Database.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/deletemssqldbsnapshots.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DeleteDbSnapshots { get; set; }

        
        [Parameter(
            ParameterSetName = "DeleteLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DeleteLiveMount' operation
in the 'Microsoft SQL Server' API domain.
Description of the operation:
Delete a Live Mount of a SQL Server database

Supported in v5.0+
Create an async request to delete a Live Mount of a SQL Server database. Poll the task status by using /mssql/request/{id}.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/deletemssqllivemount.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DeleteLiveMount { get; set; }

        
        [Parameter(
            ParameterSetName = "DownloadDatabaseBackupFiles",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DownloadDatabaseBackupFiles' operation
in the 'Microsoft SQL Server' API domain.
Description of the operation:
Downloads a list of snapshot and log backups from a Microsoft SQL database

Supported in v5.2+
Downloads a list of snapshot and log backups from a Microsoft SQL database.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/downloadmssqldatabasebackupfiles.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DownloadDatabaseBackupFiles { get; set; }

        
        [Parameter(
            ParameterSetName = "DownloadDatabaseFilesFromArchivalLocation",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DownloadDatabaseFilesFromArchivalLocation' operation
in the 'Microsoft SQL Server' API domain.
Description of the operation:
Download Microsoft SQL Database backup files from archival location.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/downloadmssqldatabasefilesfromarchivallocation.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DownloadDatabaseFilesFromArchivalLocation { get; set; }

        
        [Parameter(
            ParameterSetName = "ExportDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'ExportDatabase' operation
in the 'Microsoft SQL Server' API domain.
Description of the operation:
Create a request to export a Microsoft SQL database.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/exportmssqldatabase.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter ExportDatabase { get; set; }

        
        [Parameter(
            ParameterSetName = "RestoreDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'RestoreDatabase' operation
in the 'Microsoft SQL Server' API domain.
Description of the operation:
Create a request to restore a Microsoft SQL database.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/restoremssqldatabase.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter RestoreDatabase { get; set; }

        
        [Parameter(
            ParameterSetName = "TakeLogBackup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'TakeLogBackup' operation
in the 'Microsoft SQL Server' API domain.
Description of the operation:
Take an on-demand log backup for a Microsoft SQL database.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/takemssqllogbackup.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter TakeLogBackup { get; set; }

        
        [Parameter(
            ParameterSetName = "UpdateDefaultProperties",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpdateDefaultProperties' operation
in the 'Microsoft SQL Server' API domain.
Description of the operation:
Update the default properties for Microsoft SQL databases.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/updatemssqldefaultproperties.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpdateDefaultProperties { get; set; }

        
        [Parameter(
            ParameterSetName = "UpdateLogShippingConfiguration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpdateLogShippingConfiguration' operation
in the 'Microsoft SQL Server' API domain.
Description of the operation:
Update log shipping configuration of a Microsoft SQL Database.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/updatemssqllogshippingconfiguration.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpdateLogShippingConfiguration { get; set; }



        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "AssignSlaDomainProperties":
                        this.ProcessRecord_AssignSlaDomainProperties();
                        break;
                    case "AssignSlaDomainPropertiesAsync":
                        this.ProcessRecord_AssignSlaDomainPropertiesAsync();
                        break;
                    case "BrowseDatabaseSnapshot":
                        this.ProcessRecord_BrowseDatabaseSnapshot();
                        break;
                    case "BulkCreateOnDemandBackup":
                        this.ProcessRecord_BulkCreateOnDemandBackup();
                        break;
                    case "BulkUpdateDbs":
                        this.ProcessRecord_BulkUpdateDbs();
                        break;
                    case "CreateLiveMount":
                        this.ProcessRecord_CreateLiveMount();
                        break;
                    case "CreateLogShippingConfiguration":
                        this.ProcessRecord_CreateLogShippingConfiguration();
                        break;
                    case "CreateOnDemandBackup":
                        this.ProcessRecord_CreateOnDemandBackup();
                        break;
                    case "DeleteDbSnapshots":
                        this.ProcessRecord_DeleteDbSnapshots();
                        break;
                    case "DeleteLiveMount":
                        this.ProcessRecord_DeleteLiveMount();
                        break;
                    case "DownloadDatabaseBackupFiles":
                        this.ProcessRecord_DownloadDatabaseBackupFiles();
                        break;
                    case "DownloadDatabaseFilesFromArchivalLocation":
                        this.ProcessRecord_DownloadDatabaseFilesFromArchivalLocation();
                        break;
                    case "ExportDatabase":
                        this.ProcessRecord_ExportDatabase();
                        break;
                    case "RestoreDatabase":
                        this.ProcessRecord_RestoreDatabase();
                        break;
                    case "TakeLogBackup":
                        this.ProcessRecord_TakeLogBackup();
                        break;
                    case "UpdateDefaultProperties":
                        this.ProcessRecord_UpdateDefaultProperties();
                        break;
                    case "UpdateLogShippingConfiguration":
                        this.ProcessRecord_UpdateLogShippingConfiguration();
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
        // assignMssqlSlaDomainProperties.
        internal void ProcessRecord_AssignSlaDomainProperties()
        {
            this._logger.name += " -AssignSlaDomainProperties";
            // Create new graphql operation assignMssqlSlaDomainProperties
            InitMutationAssignMssqlSlaDomainProperties();
        }

        // This parameter set invokes a single graphql operation:
        // assignMssqlSlaDomainPropertiesAsync.
        internal void ProcessRecord_AssignSlaDomainPropertiesAsync()
        {
            this._logger.name += " -AssignSlaDomainPropertiesAsync";
            // Create new graphql operation assignMssqlSlaDomainPropertiesAsync
            InitMutationAssignMssqlSlaDomainPropertiesAsync();
        }

        // This parameter set invokes a single graphql operation:
        // browseMssqlDatabaseSnapshot.
        internal void ProcessRecord_BrowseDatabaseSnapshot()
        {
            this._logger.name += " -BrowseDatabaseSnapshot";
            // Create new graphql operation browseMssqlDatabaseSnapshot
            InitMutationBrowseMssqlDatabaseSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // bulkCreateOnDemandMssqlBackup.
        internal void ProcessRecord_BulkCreateOnDemandBackup()
        {
            this._logger.name += " -BulkCreateOnDemandBackup";
            // Create new graphql operation bulkCreateOnDemandMssqlBackup
            InitMutationBulkCreateOnDemandMssqlBackup();
        }

        // This parameter set invokes a single graphql operation:
        // bulkUpdateMssqlDbs.
        internal void ProcessRecord_BulkUpdateDbs()
        {
            this._logger.name += " -BulkUpdateDbs";
            // Create new graphql operation bulkUpdateMssqlDbs
            InitMutationBulkUpdateMssqlDbs();
        }

        // This parameter set invokes a single graphql operation:
        // createMssqlLiveMount.
        internal void ProcessRecord_CreateLiveMount()
        {
            this._logger.name += " -CreateLiveMount";
            // Create new graphql operation createMssqlLiveMount
            InitMutationCreateMssqlLiveMount();
        }

        // This parameter set invokes a single graphql operation:
        // createMssqlLogShippingConfiguration.
        internal void ProcessRecord_CreateLogShippingConfiguration()
        {
            this._logger.name += " -CreateLogShippingConfiguration";
            // Create new graphql operation createMssqlLogShippingConfiguration
            InitMutationCreateMssqlLogShippingConfiguration();
        }

        // This parameter set invokes a single graphql operation:
        // createOnDemandMssqlBackup.
        internal void ProcessRecord_CreateOnDemandBackup()
        {
            this._logger.name += " -CreateOnDemandBackup";
            // Create new graphql operation createOnDemandMssqlBackup
            InitMutationCreateOnDemandMssqlBackup();
        }

        // This parameter set invokes a single graphql operation:
        // deleteMssqlDbSnapshots.
        internal void ProcessRecord_DeleteDbSnapshots()
        {
            this._logger.name += " -DeleteDbSnapshots";
            // Create new graphql operation deleteMssqlDbSnapshots
            InitMutationDeleteMssqlDbSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // deleteMssqlLiveMount.
        internal void ProcessRecord_DeleteLiveMount()
        {
            this._logger.name += " -DeleteLiveMount";
            // Create new graphql operation deleteMssqlLiveMount
            InitMutationDeleteMssqlLiveMount();
        }

        // This parameter set invokes a single graphql operation:
        // downloadMssqlDatabaseBackupFiles.
        internal void ProcessRecord_DownloadDatabaseBackupFiles()
        {
            this._logger.name += " -DownloadDatabaseBackupFiles";
            // Create new graphql operation downloadMssqlDatabaseBackupFiles
            InitMutationDownloadMssqlDatabaseBackupFiles();
        }

        // This parameter set invokes a single graphql operation:
        // downloadMssqlDatabaseFilesFromArchivalLocation.
        internal void ProcessRecord_DownloadDatabaseFilesFromArchivalLocation()
        {
            this._logger.name += " -DownloadDatabaseFilesFromArchivalLocation";
            // Create new graphql operation downloadMssqlDatabaseFilesFromArchivalLocation
            InitMutationDownloadMssqlDatabaseFilesFromArchivalLocation();
        }

        // This parameter set invokes a single graphql operation:
        // exportMssqlDatabase.
        internal void ProcessRecord_ExportDatabase()
        {
            this._logger.name += " -ExportDatabase";
            // Create new graphql operation exportMssqlDatabase
            InitMutationExportMssqlDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // restoreMssqlDatabase.
        internal void ProcessRecord_RestoreDatabase()
        {
            this._logger.name += " -RestoreDatabase";
            // Create new graphql operation restoreMssqlDatabase
            InitMutationRestoreMssqlDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // takeMssqlLogBackup.
        internal void ProcessRecord_TakeLogBackup()
        {
            this._logger.name += " -TakeLogBackup";
            // Create new graphql operation takeMssqlLogBackup
            InitMutationTakeMssqlLogBackup();
        }

        // This parameter set invokes a single graphql operation:
        // updateMssqlDefaultProperties.
        internal void ProcessRecord_UpdateDefaultProperties()
        {
            this._logger.name += " -UpdateDefaultProperties";
            // Create new graphql operation updateMssqlDefaultProperties
            InitMutationUpdateMssqlDefaultProperties();
        }

        // This parameter set invokes a single graphql operation:
        // updateMssqlLogShippingConfiguration.
        internal void ProcessRecord_UpdateLogShippingConfiguration()
        {
            this._logger.name += " -UpdateLogShippingConfiguration";
            // Create new graphql operation updateMssqlLogShippingConfiguration
            InitMutationUpdateMssqlLogShippingConfiguration();
        }


        // Create new GraphQL Mutation:
        // assignMssqlSlaDomainProperties(input: AssignMssqlSlaDomainPropertiesInput!): ResponseSuccess!
        internal void InitMutationAssignMssqlSlaDomainProperties()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AssignMssqlSlaDomainPropertiesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAssignMssqlSlaDomainProperties",
                "($input: AssignMssqlSlaDomainPropertiesInput!)",
                "ResponseSuccess",
                Mutation.AssignMssqlSlaDomainProperties_ObjectFieldSpec,
                Mutation.AssignMssqlSlaDomainPropertiesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	updateInfo = @{
		# OPTIONAL
		shouldApplyToExistingSnapshots = $someBoolean
		# OPTIONAL
		shouldApplyToNonPolicySnapshots = $someBoolean
		# OPTIONAL
		mssqlSlaPatchProperties = @{
			# OPTIONAL
			configuredSlaDomainId = $someString
			# OPTIONAL
			useConfiguredDefaultLogRetention = $someBoolean
			# OPTIONAL
			mssqlSlaRelatedProperties = @{
				# OPTIONAL
				copyOnly = $someBoolean
				# OPTIONAL
				logBackupFrequencyInSeconds = $someInt
				# OPTIONAL
				logRetentionHours = $someInt
				# OPTIONAL
				hasLogConfigFromSla = $someBoolean
				# OPTIONAL
				hostLogRetention = $someInt
			}
		}
		# OPTIONAL
		existingSnapshotRetention = $someExistingSnapshotRetention # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ExistingSnapshotRetention]) for enum values.
		# REQUIRED
		ids = @(
			$someString
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // assignMssqlSlaDomainPropertiesAsync(input: AssignMssqlSlaDomainPropertiesAsyncInput!): AssignMssqlSlaDomainPropertiesAsyncReply!
        internal void InitMutationAssignMssqlSlaDomainPropertiesAsync()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AssignMssqlSlaDomainPropertiesAsyncInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAssignMssqlSlaDomainPropertiesAsync",
                "($input: AssignMssqlSlaDomainPropertiesAsyncInput!)",
                "AssignMssqlSlaDomainPropertiesAsyncReply",
                Mutation.AssignMssqlSlaDomainPropertiesAsync_ObjectFieldSpec,
                Mutation.AssignMssqlSlaDomainPropertiesAsyncFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	updateInfo = @{
		# OPTIONAL
		shouldApplyToExistingSnapshots = $someBoolean
		# OPTIONAL
		shouldApplyToNonPolicySnapshots = $someBoolean
		# OPTIONAL
		mssqlSlaPatchProperties = @{
			# OPTIONAL
			configuredSlaDomainId = $someString
			# OPTIONAL
			useConfiguredDefaultLogRetention = $someBoolean
			# OPTIONAL
			mssqlSlaRelatedProperties = @{
				# OPTIONAL
				copyOnly = $someBoolean
				# OPTIONAL
				logBackupFrequencyInSeconds = $someInt
				# OPTIONAL
				logRetentionHours = $someInt
				# OPTIONAL
				hasLogConfigFromSla = $someBoolean
				# OPTIONAL
				hostLogRetention = $someInt
			}
		}
		# OPTIONAL
		existingSnapshotRetention = $someExistingSnapshotRetention # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ExistingSnapshotRetention]) for enum values.
		# REQUIRED
		ids = @(
			$someString
		)
	}
	# OPTIONAL
	userNote = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // browseMssqlDatabaseSnapshot(input: BrowseMssqlDatabaseSnapshotInput!): BrowseMssqlDatabaseSnapshotReply!
        internal void InitMutationBrowseMssqlDatabaseSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BrowseMssqlDatabaseSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBrowseMssqlDatabaseSnapshot",
                "($input: BrowseMssqlDatabaseSnapshotInput!)",
                "BrowseMssqlDatabaseSnapshotReply",
                Mutation.BrowseMssqlDatabaseSnapshot_ObjectFieldSpec,
                Mutation.BrowseMssqlDatabaseSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		endPoint = @{
			# OPTIONAL
			lsnPoint = @{
				# OPTIONAL
				recoveryForkGuid = $someString
				# REQUIRED
				lsn = $someString
			}
			# OPTIONAL
			timestampMs = $someInt64
			# OPTIONAL
			date = $someDateTime
		}
		# OPTIONAL
		legalHoldDownloadConfig = @{
			# REQUIRED
			isLegalHoldDownload = $someBoolean
		}
		# OPTIONAL
		recoveryPoint = @{
			# OPTIONAL
			lsnPoint = @{
				# OPTIONAL
				recoveryForkGuid = $someString
				# REQUIRED
				lsn = $someString
			}
			# OPTIONAL
			timestampMs = $someInt64
			# OPTIONAL
			date = $someDateTime
		}
		# OPTIONAL
		startPoint = @{
			# OPTIONAL
			lsnPoint = @{
				# OPTIONAL
				recoveryForkGuid = $someString
				# REQUIRED
				lsn = $someString
			}
			# OPTIONAL
			timestampMs = $someInt64
			# OPTIONAL
			date = $someDateTime
		}
		# OPTIONAL
		backupType = $someMssqlBackupType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlBackupType]) for enum values.
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkCreateOnDemandMssqlBackup(input: BulkCreateOnDemandMssqlBackupInput!): AsyncRequestStatus!
        internal void InitMutationBulkCreateOnDemandMssqlBackup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkCreateOnDemandMssqlBackupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkCreateOnDemandMssqlBackup",
                "($input: BulkCreateOnDemandMssqlBackupInput!)",
                "AsyncRequestStatus",
                Mutation.BulkCreateOnDemandMssqlBackup_ObjectFieldSpec,
                Mutation.BulkCreateOnDemandMssqlBackupFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		availabilityGroupIds = @(
			$someString
		)
		# OPTIONAL
		databaseIds = @(
			$someString
		)
		# OPTIONAL
		forceFullSnapshot = $someBoolean
		# OPTIONAL
		hostIds = @(
			$someString
		)
		# OPTIONAL
		instanceIds = @(
			$someString
		)
		# OPTIONAL
		windowsClusterIds = @(
			$someString
		)
		# OPTIONAL
		baseOnDemandSnapshotConfig = @{
			# OPTIONAL
			slaId = $someString
		}
	}
	# OPTIONAL
	userNote = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkUpdateMssqlDbs(input: BulkUpdateMssqlDbsInput!): BulkUpdateMssqlDbsReply!
        internal void InitMutationBulkUpdateMssqlDbs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkUpdateMssqlDbsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkUpdateMssqlDbs",
                "($input: BulkUpdateMssqlDbsInput!)",
                "BulkUpdateMssqlDbsReply",
                Mutation.BulkUpdateMssqlDbs_ObjectFieldSpec,
                Mutation.BulkUpdateMssqlDbsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	dbsUpdateProperties = @(
		@{
			# REQUIRED
			databaseId = $someString
			# REQUIRED
			updateProperties = @{
				# OPTIONAL
				configuredSlaDomainId = $someString
				# OPTIONAL
				maxDataStreams = $someInt
				# OPTIONAL
				postBackupScript = @{
					# REQUIRED
					scriptErrorAction = $someScriptErrorAction # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ScriptErrorAction]) for enum values.
					# REQUIRED
					scriptPath = $someString
					# REQUIRED
					timeoutMs = $someInt64
				}
				# OPTIONAL
				preBackupScript = @{
					# REQUIRED
					scriptErrorAction = $someScriptErrorAction # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ScriptErrorAction]) for enum values.
					# REQUIRED
					scriptPath = $someString
					# REQUIRED
					timeoutMs = $someInt64
				}
				# OPTIONAL
				isPaused = $someBoolean
				# OPTIONAL
				shouldForceFull = $someBoolean
				# OPTIONAL
				mssqlNonSlaProperties = @{
					# OPTIONAL
					copyOnly = $someBoolean
					# OPTIONAL
					logBackupFrequencyInSeconds = $someInt
					# OPTIONAL
					logRetentionHours = $someInt
				}
				# OPTIONAL
				mssqlSlaPatchProperties = @{
					# OPTIONAL
					configuredSlaDomainId = $someString
					# OPTIONAL
					useConfiguredDefaultLogRetention = $someBoolean
					# OPTIONAL
					mssqlSlaRelatedProperties = @{
						# OPTIONAL
						copyOnly = $someBoolean
						# OPTIONAL
						logBackupFrequencyInSeconds = $someInt
						# OPTIONAL
						logRetentionHours = $someInt
						# OPTIONAL
						hasLogConfigFromSla = $someBoolean
						# OPTIONAL
						hostLogRetention = $someInt
					}
				}
				# OPTIONAL
				mssqlSlaRelatedProperties = @{
					# OPTIONAL
					copyOnly = $someBoolean
					# OPTIONAL
					logBackupFrequencyInSeconds = $someInt
					# OPTIONAL
					logRetentionHours = $someInt
					# OPTIONAL
					hasLogConfigFromSla = $someBoolean
					# OPTIONAL
					hostLogRetention = $someInt
				}
			}
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // createMssqlLiveMount(input: CreateMssqlLiveMountInput!): AsyncRequestStatus!
        internal void InitMutationCreateMssqlLiveMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateMssqlLiveMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateMssqlLiveMount",
                "($input: CreateMssqlLiveMountInput!)",
                "AsyncRequestStatus",
                Mutation.CreateMssqlLiveMount_ObjectFieldSpec,
                Mutation.CreateMssqlLiveMountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		targetInstanceId = $someString
		# OPTIONAL
		recoveryModel = $someMssqlDatabaseRecoveryModel # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlDatabaseRecoveryModel]) for enum values.
		# REQUIRED
		mountedDatabaseName = $someString
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			lsnPoint = @{
				# OPTIONAL
				recoveryForkGuid = $someString
				# REQUIRED
				lsn = $someString
			}
			# OPTIONAL
			timestampMs = $someInt64
			# OPTIONAL
			date = $someDateTime
		}
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // createMssqlLogShippingConfiguration(input: CreateMssqlLogShippingConfigurationInput!): AsyncRequestStatus!
        internal void InitMutationCreateMssqlLogShippingConfiguration()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateMssqlLogShippingConfigurationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateMssqlLogShippingConfiguration",
                "($input: CreateMssqlLogShippingConfigurationInput!)",
                "AsyncRequestStatus",
                Mutation.CreateMssqlLogShippingConfiguration_ObjectFieldSpec,
                Mutation.CreateMssqlLogShippingConfigurationFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	config = @{
		# OPTIONAL
		makeupReseedLimit = $someInt
		# OPTIONAL
		mssqlLogShippingCreateConfig = @{
			# OPTIONAL
			maxDataStreams = $someInt
			# OPTIONAL
			targetDataFilePath = $someString
			# OPTIONAL
			targetFilePaths = @(
				@{
					# OPTIONAL
					newFilename = $someString
					# OPTIONAL
					newLogicalName = $someString
					# REQUIRED
					exportPath = $someString
					# REQUIRED
					logicalName = $someString
				}
			)
			# OPTIONAL
			targetLogFilePath = $someString
			# OPTIONAL
			mssqlLogShippingTargetStateOptions = @{
				# OPTIONAL
				shouldDisconnectStandbyUsers = $someBoolean
				# REQUIRED
				state = $someMssqlLogShippingOkState # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlLogShippingOkState]) for enum values.
			}
			# REQUIRED
			targetDatabaseName = $someString
			# REQUIRED
			targetInstanceId = $someString
		}
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // createOnDemandMssqlBackup(input: CreateOnDemandMssqlBackupInput!): AsyncRequestStatus!
        internal void InitMutationCreateOnDemandMssqlBackup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateOnDemandMssqlBackupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateOnDemandMssqlBackup",
                "($input: CreateOnDemandMssqlBackupInput!)",
                "AsyncRequestStatus",
                Mutation.CreateOnDemandMssqlBackup_ObjectFieldSpec,
                Mutation.CreateOnDemandMssqlBackupFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		forceFullSnapshot = $someBoolean
		# OPTIONAL
		baseOnDemandSnapshotConfig = @{
			# OPTIONAL
			slaId = $someString
		}
	}
	# REQUIRED
	id = $someString
	# OPTIONAL
	userNote = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteMssqlDbSnapshots(input: DeleteMssqlDbSnapshotsInput!): ResponseSuccess!
        internal void InitMutationDeleteMssqlDbSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteMssqlDbSnapshotsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteMssqlDbSnapshots",
                "($input: DeleteMssqlDbSnapshotsInput!)",
                "ResponseSuccess",
                Mutation.DeleteMssqlDbSnapshots_ObjectFieldSpec,
                Mutation.DeleteMssqlDbSnapshotsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteMssqlLiveMount(input: DeleteMssqlLiveMountInput!): AsyncRequestStatus!
        internal void InitMutationDeleteMssqlLiveMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteMssqlLiveMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteMssqlLiveMount",
                "($input: DeleteMssqlLiveMountInput!)",
                "AsyncRequestStatus",
                Mutation.DeleteMssqlLiveMount_ObjectFieldSpec,
                Mutation.DeleteMssqlLiveMountFieldSpec,
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
        // downloadMssqlDatabaseBackupFiles(input: DownloadMssqlDatabaseBackupFilesInput!): AsyncRequestStatus!
        internal void InitMutationDownloadMssqlDatabaseBackupFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadMssqlDatabaseBackupFilesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadMssqlDatabaseBackupFiles",
                "($input: DownloadMssqlDatabaseBackupFilesInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadMssqlDatabaseBackupFiles_ObjectFieldSpec,
                Mutation.DownloadMssqlDatabaseBackupFilesFieldSpec,
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
		items = @(
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
        // downloadMssqlDatabaseFilesFromArchivalLocation(input: DownloadMssqlDatabaseFilesFromArchivalLocationInput!): AsyncRequestStatus!
        internal void InitMutationDownloadMssqlDatabaseFilesFromArchivalLocation()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadMssqlDatabaseFilesFromArchivalLocationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadMssqlDatabaseFilesFromArchivalLocation",
                "($input: DownloadMssqlDatabaseFilesFromArchivalLocationInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadMssqlDatabaseFilesFromArchivalLocation_ObjectFieldSpec,
                Mutation.DownloadMssqlDatabaseFilesFromArchivalLocationFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			lsnPoint = @{
				# OPTIONAL
				recoveryForkGuid = $someString
				# REQUIRED
				lsn = $someString
			}
			# OPTIONAL
			timestampMs = $someInt64
			# OPTIONAL
			date = $someDateTime
		}
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // exportMssqlDatabase(input: ExportMssqlDatabaseInput!): AsyncRequestStatus!
        internal void InitMutationExportMssqlDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportMssqlDatabaseInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExportMssqlDatabase",
                "($input: ExportMssqlDatabaseInput!)",
                "AsyncRequestStatus",
                Mutation.ExportMssqlDatabase_ObjectFieldSpec,
                Mutation.ExportMssqlDatabaseFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		allowOverwrite = $someBoolean
		# OPTIONAL
		finishRecovery = $someBoolean
		# OPTIONAL
		maxDataStreams = $someInt
		# OPTIONAL
		targetDataFilePath = $someString
		# OPTIONAL
		targetFilePaths = @(
			@{
				# OPTIONAL
				newFilename = $someString
				# OPTIONAL
				newLogicalName = $someString
				# REQUIRED
				exportPath = $someString
				# REQUIRED
				logicalName = $someString
			}
		)
		# OPTIONAL
		targetLogFilePath = $someString
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			lsnPoint = @{
				# OPTIONAL
				recoveryForkGuid = $someString
				# REQUIRED
				lsn = $someString
			}
			# OPTIONAL
			timestampMs = $someInt64
			# OPTIONAL
			date = $someDateTime
		}
		# REQUIRED
		targetDatabaseName = $someString
		# REQUIRED
		targetInstanceId = $someString
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // restoreMssqlDatabase(input: RestoreMssqlDatabaseInput!): AsyncRequestStatus!
        internal void InitMutationRestoreMssqlDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreMssqlDatabaseInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreMssqlDatabase",
                "($input: RestoreMssqlDatabaseInput!)",
                "AsyncRequestStatus",
                Mutation.RestoreMssqlDatabase_ObjectFieldSpec,
                Mutation.RestoreMssqlDatabaseFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		finishRecovery = $someBoolean
		# OPTIONAL
		maxDataStreams = $someInt
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			lsnPoint = @{
				# OPTIONAL
				recoveryForkGuid = $someString
				# REQUIRED
				lsn = $someString
			}
			# OPTIONAL
			timestampMs = $someInt64
			# OPTIONAL
			date = $someDateTime
		}
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // takeMssqlLogBackup(input: TakeMssqlLogBackupInput!): AsyncRequestStatus!
        internal void InitMutationTakeMssqlLogBackup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "TakeMssqlLogBackupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationTakeMssqlLogBackup",
                "($input: TakeMssqlLogBackupInput!)",
                "AsyncRequestStatus",
                Mutation.TakeMssqlLogBackup_ObjectFieldSpec,
                Mutation.TakeMssqlLogBackupFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateMssqlDefaultProperties(input: UpdateMssqlDefaultPropertiesInput!): UpdateMssqlDefaultPropertiesReply!
        internal void InitMutationUpdateMssqlDefaultProperties()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateMssqlDefaultPropertiesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateMssqlDefaultProperties",
                "($input: UpdateMssqlDefaultPropertiesInput!)",
                "UpdateMssqlDefaultPropertiesReply",
                Mutation.UpdateMssqlDefaultProperties_ObjectFieldSpec,
                Mutation.UpdateMssqlDefaultPropertiesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	defaultProperties = @{
		# OPTIONAL
		cbtStatus = $someBoolean
		# OPTIONAL
		logBackupFrequencyInSeconds = $someInt64
		# OPTIONAL
		logRetentionTimeInHours = $someInt
		# OPTIONAL
		shouldUseDefaultBackupLocation = $someBoolean
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateMssqlLogShippingConfiguration(input: UpdateMssqlLogShippingConfigurationInput!): UpdateMssqlLogShippingConfigurationReply!
        internal void InitMutationUpdateMssqlLogShippingConfiguration()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateMssqlLogShippingConfigurationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateMssqlLogShippingConfiguration",
                "($input: UpdateMssqlLogShippingConfigurationInput!)",
                "UpdateMssqlLogShippingConfigurationReply",
                Mutation.UpdateMssqlLogShippingConfiguration_ObjectFieldSpec,
                Mutation.UpdateMssqlLogShippingConfigurationFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	config = @{
		# OPTIONAL
		makeupReseedLimit = $someInt
	}
	# REQUIRED
	id = $someString
}"
            );
        }


    } // class New_RscMutationMssql
}