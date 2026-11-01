### SddSchedule
Schedule for sensitive data discovery on a workload. Not specific to any
workload type, so every object type that supports scheduled discovery
shares this definition.

Which day and month fields a schedule may set depends on its frequency type.
A value outside this table is rejected rather than normalized:

frequencyType      | when                    | startMonth
-------------------+-------------------------+-----------
HOURLY, DAILY      | 0                       | 0
WEEKLY             | 0-6, Sunday is 0        | 0
MONTHLY            | 1-31, or -1 for last    | 1-12
QUARTERLY, YEARLY  | 1 or -1 only            | 1-12

For QUARTERLY and YEARLY, startMonth is the month each period opens in, and
when picks the period's first day (1) or last day (-1). The last day falls in
the month before the next period opens: YEARLY with startMonth 3 and when -1
runs on the last day of February, and QUARTERLY with startMonth 1 and when -1
on the last day of March, June, September and December.

Quarterly and yearly frequencies support only the first or last day of the
month.

- frequency: SddScheduleFrequency
  - Rate at which the scan recurs. Required.
- when: System.Int32
  - Day the scan runs on, as a day-of-week or a day-of-month depending on the
frequency type. See the table above for the range each type allows.
- startMonth: System.Int32
  - Month the recurrence cycle is anchored to. Required for MONTHLY, QUARTERLY
and YEARLY; must be 0 for the shorter frequencies, which have no month to
anchor. See the table above.
- beginTime: DateTime
  - Time the schedule's recurrence is computed from. The first run is only
guaranteed to fall after it, not on or near it. Required: a zero timestamp
is rejected.
