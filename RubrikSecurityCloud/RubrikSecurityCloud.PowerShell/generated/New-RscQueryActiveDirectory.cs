// New-RscQueryActiveDirectory.cs
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
    /// Create a new RscQuery object for any of the 14
    /// operations in the 'Active Directory' API domain:
    /// AsyncRequestStatus, Domain, DomainController, DomainControllers, Domains, Forests, ObjectDiff, SearchSnapshots, SnapshotBrowse, SnapshotSearch, UnifiedDomain, UnifiedDomainControllers, UnifiedDomains, or UnifiedForests.
    /// </summary>
    /// <description>
    /// New-RscQueryActiveDirectory creates a new
    /// query object for operations
    /// in the 'Active Directory' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 14 operations
    /// in the 'Active Directory' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AsyncRequestStatus, Domain, DomainController, DomainControllers, Domains, Forests, ObjectDiff, SearchSnapshots, SnapshotBrowse, SnapshotSearch, UnifiedDomain, UnifiedDomainControllers, UnifiedDomains, or UnifiedForests.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryActiveDirectory -AsyncRequestStatus).Info().
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
    /// (New-RscQueryActiveDirectory -AsyncRequestStatus).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AsyncRequestStatus operation
    /// of the 'Active Directory' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActiveDirectory
    /// # API Operation: AsyncRequestStatus
    /// 
    /// $query = New-RscQueryActiveDirectory -AsyncRequestStatus
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
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
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Domain operation
    /// of the 'Active Directory' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActiveDirectory
    /// # API Operation: Domain
    /// 
    /// $query = New-RscQueryActiveDirectory -Domain
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ActiveDirectoryDomain
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DomainController operation
    /// of the 'Active Directory' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActiveDirectory
    /// # API Operation: DomainController
    /// 
    /// $query = New-RscQueryActiveDirectory -DomainController
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ActiveDirectoryDomainController
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DomainControllers operation
    /// of the 'Active Directory' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActiveDirectory
    /// # API Operation: DomainControllers
    /// 
    /// $query = New-RscQueryActiveDirectory -DomainControllers
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
    /// Write-Host $result.GetType().Name # prints: ActiveDirectoryDomainControllerConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Domains operation
    /// of the 'Active Directory' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActiveDirectory
    /// # API Operation: Domains
    /// 
    /// $query = New-RscQueryActiveDirectory -Domains
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
    /// Write-Host $result.GetType().Name # prints: ActiveDirectoryDomainConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Forests operation
    /// of the 'Active Directory' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActiveDirectory
    /// # API Operation: Forests
    /// 
    /// $query = New-RscQueryActiveDirectory -Forests
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
    /// Write-Host $result.GetType().Name # prints: ActiveDirectoryForestConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ObjectDiff operation
    /// of the 'Active Directory' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActiveDirectory
    /// # API Operation: ObjectDiff
    /// 
    /// $query = New-RscQueryActiveDirectory -ObjectDiff
    /// 
    /// # REQUIRED
    /// $query.Var.dnt = $someInt
    /// # REQUIRED
    /// $query.Var.snapshotId1 = $someString
    /// # REQUIRED
    /// $query.Var.snapshotId2 = $someString
    /// # OPTIONAL
    /// $query.Var.attributes = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.shouldReportOnlyChangedAttrs = $someBoolean
    /// # OPTIONAL
    /// $query.Var.shouldReportOnlyChangedValues = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ActiveDirectoryObjectAttributesDiffResponseListResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SearchSnapshots operation
    /// of the 'Active Directory' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActiveDirectory
    /// # API Operation: SearchSnapshots
    /// 
    /// $query = New-RscQueryActiveDirectory -SearchSnapshots
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.id = $someString
    /// # OPTIONAL
    /// $query.Var.snapshotAfterDate = $someDateTime
    /// # OPTIONAL
    /// $query.Var.snapshotBeforeDate = $someDateTime
    /// # REQUIRED
    /// $query.Var.name = $someString
    /// # OPTIONAL
    /// $query.Var.activeDirectoryObjectType = $someActiveDirectoryObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActiveDirectoryObjectType]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ActiveDirectorySnappableSearchResponseConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SnapshotBrowse operation
    /// of the 'Active Directory' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActiveDirectory
    /// # API Operation: SnapshotBrowse
    /// 
    /// $query = New-RscQueryActiveDirectory -SnapshotBrowse
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.id = $someString
    /// # REQUIRED
    /// $query.Var.dnt = $someInt
    /// # OPTIONAL
    /// $query.Var.listOnlyContainers = $someBoolean
    /// # OPTIONAL
    /// $query.Var.activeDirectoryObjectType = $someActiveDirectoryObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActiveDirectoryObjectType]) for enum values.
    /// # OPTIONAL
    /// $query.Var.locationId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ActiveDirectorySnapshotBrowseConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SnapshotSearch operation
    /// of the 'Active Directory' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActiveDirectory
    /// # API Operation: SnapshotSearch
    /// 
    /// $query = New-RscQueryActiveDirectory -SnapshotSearch
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.id = $someString
    /// # REQUIRED
    /// $query.Var.dnt = $someInt
    /// # OPTIONAL
    /// $query.Var.attribute = $someString
    /// # OPTIONAL
    /// $query.Var.activeDirectoryObjectType = $someActiveDirectoryObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActiveDirectoryObjectType]) for enum values.
    /// # REQUIRED
    /// $query.Var.name = $someString
    /// # OPTIONAL
    /// $query.Var.locationId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ActiveDirectorySnapshotBrowseConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UnifiedDomain operation
    /// of the 'Active Directory' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActiveDirectory
    /// # API Operation: UnifiedDomain
    /// 
    /// $query = New-RscQueryActiveDirectory -UnifiedDomain
    /// 
    /// # OPTIONAL
    /// $query.Var.domainFid = $someString
    /// # OPTIONAL
    /// $query.Var.domainSid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UnifiedActiveDirectoryDomain
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UnifiedDomainControllers operation
    /// of the 'Active Directory' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActiveDirectory
    /// # API Operation: UnifiedDomainControllers
    /// 
    /// $query = New-RscQueryActiveDirectory -UnifiedDomainControllers
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
    /// Write-Host $result.GetType().Name # prints: ActiveDirectoryDomainControllerConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UnifiedDomains operation
    /// of the 'Active Directory' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActiveDirectory
    /// # API Operation: UnifiedDomains
    /// 
    /// $query = New-RscQueryActiveDirectory -UnifiedDomains
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
    /// Write-Host $result.GetType().Name # prints: UnifiedActiveDirectoryDomainConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UnifiedForests operation
    /// of the 'Active Directory' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ActiveDirectory
    /// # API Operation: UnifiedForests
    /// 
    /// $query = New-RscQueryActiveDirectory -UnifiedForests
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = $someHierarchySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UnifiedActiveDirectoryForestConnection
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
        "RscQueryActiveDirectory",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryActiveDirectory : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "AsyncRequestStatus",
                "Domain",
                "DomainController",
                "DomainControllers",
                "Domains",
                "Forests",
                "ObjectDiff",
                "SearchSnapshots",
                "SnapshotBrowse",
                "SnapshotSearch",
                "UnifiedDomain",
                "UnifiedDomainControllers",
                "UnifiedDomains",
                "UnifiedForests",
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
                    case "AsyncRequestStatus":
                        this.ProcessRecord_AsyncRequestStatus();
                        break;
                    case "Domain":
                        this.ProcessRecord_Domain();
                        break;
                    case "DomainController":
                        this.ProcessRecord_DomainController();
                        break;
                    case "DomainControllers":
                        this.ProcessRecord_DomainControllers();
                        break;
                    case "Domains":
                        this.ProcessRecord_Domains();
                        break;
                    case "Forests":
                        this.ProcessRecord_Forests();
                        break;
                    case "ObjectDiff":
                        this.ProcessRecord_ObjectDiff();
                        break;
                    case "SearchSnapshots":
                        this.ProcessRecord_SearchSnapshots();
                        break;
                    case "SnapshotBrowse":
                        this.ProcessRecord_SnapshotBrowse();
                        break;
                    case "SnapshotSearch":
                        this.ProcessRecord_SnapshotSearch();
                        break;
                    case "UnifiedDomain":
                        this.ProcessRecord_UnifiedDomain();
                        break;
                    case "UnifiedDomainControllers":
                        this.ProcessRecord_UnifiedDomainControllers();
                        break;
                    case "UnifiedDomains":
                        this.ProcessRecord_UnifiedDomains();
                        break;
                    case "UnifiedForests":
                        this.ProcessRecord_UnifiedForests();
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
        // activeDirectoryAsyncRequestStatus.
        internal void ProcessRecord_AsyncRequestStatus()
        {
            this._logger.name += " -AsyncRequestStatus";
            // Create new graphql operation activeDirectoryAsyncRequestStatus
            InitQueryActiveDirectoryAsyncRequestStatus();
        }

        // This parameter set invokes a single graphql operation:
        // activeDirectoryDomain.
        internal void ProcessRecord_Domain()
        {
            this._logger.name += " -Domain";
            // Create new graphql operation activeDirectoryDomain
            InitQueryActiveDirectoryDomain();
        }

        // This parameter set invokes a single graphql operation:
        // activeDirectoryDomainController.
        internal void ProcessRecord_DomainController()
        {
            this._logger.name += " -DomainController";
            // Create new graphql operation activeDirectoryDomainController
            InitQueryActiveDirectoryDomainController();
        }

        // This parameter set invokes a single graphql operation:
        // activeDirectoryDomainControllers.
        internal void ProcessRecord_DomainControllers()
        {
            this._logger.name += " -DomainControllers";
            // Create new graphql operation activeDirectoryDomainControllers
            InitQueryActiveDirectoryDomainControllers();
        }

        // This parameter set invokes a single graphql operation:
        // activeDirectoryDomains.
        internal void ProcessRecord_Domains()
        {
            this._logger.name += " -Domains";
            // Create new graphql operation activeDirectoryDomains
            InitQueryActiveDirectoryDomains();
        }

        // This parameter set invokes a single graphql operation:
        // activeDirectoryForests.
        internal void ProcessRecord_Forests()
        {
            this._logger.name += " -Forests";
            // Create new graphql operation activeDirectoryForests
            InitQueryActiveDirectoryForests();
        }

        // This parameter set invokes a single graphql operation:
        // activeDirectoryObjectDiff.
        internal void ProcessRecord_ObjectDiff()
        {
            this._logger.name += " -ObjectDiff";
            // Create new graphql operation activeDirectoryObjectDiff
            InitQueryActiveDirectoryObjectDiff();
        }

        // This parameter set invokes a single graphql operation:
        // activeDirectorySearchSnapshots.
        internal void ProcessRecord_SearchSnapshots()
        {
            this._logger.name += " -SearchSnapshots";
            // Create new graphql operation activeDirectorySearchSnapshots
            InitQueryActiveDirectorySearchSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // activeDirectorySnapshotBrowse.
        internal void ProcessRecord_SnapshotBrowse()
        {
            this._logger.name += " -SnapshotBrowse";
            // Create new graphql operation activeDirectorySnapshotBrowse
            InitQueryActiveDirectorySnapshotBrowse();
        }

        // This parameter set invokes a single graphql operation:
        // activeDirectorySnapshotSearch.
        internal void ProcessRecord_SnapshotSearch()
        {
            this._logger.name += " -SnapshotSearch";
            // Create new graphql operation activeDirectorySnapshotSearch
            InitQueryActiveDirectorySnapshotSearch();
        }

        // This parameter set invokes a single graphql operation:
        // unifiedActiveDirectoryDomain.
        internal void ProcessRecord_UnifiedDomain()
        {
            this._logger.name += " -UnifiedDomain";
            // Create new graphql operation unifiedActiveDirectoryDomain
            InitQueryUnifiedActiveDirectoryDomain();
        }

        // This parameter set invokes a single graphql operation:
        // unifiedActiveDirectoryDomainControllers.
        internal void ProcessRecord_UnifiedDomainControllers()
        {
            this._logger.name += " -UnifiedDomainControllers";
            // Create new graphql operation unifiedActiveDirectoryDomainControllers
            InitQueryUnifiedActiveDirectoryDomainControllers();
        }

        // This parameter set invokes a single graphql operation:
        // unifiedActiveDirectoryDomains.
        internal void ProcessRecord_UnifiedDomains()
        {
            this._logger.name += " -UnifiedDomains";
            // Create new graphql operation unifiedActiveDirectoryDomains
            InitQueryUnifiedActiveDirectoryDomains();
        }

        // This parameter set invokes a single graphql operation:
        // unifiedActiveDirectoryForests.
        internal void ProcessRecord_UnifiedForests()
        {
            this._logger.name += " -UnifiedForests";
            // Create new graphql operation unifiedActiveDirectoryForests
            InitQueryUnifiedActiveDirectoryForests();
        }


        // Create new GraphQL Query:
        // activeDirectoryAsyncRequestStatus(input: ActiveDirectoryAsyncRequestStatusInput!): AsyncRequestStatus!
        internal void InitQueryActiveDirectoryAsyncRequestStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ActiveDirectoryAsyncRequestStatusInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryActiveDirectoryAsyncRequestStatus",
                "($input: ActiveDirectoryAsyncRequestStatusInput!)",
                "AsyncRequestStatus",
                Query.ActiveDirectoryAsyncRequestStatus,
                Query.ActiveDirectoryAsyncRequestStatusFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // activeDirectoryDomain(fid: UUID!): ActiveDirectoryDomain!
        internal void InitQueryActiveDirectoryDomain()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryActiveDirectoryDomain",
                "($fid: UUID!)",
                "ActiveDirectoryDomain",
                Query.ActiveDirectoryDomain,
                Query.ActiveDirectoryDomainFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // activeDirectoryDomainController(fid: UUID!): ActiveDirectoryDomainController!
        internal void InitQueryActiveDirectoryDomainController()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryActiveDirectoryDomainController",
                "($fid: UUID!)",
                "ActiveDirectoryDomainController",
                Query.ActiveDirectoryDomainController,
                Query.ActiveDirectoryDomainControllerFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // activeDirectoryDomainControllers(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): ActiveDirectoryDomainControllerConnection!
        internal void InitQueryActiveDirectoryDomainControllers()
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
                "QueryActiveDirectoryDomainControllers",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "ActiveDirectoryDomainControllerConnection",
                Query.ActiveDirectoryDomainControllers,
                Query.ActiveDirectoryDomainControllersFieldSpec,
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
        // activeDirectoryDomains(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): ActiveDirectoryDomainConnection!
        internal void InitQueryActiveDirectoryDomains()
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
                "QueryActiveDirectoryDomains",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "ActiveDirectoryDomainConnection",
                Query.ActiveDirectoryDomains,
                Query.ActiveDirectoryDomainsFieldSpec,
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
        // activeDirectoryForests(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): ActiveDirectoryForestConnection!
        internal void InitQueryActiveDirectoryForests()
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
                "QueryActiveDirectoryForests",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "ActiveDirectoryForestConnection",
                Query.ActiveDirectoryForests,
                Query.ActiveDirectoryForestsFieldSpec,
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
        // activeDirectoryObjectDiff(
        //     dnt: Int!
        //     snapshotId1: String!
        //     snapshotId2: String!
        //     attributes: [String!]
        //     shouldReportOnlyChangedAttrs: Boolean
        //     shouldReportOnlyChangedValues: Boolean
        //   ): ActiveDirectoryObjectAttributesDiffResponseListResponse!
        internal void InitQueryActiveDirectoryObjectDiff()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("dnt", "Int!"),
                Tuple.Create("snapshotId1", "String!"),
                Tuple.Create("snapshotId2", "String!"),
                Tuple.Create("attributes", "[String!]"),
                Tuple.Create("shouldReportOnlyChangedAttrs", "Boolean"),
                Tuple.Create("shouldReportOnlyChangedValues", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryActiveDirectoryObjectDiff",
                "($dnt: Int!,$snapshotId1: String!,$snapshotId2: String!,$attributes: [String!],$shouldReportOnlyChangedAttrs: Boolean,$shouldReportOnlyChangedValues: Boolean)",
                "ActiveDirectoryObjectAttributesDiffResponseListResponse",
                Query.ActiveDirectoryObjectDiff,
                Query.ActiveDirectoryObjectDiffFieldSpec,
                @"# REQUIRED
$query.Var.dnt = $someInt
# REQUIRED
$query.Var.snapshotId1 = $someString
# REQUIRED
$query.Var.snapshotId2 = $someString
# OPTIONAL
$query.Var.attributes = @(
	$someString
)
# OPTIONAL
$query.Var.shouldReportOnlyChangedAttrs = $someBoolean
# OPTIONAL
$query.Var.shouldReportOnlyChangedValues = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // activeDirectorySearchSnapshots(
        //     first: Int
        //     after: String
        //     id: String!
        //     snapshotAfterDate: DateTime
        //     snapshotBeforeDate: DateTime
        //     name: String!
        //     activeDirectoryObjectType: ActiveDirectoryObjectType
        //   ): ActiveDirectorySnappableSearchResponseConnection!
        internal void InitQueryActiveDirectorySearchSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("id", "String!"),
                Tuple.Create("snapshotAfterDate", "DateTime"),
                Tuple.Create("snapshotBeforeDate", "DateTime"),
                Tuple.Create("name", "String!"),
                Tuple.Create("activeDirectoryObjectType", "ActiveDirectoryObjectType"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryActiveDirectorySearchSnapshots",
                "($first: Int,$after: String,$id: String!,$snapshotAfterDate: DateTime,$snapshotBeforeDate: DateTime,$name: String!,$activeDirectoryObjectType: ActiveDirectoryObjectType)",
                "ActiveDirectorySnappableSearchResponseConnection",
                Query.ActiveDirectorySearchSnapshots,
                Query.ActiveDirectorySearchSnapshotsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.id = $someString
# OPTIONAL
$query.Var.snapshotAfterDate = $someDateTime
# OPTIONAL
$query.Var.snapshotBeforeDate = $someDateTime
# REQUIRED
$query.Var.name = $someString
# OPTIONAL
$query.Var.activeDirectoryObjectType = $someActiveDirectoryObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActiveDirectoryObjectType]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // activeDirectorySnapshotBrowse(
        //     first: Int
        //     after: String
        //     id: String!
        //     dnt: Int!
        //     listOnlyContainers: Boolean
        //     activeDirectoryObjectType: ActiveDirectoryObjectType
        //     locationId: String
        //   ): ActiveDirectorySnapshotBrowseConnection!
        internal void InitQueryActiveDirectorySnapshotBrowse()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("id", "String!"),
                Tuple.Create("dnt", "Int!"),
                Tuple.Create("listOnlyContainers", "Boolean"),
                Tuple.Create("activeDirectoryObjectType", "ActiveDirectoryObjectType"),
                Tuple.Create("locationId", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryActiveDirectorySnapshotBrowse",
                "($first: Int,$after: String,$id: String!,$dnt: Int!,$listOnlyContainers: Boolean,$activeDirectoryObjectType: ActiveDirectoryObjectType,$locationId: String)",
                "ActiveDirectorySnapshotBrowseConnection",
                Query.ActiveDirectorySnapshotBrowse,
                Query.ActiveDirectorySnapshotBrowseFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.id = $someString
# REQUIRED
$query.Var.dnt = $someInt
# OPTIONAL
$query.Var.listOnlyContainers = $someBoolean
# OPTIONAL
$query.Var.activeDirectoryObjectType = $someActiveDirectoryObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActiveDirectoryObjectType]) for enum values.
# OPTIONAL
$query.Var.locationId = $someString"
            );
        }

        // Create new GraphQL Query:
        // activeDirectorySnapshotSearch(
        //     first: Int
        //     after: String
        //     id: String!
        //     dnt: Int!
        //     attribute: String
        //     activeDirectoryObjectType: ActiveDirectoryObjectType
        //     name: String!
        //     locationId: String
        //   ): ActiveDirectorySnapshotBrowseConnection!
        internal void InitQueryActiveDirectorySnapshotSearch()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("id", "String!"),
                Tuple.Create("dnt", "Int!"),
                Tuple.Create("attribute", "String"),
                Tuple.Create("activeDirectoryObjectType", "ActiveDirectoryObjectType"),
                Tuple.Create("name", "String!"),
                Tuple.Create("locationId", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryActiveDirectorySnapshotSearch",
                "($first: Int,$after: String,$id: String!,$dnt: Int!,$attribute: String,$activeDirectoryObjectType: ActiveDirectoryObjectType,$name: String!,$locationId: String)",
                "ActiveDirectorySnapshotBrowseConnection",
                Query.ActiveDirectorySnapshotSearch,
                Query.ActiveDirectorySnapshotSearchFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.id = $someString
# REQUIRED
$query.Var.dnt = $someInt
# OPTIONAL
$query.Var.attribute = $someString
# OPTIONAL
$query.Var.activeDirectoryObjectType = $someActiveDirectoryObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActiveDirectoryObjectType]) for enum values.
# REQUIRED
$query.Var.name = $someString
# OPTIONAL
$query.Var.locationId = $someString"
            );
        }

        // Create new GraphQL Query:
        // unifiedActiveDirectoryDomain(domainFid: UUID, domainSid: String): UnifiedActiveDirectoryDomain
        internal void InitQueryUnifiedActiveDirectoryDomain()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("domainFid", "UUID"),
                Tuple.Create("domainSid", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryUnifiedActiveDirectoryDomain",
                "($domainFid: UUID,$domainSid: String)",
                "UnifiedActiveDirectoryDomain",
                Query.UnifiedActiveDirectoryDomain,
                Query.UnifiedActiveDirectoryDomainFieldSpec,
                @"# OPTIONAL
$query.Var.domainFid = $someString
# OPTIONAL
$query.Var.domainSid = $someString"
            );
        }

        // Create new GraphQL Query:
        // unifiedActiveDirectoryDomainControllers(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): ActiveDirectoryDomainControllerConnection!
        internal void InitQueryUnifiedActiveDirectoryDomainControllers()
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
                "QueryUnifiedActiveDirectoryDomainControllers",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "ActiveDirectoryDomainControllerConnection",
                Query.UnifiedActiveDirectoryDomainControllers,
                Query.UnifiedActiveDirectoryDomainControllersFieldSpec,
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
        // unifiedActiveDirectoryDomains(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): UnifiedActiveDirectoryDomainConnection!
        internal void InitQueryUnifiedActiveDirectoryDomains()
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
                "QueryUnifiedActiveDirectoryDomains",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "UnifiedActiveDirectoryDomainConnection",
                Query.UnifiedActiveDirectoryDomains,
                Query.UnifiedActiveDirectoryDomainsFieldSpec,
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
        // unifiedActiveDirectoryForests(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //   ): UnifiedActiveDirectoryForestConnection!
        internal void InitQueryUnifiedActiveDirectoryForests()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryUnifiedActiveDirectoryForests",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder)",
                "UnifiedActiveDirectoryForestConnection",
                Query.UnifiedActiveDirectoryForests,
                Query.UnifiedActiveDirectoryForestsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.sortBy = $someHierarchySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values."
            );
        }


    } // class New_RscQueryActiveDirectory
}