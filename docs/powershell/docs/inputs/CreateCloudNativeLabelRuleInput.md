### CreateCloudNativeLabelRuleInput
Input required to create a cloud-native label rule.

- objectType: CloudNativeLabelObjectType
  - Type of managed object on which label rule will be applied.
- labelRuleName: System.String
  - Name of the label rule.
- label: LabelType
  - Label key-value pair for label rule.
- slaAssignType: TagRuleSlaAssignType
  - Corresponds to the assignment type for the SLA.
- slaId: System.String
  - Corresponds to optional global SLA Rubrik ID.
- cloudNativeAccountIds: CloudNativeIds
  - Cloud native accounts on which label rule will be applied.
- applyToAllCloudAccounts: System.Boolean
  - Specifies whether this label rule apply to all cloud accounts.
