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
+ Carried as the raw EC2 metadata JSON bytes (deserialized to the type at
+ rubrik/aws/ec2/manager/resources_metadata.go#EC2Metadata); the
+ iam_instance_profile_arn value is extracted by the
+ CUSTOM_FIELD_TRANSFORM_EC2_METADATA_TO_IAM_INSTANCE_PROFILE_ARN transform.
- devicePathToVolumeSnapshotIdMap: DevicePathToVolumeSnapshotIdMap
  - List of key-value pairs that map device path to volume snapshot.
- snapshotId: System.String
  - ID of the snapshot.
