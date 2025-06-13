// New-RscQuerySnapshot.cs
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
    /// Create a new RscQuery object for any of the 25
    /// operations in the 'Snapshot' API domain:
    /// BrowseFileList, ClosestToPointInTime, CloudDirect, CloudDirects, EmailSearch, EventSearch, FilesDelta, FilesDeltaV2, Fileset, FilesetFiles, LegalHoldSnappable, OnedriveSearch, Polaris, Pvcs, QuarantinedDetails, Results, SOfCloudDirectBucket, SOfCloudDirectShare, SnappableList, SnappablesList, SnappablesWithLegalHoldsSummary, Snapshot, UnmanagedObject, VappInstantRecoveryOptions, or VappTemplateExportOptions.
    /// </summary>
    /// <description>
    /// New-RscQuerySnapshot creates a new
    /// query object for operations
    /// in the 'Snapshot' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 25 operations
    /// in the 'Snapshot' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: BrowseFileList, ClosestToPointInTime, CloudDirect, CloudDirects, EmailSearch, EventSearch, FilesDelta, FilesDeltaV2, Fileset, FilesetFiles, LegalHoldSnappable, OnedriveSearch, Polaris, Pvcs, QuarantinedDetails, Results, SOfCloudDirectBucket, SOfCloudDirectShare, SnappableList, SnappablesList, SnappablesWithLegalHoldsSummary, Snapshot, UnmanagedObject, VappInstantRecoveryOptions, or VappTemplateExportOptions.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQuerySnapshot -BrowseFileList).Info().
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
    /// (New-RscQuerySnapshot -BrowseFileList).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the BrowseFileList operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: BrowseFileList
    /// 
    /// $query = New-RscQuerySnapshot -Operation BrowseFileList
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.path = $someString
    /// # REQUIRED
    /// $query.Var.snapshotFid = $someString
    /// # OPTIONAL
    /// $query.Var.searchPrefix = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SnapshotFileConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ClosestToPointInTime operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: ClosestToPointInTime
    /// 
    /// $query = New-RscQuerySnapshot -Operation ClosestToPointInTime
    /// 
    /// # OPTIONAL
    /// $query.Var.beforeTime = $someDateTime
    /// # OPTIONAL
    /// $query.Var.afterTime = $someDateTime
    /// # REQUIRED
    /// $query.Var.snappableIds = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.includeLinked = $someBoolean
    /// # OPTIONAL
    /// $query.Var.ignoreActiveWorkloadCheck = $someBoolean
    /// # OPTIONAL
    /// $query.Var.excludeQuarantined = $someBoolean
    /// # OPTIONAL
    /// $query.Var.excludeAnomalous = $someBoolean
    /// # OPTIONAL
    /// $query.Var.quarantinedOnly = $someBoolean
    /// # OPTIONAL
    /// $query.Var.anomalousOnly = $someBoolean
    /// # OPTIONAL
    /// $query.Var.getFullDetails = $someBoolean
    /// # OPTIONAL
    /// $query.Var.excludeReplica = $someBoolean
    /// # OPTIONAL
    /// $query.Var.excludeArchivalLocationTypes = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;ClosestSnapshotSearchResult&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudDirect operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: CloudDirect
    /// 
    /// $query = New-RscQuerySnapshot -Operation CloudDirect
    /// 
    /// # REQUIRED
    /// $query.Var.snapshotFid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CloudDirectSnapshot
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudDirects operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: CloudDirects
    /// 
    /// $query = New-RscQuerySnapshot -Operation CloudDirects
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
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someCloudDirectSnapshotsFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudDirectSnapshotsFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.sortBy = @{
    /// 	# OPTIONAL
    /// 	field = $someCloudDirectSnapshotsSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudDirectSnapshotsSortByField]) for enum values.
    /// 	# OPTIONAL
    /// 	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CloudDirectSnapshotConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the EmailSearch operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: EmailSearch
    /// 
    /// $query = New-RscQuerySnapshot -Operation EmailSearch
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.snappableFid = $someString
    /// # REQUIRED
    /// $query.Var.snapshotFid = $someString
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// # OPTIONAL
    /// $query.Var.searchFilter = @{
    /// 	# OPTIONAL
    /// 	searchKeywordFilter = @{
    /// 		# OPTIONAL
    /// 		searchKeyword = $someString
    /// 		# OPTIONAL
    /// 		keywordType = $someSearchKeywordType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SearchKeywordType]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	emailAddresses = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			emailAddress = $someString
    /// 			# OPTIONAL
    /// 			emailAddressType = $someEmailAddressFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EmailAddressFilterType]) for enum values.
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	fromTime = $someDateTime
    /// 	# OPTIONAL
    /// 	untilTime = $someDateTime
    /// 	# OPTIONAL
    /// 	searchObjectFilter = @{
    /// 		# OPTIONAL
    /// 		searchObjectType = $someSearchObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SearchObjectType]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	lambdaFilters = @{
    /// 		# OPTIONAL
    /// 		enableAbsolutePaths = $someBoolean
    /// 		# OPTIONAL
    /// 		enableAbsolutePathCachePreload = $someBoolean
    /// 		# OPTIONAL
    /// 		parentFolderIdBatch = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		searchRecurseFolderId = $someString
    /// 		# OPTIONAL
    /// 		includeAncestors = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	archiveFolderAction = $someArchiveFolderAction # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ArchiveFolderAction]) for enum values.
    /// 	# OPTIONAL
    /// 	skipRifItems = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: O365ExchangeObjectConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the EventSearch operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: EventSearch
    /// 
    /// $query = New-RscQuerySnapshot -Operation EventSearch
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.snappableFid = $someString
    /// # REQUIRED
    /// $query.Var.snapshotFid = $someString
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// # OPTIONAL
    /// $query.Var.calendarSearchFilter = @{
    /// 	# OPTIONAL
    /// 	searchKeywordFilter = @{
    /// 		# OPTIONAL
    /// 		searchKeyword = $someString
    /// 		# OPTIONAL
    /// 		keywordType = $someCalendarSearchKeywordType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CalendarSearchKeywordType]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	emailAddresses = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			emailAddress = $someString
    /// 			# OPTIONAL
    /// 			filterType = $someCalendarEmailAddressFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CalendarEmailAddressFilterType]) for enum values.
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	timerange = @{
    /// 		# OPTIONAL
    /// 		fromTime = $someDateTime
    /// 		# OPTIONAL
    /// 		untilTime = $someDateTime
    /// 	}
    /// 	# OPTIONAL
    /// 	searchObjectFilter = @{
    /// 		# OPTIONAL
    /// 		searchObjectType = $someO365CalendarSearchObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365CalendarSearchObjectType]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	recurrenceFilter = @{
    /// 		# OPTIONAL
    /// 		recurrenceType = $someCalendarRecurrenceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CalendarRecurrenceType]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	lambdaFilters = @{
    /// 		# OPTIONAL
    /// 		enableAbsolutePaths = $someBoolean
    /// 		# OPTIONAL
    /// 		enableAbsolutePathCachePreload = $someBoolean
    /// 		# OPTIONAL
    /// 		parentFolderIdBatch = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		searchRecurseFolderId = $someString
    /// 		# OPTIONAL
    /// 		includeAncestors = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	skipRifItems = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: O365ExchangeObjectConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the FilesDelta operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: FilesDelta
    /// 
    /// $query = New-RscQuerySnapshot -Operation FilesDelta
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.path = $someString
    /// # REQUIRED
    /// $query.Var.snapshotFid = $someString
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	deltaType = @(
    /// 		$someDeltaType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeltaType]) for enum values.
    /// 	)
    /// }
    /// # OPTIONAL
    /// $query.Var.searchPrefix = $someString
    /// # OPTIONAL
    /// $query.Var.quarantineFilters = @(
    /// 	$someQuarantineFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.QuarantineFilter]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.workloadFieldsArg = @{
    /// 	# OPTIONAL
    /// 	o365FileDelta = @{
    /// 		# OPTIONAL
    /// 		folderId = $someString
    /// 		# OPTIONAL
    /// 		orgId = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	o365SharepointDelta = @{
    /// 		# OPTIONAL
    /// 		folderId = $someString
    /// 		# OPTIONAL
    /// 		orgId = $someString
    /// 		# OPTIONAL
    /// 		sharepointSiteReq = @{
    /// 			# OPTIONAL
    /// 			siteChildId = $someString
    /// 			# OPTIONAL
    /// 			siteChildType = $someSharePointDescendantType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SharePointDescendantType]) for enum values.
    /// 		}
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SnapshotFileDeltaConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the FilesDeltaV2 operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: FilesDeltaV2
    /// 
    /// $query = New-RscQuerySnapshot -Operation FilesDeltaV2
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.path = $someString
    /// # REQUIRED
    /// $query.Var.snapshotFid = $someString
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	deltaType = @(
    /// 		$someDeltaType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeltaType]) for enum values.
    /// 	)
    /// }
    /// # OPTIONAL
    /// $query.Var.searchPrefix = $someString
    /// # OPTIONAL
    /// $query.Var.quarantineFilters = @(
    /// 	$someQuarantineFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.QuarantineFilter]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.workloadFieldsArg = @{
    /// 	# OPTIONAL
    /// 	o365FileDelta = @{
    /// 		# OPTIONAL
    /// 		folderId = $someString
    /// 		# OPTIONAL
    /// 		orgId = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	o365SharepointDelta = @{
    /// 		# OPTIONAL
    /// 		folderId = $someString
    /// 		# OPTIONAL
    /// 		orgId = $someString
    /// 		# OPTIONAL
    /// 		sharepointSiteReq = @{
    /// 			# OPTIONAL
    /// 			siteChildId = $someString
    /// 			# OPTIONAL
    /// 			siteChildType = $someSharePointDescendantType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SharePointDescendantType]) for enum values.
    /// 		}
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SnapshotFileDeltaV2Connection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Fileset operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: Fileset
    /// 
    /// $query = New-RscQuerySnapshot -Operation Fileset
    /// 
    /// # REQUIRED
    /// $query.Var.id = $someString
    /// # OPTIONAL
    /// $query.Var.verbose = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: FilesetSnapshotDetail
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the FilesetFiles operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: FilesetFiles
    /// 
    /// $query = New-RscQuerySnapshot -Operation FilesetFiles
    /// 
    /// # REQUIRED
    /// $query.Var.id = $someString
    /// # OPTIONAL
    /// $query.Var.limit = $someInt
    /// # OPTIONAL
    /// $query.Var.offset = $someInt
    /// # REQUIRED
    /// $query.Var.path = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BrowseResponseListResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the LegalHoldSnappable operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: LegalHoldSnappable
    /// 
    /// $query = New-RscQuerySnapshot -Operation LegalHoldSnappable
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
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	snappableId = $someString
    /// 	# REQUIRED
    /// 	filterParams = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			filterField = $someLegalHoldQueryFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LegalHoldQueryFilterField]) for enum values.
    /// 			# OPTIONAL
    /// 			beforeTime = $someDateTime
    /// 			# OPTIONAL
    /// 			afterTime = $someDateTime
    /// 			# OPTIONAL
    /// 			snappableName = $someString
    /// 			# OPTIONAL
    /// 			snappableTypes = @(
    /// 				$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			snapshotTypes = @(
    /// 				$someSnapshotTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotTypeEnum]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			snapshotCustomizations = @(
    /// 				$someSnapshotCustomization # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotCustomization]) for enum values.
    /// 			)
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	sortParam = @{
    /// 		# OPTIONAL
    /// 		type = $someLegalHoldSortType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LegalHoldSortType]) for enum values.
    /// 		# OPTIONAL
    /// 		sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: LegalHoldSnapshotDetailConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the OnedriveSearch operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: OnedriveSearch
    /// 
    /// $query = New-RscQuerySnapshot -Operation OnedriveSearch
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.snappableFid = $someString
    /// # REQUIRED
    /// $query.Var.snapshotFid = $someString
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// # OPTIONAL
    /// $query.Var.onedriveSearchFilter = @{
    /// 	# OPTIONAL
    /// 	searchKeywordFilter = @{
    /// 		# OPTIONAL
    /// 		searchKeyword = $someString
    /// 		# OPTIONAL
    /// 		keywordType = $someOnedriveSearchKeywordType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OnedriveSearchKeywordType]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	modifiedTime = @{
    /// 		# OPTIONAL
    /// 		fromTime = $someDateTime
    /// 		# OPTIONAL
    /// 		untilTime = $someDateTime
    /// 	}
    /// 	# OPTIONAL
    /// 	createTime = @{
    /// 		# OPTIONAL
    /// 		fromTime = $someDateTime
    /// 		# OPTIONAL
    /// 		untilTime = $someDateTime
    /// 	}
    /// 	# OPTIONAL
    /// 	searchObjectFilter = @{
    /// 		# OPTIONAL
    /// 		searchObjectType = $someOnedriveSearchObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OnedriveSearchObjectType]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	channelId = $someString
    /// 	# OPTIONAL
    /// 	channelFolderName = $someString
    /// 	# OPTIONAL
    /// 	channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
    /// 	# OPTIONAL
    /// 	excludeItemsUnderRoot = $someBoolean
    /// 	# OPTIONAL
    /// 	channelNameKeyword = $someString
    /// 	# OPTIONAL
    /// 	useExactVersionMatch = $someBoolean
    /// 	# OPTIONAL
    /// 	lambdaFilters = @{
    /// 		# OPTIONAL
    /// 		enableAbsolutePaths = $someBoolean
    /// 		# OPTIONAL
    /// 		enableAbsolutePathCachePreload = $someBoolean
    /// 		# OPTIONAL
    /// 		parentFolderIdBatch = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		searchRecurseFolderId = $someString
    /// 		# OPTIONAL
    /// 		includeAncestors = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	objectId = $someString
    /// 	# OPTIONAL
    /// 	filePath = $someString
    /// 	# OPTIONAL
    /// 	parentWorkloadId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: O365OnedriveObjectConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Polaris operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: Polaris
    /// 
    /// $query = New-RscQuerySnapshot -Operation Polaris
    /// 
    /// # REQUIRED
    /// $query.Var.snapshotFid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PolarisSnapshot
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Pvcs operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: Pvcs
    /// 
    /// $query = New-RscQuerySnapshot -Operation Pvcs
    /// 
    /// # REQUIRED
    /// $query.Var.snapshotId = $someString
    /// # REQUIRED
    /// $query.Var.snappableId = $someString
    /// # REQUIRED
    /// $query.Var.isReplica = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;PvcInformation&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the QuarantinedDetails operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: QuarantinedDetails
    /// 
    /// $query = New-RscQuerySnapshot -Operation QuarantinedDetails
    /// 
    /// # REQUIRED
    /// $query.Var.snapshotIds = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;QuarantineSpec&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Results operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: Results
    /// 
    /// $query = New-RscQuerySnapshot -Operation Results
    /// 
    /// # REQUIRED
    /// $query.Var.snappableFid = $someString
    /// # REQUIRED
    /// $query.Var.startTimeMs = $someInt64
    /// # REQUIRED
    /// $query.Var.endTimeMs = $someInt64
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SnapshotResultConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SOfCloudDirectBucket operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: SOfCloudDirectBucket
    /// 
    /// $query = New-RscQuerySnapshot -Operation SOfCloudDirectBucket
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
    /// $query.Var.workloadId = $someString
    /// # OPTIONAL
    /// $query.Var.snapshotFilter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someSnapshotQueryFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotQueryFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		text = $someString
    /// 		# OPTIONAL
    /// 		typeFilters = @(
    /// 			$someSnapshotTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotTypeEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		shouldFetchLinked = $someBoolean
    /// 		# OPTIONAL
    /// 		textList = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		time = $someDateTime
    /// 		# OPTIONAL
    /// 		customizationFilters = @(
    /// 			$someSnapshotCustomization # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotCustomization]) for enum values.
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortBy = $someSnapshotQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotQuerySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.timeRange = @{
    /// 	# REQUIRED
    /// 	start = $someDateTime
    /// 	# REQUIRED
    /// 	end = $someDateTime
    /// }
    /// # OPTIONAL
    /// $query.Var.cloudDirectTargetId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CloudDirectSnapshotConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SOfCloudDirectShare operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: SOfCloudDirectShare
    /// 
    /// $query = New-RscQuerySnapshot -Operation SOfCloudDirectShare
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
    /// $query.Var.workloadId = $someString
    /// # OPTIONAL
    /// $query.Var.snapshotFilter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someSnapshotQueryFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotQueryFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		text = $someString
    /// 		# OPTIONAL
    /// 		typeFilters = @(
    /// 			$someSnapshotTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotTypeEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		shouldFetchLinked = $someBoolean
    /// 		# OPTIONAL
    /// 		textList = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		time = $someDateTime
    /// 		# OPTIONAL
    /// 		customizationFilters = @(
    /// 			$someSnapshotCustomization # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotCustomization]) for enum values.
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortBy = $someSnapshotQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotQuerySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.timeRange = @{
    /// 	# REQUIRED
    /// 	start = $someDateTime
    /// 	# REQUIRED
    /// 	end = $someDateTime
    /// }
    /// # OPTIONAL
    /// $query.Var.cloudDirectTargetId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CloudDirectSnapshotConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SnappableList operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: SnappableList
    /// 
    /// $query = New-RscQuerySnapshot -Operation SnappableList
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
    /// $query.Var.workloadId = $someString
    /// # OPTIONAL
    /// $query.Var.snapshotFilter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someSnapshotQueryFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotQueryFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		text = $someString
    /// 		# OPTIONAL
    /// 		typeFilters = @(
    /// 			$someSnapshotTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotTypeEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		shouldFetchLinked = $someBoolean
    /// 		# OPTIONAL
    /// 		textList = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		time = $someDateTime
    /// 		# OPTIONAL
    /// 		customizationFilters = @(
    /// 			$someSnapshotCustomization # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotCustomization]) for enum values.
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortBy = $someSnapshotQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotQuerySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.timeRange = @{
    /// 	# REQUIRED
    /// 	start = $someDateTime
    /// 	# REQUIRED
    /// 	end = $someDateTime
    /// }
    /// # OPTIONAL
    /// $query.Var.ignoreActiveWorkloadCheck = $someBoolean
    /// # OPTIONAL
    /// $query.Var.showSnapshotRetentionInfo = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GenericSnapshotConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SnappablesList operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: SnappablesList
    /// 
    /// $query = New-RscQuerySnapshot -Operation SnappablesList
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
    /// $query.Var.snappableIds = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.snapshotFilter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someSnapshotQueryFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotQueryFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		text = $someString
    /// 		# OPTIONAL
    /// 		typeFilters = @(
    /// 			$someSnapshotTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotTypeEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		shouldFetchLinked = $someBoolean
    /// 		# OPTIONAL
    /// 		textList = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		time = $someDateTime
    /// 		# OPTIONAL
    /// 		customizationFilters = @(
    /// 			$someSnapshotCustomization # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotCustomization]) for enum values.
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortBy = $someSnapshotQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotQuerySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.timeRange = @{
    /// 	# REQUIRED
    /// 	start = $someDateTime
    /// 	# REQUIRED
    /// 	end = $someDateTime
    /// }
    /// # OPTIONAL
    /// $query.Var.ignoreActiveWorkloadCheck = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GenericSnapshotConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SnappablesWithLegalHoldsSummary operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: SnappablesWithLegalHoldsSummary
    /// 
    /// $query = New-RscQuerySnapshot -Operation SnappablesWithLegalHoldsSummary
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
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	filterParams = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			filterField = $someLegalHoldQueryFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LegalHoldQueryFilterField]) for enum values.
    /// 			# OPTIONAL
    /// 			beforeTime = $someDateTime
    /// 			# OPTIONAL
    /// 			afterTime = $someDateTime
    /// 			# OPTIONAL
    /// 			snappableName = $someString
    /// 			# OPTIONAL
    /// 			snappableTypes = @(
    /// 				$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			snapshotTypes = @(
    /// 				$someSnapshotTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotTypeEnum]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			snapshotCustomizations = @(
    /// 				$someSnapshotCustomization # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotCustomization]) for enum values.
    /// 			)
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	sortParam = @{
    /// 		# OPTIONAL
    /// 		type = $someLegalHoldSortType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LegalHoldSortType]) for enum values.
    /// 		# OPTIONAL
    /// 		sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: LegalHoldSnappableDetailConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Snapshot operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: Snapshot
    /// 
    /// $query = New-RscQuerySnapshot -Operation Snapshot
    /// 
    /// # REQUIRED
    /// $query.Var.snapshotFid = $someString
    /// # OPTIONAL
    /// $query.Var.clusterUuid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CdmSnapshot
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UnmanagedObject operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: UnmanagedObject
    /// 
    /// $query = New-RscQuerySnapshot -Operation UnmanagedObject
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
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	afterDate = $someDateTime
    /// 	# OPTIONAL
    /// 	beforeDate = $someDateTime
    /// 	# OPTIONAL
    /// 	limit = $someInt
    /// 	# OPTIONAL
    /// 	offset = $someInt
    /// 	# OPTIONAL
    /// 	searchValue = $someString
    /// 	# OPTIONAL
    /// 	snapshotType = $someV1QueryUnmanagedObjectSnapshotsV1RequestSnapshotType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryUnmanagedObjectSnapshotsV1RequestSnapshotType]) for enum values.
    /// 	# OPTIONAL
    /// 	sortBy = $someV1QueryUnmanagedObjectSnapshotsV1RequestSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryUnmanagedObjectSnapshotsV1RequestSortBy]) for enum values.
    /// 	# OPTIONAL
    /// 	sortOrder = $someV1QueryUnmanagedObjectSnapshotsV1RequestSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryUnmanagedObjectSnapshotsV1RequestSortOrder]) for enum values.
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SnapshotSummaryConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the VappInstantRecoveryOptions operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: VappInstantRecoveryOptions
    /// 
    /// $query = New-RscQuerySnapshot -Operation VappInstantRecoveryOptions
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
    /// Write-Host $result.GetType().Name # prints: VappInstantRecoveryOptions
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the VappTemplateExportOptions operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: VappTemplateExportOptions
    /// 
    /// $query = New-RscQuerySnapshot -Operation VappTemplateExportOptions
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	orgVdcId = $someString
    /// 	# REQUIRED
    /// 	catalogId = $someString
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	snapshotId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VappTemplateExportOptionsUnion
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
        "RscQuerySnapshot",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQuerySnapshot : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "BrowseFileList",
                "ClosestToPointInTime",
                "CloudDirect",
                "CloudDirects",
                "EmailSearch",
                "EventSearch",
                "FilesDelta",
                "FilesDeltaV2",
                "Fileset",
                "FilesetFiles",
                "LegalHoldSnappable",
                "OnedriveSearch",
                "Polaris",
                "Pvcs",
                "QuarantinedDetails",
                "Results",
                "SOfCloudDirectBucket",
                "SOfCloudDirectShare",
                "SnappableList",
                "SnappablesList",
                "SnappablesWithLegalHoldsSummary",
                "Snapshot",
                "UnmanagedObject",
                "VappInstantRecoveryOptions",
                "VappTemplateExportOptions",
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
                    case "BrowseFileList":
                        this.ProcessRecord_BrowseFileList();
                        break;
                    case "ClosestToPointInTime":
                        this.ProcessRecord_ClosestToPointInTime();
                        break;
                    case "CloudDirect":
                        this.ProcessRecord_CloudDirect();
                        break;
                    case "CloudDirects":
                        this.ProcessRecord_CloudDirects();
                        break;
                    case "EmailSearch":
                        this.ProcessRecord_EmailSearch();
                        break;
                    case "EventSearch":
                        this.ProcessRecord_EventSearch();
                        break;
                    case "FilesDelta":
                        this.ProcessRecord_FilesDelta();
                        break;
                    case "FilesDeltaV2":
                        this.ProcessRecord_FilesDeltaV2();
                        break;
                    case "Fileset":
                        this.ProcessRecord_Fileset();
                        break;
                    case "FilesetFiles":
                        this.ProcessRecord_FilesetFiles();
                        break;
                    case "LegalHoldSnappable":
                        this.ProcessRecord_LegalHoldSnappable();
                        break;
                    case "OnedriveSearch":
                        this.ProcessRecord_OnedriveSearch();
                        break;
                    case "Polaris":
                        this.ProcessRecord_Polaris();
                        break;
                    case "Pvcs":
                        this.ProcessRecord_Pvcs();
                        break;
                    case "QuarantinedDetails":
                        this.ProcessRecord_QuarantinedDetails();
                        break;
                    case "Results":
                        this.ProcessRecord_Results();
                        break;
                    case "SOfCloudDirectBucket":
                        this.ProcessRecord_SOfCloudDirectBucket();
                        break;
                    case "SOfCloudDirectShare":
                        this.ProcessRecord_SOfCloudDirectShare();
                        break;
                    case "SnappableList":
                        this.ProcessRecord_SnappableList();
                        break;
                    case "SnappablesList":
                        this.ProcessRecord_SnappablesList();
                        break;
                    case "SnappablesWithLegalHoldsSummary":
                        this.ProcessRecord_SnappablesWithLegalHoldsSummary();
                        break;
                    case "Snapshot":
                        this.ProcessRecord_Snapshot();
                        break;
                    case "UnmanagedObject":
                        this.ProcessRecord_UnmanagedObject();
                        break;
                    case "VappInstantRecoveryOptions":
                        this.ProcessRecord_VappInstantRecoveryOptions();
                        break;
                    case "VappTemplateExportOptions":
                        this.ProcessRecord_VappTemplateExportOptions();
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
        // browseSnapshotFileConnection.
        internal void ProcessRecord_BrowseFileList()
        {
            this._logger.name += " -BrowseFileList";
            // Create new graphql operation browseSnapshotFileConnection
            InitQueryBrowseSnapshotFileConnection();
        }

        // This parameter set invokes a single graphql operation:
        // allSnapshotsClosestToPointInTime.
        internal void ProcessRecord_ClosestToPointInTime()
        {
            this._logger.name += " -ClosestToPointInTime";
            // Create new graphql operation allSnapshotsClosestToPointInTime
            InitQueryAllSnapshotsClosestToPointInTime();
        }

        // This parameter set invokes a single graphql operation:
        // cloudDirectSnapshot.
        internal void ProcessRecord_CloudDirect()
        {
            this._logger.name += " -CloudDirect";
            // Create new graphql operation cloudDirectSnapshot
            InitQueryCloudDirectSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // cloudDirectSnapshots.
        internal void ProcessRecord_CloudDirects()
        {
            this._logger.name += " -CloudDirects";
            // Create new graphql operation cloudDirectSnapshots
            InitQueryCloudDirectSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // snapshotEmailSearch.
        internal void ProcessRecord_EmailSearch()
        {
            this._logger.name += " -EmailSearch";
            // Create new graphql operation snapshotEmailSearch
            InitQuerySnapshotEmailSearch();
        }

        // This parameter set invokes a single graphql operation:
        // snapshotEventSearch.
        internal void ProcessRecord_EventSearch()
        {
            this._logger.name += " -EventSearch";
            // Create new graphql operation snapshotEventSearch
            InitQuerySnapshotEventSearch();
        }

        // This parameter set invokes a single graphql operation:
        // snapshotFilesDelta.
        internal void ProcessRecord_FilesDelta()
        {
            this._logger.name += " -FilesDelta";
            // Create new graphql operation snapshotFilesDelta
            InitQuerySnapshotFilesDelta();
        }

        // This parameter set invokes a single graphql operation:
        // snapshotFilesDeltaV2.
        internal void ProcessRecord_FilesDeltaV2()
        {
            this._logger.name += " -FilesDeltaV2";
            // Create new graphql operation snapshotFilesDeltaV2
            InitQuerySnapshotFilesDeltaV2();
        }

        // This parameter set invokes a single graphql operation:
        // filesetSnapshot.
        internal void ProcessRecord_Fileset()
        {
            this._logger.name += " -Fileset";
            // Create new graphql operation filesetSnapshot
            InitQueryFilesetSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // filesetSnapshotFiles.
        internal void ProcessRecord_FilesetFiles()
        {
            this._logger.name += " -FilesetFiles";
            // Create new graphql operation filesetSnapshotFiles
            InitQueryFilesetSnapshotFiles();
        }

        // This parameter set invokes a single graphql operation:
        // legalHoldSnapshotsForSnappable.
        internal void ProcessRecord_LegalHoldSnappable()
        {
            this._logger.name += " -LegalHoldSnappable";
            // Create new graphql operation legalHoldSnapshotsForSnappable
            InitQueryLegalHoldSnapshotsForSnappable();
        }

        // This parameter set invokes a single graphql operation:
        // snapshotOnedriveSearch.
        internal void ProcessRecord_OnedriveSearch()
        {
            this._logger.name += " -OnedriveSearch";
            // Create new graphql operation snapshotOnedriveSearch
            InitQuerySnapshotOnedriveSearch();
        }

        // This parameter set invokes a single graphql operation:
        // polarisSnapshot.
        internal void ProcessRecord_Polaris()
        {
            this._logger.name += " -Polaris";
            // Create new graphql operation polarisSnapshot
            InitQueryPolarisSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // allSnapshotPvcs.
        internal void ProcessRecord_Pvcs()
        {
            this._logger.name += " -Pvcs";
            // Create new graphql operation allSnapshotPvcs
            InitQueryAllSnapshotPvcs();
        }

        // This parameter set invokes a single graphql operation:
        // allQuarantinedDetailsForSnapshots.
        internal void ProcessRecord_QuarantinedDetails()
        {
            this._logger.name += " -QuarantinedDetails";
            // Create new graphql operation allQuarantinedDetailsForSnapshots
            InitQueryAllQuarantinedDetailsForSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // snapshotResults.
        internal void ProcessRecord_Results()
        {
            this._logger.name += " -Results";
            // Create new graphql operation snapshotResults
            InitQuerySnapshotResults();
        }

        // This parameter set invokes a single graphql operation:
        // snapshotsOfCloudDirectBucket.
        internal void ProcessRecord_SOfCloudDirectBucket()
        {
            this._logger.name += " -SOfCloudDirectBucket";
            // Create new graphql operation snapshotsOfCloudDirectBucket
            InitQuerySnapshotsOfCloudDirectBucket();
        }

        // This parameter set invokes a single graphql operation:
        // snapshotsOfCloudDirectShare.
        internal void ProcessRecord_SOfCloudDirectShare()
        {
            this._logger.name += " -SOfCloudDirectShare";
            // Create new graphql operation snapshotsOfCloudDirectShare
            InitQuerySnapshotsOfCloudDirectShare();
        }

        // This parameter set invokes a single graphql operation:
        // snapshotOfASnappableConnection.
        internal void ProcessRecord_SnappableList()
        {
            this._logger.name += " -SnappableList";
            // Create new graphql operation snapshotOfASnappableConnection
            InitQuerySnapshotOfAsnappableConnection();
        }

        // This parameter set invokes a single graphql operation:
        // snapshotOfSnappablesConnection.
        internal void ProcessRecord_SnappablesList()
        {
            this._logger.name += " -SnappablesList";
            // Create new graphql operation snapshotOfSnappablesConnection
            InitQuerySnapshotOfSnappablesConnection();
        }

        // This parameter set invokes a single graphql operation:
        // snappablesWithLegalHoldSnapshotsSummary.
        internal void ProcessRecord_SnappablesWithLegalHoldsSummary()
        {
            this._logger.name += " -SnappablesWithLegalHoldsSummary";
            // Create new graphql operation snappablesWithLegalHoldSnapshotsSummary
            InitQuerySnappablesWithLegalHoldSnapshotsSummary();
        }

        // This parameter set invokes a single graphql operation:
        // snapshot.
        internal void ProcessRecord_Snapshot()
        {
            this._logger.name += " -Snapshot";
            // Create new graphql operation snapshot
            InitQuerySnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // snapshotsForUnmanagedObject.
        internal void ProcessRecord_UnmanagedObject()
        {
            this._logger.name += " -UnmanagedObject";
            // Create new graphql operation snapshotsForUnmanagedObject
            InitQuerySnapshotsForUnmanagedObject();
        }

        // This parameter set invokes a single graphql operation:
        // vappSnapshotInstantRecoveryOptions.
        internal void ProcessRecord_VappInstantRecoveryOptions()
        {
            this._logger.name += " -VappInstantRecoveryOptions";
            // Create new graphql operation vappSnapshotInstantRecoveryOptions
            InitQueryVappSnapshotInstantRecoveryOptions();
        }

        // This parameter set invokes a single graphql operation:
        // vappTemplateSnapshotExportOptions.
        internal void ProcessRecord_VappTemplateExportOptions()
        {
            this._logger.name += " -VappTemplateExportOptions";
            // Create new graphql operation vappTemplateSnapshotExportOptions
            InitQueryVappTemplateSnapshotExportOptions();
        }


        // Create new GraphQL Query:
        // browseSnapshotFileConnection(
        //     first: Int
        //     after: String
        //     path: String!
        //     snapshotFid: UUID!
        //     searchPrefix: String
        //   ): SnapshotFileConnection!
        internal void InitQueryBrowseSnapshotFileConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("path", "String!"),
                Tuple.Create("snapshotFid", "UUID!"),
                Tuple.Create("searchPrefix", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryBrowseSnapshotFileConnection",
                "($first: Int,$after: String,$path: String!,$snapshotFid: UUID!,$searchPrefix: String)",
                "SnapshotFileConnection",
                Query.BrowseSnapshotFileConnection,
                Query.BrowseSnapshotFileConnectionFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.path = $someString
# REQUIRED
$query.Var.snapshotFid = $someString
# OPTIONAL
$query.Var.searchPrefix = $someString"
            );
        }

        // Create new GraphQL Query:
        // allSnapshotsClosestToPointInTime(
        //     beforeTime: DateTime
        //     afterTime: DateTime
        //     snappableIds: [String!]!
        //     includeLinked: Boolean
        //     ignoreActiveWorkloadCheck: Boolean
        //     excludeQuarantined: Boolean
        //     excludeAnomalous: Boolean
        //     quarantinedOnly: Boolean
        //     anomalousOnly: Boolean
        //     getFullDetails: Boolean
        //     excludeReplica: Boolean
        //     excludeArchivalLocationTypes: [String!]
        //   ): [ClosestSnapshotSearchResult!]!
        internal void InitQueryAllSnapshotsClosestToPointInTime()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("beforeTime", "DateTime"),
                Tuple.Create("afterTime", "DateTime"),
                Tuple.Create("snappableIds", "[String!]!"),
                Tuple.Create("includeLinked", "Boolean"),
                Tuple.Create("ignoreActiveWorkloadCheck", "Boolean"),
                Tuple.Create("excludeQuarantined", "Boolean"),
                Tuple.Create("excludeAnomalous", "Boolean"),
                Tuple.Create("quarantinedOnly", "Boolean"),
                Tuple.Create("anomalousOnly", "Boolean"),
                Tuple.Create("getFullDetails", "Boolean"),
                Tuple.Create("excludeReplica", "Boolean"),
                Tuple.Create("excludeArchivalLocationTypes", "[String!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllSnapshotsClosestToPointInTime",
                "($beforeTime: DateTime,$afterTime: DateTime,$snappableIds: [String!]!,$includeLinked: Boolean,$ignoreActiveWorkloadCheck: Boolean,$excludeQuarantined: Boolean,$excludeAnomalous: Boolean,$quarantinedOnly: Boolean,$anomalousOnly: Boolean,$getFullDetails: Boolean,$excludeReplica: Boolean,$excludeArchivalLocationTypes: [String!])",
                "List<ClosestSnapshotSearchResult>",
                Query.AllSnapshotsClosestToPointInTime,
                Query.AllSnapshotsClosestToPointInTimeFieldSpec,
                @"# OPTIONAL
$query.Var.beforeTime = $someDateTime
# OPTIONAL
$query.Var.afterTime = $someDateTime
# REQUIRED
$query.Var.snappableIds = @(
	$someString
)
# OPTIONAL
$query.Var.includeLinked = $someBoolean
# OPTIONAL
$query.Var.ignoreActiveWorkloadCheck = $someBoolean
# OPTIONAL
$query.Var.excludeQuarantined = $someBoolean
# OPTIONAL
$query.Var.excludeAnomalous = $someBoolean
# OPTIONAL
$query.Var.quarantinedOnly = $someBoolean
# OPTIONAL
$query.Var.anomalousOnly = $someBoolean
# OPTIONAL
$query.Var.getFullDetails = $someBoolean
# OPTIONAL
$query.Var.excludeReplica = $someBoolean
# OPTIONAL
$query.Var.excludeArchivalLocationTypes = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // cloudDirectSnapshot(snapshotFid: UUID!): CloudDirectSnapshot!
        internal void InitQueryCloudDirectSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snapshotFid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCloudDirectSnapshot",
                "($snapshotFid: UUID!)",
                "CloudDirectSnapshot",
                Query.CloudDirectSnapshot,
                Query.CloudDirectSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.snapshotFid = $someString"
            );
        }

        // Create new GraphQL Query:
        // cloudDirectSnapshots(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     filter: [CloudDirectSnapshotsFilterInput!]
        //     sortBy: CloudDirectSnapshotsSortByInput
        //   ): CloudDirectSnapshotConnection!
        internal void InitQueryCloudDirectSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("filter", "[CloudDirectSnapshotsFilterInput!]"),
                Tuple.Create("sortBy", "CloudDirectSnapshotsSortByInput"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCloudDirectSnapshots",
                "($first: Int,$after: String,$last: Int,$before: String,$filter: [CloudDirectSnapshotsFilterInput!],$sortBy: CloudDirectSnapshotsSortByInput)",
                "CloudDirectSnapshotConnection",
                Query.CloudDirectSnapshots,
                Query.CloudDirectSnapshotsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someCloudDirectSnapshotsFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudDirectSnapshotsFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
}
)
# OPTIONAL
$query.Var.sortBy = @{
	# OPTIONAL
	field = $someCloudDirectSnapshotsSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudDirectSnapshotsSortByField]) for enum values.
	# OPTIONAL
	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}"
            );
        }

        // Create new GraphQL Query:
        // snapshotEmailSearch(
        //     first: Int
        //     after: String
        //     snappableFid: UUID!
        //     snapshotFid: UUID!
        //     orgId: UUID!
        //     searchFilter: SearchFilter
        //   ): O365ExchangeObjectConnection!
        internal void InitQuerySnapshotEmailSearch()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("snapshotFid", "UUID!"),
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("searchFilter", "SearchFilter"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySnapshotEmailSearch",
                "($first: Int,$after: String,$snappableFid: UUID!,$snapshotFid: UUID!,$orgId: UUID!,$searchFilter: SearchFilter)",
                "O365ExchangeObjectConnection",
                Query.SnapshotEmailSearch,
                Query.SnapshotEmailSearchFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.snappableFid = $someString
# REQUIRED
$query.Var.snapshotFid = $someString
# REQUIRED
$query.Var.orgId = $someString
# OPTIONAL
$query.Var.searchFilter = @{
	# OPTIONAL
	searchKeywordFilter = @{
		# OPTIONAL
		searchKeyword = $someString
		# OPTIONAL
		keywordType = $someSearchKeywordType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SearchKeywordType]) for enum values.
	}
	# OPTIONAL
	emailAddresses = @(
		@{
			# OPTIONAL
			emailAddress = $someString
			# OPTIONAL
			emailAddressType = $someEmailAddressFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EmailAddressFilterType]) for enum values.
		}
	)
	# OPTIONAL
	fromTime = $someDateTime
	# OPTIONAL
	untilTime = $someDateTime
	# OPTIONAL
	searchObjectFilter = @{
		# OPTIONAL
		searchObjectType = $someSearchObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SearchObjectType]) for enum values.
	}
	# OPTIONAL
	lambdaFilters = @{
		# OPTIONAL
		enableAbsolutePaths = $someBoolean
		# OPTIONAL
		enableAbsolutePathCachePreload = $someBoolean
		# OPTIONAL
		parentFolderIdBatch = @(
			$someString
		)
		# OPTIONAL
		searchRecurseFolderId = $someString
		# OPTIONAL
		includeAncestors = $someBoolean
	}
	# OPTIONAL
	archiveFolderAction = $someArchiveFolderAction # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ArchiveFolderAction]) for enum values.
	# OPTIONAL
	skipRifItems = $someBoolean
}"
            );
        }

        // Create new GraphQL Query:
        // snapshotEventSearch(
        //     first: Int
        //     after: String
        //     snappableFid: UUID!
        //     snapshotFid: UUID!
        //     orgId: UUID!
        //     calendarSearchFilter: CalendarSearchFilter
        //   ): O365ExchangeObjectConnection!
        internal void InitQuerySnapshotEventSearch()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("snapshotFid", "UUID!"),
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("calendarSearchFilter", "CalendarSearchFilter"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySnapshotEventSearch",
                "($first: Int,$after: String,$snappableFid: UUID!,$snapshotFid: UUID!,$orgId: UUID!,$calendarSearchFilter: CalendarSearchFilter)",
                "O365ExchangeObjectConnection",
                Query.SnapshotEventSearch,
                Query.SnapshotEventSearchFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.snappableFid = $someString
# REQUIRED
$query.Var.snapshotFid = $someString
# REQUIRED
$query.Var.orgId = $someString
# OPTIONAL
$query.Var.calendarSearchFilter = @{
	# OPTIONAL
	searchKeywordFilter = @{
		# OPTIONAL
		searchKeyword = $someString
		# OPTIONAL
		keywordType = $someCalendarSearchKeywordType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CalendarSearchKeywordType]) for enum values.
	}
	# OPTIONAL
	emailAddresses = @(
		@{
			# OPTIONAL
			emailAddress = $someString
			# OPTIONAL
			filterType = $someCalendarEmailAddressFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CalendarEmailAddressFilterType]) for enum values.
		}
	)
	# OPTIONAL
	timerange = @{
		# OPTIONAL
		fromTime = $someDateTime
		# OPTIONAL
		untilTime = $someDateTime
	}
	# OPTIONAL
	searchObjectFilter = @{
		# OPTIONAL
		searchObjectType = $someO365CalendarSearchObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365CalendarSearchObjectType]) for enum values.
	}
	# OPTIONAL
	recurrenceFilter = @{
		# OPTIONAL
		recurrenceType = $someCalendarRecurrenceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CalendarRecurrenceType]) for enum values.
	}
	# OPTIONAL
	lambdaFilters = @{
		# OPTIONAL
		enableAbsolutePaths = $someBoolean
		# OPTIONAL
		enableAbsolutePathCachePreload = $someBoolean
		# OPTIONAL
		parentFolderIdBatch = @(
			$someString
		)
		# OPTIONAL
		searchRecurseFolderId = $someString
		# OPTIONAL
		includeAncestors = $someBoolean
	}
	# OPTIONAL
	skipRifItems = $someBoolean
}"
            );
        }

        // Create new GraphQL Query:
        // snapshotFilesDelta(
        //     first: Int
        //     after: String
        //     path: String!
        //     snapshotFid: UUID!
        //     filter: SnapshotDeltaFilterInput
        //     searchPrefix: String
        //     quarantineFilters: [QuarantineFilter!]
        //     workloadFieldsArg: WorkloadFieldsInput
        //   ): SnapshotFileDeltaConnection!
        internal void InitQuerySnapshotFilesDelta()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("path", "String!"),
                Tuple.Create("snapshotFid", "UUID!"),
                Tuple.Create("filter", "SnapshotDeltaFilterInput"),
                Tuple.Create("searchPrefix", "String"),
                Tuple.Create("quarantineFilters", "[QuarantineFilter!]"),
                Tuple.Create("workloadFieldsArg", "WorkloadFieldsInput"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySnapshotFilesDelta",
                "($first: Int,$after: String,$path: String!,$snapshotFid: UUID!,$filter: SnapshotDeltaFilterInput,$searchPrefix: String,$quarantineFilters: [QuarantineFilter!],$workloadFieldsArg: WorkloadFieldsInput)",
                "SnapshotFileDeltaConnection",
                Query.SnapshotFilesDelta,
                Query.SnapshotFilesDeltaFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.path = $someString
# REQUIRED
$query.Var.snapshotFid = $someString
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	deltaType = @(
		$someDeltaType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeltaType]) for enum values.
	)
}
# OPTIONAL
$query.Var.searchPrefix = $someString
# OPTIONAL
$query.Var.quarantineFilters = @(
	$someQuarantineFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.QuarantineFilter]) for enum values.
)
# OPTIONAL
$query.Var.workloadFieldsArg = @{
	# OPTIONAL
	o365FileDelta = @{
		# OPTIONAL
		folderId = $someString
		# OPTIONAL
		orgId = $someString
	}
	# OPTIONAL
	o365SharepointDelta = @{
		# OPTIONAL
		folderId = $someString
		# OPTIONAL
		orgId = $someString
		# OPTIONAL
		sharepointSiteReq = @{
			# OPTIONAL
			siteChildId = $someString
			# OPTIONAL
			siteChildType = $someSharePointDescendantType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SharePointDescendantType]) for enum values.
		}
	}
}"
            );
        }

        // Create new GraphQL Query:
        // snapshotFilesDeltaV2(
        //     first: Int
        //     after: String
        //     path: String!
        //     snapshotFid: UUID!
        //     filter: SnapshotDeltaFilterInput
        //     searchPrefix: String
        //     quarantineFilters: [QuarantineFilter!]
        //     workloadFieldsArg: WorkloadFieldsInput
        //   ): SnapshotFileDeltaV2Connection!
        internal void InitQuerySnapshotFilesDeltaV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("path", "String!"),
                Tuple.Create("snapshotFid", "UUID!"),
                Tuple.Create("filter", "SnapshotDeltaFilterInput"),
                Tuple.Create("searchPrefix", "String"),
                Tuple.Create("quarantineFilters", "[QuarantineFilter!]"),
                Tuple.Create("workloadFieldsArg", "WorkloadFieldsInput"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySnapshotFilesDeltaV2",
                "($first: Int,$after: String,$path: String!,$snapshotFid: UUID!,$filter: SnapshotDeltaFilterInput,$searchPrefix: String,$quarantineFilters: [QuarantineFilter!],$workloadFieldsArg: WorkloadFieldsInput)",
                "SnapshotFileDeltaV2Connection",
                Query.SnapshotFilesDeltaV2,
                Query.SnapshotFilesDeltaV2FieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.path = $someString
# REQUIRED
$query.Var.snapshotFid = $someString
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	deltaType = @(
		$someDeltaType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeltaType]) for enum values.
	)
}
# OPTIONAL
$query.Var.searchPrefix = $someString
# OPTIONAL
$query.Var.quarantineFilters = @(
	$someQuarantineFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.QuarantineFilter]) for enum values.
)
# OPTIONAL
$query.Var.workloadFieldsArg = @{
	# OPTIONAL
	o365FileDelta = @{
		# OPTIONAL
		folderId = $someString
		# OPTIONAL
		orgId = $someString
	}
	# OPTIONAL
	o365SharepointDelta = @{
		# OPTIONAL
		folderId = $someString
		# OPTIONAL
		orgId = $someString
		# OPTIONAL
		sharepointSiteReq = @{
			# OPTIONAL
			siteChildId = $someString
			# OPTIONAL
			siteChildType = $someSharePointDescendantType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SharePointDescendantType]) for enum values.
		}
	}
}"
            );
        }

        // Create new GraphQL Query:
        // filesetSnapshot(id: String!, verbose: Boolean): FilesetSnapshotDetail!
        internal void InitQueryFilesetSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("id", "String!"),
                Tuple.Create("verbose", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryFilesetSnapshot",
                "($id: String!,$verbose: Boolean)",
                "FilesetSnapshotDetail",
                Query.FilesetSnapshot,
                Query.FilesetSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.id = $someString
# OPTIONAL
$query.Var.verbose = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // filesetSnapshotFiles(
        //     id: String!
        //     limit: Int
        //     offset: Int
        //     path: String!
        //   ): BrowseResponseListResponse!
        internal void InitQueryFilesetSnapshotFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("id", "String!"),
                Tuple.Create("limit", "Int"),
                Tuple.Create("offset", "Int"),
                Tuple.Create("path", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryFilesetSnapshotFiles",
                "($id: String!,$limit: Int,$offset: Int,$path: String!)",
                "BrowseResponseListResponse",
                Query.FilesetSnapshotFiles,
                Query.FilesetSnapshotFilesFieldSpec,
                @"# REQUIRED
$query.Var.id = $someString
# OPTIONAL
$query.Var.limit = $someInt
# OPTIONAL
$query.Var.offset = $someInt
# REQUIRED
$query.Var.path = $someString"
            );
        }

        // Create new GraphQL Query:
        // legalHoldSnapshotsForSnappable(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     input: LegalHoldSnapshotsForSnappableInput!
        //   ): LegalHoldSnapshotDetailConnection!
        internal void InitQueryLegalHoldSnapshotsForSnappable()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("input", "LegalHoldSnapshotsForSnappableInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryLegalHoldSnapshotsForSnappable",
                "($first: Int,$after: String,$last: Int,$before: String,$input: LegalHoldSnapshotsForSnappableInput!)",
                "LegalHoldSnapshotDetailConnection",
                Query.LegalHoldSnapshotsForSnappable,
                Query.LegalHoldSnapshotsForSnappableFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	snappableId = $someString
	# REQUIRED
	filterParams = @(
		@{
			# OPTIONAL
			filterField = $someLegalHoldQueryFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LegalHoldQueryFilterField]) for enum values.
			# OPTIONAL
			beforeTime = $someDateTime
			# OPTIONAL
			afterTime = $someDateTime
			# OPTIONAL
			snappableName = $someString
			# OPTIONAL
			snappableTypes = @(
				$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
			)
			# OPTIONAL
			snapshotTypes = @(
				$someSnapshotTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotTypeEnum]) for enum values.
			)
			# OPTIONAL
			snapshotCustomizations = @(
				$someSnapshotCustomization # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotCustomization]) for enum values.
			)
		}
	)
	# OPTIONAL
	sortParam = @{
		# OPTIONAL
		type = $someLegalHoldSortType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LegalHoldSortType]) for enum values.
		# OPTIONAL
		sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
	}
}"
            );
        }

        // Create new GraphQL Query:
        // snapshotOnedriveSearch(
        //     first: Int
        //     after: String
        //     snappableFid: UUID!
        //     snapshotFid: UUID!
        //     orgId: UUID!
        //     onedriveSearchFilter: OnedriveSearchFilter
        //   ): O365OnedriveObjectConnection!
        internal void InitQuerySnapshotOnedriveSearch()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("snapshotFid", "UUID!"),
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("onedriveSearchFilter", "OnedriveSearchFilter"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySnapshotOnedriveSearch",
                "($first: Int,$after: String,$snappableFid: UUID!,$snapshotFid: UUID!,$orgId: UUID!,$onedriveSearchFilter: OnedriveSearchFilter)",
                "O365OnedriveObjectConnection",
                Query.SnapshotOnedriveSearch,
                Query.SnapshotOnedriveSearchFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.snappableFid = $someString
# REQUIRED
$query.Var.snapshotFid = $someString
# REQUIRED
$query.Var.orgId = $someString
# OPTIONAL
$query.Var.onedriveSearchFilter = @{
	# OPTIONAL
	searchKeywordFilter = @{
		# OPTIONAL
		searchKeyword = $someString
		# OPTIONAL
		keywordType = $someOnedriveSearchKeywordType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OnedriveSearchKeywordType]) for enum values.
	}
	# OPTIONAL
	modifiedTime = @{
		# OPTIONAL
		fromTime = $someDateTime
		# OPTIONAL
		untilTime = $someDateTime
	}
	# OPTIONAL
	createTime = @{
		# OPTIONAL
		fromTime = $someDateTime
		# OPTIONAL
		untilTime = $someDateTime
	}
	# OPTIONAL
	searchObjectFilter = @{
		# OPTIONAL
		searchObjectType = $someOnedriveSearchObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OnedriveSearchObjectType]) for enum values.
	}
	# OPTIONAL
	channelId = $someString
	# OPTIONAL
	channelFolderName = $someString
	# OPTIONAL
	channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
	# OPTIONAL
	excludeItemsUnderRoot = $someBoolean
	# OPTIONAL
	channelNameKeyword = $someString
	# OPTIONAL
	useExactVersionMatch = $someBoolean
	# OPTIONAL
	lambdaFilters = @{
		# OPTIONAL
		enableAbsolutePaths = $someBoolean
		# OPTIONAL
		enableAbsolutePathCachePreload = $someBoolean
		# OPTIONAL
		parentFolderIdBatch = @(
			$someString
		)
		# OPTIONAL
		searchRecurseFolderId = $someString
		# OPTIONAL
		includeAncestors = $someBoolean
	}
	# OPTIONAL
	objectId = $someString
	# OPTIONAL
	filePath = $someString
	# OPTIONAL
	parentWorkloadId = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // polarisSnapshot(snapshotFid: UUID!): PolarisSnapshot!
        internal void InitQueryPolarisSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snapshotFid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryPolarisSnapshot",
                "($snapshotFid: UUID!)",
                "PolarisSnapshot",
                Query.PolarisSnapshot,
                Query.PolarisSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.snapshotFid = $someString"
            );
        }

        // Create new GraphQL Query:
        // allSnapshotPvcs(snapshotId: String!, snappableId: UUID!, isReplica: Boolean! = false): [PvcInformation!]!
        internal void InitQueryAllSnapshotPvcs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snapshotId", "String!"),
                Tuple.Create("snappableId", "UUID!"),
                Tuple.Create("isReplica", "Boolean!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllSnapshotPvcs",
                "($snapshotId: String!,$snappableId: UUID!,$isReplica: Boolean!)",
                "List<PvcInformation>",
                Query.AllSnapshotPvcs,
                Query.AllSnapshotPvcsFieldSpec,
                @"# REQUIRED
$query.Var.snapshotId = $someString
# REQUIRED
$query.Var.snappableId = $someString
# REQUIRED
$query.Var.isReplica = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // allQuarantinedDetailsForSnapshots(snapshotIds: [String!]!): [QuarantineSpec!]!
        internal void InitQueryAllQuarantinedDetailsForSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snapshotIds", "[String!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllQuarantinedDetailsForSnapshots",
                "($snapshotIds: [String!]!)",
                "List<QuarantineSpec>",
                Query.AllQuarantinedDetailsForSnapshots,
                Query.AllQuarantinedDetailsForSnapshotsFieldSpec,
                @"# REQUIRED
$query.Var.snapshotIds = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // snapshotResults(snappableFid: String!, startTimeMs: Long!, endTimeMs: Long!): SnapshotResultConnection!
        internal void InitQuerySnapshotResults()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "String!"),
                Tuple.Create("startTimeMs", "Long!"),
                Tuple.Create("endTimeMs", "Long!"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySnapshotResults",
                "($snappableFid: String!,$startTimeMs: Long!,$endTimeMs: Long!)",
                "SnapshotResultConnection",
                Query.SnapshotResults,
                Query.SnapshotResultsFieldSpec,
                @"# REQUIRED
$query.Var.snappableFid = $someString
# REQUIRED
$query.Var.startTimeMs = $someInt64
# REQUIRED
$query.Var.endTimeMs = $someInt64"
            );
        }

        // Create new GraphQL Query:
        // snapshotsOfCloudDirectBucket(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     workloadId: String!
        //     snapshotFilter: [SnapshotQueryFilterInput!]
        //     sortOrder: SortOrder
        //     sortBy: SnapshotQuerySortByField
        //     timeRange: TimeRangeInput
        //     cloudDirectTargetId: UUID
        //   ): CloudDirectSnapshotConnection!
        internal void InitQuerySnapshotsOfCloudDirectBucket()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("workloadId", "String!"),
                Tuple.Create("snapshotFilter", "[SnapshotQueryFilterInput!]"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "SnapshotQuerySortByField"),
                Tuple.Create("timeRange", "TimeRangeInput"),
                Tuple.Create("cloudDirectTargetId", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySnapshotsOfCloudDirectBucket",
                "($first: Int,$after: String,$last: Int,$before: String,$workloadId: String!,$snapshotFilter: [SnapshotQueryFilterInput!],$sortOrder: SortOrder,$sortBy: SnapshotQuerySortByField,$timeRange: TimeRangeInput,$cloudDirectTargetId: UUID)",
                "CloudDirectSnapshotConnection",
                Query.SnapshotsOfCloudDirectBucket,
                Query.SnapshotsOfCloudDirectBucketFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# REQUIRED
$query.Var.workloadId = $someString
# OPTIONAL
$query.Var.snapshotFilter = @(
	@{
		# OPTIONAL
		field = $someSnapshotQueryFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotQueryFilterField]) for enum values.
		# OPTIONAL
		text = $someString
		# OPTIONAL
		typeFilters = @(
			$someSnapshotTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotTypeEnum]) for enum values.
		)
		# OPTIONAL
		shouldFetchLinked = $someBoolean
		# OPTIONAL
		textList = @(
			$someString
		)
		# OPTIONAL
		time = $someDateTime
		# OPTIONAL
		customizationFilters = @(
			$someSnapshotCustomization # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotCustomization]) for enum values.
		)
}
)
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.sortBy = $someSnapshotQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotQuerySortByField]) for enum values.
# OPTIONAL
$query.Var.timeRange = @{
	# REQUIRED
	start = $someDateTime
	# REQUIRED
	end = $someDateTime
}
# OPTIONAL
$query.Var.cloudDirectTargetId = $someString"
            );
        }

        // Create new GraphQL Query:
        // snapshotsOfCloudDirectShare(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     workloadId: String!
        //     snapshotFilter: [SnapshotQueryFilterInput!]
        //     sortOrder: SortOrder
        //     sortBy: SnapshotQuerySortByField
        //     timeRange: TimeRangeInput
        //     cloudDirectTargetId: UUID
        //   ): CloudDirectSnapshotConnection!
        internal void InitQuerySnapshotsOfCloudDirectShare()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("workloadId", "String!"),
                Tuple.Create("snapshotFilter", "[SnapshotQueryFilterInput!]"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "SnapshotQuerySortByField"),
                Tuple.Create("timeRange", "TimeRangeInput"),
                Tuple.Create("cloudDirectTargetId", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySnapshotsOfCloudDirectShare",
                "($first: Int,$after: String,$last: Int,$before: String,$workloadId: String!,$snapshotFilter: [SnapshotQueryFilterInput!],$sortOrder: SortOrder,$sortBy: SnapshotQuerySortByField,$timeRange: TimeRangeInput,$cloudDirectTargetId: UUID)",
                "CloudDirectSnapshotConnection",
                Query.SnapshotsOfCloudDirectShare,
                Query.SnapshotsOfCloudDirectShareFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# REQUIRED
$query.Var.workloadId = $someString
# OPTIONAL
$query.Var.snapshotFilter = @(
	@{
		# OPTIONAL
		field = $someSnapshotQueryFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotQueryFilterField]) for enum values.
		# OPTIONAL
		text = $someString
		# OPTIONAL
		typeFilters = @(
			$someSnapshotTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotTypeEnum]) for enum values.
		)
		# OPTIONAL
		shouldFetchLinked = $someBoolean
		# OPTIONAL
		textList = @(
			$someString
		)
		# OPTIONAL
		time = $someDateTime
		# OPTIONAL
		customizationFilters = @(
			$someSnapshotCustomization # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotCustomization]) for enum values.
		)
}
)
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.sortBy = $someSnapshotQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotQuerySortByField]) for enum values.
# OPTIONAL
$query.Var.timeRange = @{
	# REQUIRED
	start = $someDateTime
	# REQUIRED
	end = $someDateTime
}
# OPTIONAL
$query.Var.cloudDirectTargetId = $someString"
            );
        }

        // Create new GraphQL Query:
        // snapshotOfASnappableConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     workloadId: String!
        //     snapshotFilter: [SnapshotQueryFilterInput!]
        //     sortOrder: SortOrder
        //     sortBy: SnapshotQuerySortByField
        //     timeRange: TimeRangeInput
        //     ignoreActiveWorkloadCheck: Boolean
        //     showSnapshotRetentionInfo: Boolean
        //   ): GenericSnapshotConnection!
        internal void InitQuerySnapshotOfAsnappableConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("workloadId", "String!"),
                Tuple.Create("snapshotFilter", "[SnapshotQueryFilterInput!]"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "SnapshotQuerySortByField"),
                Tuple.Create("timeRange", "TimeRangeInput"),
                Tuple.Create("ignoreActiveWorkloadCheck", "Boolean"),
                Tuple.Create("showSnapshotRetentionInfo", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySnapshotOfAsnappableConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$workloadId: String!,$snapshotFilter: [SnapshotQueryFilterInput!],$sortOrder: SortOrder,$sortBy: SnapshotQuerySortByField,$timeRange: TimeRangeInput,$ignoreActiveWorkloadCheck: Boolean,$showSnapshotRetentionInfo: Boolean)",
                "GenericSnapshotConnection",
                Query.SnapshotOfAsnappableConnection,
                Query.SnapshotOfAsnappableConnectionFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# REQUIRED
$query.Var.workloadId = $someString
# OPTIONAL
$query.Var.snapshotFilter = @(
	@{
		# OPTIONAL
		field = $someSnapshotQueryFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotQueryFilterField]) for enum values.
		# OPTIONAL
		text = $someString
		# OPTIONAL
		typeFilters = @(
			$someSnapshotTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotTypeEnum]) for enum values.
		)
		# OPTIONAL
		shouldFetchLinked = $someBoolean
		# OPTIONAL
		textList = @(
			$someString
		)
		# OPTIONAL
		time = $someDateTime
		# OPTIONAL
		customizationFilters = @(
			$someSnapshotCustomization # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotCustomization]) for enum values.
		)
}
)
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.sortBy = $someSnapshotQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotQuerySortByField]) for enum values.
# OPTIONAL
$query.Var.timeRange = @{
	# REQUIRED
	start = $someDateTime
	# REQUIRED
	end = $someDateTime
}
# OPTIONAL
$query.Var.ignoreActiveWorkloadCheck = $someBoolean
# OPTIONAL
$query.Var.showSnapshotRetentionInfo = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // snapshotOfSnappablesConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     snappableIds: [String!]!
        //     snapshotFilter: [SnapshotQueryFilterInput!]
        //     sortOrder: SortOrder
        //     sortBy: SnapshotQuerySortByField
        //     timeRange: TimeRangeInput
        //     ignoreActiveWorkloadCheck: Boolean
        //   ): GenericSnapshotConnection!
        internal void InitQuerySnapshotOfSnappablesConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("snappableIds", "[String!]!"),
                Tuple.Create("snapshotFilter", "[SnapshotQueryFilterInput!]"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "SnapshotQuerySortByField"),
                Tuple.Create("timeRange", "TimeRangeInput"),
                Tuple.Create("ignoreActiveWorkloadCheck", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySnapshotOfSnappablesConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$snappableIds: [String!]!,$snapshotFilter: [SnapshotQueryFilterInput!],$sortOrder: SortOrder,$sortBy: SnapshotQuerySortByField,$timeRange: TimeRangeInput,$ignoreActiveWorkloadCheck: Boolean)",
                "GenericSnapshotConnection",
                Query.SnapshotOfSnappablesConnection,
                Query.SnapshotOfSnappablesConnectionFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# REQUIRED
$query.Var.snappableIds = @(
	$someString
)
# OPTIONAL
$query.Var.snapshotFilter = @(
	@{
		# OPTIONAL
		field = $someSnapshotQueryFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotQueryFilterField]) for enum values.
		# OPTIONAL
		text = $someString
		# OPTIONAL
		typeFilters = @(
			$someSnapshotTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotTypeEnum]) for enum values.
		)
		# OPTIONAL
		shouldFetchLinked = $someBoolean
		# OPTIONAL
		textList = @(
			$someString
		)
		# OPTIONAL
		time = $someDateTime
		# OPTIONAL
		customizationFilters = @(
			$someSnapshotCustomization # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotCustomization]) for enum values.
		)
}
)
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.sortBy = $someSnapshotQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotQuerySortByField]) for enum values.
# OPTIONAL
$query.Var.timeRange = @{
	# REQUIRED
	start = $someDateTime
	# REQUIRED
	end = $someDateTime
}
# OPTIONAL
$query.Var.ignoreActiveWorkloadCheck = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // snappablesWithLegalHoldSnapshotsSummary(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     input: SnappablesWithLegalHoldSnapshotsInput!
        //   ): LegalHoldSnappableDetailConnection!
        internal void InitQuerySnappablesWithLegalHoldSnapshotsSummary()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("input", "SnappablesWithLegalHoldSnapshotsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySnappablesWithLegalHoldSnapshotsSummary",
                "($first: Int,$after: String,$last: Int,$before: String,$input: SnappablesWithLegalHoldSnapshotsInput!)",
                "LegalHoldSnappableDetailConnection",
                Query.SnappablesWithLegalHoldSnapshotsSummary,
                Query.SnappablesWithLegalHoldSnapshotsSummaryFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	filterParams = @(
		@{
			# OPTIONAL
			filterField = $someLegalHoldQueryFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LegalHoldQueryFilterField]) for enum values.
			# OPTIONAL
			beforeTime = $someDateTime
			# OPTIONAL
			afterTime = $someDateTime
			# OPTIONAL
			snappableName = $someString
			# OPTIONAL
			snappableTypes = @(
				$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
			)
			# OPTIONAL
			snapshotTypes = @(
				$someSnapshotTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotTypeEnum]) for enum values.
			)
			# OPTIONAL
			snapshotCustomizations = @(
				$someSnapshotCustomization # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotCustomization]) for enum values.
			)
		}
	)
	# OPTIONAL
	sortParam = @{
		# OPTIONAL
		type = $someLegalHoldSortType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LegalHoldSortType]) for enum values.
		# OPTIONAL
		sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
	}
}"
            );
        }

        // Create new GraphQL Query:
        // snapshot(snapshotFid: UUID!, clusterUuid: UUID): CdmSnapshot!
        internal void InitQuerySnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snapshotFid", "UUID!"),
                Tuple.Create("clusterUuid", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySnapshot",
                "($snapshotFid: UUID!,$clusterUuid: UUID)",
                "CdmSnapshot",
                Query.Snapshot,
                Query.SnapshotFieldSpec,
                @"# REQUIRED
$query.Var.snapshotFid = $someString
# OPTIONAL
$query.Var.clusterUuid = $someString"
            );
        }

        // Create new GraphQL Query:
        // snapshotsForUnmanagedObject(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     input: QueryUnmanagedObjectSnapshotsV1Input!
        //   ): SnapshotSummaryConnection!
        internal void InitQuerySnapshotsForUnmanagedObject()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("input", "QueryUnmanagedObjectSnapshotsV1Input!"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySnapshotsForUnmanagedObject",
                "($first: Int,$after: String,$last: Int,$before: String,$input: QueryUnmanagedObjectSnapshotsV1Input!)",
                "SnapshotSummaryConnection",
                Query.SnapshotsForUnmanagedObject,
                Query.SnapshotsForUnmanagedObjectFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	afterDate = $someDateTime
	# OPTIONAL
	beforeDate = $someDateTime
	# OPTIONAL
	limit = $someInt
	# OPTIONAL
	offset = $someInt
	# OPTIONAL
	searchValue = $someString
	# OPTIONAL
	snapshotType = $someV1QueryUnmanagedObjectSnapshotsV1RequestSnapshotType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryUnmanagedObjectSnapshotsV1RequestSnapshotType]) for enum values.
	# OPTIONAL
	sortBy = $someV1QueryUnmanagedObjectSnapshotsV1RequestSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryUnmanagedObjectSnapshotsV1RequestSortBy]) for enum values.
	# OPTIONAL
	sortOrder = $someV1QueryUnmanagedObjectSnapshotsV1RequestSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryUnmanagedObjectSnapshotsV1RequestSortOrder]) for enum values.
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // vappSnapshotInstantRecoveryOptions(input: VappSnapshotInstantRecoveryOptionsInput!): VappInstantRecoveryOptions!
        internal void InitQueryVappSnapshotInstantRecoveryOptions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VappSnapshotInstantRecoveryOptionsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVappSnapshotInstantRecoveryOptions",
                "($input: VappSnapshotInstantRecoveryOptionsInput!)",
                "VappInstantRecoveryOptions",
                Query.VappSnapshotInstantRecoveryOptions,
                Query.VappSnapshotInstantRecoveryOptionsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotId = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // vappTemplateSnapshotExportOptions(input: VappTemplateSnapshotExportOptionsInput!): VappTemplateExportOptionsUnion!
        internal void InitQueryVappTemplateSnapshotExportOptions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VappTemplateSnapshotExportOptionsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVappTemplateSnapshotExportOptions",
                "($input: VappTemplateSnapshotExportOptionsInput!)",
                "VappTemplateExportOptionsUnion",
                Query.VappTemplateSnapshotExportOptions,
                Query.VappTemplateSnapshotExportOptionsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	orgVdcId = $someString
	# REQUIRED
	catalogId = $someString
	# REQUIRED
	name = $someString
	# REQUIRED
	snapshotId = $someString
}"
            );
        }


    } // class New_RscQuerySnapshot
}