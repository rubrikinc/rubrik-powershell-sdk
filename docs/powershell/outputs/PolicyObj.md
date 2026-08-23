### PolicyObj
A workload evaluated against a classification policy at a point in time,
along with its classification and access-risk results.

- snapshotFid: System.String
  - Identifier of the snapshot the results were computed from.
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
  - Operating system of the workload.
- shareType: DataGovShareType
  - Network file-sharing protocol of the workload, when applicable.
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
- hasInsights: System.Boolean
  - Specifies whether the object has insights or not.
- unusedSensitiveFiles: SensitiveFiles
  - Unused sensitive file count for various risk levels.
- isUserActivityEnabled: System.Boolean
  - Specifies whether the user activity for the object is enabled.
- dataTypeResults: list of DataTypeResults
  - Specifies the data type level results.
- assetMetadata: AssetMetadata
  - Specifies the metadata of the asset.
- objectType: DataGovObjectType
  - Specifies the object type of the asset.
- scanStatus: ScanStatus
  - Specifies the scan status of the asset.
- mipLabelsSummary: list of MipLabelSummarys
  - Specifies the sensitive files count summary for MIP Labels.
- violationSeverity: ViolationSeverity
  - Signifies the violation severity of the asset.
- exposureSummary: list of ExposureSummarys
  - Signifies the file exposure summary of the asset.
- attributesSummary: list of AttributesSummarys
  - Specifies the sensitive files count summary for attributes.
- accessTypeSummary: AccessTypeSummary
  - Specifies the access type summary for a principal.
- documentTypesSummary: list of DocumentTypeSummarys
  - Specifies the sensitive files count summary for document types.
- scanErrorInfo: ScanErrorInfo
  - Scan error information for the policy object.
- id: System.String
  - Cache-differentiating identifier for this policy object at a point in time.
- folderChildConnection: FileResultConnection
  - Browse the contents of a directory within this policy object's snapshot.
- fileResultConnection: FileResultConnection
  - File classification results within this policy object's snapshot.
- whitelistedAnalyzerList: list of WhitelistedAnalyzers
  - Whitelisted analyzers for a path in this policy object.
- policySummaries: list of ClassificationPolicySummarys
  - Summaries of the policies that classified this object.
- objectStatus: ObjectStatus
  - Assignment and analysis status of this object.
- allAnalyzerMappings: list of AnalyzerMappings
  - Analyzer mappings for a path in this policy object.
- snappable: HierarchyObject
  - The hierarchy object this policy object describes.
