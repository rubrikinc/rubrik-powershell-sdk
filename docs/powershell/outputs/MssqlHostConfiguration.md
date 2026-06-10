### MssqlHostConfiguration
MSSQL host-level configuration flags controlling backup, restore, and operational behavior.

- useDefaultBackupLocation: HostConfigurationPropertyEnabled
  - Supported in v7.0+
Specifies whether to use the default backup location.
- physicalHostDatabaseRestoreThrottleMaxRefCount: System.Int32
  - Supported in v6.0+
The maximum number of concurrent database restore job running on a host.
- multiNodeRestoreMaxDataStreamsPerNode: System.Int32
  - Supported in v9.3+
The maximum number of data streams per node used for multi-node restore.
- fileRestoreReadParallelism: System.Int32
  - Supported in v6.0+
Number of concurrent read requests for restoring a file from the Rubrik cluster to a remote host.
- enableVdi: HostConfigurationPropertyEnabled
  - Supported in v6.0+
Enables SQL Server log backup and restore using VDI.
- enableDatabaseBatchSnapshots: HostConfigurationPropertyEnabled
  - Supported in v6.0+
Specifies if SQL Server batch snapshots are enabled.
- useAf2ForHighDataFileCount: HostConfigurationPropertyEnabled
  - Supported in v9.4+
Specifies whether to use AF2 for high data file count databases.
- fileTransferParallelism: System.Int32
  - Supported in v6.0+
Number of concurrent requests for transferring a file from a remote host to the Rubrik cluster.
- maxNodesForMultiNodeRestore: System.Int32
  - Supported in v9.5+
v9.5: Maximum number of Rubrik nodes to use for multi-node restore on this host. Overrides the global maxNodesForMultiNodeRestore setting. Valid range is from 1 to the total number of nodes available in the cluster.
v9.6: Maximum number of Rubrik nodes to use for multi-node restore on this host. Overrides the global maxNodesForMultiNodeRestore setting. Valid range is 1 to the total number of nodes available in the cluster.
- enableMssqlMultiNodeRestore: HostConfigurationPropertyEnabled
  - Supported in v9.2+
Enables SQL Server multi-node restore.
- copyLogsToHostDuringLiveMount: HostConfigurationPropertyEnabled
  - Specifies whether to copy logs to be applied on the host during a live mount operation instead of exposing them via mount.
- physicalHostLogBackupThrottleMaxRefCount: System.Int32
  - Supported in v6.0+
Maximum number of concurrent SQL Server log backup jobs per physical host.
- cbtMaxMemoryUsageInMb: System.Int32
  - Supported in v6.0+
The maximum memory size in MB that a CBT driver can use.
- throttlePhysicalHostMaxRefCount: System.Int32
  - Supported in v6.0+
Maximum number of concurrent snapshots per physical host.
- mssqlEnableCleanupOnRestoreFailure: HostConfigurationPropertyEnabled
  - Specifies whether to delete orphaned database files (MDF/LDF) at the target restore path during cleanup of a failed restore job.
- maxNodesForMultiNodeBackup: System.Int32
  - Supported in v9.5+
v9.5: Maximum number of Rubrik nodes to use for multi-node backup on this host. Overrides the global maxNodesForMultiNodeBackup setting. Valid range is from 1 to the total number of nodes available in the cluster.
v9.6: Maximum number of Rubrik nodes to use for multi-node backup on this host. Overrides the global maxNodesForMultiNodeBackup setting. Valid range is 1 to the total number of nodes available in the cluster.
- fileRestoreWriteParallelism: System.Int32
  - Supported in v6.0+
Number of concurrent write requests for restoring a file from the Rubrik cluster to a remote host.
- enableGroupFetch: HostConfigurationPropertyEnabled
  - Supported in v6.0+
Enables group fetches of SQL Server files.
- vdiRestoreTimeoutInSecondsPerGb: System.Int32
  - Supported in v7.0+
Length, in seconds, of the timeout for each gigabyte of log during a VDI log restore operation. Has a minimum value of 1800, and a maximum value of 7200.
- mssqlDatabaseQueryTimeout: System.Int32
  - Supported in v9.2+
Length, in seconds, of the query timeout for database operations.
- enableMssqlMultiNodeBackup: HostConfigurationPropertyEnabled
  - Supported in v9.3+
Enables SQL Server multi-node backup.
- af2MinimumFileCount: System.Int32
  - Supported in v9.4+
v9.4: The minimum number of data files a database must have in order to take backups via AF2.
v9.5+: The minimum number of data files a database must have in order to take backups using AF2.
- mssqlDefaultMaxDataStreamsPerDatabase: System.Int32
  - Supported in v6.0+
The default value for maximum number of data streams per database.
- mssqlAllowDirtyReadForDbSizeQuery: HostConfigurationPropertyEnabled
  - Supported in v9.3+
Specifies whether to use the NOLOCK hint when querying database file information.
- mssqlUseDmFileSpaceUsage: HostConfigurationPropertyEnabled
  - Supported in v9.3+
Specifies whether to use sys.dm_db_file_space_usage instead of FILEPROPERTY for determining space usage information.
- enableVdiDb: HostConfigurationPropertyEnabled
  - Supported in v6.0+
Enables SQL Server DB backup and restore using VDI.
- cmdPipeBufferSizeInKb: System.Int32
  - Supported in v9.3+
The size of the buffer in KB for the command pipe.
- vdiRestoreMaxTimeoutInMinutes: System.Int32
  - Supported in v7.0+
Length, in minutes, of the maximum timeout during a VDI log restore operation. Has a minimum value of 360, and a maximum value of 1440.
- maxDbLoadSizeInBytes: System.Int32
  - Supported in v9.4+
Maximum database load size in bytes, used for Sensitive Data Discovery through RBA for SQL databases.
