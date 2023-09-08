### PolicyObj
- snapshotFid: System.String
- snapshotTimestamp: System.Int64
  - Timestamp in ms.
- rootFileResult: FileResult
  - Root file result.
- timeContext: System.String
  - The same snapshot may be returned for different policy object queries at
 different time points since snapshot results are pulled forward if no new
 snapshots have come up from CDM. The daily change values will be
 different for these different time points.

 This time_context field is used by the graphql layer to make sure that
 Apollo cache on the UI can differentiate between the policy object at
 different time points.
- osType: DataGovOsType
- shareType: DataGovShareType
- riskLevel: RiskLevelType
  - Risk level of the policy object.
- analysisStatus: AnalysisStatus
  - Analysis status of the policy object.
- sensitiveFiles: SensitiveFiles
  - Sensitive File count for various risk levels.
- totalSensitiveHits: SummaryHits
  - Sensitive hits accumulated across different workloads for the user.
- analyzerHits: AnalyzerHits
  - Analyzer Hits count for various risk levels.
- accessRiskReasons: list of RiskReasons
  - User access risk reasons.
- userCounts: PrincipalCounts
  - User count for various risk levels.
- riskHits: SensitiveHits
  - Sensitive hits for various risk levels.
- isUserAccessEnabledObject: System.Boolean
  - Specifies whether the object has user access enabled or not.
- deltaUserCounts: PrincipalCounts
  - Change in the user count for various risk levels.
- id: System.String
- folderChildConnection: FileResultConnection
- fileResultConnection: FileResultConnection
- whitelistedAnalyzerList: list of WhitelistedAnalyzers
- policySummaries: list of ClassificationPolicySummarys
- objectStatus: ObjectStatus
- allAnalyzerMappings: list of AnalyzerMappings
- snappable: HierarchyObject
