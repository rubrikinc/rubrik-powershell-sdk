### AwsRdsInstanceRecoverySpecInput
AwsRdsInstanceRecoverySpec represents the recovery specification for creating a new
AWS RDS instance.

- version: System.Int64
  - The version of the recovery specification.
- snapshotType: SnapshotType
  - The type of snapshot to be used for recovery.
- kmsKeyId: System.String
  - The KMS key ID of the recovered RDS instance.
- dbInstanceClass: System.String
  - The instance class type of the recovered RDS instance.
- dbEngineVersion: System.String
  - The database engine version to be used for the recovered RDS instance.
- isMultiAz: System.Boolean
  - Whether the recovered RDS instance should be configured for multi-AZ deployment.
- primaryAz: System.String
  - The primary availability zone in which the recovered RDS instance should be launched.
- port: System.Int64
  - The port on which the recovered RDS instance will accept connections.
- storageType: System.String
  - The storage type of the recovered RDS instance.
- iops: System.Int64
  - The provisioned IOPS of the recovered RDS instance.
- vpcNativeId: System.String
  - The VPC native ID where the recovered RDS instance will be created.
- securityGroupNativeIds: list of System.Strings
  - The native security group IDs to be associated with the recovered RDS
instance.
- subnetGroupName: System.String
  - The subnet group name for the recovered RDS instance.
- isPubliclyAccessible: System.Boolean
  - Whether the recovered RDS instance should be publicly accessible.
- optionGroupName: System.String
  - The option group name to be associated with the recovered RDS instance.
- parameterGroupName: System.String
  - The parameter group name to be associated with the recovered RDS instance.
- clusterParameterGroupName: System.String
  - The cluster parameter group name to be associated with the recovered RDS instance.
