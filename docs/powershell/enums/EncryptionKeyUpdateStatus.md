### EncryptionKeyUpdateStatus
Status of the encryption key update for RCV migration.

- UPDATE_STATUS_UNSPECIFIED - Unknown status of the encryption key update.
- NO_MIGRATION_IN_PROGRESS - Encryption key update failed because no migration is in progress for the
location.
- FAILURE - Encryption key update failed.
- INVALID_ENCRYPTION_KEY - Encryption key update failed because the provided encryption key is
invalid.
- SUCCESS - Encryption key update is successful.
