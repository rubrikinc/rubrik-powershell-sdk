### GetRecoveryAnalysisResultReq
Request message for retrieving O365 recovery analysis results.
This retrieves the analysis of O365 activity data (Exchange, OneDrive, SharePoint)
for a given taskchain, providing per-user statistics and aggregate summaries.

- taskchainId: System.String
  - The ID of the recovery analysis taskchain.
- groupId: System.String
  - The O365 group ID.
