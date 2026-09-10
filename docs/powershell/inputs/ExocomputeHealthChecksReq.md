### ExocomputeHealthChecksReq
ExocomputeHealthChecksRequest defines the request for retrieving
health checks.

- exocomputeConfigId: System.String
  - This is the unique ID of the Exocompute configuration.
- cloudVendor: ExocomputeCloudType
  - Cloud vendor for the Exocompute configuration, such as Azure or AWS.
- shouldIncludeDiagnosticDetails: System.Boolean
  - When true, includes diagnostic check results (network path trace, AWS
network config, AWS node scaling). Omitted or false excludes diagnostic
data from the response by default.
