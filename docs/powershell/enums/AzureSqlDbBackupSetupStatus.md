### AzureSqlDbBackupSetupStatus
Status of the setup for taking Azure SQL database backup.

- NOT_SPECIFIED - The Azure backup setup status is not specified.
- SUCCESS - The Azure database backup setup is successful.
- INVALID_CREDENTIALS - The Azure database configuration is invalid because the credentials are invalid.
- CDC_DISABLED - The Azure database configuration is invalid because Change Data Capture (CDC) is not enabled.
- CDC_INVALID_CONFIG - The Azure database configuration is invalid because Change Data Capture (CDC) is misconfigured.
- UNSUPPORTED_COLLATION_CONFIG - The Azure database configuration is invalid due to the presence of multiple collations.
- MISSING_PERMISSIONS - The Azure database configuration is invalid because the backup user is missing some required permissions.
- TEMPORAL_TABLES_EXIST - The Azure database configuration is invalid because of the presence of temporal system-versioned tables.
- LEDGER_TABLES_EXIST - The Azure database configuration is invalid because of the presence of ledger tables.
- ENCRYPTED_OBJECTS_EXIST - The Azure database configuration is invalid because of the presence of encrypted objects.
- UNSUPPORTED_COLUMNS_EXIST - The Azure database configuration is invalid because of the presence of unsupported columns.
- SUCCESS_BAK - The Azure database backup setup for BAK backups is successful.
