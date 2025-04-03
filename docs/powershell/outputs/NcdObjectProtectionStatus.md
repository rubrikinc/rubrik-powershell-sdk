### NcdObjectProtectionStatus
ObjectProtectionStatusReply is returned in response to a
ObjectProtectionStatusReq and holds the requested object protection statuses.

- files: NcdFilesObjectProtectionStatusData
  - The object protection status summary for files.
- shares: NcdSharesObjectProtectionStatusData
  - The object protection status summary for shares.
- throughput: System.Int64
  - The throughput.
- averageFileSize: System.Int64
  - The average file size.
