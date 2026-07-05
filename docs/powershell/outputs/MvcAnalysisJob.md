### MvcAnalysisJob
MvcAnalysisJob represents the most recent MVC analysis job for a profile.

- taskchainId: System.String
  - ID of the taskchain for the job.
- status: O365MvbAnalysisJobStatus
  - Current status of the job.
- resultsExpiryTime: DateTime
  - Expiration time of the recovery analysis results.
- recoveryPlanId: System.String
  - ID of the Recovery Plan this analysis is scoped to. Null when the
analysis covers the whole minimum viable company profile rather than
a single Recovery Plan.
