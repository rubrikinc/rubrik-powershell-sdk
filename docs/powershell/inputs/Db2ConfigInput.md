### Db2ConfigInput
Input to configure the SLA Domain for Db2 database.

- incrementalFrequency: SlaDurationInput
  - Frequency value for incremental backup of Db2 databases.
- logRetention: SlaDurationInput
  - Specifies the duration for which the Db2 database logs will be retained.
- differentialFrequency: SlaDurationInput
  - Frequency value for differential backup of Db2 databases.
- logArchivalMethod: LogArchivalMethod
  - Configure the log archival method for Db2 database log backups.
- incrementalSchedule: GlobalSnapshotScheduleInput
  - Schedule of incremental backup of Db2 databases, with exactly one unit set and its days listed.
- differentialSchedule: GlobalSnapshotScheduleInput
  - Schedule of the Db2 delta backup, with exactly one unit set and its days listed.
