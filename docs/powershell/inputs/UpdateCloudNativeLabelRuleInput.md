### UpdateCloudNativeLabelRuleInput
Input required to update a cloud-native label rule.

- labelRuleId: System.String
  - Label rule ID.
- labelRuleName: System.String
  - Name of the label rule.
- slaAssignType: TagRuleSlaAssignType
  - Deprecated: use bulkAssignSlas to assign SLA Domain to tag rule.
- slaId: System.String
  - Deprecated: use bulkAssignSlas to assign SLA Domain to tag rule.
- cloudNativeAccountIds: CloudNativeIds
  - Cloud native accounts on which label rule will be applied.
- applyToAllCloudAccounts: System.Boolean
  - Specifies whether this label rule apply to all cloud accounts.
