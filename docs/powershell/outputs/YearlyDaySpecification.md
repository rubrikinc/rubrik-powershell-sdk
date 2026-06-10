### YearlyDaySpecification
Specification for a day in a yearly schedule. Identifies a specific
month and a day within that month.

- monthInYear: Month
  - The calendar month for the snapshot day.
- dayOfMonthSpecification: MonthlyDaySpec
  - Day of month specification within the selected month. Can be a
specific date (using dateOffset) or a day-of-week pattern
(e.g., Second Friday of March).
