### CreateTprPolicyInput
Create a TPR policy.

- name: System.String
  - Name of the TPR policy.
- description: System.String
  - Description of the TPR policy.
- policyScope: TprPolicyScope
  - Scope of the TPR policy.
- policyRules: list of TprPolicyRuleInputs
  - Rules of the TPR policy.
- exemptServiceAccounts: list of System.Strings
  - IDs of service accounts exempt from the TPR policy.
