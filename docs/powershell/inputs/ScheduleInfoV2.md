### ScheduleInfoV2
Recovery schedule information.

- startRunTime: DateTime
  - Start time for the schedule.
- timezone: System.String
  - Timezone for the schedule.
- frequency: ScheduleFrequency
  - Recovery frequency.
- recoveryConfig: RecoveryConfigV2
  - Recovery configuration.
- recipients: list of System.Strings
  - Recovery report recipients.
- excludeReportInEmail: System.Boolean
  - Controls whether recovery reports are excluded from notification emails.
Note: RSC-G deployments override this to true at service layer regardless
of client value
RSC-C/P: Configurable, defaults to false (include report)

Exclude recovery report from notification emails.
