### PermissionPolicy
AWS permission policy details.

- externalArtifactKey: AwsCloudExternalArtifact
  - External artifact key to uniquely identify the AWS artifact such as cross account role.
- awsManagedPolicies: list of System.Strings
  - List of AWS-managed policy ARNs to be attached to the role.
- customerManagedPolicies: list of CustomerManagedPolicys
  - List of custom policy documents to be attached to the role.
