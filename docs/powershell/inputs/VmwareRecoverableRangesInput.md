### VmwareRecoverableRangesInput
Input for getting recoverable ranges of a Virtual Machine.

- afterTime: DateTime
  - Filter ranges to end after this time. The date-time string should be in ISO8601 format, such as `2018-01-01T01:23:45.678Z`.
- beforeTime: DateTime
  - Filter ranges to start before this time. The date-time string should be in ISO8601 format, such as `2018-01-01T01:23:45.678Z`.
- id: System.String
  - Required. The virtual machine ID.
