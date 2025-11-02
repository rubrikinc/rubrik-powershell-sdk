### ActiveDirectoryUserPasswordRecoveryOption
Supported in v9.0+
Recovery options for users.

- ACTIVE_DIRECTORY_USER_PASSWORD_RECOVERY_OPTION_DONT_RESTORE_PASSWORD - No password would be set for the objects that would be recovered from Tombstoned state or the new objects that would be created. User will be left in not enabled state.
- ACTIVE_DIRECTORY_USER_PASSWORD_RECOVERY_OPTION_RESTORE_PASSWORD_FROM_BACKUP_COPY - The new users that would be created or the users that would be recovered from Tombstoned state, would have the same password as in the backup copy.
- ACTIVE_DIRECTORY_USER_PASSWORD_RECOVERY_OPTION_RETAIN_RECYCLE_BIN_PASSWORD - While recovering the user from recycle bin, retain the same password as that what user had before it was deleted.
