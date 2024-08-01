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
- relationshipType: RelationshipType
  - The type of the relationship between this app item type to the one immediately above it in cascading hierarchy.
- itemKeys: list of System.Strings
  - Keys for the items with type appItemTypeToken.
- pathIdentifier: System.String
  - ID identifying the cascading path for this set of item keys.
- itemsWithActionType: list of cascadingImpactKeyss
  - Keys information for this app item type and with the action to perform on them during a restore.
