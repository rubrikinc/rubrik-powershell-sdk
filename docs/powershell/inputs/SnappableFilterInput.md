### SnappableFilterInput
Filter workload data.

- protectionStatus: list of ProtectionStatusEnums
  - The protection status of the workload.
- slaDomain: SnappableSlaDomainFilterInput
  - The SLA Domain of the workload.
- complianceStatus: list of ComplianceStatusEnums
  - The compliance status of the workload.
- objectType: list of ObjectTypeEnums
  - The object type of the workload.
- excludedObjectTypes: list of ObjectTypeEnums
  - List of workload types to exclude. This should NOT be specified along
with objectType.
- cluster: CommonClusterFilterInput
  - The cluster filter for the workload.
- timeRange: TimeRangeInput
  - The time range filter.
- searchTerm: System.String
  - The search term applied to the workload.
- slaTimeRange: SlaComplianceTimeRange
  - The SLA Domain time range applied to the workload.
- orgId: list of System.Strings
  - The organization IDs of the workload.
- objectState: list of ObjectStates
  - The state of the workload.
- isLocal: System.Boolean
  - True if the workload is local; false if the workload is remote.
- objectFid: list of System.Strings
  - The FIDs of the workload.
- awsServiceType: list of AwsServiceTypes
  - The AWS deployment model of the workload (BaaS / non-BaaS).
Filters only AWS workloads; non-AWS workloads pass through unfiltered.
Empty list disables the filter.
