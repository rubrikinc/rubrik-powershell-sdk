### CascadingImpactActionType
The different types of actions that can be performed on the keys to be restored.

- ACTION_TYPE_UNKNOWN - Specifies that the cause type is unknown. It could be orphaned or deleted
or neither of them.
- RECREATE - Specifies that the keys associated with this action type are deleted at
the source and will be created during the restore process.
- RELINK - Specifies that the keys associated with this action type are orphaned at
the source and will be relinked during the restore process.
- OVERWRITE - Specifies that the keys associated with this action type are modified at
the source and will be overwritten during the restore process.
- UNDELETE_NOOP - Specifies that the keys associated with this action type are cascade
children of a record being undeleted; the source system's cascade-undelete
behavior restores them automatically, so no explicit restore action is
performed for them.
