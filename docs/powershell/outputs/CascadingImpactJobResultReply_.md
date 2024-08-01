### CascadingImpactJobResultReply
- jobStatus: TaskchainState
  - Status of the cascading impact job.
- stateToken: System.String
  - Token storing the state of the restore flow the cascading analysis was triggered during.
- result: AppItemWithCascadingImpact
  - The result of the cascading impact. This is defined only when the
 job_status is SUCCEEDED.
