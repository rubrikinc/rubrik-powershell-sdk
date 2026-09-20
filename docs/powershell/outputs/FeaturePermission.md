### FeaturePermission
Represents the permissions for a feature.

- feature: CloudAccountFeature
  - Represents the feature for which the permissions are returned.
- permissionJson: System.String
  - Represents the json string of the permissions.
- version: System.Int32
  - Represents the version of the permissions.
- permissionsGroupVersions: list of PermissionsGroupWithVersions
  - Represents the version of the permissions groups.
- hasExocomputeLambdaRole: System.Boolean
  - Whether an Exocompute Lambda execution role ARN is registered for the
cloud account. Meaningful only for the EXOCOMPUTE feature, and false for
every other feature. Also false for every feature of an organization
without private Exocompute enabled. An Exocompute configuration can
request an EKS cluster with a private API endpoint only while this is true.
