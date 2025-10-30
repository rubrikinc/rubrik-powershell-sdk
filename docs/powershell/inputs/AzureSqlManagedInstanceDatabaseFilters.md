### AzureSqlManagedInstanceDatabaseFilters
Filters for list of Azure SQL Managed Instance Databases.

- nameSubstringFilter: NameSubstringFilter
  - Filter by name substring.
- effectiveSlaFilter: EffectiveSlaFilter
  - Filter by effective SLA Domain.
- resourceGroupFilter: AzureSqlManagedInstanceDatabaseResourceGroupFilter
  - Filter by resource group name.
- subscriptionFilter: AzureSqlManagedInstanceDatabaseSubscriptionFilter
  - Filter by subscription.
- regionFilter: AzureNativeRegionFilter
  - Filter by region.
- relicFilter: RelicFilter
  - Filter by relic.
- sensitivityStatusFilter: SensitivityStatusFilter
  - Filter by sensitivity status.
- protectionStatusFilter: ProtectionStatusFilter
  - Filter by protection status.
- serverFilter: CloudNativeDatabaseServerFilter
  - Filter by server.
- serverId: System.String
  - Filter by managed object ID of the server.
- azureNativeIsEligibleForSqlMiDbProtectionFilter: AzureNativeIsEligibleForSqlMiDbProtectionFilter
  - Filter workloads based on their eligibility for protection (nested).
- isEligibleForProtection: System.Boolean
  - Filter workloads based on their eligibility for protection.
