// New-RscQuerySnappable.cs
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
    /// Create a new RscQuery object for any of the 13
    /// operations in the 'Snappable' API domain:
    /// CdmHierarchySnappableNew, CdmHierarchySnappablesNew, ContactSearch, EmailSearch, EventSearch, GroupByList, Hierarchy, List, OnedriveSearch, Search, SearchVersionedFiles, TeamsConversationsSearch, or TeamsDriveSearch.
    /// </summary>
    /// <description>
    /// New-RscQuerySnappable creates a new
    /// query object for operations
    /// in the 'Snappable' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 13 operations
    /// in the 'Snappable' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: CdmHierarchySnappableNew, CdmHierarchySnappablesNew, ContactSearch, EmailSearch, EventSearch, GroupByList, Hierarchy, List, OnedriveSearch, Search, SearchVersionedFiles, TeamsConversationsSearch, or TeamsDriveSearch.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQuerySnappable -CdmHierarchySnappableNew).Info().
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
    /// (New-RscQuerySnappable -CdmHierarchySnappableNew).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the CdmHierarchySnappableNew operation
    /// of the 'Snappable' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snappable
    /// # API Operation: CdmHierarchySnappableNew
    /// 
    /// $query = New-RscQuerySnappable -CdmHierarchySnappableNew
    /// 
    /// # REQUIRED
    /// $query.Var.snappableFid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CdmHierarchySnappableNew
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CdmHierarchySnappablesNew operation
    /// of the 'Snappable' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snappable
    /// # API Operation: CdmHierarchySnappablesNew
    /// 
    /// $query = New-RscQuerySnappable -CdmHierarchySnappablesNew
    /// 
    /// # REQUIRED
    /// $query.Var.fids = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;CdmHierarchySnappableNew&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ContactSearch operation
    /// of the 'Snappable' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snappable
    /// # API Operation: ContactSearch
    /// 
    /// $query = New-RscQuerySnappable -ContactSearch
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.snappableFid = $someString
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// # OPTIONAL
    /// $query.Var.contactsSearchFilter = @{
    /// 	# OPTIONAL
    /// 	searchKeywordFilter = @{
    /// 		# OPTIONAL
    /// 		searchKeyword = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	searchObjectFilter = @{
    /// 		# OPTIONAL
    /// 		searchObjectType = $someO365ContactsSearchObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365ContactsSearchObjectType]) for enum values.
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
    /// 	}
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
    /// Runs the EmailSearch operation
    /// of the 'Snappable' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snappable
    /// # API Operation: EmailSearch
    /// 
    /// $query = New-RscQuerySnappable -EmailSearch
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.snappableFid = $someString
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
    /// 	}
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
    /// of the 'Snappable' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snappable
    /// # API Operation: EventSearch
    /// 
    /// $query = New-RscQuerySnappable -EventSearch
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.snappableFid = $someString
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
    /// 	}
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
    /// Runs the GroupByList operation
    /// of the 'Snappable' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snappable
    /// # API Operation: GroupByList
    /// 
    /// $query = New-RscQuerySnappable -GroupByList
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
    /// $query.Var.groupBy = $someSnappableGroupByEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableGroupByEnum]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	protectionStatus = @(
    /// 		$someProtectionStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProtectionStatusEnum]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	slaDomain = @{
    /// 		# OPTIONAL
    /// 		id = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	complianceStatus = @(
    /// 		$someComplianceStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ComplianceStatusEnum]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	objectType = @(
    /// 		$someObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	excludedObjectTypes = @(
    /// 		$someObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	cluster = @{
    /// 		# OPTIONAL
    /// 		id = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		type = @(
    /// 			$someClusterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	timeRange = @{
    /// 		# REQUIRED
    /// 		start = $someDateTime
    /// 		# REQUIRED
    /// 		end = $someDateTime
    /// 	}
    /// 	# OPTIONAL
    /// 	slaTimeRange = $someSlaComplianceTimeRange # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaComplianceTimeRange]) for enum values.
    /// 	# OPTIONAL
    /// 	orgId = @(
    /// 		$someString
    /// 	)
    /// }
    /// # OPTIONAL
    /// $query.Var.timezoneOffset = $someSingle
    /// # OPTIONAL
    /// $query.Var.requestedAggregations = @(
    /// 	$someSnappableAggregationsEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableAggregationsEnum]) for enum values.
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SnappableGroupByConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Hierarchy operation
    /// of the 'Snappable' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snappable
    /// # API Operation: Hierarchy
    /// 
    /// $query = New-RscQuerySnappable -Hierarchy
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = $someHierarchySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		tagFilterParams = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
    /// 				# OPTIONAL
    /// 				tagKey = $someString
    /// 				# OPTIONAL
    /// 				tagValue = $someString
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		objectTypeFilterParams = @(
    /// 			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		awsNativeProtectionFeatureNames = @(
    /// 			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		isNegative = $someBoolean
    /// 		# OPTIONAL
    /// 		isSlowSearchEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		azureNativeProtectionFeatureNames = @(
    /// 			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		unmanagedObjectAvailabilityFilter = @(
    /// 			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
    /// 		)
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: HierarchySnappableConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the List operation
    /// of the 'Snappable' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snappable
    /// # API Operation: List
    /// 
    /// $query = New-RscQuerySnappable -List
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
    /// $query.Var.sortBy = $someSnappableSortByEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableSortByEnum]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	protectionStatus = @(
    /// 		$someProtectionStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProtectionStatusEnum]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	slaDomain = @{
    /// 		# OPTIONAL
    /// 		id = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	complianceStatus = @(
    /// 		$someComplianceStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ComplianceStatusEnum]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	objectType = @(
    /// 		$someObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	excludedObjectTypes = @(
    /// 		$someObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	cluster = @{
    /// 		# OPTIONAL
    /// 		id = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		type = @(
    /// 			$someClusterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	searchTerm = $someString
    /// 	# OPTIONAL
    /// 	slaTimeRange = $someSlaComplianceTimeRange # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaComplianceTimeRange]) for enum values.
    /// 	# OPTIONAL
    /// 	orgId = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SnappableConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the OnedriveSearch operation
    /// of the 'Snappable' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snappable
    /// # API Operation: OnedriveSearch
    /// 
    /// $query = New-RscQuerySnappable -OnedriveSearch
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.snappableFid = $someString
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
    /// 	}
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
    /// Runs the Search operation
    /// of the 'Snappable' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snappable
    /// # API Operation: Search
    /// 
    /// $query = New-RscQuerySnappable -Search
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
    /// $query.Var.sortBy = $someSnappableSortByEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableSortByEnum]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	protectionStatus = @(
    /// 		$someProtectionStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProtectionStatusEnum]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	slaDomain = @{
    /// 		# OPTIONAL
    /// 		id = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	complianceStatus = @(
    /// 		$someComplianceStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ComplianceStatusEnum]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	objectType = @(
    /// 		$someObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	excludedObjectTypes = @(
    /// 		$someObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	cluster = @{
    /// 		# OPTIONAL
    /// 		id = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		type = @(
    /// 			$someClusterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	timeRange = @{
    /// 		# REQUIRED
    /// 		start = $someDateTime
    /// 		# REQUIRED
    /// 		end = $someDateTime
    /// 	}
    /// 	# OPTIONAL
    /// 	searchTerm = $someString
    /// 	# OPTIONAL
    /// 	slaTimeRange = $someSlaComplianceTimeRange # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaComplianceTimeRange]) for enum values.
    /// 	# OPTIONAL
    /// 	orgId = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SnappableConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SearchVersionedFiles operation
    /// of the 'Snappable' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snappable
    /// # API Operation: SearchVersionedFiles
    /// 
    /// $query = New-RscQuerySnappable -SearchVersionedFiles
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.snappableFid = $someString
    /// # REQUIRED
    /// $query.Var.searchQuery = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VersionedFileConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TeamsConversationsSearch operation
    /// of the 'Snappable' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snappable
    /// # API Operation: TeamsConversationsSearch
    /// 
    /// $query = New-RscQuerySnappable -TeamsConversationsSearch
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.snappableFid = $someString
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// # OPTIONAL
    /// $query.Var.snapshotFidOpt = $someString
    /// # REQUIRED
    /// $query.Var.teamConvChannels = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		naturalId = $someString
    /// 		# REQUIRED
    /// 		name = $someString
    /// 		# REQUIRED
    /// 		folderId = $someString
    /// 		# REQUIRED
    /// 		membershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.teamsConversationsSearchFilter = @{
    /// 	# OPTIONAL
    /// 	postedTime = @{
    /// 		# OPTIONAL
    /// 		fromTime = $someDateTime
    /// 		# OPTIONAL
    /// 		untilTime = $someDateTime
    /// 	}
    /// 	# OPTIONAL
    /// 	channelNaturalId = $someString
    /// 	# OPTIONAL
    /// 	postedBy = $someString
    /// 	# OPTIONAL
    /// 	snapshotId = $someString
    /// 	# OPTIONAL
    /// 	parentId = $someString
    /// 	# OPTIONAL
    /// 	convId = $someString
    /// 	# OPTIONAL
    /// 	snapshotNum = $someInt
    /// 	# OPTIONAL
    /// 	includeArchived = $someBoolean
    /// 	# OPTIONAL
    /// 	fetchAllPostSenders = $someString
    /// 	# OPTIONAL
    /// 	skipPostsAttachments = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: O365TeamsConversationsConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TeamsDriveSearch operation
    /// of the 'Snappable' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snappable
    /// # API Operation: TeamsDriveSearch
    /// 
    /// $query = New-RscQuerySnappable -TeamsDriveSearch
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.snappableFid = $someString
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// # OPTIONAL
    /// $query.Var.channelId = $someString
    /// # OPTIONAL
    /// $query.Var.channelFolderName = $someString
    /// # OPTIONAL
    /// $query.Var.teamsDriveSearchFilter = @{
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
    /// 	}
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
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscQuerySnappable",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQuerySnappable : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "CdmHierarchySnappableNew",
                "CdmHierarchySnappablesNew",
                "ContactSearch",
                "EmailSearch",
                "EventSearch",
                "GroupByList",
                "Hierarchy",
                "List",
                "OnedriveSearch",
                "Search",
                "SearchVersionedFiles",
                "TeamsConversationsSearch",
                "TeamsDriveSearch",
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
                    case "CdmHierarchySnappableNew":
                        this.ProcessRecord_CdmHierarchySnappableNew();
                        break;
                    case "CdmHierarchySnappablesNew":
                        this.ProcessRecord_CdmHierarchySnappablesNew();
                        break;
                    case "ContactSearch":
                        this.ProcessRecord_ContactSearch();
                        break;
                    case "EmailSearch":
                        this.ProcessRecord_EmailSearch();
                        break;
                    case "EventSearch":
                        this.ProcessRecord_EventSearch();
                        break;
                    case "GroupByList":
                        this.ProcessRecord_GroupByList();
                        break;
                    case "Hierarchy":
                        this.ProcessRecord_Hierarchy();
                        break;
                    case "List":
                        this.ProcessRecord_List();
                        break;
                    case "OnedriveSearch":
                        this.ProcessRecord_OnedriveSearch();
                        break;
                    case "Search":
                        this.ProcessRecord_Search();
                        break;
                    case "SearchVersionedFiles":
                        this.ProcessRecord_SearchVersionedFiles();
                        break;
                    case "TeamsConversationsSearch":
                        this.ProcessRecord_TeamsConversationsSearch();
                        break;
                    case "TeamsDriveSearch":
                        this.ProcessRecord_TeamsDriveSearch();
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
        // cdmHierarchySnappableNew.
        internal void ProcessRecord_CdmHierarchySnappableNew()
        {
            this._logger.name += " -CdmHierarchySnappableNew";
            // Create new graphql operation cdmHierarchySnappableNew
            InitQueryCdmHierarchySnappableNew();
        }

        // This parameter set invokes a single graphql operation:
        // cdmHierarchySnappablesNew.
        internal void ProcessRecord_CdmHierarchySnappablesNew()
        {
            this._logger.name += " -CdmHierarchySnappablesNew";
            // Create new graphql operation cdmHierarchySnappablesNew
            InitQueryCdmHierarchySnappablesNew();
        }

        // This parameter set invokes a single graphql operation:
        // snappableContactSearch.
        internal void ProcessRecord_ContactSearch()
        {
            this._logger.name += " -ContactSearch";
            // Create new graphql operation snappableContactSearch
            InitQuerySnappableContactSearch();
        }

        // This parameter set invokes a single graphql operation:
        // snappableEmailSearch.
        internal void ProcessRecord_EmailSearch()
        {
            this._logger.name += " -EmailSearch";
            // Create new graphql operation snappableEmailSearch
            InitQuerySnappableEmailSearch();
        }

        // This parameter set invokes a single graphql operation:
        // snappableEventSearch.
        internal void ProcessRecord_EventSearch()
        {
            this._logger.name += " -EventSearch";
            // Create new graphql operation snappableEventSearch
            InitQuerySnappableEventSearch();
        }

        // This parameter set invokes a single graphql operation:
        // snappableGroupByConnection.
        internal void ProcessRecord_GroupByList()
        {
            this._logger.name += " -GroupByList";
            // Create new graphql operation snappableGroupByConnection
            InitQuerySnappableGroupByConnection();
        }

        // This parameter set invokes a single graphql operation:
        // hierarchySnappables.
        internal void ProcessRecord_Hierarchy()
        {
            this._logger.name += " -Hierarchy";
            // Create new graphql operation hierarchySnappables
            InitQueryHierarchySnappables();
        }

        // This parameter set invokes a single graphql operation:
        // snappableConnection.
        internal void ProcessRecord_List()
        {
            this._logger.name += " -List";
            // Create new graphql operation snappableConnection
            InitQuerySnappableConnection();
        }

        // This parameter set invokes a single graphql operation:
        // snappableOnedriveSearch.
        internal void ProcessRecord_OnedriveSearch()
        {
            this._logger.name += " -OnedriveSearch";
            // Create new graphql operation snappableOnedriveSearch
            InitQuerySnappableOnedriveSearch();
        }

        // This parameter set invokes a single graphql operation:
        // searchSnappableConnection.
        internal void ProcessRecord_Search()
        {
            this._logger.name += " -Search";
            // Create new graphql operation searchSnappableConnection
            InitQuerySearchSnappableConnection();
        }

        // This parameter set invokes a single graphql operation:
        // searchSnappableVersionedFiles.
        internal void ProcessRecord_SearchVersionedFiles()
        {
            this._logger.name += " -SearchVersionedFiles";
            // Create new graphql operation searchSnappableVersionedFiles
            InitQuerySearchSnappableVersionedFiles();
        }

        // This parameter set invokes a single graphql operation:
        // snappableTeamsConversationsSearch.
        internal void ProcessRecord_TeamsConversationsSearch()
        {
            this._logger.name += " -TeamsConversationsSearch";
            // Create new graphql operation snappableTeamsConversationsSearch
            InitQuerySnappableTeamsConversationsSearch();
        }

        // This parameter set invokes a single graphql operation:
        // snappableTeamsDriveSearch.
        internal void ProcessRecord_TeamsDriveSearch()
        {
            this._logger.name += " -TeamsDriveSearch";
            // Create new graphql operation snappableTeamsDriveSearch
            InitQuerySnappableTeamsDriveSearch();
        }


        // Create new GraphQL Query:
        // cdmHierarchySnappableNew(snappableFid: UUID!): CdmHierarchySnappableNew!
        internal void InitQueryCdmHierarchySnappableNew()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCdmHierarchySnappableNew",
                "($snappableFid: UUID!)",
                "CdmHierarchySnappableNew",
                Query.CdmHierarchySnappableNew_ObjectFieldSpec,
                Query.CdmHierarchySnappableNewFieldSpec,
                @"# REQUIRED
$query.Var.snappableFid = $someString"
            );
        }

        // Create new GraphQL Query:
        // cdmHierarchySnappablesNew(fids: [UUID!]!): [CdmHierarchySnappableNew!]!
        internal void InitQueryCdmHierarchySnappablesNew()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fids", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCdmHierarchySnappablesNew",
                "($fids: [UUID!]!)",
                "List<CdmHierarchySnappableNew>",
                Query.CdmHierarchySnappablesNew_ObjectFieldSpec,
                Query.CdmHierarchySnappablesNewFieldSpec,
                @"# REQUIRED
$query.Var.fids = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // snappableContactSearch(
        //     first: Int
        //     after: String
        //     snappableFid: UUID!
        //     orgId: UUID!
        //     contactsSearchFilter: ContactsSearchFilter
        //   ): O365ExchangeObjectConnection!
        internal void InitQuerySnappableContactSearch()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("contactsSearchFilter", "ContactsSearchFilter"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySnappableContactSearch",
                "($first: Int,$after: String,$snappableFid: UUID!,$orgId: UUID!,$contactsSearchFilter: ContactsSearchFilter)",
                "O365ExchangeObjectConnection",
                Query.SnappableContactSearch_ObjectFieldSpec,
                Query.SnappableContactSearchFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.snappableFid = $someString
# REQUIRED
$query.Var.orgId = $someString
# OPTIONAL
$query.Var.contactsSearchFilter = @{
	# OPTIONAL
	searchKeywordFilter = @{
		# OPTIONAL
		searchKeyword = $someString
	}
	# OPTIONAL
	searchObjectFilter = @{
		# OPTIONAL
		searchObjectType = $someO365ContactsSearchObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365ContactsSearchObjectType]) for enum values.
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
	}
}"
            );
        }

        // Create new GraphQL Query:
        // snappableEmailSearch(
        //     first: Int
        //     after: String
        //     snappableFid: UUID!
        //     orgId: UUID!
        //     searchFilter: SearchFilter
        //   ): O365ExchangeObjectConnection!
        internal void InitQuerySnappableEmailSearch()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("searchFilter", "SearchFilter"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySnappableEmailSearch",
                "($first: Int,$after: String,$snappableFid: UUID!,$orgId: UUID!,$searchFilter: SearchFilter)",
                "O365ExchangeObjectConnection",
                Query.SnappableEmailSearch_ObjectFieldSpec,
                Query.SnappableEmailSearchFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.snappableFid = $someString
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
	}
}"
            );
        }

        // Create new GraphQL Query:
        // snappableEventSearch(
        //     first: Int
        //     after: String
        //     snappableFid: UUID!
        //     orgId: UUID!
        //     calendarSearchFilter: CalendarSearchFilter
        //   ): O365ExchangeObjectConnection!
        internal void InitQuerySnappableEventSearch()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("calendarSearchFilter", "CalendarSearchFilter"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySnappableEventSearch",
                "($first: Int,$after: String,$snappableFid: UUID!,$orgId: UUID!,$calendarSearchFilter: CalendarSearchFilter)",
                "O365ExchangeObjectConnection",
                Query.SnappableEventSearch_ObjectFieldSpec,
                Query.SnappableEventSearchFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.snappableFid = $someString
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
	}
}"
            );
        }

        // Create new GraphQL Query:
        // snappableGroupByConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     groupBy: SnappableGroupByEnum!
        //     filter: SnappableGroupByFilterInput
        //     timezoneOffset: Float = 0.0
        //     requestedAggregations: [SnappableAggregationsEnum!]
        //   ): SnappableGroupByConnection!
        internal void InitQuerySnappableGroupByConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("groupBy", "SnappableGroupByEnum!"),
                Tuple.Create("filter", "SnappableGroupByFilterInput"),
                Tuple.Create("timezoneOffset", "Float"),
                Tuple.Create("requestedAggregations", "[SnappableAggregationsEnum!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySnappableGroupByConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$groupBy: SnappableGroupByEnum!,$filter: SnappableGroupByFilterInput,$timezoneOffset: Float,$requestedAggregations: [SnappableAggregationsEnum!])",
                "SnappableGroupByConnection",
                Query.SnappableGroupByConnection_ObjectFieldSpec,
                Query.SnappableGroupByConnectionFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# REQUIRED
$query.Var.groupBy = $someSnappableGroupByEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableGroupByEnum]) for enum values.
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	protectionStatus = @(
		$someProtectionStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProtectionStatusEnum]) for enum values.
	)
	# OPTIONAL
	slaDomain = @{
		# OPTIONAL
		id = @(
			$someString
		)
	}
	# OPTIONAL
	complianceStatus = @(
		$someComplianceStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ComplianceStatusEnum]) for enum values.
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
	cluster = @{
		# OPTIONAL
		id = @(
			$someString
		)
		# OPTIONAL
		type = @(
			$someClusterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values.
		)
	}
	# OPTIONAL
	timeRange = @{
		# REQUIRED
		start = $someDateTime
		# REQUIRED
		end = $someDateTime
	}
	# OPTIONAL
	slaTimeRange = $someSlaComplianceTimeRange # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaComplianceTimeRange]) for enum values.
	# OPTIONAL
	orgId = @(
		$someString
	)
}
# OPTIONAL
$query.Var.timezoneOffset = $someSingle
# OPTIONAL
$query.Var.requestedAggregations = @(
	$someSnappableAggregationsEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableAggregationsEnum]) for enum values.
)"
            );
        }

        // Create new GraphQL Query:
        // hierarchySnappables(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): HierarchySnappableConnection!
        internal void InitQueryHierarchySnappables()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHierarchySnappables",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "HierarchySnappableConnection",
                Query.HierarchySnappables_ObjectFieldSpec,
                Query.HierarchySnappablesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.sortBy = $someHierarchySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = $someString
				# OPTIONAL
				tagValue = $someString
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = $someBoolean
		# OPTIONAL
		isSlowSearchEnabled = $someBoolean
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // snappableConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     sortBy: SnappableSortByEnum = Name
        //     filter: SnappableFilterInput
        //   ): SnappableConnection!
        internal void InitQuerySnappableConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "SnappableSortByEnum"),
                Tuple.Create("filter", "SnappableFilterInput"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySnappableConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: SnappableSortByEnum,$filter: SnappableFilterInput)",
                "SnappableConnection",
                Query.SnappableConnection_ObjectFieldSpec,
                Query.SnappableConnectionFieldSpec,
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
$query.Var.sortBy = $someSnappableSortByEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableSortByEnum]) for enum values.
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	protectionStatus = @(
		$someProtectionStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProtectionStatusEnum]) for enum values.
	)
	# OPTIONAL
	slaDomain = @{
		# OPTIONAL
		id = @(
			$someString
		)
	}
	# OPTIONAL
	complianceStatus = @(
		$someComplianceStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ComplianceStatusEnum]) for enum values.
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
	cluster = @{
		# OPTIONAL
		id = @(
			$someString
		)
		# OPTIONAL
		type = @(
			$someClusterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values.
		)
	}
	# OPTIONAL
	searchTerm = $someString
	# OPTIONAL
	slaTimeRange = $someSlaComplianceTimeRange # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaComplianceTimeRange]) for enum values.
	# OPTIONAL
	orgId = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Query:
        // snappableOnedriveSearch(
        //     first: Int
        //     after: String
        //     snappableFid: UUID!
        //     orgId: UUID!
        //     onedriveSearchFilter: OnedriveSearchFilter
        //   ): O365OnedriveObjectConnection!
        internal void InitQuerySnappableOnedriveSearch()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("onedriveSearchFilter", "OnedriveSearchFilter"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySnappableOnedriveSearch",
                "($first: Int,$after: String,$snappableFid: UUID!,$orgId: UUID!,$onedriveSearchFilter: OnedriveSearchFilter)",
                "O365OnedriveObjectConnection",
                Query.SnappableOnedriveSearch_ObjectFieldSpec,
                Query.SnappableOnedriveSearchFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.snappableFid = $someString
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
	}
}"
            );
        }

        // Create new GraphQL Query:
        // searchSnappableConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     sortBy: SnappableSortByEnum = Name
        //     filter: SnappableFilterInputWithSearch
        //   ): SnappableConnection!
        internal void InitQuerySearchSnappableConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "SnappableSortByEnum"),
                Tuple.Create("filter", "SnappableFilterInputWithSearch"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySearchSnappableConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: SnappableSortByEnum,$filter: SnappableFilterInputWithSearch)",
                "SnappableConnection",
                Query.SearchSnappableConnection_ObjectFieldSpec,
                Query.SearchSnappableConnectionFieldSpec,
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
$query.Var.sortBy = $someSnappableSortByEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableSortByEnum]) for enum values.
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	protectionStatus = @(
		$someProtectionStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProtectionStatusEnum]) for enum values.
	)
	# OPTIONAL
	slaDomain = @{
		# OPTIONAL
		id = @(
			$someString
		)
	}
	# OPTIONAL
	complianceStatus = @(
		$someComplianceStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ComplianceStatusEnum]) for enum values.
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
	cluster = @{
		# OPTIONAL
		id = @(
			$someString
		)
		# OPTIONAL
		type = @(
			$someClusterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values.
		)
	}
	# OPTIONAL
	timeRange = @{
		# REQUIRED
		start = $someDateTime
		# REQUIRED
		end = $someDateTime
	}
	# OPTIONAL
	searchTerm = $someString
	# OPTIONAL
	slaTimeRange = $someSlaComplianceTimeRange # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaComplianceTimeRange]) for enum values.
	# OPTIONAL
	orgId = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Query:
        // searchSnappableVersionedFiles(
        //     first: Int
        //     after: String
        //     snappableFid: UUID!
        //     searchQuery: String!
        //   ): VersionedFileConnection!
        internal void InitQuerySearchSnappableVersionedFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("searchQuery", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySearchSnappableVersionedFiles",
                "($first: Int,$after: String,$snappableFid: UUID!,$searchQuery: String!)",
                "VersionedFileConnection",
                Query.SearchSnappableVersionedFiles_ObjectFieldSpec,
                Query.SearchSnappableVersionedFilesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.snappableFid = $someString
# REQUIRED
$query.Var.searchQuery = $someString"
            );
        }

        // Create new GraphQL Query:
        // snappableTeamsConversationsSearch(
        //     first: Int
        //     after: String
        //     snappableFid: UUID!
        //     orgId: UUID!
        //     snapshotFidOpt: UUID
        //     teamConvChannels: [O365TeamConvChannelInput!]!
        //     teamsConversationsSearchFilter: TeamsConversationsSearchFilter
        //   ): O365TeamsConversationsConnection!
        internal void InitQuerySnappableTeamsConversationsSearch()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("snapshotFidOpt", "UUID"),
                Tuple.Create("teamConvChannels", "[O365TeamConvChannelInput!]!"),
                Tuple.Create("teamsConversationsSearchFilter", "TeamsConversationsSearchFilter"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySnappableTeamsConversationsSearch",
                "($first: Int,$after: String,$snappableFid: UUID!,$orgId: UUID!,$snapshotFidOpt: UUID,$teamConvChannels: [O365TeamConvChannelInput!]!,$teamsConversationsSearchFilter: TeamsConversationsSearchFilter)",
                "O365TeamsConversationsConnection",
                Query.SnappableTeamsConversationsSearch_ObjectFieldSpec,
                Query.SnappableTeamsConversationsSearchFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.snappableFid = $someString
# REQUIRED
$query.Var.orgId = $someString
# OPTIONAL
$query.Var.snapshotFidOpt = $someString
# REQUIRED
$query.Var.teamConvChannels = @(
	@{
		# REQUIRED
		naturalId = $someString
		# REQUIRED
		name = $someString
		# REQUIRED
		folderId = $someString
		# REQUIRED
		membershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
}
)
# OPTIONAL
$query.Var.teamsConversationsSearchFilter = @{
	# OPTIONAL
	postedTime = @{
		# OPTIONAL
		fromTime = $someDateTime
		# OPTIONAL
		untilTime = $someDateTime
	}
	# OPTIONAL
	channelNaturalId = $someString
	# OPTIONAL
	postedBy = $someString
	# OPTIONAL
	snapshotId = $someString
	# OPTIONAL
	parentId = $someString
	# OPTIONAL
	convId = $someString
	# OPTIONAL
	snapshotNum = $someInt
	# OPTIONAL
	includeArchived = $someBoolean
	# OPTIONAL
	fetchAllPostSenders = $someString
	# OPTIONAL
	skipPostsAttachments = $someBoolean
}"
            );
        }

        // Create new GraphQL Query:
        // snappableTeamsDriveSearch(
        //     first: Int
        //     after: String
        //     snappableFid: UUID!
        //     orgId: UUID!
        //     channelId: String
        //     channelFolderName: String
        //     teamsDriveSearchFilter: OnedriveSearchFilter
        //   ): O365OnedriveObjectConnection!
        internal void InitQuerySnappableTeamsDriveSearch()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("channelId", "String"),
                Tuple.Create("channelFolderName", "String"),
                Tuple.Create("teamsDriveSearchFilter", "OnedriveSearchFilter"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySnappableTeamsDriveSearch",
                "($first: Int,$after: String,$snappableFid: UUID!,$orgId: UUID!,$channelId: String,$channelFolderName: String,$teamsDriveSearchFilter: OnedriveSearchFilter)",
                "O365OnedriveObjectConnection",
                Query.SnappableTeamsDriveSearch_ObjectFieldSpec,
                Query.SnappableTeamsDriveSearchFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.snappableFid = $someString
# REQUIRED
$query.Var.orgId = $someString
# OPTIONAL
$query.Var.channelId = $someString
# OPTIONAL
$query.Var.channelFolderName = $someString
# OPTIONAL
$query.Var.teamsDriveSearchFilter = @{
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
	}
}"
            );
        }


    } // class New_RscQuerySnappable
}