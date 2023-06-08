# Invoke-RscQueryAzureO365
## Subcommands
### Checknetworksubnet
Checks the network subnet of the Azure resources.

- There are 6 arguments.
    - tenantId - System.String
    - subscriptionId - System.String
    - resourceGroupName - System.String
    - vnet_name - System.String
    - subnet_name - System.String
    - strict_addr_check - System.Boolean
- Returns AzureNetworkSubnetResp.
### Checknsgoutboundrule
Checks the NSG Outbound rules of the Azure resources.

- There are 5 arguments.
    - tenantId - System.String
    - subscriptionId - System.String
    - resourceGroupName - System.String
    - vnet_name - System.String
    - subnet_name - System.String
- Returns AzureNetworkSecurityGroupResp.
### Checkresourcegroupname
Checks the resource group name.

- There are 3 arguments.
    - tenantId - System.String
    - subscriptionId - System.String
    - groupName - System.String
- Returns AzureResourceAvailabilityResp.
### Checkstorageaccountaccessibility
Checks the accessibility of the storage account.

- There are 4 arguments.
    - tenantId - System.String
    - subscriptionId - System.String
    - storage_account_name - System.String
    - groupName - System.String
- Returns AzureResourceAvailabilityResp.
### Checkstorageaccountname
Checks the storage account name.

- There are 3 arguments.
    - tenantId - System.String
    - subscriptionId - System.String
    - storage_account_name - System.String
- Returns AzureResourceAvailabilityResp.
### Checksubscriptionquota
Checks the Azure subscription quota.

- There are 3 arguments.
    - tenantId - System.String
    - subscriptionId - System.String
    - regionName - System.String
- Returns AzureResourceAvailabilityResp.
### Checkvirtualnetworkname
Checks the virtual network name.

- There are 4 arguments.
    - tenantId - System.String
    - subscriptionId - System.String
    - groupName - System.String
    - vnet_name - System.String
- Returns AzureResourceAvailabilityResp.
### Exocompute
Gets the exocompute details of the given cluster.

- There are 2 arguments.
    - orgId - System.String: Org UUID.
    - exocomputeClusterId - System.String
- Returns GetAzureO365ExocomputeResp.
### Getazurehosttype
Retrieves the AzureHostType of the account.

- The Getazurehosttype subcommand takes no arguments.
- Returns GetAzureHostTypeResp.
### Getnetworksubnetunusedaddr
Retrieves the unused addresses available in a subnet.

- There are 6 arguments.
    - tenantId - System.String
    - subscriptionId - System.String
    - resourceGroupName - System.String
    - vnet_name - System.String
    - subnet_name - System.String
    - strict_addr_check - System.Boolean
- Returns AzureNetworkSubnetUnusedAddrResp.
### Validateuserrole
Validates the user roles in the subscription.

- There are 2 arguments.
    - tenantId - System.String
    - subscriptionId - System.String
- Returns AzureUserRoleResp.
