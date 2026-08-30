### AppItemRestoreInfo
Represents the app items that need to be restored.

- workloadId: System.String
  - Rubrik ID of the workload whose data items need to be restored.
- appItemTypeToken: System.String
  - Token specifying the type of the item. The token should exactly match the token retrieved from the query field response.
- itemsToRestore: list of RestoreItemInfos
  - List of items of item type that need to be restored.
- itemCriteria: RestoreItemCriteria
  - Optional, the criteria for which matching items will be restored, as an alternative to specifying the items directly.
- excludeChildren: list of ExcludedChildDetailss
  - List of child objects for the given workload that need to be excluded from the restore.
- hierarchyDepth: System.Int32
  - The maximum depth of the cascaded hierarchy for the given workload. A larger value may result in a longer response time.
- fieldsToRestore: list of System.Strings
  - Optional. The fields to restore. If specified, only these fields are restored.
