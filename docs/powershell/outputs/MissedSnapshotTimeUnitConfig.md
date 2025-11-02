### MissedSnapshotTimeUnitConfig
Supported in v5.0+

- dayOfTime: MissedSnapshotDayOfTimeUnit
  - Supported in v5.0+
Trigger day for Weekly, Monthly, Quarterly, and Yearly units. Accepted values are enum of MissedSnapshotDayOfTimeUnit.
- frequency: System.Int32
  - Required. Supported in v5.0+
- retention: System.Int32
  - Required. Supported in v5.0+
- timeUnit: SlaTimeUnit
  - Required. Supported in v5.0+
Units for frequency and retention. Accepted values are Minute, Hourly, Daily, Weekly, Monthly, Quarterly, and Yearly.
