### AttributeRecoveryMode
Specifies the mode for attribute recovery of Azure AD objects.

- ATTRIBUTE_RECOVERY_MODE_UNSPECIFIED - Attribute recovery mode is unspecified.
- ATTRIBUTE_RECOVERY_MODE_MERGE - Replaces single-valued attributes with snapshot values. Adds missing
multi-valued entries from the snapshot without removing live-only entries.
- ATTRIBUTE_RECOVERY_MODE_OVERWRITE - Replaces single-valued and multi-valued attributes with snapshot values.
Live-only multi-valued entries are removed.
- ATTRIBUTE_RECOVERY_MODE_SKIP - Does not modify objects that already exist in the target environment.
Missing objects are created from the snapshot. Relationships are
established only between newly created objects.
NOTE: Not yet supported. Using this value will return an error.
