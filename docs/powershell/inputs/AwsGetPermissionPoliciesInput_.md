### AwsGetPermissionPoliciesInput
Input to retrieve the AWS permission policies.

- cloudType: AwsCloudType
  - Cloud type (Standard/China) for the cloud account.
- features: list of CloudAccountFeatures
  - List of cloud account features.
- featureSpecificDetails: FeatureSpecificDetailsInput
  - Feature specific details needed to retrieve the permission policies.
- featuresWithPermissionsGroups: list of FeatureWithPermissionsGroupss
  - List of cloud account features with specific permissions group. This is a valid input only for customer-managed cluster users.
