### UpdateCloudNativeLabelRuleInput
Input required to update a cloud-native label rule.

- applyToAllCloudAccounts: System.Boolean
  - Specifies whether this label rule apply to all cloud accounts.
- cloudNativeAccountIds: CloudNativeIds
  - Cloud native accounts on which label rule will be applied.
- labelRuleId: System.String
  - Label rule ID.
- labelRuleName: System.String
  - Name of the label rule.
- slaAssignType: TagRuleSlaAssignType
  - Corresponds to the assignment type for the SLA.
- slaId: System.String
  - Corresponds to optional global SLA Rubrik ID.
