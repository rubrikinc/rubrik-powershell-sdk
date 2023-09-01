### AppItemWithCascadingImpact
App item type with their cascading impact.

- appItemTypeToken: System.String
  - Token specifying the type of the item. The token should exactly match the token retrieved from query graphql field response.
- appItemTypeDisplayName: System.String
  - Display name to be used for the item type.
- count: System.Int32
  - Total number of items of type `appItemTypeToken` that will be restored.
- isOptionalToRestore: System.Boolean
  - Specifies whether this item type is optional to restore.
- cascadedItems: list of AppItemWithCascadingImpacts
  - List of items the restore operation of this item cascades to.
