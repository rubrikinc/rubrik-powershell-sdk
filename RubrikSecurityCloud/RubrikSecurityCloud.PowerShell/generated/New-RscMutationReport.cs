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
    /// Create a new RscQuery object for any of the 9
    /// operations in the 'Report' API domain:
    /// CreateCustom, CreateScheduled, DeleteCustom, DeleteScheduled, SendPdf, SendScheduledAsync, StartClusterMigrationJob, UpdateCustom, or UpdateScheduled.
    /// </summary>
    /// <description>
    /// New-RscMutationReport creates a new
    /// mutation object for operations
    /// in the 'Report' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 9 operations
    /// in the 'Report' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: CreateCustom, CreateScheduled, DeleteCustom, DeleteScheduled, SendPdf, SendScheduledAsync, StartClusterMigrationJob, UpdateCustom, or UpdateScheduled.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationReport -CreateCustom).Info().
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
    /// (New-RscMutationReport -CreateCustom).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
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
    /// Runs the DeleteScheduled operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: DeleteScheduled
    /// 
    /// $query = New-RscMutationReport -DeleteScheduled
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
    /// Runs the SendScheduledAsync operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: SendScheduledAsync
    /// 
    /// $query = New-RscMutationReport -SendScheduledAsync
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
    /// Runs the UpdateScheduled operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: UpdateScheduled
    /// 
    /// $query = New-RscMutationReport -UpdateScheduled
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
                "CreateCustom",
                "CreateScheduled",
                "DeleteCustom",
                "DeleteScheduled",
                "SendPdf",
                "SendScheduledAsync",
                "StartClusterMigrationJob",
                "UpdateCustom",
                "UpdateScheduled",
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
                    case "CreateCustom":
                        this.ProcessRecord_CreateCustom();
                        break;
                    case "CreateScheduled":
                        this.ProcessRecord_CreateScheduled();
                        break;
                    case "DeleteCustom":
                        this.ProcessRecord_DeleteCustom();
                        break;
                    case "DeleteScheduled":
                        this.ProcessRecord_DeleteScheduled();
                        break;
                    case "SendPdf":
                        this.ProcessRecord_SendPdf();
                        break;
                    case "SendScheduledAsync":
                        this.ProcessRecord_SendScheduledAsync();
                        break;
                    case "StartClusterMigrationJob":
                        this.ProcessRecord_StartClusterMigrationJob();
                        break;
                    case "UpdateCustom":
                        this.ProcessRecord_UpdateCustom();
                        break;
                    case "UpdateScheduled":
                        this.ProcessRecord_UpdateScheduled();
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
        // createCustomReport.
        internal void ProcessRecord_CreateCustom()
        {
            this._logger.name += " -CreateCustom";
            // Create new graphql operation createCustomReport
            InitMutationCreateCustomReport();
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
        // deleteCustomReport.
        internal void ProcessRecord_DeleteCustom()
        {
            this._logger.name += " -DeleteCustom";
            // Create new graphql operation deleteCustomReport
            InitMutationDeleteCustomReport();
        }

        // This parameter set invokes a single graphql operation:
        // deleteScheduledReport.
        internal void ProcessRecord_DeleteScheduled()
        {
            this._logger.name += " -DeleteScheduled";
            // Create new graphql operation deleteScheduledReport
            InitMutationDeleteScheduledReport();
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
        // sendScheduledReportAsync.
        internal void ProcessRecord_SendScheduledAsync()
        {
            this._logger.name += " -SendScheduledAsync";
            // Create new graphql operation sendScheduledReportAsync
            InitMutationSendScheduledReportAsync();
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
        // updateCustomReport.
        internal void ProcessRecord_UpdateCustom()
        {
            this._logger.name += " -UpdateCustom";
            // Create new graphql operation updateCustomReport
            InitMutationUpdateCustomReport();
        }

        // This parameter set invokes a single graphql operation:
        // updateScheduledReport.
        internal void ProcessRecord_UpdateScheduled()
        {
            this._logger.name += " -UpdateScheduled";
            // Create new graphql operation updateScheduledReport
            InitMutationUpdateScheduledReport();
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
                Mutation.CreateCustomReport_ObjectFieldSpec,
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
                Mutation.CreateScheduledReport_ObjectFieldSpec,
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
                Mutation.DeleteCustomReport_ObjectFieldSpec,
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
                Mutation.DeleteScheduledReport_ObjectFieldSpec,
                Mutation.DeleteScheduledReportFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someInt
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
                Mutation.SendPdfReport_ObjectFieldSpec,
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
                Mutation.SendScheduledReportAsync_ObjectFieldSpec,
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
                Mutation.StartClusterReportMigrationJob_ObjectFieldSpec,
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
                Mutation.UpdateCustomReport_ObjectFieldSpec,
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
                Mutation.UpdateScheduledReport_ObjectFieldSpec,
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