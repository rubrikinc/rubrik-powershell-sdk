### QueryUnmanagedObjectSnapshotsV1Input


- afterDate: DateTime
  - Filter all the snapshots after a date.
- beforeDate: DateTime
  - Filter all the snapshots before a date.
- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
- id: System.String
  - Required. ID of a object.
- limit: System.Int32
  - Limit the number of matches returned.
- offset: System.Int32
  - Ignore these many matches in the beginning.
- searchValue: System.String
  - Search snapshot by date and time.
- snapshotType: V1QueryUnmanagedObjectSnapshotsV1RequestSnapshotType
  - Filter by snapshot type. Valid types are OnDemand, PolicyBased, Retrieved.
- sortBy: V1QueryUnmanagedObjectSnapshotsV1RequestSortBy
  - Sort by given attribute.
- sortOrder: V1QueryUnmanagedObjectSnapshotsV1RequestSortOrder
  - The sort order. The default sort order is ascending.
