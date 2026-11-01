### CloudDirectCopyScheduleItem
A copy schedule returned by the list and get RPCs. The destination is a
oneof matching the create/update input shape.

- scheduleId: System.String
  - Schedule ID is the stable unique identifier for this copy schedule.
- clusterUuid: System.String
  - Cluster UUID is the NCD cluster that owns the schedule.
- name: System.String
  - Name is the human-readable label for the schedule.
- targetType: CopyScheduleTargetType
  - Target type is the destination category.
- frequency: CopyScheduleFrequency
  - Frequency is the schedule cadence.
- frequencyValue: System.Int32
  - Frequency value is the interval count within the cadence unit.
- startTime: System.String
  - Start time is the "HH:MM" 24-hour run time for the schedule, interpreted
in the cluster's local timezone.
- dayOfWeek: System.Int32
  - Day of week (0=Sun) for WEEKLY schedules; unset otherwise.
- dayOfMonth: System.Int32
  - Day of month (1-31) for MONTHLY schedules; unset otherwise.
- isEnabled: System.Boolean
  - Is enabled indicates whether the schedule is active (true) or paused.
- destination: CopyScheduleDestinationOutput
  - Destination for the copy schedule.
