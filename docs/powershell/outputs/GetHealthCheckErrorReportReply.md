### GetHealthCheckErrorReportReply
GetHealthCheckErrorReportReply contains the detailed failure
information for a specific health check type.

- csvData: System.String
  - This field contains the CSV-formatted failure report as a string.
The CSV includes headers and detailed information about each failure,
with each row representing a single failure instance.
For archival location checks, this includes location IDs, names, regions,
cloud types, and specific error messages.
