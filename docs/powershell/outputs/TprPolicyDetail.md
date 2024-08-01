### TprPolicyDetail
Response for getting the TPR Policy detail.

- name: System.String
  - Name of the TPR policy.
- description: System.String
  - Description of the TPR policy.
- createdAt: DateTime
  - The time at which the TPR policy was created.
- createdBy: UserSummary
  - The user who created the TPR policy.
- exemptServiceAccounts: list of ServiceAccountClients
  - Service accounts exempt from the TPR policy.
- policyId: System.String
  - ID of the TPR policy.
- policyRules: list of TprPolicyRules
  - Rules of the TPR policy.
- policyScope: TprPolicyScope
  - The scope of the TPR policy.
