### ActiveDirectoryObjectNameConflictOption
Supported in v9.0+
Options for objects that have been moved across Organizational Units (OUs) or Containers.

- ACTIVE_DIRECTORY_OBJECT_NAME_CONFLICT_OPTION_RESTORE_ATTRIBUTES - In case we find samAccount name conflicts with another object, restore the attributes in the object matching the same SamAccount name.
- ACTIVE_DIRECTORY_OBJECT_NAME_CONFLICT_OPTION_SKIP - Skip setting the attributes objects having samAccount name conflict.
