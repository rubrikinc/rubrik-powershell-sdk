### GetApplicationResourceCountResponse
Response containing count of application resources with breakdown by type.

- count: System.Int64
  - Total count of resources matching filters.
- countByType: list of ApplicationResourceTypeCounts
  - Count breakdown by resource type.
- applicationName: System.String
  - Name of the application.
- refreshStatus: CloudNativeApplicationRefreshStatus
  - Refresh status of the application.
- cloudNativeAccountName: System.String
  - Account name of the application.
- region: CloudRegion
  - Region where the application is deployed.
- lastRefreshedAt: DateTime
  - Timestamp of the last successful refresh for the application.
- granularResources: list of GranularResourceProtections
  - Per-resource protection details for individual workload resources.
Populated only when shouldIncludeGranularWorkloadProtectionStatus is set
on the request.
