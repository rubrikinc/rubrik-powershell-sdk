### MysqldbPerReplicaRestoreSettingsInput
Restore settings for one target replica of an HA MySQL cluster.

- mysqldbAutomatedRestoreInstanceDetails: MysqldbAutomatedRestoreInstanceDetailsInput
  - Restore details for this replica, such as the MySQL configuration file path.
- mysqldbAutomatedRestoreConnectionInfo: MysqldbAutomatedRestoreConnectionInfoInput
  - Credentials to be used during MySQL recovery for this replica.
- replicaId: System.String
  - Required. ID of the target replica being restored, as returned in the replicaId field of MysqldbHaReplicaConfig.
