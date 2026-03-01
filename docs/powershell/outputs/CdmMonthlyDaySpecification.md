### CdmMonthlyDaySpecification
Supported in v9.5+
Specifies which day of the month to take snapshot. Supports specific dates (relative to start or end of month) and day-of-week patterns (e.g., "Second Friday", "Last Sunday"). Exactly one of 'dateOffset' or 'dayOfWeekInMonth' must be specified.

- dayOfWeekInMonth: DayOfWeekInMonth
  - Supported in v9.5+
Day-of-week pattern specification for pattern-based scheduling. Mutually exclusive with dateOffset.
Specifies when a particular day of the week occurs  within the month (e.g., "Second Friday", "Last Sunday").
- dateOffset: System.Int32
  - Supported in v9.5+
Date offset within the month for specific date scheduling. Mutually exclusive with dayOfWeekInMonth.
Allows positive values (1 to 28): Offset from the start of the month. - 1 = First day of the month - 15 = Fifteenth day of the month - 28 = Twenty-eighth day of the month
Allows negative values (-1 to -28): Offset from the end of the month. - -1 = Last day of the month - -2 = Second last day of the month - -3 = Third last day of the month - -28 = Twenty-eighth day from the end of the month
Zero (0) is not allowed and will result in a validation error.
Negative offset always counts from the actual end of the month, so -1 will always be the last day regardless of month length (e.g., January 31st, February 28th/29th, etc.). Valid range: -28 to 28 (excluding 0).
