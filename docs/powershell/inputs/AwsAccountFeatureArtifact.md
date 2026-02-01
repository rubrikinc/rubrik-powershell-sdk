### AwsAccountFeatureArtifact
AWS Native ID to features/artifacts map.

- awsNativeId: System.String
  - AWS native ID of the account being onboarded.
- externalArtifacts: list of ExternalArtifactMaps
  - Details of the artifacts to be registered.
- features: list of CloudAccountFeatures
  - List of RSC features being enabled.
- featuresWithPermissionsGroups: list of FeatureWithPermissionsGroupss
  - List of cloud account features with specific permissions groups.
