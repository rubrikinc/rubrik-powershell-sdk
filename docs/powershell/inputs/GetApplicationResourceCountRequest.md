### GetApplicationResourceCountRequest
Request to get count of application resources with optional filters.

- applicationId: System.String
  - Application managed object ID.
- resourceTypes: list of ApplicationResourceTypeFilterInputs
  - Filter by specific application resource types.
Includes both configuration resources (VPC, Subnet, Security Group) and
workload resources (EC2, RDS).
Empty means all resource types.
- shouldIncludeGranularWorkloadProtectionStatus: System.Boolean
  - When true, populate granular per-resource protection details in the
response. Despite the field name, this covers config resource types as
well as workload ones; config resources repeat their resource type's
status and warning flags.
