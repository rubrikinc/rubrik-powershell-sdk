### UpdateCloudNativeTagRuleInput
Input required to update a cloud-native tag rule.

- applyToAllCloudAccounts: System.Boolean
  - Specifies whether this tag rule apply to all cloud accounts.
- cloudNativeAccountIds: CloudNativeIds
  - Cloud native accounts on which tag rule will be applied.
- slaAssignType: TagRuleSlaAssignType
  - Corresponds to the assignment type for the SLA.
- slaId: System.String
  - Corresponds to optional global SLA Rubrik ID.
- tagRuleId: System.String
  - Tag rule ID.
- tagRuleName: System.String
  - Name of the tag rule.
