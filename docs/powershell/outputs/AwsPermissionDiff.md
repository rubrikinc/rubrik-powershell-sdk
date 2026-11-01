### AwsPermissionDiff
AwsGetPermissionDiffReply is the permission difference for the requested
features.

- entries: list of AwsPermissionDiffEntrys
  - One entry per requested feature, permissions group and IAM role.
- unresolvedFeatures: list of CloudAccountFeatures
  - Features with at least one NOT_AVAILABLE entry.
- permissionsGroupVersions: list of AwsPermissionsGroupVersions
  - Deployed and latest version of every AVAILABLE permissions group.
