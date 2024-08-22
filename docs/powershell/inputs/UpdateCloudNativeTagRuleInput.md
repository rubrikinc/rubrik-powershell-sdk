### UpdateCloudNativeTagRuleInput
Input required to update a cloud-native tag rule.

- tagRuleId: System.String
  - Tag rule ID.
- tagRuleName: System.String
  - Name of the tag rule.
- slaAssignType: TagRuleSlaAssignType
  - Deprecated: use bulkAssignSlas to assign SLA Domain to tag rule.
- slaId: System.String
  - Deprecated: use bulkAssignSlas to assign SLA Domain to tag rule.
- cloudNativeAccountIds: CloudNativeIds
  - Cloud native accounts on which tag rule will be applied.
- applyToAllCloudAccounts: System.Boolean
  - Specifies whether this tag rule apply to all cloud accounts.
