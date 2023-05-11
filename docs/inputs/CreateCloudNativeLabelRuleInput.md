### CreateCloudNativeLabelRuleInput
Input required to create a cloud-native label rule.

- applyToAllCloudAccounts: System.Boolean
  - Specifies whether this label rule apply to all cloud accounts.
- cloudNativeAccountIds: CloudNativeIds
  - Cloud native accounts on which label rule will be applied.
- label: LabelType
  - Label key-value pair for label rule.
- labelRuleName: System.String
  - Name of the label rule.
- objectType: CloudNativeLabelObjectType
  - Type of managed object on which label rule will be applied.
- slaAssignType: TagRuleSlaAssignType
  - Corresponds to the assignment type for the SLA.
- slaId: System.String
  - Corresponds to optional global SLA Rubrik ID.
