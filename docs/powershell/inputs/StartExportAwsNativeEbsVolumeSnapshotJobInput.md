### StartExportAwsNativeEbsVolumeSnapshotJobInput
Input to initiate an export job for the AWS native EBS volume.

- snapshotId: System.String
  - ID of the snapshot to be exported.
- destinationAwsAccountRubrikId: System.String
  - Rubrik UUID of the AWS account where exported volume will reside.
- destinationRegionNativeId: AwsNativeRegion
  - Region of the exported volume.
- volumeName: System.String
  - Name of the exported volume.
- volumeSize: System.Int32
  - Size of the exported volume in Giga Bytes.
- volumeType: AwsNativeEbsVolumeType
  - AWS Native EBS volume type. Some examples are: g3, io2. For more information, see https://aws.amazon.com/ebs/volume-types.
- availabilityZone: System.String
  - Availability Zone (AZ) of the exported volume.
- iops: System.Int32
  - Input/Output (IO) operation limit per second for the exported volume.
- shouldCopyTags: System.Boolean
  - Specifies whether to copy tags to the exported volume.
- shouldReplaceAttached: System.Boolean
  - Specifies whether to replace attached volumes.
- kmsKeyId: System.String
  - ID of the KMS key to be used for export.
- snapshotType: SnapshotType
  - Type of snapshot used for export.
- archivedSnapshotId: System.String
  - ID of the archived snapshot to be exported.
