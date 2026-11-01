### CreateCloudDirectCopyScheduleInput
CreateCopyScheduleReq is the request for CreateCloudDirectCopySchedule.
The destination is a oneof, so exactly one of the NAS share target or the
cloud target is set.

- clusterUuid: System.String
  - Cluster UUID is the NCD cluster on which to create the schedule.
- name: System.String
  - Name is the human-readable label for the schedule.
- targetType: CopyScheduleTargetType
  - Target type is the destination category.
- frequency: CopyScheduleFrequency
  - Frequency is the schedule cadence.
- frequencyValue: System.Int32
  - Frequency value is the interval count within the cadence unit.
- startTime: System.String
  - Start time is the run time in "HH:MM" 24-hour form, interpreted in the
cluster's local timezone.
- dayOfWeek: System.Int32
  - Day of week (0=Sunday) for WEEKLY schedules; unset for others.
- dayOfMonth: System.Int32
  - Day of month (1-31) for MONTHLY schedules; unset for others.
- destination: CopyScheduleDestinationInput
  - Destination for the copy schedule.
