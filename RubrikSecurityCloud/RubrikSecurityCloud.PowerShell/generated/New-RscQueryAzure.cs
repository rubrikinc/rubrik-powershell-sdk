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
    /// Create a new RscQuery object for any of the 58
    /// operations in the 'Azure' API domain:
    /// AdDirectories, AdDirectory, AdObjectsByType, ArmTemplatesByFeature, AzureRegions, AzureStorageAccounts, AzureVnets, BlobContainersByStorageAccount, CdmVersions, CheckPersistentStorageSubscriptionCanUnmap, CloudAccountDetailsForFeature, CloudAccountMissingPermissions, CloudAccountPermissionConfig, CloudAccountSubnetsByRegion, CloudAccountSubscriptionWithFeatures, CloudAccountSubscriptionsByFeature, CloudAccountTenant, CloudAccountTenantWithExoConfigs, CloudAccountTenants, DiskEncryptionSetsByRegion, EncryptionKeys, ExocomputeConfigsInAccount, ExocomputeNetworkSetupTemplate, HasRelicAdSnapshot, HostedAzureRegions, IsStorageAccountNameAvailable, KeyVaultsByRegion, ManagedIdentities, MarketplaceTermsInfo, Nsgs, RcvBliMigrationDetails, Regions, RegionsWithAzDetails, ResourceGroups, ResourceGroupsFromAzure, SearchAdSnapshot, SqlDatabase, SqlDatabaseDbPointInTimeRestoreWindowFromAzure, SqlDatabaseServer, SqlDatabaseServerElasticPools, SqlDatabaseServers, SqlDatabases, SqlManagedInstanceDatabase, SqlManagedInstanceDatabases, SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure, SqlManagedInstanceServer, SqlManagedInstanceServers, StorageAccountContainers, StorageAccountExcludedContainers, StorageAccounts, StorageAccountsByRegion, Subnets, SubscriptionWithExocomputeMappings, Subscriptions, SupportedAdRegions, VNets, ValidateCloudAccountExocomputeConfigurations, or ValidateCreateClusterInput.
    /// </summary>
    /// <description>
    /// New-RscQueryAzure creates a new
    /// query object for operations
    /// in the 'Azure' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 58 operations
    /// in the 'Azure' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AdDirectories, AdDirectory, AdObjectsByType, ArmTemplatesByFeature, AzureRegions, AzureStorageAccounts, AzureVnets, BlobContainersByStorageAccount, CdmVersions, CheckPersistentStorageSubscriptionCanUnmap, CloudAccountDetailsForFeature, CloudAccountMissingPermissions, CloudAccountPermissionConfig, CloudAccountSubnetsByRegion, CloudAccountSubscriptionWithFeatures, CloudAccountSubscriptionsByFeature, CloudAccountTenant, CloudAccountTenantWithExoConfigs, CloudAccountTenants, DiskEncryptionSetsByRegion, EncryptionKeys, ExocomputeConfigsInAccount, ExocomputeNetworkSetupTemplate, HasRelicAdSnapshot, HostedAzureRegions, IsStorageAccountNameAvailable, KeyVaultsByRegion, ManagedIdentities, MarketplaceTermsInfo, Nsgs, RcvBliMigrationDetails, Regions, RegionsWithAzDetails, ResourceGroups, ResourceGroupsFromAzure, SearchAdSnapshot, SqlDatabase, SqlDatabaseDbPointInTimeRestoreWindowFromAzure, SqlDatabaseServer, SqlDatabaseServerElasticPools, SqlDatabaseServers, SqlDatabases, SqlManagedInstanceDatabase, SqlManagedInstanceDatabases, SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure, SqlManagedInstanceServer, SqlManagedInstanceServers, StorageAccountContainers, StorageAccountExcludedContainers, StorageAccounts, StorageAccountsByRegion, Subnets, SubscriptionWithExocomputeMappings, Subscriptions, SupportedAdRegions, VNets, ValidateCloudAccountExocomputeConfigurations, or ValidateCreateClusterInput.
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
    /// $query = New-RscQueryAzure -Operation AdDirectories
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
    /// $query = New-RscQueryAzure -Operation AdDirectory
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
    /// $query = New-RscQueryAzure -Operation AdObjectsByType
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
    /// 	workloadFid = $someString
    /// 	# REQUIRED
    /// 	keywordSearchFilters = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			searchKeyword = $someString
    /// 			# OPTIONAL
    /// 			searchKeywordType = $someString
    /// 		}
    /// 	)
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
    /// $query = New-RscQueryAzure -Operation ArmTemplatesByFeature
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	customerTenantDomainName = $someString
    /// 	# OPTIONAL
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
    /// Runs the AzureRegions operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: AzureRegions
    /// 
    /// $query = New-RscQueryAzure -Operation AzureRegions
    /// 
    /// # REQUIRED
    /// $query.Var.cloudAccountId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AzureCloudAccountRegion&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AzureStorageAccounts operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: AzureStorageAccounts
    /// 
    /// $query = New-RscQueryAzure -Operation AzureStorageAccounts
    /// 
    /// # REQUIRED
    /// $query.Var.storageAccountsRequest = @{
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
    /// Runs the AzureVnets operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: AzureVnets
    /// 
    /// $query = New-RscQueryAzure -Operation AzureVnets
    /// 
    /// # REQUIRED
    /// $query.Var.vnetRequest = @{
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
    /// Runs the BlobContainersByStorageAccount operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: BlobContainersByStorageAccount
    /// 
    /// $query = New-RscQueryAzure -Operation BlobContainersByStorageAccount
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
    /// 	cloudAccountId = $someString
    /// 	# OPTIONAL
    /// 	resourceGroup = $someString
    /// 	# OPTIONAL
    /// 	storageAccount = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureBlobContainerCcprovisionConnection
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
    /// $query = New-RscQueryAzure -Operation CdmVersions
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
    /// $query = New-RscQueryAzure -Operation CheckPersistentStorageSubscriptionCanUnmap
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
    /// Runs the CloudAccountDetailsForFeature operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CloudAccountDetailsForFeature
    /// 
    /// $query = New-RscQueryAzure -Operation CloudAccountDetailsForFeature
    /// 
    /// # REQUIRED
    /// $query.Var.featureId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureCloudAccountDetailsForFeatureReply
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
    /// $query = New-RscQueryAzure -Operation CloudAccountMissingPermissions
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
    /// $query = New-RscQueryAzure -Operation CloudAccountPermissionConfig
    /// 
    /// # REQUIRED
    /// $query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// # REQUIRED
    /// $query.Var.permissionsGroups = @(
    /// 	$somePermissionsGroup # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
    /// )
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
    /// $query = New-RscQueryAzure -Operation CloudAccountSubnetsByRegion
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
    /// $query = New-RscQueryAzure -Operation CloudAccountSubscriptionWithFeatures
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
    /// $query = New-RscQueryAzure -Operation CloudAccountSubscriptionsByFeature
    /// 
    /// # REQUIRED
    /// $query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// # REQUIRED
    /// $query.Var.subscriptionStatusFilters = @(
    /// 	$someCloudAccountStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountStatus]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.permissionsGroupFilters = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		featureType = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 		# OPTIONAL
    /// 		permissionsGroups = @(
    /// 			$somePermissionsGroup # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
    /// 		)
    /// }
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
    /// $query = New-RscQueryAzure -Operation CloudAccountTenant
    /// 
    /// # REQUIRED
    /// $query.Var.tenantId = $someString
    /// # REQUIRED
    /// $query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// # OPTIONAL
    /// $query.Var.features = @(
    /// 	$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// )
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
    /// $query = New-RscQueryAzure -Operation CloudAccountTenantWithExoConfigs
    /// 
    /// # REQUIRED
    /// $query.Var.tenantId = $someString
    /// # REQUIRED
    /// $query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// # OPTIONAL
    /// $query.Var.features = @(
    /// 	$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// )
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
    /// $query = New-RscQueryAzure -Operation CloudAccountTenants
    /// 
    /// # OPTIONAL
    /// $query.Var.features = @(
    /// 	$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// )
    /// # REQUIRED
    /// $query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// # REQUIRED
    /// $query.Var.includeSubscriptionDetails = $someBoolean
    /// # OPTIONAL
    /// $query.Var.azureTenants = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.status = @(
    /// 	$someCloudAccountStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountStatus]) for enum values.
    /// )
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
    /// $query = New-RscQueryAzure -Operation DiskEncryptionSetsByRegion
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
    /// $query = New-RscQueryAzure -Operation EncryptionKeys
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
    /// $query = New-RscQueryAzure -Operation ExocomputeConfigsInAccount
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
    /// Runs the ExocomputeNetworkSetupTemplate operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: ExocomputeNetworkSetupTemplate
    /// 
    /// $query = New-RscQueryAzure -Operation ExocomputeNetworkSetupTemplate
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	locations = @(
    /// 		$someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GetAzureExocomputeNetworkSetupTemplateReply
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
    /// $query = New-RscQueryAzure -Operation HasRelicAdSnapshot
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
    /// $query = New-RscQueryAzure -Operation HostedAzureRegions
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
    /// $query = New-RscQueryAzure -Operation IsStorageAccountNameAvailable
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
    /// $query = New-RscQueryAzure -Operation KeyVaultsByRegion
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
    /// $query = New-RscQueryAzure -Operation ManagedIdentities
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
    /// Runs the MarketplaceTermsInfo operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: MarketplaceTermsInfo
    /// 
    /// $query = New-RscQueryAzure -Operation MarketplaceTermsInfo
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	cloudAccountId = $someString
    /// 	# OPTIONAL
    /// 	cdmVersion = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CheckAzureMarketplaceTermsReply
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
    /// $query = New-RscQueryAzure -Operation Nsgs
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
    /// Runs the RcvBliMigrationDetails operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: RcvBliMigrationDetails
    /// 
    /// $query = New-RscQueryAzure -Operation RcvBliMigrationDetails
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
    /// $query.Var.BliMigrationDetailsFilter = @{
    /// 	# OPTIONAL
    /// 	migrationStatuses = @(
    /// 		$someBliMigrationStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BliMigrationStatus]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	clusterIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	tiers = @(
    /// 		$someRcvTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RcvTier]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	regions = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			cloudSpecificRegion = @{
    /// 				# OPTIONAL
    /// 				azureRegion = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
    /// 				# OPTIONAL
    /// 				awsRegion = $someAwsRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
    /// 				# OPTIONAL
    /// 				gcpRegion = $someGcpRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GcpRegion]) for enum values.
    /// 			}
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	locationStatuses = @(
    /// 		$someArchivalLocationStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ArchivalLocationStatus]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	unavailabilityReasons = @(
    /// 		$someMigrationUnavailabilityReason # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MigrationUnavailabilityReason]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	searchByLocationName = $someString
    /// }
    /// # OPTIONAL
    /// $query.Var.sortBy = $someRcvBliMigrationDetailsSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RcvBliMigrationDetailsSortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RcvBliMigrationDetailsConnection
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
    /// $query = New-RscQueryAzure -Operation Regions
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
    /// Runs the RegionsWithAzDetails operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: RegionsWithAzDetails
    /// 
    /// $query = New-RscQueryAzure -Operation RegionsWithAzDetails
    /// 
    /// # REQUIRED
    /// $query.Var.cloudAccountId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AzureLocationDetailType&gt;
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
    /// $query = New-RscQueryAzure -Operation ResourceGroups
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
    /// Write-Host $result.GetType().Name # prints: ResourceGroupConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ResourceGroupsFromAzure operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: ResourceGroupsFromAzure
    /// 
    /// $query = New-RscQueryAzure -Operation ResourceGroupsFromAzure
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
    /// $query = New-RscQueryAzure -Operation SearchAdSnapshot
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
    /// 	workloadFid = $someString
    /// 	# REQUIRED
    /// 	keywordSearchFilters = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			searchKeyword = $someString
    /// 			# OPTIONAL
    /// 			searchKeywordType = $someString
    /// 		}
    /// 	)
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
    /// $query = New-RscQueryAzure -Operation SqlDatabase
    /// 
    /// # REQUIRED
    /// $query.Var.azureSqlDatabaseRubrikId = $someString
    /// # OPTIONAL
    /// $query.Var.includeSecurityMetadata = $someBoolean
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
    /// $query = New-RscQueryAzure -Operation SqlDatabaseDbPointInTimeRestoreWindowFromAzure
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
    /// $query = New-RscQueryAzure -Operation SqlDatabaseServer
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
    /// $query = New-RscQueryAzure -Operation SqlDatabaseServerElasticPools
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
    /// $query = New-RscQueryAzure -Operation SqlDatabaseServers
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
    /// 	# OPTIONAL
    /// 	azureNativeIsEligibleForSqlDatabaseServerProtectionFilter = @{
    /// 		# REQUIRED
    /// 		isEligibleForProtection = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	isEligibleForProtection = $someBoolean
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
    /// $query = New-RscQueryAzure -Operation SqlDatabases
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
    /// 	sensitivityStatusFilter = @{
    /// 		# REQUIRED
    /// 		sensitivityStatuses = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	protectionStatusFilter = @{
    /// 		# REQUIRED
    /// 		protectionStatuses = @(
    /// 			$someString
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
    /// 	# OPTIONAL
    /// 	serverFilter = @{
    /// 		# REQUIRED
    /// 		serverNames = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	serverId = $someString
    /// 	# OPTIONAL
    /// 	azureNativeIsEligibleForSqlDatabaseDbProtectionFilter = @{
    /// 		# REQUIRED
    /// 		isEligibleForProtection = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	isEligibleForProtection = $someBoolean
    /// }
    /// # OPTIONAL
    /// $query.Var.includeSecurityMetadata = $someBoolean
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
    /// $query = New-RscQueryAzure -Operation SqlManagedInstanceDatabase
    /// 
    /// # REQUIRED
    /// $query.Var.azureSqlManagedInstanceDatabaseRubrikId = $someString
    /// # OPTIONAL
    /// $query.Var.includeSecurityMetadata = $someBoolean
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
    /// $query = New-RscQueryAzure -Operation SqlManagedInstanceDatabases
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
    /// 	sensitivityStatusFilter = @{
    /// 		# REQUIRED
    /// 		sensitivityStatuses = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	protectionStatusFilter = @{
    /// 		# REQUIRED
    /// 		protectionStatuses = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	serverFilter = @{
    /// 		# REQUIRED
    /// 		serverNames = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	serverId = $someString
    /// 	# OPTIONAL
    /// 	azureNativeIsEligibleForSqlMiDbProtectionFilter = @{
    /// 		# REQUIRED
    /// 		isEligibleForProtection = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	isEligibleForProtection = $someBoolean
    /// }
    /// # OPTIONAL
    /// $query.Var.includeSecurityMetadata = $someBoolean
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
    /// $query = New-RscQueryAzure -Operation SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure
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
    /// $query = New-RscQueryAzure -Operation SqlManagedInstanceServer
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
    /// $query = New-RscQueryAzure -Operation SqlManagedInstanceServers
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
    /// 	# OPTIONAL
    /// 	azureNativeIsEligibleForSqlMiServerProtectionFilter = @{
    /// 		# REQUIRED
    /// 		isEligibleForProtection = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	isEligibleForProtection = $someBoolean
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
    /// Runs the StorageAccountContainers operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: StorageAccountContainers
    /// 
    /// $query = New-RscQueryAzure -Operation StorageAccountContainers
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
    /// $query.Var.sortBy = $someStorageAccountContainersSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StorageAccountContainersSortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # REQUIRED
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		field = $someStorageAccountContainersFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StorageAccountContainersFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		text = $someString
    /// }
    /// )
    /// # REQUIRED
    /// $query.Var.azureStorageAccountRubrikId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BlobContainerConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StorageAccountExcludedContainers operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: StorageAccountExcludedContainers
    /// 
    /// $query = New-RscQueryAzure -Operation StorageAccountExcludedContainers
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
    /// $query.Var.sortBy = $someExcludedContainersSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ExcludedContainersSortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # REQUIRED
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		field = $someStorageAccountContainersFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StorageAccountContainersFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		text = $someString
    /// }
    /// )
    /// # REQUIRED
    /// $query.Var.azureStorageAccountRubrikId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ExcludedContainerConnection
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
    /// $query = New-RscQueryAzure -Operation StorageAccounts
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
    /// $query = New-RscQueryAzure -Operation StorageAccountsByRegion
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
    /// $query = New-RscQueryAzure -Operation Subnets
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
    /// $query = New-RscQueryAzure -Operation SubscriptionWithExocomputeMappings
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
    /// $query = New-RscQueryAzure -Operation Subscriptions
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
    /// Runs the SupportedAdRegions operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: SupportedAdRegions
    /// 
    /// $query = New-RscQueryAzure -Operation SupportedAdRegions
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SupportedAzureAdRegions
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
    /// $query = New-RscQueryAzure -Operation VNets
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
    /// $query = New-RscQueryAzure -Operation ValidateCloudAccountExocomputeConfigurations
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
    /// 			# OPTIONAL
    /// 			subnetNativeId = $someString
    /// 			# REQUIRED
    /// 			isRscManaged = $someBoolean
    /// 			# OPTIONAL
    /// 			podSubnetNativeId = $someString
    /// 			# OPTIONAL
    /// 			podOverlayNetworkCidr = $someString
    /// 			# OPTIONAL
    /// 			optionalConfig = @{
    /// 				# OPTIONAL
    /// 				aksNodeRgPrefix = $someString
    /// 				# OPTIONAL
    /// 				diskEncryptionAtHost = $someBoolean
    /// 				# OPTIONAL
    /// 				additionalWhitelistIps = @(
    /// 					$someString
    /// 				)
    /// 				# OPTIONAL
    /// 				enableUserDefinedRouting = $someBoolean
    /// 				# OPTIONAL
    /// 				shouldWhitelistRubrikIps = $someBoolean
    /// 				# OPTIONAL
    /// 				privateDnsZoneId = $someString
    /// 				# OPTIONAL
    /// 				aksCustomPrivateDnsZoneId = $someString
    /// 				# OPTIONAL
    /// 				aksClusterTier = $someAKSProvisionTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AKSProvisionTier]) for enum values.
    /// 				# OPTIONAL
    /// 				aksNodeCountBucket = $someAKSNodeCountBucket # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AKSNodeCountBucket]) for enum values.
    /// 				# OPTIONAL
    /// 				aksClusterAccessType = $someAKSClusterAccessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AKSClusterAccessType]) for enum values.
    /// 			}
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
    /// <example>
    /// Runs the ValidateCreateClusterInput operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: ValidateCreateClusterInput
    /// 
    /// $query = New-RscQueryAzure -Operation ValidateCreateClusterInput
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	cloudAccountId = $someString
    /// 	# OPTIONAL
    /// 	isEsType = $someBoolean
    /// 	# OPTIONAL
    /// 	keepClusterOnFailure = $someBoolean
    /// 	# OPTIONAL
    /// 	isAzResilient = $someBoolean
    /// 	# OPTIONAL
    /// 	clusterConfig = @{
    /// 		# OPTIONAL
    /// 		userEmail = $someString
    /// 		# OPTIONAL
    /// 		adminPassword = $someString
    /// 		# OPTIONAL
    /// 		clusterName = $someString
    /// 		# OPTIONAL
    /// 		numNodes = $someInt
    /// 		# OPTIONAL
    /// 		dnsNameServers = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		dnsSearchDomains = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		ntpServers = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		azureEsConfig = @{
    /// 			# OPTIONAL
    /// 			storageAccount = $someString
    /// 			# OPTIONAL
    /// 			resourceGroup = $someString
    /// 			# OPTIONAL
    /// 			storageSecret = $someString
    /// 			# OPTIONAL
    /// 			containerName = $someString
    /// 			# OPTIONAL
    /// 			shouldCreateContainer = $someBoolean
    /// 			# OPTIONAL
    /// 			enableImmutability = $someBoolean
    /// 			# OPTIONAL
    /// 			managedIdentity = @{
    /// 				# OPTIONAL
    /// 				name = $someString
    /// 				# OPTIONAL
    /// 				clientId = $someString
    /// 				# OPTIONAL
    /// 				resourceGroup = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			endpointSuffix = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		awsEsConfig = @{
    /// 			# OPTIONAL
    /// 			bucketName = $someString
    /// 			# OPTIONAL
    /// 			shouldCreateBucket = $someBoolean
    /// 			# OPTIONAL
    /// 			enableObjectLock = $someBoolean
    /// 			# OPTIONAL
    /// 			enableImmutability = $someBoolean
    /// 		}
    /// 		# OPTIONAL
    /// 		ociEsConfig = @{
    /// 			# OPTIONAL
    /// 			bucketName = $someString
    /// 			# OPTIONAL
    /// 			ociNamespace = $someString
    /// 			# OPTIONAL
    /// 			accessKey = $someString
    /// 			# OPTIONAL
    /// 			secretKey = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		gcpEsConfig = @{
    /// 			# OPTIONAL
    /// 			bucketName = $someString
    /// 			# OPTIONAL
    /// 			region = $someString
    /// 			# OPTIONAL
    /// 			shouldCreateBucket = $someBoolean
    /// 		}
    /// 		# OPTIONAL
    /// 		dynamicNumNodes = $someInt
    /// 		# OPTIONAL
    /// 		dynamicScalingEnabled = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	vmConfig = @{
    /// 		# OPTIONAL
    /// 		resourceGroup = $someString
    /// 		# OPTIONAL
    /// 		cdmVersion = $someString
    /// 		# OPTIONAL
    /// 		location = $someString
    /// 		# OPTIONAL
    /// 		nodeSizeGb = $someInt
    /// 		# OPTIONAL
    /// 		networkResourceGroup = $someString
    /// 		# OPTIONAL
    /// 		vnetResourceGroup = $someString
    /// 		# OPTIONAL
    /// 		networkSecurityGroup = $someString
    /// 		# OPTIONAL
    /// 		networkSecurityResourceGroup = $someString
    /// 		# OPTIONAL
    /// 		vnet = $someString
    /// 		# OPTIONAL
    /// 		subnet = $someString
    /// 		# OPTIONAL
    /// 		tags = $someString
    /// 		# OPTIONAL
    /// 		vmImage = $someString
    /// 		# OPTIONAL
    /// 		cdmProduct = $someString
    /// 		# OPTIONAL
    /// 		availabilityZone = $someString
    /// 		# OPTIONAL
    /// 		subnetAzConfigs = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				subnet = $someString
    /// 				# OPTIONAL
    /// 				availabilityZone = $someString
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		vmType = $someVmType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VmType]) for enum values.
    /// 		# OPTIONAL
    /// 		instanceType = $someAzureInstanceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureInstanceType]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	validations = @(
    /// 		$someClusterCreateValidations # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterCreateValidations]) for enum values.
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ValidationReply
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
                "AzureRegions",
                "AzureStorageAccounts",
                "AzureVnets",
                "BlobContainersByStorageAccount",
                "CdmVersions",
                "CheckPersistentStorageSubscriptionCanUnmap",
                "CloudAccountDetailsForFeature",
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
                "ExocomputeNetworkSetupTemplate",
                "HasRelicAdSnapshot",
                "HostedAzureRegions",
                "IsStorageAccountNameAvailable",
                "KeyVaultsByRegion",
                "ManagedIdentities",
                "MarketplaceTermsInfo",
                "Nsgs",
                "RcvBliMigrationDetails",
                "Regions",
                "RegionsWithAzDetails",
                "ResourceGroups",
                "ResourceGroupsFromAzure",
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
                "StorageAccountContainers",
                "StorageAccountExcludedContainers",
                "StorageAccounts",
                "StorageAccountsByRegion",
                "Subnets",
                "SubscriptionWithExocomputeMappings",
                "Subscriptions",
                "SupportedAdRegions",
                "VNets",
                "ValidateCloudAccountExocomputeConfigurations",
                "ValidateCreateClusterInput",
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
                    case "AzureRegions":
                        this.ProcessRecord_AzureRegions();
                        break;
                    case "AzureStorageAccounts":
                        this.ProcessRecord_AzureStorageAccounts();
                        break;
                    case "AzureVnets":
                        this.ProcessRecord_AzureVnets();
                        break;
                    case "BlobContainersByStorageAccount":
                        this.ProcessRecord_BlobContainersByStorageAccount();
                        break;
                    case "CdmVersions":
                        this.ProcessRecord_CdmVersions();
                        break;
                    case "CheckPersistentStorageSubscriptionCanUnmap":
                        this.ProcessRecord_CheckPersistentStorageSubscriptionCanUnmap();
                        break;
                    case "CloudAccountDetailsForFeature":
                        this.ProcessRecord_CloudAccountDetailsForFeature();
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
                    case "ExocomputeNetworkSetupTemplate":
                        this.ProcessRecord_ExocomputeNetworkSetupTemplate();
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
                    case "MarketplaceTermsInfo":
                        this.ProcessRecord_MarketplaceTermsInfo();
                        break;
                    case "Nsgs":
                        this.ProcessRecord_Nsgs();
                        break;
                    case "RcvBliMigrationDetails":
                        this.ProcessRecord_RcvBliMigrationDetails();
                        break;
                    case "Regions":
                        this.ProcessRecord_Regions();
                        break;
                    case "RegionsWithAzDetails":
                        this.ProcessRecord_RegionsWithAzDetails();
                        break;
                    case "ResourceGroups":
                        this.ProcessRecord_ResourceGroups();
                        break;
                    case "ResourceGroupsFromAzure":
                        this.ProcessRecord_ResourceGroupsFromAzure();
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
                    case "StorageAccountContainers":
                        this.ProcessRecord_StorageAccountContainers();
                        break;
                    case "StorageAccountExcludedContainers":
                        this.ProcessRecord_StorageAccountExcludedContainers();
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
                    case "SupportedAdRegions":
                        this.ProcessRecord_SupportedAdRegions();
                        break;
                    case "VNets":
                        this.ProcessRecord_VNets();
                        break;
                    case "ValidateCloudAccountExocomputeConfigurations":
                        this.ProcessRecord_ValidateCloudAccountExocomputeConfigurations();
                        break;
                    case "ValidateCreateClusterInput":
                        this.ProcessRecord_ValidateCreateClusterInput();
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
        // allAzureRegions.
        internal void ProcessRecord_AzureRegions()
        {
            this._logger.name += " -AzureRegions";
            // Create new graphql operation allAzureRegions
            InitQueryAllAzureRegions();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureStorageAccounts.
        internal void ProcessRecord_AzureStorageAccounts()
        {
            this._logger.name += " -AzureStorageAccounts";
            // Create new graphql operation allAzureStorageAccounts
            InitQueryAllAzureStorageAccounts();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureVnets.
        internal void ProcessRecord_AzureVnets()
        {
            this._logger.name += " -AzureVnets";
            // Create new graphql operation allAzureVnets
            InitQueryAllAzureVnets();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureBlobContainersByStorageAccount.
        internal void ProcessRecord_BlobContainersByStorageAccount()
        {
            this._logger.name += " -BlobContainersByStorageAccount";
            // Create new graphql operation allAzureBlobContainersByStorageAccount
            InitQueryAllAzureBlobContainersByStorageAccount();
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
        // azureCloudAccountDetailsForFeature.
        internal void ProcessRecord_CloudAccountDetailsForFeature()
        {
            this._logger.name += " -CloudAccountDetailsForFeature";
            // Create new graphql operation azureCloudAccountDetailsForFeature
            InitQueryAzureCloudAccountDetailsForFeature();
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
        // azureExocomputeNetworkSetupTemplate.
        internal void ProcessRecord_ExocomputeNetworkSetupTemplate()
        {
            this._logger.name += " -ExocomputeNetworkSetupTemplate";
            // Create new graphql operation azureExocomputeNetworkSetupTemplate
            InitQueryAzureExocomputeNetworkSetupTemplate();
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
        // azureMarketplaceTermsInfo.
        internal void ProcessRecord_MarketplaceTermsInfo()
        {
            this._logger.name += " -MarketplaceTermsInfo";
            // Create new graphql operation azureMarketplaceTermsInfo
            InitQueryAzureMarketplaceTermsInfo();
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
        // rcvAzureBliMigrationDetails.
        internal void ProcessRecord_RcvBliMigrationDetails()
        {
            this._logger.name += " -RcvBliMigrationDetails";
            // Create new graphql operation rcvAzureBliMigrationDetails
            InitQueryRcvAzureBliMigrationDetails();
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
        // allAzureRegionsWithAzDetails.
        internal void ProcessRecord_RegionsWithAzDetails()
        {
            this._logger.name += " -RegionsWithAzDetails";
            // Create new graphql operation allAzureRegionsWithAzDetails
            InitQueryAllAzureRegionsWithAzDetails();
        }

        // This parameter set invokes a single graphql operation:
        // azureResourceGroups.
        internal void ProcessRecord_ResourceGroups()
        {
            this._logger.name += " -ResourceGroups";
            // Create new graphql operation azureResourceGroups
            InitQueryAzureResourceGroups();
        }

        // This parameter set invokes a single graphql operation:
        // allResourceGroupsFromAzure.
        internal void ProcessRecord_ResourceGroupsFromAzure()
        {
            this._logger.name += " -ResourceGroupsFromAzure";
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
        // azureStorageAccountContainers.
        internal void ProcessRecord_StorageAccountContainers()
        {
            this._logger.name += " -StorageAccountContainers";
            // Create new graphql operation azureStorageAccountContainers
            InitQueryAzureStorageAccountContainers();
        }

        // This parameter set invokes a single graphql operation:
        // azureStorageAccountExcludedContainers.
        internal void ProcessRecord_StorageAccountExcludedContainers()
        {
            this._logger.name += " -StorageAccountExcludedContainers";
            // Create new graphql operation azureStorageAccountExcludedContainers
            InitQueryAzureStorageAccountExcludedContainers();
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
        // supportedAzureAdRegions.
        internal void ProcessRecord_SupportedAdRegions()
        {
            this._logger.name += " -SupportedAdRegions";
            // Create new graphql operation supportedAzureAdRegions
            InitQuerySupportedAzureAdRegions();
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

        // This parameter set invokes a single graphql operation:
        // validateCreateAzureClusterInput.
        internal void ProcessRecord_ValidateCreateClusterInput()
        {
            this._logger.name += " -ValidateCreateClusterInput";
            // Create new graphql operation validateCreateAzureClusterInput
            InitQueryValidateCreateAzureClusterInput();
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
                Query.AzureAdDirectories,
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
                Query.AzureAdDirectory,
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
                Query.AzureAdObjectsByType,
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
	workloadFid = $someString
	# REQUIRED
	keywordSearchFilters = @(
		@{
			# OPTIONAL
			searchKeyword = $someString
			# OPTIONAL
			searchKeywordType = $someString
		}
	)
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
                Query.AllAzureArmTemplatesByFeature,
                Query.AllAzureArmTemplatesByFeatureFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	customerTenantDomainName = $someString
	# OPTIONAL
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
        // allAzureRegions(cloudAccountId: String!): [AzureCloudAccountRegion!]!
        internal void InitQueryAllAzureRegions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureRegions",
                "($cloudAccountId: String!)",
                "List<AzureCloudAccountRegion>",
                Query.AllAzureRegions,
                Query.AllAzureRegionsFieldSpec,
                @"# REQUIRED
$query.Var.cloudAccountId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allAzureStorageAccounts(storageAccountsRequest: AzureStorageAccountsReq!): [String!]!
        internal void InitQueryAllAzureStorageAccounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("storageAccountsRequest", "AzureStorageAccountsReq!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureStorageAccounts",
                "($storageAccountsRequest: AzureStorageAccountsReq!)",
                "List<System.String>",
                Query.AllAzureStorageAccounts,
                Query.AllAzureStorageAccountsFieldSpec,
                @"# REQUIRED
$query.Var.storageAccountsRequest = @{
	# OPTIONAL
	cloudAccountId = $someString
	# OPTIONAL
	resourceGroup = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // allAzureVnets(vnetRequest: AzureVnetReq!): [String!]!
        internal void InitQueryAllAzureVnets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("vnetRequest", "AzureVnetReq!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureVnets",
                "($vnetRequest: AzureVnetReq!)",
                "List<System.String>",
                Query.AllAzureVnets,
                Query.AllAzureVnetsFieldSpec,
                @"# REQUIRED
$query.Var.vnetRequest = @{
	# OPTIONAL
	cloudAccountId = $someString
	# OPTIONAL
	resourceGroup = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // allAzureBlobContainersByStorageAccount(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     input: AzureBlobContainersByStorageAccountInput!
        //   ): AzureBlobContainerCcprovisionConnection!
        internal void InitQueryAllAzureBlobContainersByStorageAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("input", "AzureBlobContainersByStorageAccountInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureBlobContainersByStorageAccount",
                "($first: Int,$after: String,$last: Int,$before: String,$input: AzureBlobContainersByStorageAccountInput!)",
                "AzureBlobContainerCcprovisionConnection",
                Query.AllAzureBlobContainersByStorageAccount,
                Query.AllAzureBlobContainersByStorageAccountFieldSpec,
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
	cloudAccountId = $someString
	# OPTIONAL
	resourceGroup = $someString
	# OPTIONAL
	storageAccount = $someString
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
                Query.AllAzureCdmVersions,
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
                Query.CheckAzurePersistentStorageSubscriptionCanUnmap,
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
        // azureCloudAccountDetailsForFeature(featureId: UUID!): AzureCloudAccountDetailsForFeatureReply!
        internal void InitQueryAzureCloudAccountDetailsForFeature()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("featureId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureCloudAccountDetailsForFeature",
                "($featureId: UUID!)",
                "AzureCloudAccountDetailsForFeatureReply",
                Query.AzureCloudAccountDetailsForFeature,
                Query.AzureCloudAccountDetailsForFeatureFieldSpec,
                @"# REQUIRED
$query.Var.featureId = $someString"
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
                Query.AllAzureCloudAccountMissingPermissions,
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
        // azureCloudAccountPermissionConfig(feature: CloudAccountFeature!, permissionsGroups: [PermissionsGroup!]! = []): AzureCloudAccountPermissionConfigResponse!
        internal void InitQueryAzureCloudAccountPermissionConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("permissionsGroups", "[PermissionsGroup!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureCloudAccountPermissionConfig",
                "($feature: CloudAccountFeature!,$permissionsGroups: [PermissionsGroup!]!)",
                "AzureCloudAccountPermissionConfigResponse",
                Query.AzureCloudAccountPermissionConfig,
                Query.AzureCloudAccountPermissionConfigFieldSpec,
                @"# REQUIRED
$query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$query.Var.permissionsGroups = @(
	$somePermissionsGroup # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
)"
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
                Query.AllAzureCloudAccountSubnetsByRegion,
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
                Query.AzureCloudAccountSubscriptionWithFeatures,
                Query.AzureCloudAccountSubscriptionWithFeaturesFieldSpec,
                @"# REQUIRED
$query.Var.cloudAccountId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allAzureCloudAccountSubscriptionsByFeature(feature: CloudAccountFeature!, subscriptionStatusFilters: [CloudAccountStatus!]!, permissionsGroupFilters: [FeatureWithPermissionsGroups!]): [AzureSubscriptionWithFeaturesType!]!
        internal void InitQueryAllAzureCloudAccountSubscriptionsByFeature()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("subscriptionStatusFilters", "[CloudAccountStatus!]!"),
                Tuple.Create("permissionsGroupFilters", "[FeatureWithPermissionsGroups!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureCloudAccountSubscriptionsByFeature",
                "($feature: CloudAccountFeature!,$subscriptionStatusFilters: [CloudAccountStatus!]!,$permissionsGroupFilters: [FeatureWithPermissionsGroups!])",
                "List<AzureSubscriptionWithFeaturesType>",
                Query.AllAzureCloudAccountSubscriptionsByFeature,
                Query.AllAzureCloudAccountSubscriptionsByFeatureFieldSpec,
                @"# REQUIRED
$query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$query.Var.subscriptionStatusFilters = @(
	$someCloudAccountStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountStatus]) for enum values.
)
# OPTIONAL
$query.Var.permissionsGroupFilters = @(
	@{
		# OPTIONAL
		featureType = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
		# OPTIONAL
		permissionsGroups = @(
			$somePermissionsGroup # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // azureCloudAccountTenant(
        //     tenantId: UUID!
        //     feature: CloudAccountFeature!
        //     features: [CloudAccountFeature!]
        //     subscriptionStatusFilters: [CloudAccountStatus!]!
        //     subscriptionSearchText: String!
        //     subscriptionIdsFilter: [UUID!]
        //   ): AzureCloudAccountTenant!
        internal void InitQueryAzureCloudAccountTenant()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("features", "[CloudAccountFeature!]"),
                Tuple.Create("subscriptionStatusFilters", "[CloudAccountStatus!]!"),
                Tuple.Create("subscriptionSearchText", "String!"),
                Tuple.Create("subscriptionIdsFilter", "[UUID!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureCloudAccountTenant",
                "($tenantId: UUID!,$feature: CloudAccountFeature!,$features: [CloudAccountFeature!],$subscriptionStatusFilters: [CloudAccountStatus!]!,$subscriptionSearchText: String!,$subscriptionIdsFilter: [UUID!])",
                "AzureCloudAccountTenant",
                Query.AzureCloudAccountTenant,
                Query.AzureCloudAccountTenantFieldSpec,
                @"# REQUIRED
$query.Var.tenantId = $someString
# REQUIRED
$query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# OPTIONAL
$query.Var.features = @(
	$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
)
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
        //     features: [CloudAccountFeature!]
        //     subscriptionStatusFilters: [CloudAccountStatus!]!
        //     subscriptionSearchText: String!
        //     subscriptionIdsFilter: [UUID!]
        //   ): AzureCloudAccountTenantWithExoConfigs!
        internal void InitQueryAzureCloudAccountTenantWithExoConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("features", "[CloudAccountFeature!]"),
                Tuple.Create("subscriptionStatusFilters", "[CloudAccountStatus!]!"),
                Tuple.Create("subscriptionSearchText", "String!"),
                Tuple.Create("subscriptionIdsFilter", "[UUID!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureCloudAccountTenantWithExoConfigs",
                "($tenantId: UUID!,$feature: CloudAccountFeature!,$features: [CloudAccountFeature!],$subscriptionStatusFilters: [CloudAccountStatus!]!,$subscriptionSearchText: String!,$subscriptionIdsFilter: [UUID!])",
                "AzureCloudAccountTenantWithExoConfigs",
                Query.AzureCloudAccountTenantWithExoConfigs,
                Query.AzureCloudAccountTenantWithExoConfigsFieldSpec,
                @"# REQUIRED
$query.Var.tenantId = $someString
# REQUIRED
$query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# OPTIONAL
$query.Var.features = @(
	$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
)
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
        // allAzureCloudAccountTenants(
        //     features: [CloudAccountFeature!]
        //     feature: CloudAccountFeature!
        //     includeSubscriptionDetails: Boolean!
        //     azureTenants: [String!]
        //     status: [CloudAccountStatus!]
        //   ): [AzureCloudAccountTenant!]!
        internal void InitQueryAllAzureCloudAccountTenants()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("features", "[CloudAccountFeature!]"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("includeSubscriptionDetails", "Boolean!"),
                Tuple.Create("azureTenants", "[String!]"),
                Tuple.Create("status", "[CloudAccountStatus!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureCloudAccountTenants",
                "($features: [CloudAccountFeature!],$feature: CloudAccountFeature!,$includeSubscriptionDetails: Boolean!,$azureTenants: [String!],$status: [CloudAccountStatus!])",
                "List<AzureCloudAccountTenant>",
                Query.AllAzureCloudAccountTenants,
                Query.AllAzureCloudAccountTenantsFieldSpec,
                @"# OPTIONAL
$query.Var.features = @(
	$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
)
# REQUIRED
$query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$query.Var.includeSubscriptionDetails = $someBoolean
# OPTIONAL
$query.Var.azureTenants = @(
	$someString
)
# OPTIONAL
$query.Var.status = @(
	$someCloudAccountStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountStatus]) for enum values.
)"
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
                Query.AllAzureDiskEncryptionSetsByRegion,
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
                Query.AllAzureEncryptionKeys,
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
                Query.AllAzureExocomputeConfigsInAccount,
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
        // azureExocomputeNetworkSetupTemplate(input: GetAzureExocomputeNetworkSetupTemplateReq!): GetAzureExocomputeNetworkSetupTemplateReply!
        internal void InitQueryAzureExocomputeNetworkSetupTemplate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetAzureExocomputeNetworkSetupTemplateReq!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureExocomputeNetworkSetupTemplate",
                "($input: GetAzureExocomputeNetworkSetupTemplateReq!)",
                "GetAzureExocomputeNetworkSetupTemplateReply",
                Query.AzureExocomputeNetworkSetupTemplate,
                Query.AzureExocomputeNetworkSetupTemplateFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	locations = @(
		$someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
	)
}"
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
                Query.HasRelicAzureAdSnapshot,
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
                Query.AllHostedAzureRegions,
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
                Query.IsAzureStorageAccountNameAvailable,
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
                Query.AllAzureKeyVaultsByRegion,
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
                Query.AllAzureManagedIdentities,
                Query.AllAzureManagedIdentitiesFieldSpec,
                @"# REQUIRED
$query.Var.managedIdentitiesRequest = @{
	# REQUIRED
	cloudAccountId = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // azureMarketplaceTermsInfo(input: CheckAzureMarketplaceTermsReq!): CheckAzureMarketplaceTermsReply!
        internal void InitQueryAzureMarketplaceTermsInfo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CheckAzureMarketplaceTermsReq!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureMarketplaceTermsInfo",
                "($input: CheckAzureMarketplaceTermsReq!)",
                "CheckAzureMarketplaceTermsReply",
                Query.AzureMarketplaceTermsInfo,
                Query.AzureMarketplaceTermsInfoFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	cloudAccountId = $someString
	# OPTIONAL
	cdmVersion = $someString
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
                Query.AllAzureNsgs,
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
        // rcvAzureBliMigrationDetails(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     BliMigrationDetailsFilter: RcvBliMigrationFilter
        //     sortBy: RcvBliMigrationDetailsSortByField
        //     sortOrder: SortOrder
        //   ): RcvBliMigrationDetailsConnection!
        internal void InitQueryRcvAzureBliMigrationDetails()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("BliMigrationDetailsFilter", "RcvBliMigrationFilter"),
                Tuple.Create("sortBy", "RcvBliMigrationDetailsSortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryRcvAzureBliMigrationDetails",
                "($first: Int,$after: String,$last: Int,$before: String,$BliMigrationDetailsFilter: RcvBliMigrationFilter,$sortBy: RcvBliMigrationDetailsSortByField,$sortOrder: SortOrder)",
                "RcvBliMigrationDetailsConnection",
                Query.RcvAzureBliMigrationDetails,
                Query.RcvAzureBliMigrationDetailsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.BliMigrationDetailsFilter = @{
	# OPTIONAL
	migrationStatuses = @(
		$someBliMigrationStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BliMigrationStatus]) for enum values.
	)
	# OPTIONAL
	clusterIds = @(
		$someString
	)
	# OPTIONAL
	tiers = @(
		$someRcvTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RcvTier]) for enum values.
	)
	# OPTIONAL
	regions = @(
		@{
			# OPTIONAL
			cloudSpecificRegion = @{
				# OPTIONAL
				azureRegion = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
				# OPTIONAL
				awsRegion = $someAwsRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
				# OPTIONAL
				gcpRegion = $someGcpRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GcpRegion]) for enum values.
			}
		}
	)
	# OPTIONAL
	locationStatuses = @(
		$someArchivalLocationStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ArchivalLocationStatus]) for enum values.
	)
	# OPTIONAL
	unavailabilityReasons = @(
		$someMigrationUnavailabilityReason # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MigrationUnavailabilityReason]) for enum values.
	)
	# OPTIONAL
	searchByLocationName = $someString
}
# OPTIONAL
$query.Var.sortBy = $someRcvBliMigrationDetailsSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RcvBliMigrationDetailsSortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values."
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
                Query.AzureRegions,
                Query.AzureRegionsFieldSpec,
                @"# REQUIRED
$query.Var.tenantId = $someString
# REQUIRED
$query.Var.subscriptionId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allAzureRegionsWithAzDetails(cloudAccountId: String!): [AzureLocationDetailType!]!
        internal void InitQueryAllAzureRegionsWithAzDetails()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureRegionsWithAzDetails",
                "($cloudAccountId: String!)",
                "List<AzureLocationDetailType>",
                Query.AllAzureRegionsWithAzDetails,
                Query.AllAzureRegionsWithAzDetailsFieldSpec,
                @"# REQUIRED
$query.Var.cloudAccountId = $someString"
            );
        }

        // Create new GraphQL Query:
        // azureResourceGroups(tenantId: String!, subscriptionId: UUID!): ResourceGroupConnection!
        internal void InitQueryAzureResourceGroups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureResourceGroups",
                "($tenantId: String!,$subscriptionId: UUID!)",
                "ResourceGroupConnection",
                Query.AzureResourceGroups,
                Query.AzureResourceGroupsFieldSpec,
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
                Query.AllResourceGroupsFromAzure,
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
                Query.SearchAzureAdSnapshot,
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
	workloadFid = $someString
	# REQUIRED
	keywordSearchFilters = @(
		@{
			# OPTIONAL
			searchKeyword = $someString
			# OPTIONAL
			searchKeywordType = $someString
		}
	)
	# REQUIRED
	azureAdObjectType = $someAzureAdObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdObjectType]) for enum values.
}"
            );
        }

        // Create new GraphQL Query:
        // azureSqlDatabase(azureSqlDatabaseRubrikId: UUID!, includeSecurityMetadata: Boolean): AzureSqlDatabaseDb!
        internal void InitQueryAzureSqlDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlDatabaseRubrikId", "UUID!"),
                Tuple.Create("includeSecurityMetadata", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlDatabase",
                "($azureSqlDatabaseRubrikId: UUID!,$includeSecurityMetadata: Boolean)",
                "AzureSqlDatabaseDb",
                Query.AzureSqlDatabase,
                Query.AzureSqlDatabaseFieldSpec,
                @"# REQUIRED
$query.Var.azureSqlDatabaseRubrikId = $someString
# OPTIONAL
$query.Var.includeSecurityMetadata = $someBoolean"
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
                Query.AzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure,
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
                Query.AzureSqlDatabaseServer,
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
                Query.AllAzureSqlDatabaseServerElasticPools,
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
                Query.AzureSqlDatabaseServers,
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
	# OPTIONAL
	azureNativeIsEligibleForSqlDatabaseServerProtectionFilter = @{
		# REQUIRED
		isEligibleForProtection = $someBoolean
	}
	# OPTIONAL
	isEligibleForProtection = $someBoolean
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
        //     includeSecurityMetadata: Boolean
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
                Tuple.Create("includeSecurityMetadata", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlDatabases",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureSqlDatabaseSortFields,$sortOrder: SortOrder,$azureSqlDatabaseFilters: AzureSqlDatabaseFilters,$includeSecurityMetadata: Boolean)",
                "AzureSqlDatabaseDbConnection",
                Query.AzureSqlDatabases,
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
	sensitivityStatusFilter = @{
		# REQUIRED
		sensitivityStatuses = @(
			$someString
		)
	}
	# OPTIONAL
	protectionStatusFilter = @{
		# REQUIRED
		protectionStatuses = @(
			$someString
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
	# OPTIONAL
	serverFilter = @{
		# REQUIRED
		serverNames = @(
			$someString
		)
	}
	# OPTIONAL
	serverId = $someString
	# OPTIONAL
	azureNativeIsEligibleForSqlDatabaseDbProtectionFilter = @{
		# REQUIRED
		isEligibleForProtection = $someBoolean
	}
	# OPTIONAL
	isEligibleForProtection = $someBoolean
}
# OPTIONAL
$query.Var.includeSecurityMetadata = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // azureSqlManagedInstanceDatabase(azureSqlManagedInstanceDatabaseRubrikId: UUID!, includeSecurityMetadata: Boolean): AzureSqlManagedInstanceDatabase!
        internal void InitQueryAzureSqlManagedInstanceDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlManagedInstanceDatabaseRubrikId", "UUID!"),
                Tuple.Create("includeSecurityMetadata", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlManagedInstanceDatabase",
                "($azureSqlManagedInstanceDatabaseRubrikId: UUID!,$includeSecurityMetadata: Boolean)",
                "AzureSqlManagedInstanceDatabase",
                Query.AzureSqlManagedInstanceDatabase,
                Query.AzureSqlManagedInstanceDatabaseFieldSpec,
                @"# REQUIRED
$query.Var.azureSqlManagedInstanceDatabaseRubrikId = $someString
# OPTIONAL
$query.Var.includeSecurityMetadata = $someBoolean"
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
        //     includeSecurityMetadata: Boolean
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
                Tuple.Create("includeSecurityMetadata", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlManagedInstanceDatabases",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureSqlManagedInstanceDatabaseSortFields,$sortOrder: SortOrder,$azureSqlManagedInstanceDatabaseFilters: AzureSqlManagedInstanceDatabaseFilters,$includeSecurityMetadata: Boolean)",
                "AzureSqlManagedInstanceDatabaseConnection",
                Query.AzureSqlManagedInstanceDatabases,
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
	sensitivityStatusFilter = @{
		# REQUIRED
		sensitivityStatuses = @(
			$someString
		)
	}
	# OPTIONAL
	protectionStatusFilter = @{
		# REQUIRED
		protectionStatuses = @(
			$someString
		)
	}
	# OPTIONAL
	serverFilter = @{
		# REQUIRED
		serverNames = @(
			$someString
		)
	}
	# OPTIONAL
	serverId = $someString
	# OPTIONAL
	azureNativeIsEligibleForSqlMiDbProtectionFilter = @{
		# REQUIRED
		isEligibleForProtection = $someBoolean
	}
	# OPTIONAL
	isEligibleForProtection = $someBoolean
}
# OPTIONAL
$query.Var.includeSecurityMetadata = $someBoolean"
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
                Query.AzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure,
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
                Query.AzureSqlManagedInstanceServer,
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
                Query.AzureSqlManagedInstanceServers,
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
	# OPTIONAL
	azureNativeIsEligibleForSqlMiServerProtectionFilter = @{
		# REQUIRED
		isEligibleForProtection = $someBoolean
	}
	# OPTIONAL
	isEligibleForProtection = $someBoolean
}"
            );
        }

        // Create new GraphQL Query:
        // azureStorageAccountContainers(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: StorageAccountContainersSortByField
        //     sortOrder: SortOrder
        //     filter: [StorageAccountContainersFilterInput!]!
        //     azureStorageAccountRubrikId: UUID!
        //   ): BlobContainerConnection!
        internal void InitQueryAzureStorageAccountContainers()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "StorageAccountContainersSortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[StorageAccountContainersFilterInput!]!"),
                Tuple.Create("azureStorageAccountRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureStorageAccountContainers",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: StorageAccountContainersSortByField,$sortOrder: SortOrder,$filter: [StorageAccountContainersFilterInput!]!,$azureStorageAccountRubrikId: UUID!)",
                "BlobContainerConnection",
                Query.AzureStorageAccountContainers,
                Query.AzureStorageAccountContainersFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someStorageAccountContainersSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StorageAccountContainersSortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# REQUIRED
$query.Var.filter = @(
	@{
		# REQUIRED
		field = $someStorageAccountContainersFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StorageAccountContainersFilterField]) for enum values.
		# OPTIONAL
		text = $someString
}
)
# REQUIRED
$query.Var.azureStorageAccountRubrikId = $someString"
            );
        }

        // Create new GraphQL Query:
        // azureStorageAccountExcludedContainers(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: ExcludedContainersSortByField
        //     sortOrder: SortOrder
        //     filter: [StorageAccountContainersFilterInput!]!
        //     azureStorageAccountRubrikId: UUID!
        //   ): ExcludedContainerConnection!
        internal void InitQueryAzureStorageAccountExcludedContainers()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "ExcludedContainersSortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[StorageAccountContainersFilterInput!]!"),
                Tuple.Create("azureStorageAccountRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureStorageAccountExcludedContainers",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: ExcludedContainersSortByField,$sortOrder: SortOrder,$filter: [StorageAccountContainersFilterInput!]!,$azureStorageAccountRubrikId: UUID!)",
                "ExcludedContainerConnection",
                Query.AzureStorageAccountExcludedContainers,
                Query.AzureStorageAccountExcludedContainersFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someExcludedContainersSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ExcludedContainersSortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# REQUIRED
$query.Var.filter = @(
	@{
		# REQUIRED
		field = $someStorageAccountContainersFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StorageAccountContainersFilterField]) for enum values.
		# OPTIONAL
		text = $someString
}
)
# REQUIRED
$query.Var.azureStorageAccountRubrikId = $someString"
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
                Query.AzureStorageAccounts,
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
                Query.AllAzureStorageAccountsByRegion,
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
                Query.AzureSubnets,
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
                Query.AllAzureSubscriptionWithExocomputeMappings,
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
                Query.AzureSubscriptions,
                Query.AzureSubscriptionsFieldSpec,
                @"# REQUIRED
$query.Var.tenantId = $someString"
            );
        }

        // Create new GraphQL Query:
        // supportedAzureAdRegions: SupportedAzureAdRegions!
        internal void InitQuerySupportedAzureAdRegions()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QuerySupportedAzureAdRegions",
                "",
                "SupportedAzureAdRegions",
                Query.SupportedAzureAdRegions,
                Query.SupportedAzureAdRegionsFieldSpec,
                @""
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
                Query.AzureVnets,
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
                Query.ValidateAzureCloudAccountExocomputeConfigurations,
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
			# OPTIONAL
			subnetNativeId = $someString
			# REQUIRED
			isRscManaged = $someBoolean
			# OPTIONAL
			podSubnetNativeId = $someString
			# OPTIONAL
			podOverlayNetworkCidr = $someString
			# OPTIONAL
			optionalConfig = @{
				# OPTIONAL
				aksNodeRgPrefix = $someString
				# OPTIONAL
				diskEncryptionAtHost = $someBoolean
				# OPTIONAL
				additionalWhitelistIps = @(
					$someString
				)
				# OPTIONAL
				enableUserDefinedRouting = $someBoolean
				# OPTIONAL
				shouldWhitelistRubrikIps = $someBoolean
				# OPTIONAL
				privateDnsZoneId = $someString
				# OPTIONAL
				aksCustomPrivateDnsZoneId = $someString
				# OPTIONAL
				aksClusterTier = $someAKSProvisionTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AKSProvisionTier]) for enum values.
				# OPTIONAL
				aksNodeCountBucket = $someAKSNodeCountBucket # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AKSNodeCountBucket]) for enum values.
				# OPTIONAL
				aksClusterAccessType = $someAKSClusterAccessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AKSClusterAccessType]) for enum values.
			}
		}
	)
}"
            );
        }

        // Create new GraphQL Query:
        // validateCreateAzureClusterInput(input: CreateAzureClusterInput!): ValidationReply!
        internal void InitQueryValidateCreateAzureClusterInput()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAzureClusterInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryValidateCreateAzureClusterInput",
                "($input: CreateAzureClusterInput!)",
                "ValidationReply",
                Query.ValidateCreateAzureClusterInput,
                Query.ValidateCreateAzureClusterInputFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	cloudAccountId = $someString
	# OPTIONAL
	isEsType = $someBoolean
	# OPTIONAL
	keepClusterOnFailure = $someBoolean
	# OPTIONAL
	isAzResilient = $someBoolean
	# OPTIONAL
	clusterConfig = @{
		# OPTIONAL
		userEmail = $someString
		# OPTIONAL
		adminPassword = $someString
		# OPTIONAL
		clusterName = $someString
		# OPTIONAL
		numNodes = $someInt
		# OPTIONAL
		dnsNameServers = @(
			$someString
		)
		# OPTIONAL
		dnsSearchDomains = @(
			$someString
		)
		# OPTIONAL
		ntpServers = @(
			$someString
		)
		# OPTIONAL
		azureEsConfig = @{
			# OPTIONAL
			storageAccount = $someString
			# OPTIONAL
			resourceGroup = $someString
			# OPTIONAL
			storageSecret = $someString
			# OPTIONAL
			containerName = $someString
			# OPTIONAL
			shouldCreateContainer = $someBoolean
			# OPTIONAL
			enableImmutability = $someBoolean
			# OPTIONAL
			managedIdentity = @{
				# OPTIONAL
				name = $someString
				# OPTIONAL
				clientId = $someString
				# OPTIONAL
				resourceGroup = $someString
			}
			# OPTIONAL
			endpointSuffix = $someString
		}
		# OPTIONAL
		awsEsConfig = @{
			# OPTIONAL
			bucketName = $someString
			# OPTIONAL
			shouldCreateBucket = $someBoolean
			# OPTIONAL
			enableObjectLock = $someBoolean
			# OPTIONAL
			enableImmutability = $someBoolean
		}
		# OPTIONAL
		ociEsConfig = @{
			# OPTIONAL
			bucketName = $someString
			# OPTIONAL
			ociNamespace = $someString
			# OPTIONAL
			accessKey = $someString
			# OPTIONAL
			secretKey = $someString
		}
		# OPTIONAL
		gcpEsConfig = @{
			# OPTIONAL
			bucketName = $someString
			# OPTIONAL
			region = $someString
			# OPTIONAL
			shouldCreateBucket = $someBoolean
		}
		# OPTIONAL
		dynamicNumNodes = $someInt
		# OPTIONAL
		dynamicScalingEnabled = $someBoolean
	}
	# OPTIONAL
	vmConfig = @{
		# OPTIONAL
		resourceGroup = $someString
		# OPTIONAL
		cdmVersion = $someString
		# OPTIONAL
		location = $someString
		# OPTIONAL
		nodeSizeGb = $someInt
		# OPTIONAL
		networkResourceGroup = $someString
		# OPTIONAL
		vnetResourceGroup = $someString
		# OPTIONAL
		networkSecurityGroup = $someString
		# OPTIONAL
		networkSecurityResourceGroup = $someString
		# OPTIONAL
		vnet = $someString
		# OPTIONAL
		subnet = $someString
		# OPTIONAL
		tags = $someString
		# OPTIONAL
		vmImage = $someString
		# OPTIONAL
		cdmProduct = $someString
		# OPTIONAL
		availabilityZone = $someString
		# OPTIONAL
		subnetAzConfigs = @(
			@{
				# OPTIONAL
				subnet = $someString
				# OPTIONAL
				availabilityZone = $someString
			}
		)
		# OPTIONAL
		vmType = $someVmType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VmType]) for enum values.
		# OPTIONAL
		instanceType = $someAzureInstanceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureInstanceType]) for enum values.
	}
	# OPTIONAL
	validations = @(
		$someClusterCreateValidations # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterCreateValidations]) for enum values.
	)
}"
            );
        }


    } // class New_RscQueryAzure
}