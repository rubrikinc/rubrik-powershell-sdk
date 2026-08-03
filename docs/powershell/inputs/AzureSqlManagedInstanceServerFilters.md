### AzureSqlManagedInstanceServerFilters
Filters for list of Azure SQL Managed Instance Servers.

- nameSubstringFilter: NameSubstringFilter
  - Filter by name substring.
- effectiveSlaFilter: EffectiveSlaFilter
  - Filter by effective SLA Domain.
- regionFilter: AzureNativeRegionFilter
  - Filter by region.
- tagFilter: AzureNativeTagFilter
  - Filter by tag.
- isEligibleForProtection: System.Boolean
  - Filter workloads based on their eligibility for protection.
- resourceGroupFilter: AzureSqlManagedInstanceServerResourceGroupFilter
  - Filter by resource group name.
- subscriptionFilter: AzureSqlManagedInstanceServerSubscriptionFilter
  - Filter by subscription.
- azureNativeIsEligibleForSqlMiServerProtectionFilter: AzureNativeIsEligibleForSqlMiServerProtectionFilter
  - Filter workloads based on their eligibility for protection (nested).
