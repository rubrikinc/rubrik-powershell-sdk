### GcpGetExocomputeConfigsReq
Input to get the exocompute configuration for a GCP project.

- accountId: System.String
  - Optional argument to be used when calling the rpc internally.
- cloudAccountId: System.String
  - Cloud account ID.
- regions: list of GcpCloudAccountRegions
  - Regions to filter against. If regions list is empty, configs for all
regions are returned.
- showHealthCheckStatus: System.Boolean
  - Flag to indicate whether to include health check information.
