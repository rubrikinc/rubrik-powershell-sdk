### GetRecoveryAnalysisResultResp
Response message containing O365 recovery analysis results.
Includes per-user analysis data, aggregate statistics, and metadata about the analysis.

- userAnalyses: list of UserRecoveryAnalysiss
  - Per-user analysis results showing Exchange, OneDrive, and SharePoint.
- summary: RecoveryAnalysisSummary
  - Aggregate statistics summarizing activity across all users.
- metadata: RecoveryAnalysisMetadata
  - Metadata about the analysis including time range and data source paths.
