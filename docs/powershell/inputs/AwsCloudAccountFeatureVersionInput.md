### AwsCloudAccountFeatureVersionInput
Input to protect a feature for the AWS cloud account.

- feature: CloudAccountFeature
  - Name of feature to be protected for cloud account.
- version: System.Int32
  - Version of feature. This should be same as the response given in the first step (validateAndCreateAwsCloudAccount).
- permissionsGroupVersions: list of PermissionsGroupWithVersionInputs
  - List of permissions groups with corresponding versions valid only for customer-managed cluster users.
