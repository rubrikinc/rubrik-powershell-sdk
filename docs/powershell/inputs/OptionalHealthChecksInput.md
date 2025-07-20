### OptionalHealthChecksInput
Input for optional health checks configuration.

- archivalHealthCheckParams: list of ArchivalHealthCheckParamsInputs
  - The archival locations for which connectivity will be checked from Exocompute.
- runCloudslabCheck: System.Boolean
  - If true, connectivity to cloudslab is checked.
- runGcsConnectivityCheck: System.Boolean
  - If true, connectivity to GCS for indexing is checked.
