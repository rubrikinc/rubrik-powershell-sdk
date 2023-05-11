### SnappableGroupByFilterInput
Filter snappable data in group by.

- cluster: CommonClusterFilterInput
  - The cluster UUID of the workload.
- complianceStatus: a list of ComplianceStatusEnums
  - The compliance status of the workload.
- excludedObjectTypes: a list of ObjectTypeEnums
  - List of workload types to exclude. This should NOT be specified along with objectType.
- objectType: a list of ObjectTypeEnums
  - The object type of the workload.
- orgId: a list of System.Strings
  - The organization ID of the workload.
- protectionStatus: a list of ProtectionStatusEnums
  - The protection status of the workload.
- slaDomain: SnappableSlaDomainFilterInput
  - The SLA Domain of the workload.
- slaTimeRange: SlaComplianceTimeRange
  - The SLA Domain time range applied to the workload.
- timeRange: TimeRangeInput
  - None
