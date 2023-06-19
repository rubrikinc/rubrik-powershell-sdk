### MssqlDbReplica
Supported in v5.0+

- availabilityInfo: MssqlDbReplicaAvailabilityInfo
  - Supported in v5.0+
  For an availability database, provides additional information about a database replica.
- hasPermissions: System.Boolean
  - Required. Supported in v5.0+
  `True` when the Rubrik cluster has sufficient permissions to perform all necessary operations.
- instanceId: System.String
  - Required. Supported in v5.0+
  ID of the SQL Server instance managing the replica.
- instanceName: System.String
  - Required. Supported in v5.0+
  Name of the SQL Server instance managing the replica.
- isArchived: System.Boolean
  - Required. Supported in v5.0+
  Deprecated. Please use 'isDeleted' instead.
- isDeleted: System.Boolean
  - Required. Supported in v5.0+
  `True` when the replica is deleted.
- isStandby: System.Boolean
  - Required. Supported in v5.0+
  `True` when the replica is in standby mode.
- recoveryForkGuid: System.String
  - Supported in v5.0+
  The recovery fork GUID of the replica.
- rootProperties: MssqlRootProperties
  - Required. Supported in v5.0+
- state: System.String
  - Required. Supported in v5.0+
  The state of the replica.
- recoveryModel: MssqlDbReplicaRecoveryModel
  - 
