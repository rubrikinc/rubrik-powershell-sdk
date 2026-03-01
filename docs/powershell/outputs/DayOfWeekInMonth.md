### DayOfWeekInMonth
Supported in v9.5+
Specifies a day-of-week pattern within a month by combining an ordinal position (First, Second, Third, Fourth, Last) with a day of the week (Monday through Sunday).
Examples: - weekOrdinal: Second, dayOfWeek: Friday = Second Friday of the
month
- weekOrdinal: Last, dayOfWeek: Sunday = Last Sunday of the month - weekOrdinal: First, dayOfWeek: Monday = First Monday of the
month

Note: Some months may not have a Fourth or Fifth occurrence of a particular day, in which case they will be ignored for that month.

- dayOfWeek: SlaDayOfWeek
  - Required. Supported in v9.5+
The day of the week (Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, or Sunday).
Combined with weekOrdinal to create patterns like: "Second Friday" (weekOrdinal: Second, dayOfWeek: Friday), "Last Sunday" (weekOrdinal: Last, dayOfWeek: Sunday), "First Monday" (weekOrdinal: First, dayOfWeek: Monday), etc.
- weekOrdinal: CdmWeekOrdinal
  - Required. Supported in v9.5+
The ordinal position of the week within the month.
- First: First occurrence of the specified day in the month - Second: Second occurrence of the specified day in the month - Third: Third occurrence of the specified day in the month - Fourth: Fourth occurrence of the specified day in the month - Last: Last occurrence of the specified day in the month
Note: 'Last' is recommended over 'Fourth' when you want the final occurrence, as not all months have a fourth occurrence of all days.
