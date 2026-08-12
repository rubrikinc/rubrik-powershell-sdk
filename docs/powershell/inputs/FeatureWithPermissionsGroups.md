### FeatureWithPermissionsGroups
Cloud account feature with specific permissions groups.

- featureType: CloudAccountFeature
  - The cloud account feature.
- permissionsGroups: list of PermissionsGroups
  - List of permissions groups to include for the feature.If the list is
empty, all permissions groups will be included.
- tagBindings: list of AwsFeatureTagBindings
  - The customer-supplied IAM Condition tag bindings for this feature. These
apply only to AWS cloud accounts; other clouds ignore them. When the
list is empty, no additional IAM Condition is added.
