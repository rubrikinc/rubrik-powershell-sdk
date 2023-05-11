### StartRestoreAwsNativeEc2InstanceSnapshotJobInput
Trigger AWS EC2 instance snapshot restore job.

- shouldPowerOn: System.Boolean
  - Specifies the power status of the restored EC2 Instance. When true, the EC2 Instance is powered-on after completion of the restore.
- shouldRestoreTags: System.Boolean
  - Specifies whether to restore associated tags. If true, the restored EC2 Instance will have same tags associated.
- snapshotId: System.String
  - ID of snapshot to restore.
- snapshotTypeToUseIfSourceExpired: SnapshotTypeToUseIfSourceExpired
  - Snapshot type to use if source snapshot is expired.
