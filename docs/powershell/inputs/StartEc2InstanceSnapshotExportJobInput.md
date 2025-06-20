### StartEc2InstanceSnapshotExportJobInput
Input to initiate an export job for an AWS native EC2 instance.

- snapshotId: System.String
  - ID of the snapshot to be exported.
- destinationAwsAccountRubrikId: System.String
  - Rubrik UUID of the AWS account where the instance will be exported.
- instanceType: AwsNativeEc2InstanceType
  - Deprecated, use ec2InstanceType instead. Instance class of EC2 instance.
- ec2InstanceType: System.String
  - AWS Native EC2 instance type to be used after export. Some examples are: t2.nano, m5.xlarge. For more information, see https://aws.amazon.com/ec2/instance-types.
- instanceName: System.String
  - Name of the exported instance.
- securityGroupIds: list of System.Strings
  - List of security group IDs to be used for the exported instance.
- subnetId: System.String
  - ID of the subnet to use for the exported instance.
- destinationRegionId: AwsNativeRegion
  - Region of the exported instance.
- shouldCopyTags: System.Boolean
  - Specifies whether to copy tags to the exported instance.
- kmsKeyId: System.String
  - ID of the KMS key to be used for export.
- sshKeyPairName: System.String
  - Name of the SSH key pair to be used for export.
- exportInstanceInPoweredOffState: System.Boolean
  - Power state of the exported instance.
- snapshotType: SnapshotType
  - Type of snapshot used for export.
- amiId: System.String
  - ID of the Amazon Machine Image (AMI) to be used for launching the EC2 instance. This field should be specified only when snapshotType is specified as Archived and amiTypeForAwsNativeArchivedSnapshot returns AMI type as USER_SPECIFIED. In other cases, either a pre-existing AMI is picked, or a new AMI is created at runtime, and an AMI ID is not required. The AMI specified here should be present in the target account and region of export. The specified AMI will be used for launching the instance for export, and all its volumes will be replaced.
- iamInstanceProfileArn: System.String
  - ARN of the IAM instance profile to be attached to the exported EC2 instance.
- archivedSnapshotId: System.String
  - ID of the archived snapshot to be exported. This field should be specified only when `snapshotType` is set to `Archived`. In such cases, the archived snapshot will be used for export. If `snapshotType` is not `Archived`, this field is ignored.
