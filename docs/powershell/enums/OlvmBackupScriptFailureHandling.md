### OlvmBackupScriptFailureHandling
Action to take if an OLVM pre/post backup script fails or times out.

- OLVM_BACKUP_SCRIPT_FAILURE_HANDLING_UNSPECIFIED - Failure handling is not set or the persisted value is unrecognized.
- OLVM_BACKUP_SCRIPT_FAILURE_HANDLING_ABORT - Abort the backup job when the script fails.
- OLVM_BACKUP_SCRIPT_FAILURE_HANDLING_CONTINUE - Log the failure and proceed with the backup.
