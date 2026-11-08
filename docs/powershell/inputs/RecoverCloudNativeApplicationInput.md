### RecoverCloudNativeApplicationInput
RecoverCloudNativeApplicationRequest is the request for
RecoverCloudNativeApplication.

- applicationId: System.String
  - MO ID of the cloud native application to recover.
- targetCloudNativeAccountId: System.String
  - Target cloud native account ID for the recovery.
- recoveryName: System.String
  - Human-readable name for this recovery operation.
- errorHandling: RecoveryErrorHandling
  - How to handle errors during a partial recovery.
- workloadSnapshots: list of WorkloadSnapshotInputs
  - Per-workload snapshot selection. May be empty.
- preRecoveryHook: RecoveryHookInput
  - Pre-recovery hook (optional). Absent means no hook is triggered.
- postRecoveryHook: RecoveryHookInput
  - Post-recovery hook (optional). Absent means no hook is triggered.
- vmPostRecoveryScriptEnabled: System.Boolean
  - If true, run the post-recovery script on the recovered instance.
- cloudSettings: CloudSettingsInput
  - Cloud-type-specific recovery settings.
