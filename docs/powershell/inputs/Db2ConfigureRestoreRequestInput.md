### Db2ConfigureRestoreRequestInput
Supported in v9.1+

- expiryTimestamp: DateTime
  - Supported in v9.1+
Configure an expiry timestamp for the designated target hosts that require configuration. The date-time string must be in the ISO8601 format, such as \"2016-01-01T01:23:45.678\". The timezone aligns with that of the Rubrik cluster.
- hostIdsToAdd: list of System.Strings
  - Required. Supported in v9.1+
Configure the list of target hosts for restoring a database on a different host.
- hostIdsToRemove: list of System.Strings
  - Required. Supported in v9.1+
Remove the configuration for the list of target hosts for restoring a database on a different host.
