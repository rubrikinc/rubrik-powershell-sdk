### OracleDbSummary
Supported in v5.0+

- id: System.String
  - Required. Supported in v5.0+
ID assigned to the Oracle database.
- infraPath: list of ManagedHierarchyObjectAncestors
  - Required. Supported in v5.0+
An array that contains information about the objects in the infrastructure path of a specified Oracle database.
- instances: list of OracleInstancePropertiess
  - Supported in v5.0+
Details of the instances of the Oracle database.
- isArchiveLogModeEnabled: System.Boolean
  - Supported in v5.0+
v5.0-v5.3: Boolean value that indicates whether the ARCHIVELOGMODE is enabled on the Oracle database.
v6.0+: Boolean value that indicates whether the ARCHIVELOG mode is enabled on the Oracle database or not.
- isRelic: System.Boolean
  - Required. Supported in v5.0+
Boolean value that indicates whether a Oracle database object is in an archived state and has retained snapshots. Value is true when the object is archived with retained snapshots.
- name: System.String
  - Required. Supported in v5.0+
Service name of the Oracle database.
- numInstances: System.Int32
  - Supported in v5.0+
Count of the number of instances of the Oracle database.
- numTablespaces: System.Int32
  - Required. Supported in v5.0+
Count of the number of table spaces in Oracle database.
- primaryClusterId: System.String
  - Required. Supported in v5.0+
- racId: System.String
  - Supported in v5.0+
Rubrik ID of the RAC on which this database is hosted. This field will be empty if the database is not hosted on a RAC environment.
- racName: System.String
  - Supported in v5.0+
v5.0-v5.3: RAC name of cluster database.
v6.0+: RAC name of the cluster database.
- sid: System.String
  - Supported in v5.0+
System identifier (SID) of the Oracle database.
- standaloneHostId: System.String
  - Supported in v5.0+
Rubrik ID of the standalone Oracle host on which this database is hosted. This field will be empty if the database is not hosted on a standalone system.
- standaloneHostName: System.String
  - Supported in v5.0+
Hostname of the standalone Oracle database host.
- currentBackupTaskInfo: BackupTaskDiagnosticInfo
  - Supported in v5.1+
Information about the current backup task.
- includeBackupTaskInfo: System.Boolean
  - Supported in v5.1+
True/false value indicating if backup task information is included in the response.
- isDbLocalToTheCluster: System.Boolean
  - Supported in v5.1+
A Boolean value that specifies whether the Oracle database is local to the cluster. When this value is 'true', the Oracle database is local to the cluster.
- lastSnapshotTime: DateTime
  - Supported in v5.1+
The timestamp of the previous snapshot.
- logBackupFrequencyInMinutes: System.Int32
  - Supported in v5.1+
Specifies an interval in minutes. This interval is the period between successive log backups.
- numMissedSnapshot: System.Int32
  - Supported in v5.1+
An integer that specifies the number of missed snapshots.
- archiveLogDestinations: list of System.Strings
  - Supported in v5.2+
v5.2-v5.3: An array that contains the archive log destinations of the specified Oracle database.
v6.0+: An array that contains the archive log destinations for the specified Oracle database.
- hostLogRetentionHours: System.Int32
  - Supported in v5.2+
Specifies an interval in hours. The next log snapshot job deletes archived Oracle redo log files whose 'nextTime' field specifies a time more than the specified number of hours ago. To immediately delete archived redo log files regardless of age, specify an interval of -1. To preserve all archived redo log files, specify an interval of -2.
- isPrimary: System.Boolean
  - Supported in v5.2+
Indicates whether the current DATABASE_ROLE is PRIMARY which specifies the database is accepting read/write transactions as the primary database in a Data Guard configuration.
- dataGuardGroupId: System.String
  - Supported in v6.0+
Rubrik ID of the Data Guard group to which this database belongs.
- dataGuardGroupMembers: list of DataGuardGroupMembers
  - Supported in v6.0+
List of Data Guard group members.
- dataGuardGroupName: System.String
  - Supported in v6.0+
Name of the Data Guard group to which this database belongs.
- dataGuardType: CdmDataGuardType
  - Supported in v6.0+
Indicates whether this object is a non-Data Guard database, Data Guard member database, or Data Guard group.
- databaseRole: System.String
  - Supported in v6.0+
Current role of the database.
- dbUniqueName: System.String
  - Supported in v6.0+
Unique name for the Oracle database (DB_UNIQUE_NAME).
- hasLogConfigFromSla: System.Boolean
  - Supported in v7.0+
Boolean value specifying whether the database obtains the log backup configurations from the SLA Domain.
- snappable: CdmWorkload
- blackoutWindows: BlackoutWindows
  - Supported in v9.3+
An array that contains blackout windows for the Oracle database.
- shouldUseSecureThriftForDataTransfer: System.Boolean
  - Supported in v9.4+
Boolean value specifying whether to use secure thrift as the data transfer mechanism between the Rubrik cluster and the Oracle database instead of NFS. The default data transfer mechanism is NFS.
- blackoutWindowStatus: BlackoutWindowStatus
  - Supported in v9.3+
Status of the blackout window for the Oracle database.
