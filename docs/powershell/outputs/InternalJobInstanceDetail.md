### InternalJobInstanceDetail
Supported in v5.0+

- archived: System.Boolean
  - Required. Supported in v5.0+
  Whether this job instance has been archived.
- endTime: System.String
  - Supported in v5.0+
  End time of the job instance.
- errorInfo: System.String
  - Supported in v5.0+
  Error information of the job instance.
- id: System.String
  - Required. Supported in v5.0+
  ID of the instance.
- isDisabled: System.Boolean
  - Required. Supported in v5.0+
  Whether this job is disabled or not.
- jobProgress: System.Single
  - Supported in v5.0+
  The current progress in terms of percentage of the async request.
- jobType: System.String
  - Required. Supported in v5.0+
  Type of the job.
- nodeId: System.String
  - Required. Supported in v5.0+
  ID of the node where the job runs.
- result: System.String
  - Supported in v5.0+
  Result of the job instance. Its meaning depends on the job type but is usually an ID.
- startTime: System.String
  - Supported in v5.0+
  Start time of the job instance.
- status: System.String
  - Required. Supported in v5.0+
  Status of the job instance.
- childJobDebugInfo: System.String
  - Supported in v5.3+
  Some job types create other 'child' jobs to perform their work. Here we show information on how this job is being affected by its child jobs (if any).
- opentracingContext: System.String
  - Supported in v8.1+
  Trace id of the job instance.
- eventSeriesId: System.String
  - Supported in v9.1
  The associated event series ID of the job.
