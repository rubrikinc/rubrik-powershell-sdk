### O365Consumption
Stores the consumption of Microsoft 365 license.

- consumption: LicenseConsumptionType
  - Overall Rubrik M365 license consumption statistics.
- consumptionPerWorkloadType: list of PerWorkloadConsumptionTypes
  - Consumption statistics per workload type.
- consumptionPerMspOrg: list of MultiTenancyConsumptionTypes
  - List of licenses consumed for all multitenant organizations of an account.
- orgSegregatedConsumption: list of OrgSegregatedConsumptions
  - Rich org-level segregated consumption data with detailed breakdowns.
