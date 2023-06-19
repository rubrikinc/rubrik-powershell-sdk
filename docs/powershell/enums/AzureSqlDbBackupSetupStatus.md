### AzureSqlDbBackupSetupStatus
Status of the setup for taking Azure SQL database backup.

- TEMPORAL_TABLES_EXIST - The Azure database configuration is invalid because of the presence of temporal system-versioned tables.
- ENCRYPTED_OBJECTS_EXIST - The Azure database configuration is invalid because of the presence of encrypted objects.
- SUCCESS - The Azure database backup setup is successful.
- UNSUPPORTED_COLLATION_CONFIG - The Azure database configuration is invalid due to the presence of multiple collations.
- CDC_INVALID_CONFIG - The Azure database configuration is invalid because Change Data Capture (CDC) is misconfigured.
- MISSING_PERMISSIONS - The Azure database configuration is invalid because the backup user is missing some required permissions.
- CDC_DISABLED - The Azure database configuration is invalid because Change Data Capture (CDC) is not enabled.
- NOT_SPECIFIED - The Azure backup setup status is not specified.
- LEDGER_TABLES_EXIST - The Azure database configuration is invalid because of the presence of ledger tables.
- INVALID_CREDENTIALS - The Azure database configuration is invalid because the credentials are invalid.
