### CreateGlobalSlaInput
Input to create SLA Domain.

- name: System.String
  - Name of the SLA Domain.
- description: System.String
  - Description of the SLA Domain.
- snapshotSchedule: GlobalSnapshotScheduleInput
  - Snapshot schedule of the SLA Domain.
- replicationSpecInput: ReplicationSpecInput
  - Replication specification of the SLA Domain.
- localRetentionLimit: SlaDurationInput
  - Retention limit for snapshots on the local Rubrik system. If none, they will remain as long as SLA requires.
- firstFullBackupWindows: list of BackupWindowInputs
  - Backup Window specifications of first full backup for SLA Domain.
- backupWindows: list of BackupWindowInputs
  - Backup Window specifications for SLA Domain.
- logConfig: LogConfig
  - Log configuration of the SLA Domain.
- objectSpecificConfigsInput: ObjectSpecificConfigsInput
  - Object-specific configuration of the SLA Domain.
- archivalSpecs: list of ArchivalSpecInputs
  - List of archival specifications for SLA Domain.
- replicationSpecsV2: list of ReplicationSpecV2Inputs
  - Replication specificationsof the SLA Domain.
- objectTypes: list of SlaObjectTypes
  - Object types of the SLA Domain.
- isRetentionLockedSla: System.Boolean
  - Specifies if the SLA Domain to be created must be Retention Locked or not.
