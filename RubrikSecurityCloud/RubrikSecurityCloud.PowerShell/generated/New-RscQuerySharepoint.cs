// New-RscQuerySharepoint.cs
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
    /// Create a new RscQuery object for any of the 8
    /// operations in the 'Sharepoint' API domain:
    /// BrowseDrive, BrowseList, SiteDescendants, SiteExclusions, SiteSearch, SnappableDriveSearch, SnappableListSearch, or SnapshotDriveSearch.
    /// </summary>
    /// <description>
    /// New-RscQuerySharepoint creates a new
    /// query object for operations
    /// in the 'Sharepoint' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 8 operations
    /// in the 'Sharepoint' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: BrowseDrive, BrowseList, SiteDescendants, SiteExclusions, SiteSearch, SnappableDriveSearch, SnappableListSearch, or SnapshotDriveSearch.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQuerySharepoint -BrowseDrive).Info().
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
    /// (New-RscQuerySharepoint -BrowseDrive).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the BrowseDrive operation
    /// of the 'Sharepoint' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sharepoint
    /// # API Operation: BrowseDrive
    /// 
    /// $query = New-RscQuerySharepoint -Operation BrowseDrive
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.snappableFid = $someString
    /// # REQUIRED
    /// $query.Var.snapshotFid = $someString
    /// # OPTIONAL
    /// $query.Var.folderId = $someString
    /// # OPTIONAL
    /// $query.Var.sharepointDriveSearchFilter = @{
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
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// # OPTIONAL
    /// $query.Var.siteChildId = $someString
    /// # OPTIONAL
    /// $query.Var.siteChildType = $someSharePointDescendantType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SharePointDescendantType]) for enum values.
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
    /// Runs the BrowseList operation
    /// of the 'Sharepoint' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sharepoint
    /// # API Operation: BrowseList
    /// 
    /// $query = New-RscQuerySharepoint -Operation BrowseList
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.snappableFid = $someString
    /// # REQUIRED
    /// $query.Var.snapshotFid = $someString
    /// # OPTIONAL
    /// $query.Var.folderId = $someString
    /// # OPTIONAL
    /// $query.Var.sharepointDriveSearchFilter = @{
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
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// # OPTIONAL
    /// $query.Var.siteChildId = $someString
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
    /// Runs the SiteDescendants operation
    /// of the 'Sharepoint' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sharepoint
    /// # API Operation: SiteDescendants
    /// 
    /// $query = New-RscQuerySharepoint -Operation SiteDescendants
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.siteFid = $someString
    /// # REQUIRED
    /// $query.Var.snapshotFid = $someString
    /// # OPTIONAL
    /// $query.Var.naturalId = $someString
    /// # OPTIONAL
    /// $query.Var.sharepointSiteSearchFilter = @{
    /// 	# OPTIONAL
    /// 	searchKeywordFilter = @{
    /// 		# OPTIONAL
    /// 		searchKeyword = $someString
    /// 		# OPTIONAL
    /// 		keywordType = $someSharePointSearchKeywordType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SharePointSearchKeywordType]) for enum values.
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
    /// 		searchObjectType = $someSharePointSearchObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SharePointSearchObjectType]) for enum values.
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
    /// 	descendantWorkloadId = $someString
    /// }
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: O365FullSpObjectConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SiteExclusions operation
    /// of the 'Sharepoint' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sharepoint
    /// # API Operation: SiteExclusions
    /// 
    /// $query = New-RscQuerySharepoint -Operation SiteExclusions
    /// 
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// # REQUIRED
    /// $query.Var.siteFids = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;FullSpSiteExclusions&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SiteSearch operation
    /// of the 'Sharepoint' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sharepoint
    /// # API Operation: SiteSearch
    /// 
    /// $query = New-RscQuerySharepoint -Operation SiteSearch
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.siteFid = $someString
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// # OPTIONAL
    /// $query.Var.sharepointSiteSearchFilter = @{
    /// 	# OPTIONAL
    /// 	searchKeywordFilter = @{
    /// 		# OPTIONAL
    /// 		searchKeyword = $someString
    /// 		# OPTIONAL
    /// 		keywordType = $someSharePointSearchKeywordType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SharePointSearchKeywordType]) for enum values.
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
    /// 		searchObjectType = $someSharePointSearchObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SharePointSearchObjectType]) for enum values.
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
    /// 	descendantWorkloadId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: O365FullSpObjectConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SnappableDriveSearch operation
    /// of the 'Sharepoint' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sharepoint
    /// # API Operation: SnappableDriveSearch
    /// 
    /// $query = New-RscQuerySharepoint -Operation SnappableDriveSearch
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
    /// $query.Var.sharepointDriveSearchFilter = @{
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
    /// # OPTIONAL
    /// $query.Var.siteChildId = $someString
    /// # OPTIONAL
    /// $query.Var.siteChildType = $someSharePointDescendantType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SharePointDescendantType]) for enum values.
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
    /// Runs the SnappableListSearch operation
    /// of the 'Sharepoint' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sharepoint
    /// # API Operation: SnappableListSearch
    /// 
    /// $query = New-RscQuerySharepoint -Operation SnappableListSearch
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
    /// $query.Var.sharepointDriveSearchFilter = @{
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
    /// # OPTIONAL
    /// $query.Var.siteChildId = $someString
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
    /// Runs the SnapshotDriveSearch operation
    /// of the 'Sharepoint' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sharepoint
    /// # API Operation: SnapshotDriveSearch
    /// 
    /// $query = New-RscQuerySharepoint -Operation SnapshotDriveSearch
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
    /// $query.Var.sharepointDriveSearchFilter = @{
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
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscQuerySharepoint",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQuerySharepoint : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "BrowseDrive",
                "BrowseList",
                "SiteDescendants",
                "SiteExclusions",
                "SiteSearch",
                "SnappableDriveSearch",
                "SnappableListSearch",
                "SnapshotDriveSearch",
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
                    case "BrowseDrive":
                        this.ProcessRecord_BrowseDrive();
                        break;
                    case "BrowseList":
                        this.ProcessRecord_BrowseList();
                        break;
                    case "SiteDescendants":
                        this.ProcessRecord_SiteDescendants();
                        break;
                    case "SiteExclusions":
                        this.ProcessRecord_SiteExclusions();
                        break;
                    case "SiteSearch":
                        this.ProcessRecord_SiteSearch();
                        break;
                    case "SnappableDriveSearch":
                        this.ProcessRecord_SnappableDriveSearch();
                        break;
                    case "SnappableListSearch":
                        this.ProcessRecord_SnappableListSearch();
                        break;
                    case "SnapshotDriveSearch":
                        this.ProcessRecord_SnapshotDriveSearch();
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
        // browseSharepointDrive.
        internal void ProcessRecord_BrowseDrive()
        {
            this._logger.name += " -BrowseDrive";
            // Create new graphql operation browseSharepointDrive
            InitQueryBrowseSharepointDrive();
        }

        // This parameter set invokes a single graphql operation:
        // browseSharepointList.
        internal void ProcessRecord_BrowseList()
        {
            this._logger.name += " -BrowseList";
            // Create new graphql operation browseSharepointList
            InitQueryBrowseSharepointList();
        }

        // This parameter set invokes a single graphql operation:
        // sharepointSiteDescendants.
        internal void ProcessRecord_SiteDescendants()
        {
            this._logger.name += " -SiteDescendants";
            // Create new graphql operation sharepointSiteDescendants
            InitQuerySharepointSiteDescendants();
        }

        // This parameter set invokes a single graphql operation:
        // allSharepointSiteExclusions.
        internal void ProcessRecord_SiteExclusions()
        {
            this._logger.name += " -SiteExclusions";
            // Create new graphql operation allSharepointSiteExclusions
            InitQueryAllSharepointSiteExclusions();
        }

        // This parameter set invokes a single graphql operation:
        // sharepointSiteSearch.
        internal void ProcessRecord_SiteSearch()
        {
            this._logger.name += " -SiteSearch";
            // Create new graphql operation sharepointSiteSearch
            InitQuerySharepointSiteSearch();
        }

        // This parameter set invokes a single graphql operation:
        // snappableSharepointDriveSearch.
        internal void ProcessRecord_SnappableDriveSearch()
        {
            this._logger.name += " -SnappableDriveSearch";
            // Create new graphql operation snappableSharepointDriveSearch
            InitQuerySnappableSharepointDriveSearch();
        }

        // This parameter set invokes a single graphql operation:
        // snappableSharepointListSearch.
        internal void ProcessRecord_SnappableListSearch()
        {
            this._logger.name += " -SnappableListSearch";
            // Create new graphql operation snappableSharepointListSearch
            InitQuerySnappableSharepointListSearch();
        }

        // This parameter set invokes a single graphql operation:
        // snapshotSharepointDriveSearch.
        internal void ProcessRecord_SnapshotDriveSearch()
        {
            this._logger.name += " -SnapshotDriveSearch";
            // Create new graphql operation snapshotSharepointDriveSearch
            InitQuerySnapshotSharepointDriveSearch();
        }


        // Create new GraphQL Query:
        // browseSharepointDrive(
        //     first: Int
        //     after: String
        //     snappableFid: UUID!
        //     snapshotFid: UUID!
        //     folderId: String
        //     sharepointDriveSearchFilter: OnedriveSearchFilter
        //     orgId: UUID!
        //     siteChildId: String
        //     siteChildType: SharePointDescendantType
        //   ): O365OnedriveObjectConnection!
        internal void InitQueryBrowseSharepointDrive()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("snapshotFid", "UUID!"),
                Tuple.Create("folderId", "String"),
                Tuple.Create("sharepointDriveSearchFilter", "OnedriveSearchFilter"),
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("siteChildId", "String"),
                Tuple.Create("siteChildType", "SharePointDescendantType"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryBrowseSharepointDrive",
                "($first: Int,$after: String,$snappableFid: UUID!,$snapshotFid: UUID!,$folderId: String,$sharepointDriveSearchFilter: OnedriveSearchFilter,$orgId: UUID!,$siteChildId: String,$siteChildType: SharePointDescendantType)",
                "O365OnedriveObjectConnection",
                Query.BrowseSharepointDrive,
                Query.BrowseSharepointDriveFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.snappableFid = $someString
# REQUIRED
$query.Var.snapshotFid = $someString
# OPTIONAL
$query.Var.folderId = $someString
# OPTIONAL
$query.Var.sharepointDriveSearchFilter = @{
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
}
# REQUIRED
$query.Var.orgId = $someString
# OPTIONAL
$query.Var.siteChildId = $someString
# OPTIONAL
$query.Var.siteChildType = $someSharePointDescendantType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SharePointDescendantType]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // browseSharepointList(
        //     first: Int
        //     after: String
        //     snappableFid: UUID!
        //     snapshotFid: UUID!
        //     folderId: String
        //     sharepointDriveSearchFilter: OnedriveSearchFilter
        //     orgId: UUID!
        //     siteChildId: String
        //   ): O365OnedriveObjectConnection!
        internal void InitQueryBrowseSharepointList()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("snapshotFid", "UUID!"),
                Tuple.Create("folderId", "String"),
                Tuple.Create("sharepointDriveSearchFilter", "OnedriveSearchFilter"),
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("siteChildId", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryBrowseSharepointList",
                "($first: Int,$after: String,$snappableFid: UUID!,$snapshotFid: UUID!,$folderId: String,$sharepointDriveSearchFilter: OnedriveSearchFilter,$orgId: UUID!,$siteChildId: String)",
                "O365OnedriveObjectConnection",
                Query.BrowseSharepointList,
                Query.BrowseSharepointListFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.snappableFid = $someString
# REQUIRED
$query.Var.snapshotFid = $someString
# OPTIONAL
$query.Var.folderId = $someString
# OPTIONAL
$query.Var.sharepointDriveSearchFilter = @{
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
}
# REQUIRED
$query.Var.orgId = $someString
# OPTIONAL
$query.Var.siteChildId = $someString"
            );
        }

        // Create new GraphQL Query:
        // sharepointSiteDescendants(
        //     first: Int
        //     after: String
        //     siteFid: UUID!
        //     snapshotFid: UUID!
        //     naturalId: String
        //     sharepointSiteSearchFilter: SharePointSearchFilter
        //     orgId: UUID!
        //   ): O365FullSpObjectConnection!
        internal void InitQuerySharepointSiteDescendants()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("siteFid", "UUID!"),
                Tuple.Create("snapshotFid", "UUID!"),
                Tuple.Create("naturalId", "String"),
                Tuple.Create("sharepointSiteSearchFilter", "SharePointSearchFilter"),
                Tuple.Create("orgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySharepointSiteDescendants",
                "($first: Int,$after: String,$siteFid: UUID!,$snapshotFid: UUID!,$naturalId: String,$sharepointSiteSearchFilter: SharePointSearchFilter,$orgId: UUID!)",
                "O365FullSpObjectConnection",
                Query.SharepointSiteDescendants,
                Query.SharepointSiteDescendantsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.siteFid = $someString
# REQUIRED
$query.Var.snapshotFid = $someString
# OPTIONAL
$query.Var.naturalId = $someString
# OPTIONAL
$query.Var.sharepointSiteSearchFilter = @{
	# OPTIONAL
	searchKeywordFilter = @{
		# OPTIONAL
		searchKeyword = $someString
		# OPTIONAL
		keywordType = $someSharePointSearchKeywordType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SharePointSearchKeywordType]) for enum values.
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
		searchObjectType = $someSharePointSearchObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SharePointSearchObjectType]) for enum values.
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
	descendantWorkloadId = $someString
}
# REQUIRED
$query.Var.orgId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allSharepointSiteExclusions(orgId: UUID!, siteFids: [String!]!): [FullSpSiteExclusions!]!
        internal void InitQueryAllSharepointSiteExclusions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("siteFids", "[String!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllSharepointSiteExclusions",
                "($orgId: UUID!,$siteFids: [String!]!)",
                "List<FullSpSiteExclusions>",
                Query.AllSharepointSiteExclusions,
                Query.AllSharepointSiteExclusionsFieldSpec,
                @"# REQUIRED
$query.Var.orgId = $someString
# REQUIRED
$query.Var.siteFids = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // sharepointSiteSearch(
        //     first: Int
        //     after: String
        //     siteFid: UUID!
        //     orgId: UUID!
        //     sharepointSiteSearchFilter: SharePointSearchFilter
        //   ): O365FullSpObjectConnection!
        internal void InitQuerySharepointSiteSearch()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("siteFid", "UUID!"),
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("sharepointSiteSearchFilter", "SharePointSearchFilter"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySharepointSiteSearch",
                "($first: Int,$after: String,$siteFid: UUID!,$orgId: UUID!,$sharepointSiteSearchFilter: SharePointSearchFilter)",
                "O365FullSpObjectConnection",
                Query.SharepointSiteSearch,
                Query.SharepointSiteSearchFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.siteFid = $someString
# REQUIRED
$query.Var.orgId = $someString
# OPTIONAL
$query.Var.sharepointSiteSearchFilter = @{
	# OPTIONAL
	searchKeywordFilter = @{
		# OPTIONAL
		searchKeyword = $someString
		# OPTIONAL
		keywordType = $someSharePointSearchKeywordType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SharePointSearchKeywordType]) for enum values.
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
		searchObjectType = $someSharePointSearchObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SharePointSearchObjectType]) for enum values.
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
	descendantWorkloadId = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // snappableSharepointDriveSearch(
        //     first: Int
        //     after: String
        //     snappableFid: UUID!
        //     orgId: UUID!
        //     sharepointDriveSearchFilter: OnedriveSearchFilter
        //     siteChildId: String
        //     siteChildType: SharePointDescendantType
        //   ): O365OnedriveObjectConnection!
        internal void InitQuerySnappableSharepointDriveSearch()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("sharepointDriveSearchFilter", "OnedriveSearchFilter"),
                Tuple.Create("siteChildId", "String"),
                Tuple.Create("siteChildType", "SharePointDescendantType"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySnappableSharepointDriveSearch",
                "($first: Int,$after: String,$snappableFid: UUID!,$orgId: UUID!,$sharepointDriveSearchFilter: OnedriveSearchFilter,$siteChildId: String,$siteChildType: SharePointDescendantType)",
                "O365OnedriveObjectConnection",
                Query.SnappableSharepointDriveSearch,
                Query.SnappableSharepointDriveSearchFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.snappableFid = $someString
# REQUIRED
$query.Var.orgId = $someString
# OPTIONAL
$query.Var.sharepointDriveSearchFilter = @{
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
}
# OPTIONAL
$query.Var.siteChildId = $someString
# OPTIONAL
$query.Var.siteChildType = $someSharePointDescendantType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SharePointDescendantType]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // snappableSharepointListSearch(
        //     first: Int
        //     after: String
        //     snappableFid: UUID!
        //     orgId: UUID!
        //     sharepointDriveSearchFilter: OnedriveSearchFilter
        //     siteChildId: String
        //   ): O365OnedriveObjectConnection!
        internal void InitQuerySnappableSharepointListSearch()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("sharepointDriveSearchFilter", "OnedriveSearchFilter"),
                Tuple.Create("siteChildId", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySnappableSharepointListSearch",
                "($first: Int,$after: String,$snappableFid: UUID!,$orgId: UUID!,$sharepointDriveSearchFilter: OnedriveSearchFilter,$siteChildId: String)",
                "O365OnedriveObjectConnection",
                Query.SnappableSharepointListSearch,
                Query.SnappableSharepointListSearchFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.snappableFid = $someString
# REQUIRED
$query.Var.orgId = $someString
# OPTIONAL
$query.Var.sharepointDriveSearchFilter = @{
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
}
# OPTIONAL
$query.Var.siteChildId = $someString"
            );
        }

        // Create new GraphQL Query:
        // snapshotSharepointDriveSearch(
        //     first: Int
        //     after: String
        //     snappableFid: UUID!
        //     snapshotFid: UUID!
        //     orgId: UUID!
        //     sharepointDriveSearchFilter: OnedriveSearchFilter
        //   ): O365OnedriveObjectConnection!
        internal void InitQuerySnapshotSharepointDriveSearch()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("snapshotFid", "UUID!"),
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("sharepointDriveSearchFilter", "OnedriveSearchFilter"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySnapshotSharepointDriveSearch",
                "($first: Int,$after: String,$snappableFid: UUID!,$snapshotFid: UUID!,$orgId: UUID!,$sharepointDriveSearchFilter: OnedriveSearchFilter)",
                "O365OnedriveObjectConnection",
                Query.SnapshotSharepointDriveSearch,
                Query.SnapshotSharepointDriveSearchFieldSpec,
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
$query.Var.sharepointDriveSearchFilter = @{
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


    } // class New_RscQuerySharepoint
}