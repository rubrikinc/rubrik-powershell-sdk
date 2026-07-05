### PolicyViolationsByResource
Policy violations grouped by resource.

- resourceId: System.String
  - The resource ID of the resource.
- resourceType: PolicyResourceType
  - The resource type of the resource.
- resourceMetadata: ResourceMetadata
  - Metadata for the resource involved in the policy violation.
- activeViolationsCount: System.Int32
  - The number of active violations for the resource.
- severity: Severity
  - The max severity of the violations for the resource.
- criticalSeverityViolationCount: System.Int32
  - Number of critical severity violations.
