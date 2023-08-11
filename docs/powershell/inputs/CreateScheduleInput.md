### CreateScheduleInput
Input for creating a schedule for the specified Recovery Plan.

- recoveryPlanFid: System.String
  - Recovery Plan ID.
- startRunTime: DateTime
  - Start run time.
- timezone: System.String
  - User's time zone.
- frequency: ScheduleFrequency
  - Recovery frequency.
- recoveryConfig: RecoveryConfigInput
  - Recovery configuration.
- recipients: list of System.Strings
  - Recipients of the recovery report.
