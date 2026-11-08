### AwsNativeEc2InstanceRecoverySpec
AWS native EC2 instance recovery specification.

- appId: System.String
  - ID of the recovery plan.
- snappableId: System.String
  - ID of the workload.
- version: System.Int64
  - Version of the recovery specification.
- userData: System.String
  - Script to run on the recovered virtual machine after reboot.
- recoveryPointOpt: System.Int64
  - Recovery point of the workload.
- instanceType: System.String
  - Instance type to use for the recovered EC2 instance.
- subnetNativeId: System.String
  - Subnet native ID used for the recovered EC2 instance.
- kmsKeyId: System.String
  - KMS key ID to use for the recovered EC2 instance.
- sshKeyPairName: System.String
  - SSH key pair name to use for the recovered EC2 instance.
- iamInstanceProfileArn: System.String
  - IAM instance profile ARN to use for the recovered EC2 instance.
- securityGroupNativeIds: list of System.Strings
  - Security group native IDs to use for the recovered EC2 instance.
- vpcNativeId: System.String
  - VPC native ID for the recovered EC2 instance.
- snapshotType: SnapshotType
  - Which type of snapshot used to recover the EC2 instance from. This is only used in INSTANCE Spec for a recovery.
