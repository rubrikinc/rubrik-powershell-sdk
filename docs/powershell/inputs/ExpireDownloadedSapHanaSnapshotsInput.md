### ExpireDownloadedSapHanaSnapshotsInput
Input for expiring downloaded SAP HANA snapshots.

- afterTime: DateTime
  - Specifies the time to expire only the snapshots that were taken after the specified time. The date-time string should be in ISO8601 format. For example, "2016-01-01T01:23:45.678".
- beforeTime: DateTime
  - Specifies the time to expire only the snapshots that were taken before the specified time. The date-time string should be in ISO8601 format. For example, "2016-01-01T01:23:45.678".
- id: System.String
  - Required. ID of the SAP HANA database.
- shouldExpireLogsOnly: System.Boolean
  - Specifies whether to expire only the log snapshots or the data snapshots as well. If not configured, both data and log snapshots will be expired.
