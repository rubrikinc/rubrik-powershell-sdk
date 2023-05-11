### NetworkThrottleSchedule
Summary of scheduled throttle.

- daysOfWeek: a list of DayOfWeeks
  - Days of the week on which to apply a scheduled network throttle.
- endHour: System.Int32
  - Denotes the end time. The end time should be an hour of the day.
- startHour: System.Int32
  - Denotes the start time. The start time should be an hour of the day.
- throttleLimit: System.Single
  - Network bandwidth throttle limit for a resource, in Mbps.
