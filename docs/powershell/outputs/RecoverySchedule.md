### RecoverySchedule
Recovery schedule associated with a recovery plan.

- recoveryPlanId: System.String
  - Recovery plan identifier this schedule belongs to.
- scheduleId: System.Int64
  - Unique identifier for the schedule.
- scheduleInfo: ScheduleInfoV2Output
  - Schedule details (frequency, timezone, start time, config, recipients).
- nextRunTime: DateTime
  - Next scheduled run time.
