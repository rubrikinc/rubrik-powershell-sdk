### AwsPermissionDiffEntry
AwsPermissionDiffEntry is the permission difference for one feature,
permissions group and IAM role. Each grant appears in exactly one of added,
removed, modified and existing, except that a modified action's unchanged
grants are also listed in existing.

- feature: CloudAccountFeature
  - The cloud account feature.
- permissionsGroup: PermissionsGroup
  - The permissions group; unspecified for a whole-feature entry.
- iamRoleName: System.String
  - Name of the IAM role the statements are attached to.
- added: list of AwsPermissionStatements
  - Grants the latest model requires that the account does not have.
- removed: list of AwsPermissionStatements
  - Grants the account has that the latest model no longer requires.
- modified: list of AwsPermissionModifications
  - Grants present on both sides in a different form.
- existing: list of AwsPermissionStatements
  - Unchanged grants, including those of modified actions, for readers that
rebuild a modified action's before and after from them. Populated only
when include_existing is set.
- status: AwsPermissionDiffStatus
  - Whether the diff could be computed.
