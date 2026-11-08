### ApplicationRecoveryInfo
Information about a single application recovery.

- recoveryId: System.String
  - Unique recovery identifier.
- applicationId: System.String
  - Application managed object ID.
- compositeBlueprintId: System.String
  - Composite blueprint ID.
- compositeFailoverId: System.String
  - Composite failover ID.
- targetCloudNativeAccountId: System.String
  - Target cloud native account ID.
- targetRegion: System.String
  - Target region.
- createdAt: DateTime
  - Timestamp when the recovery was created.
- updatedAt: DateTime
  - Timestamp when the recovery was last updated.
- targetCloudNativeAccountName: System.String
  - Target cloud native account name.
- recoveryName: System.String
  - Human-readable name of the recovery.
- startTime: System.Int64
  - Recovery start time as Unix milliseconds. 0 if absent.
- endTime: System.Int64
  - Recovery end time as Unix milliseconds. 0 if absent.
- elapsedTime: System.Int64
  - Elapsed wall time in milliseconds. 0 if absent.
- numWorkloads: System.Int64
  - Number of workloads involved in the recovery. 0 if absent.
- status: ApplicationRecoveryStatus
  - Operational status of the recovery, or UNSPECIFIED when no
status is available.
- recoveryOutcome: ApplicationRecoveryOutcome
  - Final outcome of the recovery, or UNSPECIFIED when not yet known.
