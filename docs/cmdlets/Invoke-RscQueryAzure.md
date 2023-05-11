# Invoke-RscQueryAzure
## Subcommands
### Ad
Details of the Azure AD corresponds to the workload ID.

- The Input parameter takes a single value of type System.String.
- Returns AzureAdTenant.
### AdTenant
All Azure AD tenants for the account.

- The Input parameter takes a hashtable with 5 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filter - a list of Filters: The hierarchy object filter.
    - first - System.Int32: Returns the first n elements from the list.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
- Returns AzureAdTenantConnection.
### CloudAccountPermissionConfig
Retrieves the configuration consisting of role permissions and feature policy version required for Azure subscription setup. Features refer to the Polaris features that the customer wants to be enabled on the cloud account.

- The Input parameter takes a single value of type CloudAccountFeature.
- Returns AzureCloudAccountPermissionConfigResponse.
### CloudAccountSubscriptionWithFeature
Retrieves the details of the Azure cloud account.

- The Input parameter takes a single value of type System.String.
- Returns AzureCloudAccountSubscriptionWithFeatures.
### CloudAccountTenant
Retrieves the details of the Azure tenant and all the subscriptions of the tenant, for a feature.

- The Input parameter takes a hashtable with 5 name and value pairs.
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
    - subscriptionIdsFilter - a list of System.Strings: List of subscription IDs to filter on.
    - subscriptionSearchText - System.String: Search text for subscription name and native ID.
    - subscriptionStatusFilters - a list of CloudAccountStatuss: List of subscription status filters to apply.
    - tenantId - System.String: Tenant ID of the Azure tenant.
- Returns AzureCloudAccountTenant.
### CloudAccountTenantWithExoConfig
Retrieves details about the Azure cloud account tenant including the Exocompute configurations for the tenant subscriptions, for a specified feature.

- The Input parameter takes a hashtable with 5 name and value pairs.
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
    - subscriptionIdsFilter - a list of System.Strings: List of subscription IDs to filter on.
    - subscriptionSearchText - System.String: Search text for subscription name and native ID.
    - subscriptionStatusFilters - a list of CloudAccountStatuss: List of subscription status filters to apply.
    - tenantId - System.String: Tenant ID of the Azure tenant.
- Returns AzureCloudAccountTenantWithExoConfigs.
### NativeManagedDisk
Retrieves an Azure Native Managed Disk that refers to the block storage designed to be used with Azure Virtual Machines. Some examples are: ultra disks, premium solid-state drives (SSD), standard SSDs, and standard hard disk drives (HDD). For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/managed-disks-overview.

- The Input parameter takes a single value of type System.String.
- Returns AzureNativeManagedDisk.
### NativeResourceGroup
Retrieves an Azure Native Resource Group. Refers to a collection of resources in which multiple Azure services can reside.

- The Input parameter takes a single value of type System.String.
- Returns AzureNativeResourceGroup.
### NativeRoot
Root of Azure native hierarchy.

- The NativeRoot subcommand takes no arguments.
- Returns AzureNativeRoot.
### NativeSubscription
Retrieves an Azure Native Subscription. Refers to the logical entity that provides entitlement to deploy and consume Azure resources.

- The Input parameter takes a single value of type System.String.
- Returns AzureNativeSubscription.
### NativeVirtualMachine
Retrieves an Azure Virtual Machine that refers to the Azure infrastructure as a service (IaaS) used to deploy persistent VMs. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/.

- The Input parameter takes a single value of type System.String.
- Returns AzureNativeVirtualMachine.
### Region
Gets the Azure regions for the given subscription.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - subscriptionId - System.String
    - tenantId - System.String
- Returns RegionConnection.
### ResourceGroup
Gets the Azure resource groups for the given subscription.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - subscriptionId - System.String
    - tenantId - System.String
- Returns ResourceGroupConnection.
### SqlDatabase
Retrieves an Azure SQL Database. Refers to the fully managed SQL database built for the cloud. For more information, see https://azure.microsoft.com/en-us/products/azure-sql/database/.

- The Input parameter takes a single value of type System.String.
- Returns AzureSqlDatabaseDb.
### SqlDatabaseDbPointInTimeRestoreWindowFromAzure
Point-in-Time (PiT) restore window of the Azure SQL Database instance in the Azure native account. Refers to the range of time within which the database is available to be restored to a particular point in time. For more information, see https://azure.microsoft.com/en-in/blog/azure-sql-database-point-in-time-restore/.

- The Input parameter takes a hashtable with 4 name and value pairs.
    - azureSqlDatabaseName - System.String: Name of the Azure SQL Database.
    - azureSqlDatabaseServerName - System.String: Name of the Azure SQL Database server.
    - resourceGroupName - System.String: Resource Group Name.
    - subscriptionId - System.String: Subscription ID.
- Returns AzureNativeSqlDatabasePointInTimeRestoreWindow.
### SqlDatabaseServer
Retrieves an Azure SQL Database Server. Refers to the server that contains the Azure SQL Databases. For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/database/logical-servers.

- The Input parameter takes a single value of type System.String.
- Returns AzureSqlDatabaseServer.
### SqlManagedInstanceDatabase
Retrieves an Azure SQL Managed Instance Database. Refers to the database engine compatible with the latest SQL Server (Enterprise Edition) database engine. For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/managed-instance/sql-managed-instance-paas-overview.

- The Input parameter takes a single value of type System.String.
- Returns AzureSqlManagedInstanceDatabase.
### SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure
Point-in-Time (PiT) restore window of the Azure SQL Managed Instance database in the Azure native account. Refers to the range of time within which the database is available to be restored to a particular point in time. For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/managed-instance/point-in-time-restore?tabs=azure-portal.

- The Input parameter takes a hashtable with 4 name and value pairs.
    - azureSqlDatabaseName - System.String: Name of the Azure SQL Database.
    - azureSqlManagedInstanceName - System.String: Name of the Azure SQL Managed Instance.
    - resourceGroupName - System.String: Resource Group Name.
    - subscriptionId - System.String: Subscription ID.
- Returns AzureNativeSqlDatabasePointInTimeRestoreWindow.
### SqlManagedInstanceServer
Retrieves an Azure SQL Managed Instance Server. Refers to the server the Azure SQL Managed Instance Database is a part of.

- The Input parameter takes a single value of type System.String.
- Returns AzureSqlManagedInstanceServer.
### StorageAccount
Gets the storage accounts for the given subscription.

- The Input parameter takes a hashtable with 3 name and value pairs.
    - regionName - System.String
    - subscriptionId - System.String
    - tenantId - System.String
- Returns StorageAccountConnection.
### Subnet
Gets the subnets for the given subscription.

- The Input parameter takes a hashtable with 3 name and value pairs.
    - subscriptionId - System.String
    - tenantId - System.String
    - vNetId - System.String
- Returns SubnetConnection.
### Subscription
Gets the subscriptions for the given Azure tenant.

- The Input parameter takes a single value of type System.String.
- Returns AzureSubscriptionConnection.
### VNet
Gets the VNets for the given subscription.

- The Input parameter takes a hashtable with 3 name and value pairs.
    - regionName - System.String
    - subscriptionId - System.String
    - tenantId - System.String
- Returns VnetConnection.
### allArmTemplatesByFeature
Retrieve ARM templates for role definition and role assignment.

- The Input parameter takes a single value of type AzureArmTemplatesByFeatureInput.
- Returns a list of AzureArmTemplateByFeatures.
### allCdmVersion
Get all Rubrik CDM versions in the Azure marketplace.

- The Input parameter takes a single value of type AzureCdmVersionReq.
- Returns a list of AzureCdmVersions.
### allCloudAccountMissingPermission
Retrieves a list of all the missing permissions on Azure subscriptions that are a part of the Azure Cloud Account.

- The Input parameter takes a hashtable with 3 name and value pairs.
    - cloudAccountAction - CloudAccountAction: The cloud account action to be performed. Some examples are: isCreate, isUpdateRegions, isDelete.
    - sessionId - System.String: Session ID of the current OAuth session.
    - subscriptionIds - a list of System.Strings: List of Azure subscription IDs.
- Returns a list of AzureSubscriptionMissingPermissionss.
### allCloudAccountSubnetsByRegion
Retrieves all subnets in the specified region and subscription. Subnets allow you to choose IP address range of your choice. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/network-overview#virtual-network-and-subnets.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - cloudAccountId - System.String: The Rubrik ID of the cloud account.
    - region - AzureCloudAccountRegion: Azure region.
- Returns a list of AzureNativeSubnets.
### allCloudAccountSubscriptionsByFeature
Retrieves a list of all Azure Subscriptions with feature details such as feature, status, and regions.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
    - subscriptionStatusFilters - a list of CloudAccountStatuss: List of subscription status filters to apply.
- Returns a list of AzureSubscriptionWithFeaturesTypes.
### allCloudAccountTenant
Retrieves a list of all the Azure tenants and tenant subscriptions for features. The list can be filtered by feature status, subscription native ID, and subscription name.

- The Input parameter takes a hashtable with 3 name and value pairs.
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
    - features - a list of CloudAccountFeatures: Cloud account features. A feature refers to the Polaris feature that Rubrik provides.
    - includeSubscriptionDetails - System.Boolean: Specifies whether the details about the subscriptions in the tenants are included in the response or not.
- Returns a list of AzureCloudAccountTenants.
### allDiskEncryptionSetsByRegion
List of all Azure Disk Encryption Sets in a region.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - azureSubscriptionRubrikId - System.String: Rubrik ID of the Azure Subscription.
    - region - AzureNativeRegion: The azure region.
- Returns a list of AzureNativeDiskEncryptionSets.
### allEncryptionKey
List of all Encryption Keys in an Azure Key Vault.

- The Input parameter takes a single value of type AzureEncryptionKeysInput.
- Returns a list of AzureEncryptionKeys.
### allExocomputeConfigsInAccount
Retrieves a list of Azure Exocompute configurations filtered by a cloud account ID or a search query.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - azureExocomputeSearchQuery - System.String: A query that searches for Exocompute configurations with an account name or account native ID that is prefixed by the search query.
    - cloudAccountIDs - a list of System.Strings: IDs of cloud accounts.
- Returns a list of AzureExocomputeConfigsInAccounts.
### allHostedRegion
Lists all Azure regions supported by the Rubrik-Hosted SaaS protection.

- The allHostedRegion subcommand takes no arguments.
- Returns AzureRegionsResp.
### allKeyVaultsByRegion
List of all Azure Key Vaults in a region.

- The Input parameter takes a single value of type AzureKeyVaultsInput.
- Returns a list of AzureKeyVaults.
### allNativeAvailabilitySetsByRegionFromAzure
Retrieves all availability sets in the specified region, resource group, and subscription. An availability set is a logical grouping of VMs to facilitate redundancy and availability. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/availability-set-overview.

- The Input parameter takes a hashtable with 3 name and value pairs.
    - azureSubscriptionRubrikId - System.String: Rubrik ID of the Azure Subscription.
    - region - AzureNativeRegion: The azure region.
    - resourceGroupName - System.String: Resource Group Name.
- Returns a list of AzureNativeAvailabilitySets.
### allNativeExportCompatibleDiskTypesByRegionFromAzure
Retrieves all supported disk types when exporting a specific snapshot. Not all disk types are supported in all the regions. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/disks-types.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - azureSubscriptionRubrikId - System.String: Rubrik ID of the Azure Subscription.
    - region - AzureNativeRegion: The azure region.
- Returns a list of AzureNativeExportCompatibleDiskTypess.
### allNativeExportCompatibleVmSizesByRegionFromAzure
Retrieves all supported virtual machine (VM) sizes when exporting a particular snapshot. Not all VM sizes are supported in all the regions. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/sizes.

- The Input parameter takes a hashtable with 3 name and value pairs.
    - azureSubscriptionRubrikId - System.String: Rubrik ID of the Azure Subscription.
    - region - AzureNativeRegion: The azure region.
    - vmSnapshotId - System.String: Snapshot ID
- Returns a list of AzureNativeExportCompatibleVmSizess.
### allNativeResourceGroupsInfoIfExist
Retrieves a list of resource groups with the specified names which exist in the specified account.

- The Input parameter takes a single value of type AzureGetResourceGroupsInfoIfExistInput.
- Returns a list of AzureResourceGroupInfos.
### allNativeSecurityGroupsByRegionFromAzure
Retrieves all security groups in the specified region and subscription. Security groups enable you to configure network security as a natural extension of an application's structure, allowing you to group virtual machines and define network security policies based on those groups. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/application-security-groups.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - azureSubscriptionRubrikId - System.String: Rubrik ID of the Azure Subscription.
    - region - AzureNativeRegion: The azure region.
- Returns a list of AzureNativeSecurityGroups.
### allNativeStorageAccountsFromAzure
Retrieves list of all storage Accounts in a subscription.

- The Input parameter takes a single value of type System.String.
- Returns a list of AzureNativeStorageAccounts.
### allNativeSubnetsByRegionFromAzure
Retrieves all subnets in the specified region and subscription. Subnets allow you to choose IP address range of your choice. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/network-overview#virtual-network-and-subnets.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - azureSubscriptionRubrikId - System.String: Rubrik ID of the Azure Subscription.
    - region - AzureNativeRegion: The azure region.
- Returns a list of AzureNativeSubnets.
### allNativeVirtualMachineSize
Retrieves all virtual machine (VM) sizes in the subscriptions protected by Rubrik that have been configured for protection. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/sizes.

- The Input parameter takes a single value of type System.String.
- Returns a list of System.Strings.
### allNativeVirtualNetwork
Retrieves all virtual networks (VNets) in the protected subscriptions. VNet enables secure communication with other VNets, the internet, and on-premise networks. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/virtual-networks-overview.

- The Input parameter takes a single value of type System.String.
- Returns a list of AzureNativeVirtualNetworks.
### allNsg
Get all available network security groups for Azure.

- The Input parameter takes a single value of type AzureNsgRequest.
- Returns a list of System.Strings.
### allRegion
Get all available regions for Azure.

- The Input parameter takes a single value of type System.String.
- Returns a list of AzureCloudAccountRegions.
### allResourceGroup
Get resource groups for a service principal in Azure.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - azureRegion - System.String: Region for Azure cloud account.
    - cloudAccountId - System.String: Cloud account ID.
- Returns a list of System.Strings.
### allResourceGroupsFrom
Retrieves a list og all resource groups in the specified account.

- The Input parameter takes a hashtable with 3 name and value pairs.
    - azureSubscriptionNativeId - System.String: The Native ID of the subscription.
    - cloudAccountId - System.String: The Rubrik ID of the cloud account.
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
- Returns a list of AzureResourceGroups.
### allSqlDatabaseServerElasticPool
Retrieves the list of elastic pools available for a SQL Database Server.For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/database/elastic-pool-overview.

- The Input parameter takes a hashtable with 4 name and value pairs.
    - azureSqlDatabaseServerName - System.String: Name of the Azure SQL Database server.
    - azureSqlDatabaseServerRubrikId - System.String: Rubrik ID of the Azure SQL Database Server.
    - resourceGroupName - System.String: Resource Group Name.
    - subscriptionId - System.String: Subscription ID.
- Returns a list of AzureSqlDatabaseServerElasticPools.
### allStorageAccount
List all storage accounts from Azure.

- The Input parameter takes a single value of type AzureStorageAccountsReq.
- Returns a list of System.Strings.
### allSubnet
Get subnets for a given account in Azure.

- The Input parameter takes a single value of type AzureSubnetReq.
- Returns a list of System.Strings.
### allSubscriptionWithExocomputeMapping
Retrieves a list of all Azure subscriptions with Exocompute subscription mapping.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - exocomputeSubscriptionIdsFilter - a list of System.Strings: List of mapped Exocompute subscription IDs.
    - features - a list of CloudAccountFeatures: Cloud account features. A feature refers to the Polaris feature that Rubrik provides.
- Returns a list of AzureSubscriptionWithExocomputeMappings.
### allVnet
Get VNets for a given account in Azure.

- The Input parameter takes a single value of type AzureVnetReq.
- Returns a list of System.Strings.
### doesNativeResourceGroupExist
Checks if a resource group with the specified name exists in the specified account.

- The Input parameter takes a hashtable with 4 name and value pairs.
    - azureSubscriptionNativeId - System.String: The Native ID of the subscription.
    - cloudAccountId - System.String: The Rubrik ID of the cloud account.
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
    - resourceGroupName - System.String: The name of the resource group.
- Returns System.Boolean.
### isNativeManagedDiskSnapshotRestorable
Specifies whether the Managed Disk snapshot is restorable or not. A managed disk is restorable when the restore settings of the Managed Disk are configured on the Azure portal and on the Rubrik platform. When the value is true, the managed disk snapshot is restorable.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - azureSubscriptionRubrikId - System.String: Rubrik ID of the Azure Subscription.
    - diskSnapshotId - System.String: Snapshot ID
- Returns System.Boolean.
### isNativeSqlDatabaseSnapshotPersistent
Checks if an Azure SQL Database Snapshot or an Azure SQL Managed Instance Database Snapshot is a persistent snapshot.

- The Input parameter takes a single value of type System.String.
- Returns System.Boolean.
### isStorageAccountNameAvailable
Specifies whether the given storage account name is valid and available in Azure to be assigned to a new storage account. When the value is true, the specified account name is available in Azure.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - azureSubscriptionRubrikId - System.String: Rubrik ID of the Azure Subscription.
    - storageAccountName - System.String: A unique name for the storage account. Storage account names must be between 3 and 24 characters in length and may contain numbers and lowercase letters only.
- Returns System.Boolean.
### validateCloudAccountExocomputeConfiguration
Validates if Azure subnets are correctly configured for running Azure Kubernetes Service (AKS) Clusters. When correctly configured, the Azure subnets allow the required region-specific outbound connectivity and do not overlap with Azure restricted IP Address Space.

- The Input parameter takes a single value of type ValidateAzureCloudAccountExocomputeConfigurationsInput.
- Returns ValidateAzureSubnetsForCloudAccountExocomputeReply.
### validateNativeSqlDatabaseDbNameForExport
Validates the name used for an Sql Database during an export operation. Returns true if the database name is valid. Returns false, with an error message, if the database name validation fails. Returns false, without an error message for all other failures.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - azureSqlDatabaseName - System.String: Name of the Azure SQL Database.
    - azureSqlDatabaseServerRubrikId - System.String: Rubrik ID of the Azure SQL Database Server.
- Returns ValidateAzureNativeSqlDatabaseDbNameForExportReply.
### validateNativeSqlManagedInstanceDbNameForExport
Validates the name used for an Managed Instance Database during an export operation. Returns true if the database name is valid. Returns false, with an error message, if the database name validation fails. Returns false, without an error message for all other failures.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - azureSqlDatabaseName - System.String: Name of the Azure SQL Database.
    - azureSqlManagedInstanceServerRubrikId - System.String: Rubrik ID of the Azure SQL Managed Instance Server.
- Returns ValidateAzureNativeSqlManagedInstanceDbNameForExportReply.
