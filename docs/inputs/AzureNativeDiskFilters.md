### AzureNativeDiskFilters
Filters for list of Azure disks.

- attachedVmFilter: AzureNativeAttachedVmFilter
  - Filter by attached Azure Virtual Machine.
- diskTypeFilter: AzureNativeDiskTypeFilter
  - Filter by disk type.
- effectiveSlaFilter: EffectiveSlaFilter
  - Filter by effective SLA Domain of disks.
- exocomputeConnectedFilter: AzureNativeDiskExocomputeConnectedFilter
  - Filter by Exocompute connection status in the disk region.
- fileIndexingFilter: AzureNativeDiskFileIndexingFilter
  - Filter disks where file indexing is enabled.
- nameSubstringFilter: NameSubstringFilter
  - Filter by disk name.
- regionFilter: AzureNativeRegionFilter
  - Filter by disk region.
- relicFilter: RelicFilter
  - Filter by disk relic status.
- resourceGroupFilter: AzureNativeDiskResourceGroupFilter
  - Filter by disk resource group name.
- subscriptionFilter: AzureNativeDiskSubscriptionFilter
  - Filter by subscription.
- tagFilter: AzureNativeTagFilter
  - Filter by disk tags.
