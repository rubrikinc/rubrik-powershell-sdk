// New-RscMutationSla.cs
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
    /// Create a new RscQuery object for any of the 10
    /// operations in the 'SLA' API domain:
    /// Assign, AssignRetentionToSnappables, AssignRetentionToSnapshots, AssignsForSnappableHierarchies, CreateGlobal, DeleteGlobal, ExportManagedVolumeSnapshot, GetPendingAssignments, Pause, or UpdateGlobal.
    /// </summary>
    /// <description>
    /// New-RscMutationSla creates a new
    /// mutation object for operations
    /// in the 'SLA' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 10 operations
    /// in the 'SLA' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: Assign, AssignRetentionToSnappables, AssignRetentionToSnapshots, AssignsForSnappableHierarchies, CreateGlobal, DeleteGlobal, ExportManagedVolumeSnapshot, GetPendingAssignments, Pause, or UpdateGlobal.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationSla -Assign).Info().
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
    /// (New-RscMutationSla -Assign).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the Assign operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: Assign
    /// 
    /// $query = New-RscMutationSla -Assign
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	slaDomainAssignType = $someSlaAssignTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaAssignTypeEnum]) for enum values.
    /// 	# OPTIONAL
    /// 	slaOptionalId = $someString
    /// 	# REQUIRED
    /// 	objectIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	applicableWorkloadType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// 	# OPTIONAL
    /// 	shouldApplyToExistingSnapshots = $someBoolean
    /// 	# OPTIONAL
    /// 	shouldApplyToNonPolicySnapshots = $someBoolean
    /// 	# OPTIONAL
    /// 	existingSnapshotRetention = $someGlobalExistingSnapshotRetention # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalExistingSnapshotRetention]) for enum values.
    /// 	# OPTIONAL
    /// 	userNote = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SlaAssignResult
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AssignRetentionToSnappables operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: AssignRetentionToSnappables
    /// 
    /// $query = New-RscMutationSla -AssignRetentionToSnappables
    /// 
    /// # OPTIONAL
    /// $query.Var.globalSlaOptionalFid = $someString
    /// # REQUIRED
    /// $query.Var.globalSlaAssignType = $someSlaAssignTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaAssignTypeEnum]) for enum values.
    /// # REQUIRED
    /// $query.Var.objectIds = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.applicableSnappableType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.shouldApplyToNonPolicySnapshots = $someBoolean
    /// # OPTIONAL
    /// $query.Var.userNote = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SlaAssignResult
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AssignRetentionToSnapshots operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: AssignRetentionToSnapshots
    /// 
    /// $query = New-RscMutationSla -AssignRetentionToSnapshots
    /// 
    /// # OPTIONAL
    /// $query.Var.globalSlaOptionalFid = $someString
    /// # REQUIRED
    /// $query.Var.globalSlaAssignType = $someSlaAssignTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaAssignTypeEnum]) for enum values.
    /// # REQUIRED
    /// $query.Var.snapshotFids = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.userNote = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SlaAssignResult
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AssignsForSnappableHierarchies operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: AssignsForSnappableHierarchies
    /// 
    /// $query = New-RscMutationSla -AssignsForSnappableHierarchies
    /// 
    /// # OPTIONAL
    /// $query.Var.globalSlaOptionalFid = $someString
    /// # REQUIRED
    /// $query.Var.globalSlaAssignType = $someSlaAssignTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaAssignTypeEnum]) for enum values.
    /// # REQUIRED
    /// $query.Var.objectIds = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.applicableSnappableTypes = @(
    /// 	$someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.shouldApplyToExistingSnapshots = $someBoolean
    /// # OPTIONAL
    /// $query.Var.shouldApplyToNonPolicySnapshots = $someBoolean
    /// # OPTIONAL
    /// $query.Var.globalExistingSnapshotRetention = $someGlobalExistingSnapshotRetention # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalExistingSnapshotRetention]) for enum values.
    /// # OPTIONAL
    /// $query.Var.userNote = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;SlaAssignResult&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateGlobal operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: CreateGlobal
    /// 
    /// $query = New-RscMutationSla -CreateGlobal
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	description = $someString
    /// 	# OPTIONAL
    /// 	snapshotSchedule = @{
    /// 		# OPTIONAL
    /// 		minute = @{
    /// 			# OPTIONAL
    /// 			basicSchedule = @{
    /// 				# OPTIONAL
    /// 				frequency = $someInt
    /// 				# OPTIONAL
    /// 				retention = $someInt
    /// 				# OPTIONAL
    /// 				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		hourly = @{
    /// 			# OPTIONAL
    /// 			basicSchedule = @{
    /// 				# OPTIONAL
    /// 				frequency = $someInt
    /// 				# OPTIONAL
    /// 				retention = $someInt
    /// 				# OPTIONAL
    /// 				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		daily = @{
    /// 			# OPTIONAL
    /// 			basicSchedule = @{
    /// 				# OPTIONAL
    /// 				frequency = $someInt
    /// 				# OPTIONAL
    /// 				retention = $someInt
    /// 				# OPTIONAL
    /// 				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		weekly = @{
    /// 			# OPTIONAL
    /// 			basicSchedule = @{
    /// 				# OPTIONAL
    /// 				frequency = $someInt
    /// 				# OPTIONAL
    /// 				retention = $someInt
    /// 				# OPTIONAL
    /// 				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			dayOfWeek = $someDayOfWeek # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfWeek]) for enum values.
    /// 		}
    /// 		# OPTIONAL
    /// 		monthly = @{
    /// 			# OPTIONAL
    /// 			basicSchedule = @{
    /// 				# OPTIONAL
    /// 				frequency = $someInt
    /// 				# OPTIONAL
    /// 				retention = $someInt
    /// 				# OPTIONAL
    /// 				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			dayOfMonth = $someDayOfMonth # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfMonth]) for enum values.
    /// 		}
    /// 		# OPTIONAL
    /// 		quarterly = @{
    /// 			# OPTIONAL
    /// 			basicSchedule = @{
    /// 				# OPTIONAL
    /// 				frequency = $someInt
    /// 				# OPTIONAL
    /// 				retention = $someInt
    /// 				# OPTIONAL
    /// 				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			dayOfQuarter = $someDayOfQuarter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfQuarter]) for enum values.
    /// 			# OPTIONAL
    /// 			quarterStartMonth = $someMonth # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Month]) for enum values.
    /// 		}
    /// 		# OPTIONAL
    /// 		yearly = @{
    /// 			# OPTIONAL
    /// 			basicSchedule = @{
    /// 				# OPTIONAL
    /// 				frequency = $someInt
    /// 				# OPTIONAL
    /// 				retention = $someInt
    /// 				# OPTIONAL
    /// 				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			dayOfYear = $someDayOfYear # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfYear]) for enum values.
    /// 			# OPTIONAL
    /// 			yearStartMonth = $someMonth # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Month]) for enum values.
    /// 		}
    /// 	}
    /// 	# OPTIONAL
    /// 	replicationSpecInput = @{
    /// 		# OPTIONAL
    /// 		replicationType = $someReplicationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReplicationType]) for enum values.
    /// 		# OPTIONAL
    /// 		specificReplicationSpecInput = @{
    /// 			# OPTIONAL
    /// 			unidirectionalSpecInput = @{
    /// 				# OPTIONAL
    /// 				replicationTargetId = $someString
    /// 				# OPTIONAL
    /// 				retention = $someInt
    /// 				# OPTIONAL
    /// 				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			bidirectionalSpecInput = @{
    /// 				# OPTIONAL
    /// 				replicationSpec1 = @{
    /// 					# OPTIONAL
    /// 					replicationTargetId = $someString
    /// 					# OPTIONAL
    /// 					retention = $someInt
    /// 					# OPTIONAL
    /// 					retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 				}
    /// 				# OPTIONAL
    /// 				replicationSpec2 = @{
    /// 					# OPTIONAL
    /// 					replicationTargetId = $someString
    /// 					# OPTIONAL
    /// 					retention = $someInt
    /// 					# OPTIONAL
    /// 					retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 				}
    /// 			}
    /// 			# OPTIONAL
    /// 			cloudRegionSpecInput = @{
    /// 				# OPTIONAL
    /// 				replicationTargetRegion = $someString
    /// 				# OPTIONAL
    /// 				cloudProvider = $someCloudProvider # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudProvider]) for enum values.
    /// 				# OPTIONAL
    /// 				retention = $someInt
    /// 				# OPTIONAL
    /// 				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			cloudLocationSpecInput = @{
    /// 				# OPTIONAL
    /// 				replicationTargetId = $someString
    /// 				# OPTIONAL
    /// 				cloudProvider = $someCloudProvider # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudProvider]) for enum values.
    /// 				# OPTIONAL
    /// 				retentionDuration = @{
    /// 					# OPTIONAL
    /// 					duration = $someInt
    /// 					# OPTIONAL
    /// 					unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 				}
    /// 			}
    /// 		}
    /// 	}
    /// 	# OPTIONAL
    /// 	localRetentionLimit = @{
    /// 		# OPTIONAL
    /// 		duration = $someInt
    /// 		# OPTIONAL
    /// 		unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	firstFullBackupWindows = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			durationInHours = $someInt
    /// 			# OPTIONAL
    /// 			startTimeAttributes = @{
    /// 				# OPTIONAL
    /// 				dayOfWeek = @{
    /// 					# OPTIONAL
    /// 					day = $someDayOfWeek # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfWeek]) for enum values.
    /// 				}
    /// 				# OPTIONAL
    /// 				hour = $someInt
    /// 				# OPTIONAL
    /// 				minute = $someInt
    /// 			}
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	backupWindows = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			durationInHours = $someInt
    /// 			# OPTIONAL
    /// 			startTimeAttributes = @{
    /// 				# OPTIONAL
    /// 				dayOfWeek = @{
    /// 					# OPTIONAL
    /// 					day = $someDayOfWeek # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfWeek]) for enum values.
    /// 				}
    /// 				# OPTIONAL
    /// 				hour = $someInt
    /// 				# OPTIONAL
    /// 				minute = $someInt
    /// 			}
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	logConfig = @{
    /// 		# OPTIONAL
    /// 		slaLogFrequencyConfig = @{
    /// 			# OPTIONAL
    /// 			retention = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 		}
    /// 	}
    /// 	# OPTIONAL
    /// 	objectSpecificConfigsInput = @{
    /// 		# OPTIONAL
    /// 		sapHanaConfigInput = @{
    /// 			# OPTIONAL
    /// 			incrementalFrequency = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			logRetention = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			differentialFrequency = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			storageSnapshotConfig = @{
    /// 				# OPTIONAL
    /// 				frequency = @{
    /// 					# OPTIONAL
    /// 					duration = $someInt
    /// 					# OPTIONAL
    /// 					unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 				}
    /// 				# OPTIONAL
    /// 				retention = @{
    /// 					# OPTIONAL
    /// 					duration = $someInt
    /// 					# OPTIONAL
    /// 					unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 				}
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		awsRdsConfigInput = @{
    /// 			# OPTIONAL
    /// 			logRetention = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		vmwareVmConfigInput = @{
    /// 			# OPTIONAL
    /// 			logRetentionSeconds = $someInt64
    /// 		}
    /// 		# OPTIONAL
    /// 		azureSqlDatabaseDbConfigInput = @{
    /// 			# OPTIONAL
    /// 			logRetentionInDays = $someInt
    /// 		}
    /// 		# OPTIONAL
    /// 		azureSqlManagedInstanceDbConfigInput = @{
    /// 			# OPTIONAL
    /// 			logRetentionInDays = $someInt
    /// 		}
    /// 		# OPTIONAL
    /// 		db2ConfigInput = @{
    /// 			# OPTIONAL
    /// 			incrementalFrequency = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			logRetention = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			differentialFrequency = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		mssqlConfigInput = @{
    /// 			# OPTIONAL
    /// 			frequency = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			logRetention = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		oracleConfigInput = @{
    /// 			# OPTIONAL
    /// 			frequency = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			logRetention = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			hostLogRetention = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		mongoConfigInput = @{
    /// 			# OPTIONAL
    /// 			logFrequency = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			logRetention = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		azureBlobConfigInput = @{
    /// 			# OPTIONAL
    /// 			continuousBackupRetentionInDays = $someInt
    /// 			# OPTIONAL
    /// 			backupLocationId = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		awsNativeS3SlaConfigInput = @{
    /// 			# OPTIONAL
    /// 			archivalLocationId = $someString
    /// 			# OPTIONAL
    /// 			continuousBackupRetentionInDays = $someInt
    /// 		}
    /// 		# OPTIONAL
    /// 		managedVolumeSlaConfigInput = @{
    /// 			# OPTIONAL
    /// 			logRetention = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		postgresDbClusterSlaConfigInput = @{
    /// 			# OPTIONAL
    /// 			logRetention = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 		}
    /// 	}
    /// 	# OPTIONAL
    /// 	archivalSpecs = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			archivalGroupId = $someString
    /// 			# OPTIONAL
    /// 			threshold = $someInt
    /// 			# OPTIONAL
    /// 			thresholdUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			# OPTIONAL
    /// 			archivalTieringSpecInput = @{
    /// 				# OPTIONAL
    /// 				isInstantTieringEnabled = $someBoolean
    /// 				# OPTIONAL
    /// 				minAccessibleDurationInSeconds = $someInt64
    /// 				# OPTIONAL
    /// 				coldStorageClass = $someColdStorageClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ColdStorageClass]) for enum values.
    /// 				# OPTIONAL
    /// 				shouldTierExistingSnapshots = $someBoolean
    /// 			}
    /// 			# OPTIONAL
    /// 			frequencies = @(
    /// 				$someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			archivalLocationToClusterMapping = @(
    /// 				@{
    /// 					# OPTIONAL
    /// 					clusterUuid = $someString
    /// 					# OPTIONAL
    /// 					locationId = $someString
    /// 				}
    /// 			)
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	replicationSpecsV2 = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			clusterUuid = $someString
    /// 			# OPTIONAL
    /// 			storageSettingId = $someString
    /// 			# OPTIONAL
    /// 			retentionDuration = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			awsAccount = $someString
    /// 			# OPTIONAL
    /// 			azureSubscription = $someString
    /// 			# OPTIONAL
    /// 			replicationLocalRetentionDuration = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			cascadingArchivalSpecs = @(
    /// 				@{
    /// 					# OPTIONAL
    /// 					archivalLocationId = $someString
    /// 					# OPTIONAL
    /// 					archivalThreshold = @{
    /// 						# OPTIONAL
    /// 						duration = $someInt
    /// 						# OPTIONAL
    /// 						unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 					}
    /// 					# OPTIONAL
    /// 					archivalTieringSpecInput = @{
    /// 						# OPTIONAL
    /// 						isInstantTieringEnabled = $someBoolean
    /// 						# OPTIONAL
    /// 						minAccessibleDurationInSeconds = $someInt64
    /// 						# OPTIONAL
    /// 						coldStorageClass = $someColdStorageClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ColdStorageClass]) for enum values.
    /// 						# OPTIONAL
    /// 						shouldTierExistingSnapshots = $someBoolean
    /// 					}
    /// 					# OPTIONAL
    /// 					frequency = @(
    /// 						$someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 					)
    /// 				}
    /// 			)
    /// 			# OPTIONAL
    /// 			awsRegion = $someAwsNativeRegionForReplication # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegionForReplication]) for enum values.
    /// 			# OPTIONAL
    /// 			azureRegion = $someAzureNativeRegionForReplication # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegionForReplication]) for enum values.
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	objectTypes = @(
    /// 		$someSlaObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaObjectType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	isRetentionLockedSla = $someBoolean
    /// 	# OPTIONAL
    /// 	retentionLockMode = $someRetentionLockMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionLockMode]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GlobalSlaReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteGlobal operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: DeleteGlobal
    /// 
    /// $query = New-RscMutationSla -DeleteGlobal
    /// 
    /// # REQUIRED
    /// $query.Var.id = $someString
    /// # OPTIONAL
    /// $query.Var.userNote = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SlaResult
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ExportManagedVolumeSnapshot operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: ExportManagedVolumeSnapshot
    /// 
    /// $query = New-RscMutationSla -ExportManagedVolumeSnapshot
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
    /// 		managedVolumeSlaExportConfig = @{
    /// 			# OPTIONAL
    /// 			managedVolumeExportConfig = @{
    /// 				# OPTIONAL
    /// 				subnet = $someString
    /// 				# OPTIONAL
    /// 				managedVolumePatchConfig = @{
    /// 					# OPTIONAL
    /// 					hostPatterns = @(
    /// 						$someString
    /// 					)
    /// 					# OPTIONAL
    /// 					nodeHint = @(
    /// 						$someString
    /// 					)
    /// 					# OPTIONAL
    /// 					smbDomainName = $someString
    /// 					# OPTIONAL
    /// 					smbValidIps = @(
    /// 						$someString
    /// 					)
    /// 					# OPTIONAL
    /// 					smbValidUsers = @(
    /// 						$someString
    /// 					)
    /// 				}
    /// 				# OPTIONAL
    /// 				shareType = $someManagedVolumeShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedVolumeShareType]) for enum values.
    /// 			}
    /// 			# REQUIRED
    /// 			hostId = $someString
    /// 			# REQUIRED
    /// 			hostMountPaths = @(
    /// 				$someString
    /// 			)
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
    /// Runs the GetPendingAssignments operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: GetPendingAssignments
    /// 
    /// $query = New-RscMutationSla -GetPendingAssignments
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	pendingAssignmentsRequest = @{
    /// 		# REQUIRED
    /// 		objectIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GetPendingSlaAssignmentsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Pause operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: Pause
    /// 
    /// $query = New-RscMutationSla -Pause
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	slaId = $someString
    /// 	# REQUIRED
    /// 	clusterUuids = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	pauseSla = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PauseSlaReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateGlobal operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: UpdateGlobal
    /// 
    /// $query = New-RscMutationSla -UpdateGlobal
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	description = $someString
    /// 	# OPTIONAL
    /// 	snapshotSchedule = @{
    /// 		# OPTIONAL
    /// 		minute = @{
    /// 			# OPTIONAL
    /// 			basicSchedule = @{
    /// 				# OPTIONAL
    /// 				frequency = $someInt
    /// 				# OPTIONAL
    /// 				retention = $someInt
    /// 				# OPTIONAL
    /// 				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		hourly = @{
    /// 			# OPTIONAL
    /// 			basicSchedule = @{
    /// 				# OPTIONAL
    /// 				frequency = $someInt
    /// 				# OPTIONAL
    /// 				retention = $someInt
    /// 				# OPTIONAL
    /// 				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		daily = @{
    /// 			# OPTIONAL
    /// 			basicSchedule = @{
    /// 				# OPTIONAL
    /// 				frequency = $someInt
    /// 				# OPTIONAL
    /// 				retention = $someInt
    /// 				# OPTIONAL
    /// 				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		weekly = @{
    /// 			# OPTIONAL
    /// 			basicSchedule = @{
    /// 				# OPTIONAL
    /// 				frequency = $someInt
    /// 				# OPTIONAL
    /// 				retention = $someInt
    /// 				# OPTIONAL
    /// 				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			dayOfWeek = $someDayOfWeek # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfWeek]) for enum values.
    /// 		}
    /// 		# OPTIONAL
    /// 		monthly = @{
    /// 			# OPTIONAL
    /// 			basicSchedule = @{
    /// 				# OPTIONAL
    /// 				frequency = $someInt
    /// 				# OPTIONAL
    /// 				retention = $someInt
    /// 				# OPTIONAL
    /// 				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			dayOfMonth = $someDayOfMonth # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfMonth]) for enum values.
    /// 		}
    /// 		# OPTIONAL
    /// 		quarterly = @{
    /// 			# OPTIONAL
    /// 			basicSchedule = @{
    /// 				# OPTIONAL
    /// 				frequency = $someInt
    /// 				# OPTIONAL
    /// 				retention = $someInt
    /// 				# OPTIONAL
    /// 				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			dayOfQuarter = $someDayOfQuarter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfQuarter]) for enum values.
    /// 			# OPTIONAL
    /// 			quarterStartMonth = $someMonth # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Month]) for enum values.
    /// 		}
    /// 		# OPTIONAL
    /// 		yearly = @{
    /// 			# OPTIONAL
    /// 			basicSchedule = @{
    /// 				# OPTIONAL
    /// 				frequency = $someInt
    /// 				# OPTIONAL
    /// 				retention = $someInt
    /// 				# OPTIONAL
    /// 				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			dayOfYear = $someDayOfYear # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfYear]) for enum values.
    /// 			# OPTIONAL
    /// 			yearStartMonth = $someMonth # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Month]) for enum values.
    /// 		}
    /// 	}
    /// 	# OPTIONAL
    /// 	stateVersion = $someInt64
    /// 	# OPTIONAL
    /// 	replicationSpecInput = @{
    /// 		# OPTIONAL
    /// 		replicationType = $someReplicationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReplicationType]) for enum values.
    /// 		# OPTIONAL
    /// 		specificReplicationSpecInput = @{
    /// 			# OPTIONAL
    /// 			unidirectionalSpecInput = @{
    /// 				# OPTIONAL
    /// 				replicationTargetId = $someString
    /// 				# OPTIONAL
    /// 				retention = $someInt
    /// 				# OPTIONAL
    /// 				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			bidirectionalSpecInput = @{
    /// 				# OPTIONAL
    /// 				replicationSpec1 = @{
    /// 					# OPTIONAL
    /// 					replicationTargetId = $someString
    /// 					# OPTIONAL
    /// 					retention = $someInt
    /// 					# OPTIONAL
    /// 					retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 				}
    /// 				# OPTIONAL
    /// 				replicationSpec2 = @{
    /// 					# OPTIONAL
    /// 					replicationTargetId = $someString
    /// 					# OPTIONAL
    /// 					retention = $someInt
    /// 					# OPTIONAL
    /// 					retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 				}
    /// 			}
    /// 			# OPTIONAL
    /// 			cloudRegionSpecInput = @{
    /// 				# OPTIONAL
    /// 				replicationTargetRegion = $someString
    /// 				# OPTIONAL
    /// 				cloudProvider = $someCloudProvider # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudProvider]) for enum values.
    /// 				# OPTIONAL
    /// 				retention = $someInt
    /// 				# OPTIONAL
    /// 				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			cloudLocationSpecInput = @{
    /// 				# OPTIONAL
    /// 				replicationTargetId = $someString
    /// 				# OPTIONAL
    /// 				cloudProvider = $someCloudProvider # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudProvider]) for enum values.
    /// 				# OPTIONAL
    /// 				retentionDuration = @{
    /// 					# OPTIONAL
    /// 					duration = $someInt
    /// 					# OPTIONAL
    /// 					unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 				}
    /// 			}
    /// 		}
    /// 	}
    /// 	# OPTIONAL
    /// 	localRetentionLimit = @{
    /// 		# OPTIONAL
    /// 		duration = $someInt
    /// 		# OPTIONAL
    /// 		unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	firstFullBackupWindows = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			durationInHours = $someInt
    /// 			# OPTIONAL
    /// 			startTimeAttributes = @{
    /// 				# OPTIONAL
    /// 				dayOfWeek = @{
    /// 					# OPTIONAL
    /// 					day = $someDayOfWeek # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfWeek]) for enum values.
    /// 				}
    /// 				# OPTIONAL
    /// 				hour = $someInt
    /// 				# OPTIONAL
    /// 				minute = $someInt
    /// 			}
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	backupWindows = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			durationInHours = $someInt
    /// 			# OPTIONAL
    /// 			startTimeAttributes = @{
    /// 				# OPTIONAL
    /// 				dayOfWeek = @{
    /// 					# OPTIONAL
    /// 					day = $someDayOfWeek # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfWeek]) for enum values.
    /// 				}
    /// 				# OPTIONAL
    /// 				hour = $someInt
    /// 				# OPTIONAL
    /// 				minute = $someInt
    /// 			}
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	logConfig = @{
    /// 		# OPTIONAL
    /// 		slaLogFrequencyConfig = @{
    /// 			# OPTIONAL
    /// 			retention = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 		}
    /// 	}
    /// 	# OPTIONAL
    /// 	objectSpecificConfigsInput = @{
    /// 		# OPTIONAL
    /// 		sapHanaConfigInput = @{
    /// 			# OPTIONAL
    /// 			incrementalFrequency = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			logRetention = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			differentialFrequency = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			storageSnapshotConfig = @{
    /// 				# OPTIONAL
    /// 				frequency = @{
    /// 					# OPTIONAL
    /// 					duration = $someInt
    /// 					# OPTIONAL
    /// 					unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 				}
    /// 				# OPTIONAL
    /// 				retention = @{
    /// 					# OPTIONAL
    /// 					duration = $someInt
    /// 					# OPTIONAL
    /// 					unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 				}
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		awsRdsConfigInput = @{
    /// 			# OPTIONAL
    /// 			logRetention = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		vmwareVmConfigInput = @{
    /// 			# OPTIONAL
    /// 			logRetentionSeconds = $someInt64
    /// 		}
    /// 		# OPTIONAL
    /// 		azureSqlDatabaseDbConfigInput = @{
    /// 			# OPTIONAL
    /// 			logRetentionInDays = $someInt
    /// 		}
    /// 		# OPTIONAL
    /// 		azureSqlManagedInstanceDbConfigInput = @{
    /// 			# OPTIONAL
    /// 			logRetentionInDays = $someInt
    /// 		}
    /// 		# OPTIONAL
    /// 		db2ConfigInput = @{
    /// 			# OPTIONAL
    /// 			incrementalFrequency = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			logRetention = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			differentialFrequency = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		mssqlConfigInput = @{
    /// 			# OPTIONAL
    /// 			frequency = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			logRetention = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		oracleConfigInput = @{
    /// 			# OPTIONAL
    /// 			frequency = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			logRetention = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			hostLogRetention = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		mongoConfigInput = @{
    /// 			# OPTIONAL
    /// 			logFrequency = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			logRetention = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		azureBlobConfigInput = @{
    /// 			# OPTIONAL
    /// 			continuousBackupRetentionInDays = $someInt
    /// 			# OPTIONAL
    /// 			backupLocationId = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		awsNativeS3SlaConfigInput = @{
    /// 			# OPTIONAL
    /// 			archivalLocationId = $someString
    /// 			# OPTIONAL
    /// 			continuousBackupRetentionInDays = $someInt
    /// 		}
    /// 		# OPTIONAL
    /// 		managedVolumeSlaConfigInput = @{
    /// 			# OPTIONAL
    /// 			logRetention = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		postgresDbClusterSlaConfigInput = @{
    /// 			# OPTIONAL
    /// 			logRetention = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 		}
    /// 	}
    /// 	# OPTIONAL
    /// 	shouldApplyToExistingSnapshots = @{
    /// 		# OPTIONAL
    /// 		value = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	shouldApplyToNonPolicySnapshots = @{
    /// 		# OPTIONAL
    /// 		value = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	userNote = $someString
    /// 	# OPTIONAL
    /// 	archivalSpecs = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			archivalGroupId = $someString
    /// 			# OPTIONAL
    /// 			threshold = $someInt
    /// 			# OPTIONAL
    /// 			thresholdUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			# OPTIONAL
    /// 			archivalTieringSpecInput = @{
    /// 				# OPTIONAL
    /// 				isInstantTieringEnabled = $someBoolean
    /// 				# OPTIONAL
    /// 				minAccessibleDurationInSeconds = $someInt64
    /// 				# OPTIONAL
    /// 				coldStorageClass = $someColdStorageClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ColdStorageClass]) for enum values.
    /// 				# OPTIONAL
    /// 				shouldTierExistingSnapshots = $someBoolean
    /// 			}
    /// 			# OPTIONAL
    /// 			frequencies = @(
    /// 				$someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			archivalLocationToClusterMapping = @(
    /// 				@{
    /// 					# OPTIONAL
    /// 					clusterUuid = $someString
    /// 					# OPTIONAL
    /// 					locationId = $someString
    /// 				}
    /// 			)
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	replicationSpecsV2 = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			clusterUuid = $someString
    /// 			# OPTIONAL
    /// 			storageSettingId = $someString
    /// 			# OPTIONAL
    /// 			retentionDuration = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			awsAccount = $someString
    /// 			# OPTIONAL
    /// 			azureSubscription = $someString
    /// 			# OPTIONAL
    /// 			replicationLocalRetentionDuration = @{
    /// 				# OPTIONAL
    /// 				duration = $someInt
    /// 				# OPTIONAL
    /// 				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			cascadingArchivalSpecs = @(
    /// 				@{
    /// 					# OPTIONAL
    /// 					archivalLocationId = $someString
    /// 					# OPTIONAL
    /// 					archivalThreshold = @{
    /// 						# OPTIONAL
    /// 						duration = $someInt
    /// 						# OPTIONAL
    /// 						unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 					}
    /// 					# OPTIONAL
    /// 					archivalTieringSpecInput = @{
    /// 						# OPTIONAL
    /// 						isInstantTieringEnabled = $someBoolean
    /// 						# OPTIONAL
    /// 						minAccessibleDurationInSeconds = $someInt64
    /// 						# OPTIONAL
    /// 						coldStorageClass = $someColdStorageClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ColdStorageClass]) for enum values.
    /// 						# OPTIONAL
    /// 						shouldTierExistingSnapshots = $someBoolean
    /// 					}
    /// 					# OPTIONAL
    /// 					frequency = @(
    /// 						$someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 					)
    /// 				}
    /// 			)
    /// 			# OPTIONAL
    /// 			awsRegion = $someAwsNativeRegionForReplication # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegionForReplication]) for enum values.
    /// 			# OPTIONAL
    /// 			azureRegion = $someAzureNativeRegionForReplication # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegionForReplication]) for enum values.
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	objectTypes = @(
    /// 		$someSlaObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaObjectType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	isRetentionLockedSla = $someBoolean
    /// 	# OPTIONAL
    /// 	retentionLockMode = $someRetentionLockMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionLockMode]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GlobalSlaReply
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
        "RscMutationSla",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationSla : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "Assign",
                "AssignRetentionToSnappables",
                "AssignRetentionToSnapshots",
                "AssignsForSnappableHierarchies",
                "CreateGlobal",
                "DeleteGlobal",
                "ExportManagedVolumeSnapshot",
                "GetPendingAssignments",
                "Pause",
                "UpdateGlobal",
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
                    case "Assign":
                        this.ProcessRecord_Assign();
                        break;
                    case "AssignRetentionToSnappables":
                        this.ProcessRecord_AssignRetentionToSnappables();
                        break;
                    case "AssignRetentionToSnapshots":
                        this.ProcessRecord_AssignRetentionToSnapshots();
                        break;
                    case "AssignsForSnappableHierarchies":
                        this.ProcessRecord_AssignsForSnappableHierarchies();
                        break;
                    case "CreateGlobal":
                        this.ProcessRecord_CreateGlobal();
                        break;
                    case "DeleteGlobal":
                        this.ProcessRecord_DeleteGlobal();
                        break;
                    case "ExportManagedVolumeSnapshot":
                        this.ProcessRecord_ExportManagedVolumeSnapshot();
                        break;
                    case "GetPendingAssignments":
                        this.ProcessRecord_GetPendingAssignments();
                        break;
                    case "Pause":
                        this.ProcessRecord_Pause();
                        break;
                    case "UpdateGlobal":
                        this.ProcessRecord_UpdateGlobal();
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
        // assignSla.
        internal void ProcessRecord_Assign()
        {
            this._logger.name += " -Assign";
            // Create new graphql operation assignSla
            InitMutationAssignSla();
        }

        // This parameter set invokes a single graphql operation:
        // assignRetentionSLAToSnappables.
        internal void ProcessRecord_AssignRetentionToSnappables()
        {
            this._logger.name += " -AssignRetentionToSnappables";
            // Create new graphql operation assignRetentionSLAToSnappables
            InitMutationAssignRetentionSlaToSnappables();
        }

        // This parameter set invokes a single graphql operation:
        // assignRetentionSLAToSnapshots.
        internal void ProcessRecord_AssignRetentionToSnapshots()
        {
            this._logger.name += " -AssignRetentionToSnapshots";
            // Create new graphql operation assignRetentionSLAToSnapshots
            InitMutationAssignRetentionSlaToSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // assignSlasForSnappableHierarchies.
        internal void ProcessRecord_AssignsForSnappableHierarchies()
        {
            this._logger.name += " -AssignsForSnappableHierarchies";
            // Create new graphql operation assignSlasForSnappableHierarchies
            InitMutationAssignSlasForSnappableHierarchies();
        }

        // This parameter set invokes a single graphql operation:
        // createGlobalSla.
        internal void ProcessRecord_CreateGlobal()
        {
            this._logger.name += " -CreateGlobal";
            // Create new graphql operation createGlobalSla
            InitMutationCreateGlobalSla();
        }

        // This parameter set invokes a single graphql operation:
        // deleteGlobalSla.
        internal void ProcessRecord_DeleteGlobal()
        {
            this._logger.name += " -DeleteGlobal";
            // Create new graphql operation deleteGlobalSla
            InitMutationDeleteGlobalSla();
        }

        // This parameter set invokes a single graphql operation:
        // exportSlaManagedVolumeSnapshot.
        internal void ProcessRecord_ExportManagedVolumeSnapshot()
        {
            this._logger.name += " -ExportManagedVolumeSnapshot";
            // Create new graphql operation exportSlaManagedVolumeSnapshot
            InitMutationExportSlaManagedVolumeSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // getPendingSlaAssignments.
        internal void ProcessRecord_GetPendingAssignments()
        {
            this._logger.name += " -GetPendingAssignments";
            // Create new graphql operation getPendingSlaAssignments
            InitMutationGetPendingSlaAssignments();
        }

        // This parameter set invokes a single graphql operation:
        // pauseSla.
        internal void ProcessRecord_Pause()
        {
            this._logger.name += " -Pause";
            // Create new graphql operation pauseSla
            InitMutationPauseSla();
        }

        // This parameter set invokes a single graphql operation:
        // updateGlobalSla.
        internal void ProcessRecord_UpdateGlobal()
        {
            this._logger.name += " -UpdateGlobal";
            // Create new graphql operation updateGlobalSla
            InitMutationUpdateGlobalSla();
        }


        // Create new GraphQL Mutation:
        // assignSla(input: AssignSlaInput!): SlaAssignResult!
        internal void InitMutationAssignSla()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AssignSlaInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAssignSla",
                "($input: AssignSlaInput!)",
                "SlaAssignResult",
                Mutation.AssignSla_ObjectFieldSpec,
                Mutation.AssignSlaFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	slaDomainAssignType = $someSlaAssignTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaAssignTypeEnum]) for enum values.
	# OPTIONAL
	slaOptionalId = $someString
	# REQUIRED
	objectIds = @(
		$someString
	)
	# OPTIONAL
	applicableWorkloadType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
	# OPTIONAL
	shouldApplyToExistingSnapshots = $someBoolean
	# OPTIONAL
	shouldApplyToNonPolicySnapshots = $someBoolean
	# OPTIONAL
	existingSnapshotRetention = $someGlobalExistingSnapshotRetention # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalExistingSnapshotRetention]) for enum values.
	# OPTIONAL
	userNote = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // assignRetentionSLAToSnappables(
        //     globalSlaOptionalFid: UUID
        //     globalSlaAssignType: SlaAssignTypeEnum!
        //     objectIds: [UUID!]!
        //     applicableSnappableType: WorkloadLevelHierarchy
        //     shouldApplyToNonPolicySnapshots: Boolean
        //     userNote: String
        //   ): SlaAssignResult!
        internal void InitMutationAssignRetentionSlaToSnappables()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("globalSlaOptionalFid", "UUID"),
                Tuple.Create("globalSlaAssignType", "SlaAssignTypeEnum!"),
                Tuple.Create("objectIds", "[UUID!]!"),
                Tuple.Create("applicableSnappableType", "WorkloadLevelHierarchy"),
                Tuple.Create("shouldApplyToNonPolicySnapshots", "Boolean"),
                Tuple.Create("userNote", "String"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAssignRetentionSlaToSnappables",
                "($globalSlaOptionalFid: UUID,$globalSlaAssignType: SlaAssignTypeEnum!,$objectIds: [UUID!]!,$applicableSnappableType: WorkloadLevelHierarchy,$shouldApplyToNonPolicySnapshots: Boolean,$userNote: String)",
                "SlaAssignResult",
                Mutation.AssignRetentionSlaToSnappables_ObjectFieldSpec,
                Mutation.AssignRetentionSlaToSnappablesFieldSpec,
                @"# OPTIONAL
$query.Var.globalSlaOptionalFid = $someString
# REQUIRED
$query.Var.globalSlaAssignType = $someSlaAssignTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaAssignTypeEnum]) for enum values.
# REQUIRED
$query.Var.objectIds = @(
	$someString
)
# OPTIONAL
$query.Var.applicableSnappableType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
# OPTIONAL
$query.Var.shouldApplyToNonPolicySnapshots = $someBoolean
# OPTIONAL
$query.Var.userNote = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // assignRetentionSLAToSnapshots(
        //     globalSlaOptionalFid: UUID
        //     globalSlaAssignType: SlaAssignTypeEnum!
        //     snapshotFids: [UUID!]!
        //     userNote: String
        //   ): SlaAssignResult!
        internal void InitMutationAssignRetentionSlaToSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("globalSlaOptionalFid", "UUID"),
                Tuple.Create("globalSlaAssignType", "SlaAssignTypeEnum!"),
                Tuple.Create("snapshotFids", "[UUID!]!"),
                Tuple.Create("userNote", "String"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAssignRetentionSlaToSnapshots",
                "($globalSlaOptionalFid: UUID,$globalSlaAssignType: SlaAssignTypeEnum!,$snapshotFids: [UUID!]!,$userNote: String)",
                "SlaAssignResult",
                Mutation.AssignRetentionSlaToSnapshots_ObjectFieldSpec,
                Mutation.AssignRetentionSlaToSnapshotsFieldSpec,
                @"# OPTIONAL
$query.Var.globalSlaOptionalFid = $someString
# REQUIRED
$query.Var.globalSlaAssignType = $someSlaAssignTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaAssignTypeEnum]) for enum values.
# REQUIRED
$query.Var.snapshotFids = @(
	$someString
)
# OPTIONAL
$query.Var.userNote = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // assignSlasForSnappableHierarchies(
        //     globalSlaOptionalFid: UUID
        //     globalSlaAssignType: SlaAssignTypeEnum!
        //     objectIds: [UUID!]!
        //     applicableSnappableTypes: [WorkloadLevelHierarchy!]
        //     shouldApplyToExistingSnapshots: Boolean
        //     shouldApplyToNonPolicySnapshots: Boolean
        //     globalExistingSnapshotRetention: GlobalExistingSnapshotRetention
        //     userNote: String
        //   ): [SlaAssignResult!]!
        internal void InitMutationAssignSlasForSnappableHierarchies()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("globalSlaOptionalFid", "UUID"),
                Tuple.Create("globalSlaAssignType", "SlaAssignTypeEnum!"),
                Tuple.Create("objectIds", "[UUID!]!"),
                Tuple.Create("applicableSnappableTypes", "[WorkloadLevelHierarchy!]"),
                Tuple.Create("shouldApplyToExistingSnapshots", "Boolean"),
                Tuple.Create("shouldApplyToNonPolicySnapshots", "Boolean"),
                Tuple.Create("globalExistingSnapshotRetention", "GlobalExistingSnapshotRetention"),
                Tuple.Create("userNote", "String"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAssignSlasForSnappableHierarchies",
                "($globalSlaOptionalFid: UUID,$globalSlaAssignType: SlaAssignTypeEnum!,$objectIds: [UUID!]!,$applicableSnappableTypes: [WorkloadLevelHierarchy!],$shouldApplyToExistingSnapshots: Boolean,$shouldApplyToNonPolicySnapshots: Boolean,$globalExistingSnapshotRetention: GlobalExistingSnapshotRetention,$userNote: String)",
                "List<SlaAssignResult>",
                Mutation.AssignSlasForSnappableHierarchies_ObjectFieldSpec,
                Mutation.AssignSlasForSnappableHierarchiesFieldSpec,
                @"# OPTIONAL
$query.Var.globalSlaOptionalFid = $someString
# REQUIRED
$query.Var.globalSlaAssignType = $someSlaAssignTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaAssignTypeEnum]) for enum values.
# REQUIRED
$query.Var.objectIds = @(
	$someString
)
# OPTIONAL
$query.Var.applicableSnappableTypes = @(
	$someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
)
# OPTIONAL
$query.Var.shouldApplyToExistingSnapshots = $someBoolean
# OPTIONAL
$query.Var.shouldApplyToNonPolicySnapshots = $someBoolean
# OPTIONAL
$query.Var.globalExistingSnapshotRetention = $someGlobalExistingSnapshotRetention # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalExistingSnapshotRetention]) for enum values.
# OPTIONAL
$query.Var.userNote = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // createGlobalSla(input: CreateGlobalSlaInput!): GlobalSlaReply!
        internal void InitMutationCreateGlobalSla()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateGlobalSlaInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateGlobalSla",
                "($input: CreateGlobalSlaInput!)",
                "GlobalSlaReply",
                Mutation.CreateGlobalSla_ObjectFieldSpec,
                Mutation.CreateGlobalSlaFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	name = $someString
	# OPTIONAL
	description = $someString
	# OPTIONAL
	snapshotSchedule = @{
		# OPTIONAL
		minute = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = $someInt
				# OPTIONAL
				retention = $someInt
				# OPTIONAL
				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		hourly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = $someInt
				# OPTIONAL
				retention = $someInt
				# OPTIONAL
				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		daily = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = $someInt
				# OPTIONAL
				retention = $someInt
				# OPTIONAL
				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		weekly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = $someInt
				# OPTIONAL
				retention = $someInt
				# OPTIONAL
				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfWeek = $someDayOfWeek # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfWeek]) for enum values.
		}
		# OPTIONAL
		monthly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = $someInt
				# OPTIONAL
				retention = $someInt
				# OPTIONAL
				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfMonth = $someDayOfMonth # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfMonth]) for enum values.
		}
		# OPTIONAL
		quarterly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = $someInt
				# OPTIONAL
				retention = $someInt
				# OPTIONAL
				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfQuarter = $someDayOfQuarter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfQuarter]) for enum values.
			# OPTIONAL
			quarterStartMonth = $someMonth # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Month]) for enum values.
		}
		# OPTIONAL
		yearly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = $someInt
				# OPTIONAL
				retention = $someInt
				# OPTIONAL
				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfYear = $someDayOfYear # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfYear]) for enum values.
			# OPTIONAL
			yearStartMonth = $someMonth # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Month]) for enum values.
		}
	}
	# OPTIONAL
	replicationSpecInput = @{
		# OPTIONAL
		replicationType = $someReplicationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReplicationType]) for enum values.
		# OPTIONAL
		specificReplicationSpecInput = @{
			# OPTIONAL
			unidirectionalSpecInput = @{
				# OPTIONAL
				replicationTargetId = $someString
				# OPTIONAL
				retention = $someInt
				# OPTIONAL
				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			bidirectionalSpecInput = @{
				# OPTIONAL
				replicationSpec1 = @{
					# OPTIONAL
					replicationTargetId = $someString
					# OPTIONAL
					retention = $someInt
					# OPTIONAL
					retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
				}
				# OPTIONAL
				replicationSpec2 = @{
					# OPTIONAL
					replicationTargetId = $someString
					# OPTIONAL
					retention = $someInt
					# OPTIONAL
					retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
				}
			}
			# OPTIONAL
			cloudRegionSpecInput = @{
				# OPTIONAL
				replicationTargetRegion = $someString
				# OPTIONAL
				cloudProvider = $someCloudProvider # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudProvider]) for enum values.
				# OPTIONAL
				retention = $someInt
				# OPTIONAL
				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			cloudLocationSpecInput = @{
				# OPTIONAL
				replicationTargetId = $someString
				# OPTIONAL
				cloudProvider = $someCloudProvider # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudProvider]) for enum values.
				# OPTIONAL
				retentionDuration = @{
					# OPTIONAL
					duration = $someInt
					# OPTIONAL
					unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
				}
			}
		}
	}
	# OPTIONAL
	localRetentionLimit = @{
		# OPTIONAL
		duration = $someInt
		# OPTIONAL
		unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
	}
	# OPTIONAL
	firstFullBackupWindows = @(
		@{
			# OPTIONAL
			durationInHours = $someInt
			# OPTIONAL
			startTimeAttributes = @{
				# OPTIONAL
				dayOfWeek = @{
					# OPTIONAL
					day = $someDayOfWeek # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfWeek]) for enum values.
				}
				# OPTIONAL
				hour = $someInt
				# OPTIONAL
				minute = $someInt
			}
		}
	)
	# OPTIONAL
	backupWindows = @(
		@{
			# OPTIONAL
			durationInHours = $someInt
			# OPTIONAL
			startTimeAttributes = @{
				# OPTIONAL
				dayOfWeek = @{
					# OPTIONAL
					day = $someDayOfWeek # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfWeek]) for enum values.
				}
				# OPTIONAL
				hour = $someInt
				# OPTIONAL
				minute = $someInt
			}
		}
	)
	# OPTIONAL
	logConfig = @{
		# OPTIONAL
		slaLogFrequencyConfig = @{
			# OPTIONAL
			retention = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
	}
	# OPTIONAL
	objectSpecificConfigsInput = @{
		# OPTIONAL
		sapHanaConfigInput = @{
			# OPTIONAL
			incrementalFrequency = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			differentialFrequency = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			storageSnapshotConfig = @{
				# OPTIONAL
				frequency = @{
					# OPTIONAL
					duration = $someInt
					# OPTIONAL
					unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
				}
				# OPTIONAL
				retention = @{
					# OPTIONAL
					duration = $someInt
					# OPTIONAL
					unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
				}
			}
		}
		# OPTIONAL
		awsRdsConfigInput = @{
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		vmwareVmConfigInput = @{
			# OPTIONAL
			logRetentionSeconds = $someInt64
		}
		# OPTIONAL
		azureSqlDatabaseDbConfigInput = @{
			# OPTIONAL
			logRetentionInDays = $someInt
		}
		# OPTIONAL
		azureSqlManagedInstanceDbConfigInput = @{
			# OPTIONAL
			logRetentionInDays = $someInt
		}
		# OPTIONAL
		db2ConfigInput = @{
			# OPTIONAL
			incrementalFrequency = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			differentialFrequency = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		mssqlConfigInput = @{
			# OPTIONAL
			frequency = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		oracleConfigInput = @{
			# OPTIONAL
			frequency = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			hostLogRetention = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		mongoConfigInput = @{
			# OPTIONAL
			logFrequency = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		azureBlobConfigInput = @{
			# OPTIONAL
			continuousBackupRetentionInDays = $someInt
			# OPTIONAL
			backupLocationId = $someString
		}
		# OPTIONAL
		awsNativeS3SlaConfigInput = @{
			# OPTIONAL
			archivalLocationId = $someString
			# OPTIONAL
			continuousBackupRetentionInDays = $someInt
		}
		# OPTIONAL
		managedVolumeSlaConfigInput = @{
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		postgresDbClusterSlaConfigInput = @{
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
	}
	# OPTIONAL
	archivalSpecs = @(
		@{
			# OPTIONAL
			archivalGroupId = $someString
			# OPTIONAL
			threshold = $someInt
			# OPTIONAL
			thresholdUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			# OPTIONAL
			archivalTieringSpecInput = @{
				# OPTIONAL
				isInstantTieringEnabled = $someBoolean
				# OPTIONAL
				minAccessibleDurationInSeconds = $someInt64
				# OPTIONAL
				coldStorageClass = $someColdStorageClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ColdStorageClass]) for enum values.
				# OPTIONAL
				shouldTierExistingSnapshots = $someBoolean
			}
			# OPTIONAL
			frequencies = @(
				$someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			)
			# OPTIONAL
			archivalLocationToClusterMapping = @(
				@{
					# OPTIONAL
					clusterUuid = $someString
					# OPTIONAL
					locationId = $someString
				}
			)
		}
	)
	# OPTIONAL
	replicationSpecsV2 = @(
		@{
			# OPTIONAL
			clusterUuid = $someString
			# OPTIONAL
			storageSettingId = $someString
			# OPTIONAL
			retentionDuration = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			awsAccount = $someString
			# OPTIONAL
			azureSubscription = $someString
			# OPTIONAL
			replicationLocalRetentionDuration = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			cascadingArchivalSpecs = @(
				@{
					# OPTIONAL
					archivalLocationId = $someString
					# OPTIONAL
					archivalThreshold = @{
						# OPTIONAL
						duration = $someInt
						# OPTIONAL
						unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
					}
					# OPTIONAL
					archivalTieringSpecInput = @{
						# OPTIONAL
						isInstantTieringEnabled = $someBoolean
						# OPTIONAL
						minAccessibleDurationInSeconds = $someInt64
						# OPTIONAL
						coldStorageClass = $someColdStorageClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ColdStorageClass]) for enum values.
						# OPTIONAL
						shouldTierExistingSnapshots = $someBoolean
					}
					# OPTIONAL
					frequency = @(
						$someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
					)
				}
			)
			# OPTIONAL
			awsRegion = $someAwsNativeRegionForReplication # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegionForReplication]) for enum values.
			# OPTIONAL
			azureRegion = $someAzureNativeRegionForReplication # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegionForReplication]) for enum values.
		}
	)
	# OPTIONAL
	objectTypes = @(
		$someSlaObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaObjectType]) for enum values.
	)
	# OPTIONAL
	isRetentionLockedSla = $someBoolean
	# OPTIONAL
	retentionLockMode = $someRetentionLockMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionLockMode]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteGlobalSla(id: UUID!, userNote: String): SlaResult!
        internal void InitMutationDeleteGlobalSla()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("id", "UUID!"),
                Tuple.Create("userNote", "String"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteGlobalSla",
                "($id: UUID!,$userNote: String)",
                "SlaResult",
                Mutation.DeleteGlobalSla_ObjectFieldSpec,
                Mutation.DeleteGlobalSlaFieldSpec,
                @"# REQUIRED
$query.Var.id = $someString
# OPTIONAL
$query.Var.userNote = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // exportSlaManagedVolumeSnapshot(input: ExportSlaManagedVolumeSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationExportSlaManagedVolumeSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportSlaManagedVolumeSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExportSlaManagedVolumeSnapshot",
                "($input: ExportSlaManagedVolumeSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.ExportSlaManagedVolumeSnapshot_ObjectFieldSpec,
                Mutation.ExportSlaManagedVolumeSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	params = @{
		# OPTIONAL
		shouldDownloadToLocal = $someBoolean
		# OPTIONAL
		managedVolumeSlaExportConfig = @{
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
			# REQUIRED
			hostId = $someString
			# REQUIRED
			hostMountPaths = @(
				$someString
			)
		}
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // getPendingSlaAssignments(input: GetPendingSlaAssignmentsInput!): GetPendingSlaAssignmentsReply!
        internal void InitMutationGetPendingSlaAssignments()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetPendingSlaAssignmentsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationGetPendingSlaAssignments",
                "($input: GetPendingSlaAssignmentsInput!)",
                "GetPendingSlaAssignmentsReply",
                Mutation.GetPendingSlaAssignments_ObjectFieldSpec,
                Mutation.GetPendingSlaAssignmentsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	pendingAssignmentsRequest = @{
		# REQUIRED
		objectIds = @(
			$someString
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // pauseSla(input: PauseSlaInput!): PauseSlaReply!
        internal void InitMutationPauseSla()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PauseSlaInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPauseSla",
                "($input: PauseSlaInput!)",
                "PauseSlaReply",
                Mutation.PauseSla_ObjectFieldSpec,
                Mutation.PauseSlaFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	slaId = $someString
	# REQUIRED
	clusterUuids = @(
		$someString
	)
	# REQUIRED
	pauseSla = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateGlobalSla(input: UpdateGlobalSlaInput!): GlobalSlaReply!
        internal void InitMutationUpdateGlobalSla()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateGlobalSlaInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateGlobalSla",
                "($input: UpdateGlobalSlaInput!)",
                "GlobalSlaReply",
                Mutation.UpdateGlobalSla_ObjectFieldSpec,
                Mutation.UpdateGlobalSlaFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	id = $someString
	# OPTIONAL
	name = $someString
	# OPTIONAL
	description = $someString
	# OPTIONAL
	snapshotSchedule = @{
		# OPTIONAL
		minute = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = $someInt
				# OPTIONAL
				retention = $someInt
				# OPTIONAL
				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		hourly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = $someInt
				# OPTIONAL
				retention = $someInt
				# OPTIONAL
				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		daily = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = $someInt
				# OPTIONAL
				retention = $someInt
				# OPTIONAL
				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		weekly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = $someInt
				# OPTIONAL
				retention = $someInt
				# OPTIONAL
				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfWeek = $someDayOfWeek # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfWeek]) for enum values.
		}
		# OPTIONAL
		monthly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = $someInt
				# OPTIONAL
				retention = $someInt
				# OPTIONAL
				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfMonth = $someDayOfMonth # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfMonth]) for enum values.
		}
		# OPTIONAL
		quarterly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = $someInt
				# OPTIONAL
				retention = $someInt
				# OPTIONAL
				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfQuarter = $someDayOfQuarter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfQuarter]) for enum values.
			# OPTIONAL
			quarterStartMonth = $someMonth # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Month]) for enum values.
		}
		# OPTIONAL
		yearly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = $someInt
				# OPTIONAL
				retention = $someInt
				# OPTIONAL
				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfYear = $someDayOfYear # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfYear]) for enum values.
			# OPTIONAL
			yearStartMonth = $someMonth # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Month]) for enum values.
		}
	}
	# OPTIONAL
	stateVersion = $someInt64
	# OPTIONAL
	replicationSpecInput = @{
		# OPTIONAL
		replicationType = $someReplicationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReplicationType]) for enum values.
		# OPTIONAL
		specificReplicationSpecInput = @{
			# OPTIONAL
			unidirectionalSpecInput = @{
				# OPTIONAL
				replicationTargetId = $someString
				# OPTIONAL
				retention = $someInt
				# OPTIONAL
				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			bidirectionalSpecInput = @{
				# OPTIONAL
				replicationSpec1 = @{
					# OPTIONAL
					replicationTargetId = $someString
					# OPTIONAL
					retention = $someInt
					# OPTIONAL
					retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
				}
				# OPTIONAL
				replicationSpec2 = @{
					# OPTIONAL
					replicationTargetId = $someString
					# OPTIONAL
					retention = $someInt
					# OPTIONAL
					retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
				}
			}
			# OPTIONAL
			cloudRegionSpecInput = @{
				# OPTIONAL
				replicationTargetRegion = $someString
				# OPTIONAL
				cloudProvider = $someCloudProvider # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudProvider]) for enum values.
				# OPTIONAL
				retention = $someInt
				# OPTIONAL
				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			cloudLocationSpecInput = @{
				# OPTIONAL
				replicationTargetId = $someString
				# OPTIONAL
				cloudProvider = $someCloudProvider # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudProvider]) for enum values.
				# OPTIONAL
				retentionDuration = @{
					# OPTIONAL
					duration = $someInt
					# OPTIONAL
					unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
				}
			}
		}
	}
	# OPTIONAL
	localRetentionLimit = @{
		# OPTIONAL
		duration = $someInt
		# OPTIONAL
		unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
	}
	# OPTIONAL
	firstFullBackupWindows = @(
		@{
			# OPTIONAL
			durationInHours = $someInt
			# OPTIONAL
			startTimeAttributes = @{
				# OPTIONAL
				dayOfWeek = @{
					# OPTIONAL
					day = $someDayOfWeek # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfWeek]) for enum values.
				}
				# OPTIONAL
				hour = $someInt
				# OPTIONAL
				minute = $someInt
			}
		}
	)
	# OPTIONAL
	backupWindows = @(
		@{
			# OPTIONAL
			durationInHours = $someInt
			# OPTIONAL
			startTimeAttributes = @{
				# OPTIONAL
				dayOfWeek = @{
					# OPTIONAL
					day = $someDayOfWeek # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfWeek]) for enum values.
				}
				# OPTIONAL
				hour = $someInt
				# OPTIONAL
				minute = $someInt
			}
		}
	)
	# OPTIONAL
	logConfig = @{
		# OPTIONAL
		slaLogFrequencyConfig = @{
			# OPTIONAL
			retention = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
	}
	# OPTIONAL
	objectSpecificConfigsInput = @{
		# OPTIONAL
		sapHanaConfigInput = @{
			# OPTIONAL
			incrementalFrequency = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			differentialFrequency = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			storageSnapshotConfig = @{
				# OPTIONAL
				frequency = @{
					# OPTIONAL
					duration = $someInt
					# OPTIONAL
					unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
				}
				# OPTIONAL
				retention = @{
					# OPTIONAL
					duration = $someInt
					# OPTIONAL
					unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
				}
			}
		}
		# OPTIONAL
		awsRdsConfigInput = @{
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		vmwareVmConfigInput = @{
			# OPTIONAL
			logRetentionSeconds = $someInt64
		}
		# OPTIONAL
		azureSqlDatabaseDbConfigInput = @{
			# OPTIONAL
			logRetentionInDays = $someInt
		}
		# OPTIONAL
		azureSqlManagedInstanceDbConfigInput = @{
			# OPTIONAL
			logRetentionInDays = $someInt
		}
		# OPTIONAL
		db2ConfigInput = @{
			# OPTIONAL
			incrementalFrequency = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			differentialFrequency = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		mssqlConfigInput = @{
			# OPTIONAL
			frequency = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		oracleConfigInput = @{
			# OPTIONAL
			frequency = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			hostLogRetention = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		mongoConfigInput = @{
			# OPTIONAL
			logFrequency = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		azureBlobConfigInput = @{
			# OPTIONAL
			continuousBackupRetentionInDays = $someInt
			# OPTIONAL
			backupLocationId = $someString
		}
		# OPTIONAL
		awsNativeS3SlaConfigInput = @{
			# OPTIONAL
			archivalLocationId = $someString
			# OPTIONAL
			continuousBackupRetentionInDays = $someInt
		}
		# OPTIONAL
		managedVolumeSlaConfigInput = @{
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		postgresDbClusterSlaConfigInput = @{
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
	}
	# OPTIONAL
	shouldApplyToExistingSnapshots = @{
		# OPTIONAL
		value = $someBoolean
	}
	# OPTIONAL
	shouldApplyToNonPolicySnapshots = @{
		# OPTIONAL
		value = $someBoolean
	}
	# OPTIONAL
	userNote = $someString
	# OPTIONAL
	archivalSpecs = @(
		@{
			# OPTIONAL
			archivalGroupId = $someString
			# OPTIONAL
			threshold = $someInt
			# OPTIONAL
			thresholdUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			# OPTIONAL
			archivalTieringSpecInput = @{
				# OPTIONAL
				isInstantTieringEnabled = $someBoolean
				# OPTIONAL
				minAccessibleDurationInSeconds = $someInt64
				# OPTIONAL
				coldStorageClass = $someColdStorageClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ColdStorageClass]) for enum values.
				# OPTIONAL
				shouldTierExistingSnapshots = $someBoolean
			}
			# OPTIONAL
			frequencies = @(
				$someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			)
			# OPTIONAL
			archivalLocationToClusterMapping = @(
				@{
					# OPTIONAL
					clusterUuid = $someString
					# OPTIONAL
					locationId = $someString
				}
			)
		}
	)
	# OPTIONAL
	replicationSpecsV2 = @(
		@{
			# OPTIONAL
			clusterUuid = $someString
			# OPTIONAL
			storageSettingId = $someString
			# OPTIONAL
			retentionDuration = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			awsAccount = $someString
			# OPTIONAL
			azureSubscription = $someString
			# OPTIONAL
			replicationLocalRetentionDuration = @{
				# OPTIONAL
				duration = $someInt
				# OPTIONAL
				unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			cascadingArchivalSpecs = @(
				@{
					# OPTIONAL
					archivalLocationId = $someString
					# OPTIONAL
					archivalThreshold = @{
						# OPTIONAL
						duration = $someInt
						# OPTIONAL
						unit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
					}
					# OPTIONAL
					archivalTieringSpecInput = @{
						# OPTIONAL
						isInstantTieringEnabled = $someBoolean
						# OPTIONAL
						minAccessibleDurationInSeconds = $someInt64
						# OPTIONAL
						coldStorageClass = $someColdStorageClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ColdStorageClass]) for enum values.
						# OPTIONAL
						shouldTierExistingSnapshots = $someBoolean
					}
					# OPTIONAL
					frequency = @(
						$someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
					)
				}
			)
			# OPTIONAL
			awsRegion = $someAwsNativeRegionForReplication # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegionForReplication]) for enum values.
			# OPTIONAL
			azureRegion = $someAzureNativeRegionForReplication # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegionForReplication]) for enum values.
		}
	)
	# OPTIONAL
	objectTypes = @(
		$someSlaObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaObjectType]) for enum values.
	)
	# OPTIONAL
	isRetentionLockedSla = $someBoolean
	# OPTIONAL
	retentionLockMode = $someRetentionLockMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionLockMode]) for enum values.
}"
            );
        }


    } // class New_RscMutationSla
}