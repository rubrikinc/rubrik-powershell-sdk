# New-RscQueryAzureO365
## Subcommands
### checknetworksubnet
Checks the network subnet of the Azure resources.

- There are 6 arguments.
    - tenantId - System.String
    - subscriptionId - System.String
    - resourceGroupName - System.String
    - vnet_name - System.String
    - subnet_name - System.String
    - strict_addr_check - System.Boolean
- Returns AzureNetworkSubnetResp.
### checknsgoutboundrules
Checks the NSG Outbound rules of the Azure resources.

- There are 5 arguments.
    - tenantId - System.String
    - subscriptionId - System.String
    - resourceGroupName - System.String
    - vnet_name - System.String
    - subnet_name - System.String
- Returns AzureNetworkSecurityGroupResp.
### checkresourcegroupname
Checks the resource group name.

- There are 3 arguments.
    - tenantId - System.String
    - subscriptionId - System.String
    - groupName - System.String
- Returns AzureResourceAvailabilityResp.
### checkstorageaccountaccessibility
Checks the accessibility of the storage account.

- There are 4 arguments.
    - tenantId - System.String
    - subscriptionId - System.String
    - storage_account_name - System.String
    - groupName - System.String
- Returns AzureResourceAvailabilityResp.
### checkstorageaccountname
CheckAzureStorageAccountName checks that given storage account name is
valid and available for use in Azure.

- There are 3 arguments.
    - tenantId - System.String: The Azure tenant ID.
    - subscriptionId - System.String: The Azure subscription ID.
    - storage_account_name - System.String: The Azure storage account name to check.
- Returns AzureResourceAvailabilityResp.
### checksubscriptionquota
Checks the Azure subscription quota.

- There are 3 arguments.
    - tenantId - System.String
    - subscriptionId - System.String
    - regionName - System.String
- Returns AzureResourceAvailabilityResp.
### checkvirtualnetworkname
Checks the virtual network name.

- There are 4 arguments.
    - tenantId - System.String
    - subscriptionId - System.String
    - groupName - System.String
    - vnet_name - System.String
- Returns AzureResourceAvailabilityResp.
### exocompute
GetAzureO365Exocompute returns the details of the specified Exocluster.

- There are 2 arguments.
    - orgId - System.String: Org UUID.
    - exocomputeClusterId - System.String: The ID of the exocompute cluster.
- Returns GetAzureO365ExocomputeResp.
### getazurehosttype
GetAzureHostType returns the Azure host type for an account. If no license
is specified, it returns the default host type.
If an exoclusterID is specified, it returns the host type of the exocluster.

- The getazurehosttype subcommand takes no arguments.
- Returns GetAzureHostTypeResp.
### getnetworksubnetunusedaddr
GetAzureNetworkSubnetUnusedAddr validates the subnet and gets the unused
ip address space in the subnet.

- There are 6 arguments.
    - tenantId - System.String: The Azure tenant ID.
    - subscriptionId - System.String: The Azure subscription ID.
    - resourceGroupName - System.String: The Azure resource group name.
    - vnet_name - System.String: The Azure virtual network name.
    - subnet_name - System.String: The Azure subnet name.
    - strict_addr_check - System.Boolean: Whether to fail if any address in the subnet is in use.
- Returns AzureNetworkSubnetUnusedAddrResp.
### validateuserroles
Validates that the caller has the Azure global-administrator and
subscription-owner roles required for O365 setup. The
O365InventoryEnabled feature-flag gate is enforced upstream in the
Scala resolver, mirroring the V1 path.

- There are 2 arguments.
    - tenantId - System.String: The Azure tenant ID.
    - subscriptionId - System.String: The Azure subscription ID.
- Returns AzureUserRoleResp.
