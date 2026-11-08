### GetConfigResourceCountRequest
Request to get count of config resources with optional filters.

- cloudNativeAccountId: System.String
  - Cloud native account ID (AWS Account / Azure Subscription / GCP Project).
- region: CloudRegionInput
  - Filter by specific region.
Default means all regions for a particular cloud type based on
cloud native account id.
- resourceTypes: list of ConfigResourceTypes
  - Filter by specific resource types.
Default means all resource types.
- tags: list of TagFilterInputs
  - Filter by tags (key-value pairs).
Multiple tags use OR logic (resource must have ANY of the specified tags).
Optional: Empty means no tag filtering.
