### O365Consumption
Stores the consumption of Microsoft 365 license.

- consumption: LicenseConsumptionType
  - Overall Rubrik M365 license consumption statistics.
- consumptionPerMspOrg: list of MultiTenancyConsumptionTypes
  - List of licenses consumed for all multitenant organizations of an account.
- consumptionPerWorkloadType: list of PerWorkloadConsumptionTypes
  - Consumption statistics per workload type.
