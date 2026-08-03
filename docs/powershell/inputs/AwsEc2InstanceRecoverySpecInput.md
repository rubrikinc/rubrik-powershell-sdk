### AwsEc2InstanceRecoverySpecInput
Recovery specification for AWS EC2 instance recovery.

- snapshotType: SnapshotType
  - The type of the source snapshot to be used for recovery.
- instanceType: System.String
  - The instance type of the virtual machine to recover to.
- subnetNativeId: System.String
  - The native ID of the subnet from which to recover the EC2 instance.
- securityGroupNativeIds: list of System.Strings
  - The native IDs of the security groups used for the recovered
virtual machine.
- kmsKeyId: System.String
  - The KMS key ID of the recovered virtual machine (optional).
- sshKeyPairName: System.String
  - The SSH key pair of the recovered virtual machine (optional).
- iamInstanceProfileArn: System.String
  - The IAM instance profile ARN selected by the user (optional).
- vpcNativeId: System.String
  - The VPC native ID of the provided subnet.
