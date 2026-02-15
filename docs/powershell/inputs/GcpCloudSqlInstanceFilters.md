### GcpCloudSqlInstanceFilters
Filters for list of GCP Cloud SQL instances.

- nameOrIdSubstringFilter: GcpCloudSqlInstanceNameOrIdSubstringFilter
  - Filter by name or ID substring.
- effectiveSlaFilter: EffectiveSlaFilter
  - Filter by the effective SLA Domain.
- projectFilter: GcpCloudSqlInstanceProjectFilter
  - Filter by GCP project ID.
- regionFilter: GcpNativeRegionFilter
  - Filter by GCP region.
- labelFilter: GcpNativeLabelFilter
  - Filter by GCP labels.
- engineTypeFilter: GcpCloudSqlEngineTypeFilter
  - Filter by database engine type.
- relicFilter: RelicFilter
  - Filter by relic status.
