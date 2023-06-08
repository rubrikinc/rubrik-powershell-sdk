### MssqlDbSummary
Supported in v5.0+

- availabilityGroupId: System.String
  - Supported in v5.0+
  For an availability database, the ID of the availability group that the database belongs to.
- copyOnly: System.Boolean
  - Required. Supported in v5.0+
  Boolean value that specifies whether or not to perform copy-only backups of the database. When true, database backups are copy-only backups. When false, database backups are full backups.
- hasPermissions: System.Boolean
  - Required. Supported in v5.0+
  v5.0: Boolean value that specifies whether the cluster has permission to backup the database.
  v5.1: Boolean value that specifies whether the cluster has permission to back up the database.
  v5.2+: A Boolean value that specifies whether the cluster has permission to back up the database. When this value is 'true', the cluster has permission to back up the database.
- id: System.String
  - Required. Supported in v5.0+
- instanceId: System.String
  - Supported in v5.0+
  This field is deprecated. Use the instanceId field on the replicas list instead. This field will continue to work for non-availability databases, but it is meaningless for availability databases.
- instanceName: System.String
  - Supported in v5.0+
  This field is deprecated. Use the instanceName field on the replicas list instead. This field will continue to work for non-availability databases, but it is meaningless for availability databases.
- isInAvailabilityGroup: System.Boolean
  - Required. Supported in v5.0+
- isLiveMount: System.Boolean
  - Required. Supported in v5.0+
  Boolean value that specifies whether a database object is a Live Mount. Value is 'true' when the database object is a Live Mount.
- isLogShippingSecondary: System.Boolean
  - Required. Supported in v5.0+
  Boolean value that specifies whether a database object represents a secondary database. Value is 'true' when the database object represents a secondary database in a log shipping configuration.
- isOnline: System.Boolean
  - Required. Supported in v5.0+
  v5.0-v5.1: Boolean value that specifies whether the database state is ONLINE.
  v5.2+: A Boolean value that specifies whether the database is in the ONLINE state. When this value is 'true', the database is in the ONLINE state.
- isRelic: System.Boolean
  - Required. Supported in v5.0+
- logBackupFrequencyInSeconds: System.Int32
  - Required. Supported in v5.0+
- logBackupRetentionHours: System.Int32
  - Required. Supported in v5.0+
  Hours to keep a log backup. A value of -1 indicates that a log will only expire when the preceding snapshots have expired.
- name: System.String
  - Required. Supported in v5.0+
- primaryClusterId: System.String
  - Required. Supported in v5.0+
- replicas: list of MssqlDbReplicas
  - Required. Supported in v5.0+
  List of replicas of this database. An availability database may have multiple replicas, while other databases will have only one replica.
- rootProperties: MssqlRootProperties
  - Required. Supported in v5.0+
- state: System.String
  - Supported in v5.0+
  This field is deprecated. Use the state field on the replicas list instead. This field will continue to work for non-availability databases, but it is meaningless for availability databases.
- currentBackupTaskInfo: BackupTaskDiagnosticInfo
  - Supported in v5.1+
  Information about the current backup task.
- includeBackupTaskInfo: System.Boolean
  - Supported in v5.1+
  True/false value indicating if backup task information is included in the response.
- lastSnapshotTime: DateTime
  - Supported in v5.1+
  v5.1: The timestamp of the previous snapshot
  v5.2-v5.3: The timestamp of the previous snapshot. Only available in the /v1/mssql/db endpoint request body. The information will not be available for other endpoints.
  v6.0+: The timestamp of the previous snapshot.. Only available in the /v1/mssql/db endpoint request body. The information will not be available for other endpoints.
- numMissedSnapshot: System.Int32
  - Supported in v5.1+
  v5.1: An integer that specifies the number of missed snapshots.
  v5.2+: An integer that specifies the number of missed snapshots. Only available in the /v1/mssql/db endpoint request body. The information will not be available for other endpoints.
- pendingSlaDomain: ManagedObjectPendingSlaInfo
  - Supported in v5.2+
  v5.2: Describes any pending SLA assignment on this object.
  v5.3+: Describes any pending SLA Domain assignment on this object.
- hasLogConfigFromSla: System.Boolean
  - Supported in v7.0+
  A boolean value that specifies whether the database derives the log backup configurations from SLA.
- hostLogRetention: System.Int32
  - Supported in v9.0
  Specifies the interval, in hours, the Rubrik cluster waits before the next log snapshot job deletes archived Mssql redo log files whose 'nextTime' field specifies a time longer than this interval. To specify a wait interval, enter a positive integer. To immediately delete archived redo log files regardless of age, specify an interval of -1. To preserve all archived redo log files, specify an interval of -2.
- snappable: CdmWorkload
  - 
- unprotectableReasonsV50: list of MssqlUnprotectableReasons
  - A list of reasons that a SQL Server database cannot be protected by Rubrik.
- unprotectableReasonsV51: list of System.Strings
  - A list of reasons that a SQL Server database cannot be protected by the Rubrik CDM.
- unprotectableReasonsV52: list of System.Strings
  - A list of reasons that a SQL Server database cannot be protected by the Rubrik CDM.
- unprotectableReasonsV53: list of System.Strings
  - A list of reasons that a SQL Server database cannot be protected by the Rubrik CDM.
- unprotectableReasonsV60: list of System.Strings
  - A list of reasons that a SQL Server database cannot be protected by the Rubrik CDM.
- unprotectableReasonsV70: list of System.Strings
  - A list of reasons that a SQL Server database cannot be protected by the Rubrik CDM.
- unprotectableReasonsV80: list of System.Strings
  - A list of reasons that a SQL Server database cannot be protected by the Rubrik CDM.
- unprotectableReasonsV81: list of System.Strings
  - A list of reasons that a SQL Server database cannot be protected by the Rubrik CDM.
- unprotectableReasonsV90: list of System.Strings
  - A list of reasons that a SQL Server database cannot be protected by the Rubrik CDM.
- recoveryModel: MssqlDbSummaryRecoveryModel
  - 
