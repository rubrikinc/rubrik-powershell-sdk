### AzureSqlDatabaseFilters
Filters for list of Azure SQL Databases.

- nameSubstringFilter: NameSubstringFilter
  - Filter by name substring.
- effectiveSlaFilter: EffectiveSlaFilter
  - Filter by effective SLA Domain.
- resourceGroupFilter: AzureSqlDatabaseResourceGroupFilter
  - Filter by resource group name.
- subscriptionFilter: AzureSqlDatabaseSubscriptionFilter
  - Filter by subscription.
- regionFilter: AzureNativeRegionFilter
  - Filter by region.
- relicFilter: RelicFilter
  - Filter by relics.
- sensitivityStatusFilter: SensitivityStatusFilter
  - Filter by sensitivity status.
- protectionStatusFilter: ProtectionStatusFilter
  - Filter by protection status.
- tagFilter: AzureNativeTagFilter
  - Filter by tag.
- serverFilter: CloudNativeDatabaseServerFilter
  - Filter by server.
- serverId: System.String
  - Filter by managed object ID of the server.
- azureNativeIsEligibleForSqlDatabaseDbProtectionFilter: AzureNativeIsEligibleForSqlDatabaseDbProtectionFilter
  - Filter workloads based on their eligibility for protection (nested).
- isEligibleForProtection: System.Boolean
  - Filter workloads based on their eligibility for protection.
