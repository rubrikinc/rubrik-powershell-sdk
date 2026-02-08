### OperationQuarantineSpec
New quarantine spec for operations (different from snapshot-based
quarantine).

- workloadId: System.String
  - Workload ID.
- filePath: System.String
  - File path to quarantine.
- fileVersion: DateTime
  - File version represented as modified time.
- fileMetadata: FileMetadataInput
  - File Metadata for the file.
- metadata: MetadataOneof
  - This represents the metadata for quarantine operation.
