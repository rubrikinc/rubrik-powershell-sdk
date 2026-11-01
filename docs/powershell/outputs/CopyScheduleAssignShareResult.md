### CopyScheduleAssignShareResult
Per-share outcome of an assign operation.

- shareId: System.String
  - Share ID echoes the input NAS Cloud Direct share identifier so callers can correlate results.
- status: ShareAssignStatus
  - Status is the assign outcome for this share.
- errorMessage: System.String
  - Error message provides detail when status is not SUCCESS.
