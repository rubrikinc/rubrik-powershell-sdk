### CloudNativeTagRule
Cloud-native tag rule.

- id: System.String
  - ID of the tag rule.
- name: System.String
  - Name of the tag rule.
- tag: TagRuleTag
  - Tag for the tag rule.
- effectiveSla: TagRuleEffectiveSla
  - Effective SLA domain to be assigned to objects.
- objectType: ManagedObjectType
  - Object type to which the tag rule will be applied.
- hasPermissionToModify: System.Boolean
  - Specifies whether the user has permissions to modify the tag rule.
- cloudNativeAccounts: list of CloudNativeAccountIdWithNames
  - Cloud-native accounts for the tag rule.
- applyToAllCloudAccounts: System.Boolean
  - Does this tag rule apply to all cloud accounts.
