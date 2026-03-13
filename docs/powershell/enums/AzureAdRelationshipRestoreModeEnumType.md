### AzureAdRelationshipRestoreModeEnumType
Represents the modes for relationship restores for Entra ID objects.

- RELATIONSHIP_RESTORE_MODE_UNSPECIFIED - Unspecified relationship restore mode.
- MERGE - Restore adds missing relationships from snapshot to the Entra ID object being restored.
- SKIP - Restore does not reestablish relationships to the Entra ID object being restored.
- ROLLBACK - Restore will add or remove relationships to match those that existed in the snapshot of the Entra ID object being restored.
- SKIP_EXISTING - Restore only creates relationships between newly restored objects. Relationships to or from objects that already exist are skipped. Not yet supported.
