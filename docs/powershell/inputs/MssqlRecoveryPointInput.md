### MssqlRecoveryPointInput
Supported in v5.0+

- lsnPoint: LsnRecoveryPointInput
  - Supported in v5.0+
- timestampMs: System.Int64
  - Recovery point specified in the form of a timestamp (in milliseconds). Deprecated. Use 'date' instead.
- date: DateTime
  - Supported in v5.2+
Recovery point specified in ISO8601 format, such as "2016-01-01T01:23:45.678".
