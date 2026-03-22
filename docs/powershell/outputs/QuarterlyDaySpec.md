### QuarterlyDaySpec
Supported in v9.5+
Specification for a day in a quarterly schedule.

- firstQuarterStartMonth: SlaMonth
  - Required. Supported in v9.5+
The month when Q1 begins. This determines the quarter boundaries. For example, if January, quarters are Jan-Mar, Apr-Jun, Jul-Sep, Oct-Dec. If April, quarters are Apr-Jun, Jul-Sep, Oct-Dec, Jan-Mar.
- dayInMonth: CdmMonthlyDaySpecification
  - Required. Supported in v9.5+
Specifies which day within the selected month. Can be a specific date (using dateOffset) or a day-of-week pattern (using dayOfWeekInMonth).
- monthInQuarter: System.Int32
  - Required. Supported in v9.5+
Which month within the quarter. Valid values: 1 (first month), 2 (second month), 3 (third month).
