### AzureCosmosNosqlConfigInput
SLA Domain configuration for Azure Cosmos DB for NoSQL.

- shouldChangeContinuousBackupRetention: System.Boolean
  - Specifies whether RSC changes the continuous backup retention of the
Azure Cosmos DB account of each container protected by this SLA Domain to
the retention in this configuration. The account must already use
continuous backup (Azure point-in-time restore). RSC does not migrate an
account from periodic backup, and refuses to assign this SLA Domain to an
account, database or container of an account on periodic backup. Azure
applies the backup policy to the whole account, so the change covers every
container in the account, including containers RSC does not protect. When
false, this SLA Domain does not change the backup policy of any account.
- continuousBackupRetentionInDays: System.Int32
  - Specifies the number of days Azure retains continuous backups: 7 or 30.
Must be 0 when RSC does not change the continuous backup retention. Azure
sets retention per account, so RSC raises each account to the longest
retention among its protected containers whose SLA Domain allows the
change, and never lowers it. Azure charges for backup storage on the
30-day tier; the 7-day tier has no backup storage charge.
