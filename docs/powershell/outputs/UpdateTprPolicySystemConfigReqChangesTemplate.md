### UpdateTprPolicySystemConfigReqChangesTemplate
TPR requested changes template for updating TPR system configuration policies.

- selectedClusters: TprRequestedChangeClusterSummaryEntry
  - Selected clusters.
- clusterTprRules: TprRequestedChangeTprRuleEntry
  - Cluster-level TPR rules.
- globalTprRules: TprRequestedChangeTprRuleEntry
  - Global TPR rules.
- exemptServiceAccounts: TprRequestedChangeServiceAccountEntry
  - Service accounts exempt from TPR policy.
- templateName: System.String
  - Name of the TPR requested-changes template.
