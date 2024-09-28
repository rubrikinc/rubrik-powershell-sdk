### UpdateTprPolicyDataMangementSlaReqChangesTemplate
TPR requested changes template for updating TPR data management by SLA domain policies.

- selectedSlaDomains: TprRequestedChangeSlaDomainSummaryEntry
  - Selected SLA domains.
- tprRules: TprRequestedChangeTprRuleEntry
  - TPR rules.
- exemptServiceAccounts: TprRequestedChangeServiceAccountEntry
  - Service accounts exempt from TPR policy.
- quorumRequirement: TprRequestedChangeEntry
  - Quorum authorization requirement
- templateName: System.String
  - Name of the requested changes template for quorum authorization.
