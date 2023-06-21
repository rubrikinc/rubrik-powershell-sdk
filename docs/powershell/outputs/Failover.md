### Failover
A protection task.

- id: System.String
  - ID of the failover job.
- taskchainId: System.String
- appBlueprintId: System.String
  - ID of the associated appblueprint.
- source: System.String
  - Source of the workload associated with this Orchestrated Application Recovery failover job.
- targetSite: System.String
  - Target site of the Orchestrated Application Recovery failover job.
- startTime: DateTime
  - The timestamp that the job starts.
- endTime: DateTime
  - The timestamp that the job ends.
- failoverStatus: FailoverStatusEnum
  - The failover job status.
- failoverType: FailoverTypeEnum
  - The type of the failover job.
- lastTestTime: DateTime
  - The timestamp of the last test.
- lastTestStatus: LastTestStatusEnum
  - The status of the last test.
- duration: System.Int64
  - Duration of the Orchestrated Application Recovery failover job, in milliseconds.
- appBlueprintName: System.String
  - Name of the associated appblueprint.
- report: FailoverReport
  - The report for the failover job.
