### CloudNativeFeatureForPermissionsCheck
Feature for which required permissions have to be checked.
Exactly one of the two features is expected. If both are set the Azure
feature takes precedence and the AWS feature is ignored; if neither is set
the request is rejected as invalid.

- azureFeature: AzureFeatureForPermissionCheck
  - Azure feature.
- awsFeature: AwsFeatureForPermissionCheck
  - AWS feature.
