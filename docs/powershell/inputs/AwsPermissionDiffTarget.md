### AwsPermissionDiffTarget
AwsPermissionDiffTarget is the permissions group selection for one feature.

- feature: CloudAccountFeature
  - The feature whose selection is overridden.
- permissionsGroups: list of PermissionsGroups
  - The permissions groups the feature is to hold. Empty keeps the groups the
account already holds.
