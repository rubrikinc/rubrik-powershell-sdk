### AzureNativeVirtualMachineFilters
Filters for list of Azure virtual machines.

- nameSubstringFilter: NameSubstringFilter
  - Filter by name substring.
- effectiveSlaFilter: EffectiveSlaFilter
  - Filter by effective SLA Domain.
- resourceGroupFilter: AzureNativeVmResourceGroupFilter
  - Filter by resource group.
- subscriptionFilter: AzureNativeVmSubscriptionFilter
  - Filter by subscription.
- regionFilter: AzureNativeRegionFilter
  - Filter by region.
- vmSizeFilter: AzureNativeVmSizeFilter
  - Filter by virtual machine sizes.
- vnetFilter: AzureNativeVnetFilter
  - Filter by VNet.
- relicFilter: RelicFilter
  - Filter by relics.
- sensitivityStatusFilter: SensitivityStatusFilter
  - Filter by sensitivity status.
- protectionStatusFilter: ProtectionStatusFilter
  - Filter by protection status.
- tagFilter: AzureNativeTagFilter
  - Filter by tag.
- exocomputeConnectedFilter: AzureNativeVmExocomputeConnectedFilter
  - Filter by configured Exocompute.
- fileIndexingFilter: AzureNativeVmFileIndexingFilter
  - Filter by file indexing status.
- appProtectionStatusFilter: CloudNativeInstaceAppProtectionFilter
  - Filter by the protection status of the App.
- rbsStatusFilter: AzureVmCcOrCnpRbsConnectionStatusFilter
  - Filter by RBS connection status.
- orgFilter: OrgFilter
  - Filter by organization ID.
- hierarchyFilter: Filter
  - Deprecated, use hierarchyFilters.
- hierarchyFilters: list of Filters
  - Filter by hierarchy.
