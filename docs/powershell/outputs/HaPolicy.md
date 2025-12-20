### HaPolicy
High-availability policy information.

- id: System.String
  - Unique identifier of the high-availability policy.
- name: System.String
  - Name of the high-availability policy.
- description: System.String
  - Description of the high-availability policy.
- primaryClusterUuid: System.String
  - Primary cluster UUID.
- secondaryClusterUuids: list of System.Strings
  - Secondary cluster UUIDs for failover destinations.
- status: FailoverGroupStatus
  - Status of the high-availability policy.
- statusMessage: System.String
  - Status message providing additional details.
- creationTime: System.String
  - Creation time of the high-availability policy.
- lastUpdatedTime: System.String
  - Last updated time of the high-availability policy.
- archivalLocationCount: System.Int32
  - Number of archival locations in this high-availability policy.
- hostCount: System.Int32
  - Number of hosts in this high-availability policy.
- objectCount: System.Int32
  - Number of objects (protected workloads) in this high-availability policy.
