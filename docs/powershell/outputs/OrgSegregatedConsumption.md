### OrgSegregatedConsumption
Rich org-level segregated consumption data with detailed breakdowns

- orgId: System.String
  - UUID of the organization
- orgName: System.String
  - Name of the organization
- totalFetbConsumed: System.Int64
  - Total FETB consumed aggregated across all Microsoft 365 workloads
- totalObjectCount: System.Int64
  - Total protected object count for this org
- exchangeConsumption: SegregatedFETBConsumption
  - Segregated consumption for Exchange workload
- onedriveConsumption: SegregatedFETBConsumption
  - Segregated consumption for OneDrive workload
- sharepointConsumption: SegregatedFETBConsumption
  - Segregated consumption for SharePoint workload
- totalConsumption: SegregatedFETBConsumption
  - Aggregated total consumption across all Microsoft 365 workloads
- objectTypeUsage: list of ObjectTypeUsages
  - Consumption breakdown by object type.
- hasAuthenticatedMgmtApp: System.Boolean
  - Indicates whether the organization has an authenticated management
application. If this is false, protected user counts are 0 because user
count calculation requires an authenticated management application. Storage
consumption is populated regardless of the status of this field.
