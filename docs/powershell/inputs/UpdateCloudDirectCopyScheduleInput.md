### UpdateCloudDirectCopyScheduleInput
Fields to update on a copy schedule; unset fields are left unchanged.

- clusterUuid: System.String
  - Cluster UUID is the NCD cluster that owns the schedule.
- scheduleId: System.String
  - Schedule ID is the unique identifier of the schedule to update.
- name: System.String
  - Name is the human-readable label for the schedule; unset leaves the
existing value. Target type and frequency unit cannot be changed after
the schedule is created.
- frequencyValue: System.Int32
  - Frequency value is the interval count; unset leaves the existing value.
- startTime: System.String
  - Start time is the "HH:MM" 24-hour run time, interpreted in the cluster's
local timezone; unset leaves existing.
- dayOfWeek: System.Int32
  - Day of week (0=Sun) for WEEKLY schedules; unset leaves existing.
- dayOfMonth: System.Int32
  - Day of month (1-31) for MONTHLY schedules; unset leaves existing.
- isEnabled: System.Boolean
  - Is enabled pauses (false) or resumes (true) the schedule; unset leaves.
- destinationShareId: System.String
  - Destination share ID is the unique identifier of the NAS share
destination; unset leaves the existing destination unchanged.
- cloudTarget: CopyScheduleCloudTargetInput
  - Cloud target is the inline cloud destination configuration; unset leaves
the existing destination unchanged. When set, it replaces the destination
with this cloud target.
