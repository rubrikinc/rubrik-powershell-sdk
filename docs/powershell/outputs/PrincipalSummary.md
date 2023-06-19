### PrincipalSummary
Summary of a principal.

- fullName: System.String
  - Name of the principal.
- principalId: System.String
  - ID of the principal.
- riskLevel: RiskLevelType
  - Risk level for the principal.
- sensitiveFiles: SensitiveFiles
  - Sensitive File count for various risk levels.
- totalSensitiveHits: SummaryHits
  - Sensitive hits accumulated across different workloads for the user.
- sensitiveObjectCount: SummaryCount
  - Number of objects on which the user has sensitive hits.
- upn: System.String
  - Unique name for the principal (user or group).
- numDescendants: System.Int32
  - Number of descendants of the principal (user or group). For a user,
 this will always be 0.
- domainId: System.String
  - ID of the domain to which the principal belongs.
- domainName: System.String
  - Name of the domain to which the principal belongs.
- riskReasons: PrincipalRiskReasons
  - Risk reasons for a principal.
- deltaSensitiveHits: SummaryHits
  - Delta sensitive hits accumulated across different workloads for the user.
