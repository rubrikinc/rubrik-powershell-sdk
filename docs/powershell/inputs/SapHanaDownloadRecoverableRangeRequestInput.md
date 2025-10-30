### SapHanaDownloadRecoverableRangeRequestInput
Supported in v8.0+

- pointInTime: DateTime
  - Required. Supported in v8.0+
Point in time for which the snapshots should be downloaded for recovery. The date-time string must be in the ISO8601 format. For example, "2016-01-01T01:23:45.678". The timezone is same as the timezone of the Rubrik cluster.
- preferredLocationId: System.String
  - Required. Supported in v8.0+
ID of the location preferred for downloading the base full and log snapshots required for point in time recovery. The snapshots not available at the preferred location will be downloaded from the location where they are available.
