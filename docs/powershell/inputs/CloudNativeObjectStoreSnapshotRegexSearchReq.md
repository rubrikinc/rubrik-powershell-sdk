### CloudNativeObjectStoreSnapshotRegexSearchReq
CloudNativeObjectStoreSnapshotRegexSearchReq is the request for regex-based
search on the object store snapshot using directory field matching.

- objectStoreId: System.String
  - ID of the object store to search.
- snapshotId: System.String
  - Snapshot ID.
- regexPattern: System.String
  - Regular expression pattern matched against the directory field.
- pagination: ObjectStorePaginationParam
  - Pagination parameters.
