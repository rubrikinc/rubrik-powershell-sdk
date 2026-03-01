### ConfiguredSchedule
Supported in v9.6
Contains the configured schedule days for the frequency under which a missed snapshot is detected, as defined in the SLA Domain. Exactly one of the fields will be populated based on the frequency type.

- daysOfMonth: list of CdmMonthlyDaySpecifications
  - Supported in v9.6
List of configured days for monthly frequency.
- daysOfWeek: list of WeeklyDaySpecifications
  - Supported in v9.6
List of configured days for weekly frequency.
- daysOfYear: list of YearlyDaySpecs
  - Supported in v9.6
List of configured days for yearly frequency.
- daysOfQuarter: list of QuarterlyDaySpecs
  - Supported in v9.6
List of configured days for quarterly frequency.
