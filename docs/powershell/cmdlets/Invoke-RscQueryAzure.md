# Invoke-RscQueryAzure
## Subcommands
### Addirectorie
All Azure AD directories for the account.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns AzureAdDirectoryConnection.
### Addirectory
Details of the Azure AD corresponds to the workload ID.

- There is a single argument of type System.String.
- Returns AzureAdDirectory.
### Allarmtemplatesbyfeature
Retrieve ARM templates for role definition and role assignment.

- There is a single argument of type AzureArmTemplatesByFeatureInput.
- Returns list of AzureArmTemplateByFeatures.
### Allcdmversion
Get all Rubrik CDM versions in the Azure marketplace.

- There is a single argument of type AzureCdmVersionReq.
- Returns list of AzureCdmVersions.
### Allcloudaccountmissingpermission
Retrieves a list of all the missing permissions on Azure subscriptions that are a part of the Azure Cloud Account.

- There are 3 arguments.
    - sessionId - System.String: Session ID of the current OAuth session.
    - subscriptionIds - list of System.Strings: List of Azure subscription IDs.
    - cloudAccountAction - CloudAccountAction: The cloud account action to be performed. Some examples are: isCreate, isUpdateRegions, isDelete.
- Returns list of AzureSubscriptionMissingPermissionss.
### Allcloudaccountsubnetsbyregion
Retrieves all subnets in the specified region and subscription. Subnets allow you to choose IP address range of your choice. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/network-overview#virtual-network-and-subnets.

- There are 2 arguments.
    - cloudAccountId - System.String: The Rubrik ID of the cloud account.
    - region - AzureCloudAccountRegion: Azure region.
- Returns list of AzureNativeSubnets.
### Allcloudaccountsubscriptionsbyfeature
Retrieves a list of all Azure Subscriptions with feature details such as feature, status, and regions.

- There are 2 arguments.
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
    - subscriptionStatusFilters - list of CloudAccountStatuss: List of subscription status filters to apply.
- Returns list of AzureSubscriptionWithFeaturesTypes.
### Allcloudaccounttenant
Retrieves a list of all the Azure tenants and tenant subscriptions for features. The list can be filtered by feature status, subscription native ID, and subscription name.

- There are 3 arguments.
    - features - list of CloudAccountFeatures: Cloud account features. Rubrik offers a cloud account feature as part of Rubrik Security Cloud (RSC).
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
    - includeSubscriptionDetails - System.Boolean: Specifies whether the details about the subscriptions in the tenants are included in the response or not.
- Returns list of AzureCloudAccountTenants.
### Alldiskencryptionsetsbyregion
List of all Azure Disk Encryption Sets in a region.

- There are 2 arguments.
    - azureSubscriptionRubrikId - System.String: Rubrik ID of the Azure Subscription.
    - region - AzureNativeRegion: The azure region.
- Returns list of AzureNativeDiskEncryptionSets.
### Allencryptionkey
List of all Encryption Keys in an Azure Key Vault.

- There is a single argument of type AzureEncryptionKeysInput.
- Returns list of AzureEncryptionKeys.
### Allexocomputeconfigsinaccount
Retrieves a list of Azure Exocompute configurations filtered by a cloud account ID or a search query.

- There are 2 arguments.
    - azureExocomputeSearchQuery - System.String: A query that searches for Exocompute configurations with an account name or account native ID that is prefixed by the search query.
    - cloudAccountIDs - list of System.Strings: IDs of cloud accounts.
- Returns list of AzureExocomputeConfigsInAccounts.
### Allhostedregion
Lists all Azure regions supported by the Rubrik-Hosted SaaS protection.

- The Allhostedregion subcommand takes no arguments.
- Returns AzureRegionsResp.
### Allkeyvaultsbyregion
List of all Azure Key Vaults in a region.

- There is a single argument of type AzureKeyVaultsInput.
- Returns list of AzureKeyVaults.
### Allnativeavailabilitysetsbyregionfromazure
Retrieves all availability sets in the specified region, resource group, and subscription. An availability set is a logical grouping of VMs to facilitate redundancy and availability. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/availability-set-overview.

- There are 3 arguments.
    - azureSubscriptionRubrikId - System.String: Rubrik ID of the Azure Subscription.
    - resourceGroupName - System.String: Resource Group Name.
    - region - AzureNativeRegion: The azure region.
- Returns list of AzureNativeAvailabilitySets.
### Allnativeexportcompatibledisktypesbyregionfromazure
Retrieves all supported disk types when exporting a specific snapshot. Not all disk types are supported in all the regions. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/disks-types.

- There are 2 arguments.
    - azureSubscriptionRubrikId - System.String: Rubrik ID of the Azure Subscription.
    - region - AzureNativeRegion: The azure region.
- Returns list of AzureNativeExportCompatibleDiskTypess.
### Allnativeexportcompatiblevmsizesbyregionfromazure
Retrieves all supported virtual machine (VM) sizes when exporting a particular snapshot. Not all VM sizes are supported in all the regions. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/sizes.

- There are 3 arguments.
    - azureSubscriptionRubrikId - System.String: Rubrik ID of the Azure Subscription.
    - region - AzureNativeRegion: The azure region.
    - vmSnapshotId - System.String: Snapshot ID
- Returns list of AzureNativeExportCompatibleVmSizess.
### Allnativeresourcegroupsinfoifexist
Retrieves a list of resource groups with the specified names which exist in the specified account.

- There is a single argument of type AzureGetResourceGroupsInfoIfExistInput.
- Returns list of AzureResourceGroupInfos.
### Allnativesecuritygroupsbyregionfromazure
Retrieves all security groups in the specified region and subscription. Security groups enable you to configure network security as a natural extension of an application's structure, allowing you to group virtual machines and define network security policies based on those groups. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/application-security-groups.

- There are 2 arguments.
    - azureSubscriptionRubrikId - System.String: Rubrik ID of the Azure Subscription.
    - region - AzureNativeRegion: The azure region.
- Returns list of AzureNativeSecurityGroups.
### Allnativestorageaccountsfromazure
Retrieves list of all storage Accounts in a subscription.

- There is a single argument of type System.String.
- Returns list of AzureNativeStorageAccounts.
### Allnativesubnetsbyregionfromazure
Retrieves all subnets in the specified region and subscription. Subnets allow you to choose IP address range of your choice. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/network-overview#virtual-network-and-subnets.

- There are 2 arguments.
    - azureSubscriptionRubrikId - System.String: Rubrik ID of the Azure Subscription.
    - region - AzureNativeRegion: The azure region.
- Returns list of AzureNativeSubnets.
### Allnativevirtualmachinesize
Retrieves all virtual machine (VM) sizes in the subscriptions protected by Rubrik that have been configured for protection. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/sizes.

- There is a single argument of type System.String.
- Returns list of System.Strings.
### Allnativevirtualnetwork
Retrieves all virtual networks (VNets) in the protected subscriptions. VNet enables secure communication with other VNets, the internet, and on-premise networks. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/virtual-networks-overview.

- There is a single argument of type System.String.
- Returns list of AzureNativeVirtualNetworks.
### Allnsg
Get all available network security groups for Azure.

- There is a single argument of type AzureNsgRequest.
- Returns list of System.Strings.
### Allregion
Get all available regions for Azure.

- There is a single argument of type System.String.
- Returns list of AzureCloudAccountRegions.
### Allresourcegroup
Get resource groups for a service principal in Azure.

- There are 2 arguments.
    - cloudAccountId - System.String: Cloud account ID.
    - azureRegion - System.String: Region for Azure cloud account.
- Returns list of System.Strings.
### Allresourcegroupsfrom
Retrieves a list og all resource groups in the specified account.

- There are 3 arguments.
    - cloudAccountId - System.String: The Rubrik ID of the cloud account.
    - azureSubscriptionNativeId - System.String: The Native ID of the subscription.
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
- Returns list of AzureResourceGroups.
### Allsqldatabaseserverelasticpool
Retrieves the list of elastic pools available for a SQL Database Server.For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/database/elastic-pool-overview.

- There are 4 arguments.
    - subscriptionId - System.String: Subscription ID.
    - resourceGroupName - System.String: Resource Group Name.
    - azureSqlDatabaseServerName - System.String: Name of the Azure SQL Database server.
    - azureSqlDatabaseServerRubrikId - System.String: Rubrik ID of the Azure SQL Database Server.
- Returns list of AzureSqlDatabaseServerElasticPools.
### Allstorageaccount
List all storage accounts from Azure.

- There is a single argument of type AzureStorageAccountsReq.
- Returns list of System.Strings.
### Allsubnet
Get subnets for a given account in Azure.

- There is a single argument of type AzureSubnetReq.
- Returns list of System.Strings.
### Allsubscriptionwithexocomputemapping
Retrieves a list of all Azure subscriptions with Exocompute subscription mapping.

- There are 2 arguments.
    - features - list of CloudAccountFeatures: Cloud account features. Rubrik offers a cloud account feature as part of Rubrik Security Cloud (RSC).
    - exocomputeSubscriptionIdsFilter - list of System.Strings: List of mapped Exocompute subscription IDs.
- Returns list of AzureSubscriptionWithExocomputeMappings.
### Allvnet
Get VNets for a given account in Azure.

- There is a single argument of type AzureVnetReq.
- Returns list of System.Strings.
### Cloudaccountpermissionconfig
Retrieves the configuration consisting of role permissions and feature policy version required for Azure subscription setup. Features refer to the Polaris features that the customer wants to be enabled on the cloud account.

- There is a single argument of type CloudAccountFeature.
- Returns AzureCloudAccountPermissionConfigResponse.
### Cloudaccountsubscriptionwithfeature
Retrieves the details of the Azure cloud account.

- There is a single argument of type System.String.
- Returns AzureCloudAccountSubscriptionWithFeatures.
### Cloudaccounttenant
Retrieves the details of the Azure tenant and all the subscriptions of the tenant, for a feature.

- There are 5 arguments.
    - tenantId - System.String: Tenant ID of the Azure tenant.
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
    - subscriptionStatusFilters - list of CloudAccountStatuss: List of subscription status filters to apply.
    - subscriptionSearchText - System.String: Search text for subscription name and native ID.
    - subscriptionIdsFilter - list of System.Strings: List of subscription IDs to filter on.
- Returns AzureCloudAccountTenant.
### Cloudaccounttenantwithexoconfig
Retrieves details about the Azure cloud account tenant including the Exocompute configurations for the tenant subscriptions, for a specified feature.

- There are 5 arguments.
    - tenantId - System.String: Tenant ID of the Azure tenant.
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
    - subscriptionStatusFilters - list of CloudAccountStatuss: List of subscription status filters to apply.
    - subscriptionSearchText - System.String: Search text for subscription name and native ID.
    - subscriptionIdsFilter - list of System.Strings: List of subscription IDs to filter on.
- Returns AzureCloudAccountTenantWithExoConfigs.
### Doesnativeresourcegroupexist
Checks if a resource group with the specified name exists in the specified account.

- There are 4 arguments.
    - cloudAccountId - System.String: The Rubrik ID of the cloud account.
    - azureSubscriptionNativeId - System.String: The Native ID of the subscription.
    - resourceGroupName - System.String: The name of the resource group.
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
- Returns System.Boolean.
### Isnativemanageddisksnapshotrestorable
Specifies whether the Managed Disk snapshot is restorable or not. A managed disk is restorable when the restore settings of the Managed Disk are configured on the Azure portal and on the Rubrik platform. When the value is true, the managed disk snapshot is restorable.

- There are 2 arguments.
    - azureSubscriptionRubrikId - System.String: Rubrik ID of the Azure Subscription.
    - diskSnapshotId - System.String: Snapshot ID
- Returns System.Boolean.
### Isnativesqldatabasesnapshotpersistent
Checks if an Azure SQL Database Snapshot or an Azure SQL Managed Instance Database Snapshot is a persistent snapshot.

- There is a single argument of type System.String.
- Returns System.Boolean.
### Isstorageaccountnameavailable
Specifies whether the given storage account name is valid and available in Azure to be assigned to a new storage account. When the value is true, the specified account name is available in Azure.

- There are 2 arguments.
    - azureSubscriptionRubrikId - System.String: Rubrik ID of the Azure Subscription.
    - storageAccountName - System.String: A unique name for the storage account. Storage account names must be between 3 and 24 characters in length and may contain numbers and lowercase letters only.
- Returns System.Boolean.
### Nativemanageddisk
Retrieves an Azure Native Managed Disk that refers to the block storage designed to be used with Azure Virtual Machines. Some examples are: ultra disks, premium solid-state drives (SSD), standard SSDs, and standard hard disk drives (HDD). For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/managed-disks-overview.

- There is a single argument of type System.String.
- Returns AzureNativeManagedDisk.
### Nativeresourcegroup
Retrieves an Azure Native Resource Group. Refers to a collection of resources in which multiple Azure services can reside.

- There is a single argument of type System.String.
- Returns AzureNativeResourceGroup.
### Nativeroot
Root of Azure native hierarchy.

- The Nativeroot subcommand takes no arguments.
- Returns AzureNativeRoot.
### Nativesubscription
Retrieves an Azure Native Subscription. Refers to the logical entity that provides entitlement to deploy and consume Azure resources.

- There is a single argument of type System.String.
- Returns AzureNativeSubscription.
### Nativevirtualmachine
Retrieves an Azure Virtual Machine that refers to the Azure infrastructure as a service (IaaS) used to deploy persistent VMs. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/.

- There is a single argument of type System.String.
- Returns AzureNativeVirtualMachine.
### Region
Gets the Azure regions for the given subscription.

- There are 2 arguments.
    - tenantId - System.String
    - subscriptionId - System.String
- Returns RegionConnection.
### Resourcegroup
Gets the Azure resource groups for the given subscription.

- There are 2 arguments.
    - tenantId - System.String
    - subscriptionId - System.String
- Returns ResourceGroupConnection.
### Sqldatabase
Retrieves an Azure SQL Database. Refers to the fully managed SQL database built for the cloud. For more information, see https://azure.microsoft.com/en-us/products/azure-sql/database/.

- There is a single argument of type System.String.
- Returns AzureSqlDatabaseDb.
### Sqldatabasedbpointintimerestorewindowfromazure
Point-in-Time (PiT) restore window of the Azure SQL Database instance in the Azure native account. Refers to the range of time within which the database is available to be restored to a particular point in time. For more information, see https://azure.microsoft.com/en-in/blog/azure-sql-database-point-in-time-restore/.

- There are 4 arguments.
    - subscriptionId - System.String: Subscription ID.
    - resourceGroupName - System.String: Resource Group Name.
    - azureSqlDatabaseServerName - System.String: Name of the Azure SQL Database server.
    - azureSqlDatabaseName - System.String: Name of the Azure SQL Database.
- Returns AzureNativeSqlDatabasePointInTimeRestoreWindow.
### Sqldatabaseserver
Retrieves an Azure SQL Database Server. Refers to the server that contains the Azure SQL Databases. For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/database/logical-servers.

- There is a single argument of type System.String.
- Returns AzureSqlDatabaseServer.
### Sqlmanagedinstancedatabase
Retrieves an Azure SQL Managed Instance Database. Refers to the database engine compatible with the latest SQL Server (Enterprise Edition) database engine. For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/managed-instance/sql-managed-instance-paas-overview.

- There is a single argument of type System.String.
- Returns AzureSqlManagedInstanceDatabase.
### Sqlmanagedinstancedbpointintimerestorewindowfromazure
Point-in-Time (PiT) restore window of the Azure SQL Managed Instance database in the Azure native account. Refers to the range of time within which the database is available to be restored to a particular point in time. For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/managed-instance/point-in-time-restore?tabs=azure-portal.

- There are 4 arguments.
    - subscriptionId - System.String: Subscription ID.
    - resourceGroupName - System.String: Resource Group Name.
    - azureSqlManagedInstanceName - System.String: Name of the Azure SQL Managed Instance.
    - azureSqlDatabaseName - System.String: Name of the Azure SQL Database.
- Returns AzureNativeSqlDatabasePointInTimeRestoreWindow.
### Sqlmanagedinstanceserver
Retrieves an Azure SQL Managed Instance Server. Refers to the server the Azure SQL Managed Instance Database is a part of.

- There is a single argument of type System.String.
- Returns AzureSqlManagedInstanceServer.
### Storageaccount
Gets the storage accounts for the given subscription.

- There are 3 arguments.
    - tenantId - System.String
    - subscriptionId - System.String
    - regionName - System.String
- Returns StorageAccountConnection.
### Subnet
Gets the subnets for the given subscription.

- There are 3 arguments.
    - tenantId - System.String
    - subscriptionId - System.String
    - vNetId - System.String
- Returns SubnetConnection.
### Subscription
Gets the subscriptions for the given Azure tenant.

- There is a single argument of type System.String.
- Returns AzureSubscriptionConnection.
### Validatecloudaccountexocomputeconfiguration
Validates if Azure subnets are correctly configured for running Azure Kubernetes Service (AKS) Clusters. When correctly configured, the Azure subnets allow the required region-specific outbound connectivity and do not overlap with Azure restricted IP Address Space.

- There is a single argument of type ValidateAzureCloudAccountExocomputeConfigurationsInput.
- Returns ValidateAzureSubnetsForCloudAccountExocomputeReply.
### Validatenativesqldatabasedbnameforexport
Validates the name used for an Sql Database during an export operation. Returns true if the database name is valid. Returns false, with an error message, if the database name validation fails. Returns false, without an error message for all other failures.

- There are 2 arguments.
    - azureSqlDatabaseName - System.String: Name of the Azure SQL Database.
    - azureSqlDatabaseServerRubrikId - System.String: Rubrik ID of the Azure SQL Database Server.
- Returns ValidateAzureNativeSqlDatabaseDbNameForExportReply.
### Validatenativesqlmanagedinstancedbnameforexport
Validates the name used for an Managed Instance Database during an export operation. Returns true if the database name is valid. Returns false, with an error message, if the database name validation fails. Returns false, without an error message for all other failures.

- There are 2 arguments.
    - azureSqlDatabaseName - System.String: Name of the Azure SQL Database.
    - azureSqlManagedInstanceServerRubrikId - System.String: Rubrik ID of the Azure SQL Managed Instance Server.
- Returns ValidateAzureNativeSqlManagedInstanceDbNameForExportReply.
### Vnet
Gets the VNets for the given subscription.

- There are 3 arguments.
    - tenantId - System.String
    - subscriptionId - System.String
    - regionName - System.String
- Returns VnetConnection.
