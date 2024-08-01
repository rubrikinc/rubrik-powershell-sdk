### CascadingImpactActionType
The different types of actions that can be performed on the keys to be restored.

- ACTION_TYPE_UNKNOWN - Specifies that the cause type is unknown. It could be orphaned or deleted or neither of them.
- RECREATE - Specifies that the keys associated with this action type are deleted at source and will be created during the restore process.
- RELINK - Specifies that the keys associated with this action type are orphaned at the source and will be relinked during the restore process.
