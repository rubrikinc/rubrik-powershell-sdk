### AwsNativeEc2InstanceSpecificSnapshot
Specific information for AWS EC2 snapshot created on Polaris.

- nativeId: System.String
  - Native ID of the EC2 snapshot.
- nativeName: System.String
  - Native name of the EC2 snapshot.
- consistencyLevel: SnapshotServiceConsistencyLevel
  - Consistency level of the EC2 snapshot.
- instanceType: System.String
  - Instance type of the EC2 snapshot.
- awsNativeAccountId: System.String
  - AWS native account ID of the EC2 snapshot.
- region: System.String
  - Region native ID of the EC2 snapshot.
- volumeSnapshotsToExclude: list of System.Strings
  - Volume snapshots excluded from the EC2 snapshot.
- iamInstanceProfileArn: System.String
  - IAM instance profile ARN of the EC2 object at the time EC2 snapshot was taken.
- devicePathToVolumeSnapshotIdMap: DevicePathToVolumeSnapshotIdMap
  - List of key-value pairs that map device path to volume snapshot.
- snapshotId: System.String
  - ID of the snapshot.
