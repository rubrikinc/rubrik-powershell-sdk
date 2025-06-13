### GeneratePresignedUrlForPartUploadInput
Input for generatePresignedUrlForPartUpload.

- account: System.String
  - RSC account id.
- sessionId: System.String
  - Unique identifier for the upload session.
- partIndex: System.Int32
  - One-based index of the part to be uploaded.
- retryCount: System.Int32
  - Number of times this specific part upload has been retried.
- clusterUuids: list of System.Strings
  - List of cluster UUIDs.
