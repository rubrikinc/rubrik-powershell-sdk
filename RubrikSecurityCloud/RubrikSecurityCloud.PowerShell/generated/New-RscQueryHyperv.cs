// New-RscQueryHyperv.cs
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
    /// Create a new RscQuery object for any of the 16
    /// operations in the 'Microsoft Hyper-V' API domain:
    /// Cluster, HostAsyncRequestStatus, Mounts, Scvmm, ScvmmAsyncRequestStatus, Scvmms, Server, Servers, ServersPaginated, TopLevelDescendants, UniqueServersCount, VirtualMachine, VirtualMachineAsyncRequestStatus, VirtualMachineLevelFileInfo, VirtualMachines, or VmDetail.
    /// </summary>
    /// <description>
    /// New-RscQueryHyperv creates a new
    /// query object for operations
    /// in the 'Microsoft Hyper-V' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 16 operations
    /// in the 'Microsoft Hyper-V' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: Cluster, HostAsyncRequestStatus, Mounts, Scvmm, ScvmmAsyncRequestStatus, Scvmms, Server, Servers, ServersPaginated, TopLevelDescendants, UniqueServersCount, VirtualMachine, VirtualMachineAsyncRequestStatus, VirtualMachineLevelFileInfo, VirtualMachines, or VmDetail.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryHyperv -Cluster).Info().
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
    /// (New-RscQueryHyperv -Cluster).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the Cluster operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: Cluster
    /// 
    /// $query = New-RscQueryHyperv -Cluster
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: HyperVcluster
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the HostAsyncRequestStatus operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: HostAsyncRequestStatus
    /// 
    /// $query = New-RscQueryHyperv -HostAsyncRequestStatus
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
    /// Runs the Mounts operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: Mounts
    /// 
    /// $query = New-RscQueryHyperv -Mounts
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.filters = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someHypervLiveMountFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HypervLiveMountFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.sortBy = @{
    /// 	# OPTIONAL
    /// 	field = $someHypervLiveMountSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HypervLiveMountSortByField]) for enum values.
    /// 	# OPTIONAL
    /// 	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: HyperVliveMountConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Scvmm operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: Scvmm
    /// 
    /// $query = New-RscQueryHyperv -Scvmm
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: HyperVscvmm
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ScvmmAsyncRequestStatus operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: ScvmmAsyncRequestStatus
    /// 
    /// $query = New-RscQueryHyperv -ScvmmAsyncRequestStatus
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
    /// Runs the Scvmms operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: Scvmms
    /// 
    /// $query = New-RscQueryHyperv -Scvmms
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
    /// Write-Host $result.GetType().Name # prints: HyperVscvmmConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Server operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: Server
    /// 
    /// $query = New-RscQueryHyperv -Server
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: HypervServer
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Servers operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: Servers
    /// 
    /// $query = New-RscQueryHyperv -Servers
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	effectiveSlaDomainId = $someString
    /// 	# OPTIONAL
    /// 	limit = $someInt
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	offset = $someInt
    /// 	# OPTIONAL
    /// 	primaryClusterId = $someString
    /// 	# OPTIONAL
    /// 	slaAssignment = $someInternalQueryHypervHostRequestSlaAssignment # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InternalQueryHypervHostRequestSlaAssignment]) for enum values.
    /// 	# OPTIONAL
    /// 	sortBy = $someInternalQueryHypervHostRequestSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InternalQueryHypervHostRequestSortBy]) for enum values.
    /// 	# OPTIONAL
    /// 	sortOrder = $someInternalQueryHypervHostRequestSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InternalQueryHypervHostRequestSortOrder]) for enum values.
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: HypervHostSummaryListResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ServersPaginated operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: ServersPaginated
    /// 
    /// $query = New-RscQueryHyperv -ServersPaginated
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
    /// Write-Host $result.GetType().Name # prints: HypervServerConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TopLevelDescendants operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: TopLevelDescendants
    /// 
    /// $query = New-RscQueryHyperv -TopLevelDescendants
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
    /// $query.Var.typeFilter = @(
    /// 	$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
    /// )
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
    /// Write-Host $result.GetType().Name # prints: HypervTopLevelDescendantTypeConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UniqueServersCount operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: UniqueServersCount
    /// 
    /// $query = New-RscQueryHyperv -UniqueServersCount
    /// 
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
    /// Write-Host $result.GetType().Name # prints: System.Int32
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the VirtualMachine operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: VirtualMachine
    /// 
    /// $query = New-RscQueryHyperv -VirtualMachine
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: HyperVvirtualMachine
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the VirtualMachineAsyncRequestStatus operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: VirtualMachineAsyncRequestStatus
    /// 
    /// $query = New-RscQueryHyperv -VirtualMachineAsyncRequestStatus
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
    /// Runs the VirtualMachineLevelFileInfo operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: VirtualMachineLevelFileInfo
    /// 
    /// $query = New-RscQueryHyperv -VirtualMachineLevelFileInfo
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	shouldRetrieveConfigFiles = $someBoolean
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: HypervVirtualMachineSnapshotFileDetails
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the VirtualMachines operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: VirtualMachines
    /// 
    /// $query = New-RscQueryHyperv -VirtualMachines
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
    /// Write-Host $result.GetType().Name # prints: HyperVvirtualMachineConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the VmDetail operation
    /// of the 'Microsoft Hyper-V' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Hyperv
    /// # API Operation: VmDetail
    /// 
    /// $query = New-RscQueryHyperv -VmDetail
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
    /// Write-Host $result.GetType().Name # prints: HypervVirtualMachineDetail
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
        "RscQueryHyperv",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryHyperv : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "Cluster",
                "HostAsyncRequestStatus",
                "Mounts",
                "Scvmm",
                "ScvmmAsyncRequestStatus",
                "Scvmms",
                "Server",
                "Servers",
                "ServersPaginated",
                "TopLevelDescendants",
                "UniqueServersCount",
                "VirtualMachine",
                "VirtualMachineAsyncRequestStatus",
                "VirtualMachineLevelFileInfo",
                "VirtualMachines",
                "VmDetail",
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
                    case "Cluster":
                        this.ProcessRecord_Cluster();
                        break;
                    case "HostAsyncRequestStatus":
                        this.ProcessRecord_HostAsyncRequestStatus();
                        break;
                    case "Mounts":
                        this.ProcessRecord_Mounts();
                        break;
                    case "Scvmm":
                        this.ProcessRecord_Scvmm();
                        break;
                    case "ScvmmAsyncRequestStatus":
                        this.ProcessRecord_ScvmmAsyncRequestStatus();
                        break;
                    case "Scvmms":
                        this.ProcessRecord_Scvmms();
                        break;
                    case "Server":
                        this.ProcessRecord_Server();
                        break;
                    case "Servers":
                        this.ProcessRecord_Servers();
                        break;
                    case "ServersPaginated":
                        this.ProcessRecord_ServersPaginated();
                        break;
                    case "TopLevelDescendants":
                        this.ProcessRecord_TopLevelDescendants();
                        break;
                    case "UniqueServersCount":
                        this.ProcessRecord_UniqueServersCount();
                        break;
                    case "VirtualMachine":
                        this.ProcessRecord_VirtualMachine();
                        break;
                    case "VirtualMachineAsyncRequestStatus":
                        this.ProcessRecord_VirtualMachineAsyncRequestStatus();
                        break;
                    case "VirtualMachineLevelFileInfo":
                        this.ProcessRecord_VirtualMachineLevelFileInfo();
                        break;
                    case "VirtualMachines":
                        this.ProcessRecord_VirtualMachines();
                        break;
                    case "VmDetail":
                        this.ProcessRecord_VmDetail();
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
        // hypervCluster.
        internal void ProcessRecord_Cluster()
        {
            this._logger.name += " -Cluster";
            // Create new graphql operation hypervCluster
            InitQueryHypervCluster();
        }

        // This parameter set invokes a single graphql operation:
        // hypervHostAsyncRequestStatus.
        internal void ProcessRecord_HostAsyncRequestStatus()
        {
            this._logger.name += " -HostAsyncRequestStatus";
            // Create new graphql operation hypervHostAsyncRequestStatus
            InitQueryHypervHostAsyncRequestStatus();
        }

        // This parameter set invokes a single graphql operation:
        // hypervMounts.
        internal void ProcessRecord_Mounts()
        {
            this._logger.name += " -Mounts";
            // Create new graphql operation hypervMounts
            InitQueryHypervMounts();
        }

        // This parameter set invokes a single graphql operation:
        // hypervScvmm.
        internal void ProcessRecord_Scvmm()
        {
            this._logger.name += " -Scvmm";
            // Create new graphql operation hypervScvmm
            InitQueryHypervScvmm();
        }

        // This parameter set invokes a single graphql operation:
        // hypervScvmmAsyncRequestStatus.
        internal void ProcessRecord_ScvmmAsyncRequestStatus()
        {
            this._logger.name += " -ScvmmAsyncRequestStatus";
            // Create new graphql operation hypervScvmmAsyncRequestStatus
            InitQueryHypervScvmmAsyncRequestStatus();
        }

        // This parameter set invokes a single graphql operation:
        // hypervScvmms.
        internal void ProcessRecord_Scvmms()
        {
            this._logger.name += " -Scvmms";
            // Create new graphql operation hypervScvmms
            InitQueryHypervScvmms();
        }

        // This parameter set invokes a single graphql operation:
        // hypervServer.
        internal void ProcessRecord_Server()
        {
            this._logger.name += " -Server";
            // Create new graphql operation hypervServer
            InitQueryHypervServer();
        }

        // This parameter set invokes a single graphql operation:
        // hypervServers.
        internal void ProcessRecord_Servers()
        {
            this._logger.name += " -Servers";
            // Create new graphql operation hypervServers
            InitQueryHypervServers();
        }

        // This parameter set invokes a single graphql operation:
        // hypervServersPaginated.
        internal void ProcessRecord_ServersPaginated()
        {
            this._logger.name += " -ServersPaginated";
            // Create new graphql operation hypervServersPaginated
            InitQueryHypervServersPaginated();
        }

        // This parameter set invokes a single graphql operation:
        // hypervTopLevelDescendants.
        internal void ProcessRecord_TopLevelDescendants()
        {
            this._logger.name += " -TopLevelDescendants";
            // Create new graphql operation hypervTopLevelDescendants
            InitQueryHypervTopLevelDescendants();
        }

        // This parameter set invokes a single graphql operation:
        // uniqueHypervServersCount.
        internal void ProcessRecord_UniqueServersCount()
        {
            this._logger.name += " -UniqueServersCount";
            // Create new graphql operation uniqueHypervServersCount
            InitQueryUniqueHypervServersCount();
        }

        // This parameter set invokes a single graphql operation:
        // hypervVirtualMachine.
        internal void ProcessRecord_VirtualMachine()
        {
            this._logger.name += " -VirtualMachine";
            // Create new graphql operation hypervVirtualMachine
            InitQueryHypervVirtualMachine();
        }

        // This parameter set invokes a single graphql operation:
        // hypervVirtualMachineAsyncRequestStatus.
        internal void ProcessRecord_VirtualMachineAsyncRequestStatus()
        {
            this._logger.name += " -VirtualMachineAsyncRequestStatus";
            // Create new graphql operation hypervVirtualMachineAsyncRequestStatus
            InitQueryHypervVirtualMachineAsyncRequestStatus();
        }

        // This parameter set invokes a single graphql operation:
        // hypervVirtualMachineLevelFileInfo.
        internal void ProcessRecord_VirtualMachineLevelFileInfo()
        {
            this._logger.name += " -VirtualMachineLevelFileInfo";
            // Create new graphql operation hypervVirtualMachineLevelFileInfo
            InitQueryHypervVirtualMachineLevelFileInfo();
        }

        // This parameter set invokes a single graphql operation:
        // hypervVirtualMachines.
        internal void ProcessRecord_VirtualMachines()
        {
            this._logger.name += " -VirtualMachines";
            // Create new graphql operation hypervVirtualMachines
            InitQueryHypervVirtualMachines();
        }

        // This parameter set invokes a single graphql operation:
        // hypervVmDetail.
        internal void ProcessRecord_VmDetail()
        {
            this._logger.name += " -VmDetail";
            // Create new graphql operation hypervVmDetail
            InitQueryHypervVmDetail();
        }


        // Create new GraphQL Query:
        // hypervCluster(fid: UUID!): HyperVCluster!
        internal void InitQueryHypervCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervCluster",
                "($fid: UUID!)",
                "HyperVcluster",
                Query.HypervCluster_ObjectFieldSpec,
                Query.HypervClusterFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // hypervHostAsyncRequestStatus(input: GetHypervHostAsyncRequestStatusInput!): AsyncRequestStatus!
        internal void InitQueryHypervHostAsyncRequestStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHypervHostAsyncRequestStatusInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervHostAsyncRequestStatus",
                "($input: GetHypervHostAsyncRequestStatusInput!)",
                "AsyncRequestStatus",
                Query.HypervHostAsyncRequestStatus_ObjectFieldSpec,
                Query.HypervHostAsyncRequestStatusFieldSpec,
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
        // hypervMounts(
        //     first: Int
        //     after: String
        //     filters: [HypervLiveMountFilterInput!]
        //     sortBy: HypervLiveMountSortByInput
        //   ): HyperVLiveMountConnection!
        internal void InitQueryHypervMounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("filters", "[HypervLiveMountFilterInput!]"),
                Tuple.Create("sortBy", "HypervLiveMountSortByInput"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervMounts",
                "($first: Int,$after: String,$filters: [HypervLiveMountFilterInput!],$sortBy: HypervLiveMountSortByInput)",
                "HyperVliveMountConnection",
                Query.HypervMounts_ObjectFieldSpec,
                Query.HypervMountsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.filters = @(
	@{
		# OPTIONAL
		field = $someHypervLiveMountFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HypervLiveMountFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
}
)
# OPTIONAL
$query.Var.sortBy = @{
	# OPTIONAL
	field = $someHypervLiveMountSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HypervLiveMountSortByField]) for enum values.
	# OPTIONAL
	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}"
            );
        }

        // Create new GraphQL Query:
        // hypervScvmm(fid: UUID!): HyperVSCVMM!
        internal void InitQueryHypervScvmm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervScvmm",
                "($fid: UUID!)",
                "HyperVscvmm",
                Query.HypervScvmm_ObjectFieldSpec,
                Query.HypervScvmmFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // hypervScvmmAsyncRequestStatus(input: GetHypervScvmmAsyncRequestStatusInput!): AsyncRequestStatus!
        internal void InitQueryHypervScvmmAsyncRequestStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHypervScvmmAsyncRequestStatusInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervScvmmAsyncRequestStatus",
                "($input: GetHypervScvmmAsyncRequestStatusInput!)",
                "AsyncRequestStatus",
                Query.HypervScvmmAsyncRequestStatus_ObjectFieldSpec,
                Query.HypervScvmmAsyncRequestStatusFieldSpec,
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
        // hypervScvmms(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): HyperVSCVMMConnection!
        internal void InitQueryHypervScvmms()
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
                "QueryHypervScvmms",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "HyperVscvmmConnection",
                Query.HypervScvmms_ObjectFieldSpec,
                Query.HypervScvmmsFieldSpec,
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
        // hypervServer(fid: UUID!): HypervServer!
        internal void InitQueryHypervServer()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervServer",
                "($fid: UUID!)",
                "HypervServer",
                Query.HypervServer_ObjectFieldSpec,
                Query.HypervServerFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // hypervServers(input: QueryHypervHostInput!): HypervHostSummaryListResponse!
        internal void InitQueryHypervServers()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryHypervHostInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervServers",
                "($input: QueryHypervHostInput!)",
                "HypervHostSummaryListResponse",
                Query.HypervServers_ObjectFieldSpec,
                Query.HypervServersFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	effectiveSlaDomainId = $someString
	# OPTIONAL
	limit = $someInt
	# OPTIONAL
	name = $someString
	# OPTIONAL
	offset = $someInt
	# OPTIONAL
	primaryClusterId = $someString
	# OPTIONAL
	slaAssignment = $someInternalQueryHypervHostRequestSlaAssignment # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InternalQueryHypervHostRequestSlaAssignment]) for enum values.
	# OPTIONAL
	sortBy = $someInternalQueryHypervHostRequestSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InternalQueryHypervHostRequestSortBy]) for enum values.
	# OPTIONAL
	sortOrder = $someInternalQueryHypervHostRequestSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InternalQueryHypervHostRequestSortOrder]) for enum values.
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // hypervServersPaginated(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): HypervServerConnection!
        internal void InitQueryHypervServersPaginated()
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
                "QueryHypervServersPaginated",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "HypervServerConnection",
                Query.HypervServersPaginated_ObjectFieldSpec,
                Query.HypervServersPaginatedFieldSpec,
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
        // hypervTopLevelDescendants(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     typeFilter: [HierarchyObjectTypeEnum!]
        //     filter: [Filter!]
        //   ): HypervTopLevelDescendantTypeConnection!
        internal void InitQueryHypervTopLevelDescendants()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("typeFilter", "[HierarchyObjectTypeEnum!]"),
                Tuple.Create("filter", "[Filter!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervTopLevelDescendants",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$typeFilter: [HierarchyObjectTypeEnum!],$filter: [Filter!])",
                "HypervTopLevelDescendantTypeConnection",
                Query.HypervTopLevelDescendants_ObjectFieldSpec,
                Query.HypervTopLevelDescendantsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.sortBy = $someHierarchySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.typeFilter = @(
	$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
)
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
        // uniqueHypervServersCount(filter: [Filter!]): Int!
        internal void InitQueryUniqueHypervServersCount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("filter", "[Filter!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryUniqueHypervServersCount",
                "($filter: [Filter!])",
                "System.Int32",
                Query.UniqueHypervServersCount_ObjectFieldSpec,
                Query.UniqueHypervServersCountFieldSpec,
                @"# OPTIONAL
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
        // hypervVirtualMachine(fid: UUID!): HyperVVirtualMachine!
        internal void InitQueryHypervVirtualMachine()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervVirtualMachine",
                "($fid: UUID!)",
                "HyperVvirtualMachine",
                Query.HypervVirtualMachine_ObjectFieldSpec,
                Query.HypervVirtualMachineFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // hypervVirtualMachineAsyncRequestStatus(input: GetHypervVirtualMachineAsyncRequestStatusInput!): AsyncRequestStatus!
        internal void InitQueryHypervVirtualMachineAsyncRequestStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHypervVirtualMachineAsyncRequestStatusInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervVirtualMachineAsyncRequestStatus",
                "($input: GetHypervVirtualMachineAsyncRequestStatusInput!)",
                "AsyncRequestStatus",
                Query.HypervVirtualMachineAsyncRequestStatus_ObjectFieldSpec,
                Query.HypervVirtualMachineAsyncRequestStatusFieldSpec,
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
        // hypervVirtualMachineLevelFileInfo(input: GetVmLevelFilesFromSnapshotInput!): HypervVirtualMachineSnapshotFileDetails!
        internal void InitQueryHypervVirtualMachineLevelFileInfo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetVmLevelFilesFromSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervVirtualMachineLevelFileInfo",
                "($input: GetVmLevelFilesFromSnapshotInput!)",
                "HypervVirtualMachineSnapshotFileDetails",
                Query.HypervVirtualMachineLevelFileInfo_ObjectFieldSpec,
                Query.HypervVirtualMachineLevelFileInfoFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	shouldRetrieveConfigFiles = $someBoolean
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // hypervVirtualMachines(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): HyperVVirtualMachineConnection!
        internal void InitQueryHypervVirtualMachines()
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
                "QueryHypervVirtualMachines",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "HyperVvirtualMachineConnection",
                Query.HypervVirtualMachines_ObjectFieldSpec,
                Query.HypervVirtualMachinesFieldSpec,
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
        // hypervVmDetail(input: GetHypervVirtualMachineInput!): HypervVirtualMachineDetail!
        internal void InitQueryHypervVmDetail()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHypervVirtualMachineInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervVmDetail",
                "($input: GetHypervVirtualMachineInput!)",
                "HypervVirtualMachineDetail",
                Query.HypervVmDetail_ObjectFieldSpec,
                Query.HypervVmDetailFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }


    } // class New_RscQueryHyperv
}