### ExportPolicyViolationsCsvReply
Response returned when the CSV export request is accepted.
The CSV file is generated asynchronously; use the download identifier
to poll for status and retrieve the download URL once ready.

- downloadId: System.Int64
  - Identifier for tracking the asynchronous CSV export. Use this to
poll for export status and to retrieve the download URL once the
file is ready.
