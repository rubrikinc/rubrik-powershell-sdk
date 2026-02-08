### AsyncJobStatus
Represents the status of a single async job.

- jobId: System.String
  - Job ID for the object if pre-validation succeeds for the object. If
pre-validation fails Job ID will be empty and details
will be present in the error field.
- error: System.String
  - Error message if pre validation failed.
