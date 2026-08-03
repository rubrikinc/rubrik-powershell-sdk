### PolicyHitsSummary
Summary of sensitive data hits for a policy.

- policyName: System.String
  - Name of the policy.
- policyId: System.String
  - ID of the policy.
- riskHits: System.Int64
  - Hits for the risk level for this policy.
- riskLevel: RiskLevelType
  - Risk of this policy.
- sidSensitiveFiles: SensitiveFiles
  - Sensitive file count for this policy for the corresponding SID.
- sidDeltaSensitiveFiles: SensitiveFiles
  - Delta change for this policy for a given time period for the
corresponding SID.
- sidAnalyzerHits: SensitiveHits
  - Analyzer risk hits for the corresponding SID.
- sidDeltaAnalyzerHits: SensitiveHits
  - Delta change of Analyzer risk hits for a given time period for the
corresponding SID.
- sidRiskHits: SensitiveHits
  - Risk hits for the corresponding SID.
- sidDeltaRiskHits: SensitiveHits
  - Delta change of risk hits for a given time period for the
corresponding SID.
- sidObjectCount: SensitiveObjects
  - Risk objects for the corresponding SID.
- sidDeltaObjectCount: SensitiveObjects
  - Delta change of risk objects for a given time period for the
corresponding SID.
- analyzerResults: list of AnalyzerResultss
  - Analyzer results for all the analyzer inside this policy for the
corresponding SID.
