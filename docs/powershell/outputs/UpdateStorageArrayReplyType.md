### UpdateStorageArrayReplyType
Result of a storage array update operation in a Rubrik Cluster.

- hostname: System.String
  - Hostname of the storage array.
- id: System.String
  - ID of the storage array.
- cluster: Cluster
  - Details of the Rubrik cluster.
- detail: StorageArrayDetail
  - Storage array details. Available only when the storage array updates successfully.
- errorMessage: System.String
  - Error message. Available only when the storage array update fails.
