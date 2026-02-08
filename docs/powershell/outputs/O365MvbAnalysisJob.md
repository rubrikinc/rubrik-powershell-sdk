### O365MvbAnalysisJob
Defines the information for O365 MVB analysis job.

- taskchainId: System.String
  - ID of the taskchain for the job.
- status: O365MvbAnalysisJobStatus
  - Current status of the job.
- resultsExpiryTime: DateTime
  - Expiration time of the recovery analysis results.
Nil if taskchain is in progress or failed.
