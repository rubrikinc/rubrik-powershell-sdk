### PureStorageProtectionGroupSummary
Summary of a Pure Storage protection group.

- id: System.String
  - Required. Supported in v9.6+
The ID of the Pure Storage protection group.
- name: System.String
  - Required. Supported in v9.6+
The name of the Pure Storage protection group.
- snapshotConsistencyMandate: PureStorageProtectionGroupSummarySnapshotConsistencyMandate
  - Supported in v9.6+
The snapshot consistency mandate for the protection group.
- primaryClusterId: System.String
  - Required. Supported in v9.6+
The ID of the cluster that manages the Pure Storage protection group.
- quiesceTargets: list of QuiesceTargets
  - Supported in v9.6+
The customer-selected list of quiesce targets (VMware virtual machines and RBA-installed hosts) that the snapshot pipeline runs pre/post scripts against. Empty or omitted when no selection has been configured; an APP_CONSISTENT mandate with an empty selection downgrades the snapshot to CRASH_CONSISTENT (operators see this in the AppConsistentEmptySelection audit event).
