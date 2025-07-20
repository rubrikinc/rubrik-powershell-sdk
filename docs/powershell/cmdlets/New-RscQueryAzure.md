# New-RscQueryAzure
## Subcommands
### addirectories
Lists all Azure AD directories for the account.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns AzureAdDirectoryConnection.
### addirectory
Details of the Azure AD corresponding to the workload ID.

- There is a single argument of type System.String.
- Returns AzureAdDirectory.
### adobjectsbytype
Details of the Azure AD objects corresponding to the type.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortByOption - list of AzureAdObjectSearchTypes: Ordered list sorted by column names.
    - sortOrder - SortOrder: Sorts the order of results.
    - input - AzureAdObjectTypeInput: Input for the azureAdObjectsByType API.
- Returns AzureAdObjectConnection.
### armtemplatesbyfeature
Retrieve ARM templates for role definition and role assignment.

- There is a single argument of type AzureArmTemplatesByFeatureInput.
- Returns list of AzureArmTemplateByFeatures.
### azureregions
Get all available regions for Azure.

- There is a single argument of type System.String.
- Returns list of AzureCloudAccountRegions.
### azurestorageaccounts
List all Azure storage accounts by resource group.

- There is a single argument of type AzureStorageAccountsReq.
- Returns list of System.Strings.
### azurevnets
Get VNets for a given account in Azure.

- There is a single argument of type AzureVnetReq.
- Returns list of System.Strings.
### blobcontainersbystorageaccount
List all Azure blob containers by storage account.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - input - AzureBlobContainersByStorageAccountInput: Azure blob containers request parameters by storage account.
- Returns AzureBlobContainerCcprovisionConnection.
### cdmversions
Get all Rubrik CDM versions in the Azure marketplace.

- There is a single argument of type AzureCdmVersionReq.
- Returns list of AzureCdmVersions.
### checkpersistentstoragesubscriptioncanunmap
Checks if we can unmap the archival location from the subscription.

- There are 3 arguments.
    - cloudAccountId - System.String: The Rubrik ID of the cloud account.
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
    - unmappingValidationType - UnmappingValidationType: Unmapping validation type.
- Returns CheckAzurePersistentStorageSubscriptionCanUnmapReply.
### cloudaccountdetailsforfeature
Retrieves the cloud account details from azure customer feature ID.

- There is a single argument of type System.String.
- Returns AzureCloudAccountDetailsForFeatureReply.
### cloudaccountmissingpermissions
Retrieves a list of all the missing permissions on Azure subscriptions that are a part of the Azure Cloud Account.

- There are 3 arguments.
    - sessionId - System.String: Session ID of the current OAuth session.
    - subscriptionIds - list of System.Strings: List of Azure subscription IDs.
    - cloudAccountAction - CloudAccountAction: The cloud account action to be performed. Some examples are: isCreate, isUpdateRegions, isDelete.
- Returns list of AzureSubscriptionMissingPermissionss.
### cloudaccountpermissionconfig
Retrieves the configuration consisting of role permissions and feature policy version required for Azure subscription setup. Features refer to the Polaris features that the customer wants to be enabled on the cloud account.

- There are 2 arguments.
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
    - permissionsGroups - list of PermissionsGroups: Cloud account feature permissions groups.
- Returns AzureCloudAccountPermissionConfigResponse.
### cloudaccountsubnetsbyregion
Retrieves all subnets in the specified region and subscription. Subnets allow you to choose IP address range of your choice. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/network-overview#virtual-network-and-subnets.

- There are 2 arguments.
    - cloudAccountId - System.String: The Rubrik ID of the cloud account.
    - region - AzureCloudAccountRegion: Azure region.
- Returns list of AzureNativeSubnets.
### cloudaccountsubscriptionsbyfeature
Retrieves a list of all Azure Subscriptions with feature details such as feature, status, and regions.

- There are 3 arguments.
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
    - subscriptionStatusFilters - list of CloudAccountStatuss: List of subscription status filters to apply.
    - permissionsGroupFilters - list of FeatureWithPermissionsGroupss: List of feature-to-permission group filters to apply.
- Returns list of AzureSubscriptionWithFeaturesTypes.
### cloudaccountsubscriptionwithfeatures
Retrieves the details of the Azure cloud account.

- There is a single argument of type System.String.
- Returns AzureCloudAccountSubscriptionWithFeatures.
### cloudaccounttenant
Retrieves the details of the Azure tenant and all the subscriptions of the tenant, for a feature.

- There are 6 arguments.
    - tenantId - System.String: Tenant ID of the Azure tenant.
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
    - features - list of CloudAccountFeatures: Cloud account features. Rubrik offers a cloud account feature as part of Rubrik Security Cloud (RSC).
    - subscriptionStatusFilters - list of CloudAccountStatuss: List of subscription status filters to apply.
    - subscriptionSearchText - System.String: Search text for subscription name and native ID.
    - subscriptionIdsFilter - list of System.Strings: List of subscription IDs to filter on.
- Returns AzureCloudAccountTenant.
### cloudaccounttenants
Retrieves a list of all the Azure tenants and tenant subscriptions for features. The list can be filtered by feature status, subscription native ID, subscription name, and tenant domain names.

- There are 5 arguments.
    - features - list of CloudAccountFeatures: Cloud account features. Rubrik offers a cloud account feature as part of Rubrik Security Cloud (RSC).
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
    - includeSubscriptionDetails - System.Boolean: Specifies whether the details about the subscriptions in the tenants are included in the response or not.
    - azureTenants - list of System.Strings: List of Azure tenants domain names.
    - status - list of CloudAccountStatuss: List of cloud account status filters.
- Returns list of AzureCloudAccountTenants.
### cloudaccounttenantwithexoconfigs
Retrieves details about the Azure cloud account tenant including the Exocompute configurations for the tenant subscriptions, for a specified feature.

- There are 6 arguments.
    - tenantId - System.String: Tenant ID of the Azure tenant.
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
    - features - list of CloudAccountFeatures: Cloud account features. Rubrik offers a cloud account feature as part of Rubrik Security Cloud (RSC).
    - subscriptionStatusFilters - list of CloudAccountStatuss: List of subscription status filters to apply.
    - subscriptionSearchText - System.String: Search text for subscription name and native ID.
    - subscriptionIdsFilter - list of System.Strings: List of subscription IDs to filter on.
- Returns AzureCloudAccountTenantWithExoConfigs.
### diskencryptionsetsbyregion
List of all Azure Disk Encryption Sets in a region.

- There are 2 arguments.
    - azureSubscriptionRubrikId - System.String: Rubrik ID of the Azure Subscription.
    - region - AzureNativeRegion: The azure region.
- Returns list of AzureNativeDiskEncryptionSets.
### encryptionkeys
List of all Encryption Keys in an Azure Key Vault.

- There is a single argument of type AzureEncryptionKeysInput.
- Returns list of AzureEncryptionKeys.
### exocomputeconfigsinaccount
Retrieves a list of Azure Exocompute configurations filtered by a cloud account ID or a search query.

- There are 2 arguments.
    - azureExocomputeSearchQuery - System.String: A query that searches for Exocompute configurations with an account name or account native ID that is prefixed by the search query.
    - cloudAccountIDs - list of System.Strings: IDs of cloud accounts.
- Returns list of AzureExocomputeConfigsInAccounts.
### exocomputenetworksetuptemplate
GetAzureExocomputeNetworkSetupTemplate retrieves the ARM templates for
creating VNet, Subnet, and NSG in the regions provided in the request.

- There is a single argument of type GetAzureExocomputeNetworkSetupTemplateReq.
- Returns GetAzureExocomputeNetworkSetupTemplateReply.
### hasrelicadsnapshot
Checks if Microsoft Entra ID has relic snapshots.

- There is a single argument of type HasRelicAzureAdSnapshotInput.
- Returns HasRelicAzureAdSnapshotReplyType.
### hostedazureregions
Lists all Azure regions supported by the Rubrik-Hosted SaaS protection.

- The hostedazureregions subcommand takes no arguments.
- Returns AzureRegionsResp.
### isstorageaccountnameavailable
Specifies whether the given storage account name is valid and available in Azure to be assigned to a new storage account. When the value is true, the specified account name is available in Azure.

- There are 2 arguments.
    - azureSubscriptionRubrikId - System.String: Rubrik ID of the Azure Subscription.
    - storageAccountName - System.String: A unique name for the storage account. Storage account names must be between 3 and 24 characters in length and may contain numbers and lowercase letters only.
- Returns System.Boolean.
### keyvaultsbyregion
List of all Azure Key Vaults in a region.

- There is a single argument of type AzureKeyVaultsInput.
- Returns list of AzureKeyVaults.
### managedidentities
List all managed identities for Azure resources.

- There is a single argument of type AzureManagedIdentitiesRequest.
- Returns list of AzureManagedIdentitys.
### nsgs
Get all available network security groups for Azure.

- There is a single argument of type AzureNsgRequest.
- Returns list of System.Strings.
### regions
Gets the Azure regions for the given subscription.

- There are 2 arguments.
    - tenantId - System.String
    - subscriptionId - System.String
- Returns RegionConnection.
### regionswithazdetails
Retrieve all available regions for Azure with availability zone details.

- There is a single argument of type System.String.
- Returns list of AzureLocationDetailTypes.
### resourcegroups
Gets the Azure resource groups for the given subscription.

- There are 2 arguments.
    - tenantId - System.String
    - subscriptionId - System.String
- Returns ResourceGroupConnection.
### resourcegroupsfromazure
Retrieves a list og all resource groups in the specified account.

- There are 3 arguments.
    - cloudAccountId - System.String: The Rubrik ID of the cloud account.
    - azureSubscriptionNativeId - System.String: The Native ID of the subscription.
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
- Returns list of AzureResourceGroups.
### searchadsnapshot
Search for azureAdObjects in a snapshot.

- There are 3 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - input - SearchAzureAdSnapshotInput: Input for searching for Azure AD objects in a snapshot.
- Returns AzureAdObjectConnection.
### sqldatabase
Retrieves an Azure SQL Database. Refers to the fully managed SQL database built for the cloud. For more information, see https://azure.microsoft.com/en-us/products/azure-sql/database/.

- There are 2 arguments.
    - azureSqlDatabaseRubrikId - System.String: Rubrik ID of the Azure SQL Database.
    - includeSecurityMetadata - System.Boolean: Filter to include the security metadata.
- Returns AzureSqlDatabaseDb.
### sqldatabasedbpointintimerestorewindowfromazure
Point-in-Time (PiT) restore window of the Azure SQL Database instance in the Azure native account. Refers to the range of time within which the database is available to be restored to a particular point in time. For more information, see https://azure.microsoft.com/en-in/blog/azure-sql-database-point-in-time-restore/.

- There are 4 arguments.
    - subscriptionId - System.String: Subscription ID.
    - resourceGroupName - System.String: Resource Group Name.
    - azureSqlDatabaseServerName - System.String: Name of the Azure SQL Database server.
    - azureSqlDatabaseName - System.String: Name of the Azure SQL Database.
- Returns AzureNativeSqlDatabasePointInTimeRestoreWindow.
### sqldatabases
Retrieves a paginated list of all Azure SQL Databases.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - AzureSqlDatabaseSortFields: Sort fields for list of Azure SQL Databases.
    - sortOrder - SortOrder: Sorts the order of results.
    - azureSqlDatabaseFilters - AzureSqlDatabaseFilters: Filters for listing Azure SQL Databases.
    - includeSecurityMetadata - System.Boolean: Filter to include the security metadata.
- Returns AzureSqlDatabaseDbConnection.
### sqldatabaseserver
Retrieves an Azure SQL Database Server. Refers to the server that contains the Azure SQL Databases. For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/database/logical-servers.

- There is a single argument of type System.String.
- Returns AzureSqlDatabaseServer.
### sqldatabaseserverelasticpools
Retrieves the list of elastic pools available for a SQL Database Server.For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/database/elastic-pool-overview.

- There are 4 arguments.
    - subscriptionId - System.String: Subscription ID.
    - resourceGroupName - System.String: Resource Group Name.
    - azureSqlDatabaseServerName - System.String: Name of the Azure SQL Database server.
    - azureSqlDatabaseServerRubrikId - System.String: Rubrik ID of the Azure SQL Database Server.
- Returns list of AzureSqlDatabaseServerElasticPools.
### sqldatabaseservers
Retrieves a paginated list of all Azure SQL Database Servers.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - AzureSqlDatabaseServerSortFields: Sort fields for list of Azure SQL Database Servers.
    - sortOrder - SortOrder: Sorts the order of results.
    - azureSqlDatabaseServerFilters - AzureSqlDatabaseServerFilters: Filters for listing Azure SQL Database Servers.
- Returns AzureSqlDatabaseServerConnection.
### sqlmanagedinstancedatabase
Retrieves an Azure SQL Managed Instance Database. Refers to the database engine compatible with the latest SQL Server (Enterprise Edition) database engine. For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/managed-instance/sql-managed-instance-paas-overview.

- There are 2 arguments.
    - azureSqlManagedInstanceDatabaseRubrikId - System.String: Rubrik ID of the Azure SQL Managed Instance Database.
    - includeSecurityMetadata - System.Boolean: Filter to include the security metadata.
- Returns AzureSqlManagedInstanceDatabase.
### sqlmanagedinstancedatabases
Retrieves a paginated list of all Azure SQL Managed Instance Databases.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - AzureSqlManagedInstanceDatabaseSortFields: Sort fields for list of Azure SQL Managed Instance Databases.
    - sortOrder - SortOrder: Sorts the order of results.
    - azureSqlManagedInstanceDatabaseFilters - AzureSqlManagedInstanceDatabaseFilters: Filters for listing Azure SQL Managed Instance Databases.
    - includeSecurityMetadata - System.Boolean: Filter to include the security metadata.
- Returns AzureSqlManagedInstanceDatabaseConnection.
### sqlmanagedinstancedbpointintimerestorewindowfromazure
Point-in-Time (PiT) restore window of the Azure SQL Managed Instance database in the Azure native account. Refers to the range of time within which the database is available to be restored to a particular point in time. For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/managed-instance/point-in-time-restore?tabs=azure-portal.

- There are 4 arguments.
    - subscriptionId - System.String: Subscription ID.
    - resourceGroupName - System.String: Resource Group Name.
    - azureSqlManagedInstanceName - System.String: Name of the Azure SQL Managed Instance.
    - azureSqlDatabaseName - System.String: Name of the Azure SQL Database.
- Returns AzureNativeSqlDatabasePointInTimeRestoreWindow.
### sqlmanagedinstanceserver
Retrieves an Azure SQL Managed Instance Server. Refers to the server the Azure SQL Managed Instance Database is a part of.

- There is a single argument of type System.String.
- Returns AzureSqlManagedInstanceServer.
### sqlmanagedinstanceservers
Retrieves a paginated list of all Azure SQL Managed Instance Servers.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - AzureSqlManagedInstanceServerSortFields: Sort fields for list of Azure SQL Managed Instance Servers.
    - sortOrder - SortOrder: Sorts the order of results.
    - azureSqlManagedInstanceServerFilters - AzureSqlManagedInstanceServerFilters: Filters for listing Azure SQL Managed Instance Servers.
- Returns AzureSqlManagedInstanceServerConnection.
### storageaccountcontainers
Retrieves the list of containers for the specified storage account.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - StorageAccountContainersSortByField: Sorts the containers by field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of StorageAccountContainersFilterInputs: Filters the containers by field.
    - azureStorageAccountRubrikId - System.String: Rubrik ID for the Azure Storage Account.
- Returns BlobContainerConnection.
### storageaccountexcludedcontainers
Retrieves the list of containers excluded from protection for the specified storage account.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - ExcludedContainersSortByField: Sorts the excluded containers by field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of StorageAccountContainersFilterInputs: Filters the containers by field.
    - azureStorageAccountRubrikId - System.String: Rubrik ID for the Azure Storage Account.
- Returns ExcludedContainerConnection.
### storageaccounts
Gets the storage accounts for the given subscription.

- There are 3 arguments.
    - tenantId - System.String
    - subscriptionId - System.String
    - regionName - System.String
- Returns StorageAccountConnection.
### storageaccountsbyregion
List all Azure storage accounts by region.

- There is a single argument of type AzureStorageAccountsByRegionInput.
- Returns list of AzureStorageAccountCcprovisions.
### subnets
Gets the subnets for the given subscription.

- There are 3 arguments.
    - tenantId - System.String
    - subscriptionId - System.String
    - vNetId - System.String
- Returns SubnetConnection.
### subscriptions
Gets the subscriptions for the given Azure tenant.

- There is a single argument of type System.String.
- Returns AzureSubscriptionConnection.
### subscriptionwithexocomputemappings
Retrieves a list of all Azure subscriptions with Exocompute subscription mapping.

- There are 2 arguments.
    - features - list of CloudAccountFeatures: Cloud account features. Rubrik offers a cloud account feature as part of Rubrik Security Cloud (RSC).
    - exocomputeSubscriptionIdsFilter - list of System.Strings: List of mapped Exocompute subscription IDs.
- Returns list of AzureSubscriptionWithExocomputeMappings.
### supportedadregions
Lists all the supported Azure AD regions.

- The supportedadregions subcommand takes no arguments.
- Returns SupportedAzureAdRegions.
### validatecloudaccountexocomputeconfigurations
Validates if Azure subnets are correctly configured for running Azure Kubernetes Service (AKS) Clusters. When correctly configured, the Azure subnets allow the required region-specific outbound connectivity and do not overlap with Azure restricted IP Address Space.

- There is a single argument of type ValidateAzureCloudAccountExocomputeConfigurationsInput.
- Returns ValidateAzureSubnetsForCloudAccountExocomputeReply.
### validatecreateclusterinput
Validates azure cluster create request.

- There is a single argument of type CreateAzureClusterInput.
- Returns ValidationReply.
### vnets
Gets the VNets for the given subscription.

- There are 3 arguments.
    - tenantId - System.String
    - subscriptionId - System.String
    - regionName - System.String
- Returns VnetConnection.
