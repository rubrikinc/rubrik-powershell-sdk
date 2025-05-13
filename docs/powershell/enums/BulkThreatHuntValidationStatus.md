### BulkThreatHuntValidationStatus
Validation status of the bulk threat hunt request.

- FAILURE_UNSPECIFIED - Unspecified validation failure.
- FAILURE_LIMIT_EXCEEDED_V1_HUNTS - Validation failed because the number of separate hunts that will be
triggered exceeds the upper limit.
- SUCCESS_ONLY_V2_HUNT - Validation succeeded and will only trigger a V2 hunt.
- SUCCESS_AT_LEAST_ONE_V1_HUNT - Validation succeeded and will trigger at least one V1 hunt and zero or
more V2 hunt.
