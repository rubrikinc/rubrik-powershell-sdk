### YearlyDaySpec
Supported in v9.5+
Specification for a day in a yearly schedule.

- monthOfYear: SlaMonth
  - Supported in v9.6+
The calendar month of the scheduled snapshot day, from January to December.
- dayInMonth: CdmMonthlyDaySpecification
  - Required. Supported in v9.5+
v9.5: Specifies which day within the selected month. Can be a specific date (using dateOffset) or a day-of-week pattern (using dayOfWeekInMonth).

v9.6+: The day within the selected month. This is either a specific date (set through dateOffset) or a day-of-week pattern (set through dayOfWeekInMonth).
- yearStartMonth: SlaMonth
  - Required. Supported in v9.5+
v9.5: The month when the year begins. This determines the year boundaries. For example, if January (default), the year is Jan-Dec. If April, the year is Apr-Mar.

v9.6+: (Deprecated) The calendar month when the SLA year begins. It is only used to read the deprecated monthInYear value, which counts forward from it. For example, if the SLA year begins in April, then April is counted as month 1. Use monthOfYear instead, which does not depend on when the year begins.
- monthInYear: System.Int32
  - Required. Supported in v9.5+
v9.5: Which month within the year. Valid values: 1 (first month) through 12 (twelfth month). The actual calendar month depends on yearStartMonth. For example, if yearStartMonth is April, then monthInYear=1 is April, monthInYear=6 is September, monthInYear=12 is March.

v9.6+: (Deprecated) The month of the snapshot day, given as a position from 1 to 12 counted from yearStartMonth instead of as a calendar month. For example, when yearStartMonth is April, a value of 1 is April, 6 is September, and 12 is March. Use monthOfYear instead, which gives the calendar month directly.
