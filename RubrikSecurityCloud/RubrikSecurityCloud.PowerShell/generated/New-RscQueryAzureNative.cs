// New-RscQueryAzureNative.cs
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
    /// operations in the 'Azure Native' API domain:
    /// AvailabilitySetsByRegionFromAzure, DoesResourceGroupExist, ExportCompatibleDiskTypesByRegionFromAzure, ExportCompatibleVmSizesByRegionFromAzure, IsManagedDiskSnapshotRestorable, IsSqlDatabaseSnapshotPersistent, ManagedDisk, ManagedDisks, ResourceGroup, ResourceGroups, ResourceGroupsInfoIfExist, Root, SecurityGroupsByRegionFromAzure, StorageAccountsFromAzure, SubnetsByRegionFromAzure, Subscription, Subscriptions, ValidateSqlDatabaseDbNameForExport, ValidateSqlManagedInstanceDbNameForExport, VirtualMachine, VirtualMachineSizes, VirtualMachines, or VirtualNetworks.
    /// </summary>
    /// <description>
    /// New-RscQueryAzureNative creates a new
    /// query object for operations
    /// in the 'Azure Native' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 23 operations
    /// in the 'Azure Native' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AvailabilitySetsByRegionFromAzure, DoesResourceGroupExist, ExportCompatibleDiskTypesByRegionFromAzure, ExportCompatibleVmSizesByRegionFromAzure, IsManagedDiskSnapshotRestorable, IsSqlDatabaseSnapshotPersistent, ManagedDisk, ManagedDisks, ResourceGroup, ResourceGroups, ResourceGroupsInfoIfExist, Root, SecurityGroupsByRegionFromAzure, StorageAccountsFromAzure, SubnetsByRegionFromAzure, Subscription, Subscriptions, ValidateSqlDatabaseDbNameForExport, ValidateSqlManagedInstanceDbNameForExport, VirtualMachine, VirtualMachineSizes, VirtualMachines, or VirtualNetworks.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryAzureNative -AvailabilitySetsByRegionFromAzure).Info().
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
    /// (New-RscQueryAzureNative -AvailabilitySetsByRegionFromAzure).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AvailabilitySetsByRegionFromAzure operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: AvailabilitySetsByRegionFromAzure
    /// 
    /// $query = New-RscQueryAzureNative -AvailabilitySetsByRegionFromAzure
    /// 
    /// # REQUIRED
    /// $query.Var.azureSubscriptionRubrikId = $someString
    /// # REQUIRED
    /// $query.Var.resourceGroupName = $someString
    /// # REQUIRED
    /// $query.Var.region = $someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AzureNativeAvailabilitySet&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DoesResourceGroupExist operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: DoesResourceGroupExist
    /// 
    /// $query = New-RscQueryAzureNative -DoesResourceGroupExist
    /// 
    /// # REQUIRED
    /// $query.Var.cloudAccountId = $someString
    /// # REQUIRED
    /// $query.Var.azureSubscriptionNativeId = $someString
    /// # REQUIRED
    /// $query.Var.resourceGroupName = $someString
    /// # REQUIRED
    /// $query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
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
    /// Runs the ExportCompatibleDiskTypesByRegionFromAzure operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: ExportCompatibleDiskTypesByRegionFromAzure
    /// 
    /// $query = New-RscQueryAzureNative -ExportCompatibleDiskTypesByRegionFromAzure
    /// 
    /// # REQUIRED
    /// $query.Var.azureSubscriptionRubrikId = $someString
    /// # REQUIRED
    /// $query.Var.region = $someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AzureNativeExportCompatibleDiskTypes&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ExportCompatibleVmSizesByRegionFromAzure operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: ExportCompatibleVmSizesByRegionFromAzure
    /// 
    /// $query = New-RscQueryAzureNative -ExportCompatibleVmSizesByRegionFromAzure
    /// 
    /// # REQUIRED
    /// $query.Var.azureSubscriptionRubrikId = $someString
    /// # REQUIRED
    /// $query.Var.region = $someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
    /// # REQUIRED
    /// $query.Var.vmSnapshotId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AzureNativeExportCompatibleVmSizes&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the IsManagedDiskSnapshotRestorable operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: IsManagedDiskSnapshotRestorable
    /// 
    /// $query = New-RscQueryAzureNative -IsManagedDiskSnapshotRestorable
    /// 
    /// # REQUIRED
    /// $query.Var.azureSubscriptionRubrikId = $someString
    /// # REQUIRED
    /// $query.Var.diskSnapshotId = $someString
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
    /// Runs the IsSqlDatabaseSnapshotPersistent operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: IsSqlDatabaseSnapshotPersistent
    /// 
    /// $query = New-RscQueryAzureNative -IsSqlDatabaseSnapshotPersistent
    /// 
    /// # REQUIRED
    /// $query.Var.snapshotId = $someString
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
    /// Runs the ManagedDisk operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: ManagedDisk
    /// 
    /// $query = New-RscQueryAzureNative -ManagedDisk
    /// 
    /// # REQUIRED
    /// $query.Var.azureManagedDiskRubrikId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureNativeManagedDisk
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ManagedDisks operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: ManagedDisks
    /// 
    /// $query = New-RscQueryAzureNative -ManagedDisks
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
    /// $query.Var.sortBy = $someAzureNativeDiskSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeDiskSortFields]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.diskFilters = @{
    /// 	# OPTIONAL
    /// 	nameSubstringFilter = @{
    /// 		# REQUIRED
    /// 		nameSubstring = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	effectiveSlaFilter = @{
    /// 		# REQUIRED
    /// 		effectiveSlaIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	resourceGroupFilter = @{
    /// 		# REQUIRED
    /// 		resourceGroupNames = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	subscriptionFilter = @{
    /// 		# REQUIRED
    /// 		subscriptionIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	regionFilter = @{
    /// 		# REQUIRED
    /// 		regions = @(
    /// 			$someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	diskTypeFilter = @{
    /// 		# REQUIRED
    /// 		diskTypes = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	attachedVmFilter = @{
    /// 		# REQUIRED
    /// 		virtualMachineIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	relicFilter = @{
    /// 		# REQUIRED
    /// 		relic = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	tagFilter = @{
    /// 		# REQUIRED
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
    /// 	}
    /// 	# OPTIONAL
    /// 	exocomputeConnectedFilter = @{
    /// 		# REQUIRED
    /// 		isConnected = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	fileIndexingFilter = @{
    /// 		# REQUIRED
    /// 		statuses = @(
    /// 			$someAzureNativeFileIndexingStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeFileIndexingStatus]) for enum values.
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureNativeManagedDiskConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ResourceGroup operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: ResourceGroup
    /// 
    /// $query = New-RscQueryAzureNative -ResourceGroup
    /// 
    /// # REQUIRED
    /// $query.Var.resourceGroupId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureNativeResourceGroup
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ResourceGroups operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: ResourceGroups
    /// 
    /// $query = New-RscQueryAzureNative -ResourceGroups
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
    /// $query.Var.sortBy = $someAzureNativeCommonResourceGroupSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeCommonResourceGroupSortFields]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.commonResourceGroupFilters = @{
    /// 	# OPTIONAL
    /// 	nameSubstringFilter = @{
    /// 		# REQUIRED
    /// 		nameSubstring = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	subscriptionFilter = @{
    /// 		# REQUIRED
    /// 		subscriptionIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	regionFilter = @{
    /// 		# REQUIRED
    /// 		regions = @(
    /// 			$someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	effectiveSlaFilter = @{
    /// 		# REQUIRED
    /// 		effectiveSlaIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// }
    /// # OPTIONAL
    /// $query.Var.protectedObjectTypes = @(
    /// 	$someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.azureNativeProtectionFeatures = @(
    /// 	$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureNativeResourceGroupConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ResourceGroupsInfoIfExist operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: ResourceGroupsInfoIfExist
    /// 
    /// $query = New-RscQueryAzureNative -ResourceGroupsInfoIfExist
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	sessionId = $someString
    /// 	# REQUIRED
    /// 	resourceGroupInputs = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			subscriptionNativeId = $someString
    /// 			# REQUIRED
    /// 			resourceGroupName = $someString
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AzureResourceGroupInfo&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Root operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: Root
    /// 
    /// $query = New-RscQueryAzureNative -Root
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureNativeRoot
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SecurityGroupsByRegionFromAzure operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: SecurityGroupsByRegionFromAzure
    /// 
    /// $query = New-RscQueryAzureNative -SecurityGroupsByRegionFromAzure
    /// 
    /// # REQUIRED
    /// $query.Var.azureSubscriptionRubrikId = $someString
    /// # REQUIRED
    /// $query.Var.region = $someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AzureNativeSecurityGroup&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StorageAccountsFromAzure operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: StorageAccountsFromAzure
    /// 
    /// $query = New-RscQueryAzureNative -StorageAccountsFromAzure
    /// 
    /// # REQUIRED
    /// $query.Var.azureSubscriptionRubrikId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AzureNativeStorageAccount&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SubnetsByRegionFromAzure operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: SubnetsByRegionFromAzure
    /// 
    /// $query = New-RscQueryAzureNative -SubnetsByRegionFromAzure
    /// 
    /// # REQUIRED
    /// $query.Var.azureSubscriptionRubrikId = $someString
    /// # REQUIRED
    /// $query.Var.region = $someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AzureNativeSubnet&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Subscription operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: Subscription
    /// 
    /// $query = New-RscQueryAzureNative -Subscription
    /// 
    /// # REQUIRED
    /// $query.Var.azureSubscriptionRubrikId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureNativeSubscription
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Subscriptions operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: Subscriptions
    /// 
    /// $query = New-RscQueryAzureNative -Subscriptions
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
    /// $query.Var.sortBy = $someAzureNativeSubscriptionSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeSubscriptionSortFields]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.subscriptionFilters = @{
    /// 	# OPTIONAL
    /// 	nameSubstringFilter = @{
    /// 		# REQUIRED
    /// 		nameSubstring = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	effectiveSlaFilter = @{
    /// 		# REQUIRED
    /// 		effectiveSlaIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// }
    /// # OPTIONAL
    /// $query.Var.authorizedOperationFilter = $someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
    /// # OPTIONAL
    /// $query.Var.workloadHierarchy = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.azureNativeProtectionFeature = $someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureNativeSubscriptionConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ValidateSqlDatabaseDbNameForExport operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: ValidateSqlDatabaseDbNameForExport
    /// 
    /// $query = New-RscQueryAzureNative -ValidateSqlDatabaseDbNameForExport
    /// 
    /// # REQUIRED
    /// $query.Var.azureSqlDatabaseName = $someString
    /// # REQUIRED
    /// $query.Var.azureSqlDatabaseServerRubrikId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ValidateAzureNativeSqlDatabaseDbNameForExportReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ValidateSqlManagedInstanceDbNameForExport operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: ValidateSqlManagedInstanceDbNameForExport
    /// 
    /// $query = New-RscQueryAzureNative -ValidateSqlManagedInstanceDbNameForExport
    /// 
    /// # REQUIRED
    /// $query.Var.azureSqlDatabaseName = $someString
    /// # REQUIRED
    /// $query.Var.azureSqlManagedInstanceServerRubrikId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ValidateAzureNativeSqlManagedInstanceDbNameForExportReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the VirtualMachine operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: VirtualMachine
    /// 
    /// $query = New-RscQueryAzureNative -VirtualMachine
    /// 
    /// # REQUIRED
    /// $query.Var.azureVirtualMachineRubrikId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureNativeVirtualMachine
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the VirtualMachineSizes operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: VirtualMachineSizes
    /// 
    /// $query = New-RscQueryAzureNative -VirtualMachineSizes
    /// 
    /// # OPTIONAL
    /// $query.Var.azureSubscriptionRubrikId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;System.String&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the VirtualMachines operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: VirtualMachines
    /// 
    /// $query = New-RscQueryAzureNative -VirtualMachines
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
    /// $query.Var.sortBy = $someAzureNativeVirtualMachineSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeVirtualMachineSortFields]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.descendantTypeFilter = @(
    /// 	$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.virtualMachineFilters = @{
    /// 	# OPTIONAL
    /// 	nameSubstringFilter = @{
    /// 		# REQUIRED
    /// 		nameSubstring = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	effectiveSlaFilter = @{
    /// 		# REQUIRED
    /// 		effectiveSlaIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	resourceGroupFilter = @{
    /// 		# REQUIRED
    /// 		resourceGroupNames = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	subscriptionFilter = @{
    /// 		# REQUIRED
    /// 		subscriptionIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	regionFilter = @{
    /// 		# REQUIRED
    /// 		regions = @(
    /// 			$someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	vmSizeFilter = @{
    /// 		# REQUIRED
    /// 		vmSizes = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	vnetFilter = @{
    /// 		# REQUIRED
    /// 		vnetNames = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	relicFilter = @{
    /// 		# REQUIRED
    /// 		relic = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	tagFilter = @{
    /// 		# REQUIRED
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
    /// 	}
    /// 	# OPTIONAL
    /// 	exocomputeConnectedFilter = @{
    /// 		# REQUIRED
    /// 		isConnected = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	fileIndexingFilter = @{
    /// 		# REQUIRED
    /// 		statuses = @(
    /// 			$someAzureNativeFileIndexingStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeFileIndexingStatus]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	appProtectionStatusFilter = @{
    /// 		# REQUIRED
    /// 		isProtectionSetup = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	rbsStatusFilter = @{
    /// 		# REQUIRED
    /// 		status = $someCloudInstanceRbsConnectionStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudInstanceRbsConnectionStatus]) for enum values.
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureNativeVirtualMachineConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the VirtualNetworks operation
    /// of the 'Azure Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AzureNative
    /// # API Operation: VirtualNetworks
    /// 
    /// $query = New-RscQueryAzureNative -VirtualNetworks
    /// 
    /// # OPTIONAL
    /// $query.Var.azureSubscriptionRubrikId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AzureNativeVirtualNetwork&gt;
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
        "RscQueryAzureNative",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryAzureNative : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "AvailabilitySetsByRegionFromAzure",
                "DoesResourceGroupExist",
                "ExportCompatibleDiskTypesByRegionFromAzure",
                "ExportCompatibleVmSizesByRegionFromAzure",
                "IsManagedDiskSnapshotRestorable",
                "IsSqlDatabaseSnapshotPersistent",
                "ManagedDisk",
                "ManagedDisks",
                "ResourceGroup",
                "ResourceGroups",
                "ResourceGroupsInfoIfExist",
                "Root",
                "SecurityGroupsByRegionFromAzure",
                "StorageAccountsFromAzure",
                "SubnetsByRegionFromAzure",
                "Subscription",
                "Subscriptions",
                "ValidateSqlDatabaseDbNameForExport",
                "ValidateSqlManagedInstanceDbNameForExport",
                "VirtualMachine",
                "VirtualMachineSizes",
                "VirtualMachines",
                "VirtualNetworks",
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
                    case "AvailabilitySetsByRegionFromAzure":
                        this.ProcessRecord_AvailabilitySetsByRegionFromAzure();
                        break;
                    case "DoesResourceGroupExist":
                        this.ProcessRecord_DoesResourceGroupExist();
                        break;
                    case "ExportCompatibleDiskTypesByRegionFromAzure":
                        this.ProcessRecord_ExportCompatibleDiskTypesByRegionFromAzure();
                        break;
                    case "ExportCompatibleVmSizesByRegionFromAzure":
                        this.ProcessRecord_ExportCompatibleVmSizesByRegionFromAzure();
                        break;
                    case "IsManagedDiskSnapshotRestorable":
                        this.ProcessRecord_IsManagedDiskSnapshotRestorable();
                        break;
                    case "IsSqlDatabaseSnapshotPersistent":
                        this.ProcessRecord_IsSqlDatabaseSnapshotPersistent();
                        break;
                    case "ManagedDisk":
                        this.ProcessRecord_ManagedDisk();
                        break;
                    case "ManagedDisks":
                        this.ProcessRecord_ManagedDisks();
                        break;
                    case "ResourceGroup":
                        this.ProcessRecord_ResourceGroup();
                        break;
                    case "ResourceGroups":
                        this.ProcessRecord_ResourceGroups();
                        break;
                    case "ResourceGroupsInfoIfExist":
                        this.ProcessRecord_ResourceGroupsInfoIfExist();
                        break;
                    case "Root":
                        this.ProcessRecord_Root();
                        break;
                    case "SecurityGroupsByRegionFromAzure":
                        this.ProcessRecord_SecurityGroupsByRegionFromAzure();
                        break;
                    case "StorageAccountsFromAzure":
                        this.ProcessRecord_StorageAccountsFromAzure();
                        break;
                    case "SubnetsByRegionFromAzure":
                        this.ProcessRecord_SubnetsByRegionFromAzure();
                        break;
                    case "Subscription":
                        this.ProcessRecord_Subscription();
                        break;
                    case "Subscriptions":
                        this.ProcessRecord_Subscriptions();
                        break;
                    case "ValidateSqlDatabaseDbNameForExport":
                        this.ProcessRecord_ValidateSqlDatabaseDbNameForExport();
                        break;
                    case "ValidateSqlManagedInstanceDbNameForExport":
                        this.ProcessRecord_ValidateSqlManagedInstanceDbNameForExport();
                        break;
                    case "VirtualMachine":
                        this.ProcessRecord_VirtualMachine();
                        break;
                    case "VirtualMachineSizes":
                        this.ProcessRecord_VirtualMachineSizes();
                        break;
                    case "VirtualMachines":
                        this.ProcessRecord_VirtualMachines();
                        break;
                    case "VirtualNetworks":
                        this.ProcessRecord_VirtualNetworks();
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
        // allAzureNativeAvailabilitySetsByRegionFromAzure.
        internal void ProcessRecord_AvailabilitySetsByRegionFromAzure()
        {
            this._logger.name += " -AvailabilitySetsByRegionFromAzure";
            // Create new graphql operation allAzureNativeAvailabilitySetsByRegionFromAzure
            InitQueryAllAzureNativeAvailabilitySetsByRegionFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // doesAzureNativeResourceGroupExist.
        internal void ProcessRecord_DoesResourceGroupExist()
        {
            this._logger.name += " -DoesResourceGroupExist";
            // Create new graphql operation doesAzureNativeResourceGroupExist
            InitQueryDoesAzureNativeResourceGroupExist();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeExportCompatibleDiskTypesByRegionFromAzure.
        internal void ProcessRecord_ExportCompatibleDiskTypesByRegionFromAzure()
        {
            this._logger.name += " -ExportCompatibleDiskTypesByRegionFromAzure";
            // Create new graphql operation allAzureNativeExportCompatibleDiskTypesByRegionFromAzure
            InitQueryAllAzureNativeExportCompatibleDiskTypesByRegionFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeExportCompatibleVmSizesByRegionFromAzure.
        internal void ProcessRecord_ExportCompatibleVmSizesByRegionFromAzure()
        {
            this._logger.name += " -ExportCompatibleVmSizesByRegionFromAzure";
            // Create new graphql operation allAzureNativeExportCompatibleVmSizesByRegionFromAzure
            InitQueryAllAzureNativeExportCompatibleVmSizesByRegionFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // isAzureNativeManagedDiskSnapshotRestorable.
        internal void ProcessRecord_IsManagedDiskSnapshotRestorable()
        {
            this._logger.name += " -IsManagedDiskSnapshotRestorable";
            // Create new graphql operation isAzureNativeManagedDiskSnapshotRestorable
            InitQueryIsAzureNativeManagedDiskSnapshotRestorable();
        }

        // This parameter set invokes a single graphql operation:
        // isAzureNativeSqlDatabaseSnapshotPersistent.
        internal void ProcessRecord_IsSqlDatabaseSnapshotPersistent()
        {
            this._logger.name += " -IsSqlDatabaseSnapshotPersistent";
            // Create new graphql operation isAzureNativeSqlDatabaseSnapshotPersistent
            InitQueryIsAzureNativeSqlDatabaseSnapshotPersistent();
        }

        // This parameter set invokes a single graphql operation:
        // azureNativeManagedDisk.
        internal void ProcessRecord_ManagedDisk()
        {
            this._logger.name += " -ManagedDisk";
            // Create new graphql operation azureNativeManagedDisk
            InitQueryAzureNativeManagedDisk();
        }

        // This parameter set invokes a single graphql operation:
        // azureNativeManagedDisks.
        internal void ProcessRecord_ManagedDisks()
        {
            this._logger.name += " -ManagedDisks";
            // Create new graphql operation azureNativeManagedDisks
            InitQueryAzureNativeManagedDisks();
        }

        // This parameter set invokes a single graphql operation:
        // azureNativeResourceGroup.
        internal void ProcessRecord_ResourceGroup()
        {
            this._logger.name += " -ResourceGroup";
            // Create new graphql operation azureNativeResourceGroup
            InitQueryAzureNativeResourceGroup();
        }

        // This parameter set invokes a single graphql operation:
        // azureNativeResourceGroups.
        internal void ProcessRecord_ResourceGroups()
        {
            this._logger.name += " -ResourceGroups";
            // Create new graphql operation azureNativeResourceGroups
            InitQueryAzureNativeResourceGroups();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeResourceGroupsInfoIfExist.
        internal void ProcessRecord_ResourceGroupsInfoIfExist()
        {
            this._logger.name += " -ResourceGroupsInfoIfExist";
            // Create new graphql operation allAzureNativeResourceGroupsInfoIfExist
            InitQueryAllAzureNativeResourceGroupsInfoIfExist();
        }

        // This parameter set invokes a single graphql operation:
        // azureNativeRoot.
        internal void ProcessRecord_Root()
        {
            this._logger.name += " -Root";
            // Create new graphql operation azureNativeRoot
            InitQueryAzureNativeRoot();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeSecurityGroupsByRegionFromAzure.
        internal void ProcessRecord_SecurityGroupsByRegionFromAzure()
        {
            this._logger.name += " -SecurityGroupsByRegionFromAzure";
            // Create new graphql operation allAzureNativeSecurityGroupsByRegionFromAzure
            InitQueryAllAzureNativeSecurityGroupsByRegionFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeStorageAccountsFromAzure.
        internal void ProcessRecord_StorageAccountsFromAzure()
        {
            this._logger.name += " -StorageAccountsFromAzure";
            // Create new graphql operation allAzureNativeStorageAccountsFromAzure
            InitQueryAllAzureNativeStorageAccountsFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeSubnetsByRegionFromAzure.
        internal void ProcessRecord_SubnetsByRegionFromAzure()
        {
            this._logger.name += " -SubnetsByRegionFromAzure";
            // Create new graphql operation allAzureNativeSubnetsByRegionFromAzure
            InitQueryAllAzureNativeSubnetsByRegionFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // azureNativeSubscription.
        internal void ProcessRecord_Subscription()
        {
            this._logger.name += " -Subscription";
            // Create new graphql operation azureNativeSubscription
            InitQueryAzureNativeSubscription();
        }

        // This parameter set invokes a single graphql operation:
        // azureNativeSubscriptions.
        internal void ProcessRecord_Subscriptions()
        {
            this._logger.name += " -Subscriptions";
            // Create new graphql operation azureNativeSubscriptions
            InitQueryAzureNativeSubscriptions();
        }

        // This parameter set invokes a single graphql operation:
        // validateAzureNativeSqlDatabaseDbNameForExport.
        internal void ProcessRecord_ValidateSqlDatabaseDbNameForExport()
        {
            this._logger.name += " -ValidateSqlDatabaseDbNameForExport";
            // Create new graphql operation validateAzureNativeSqlDatabaseDbNameForExport
            InitQueryValidateAzureNativeSqlDatabaseDbNameForExport();
        }

        // This parameter set invokes a single graphql operation:
        // validateAzureNativeSqlManagedInstanceDbNameForExport.
        internal void ProcessRecord_ValidateSqlManagedInstanceDbNameForExport()
        {
            this._logger.name += " -ValidateSqlManagedInstanceDbNameForExport";
            // Create new graphql operation validateAzureNativeSqlManagedInstanceDbNameForExport
            InitQueryValidateAzureNativeSqlManagedInstanceDbNameForExport();
        }

        // This parameter set invokes a single graphql operation:
        // azureNativeVirtualMachine.
        internal void ProcessRecord_VirtualMachine()
        {
            this._logger.name += " -VirtualMachine";
            // Create new graphql operation azureNativeVirtualMachine
            InitQueryAzureNativeVirtualMachine();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeVirtualMachineSizes.
        internal void ProcessRecord_VirtualMachineSizes()
        {
            this._logger.name += " -VirtualMachineSizes";
            // Create new graphql operation allAzureNativeVirtualMachineSizes
            InitQueryAllAzureNativeVirtualMachineSizes();
        }

        // This parameter set invokes a single graphql operation:
        // azureNativeVirtualMachines.
        internal void ProcessRecord_VirtualMachines()
        {
            this._logger.name += " -VirtualMachines";
            // Create new graphql operation azureNativeVirtualMachines
            InitQueryAzureNativeVirtualMachines();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeVirtualNetworks.
        internal void ProcessRecord_VirtualNetworks()
        {
            this._logger.name += " -VirtualNetworks";
            // Create new graphql operation allAzureNativeVirtualNetworks
            InitQueryAllAzureNativeVirtualNetworks();
        }


        // Create new GraphQL Query:
        // allAzureNativeAvailabilitySetsByRegionFromAzure(azureSubscriptionRubrikId: UUID!, resourceGroupName: String!, region: AzureNativeRegion!): [AzureNativeAvailabilitySet!]!
        internal void InitQueryAllAzureNativeAvailabilitySetsByRegionFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("region", "AzureNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeAvailabilitySetsByRegionFromAzure",
                "($azureSubscriptionRubrikId: UUID!,$resourceGroupName: String!,$region: AzureNativeRegion!)",
                "List<AzureNativeAvailabilitySet>",
                Query.AllAzureNativeAvailabilitySetsByRegionFromAzure_ObjectFieldSpec,
                Query.AllAzureNativeAvailabilitySetsByRegionFromAzureFieldSpec,
                @"# REQUIRED
$query.Var.azureSubscriptionRubrikId = $someString
# REQUIRED
$query.Var.resourceGroupName = $someString
# REQUIRED
$query.Var.region = $someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // doesAzureNativeResourceGroupExist(
        //     cloudAccountId: UUID!
        //     azureSubscriptionNativeId: UUID!
        //     resourceGroupName: String!
        //     feature: CloudAccountFeature!
        //   ): Boolean!
        internal void InitQueryDoesAzureNativeResourceGroupExist()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
                Tuple.Create("azureSubscriptionNativeId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDoesAzureNativeResourceGroupExist",
                "($cloudAccountId: UUID!,$azureSubscriptionNativeId: UUID!,$resourceGroupName: String!,$feature: CloudAccountFeature!)",
                "System.Boolean",
                Query.DoesAzureNativeResourceGroupExist_ObjectFieldSpec,
                Query.DoesAzureNativeResourceGroupExistFieldSpec,
                @"# REQUIRED
$query.Var.cloudAccountId = $someString
# REQUIRED
$query.Var.azureSubscriptionNativeId = $someString
# REQUIRED
$query.Var.resourceGroupName = $someString
# REQUIRED
$query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allAzureNativeExportCompatibleDiskTypesByRegionFromAzure(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!): [AzureNativeExportCompatibleDiskTypes!]!
        internal void InitQueryAllAzureNativeExportCompatibleDiskTypesByRegionFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("region", "AzureNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeExportCompatibleDiskTypesByRegionFromAzure",
                "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!)",
                "List<AzureNativeExportCompatibleDiskTypes>",
                Query.AllAzureNativeExportCompatibleDiskTypesByRegionFromAzure_ObjectFieldSpec,
                Query.AllAzureNativeExportCompatibleDiskTypesByRegionFromAzureFieldSpec,
                @"# REQUIRED
$query.Var.azureSubscriptionRubrikId = $someString
# REQUIRED
$query.Var.region = $someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allAzureNativeExportCompatibleVmSizesByRegionFromAzure(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!, vmSnapshotId: UUID!): [AzureNativeExportCompatibleVmSizes!]!
        internal void InitQueryAllAzureNativeExportCompatibleVmSizesByRegionFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("region", "AzureNativeRegion!"),
                Tuple.Create("vmSnapshotId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeExportCompatibleVmSizesByRegionFromAzure",
                "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!,$vmSnapshotId: UUID!)",
                "List<AzureNativeExportCompatibleVmSizes>",
                Query.AllAzureNativeExportCompatibleVmSizesByRegionFromAzure_ObjectFieldSpec,
                Query.AllAzureNativeExportCompatibleVmSizesByRegionFromAzureFieldSpec,
                @"# REQUIRED
$query.Var.azureSubscriptionRubrikId = $someString
# REQUIRED
$query.Var.region = $someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
# REQUIRED
$query.Var.vmSnapshotId = $someString"
            );
        }

        // Create new GraphQL Query:
        // isAzureNativeManagedDiskSnapshotRestorable(azureSubscriptionRubrikId: UUID!, diskSnapshotId: UUID!): Boolean!
        internal void InitQueryIsAzureNativeManagedDiskSnapshotRestorable()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("diskSnapshotId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsAzureNativeManagedDiskSnapshotRestorable",
                "($azureSubscriptionRubrikId: UUID!,$diskSnapshotId: UUID!)",
                "System.Boolean",
                Query.IsAzureNativeManagedDiskSnapshotRestorable_ObjectFieldSpec,
                Query.IsAzureNativeManagedDiskSnapshotRestorableFieldSpec,
                @"# REQUIRED
$query.Var.azureSubscriptionRubrikId = $someString
# REQUIRED
$query.Var.diskSnapshotId = $someString"
            );
        }

        // Create new GraphQL Query:
        // isAzureNativeSqlDatabaseSnapshotPersistent(snapshotId: UUID!): Boolean!
        internal void InitQueryIsAzureNativeSqlDatabaseSnapshotPersistent()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snapshotId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsAzureNativeSqlDatabaseSnapshotPersistent",
                "($snapshotId: UUID!)",
                "System.Boolean",
                Query.IsAzureNativeSqlDatabaseSnapshotPersistent_ObjectFieldSpec,
                Query.IsAzureNativeSqlDatabaseSnapshotPersistentFieldSpec,
                @"# REQUIRED
$query.Var.snapshotId = $someString"
            );
        }

        // Create new GraphQL Query:
        // azureNativeManagedDisk(azureManagedDiskRubrikId: UUID!): AzureNativeManagedDisk!
        internal void InitQueryAzureNativeManagedDisk()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureManagedDiskRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeManagedDisk",
                "($azureManagedDiskRubrikId: UUID!)",
                "AzureNativeManagedDisk",
                Query.AzureNativeManagedDisk_ObjectFieldSpec,
                Query.AzureNativeManagedDiskFieldSpec,
                @"# REQUIRED
$query.Var.azureManagedDiskRubrikId = $someString"
            );
        }

        // Create new GraphQL Query:
        // azureNativeManagedDisks(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AzureNativeDiskSortFields
        //     sortOrder: SortOrder
        //     diskFilters: AzureNativeDiskFilters
        //   ): AzureNativeManagedDiskConnection!
        internal void InitQueryAzureNativeManagedDisks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AzureNativeDiskSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("diskFilters", "AzureNativeDiskFilters"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeManagedDisks",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureNativeDiskSortFields,$sortOrder: SortOrder,$diskFilters: AzureNativeDiskFilters)",
                "AzureNativeManagedDiskConnection",
                Query.AzureNativeManagedDisks_ObjectFieldSpec,
                Query.AzureNativeManagedDisksFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someAzureNativeDiskSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeDiskSortFields]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.diskFilters = @{
	# OPTIONAL
	nameSubstringFilter = @{
		# REQUIRED
		nameSubstring = $someString
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			$someString
		)
	}
	# OPTIONAL
	resourceGroupFilter = @{
		# REQUIRED
		resourceGroupNames = @(
			$someString
		)
	}
	# OPTIONAL
	subscriptionFilter = @{
		# REQUIRED
		subscriptionIds = @(
			$someString
		)
	}
	# OPTIONAL
	regionFilter = @{
		# REQUIRED
		regions = @(
			$someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
		)
	}
	# OPTIONAL
	diskTypeFilter = @{
		# REQUIRED
		diskTypes = @(
			$someString
		)
	}
	# OPTIONAL
	attachedVmFilter = @{
		# REQUIRED
		virtualMachineIds = @(
			$someString
		)
	}
	# OPTIONAL
	relicFilter = @{
		# REQUIRED
		relic = $someBoolean
	}
	# OPTIONAL
	tagFilter = @{
		# REQUIRED
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
	}
	# OPTIONAL
	exocomputeConnectedFilter = @{
		# REQUIRED
		isConnected = $someBoolean
	}
	# OPTIONAL
	fileIndexingFilter = @{
		# REQUIRED
		statuses = @(
			$someAzureNativeFileIndexingStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeFileIndexingStatus]) for enum values.
		)
	}
}"
            );
        }

        // Create new GraphQL Query:
        // azureNativeResourceGroup(resourceGroupId: UUID!): AzureNativeResourceGroup!
        internal void InitQueryAzureNativeResourceGroup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("resourceGroupId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeResourceGroup",
                "($resourceGroupId: UUID!)",
                "AzureNativeResourceGroup",
                Query.AzureNativeResourceGroup_ObjectFieldSpec,
                Query.AzureNativeResourceGroupFieldSpec,
                @"# REQUIRED
$query.Var.resourceGroupId = $someString"
            );
        }

        // Create new GraphQL Query:
        // azureNativeResourceGroups(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AzureNativeCommonResourceGroupSortFields
        //     sortOrder: SortOrder
        //     commonResourceGroupFilters: AzureNativeCommonResourceGroupFilters
        //     protectedObjectTypes: [WorkloadLevelHierarchy!]
        //     azureNativeProtectionFeatures: [AzureNativeProtectionFeature!]
        //   ): AzureNativeResourceGroupConnection!
        internal void InitQueryAzureNativeResourceGroups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AzureNativeCommonResourceGroupSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("commonResourceGroupFilters", "AzureNativeCommonResourceGroupFilters"),
                Tuple.Create("protectedObjectTypes", "[WorkloadLevelHierarchy!]"),
                Tuple.Create("azureNativeProtectionFeatures", "[AzureNativeProtectionFeature!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeResourceGroups",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureNativeCommonResourceGroupSortFields,$sortOrder: SortOrder,$commonResourceGroupFilters: AzureNativeCommonResourceGroupFilters,$protectedObjectTypes: [WorkloadLevelHierarchy!],$azureNativeProtectionFeatures: [AzureNativeProtectionFeature!])",
                "AzureNativeResourceGroupConnection",
                Query.AzureNativeResourceGroups_ObjectFieldSpec,
                Query.AzureNativeResourceGroupsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someAzureNativeCommonResourceGroupSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeCommonResourceGroupSortFields]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.commonResourceGroupFilters = @{
	# OPTIONAL
	nameSubstringFilter = @{
		# REQUIRED
		nameSubstring = $someString
	}
	# OPTIONAL
	subscriptionFilter = @{
		# REQUIRED
		subscriptionIds = @(
			$someString
		)
	}
	# OPTIONAL
	regionFilter = @{
		# REQUIRED
		regions = @(
			$someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
		)
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			$someString
		)
	}
}
# OPTIONAL
$query.Var.protectedObjectTypes = @(
	$someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
)
# OPTIONAL
$query.Var.azureNativeProtectionFeatures = @(
	$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
)"
            );
        }

        // Create new GraphQL Query:
        // allAzureNativeResourceGroupsInfoIfExist(input: AzureGetResourceGroupsInfoIfExistInput!): [AzureResourceGroupInfo!]!
        internal void InitQueryAllAzureNativeResourceGroupsInfoIfExist()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AzureGetResourceGroupsInfoIfExistInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeResourceGroupsInfoIfExist",
                "($input: AzureGetResourceGroupsInfoIfExistInput!)",
                "List<AzureResourceGroupInfo>",
                Query.AllAzureNativeResourceGroupsInfoIfExist_ObjectFieldSpec,
                Query.AllAzureNativeResourceGroupsInfoIfExistFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	sessionId = $someString
	# REQUIRED
	resourceGroupInputs = @(
		@{
			# REQUIRED
			subscriptionNativeId = $someString
			# REQUIRED
			resourceGroupName = $someString
		}
	)
}"
            );
        }

        // Create new GraphQL Query:
        // azureNativeRoot: AzureNativeRoot!
        internal void InitQueryAzureNativeRoot()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeRoot",
                "",
                "AzureNativeRoot",
                Query.AzureNativeRoot_ObjectFieldSpec,
                Query.AzureNativeRootFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // allAzureNativeSecurityGroupsByRegionFromAzure(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!): [AzureNativeSecurityGroup!]!
        internal void InitQueryAllAzureNativeSecurityGroupsByRegionFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("region", "AzureNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeSecurityGroupsByRegionFromAzure",
                "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!)",
                "List<AzureNativeSecurityGroup>",
                Query.AllAzureNativeSecurityGroupsByRegionFromAzure_ObjectFieldSpec,
                Query.AllAzureNativeSecurityGroupsByRegionFromAzureFieldSpec,
                @"# REQUIRED
$query.Var.azureSubscriptionRubrikId = $someString
# REQUIRED
$query.Var.region = $someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allAzureNativeStorageAccountsFromAzure(azureSubscriptionRubrikId: UUID!): [AzureNativeStorageAccount!]!
        internal void InitQueryAllAzureNativeStorageAccountsFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeStorageAccountsFromAzure",
                "($azureSubscriptionRubrikId: UUID!)",
                "List<AzureNativeStorageAccount>",
                Query.AllAzureNativeStorageAccountsFromAzure_ObjectFieldSpec,
                Query.AllAzureNativeStorageAccountsFromAzureFieldSpec,
                @"# REQUIRED
$query.Var.azureSubscriptionRubrikId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allAzureNativeSubnetsByRegionFromAzure(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!): [AzureNativeSubnet!]!
        internal void InitQueryAllAzureNativeSubnetsByRegionFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("region", "AzureNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeSubnetsByRegionFromAzure",
                "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!)",
                "List<AzureNativeSubnet>",
                Query.AllAzureNativeSubnetsByRegionFromAzure_ObjectFieldSpec,
                Query.AllAzureNativeSubnetsByRegionFromAzureFieldSpec,
                @"# REQUIRED
$query.Var.azureSubscriptionRubrikId = $someString
# REQUIRED
$query.Var.region = $someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // azureNativeSubscription(azureSubscriptionRubrikId: UUID!): AzureNativeSubscription!
        internal void InitQueryAzureNativeSubscription()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeSubscription",
                "($azureSubscriptionRubrikId: UUID!)",
                "AzureNativeSubscription",
                Query.AzureNativeSubscription_ObjectFieldSpec,
                Query.AzureNativeSubscriptionFieldSpec,
                @"# REQUIRED
$query.Var.azureSubscriptionRubrikId = $someString"
            );
        }

        // Create new GraphQL Query:
        // azureNativeSubscriptions(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AzureNativeSubscriptionSortFields
        //     sortOrder: SortOrder
        //     subscriptionFilters: AzureNativeSubscriptionFilters
        //     authorizedOperationFilter: Operation
        //     workloadHierarchy: WorkloadLevelHierarchy
        //     azureNativeProtectionFeature: AzureNativeProtectionFeature
        //   ): AzureNativeSubscriptionConnection!
        internal void InitQueryAzureNativeSubscriptions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AzureNativeSubscriptionSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("subscriptionFilters", "AzureNativeSubscriptionFilters"),
                Tuple.Create("authorizedOperationFilter", "Operation"),
                Tuple.Create("workloadHierarchy", "WorkloadLevelHierarchy"),
                Tuple.Create("azureNativeProtectionFeature", "AzureNativeProtectionFeature"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeSubscriptions",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureNativeSubscriptionSortFields,$sortOrder: SortOrder,$subscriptionFilters: AzureNativeSubscriptionFilters,$authorizedOperationFilter: Operation,$workloadHierarchy: WorkloadLevelHierarchy,$azureNativeProtectionFeature: AzureNativeProtectionFeature)",
                "AzureNativeSubscriptionConnection",
                Query.AzureNativeSubscriptions_ObjectFieldSpec,
                Query.AzureNativeSubscriptionsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someAzureNativeSubscriptionSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeSubscriptionSortFields]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.subscriptionFilters = @{
	# OPTIONAL
	nameSubstringFilter = @{
		# REQUIRED
		nameSubstring = $someString
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			$someString
		)
	}
}
# OPTIONAL
$query.Var.authorizedOperationFilter = $someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
# OPTIONAL
$query.Var.workloadHierarchy = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
# OPTIONAL
$query.Var.azureNativeProtectionFeature = $someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // validateAzureNativeSqlDatabaseDbNameForExport(azureSqlDatabaseName: String!, azureSqlDatabaseServerRubrikId: UUID!): ValidateAzureNativeSqlDatabaseDbNameForExportReply!
        internal void InitQueryValidateAzureNativeSqlDatabaseDbNameForExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlDatabaseName", "String!"),
                Tuple.Create("azureSqlDatabaseServerRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryValidateAzureNativeSqlDatabaseDbNameForExport",
                "($azureSqlDatabaseName: String!,$azureSqlDatabaseServerRubrikId: UUID!)",
                "ValidateAzureNativeSqlDatabaseDbNameForExportReply",
                Query.ValidateAzureNativeSqlDatabaseDbNameForExport_ObjectFieldSpec,
                Query.ValidateAzureNativeSqlDatabaseDbNameForExportFieldSpec,
                @"# REQUIRED
$query.Var.azureSqlDatabaseName = $someString
# REQUIRED
$query.Var.azureSqlDatabaseServerRubrikId = $someString"
            );
        }

        // Create new GraphQL Query:
        // validateAzureNativeSqlManagedInstanceDbNameForExport(azureSqlDatabaseName: String!, azureSqlManagedInstanceServerRubrikId: UUID!): ValidateAzureNativeSqlManagedInstanceDbNameForExportReply!
        internal void InitQueryValidateAzureNativeSqlManagedInstanceDbNameForExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlDatabaseName", "String!"),
                Tuple.Create("azureSqlManagedInstanceServerRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryValidateAzureNativeSqlManagedInstanceDbNameForExport",
                "($azureSqlDatabaseName: String!,$azureSqlManagedInstanceServerRubrikId: UUID!)",
                "ValidateAzureNativeSqlManagedInstanceDbNameForExportReply",
                Query.ValidateAzureNativeSqlManagedInstanceDbNameForExport_ObjectFieldSpec,
                Query.ValidateAzureNativeSqlManagedInstanceDbNameForExportFieldSpec,
                @"# REQUIRED
$query.Var.azureSqlDatabaseName = $someString
# REQUIRED
$query.Var.azureSqlManagedInstanceServerRubrikId = $someString"
            );
        }

        // Create new GraphQL Query:
        // azureNativeVirtualMachine(azureVirtualMachineRubrikId: UUID!): AzureNativeVirtualMachine!
        internal void InitQueryAzureNativeVirtualMachine()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureVirtualMachineRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeVirtualMachine",
                "($azureVirtualMachineRubrikId: UUID!)",
                "AzureNativeVirtualMachine",
                Query.AzureNativeVirtualMachine_ObjectFieldSpec,
                Query.AzureNativeVirtualMachineFieldSpec,
                @"# REQUIRED
$query.Var.azureVirtualMachineRubrikId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allAzureNativeVirtualMachineSizes(azureSubscriptionRubrikId: UUID): [String!]!
        internal void InitQueryAllAzureNativeVirtualMachineSizes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeVirtualMachineSizes",
                "($azureSubscriptionRubrikId: UUID)",
                "List<System.String>",
                Query.AllAzureNativeVirtualMachineSizes_ObjectFieldSpec,
                Query.AllAzureNativeVirtualMachineSizesFieldSpec,
                @"# OPTIONAL
$query.Var.azureSubscriptionRubrikId = $someString"
            );
        }

        // Create new GraphQL Query:
        // azureNativeVirtualMachines(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AzureNativeVirtualMachineSortFields
        //     sortOrder: SortOrder
        //     descendantTypeFilter: [HierarchyObjectTypeEnum!]
        //     virtualMachineFilters: AzureNativeVirtualMachineFilters
        //   ): AzureNativeVirtualMachineConnection!
        internal void InitQueryAzureNativeVirtualMachines()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AzureNativeVirtualMachineSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("descendantTypeFilter", "[HierarchyObjectTypeEnum!]"),
                Tuple.Create("virtualMachineFilters", "AzureNativeVirtualMachineFilters"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeVirtualMachines",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureNativeVirtualMachineSortFields,$sortOrder: SortOrder,$descendantTypeFilter: [HierarchyObjectTypeEnum!],$virtualMachineFilters: AzureNativeVirtualMachineFilters)",
                "AzureNativeVirtualMachineConnection",
                Query.AzureNativeVirtualMachines_ObjectFieldSpec,
                Query.AzureNativeVirtualMachinesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someAzureNativeVirtualMachineSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeVirtualMachineSortFields]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.descendantTypeFilter = @(
	$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
)
# OPTIONAL
$query.Var.virtualMachineFilters = @{
	# OPTIONAL
	nameSubstringFilter = @{
		# REQUIRED
		nameSubstring = $someString
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			$someString
		)
	}
	# OPTIONAL
	resourceGroupFilter = @{
		# REQUIRED
		resourceGroupNames = @(
			$someString
		)
	}
	# OPTIONAL
	subscriptionFilter = @{
		# REQUIRED
		subscriptionIds = @(
			$someString
		)
	}
	# OPTIONAL
	regionFilter = @{
		# REQUIRED
		regions = @(
			$someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
		)
	}
	# OPTIONAL
	vmSizeFilter = @{
		# REQUIRED
		vmSizes = @(
			$someString
		)
	}
	# OPTIONAL
	vnetFilter = @{
		# REQUIRED
		vnetNames = @(
			$someString
		)
	}
	# OPTIONAL
	relicFilter = @{
		# REQUIRED
		relic = $someBoolean
	}
	# OPTIONAL
	tagFilter = @{
		# REQUIRED
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
	}
	# OPTIONAL
	exocomputeConnectedFilter = @{
		# REQUIRED
		isConnected = $someBoolean
	}
	# OPTIONAL
	fileIndexingFilter = @{
		# REQUIRED
		statuses = @(
			$someAzureNativeFileIndexingStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeFileIndexingStatus]) for enum values.
		)
	}
	# OPTIONAL
	appProtectionStatusFilter = @{
		# REQUIRED
		isProtectionSetup = $someBoolean
	}
	# OPTIONAL
	rbsStatusFilter = @{
		# REQUIRED
		status = $someCloudInstanceRbsConnectionStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudInstanceRbsConnectionStatus]) for enum values.
	}
}"
            );
        }

        // Create new GraphQL Query:
        // allAzureNativeVirtualNetworks(azureSubscriptionRubrikId: UUID): [AzureNativeVirtualNetwork!]!
        internal void InitQueryAllAzureNativeVirtualNetworks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeVirtualNetworks",
                "($azureSubscriptionRubrikId: UUID)",
                "List<AzureNativeVirtualNetwork>",
                Query.AllAzureNativeVirtualNetworks_ObjectFieldSpec,
                Query.AllAzureNativeVirtualNetworksFieldSpec,
                @"# OPTIONAL
$query.Var.azureSubscriptionRubrikId = $someString"
            );
        }


    } // class New_RscQueryAzureNative
}