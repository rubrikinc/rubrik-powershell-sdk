### MonthlyDaySpecInput
Specification for day selection for monthly snapshot schedule. You can choose only one type of monthly specification: 
1. Choose the date offset for the month using 'specificDate'. For example, dateOffset=1 specifies first day of the month and dateOffset=-1 would mean last day of the month. 
2. Choose the day of week pattern using 'dayOfWeekPattern'. For example, First Monday, Last Friday. 


- specificDate: SpecificDateInput
  - Input for selecting a specific date in a month to schedule a snapshot. For example, dateOffset=15 for the 15th day.
- dayOfWeekPattern: DayOfWeekPatternInput
  - Input for selecting a specific day of the week in a month to schedule a snapshot. For example, First Monday or Last Friday.
