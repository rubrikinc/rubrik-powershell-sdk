### SLAWithExternalReplicationTargetSummary
Summary of global SLA Domain with external replication targets.

- name: System.String
  - Name of the SLA Domain.
- snapshotSchedule: SnapshotSchedule
  - Snapshot schedule for the SLA Domain.
- stateVersion: System.Int64
  - State version of the SLA Domain.
- firstFullBackupWindows: list of BackupWindows
  - First full backup windows of the SLA Domain.
- backupWindows: list of BackupWindows
  - Backup windows for the SLA Domain.
- objectSpecificConfigs: ObjectSpecificConfigs
  - The object-specific configurations of the SLA Domain.
- objectTypeList: list of SlaObjectTypes
  - The object-types supported by the SLA Domain.
- replicationSpecs: list of ReplicationSpecV2s
  - Replication specification for the SLA Domain.
- logConfig: LogConfigResult
  - Log configuration of the SLA Domain.
- sourceAccountId: System.String
  - ID of the account in which the SLA Domain was created.
- id: System.String
  - ID of the SLA Domain.
