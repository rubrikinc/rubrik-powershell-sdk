### CreateCloudNativeTagRuleInput
Input required to create a cloud-native tag rule.

- applyToAllCloudAccounts: System.Boolean
  - Specifies whether this tag rule apply to all cloud accounts.
- cloudNativeAccountIds: CloudNativeIds
  - Cloud native accounts on which tag rule will be applied.
- objectType: CloudNativeTagObjectType
  - Type of managed object on which tag rule will be applied.
- slaAssignType: TagRuleSlaAssignType
  - Corresponds to the assignment type for the SLA.
- slaId: System.String
  - Corresponds to optional global SLA Rubrik ID.
- tag: TagType
  - Tag key-value pair for tag rule.
- tagRuleName: System.String
  - Name of the tag rule.
