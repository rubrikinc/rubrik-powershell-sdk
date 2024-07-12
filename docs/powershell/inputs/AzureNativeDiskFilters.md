### AzureNativeDiskFilters
Filters for list of Azure disks.

- nameSubstringFilter: NameSubstringFilter
  - Filter by disk name.
- effectiveSlaFilter: EffectiveSlaFilter
  - Filter by effective SLA Domain of disks.
- resourceGroupFilter: AzureNativeDiskResourceGroupFilter
  - Filter by disk resource group name.
- subscriptionFilter: AzureNativeDiskSubscriptionFilter
  - Filter by subscription.
- regionFilter: AzureNativeRegionFilter
  - Filter by disk region.
- diskTypeFilter: AzureNativeDiskTypeFilter
  - Filter by disk type.
- attachedVmFilter: AzureNativeAttachedVmFilter
  - Filter by attached Azure Virtual Machine.
- relicFilter: RelicFilter
  - Filter by disk relic status.
- tagFilter: AzureNativeTagFilter
  - Filter by disk tags.
- exocomputeConnectedFilter: AzureNativeDiskExocomputeConnectedFilter
  - Filter by Exocompute connection status in the disk region.
- fileIndexingFilter: AzureNativeDiskFileIndexingFilter
  - Filter disks where file indexing is enabled.
- orgFilter: OrgFilter
  - Filter by organization ID.
