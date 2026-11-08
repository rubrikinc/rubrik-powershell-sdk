### ApplicationResourceTypeCount
Count of application resources for a specific resource type.
Used for application resource count breakdown by type.

- resourceType: ApplicationResourceTypeFilter
  - Application resource type (config or cloud native object).
- count: System.Int64
  - Count of resources of this type.
- protectionStatus: CloudNativeProtectionStatus
  - Protection status by resource type.
- tagBasedCount: System.Int64
  - Count of resources discovered via tag-based discovery.
- autoDiscoveryCount: System.Int64
  - Count of resources discovered via auto discovery.
- warningFlags: list of ApplicationWarningFlags
  - Actionable protection warnings applying to this resource type.
- manuallySelectedCount: System.Int64
  - Count of resources explicitly chosen via an inclusion list.
