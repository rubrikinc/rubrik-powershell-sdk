### UpdateTprPolicyInput
Update a TPR policy.

- policyId: System.String
  - ID of the TPR policy.
- name: System.String
  - Name of the TPR policy.
- description: System.String
  - Description of the TPR policy.
- policyRules: list of TprPolicyRuleInputs
  - Rules of the TPR policy.
- exemptServiceAccounts: list of System.Strings
  - Service accounts exempt from the TPR policy.
