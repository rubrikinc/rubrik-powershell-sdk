// New-RscMutationOracle.cs
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
    /// Create a new RscQuery object for any of the 18
    /// operations in the 'Oracle' API domain:
    /// BulkUpdateDatabases, BulkUpdateHosts, BulkUpdateRacs, CreatePdbRestore, DeleteAllDatabaseSnapshots, DeleteMount, DownloadDatabaseSnapshot, ExportDatabase, ExportTablespace, InstantRecoverSnapshot, MountDatabase, RefreshDatabase, RestoreLogs, TakeOnDemandDatabaseSnapshot, TakeOnDemandLogSnapshot, UpdateDataGuardGroup, ValidateAcoFile, or ValidateDatabaseBackups.
    /// </summary>
    /// <description>
    /// New-RscMutationOracle creates a new
    /// mutation object for operations
    /// in the 'Oracle' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 18 operations
    /// in the 'Oracle' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: BulkUpdateDatabases, BulkUpdateHosts, BulkUpdateRacs, CreatePdbRestore, DeleteAllDatabaseSnapshots, DeleteMount, DownloadDatabaseSnapshot, ExportDatabase, ExportTablespace, InstantRecoverSnapshot, MountDatabase, RefreshDatabase, RestoreLogs, TakeOnDemandDatabaseSnapshot, TakeOnDemandLogSnapshot, UpdateDataGuardGroup, ValidateAcoFile, or ValidateDatabaseBackups.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationOracle -BulkUpdateDatabases).Info().
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
    /// (New-RscMutationOracle -BulkUpdateDatabases).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the BulkUpdateDatabases operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: BulkUpdateDatabases
    /// 
    /// $query = New-RscMutationOracle -BulkUpdateDatabases
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	bulkUpdateProperties = @{
    /// 		# REQUIRED
    /// 		ids = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		oracleUpdate = @{
    /// 			# OPTIONAL
    /// 			configuredSlaDomainId = $someString
    /// 			# OPTIONAL
    /// 			hostMount = $someString
    /// 			# OPTIONAL
    /// 			logBackupFrequencyInMinutes = $someInt
    /// 			# OPTIONAL
    /// 			logRetentionHours = $someInt
    /// 			# OPTIONAL
    /// 			numChannels = $someInt
    /// 			# OPTIONAL
    /// 			hostLogRetentionHours = $someInt
    /// 			# OPTIONAL
    /// 			configuredSlaDomainIdDeprecated = $someString
    /// 			# OPTIONAL
    /// 			shouldDistributeBackupsAutomatically = $someBoolean
    /// 			# OPTIONAL
    /// 			nodeOrder = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					nodeName = $someString
    /// 					# REQUIRED
    /// 					order = $someInt
    /// 				}
    /// 			)
    /// 			# OPTIONAL
    /// 			oracleUpdateCommon = @{
    /// 				# OPTIONAL
    /// 				hostLogRetentionHours = $someInt
    /// 				# OPTIONAL
    /// 				hostMount = $someString
    /// 				# OPTIONAL
    /// 				logBackupFrequencyInMinutes = $someInt
    /// 				# OPTIONAL
    /// 				logRetentionHours = $someInt
    /// 				# OPTIONAL
    /// 				numChannels = $someInt
    /// 				# OPTIONAL
    /// 				hasLogConfigFromSla = $someBoolean
    /// 				# OPTIONAL
    /// 				shouldEnableHighFileCountSupport = $someBoolean
    /// 				# OPTIONAL
    /// 				shouldUseSecureThriftForDataTransfer = $someBoolean
    /// 				# OPTIONAL
    /// 				sectionSizeInGb = $someInt
    /// 				# OPTIONAL
    /// 				isPaused = $someBoolean
    /// 			}
    /// 		}
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BulkUpdateOracleDatabasesReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BulkUpdateHosts operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: BulkUpdateHosts
    /// 
    /// $query = New-RscMutationOracle -BulkUpdateHosts
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	bulkUpdateProperties = @{
    /// 		# REQUIRED
    /// 		ids = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		oracleUpdate = @{
    /// 			# OPTIONAL
    /// 			configuredSlaDomainId = $someString
    /// 			# OPTIONAL
    /// 			hostMount = $someString
    /// 			# OPTIONAL
    /// 			logBackupFrequencyInMinutes = $someInt
    /// 			# OPTIONAL
    /// 			logRetentionHours = $someInt
    /// 			# OPTIONAL
    /// 			numChannels = $someInt
    /// 			# OPTIONAL
    /// 			hostLogRetentionHours = $someInt
    /// 			# OPTIONAL
    /// 			configuredSlaDomainIdDeprecated = $someString
    /// 			# OPTIONAL
    /// 			shouldDistributeBackupsAutomatically = $someBoolean
    /// 			# OPTIONAL
    /// 			nodeOrder = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					nodeName = $someString
    /// 					# REQUIRED
    /// 					order = $someInt
    /// 				}
    /// 			)
    /// 			# OPTIONAL
    /// 			oracleUpdateCommon = @{
    /// 				# OPTIONAL
    /// 				hostLogRetentionHours = $someInt
    /// 				# OPTIONAL
    /// 				hostMount = $someString
    /// 				# OPTIONAL
    /// 				logBackupFrequencyInMinutes = $someInt
    /// 				# OPTIONAL
    /// 				logRetentionHours = $someInt
    /// 				# OPTIONAL
    /// 				numChannels = $someInt
    /// 				# OPTIONAL
    /// 				hasLogConfigFromSla = $someBoolean
    /// 				# OPTIONAL
    /// 				shouldEnableHighFileCountSupport = $someBoolean
    /// 				# OPTIONAL
    /// 				shouldUseSecureThriftForDataTransfer = $someBoolean
    /// 				# OPTIONAL
    /// 				sectionSizeInGb = $someInt
    /// 				# OPTIONAL
    /// 				isPaused = $someBoolean
    /// 			}
    /// 		}
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BulkUpdateOracleHostsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BulkUpdateRacs operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: BulkUpdateRacs
    /// 
    /// $query = New-RscMutationOracle -BulkUpdateRacs
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	bulkUpdateProperties = @{
    /// 		# REQUIRED
    /// 		ids = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		oracleUpdate = @{
    /// 			# OPTIONAL
    /// 			configuredSlaDomainId = $someString
    /// 			# OPTIONAL
    /// 			hostMount = $someString
    /// 			# OPTIONAL
    /// 			logBackupFrequencyInMinutes = $someInt
    /// 			# OPTIONAL
    /// 			logRetentionHours = $someInt
    /// 			# OPTIONAL
    /// 			numChannels = $someInt
    /// 			# OPTIONAL
    /// 			hostLogRetentionHours = $someInt
    /// 			# OPTIONAL
    /// 			configuredSlaDomainIdDeprecated = $someString
    /// 			# OPTIONAL
    /// 			shouldDistributeBackupsAutomatically = $someBoolean
    /// 			# OPTIONAL
    /// 			nodeOrder = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					nodeName = $someString
    /// 					# REQUIRED
    /// 					order = $someInt
    /// 				}
    /// 			)
    /// 			# OPTIONAL
    /// 			oracleUpdateCommon = @{
    /// 				# OPTIONAL
    /// 				hostLogRetentionHours = $someInt
    /// 				# OPTIONAL
    /// 				hostMount = $someString
    /// 				# OPTIONAL
    /// 				logBackupFrequencyInMinutes = $someInt
    /// 				# OPTIONAL
    /// 				logRetentionHours = $someInt
    /// 				# OPTIONAL
    /// 				numChannels = $someInt
    /// 				# OPTIONAL
    /// 				hasLogConfigFromSla = $someBoolean
    /// 				# OPTIONAL
    /// 				shouldEnableHighFileCountSupport = $someBoolean
    /// 				# OPTIONAL
    /// 				shouldUseSecureThriftForDataTransfer = $someBoolean
    /// 				# OPTIONAL
    /// 				sectionSizeInGb = $someInt
    /// 				# OPTIONAL
    /// 				isPaused = $someBoolean
    /// 			}
    /// 		}
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BulkUpdateOracleRacsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreatePdbRestore operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: CreatePdbRestore
    /// 
    /// $query = New-RscMutationOracle -CreatePdbRestore
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# REQUIRED
    /// 		pdbsToRestore = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		recoveryPoint = @{
    /// 			# OPTIONAL
    /// 			snapshotId = $someString
    /// 			# OPTIONAL
    /// 			timestampMs = $someInt64
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
    /// Runs the DeleteAllDatabaseSnapshots operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: DeleteAllDatabaseSnapshots
    /// 
    /// $query = New-RscMutationOracle -DeleteAllDatabaseSnapshots
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
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteMount operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: DeleteMount
    /// 
    /// $query = New-RscMutationOracle -DeleteMount
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
    /// Runs the DownloadDatabaseSnapshot operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: DownloadDatabaseSnapshot
    /// 
    /// $query = New-RscMutationOracle -DownloadDatabaseSnapshot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
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
    /// Runs the ExportDatabase operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: ExportDatabase
    /// 
    /// $query = New-RscMutationOracle -ExportDatabase
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	request = @{
    /// 		# REQUIRED
    /// 		config = @{
    /// 			# OPTIONAL
    /// 			restoreFilesPath = $someString
    /// 			# OPTIONAL
    /// 			shouldRestoreFilesOnly = $someBoolean
    /// 			# OPTIONAL
    /// 			targetMountPath = $someString
    /// 			# OPTIONAL
    /// 			advancedRecoveryConfigBase64 = $someString
    /// 			# OPTIONAL
    /// 			archiveLogPath = $someString
    /// 			# OPTIONAL
    /// 			cloneDbName = $someString
    /// 			# OPTIONAL
    /// 			customPfilePath = $someString
    /// 			# OPTIONAL
    /// 			numChannels = $someInt
    /// 			# OPTIONAL
    /// 			postScriptPath = $someString
    /// 			# OPTIONAL
    /// 			preScriptPath = $someString
    /// 			# OPTIONAL
    /// 			shouldStopRecoveryOnPreScriptFailure = $someBoolean
    /// 			# OPTIONAL
    /// 			pdbsToClone = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			shouldSkipDropDbInUndo = $someBoolean
    /// 			# OPTIONAL
    /// 			targetRacHostIds = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			targetRacPrimaryHostId = $someString
    /// 			# OPTIONAL
    /// 			shouldAllowRenameToSource = $someBoolean
    /// 			# REQUIRED
    /// 			recoveryPoint = @{
    /// 				# OPTIONAL
    /// 				snapshotId = $someString
    /// 				# OPTIONAL
    /// 				timestampMs = $someInt64
    /// 			}
    /// 			# REQUIRED
    /// 			targetOracleHostOrRacId = $someString
    /// 		}
    /// 		# REQUIRED
    /// 		id = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	advancedRecoveryConfigMap = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			key = $someString
    /// 			# OPTIONAL
    /// 			value = $someString
    /// 		}
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
    /// Runs the ExportTablespace operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: ExportTablespace
    /// 
    /// $query = New-RscMutationOracle -ExportTablespace
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		exposeAllLogs = $someBoolean
    /// 		# REQUIRED
    /// 		auxiliaryDestinationPath = $someString
    /// 		# REQUIRED
    /// 		recoveryPoint = @{
    /// 			# OPTIONAL
    /// 			snapshotId = $someString
    /// 			# OPTIONAL
    /// 			timestampMs = $someInt64
    /// 		}
    /// 		# REQUIRED
    /// 		tablespaceName = $someString
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
    /// Runs the InstantRecoverSnapshot operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: InstantRecoverSnapshot
    /// 
    /// $query = New-RscMutationOracle -InstantRecoverSnapshot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		numChannels = $someInt
    /// 		# OPTIONAL
    /// 		shouldSkipDropDbInUndo = $someBoolean
    /// 		# REQUIRED
    /// 		recoveryPoint = @{
    /// 			# OPTIONAL
    /// 			snapshotId = $someString
    /// 			# OPTIONAL
    /// 			timestampMs = $someInt64
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
    /// Runs the MountDatabase operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: MountDatabase
    /// 
    /// $query = New-RscMutationOracle -MountDatabase
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	request = @{
    /// 		# REQUIRED
    /// 		config = @{
    /// 			# OPTIONAL
    /// 			shouldMountFilesOnly = $someBoolean
    /// 			# OPTIONAL
    /// 			targetMountPath = $someString
    /// 			# OPTIONAL
    /// 			advancedRecoveryConfigBase64 = $someString
    /// 			# OPTIONAL
    /// 			customPfilePath = $someString
    /// 			# OPTIONAL
    /// 			numChannels = $someInt
    /// 			# OPTIONAL
    /// 			postScriptPath = $someString
    /// 			# OPTIONAL
    /// 			preScriptPath = $someString
    /// 			# OPTIONAL
    /// 			shouldStopRecoveryOnPreScriptFailure = $someBoolean
    /// 			# OPTIONAL
    /// 			pdbsToLiveMount = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			targetRacHostIds = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			shouldSkipDropDbInUndo = $someBoolean
    /// 			# OPTIONAL
    /// 			lmDbName = $someString
    /// 			# OPTIONAL
    /// 			targetRacPrimaryHostId = $someString
    /// 			# OPTIONAL
    /// 			shouldAllowRenameToSource = $someBoolean
    /// 			# REQUIRED
    /// 			recoveryPoint = @{
    /// 				# OPTIONAL
    /// 				snapshotId = $someString
    /// 				# OPTIONAL
    /// 				timestampMs = $someInt64
    /// 			}
    /// 			# REQUIRED
    /// 			targetOracleHostOrRacId = $someString
    /// 		}
    /// 		# REQUIRED
    /// 		id = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	advancedRecoveryConfigMap = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			key = $someString
    /// 			# OPTIONAL
    /// 			value = $someString
    /// 		}
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
    /// Runs the RefreshDatabase operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: RefreshDatabase
    /// 
    /// $query = New-RscMutationOracle -RefreshDatabase
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
    /// Runs the RestoreLogs operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: RestoreLogs
    /// 
    /// $query = New-RscMutationOracle -RestoreLogs
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		targetMountPath = $someString
    /// 		# REQUIRED
    /// 		oracleLogRecoveryRange = @{
    /// 			# OPTIONAL
    /// 			oracleTimeRange = @{
    /// 				# OPTIONAL
    /// 				endTime = $someDateTime
    /// 				# OPTIONAL
    /// 				startTime = $someDateTime
    /// 			}
    /// 		}
    /// 		# REQUIRED
    /// 		shouldMountFilesOnly = $someBoolean
    /// 		# REQUIRED
    /// 		targetOracleHostOrRacId = $someString
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
    /// Runs the TakeOnDemandDatabaseSnapshot operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: TakeOnDemandDatabaseSnapshot
    /// 
    /// $query = New-RscMutationOracle -TakeOnDemandDatabaseSnapshot
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
    /// Runs the TakeOnDemandLogSnapshot operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: TakeOnDemandLogSnapshot
    /// 
    /// $query = New-RscMutationOracle -TakeOnDemandLogSnapshot
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
    /// Runs the UpdateDataGuardGroup operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: UpdateDataGuardGroup
    /// 
    /// $query = New-RscMutationOracle -UpdateDataGuardGroup
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	updateProperties = @{
    /// 		# OPTIONAL
    /// 		preferredDgMemberUniqueNames = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		shouldBackupFromPrimaryOnly = $someBoolean
    /// 		# OPTIONAL
    /// 		shouldUseSepsWallet = $someBoolean
    /// 		# OPTIONAL
    /// 		shouldForceDisableDgDiscovery = $someBoolean
    /// 		# OPTIONAL
    /// 		oracleUpdateCommon = @{
    /// 			# OPTIONAL
    /// 			hostLogRetentionHours = $someInt
    /// 			# OPTIONAL
    /// 			hostMount = $someString
    /// 			# OPTIONAL
    /// 			logBackupFrequencyInMinutes = $someInt
    /// 			# OPTIONAL
    /// 			logRetentionHours = $someInt
    /// 			# OPTIONAL
    /// 			numChannels = $someInt
    /// 			# OPTIONAL
    /// 			hasLogConfigFromSla = $someBoolean
    /// 			# OPTIONAL
    /// 			shouldEnableHighFileCountSupport = $someBoolean
    /// 			# OPTIONAL
    /// 			shouldUseSecureThriftForDataTransfer = $someBoolean
    /// 			# OPTIONAL
    /// 			sectionSizeInGb = $someInt
    /// 			# OPTIONAL
    /// 			isPaused = $someBoolean
    /// 		}
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: OracleDbDetail
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ValidateAcoFile operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: ValidateAcoFile
    /// 
    /// $query = New-RscMutationOracle -ValidateAcoFile
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	acoContentsBase64 = $someString
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	isLiveMount = $someBoolean
    /// 	# REQUIRED
    /// 	dbId = $someString
    /// 	# OPTIONAL
    /// 	isDifferentTargetDbName = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ValidateOracleAcoFileReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ValidateDatabaseBackups operation
    /// of the 'Oracle' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Oracle
    /// # API Operation: ValidateDatabaseBackups
    /// 
    /// $query = New-RscMutationOracle -ValidateDatabaseBackups
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		numChannels = $someInt
    /// 		# OPTIONAL
    /// 		sgaMaxSizeInMb = $someInt64
    /// 		# OPTIONAL
    /// 		targetMountPath = $someString
    /// 		# OPTIONAL
    /// 		targetOracleHome = $someString
    /// 		# REQUIRED
    /// 		recoveryPoint = @{
    /// 			# OPTIONAL
    /// 			snapshotId = $someString
    /// 			# OPTIONAL
    /// 			timestampMs = $someInt64
    /// 		}
    /// 		# REQUIRED
    /// 		targetOracleHostOrRacId = $someString
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
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationOracle",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationOracle : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "BulkUpdateDatabases",
                "BulkUpdateHosts",
                "BulkUpdateRacs",
                "CreatePdbRestore",
                "DeleteAllDatabaseSnapshots",
                "DeleteMount",
                "DownloadDatabaseSnapshot",
                "ExportDatabase",
                "ExportTablespace",
                "InstantRecoverSnapshot",
                "MountDatabase",
                "RefreshDatabase",
                "RestoreLogs",
                "TakeOnDemandDatabaseSnapshot",
                "TakeOnDemandLogSnapshot",
                "UpdateDataGuardGroup",
                "ValidateAcoFile",
                "ValidateDatabaseBackups",
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
                    case "BulkUpdateDatabases":
                        this.ProcessRecord_BulkUpdateDatabases();
                        break;
                    case "BulkUpdateHosts":
                        this.ProcessRecord_BulkUpdateHosts();
                        break;
                    case "BulkUpdateRacs":
                        this.ProcessRecord_BulkUpdateRacs();
                        break;
                    case "CreatePdbRestore":
                        this.ProcessRecord_CreatePdbRestore();
                        break;
                    case "DeleteAllDatabaseSnapshots":
                        this.ProcessRecord_DeleteAllDatabaseSnapshots();
                        break;
                    case "DeleteMount":
                        this.ProcessRecord_DeleteMount();
                        break;
                    case "DownloadDatabaseSnapshot":
                        this.ProcessRecord_DownloadDatabaseSnapshot();
                        break;
                    case "ExportDatabase":
                        this.ProcessRecord_ExportDatabase();
                        break;
                    case "ExportTablespace":
                        this.ProcessRecord_ExportTablespace();
                        break;
                    case "InstantRecoverSnapshot":
                        this.ProcessRecord_InstantRecoverSnapshot();
                        break;
                    case "MountDatabase":
                        this.ProcessRecord_MountDatabase();
                        break;
                    case "RefreshDatabase":
                        this.ProcessRecord_RefreshDatabase();
                        break;
                    case "RestoreLogs":
                        this.ProcessRecord_RestoreLogs();
                        break;
                    case "TakeOnDemandDatabaseSnapshot":
                        this.ProcessRecord_TakeOnDemandDatabaseSnapshot();
                        break;
                    case "TakeOnDemandLogSnapshot":
                        this.ProcessRecord_TakeOnDemandLogSnapshot();
                        break;
                    case "UpdateDataGuardGroup":
                        this.ProcessRecord_UpdateDataGuardGroup();
                        break;
                    case "ValidateAcoFile":
                        this.ProcessRecord_ValidateAcoFile();
                        break;
                    case "ValidateDatabaseBackups":
                        this.ProcessRecord_ValidateDatabaseBackups();
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
        // bulkUpdateOracleDatabases.
        internal void ProcessRecord_BulkUpdateDatabases()
        {
            this._logger.name += " -BulkUpdateDatabases";
            // Create new graphql operation bulkUpdateOracleDatabases
            InitMutationBulkUpdateOracleDatabases();
        }

        // This parameter set invokes a single graphql operation:
        // bulkUpdateOracleHosts.
        internal void ProcessRecord_BulkUpdateHosts()
        {
            this._logger.name += " -BulkUpdateHosts";
            // Create new graphql operation bulkUpdateOracleHosts
            InitMutationBulkUpdateOracleHosts();
        }

        // This parameter set invokes a single graphql operation:
        // bulkUpdateOracleRacs.
        internal void ProcessRecord_BulkUpdateRacs()
        {
            this._logger.name += " -BulkUpdateRacs";
            // Create new graphql operation bulkUpdateOracleRacs
            InitMutationBulkUpdateOracleRacs();
        }

        // This parameter set invokes a single graphql operation:
        // createOraclePdbRestore.
        internal void ProcessRecord_CreatePdbRestore()
        {
            this._logger.name += " -CreatePdbRestore";
            // Create new graphql operation createOraclePdbRestore
            InitMutationCreateOraclePdbRestore();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAllOracleDatabaseSnapshots.
        internal void ProcessRecord_DeleteAllDatabaseSnapshots()
        {
            this._logger.name += " -DeleteAllDatabaseSnapshots";
            // Create new graphql operation deleteAllOracleDatabaseSnapshots
            InitMutationDeleteAllOracleDatabaseSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // deleteOracleMount.
        internal void ProcessRecord_DeleteMount()
        {
            this._logger.name += " -DeleteMount";
            // Create new graphql operation deleteOracleMount
            InitMutationDeleteOracleMount();
        }

        // This parameter set invokes a single graphql operation:
        // downloadOracleDatabaseSnapshot.
        internal void ProcessRecord_DownloadDatabaseSnapshot()
        {
            this._logger.name += " -DownloadDatabaseSnapshot";
            // Create new graphql operation downloadOracleDatabaseSnapshot
            InitMutationDownloadOracleDatabaseSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // exportOracleDatabase.
        internal void ProcessRecord_ExportDatabase()
        {
            this._logger.name += " -ExportDatabase";
            // Create new graphql operation exportOracleDatabase
            InitMutationExportOracleDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // exportOracleTablespace.
        internal void ProcessRecord_ExportTablespace()
        {
            this._logger.name += " -ExportTablespace";
            // Create new graphql operation exportOracleTablespace
            InitMutationExportOracleTablespace();
        }

        // This parameter set invokes a single graphql operation:
        // instantRecoverOracleSnapshot.
        internal void ProcessRecord_InstantRecoverSnapshot()
        {
            this._logger.name += " -InstantRecoverSnapshot";
            // Create new graphql operation instantRecoverOracleSnapshot
            InitMutationInstantRecoverOracleSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // mountOracleDatabase.
        internal void ProcessRecord_MountDatabase()
        {
            this._logger.name += " -MountDatabase";
            // Create new graphql operation mountOracleDatabase
            InitMutationMountOracleDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // refreshOracleDatabase.
        internal void ProcessRecord_RefreshDatabase()
        {
            this._logger.name += " -RefreshDatabase";
            // Create new graphql operation refreshOracleDatabase
            InitMutationRefreshOracleDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // restoreOracleLogs.
        internal void ProcessRecord_RestoreLogs()
        {
            this._logger.name += " -RestoreLogs";
            // Create new graphql operation restoreOracleLogs
            InitMutationRestoreOracleLogs();
        }

        // This parameter set invokes a single graphql operation:
        // takeOnDemandOracleDatabaseSnapshot.
        internal void ProcessRecord_TakeOnDemandDatabaseSnapshot()
        {
            this._logger.name += " -TakeOnDemandDatabaseSnapshot";
            // Create new graphql operation takeOnDemandOracleDatabaseSnapshot
            InitMutationTakeOnDemandOracleDatabaseSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // takeOnDemandOracleLogSnapshot.
        internal void ProcessRecord_TakeOnDemandLogSnapshot()
        {
            this._logger.name += " -TakeOnDemandLogSnapshot";
            // Create new graphql operation takeOnDemandOracleLogSnapshot
            InitMutationTakeOnDemandOracleLogSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // updateOracleDataGuardGroup.
        internal void ProcessRecord_UpdateDataGuardGroup()
        {
            this._logger.name += " -UpdateDataGuardGroup";
            // Create new graphql operation updateOracleDataGuardGroup
            InitMutationUpdateOracleDataGuardGroup();
        }

        // This parameter set invokes a single graphql operation:
        // validateOracleAcoFile.
        internal void ProcessRecord_ValidateAcoFile()
        {
            this._logger.name += " -ValidateAcoFile";
            // Create new graphql operation validateOracleAcoFile
            InitMutationValidateOracleAcoFile();
        }

        // This parameter set invokes a single graphql operation:
        // validateOracleDatabaseBackups.
        internal void ProcessRecord_ValidateDatabaseBackups()
        {
            this._logger.name += " -ValidateDatabaseBackups";
            // Create new graphql operation validateOracleDatabaseBackups
            InitMutationValidateOracleDatabaseBackups();
        }


        // Create new GraphQL Mutation:
        // bulkUpdateOracleDatabases(input: BulkUpdateOracleDatabasesInput!): BulkUpdateOracleDatabasesReply!
        internal void InitMutationBulkUpdateOracleDatabases()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkUpdateOracleDatabasesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkUpdateOracleDatabases",
                "($input: BulkUpdateOracleDatabasesInput!)",
                "BulkUpdateOracleDatabasesReply",
                Mutation.BulkUpdateOracleDatabases_ObjectFieldSpec,
                Mutation.BulkUpdateOracleDatabasesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	bulkUpdateProperties = @{
		# REQUIRED
		ids = @(
			$someString
		)
		# OPTIONAL
		oracleUpdate = @{
			# OPTIONAL
			configuredSlaDomainId = $someString
			# OPTIONAL
			hostMount = $someString
			# OPTIONAL
			logBackupFrequencyInMinutes = $someInt
			# OPTIONAL
			logRetentionHours = $someInt
			# OPTIONAL
			numChannels = $someInt
			# OPTIONAL
			hostLogRetentionHours = $someInt
			# OPTIONAL
			configuredSlaDomainIdDeprecated = $someString
			# OPTIONAL
			shouldDistributeBackupsAutomatically = $someBoolean
			# OPTIONAL
			nodeOrder = @(
				@{
					# REQUIRED
					nodeName = $someString
					# REQUIRED
					order = $someInt
				}
			)
			# OPTIONAL
			oracleUpdateCommon = @{
				# OPTIONAL
				hostLogRetentionHours = $someInt
				# OPTIONAL
				hostMount = $someString
				# OPTIONAL
				logBackupFrequencyInMinutes = $someInt
				# OPTIONAL
				logRetentionHours = $someInt
				# OPTIONAL
				numChannels = $someInt
				# OPTIONAL
				hasLogConfigFromSla = $someBoolean
				# OPTIONAL
				shouldEnableHighFileCountSupport = $someBoolean
				# OPTIONAL
				shouldUseSecureThriftForDataTransfer = $someBoolean
				# OPTIONAL
				sectionSizeInGb = $someInt
				# OPTIONAL
				isPaused = $someBoolean
			}
		}
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkUpdateOracleHosts(input: BulkUpdateOracleHostsInput!): BulkUpdateOracleHostsReply!
        internal void InitMutationBulkUpdateOracleHosts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkUpdateOracleHostsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkUpdateOracleHosts",
                "($input: BulkUpdateOracleHostsInput!)",
                "BulkUpdateOracleHostsReply",
                Mutation.BulkUpdateOracleHosts_ObjectFieldSpec,
                Mutation.BulkUpdateOracleHostsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	bulkUpdateProperties = @{
		# REQUIRED
		ids = @(
			$someString
		)
		# OPTIONAL
		oracleUpdate = @{
			# OPTIONAL
			configuredSlaDomainId = $someString
			# OPTIONAL
			hostMount = $someString
			# OPTIONAL
			logBackupFrequencyInMinutes = $someInt
			# OPTIONAL
			logRetentionHours = $someInt
			# OPTIONAL
			numChannels = $someInt
			# OPTIONAL
			hostLogRetentionHours = $someInt
			# OPTIONAL
			configuredSlaDomainIdDeprecated = $someString
			# OPTIONAL
			shouldDistributeBackupsAutomatically = $someBoolean
			# OPTIONAL
			nodeOrder = @(
				@{
					# REQUIRED
					nodeName = $someString
					# REQUIRED
					order = $someInt
				}
			)
			# OPTIONAL
			oracleUpdateCommon = @{
				# OPTIONAL
				hostLogRetentionHours = $someInt
				# OPTIONAL
				hostMount = $someString
				# OPTIONAL
				logBackupFrequencyInMinutes = $someInt
				# OPTIONAL
				logRetentionHours = $someInt
				# OPTIONAL
				numChannels = $someInt
				# OPTIONAL
				hasLogConfigFromSla = $someBoolean
				# OPTIONAL
				shouldEnableHighFileCountSupport = $someBoolean
				# OPTIONAL
				shouldUseSecureThriftForDataTransfer = $someBoolean
				# OPTIONAL
				sectionSizeInGb = $someInt
				# OPTIONAL
				isPaused = $someBoolean
			}
		}
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkUpdateOracleRacs(input: BulkUpdateOracleRacsInput!): BulkUpdateOracleRacsReply!
        internal void InitMutationBulkUpdateOracleRacs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkUpdateOracleRacsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkUpdateOracleRacs",
                "($input: BulkUpdateOracleRacsInput!)",
                "BulkUpdateOracleRacsReply",
                Mutation.BulkUpdateOracleRacs_ObjectFieldSpec,
                Mutation.BulkUpdateOracleRacsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	bulkUpdateProperties = @{
		# REQUIRED
		ids = @(
			$someString
		)
		# OPTIONAL
		oracleUpdate = @{
			# OPTIONAL
			configuredSlaDomainId = $someString
			# OPTIONAL
			hostMount = $someString
			# OPTIONAL
			logBackupFrequencyInMinutes = $someInt
			# OPTIONAL
			logRetentionHours = $someInt
			# OPTIONAL
			numChannels = $someInt
			# OPTIONAL
			hostLogRetentionHours = $someInt
			# OPTIONAL
			configuredSlaDomainIdDeprecated = $someString
			# OPTIONAL
			shouldDistributeBackupsAutomatically = $someBoolean
			# OPTIONAL
			nodeOrder = @(
				@{
					# REQUIRED
					nodeName = $someString
					# REQUIRED
					order = $someInt
				}
			)
			# OPTIONAL
			oracleUpdateCommon = @{
				# OPTIONAL
				hostLogRetentionHours = $someInt
				# OPTIONAL
				hostMount = $someString
				# OPTIONAL
				logBackupFrequencyInMinutes = $someInt
				# OPTIONAL
				logRetentionHours = $someInt
				# OPTIONAL
				numChannels = $someInt
				# OPTIONAL
				hasLogConfigFromSla = $someBoolean
				# OPTIONAL
				shouldEnableHighFileCountSupport = $someBoolean
				# OPTIONAL
				shouldUseSecureThriftForDataTransfer = $someBoolean
				# OPTIONAL
				sectionSizeInGb = $someInt
				# OPTIONAL
				isPaused = $someBoolean
			}
		}
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createOraclePdbRestore(input: CreateOraclePdbRestoreInput!): AsyncRequestStatus!
        internal void InitMutationCreateOraclePdbRestore()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateOraclePdbRestoreInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateOraclePdbRestore",
                "($input: CreateOraclePdbRestoreInput!)",
                "AsyncRequestStatus",
                Mutation.CreateOraclePdbRestore_ObjectFieldSpec,
                Mutation.CreateOraclePdbRestoreFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		pdbsToRestore = @(
			$someString
		)
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			snapshotId = $someString
			# OPTIONAL
			timestampMs = $someInt64
		}
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteAllOracleDatabaseSnapshots(input: DeleteAllOracleDatabaseSnapshotsInput!): Void
        internal void InitMutationDeleteAllOracleDatabaseSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAllOracleDatabaseSnapshotsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteAllOracleDatabaseSnapshots",
                "($input: DeleteAllOracleDatabaseSnapshotsInput!)",
                "System.String",
                Mutation.DeleteAllOracleDatabaseSnapshots_ObjectFieldSpec,
                Mutation.DeleteAllOracleDatabaseSnapshotsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteOracleMount(input: DeleteOracleMountInput!): AsyncRequestStatus!
        internal void InitMutationDeleteOracleMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteOracleMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteOracleMount",
                "($input: DeleteOracleMountInput!)",
                "AsyncRequestStatus",
                Mutation.DeleteOracleMount_ObjectFieldSpec,
                Mutation.DeleteOracleMountFieldSpec,
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
        // downloadOracleDatabaseSnapshot(input: DownloadOracleDatabaseSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationDownloadOracleDatabaseSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadOracleDatabaseSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadOracleDatabaseSnapshot",
                "($input: DownloadOracleDatabaseSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadOracleDatabaseSnapshot_ObjectFieldSpec,
                Mutation.DownloadOracleDatabaseSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // exportOracleDatabase(input: ExportOracleDatabaseInput!): AsyncRequestStatus!
        internal void InitMutationExportOracleDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportOracleDatabaseInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExportOracleDatabase",
                "($input: ExportOracleDatabaseInput!)",
                "AsyncRequestStatus",
                Mutation.ExportOracleDatabase_ObjectFieldSpec,
                Mutation.ExportOracleDatabaseFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	request = @{
		# REQUIRED
		config = @{
			# OPTIONAL
			restoreFilesPath = $someString
			# OPTIONAL
			shouldRestoreFilesOnly = $someBoolean
			# OPTIONAL
			targetMountPath = $someString
			# OPTIONAL
			advancedRecoveryConfigBase64 = $someString
			# OPTIONAL
			archiveLogPath = $someString
			# OPTIONAL
			cloneDbName = $someString
			# OPTIONAL
			customPfilePath = $someString
			# OPTIONAL
			numChannels = $someInt
			# OPTIONAL
			postScriptPath = $someString
			# OPTIONAL
			preScriptPath = $someString
			# OPTIONAL
			shouldStopRecoveryOnPreScriptFailure = $someBoolean
			# OPTIONAL
			pdbsToClone = @(
				$someString
			)
			# OPTIONAL
			shouldSkipDropDbInUndo = $someBoolean
			# OPTIONAL
			targetRacHostIds = @(
				$someString
			)
			# OPTIONAL
			targetRacPrimaryHostId = $someString
			# OPTIONAL
			shouldAllowRenameToSource = $someBoolean
			# REQUIRED
			recoveryPoint = @{
				# OPTIONAL
				snapshotId = $someString
				# OPTIONAL
				timestampMs = $someInt64
			}
			# REQUIRED
			targetOracleHostOrRacId = $someString
		}
		# REQUIRED
		id = $someString
	}
	# OPTIONAL
	advancedRecoveryConfigMap = @(
		@{
			# OPTIONAL
			key = $someString
			# OPTIONAL
			value = $someString
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // exportOracleTablespace(input: ExportOracleTablespaceInput!): AsyncRequestStatus!
        internal void InitMutationExportOracleTablespace()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportOracleTablespaceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExportOracleTablespace",
                "($input: ExportOracleTablespaceInput!)",
                "AsyncRequestStatus",
                Mutation.ExportOracleTablespace_ObjectFieldSpec,
                Mutation.ExportOracleTablespaceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		exposeAllLogs = $someBoolean
		# REQUIRED
		auxiliaryDestinationPath = $someString
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			snapshotId = $someString
			# OPTIONAL
			timestampMs = $someInt64
		}
		# REQUIRED
		tablespaceName = $someString
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // instantRecoverOracleSnapshot(input: InstantRecoverOracleSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationInstantRecoverOracleSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "InstantRecoverOracleSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationInstantRecoverOracleSnapshot",
                "($input: InstantRecoverOracleSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.InstantRecoverOracleSnapshot_ObjectFieldSpec,
                Mutation.InstantRecoverOracleSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		numChannels = $someInt
		# OPTIONAL
		shouldSkipDropDbInUndo = $someBoolean
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			snapshotId = $someString
			# OPTIONAL
			timestampMs = $someInt64
		}
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // mountOracleDatabase(input: MountOracleDatabaseInput!): AsyncRequestStatus!
        internal void InitMutationMountOracleDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MountOracleDatabaseInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationMountOracleDatabase",
                "($input: MountOracleDatabaseInput!)",
                "AsyncRequestStatus",
                Mutation.MountOracleDatabase_ObjectFieldSpec,
                Mutation.MountOracleDatabaseFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	request = @{
		# REQUIRED
		config = @{
			# OPTIONAL
			shouldMountFilesOnly = $someBoolean
			# OPTIONAL
			targetMountPath = $someString
			# OPTIONAL
			advancedRecoveryConfigBase64 = $someString
			# OPTIONAL
			customPfilePath = $someString
			# OPTIONAL
			numChannels = $someInt
			# OPTIONAL
			postScriptPath = $someString
			# OPTIONAL
			preScriptPath = $someString
			# OPTIONAL
			shouldStopRecoveryOnPreScriptFailure = $someBoolean
			# OPTIONAL
			pdbsToLiveMount = @(
				$someString
			)
			# OPTIONAL
			targetRacHostIds = @(
				$someString
			)
			# OPTIONAL
			shouldSkipDropDbInUndo = $someBoolean
			# OPTIONAL
			lmDbName = $someString
			# OPTIONAL
			targetRacPrimaryHostId = $someString
			# OPTIONAL
			shouldAllowRenameToSource = $someBoolean
			# REQUIRED
			recoveryPoint = @{
				# OPTIONAL
				snapshotId = $someString
				# OPTIONAL
				timestampMs = $someInt64
			}
			# REQUIRED
			targetOracleHostOrRacId = $someString
		}
		# REQUIRED
		id = $someString
	}
	# OPTIONAL
	advancedRecoveryConfigMap = @(
		@{
			# OPTIONAL
			key = $someString
			# OPTIONAL
			value = $someString
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // refreshOracleDatabase(input: RefreshOracleDatabaseInput!): AsyncRequestStatus!
        internal void InitMutationRefreshOracleDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshOracleDatabaseInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshOracleDatabase",
                "($input: RefreshOracleDatabaseInput!)",
                "AsyncRequestStatus",
                Mutation.RefreshOracleDatabase_ObjectFieldSpec,
                Mutation.RefreshOracleDatabaseFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // restoreOracleLogs(input: RestoreOracleLogsInput!): AsyncRequestStatus!
        internal void InitMutationRestoreOracleLogs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreOracleLogsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreOracleLogs",
                "($input: RestoreOracleLogsInput!)",
                "AsyncRequestStatus",
                Mutation.RestoreOracleLogs_ObjectFieldSpec,
                Mutation.RestoreOracleLogsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		targetMountPath = $someString
		# REQUIRED
		oracleLogRecoveryRange = @{
			# OPTIONAL
			oracleTimeRange = @{
				# OPTIONAL
				endTime = $someDateTime
				# OPTIONAL
				startTime = $someDateTime
			}
		}
		# REQUIRED
		shouldMountFilesOnly = $someBoolean
		# REQUIRED
		targetOracleHostOrRacId = $someString
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // takeOnDemandOracleDatabaseSnapshot(input: TakeOnDemandOracleDatabaseSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationTakeOnDemandOracleDatabaseSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "TakeOnDemandOracleDatabaseSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationTakeOnDemandOracleDatabaseSnapshot",
                "($input: TakeOnDemandOracleDatabaseSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.TakeOnDemandOracleDatabaseSnapshot_ObjectFieldSpec,
                Mutation.TakeOnDemandOracleDatabaseSnapshotFieldSpec,
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
        // takeOnDemandOracleLogSnapshot(input: TakeOnDemandOracleLogSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationTakeOnDemandOracleLogSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "TakeOnDemandOracleLogSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationTakeOnDemandOracleLogSnapshot",
                "($input: TakeOnDemandOracleLogSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.TakeOnDemandOracleLogSnapshot_ObjectFieldSpec,
                Mutation.TakeOnDemandOracleLogSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateOracleDataGuardGroup(input: UpdateOracleDataGuardGroupInput!): OracleDbDetail!
        internal void InitMutationUpdateOracleDataGuardGroup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateOracleDataGuardGroupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateOracleDataGuardGroup",
                "($input: UpdateOracleDataGuardGroupInput!)",
                "OracleDbDetail",
                Mutation.UpdateOracleDataGuardGroup_ObjectFieldSpec,
                Mutation.UpdateOracleDataGuardGroupFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	updateProperties = @{
		# OPTIONAL
		preferredDgMemberUniqueNames = @(
			$someString
		)
		# OPTIONAL
		shouldBackupFromPrimaryOnly = $someBoolean
		# OPTIONAL
		shouldUseSepsWallet = $someBoolean
		# OPTIONAL
		shouldForceDisableDgDiscovery = $someBoolean
		# OPTIONAL
		oracleUpdateCommon = @{
			# OPTIONAL
			hostLogRetentionHours = $someInt
			# OPTIONAL
			hostMount = $someString
			# OPTIONAL
			logBackupFrequencyInMinutes = $someInt
			# OPTIONAL
			logRetentionHours = $someInt
			# OPTIONAL
			numChannels = $someInt
			# OPTIONAL
			hasLogConfigFromSla = $someBoolean
			# OPTIONAL
			shouldEnableHighFileCountSupport = $someBoolean
			# OPTIONAL
			shouldUseSecureThriftForDataTransfer = $someBoolean
			# OPTIONAL
			sectionSizeInGb = $someInt
			# OPTIONAL
			isPaused = $someBoolean
		}
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // validateOracleAcoFile(input: ValidateOracleAcoFileInput!): ValidateOracleAcoFileReply!
        internal void InitMutationValidateOracleAcoFile()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ValidateOracleAcoFileInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationValidateOracleAcoFile",
                "($input: ValidateOracleAcoFileInput!)",
                "ValidateOracleAcoFileReply",
                Mutation.ValidateOracleAcoFile_ObjectFieldSpec,
                Mutation.ValidateOracleAcoFileFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	acoContentsBase64 = $someString
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	isLiveMount = $someBoolean
	# REQUIRED
	dbId = $someString
	# OPTIONAL
	isDifferentTargetDbName = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // validateOracleDatabaseBackups(input: ValidateOracleDatabaseBackupsInput!): AsyncRequestStatus!
        internal void InitMutationValidateOracleDatabaseBackups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ValidateOracleDatabaseBackupsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationValidateOracleDatabaseBackups",
                "($input: ValidateOracleDatabaseBackupsInput!)",
                "AsyncRequestStatus",
                Mutation.ValidateOracleDatabaseBackups_ObjectFieldSpec,
                Mutation.ValidateOracleDatabaseBackupsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		numChannels = $someInt
		# OPTIONAL
		sgaMaxSizeInMb = $someInt64
		# OPTIONAL
		targetMountPath = $someString
		# OPTIONAL
		targetOracleHome = $someString
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			snapshotId = $someString
			# OPTIONAL
			timestampMs = $someInt64
		}
		# REQUIRED
		targetOracleHostOrRacId = $someString
	}
	# REQUIRED
	id = $someString
}"
            );
        }


    } // class New_RscMutationOracle
}