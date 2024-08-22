# New-RscQueryAzureNative
## Subcommands
### availabilitysetsbyregionfromazure
Retrieves all availability sets in the specified region, resource group, and subscription. An availability set is a logical grouping of VMs to facilitate redundancy and availability. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/availability-set-overview.

- There are 3 arguments.
    - azureSubscriptionRubrikId - System.String: Rubrik ID of the Azure Subscription.
    - resourceGroupName - System.String: Resource Group Name.
    - region - AzureNativeRegion: The azure region.
- Returns list of AzureNativeAvailabilitySets.
### doesresourcegroupexist
Checks if a resource group with the specified name exists in the specified account.

- There are 4 arguments.
    - cloudAccountId - System.String: The Rubrik ID of the cloud account.
    - azureSubscriptionNativeId - System.String: The Native ID of the subscription.
    - resourceGroupName - System.String: The name of the resource group.
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
- Returns System.Boolean.
### exportcompatibledisktypesbyregionfromazure
Retrieves all supported disk types when exporting a specific snapshot. Not all disk types are supported in all the regions. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/disks-types.

- There are 2 arguments.
    - azureSubscriptionRubrikId - System.String: Rubrik ID of the Azure Subscription.
    - region - AzureNativeRegion: The azure region.
- Returns list of AzureNativeExportCompatibleDiskTypess.
### exportcompatiblevmsizesbyregionfromazure
Retrieves all supported virtual machine (VM) sizes when exporting a particular snapshot. Not all VM sizes are supported in all the regions. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/sizes.

- There are 3 arguments.
    - azureSubscriptionRubrikId - System.String: Rubrik ID of the Azure Subscription.
    - region - AzureNativeRegion: The azure region.
    - vmSnapshotId - System.String: Snapshot ID
- Returns list of AzureNativeExportCompatibleVmSizess.
### ismanageddisksnapshotrestorable
Specifies whether the Managed Disk snapshot is restorable or not. A managed disk is restorable when the restore settings of the Managed Disk are configured on the Azure portal and on the Rubrik platform. When the value is true, the managed disk snapshot is restorable.

- There are 2 arguments.
    - azureSubscriptionRubrikId - System.String: Rubrik ID of the Azure Subscription.
    - diskSnapshotId - System.String: Snapshot ID
- Returns System.Boolean.
### issqldatabasesnapshotpersistent
Checks if an Azure SQL Database Snapshot or an Azure SQL Managed Instance Database Snapshot is a persistent snapshot.

- There is a single argument of type System.String.
- Returns System.Boolean.
### manageddisk
Retrieves an Azure Native Managed Disk that refers to the block storage designed to be used with Azure Virtual Machines. Some examples are: ultra disks, premium solid-state drives (SSD), standard SSDs, and standard hard disk drives (HDD). For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/managed-disks-overview.

- There is a single argument of type System.String.
- Returns AzureNativeManagedDisk.
### manageddisks
Retrieves a paginated list of all Azure Native Managed Disks.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortBy - AzureNativeDiskSortFields: Sort fields for list of Azure disks.
    - sortOrder - SortOrder: Sort order of result.
    - diskFilters - AzureNativeDiskFilters
- Returns AzureNativeManagedDiskConnection.
### resourcegroup
Retrieves an Azure Native Resource Group. Refers to a collection of resources in which multiple Azure services can reside.

- There is a single argument of type System.String.
- Returns AzureNativeResourceGroup.
### resourcegroups
Retrieves a paginated list of all Azure Native Resource Groups.

- There are 9 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortBy - AzureNativeCommonResourceGroupSortFields: Sort fields for listing Azure resource groups.
    - sortOrder - SortOrder: Sort order of result.
    - commonResourceGroupFilters - AzureNativeCommonResourceGroupFilters: Filters for listing Azure resource groups.
    - protectedObjectTypes - list of WorkloadLevelHierarchys: List of protected object types.
    - azureNativeProtectionFeatures - list of AzureNativeProtectionFeatures: The type of Azure Native features that Polaris supports.
- Returns AzureNativeResourceGroupConnection.
### resourcegroupsinfoifexist
Retrieves a list of resource groups with the specified names which exist in the specified account.

- There is a single argument of type AzureGetResourceGroupsInfoIfExistInput.
- Returns list of AzureResourceGroupInfos.
### root
Root of Azure native hierarchy.

- The root subcommand takes no arguments.
- Returns AzureNativeRoot.
### securitygroupsbyregionfromazure
Retrieves all security groups in the specified region and subscription. Security groups enable you to configure network security as a natural extension of an application's structure, allowing you to group virtual machines and define network security policies based on those groups. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/application-security-groups.

- There are 2 arguments.
    - azureSubscriptionRubrikId - System.String: Rubrik ID of the Azure Subscription.
    - region - AzureNativeRegion: The azure region.
- Returns list of AzureNativeSecurityGroups.
### storageaccountsfromazure
Retrieves list of all storage Accounts in a subscription.

- There is a single argument of type System.String.
- Returns list of AzureNativeStorageAccounts.
### subnetsbyregionfromazure
Retrieves all subnets in the specified region and subscription. Subnets allow you to choose IP address range of your choice. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/network-overview#virtual-network-and-subnets.

- There are 2 arguments.
    - azureSubscriptionRubrikId - System.String: Rubrik ID of the Azure Subscription.
    - region - AzureNativeRegion: The azure region.
- Returns list of AzureNativeSubnets.
### subscription
Retrieves an Azure Native Subscription. Refers to the logical entity that provides entitlement to deploy and consume Azure resources.

- There is a single argument of type System.String.
- Returns AzureNativeSubscription.
### subscriptions
Retrieves a paginated list of all Azure Native Subscriptions.

- There are 10 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortBy - AzureNativeSubscriptionSortFields: Sort fields for list of Azure subscriptions.
    - sortOrder - SortOrder: Sort order of result.
    - subscriptionFilters - AzureNativeSubscriptionFilters
    - authorizedOperationFilter - Operation: Filters according to the operation given.
    - workloadHierarchy - WorkloadLevelHierarchy: Workload hierarchy.
    - azureNativeProtectionFeature - AzureNativeProtectionFeature: The type of Azure Native feature that Polaris supports.
- Returns AzureNativeSubscriptionConnection.
### validatesqldatabasedbnameforexport
Validates the name used for an Sql Database during an export operation. Returns true if the database name is valid. Returns false, with an error message, if the database name validation fails. Returns false, without an error message for all other failures.

- There are 2 arguments.
    - azureSqlDatabaseName - System.String: Name of the Azure SQL Database.
    - azureSqlDatabaseServerRubrikId - System.String: Rubrik ID of the Azure SQL Database Server.
- Returns ValidateAzureNativeSqlDatabaseDbNameForExportReply.
### validatesqlmanagedinstancedbnameforexport
Validates the name used for an Managed Instance Database during an export operation. Returns true if the database name is valid. Returns false, with an error message, if the database name validation fails. Returns false, without an error message for all other failures.

- There are 2 arguments.
    - azureSqlDatabaseName - System.String: Name of the Azure SQL Database.
    - azureSqlManagedInstanceServerRubrikId - System.String: Rubrik ID of the Azure SQL Managed Instance Server.
- Returns ValidateAzureNativeSqlManagedInstanceDbNameForExportReply.
### virtualmachine
Retrieves an Azure Virtual Machine that refers to the Azure infrastructure as a service (IaaS) used to deploy persistent VMs. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/.

- There is a single argument of type System.String.
- Returns AzureNativeVirtualMachine.
### virtualmachines
Retrieves a paginated list of all Azure Virtual Machines (VMs).

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortBy - AzureNativeVirtualMachineSortFields: Sort fields for list of Azure virtual machines.
    - sortOrder - SortOrder: Sort order of result.
    - descendantTypeFilter - list of HierarchyObjectTypeEnums: Filter the CDM cloud hosts by workload type.
    - virtualMachineFilters - AzureNativeVirtualMachineFilters
- Returns AzureNativeVirtualMachineConnection.
### virtualmachinesizes
Retrieves all virtual machine (VM) sizes in the subscriptions protected by Rubrik that have been configured for protection. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/sizes.

- There is a single argument of type System.String.
- Returns list of System.Strings.
### virtualnetworks
Retrieves all virtual networks (VNets) in the protected subscriptions. VNet enables secure communication with other VNets, the internet, and on-premise networks. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/virtual-networks-overview.

- There is a single argument of type System.String.
- Returns list of AzureNativeVirtualNetworks.
