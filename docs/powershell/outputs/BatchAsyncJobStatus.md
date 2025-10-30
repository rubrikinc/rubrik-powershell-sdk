### BatchAsyncJobStatus
- jobIds: list of AsyncJobStatusJobIds
  - List of map of Rubrik object ID to Job ID for object if pre validation succeeds for object. If pre validation failed, details will be present in error field.
- errors: list of AsyncJobStatusJobErrors
  - List of map of Rubrik object ID to error message for those object for which pre validation failed.
