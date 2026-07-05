### OptionalHealthChecksInput
Input for optional health checks configuration.

- archivalHealthCheckParams: list of ArchivalHealthCheckParamsInputs
  - The archival locations for which connectivity will be checked from Exocompute.
- runCloudslabCheck: System.Boolean
  - If true, connectivity to cloudslab is checked.
- runGcsConnectivityCheck: System.Boolean
  - If true, connectivity to GCS for indexing is checked.
- runSqlMiConnectivityCheck: System.Boolean
  - If true, connectivity to the customer's Azure SQL Managed Instance servers
is checked.
- runSqlDbConnectivityCheck: System.Boolean
  - If true, connectivity to the Rubrik-owned Azure SQL DB server is checked.
- requestedChecks: list of ExoHealthCheckTypes
  - The specific diagnostic checks to run. When provided, only these checks
are run instead of the default set.
