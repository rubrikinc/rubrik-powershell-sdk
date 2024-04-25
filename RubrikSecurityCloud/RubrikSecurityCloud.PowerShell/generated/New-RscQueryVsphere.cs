// New-RscQueryVsphere.cs
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
    /// operations in the 'VMware vSphere' API domain:
    /// ComputeCluster, ComputeClusters, Datacenter, Datastore, DatastoreCluster, DatastoreClusters, DatastoreList, Folder, Folders, Host, HostDetails, HostList, HostsByFids, LiveMounts, Mount, MountList, Network, ResourcePool, RootRecoveryHierarchy, Tag, TagCategory, TopLevelDescendantsList, or VmwareCdpLiveInfo.
    /// </summary>
    /// <description>
    /// New-RscQueryVsphere creates a new
    /// query object for operations
    /// in the 'VMware vSphere' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 23 operations
    /// in the 'VMware vSphere' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: ComputeCluster, ComputeClusters, Datacenter, Datastore, DatastoreCluster, DatastoreClusters, DatastoreList, Folder, Folders, Host, HostDetails, HostList, HostsByFids, LiveMounts, Mount, MountList, Network, ResourcePool, RootRecoveryHierarchy, Tag, TagCategory, TopLevelDescendantsList, or VmwareCdpLiveInfo.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryVsphere -ComputeCluster).Info().
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
    /// (New-RscQueryVsphere -ComputeCluster).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the ComputeCluster operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: ComputeCluster
    /// 
    /// $query = New-RscQueryVsphere -ComputeCluster
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VsphereComputeCluster
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ComputeClusters operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: ComputeClusters
    /// 
    /// $query = New-RscQueryVsphere -ComputeClusters
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
    /// Write-Host $result.GetType().Name # prints: VsphereComputeClusterConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Datacenter operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: Datacenter
    /// 
    /// $query = New-RscQueryVsphere -Datacenter
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VsphereDatacenter
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Datastore operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: Datastore
    /// 
    /// $query = New-RscQueryVsphere -Datastore
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VsphereDatastore
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DatastoreCluster operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: DatastoreCluster
    /// 
    /// $query = New-RscQueryVsphere -DatastoreCluster
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VsphereDatastoreCluster
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DatastoreClusters operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: DatastoreClusters
    /// 
    /// $query = New-RscQueryVsphere -DatastoreClusters
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
    /// Write-Host $result.GetType().Name # prints: VsphereDatastoreClusterConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DatastoreList operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: DatastoreList
    /// 
    /// $query = New-RscQueryVsphere -DatastoreList
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
    /// Write-Host $result.GetType().Name # prints: VsphereDatastoreConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Folder operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: Folder
    /// 
    /// $query = New-RscQueryVsphere -Folder
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VsphereFolder
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Folders operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: Folders
    /// 
    /// $query = New-RscQueryVsphere -Folders
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
    /// Write-Host $result.GetType().Name # prints: VsphereFolderConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Host operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: Host
    /// 
    /// $query = New-RscQueryVsphere -Host
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VsphereHost
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the HostDetails operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: HostDetails
    /// 
    /// $query = New-RscQueryVsphere -HostDetails
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
    /// Write-Host $result.GetType().Name # prints: VmwareHostDetail
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the HostList operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: HostList
    /// 
    /// $query = New-RscQueryVsphere -HostList
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
    /// Write-Host $result.GetType().Name # prints: VsphereHostConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the HostsByFids operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: HostsByFids
    /// 
    /// $query = New-RscQueryVsphere -HostsByFids
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
    /// Write-Host $result.GetType().Name # prints: List&lt;VsphereHost&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the LiveMounts operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: LiveMounts
    /// 
    /// $query = New-RscQueryVsphere -LiveMounts
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someVsphereLiveMountFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VsphereLiveMountFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.sortBy = @{
    /// 	# OPTIONAL
    /// 	field = $someVsphereLiveMountSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VsphereLiveMountSortByField]) for enum values.
    /// 	# OPTIONAL
    /// 	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VsphereLiveMountConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Mount operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: Mount
    /// 
    /// $query = New-RscQueryVsphere -Mount
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VsphereMount
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MountList operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: MountList
    /// 
    /// $query = New-RscQueryVsphere -MountList
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	clusterUuid = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	powerStatus = @(
    /// 		$someBoolean
    /// 	)
    /// 	# OPTIONAL
    /// 	sourceVmId = $someString
    /// }
    /// # OPTIONAL
    /// $query.Var.sortBy = $someVsphereMountSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VsphereMountSortBy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VsphereMountConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Network operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: Network
    /// 
    /// $query = New-RscQueryVsphere -Network
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VsphereNetwork
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ResourcePool operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: ResourcePool
    /// 
    /// $query = New-RscQueryVsphere -ResourcePool
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VsphereResourcePool
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RootRecoveryHierarchy operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: RootRecoveryHierarchy
    /// 
    /// $query = New-RscQueryVsphere -RootRecoveryHierarchy
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
    /// Write-Host $result.GetType().Name # prints: CdmHierarchyObjectConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Tag operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: Tag
    /// 
    /// $query = New-RscQueryVsphere -Tag
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VsphereTag
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TagCategory operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: TagCategory
    /// 
    /// $query = New-RscQueryVsphere -TagCategory
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VsphereTagCategory
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TopLevelDescendantsList operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: TopLevelDescendantsList
    /// 
    /// $query = New-RscQueryVsphere -TopLevelDescendantsList
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
    /// Write-Host $result.GetType().Name # prints: CdmHierarchyObjectConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the VmwareCdpLiveInfo operation
    /// of the 'VMware vSphere' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Vsphere
    /// # API Operation: VmwareCdpLiveInfo
    /// 
    /// $query = New-RscQueryVsphere -VmwareCdpLiveInfo
    /// 
    /// # REQUIRED
    /// $query.Var.ids = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchVmwareCdpLiveInfo
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
        "RscQueryVsphere",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryVsphere : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "ComputeCluster",
                "ComputeClusters",
                "Datacenter",
                "Datastore",
                "DatastoreCluster",
                "DatastoreClusters",
                "DatastoreList",
                "Folder",
                "Folders",
                "Host",
                "HostDetails",
                "HostList",
                "HostsByFids",
                "LiveMounts",
                "Mount",
                "MountList",
                "Network",
                "ResourcePool",
                "RootRecoveryHierarchy",
                "Tag",
                "TagCategory",
                "TopLevelDescendantsList",
                "VmwareCdpLiveInfo",
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
                    case "ComputeCluster":
                        this.ProcessRecord_ComputeCluster();
                        break;
                    case "ComputeClusters":
                        this.ProcessRecord_ComputeClusters();
                        break;
                    case "Datacenter":
                        this.ProcessRecord_Datacenter();
                        break;
                    case "Datastore":
                        this.ProcessRecord_Datastore();
                        break;
                    case "DatastoreCluster":
                        this.ProcessRecord_DatastoreCluster();
                        break;
                    case "DatastoreClusters":
                        this.ProcessRecord_DatastoreClusters();
                        break;
                    case "DatastoreList":
                        this.ProcessRecord_DatastoreList();
                        break;
                    case "Folder":
                        this.ProcessRecord_Folder();
                        break;
                    case "Folders":
                        this.ProcessRecord_Folders();
                        break;
                    case "Host":
                        this.ProcessRecord_Host();
                        break;
                    case "HostDetails":
                        this.ProcessRecord_HostDetails();
                        break;
                    case "HostList":
                        this.ProcessRecord_HostList();
                        break;
                    case "HostsByFids":
                        this.ProcessRecord_HostsByFids();
                        break;
                    case "LiveMounts":
                        this.ProcessRecord_LiveMounts();
                        break;
                    case "Mount":
                        this.ProcessRecord_Mount();
                        break;
                    case "MountList":
                        this.ProcessRecord_MountList();
                        break;
                    case "Network":
                        this.ProcessRecord_Network();
                        break;
                    case "ResourcePool":
                        this.ProcessRecord_ResourcePool();
                        break;
                    case "RootRecoveryHierarchy":
                        this.ProcessRecord_RootRecoveryHierarchy();
                        break;
                    case "Tag":
                        this.ProcessRecord_Tag();
                        break;
                    case "TagCategory":
                        this.ProcessRecord_TagCategory();
                        break;
                    case "TopLevelDescendantsList":
                        this.ProcessRecord_TopLevelDescendantsList();
                        break;
                    case "VmwareCdpLiveInfo":
                        this.ProcessRecord_VmwareCdpLiveInfo();
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
        // vSphereComputeCluster.
        internal void ProcessRecord_ComputeCluster()
        {
            this._logger.name += " -ComputeCluster";
            // Create new graphql operation vSphereComputeCluster
            InitQueryVsphereComputeCluster();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereComputeClusters.
        internal void ProcessRecord_ComputeClusters()
        {
            this._logger.name += " -ComputeClusters";
            // Create new graphql operation vSphereComputeClusters
            InitQueryVsphereComputeClusters();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereDatacenter.
        internal void ProcessRecord_Datacenter()
        {
            this._logger.name += " -Datacenter";
            // Create new graphql operation vSphereDatacenter
            InitQueryVsphereDatacenter();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereDatastore.
        internal void ProcessRecord_Datastore()
        {
            this._logger.name += " -Datastore";
            // Create new graphql operation vSphereDatastore
            InitQueryVsphereDatastore();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereDatastoreCluster.
        internal void ProcessRecord_DatastoreCluster()
        {
            this._logger.name += " -DatastoreCluster";
            // Create new graphql operation vSphereDatastoreCluster
            InitQueryVsphereDatastoreCluster();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereDatastoreClusters.
        internal void ProcessRecord_DatastoreClusters()
        {
            this._logger.name += " -DatastoreClusters";
            // Create new graphql operation vSphereDatastoreClusters
            InitQueryVsphereDatastoreClusters();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereDatastoreConnection.
        internal void ProcessRecord_DatastoreList()
        {
            this._logger.name += " -DatastoreList";
            // Create new graphql operation vSphereDatastoreConnection
            InitQueryVsphereDatastoreConnection();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereFolder.
        internal void ProcessRecord_Folder()
        {
            this._logger.name += " -Folder";
            // Create new graphql operation vSphereFolder
            InitQueryVsphereFolder();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereFolders.
        internal void ProcessRecord_Folders()
        {
            this._logger.name += " -Folders";
            // Create new graphql operation vSphereFolders
            InitQueryVsphereFolders();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereHost.
        internal void ProcessRecord_Host()
        {
            this._logger.name += " -Host";
            // Create new graphql operation vSphereHost
            InitQueryVsphereHost();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereHostDetails.
        internal void ProcessRecord_HostDetails()
        {
            this._logger.name += " -HostDetails";
            // Create new graphql operation vSphereHostDetails
            InitQueryVsphereHostDetails();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereHostConnection.
        internal void ProcessRecord_HostList()
        {
            this._logger.name += " -HostList";
            // Create new graphql operation vSphereHostConnection
            InitQueryVsphereHostConnection();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereHostsByFids.
        internal void ProcessRecord_HostsByFids()
        {
            this._logger.name += " -HostsByFids";
            // Create new graphql operation vSphereHostsByFids
            InitQueryVsphereHostsByFids();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereLiveMounts.
        internal void ProcessRecord_LiveMounts()
        {
            this._logger.name += " -LiveMounts";
            // Create new graphql operation vSphereLiveMounts
            InitQueryVsphereLiveMounts();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereMount.
        internal void ProcessRecord_Mount()
        {
            this._logger.name += " -Mount";
            // Create new graphql operation vSphereMount
            InitQueryVsphereMount();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereMountConnection.
        internal void ProcessRecord_MountList()
        {
            this._logger.name += " -MountList";
            // Create new graphql operation vSphereMountConnection
            InitQueryVsphereMountConnection();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereNetwork.
        internal void ProcessRecord_Network()
        {
            this._logger.name += " -Network";
            // Create new graphql operation vSphereNetwork
            InitQueryVsphereNetwork();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereResourcePool.
        internal void ProcessRecord_ResourcePool()
        {
            this._logger.name += " -ResourcePool";
            // Create new graphql operation vSphereResourcePool
            InitQueryVsphereResourcePool();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereRootRecoveryHierarchy.
        internal void ProcessRecord_RootRecoveryHierarchy()
        {
            this._logger.name += " -RootRecoveryHierarchy";
            // Create new graphql operation vSphereRootRecoveryHierarchy
            InitQueryVsphereRootRecoveryHierarchy();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereTag.
        internal void ProcessRecord_Tag()
        {
            this._logger.name += " -Tag";
            // Create new graphql operation vSphereTag
            InitQueryVsphereTag();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereTagCategory.
        internal void ProcessRecord_TagCategory()
        {
            this._logger.name += " -TagCategory";
            // Create new graphql operation vSphereTagCategory
            InitQueryVsphereTagCategory();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereTopLevelDescendantsConnection.
        internal void ProcessRecord_TopLevelDescendantsList()
        {
            this._logger.name += " -TopLevelDescendantsList";
            // Create new graphql operation vSphereTopLevelDescendantsConnection
            InitQueryVsphereTopLevelDescendantsConnection();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmwareCdpLiveInfo.
        internal void ProcessRecord_VmwareCdpLiveInfo()
        {
            this._logger.name += " -VmwareCdpLiveInfo";
            // Create new graphql operation vsphereVmwareCdpLiveInfo
            InitQueryVsphereVmwareCdpLiveInfo();
        }


        // Create new GraphQL Query:
        // vSphereComputeCluster(fid: UUID!): VsphereComputeCluster!
        internal void InitQueryVsphereComputeCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereComputeCluster",
                "($fid: UUID!)",
                "VsphereComputeCluster",
                Query.VsphereComputeCluster,
                Query.VsphereComputeClusterFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // vSphereComputeClusters(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): VsphereComputeClusterConnection!
        internal void InitQueryVsphereComputeClusters()
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
                "QueryVsphereComputeClusters",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "VsphereComputeClusterConnection",
                Query.VsphereComputeClusters,
                Query.VsphereComputeClustersFieldSpec,
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
        // vSphereDatacenter(fid: UUID!): VsphereDatacenter!
        internal void InitQueryVsphereDatacenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereDatacenter",
                "($fid: UUID!)",
                "VsphereDatacenter",
                Query.VsphereDatacenter,
                Query.VsphereDatacenterFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // vSphereDatastore(fid: UUID!): VsphereDatastore!
        internal void InitQueryVsphereDatastore()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereDatastore",
                "($fid: UUID!)",
                "VsphereDatastore",
                Query.VsphereDatastore,
                Query.VsphereDatastoreFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // vSphereDatastoreCluster(fid: UUID!): VsphereDatastoreCluster!
        internal void InitQueryVsphereDatastoreCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereDatastoreCluster",
                "($fid: UUID!)",
                "VsphereDatastoreCluster",
                Query.VsphereDatastoreCluster,
                Query.VsphereDatastoreClusterFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // vSphereDatastoreClusters(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): VsphereDatastoreClusterConnection!
        internal void InitQueryVsphereDatastoreClusters()
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
                "QueryVsphereDatastoreClusters",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "VsphereDatastoreClusterConnection",
                Query.VsphereDatastoreClusters,
                Query.VsphereDatastoreClustersFieldSpec,
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
        // vSphereDatastoreConnection(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): VsphereDatastoreConnection!
        internal void InitQueryVsphereDatastoreConnection()
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
                "QueryVsphereDatastoreConnection",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "VsphereDatastoreConnection",
                Query.VsphereDatastoreConnection,
                Query.VsphereDatastoreConnectionFieldSpec,
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
        // vSphereFolder(fid: UUID!): VsphereFolder!
        internal void InitQueryVsphereFolder()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereFolder",
                "($fid: UUID!)",
                "VsphereFolder",
                Query.VsphereFolder,
                Query.VsphereFolderFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // vSphereFolders(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): VsphereFolderConnection!
        internal void InitQueryVsphereFolders()
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
                "QueryVsphereFolders",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "VsphereFolderConnection",
                Query.VsphereFolders,
                Query.VsphereFoldersFieldSpec,
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
        // vSphereHost(fid: UUID!): VsphereHost!
        internal void InitQueryVsphereHost()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereHost",
                "($fid: UUID!)",
                "VsphereHost",
                Query.VsphereHost,
                Query.VsphereHostFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // vSphereHostDetails(input: GetVmwareHostInput!): VmwareHostDetail!
        internal void InitQueryVsphereHostDetails()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetVmwareHostInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereHostDetails",
                "($input: GetVmwareHostInput!)",
                "VmwareHostDetail",
                Query.VsphereHostDetails,
                Query.VsphereHostDetailsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // vSphereHostConnection(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): VsphereHostConnection!
        internal void InitQueryVsphereHostConnection()
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
                "QueryVsphereHostConnection",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "VsphereHostConnection",
                Query.VsphereHostConnection,
                Query.VsphereHostConnectionFieldSpec,
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
        // vSphereHostsByFids(fids: [UUID!]!): [VsphereHost!]!
        internal void InitQueryVsphereHostsByFids()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fids", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereHostsByFids",
                "($fids: [UUID!]!)",
                "List<VsphereHost>",
                Query.VsphereHostsByFids,
                Query.VsphereHostsByFidsFieldSpec,
                @"# REQUIRED
$query.Var.fids = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // vSphereLiveMounts(
        //     first: Int
        //     after: String
        //     filter: [VsphereLiveMountFilterInput!]
        //     sortBy: VsphereLiveMountSortBy
        //   ): VsphereLiveMountConnection!
        internal void InitQueryVsphereLiveMounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("filter", "[VsphereLiveMountFilterInput!]"),
                Tuple.Create("sortBy", "VsphereLiveMountSortBy"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereLiveMounts",
                "($first: Int,$after: String,$filter: [VsphereLiveMountFilterInput!],$sortBy: VsphereLiveMountSortBy)",
                "VsphereLiveMountConnection",
                Query.VsphereLiveMounts,
                Query.VsphereLiveMountsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someVsphereLiveMountFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VsphereLiveMountFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
}
)
# OPTIONAL
$query.Var.sortBy = @{
	# OPTIONAL
	field = $someVsphereLiveMountSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VsphereLiveMountSortByField]) for enum values.
	# OPTIONAL
	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}"
            );
        }

        // Create new GraphQL Query:
        // vSphereMount(fid: UUID!): VsphereMount!
        internal void InitQueryVsphereMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereMount",
                "($fid: UUID!)",
                "VsphereMount",
                Query.VsphereMount,
                Query.VsphereMountFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // vSphereMountConnection(
        //     first: Int
        //     after: String
        //     filter: VSphereMountFilter
        //     sortBy: VsphereMountSortBy
        //     sortOrder: SortOrder
        //   ): VsphereMountConnection!
        internal void InitQueryVsphereMountConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("filter", "VSphereMountFilter"),
                Tuple.Create("sortBy", "VsphereMountSortBy"),
                Tuple.Create("sortOrder", "SortOrder"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereMountConnection",
                "($first: Int,$after: String,$filter: VSphereMountFilter,$sortBy: VsphereMountSortBy,$sortOrder: SortOrder)",
                "VsphereMountConnection",
                Query.VsphereMountConnection,
                Query.VsphereMountConnectionFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	name = $someString
	# OPTIONAL
	clusterUuid = @(
		$someString
	)
	# OPTIONAL
	powerStatus = @(
		$someBoolean
	)
	# OPTIONAL
	sourceVmId = $someString
}
# OPTIONAL
$query.Var.sortBy = $someVsphereMountSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VsphereMountSortBy]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // vSphereNetwork(fid: UUID!): VsphereNetwork!
        internal void InitQueryVsphereNetwork()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereNetwork",
                "($fid: UUID!)",
                "VsphereNetwork",
                Query.VsphereNetwork,
                Query.VsphereNetworkFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // vSphereResourcePool(fid: UUID!): VsphereResourcePool!
        internal void InitQueryVsphereResourcePool()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereResourcePool",
                "($fid: UUID!)",
                "VsphereResourcePool",
                Query.VsphereResourcePool,
                Query.VsphereResourcePoolFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // vSphereRootRecoveryHierarchy(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): CdmHierarchyObjectConnection!
        internal void InitQueryVsphereRootRecoveryHierarchy()
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
                "QueryVsphereRootRecoveryHierarchy",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "CdmHierarchyObjectConnection",
                Query.VsphereRootRecoveryHierarchy,
                Query.VsphereRootRecoveryHierarchyFieldSpec,
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
        // vSphereTag(fid: UUID!): VsphereTag!
        internal void InitQueryVsphereTag()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereTag",
                "($fid: UUID!)",
                "VsphereTag",
                Query.VsphereTag,
                Query.VsphereTagFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // vSphereTagCategory(fid: UUID!): VsphereTagCategory!
        internal void InitQueryVsphereTagCategory()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereTagCategory",
                "($fid: UUID!)",
                "VsphereTagCategory",
                Query.VsphereTagCategory,
                Query.VsphereTagCategoryFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // vSphereTopLevelDescendantsConnection(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     typeFilter: [HierarchyObjectTypeEnum!]
        //     filter: [Filter!]
        //   ): CdmHierarchyObjectConnection!
        internal void InitQueryVsphereTopLevelDescendantsConnection()
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
                "QueryVsphereTopLevelDescendantsConnection",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$typeFilter: [HierarchyObjectTypeEnum!],$filter: [Filter!])",
                "CdmHierarchyObjectConnection",
                Query.VsphereTopLevelDescendantsConnection,
                Query.VsphereTopLevelDescendantsConnectionFieldSpec,
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
        // vsphereVmwareCdpLiveInfo(ids: [String!]!): BatchVmwareCdpLiveInfo!
        internal void InitQueryVsphereVmwareCdpLiveInfo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("ids", "[String!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereVmwareCdpLiveInfo",
                "($ids: [String!]!)",
                "BatchVmwareCdpLiveInfo",
                Query.VsphereVmwareCdpLiveInfo,
                Query.VsphereVmwareCdpLiveInfoFieldSpec,
                @"# REQUIRED
$query.Var.ids = @(
	$someString
)"
            );
        }


    } // class New_RscQueryVsphere
}