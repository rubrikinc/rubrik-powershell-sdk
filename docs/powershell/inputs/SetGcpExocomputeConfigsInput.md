### SetGcpExocomputeConfigsInput
Input to upsert the exocompute configuration for a GCP project.

- cloudAccountId: System.String
  - Cloud account ID.
- regionalExocomputeConfigs: list of RegionalExocomputeConfigInputs
  - List of exocompute configurations for the regions.
- triggerHealthCheck: System.Boolean
  - Flag to trigger health check.
- optionalHealthChecks: OptionalHealthChecks
  - Contains input for optional health checks that needs to be run.
