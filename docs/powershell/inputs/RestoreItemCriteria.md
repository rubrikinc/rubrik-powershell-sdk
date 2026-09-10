### RestoreItemCriteria
Info specifying the item criteria for restore.

- snapshotId: System.String
  - ID of the snapshot these items need to be restored to.
- sequenceNumber: System.Int32
  - Sequence number of the snapshot these items need to be restored to.
- closestSnapshotTime: DateTime
  - Optional, the closest snapshot time to be used when retrieving data to restore. Either this or snapshotId and sequenceNumber should be specified.
- recordLimit: System.Int32
  - Optional, limits the number of records to be restored.
- sortByParam: SaasSortByParam
  - Optional, field and order used to sort the records.
- itemFilters: RecordFilter
  - Criteria for which matching items will be restored.
- childRestoreItemCriteria: ChildRestoreItemCriteria
  - Optional, criteria used for restoring child items.
