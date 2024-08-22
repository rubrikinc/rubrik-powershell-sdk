### CreateCloudNativeLabelRuleInput
Input required to create a cloud-native label rule.

- objectType: CloudNativeLabelObjectType
  - Type of managed object on which label rule will be applied.
- labelRuleName: System.String
  - Name of the label rule.
- label: LabelType
  - Label key-value pair for label rule.
- slaAssignType: TagRuleSlaAssignType
  - Deprecated: use bulkAssignSlas to assign SLA Domain to tag rule.
- slaId: System.String
  - Deprecated: use bulkAssignSlas to assign SLA Domain to tag rule.
- cloudNativeAccountIds: CloudNativeIds
  - Cloud native accounts on which label rule will be applied.
- applyToAllCloudAccounts: System.Boolean
  - Specifies whether this label rule apply to all cloud accounts.
