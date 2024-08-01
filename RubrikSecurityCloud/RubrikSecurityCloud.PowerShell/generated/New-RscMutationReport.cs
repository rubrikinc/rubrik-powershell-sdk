// New-RscMutationReport.cs
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
    /// Create a new RscQuery object for any of the 19
    /// operations in the 'Report' API domain:
    /// BlueprintFailoverGenerate, Create, CreateCustom, CreatePolaris, CreateScheduled, Delete, DeleteCustom, DeleteScheduledReport, RefreshTrial, SendPdf, SendScheduled, SendScheduledReportAsync, ShareTrial, StartClusterMigrationJob, Update, UpdateCustom, UpdateDatabaseLogingPropertiesForCluster, UpdatePolaris, or UpdateScheduledReport.
    /// </summary>
    /// <description>
    /// New-RscMutationReport creates a new
    /// mutation object for operations
    /// in the 'Report' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 19 operations
    /// in the 'Report' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: BlueprintFailoverGenerate, Create, CreateCustom, CreatePolaris, CreateScheduled, Delete, DeleteCustom, DeleteScheduledReport, RefreshTrial, SendPdf, SendScheduled, SendScheduledReportAsync, ShareTrial, StartClusterMigrationJob, Update, UpdateCustom, UpdateDatabaseLogingPropertiesForCluster, UpdatePolaris, or UpdateScheduledReport.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationReport -BlueprintFailoverGenerate).Info().
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
    /// (New-RscMutationReport -BlueprintFailoverGenerate).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the BlueprintFailoverGenerate operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: BlueprintFailoverGenerate
    /// 
    /// $query = New-RscMutationReport -BlueprintFailoverGenerate
    /// 
    /// # REQUIRED
    /// $query.Var.failoverReportGeneratorJobConfig = @{
    /// 	# REQUIRED
    /// 	failoverIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	isNewReportEnabled = $someBoolean
    /// 	# OPTIONAL
    /// 	timezoneOffset = $someSingle
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateOnDemandJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Create operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: Create
    /// 
    /// $query = New-RscMutationReport -Create
    /// 
    /// # REQUIRED
    /// $query.Var.reportConfig = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	dataViewType = $someDataViewTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataViewTypeEnum]) for enum values.
    /// 	# REQUIRED
    /// 	columns = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	groupBy = @{
    /// 		# REQUIRED
    /// 		groupById = $someString
    /// 		# REQUIRED
    /// 		aggregations = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# REQUIRED
    /// 	aggregations = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	filters = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			name = $someString
    /// 			# REQUIRED
    /// 			values = @(
    /// 				$someString
    /// 			)
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	sortBy = $someString
    /// 	# OPTIONAL
    /// 	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Int32
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateCustom operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: CreateCustom
    /// 
    /// $query = New-RscMutationReport -CreateCustom
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
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
    /// # OPTIONAL
    /// $query.Var.reportRoom = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateCustomReportReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreatePolaris operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: CreatePolaris
    /// 
    /// $query = New-RscMutationReport -CreatePolaris
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	reportViewType = $somePolarisReportViewType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolarisReportViewType]) for enum values.
    /// 	# OPTIONAL
    /// 	room = $someReportRoomType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportRoomType]) for enum values.
    /// 	# REQUIRED
    /// 	charts = @(
    /// 		$someChartViewType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChartViewType]) for enum values.
    /// 	)
    /// 	# REQUIRED
    /// 	table = $someTableViewType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TableViewType]) for enum values.
    /// 	# REQUIRED
    /// 	filters = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			name = $someString
    /// 			# REQUIRED
    /// 			values = @(
    /// 				$someString
    /// 			)
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	sortBy = $someString
    /// 	# OPTIONAL
    /// 	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreatePolarisReportReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateScheduled operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: CreateScheduled
    /// 
    /// $query = New-RscMutationReport -CreateScheduled
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	reportId = $someInt
    /// 	# REQUIRED
    /// 	title = $someString
    /// 	# OPTIONAL
    /// 	dailyTime = $someDateTime
    /// 	# OPTIONAL
    /// 	weeklyTime = $someDateTime
    /// 	# OPTIONAL
    /// 	monthlyDate = $someInt
    /// 	# OPTIONAL
    /// 	monthlyTime = $someDateTime
    /// 	# REQUIRED
    /// 	rubrikRecipientUserIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	nonRubrikRecipientEmails = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	updateCreator = $someBoolean
    /// 	# OPTIONAL
    /// 	timeZone = $someString
    /// 	# OPTIONAL
    /// 	weeklyDays = @(
    /// 		$someWeekDay # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WeekDay]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	attachmentTypes = @(
    /// 		$someReportAttachmentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportAttachmentType]) for enum values.
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateScheduledReportReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Delete operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: Delete
    /// 
    /// $query = New-RscMutationReport -Delete
    /// 
    /// # REQUIRED
    /// $query.Var.reportID = $someInt
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
    /// Runs the DeleteCustom operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: DeleteCustom
    /// 
    /// $query = New-RscMutationReport -DeleteCustom
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someInt
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
    /// Runs the DeleteScheduledReport operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: DeleteScheduledReport
    /// 
    /// $query = New-RscMutationReport -DeleteScheduledReport
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someInt
    /// 	# OPTIONAL
    /// 	reportId = $someInt
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
    /// Runs the RefreshTrial operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: RefreshTrial
    /// 
    /// $query = New-RscMutationReport -RefreshTrial
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	trialId = $someString
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
    /// Runs the SendPdf operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: SendPdf
    /// 
    /// $query = New-RscMutationReport -SendPdf
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	rubrikRecipientUserIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	nonRubrikRecipientEmailIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	password = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SendPdfReportReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SendScheduled operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: SendScheduled
    /// 
    /// $query = New-RscMutationReport -SendScheduled
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someInt
    /// 	# REQUIRED
    /// 	recipients = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	attachmentTypes = @(
    /// 		$someReportAttachmentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportAttachmentType]) for enum values.
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SendScheduledReportAsync operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: SendScheduledReportAsync
    /// 
    /// $query = New-RscMutationReport -SendScheduledReportAsync
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	reportId = $someInt
    /// 	# OPTIONAL
    /// 	rubrikUserIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	nonRubrikUserEmails = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	attachmentTypes = @(
    /// 		$someReportAttachmentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportAttachmentType]) for enum values.
    /// 	)
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
    /// Runs the ShareTrial operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: ShareTrial
    /// 
    /// $query = New-RscMutationReport -ShareTrial
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	trialId = $someString
    /// 	# REQUIRED
    /// 	recipientEmails = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ShareTrialReportReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartClusterMigrationJob operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: StartClusterMigrationJob
    /// 
    /// $query = New-RscMutationReport -StartClusterMigrationJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	clusterUuid = $someString
    /// 	# OPTIONAL
    /// 	shouldDeleteCdmSchedules = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: StartClusterReportMigrationJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Update operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: Update
    /// 
    /// $query = New-RscMutationReport -Update
    /// 
    /// # REQUIRED
    /// $query.Var.reportID = $someInt
    /// # REQUIRED
    /// $query.Var.reportConfig = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	dataViewType = $someDataViewTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataViewTypeEnum]) for enum values.
    /// 	# REQUIRED
    /// 	columns = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	groupBy = @{
    /// 		# REQUIRED
    /// 		groupById = $someString
    /// 		# REQUIRED
    /// 		aggregations = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# REQUIRED
    /// 	aggregations = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	filters = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			name = $someString
    /// 			# REQUIRED
    /// 			values = @(
    /// 				$someString
    /// 			)
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	sortBy = $someString
    /// 	# OPTIONAL
    /// 	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateCustom operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: UpdateCustom
    /// 
    /// $query = New-RscMutationReport -UpdateCustom
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someInt
    /// 	# REQUIRED
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
    /// Write-Host $result.GetType().Name # prints: UpdateCustomReportReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateDatabaseLogingPropertiesForCluster operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: UpdateDatabaseLogingPropertiesForCluster
    /// 
    /// $query = New-RscMutationReport -UpdateDatabaseLogingPropertiesForCluster
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	properties = @{
    /// 		# OPTIONAL
    /// 		enableDelayNotification = $someBoolean
    /// 		# OPTIONAL
    /// 		logDelayThresholdInMin = $someInt64
    /// 		# OPTIONAL
    /// 		logDelayNotificationFrequencyInMin = $someInt64
    /// 	}
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
    /// Runs the UpdatePolaris operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: UpdatePolaris
    /// 
    /// $query = New-RscMutationReport -UpdatePolaris
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	reportId = $someInt64
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	reportViewType = $somePolarisReportViewType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolarisReportViewType]) for enum values.
    /// 	# OPTIONAL
    /// 	room = $someReportRoomType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportRoomType]) for enum values.
    /// 	# REQUIRED
    /// 	charts = @(
    /// 		$someChartViewType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChartViewType]) for enum values.
    /// 	)
    /// 	# REQUIRED
    /// 	table = $someTableViewType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TableViewType]) for enum values.
    /// 	# REQUIRED
    /// 	filters = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			name = $someString
    /// 			# REQUIRED
    /// 			values = @(
    /// 				$someString
    /// 			)
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	sortBy = $someString
    /// 	# OPTIONAL
    /// 	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// 	# OPTIONAL
    /// 	displayableColumns = @(
    /// 		$someString
    /// 	)
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
    /// Runs the UpdateScheduledReport operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: UpdateScheduledReport
    /// 
    /// $query = New-RscMutationReport -UpdateScheduledReport
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someInt
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# REQUIRED
    /// 		reportId = $someInt
    /// 		# REQUIRED
    /// 		title = $someString
    /// 		# OPTIONAL
    /// 		dailyTime = $someDateTime
    /// 		# OPTIONAL
    /// 		weeklyTime = $someDateTime
    /// 		# OPTIONAL
    /// 		monthlyDate = $someInt
    /// 		# OPTIONAL
    /// 		monthlyTime = $someDateTime
    /// 		# REQUIRED
    /// 		rubrikRecipientUserIds = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		nonRubrikRecipientEmails = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		timeZone = $someString
    /// 		# OPTIONAL
    /// 		updateCreator = $someBoolean
    /// 		# OPTIONAL
    /// 		weeklyDays = @(
    /// 			$someWeekDay # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WeekDay]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		attachmentTypes = @(
    /// 			$someReportAttachmentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportAttachmentType]) for enum values.
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateScheduledReportReply
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
        "RscMutationReport",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationReport : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "BlueprintFailoverGenerate",
                "Create",
                "CreateCustom",
                "CreatePolaris",
                "CreateScheduled",
                "Delete",
                "DeleteCustom",
                "DeleteScheduledReport",
                "RefreshTrial",
                "SendPdf",
                "SendScheduled",
                "SendScheduledReportAsync",
                "ShareTrial",
                "StartClusterMigrationJob",
                "Update",
                "UpdateCustom",
                "UpdateDatabaseLogingPropertiesForCluster",
                "UpdatePolaris",
                "UpdateScheduledReport",
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
                    case "BlueprintFailoverGenerate":
                        this.ProcessRecord_BlueprintFailoverGenerate();
                        break;
                    case "Create":
                        this.ProcessRecord_Create();
                        break;
                    case "CreateCustom":
                        this.ProcessRecord_CreateCustom();
                        break;
                    case "CreatePolaris":
                        this.ProcessRecord_CreatePolaris();
                        break;
                    case "CreateScheduled":
                        this.ProcessRecord_CreateScheduled();
                        break;
                    case "Delete":
                        this.ProcessRecord_Delete();
                        break;
                    case "DeleteCustom":
                        this.ProcessRecord_DeleteCustom();
                        break;
                    case "DeleteScheduledReport":
                        this.ProcessRecord_DeleteScheduledReport();
                        break;
                    case "RefreshTrial":
                        this.ProcessRecord_RefreshTrial();
                        break;
                    case "SendPdf":
                        this.ProcessRecord_SendPdf();
                        break;
                    case "SendScheduled":
                        this.ProcessRecord_SendScheduled();
                        break;
                    case "SendScheduledReportAsync":
                        this.ProcessRecord_SendScheduledReportAsync();
                        break;
                    case "ShareTrial":
                        this.ProcessRecord_ShareTrial();
                        break;
                    case "StartClusterMigrationJob":
                        this.ProcessRecord_StartClusterMigrationJob();
                        break;
                    case "Update":
                        this.ProcessRecord_Update();
                        break;
                    case "UpdateCustom":
                        this.ProcessRecord_UpdateCustom();
                        break;
                    case "UpdateDatabaseLogingPropertiesForCluster":
                        this.ProcessRecord_UpdateDatabaseLogingPropertiesForCluster();
                        break;
                    case "UpdatePolaris":
                        this.ProcessRecord_UpdatePolaris();
                        break;
                    case "UpdateScheduledReport":
                        this.ProcessRecord_UpdateScheduledReport();
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
        // blueprintFailoverReportGenerate.
        internal void ProcessRecord_BlueprintFailoverGenerate()
        {
            this._logger.name += " -BlueprintFailoverGenerate";
            // Create new graphql operation blueprintFailoverReportGenerate
            InitMutationBlueprintFailoverReportGenerate();
        }

        // This parameter set invokes a single graphql operation:
        // createReport.
        internal void ProcessRecord_Create()
        {
            this._logger.name += " -Create";
            // Create new graphql operation createReport
            InitMutationCreateReport();
        }

        // This parameter set invokes a single graphql operation:
        // createCustomReport.
        internal void ProcessRecord_CreateCustom()
        {
            this._logger.name += " -CreateCustom";
            // Create new graphql operation createCustomReport
            InitMutationCreateCustomReport();
        }

        // This parameter set invokes a single graphql operation:
        // createPolarisReport.
        internal void ProcessRecord_CreatePolaris()
        {
            this._logger.name += " -CreatePolaris";
            // Create new graphql operation createPolarisReport
            InitMutationCreatePolarisReport();
        }

        // This parameter set invokes a single graphql operation:
        // createScheduledReport.
        internal void ProcessRecord_CreateScheduled()
        {
            this._logger.name += " -CreateScheduled";
            // Create new graphql operation createScheduledReport
            InitMutationCreateScheduledReport();
        }

        // This parameter set invokes a single graphql operation:
        // deleteReport.
        internal void ProcessRecord_Delete()
        {
            this._logger.name += " -Delete";
            // Create new graphql operation deleteReport
            InitMutationDeleteReport();
        }

        // This parameter set invokes a single graphql operation:
        // deleteCustomReport.
        internal void ProcessRecord_DeleteCustom()
        {
            this._logger.name += " -DeleteCustom";
            // Create new graphql operation deleteCustomReport
            InitMutationDeleteCustomReport();
        }

        // This parameter set invokes a single graphql operation:
        // deleteScheduledReport.
        internal void ProcessRecord_DeleteScheduledReport()
        {
            this._logger.name += " -DeleteScheduledReport";
            // Create new graphql operation deleteScheduledReport
            InitMutationDeleteScheduledReport();
        }

        // This parameter set invokes a single graphql operation:
        // refreshTrialReport.
        internal void ProcessRecord_RefreshTrial()
        {
            this._logger.name += " -RefreshTrial";
            // Create new graphql operation refreshTrialReport
            InitMutationRefreshTrialReport();
        }

        // This parameter set invokes a single graphql operation:
        // sendPdfReport.
        internal void ProcessRecord_SendPdf()
        {
            this._logger.name += " -SendPdf";
            // Create new graphql operation sendPdfReport
            InitMutationSendPdfReport();
        }

        // This parameter set invokes a single graphql operation:
        // sendScheduledReport.
        internal void ProcessRecord_SendScheduled()
        {
            this._logger.name += " -SendScheduled";
            // Create new graphql operation sendScheduledReport
            InitMutationSendScheduledReport();
        }

        // This parameter set invokes a single graphql operation:
        // sendScheduledReportAsync.
        internal void ProcessRecord_SendScheduledReportAsync()
        {
            this._logger.name += " -SendScheduledReportAsync";
            // Create new graphql operation sendScheduledReportAsync
            InitMutationSendScheduledReportAsync();
        }

        // This parameter set invokes a single graphql operation:
        // shareTrialReport.
        internal void ProcessRecord_ShareTrial()
        {
            this._logger.name += " -ShareTrial";
            // Create new graphql operation shareTrialReport
            InitMutationShareTrialReport();
        }

        // This parameter set invokes a single graphql operation:
        // startClusterReportMigrationJob.
        internal void ProcessRecord_StartClusterMigrationJob()
        {
            this._logger.name += " -StartClusterMigrationJob";
            // Create new graphql operation startClusterReportMigrationJob
            InitMutationStartClusterReportMigrationJob();
        }

        // This parameter set invokes a single graphql operation:
        // updateReport.
        internal void ProcessRecord_Update()
        {
            this._logger.name += " -Update";
            // Create new graphql operation updateReport
            InitMutationUpdateReport();
        }

        // This parameter set invokes a single graphql operation:
        // updateCustomReport.
        internal void ProcessRecord_UpdateCustom()
        {
            this._logger.name += " -UpdateCustom";
            // Create new graphql operation updateCustomReport
            InitMutationUpdateCustomReport();
        }

        // This parameter set invokes a single graphql operation:
        // updateDatabaseLogReportingPropertiesForCluster.
        internal void ProcessRecord_UpdateDatabaseLogingPropertiesForCluster()
        {
            this._logger.name += " -UpdateDatabaseLogingPropertiesForCluster";
            // Create new graphql operation updateDatabaseLogReportingPropertiesForCluster
            InitMutationUpdateDatabaseLogReportingPropertiesForCluster();
        }

        // This parameter set invokes a single graphql operation:
        // updatePolarisReport.
        internal void ProcessRecord_UpdatePolaris()
        {
            this._logger.name += " -UpdatePolaris";
            // Create new graphql operation updatePolarisReport
            InitMutationUpdatePolarisReport();
        }

        // This parameter set invokes a single graphql operation:
        // updateScheduledReport.
        internal void ProcessRecord_UpdateScheduledReport()
        {
            this._logger.name += " -UpdateScheduledReport";
            // Create new graphql operation updateScheduledReport
            InitMutationUpdateScheduledReport();
        }


        // Create new GraphQL Mutation:
        // blueprintFailoverReportGenerate(failoverReportGeneratorJobConfig: BlueprintFailoverReportGeneratorJobInfo!): CreateOnDemandJobReply!
        internal void InitMutationBlueprintFailoverReportGenerate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("failoverReportGeneratorJobConfig", "BlueprintFailoverReportGeneratorJobInfo!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBlueprintFailoverReportGenerate",
                "($failoverReportGeneratorJobConfig: BlueprintFailoverReportGeneratorJobInfo!)",
                "CreateOnDemandJobReply",
                Mutation.BlueprintFailoverReportGenerate,
                Mutation.BlueprintFailoverReportGenerateFieldSpec,
                @"# REQUIRED
$query.Var.failoverReportGeneratorJobConfig = @{
	# REQUIRED
	failoverIds = @(
		$someString
	)
	# REQUIRED
	isNewReportEnabled = $someBoolean
	# OPTIONAL
	timezoneOffset = $someSingle
}"
            );
        }

        // Create new GraphQL Mutation:
        // createReport(reportConfig: ReportConfigInput!): Int!
        internal void InitMutationCreateReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("reportConfig", "ReportConfigInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateReport",
                "($reportConfig: ReportConfigInput!)",
                "System.Int32",
                Mutation.CreateReport,
                Mutation.CreateReportFieldSpec,
                @"# REQUIRED
$query.Var.reportConfig = @{
	# REQUIRED
	name = $someString
	# REQUIRED
	dataViewType = $someDataViewTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataViewTypeEnum]) for enum values.
	# REQUIRED
	columns = @(
		$someString
	)
	# REQUIRED
	groupBy = @{
		# REQUIRED
		groupById = $someString
		# REQUIRED
		aggregations = @(
			$someString
		)
	}
	# REQUIRED
	aggregations = @(
		$someString
	)
	# REQUIRED
	filters = @(
		@{
			# REQUIRED
			name = $someString
			# REQUIRED
			values = @(
				$someString
			)
		}
	)
	# REQUIRED
	sortBy = $someString
	# OPTIONAL
	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // createCustomReport(input: CreateCustomReportInput!, reportRoom: String): CreateCustomReportReply!
        internal void InitMutationCreateCustomReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateCustomReportInput!"),
                Tuple.Create("reportRoom", "String"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateCustomReport",
                "($input: CreateCustomReportInput!,$reportRoom: String)",
                "CreateCustomReportReply",
                Mutation.CreateCustomReport,
                Mutation.CreateCustomReportFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
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
# OPTIONAL
$query.Var.reportRoom = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // createPolarisReport(input: CreatePolarisReportInput!): CreatePolarisReportReply!
        internal void InitMutationCreatePolarisReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreatePolarisReportInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreatePolarisReport",
                "($input: CreatePolarisReportInput!)",
                "CreatePolarisReportReply",
                Mutation.CreatePolarisReport,
                Mutation.CreatePolarisReportFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# REQUIRED
	reportViewType = $somePolarisReportViewType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolarisReportViewType]) for enum values.
	# OPTIONAL
	room = $someReportRoomType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportRoomType]) for enum values.
	# REQUIRED
	charts = @(
		$someChartViewType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChartViewType]) for enum values.
	)
	# REQUIRED
	table = $someTableViewType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TableViewType]) for enum values.
	# REQUIRED
	filters = @(
		@{
			# REQUIRED
			name = $someString
			# REQUIRED
			values = @(
				$someString
			)
		}
	)
	# REQUIRED
	sortBy = $someString
	# OPTIONAL
	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // createScheduledReport(input: CreateScheduledReportInput!): CreateScheduledReportReply!
        internal void InitMutationCreateScheduledReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateScheduledReportInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateScheduledReport",
                "($input: CreateScheduledReportInput!)",
                "CreateScheduledReportReply",
                Mutation.CreateScheduledReport,
                Mutation.CreateScheduledReportFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	reportId = $someInt
	# REQUIRED
	title = $someString
	# OPTIONAL
	dailyTime = $someDateTime
	# OPTIONAL
	weeklyTime = $someDateTime
	# OPTIONAL
	monthlyDate = $someInt
	# OPTIONAL
	monthlyTime = $someDateTime
	# REQUIRED
	rubrikRecipientUserIds = @(
		$someString
	)
	# REQUIRED
	nonRubrikRecipientEmails = @(
		$someString
	)
	# OPTIONAL
	updateCreator = $someBoolean
	# OPTIONAL
	timeZone = $someString
	# OPTIONAL
	weeklyDays = @(
		$someWeekDay # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WeekDay]) for enum values.
	)
	# OPTIONAL
	attachmentTypes = @(
		$someReportAttachmentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportAttachmentType]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteReport(reportID: Int!): Void
        internal void InitMutationDeleteReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("reportID", "Int!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteReport",
                "($reportID: Int!)",
                "System.String",
                Mutation.DeleteReport,
                Mutation.DeleteReportFieldSpec,
                @"# REQUIRED
$query.Var.reportID = $someInt"
            );
        }

        // Create new GraphQL Mutation:
        // deleteCustomReport(input: DeleteCustomReportInput!): Void
        internal void InitMutationDeleteCustomReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteCustomReportInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteCustomReport",
                "($input: DeleteCustomReportInput!)",
                "System.String",
                Mutation.DeleteCustomReport,
                Mutation.DeleteCustomReportFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someInt
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteScheduledReport(input: DeleteScheduledReportInput!): Void
        internal void InitMutationDeleteScheduledReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteScheduledReportInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteScheduledReport",
                "($input: DeleteScheduledReportInput!)",
                "System.String",
                Mutation.DeleteScheduledReport,
                Mutation.DeleteScheduledReportFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someInt
	# OPTIONAL
	reportId = $someInt
}"
            );
        }

        // Create new GraphQL Mutation:
        // refreshTrialReport(input: RefreshTrialReportsInput!): Void
        internal void InitMutationRefreshTrialReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshTrialReportsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshTrialReport",
                "($input: RefreshTrialReportsInput!)",
                "System.String",
                Mutation.RefreshTrialReport,
                Mutation.RefreshTrialReportFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	trialId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // sendPdfReport(input: SendPdfReportInput!): SendPdfReportReply!
        internal void InitMutationSendPdfReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SendPdfReportInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSendPdfReport",
                "($input: SendPdfReportInput!)",
                "SendPdfReportReply",
                Mutation.SendPdfReport,
                Mutation.SendPdfReportFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	rubrikRecipientUserIds = @(
		$someString
	)
	# REQUIRED
	nonRubrikRecipientEmailIds = @(
		$someString
	)
	# REQUIRED
	password = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // sendScheduledReport(input: SendScheduledReportInput!): Boolean!
        internal void InitMutationSendScheduledReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SendScheduledReportInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSendScheduledReport",
                "($input: SendScheduledReportInput!)",
                "System.Boolean",
                Mutation.SendScheduledReport,
                Mutation.SendScheduledReportFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someInt
	# REQUIRED
	recipients = @(
		$someString
	)
	# OPTIONAL
	attachmentTypes = @(
		$someReportAttachmentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportAttachmentType]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // sendScheduledReportAsync(input: SendScheduledReportAsyncInput!): AsyncDownloadReply!
        internal void InitMutationSendScheduledReportAsync()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SendScheduledReportAsyncInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSendScheduledReportAsync",
                "($input: SendScheduledReportAsyncInput!)",
                "AsyncDownloadReply",
                Mutation.SendScheduledReportAsync,
                Mutation.SendScheduledReportAsyncFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	reportId = $someInt
	# OPTIONAL
	rubrikUserIds = @(
		$someString
	)
	# OPTIONAL
	nonRubrikUserEmails = @(
		$someString
	)
	# OPTIONAL
	attachmentTypes = @(
		$someReportAttachmentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportAttachmentType]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // shareTrialReport(input: ShareTrialReportInput!): ShareTrialReportReply!
        internal void InitMutationShareTrialReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ShareTrialReportInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationShareTrialReport",
                "($input: ShareTrialReportInput!)",
                "ShareTrialReportReply",
                Mutation.ShareTrialReport,
                Mutation.ShareTrialReportFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	trialId = $someString
	# REQUIRED
	recipientEmails = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // startClusterReportMigrationJob(input: StartClusterReportMigrationJobInput!): StartClusterReportMigrationJobReply!
        internal void InitMutationStartClusterReportMigrationJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartClusterReportMigrationJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartClusterReportMigrationJob",
                "($input: StartClusterReportMigrationJobInput!)",
                "StartClusterReportMigrationJobReply",
                Mutation.StartClusterReportMigrationJob,
                Mutation.StartClusterReportMigrationJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	clusterUuid = $someString
	# OPTIONAL
	shouldDeleteCdmSchedules = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateReport(reportID: Int!, reportConfig: ReportConfigInput!): Boolean!
        internal void InitMutationUpdateReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("reportID", "Int!"),
                Tuple.Create("reportConfig", "ReportConfigInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateReport",
                "($reportID: Int!,$reportConfig: ReportConfigInput!)",
                "System.Boolean",
                Mutation.UpdateReport,
                Mutation.UpdateReportFieldSpec,
                @"# REQUIRED
$query.Var.reportID = $someInt
# REQUIRED
$query.Var.reportConfig = @{
	# REQUIRED
	name = $someString
	# REQUIRED
	dataViewType = $someDataViewTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataViewTypeEnum]) for enum values.
	# REQUIRED
	columns = @(
		$someString
	)
	# REQUIRED
	groupBy = @{
		# REQUIRED
		groupById = $someString
		# REQUIRED
		aggregations = @(
			$someString
		)
	}
	# REQUIRED
	aggregations = @(
		$someString
	)
	# REQUIRED
	filters = @(
		@{
			# REQUIRED
			name = $someString
			# REQUIRED
			values = @(
				$someString
			)
		}
	)
	# REQUIRED
	sortBy = $someString
	# OPTIONAL
	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateCustomReport(input: UpdateCustomReportInput!): UpdateCustomReportReply!
        internal void InitMutationUpdateCustomReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateCustomReportInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateCustomReport",
                "($input: UpdateCustomReportInput!)",
                "UpdateCustomReportReply",
                Mutation.UpdateCustomReport,
                Mutation.UpdateCustomReportFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someInt
	# REQUIRED
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
        // updateDatabaseLogReportingPropertiesForCluster(input: UpdateDatabaseLogReportingPropertiesForClusterInput!): DbLogReportProperties!
        internal void InitMutationUpdateDatabaseLogReportingPropertiesForCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateDatabaseLogReportingPropertiesForClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateDatabaseLogReportingPropertiesForCluster",
                "($input: UpdateDatabaseLogReportingPropertiesForClusterInput!)",
                "DbLogReportProperties",
                Mutation.UpdateDatabaseLogReportingPropertiesForCluster,
                Mutation.UpdateDatabaseLogReportingPropertiesForClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	properties = @{
		# OPTIONAL
		enableDelayNotification = $someBoolean
		# OPTIONAL
		logDelayThresholdInMin = $someInt64
		# OPTIONAL
		logDelayNotificationFrequencyInMin = $someInt64
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updatePolarisReport(input: UpdatePolarisReportInput!): Void
        internal void InitMutationUpdatePolarisReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdatePolarisReportInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdatePolarisReport",
                "($input: UpdatePolarisReportInput!)",
                "System.String",
                Mutation.UpdatePolarisReport,
                Mutation.UpdatePolarisReportFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	reportId = $someInt64
	# REQUIRED
	name = $someString
	# REQUIRED
	reportViewType = $somePolarisReportViewType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolarisReportViewType]) for enum values.
	# OPTIONAL
	room = $someReportRoomType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportRoomType]) for enum values.
	# REQUIRED
	charts = @(
		$someChartViewType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChartViewType]) for enum values.
	)
	# REQUIRED
	table = $someTableViewType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TableViewType]) for enum values.
	# REQUIRED
	filters = @(
		@{
			# REQUIRED
			name = $someString
			# REQUIRED
			values = @(
				$someString
			)
		}
	)
	# REQUIRED
	sortBy = $someString
	# OPTIONAL
	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
	# OPTIONAL
	displayableColumns = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateScheduledReport(input: UpdateScheduledReportInput!): UpdateScheduledReportReply!
        internal void InitMutationUpdateScheduledReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateScheduledReportInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateScheduledReport",
                "($input: UpdateScheduledReportInput!)",
                "UpdateScheduledReportReply",
                Mutation.UpdateScheduledReport,
                Mutation.UpdateScheduledReportFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someInt
	# REQUIRED
	config = @{
		# REQUIRED
		reportId = $someInt
		# REQUIRED
		title = $someString
		# OPTIONAL
		dailyTime = $someDateTime
		# OPTIONAL
		weeklyTime = $someDateTime
		# OPTIONAL
		monthlyDate = $someInt
		# OPTIONAL
		monthlyTime = $someDateTime
		# REQUIRED
		rubrikRecipientUserIds = @(
			$someString
		)
		# REQUIRED
		nonRubrikRecipientEmails = @(
			$someString
		)
		# OPTIONAL
		timeZone = $someString
		# OPTIONAL
		updateCreator = $someBoolean
		# OPTIONAL
		weeklyDays = @(
			$someWeekDay # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WeekDay]) for enum values.
		)
		# OPTIONAL
		attachmentTypes = @(
			$someReportAttachmentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReportAttachmentType]) for enum values.
		)
	}
}"
            );
        }


    } // class New_RscMutationReport
}