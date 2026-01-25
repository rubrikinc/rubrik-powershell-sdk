### OracleRecoverableRangesMinimalInput
Input for oracleRecoverableRangesMinimal.

- id: System.String
  - Required. ID of the Oracle database.
- beforeTime: DateTime
  - Filter ranges to start before this time. The date-time string should be in ISO8601 format, such as "2016-01-01T01:23:45.678Z".
- afterTime: DateTime
  - Filter ranges to end after this time. The date-time string should be in ISO8601 format, such as "2016-01-01T01:23:45.678Z".
- includeSnapshots: System.Boolean
  - Required. Whether to include database snapshot summaries in the response.
