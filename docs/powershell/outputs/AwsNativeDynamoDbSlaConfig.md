### AwsNativeDynamoDbSlaConfig
The SLA Domain configuration for AWS DynamoDB instances.

- cmkAliasForPrimaryBackup: System.String
  - Specifies the customer-managed key (CMK) alias to be applied on the primary backups of the DynamoDB tables.
- continuousBackupsEnabled: System.Boolean
  - Specifies whether continuous backups (Point-in-Time Recovery) are enabled for DynamoDB tables.
- continuousBackupRetentionInDays: System.Int32
  - Specifies the retention period in days for continuous backups (Point-in-Time Recovery) of DynamoDB tables.
