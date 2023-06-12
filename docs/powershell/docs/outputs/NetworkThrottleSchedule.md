### NetworkThrottleSchedule
Summary of scheduled throttle.

- throttleLimit: System.Single
  - Network bandwidth throttle limit for a resource, in Mbps.
- daysOfWeek: list of DayOfWeeks
  - Days of the week on which to apply a scheduled network throttle.
- startHour: System.Int32
  - Denotes the start time. The start time should be an hour of the day.
- endHour: System.Int32
  - Denotes the end time. The end time should be an hour of the day.
