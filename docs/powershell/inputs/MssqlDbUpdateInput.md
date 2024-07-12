### MssqlDbUpdateInput
Supported in v5.0+

- configuredSlaDomainId: System.String
  - Assign database to SLA Domain.
- maxDataStreams: System.Int32
  - Supported in v5.0+
      Maximum number of parallel data streams that can be used to back up the database.
- isPaused: System.Boolean
  - Supported in v5.2+
      Whether to pause or resume backups/archival for this database.
- shouldForceFull: System.Boolean
  - Supported in v5.2+
      Determines whether to force a full for the next snapshot of a SQL Server database. When this value is true, the Rubrik cluster takes a full snapshot. This value is false by default and is reset to false after a successful full snapshot.
- shouldClearPostBackupScript: System.Boolean
  - Supported in v9.2
      Specifies whether to clear the post-backup script. When true, the post-backup script parameters are cleared and set to null.
- shouldClearPreBackupScript: System.Boolean
  - Supported in v9.2
      Specifies whether to clear the pre-backup script. When true, the pre-backup script parameters are cleared and set to null.
- mssqlNonSlaProperties: MssqlNonSlaPropertiesInput
  - Supported in Rubrik cluster versions 4.0 and later. Non-SLA-Domain properties of a SQL Server database.
      In Rubrik cluster versions 5.2 and later, use 'MssqlSlaPatchProperties' instead.
      In Rubrik cluster versions 9.0 and later, use 'MssqlSlaRelatedProperties' instead.
- mssqlSlaPatchProperties: MssqlSlaPatchPropertiesInput
  - Supported in Rubrik cluster versions 5.2 and later. SLA Domain properties of a SQL Server database. In Rubrik cluster versions 9.0 and later, use 'MssqlSlaRelatedProperties' instead.
- mssqlSlaRelatedProperties: MssqlSlaRelatedPropertiesInput
  - Supported in Rubrik cluster versions 9.0 and later. Non-SLA-Domain properties of a SQL Server database.
- postBackupScript: MssqlScriptDetailInput
  - Supported in v5.0+
- preBackupScript: MssqlScriptDetailInput
  - Supported in v5.0+
