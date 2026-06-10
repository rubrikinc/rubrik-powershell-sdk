### YearlySnapshotScheduleInput
Yearly snapshot schedule.

- basicSchedule: BasicSnapshotScheduleInput
  - Basic yearly snapshot schedule.
- dayOfYear: DayOfYear
  - Day of the Year.
- yearStartMonth: Month
  - Starting month of year.
- daysOfYear: list of YearlyDaySpecInputs
  - List of days of the year on which snapshots should be taken.
Each entry specifies a month and a day within that month.
