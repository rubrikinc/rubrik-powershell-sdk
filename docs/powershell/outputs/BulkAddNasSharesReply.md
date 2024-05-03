### BulkAddNasSharesReply
Supported in v8.1+
  Response for operation to manually add multiple NAS shares.

- refreshNasSharesStatus: AsyncRequestStatus
  - Required. Supported in v8.1+
  The asynchronous request status of the job that checks NAS Share connectivity.
- nasSourceId: System.String
  - Required. Supported in v8.1+
  The managed ID of the NAS associated with the share.
- nasShareDetails: list of NasShareDetails
  - Required. Supported in v8.1+
  Details of added NAS shares.
