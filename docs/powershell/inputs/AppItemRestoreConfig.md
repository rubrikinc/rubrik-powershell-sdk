### AppItemRestoreConfig
Represents the configuration for the items to be restored.

- workloadId: System.String
  - Rubrik ID of the workload whose data items needs to be restored.
- appItemTypeToken: System.String
  - Token specifying the type of the item. The token should exactly match with the token retrieved from query field response.
- itemsToRestore: list of RestoreItemInfos
  - List of items of item type that needs to be restored
