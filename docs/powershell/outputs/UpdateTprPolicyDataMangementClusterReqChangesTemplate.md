### UpdateTprPolicyDataMangementClusterReqChangesTemplate
TPR requested changes template for updating TPR data management by cluster policies.

- selectedClusters: TprRequestedChangeClusterSummaryEntry
  - Selected clusters.
- tprRules: TprRequestedChangeTprRuleEntry
  - TPR rules.
- exemptServiceAccounts: TprRequestedChangeServiceAccountEntry
  - Service accounts exempt from TPR policy.
- quorumRequirement: TprRequestedChangeEntry
  - Quorum authorization requirement
- isCdmEnforcementDisabled: TprRequestedChangeEntry
  - Whether CDM enforcement is turned off for the policy.
- templateName: System.String
  - Name of the requested changes template for quorum authorization.
