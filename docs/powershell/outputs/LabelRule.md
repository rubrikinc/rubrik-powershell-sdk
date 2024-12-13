### LabelRule
A single label Rule.

- id: System.String
  - ID of the label rule.
- name: System.String
  - Name of the label rule.
- label: CloudNativeLabel
  - Label key and value.
- effectiveSla: TagRuleEffectiveSla
  - Effective SLA Domain defined in the label rule.
- objectType: ManagedObjectType
  - Object type for which the label rule is applicable.
- hasPermissionToModify: System.Boolean
  - Specifies whether the user has permissions to modify the label rule.
- cloudNativeAccounts: list of CloudNativeAccountIdWithNames
  - List of cloud-native accounts.
- applyToAllCloudAccounts: System.Boolean
  - Does this tag rule apply to all cloud accounts.
- rscNativeObjectPendingSla: CompactSlaDomain
  - SLA Domain assignment which is pending on the Rubrik Security Cloud native objects.
