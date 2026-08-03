### AzureSqlDatabaseServerFilters
Filters for list of Azure SQL Database Servers.

- nameSubstringFilter: NameSubstringFilter
  - Filter by name substring.
- effectiveSlaFilter: EffectiveSlaFilter
  - Filter by effective SLA Domain.
- regionFilter: AzureNativeRegionFilter
  - Filter by region.
- isEligibleForProtection: System.Boolean
  - Filter workloads based on their eligibility for protection.
- resourceGroupFilter: AzureSqlDatabaseServerResourceGroupFilter
  - Filter by resource group name.
- subscriptionFilter: AzureSqlDatabaseServerSubscriptionFilter
  - Filter by subscription.
- azureNativeIsEligibleForSqlDatabaseServerProtectionFilter: AzureNativeIsEligibleForSqlDatabaseServerProtectionFilter
  - Filter workloads based on their eligibility for protection (nested).
