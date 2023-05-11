### CdmMssqlDbReplica
Replica SQL Server database of an availability group.

- availabilityInfo: CdmMssqlDbReplicaAvailabilityInfo
  - Information about the availability group of the replica SQL Server database.
- clusterUuid: System.String
  - Cluster ID of the replica SQL Server database.
- hasPermissions: System.Boolean
  - Specifies whether the Rubrik Backup Service has permissions to back up the replica SQL Server database. When this value is 'true', the Rubrik Backup Service has permission to back up the database.
- instance: MssqlInstance
  - Instance of the replica SQL Server database.
- instanceRootId: System.String
  - ID of the root of this object.
- isArchived: System.Boolean
  - Deprecated. Use `isDeleted` instead.
- isStandBy: System.Boolean
  - Specifies if the replica SQL Server database is in standby mode.
- recoveryModel: System.String
  - The recovery model of the replica.
- snapshotNeeded: System.Boolean
  - Specifies if a snapshot needs to be taken before a log backup can occur on the replica SQL Server database.
- state: System.String
  - The state of the replica.
