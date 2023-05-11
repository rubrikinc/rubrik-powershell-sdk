### AzureNativeVirtualMachineFilters
Filters for list of Azure virtual machines.

- appProtectionStatusFilter: CloudNativeInstaceAppProtectionFilter
  - Filter by the protection status of the App.
- effectiveSlaFilter: EffectiveSlaFilter
  - Filter by effective SLA Domain.
- exocomputeConnectedFilter: AzureNativeVmExocomputeConnectedFilter
  - Filter by configured Exocompute.
- fileIndexingFilter: AzureNativeVmFileIndexingFilter
  - Filter by file indexing status.
- nameSubstringFilter: NameSubstringFilter
  - Filter by name substring.
- rbsStatusFilter: AzureVmCcOrCnpRbsConnectionStatusFilter
  - Filter by RBS connection status.
- regionFilter: AzureNativeRegionFilter
  - Filter by region.
- relicFilter: RelicFilter
  - Filter by relics.
- resourceGroupFilter: AzureNativeVmResourceGroupFilter
  - Filter by resource group.
- subscriptionFilter: AzureNativeVmSubscriptionFilter
  - Filter by subscription.
- tagFilter: AzureNativeTagFilter
  - Filter by tag.
- vmSizeFilter: AzureNativeVmSizeFilter
  - Filter by virtual machine sizes.
- vnetFilter: AzureNativeVnetFilter
  - Filter by VNet.
