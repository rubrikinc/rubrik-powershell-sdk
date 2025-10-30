### AzureAdObject
Represents a search result for a generic Entra ID object.

- objectId: System.String
  - ID of the Entra ID object.
- type: AzureAdObjectType
  - Entra ID object type.
- snapshotId: System.String
  - ID of the snapshot containing Entra ID Object.
- reverseRelationships: list of AzureAdReverseRelationships
  - Reverse relationships of the Entra ID object.
- relatedItemCount: list of AzureAdRelatedItemCounts
  - Represents count of related items for relationship type.
- snapshotRange: AzureAdSnapshotRange
  - Snapshot range containing the Entra ID object.
- azureAdObjects: AzureAdObjects
  - The Entra ID object.
