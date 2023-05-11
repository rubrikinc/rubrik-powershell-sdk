### LabelRule
A single label Rule.

- applyToAllCloudAccounts: System.Boolean
  - Does this tag rule apply to all cloud accounts.
- cloudNativeAccounts: a list of CloudNativeAccountIdWithNames
  - List of cloud-native accounts.
- effectiveSla: TagRuleEffectiveSla
  - Effective SLA Domain defined in the label rule.
- hasPermissionToModify: System.Boolean
  - Specifies whether the user has permissions to modify the label rule.
- id: System.String
  - ID of the label rule.
- label: CloudNativeLabel
  - Label key and value.
- name: System.String
  - Name of the label rule.
- objectType: ManagedObjectType
  - Object type for which the label rule is applicable.
