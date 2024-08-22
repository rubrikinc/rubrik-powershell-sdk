### CreateCloudNativeTagRuleInput
Input required to create a cloud-native tag rule.

- objectType: CloudNativeTagObjectType
  - Type of managed object on which tag rule will be applied.
- tagRuleName: System.String
  - Name of the tag rule.
- tag: TagType
  - Tag key-value pair for tag rule.
- slaAssignType: TagRuleSlaAssignType
  - Deprecated: use bulkAssignSlas to assign SLA Domain to tag rule.
- slaId: System.String
  - Deprecated: use bulkAssignSlas to assign SLA Domain to tag rule.
- cloudNativeAccountIds: CloudNativeIds
  - Cloud native accounts on which tag rule will be applied.
- applyToAllCloudAccounts: System.Boolean
  - Specifies whether this tag rule apply to all cloud accounts.
