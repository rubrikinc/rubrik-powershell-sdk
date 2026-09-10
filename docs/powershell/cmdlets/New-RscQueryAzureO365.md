# New-RscQueryAzureO365
## Subcommands
### checknetworksubnet
CheckAzureNetworkSubnet checks that the given subnet conforms to the
requirements for the Exocompute config.

- There are 6 arguments.
    - tenantId - System.String: The Azure tenant ID.
    - subscriptionId - System.String: The Azure subscription ID.
    - resourceGroupName - System.String: The Azure resource group name.
    - vnet_name - System.String: The Azure virtual network name.
    - subnet_name - System.String: The Azure subnet name.
    - strict_addr_check - System.Boolean: Whether to fail if any address in the subnet is in use.
- Returns AzureNetworkSubnetResp.
### checknsgoutboundrules
CheckNetworkSecurityGroupOutboundRules validates that the given NSG allows
the required egress traffic for an AKS.

- There are 5 arguments.
    - tenantId - System.String: Azure tenant ID.
    - subscriptionId - System.String: Azure subscription ID.
    - resourceGroupName - System.String: Azure resource group name.
    - vnet_name - System.String: Azure virtual network name.
    - subnet_name - System.String: Azure subnet name.
- Returns AzureNetworkSecurityGroupResp.
### checkresourcegroupname
CheckAzureResourceGroupName checks that the given resource group name is
valid and available for use in Azure.

- There are 3 arguments.
    - tenantId - System.String: The Azure tenant ID.
    - subscriptionId - System.String: The Azure subscription ID.
    - groupName - System.String: The Azure resource group name.
- Returns AzureResourceAvailabilityResp.
### checkstorageaccountaccessibility
CheckAzureStorageAccountAccess checks that the given storage account is
valid and can be accessed by Polaris during Exocompute setup.

- There are 4 arguments.
    - tenantId - System.String: The Azure tenant ID.
    - subscriptionId - System.String: The Azure subscription ID.
    - storage_account_name - System.String: The Azure storage account name.
    - groupName - System.String: The Azure resource group name.
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
CheckAzureSubscriptionQuota checks the quota of E2s_v3 vCPUs and virtual
machines of the customer's subscription in a specific Azure location.

- There are 3 arguments.
    - tenantId - System.String: Azure tenant ID.
    - subscriptionId - System.String: Azure subscription ID.
    - regionName - System.String: Azure region name.
- Returns AzureResourceAvailabilityResp.
### checkvirtualnetworkname
CheckAzureVirtualNetworkNameV2 checks that the given virtual network name
is valid and available for use in Azure. Identity is carried in req_ctx.

- There are 4 arguments.
    - tenantId - System.String: Azure tenant ID.
    - subscriptionId - System.String: Azure subscription ID.
    - groupName - System.String: Azure resource group name.
    - vnet_name - System.String: Azure virtual network name to check.
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
