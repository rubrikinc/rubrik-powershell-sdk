### BulkUpdateNasSharesReply
Supported in v8.1+
Result of update performed on multiple NAS shares.

- refreshNasSharesStatuses: list of AsyncRequestStatuss
  - Required. Supported in v8.1+
The asynchronous request statuses of the jobs that check NAS Share connectivity for each of the updated shares.
- shareDetails: list of NasShareDetails
  - Required. Supported in v8.1+
Details of updated NAS shares.
