### EventDigestConfig
Event digest configuration to specify events criteria.

- objectType: list of ActivityObjectTypeEnums
  - Object type to include in event digest.
- activityStatus: list of ActivityStatusEnums
  - Activity statuses to include in event digest.
- activityType: list of System.Strings
  - Activity types included in event digest. Valid types are: Storage, THREAT_MONITORING, Tpr, Classification, LegalHold, HypervScvmm, THREAT_FEED, Hdfs, SCHEDULE_RECOVERY, RadarAnalysis, VolumeGroup, LockSnapshot, Instantiate, BULK_RECOVERY, LOG_BACKUP, HypervServer, ISOLATED_RECOVERY, Configuration, Upgrade, ENCRYPTION_MANAGEMENT_OPERATION, CloudNativeVm, StorageArray, Connection, Conversion, AuthDomain, UnknownEventType, CloudNativeVirtualMachine, Discovery, Replication, Maintenance, Support, Fileset, LocalRecovery, System, Failover, OWNERSHIP, StormResource, Diagnostic, Vcd, Anomaly, Archive, CloudNativeSource, HostEvent, AwsEvent, ResourceOperations, Backup, Sync, TENANT_QUOTA, Hardware, TestFailover, Recovery, Download, EmbeddedEvent, TENANT_OVERLAP, NutanixCluster, VCenter, Index, ThreatHunt, and OTHER_FILTER_ITEM.
- auditType: list of UserAuditTypeEnums
  - Audit types included in event digest. Valid types are: Audit, Classification, SlaModification, LegalHold, THREAT_FEED, BULK_RECOVERY, THREAT_HUNT, ISOLATED_RECOVERY, Configuration, ENCRYPTION_MANAGEMENT_OPERATION, RECOVERY_SCHEDULE, QUARANTINE, Login, LOCAL_RECOVERY, Failover, Diagnostic, RUBY_AI, UnknownUserAuditType, SlaAssignment, AccessManagement, Search, Backup, Sync, ANOMALY, Recovery, Download, FILE_DOWNLOAD, and Index.
- activitySeverity: list of ActivitySeverityEnums
  - Activity severities to include in event digest.
- clusters: list of System.Strings
  - Clusters to include in event digest.
- emailAddresses: list of System.Strings
  - Email addresses of the event digest recipients.
