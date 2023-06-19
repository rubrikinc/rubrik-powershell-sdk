### RubrikSyncStatus
Status of the data syncing jobs from CDM to RSC.

- objectMetadataSyncLastSuccessTime: DateTime
  - Last success time of the object metadata syncing job.
- clusterSyncLastSuccessTime: DateTime
  - Last success time of the cluster syncing job.
- reportsSyncLastSuccessTime: DateTime
  - Last success time of the reports syncing job.
- jobMonitoringSyncLastSuccessTime: DateTime
  - Last success time of the job-monitoring dashboard syncing job.
- eventsSyncLastSuccessTime: DateTime
  - The time when the events syncing job was last successful.
- isClusterSyncHealthy: System.Boolean
  - Specifies whether cluster sync is operating correctly.
- isJobMonitoringSyncHealthy: System.Boolean
  - Specifies whether job monitoring sync is operating correctly.
- isMetadataSyncHealthy: System.Boolean
  - Specifies whether metadata sync is operating correctly.
- isEventsSyncHealthy: System.Boolean
  - Specifies whether events sync is operating correctly.
- isReportsSyncHealthy: System.Boolean
  - Specifies whether reports sync is operating correctly.
