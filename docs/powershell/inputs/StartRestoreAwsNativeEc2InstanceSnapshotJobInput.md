### StartRestoreAwsNativeEc2InstanceSnapshotJobInput
Trigger AWS EC2 instance snapshot restore job.

- snapshotId: System.String
  - ID of snapshot to restore.
- shouldPowerOn: System.Boolean
  - Specifies the power status of the restored EC2 Instance. When true, the EC2 Instance is powered-on after completion of the restore.
- shouldRestoreTags: System.Boolean
  - Specifies whether to restore associated tags. If true, the restored EC2 Instance will have same tags associated.
- snapshotTypeToUseIfSourceExpired: SnapshotTypeToUseIfSourceExpired
  - Snapshot type to use if source snapshot is expired.
- archivedSnapshotId: System.String
  - ID of the archived snapshot to be restored.
