### PrincipalSummary
Summary of a principal.

- domainId: System.String
  - ID of the domain to which the principal belongs.
- domainName: System.String
  - Name of the domain to which the principal belongs.
- fullName: System.String
  - Name of the principal.
- numDescendants: System.Int32
  - Number of descendants of the principal (user or group). For a user,
 this will always be 0.
- principalId: System.String
  - ID of the principal.
- riskLevel: RiskLevelType
  - Risk level for the principal.
- riskReasons: PrincipalRiskReasons
  - Risk reasons for a principal.
- sensitiveFiles: SensitiveFiles
  - Sensitive File count for various risk levels.
- sensitiveObjectCount: SummaryCount
  - Number of objects on which the user has sensitive hits.
- totalSensitiveHits: SummaryHits
  - Sensitive hits accumulated across different workloads for the user.
- upn: System.String
  - Unique name for the principal (user or group).
