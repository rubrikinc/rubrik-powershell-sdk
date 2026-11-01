### SddScheduleFrequency
A recurrence rate, expressed as a unit of time and a multiple of that unit.
For example, frequencyType WEEKLY with interval 2 recurs every two weeks.

- frequencyType: SddScheduleFrequencyType
  - Time unit the recurrence is measured in, such as DAILY or WEEKLY.
FREQUENCY_TYPE_UNSPECIFIED is rejected.
- interval: System.Int32
  - How many of those units pass between occurrences. Must be greater than
zero: interval 3 with frequencyType DAILY recurs every third day.
