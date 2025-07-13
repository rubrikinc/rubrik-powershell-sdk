### GetHealthCheckErrorReportReq
GetHealthCheckErrorReportReq is a request to retrieve detailed failure information
for a specific health check type within an Exocompute configuration.

- exocomputeConfigId: System.String
  - This is the ID of the Exocompute configuration to check.
- checkType: System.String
  - The param check_type is the specific health check type to retrieve
failures for.
- cloudVendor: ExocomputeCloudType
  - Cloud vendor for the Exocompute configuration.
