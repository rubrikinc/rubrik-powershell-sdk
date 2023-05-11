# Invoke-RscQueryAzureO365
## Subcommands
### CheckNSGOutboundRule
Checks the NSG Outbound rules of the Azure resources.

- The Input parameter takes a hashtable with 5 name and value pairs.
    - resourceGroupName - System.String
    - subnet_name - System.String
    - subscriptionId - System.String
    - tenantId - System.String
    - vnet_name - System.String
- Returns AzureNetworkSecurityGroupResp.
### CheckNetworkSubnet
Checks the network subnet of the Azure resources.

- The Input parameter takes a hashtable with 6 name and value pairs.
    - resourceGroupName - System.String
    - strict_addr_check - System.Boolean
    - subnet_name - System.String
    - subscriptionId - System.String
    - tenantId - System.String
    - vnet_name - System.String
- Returns AzureNetworkSubnetResp.
### CheckResourceGroupName
Checks the resource group name.

- The Input parameter takes a hashtable with 3 name and value pairs.
    - groupName - System.String
    - subscriptionId - System.String
    - tenantId - System.String
- Returns AzureResourceAvailabilityResp.
### CheckStorageAccountAccessibility
Checks the accessibility of the storage account.

- The Input parameter takes a hashtable with 4 name and value pairs.
    - groupName - System.String
    - storage_account_name - System.String
    - subscriptionId - System.String
    - tenantId - System.String
- Returns AzureResourceAvailabilityResp.
### CheckStorageAccountName
Checks the storage account name.

- The Input parameter takes a hashtable with 3 name and value pairs.
    - storage_account_name - System.String
    - subscriptionId - System.String
    - tenantId - System.String
- Returns AzureResourceAvailabilityResp.
### CheckSubscriptionQuota
Checks the Azure subscription quota.

- The Input parameter takes a hashtable with 3 name and value pairs.
    - regionName - System.String
    - subscriptionId - System.String
    - tenantId - System.String
- Returns AzureResourceAvailabilityResp.
### CheckVirtualNetworkName
Checks the virtual network name.

- The Input parameter takes a hashtable with 4 name and value pairs.
    - groupName - System.String
    - subscriptionId - System.String
    - tenantId - System.String
    - vnet_name - System.String
- Returns AzureResourceAvailabilityResp.
### Exocompute
Gets the exocompute details of the given cluster.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - exocomputeClusterId - System.String
    - orgId - System.String: Org UUID.
- Returns GetAzureO365ExocomputeResp.
### GetAzureHostType
Retrieves the AzureHostType of the account.

- The GetAzureHostType subcommand takes no arguments.
- Returns GetAzureHostTypeResp.
### GetNetworkSubnetUnusedAddr
Retrieves the unused addresses available in a subnet.

- The Input parameter takes a hashtable with 6 name and value pairs.
    - resourceGroupName - System.String
    - strict_addr_check - System.Boolean
    - subnet_name - System.String
    - subscriptionId - System.String
    - tenantId - System.String
    - vnet_name - System.String
- Returns AzureNetworkSubnetUnusedAddrResp.
### ValidateUserRole
Validates the user roles in the subscription.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - subscriptionId - System.String
    - tenantId - System.String
- Returns AzureUserRoleResp.
