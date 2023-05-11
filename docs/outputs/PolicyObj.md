### PolicyObj
- accessRiskReasons: a list of RiskReasons
  - User access risk reasons.
- allAnalyzerMappings: a list of AnalyzerMappings
  - None
- analysisStatus: AnalysisStatus
  - Analysis status of the policy object.
- analyzerHits: AnalyzerHits
  - Analyzer Hits count for various risk levels.
- fileResultConnection: FileResultConnection
  - None
- folderChildConnection: FileResultConnection
  - None
- id: System.String
  - None
- objectStatus: ObjectStatus
  - None
- osType: DataGovOsType
  - None
- policySummaries: a list of ClassificationPolicySummarys
  - None
- riskLevel: RiskLevelType
  - Risk level of the policy object.
- rootFileResult: FileResult
  - Root file result.
- sensitiveFiles: SensitiveFiles
  - Sensitive File count for various risk levels.
- shareType: DataGovShareType
  - None
- snappable: HierarchyObject
  - None
- snapshotFid: System.String
  - None
- snapshotTimestamp: System.Int64
  - Timestamp in ms.
- timeContext: System.String
  - The same snapshot may be returned for different policy object queries at
 different time points since snapshot results are pulled forward if no new
 snapshots have come up from CDM. The daily change values will be
 different for these different time points.

 This time_context field is used by the graphql layer to make sure that
 Apollo cache on the UI can differentiate between the policy object at
 different time points.
- totalSensitiveHits: SummaryHits
  - Sensitive hits accumulated across different workloads for the user.
- whitelistedAnalyzerList: a list of WhitelistedAnalyzers
  - None
