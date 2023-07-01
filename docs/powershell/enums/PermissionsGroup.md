### PermissionsGroup
PermissionsGroup represents the collection of various permission groups that
 exist across all features. However, not all permission groups are applicable
 to every feature. PermissionsGroup serves as a superset encompassing all
 available permission groups. The specific context of permissions within a
 group depends on the feature to which it is onboarded.

- GROUP_UNSPECIFIED - Unspecified permission group.
- BASIC - Represents the basic set of permissions required to onboard a feature.
 These permissions are applicable to all the features.
- EXPORT_AND_RESTORE - Represents the set of permissions required for export and restore
 operations. These permissions are applicable to the cloud native
 protection feature.
- FILE_LEVEL_RECOVERY - Represents the set of permissions required for file-level recovery
 operation. These permissions are applicable to the cloud native
 protection feature.
- ENCRYPTION - Represents the set of permissions required for encryption
 operation. These permissions are applicable to the cloud native archival
 encryption feature.
- RECOVERY - Represents the set of permissions required for all recovery
 operations. These permissions are applicable to the cloud native
 SQL DB and SQL MI features.
- BACKUP_V2 - Represents the set of permissions required for immutable backup V2
 operations. These permissions are applicable to the cloud native SQL DB
 and SQL MI features.
