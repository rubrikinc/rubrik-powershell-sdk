### OrgSegregatedConsumption
Rich org-level segregated consumption data with detailed breakdowns

- orgId: System.String
  - UUID of the organization
- orgName: System.String
  - Name of the organization
- totalFetbConsumed: System.Int64
  - Total FETB consumed aggregated across all Microsoft 365 workloads
- totalObjectCount: System.Int64
  - Total object count for this org
- exchangeConsumption: SegregatedFETBConsumption
  - Segregated consumption for Exchange workload
- onedriveConsumption: SegregatedFETBConsumption
  - Segregated consumption for OneDrive workload
- sharepointConsumption: SegregatedFETBConsumption
  - Segregated consumption for SharePoint workload
- totalConsumption: SegregatedFETBConsumption
  - Aggregated total consumption across all Microsoft 365 workloads
