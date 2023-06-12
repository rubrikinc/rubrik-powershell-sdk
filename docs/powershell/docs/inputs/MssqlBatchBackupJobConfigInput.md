### MssqlBatchBackupJobConfigInput
Supported in v5.0+

- availabilityGroupIds: list of System.Strings
  - Supported in v5.0+
      v5.0-v5.2: IDs of the Microsoft SQL availability groups. All databases with a `rootId` belonging to this list will be considered.
      v5.3+: IDs of the Microsoft SQL availability groups. All databases with a `rootId` belonging to this list are considered for taking an on demand snapshot.
- databaseIds: list of System.Strings
  - Supported in v5.0+
      v5.0-v5.2: IDs of the Microsoft SQL databases. All databases in this list will be considered.
      v5.3+: IDs of the Microsoft SQL databases. All databases in this list are considered for taking an on demand snapshot.
- forceFullSnapshot: System.Boolean
  - Supported in v5.0+
      v5.0-v5.2: Whether to force a full snapshot or an incremental.
      v5.3+: Determines whether to force a full or incremental snapshot.
- hostIds: list of System.Strings
  - Supported in v5.0+
      v5.0-v5.2: IDs of the hosts. All databases with a `rootId` belonging to this list will be considered.
      v5.3+: IDs of the hosts. All databases with a `rootId` belonging to this list are considered for taking an on demand snapshot.
- instanceIds: list of System.Strings
  - Supported in v5.0+
      v5.0-v5.2: IDs of the Microsoft SQL instances. All non-availability databases on these instances will be considered.
      v5.3+: IDs of the Microsoft SQL instances. All non-availability databases on these instances are considered for taking an on demand snapshot.
- windowsClusterIds: list of System.Strings
  - Supported in v5.0+
      v5.0-v5.2: IDs of the Windows clusters. All databases with a `rootId` belonging to this list will be considered.
      v5.3+: IDs of the Windows clusters. All databases with a `rootId` belonging to this list are considered for taking an on demand snapshot.
- baseOnDemandSnapshotConfig: BaseOnDemandSnapshotConfigInput
  - Configuration for the on-demand SQL Server snapshots.
