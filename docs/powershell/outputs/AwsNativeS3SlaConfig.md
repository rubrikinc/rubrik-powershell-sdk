### AwsNativeS3SlaConfig
The SLA Domain configuration for AWS S3 instances.

- continuousBackupRetentionInDays: System.Int32
  - Specifies the duration for which the continuous backups will be retained. This duration determines the earliest time to which a Point-in-Time recovery can be performed on the associated S3 instances.
- archivalLocationId: System.String
  - Specifies the location ID where the primary backups will be stored.
- archivalLocationName: System.String
  - Specifies the location name where the primary backups will be stored.
