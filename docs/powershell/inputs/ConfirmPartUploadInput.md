### ConfirmPartUploadInput
Input for confirmPartUpload.

- sessionId: System.String
  - Unique identifier for the upload session.
- partIndex: System.Int32
  - One-based index of the part to be uploaded.
- etag: System.String
  - ETag received from MinIO PUT response.
- retryCount: System.Int32
  - Number of times the upload has been retried.
- errorCode: System.String
  - Error code received from MinIO PUT response.
- clusterUuids: list of System.Strings
  - List of cluster UUIDs.
