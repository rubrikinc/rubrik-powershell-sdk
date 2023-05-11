### PrincipalObjectSummary
Summary of a principal object.

- cluster: Cluster
  - Cluster to which this policy belongs.
- fullName: System.String
  - Name of the principal.
- objectId: System.String
  - ID of the object.
- objectName: System.String
  - Name of the object.
- objectType: DataGovObjectType
  - Type of the object.
- principalId: System.String
  - ID of the principal.
- riskLevel: RiskLevelType
  - Risk level for the principal.
- sensitiveFiles: SensitiveFiles
  - Sensitive File count for various risk levels.
- totalSensitiveHits: SummaryHits
  - Sensitive hits accumulated across different workloads for the user.
