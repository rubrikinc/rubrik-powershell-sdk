### MonthlySnapshotScheduleInput
Monthly snapshot schedule.

- basicSchedule: BasicSnapshotScheduleInput
  - Basic monthly snapshot schedule.
- dayOfMonth: DayOfMonth
  - Day of the month.
- daysOfMonth: list of MonthlyDaySpecInputs
  - List the days in a month on which you want a snapshot with monthly frequency to be taken. Currently, you can specify only one day per month, but multiple selections will be supported in the future.
