### EventDigestConfig
Event digest configuration to specify events criteria.

- activitySeverity: a list of ActivitySeverityEnums
  - Activity severities to include in event digest.
- activityStatus: a list of ActivityStatusEnums
  - Activity statuses to include in event digest.
- activityType: a list of System.Strings
  - Activity types to include in event digest. Valid types are Storage, Tpr, Classification, LegalHold, HypervScvmm, THREAT_FEED, Hdfs, RadarAnalysis, VolumeGroup, LockSnapshot, Instantiate, BULK_RECOVERY, LOG_BACKUP, HypervServer, ISOLATED_RECOVERY, Configuration, K8S, Upgrade, ENCRYPTION_MANAGEMENT_OPERATION, CloudNativeVm, StorageArray, Connection, Conversion, AuthDomain, UnknownEventType, CloudNativeVirtualMachine, Discovery, Replication, Maintenance, Support, Fileset, LocalRecovery, System, Failover, OWNERSHIP, StormResource, Diagnostic, Vcd, Anomaly, Archive, CloudNativeSource, HostEvent, AwsEvent, ResourceOperations, Backup, Sync, Hardware, TestFailover, Recovery, Download, EmbeddedEvent, TENANT_OVERLAP, NutanixCluster, VCenter, Index, ThreatHunt, and OTHER_FILTER_ITEM.
- clusters: a list of System.Strings
  - Clusters to include in event digest.
- objectType: a list of ActivityObjectTypeEnums
  - Object type to include in event digest.
