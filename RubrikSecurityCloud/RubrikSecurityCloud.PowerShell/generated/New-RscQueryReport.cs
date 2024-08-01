// New-RscQueryReport.cs
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
    /// Create a new RscQuery object for any of the 33
    /// operations in the 'Report' API domain:
    /// ChartData, Chema, ClusterMigrationCount, ClusterMigrationJobStatus, ClusterMigrationStatus, Config, Configs, Data, DatabaseLogForCluster, DatabaseLogingPropertiesForCluster, Failover, FailoverJob, FromConfig, GenerateNasMigration, GroupByList, List, Metadata, PolarisConfig, PolarisTableIntrospection, Polarischema, Report, RscConfigs, S3BucketSnapshotDownloadUrl, ScheduledReport, ScheduledReports, Screenshot, Sonar, SonarContent, SonarRow, TableData, Trial, TrialDownloadURL, or Version.
    /// </summary>
    /// <description>
    /// New-RscQueryReport creates a new
    /// query object for operations
    /// in the 'Report' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 33 operations
    /// in the 'Report' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: ChartData, Chema, ClusterMigrationCount, ClusterMigrationJobStatus, ClusterMigrationStatus, Config, Configs, Data, DatabaseLogForCluster, DatabaseLogingPropertiesForCluster, Failover, FailoverJob, FromConfig, GenerateNasMigration, GroupByList, List, Metadata, PolarisConfig, PolarisTableIntrospection, Polarischema, Report, RscConfigs, S3BucketSnapshotDownloadUrl, ScheduledReport, ScheduledReports, Screenshot, Sonar, SonarContent, SonarRow, TableData, Trial, TrialDownloadURL, or Version.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryReport -ChartData).Info().
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
    /// (New-RscQueryReport -ChartData).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the ChartData operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: ChartData
    /// 
    /// $query = New-RscQueryReport -ChartData
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # REQUIRED
    /// $query.Var.chartView = $someChartViewType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChartViewType]) for enum values.
    /// # REQUIRED
    /// $query.Var.reportRoom = $someReportRoomType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportRoomType]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filters = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		name = $someString
    /// 		# REQUIRED
    /// 		values = @(
    /// 			$someString
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.timezone = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ChartDataResult
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Chema operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: Chema
    /// 
    /// $query = New-RscQueryReport -Chema
    /// 
    /// # REQUIRED
    /// $query.Var.dataView = $someDataViewTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataViewTypeEnum]) for enum values.
    /// # OPTIONAL
    /// $query.Var.timezone = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ReportSchema
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ClusterMigrationCount operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: ClusterMigrationCount
    /// 
    /// $query = New-RscQueryReport -ClusterMigrationCount
    /// 
    /// # OPTIONAL
    /// $query.Var.clusterUuid = $someString
    /// # REQUIRED
    /// $query.Var.status = @(
    /// 	$someCdmReportMigrationStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmReportMigrationStatus]) for enum values.
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ReportsMigrationCount
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ClusterMigrationJobStatus operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: ClusterMigrationJobStatus
    /// 
    /// $query = New-RscQueryReport -ClusterMigrationJobStatus
    /// 
    /// # OPTIONAL
    /// $query.Var.clusterUuid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ClusterReportMigrationJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ClusterMigrationStatus operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: ClusterMigrationStatus
    /// 
    /// $query = New-RscQueryReport -ClusterMigrationStatus
    /// 
    /// # OPTIONAL
    /// $query.Var.clusterUuid = $someString
    /// # REQUIRED
    /// $query.Var.status = @(
    /// 	$someCdmReportMigrationStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmReportMigrationStatus]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ReportMigrationStatusConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Config operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: Config
    /// 
    /// $query = New-RscQueryReport -Config
    /// 
    /// # REQUIRED
    /// $query.Var.reportID = $someInt
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ReportConfig
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Configs operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: Configs
    /// 
    /// $query = New-RscQueryReport -Configs
    /// 
    /// # OPTIONAL
    /// $query.Var.dataView = $someDataViewTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataViewTypeEnum]) for enum values.
    /// # OPTIONAL
    /// $query.Var.searchTerm = $someString
    /// # OPTIONAL
    /// $query.Var.createdBy = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;ReportConfig&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Data operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: Data
    /// 
    /// $query = New-RscQueryReport -Data
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # REQUIRED
    /// $query.Var.dataView = $someDataViewTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataViewTypeEnum]) for enum values.
    /// # REQUIRED
    /// $query.Var.columns = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.filters = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		name = $someString
    /// 		# REQUIRED
    /// 		values = @(
    /// 			$someString
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.groupBy = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.secondaryGroupBy = $someString
    /// # OPTIONAL
    /// $query.Var.aggregations = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.sortBy = $someString
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.timezone = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RowConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DatabaseLogForCluster operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: DatabaseLogForCluster
    /// 
    /// $query = New-RscQueryReport -DatabaseLogForCluster
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	logBackupDelay = $someInt
    /// 	# OPTIONAL
    /// 	limit = $someInt
    /// 	# OPTIONAL
    /// 	offset = $someInt
    /// 	# OPTIONAL
    /// 	effectiveSlaDomainId = $someString
    /// 	# OPTIONAL
    /// 	databaseType = $someString
    /// 	# OPTIONAL
    /// 	location = $someString
    /// 	# OPTIONAL
    /// 	sortBy = $someV1QueryLogReportRequestSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryLogReportRequestSortBy]) for enum values.
    /// 	# OPTIONAL
    /// 	sortOrder = $someV1QueryLogReportRequestSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryLogReportRequestSortOrder]) for enum values.
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DbLogReportSummaryListReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DatabaseLogingPropertiesForCluster operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: DatabaseLogingPropertiesForCluster
    /// 
    /// $query = New-RscQueryReport -DatabaseLogingPropertiesForCluster
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DbLogReportProperties
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Failover operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: Failover
    /// 
    /// $query = New-RscQueryReport -Failover
    /// 
    /// # REQUIRED
    /// $query.Var.failoverReportId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: FailoverReport
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the FailoverJob operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: FailoverJob
    /// 
    /// $query = New-RscQueryReport -FailoverJob
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// # OPTIONAL
    /// $query.Var.recoveryJobID = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;FailoverJobReport&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the FromConfig operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: FromConfig
    /// 
    /// $query = New-RscQueryReport -FromConfig
    /// 
    /// # REQUIRED
    /// $query.Var.config = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	focus = $someReportFocusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportFocusEnum]) for enum values.
    /// 	# OPTIONAL
    /// 	charts = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			name = $someString
    /// 			# REQUIRED
    /// 			focus = $someReportFocusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportFocusEnum]) for enum values.
    /// 			# OPTIONAL
    /// 			groupBy = @(
    /// 				$someGroupByFieldEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GroupByFieldEnum]) for enum values.
    /// 			)
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	tables = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			name = $someString
    /// 			# REQUIRED
    /// 			focus = $someReportFocusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportFocusEnum]) for enum values.
    /// 			# OPTIONAL
    /// 			groupBy = @(
    /// 				$someGroupByFieldEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GroupByFieldEnum]) for enum values.
    /// 			)
    /// 			# REQUIRED
    /// 			selectedColumns = @(
    /// 				$someReportTableColumnEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportTableColumnEnum]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			sortBy = $someSortByFieldEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortByFieldEnum]) for enum values.
    /// 			# OPTIONAL
    /// 			sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// 		}
    /// 	)
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
    /// 	# OPTIONAL
    /// 	isHidden = $someBoolean
    /// 	# OPTIONAL
    /// 	isReadOnly = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CustomReport
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GenerateNasMigration operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: GenerateNasMigration
    /// 
    /// $query = New-RscQueryReport -GenerateNasMigration
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.hostIds = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: NasMigrationHostDetailConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GroupByList operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: GroupByList
    /// 
    /// $query = New-RscQueryReport -GroupByList
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # REQUIRED
    /// $query.Var.groupBy = $someCustomReportGroupByEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CustomReportGroupByEnum]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	focus = $someReportFocusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportFocusEnum]) for enum values.
    /// 	# OPTIONAL
    /// 	isHidden = $someBoolean
    /// 	# OPTIONAL
    /// 	isReadOnly = $someBoolean
    /// 	# OPTIONAL
    /// 	creationTime_gt = $someDateTime
    /// 	# OPTIONAL
    /// 	creationTime_lt = $someDateTime
    /// 	# OPTIONAL
    /// 	searchTerm = $someString
    /// 	# OPTIONAL
    /// 	createdBy = $someString
    /// 	# OPTIONAL
    /// 	reportRoom = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CustomReportGroupByConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the List operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: List
    /// 
    /// $query = New-RscQueryReport -List
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortBy = $someCustomReportSortByEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CustomReportSortByEnum]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	focus = $someReportFocusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportFocusEnum]) for enum values.
    /// 	# OPTIONAL
    /// 	isHidden = $someBoolean
    /// 	# OPTIONAL
    /// 	isReadOnly = $someBoolean
    /// 	# OPTIONAL
    /// 	creationTime_gt = $someDateTime
    /// 	# OPTIONAL
    /// 	creationTime_lt = $someDateTime
    /// 	# OPTIONAL
    /// 	searchTerm = $someString
    /// 	# OPTIONAL
    /// 	createdBy = $someString
    /// 	# OPTIONAL
    /// 	reportRoom = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CustomReportConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Metadata operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: Metadata
    /// 
    /// $query = New-RscQueryReport -Metadata
    /// 
    /// # OPTIONAL
    /// $query.Var.searchTerm = $someString
    /// # OPTIONAL
    /// $query.Var.polarisReportsFilters = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		field = $somePolarisReportsFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolarisReportsFilterType]) for enum values.
    /// 		# OPTIONAL
    /// 		text = $someString
    /// 		# OPTIONAL
    /// 		reportViewTypes = @(
    /// 			$somePolarisReportViewType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolarisReportViewType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		reportRooms = @(
    /// 			$someReportRoomType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportRoomType]) for enum values.
    /// 		)
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;ReportMetadata&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PolarisConfig operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: PolarisConfig
    /// 
    /// $query = New-RscQueryReport -PolarisConfig
    /// 
    /// # REQUIRED
    /// $query.Var.reportID = $someInt
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PolarisReportConfig
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PolarisTableIntrospection operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: PolarisTableIntrospection
    /// 
    /// $query = New-RscQueryReport -PolarisTableIntrospection
    /// 
    /// # REQUIRED
    /// $query.Var.tableView = $someTableViewType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TableViewType]) for enum values.
    /// # REQUIRED
    /// $query.Var.reportRoom = $someReportRoomType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportRoomType]) for enum values.
    /// # OPTIONAL
    /// $query.Var.reportId = $someInt
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PolarisReportTableIntrospection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Polarischema operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: Polarischema
    /// 
    /// $query = New-RscQueryReport -Polarischema
    /// 
    /// # REQUIRED
    /// $query.Var.polarisReportViewType = $somePolarisReportViewType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolarisReportViewType]) for enum values.
    /// # REQUIRED
    /// $query.Var.reportRoom = $someReportRoomType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportRoomType]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PolarisReportSchema
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Report operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: Report
    /// 
    /// $query = New-RscQueryReport -Report
    /// 
    /// # REQUIRED
    /// $query.Var.id = $someInt
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CustomReport
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RscConfigs operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: RscConfigs
    /// 
    /// $query = New-RscQueryReport -RscConfigs
    /// 
    /// # OPTIONAL
    /// $query.Var.polarisReportsFilters = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		field = $somePolarisReportsFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolarisReportsFilterType]) for enum values.
    /// 		# OPTIONAL
    /// 		text = $someString
    /// 		# OPTIONAL
    /// 		reportViewTypes = @(
    /// 			$somePolarisReportViewType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolarisReportViewType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		reportRooms = @(
    /// 			$someReportRoomType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportRoomType]) for enum values.
    /// 		)
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;PolarisReportConfig&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the S3BucketSnapshotDownloadUrl operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: S3BucketSnapshotDownloadUrl
    /// 
    /// $query = New-RscQueryReport -S3BucketSnapshotDownloadUrl
    /// 
    /// # REQUIRED
    /// $query.Var.awsAccountRubrikId = $someString
    /// # REQUIRED
    /// $query.Var.snapshotId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: S3BucketDownloadUrlReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ScheduledReport operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: ScheduledReport
    /// 
    /// $query = New-RscQueryReport -ScheduledReport
    /// 
    /// # REQUIRED
    /// $query.Var.id = $someInt
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ScheduledReport
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ScheduledReports operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: ScheduledReports
    /// 
    /// $query = New-RscQueryReport -ScheduledReports
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	reportId = $someInt
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ScheduledReportConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Screenshot operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: Screenshot
    /// 
    /// $query = New-RscQueryReport -Screenshot
    /// 
    /// # REQUIRED
    /// $query.Var.reportId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TakeScreenshotReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Sonar operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: Sonar
    /// 
    /// $query = New-RscQueryReport -Sonar
    /// 
    /// # REQUIRED
    /// $query.Var.sonarReportGroupBy = $someDiscoveryReportGroupBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DiscoveryReportGroupBy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.timeFilter = @{
    /// 	# OPTIONAL
    /// 	endTime = $someString
    /// 	# OPTIONAL
    /// 	startTime = $someString
    /// 	# OPTIONAL
    /// 	timeDuration = $someTimeDuration # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TimeDuration]) for enum values.
    /// 	# OPTIONAL
    /// 	timezone = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SonarReportConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SonarContent operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: SonarContent
    /// 
    /// $query = New-RscQueryReport -SonarContent
    /// 
    /// # REQUIRED
    /// $query.Var.groupBy = $someDiscoveryContentReportGroupBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DiscoveryContentReportGroupBy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortBy = $someDiscoveryContentReportSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DiscoveryContentReportSortBy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filters = @{
    /// 	# OPTIONAL
    /// 	search = $someString
    /// 	# OPTIONAL
    /// 	policyIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	clusterIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	applyWhitelists = $someBoolean
    /// 	# OPTIONAL
    /// 	subscriptionIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	objectTypes = @(
    /// 		$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
    /// 	)
    /// }
    /// # REQUIRED
    /// $query.Var.day = $someString
    /// # REQUIRED
    /// $query.Var.timezone = $someString
    /// # REQUIRED
    /// $query.Var.workloadTypes = @(
    /// 	$someDataGovObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataGovObjectType]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SonarContentReportConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SonarRow operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: SonarRow
    /// 
    /// $query = New-RscQueryReport -SonarRow
    /// 
    /// # OPTIONAL
    /// $query.Var.sortBy = $someDiscoveryReportSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DiscoveryReportSortBy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.endTime = $someString
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SonarReportRowConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TableData operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: TableData
    /// 
    /// $query = New-RscQueryReport -TableData
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # REQUIRED
    /// $query.Var.tableView = $someTableViewType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TableViewType]) for enum values.
    /// # REQUIRED
    /// $query.Var.reportRoom = $someReportRoomType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportRoomType]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filters = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		name = $someString
    /// 		# REQUIRED
    /// 		values = @(
    /// 			$someString
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.sortBy = $someString
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.timezone = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RowConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Trial operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: Trial
    /// 
    /// $query = New-RscQueryReport -Trial
    /// 
    /// # REQUIRED
    /// $query.Var.trialId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TrialReport
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TrialDownloadURL operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: TrialDownloadURL
    /// 
    /// $query = New-RscQueryReport -TrialDownloadURL
    /// 
    /// # REQUIRED
    /// $query.Var.trialId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TrialReportDownloadUrl
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Version operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: Version
    /// 
    /// $query = New-RscQueryReport -Version
    /// 
    /// # REQUIRED
    /// $query.Var.reportID = $someInt
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ReportVersion
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
        "RscQueryReport",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryReport : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "ChartData",
                "Chema",
                "ClusterMigrationCount",
                "ClusterMigrationJobStatus",
                "ClusterMigrationStatus",
                "Config",
                "Configs",
                "Data",
                "DatabaseLogForCluster",
                "DatabaseLogingPropertiesForCluster",
                "Failover",
                "FailoverJob",
                "FromConfig",
                "GenerateNasMigration",
                "GroupByList",
                "List",
                "Metadata",
                "PolarisConfig",
                "PolarisTableIntrospection",
                "Polarischema",
                "Report",
                "RscConfigs",
                "S3BucketSnapshotDownloadUrl",
                "ScheduledReport",
                "ScheduledReports",
                "Screenshot",
                "Sonar",
                "SonarContent",
                "SonarRow",
                "TableData",
                "Trial",
                "TrialDownloadURL",
                "Version",
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
                    case "ChartData":
                        this.ProcessRecord_ChartData();
                        break;
                    case "Chema":
                        this.ProcessRecord_Chema();
                        break;
                    case "ClusterMigrationCount":
                        this.ProcessRecord_ClusterMigrationCount();
                        break;
                    case "ClusterMigrationJobStatus":
                        this.ProcessRecord_ClusterMigrationJobStatus();
                        break;
                    case "ClusterMigrationStatus":
                        this.ProcessRecord_ClusterMigrationStatus();
                        break;
                    case "Config":
                        this.ProcessRecord_Config();
                        break;
                    case "Configs":
                        this.ProcessRecord_Configs();
                        break;
                    case "Data":
                        this.ProcessRecord_Data();
                        break;
                    case "DatabaseLogForCluster":
                        this.ProcessRecord_DatabaseLogForCluster();
                        break;
                    case "DatabaseLogingPropertiesForCluster":
                        this.ProcessRecord_DatabaseLogingPropertiesForCluster();
                        break;
                    case "Failover":
                        this.ProcessRecord_Failover();
                        break;
                    case "FailoverJob":
                        this.ProcessRecord_FailoverJob();
                        break;
                    case "FromConfig":
                        this.ProcessRecord_FromConfig();
                        break;
                    case "GenerateNasMigration":
                        this.ProcessRecord_GenerateNasMigration();
                        break;
                    case "GroupByList":
                        this.ProcessRecord_GroupByList();
                        break;
                    case "List":
                        this.ProcessRecord_List();
                        break;
                    case "Metadata":
                        this.ProcessRecord_Metadata();
                        break;
                    case "PolarisConfig":
                        this.ProcessRecord_PolarisConfig();
                        break;
                    case "PolarisTableIntrospection":
                        this.ProcessRecord_PolarisTableIntrospection();
                        break;
                    case "Polarischema":
                        this.ProcessRecord_Polarischema();
                        break;
                    case "Report":
                        this.ProcessRecord_Report();
                        break;
                    case "RscConfigs":
                        this.ProcessRecord_RscConfigs();
                        break;
                    case "S3BucketSnapshotDownloadUrl":
                        this.ProcessRecord_S3BucketSnapshotDownloadUrl();
                        break;
                    case "ScheduledReport":
                        this.ProcessRecord_ScheduledReport();
                        break;
                    case "ScheduledReports":
                        this.ProcessRecord_ScheduledReports();
                        break;
                    case "Screenshot":
                        this.ProcessRecord_Screenshot();
                        break;
                    case "Sonar":
                        this.ProcessRecord_Sonar();
                        break;
                    case "SonarContent":
                        this.ProcessRecord_SonarContent();
                        break;
                    case "SonarRow":
                        this.ProcessRecord_SonarRow();
                        break;
                    case "TableData":
                        this.ProcessRecord_TableData();
                        break;
                    case "Trial":
                        this.ProcessRecord_Trial();
                        break;
                    case "TrialDownloadURL":
                        this.ProcessRecord_TrialDownloadURL();
                        break;
                    case "Version":
                        this.ProcessRecord_Version();
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
        // reportChartData.
        internal void ProcessRecord_ChartData()
        {
            this._logger.name += " -ChartData";
            // Create new graphql operation reportChartData
            InitQueryReportChartData();
        }

        // This parameter set invokes a single graphql operation:
        // reportSchema.
        internal void ProcessRecord_Chema()
        {
            this._logger.name += " -Chema";
            // Create new graphql operation reportSchema
            InitQueryReportSchema();
        }

        // This parameter set invokes a single graphql operation:
        // clusterReportMigrationCount.
        internal void ProcessRecord_ClusterMigrationCount()
        {
            this._logger.name += " -ClusterMigrationCount";
            // Create new graphql operation clusterReportMigrationCount
            InitQueryClusterReportMigrationCount();
        }

        // This parameter set invokes a single graphql operation:
        // clusterReportMigrationJobStatus.
        internal void ProcessRecord_ClusterMigrationJobStatus()
        {
            this._logger.name += " -ClusterMigrationJobStatus";
            // Create new graphql operation clusterReportMigrationJobStatus
            InitQueryClusterReportMigrationJobStatus();
        }

        // This parameter set invokes a single graphql operation:
        // clusterReportMigrationStatus.
        internal void ProcessRecord_ClusterMigrationStatus()
        {
            this._logger.name += " -ClusterMigrationStatus";
            // Create new graphql operation clusterReportMigrationStatus
            InitQueryClusterReportMigrationStatus();
        }

        // This parameter set invokes a single graphql operation:
        // reportConfig.
        internal void ProcessRecord_Config()
        {
            this._logger.name += " -Config";
            // Create new graphql operation reportConfig
            InitQueryReportConfig();
        }

        // This parameter set invokes a single graphql operation:
        // allReportConfigs.
        internal void ProcessRecord_Configs()
        {
            this._logger.name += " -Configs";
            // Create new graphql operation allReportConfigs
            InitQueryAllReportConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // reportData.
        internal void ProcessRecord_Data()
        {
            this._logger.name += " -Data";
            // Create new graphql operation reportData
            InitQueryReportData();
        }

        // This parameter set invokes a single graphql operation:
        // databaseLogReportForCluster.
        internal void ProcessRecord_DatabaseLogForCluster()
        {
            this._logger.name += " -DatabaseLogForCluster";
            // Create new graphql operation databaseLogReportForCluster
            InitQueryDatabaseLogReportForCluster();
        }

        // This parameter set invokes a single graphql operation:
        // databaseLogReportingPropertiesForCluster.
        internal void ProcessRecord_DatabaseLogingPropertiesForCluster()
        {
            this._logger.name += " -DatabaseLogingPropertiesForCluster";
            // Create new graphql operation databaseLogReportingPropertiesForCluster
            InitQueryDatabaseLogReportingPropertiesForCluster();
        }

        // This parameter set invokes a single graphql operation:
        // failoverReport.
        internal void ProcessRecord_Failover()
        {
            this._logger.name += " -Failover";
            // Create new graphql operation failoverReport
            InitQueryFailoverReport();
        }

        // This parameter set invokes a single graphql operation:
        // allFailoverJobReports.
        internal void ProcessRecord_FailoverJob()
        {
            this._logger.name += " -FailoverJob";
            // Create new graphql operation allFailoverJobReports
            InitQueryAllFailoverJobReports();
        }

        // This parameter set invokes a single graphql operation:
        // reportFromConfig.
        internal void ProcessRecord_FromConfig()
        {
            this._logger.name += " -FromConfig";
            // Create new graphql operation reportFromConfig
            InitQueryReportFromConfig();
        }

        // This parameter set invokes a single graphql operation:
        // generateNasMigrationReport.
        internal void ProcessRecord_GenerateNasMigration()
        {
            this._logger.name += " -GenerateNasMigration";
            // Create new graphql operation generateNasMigrationReport
            InitQueryGenerateNasMigrationReport();
        }

        // This parameter set invokes a single graphql operation:
        // reportGroupByConnection.
        internal void ProcessRecord_GroupByList()
        {
            this._logger.name += " -GroupByList";
            // Create new graphql operation reportGroupByConnection
            InitQueryReportGroupByConnection();
        }

        // This parameter set invokes a single graphql operation:
        // reportConnection.
        internal void ProcessRecord_List()
        {
            this._logger.name += " -List";
            // Create new graphql operation reportConnection
            InitQueryReportConnection();
        }

        // This parameter set invokes a single graphql operation:
        // allReportMetadata.
        internal void ProcessRecord_Metadata()
        {
            this._logger.name += " -Metadata";
            // Create new graphql operation allReportMetadata
            InitQueryAllReportMetadata();
        }

        // This parameter set invokes a single graphql operation:
        // polarisReportConfig.
        internal void ProcessRecord_PolarisConfig()
        {
            this._logger.name += " -PolarisConfig";
            // Create new graphql operation polarisReportConfig
            InitQueryPolarisReportConfig();
        }

        // This parameter set invokes a single graphql operation:
        // polarisReportTableIntrospection.
        internal void ProcessRecord_PolarisTableIntrospection()
        {
            this._logger.name += " -PolarisTableIntrospection";
            // Create new graphql operation polarisReportTableIntrospection
            InitQueryPolarisReportTableIntrospection();
        }

        // This parameter set invokes a single graphql operation:
        // polarisReportSchema.
        internal void ProcessRecord_Polarischema()
        {
            this._logger.name += " -Polarischema";
            // Create new graphql operation polarisReportSchema
            InitQueryPolarisReportSchema();
        }

        // This parameter set invokes a single graphql operation:
        // report.
        internal void ProcessRecord_Report()
        {
            this._logger.name += " -Report";
            // Create new graphql operation report
            InitQueryReport();
        }

        // This parameter set invokes a single graphql operation:
        // allRscReportConfigs.
        internal void ProcessRecord_RscConfigs()
        {
            this._logger.name += " -RscConfigs";
            // Create new graphql operation allRscReportConfigs
            InitQueryAllRscReportConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // s3BucketSnapshotReportDownloadUrl.
        internal void ProcessRecord_S3BucketSnapshotDownloadUrl()
        {
            this._logger.name += " -S3BucketSnapshotDownloadUrl";
            // Create new graphql operation s3BucketSnapshotReportDownloadUrl
            InitQueryS3BucketSnapshotReportDownloadUrl();
        }

        // This parameter set invokes a single graphql operation:
        // scheduledReport.
        internal void ProcessRecord_ScheduledReport()
        {
            this._logger.name += " -ScheduledReport";
            // Create new graphql operation scheduledReport
            InitQueryScheduledReport();
        }

        // This parameter set invokes a single graphql operation:
        // scheduledReports.
        internal void ProcessRecord_ScheduledReports()
        {
            this._logger.name += " -ScheduledReports";
            // Create new graphql operation scheduledReports
            InitQueryScheduledReports();
        }

        // This parameter set invokes a single graphql operation:
        // screenshotReport.
        internal void ProcessRecord_Screenshot()
        {
            this._logger.name += " -Screenshot";
            // Create new graphql operation screenshotReport
            InitQueryScreenshotReport();
        }

        // This parameter set invokes a single graphql operation:
        // sonarReport.
        internal void ProcessRecord_Sonar()
        {
            this._logger.name += " -Sonar";
            // Create new graphql operation sonarReport
            InitQuerySonarReport();
        }

        // This parameter set invokes a single graphql operation:
        // sonarContentReport.
        internal void ProcessRecord_SonarContent()
        {
            this._logger.name += " -SonarContent";
            // Create new graphql operation sonarContentReport
            InitQuerySonarContentReport();
        }

        // This parameter set invokes a single graphql operation:
        // sonarReportRow.
        internal void ProcessRecord_SonarRow()
        {
            this._logger.name += " -SonarRow";
            // Create new graphql operation sonarReportRow
            InitQuerySonarReportRow();
        }

        // This parameter set invokes a single graphql operation:
        // reportTableData.
        internal void ProcessRecord_TableData()
        {
            this._logger.name += " -TableData";
            // Create new graphql operation reportTableData
            InitQueryReportTableData();
        }

        // This parameter set invokes a single graphql operation:
        // trialReport.
        internal void ProcessRecord_Trial()
        {
            this._logger.name += " -Trial";
            // Create new graphql operation trialReport
            InitQueryTrialReport();
        }

        // This parameter set invokes a single graphql operation:
        // trialReportDownloadURL.
        internal void ProcessRecord_TrialDownloadURL()
        {
            this._logger.name += " -TrialDownloadURL";
            // Create new graphql operation trialReportDownloadURL
            InitQueryTrialReportDownloadUrl();
        }

        // This parameter set invokes a single graphql operation:
        // reportVersion.
        internal void ProcessRecord_Version()
        {
            this._logger.name += " -Version";
            // Create new graphql operation reportVersion
            InitQueryReportVersion();
        }


        // Create new GraphQL Query:
        // reportChartData(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     chartView: ChartViewType!
        //     reportRoom: ReportRoomType! = REPORT_ROOM_NONE
        //     filters: [ReportFilterInput!]
        //     timezone: String
        //   ): ChartDataResult!
        internal void InitQueryReportChartData()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("chartView", "ChartViewType!"),
                Tuple.Create("reportRoom", "ReportRoomType!"),
                Tuple.Create("filters", "[ReportFilterInput!]"),
                Tuple.Create("timezone", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryReportChartData",
                "($first: Int,$after: String,$last: Int,$before: String,$chartView: ChartViewType!,$reportRoom: ReportRoomType!,$filters: [ReportFilterInput!],$timezone: String)",
                "ChartDataResult",
                Query.ReportChartData,
                Query.ReportChartDataFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# REQUIRED
$query.Var.chartView = $someChartViewType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChartViewType]) for enum values.
# REQUIRED
$query.Var.reportRoom = $someReportRoomType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportRoomType]) for enum values.
# OPTIONAL
$query.Var.filters = @(
	@{
		# REQUIRED
		name = $someString
		# REQUIRED
		values = @(
			$someString
		)
}
)
# OPTIONAL
$query.Var.timezone = $someString"
            );
        }

        // Create new GraphQL Query:
        // reportSchema(dataView: DataViewTypeEnum!, timezone: String): ReportSchema!
        internal void InitQueryReportSchema()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("dataView", "DataViewTypeEnum!"),
                Tuple.Create("timezone", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryReportSchema",
                "($dataView: DataViewTypeEnum!,$timezone: String)",
                "ReportSchema",
                Query.ReportSchema,
                Query.ReportSchemaFieldSpec,
                @"# REQUIRED
$query.Var.dataView = $someDataViewTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataViewTypeEnum]) for enum values.
# OPTIONAL
$query.Var.timezone = $someString"
            );
        }

        // Create new GraphQL Query:
        // clusterReportMigrationCount(clusterUuid: UUID, status: [CdmReportMigrationStatus!]!): ReportsMigrationCount!
        internal void InitQueryClusterReportMigrationCount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID"),
                Tuple.Create("status", "[CdmReportMigrationStatus!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterReportMigrationCount",
                "($clusterUuid: UUID,$status: [CdmReportMigrationStatus!]!)",
                "ReportsMigrationCount",
                Query.ClusterReportMigrationCount,
                Query.ClusterReportMigrationCountFieldSpec,
                @"# OPTIONAL
$query.Var.clusterUuid = $someString
# REQUIRED
$query.Var.status = @(
	$someCdmReportMigrationStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmReportMigrationStatus]) for enum values.
)"
            );
        }

        // Create new GraphQL Query:
        // clusterReportMigrationJobStatus(clusterUuid: UUID): ClusterReportMigrationJobStatus!
        internal void InitQueryClusterReportMigrationJobStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterReportMigrationJobStatus",
                "($clusterUuid: UUID)",
                "ClusterReportMigrationJobStatus",
                Query.ClusterReportMigrationJobStatus,
                Query.ClusterReportMigrationJobStatusFieldSpec,
                @"# OPTIONAL
$query.Var.clusterUuid = $someString"
            );
        }

        // Create new GraphQL Query:
        // clusterReportMigrationStatus(
        //     clusterUuid: UUID
        //     status: [CdmReportMigrationStatus!]!
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): ReportMigrationStatusConnection!
        internal void InitQueryClusterReportMigrationStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID"),
                Tuple.Create("status", "[CdmReportMigrationStatus!]!"),
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterReportMigrationStatus",
                "($clusterUuid: UUID,$status: [CdmReportMigrationStatus!]!,$first: Int,$after: String,$last: Int,$before: String)",
                "ReportMigrationStatusConnection",
                Query.ClusterReportMigrationStatus,
                Query.ClusterReportMigrationStatusFieldSpec,
                @"# OPTIONAL
$query.Var.clusterUuid = $someString
# REQUIRED
$query.Var.status = @(
	$someCdmReportMigrationStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmReportMigrationStatus]) for enum values.
)
# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString"
            );
        }

        // Create new GraphQL Query:
        // reportConfig(reportID: Int!): ReportConfig!
        internal void InitQueryReportConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("reportID", "Int!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryReportConfig",
                "($reportID: Int!)",
                "ReportConfig",
                Query.ReportConfig,
                Query.ReportConfigFieldSpec,
                @"# REQUIRED
$query.Var.reportID = $someInt"
            );
        }

        // Create new GraphQL Query:
        // allReportConfigs(dataView: DataViewTypeEnum, searchTerm: String, createdBy: String): [ReportConfig!]!
        internal void InitQueryAllReportConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("dataView", "DataViewTypeEnum"),
                Tuple.Create("searchTerm", "String"),
                Tuple.Create("createdBy", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllReportConfigs",
                "($dataView: DataViewTypeEnum,$searchTerm: String,$createdBy: String)",
                "List<ReportConfig>",
                Query.AllReportConfigs,
                Query.AllReportConfigsFieldSpec,
                @"# OPTIONAL
$query.Var.dataView = $someDataViewTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataViewTypeEnum]) for enum values.
# OPTIONAL
$query.Var.searchTerm = $someString
# OPTIONAL
$query.Var.createdBy = $someString"
            );
        }

        // Create new GraphQL Query:
        // reportData(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     dataView: DataViewTypeEnum!
        //     columns: [String!]!
        //     filters: [ReportFilterInput!]
        //     groupBy: [String!]
        //     secondaryGroupBy: String
        //     aggregations: [String!]
        //     sortBy: String
        //     sortOrder: SortOrder
        //     timezone: String
        //   ): RowConnection!
        internal void InitQueryReportData()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("dataView", "DataViewTypeEnum!"),
                Tuple.Create("columns", "[String!]!"),
                Tuple.Create("filters", "[ReportFilterInput!]"),
                Tuple.Create("groupBy", "[String!]"),
                Tuple.Create("secondaryGroupBy", "String"),
                Tuple.Create("aggregations", "[String!]"),
                Tuple.Create("sortBy", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("timezone", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryReportData",
                "($first: Int,$after: String,$last: Int,$before: String,$dataView: DataViewTypeEnum!,$columns: [String!]!,$filters: [ReportFilterInput!],$groupBy: [String!],$secondaryGroupBy: String,$aggregations: [String!],$sortBy: String,$sortOrder: SortOrder,$timezone: String)",
                "RowConnection",
                Query.ReportData,
                Query.ReportDataFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# REQUIRED
$query.Var.dataView = $someDataViewTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataViewTypeEnum]) for enum values.
# REQUIRED
$query.Var.columns = @(
	$someString
)
# OPTIONAL
$query.Var.filters = @(
	@{
		# REQUIRED
		name = $someString
		# REQUIRED
		values = @(
			$someString
		)
}
)
# OPTIONAL
$query.Var.groupBy = @(
	$someString
)
# OPTIONAL
$query.Var.secondaryGroupBy = $someString
# OPTIONAL
$query.Var.aggregations = @(
	$someString
)
# OPTIONAL
$query.Var.sortBy = $someString
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.timezone = $someString"
            );
        }

        // Create new GraphQL Query:
        // databaseLogReportForCluster(input: QueryLogReportInput!): DbLogReportSummaryListReply!
        internal void InitQueryDatabaseLogReportForCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryLogReportInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDatabaseLogReportForCluster",
                "($input: QueryLogReportInput!)",
                "DbLogReportSummaryListReply",
                Query.DatabaseLogReportForCluster,
                Query.DatabaseLogReportForClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	name = $someString
	# OPTIONAL
	logBackupDelay = $someInt
	# OPTIONAL
	limit = $someInt
	# OPTIONAL
	offset = $someInt
	# OPTIONAL
	effectiveSlaDomainId = $someString
	# OPTIONAL
	databaseType = $someString
	# OPTIONAL
	location = $someString
	# OPTIONAL
	sortBy = $someV1QueryLogReportRequestSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryLogReportRequestSortBy]) for enum values.
	# OPTIONAL
	sortOrder = $someV1QueryLogReportRequestSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryLogReportRequestSortOrder]) for enum values.
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // databaseLogReportingPropertiesForCluster(input: QueryReportPropertiesInput!): DbLogReportProperties!
        internal void InitQueryDatabaseLogReportingPropertiesForCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryReportPropertiesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDatabaseLogReportingPropertiesForCluster",
                "($input: QueryReportPropertiesInput!)",
                "DbLogReportProperties",
                Query.DatabaseLogReportingPropertiesForCluster,
                Query.DatabaseLogReportingPropertiesForClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // failoverReport(failoverReportId: String!): FailoverReport
        internal void InitQueryFailoverReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("failoverReportId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryFailoverReport",
                "($failoverReportId: String!)",
                "FailoverReport",
                Query.FailoverReport,
                Query.FailoverReportFieldSpec,
                @"# REQUIRED
$query.Var.failoverReportId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allFailoverJobReports(fid: UUID!, recoveryJobID: String): [FailoverJobReport!]!
        internal void InitQueryAllFailoverJobReports()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
                Tuple.Create("recoveryJobID", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllFailoverJobReports",
                "($fid: UUID!,$recoveryJobID: String)",
                "List<FailoverJobReport>",
                Query.AllFailoverJobReports,
                Query.AllFailoverJobReportsFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString
# OPTIONAL
$query.Var.recoveryJobID = $someString"
            );
        }

        // Create new GraphQL Query:
        // reportFromConfig(config: CustomReportCreate!): CustomReport!
        internal void InitQueryReportFromConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("config", "CustomReportCreate!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryReportFromConfig",
                "($config: CustomReportCreate!)",
                "CustomReport",
                Query.ReportFromConfig,
                Query.ReportFromConfigFieldSpec,
                @"# REQUIRED
$query.Var.config = @{
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
}"
            );
        }

        // Create new GraphQL Query:
        // generateNasMigrationReport(first: Int, after: String, hostIds: [String!]!): NasMigrationHostDetailConnection!
        internal void InitQueryGenerateNasMigrationReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("hostIds", "[String!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGenerateNasMigrationReport",
                "($first: Int,$after: String,$hostIds: [String!]!)",
                "NasMigrationHostDetailConnection",
                Query.GenerateNasMigrationReport,
                Query.GenerateNasMigrationReportFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.hostIds = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // reportGroupByConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     groupBy: CustomReportGroupByEnum!
        //     filter: CustomReportFilterInput
        //   ): CustomReportGroupByConnection!
        internal void InitQueryReportGroupByConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("groupBy", "CustomReportGroupByEnum!"),
                Tuple.Create("filter", "CustomReportFilterInput"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryReportGroupByConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$groupBy: CustomReportGroupByEnum!,$filter: CustomReportFilterInput)",
                "CustomReportGroupByConnection",
                Query.ReportGroupByConnection,
                Query.ReportGroupByConnectionFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# REQUIRED
$query.Var.groupBy = $someCustomReportGroupByEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CustomReportGroupByEnum]) for enum values.
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	focus = $someReportFocusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportFocusEnum]) for enum values.
	# OPTIONAL
	isHidden = $someBoolean
	# OPTIONAL
	isReadOnly = $someBoolean
	# OPTIONAL
	creationTime_gt = $someDateTime
	# OPTIONAL
	creationTime_lt = $someDateTime
	# OPTIONAL
	searchTerm = $someString
	# OPTIONAL
	createdBy = $someString
	# OPTIONAL
	reportRoom = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // reportConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     sortBy: CustomReportSortByEnum = UpdateTime
        //     filter: CustomReportFilterInput
        //   ): CustomReportConnection!
        internal void InitQueryReportConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "CustomReportSortByEnum"),
                Tuple.Create("filter", "CustomReportFilterInput"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryReportConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: CustomReportSortByEnum,$filter: CustomReportFilterInput)",
                "CustomReportConnection",
                Query.ReportConnection,
                Query.ReportConnectionFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.sortBy = $someCustomReportSortByEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CustomReportSortByEnum]) for enum values.
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	focus = $someReportFocusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportFocusEnum]) for enum values.
	# OPTIONAL
	isHidden = $someBoolean
	# OPTIONAL
	isReadOnly = $someBoolean
	# OPTIONAL
	creationTime_gt = $someDateTime
	# OPTIONAL
	creationTime_lt = $someDateTime
	# OPTIONAL
	searchTerm = $someString
	# OPTIONAL
	createdBy = $someString
	# OPTIONAL
	reportRoom = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // allReportMetadata(searchTerm: String, polarisReportsFilters: [PolarisReportsFilterInput!]): [ReportMetadata!]!
        internal void InitQueryAllReportMetadata()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("searchTerm", "String"),
                Tuple.Create("polarisReportsFilters", "[PolarisReportsFilterInput!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllReportMetadata",
                "($searchTerm: String,$polarisReportsFilters: [PolarisReportsFilterInput!])",
                "List<ReportMetadata>",
                Query.AllReportMetadata,
                Query.AllReportMetadataFieldSpec,
                @"# OPTIONAL
$query.Var.searchTerm = $someString
# OPTIONAL
$query.Var.polarisReportsFilters = @(
	@{
		# REQUIRED
		field = $somePolarisReportsFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolarisReportsFilterType]) for enum values.
		# OPTIONAL
		text = $someString
		# OPTIONAL
		reportViewTypes = @(
			$somePolarisReportViewType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolarisReportViewType]) for enum values.
		)
		# OPTIONAL
		reportRooms = @(
			$someReportRoomType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportRoomType]) for enum values.
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // polarisReportConfig(reportID: Int!): PolarisReportConfig!
        internal void InitQueryPolarisReportConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("reportID", "Int!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryPolarisReportConfig",
                "($reportID: Int!)",
                "PolarisReportConfig",
                Query.PolarisReportConfig,
                Query.PolarisReportConfigFieldSpec,
                @"# REQUIRED
$query.Var.reportID = $someInt"
            );
        }

        // Create new GraphQL Query:
        // polarisReportTableIntrospection(tableView: TableViewType!, reportRoom: ReportRoomType! = REPORT_ROOM_NONE, reportId: Int): PolarisReportTableIntrospection!
        internal void InitQueryPolarisReportTableIntrospection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tableView", "TableViewType!"),
                Tuple.Create("reportRoom", "ReportRoomType!"),
                Tuple.Create("reportId", "Int"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryPolarisReportTableIntrospection",
                "($tableView: TableViewType!,$reportRoom: ReportRoomType!,$reportId: Int)",
                "PolarisReportTableIntrospection",
                Query.PolarisReportTableIntrospection,
                Query.PolarisReportTableIntrospectionFieldSpec,
                @"# REQUIRED
$query.Var.tableView = $someTableViewType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TableViewType]) for enum values.
# REQUIRED
$query.Var.reportRoom = $someReportRoomType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportRoomType]) for enum values.
# OPTIONAL
$query.Var.reportId = $someInt"
            );
        }

        // Create new GraphQL Query:
        // polarisReportSchema(polarisReportViewType: PolarisReportViewType!, reportRoom: ReportRoomType! = REPORT_ROOM_NONE): PolarisReportSchema!
        internal void InitQueryPolarisReportSchema()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("polarisReportViewType", "PolarisReportViewType!"),
                Tuple.Create("reportRoom", "ReportRoomType!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryPolarisReportSchema",
                "($polarisReportViewType: PolarisReportViewType!,$reportRoom: ReportRoomType!)",
                "PolarisReportSchema",
                Query.PolarisReportSchema,
                Query.PolarisReportSchemaFieldSpec,
                @"# REQUIRED
$query.Var.polarisReportViewType = $somePolarisReportViewType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolarisReportViewType]) for enum values.
# REQUIRED
$query.Var.reportRoom = $someReportRoomType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportRoomType]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // report(id: Int!): CustomReport!
        internal void InitQueryReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("id", "Int!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryReport",
                "($id: Int!)",
                "CustomReport",
                Query.Report,
                Query.ReportFieldSpec,
                @"# REQUIRED
$query.Var.id = $someInt"
            );
        }

        // Create new GraphQL Query:
        // allRscReportConfigs(polarisReportsFilters: [PolarisReportsFilterInput!]): [PolarisReportConfig!]!
        internal void InitQueryAllRscReportConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("polarisReportsFilters", "[PolarisReportsFilterInput!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllRscReportConfigs",
                "($polarisReportsFilters: [PolarisReportsFilterInput!])",
                "List<PolarisReportConfig>",
                Query.AllRscReportConfigs,
                Query.AllRscReportConfigsFieldSpec,
                @"# OPTIONAL
$query.Var.polarisReportsFilters = @(
	@{
		# REQUIRED
		field = $somePolarisReportsFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolarisReportsFilterType]) for enum values.
		# OPTIONAL
		text = $someString
		# OPTIONAL
		reportViewTypes = @(
			$somePolarisReportViewType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolarisReportViewType]) for enum values.
		)
		# OPTIONAL
		reportRooms = @(
			$someReportRoomType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportRoomType]) for enum values.
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // s3BucketSnapshotReportDownloadUrl(awsAccountRubrikId: UUID!, snapshotId: String!): S3BucketDownloadUrlReply!
        internal void InitQueryS3BucketSnapshotReportDownloadUrl()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("snapshotId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryS3BucketSnapshotReportDownloadUrl",
                "($awsAccountRubrikId: UUID!,$snapshotId: String!)",
                "S3BucketDownloadUrlReply",
                Query.S3BucketSnapshotReportDownloadUrl,
                Query.S3BucketSnapshotReportDownloadUrlFieldSpec,
                @"# REQUIRED
$query.Var.awsAccountRubrikId = $someString
# REQUIRED
$query.Var.snapshotId = $someString"
            );
        }

        // Create new GraphQL Query:
        // scheduledReport(id: Int!): ScheduledReport
        internal void InitQueryScheduledReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("id", "Int!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryScheduledReport",
                "($id: Int!)",
                "ScheduledReport",
                Query.ScheduledReport,
                Query.ScheduledReportFieldSpec,
                @"# REQUIRED
$query.Var.id = $someInt"
            );
        }

        // Create new GraphQL Query:
        // scheduledReports(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     filter: ScheduledReportFilterInput
        //   ): ScheduledReportConnection!
        internal void InitQueryScheduledReports()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("filter", "ScheduledReportFilterInput"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryScheduledReports",
                "($first: Int,$after: String,$last: Int,$before: String,$filter: ScheduledReportFilterInput)",
                "ScheduledReportConnection",
                Query.ScheduledReports,
                Query.ScheduledReportsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	reportId = $someInt
}"
            );
        }

        // Create new GraphQL Query:
        // screenshotReport(reportId: String!): TakeScreenshotReply!
        internal void InitQueryScreenshotReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("reportId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryScreenshotReport",
                "($reportId: String!)",
                "TakeScreenshotReply",
                Query.ScreenshotReport,
                Query.ScreenshotReportFieldSpec,
                @"# REQUIRED
$query.Var.reportId = $someString"
            );
        }

        // Create new GraphQL Query:
        // sonarReport(sonarReportGroupBy: DiscoveryReportGroupBy!, filter: [String!], timeFilter: TimeFilterInput): SonarReportConnection!
        internal void InitQuerySonarReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("sonarReportGroupBy", "DiscoveryReportGroupBy!"),
                Tuple.Create("filter", "[String!]"),
                Tuple.Create("timeFilter", "TimeFilterInput"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySonarReport",
                "($sonarReportGroupBy: DiscoveryReportGroupBy!,$filter: [String!],$timeFilter: TimeFilterInput)",
                "SonarReportConnection",
                Query.SonarReport,
                Query.SonarReportFieldSpec,
                @"# REQUIRED
$query.Var.sonarReportGroupBy = $someDiscoveryReportGroupBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DiscoveryReportGroupBy]) for enum values.
# OPTIONAL
$query.Var.filter = @(
	$someString
)
# OPTIONAL
$query.Var.timeFilter = @{
	# OPTIONAL
	endTime = $someString
	# OPTIONAL
	startTime = $someString
	# OPTIONAL
	timeDuration = $someTimeDuration # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TimeDuration]) for enum values.
	# OPTIONAL
	timezone = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // sonarContentReport(
        //     groupBy: DiscoveryContentReportGroupBy!
        //     sortBy: DiscoveryContentReportSortBy
        //     sortOrder: SortOrder
        //     filters: SonarContentReportFilter
        //     day: String!
        //     timezone: String!
        //     workloadTypes: [DataGovObjectType!]! = []
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): SonarContentReportConnection!
        internal void InitQuerySonarContentReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("groupBy", "DiscoveryContentReportGroupBy!"),
                Tuple.Create("sortBy", "DiscoveryContentReportSortBy"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filters", "SonarContentReportFilter"),
                Tuple.Create("day", "String!"),
                Tuple.Create("timezone", "String!"),
                Tuple.Create("workloadTypes", "[DataGovObjectType!]!"),
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySonarContentReport",
                "($groupBy: DiscoveryContentReportGroupBy!,$sortBy: DiscoveryContentReportSortBy,$sortOrder: SortOrder,$filters: SonarContentReportFilter,$day: String!,$timezone: String!,$workloadTypes: [DataGovObjectType!]!,$first: Int,$after: String,$last: Int,$before: String)",
                "SonarContentReportConnection",
                Query.SonarContentReport,
                Query.SonarContentReportFieldSpec,
                @"# REQUIRED
$query.Var.groupBy = $someDiscoveryContentReportGroupBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DiscoveryContentReportGroupBy]) for enum values.
# OPTIONAL
$query.Var.sortBy = $someDiscoveryContentReportSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DiscoveryContentReportSortBy]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filters = @{
	# OPTIONAL
	search = $someString
	# OPTIONAL
	policyIds = @(
		$someString
	)
	# OPTIONAL
	clusterIds = @(
		$someString
	)
	# OPTIONAL
	applyWhitelists = $someBoolean
	# OPTIONAL
	subscriptionIds = @(
		$someString
	)
	# REQUIRED
	objectTypes = @(
		$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
	)
}
# REQUIRED
$query.Var.day = $someString
# REQUIRED
$query.Var.timezone = $someString
# REQUIRED
$query.Var.workloadTypes = @(
	$someDataGovObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataGovObjectType]) for enum values.
)
# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString"
            );
        }

        // Create new GraphQL Query:
        // sonarReportRow(
        //     sortBy: DiscoveryReportSortBy
        //     sortOrder: SortOrder
        //     filter: [String!]
        //     endTime: String
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): SonarReportRowConnection!
        internal void InitQuerySonarReportRow()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("sortBy", "DiscoveryReportSortBy"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[String!]"),
                Tuple.Create("endTime", "String"),
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySonarReportRow",
                "($sortBy: DiscoveryReportSortBy,$sortOrder: SortOrder,$filter: [String!],$endTime: String,$first: Int,$after: String,$last: Int,$before: String)",
                "SonarReportRowConnection",
                Query.SonarReportRow,
                Query.SonarReportRowFieldSpec,
                @"# OPTIONAL
$query.Var.sortBy = $someDiscoveryReportSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DiscoveryReportSortBy]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filter = @(
	$someString
)
# OPTIONAL
$query.Var.endTime = $someString
# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString"
            );
        }

        // Create new GraphQL Query:
        // reportTableData(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     tableView: TableViewType!
        //     reportRoom: ReportRoomType! = REPORT_ROOM_NONE
        //     filters: [ReportFilterInput!]
        //     sortBy: String
        //     sortOrder: SortOrder
        //     timezone: String
        //   ): RowConnection!
        internal void InitQueryReportTableData()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("tableView", "TableViewType!"),
                Tuple.Create("reportRoom", "ReportRoomType!"),
                Tuple.Create("filters", "[ReportFilterInput!]"),
                Tuple.Create("sortBy", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("timezone", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryReportTableData",
                "($first: Int,$after: String,$last: Int,$before: String,$tableView: TableViewType!,$reportRoom: ReportRoomType!,$filters: [ReportFilterInput!],$sortBy: String,$sortOrder: SortOrder,$timezone: String)",
                "RowConnection",
                Query.ReportTableData,
                Query.ReportTableDataFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# REQUIRED
$query.Var.tableView = $someTableViewType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TableViewType]) for enum values.
# REQUIRED
$query.Var.reportRoom = $someReportRoomType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportRoomType]) for enum values.
# OPTIONAL
$query.Var.filters = @(
	@{
		# REQUIRED
		name = $someString
		# REQUIRED
		values = @(
			$someString
		)
}
)
# OPTIONAL
$query.Var.sortBy = $someString
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.timezone = $someString"
            );
        }

        // Create new GraphQL Query:
        // trialReport(trialId: UUID!): TrialReport!
        internal void InitQueryTrialReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("trialId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryTrialReport",
                "($trialId: UUID!)",
                "TrialReport",
                Query.TrialReport,
                Query.TrialReportFieldSpec,
                @"# REQUIRED
$query.Var.trialId = $someString"
            );
        }

        // Create new GraphQL Query:
        // trialReportDownloadURL(trialId: UUID!): TrialReportDownloadUrl!
        internal void InitQueryTrialReportDownloadUrl()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("trialId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryTrialReportDownloadUrl",
                "($trialId: UUID!)",
                "TrialReportDownloadUrl",
                Query.TrialReportDownloadUrl,
                Query.TrialReportDownloadUrlFieldSpec,
                @"# REQUIRED
$query.Var.trialId = $someString"
            );
        }

        // Create new GraphQL Query:
        // reportVersion(reportID: Int!): ReportVersion!
        internal void InitQueryReportVersion()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("reportID", "Int!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryReportVersion",
                "($reportID: Int!)",
                "ReportVersion",
                Query.ReportVersion,
                Query.ReportVersionFieldSpec,
                @"# REQUIRED
$query.Var.reportID = $someInt"
            );
        }


    } // class New_RscQueryReport
}