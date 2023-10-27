// New-RscQueryAzure.cs
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
    /// Create a new RscQuery object for any of the 44
    /// operations in the 'Azure' API domain:
    /// AdDirectories, AdDirectory, AdObjectsByType, ArmTemplatesByFeature, CdmVersions, CheckPersistentStorageSubscriptionCanUnmap, CloudAccountMissingPermissions, CloudAccountPermissionConfig, CloudAccountSubnetsByRegion, CloudAccountSubscriptionWithFeatures, CloudAccountSubscriptionsByFeature, CloudAccountTenant, CloudAccountTenantWithExoConfigs, CloudAccountTenants, DiskEncryptionSetsByRegion, EncryptionKeys, ExocomputeConfigsInAccount, HasRelicAdSnapshot, HostedAzureRegions, IsStorageAccountNameAvailable, KeyVaultsByRegion, ManagedIdentities, Nsgs, Regions, ResourceGroups, SearchAdSnapshot, SqlDatabase, SqlDatabaseDbPointInTimeRestoreWindowFromAzure, SqlDatabaseServer, SqlDatabaseServerElasticPools, SqlDatabaseServers, SqlDatabases, SqlManagedInstanceDatabase, SqlManagedInstanceDatabases, SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure, SqlManagedInstanceServer, SqlManagedInstanceServers, StorageAccounts, StorageAccountsByRegion, Subnets, SubscriptionWithExocomputeMappings, Subscriptions, VNets, or ValidateCloudAccountExocomputeConfigurations.
    /// </summary>
    /// <description>
    /// New-RscQueryAzure creates a new
    /// query object for operations
    /// in the 'Azure' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 44 operations
    /// in the 'Azure' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AdDirectories, AdDirectory, AdObjectsByType, ArmTemplatesByFeature, CdmVersions, CheckPersistentStorageSubscriptionCanUnmap, CloudAccountMissingPermissions, CloudAccountPermissionConfig, CloudAccountSubnetsByRegion, CloudAccountSubscriptionWithFeatures, CloudAccountSubscriptionsByFeature, CloudAccountTenant, CloudAccountTenantWithExoConfigs, CloudAccountTenants, DiskEncryptionSetsByRegion, EncryptionKeys, ExocomputeConfigsInAccount, HasRelicAdSnapshot, HostedAzureRegions, IsStorageAccountNameAvailable, KeyVaultsByRegion, ManagedIdentities, Nsgs, Regions, ResourceGroups, SearchAdSnapshot, SqlDatabase, SqlDatabaseDbPointInTimeRestoreWindowFromAzure, SqlDatabaseServer, SqlDatabaseServerElasticPools, SqlDatabaseServers, SqlDatabases, SqlManagedInstanceDatabase, SqlManagedInstanceDatabases, SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure, SqlManagedInstanceServer, SqlManagedInstanceServers, StorageAccounts, StorageAccountsByRegion, Subnets, SubscriptionWithExocomputeMappings, Subscriptions, VNets, or ValidateCloudAccountExocomputeConfigurations.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryAzure -AdDirectories).Info().
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
    /// (New-RscQueryAzure -AdDirectories).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AdDirectories operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: AdDirectories
    /// 
    /// $query = New-RscQueryAzure -AdDirectories
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
    /// Write-Host $result.GetType().Name # prints: AzureAdDirectoryConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AdDirectory operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: AdDirectory
    /// 
    /// $query = New-RscQueryAzure -AdDirectory
    /// 
    /// # REQUIRED
    /// $query.Var.workloadFid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureAdDirectory
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AdObjectsByType operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: AdObjectsByType
    /// 
    /// $query = New-RscQueryAzure -AdObjectsByType
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.sortByOption = @(
    /// 	$someAzureAdObjectSearchType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdObjectSearchType]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotId = $someString
    /// 	# REQUIRED
    /// 	azureAdObjectType = $someAzureAdObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdObjectType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureAdObjectConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ArmTemplatesByFeature operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: ArmTemplatesByFeature
    /// 
    /// $query = New-RscQueryAzure -ArmTemplatesByFeature
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	customerTenantDomainName = $someString
    /// 	# REQUIRED
    /// 	features = @(
    /// 		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	)
    /// 	# REQUIRED
    /// 	operationType = $someCloudAccountOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountOperation]) for enum values.
    /// 	# REQUIRED
    /// 	cloudType = $someAzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
    /// 	# OPTIONAL
    /// 	featuresToInclude = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			permissionsGroups = @(
    /// 				$somePermissionsGroup # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
    /// 			)
    /// 			# REQUIRED
    /// 			featureType = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AzureArmTemplateByFeature&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CdmVersions operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CdmVersions
    /// 
    /// $query = New-RscQueryAzure -CdmVersions
    /// 
    /// # REQUIRED
    /// $query.Var.cdmVersionRequest = @{
    /// 	# OPTIONAL
    /// 	cloudAccountId = $someString
    /// 	# OPTIONAL
    /// 	location = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AzureCdmVersion&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CheckPersistentStorageSubscriptionCanUnmap operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CheckPersistentStorageSubscriptionCanUnmap
    /// 
    /// $query = New-RscQueryAzure -CheckPersistentStorageSubscriptionCanUnmap
    /// 
    /// # REQUIRED
    /// $query.Var.cloudAccountId = $someString
    /// # REQUIRED
    /// $query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// # REQUIRED
    /// $query.Var.unmappingValidationType = $someUnmappingValidationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmappingValidationType]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CheckAzurePersistentStorageSubscriptionCanUnmapReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudAccountMissingPermissions operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CloudAccountMissingPermissions
    /// 
    /// $query = New-RscQueryAzure -CloudAccountMissingPermissions
    /// 
    /// # REQUIRED
    /// $query.Var.sessionId = $someString
    /// # REQUIRED
    /// $query.Var.subscriptionIds = @(
    /// 	$someString
    /// )
    /// # REQUIRED
    /// $query.Var.cloudAccountAction = $someCloudAccountAction # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountAction]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AzureSubscriptionMissingPermissions&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudAccountPermissionConfig operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CloudAccountPermissionConfig
    /// 
    /// $query = New-RscQueryAzure -CloudAccountPermissionConfig
    /// 
    /// # REQUIRED
    /// $query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureCloudAccountPermissionConfigResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudAccountSubnetsByRegion operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CloudAccountSubnetsByRegion
    /// 
    /// $query = New-RscQueryAzure -CloudAccountSubnetsByRegion
    /// 
    /// # REQUIRED
    /// $query.Var.cloudAccountId = $someString
    /// # REQUIRED
    /// $query.Var.region = $someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
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
    /// Runs the CloudAccountSubscriptionWithFeatures operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CloudAccountSubscriptionWithFeatures
    /// 
    /// $query = New-RscQueryAzure -CloudAccountSubscriptionWithFeatures
    /// 
    /// # REQUIRED
    /// $query.Var.cloudAccountId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureCloudAccountSubscriptionWithFeatures
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudAccountSubscriptionsByFeature operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CloudAccountSubscriptionsByFeature
    /// 
    /// $query = New-RscQueryAzure -CloudAccountSubscriptionsByFeature
    /// 
    /// # REQUIRED
    /// $query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// # REQUIRED
    /// $query.Var.subscriptionStatusFilters = @(
    /// 	$someCloudAccountStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountStatus]) for enum values.
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AzureSubscriptionWithFeaturesType&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudAccountTenant operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CloudAccountTenant
    /// 
    /// $query = New-RscQueryAzure -CloudAccountTenant
    /// 
    /// # REQUIRED
    /// $query.Var.tenantId = $someString
    /// # REQUIRED
    /// $query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// # REQUIRED
    /// $query.Var.subscriptionStatusFilters = @(
    /// 	$someCloudAccountStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountStatus]) for enum values.
    /// )
    /// # REQUIRED
    /// $query.Var.subscriptionSearchText = $someString
    /// # OPTIONAL
    /// $query.Var.subscriptionIdsFilter = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureCloudAccountTenant
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudAccountTenantWithExoConfigs operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CloudAccountTenantWithExoConfigs
    /// 
    /// $query = New-RscQueryAzure -CloudAccountTenantWithExoConfigs
    /// 
    /// # REQUIRED
    /// $query.Var.tenantId = $someString
    /// # REQUIRED
    /// $query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// # REQUIRED
    /// $query.Var.subscriptionStatusFilters = @(
    /// 	$someCloudAccountStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountStatus]) for enum values.
    /// )
    /// # REQUIRED
    /// $query.Var.subscriptionSearchText = $someString
    /// # OPTIONAL
    /// $query.Var.subscriptionIdsFilter = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureCloudAccountTenantWithExoConfigs
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudAccountTenants operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CloudAccountTenants
    /// 
    /// $query = New-RscQueryAzure -CloudAccountTenants
    /// 
    /// # OPTIONAL
    /// $query.Var.features = @(
    /// 	$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// )
    /// # REQUIRED
    /// $query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// # REQUIRED
    /// $query.Var.includeSubscriptionDetails = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AzureCloudAccountTenant&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DiskEncryptionSetsByRegion operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: DiskEncryptionSetsByRegion
    /// 
    /// $query = New-RscQueryAzure -DiskEncryptionSetsByRegion
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
    /// Write-Host $result.GetType().Name # prints: List&lt;AzureNativeDiskEncryptionSet&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the EncryptionKeys operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: EncryptionKeys
    /// 
    /// $query = New-RscQueryAzure -EncryptionKeys
    /// 
    /// # REQUIRED
    /// $query.Var.azureEncryptionKeysInput = @{
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	keyVaultName = $someString
    /// 	# REQUIRED
    /// 	resourceGroupName = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AzureEncryptionKey&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ExocomputeConfigsInAccount operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: ExocomputeConfigsInAccount
    /// 
    /// $query = New-RscQueryAzure -ExocomputeConfigsInAccount
    /// 
    /// # OPTIONAL
    /// $query.Var.azureExocomputeSearchQuery = $someString
    /// # OPTIONAL
    /// $query.Var.cloudAccountIDs = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AzureExocomputeConfigsInAccount&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the HasRelicAdSnapshot operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: HasRelicAdSnapshot
    /// 
    /// $query = New-RscQueryAzure -HasRelicAdSnapshot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	domainName = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: HasRelicAzureAdSnapshotReplyType
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the HostedAzureRegions operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: HostedAzureRegions
    /// 
    /// $query = New-RscQueryAzure -HostedAzureRegions
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureRegionsResp
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the IsStorageAccountNameAvailable operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: IsStorageAccountNameAvailable
    /// 
    /// $query = New-RscQueryAzure -IsStorageAccountNameAvailable
    /// 
    /// # REQUIRED
    /// $query.Var.azureSubscriptionRubrikId = $someString
    /// # REQUIRED
    /// $query.Var.storageAccountName = $someString
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
    /// Runs the KeyVaultsByRegion operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: KeyVaultsByRegion
    /// 
    /// $query = New-RscQueryAzure -KeyVaultsByRegion
    /// 
    /// # REQUIRED
    /// $query.Var.azureKeyVaultsInput = @{
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
    /// 	# OPTIONAL
    /// 	userAssignedManagedIdentityPrincipalId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AzureKeyVault&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ManagedIdentities operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: ManagedIdentities
    /// 
    /// $query = New-RscQueryAzure -ManagedIdentities
    /// 
    /// # REQUIRED
    /// $query.Var.managedIdentitiesRequest = @{
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AzureManagedIdentity&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Nsgs operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: Nsgs
    /// 
    /// $query = New-RscQueryAzure -Nsgs
    /// 
    /// # REQUIRED
    /// $query.Var.nsgRequest = @{
    /// 	# OPTIONAL
    /// 	cloudAccountId = $someString
    /// 	# OPTIONAL
    /// 	resourceGroup = $someString
    /// }
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
    /// Runs the Regions operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: Regions
    /// 
    /// $query = New-RscQueryAzure -Regions
    /// 
    /// # REQUIRED
    /// $query.Var.tenantId = $someString
    /// # REQUIRED
    /// $query.Var.subscriptionId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RegionConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ResourceGroups operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: ResourceGroups
    /// 
    /// $query = New-RscQueryAzure -ResourceGroups
    /// 
    /// # REQUIRED
    /// $query.Var.cloudAccountId = $someString
    /// # REQUIRED
    /// $query.Var.azureSubscriptionNativeId = $someString
    /// # REQUIRED
    /// $query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AzureResourceGroup&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SearchAdSnapshot operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: SearchAdSnapshot
    /// 
    /// $query = New-RscQueryAzure -SearchAdSnapshot
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotId = $someString
    /// 	# REQUIRED
    /// 	azureAdSearchKeyword = $someString
    /// 	# REQUIRED
    /// 	azureAdObjectType = $someAzureAdObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdObjectType]) for enum values.
    /// 	# REQUIRED
    /// 	azureAdSearchKeywordType = $someAzureAdObjectSearchType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdObjectSearchType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureAdObjectConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SqlDatabase operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: SqlDatabase
    /// 
    /// $query = New-RscQueryAzure -SqlDatabase
    /// 
    /// # REQUIRED
    /// $query.Var.azureSqlDatabaseRubrikId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureSqlDatabaseDb
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SqlDatabaseDbPointInTimeRestoreWindowFromAzure operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: SqlDatabaseDbPointInTimeRestoreWindowFromAzure
    /// 
    /// $query = New-RscQueryAzure -SqlDatabaseDbPointInTimeRestoreWindowFromAzure
    /// 
    /// # REQUIRED
    /// $query.Var.subscriptionId = $someString
    /// # REQUIRED
    /// $query.Var.resourceGroupName = $someString
    /// # REQUIRED
    /// $query.Var.azureSqlDatabaseServerName = $someString
    /// # REQUIRED
    /// $query.Var.azureSqlDatabaseName = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureNativeSqlDatabasePointInTimeRestoreWindow
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SqlDatabaseServer operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: SqlDatabaseServer
    /// 
    /// $query = New-RscQueryAzure -SqlDatabaseServer
    /// 
    /// # REQUIRED
    /// $query.Var.azureSqlDatabaseServerRubrikId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureSqlDatabaseServer
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SqlDatabaseServerElasticPools operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: SqlDatabaseServerElasticPools
    /// 
    /// $query = New-RscQueryAzure -SqlDatabaseServerElasticPools
    /// 
    /// # REQUIRED
    /// $query.Var.subscriptionId = $someString
    /// # REQUIRED
    /// $query.Var.resourceGroupName = $someString
    /// # REQUIRED
    /// $query.Var.azureSqlDatabaseServerName = $someString
    /// # REQUIRED
    /// $query.Var.azureSqlDatabaseServerRubrikId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AzureSqlDatabaseServerElasticPool&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SqlDatabaseServers operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: SqlDatabaseServers
    /// 
    /// $query = New-RscQueryAzure -SqlDatabaseServers
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
    /// $query.Var.sortBy = $someAzureSqlDatabaseServerSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlDatabaseServerSortFields]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.azureSqlDatabaseServerFilters = @{
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
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureSqlDatabaseServerConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SqlDatabases operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: SqlDatabases
    /// 
    /// $query = New-RscQueryAzure -SqlDatabases
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
    /// $query.Var.sortBy = $someAzureSqlDatabaseSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlDatabaseSortFields]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.azureSqlDatabaseFilters = @{
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
    /// 	serverFilter = @{
    /// 		# REQUIRED
    /// 		serverNames = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureSqlDatabaseDbConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SqlManagedInstanceDatabase operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: SqlManagedInstanceDatabase
    /// 
    /// $query = New-RscQueryAzure -SqlManagedInstanceDatabase
    /// 
    /// # REQUIRED
    /// $query.Var.azureSqlManagedInstanceDatabaseRubrikId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureSqlManagedInstanceDatabase
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SqlManagedInstanceDatabases operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: SqlManagedInstanceDatabases
    /// 
    /// $query = New-RscQueryAzure -SqlManagedInstanceDatabases
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
    /// $query.Var.sortBy = $someAzureSqlManagedInstanceDatabaseSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlManagedInstanceDatabaseSortFields]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.azureSqlManagedInstanceDatabaseFilters = @{
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
    /// 	relicFilter = @{
    /// 		# REQUIRED
    /// 		relic = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	serverFilter = @{
    /// 		# REQUIRED
    /// 		serverNames = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureSqlManagedInstanceDatabaseConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure
    /// 
    /// $query = New-RscQueryAzure -SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure
    /// 
    /// # REQUIRED
    /// $query.Var.subscriptionId = $someString
    /// # REQUIRED
    /// $query.Var.resourceGroupName = $someString
    /// # REQUIRED
    /// $query.Var.azureSqlManagedInstanceName = $someString
    /// # REQUIRED
    /// $query.Var.azureSqlDatabaseName = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureNativeSqlDatabasePointInTimeRestoreWindow
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SqlManagedInstanceServer operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: SqlManagedInstanceServer
    /// 
    /// $query = New-RscQueryAzure -SqlManagedInstanceServer
    /// 
    /// # REQUIRED
    /// $query.Var.azureSqlManagedInstanceServerRubrikId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureSqlManagedInstanceServer
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SqlManagedInstanceServers operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: SqlManagedInstanceServers
    /// 
    /// $query = New-RscQueryAzure -SqlManagedInstanceServers
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
    /// $query.Var.sortBy = $someAzureSqlManagedInstanceServerSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlManagedInstanceServerSortFields]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.azureSqlManagedInstanceServerFilters = @{
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
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureSqlManagedInstanceServerConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StorageAccounts operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: StorageAccounts
    /// 
    /// $query = New-RscQueryAzure -StorageAccounts
    /// 
    /// # REQUIRED
    /// $query.Var.tenantId = $someString
    /// # REQUIRED
    /// $query.Var.subscriptionId = $someString
    /// # REQUIRED
    /// $query.Var.regionName = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: StorageAccountConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StorageAccountsByRegion operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: StorageAccountsByRegion
    /// 
    /// $query = New-RscQueryAzure -StorageAccountsByRegion
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	cloudAccountId = $someString
    /// 	# OPTIONAL
    /// 	region = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AzureStorageAccountCcprovision&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Subnets operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: Subnets
    /// 
    /// $query = New-RscQueryAzure -Subnets
    /// 
    /// # REQUIRED
    /// $query.Var.tenantId = $someString
    /// # REQUIRED
    /// $query.Var.subscriptionId = $someString
    /// # REQUIRED
    /// $query.Var.vNetId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SubnetConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SubscriptionWithExocomputeMappings operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: SubscriptionWithExocomputeMappings
    /// 
    /// $query = New-RscQueryAzure -SubscriptionWithExocomputeMappings
    /// 
    /// # OPTIONAL
    /// $query.Var.features = @(
    /// 	$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.exocomputeSubscriptionIdsFilter = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AzureSubscriptionWithExocomputeMapping&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Subscriptions operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: Subscriptions
    /// 
    /// $query = New-RscQueryAzure -Subscriptions
    /// 
    /// # REQUIRED
    /// $query.Var.tenantId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureSubscriptionConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the VNets operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: VNets
    /// 
    /// $query = New-RscQueryAzure -VNets
    /// 
    /// # REQUIRED
    /// $query.Var.tenantId = $someString
    /// # REQUIRED
    /// $query.Var.subscriptionId = $someString
    /// # REQUIRED
    /// $query.Var.regionName = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VnetConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ValidateCloudAccountExocomputeConfigurations operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: ValidateCloudAccountExocomputeConfigurations
    /// 
    /// $query = New-RscQueryAzure -ValidateCloudAccountExocomputeConfigurations
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	azureExocomputeRegionConfigs = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			region = $someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
    /// 			# REQUIRED
    /// 			subnetNativeId = $someString
    /// 			# REQUIRED
    /// 			isRscManaged = $someBoolean
    /// 			# OPTIONAL
    /// 			podSubnetNativeId = $someString
    /// 			# OPTIONAL
    /// 			podOverlayNetworkCidr = $someString
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ValidateAzureSubnetsForCloudAccountExocomputeReply
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
        "RscQueryAzure",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryAzure : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "AdDirectories",
                "AdDirectory",
                "AdObjectsByType",
                "ArmTemplatesByFeature",
                "CdmVersions",
                "CheckPersistentStorageSubscriptionCanUnmap",
                "CloudAccountMissingPermissions",
                "CloudAccountPermissionConfig",
                "CloudAccountSubnetsByRegion",
                "CloudAccountSubscriptionWithFeatures",
                "CloudAccountSubscriptionsByFeature",
                "CloudAccountTenant",
                "CloudAccountTenantWithExoConfigs",
                "CloudAccountTenants",
                "DiskEncryptionSetsByRegion",
                "EncryptionKeys",
                "ExocomputeConfigsInAccount",
                "HasRelicAdSnapshot",
                "HostedAzureRegions",
                "IsStorageAccountNameAvailable",
                "KeyVaultsByRegion",
                "ManagedIdentities",
                "Nsgs",
                "Regions",
                "ResourceGroups",
                "SearchAdSnapshot",
                "SqlDatabase",
                "SqlDatabaseDbPointInTimeRestoreWindowFromAzure",
                "SqlDatabaseServer",
                "SqlDatabaseServerElasticPools",
                "SqlDatabaseServers",
                "SqlDatabases",
                "SqlManagedInstanceDatabase",
                "SqlManagedInstanceDatabases",
                "SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure",
                "SqlManagedInstanceServer",
                "SqlManagedInstanceServers",
                "StorageAccounts",
                "StorageAccountsByRegion",
                "Subnets",
                "SubscriptionWithExocomputeMappings",
                "Subscriptions",
                "VNets",
                "ValidateCloudAccountExocomputeConfigurations",
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
                    case "AdDirectories":
                        this.ProcessRecord_AdDirectories();
                        break;
                    case "AdDirectory":
                        this.ProcessRecord_AdDirectory();
                        break;
                    case "AdObjectsByType":
                        this.ProcessRecord_AdObjectsByType();
                        break;
                    case "ArmTemplatesByFeature":
                        this.ProcessRecord_ArmTemplatesByFeature();
                        break;
                    case "CdmVersions":
                        this.ProcessRecord_CdmVersions();
                        break;
                    case "CheckPersistentStorageSubscriptionCanUnmap":
                        this.ProcessRecord_CheckPersistentStorageSubscriptionCanUnmap();
                        break;
                    case "CloudAccountMissingPermissions":
                        this.ProcessRecord_CloudAccountMissingPermissions();
                        break;
                    case "CloudAccountPermissionConfig":
                        this.ProcessRecord_CloudAccountPermissionConfig();
                        break;
                    case "CloudAccountSubnetsByRegion":
                        this.ProcessRecord_CloudAccountSubnetsByRegion();
                        break;
                    case "CloudAccountSubscriptionWithFeatures":
                        this.ProcessRecord_CloudAccountSubscriptionWithFeatures();
                        break;
                    case "CloudAccountSubscriptionsByFeature":
                        this.ProcessRecord_CloudAccountSubscriptionsByFeature();
                        break;
                    case "CloudAccountTenant":
                        this.ProcessRecord_CloudAccountTenant();
                        break;
                    case "CloudAccountTenantWithExoConfigs":
                        this.ProcessRecord_CloudAccountTenantWithExoConfigs();
                        break;
                    case "CloudAccountTenants":
                        this.ProcessRecord_CloudAccountTenants();
                        break;
                    case "DiskEncryptionSetsByRegion":
                        this.ProcessRecord_DiskEncryptionSetsByRegion();
                        break;
                    case "EncryptionKeys":
                        this.ProcessRecord_EncryptionKeys();
                        break;
                    case "ExocomputeConfigsInAccount":
                        this.ProcessRecord_ExocomputeConfigsInAccount();
                        break;
                    case "HasRelicAdSnapshot":
                        this.ProcessRecord_HasRelicAdSnapshot();
                        break;
                    case "HostedAzureRegions":
                        this.ProcessRecord_HostedAzureRegions();
                        break;
                    case "IsStorageAccountNameAvailable":
                        this.ProcessRecord_IsStorageAccountNameAvailable();
                        break;
                    case "KeyVaultsByRegion":
                        this.ProcessRecord_KeyVaultsByRegion();
                        break;
                    case "ManagedIdentities":
                        this.ProcessRecord_ManagedIdentities();
                        break;
                    case "Nsgs":
                        this.ProcessRecord_Nsgs();
                        break;
                    case "Regions":
                        this.ProcessRecord_Regions();
                        break;
                    case "ResourceGroups":
                        this.ProcessRecord_ResourceGroups();
                        break;
                    case "SearchAdSnapshot":
                        this.ProcessRecord_SearchAdSnapshot();
                        break;
                    case "SqlDatabase":
                        this.ProcessRecord_SqlDatabase();
                        break;
                    case "SqlDatabaseDbPointInTimeRestoreWindowFromAzure":
                        this.ProcessRecord_SqlDatabaseDbPointInTimeRestoreWindowFromAzure();
                        break;
                    case "SqlDatabaseServer":
                        this.ProcessRecord_SqlDatabaseServer();
                        break;
                    case "SqlDatabaseServerElasticPools":
                        this.ProcessRecord_SqlDatabaseServerElasticPools();
                        break;
                    case "SqlDatabaseServers":
                        this.ProcessRecord_SqlDatabaseServers();
                        break;
                    case "SqlDatabases":
                        this.ProcessRecord_SqlDatabases();
                        break;
                    case "SqlManagedInstanceDatabase":
                        this.ProcessRecord_SqlManagedInstanceDatabase();
                        break;
                    case "SqlManagedInstanceDatabases":
                        this.ProcessRecord_SqlManagedInstanceDatabases();
                        break;
                    case "SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure":
                        this.ProcessRecord_SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure();
                        break;
                    case "SqlManagedInstanceServer":
                        this.ProcessRecord_SqlManagedInstanceServer();
                        break;
                    case "SqlManagedInstanceServers":
                        this.ProcessRecord_SqlManagedInstanceServers();
                        break;
                    case "StorageAccounts":
                        this.ProcessRecord_StorageAccounts();
                        break;
                    case "StorageAccountsByRegion":
                        this.ProcessRecord_StorageAccountsByRegion();
                        break;
                    case "Subnets":
                        this.ProcessRecord_Subnets();
                        break;
                    case "SubscriptionWithExocomputeMappings":
                        this.ProcessRecord_SubscriptionWithExocomputeMappings();
                        break;
                    case "Subscriptions":
                        this.ProcessRecord_Subscriptions();
                        break;
                    case "VNets":
                        this.ProcessRecord_VNets();
                        break;
                    case "ValidateCloudAccountExocomputeConfigurations":
                        this.ProcessRecord_ValidateCloudAccountExocomputeConfigurations();
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
        // azureAdDirectories.
        internal void ProcessRecord_AdDirectories()
        {
            this._logger.name += " -AdDirectories";
            // Create new graphql operation azureAdDirectories
            InitQueryAzureAdDirectories();
        }

        // This parameter set invokes a single graphql operation:
        // azureAdDirectory.
        internal void ProcessRecord_AdDirectory()
        {
            this._logger.name += " -AdDirectory";
            // Create new graphql operation azureAdDirectory
            InitQueryAzureAdDirectory();
        }

        // This parameter set invokes a single graphql operation:
        // azureAdObjectsByType.
        internal void ProcessRecord_AdObjectsByType()
        {
            this._logger.name += " -AdObjectsByType";
            // Create new graphql operation azureAdObjectsByType
            InitQueryAzureAdObjectsByType();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureArmTemplatesByFeature.
        internal void ProcessRecord_ArmTemplatesByFeature()
        {
            this._logger.name += " -ArmTemplatesByFeature";
            // Create new graphql operation allAzureArmTemplatesByFeature
            InitQueryAllAzureArmTemplatesByFeature();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureCdmVersions.
        internal void ProcessRecord_CdmVersions()
        {
            this._logger.name += " -CdmVersions";
            // Create new graphql operation allAzureCdmVersions
            InitQueryAllAzureCdmVersions();
        }

        // This parameter set invokes a single graphql operation:
        // checkAzurePersistentStorageSubscriptionCanUnmap.
        internal void ProcessRecord_CheckPersistentStorageSubscriptionCanUnmap()
        {
            this._logger.name += " -CheckPersistentStorageSubscriptionCanUnmap";
            // Create new graphql operation checkAzurePersistentStorageSubscriptionCanUnmap
            InitQueryCheckAzurePersistentStorageSubscriptionCanUnmap();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureCloudAccountMissingPermissions.
        internal void ProcessRecord_CloudAccountMissingPermissions()
        {
            this._logger.name += " -CloudAccountMissingPermissions";
            // Create new graphql operation allAzureCloudAccountMissingPermissions
            InitQueryAllAzureCloudAccountMissingPermissions();
        }

        // This parameter set invokes a single graphql operation:
        // azureCloudAccountPermissionConfig.
        internal void ProcessRecord_CloudAccountPermissionConfig()
        {
            this._logger.name += " -CloudAccountPermissionConfig";
            // Create new graphql operation azureCloudAccountPermissionConfig
            InitQueryAzureCloudAccountPermissionConfig();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureCloudAccountSubnetsByRegion.
        internal void ProcessRecord_CloudAccountSubnetsByRegion()
        {
            this._logger.name += " -CloudAccountSubnetsByRegion";
            // Create new graphql operation allAzureCloudAccountSubnetsByRegion
            InitQueryAllAzureCloudAccountSubnetsByRegion();
        }

        // This parameter set invokes a single graphql operation:
        // azureCloudAccountSubscriptionWithFeatures.
        internal void ProcessRecord_CloudAccountSubscriptionWithFeatures()
        {
            this._logger.name += " -CloudAccountSubscriptionWithFeatures";
            // Create new graphql operation azureCloudAccountSubscriptionWithFeatures
            InitQueryAzureCloudAccountSubscriptionWithFeatures();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureCloudAccountSubscriptionsByFeature.
        internal void ProcessRecord_CloudAccountSubscriptionsByFeature()
        {
            this._logger.name += " -CloudAccountSubscriptionsByFeature";
            // Create new graphql operation allAzureCloudAccountSubscriptionsByFeature
            InitQueryAllAzureCloudAccountSubscriptionsByFeature();
        }

        // This parameter set invokes a single graphql operation:
        // azureCloudAccountTenant.
        internal void ProcessRecord_CloudAccountTenant()
        {
            this._logger.name += " -CloudAccountTenant";
            // Create new graphql operation azureCloudAccountTenant
            InitQueryAzureCloudAccountTenant();
        }

        // This parameter set invokes a single graphql operation:
        // azureCloudAccountTenantWithExoConfigs.
        internal void ProcessRecord_CloudAccountTenantWithExoConfigs()
        {
            this._logger.name += " -CloudAccountTenantWithExoConfigs";
            // Create new graphql operation azureCloudAccountTenantWithExoConfigs
            InitQueryAzureCloudAccountTenantWithExoConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureCloudAccountTenants.
        internal void ProcessRecord_CloudAccountTenants()
        {
            this._logger.name += " -CloudAccountTenants";
            // Create new graphql operation allAzureCloudAccountTenants
            InitQueryAllAzureCloudAccountTenants();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureDiskEncryptionSetsByRegion.
        internal void ProcessRecord_DiskEncryptionSetsByRegion()
        {
            this._logger.name += " -DiskEncryptionSetsByRegion";
            // Create new graphql operation allAzureDiskEncryptionSetsByRegion
            InitQueryAllAzureDiskEncryptionSetsByRegion();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureEncryptionKeys.
        internal void ProcessRecord_EncryptionKeys()
        {
            this._logger.name += " -EncryptionKeys";
            // Create new graphql operation allAzureEncryptionKeys
            InitQueryAllAzureEncryptionKeys();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureExocomputeConfigsInAccount.
        internal void ProcessRecord_ExocomputeConfigsInAccount()
        {
            this._logger.name += " -ExocomputeConfigsInAccount";
            // Create new graphql operation allAzureExocomputeConfigsInAccount
            InitQueryAllAzureExocomputeConfigsInAccount();
        }

        // This parameter set invokes a single graphql operation:
        // hasRelicAzureAdSnapshot.
        internal void ProcessRecord_HasRelicAdSnapshot()
        {
            this._logger.name += " -HasRelicAdSnapshot";
            // Create new graphql operation hasRelicAzureAdSnapshot
            InitQueryHasRelicAzureAdSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // allHostedAzureRegions.
        internal void ProcessRecord_HostedAzureRegions()
        {
            this._logger.name += " -HostedAzureRegions";
            // Create new graphql operation allHostedAzureRegions
            InitQueryAllHostedAzureRegions();
        }

        // This parameter set invokes a single graphql operation:
        // isAzureStorageAccountNameAvailable.
        internal void ProcessRecord_IsStorageAccountNameAvailable()
        {
            this._logger.name += " -IsStorageAccountNameAvailable";
            // Create new graphql operation isAzureStorageAccountNameAvailable
            InitQueryIsAzureStorageAccountNameAvailable();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureKeyVaultsByRegion.
        internal void ProcessRecord_KeyVaultsByRegion()
        {
            this._logger.name += " -KeyVaultsByRegion";
            // Create new graphql operation allAzureKeyVaultsByRegion
            InitQueryAllAzureKeyVaultsByRegion();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureManagedIdentities.
        internal void ProcessRecord_ManagedIdentities()
        {
            this._logger.name += " -ManagedIdentities";
            // Create new graphql operation allAzureManagedIdentities
            InitQueryAllAzureManagedIdentities();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNsgs.
        internal void ProcessRecord_Nsgs()
        {
            this._logger.name += " -Nsgs";
            // Create new graphql operation allAzureNsgs
            InitQueryAllAzureNsgs();
        }

        // This parameter set invokes a single graphql operation:
        // azureRegions.
        internal void ProcessRecord_Regions()
        {
            this._logger.name += " -Regions";
            // Create new graphql operation azureRegions
            InitQueryAzureRegions();
        }

        // This parameter set invokes a single graphql operation:
        // allResourceGroupsFromAzure.
        internal void ProcessRecord_ResourceGroups()
        {
            this._logger.name += " -ResourceGroups";
            // Create new graphql operation allResourceGroupsFromAzure
            InitQueryAllResourceGroupsFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // searchAzureAdSnapshot.
        internal void ProcessRecord_SearchAdSnapshot()
        {
            this._logger.name += " -SearchAdSnapshot";
            // Create new graphql operation searchAzureAdSnapshot
            InitQuerySearchAzureAdSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlDatabase.
        internal void ProcessRecord_SqlDatabase()
        {
            this._logger.name += " -SqlDatabase";
            // Create new graphql operation azureSqlDatabase
            InitQueryAzureSqlDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure.
        internal void ProcessRecord_SqlDatabaseDbPointInTimeRestoreWindowFromAzure()
        {
            this._logger.name += " -SqlDatabaseDbPointInTimeRestoreWindowFromAzure";
            // Create new graphql operation azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure
            InitQueryAzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlDatabaseServer.
        internal void ProcessRecord_SqlDatabaseServer()
        {
            this._logger.name += " -SqlDatabaseServer";
            // Create new graphql operation azureSqlDatabaseServer
            InitQueryAzureSqlDatabaseServer();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureSqlDatabaseServerElasticPools.
        internal void ProcessRecord_SqlDatabaseServerElasticPools()
        {
            this._logger.name += " -SqlDatabaseServerElasticPools";
            // Create new graphql operation allAzureSqlDatabaseServerElasticPools
            InitQueryAllAzureSqlDatabaseServerElasticPools();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlDatabaseServers.
        internal void ProcessRecord_SqlDatabaseServers()
        {
            this._logger.name += " -SqlDatabaseServers";
            // Create new graphql operation azureSqlDatabaseServers
            InitQueryAzureSqlDatabaseServers();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlDatabases.
        internal void ProcessRecord_SqlDatabases()
        {
            this._logger.name += " -SqlDatabases";
            // Create new graphql operation azureSqlDatabases
            InitQueryAzureSqlDatabases();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlManagedInstanceDatabase.
        internal void ProcessRecord_SqlManagedInstanceDatabase()
        {
            this._logger.name += " -SqlManagedInstanceDatabase";
            // Create new graphql operation azureSqlManagedInstanceDatabase
            InitQueryAzureSqlManagedInstanceDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlManagedInstanceDatabases.
        internal void ProcessRecord_SqlManagedInstanceDatabases()
        {
            this._logger.name += " -SqlManagedInstanceDatabases";
            // Create new graphql operation azureSqlManagedInstanceDatabases
            InitQueryAzureSqlManagedInstanceDatabases();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure.
        internal void ProcessRecord_SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure()
        {
            this._logger.name += " -SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure";
            // Create new graphql operation azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure
            InitQueryAzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlManagedInstanceServer.
        internal void ProcessRecord_SqlManagedInstanceServer()
        {
            this._logger.name += " -SqlManagedInstanceServer";
            // Create new graphql operation azureSqlManagedInstanceServer
            InitQueryAzureSqlManagedInstanceServer();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlManagedInstanceServers.
        internal void ProcessRecord_SqlManagedInstanceServers()
        {
            this._logger.name += " -SqlManagedInstanceServers";
            // Create new graphql operation azureSqlManagedInstanceServers
            InitQueryAzureSqlManagedInstanceServers();
        }

        // This parameter set invokes a single graphql operation:
        // azureStorageAccounts.
        internal void ProcessRecord_StorageAccounts()
        {
            this._logger.name += " -StorageAccounts";
            // Create new graphql operation azureStorageAccounts
            InitQueryAzureStorageAccounts();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureStorageAccountsByRegion.
        internal void ProcessRecord_StorageAccountsByRegion()
        {
            this._logger.name += " -StorageAccountsByRegion";
            // Create new graphql operation allAzureStorageAccountsByRegion
            InitQueryAllAzureStorageAccountsByRegion();
        }

        // This parameter set invokes a single graphql operation:
        // azureSubnets.
        internal void ProcessRecord_Subnets()
        {
            this._logger.name += " -Subnets";
            // Create new graphql operation azureSubnets
            InitQueryAzureSubnets();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureSubscriptionWithExocomputeMappings.
        internal void ProcessRecord_SubscriptionWithExocomputeMappings()
        {
            this._logger.name += " -SubscriptionWithExocomputeMappings";
            // Create new graphql operation allAzureSubscriptionWithExocomputeMappings
            InitQueryAllAzureSubscriptionWithExocomputeMappings();
        }

        // This parameter set invokes a single graphql operation:
        // azureSubscriptions.
        internal void ProcessRecord_Subscriptions()
        {
            this._logger.name += " -Subscriptions";
            // Create new graphql operation azureSubscriptions
            InitQueryAzureSubscriptions();
        }

        // This parameter set invokes a single graphql operation:
        // azureVNets.
        internal void ProcessRecord_VNets()
        {
            this._logger.name += " -VNets";
            // Create new graphql operation azureVNets
            InitQueryAzureVnets();
        }

        // This parameter set invokes a single graphql operation:
        // validateAzureCloudAccountExocomputeConfigurations.
        internal void ProcessRecord_ValidateCloudAccountExocomputeConfigurations()
        {
            this._logger.name += " -ValidateCloudAccountExocomputeConfigurations";
            // Create new graphql operation validateAzureCloudAccountExocomputeConfigurations
            InitQueryValidateAzureCloudAccountExocomputeConfigurations();
        }


        // Create new GraphQL Query:
        // azureAdDirectories(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): AzureAdDirectoryConnection!
        internal void InitQueryAzureAdDirectories()
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
                "QueryAzureAdDirectories",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "AzureAdDirectoryConnection",
                Query.AzureAdDirectories_ObjectFieldSpec,
                Query.AzureAdDirectoriesFieldSpec,
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
        // azureAdDirectory(workloadFid: UUID!): AzureAdDirectory!
        internal void InitQueryAzureAdDirectory()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("workloadFid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureAdDirectory",
                "($workloadFid: UUID!)",
                "AzureAdDirectory",
                Query.AzureAdDirectory_ObjectFieldSpec,
                Query.AzureAdDirectoryFieldSpec,
                @"# REQUIRED
$query.Var.workloadFid = $someString"
            );
        }

        // Create new GraphQL Query:
        // azureAdObjectsByType(
        //     first: Int
        //     after: String
        //     sortByOption: [AzureAdObjectSearchType!]
        //     sortOrder: SortOrder
        //     input: AzureAdObjectTypeInput!
        //   ): AzureAdObjectConnection!
        internal void InitQueryAzureAdObjectsByType()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortByOption", "[AzureAdObjectSearchType!]"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("input", "AzureAdObjectTypeInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureAdObjectsByType",
                "($first: Int,$after: String,$sortByOption: [AzureAdObjectSearchType!],$sortOrder: SortOrder,$input: AzureAdObjectTypeInput!)",
                "AzureAdObjectConnection",
                Query.AzureAdObjectsByType_ObjectFieldSpec,
                Query.AzureAdObjectsByTypeFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.sortByOption = @(
	$someAzureAdObjectSearchType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdObjectSearchType]) for enum values.
)
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotId = $someString
	# REQUIRED
	azureAdObjectType = $someAzureAdObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdObjectType]) for enum values.
}"
            );
        }

        // Create new GraphQL Query:
        // allAzureArmTemplatesByFeature(input: AzureArmTemplatesByFeatureInput!): [AzureArmTemplateByFeature!]!
        internal void InitQueryAllAzureArmTemplatesByFeature()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AzureArmTemplatesByFeatureInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureArmTemplatesByFeature",
                "($input: AzureArmTemplatesByFeatureInput!)",
                "List<AzureArmTemplateByFeature>",
                Query.AllAzureArmTemplatesByFeature_ObjectFieldSpec,
                Query.AllAzureArmTemplatesByFeatureFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	customerTenantDomainName = $someString
	# REQUIRED
	features = @(
		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# REQUIRED
	operationType = $someCloudAccountOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountOperation]) for enum values.
	# REQUIRED
	cloudType = $someAzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
	# OPTIONAL
	featuresToInclude = @(
		@{
			# OPTIONAL
			permissionsGroups = @(
				$somePermissionsGroup # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
			)
			# REQUIRED
			featureType = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
		}
	)
}"
            );
        }

        // Create new GraphQL Query:
        // allAzureCdmVersions(cdmVersionRequest: AzureCdmVersionReq!): [AzureCdmVersion!]!
        internal void InitQueryAllAzureCdmVersions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cdmVersionRequest", "AzureCdmVersionReq!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureCdmVersions",
                "($cdmVersionRequest: AzureCdmVersionReq!)",
                "List<AzureCdmVersion>",
                Query.AllAzureCdmVersions_ObjectFieldSpec,
                Query.AllAzureCdmVersionsFieldSpec,
                @"# REQUIRED
$query.Var.cdmVersionRequest = @{
	# OPTIONAL
	cloudAccountId = $someString
	# OPTIONAL
	location = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // checkAzurePersistentStorageSubscriptionCanUnmap(cloudAccountId: UUID!, feature: CloudAccountFeature!, unmappingValidationType: UnmappingValidationType!): CheckAzurePersistentStorageSubscriptionCanUnmapReply!
        internal void InitQueryCheckAzurePersistentStorageSubscriptionCanUnmap()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("unmappingValidationType", "UnmappingValidationType!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCheckAzurePersistentStorageSubscriptionCanUnmap",
                "($cloudAccountId: UUID!,$feature: CloudAccountFeature!,$unmappingValidationType: UnmappingValidationType!)",
                "CheckAzurePersistentStorageSubscriptionCanUnmapReply",
                Query.CheckAzurePersistentStorageSubscriptionCanUnmap_ObjectFieldSpec,
                Query.CheckAzurePersistentStorageSubscriptionCanUnmapFieldSpec,
                @"# REQUIRED
$query.Var.cloudAccountId = $someString
# REQUIRED
$query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$query.Var.unmappingValidationType = $someUnmappingValidationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmappingValidationType]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allAzureCloudAccountMissingPermissions(sessionId: String!, subscriptionIds: [UUID!]!, cloudAccountAction: CloudAccountAction!): [AzureSubscriptionMissingPermissions!]!
        internal void InitQueryAllAzureCloudAccountMissingPermissions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("sessionId", "String!"),
                Tuple.Create("subscriptionIds", "[UUID!]!"),
                Tuple.Create("cloudAccountAction", "CloudAccountAction!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureCloudAccountMissingPermissions",
                "($sessionId: String!,$subscriptionIds: [UUID!]!,$cloudAccountAction: CloudAccountAction!)",
                "List<AzureSubscriptionMissingPermissions>",
                Query.AllAzureCloudAccountMissingPermissions_ObjectFieldSpec,
                Query.AllAzureCloudAccountMissingPermissionsFieldSpec,
                @"# REQUIRED
$query.Var.sessionId = $someString
# REQUIRED
$query.Var.subscriptionIds = @(
	$someString
)
# REQUIRED
$query.Var.cloudAccountAction = $someCloudAccountAction # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountAction]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // azureCloudAccountPermissionConfig(feature: CloudAccountFeature!): AzureCloudAccountPermissionConfigResponse!
        internal void InitQueryAzureCloudAccountPermissionConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("feature", "CloudAccountFeature!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureCloudAccountPermissionConfig",
                "($feature: CloudAccountFeature!)",
                "AzureCloudAccountPermissionConfigResponse",
                Query.AzureCloudAccountPermissionConfig_ObjectFieldSpec,
                Query.AzureCloudAccountPermissionConfigFieldSpec,
                @"# REQUIRED
$query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allAzureCloudAccountSubnetsByRegion(cloudAccountId: UUID!, region: AzureCloudAccountRegion!): [AzureNativeSubnet!]!
        internal void InitQueryAllAzureCloudAccountSubnetsByRegion()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
                Tuple.Create("region", "AzureCloudAccountRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureCloudAccountSubnetsByRegion",
                "($cloudAccountId: UUID!,$region: AzureCloudAccountRegion!)",
                "List<AzureNativeSubnet>",
                Query.AllAzureCloudAccountSubnetsByRegion_ObjectFieldSpec,
                Query.AllAzureCloudAccountSubnetsByRegionFieldSpec,
                @"# REQUIRED
$query.Var.cloudAccountId = $someString
# REQUIRED
$query.Var.region = $someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // azureCloudAccountSubscriptionWithFeatures(cloudAccountId: UUID!): AzureCloudAccountSubscriptionWithFeatures!
        internal void InitQueryAzureCloudAccountSubscriptionWithFeatures()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureCloudAccountSubscriptionWithFeatures",
                "($cloudAccountId: UUID!)",
                "AzureCloudAccountSubscriptionWithFeatures",
                Query.AzureCloudAccountSubscriptionWithFeatures_ObjectFieldSpec,
                Query.AzureCloudAccountSubscriptionWithFeaturesFieldSpec,
                @"# REQUIRED
$query.Var.cloudAccountId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allAzureCloudAccountSubscriptionsByFeature(feature: CloudAccountFeature!, subscriptionStatusFilters: [CloudAccountStatus!]!): [AzureSubscriptionWithFeaturesType!]!
        internal void InitQueryAllAzureCloudAccountSubscriptionsByFeature()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("subscriptionStatusFilters", "[CloudAccountStatus!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureCloudAccountSubscriptionsByFeature",
                "($feature: CloudAccountFeature!,$subscriptionStatusFilters: [CloudAccountStatus!]!)",
                "List<AzureSubscriptionWithFeaturesType>",
                Query.AllAzureCloudAccountSubscriptionsByFeature_ObjectFieldSpec,
                Query.AllAzureCloudAccountSubscriptionsByFeatureFieldSpec,
                @"# REQUIRED
$query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$query.Var.subscriptionStatusFilters = @(
	$someCloudAccountStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountStatus]) for enum values.
)"
            );
        }

        // Create new GraphQL Query:
        // azureCloudAccountTenant(
        //     tenantId: UUID!
        //     feature: CloudAccountFeature!
        //     subscriptionStatusFilters: [CloudAccountStatus!]!
        //     subscriptionSearchText: String!
        //     subscriptionIdsFilter: [UUID!]
        //   ): AzureCloudAccountTenant!
        internal void InitQueryAzureCloudAccountTenant()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("subscriptionStatusFilters", "[CloudAccountStatus!]!"),
                Tuple.Create("subscriptionSearchText", "String!"),
                Tuple.Create("subscriptionIdsFilter", "[UUID!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureCloudAccountTenant",
                "($tenantId: UUID!,$feature: CloudAccountFeature!,$subscriptionStatusFilters: [CloudAccountStatus!]!,$subscriptionSearchText: String!,$subscriptionIdsFilter: [UUID!])",
                "AzureCloudAccountTenant",
                Query.AzureCloudAccountTenant_ObjectFieldSpec,
                Query.AzureCloudAccountTenantFieldSpec,
                @"# REQUIRED
$query.Var.tenantId = $someString
# REQUIRED
$query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$query.Var.subscriptionStatusFilters = @(
	$someCloudAccountStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountStatus]) for enum values.
)
# REQUIRED
$query.Var.subscriptionSearchText = $someString
# OPTIONAL
$query.Var.subscriptionIdsFilter = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // azureCloudAccountTenantWithExoConfigs(
        //     tenantId: UUID!
        //     feature: CloudAccountFeature!
        //     subscriptionStatusFilters: [CloudAccountStatus!]!
        //     subscriptionSearchText: String!
        //     subscriptionIdsFilter: [UUID!]
        //   ): AzureCloudAccountTenantWithExoConfigs!
        internal void InitQueryAzureCloudAccountTenantWithExoConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("subscriptionStatusFilters", "[CloudAccountStatus!]!"),
                Tuple.Create("subscriptionSearchText", "String!"),
                Tuple.Create("subscriptionIdsFilter", "[UUID!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureCloudAccountTenantWithExoConfigs",
                "($tenantId: UUID!,$feature: CloudAccountFeature!,$subscriptionStatusFilters: [CloudAccountStatus!]!,$subscriptionSearchText: String!,$subscriptionIdsFilter: [UUID!])",
                "AzureCloudAccountTenantWithExoConfigs",
                Query.AzureCloudAccountTenantWithExoConfigs_ObjectFieldSpec,
                Query.AzureCloudAccountTenantWithExoConfigsFieldSpec,
                @"# REQUIRED
$query.Var.tenantId = $someString
# REQUIRED
$query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$query.Var.subscriptionStatusFilters = @(
	$someCloudAccountStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountStatus]) for enum values.
)
# REQUIRED
$query.Var.subscriptionSearchText = $someString
# OPTIONAL
$query.Var.subscriptionIdsFilter = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // allAzureCloudAccountTenants(features: [CloudAccountFeature!], feature: CloudAccountFeature!, includeSubscriptionDetails: Boolean!): [AzureCloudAccountTenant!]!
        internal void InitQueryAllAzureCloudAccountTenants()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("features", "[CloudAccountFeature!]"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("includeSubscriptionDetails", "Boolean!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureCloudAccountTenants",
                "($features: [CloudAccountFeature!],$feature: CloudAccountFeature!,$includeSubscriptionDetails: Boolean!)",
                "List<AzureCloudAccountTenant>",
                Query.AllAzureCloudAccountTenants_ObjectFieldSpec,
                Query.AllAzureCloudAccountTenantsFieldSpec,
                @"# OPTIONAL
$query.Var.features = @(
	$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
)
# REQUIRED
$query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$query.Var.includeSubscriptionDetails = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // allAzureDiskEncryptionSetsByRegion(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!): [AzureNativeDiskEncryptionSet!]!
        internal void InitQueryAllAzureDiskEncryptionSetsByRegion()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("region", "AzureNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureDiskEncryptionSetsByRegion",
                "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!)",
                "List<AzureNativeDiskEncryptionSet>",
                Query.AllAzureDiskEncryptionSetsByRegion_ObjectFieldSpec,
                Query.AllAzureDiskEncryptionSetsByRegionFieldSpec,
                @"# REQUIRED
$query.Var.azureSubscriptionRubrikId = $someString
# REQUIRED
$query.Var.region = $someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allAzureEncryptionKeys(azureEncryptionKeysInput: AzureEncryptionKeysInput!): [AzureEncryptionKey!]!
        internal void InitQueryAllAzureEncryptionKeys()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureEncryptionKeysInput", "AzureEncryptionKeysInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureEncryptionKeys",
                "($azureEncryptionKeysInput: AzureEncryptionKeysInput!)",
                "List<AzureEncryptionKey>",
                Query.AllAzureEncryptionKeys_ObjectFieldSpec,
                Query.AllAzureEncryptionKeysFieldSpec,
                @"# REQUIRED
$query.Var.azureEncryptionKeysInput = @{
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	keyVaultName = $someString
	# REQUIRED
	resourceGroupName = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // allAzureExocomputeConfigsInAccount(azureExocomputeSearchQuery: String, cloudAccountIDs: [UUID!]): [AzureExocomputeConfigsInAccount!]!
        internal void InitQueryAllAzureExocomputeConfigsInAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureExocomputeSearchQuery", "String"),
                Tuple.Create("cloudAccountIDs", "[UUID!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureExocomputeConfigsInAccount",
                "($azureExocomputeSearchQuery: String,$cloudAccountIDs: [UUID!])",
                "List<AzureExocomputeConfigsInAccount>",
                Query.AllAzureExocomputeConfigsInAccount_ObjectFieldSpec,
                Query.AllAzureExocomputeConfigsInAccountFieldSpec,
                @"# OPTIONAL
$query.Var.azureExocomputeSearchQuery = $someString
# OPTIONAL
$query.Var.cloudAccountIDs = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // hasRelicAzureAdSnapshot(input: HasRelicAzureAdSnapshotInput!): HasRelicAzureAdSnapshotReplyType!
        internal void InitQueryHasRelicAzureAdSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "HasRelicAzureAdSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHasRelicAzureAdSnapshot",
                "($input: HasRelicAzureAdSnapshotInput!)",
                "HasRelicAzureAdSnapshotReplyType",
                Query.HasRelicAzureAdSnapshot_ObjectFieldSpec,
                Query.HasRelicAzureAdSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	domainName = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // allHostedAzureRegions: AzureRegionsResp!
        internal void InitQueryAllHostedAzureRegions()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllHostedAzureRegions",
                "",
                "AzureRegionsResp",
                Query.AllHostedAzureRegions_ObjectFieldSpec,
                Query.AllHostedAzureRegionsFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // isAzureStorageAccountNameAvailable(azureSubscriptionRubrikId: UUID!, storageAccountName: String!): Boolean!
        internal void InitQueryIsAzureStorageAccountNameAvailable()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("storageAccountName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsAzureStorageAccountNameAvailable",
                "($azureSubscriptionRubrikId: UUID!,$storageAccountName: String!)",
                "System.Boolean",
                Query.IsAzureStorageAccountNameAvailable_ObjectFieldSpec,
                Query.IsAzureStorageAccountNameAvailableFieldSpec,
                @"# REQUIRED
$query.Var.azureSubscriptionRubrikId = $someString
# REQUIRED
$query.Var.storageAccountName = $someString"
            );
        }

        // Create new GraphQL Query:
        // allAzureKeyVaultsByRegion(azureKeyVaultsInput: AzureKeyVaultsInput!): [AzureKeyVault!]!
        internal void InitQueryAllAzureKeyVaultsByRegion()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureKeyVaultsInput", "AzureKeyVaultsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureKeyVaultsByRegion",
                "($azureKeyVaultsInput: AzureKeyVaultsInput!)",
                "List<AzureKeyVault>",
                Query.AllAzureKeyVaultsByRegion_ObjectFieldSpec,
                Query.AllAzureKeyVaultsByRegionFieldSpec,
                @"# REQUIRED
$query.Var.azureKeyVaultsInput = @{
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
	# OPTIONAL
	userAssignedManagedIdentityPrincipalId = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // allAzureManagedIdentities(managedIdentitiesRequest: AzureManagedIdentitiesRequest!): [AzureManagedIdentity!]!
        internal void InitQueryAllAzureManagedIdentities()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("managedIdentitiesRequest", "AzureManagedIdentitiesRequest!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureManagedIdentities",
                "($managedIdentitiesRequest: AzureManagedIdentitiesRequest!)",
                "List<AzureManagedIdentity>",
                Query.AllAzureManagedIdentities_ObjectFieldSpec,
                Query.AllAzureManagedIdentitiesFieldSpec,
                @"# REQUIRED
$query.Var.managedIdentitiesRequest = @{
	# REQUIRED
	cloudAccountId = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // allAzureNsgs(nsgRequest: AzureNsgRequest!): [String!]!
        internal void InitQueryAllAzureNsgs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("nsgRequest", "AzureNsgRequest!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNsgs",
                "($nsgRequest: AzureNsgRequest!)",
                "List<System.String>",
                Query.AllAzureNsgs_ObjectFieldSpec,
                Query.AllAzureNsgsFieldSpec,
                @"# REQUIRED
$query.Var.nsgRequest = @{
	# OPTIONAL
	cloudAccountId = $someString
	# OPTIONAL
	resourceGroup = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // azureRegions(tenantId: String!, subscriptionId: UUID!): RegionConnection!
        internal void InitQueryAzureRegions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureRegions",
                "($tenantId: String!,$subscriptionId: UUID!)",
                "RegionConnection",
                Query.AzureRegions_ObjectFieldSpec,
                Query.AzureRegionsFieldSpec,
                @"# REQUIRED
$query.Var.tenantId = $someString
# REQUIRED
$query.Var.subscriptionId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allResourceGroupsFromAzure(cloudAccountId: UUID!, azureSubscriptionNativeId: UUID!, feature: CloudAccountFeature!): [AzureResourceGroup!]!
        internal void InitQueryAllResourceGroupsFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
                Tuple.Create("azureSubscriptionNativeId", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllResourceGroupsFromAzure",
                "($cloudAccountId: UUID!,$azureSubscriptionNativeId: UUID!,$feature: CloudAccountFeature!)",
                "List<AzureResourceGroup>",
                Query.AllResourceGroupsFromAzure_ObjectFieldSpec,
                Query.AllResourceGroupsFromAzureFieldSpec,
                @"# REQUIRED
$query.Var.cloudAccountId = $someString
# REQUIRED
$query.Var.azureSubscriptionNativeId = $someString
# REQUIRED
$query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // searchAzureAdSnapshot(first: Int, after: String, input: SearchAzureAdSnapshotInput!): AzureAdObjectConnection!
        internal void InitQuerySearchAzureAdSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("input", "SearchAzureAdSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySearchAzureAdSnapshot",
                "($first: Int,$after: String,$input: SearchAzureAdSnapshotInput!)",
                "AzureAdObjectConnection",
                Query.SearchAzureAdSnapshot_ObjectFieldSpec,
                Query.SearchAzureAdSnapshotFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotId = $someString
	# REQUIRED
	azureAdSearchKeyword = $someString
	# REQUIRED
	azureAdObjectType = $someAzureAdObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdObjectType]) for enum values.
	# REQUIRED
	azureAdSearchKeywordType = $someAzureAdObjectSearchType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdObjectSearchType]) for enum values.
}"
            );
        }

        // Create new GraphQL Query:
        // azureSqlDatabase(azureSqlDatabaseRubrikId: UUID!): AzureSqlDatabaseDb!
        internal void InitQueryAzureSqlDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlDatabaseRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlDatabase",
                "($azureSqlDatabaseRubrikId: UUID!)",
                "AzureSqlDatabaseDb",
                Query.AzureSqlDatabase_ObjectFieldSpec,
                Query.AzureSqlDatabaseFieldSpec,
                @"# REQUIRED
$query.Var.azureSqlDatabaseRubrikId = $someString"
            );
        }

        // Create new GraphQL Query:
        // azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure(
        //     subscriptionId: UUID!
        //     resourceGroupName: String!
        //     azureSqlDatabaseServerName: String!
        //     azureSqlDatabaseName: String!
        //   ): AzureNativeSqlDatabasePointInTimeRestoreWindow!
        internal void InitQueryAzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("azureSqlDatabaseServerName", "String!"),
                Tuple.Create("azureSqlDatabaseName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure",
                "($subscriptionId: UUID!,$resourceGroupName: String!,$azureSqlDatabaseServerName: String!,$azureSqlDatabaseName: String!)",
                "AzureNativeSqlDatabasePointInTimeRestoreWindow",
                Query.AzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure_ObjectFieldSpec,
                Query.AzureSqlDatabaseDbPointInTimeRestoreWindowFromAzureFieldSpec,
                @"# REQUIRED
$query.Var.subscriptionId = $someString
# REQUIRED
$query.Var.resourceGroupName = $someString
# REQUIRED
$query.Var.azureSqlDatabaseServerName = $someString
# REQUIRED
$query.Var.azureSqlDatabaseName = $someString"
            );
        }

        // Create new GraphQL Query:
        // azureSqlDatabaseServer(azureSqlDatabaseServerRubrikId: UUID!): AzureSqlDatabaseServer!
        internal void InitQueryAzureSqlDatabaseServer()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlDatabaseServerRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlDatabaseServer",
                "($azureSqlDatabaseServerRubrikId: UUID!)",
                "AzureSqlDatabaseServer",
                Query.AzureSqlDatabaseServer_ObjectFieldSpec,
                Query.AzureSqlDatabaseServerFieldSpec,
                @"# REQUIRED
$query.Var.azureSqlDatabaseServerRubrikId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allAzureSqlDatabaseServerElasticPools(
        //     subscriptionId: UUID!
        //     resourceGroupName: String!
        //     azureSqlDatabaseServerName: String!
        //     azureSqlDatabaseServerRubrikId: UUID!
        //   ): [AzureSqlDatabaseServerElasticPool!]!
        internal void InitQueryAllAzureSqlDatabaseServerElasticPools()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("azureSqlDatabaseServerName", "String!"),
                Tuple.Create("azureSqlDatabaseServerRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureSqlDatabaseServerElasticPools",
                "($subscriptionId: UUID!,$resourceGroupName: String!,$azureSqlDatabaseServerName: String!,$azureSqlDatabaseServerRubrikId: UUID!)",
                "List<AzureSqlDatabaseServerElasticPool>",
                Query.AllAzureSqlDatabaseServerElasticPools_ObjectFieldSpec,
                Query.AllAzureSqlDatabaseServerElasticPoolsFieldSpec,
                @"# REQUIRED
$query.Var.subscriptionId = $someString
# REQUIRED
$query.Var.resourceGroupName = $someString
# REQUIRED
$query.Var.azureSqlDatabaseServerName = $someString
# REQUIRED
$query.Var.azureSqlDatabaseServerRubrikId = $someString"
            );
        }

        // Create new GraphQL Query:
        // azureSqlDatabaseServers(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AzureSqlDatabaseServerSortFields
        //     sortOrder: SortOrder
        //     azureSqlDatabaseServerFilters: AzureSqlDatabaseServerFilters
        //   ): AzureSqlDatabaseServerConnection!
        internal void InitQueryAzureSqlDatabaseServers()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AzureSqlDatabaseServerSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("azureSqlDatabaseServerFilters", "AzureSqlDatabaseServerFilters"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlDatabaseServers",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureSqlDatabaseServerSortFields,$sortOrder: SortOrder,$azureSqlDatabaseServerFilters: AzureSqlDatabaseServerFilters)",
                "AzureSqlDatabaseServerConnection",
                Query.AzureSqlDatabaseServers_ObjectFieldSpec,
                Query.AzureSqlDatabaseServersFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someAzureSqlDatabaseServerSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlDatabaseServerSortFields]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.azureSqlDatabaseServerFilters = @{
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
}"
            );
        }

        // Create new GraphQL Query:
        // azureSqlDatabases(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AzureSqlDatabaseSortFields
        //     sortOrder: SortOrder
        //     azureSqlDatabaseFilters: AzureSqlDatabaseFilters
        //   ): AzureSqlDatabaseDbConnection!
        internal void InitQueryAzureSqlDatabases()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AzureSqlDatabaseSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("azureSqlDatabaseFilters", "AzureSqlDatabaseFilters"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlDatabases",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureSqlDatabaseSortFields,$sortOrder: SortOrder,$azureSqlDatabaseFilters: AzureSqlDatabaseFilters)",
                "AzureSqlDatabaseDbConnection",
                Query.AzureSqlDatabases_ObjectFieldSpec,
                Query.AzureSqlDatabasesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someAzureSqlDatabaseSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlDatabaseSortFields]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.azureSqlDatabaseFilters = @{
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
	serverFilter = @{
		# REQUIRED
		serverNames = @(
			$someString
		)
	}
}"
            );
        }

        // Create new GraphQL Query:
        // azureSqlManagedInstanceDatabase(azureSqlManagedInstanceDatabaseRubrikId: UUID!): AzureSqlManagedInstanceDatabase!
        internal void InitQueryAzureSqlManagedInstanceDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlManagedInstanceDatabaseRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlManagedInstanceDatabase",
                "($azureSqlManagedInstanceDatabaseRubrikId: UUID!)",
                "AzureSqlManagedInstanceDatabase",
                Query.AzureSqlManagedInstanceDatabase_ObjectFieldSpec,
                Query.AzureSqlManagedInstanceDatabaseFieldSpec,
                @"# REQUIRED
$query.Var.azureSqlManagedInstanceDatabaseRubrikId = $someString"
            );
        }

        // Create new GraphQL Query:
        // azureSqlManagedInstanceDatabases(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AzureSqlManagedInstanceDatabaseSortFields
        //     sortOrder: SortOrder
        //     azureSqlManagedInstanceDatabaseFilters: AzureSqlManagedInstanceDatabaseFilters
        //   ): AzureSqlManagedInstanceDatabaseConnection!
        internal void InitQueryAzureSqlManagedInstanceDatabases()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AzureSqlManagedInstanceDatabaseSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("azureSqlManagedInstanceDatabaseFilters", "AzureSqlManagedInstanceDatabaseFilters"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlManagedInstanceDatabases",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureSqlManagedInstanceDatabaseSortFields,$sortOrder: SortOrder,$azureSqlManagedInstanceDatabaseFilters: AzureSqlManagedInstanceDatabaseFilters)",
                "AzureSqlManagedInstanceDatabaseConnection",
                Query.AzureSqlManagedInstanceDatabases_ObjectFieldSpec,
                Query.AzureSqlManagedInstanceDatabasesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someAzureSqlManagedInstanceDatabaseSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlManagedInstanceDatabaseSortFields]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.azureSqlManagedInstanceDatabaseFilters = @{
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
	relicFilter = @{
		# REQUIRED
		relic = $someBoolean
	}
	# OPTIONAL
	serverFilter = @{
		# REQUIRED
		serverNames = @(
			$someString
		)
	}
}"
            );
        }

        // Create new GraphQL Query:
        // azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure(
        //     subscriptionId: UUID!
        //     resourceGroupName: String!
        //     azureSqlManagedInstanceName: String!
        //     azureSqlDatabaseName: String!
        //   ): AzureNativeSqlDatabasePointInTimeRestoreWindow!
        internal void InitQueryAzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("azureSqlManagedInstanceName", "String!"),
                Tuple.Create("azureSqlDatabaseName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure",
                "($subscriptionId: UUID!,$resourceGroupName: String!,$azureSqlManagedInstanceName: String!,$azureSqlDatabaseName: String!)",
                "AzureNativeSqlDatabasePointInTimeRestoreWindow",
                Query.AzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure_ObjectFieldSpec,
                Query.AzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzureFieldSpec,
                @"# REQUIRED
$query.Var.subscriptionId = $someString
# REQUIRED
$query.Var.resourceGroupName = $someString
# REQUIRED
$query.Var.azureSqlManagedInstanceName = $someString
# REQUIRED
$query.Var.azureSqlDatabaseName = $someString"
            );
        }

        // Create new GraphQL Query:
        // azureSqlManagedInstanceServer(azureSqlManagedInstanceServerRubrikId: UUID!): AzureSqlManagedInstanceServer!
        internal void InitQueryAzureSqlManagedInstanceServer()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlManagedInstanceServerRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlManagedInstanceServer",
                "($azureSqlManagedInstanceServerRubrikId: UUID!)",
                "AzureSqlManagedInstanceServer",
                Query.AzureSqlManagedInstanceServer_ObjectFieldSpec,
                Query.AzureSqlManagedInstanceServerFieldSpec,
                @"# REQUIRED
$query.Var.azureSqlManagedInstanceServerRubrikId = $someString"
            );
        }

        // Create new GraphQL Query:
        // azureSqlManagedInstanceServers(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AzureSqlManagedInstanceServerSortFields
        //     sortOrder: SortOrder
        //     azureSqlManagedInstanceServerFilters: AzureSqlManagedInstanceServerFilters
        //   ): AzureSqlManagedInstanceServerConnection!
        internal void InitQueryAzureSqlManagedInstanceServers()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AzureSqlManagedInstanceServerSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("azureSqlManagedInstanceServerFilters", "AzureSqlManagedInstanceServerFilters"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlManagedInstanceServers",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureSqlManagedInstanceServerSortFields,$sortOrder: SortOrder,$azureSqlManagedInstanceServerFilters: AzureSqlManagedInstanceServerFilters)",
                "AzureSqlManagedInstanceServerConnection",
                Query.AzureSqlManagedInstanceServers_ObjectFieldSpec,
                Query.AzureSqlManagedInstanceServersFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someAzureSqlManagedInstanceServerSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlManagedInstanceServerSortFields]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.azureSqlManagedInstanceServerFilters = @{
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
}"
            );
        }

        // Create new GraphQL Query:
        // azureStorageAccounts(tenantId: String!, subscriptionId: UUID!, regionName: String!): StorageAccountConnection!
        internal void InitQueryAzureStorageAccounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("regionName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureStorageAccounts",
                "($tenantId: String!,$subscriptionId: UUID!,$regionName: String!)",
                "StorageAccountConnection",
                Query.AzureStorageAccounts_ObjectFieldSpec,
                Query.AzureStorageAccountsFieldSpec,
                @"# REQUIRED
$query.Var.tenantId = $someString
# REQUIRED
$query.Var.subscriptionId = $someString
# REQUIRED
$query.Var.regionName = $someString"
            );
        }

        // Create new GraphQL Query:
        // allAzureStorageAccountsByRegion(input: AzureStorageAccountsByRegionInput!): [AzureStorageAccountCcprovision!]!
        internal void InitQueryAllAzureStorageAccountsByRegion()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AzureStorageAccountsByRegionInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureStorageAccountsByRegion",
                "($input: AzureStorageAccountsByRegionInput!)",
                "List<AzureStorageAccountCcprovision>",
                Query.AllAzureStorageAccountsByRegion_ObjectFieldSpec,
                Query.AllAzureStorageAccountsByRegionFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	cloudAccountId = $someString
	# OPTIONAL
	region = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // azureSubnets(tenantId: String!, subscriptionId: UUID!, vNetId: String!): SubnetConnection!
        internal void InitQueryAzureSubnets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("vNetId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSubnets",
                "($tenantId: String!,$subscriptionId: UUID!,$vNetId: String!)",
                "SubnetConnection",
                Query.AzureSubnets_ObjectFieldSpec,
                Query.AzureSubnetsFieldSpec,
                @"# REQUIRED
$query.Var.tenantId = $someString
# REQUIRED
$query.Var.subscriptionId = $someString
# REQUIRED
$query.Var.vNetId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allAzureSubscriptionWithExocomputeMappings(features: [CloudAccountFeature!], exocomputeSubscriptionIdsFilter: [UUID!]): [AzureSubscriptionWithExocomputeMapping!]!
        internal void InitQueryAllAzureSubscriptionWithExocomputeMappings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("features", "[CloudAccountFeature!]"),
                Tuple.Create("exocomputeSubscriptionIdsFilter", "[UUID!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureSubscriptionWithExocomputeMappings",
                "($features: [CloudAccountFeature!],$exocomputeSubscriptionIdsFilter: [UUID!])",
                "List<AzureSubscriptionWithExocomputeMapping>",
                Query.AllAzureSubscriptionWithExocomputeMappings_ObjectFieldSpec,
                Query.AllAzureSubscriptionWithExocomputeMappingsFieldSpec,
                @"# OPTIONAL
$query.Var.features = @(
	$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
)
# OPTIONAL
$query.Var.exocomputeSubscriptionIdsFilter = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // azureSubscriptions(tenantId: String!): AzureSubscriptionConnection!
        internal void InitQueryAzureSubscriptions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSubscriptions",
                "($tenantId: String!)",
                "AzureSubscriptionConnection",
                Query.AzureSubscriptions_ObjectFieldSpec,
                Query.AzureSubscriptionsFieldSpec,
                @"# REQUIRED
$query.Var.tenantId = $someString"
            );
        }

        // Create new GraphQL Query:
        // azureVNets(tenantId: String!, subscriptionId: UUID!, regionName: String!): VnetConnection!
        internal void InitQueryAzureVnets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("regionName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureVnets",
                "($tenantId: String!,$subscriptionId: UUID!,$regionName: String!)",
                "VnetConnection",
                Query.AzureVnets_ObjectFieldSpec,
                Query.AzureVnetsFieldSpec,
                @"# REQUIRED
$query.Var.tenantId = $someString
# REQUIRED
$query.Var.subscriptionId = $someString
# REQUIRED
$query.Var.regionName = $someString"
            );
        }

        // Create new GraphQL Query:
        // validateAzureCloudAccountExocomputeConfigurations(input: ValidateAzureCloudAccountExocomputeConfigurationsInput!): ValidateAzureSubnetsForCloudAccountExocomputeReply!
        internal void InitQueryValidateAzureCloudAccountExocomputeConfigurations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ValidateAzureCloudAccountExocomputeConfigurationsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryValidateAzureCloudAccountExocomputeConfigurations",
                "($input: ValidateAzureCloudAccountExocomputeConfigurationsInput!)",
                "ValidateAzureSubnetsForCloudAccountExocomputeReply",
                Query.ValidateAzureCloudAccountExocomputeConfigurations_ObjectFieldSpec,
                Query.ValidateAzureCloudAccountExocomputeConfigurationsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	azureExocomputeRegionConfigs = @(
		@{
			# REQUIRED
			region = $someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
			# REQUIRED
			subnetNativeId = $someString
			# REQUIRED
			isRscManaged = $someBoolean
			# OPTIONAL
			podSubnetNativeId = $someString
			# OPTIONAL
			podOverlayNetworkCidr = $someString
		}
	)
}"
            );
        }


    } // class New_RscQueryAzure
}