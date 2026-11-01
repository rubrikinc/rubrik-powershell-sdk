### AwsPermissionsGroupVersion
AwsPermissionsGroupVersion is the deployed and latest version of one
permissions group.

- feature: CloudAccountFeature
  - The cloud account feature.
- permissionsGroup: PermissionsGroup
  - The permissions group within the feature.
- held: System.Boolean
  - Whether the account holds the permissions group.
- currentVersion: System.Int32
  - Version deployed; unset when not held, or when the deployed delta
intervals match no single version.
- latestVersion: System.Int32
  - Version the update applies; unset for a dropped group.
