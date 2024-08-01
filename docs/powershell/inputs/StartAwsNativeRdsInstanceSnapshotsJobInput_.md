### StartAwsNativeRdsInstanceSnapshotsJobInput
Input to initiate job to create AWS RDS Instance snapshots.

- rdsInstanceIds: list of System.Strings
  - List of Rubrik UUIDs of the RDS Instances.
- retentionSlaId: System.String
  - ID of the SLA Domain to be used for retention of the snapshots that are created by the RDS instance snapshot job.
