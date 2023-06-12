### TaskDetailFilterInput
Filter task detail

- clusterUuid: list of System.Strings
  - The cluster UUID of the task.
- clusterType: list of System.Strings
  - The cluster type of the task.
- clusterLocation: list of System.Strings
  - The cluster location of the task.
- objectType: list of System.Strings
  - The object type of the task.
- slaDomain: SnappableSlaDomainFilterInput
  - The SLA Domain of the object of the task.
- replicationSource: list of System.Strings
  - The replication source of the task.
- taskCategory: list of System.Strings
  - The task category.
- taskStatus: list of System.Strings
  - The task status.
- taskType: list of System.Strings
  - The task type.
- time_gt: DateTime
  - The time used to filter tasks that ended after this time.
- time_lt: DateTime
  - The time used to filter tasks that ended before this time.
- searchTerm: System.String
  - The search term applied on the task.
- orgId: list of System.Strings
  - The organization ID of the task.
