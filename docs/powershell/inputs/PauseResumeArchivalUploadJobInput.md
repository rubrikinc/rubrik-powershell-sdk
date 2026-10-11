### PauseResumeArchivalUploadJobInput
Input for pausing or resuming an archival upload job.

- clusterUuid: System.String
  - UUID of the CDM cluster running the job.
- eventSeriesId: System.String
  - Event series ID of the archival upload job. This is the activity series ID
shown on the job monitoring dashboard.
- action: ArchivalUploadJobPauseAction
  - Whether to pause or resume the job.
