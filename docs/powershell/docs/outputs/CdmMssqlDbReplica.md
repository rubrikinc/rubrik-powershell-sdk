### CdmMssqlDbReplica
Replica SQL Server database of an availability group.

- state: System.String
  - The state of the replica.
- isStandBy: System.Boolean
  - Specifies if the replica SQL Server database is in standby mode.
- isArchived: System.Boolean
  - Deprecated. Use `isDeleted` instead.
- recoveryModel: System.String
  - The recovery model of the replica.
- hasPermissions: System.Boolean
  - Specifies whether the Rubrik Backup Service has permissions to back up the replica SQL Server database. When this value is 'true', the Rubrik Backup Service has permission to back up the database.
- instanceRootId: System.String
  - ID of the root of this object.
- snapshotNeeded: System.Boolean
  - Specifies if a snapshot needs to be taken before a log backup can occur on the replica SQL Server database.
- clusterUuid: System.String
  - Cluster ID of the replica SQL Server database.
- availabilityInfo: CdmMssqlDbReplicaAvailabilityInfo
  - Information about the availability group of the replica SQL Server database.
- instance: MssqlInstance
  - Instance of the replica SQL Server database.
