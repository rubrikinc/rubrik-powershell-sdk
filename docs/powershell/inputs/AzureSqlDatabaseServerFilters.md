### AzureSqlDatabaseServerFilters
Filters for list of Azure SQL Database Servers.

- nameSubstringFilter: NameSubstringFilter
  - Filter by name substring.
- effectiveSlaFilter: EffectiveSlaFilter
  - Filter by effective SLA Domain.
- resourceGroupFilter: AzureSqlDatabaseServerResourceGroupFilter
  - Filter by resource group name.
- subscriptionFilter: AzureSqlDatabaseServerSubscriptionFilter
  - Filter by subscription.
- regionFilter: AzureNativeRegionFilter
  - Filter by region.
- azureNativeIsEligibleForSqlDatabaseServerProtectionFilter: AzureNativeIsEligibleForSqlDatabaseServerProtectionFilter
  - Filter workloads based on their eligibility for protection (nested).
- isEligibleForProtection: System.Boolean
  - Filter workloads based on their eligibility for protection.
