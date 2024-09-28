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
- quorumRequirement: TprRequestedChangeEntry
  - Quorum authorization requirement
- templateName: System.String
  - Name of the requested changes template for quorum authorization.
