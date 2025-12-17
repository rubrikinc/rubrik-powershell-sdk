// New-RscMutationDownload.cs
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
    /// Create a new RscQuery object for any of the 23
    /// operations in the 'Report Download' API domain:
    /// ActiveDirectorySnapshotFromLocation, AnomalyDetailsCsv, AuditLogCsvAsync, CdmTprConfigurationAsync, ExchangeSnapshot, ExchangeSnapshotV2, FilesetSnapshot, FilesetSnapshotFromLocation, FromArchiveV2, ObjectFilesCsv, ObjectsListCsv, OpenstackSnapshotFromLocation, ReportCsvAsync, ReportPdfAsync, ResultsCsv, SapHanaSnapshot, SapHanaSnapshotFromLocation, SapHanaSnapshotsForPointInTimeRecovery, SnapshotResultsCsv, ThreatHuntCsv, ThreatHuntV2ResultsCsv, VolumeGroupSnapshotFiles, or VolumeGroupSnapshotFromLocation.
    /// </summary>
    /// <description>
    /// New-RscMutationDownload creates a new
    /// mutation object for operations
    /// in the 'Report Download' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 23 operations
    /// in the 'Report Download' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: ActiveDirectorySnapshotFromLocation, AnomalyDetailsCsv, AuditLogCsvAsync, CdmTprConfigurationAsync, ExchangeSnapshot, ExchangeSnapshotV2, FilesetSnapshot, FilesetSnapshotFromLocation, FromArchiveV2, ObjectFilesCsv, ObjectsListCsv, OpenstackSnapshotFromLocation, ReportCsvAsync, ReportPdfAsync, ResultsCsv, SapHanaSnapshot, SapHanaSnapshotFromLocation, SapHanaSnapshotsForPointInTimeRecovery, SnapshotResultsCsv, ThreatHuntCsv, ThreatHuntV2ResultsCsv, VolumeGroupSnapshotFiles, or VolumeGroupSnapshotFromLocation.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationDownload -ActiveDirectorySnapshotFromLocation).Info().
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
    /// (New-RscMutationDownload -ActiveDirectorySnapshotFromLocation).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the ActiveDirectorySnapshotFromLocation operation
    /// of the 'Report Download' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Download
    /// # API Operation: ActiveDirectorySnapshotFromLocation
    /// 
    /// $query = New-RscMutationDownload -Operation ActiveDirectorySnapshotFromLocation
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotId = $someString
    /// 	# OPTIONAL
    /// 	downloadConfig = @{
    /// 		# OPTIONAL
    /// 		slaId = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	locationId = $someString
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
    /// Runs the AnomalyDetailsCsv operation
    /// of the 'Report Download' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Download
    /// # API Operation: AnomalyDetailsCsv
    /// 
    /// $query = New-RscMutationDownload -Operation AnomalyDetailsCsv
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	workloadId = $someString
    /// 	# REQUIRED
    /// 	snapshotId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DownloadAnomalyDetailsCsvReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AuditLogCsvAsync operation
    /// of the 'Report Download' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Download
    /// # API Operation: AuditLogCsvAsync
    /// 
    /// $query = New-RscMutationDownload -Operation AuditLogCsvAsync
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	filters = @{
    /// 		# OPTIONAL
    /// 		activityObjectType = @(
    /// 			$someActivityObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityObjectTypeEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		objectType = @(
    /// 			$someObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		excludedObjectTypes = @(
    /// 			$someObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		lastActivityStatus = @(
    /// 			$someActivityStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityStatusEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		lastActivityType = @(
    /// 			$someActivityTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityTypeEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		slaDomainId = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		clusterType = @(
    /// 			$someClusterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		clusterId = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		timeRange = @{
    /// 			# OPTIONAL
    /// 			relativeTimeRange = @{
    /// 				# REQUIRED
    /// 				magnitude = $someInt
    /// 				# REQUIRED
    /// 				unit = $someTimeUnitEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TimeUnitEnum]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			absoluteTimeRange = @{
    /// 				# REQUIRED
    /// 				start = $someDateTime
    /// 				# REQUIRED
    /// 				end = $someDateTime
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		slaTimeRange = $someSlaComplianceTimeRange # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaComplianceTimeRange]) for enum values.
    /// 		# OPTIONAL
    /// 		orgId = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		managedId = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		isAnomaly = $someBoolean
    /// 		# OPTIONAL
    /// 		searchTerm = $someString
    /// 		# OPTIONAL
    /// 		complianceStatus = @(
    /// 			$someComplianceStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ComplianceStatusEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		protectionStatus = @(
    /// 			$someProtectionStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProtectionStatusEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		failoverStatus = @(
    /// 			$someFailoverStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FailoverStatusEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		failoverType = $someFailoverTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FailoverTypeEnum]) for enum values.
    /// 		# OPTIONAL
    /// 		source = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		targetSite = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		userAuditObjectType = @(
    /// 			$someUserAuditObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditObjectTypeEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		userAuditType = @(
    /// 			$someUserAuditTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditTypeEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		userAuditStatus = @(
    /// 			$someUserAuditStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditStatusEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		replicationSource = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		clusterLocation = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		taskCategory = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		taskStatus = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		taskType = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		policyId = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		sonarObjectTypes = @(
    /// 			$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		shouldApplyWhitelists = $someBoolean
    /// 		# OPTIONAL
    /// 		date = $someDateTime
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncDownloadReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CdmTprConfigurationAsync operation
    /// of the 'Report Download' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Download
    /// # API Operation: CdmTprConfigurationAsync
    /// 
    /// $query = New-RscMutationDownload -Operation CdmTprConfigurationAsync
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DownloadCdmTprConfigAsyncReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ExchangeSnapshot operation
    /// of the 'Report Download' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Download
    /// # API Operation: ExchangeSnapshot
    /// 
    /// $query = New-RscMutationDownload -Operation ExchangeSnapshot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
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
    /// Runs the ExchangeSnapshotV2 operation
    /// of the 'Report Download' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Download
    /// # API Operation: ExchangeSnapshotV2
    /// 
    /// $query = New-RscMutationDownload -Operation ExchangeSnapshotV2
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotId = $someString
    /// 	# OPTIONAL
    /// 	downloadConfig = @{
    /// 		# OPTIONAL
    /// 		slaId = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	locationId = $someString
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
    /// Runs the FilesetSnapshot operation
    /// of the 'Report Download' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Download
    /// # API Operation: FilesetSnapshot
    /// 
    /// $query = New-RscMutationDownload -Operation FilesetSnapshot
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
    /// Runs the FilesetSnapshotFromLocation operation
    /// of the 'Report Download' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Download
    /// # API Operation: FilesetSnapshotFromLocation
    /// 
    /// $query = New-RscMutationDownload -Operation FilesetSnapshotFromLocation
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
    /// Runs the FromArchiveV2 operation
    /// of the 'Report Download' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Download
    /// # API Operation: FromArchiveV2
    /// 
    /// $query = New-RscMutationDownload -Operation FromArchiveV2
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# REQUIRED
    /// 		recoveryPoint = @{
    /// 			# OPTIONAL
    /// 			lsnPoint = @{
    /// 				# REQUIRED
    /// 				lsn = $someString
    /// 				# OPTIONAL
    /// 				recoveryForkGuid = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			timestampMs = $someInt64
    /// 			# OPTIONAL
    /// 			date = $someDateTime
    /// 		}
    /// 		# OPTIONAL
    /// 		slaId = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	locationId = $someString
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
    /// Runs the ObjectFilesCsv operation
    /// of the 'Report Download' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Download
    /// # API Operation: ObjectFilesCsv
    /// 
    /// $query = New-RscMutationDownload -Operation ObjectFilesCsv
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	filters = @{
    /// 		# OPTIONAL
    /// 		openAccessTypes = @(
    /// 			$someOpenAccessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OpenAccessType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		stalenessTypes = @(
    /// 			$someStalenessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StalenessType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		analyzerGroupIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		clusterIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		pathPrefix = $someString
    /// 		# OPTIONAL
    /// 		snappableTypes = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		searchText = $someString
    /// 		# OPTIONAL
    /// 		whitelistEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		fileCountTypes = @(
    /// 			$someFileCountType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FileCountType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		accessTypes = @(
    /// 			$someAccessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AccessType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		activityTypes = @(
    /// 			$someActivityAccessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityAccessType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		objectIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		inodeTypes = @(
    /// 			$someInodeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InodeType]) for enum values.
    /// 		)
    /// 		# REQUIRED
    /// 		objectTypes = @(
    /// 			$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
    /// 		)
    /// 	}
    /// 	# REQUIRED
    /// 	day = $someString
    /// 	# REQUIRED
    /// 	timezone = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DownloadCsvReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ObjectsListCsv operation
    /// of the 'Report Download' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Download
    /// # API Operation: ObjectsListCsv
    /// 
    /// $query = New-RscMutationDownload -Operation ObjectsListCsv
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	day = $someString
    /// 	# REQUIRED
    /// 	timezone = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DownloadCsvReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the OpenstackSnapshotFromLocation operation
    /// of the 'Report Download' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Download
    /// # API Operation: OpenstackSnapshotFromLocation
    /// 
    /// $query = New-RscMutationDownload -Operation OpenstackSnapshotFromLocation
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotId = $someString
    /// 	# OPTIONAL
    /// 	downloadConfig = @{
    /// 		# OPTIONAL
    /// 		slaId = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	locationId = $someString
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
    /// Runs the ReportCsvAsync operation
    /// of the 'Report Download' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Download
    /// # API Operation: ReportCsvAsync
    /// 
    /// $query = New-RscMutationDownload -Operation ReportCsvAsync
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someInt
    /// 	# OPTIONAL
    /// 	config = @{
    /// 		# REQUIRED
    /// 		name = $someString
    /// 		# REQUIRED
    /// 		focus = $someReportFocusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportFocusEnum]) for enum values.
    /// 		# OPTIONAL
    /// 		charts = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				name = $someString
    /// 				# REQUIRED
    /// 				focus = $someReportFocusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportFocusEnum]) for enum values.
    /// 				# OPTIONAL
    /// 				groupBy = @(
    /// 					$someGroupByFieldEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GroupByFieldEnum]) for enum values.
    /// 				)
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		tables = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				name = $someString
    /// 				# REQUIRED
    /// 				focus = $someReportFocusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportFocusEnum]) for enum values.
    /// 				# OPTIONAL
    /// 				groupBy = @(
    /// 					$someGroupByFieldEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GroupByFieldEnum]) for enum values.
    /// 				)
    /// 				# REQUIRED
    /// 				selectedColumns = @(
    /// 					$someReportTableColumnEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportTableColumnEnum]) for enum values.
    /// 				)
    /// 				# OPTIONAL
    /// 				sortBy = $someSortByFieldEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortByFieldEnum]) for enum values.
    /// 				# OPTIONAL
    /// 				sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// 			}
    /// 		)
    /// 		# REQUIRED
    /// 		filters = @{
    /// 			# OPTIONAL
    /// 			activityObjectType = @(
    /// 				$someActivityObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityObjectTypeEnum]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			objectType = @(
    /// 				$someObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			excludedObjectTypes = @(
    /// 				$someObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			lastActivityStatus = @(
    /// 				$someActivityStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityStatusEnum]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			lastActivityType = @(
    /// 				$someActivityTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityTypeEnum]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			slaDomainId = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			clusterType = @(
    /// 				$someClusterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			clusterId = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			timeRange = @{
    /// 				# OPTIONAL
    /// 				relativeTimeRange = @{
    /// 					# REQUIRED
    /// 					magnitude = $someInt
    /// 					# REQUIRED
    /// 					unit = $someTimeUnitEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TimeUnitEnum]) for enum values.
    /// 				}
    /// 				# OPTIONAL
    /// 				absoluteTimeRange = @{
    /// 					# REQUIRED
    /// 					start = $someDateTime
    /// 					# REQUIRED
    /// 					end = $someDateTime
    /// 				}
    /// 			}
    /// 			# OPTIONAL
    /// 			slaTimeRange = $someSlaComplianceTimeRange # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaComplianceTimeRange]) for enum values.
    /// 			# OPTIONAL
    /// 			orgId = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			managedId = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			isAnomaly = $someBoolean
    /// 			# OPTIONAL
    /// 			searchTerm = $someString
    /// 			# OPTIONAL
    /// 			complianceStatus = @(
    /// 				$someComplianceStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ComplianceStatusEnum]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			protectionStatus = @(
    /// 				$someProtectionStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProtectionStatusEnum]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			failoverStatus = @(
    /// 				$someFailoverStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FailoverStatusEnum]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			failoverType = $someFailoverTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FailoverTypeEnum]) for enum values.
    /// 			# OPTIONAL
    /// 			source = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			targetSite = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			userAuditObjectType = @(
    /// 				$someUserAuditObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditObjectTypeEnum]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			userAuditType = @(
    /// 				$someUserAuditTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditTypeEnum]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			userAuditStatus = @(
    /// 				$someUserAuditStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditStatusEnum]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			replicationSource = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			clusterLocation = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			taskCategory = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			taskStatus = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			taskType = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			policyId = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			sonarObjectTypes = @(
    /// 				$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			shouldApplyWhitelists = $someBoolean
    /// 			# OPTIONAL
    /// 			date = $someDateTime
    /// 		}
    /// 		# OPTIONAL
    /// 		isHidden = $someBoolean
    /// 		# OPTIONAL
    /// 		isReadOnly = $someBoolean
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncDownloadReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ReportPdfAsync operation
    /// of the 'Report Download' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Download
    /// # API Operation: ReportPdfAsync
    /// 
    /// $query = New-RscMutationDownload -Operation ReportPdfAsync
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someInt
    /// 	# OPTIONAL
    /// 	config = @{
    /// 		# REQUIRED
    /// 		name = $someString
    /// 		# REQUIRED
    /// 		focus = $someReportFocusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportFocusEnum]) for enum values.
    /// 		# OPTIONAL
    /// 		charts = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				name = $someString
    /// 				# REQUIRED
    /// 				focus = $someReportFocusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportFocusEnum]) for enum values.
    /// 				# OPTIONAL
    /// 				groupBy = @(
    /// 					$someGroupByFieldEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GroupByFieldEnum]) for enum values.
    /// 				)
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		tables = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				name = $someString
    /// 				# REQUIRED
    /// 				focus = $someReportFocusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportFocusEnum]) for enum values.
    /// 				# OPTIONAL
    /// 				groupBy = @(
    /// 					$someGroupByFieldEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GroupByFieldEnum]) for enum values.
    /// 				)
    /// 				# REQUIRED
    /// 				selectedColumns = @(
    /// 					$someReportTableColumnEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportTableColumnEnum]) for enum values.
    /// 				)
    /// 				# OPTIONAL
    /// 				sortBy = $someSortByFieldEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortByFieldEnum]) for enum values.
    /// 				# OPTIONAL
    /// 				sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// 			}
    /// 		)
    /// 		# REQUIRED
    /// 		filters = @{
    /// 			# OPTIONAL
    /// 			activityObjectType = @(
    /// 				$someActivityObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityObjectTypeEnum]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			objectType = @(
    /// 				$someObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			excludedObjectTypes = @(
    /// 				$someObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			lastActivityStatus = @(
    /// 				$someActivityStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityStatusEnum]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			lastActivityType = @(
    /// 				$someActivityTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityTypeEnum]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			slaDomainId = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			clusterType = @(
    /// 				$someClusterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			clusterId = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			timeRange = @{
    /// 				# OPTIONAL
    /// 				relativeTimeRange = @{
    /// 					# REQUIRED
    /// 					magnitude = $someInt
    /// 					# REQUIRED
    /// 					unit = $someTimeUnitEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TimeUnitEnum]) for enum values.
    /// 				}
    /// 				# OPTIONAL
    /// 				absoluteTimeRange = @{
    /// 					# REQUIRED
    /// 					start = $someDateTime
    /// 					# REQUIRED
    /// 					end = $someDateTime
    /// 				}
    /// 			}
    /// 			# OPTIONAL
    /// 			slaTimeRange = $someSlaComplianceTimeRange # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaComplianceTimeRange]) for enum values.
    /// 			# OPTIONAL
    /// 			orgId = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			managedId = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			isAnomaly = $someBoolean
    /// 			# OPTIONAL
    /// 			searchTerm = $someString
    /// 			# OPTIONAL
    /// 			complianceStatus = @(
    /// 				$someComplianceStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ComplianceStatusEnum]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			protectionStatus = @(
    /// 				$someProtectionStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProtectionStatusEnum]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			failoverStatus = @(
    /// 				$someFailoverStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FailoverStatusEnum]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			failoverType = $someFailoverTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FailoverTypeEnum]) for enum values.
    /// 			# OPTIONAL
    /// 			source = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			targetSite = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			userAuditObjectType = @(
    /// 				$someUserAuditObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditObjectTypeEnum]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			userAuditType = @(
    /// 				$someUserAuditTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditTypeEnum]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			userAuditStatus = @(
    /// 				$someUserAuditStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditStatusEnum]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			replicationSource = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			clusterLocation = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			taskCategory = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			taskStatus = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			taskType = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			policyId = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			sonarObjectTypes = @(
    /// 				$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			shouldApplyWhitelists = $someBoolean
    /// 			# OPTIONAL
    /// 			date = $someDateTime
    /// 		}
    /// 		# OPTIONAL
    /// 		isHidden = $someBoolean
    /// 		# OPTIONAL
    /// 		isReadOnly = $someBoolean
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncDownloadReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ResultsCsv operation
    /// of the 'Report Download' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Download
    /// # API Operation: ResultsCsv
    /// 
    /// $query = New-RscMutationDownload -Operation ResultsCsv
    /// 
    /// # REQUIRED
    /// $query.Var.crawlId = $someString
    /// # OPTIONAL
    /// $query.Var.downloadFilter = @{
    /// 	# OPTIONAL
    /// 	analyzerGroupIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	browseDirectorySnappablePath = @{
    /// 		# OPTIONAL
    /// 		snappableFid = $someString
    /// 		# OPTIONAL
    /// 		stdPath = $someString
    /// 		# OPTIONAL
    /// 		mode = $someDataGovFileMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataGovFileMode]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	listFileResultsSnappablePaths = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			snappableFid = $someString
    /// 			# OPTIONAL
    /// 			stdPath = $someString
    /// 			# OPTIONAL
    /// 			mode = $someDataGovFileMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataGovFileMode]) for enum values.
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	listFileResultsSnappableTypes = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	listFileResultsSearchText = $someString
    /// 	# OPTIONAL
    /// 	whitelistEnabled = $someBoolean
    /// 	# OPTIONAL
    /// 	policyViolationId = $someString
    /// 	# REQUIRED
    /// 	fileType = $someFileCountType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FileCountType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DownloadResultsCsvReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SapHanaSnapshot operation
    /// of the 'Report Download' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Download
    /// # API Operation: SapHanaSnapshot
    /// 
    /// $query = New-RscMutationDownload -Operation SapHanaSnapshot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
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
    /// Runs the SapHanaSnapshotFromLocation operation
    /// of the 'Report Download' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Download
    /// # API Operation: SapHanaSnapshotFromLocation
    /// 
    /// $query = New-RscMutationDownload -Operation SapHanaSnapshotFromLocation
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
    /// Runs the SapHanaSnapshotsForPointInTimeRecovery operation
    /// of the 'Report Download' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Download
    /// # API Operation: SapHanaSnapshotsForPointInTimeRecovery
    /// 
    /// $query = New-RscMutationDownload -Operation SapHanaSnapshotsForPointInTimeRecovery
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	downloadConfig = @{
    /// 		# OPTIONAL
    /// 		pointInTime = $someDateTime
    /// 		# REQUIRED
    /// 		preferredLocationId = $someString
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
    /// Runs the SnapshotResultsCsv operation
    /// of the 'Report Download' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Download
    /// # API Operation: SnapshotResultsCsv
    /// 
    /// $query = New-RscMutationDownload -Operation SnapshotResultsCsv
    /// 
    /// # REQUIRED
    /// $query.Var.snappableFid = $someString
    /// # REQUIRED
    /// $query.Var.snapshotFid = $someString
    /// # OPTIONAL
    /// $query.Var.downloadFilter = @{
    /// 	# OPTIONAL
    /// 	analyzerGroupIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	browseDirectorySnappablePath = @{
    /// 		# OPTIONAL
    /// 		snappableFid = $someString
    /// 		# OPTIONAL
    /// 		stdPath = $someString
    /// 		# OPTIONAL
    /// 		mode = $someDataGovFileMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataGovFileMode]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	listFileResultsSnappablePaths = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			snappableFid = $someString
    /// 			# OPTIONAL
    /// 			stdPath = $someString
    /// 			# OPTIONAL
    /// 			mode = $someDataGovFileMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataGovFileMode]) for enum values.
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	listFileResultsSnappableTypes = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	listFileResultsSearchText = $someString
    /// 	# OPTIONAL
    /// 	whitelistEnabled = $someBoolean
    /// 	# OPTIONAL
    /// 	policyViolationId = $someString
    /// 	# REQUIRED
    /// 	fileType = $someFileCountType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FileCountType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DownloadCsvReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ThreatHuntCsv operation
    /// of the 'Report Download' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Download
    /// # API Operation: ThreatHuntCsv
    /// 
    /// $query = New-RscMutationDownload -Operation ThreatHuntCsv
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	huntId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DownloadThreatHuntCsvReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ThreatHuntV2ResultsCsv operation
    /// of the 'Report Download' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Download
    /// # API Operation: ThreatHuntV2ResultsCsv
    /// 
    /// $query = New-RscMutationDownload -Operation ThreatHuntV2ResultsCsv
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	huntId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DownloadThreatHuntV2CsvResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the VolumeGroupSnapshotFiles operation
    /// of the 'Report Download' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Download
    /// # API Operation: VolumeGroupSnapshotFiles
    /// 
    /// $query = New-RscMutationDownload -Operation VolumeGroupSnapshotFiles
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	nextSnapshotFid = $someString
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# REQUIRED
    /// 		paths = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		legalHoldDownloadConfig = @{
    /// 			# REQUIRED
    /// 			isLegalHoldDownload = $someBoolean
    /// 		}
    /// 		# OPTIONAL
    /// 		zipPassword = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	deltaTypeFilter = @(
    /// 		$someDeltaType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeltaType]) for enum values.
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
    /// Runs the VolumeGroupSnapshotFromLocation operation
    /// of the 'Report Download' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Download
    /// # API Operation: VolumeGroupSnapshotFromLocation
    /// 
    /// $query = New-RscMutationDownload -Operation VolumeGroupSnapshotFromLocation
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
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationDownload",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationDownload : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "ActiveDirectorySnapshotFromLocation",
                "AnomalyDetailsCsv",
                "AuditLogCsvAsync",
                "CdmTprConfigurationAsync",
                "ExchangeSnapshot",
                "ExchangeSnapshotV2",
                "FilesetSnapshot",
                "FilesetSnapshotFromLocation",
                "FromArchiveV2",
                "ObjectFilesCsv",
                "ObjectsListCsv",
                "OpenstackSnapshotFromLocation",
                "ReportCsvAsync",
                "ReportPdfAsync",
                "ResultsCsv",
                "SapHanaSnapshot",
                "SapHanaSnapshotFromLocation",
                "SapHanaSnapshotsForPointInTimeRecovery",
                "SnapshotResultsCsv",
                "ThreatHuntCsv",
                "ThreatHuntV2ResultsCsv",
                "VolumeGroupSnapshotFiles",
                "VolumeGroupSnapshotFromLocation",
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
                    case "ActiveDirectorySnapshotFromLocation":
                        this.ProcessRecord_ActiveDirectorySnapshotFromLocation();
                        break;
                    case "AnomalyDetailsCsv":
                        this.ProcessRecord_AnomalyDetailsCsv();
                        break;
                    case "AuditLogCsvAsync":
                        this.ProcessRecord_AuditLogCsvAsync();
                        break;
                    case "CdmTprConfigurationAsync":
                        this.ProcessRecord_CdmTprConfigurationAsync();
                        break;
                    case "ExchangeSnapshot":
                        this.ProcessRecord_ExchangeSnapshot();
                        break;
                    case "ExchangeSnapshotV2":
                        this.ProcessRecord_ExchangeSnapshotV2();
                        break;
                    case "FilesetSnapshot":
                        this.ProcessRecord_FilesetSnapshot();
                        break;
                    case "FilesetSnapshotFromLocation":
                        this.ProcessRecord_FilesetSnapshotFromLocation();
                        break;
                    case "FromArchiveV2":
                        this.ProcessRecord_FromArchiveV2();
                        break;
                    case "ObjectFilesCsv":
                        this.ProcessRecord_ObjectFilesCsv();
                        break;
                    case "ObjectsListCsv":
                        this.ProcessRecord_ObjectsListCsv();
                        break;
                    case "OpenstackSnapshotFromLocation":
                        this.ProcessRecord_OpenstackSnapshotFromLocation();
                        break;
                    case "ReportCsvAsync":
                        this.ProcessRecord_ReportCsvAsync();
                        break;
                    case "ReportPdfAsync":
                        this.ProcessRecord_ReportPdfAsync();
                        break;
                    case "ResultsCsv":
                        this.ProcessRecord_ResultsCsv();
                        break;
                    case "SapHanaSnapshot":
                        this.ProcessRecord_SapHanaSnapshot();
                        break;
                    case "SapHanaSnapshotFromLocation":
                        this.ProcessRecord_SapHanaSnapshotFromLocation();
                        break;
                    case "SapHanaSnapshotsForPointInTimeRecovery":
                        this.ProcessRecord_SapHanaSnapshotsForPointInTimeRecovery();
                        break;
                    case "SnapshotResultsCsv":
                        this.ProcessRecord_SnapshotResultsCsv();
                        break;
                    case "ThreatHuntCsv":
                        this.ProcessRecord_ThreatHuntCsv();
                        break;
                    case "ThreatHuntV2ResultsCsv":
                        this.ProcessRecord_ThreatHuntV2ResultsCsv();
                        break;
                    case "VolumeGroupSnapshotFiles":
                        this.ProcessRecord_VolumeGroupSnapshotFiles();
                        break;
                    case "VolumeGroupSnapshotFromLocation":
                        this.ProcessRecord_VolumeGroupSnapshotFromLocation();
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
        // downloadActiveDirectorySnapshotFromLocation.
        internal void ProcessRecord_ActiveDirectorySnapshotFromLocation()
        {
            this._logger.name += " -ActiveDirectorySnapshotFromLocation";
            // Create new graphql operation downloadActiveDirectorySnapshotFromLocation
            InitMutationDownloadActiveDirectorySnapshotFromLocation();
        }

        // This parameter set invokes a single graphql operation:
        // downloadAnomalyDetailsCsv.
        internal void ProcessRecord_AnomalyDetailsCsv()
        {
            this._logger.name += " -AnomalyDetailsCsv";
            // Create new graphql operation downloadAnomalyDetailsCsv
            InitMutationDownloadAnomalyDetailsCsv();
        }

        // This parameter set invokes a single graphql operation:
        // downloadAuditLogCsvAsync.
        internal void ProcessRecord_AuditLogCsvAsync()
        {
            this._logger.name += " -AuditLogCsvAsync";
            // Create new graphql operation downloadAuditLogCsvAsync
            InitMutationDownloadAuditLogCsvAsync();
        }

        // This parameter set invokes a single graphql operation:
        // downloadCdmTprConfigurationAsync.
        internal void ProcessRecord_CdmTprConfigurationAsync()
        {
            this._logger.name += " -CdmTprConfigurationAsync";
            // Create new graphql operation downloadCdmTprConfigurationAsync
            InitMutationDownloadCdmTprConfigurationAsync();
        }

        // This parameter set invokes a single graphql operation:
        // downloadExchangeSnapshot.
        internal void ProcessRecord_ExchangeSnapshot()
        {
            this._logger.name += " -ExchangeSnapshot";
            // Create new graphql operation downloadExchangeSnapshot
            InitMutationDownloadExchangeSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // downloadExchangeSnapshotV2.
        internal void ProcessRecord_ExchangeSnapshotV2()
        {
            this._logger.name += " -ExchangeSnapshotV2";
            // Create new graphql operation downloadExchangeSnapshotV2
            InitMutationDownloadExchangeSnapshotV2();
        }

        // This parameter set invokes a single graphql operation:
        // downloadFilesetSnapshot.
        internal void ProcessRecord_FilesetSnapshot()
        {
            this._logger.name += " -FilesetSnapshot";
            // Create new graphql operation downloadFilesetSnapshot
            InitMutationDownloadFilesetSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // downloadFilesetSnapshotFromLocation.
        internal void ProcessRecord_FilesetSnapshotFromLocation()
        {
            this._logger.name += " -FilesetSnapshotFromLocation";
            // Create new graphql operation downloadFilesetSnapshotFromLocation
            InitMutationDownloadFilesetSnapshotFromLocation();
        }

        // This parameter set invokes a single graphql operation:
        // downloadFromArchiveV2.
        internal void ProcessRecord_FromArchiveV2()
        {
            this._logger.name += " -FromArchiveV2";
            // Create new graphql operation downloadFromArchiveV2
            InitMutationDownloadFromArchiveV2();
        }

        // This parameter set invokes a single graphql operation:
        // downloadObjectFilesCsv.
        internal void ProcessRecord_ObjectFilesCsv()
        {
            this._logger.name += " -ObjectFilesCsv";
            // Create new graphql operation downloadObjectFilesCsv
            InitMutationDownloadObjectFilesCsv();
        }

        // This parameter set invokes a single graphql operation:
        // downloadObjectsListCsv.
        internal void ProcessRecord_ObjectsListCsv()
        {
            this._logger.name += " -ObjectsListCsv";
            // Create new graphql operation downloadObjectsListCsv
            InitMutationDownloadObjectsListCsv();
        }

        // This parameter set invokes a single graphql operation:
        // downloadOpenstackSnapshotFromLocation.
        internal void ProcessRecord_OpenstackSnapshotFromLocation()
        {
            this._logger.name += " -OpenstackSnapshotFromLocation";
            // Create new graphql operation downloadOpenstackSnapshotFromLocation
            InitMutationDownloadOpenstackSnapshotFromLocation();
        }

        // This parameter set invokes a single graphql operation:
        // downloadReportCsvAsync.
        internal void ProcessRecord_ReportCsvAsync()
        {
            this._logger.name += " -ReportCsvAsync";
            // Create new graphql operation downloadReportCsvAsync
            InitMutationDownloadReportCsvAsync();
        }

        // This parameter set invokes a single graphql operation:
        // downloadReportPdfAsync.
        internal void ProcessRecord_ReportPdfAsync()
        {
            this._logger.name += " -ReportPdfAsync";
            // Create new graphql operation downloadReportPdfAsync
            InitMutationDownloadReportPdfAsync();
        }

        // This parameter set invokes a single graphql operation:
        // downloadResultsCsv.
        internal void ProcessRecord_ResultsCsv()
        {
            this._logger.name += " -ResultsCsv";
            // Create new graphql operation downloadResultsCsv
            InitMutationDownloadResultsCsv();
        }

        // This parameter set invokes a single graphql operation:
        // downloadSapHanaSnapshot.
        internal void ProcessRecord_SapHanaSnapshot()
        {
            this._logger.name += " -SapHanaSnapshot";
            // Create new graphql operation downloadSapHanaSnapshot
            InitMutationDownloadSapHanaSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // downloadSapHanaSnapshotFromLocation.
        internal void ProcessRecord_SapHanaSnapshotFromLocation()
        {
            this._logger.name += " -SapHanaSnapshotFromLocation";
            // Create new graphql operation downloadSapHanaSnapshotFromLocation
            InitMutationDownloadSapHanaSnapshotFromLocation();
        }

        // This parameter set invokes a single graphql operation:
        // downloadSapHanaSnapshotsForPointInTimeRecovery.
        internal void ProcessRecord_SapHanaSnapshotsForPointInTimeRecovery()
        {
            this._logger.name += " -SapHanaSnapshotsForPointInTimeRecovery";
            // Create new graphql operation downloadSapHanaSnapshotsForPointInTimeRecovery
            InitMutationDownloadSapHanaSnapshotsForPointInTimeRecovery();
        }

        // This parameter set invokes a single graphql operation:
        // downloadSnapshotResultsCsv.
        internal void ProcessRecord_SnapshotResultsCsv()
        {
            this._logger.name += " -SnapshotResultsCsv";
            // Create new graphql operation downloadSnapshotResultsCsv
            InitMutationDownloadSnapshotResultsCsv();
        }

        // This parameter set invokes a single graphql operation:
        // downloadThreatHuntCsv.
        internal void ProcessRecord_ThreatHuntCsv()
        {
            this._logger.name += " -ThreatHuntCsv";
            // Create new graphql operation downloadThreatHuntCsv
            InitMutationDownloadThreatHuntCsv();
        }

        // This parameter set invokes a single graphql operation:
        // downloadThreatHuntV2ResultsCsv.
        internal void ProcessRecord_ThreatHuntV2ResultsCsv()
        {
            this._logger.name += " -ThreatHuntV2ResultsCsv";
            // Create new graphql operation downloadThreatHuntV2ResultsCsv
            InitMutationDownloadThreatHuntV2ResultsCsv();
        }

        // This parameter set invokes a single graphql operation:
        // downloadVolumeGroupSnapshotFiles.
        internal void ProcessRecord_VolumeGroupSnapshotFiles()
        {
            this._logger.name += " -VolumeGroupSnapshotFiles";
            // Create new graphql operation downloadVolumeGroupSnapshotFiles
            InitMutationDownloadVolumeGroupSnapshotFiles();
        }

        // This parameter set invokes a single graphql operation:
        // downloadVolumeGroupSnapshotFromLocation.
        internal void ProcessRecord_VolumeGroupSnapshotFromLocation()
        {
            this._logger.name += " -VolumeGroupSnapshotFromLocation";
            // Create new graphql operation downloadVolumeGroupSnapshotFromLocation
            InitMutationDownloadVolumeGroupSnapshotFromLocation();
        }


        // Create new GraphQL Mutation:
        // downloadActiveDirectorySnapshotFromLocation(input: DownloadActiveDirectorySnapshotFromLocationInput!): AsyncRequestStatus!
        internal void InitMutationDownloadActiveDirectorySnapshotFromLocation()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadActiveDirectorySnapshotFromLocationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadActiveDirectorySnapshotFromLocation",
                "($input: DownloadActiveDirectorySnapshotFromLocationInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadActiveDirectorySnapshotFromLocation,
                Mutation.DownloadActiveDirectorySnapshotFromLocationFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotId = $someString
	# OPTIONAL
	downloadConfig = @{
		# OPTIONAL
		slaId = $someString
	}
	# REQUIRED
	locationId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadAnomalyDetailsCsv(input: DownloadAnomalyDetailsCsvInput!): DownloadAnomalyDetailsCsvReply!
        internal void InitMutationDownloadAnomalyDetailsCsv()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadAnomalyDetailsCsvInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadAnomalyDetailsCsv",
                "($input: DownloadAnomalyDetailsCsvInput!)",
                "DownloadAnomalyDetailsCsvReply",
                Mutation.DownloadAnomalyDetailsCsv,
                Mutation.DownloadAnomalyDetailsCsvFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	workloadId = $someString
	# REQUIRED
	snapshotId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadAuditLogCsvAsync(input: DownloadAuditLogCsvAsyncInput!): AsyncDownloadReply!
        internal void InitMutationDownloadAuditLogCsvAsync()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadAuditLogCsvAsyncInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadAuditLogCsvAsync",
                "($input: DownloadAuditLogCsvAsyncInput!)",
                "AsyncDownloadReply",
                Mutation.DownloadAuditLogCsvAsync,
                Mutation.DownloadAuditLogCsvAsyncFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	filters = @{
		# OPTIONAL
		activityObjectType = @(
			$someActivityObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityObjectTypeEnum]) for enum values.
		)
		# OPTIONAL
		objectType = @(
			$someObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
		)
		# OPTIONAL
		excludedObjectTypes = @(
			$someObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
		)
		# OPTIONAL
		lastActivityStatus = @(
			$someActivityStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityStatusEnum]) for enum values.
		)
		# OPTIONAL
		lastActivityType = @(
			$someActivityTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityTypeEnum]) for enum values.
		)
		# OPTIONAL
		slaDomainId = @(
			$someString
		)
		# OPTIONAL
		clusterType = @(
			$someClusterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values.
		)
		# OPTIONAL
		clusterId = @(
			$someString
		)
		# OPTIONAL
		timeRange = @{
			# OPTIONAL
			relativeTimeRange = @{
				# REQUIRED
				magnitude = $someInt
				# REQUIRED
				unit = $someTimeUnitEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TimeUnitEnum]) for enum values.
			}
			# OPTIONAL
			absoluteTimeRange = @{
				# REQUIRED
				start = $someDateTime
				# REQUIRED
				end = $someDateTime
			}
		}
		# OPTIONAL
		slaTimeRange = $someSlaComplianceTimeRange # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaComplianceTimeRange]) for enum values.
		# OPTIONAL
		orgId = @(
			$someString
		)
		# OPTIONAL
		managedId = @(
			$someString
		)
		# OPTIONAL
		isAnomaly = $someBoolean
		# OPTIONAL
		searchTerm = $someString
		# OPTIONAL
		complianceStatus = @(
			$someComplianceStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ComplianceStatusEnum]) for enum values.
		)
		# OPTIONAL
		protectionStatus = @(
			$someProtectionStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProtectionStatusEnum]) for enum values.
		)
		# OPTIONAL
		failoverStatus = @(
			$someFailoverStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FailoverStatusEnum]) for enum values.
		)
		# OPTIONAL
		failoverType = $someFailoverTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FailoverTypeEnum]) for enum values.
		# OPTIONAL
		source = @(
			$someString
		)
		# OPTIONAL
		targetSite = @(
			$someString
		)
		# OPTIONAL
		userAuditObjectType = @(
			$someUserAuditObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditObjectTypeEnum]) for enum values.
		)
		# OPTIONAL
		userAuditType = @(
			$someUserAuditTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditTypeEnum]) for enum values.
		)
		# OPTIONAL
		userAuditStatus = @(
			$someUserAuditStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditStatusEnum]) for enum values.
		)
		# OPTIONAL
		replicationSource = @(
			$someString
		)
		# OPTIONAL
		clusterLocation = @(
			$someString
		)
		# OPTIONAL
		taskCategory = @(
			$someString
		)
		# OPTIONAL
		taskStatus = @(
			$someString
		)
		# OPTIONAL
		taskType = @(
			$someString
		)
		# OPTIONAL
		policyId = @(
			$someString
		)
		# OPTIONAL
		sonarObjectTypes = @(
			$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
		)
		# OPTIONAL
		shouldApplyWhitelists = $someBoolean
		# OPTIONAL
		date = $someDateTime
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadCdmTprConfigurationAsync: DownloadCdmTprConfigAsyncReply!
        internal void InitMutationDownloadCdmTprConfigurationAsync()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadCdmTprConfigurationAsync",
                "",
                "DownloadCdmTprConfigAsyncReply",
                Mutation.DownloadCdmTprConfigurationAsync,
                Mutation.DownloadCdmTprConfigurationAsyncFieldSpec,
                @""
            );
        }

        // Create new GraphQL Mutation:
        // downloadExchangeSnapshot(input: DownloadExchangeSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationDownloadExchangeSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadExchangeSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadExchangeSnapshot",
                "($input: DownloadExchangeSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadExchangeSnapshot,
                Mutation.DownloadExchangeSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	locationId = $someString
	# REQUIRED
	snapshotId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadExchangeSnapshotV2(input: DownloadExchangeSnapshotV2Input!): AsyncRequestStatus!
        internal void InitMutationDownloadExchangeSnapshotV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadExchangeSnapshotV2Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadExchangeSnapshotV2",
                "($input: DownloadExchangeSnapshotV2Input!)",
                "AsyncRequestStatus",
                Mutation.DownloadExchangeSnapshotV2,
                Mutation.DownloadExchangeSnapshotV2FieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotId = $someString
	# OPTIONAL
	downloadConfig = @{
		# OPTIONAL
		slaId = $someString
	}
	# REQUIRED
	locationId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadFilesetSnapshot(input: DownloadFilesetSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationDownloadFilesetSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadFilesetSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadFilesetSnapshot",
                "($input: DownloadFilesetSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadFilesetSnapshot,
                Mutation.DownloadFilesetSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadFilesetSnapshotFromLocation(input: DownloadFilesetSnapshotFromLocationInput!): AsyncRequestStatus!
        internal void InitMutationDownloadFilesetSnapshotFromLocation()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadFilesetSnapshotFromLocationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadFilesetSnapshotFromLocation",
                "($input: DownloadFilesetSnapshotFromLocationInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadFilesetSnapshotFromLocation,
                Mutation.DownloadFilesetSnapshotFromLocationFieldSpec,
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
        // downloadFromArchiveV2(input: DownloadFromArchiveV2Input!): AsyncRequestStatus!
        internal void InitMutationDownloadFromArchiveV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadFromArchiveV2Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadFromArchiveV2",
                "($input: DownloadFromArchiveV2Input!)",
                "AsyncRequestStatus",
                Mutation.DownloadFromArchiveV2,
                Mutation.DownloadFromArchiveV2FieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	config = @{
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			lsnPoint = @{
				# REQUIRED
				lsn = $someString
				# OPTIONAL
				recoveryForkGuid = $someString
			}
			# OPTIONAL
			timestampMs = $someInt64
			# OPTIONAL
			date = $someDateTime
		}
		# OPTIONAL
		slaId = $someString
	}
	# REQUIRED
	locationId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadObjectFilesCsv(input: DownloadObjectFilesCsvInput!): DownloadCsvReply!
        internal void InitMutationDownloadObjectFilesCsv()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadObjectFilesCsvInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadObjectFilesCsv",
                "($input: DownloadObjectFilesCsvInput!)",
                "DownloadCsvReply",
                Mutation.DownloadObjectFilesCsv,
                Mutation.DownloadObjectFilesCsvFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	filters = @{
		# OPTIONAL
		openAccessTypes = @(
			$someOpenAccessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OpenAccessType]) for enum values.
		)
		# OPTIONAL
		stalenessTypes = @(
			$someStalenessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StalenessType]) for enum values.
		)
		# OPTIONAL
		analyzerGroupIds = @(
			$someString
		)
		# OPTIONAL
		clusterIds = @(
			$someString
		)
		# OPTIONAL
		pathPrefix = $someString
		# OPTIONAL
		snappableTypes = @(
			$someString
		)
		# OPTIONAL
		searchText = $someString
		# OPTIONAL
		whitelistEnabled = $someBoolean
		# OPTIONAL
		fileCountTypes = @(
			$someFileCountType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FileCountType]) for enum values.
		)
		# OPTIONAL
		accessTypes = @(
			$someAccessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AccessType]) for enum values.
		)
		# OPTIONAL
		activityTypes = @(
			$someActivityAccessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityAccessType]) for enum values.
		)
		# OPTIONAL
		objectIds = @(
			$someString
		)
		# OPTIONAL
		inodeTypes = @(
			$someInodeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InodeType]) for enum values.
		)
		# REQUIRED
		objectTypes = @(
			$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
		)
	}
	# REQUIRED
	day = $someString
	# REQUIRED
	timezone = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadObjectsListCsv(input: DownloadObjectsListCsvInput!): DownloadCsvReply!
        internal void InitMutationDownloadObjectsListCsv()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadObjectsListCsvInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadObjectsListCsv",
                "($input: DownloadObjectsListCsvInput!)",
                "DownloadCsvReply",
                Mutation.DownloadObjectsListCsv,
                Mutation.DownloadObjectsListCsvFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	day = $someString
	# REQUIRED
	timezone = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadOpenstackSnapshotFromLocation(input: DownloadOpenstackSnapshotFromLocationInput!): AsyncRequestStatus!
        internal void InitMutationDownloadOpenstackSnapshotFromLocation()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadOpenstackSnapshotFromLocationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadOpenstackSnapshotFromLocation",
                "($input: DownloadOpenstackSnapshotFromLocationInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadOpenstackSnapshotFromLocation,
                Mutation.DownloadOpenstackSnapshotFromLocationFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotId = $someString
	# OPTIONAL
	downloadConfig = @{
		# OPTIONAL
		slaId = $someString
	}
	# REQUIRED
	locationId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadReportCsvAsync(input: DownloadReportCsvAsyncInput!): AsyncDownloadReply!
        internal void InitMutationDownloadReportCsvAsync()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadReportCsvAsyncInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadReportCsvAsync",
                "($input: DownloadReportCsvAsyncInput!)",
                "AsyncDownloadReply",
                Mutation.DownloadReportCsvAsync,
                Mutation.DownloadReportCsvAsyncFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someInt
	# OPTIONAL
	config = @{
		# REQUIRED
		name = $someString
		# REQUIRED
		focus = $someReportFocusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportFocusEnum]) for enum values.
		# OPTIONAL
		charts = @(
			@{
				# REQUIRED
				name = $someString
				# REQUIRED
				focus = $someReportFocusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportFocusEnum]) for enum values.
				# OPTIONAL
				groupBy = @(
					$someGroupByFieldEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GroupByFieldEnum]) for enum values.
				)
			}
		)
		# OPTIONAL
		tables = @(
			@{
				# REQUIRED
				name = $someString
				# REQUIRED
				focus = $someReportFocusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportFocusEnum]) for enum values.
				# OPTIONAL
				groupBy = @(
					$someGroupByFieldEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GroupByFieldEnum]) for enum values.
				)
				# REQUIRED
				selectedColumns = @(
					$someReportTableColumnEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportTableColumnEnum]) for enum values.
				)
				# OPTIONAL
				sortBy = $someSortByFieldEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortByFieldEnum]) for enum values.
				# OPTIONAL
				sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
			}
		)
		# REQUIRED
		filters = @{
			# OPTIONAL
			activityObjectType = @(
				$someActivityObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityObjectTypeEnum]) for enum values.
			)
			# OPTIONAL
			objectType = @(
				$someObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
			)
			# OPTIONAL
			excludedObjectTypes = @(
				$someObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
			)
			# OPTIONAL
			lastActivityStatus = @(
				$someActivityStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityStatusEnum]) for enum values.
			)
			# OPTIONAL
			lastActivityType = @(
				$someActivityTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityTypeEnum]) for enum values.
			)
			# OPTIONAL
			slaDomainId = @(
				$someString
			)
			# OPTIONAL
			clusterType = @(
				$someClusterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values.
			)
			# OPTIONAL
			clusterId = @(
				$someString
			)
			# OPTIONAL
			timeRange = @{
				# OPTIONAL
				relativeTimeRange = @{
					# REQUIRED
					magnitude = $someInt
					# REQUIRED
					unit = $someTimeUnitEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TimeUnitEnum]) for enum values.
				}
				# OPTIONAL
				absoluteTimeRange = @{
					# REQUIRED
					start = $someDateTime
					# REQUIRED
					end = $someDateTime
				}
			}
			# OPTIONAL
			slaTimeRange = $someSlaComplianceTimeRange # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaComplianceTimeRange]) for enum values.
			# OPTIONAL
			orgId = @(
				$someString
			)
			# OPTIONAL
			managedId = @(
				$someString
			)
			# OPTIONAL
			isAnomaly = $someBoolean
			# OPTIONAL
			searchTerm = $someString
			# OPTIONAL
			complianceStatus = @(
				$someComplianceStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ComplianceStatusEnum]) for enum values.
			)
			# OPTIONAL
			protectionStatus = @(
				$someProtectionStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProtectionStatusEnum]) for enum values.
			)
			# OPTIONAL
			failoverStatus = @(
				$someFailoverStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FailoverStatusEnum]) for enum values.
			)
			# OPTIONAL
			failoverType = $someFailoverTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FailoverTypeEnum]) for enum values.
			# OPTIONAL
			source = @(
				$someString
			)
			# OPTIONAL
			targetSite = @(
				$someString
			)
			# OPTIONAL
			userAuditObjectType = @(
				$someUserAuditObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditObjectTypeEnum]) for enum values.
			)
			# OPTIONAL
			userAuditType = @(
				$someUserAuditTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditTypeEnum]) for enum values.
			)
			# OPTIONAL
			userAuditStatus = @(
				$someUserAuditStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditStatusEnum]) for enum values.
			)
			# OPTIONAL
			replicationSource = @(
				$someString
			)
			# OPTIONAL
			clusterLocation = @(
				$someString
			)
			# OPTIONAL
			taskCategory = @(
				$someString
			)
			# OPTIONAL
			taskStatus = @(
				$someString
			)
			# OPTIONAL
			taskType = @(
				$someString
			)
			# OPTIONAL
			policyId = @(
				$someString
			)
			# OPTIONAL
			sonarObjectTypes = @(
				$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
			)
			# OPTIONAL
			shouldApplyWhitelists = $someBoolean
			# OPTIONAL
			date = $someDateTime
		}
		# OPTIONAL
		isHidden = $someBoolean
		# OPTIONAL
		isReadOnly = $someBoolean
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadReportPdfAsync(input: DownloadReportPdfAsyncInput!): AsyncDownloadReply!
        internal void InitMutationDownloadReportPdfAsync()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadReportPdfAsyncInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadReportPdfAsync",
                "($input: DownloadReportPdfAsyncInput!)",
                "AsyncDownloadReply",
                Mutation.DownloadReportPdfAsync,
                Mutation.DownloadReportPdfAsyncFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someInt
	# OPTIONAL
	config = @{
		# REQUIRED
		name = $someString
		# REQUIRED
		focus = $someReportFocusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportFocusEnum]) for enum values.
		# OPTIONAL
		charts = @(
			@{
				# REQUIRED
				name = $someString
				# REQUIRED
				focus = $someReportFocusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportFocusEnum]) for enum values.
				# OPTIONAL
				groupBy = @(
					$someGroupByFieldEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GroupByFieldEnum]) for enum values.
				)
			}
		)
		# OPTIONAL
		tables = @(
			@{
				# REQUIRED
				name = $someString
				# REQUIRED
				focus = $someReportFocusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportFocusEnum]) for enum values.
				# OPTIONAL
				groupBy = @(
					$someGroupByFieldEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GroupByFieldEnum]) for enum values.
				)
				# REQUIRED
				selectedColumns = @(
					$someReportTableColumnEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportTableColumnEnum]) for enum values.
				)
				# OPTIONAL
				sortBy = $someSortByFieldEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortByFieldEnum]) for enum values.
				# OPTIONAL
				sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
			}
		)
		# REQUIRED
		filters = @{
			# OPTIONAL
			activityObjectType = @(
				$someActivityObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityObjectTypeEnum]) for enum values.
			)
			# OPTIONAL
			objectType = @(
				$someObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
			)
			# OPTIONAL
			excludedObjectTypes = @(
				$someObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
			)
			# OPTIONAL
			lastActivityStatus = @(
				$someActivityStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityStatusEnum]) for enum values.
			)
			# OPTIONAL
			lastActivityType = @(
				$someActivityTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityTypeEnum]) for enum values.
			)
			# OPTIONAL
			slaDomainId = @(
				$someString
			)
			# OPTIONAL
			clusterType = @(
				$someClusterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values.
			)
			# OPTIONAL
			clusterId = @(
				$someString
			)
			# OPTIONAL
			timeRange = @{
				# OPTIONAL
				relativeTimeRange = @{
					# REQUIRED
					magnitude = $someInt
					# REQUIRED
					unit = $someTimeUnitEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TimeUnitEnum]) for enum values.
				}
				# OPTIONAL
				absoluteTimeRange = @{
					# REQUIRED
					start = $someDateTime
					# REQUIRED
					end = $someDateTime
				}
			}
			# OPTIONAL
			slaTimeRange = $someSlaComplianceTimeRange # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaComplianceTimeRange]) for enum values.
			# OPTIONAL
			orgId = @(
				$someString
			)
			# OPTIONAL
			managedId = @(
				$someString
			)
			# OPTIONAL
			isAnomaly = $someBoolean
			# OPTIONAL
			searchTerm = $someString
			# OPTIONAL
			complianceStatus = @(
				$someComplianceStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ComplianceStatusEnum]) for enum values.
			)
			# OPTIONAL
			protectionStatus = @(
				$someProtectionStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProtectionStatusEnum]) for enum values.
			)
			# OPTIONAL
			failoverStatus = @(
				$someFailoverStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FailoverStatusEnum]) for enum values.
			)
			# OPTIONAL
			failoverType = $someFailoverTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FailoverTypeEnum]) for enum values.
			# OPTIONAL
			source = @(
				$someString
			)
			# OPTIONAL
			targetSite = @(
				$someString
			)
			# OPTIONAL
			userAuditObjectType = @(
				$someUserAuditObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditObjectTypeEnum]) for enum values.
			)
			# OPTIONAL
			userAuditType = @(
				$someUserAuditTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditTypeEnum]) for enum values.
			)
			# OPTIONAL
			userAuditStatus = @(
				$someUserAuditStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditStatusEnum]) for enum values.
			)
			# OPTIONAL
			replicationSource = @(
				$someString
			)
			# OPTIONAL
			clusterLocation = @(
				$someString
			)
			# OPTIONAL
			taskCategory = @(
				$someString
			)
			# OPTIONAL
			taskStatus = @(
				$someString
			)
			# OPTIONAL
			taskType = @(
				$someString
			)
			# OPTIONAL
			policyId = @(
				$someString
			)
			# OPTIONAL
			sonarObjectTypes = @(
				$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
			)
			# OPTIONAL
			shouldApplyWhitelists = $someBoolean
			# OPTIONAL
			date = $someDateTime
		}
		# OPTIONAL
		isHidden = $someBoolean
		# OPTIONAL
		isReadOnly = $someBoolean
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadResultsCsv(crawlId: String!, downloadFilter: DownloadResultsCsvFiltersInput): DownloadResultsCsvReply!
        internal void InitMutationDownloadResultsCsv()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("crawlId", "String!"),
                Tuple.Create("downloadFilter", "DownloadResultsCsvFiltersInput"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadResultsCsv",
                "($crawlId: String!,$downloadFilter: DownloadResultsCsvFiltersInput)",
                "DownloadResultsCsvReply",
                Mutation.DownloadResultsCsv,
                Mutation.DownloadResultsCsvFieldSpec,
                @"# REQUIRED
$query.Var.crawlId = $someString
# OPTIONAL
$query.Var.downloadFilter = @{
	# OPTIONAL
	analyzerGroupIds = @(
		$someString
	)
	# OPTIONAL
	browseDirectorySnappablePath = @{
		# OPTIONAL
		snappableFid = $someString
		# OPTIONAL
		stdPath = $someString
		# OPTIONAL
		mode = $someDataGovFileMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataGovFileMode]) for enum values.
	}
	# OPTIONAL
	listFileResultsSnappablePaths = @(
		@{
			# OPTIONAL
			snappableFid = $someString
			# OPTIONAL
			stdPath = $someString
			# OPTIONAL
			mode = $someDataGovFileMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataGovFileMode]) for enum values.
		}
	)
	# OPTIONAL
	listFileResultsSnappableTypes = @(
		$someString
	)
	# OPTIONAL
	listFileResultsSearchText = $someString
	# OPTIONAL
	whitelistEnabled = $someBoolean
	# OPTIONAL
	policyViolationId = $someString
	# REQUIRED
	fileType = $someFileCountType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FileCountType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadSapHanaSnapshot(input: DownloadSapHanaSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationDownloadSapHanaSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadSapHanaSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadSapHanaSnapshot",
                "($input: DownloadSapHanaSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadSapHanaSnapshot,
                Mutation.DownloadSapHanaSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	locationId = $someString
	# REQUIRED
	snapshotId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadSapHanaSnapshotFromLocation(input: DownloadSapHanaSnapshotFromLocationInput!): AsyncRequestStatus!
        internal void InitMutationDownloadSapHanaSnapshotFromLocation()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadSapHanaSnapshotFromLocationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadSapHanaSnapshotFromLocation",
                "($input: DownloadSapHanaSnapshotFromLocationInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadSapHanaSnapshotFromLocation,
                Mutation.DownloadSapHanaSnapshotFromLocationFieldSpec,
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
        // downloadSapHanaSnapshotsForPointInTimeRecovery(input: DownloadSapHanaSnapshotsForPointInTimeRecoveryInput!): AsyncRequestStatus!
        internal void InitMutationDownloadSapHanaSnapshotsForPointInTimeRecovery()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadSapHanaSnapshotsForPointInTimeRecoveryInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadSapHanaSnapshotsForPointInTimeRecovery",
                "($input: DownloadSapHanaSnapshotsForPointInTimeRecoveryInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadSapHanaSnapshotsForPointInTimeRecovery,
                Mutation.DownloadSapHanaSnapshotsForPointInTimeRecoveryFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	downloadConfig = @{
		# OPTIONAL
		pointInTime = $someDateTime
		# REQUIRED
		preferredLocationId = $someString
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadSnapshotResultsCsv(snappableFid: String!, snapshotFid: String!, downloadFilter: DownloadResultsCsvFiltersInput): DownloadCsvReply!
        internal void InitMutationDownloadSnapshotResultsCsv()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "String!"),
                Tuple.Create("snapshotFid", "String!"),
                Tuple.Create("downloadFilter", "DownloadResultsCsvFiltersInput"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadSnapshotResultsCsv",
                "($snappableFid: String!,$snapshotFid: String!,$downloadFilter: DownloadResultsCsvFiltersInput)",
                "DownloadCsvReply",
                Mutation.DownloadSnapshotResultsCsv,
                Mutation.DownloadSnapshotResultsCsvFieldSpec,
                @"# REQUIRED
$query.Var.snappableFid = $someString
# REQUIRED
$query.Var.snapshotFid = $someString
# OPTIONAL
$query.Var.downloadFilter = @{
	# OPTIONAL
	analyzerGroupIds = @(
		$someString
	)
	# OPTIONAL
	browseDirectorySnappablePath = @{
		# OPTIONAL
		snappableFid = $someString
		# OPTIONAL
		stdPath = $someString
		# OPTIONAL
		mode = $someDataGovFileMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataGovFileMode]) for enum values.
	}
	# OPTIONAL
	listFileResultsSnappablePaths = @(
		@{
			# OPTIONAL
			snappableFid = $someString
			# OPTIONAL
			stdPath = $someString
			# OPTIONAL
			mode = $someDataGovFileMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataGovFileMode]) for enum values.
		}
	)
	# OPTIONAL
	listFileResultsSnappableTypes = @(
		$someString
	)
	# OPTIONAL
	listFileResultsSearchText = $someString
	# OPTIONAL
	whitelistEnabled = $someBoolean
	# OPTIONAL
	policyViolationId = $someString
	# REQUIRED
	fileType = $someFileCountType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FileCountType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadThreatHuntCsv(input: DownloadThreatHuntCsvInput!): DownloadThreatHuntCsvReply!
        internal void InitMutationDownloadThreatHuntCsv()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadThreatHuntCsvInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadThreatHuntCsv",
                "($input: DownloadThreatHuntCsvInput!)",
                "DownloadThreatHuntCsvReply",
                Mutation.DownloadThreatHuntCsv,
                Mutation.DownloadThreatHuntCsvFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	huntId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadThreatHuntV2ResultsCsv(input: DownloadThreatHuntV2CsvInput!): DownloadThreatHuntV2CsvResponse!
        internal void InitMutationDownloadThreatHuntV2ResultsCsv()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadThreatHuntV2CsvInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadThreatHuntV2ResultsCsv",
                "($input: DownloadThreatHuntV2CsvInput!)",
                "DownloadThreatHuntV2CsvResponse",
                Mutation.DownloadThreatHuntV2ResultsCsv,
                Mutation.DownloadThreatHuntV2ResultsCsvFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	huntId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadVolumeGroupSnapshotFiles(input: DownloadVolumeGroupSnapshotFilesInput!): AsyncRequestStatus!
        internal void InitMutationDownloadVolumeGroupSnapshotFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadVolumeGroupSnapshotFilesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadVolumeGroupSnapshotFiles",
                "($input: DownloadVolumeGroupSnapshotFilesInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadVolumeGroupSnapshotFiles,
                Mutation.DownloadVolumeGroupSnapshotFilesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	nextSnapshotFid = $someString
	# REQUIRED
	config = @{
		# REQUIRED
		paths = @(
			$someString
		)
		# OPTIONAL
		legalHoldDownloadConfig = @{
			# REQUIRED
			isLegalHoldDownload = $someBoolean
		}
		# OPTIONAL
		zipPassword = $someString
	}
	# OPTIONAL
	deltaTypeFilter = @(
		$someDeltaType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeltaType]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadVolumeGroupSnapshotFromLocation(input: DownloadVolumeGroupSnapshotFromLocationInput!): AsyncRequestStatus!
        internal void InitMutationDownloadVolumeGroupSnapshotFromLocation()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadVolumeGroupSnapshotFromLocationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadVolumeGroupSnapshotFromLocation",
                "($input: DownloadVolumeGroupSnapshotFromLocationInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadVolumeGroupSnapshotFromLocation,
                Mutation.DownloadVolumeGroupSnapshotFromLocationFieldSpec,
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


    } // class New_RscMutationDownload
}