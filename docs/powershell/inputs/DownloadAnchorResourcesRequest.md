### DownloadAnchorResourcesRequest
Request to download config resources as JSON for offline review.

- cloudNativeAccountId: System.String
  - Cloud native account ID (AWS Account / Azure Subscription / GCP Project).
- serviceConfigured: ApplicationServiceConfigurationInput
  - Service configuration.
- region: CloudRegionInput
  - Filter by specific region.
- tags: list of TagFilterInputs
  - Filter by tags (key-value pairs)
Atleast one tag (key-value pairs) must be specified.
