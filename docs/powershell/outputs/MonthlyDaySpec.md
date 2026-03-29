### MonthlyDaySpec
Specification for day selection for monthly snapshot schedule. You can choose only one type of monthly specification:
1. Choose the date offset for the month using 'specificDate'. For example, dateOffset=1 specifies first day of the month and dateOffset=-1 would mean last day of the month.
2. Choose the day of week pattern using 'dayOfWeekPattern'. For example, First Monday, Last Friday.

- spec: MonthlyDaySpecification
  - The day specification for monthly snapshot schedule.
