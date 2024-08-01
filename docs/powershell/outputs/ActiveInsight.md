### ActiveInsight
An active insight for the account.

- id: System.String
  - The ID of the insight.
- title: System.String
  - The title of the insight.
- description: System.String
  - The description of the insight.
- resolution: System.String
  - The resolution of the insight.
- severity: InsightSeverity
  - The severity of the insight.
- category: InsightCategory
  - The category of the insight.
- labels: list of System.Strings
  - The labels of the insight.
- automatedCaseId: System.String
  - The ID of the support case created for the insight.
- type: InsightType
  - The type of the insight.
- clusters: list of ActiveInsightClusterMetadatas
  - The clusters for which the insight matched.
