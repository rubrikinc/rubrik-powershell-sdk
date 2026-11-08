### GranularResourceProtection
Per-resource protection details for an individual application resource,
workload or config.

- resourceId: System.String
  - Native resource identifier (ARN / native id).
- resourceName: System.String
  - Human-readable resource name.
- protectionStatus: CloudNativeProtectionStatus
  - Per-resource protection status.
- warningFlags: list of ApplicationWarningFlags
  - Actionable protection warnings applying to this resource.
- resourceType: GranularApplicationResourceType
  - The specific resource type.
