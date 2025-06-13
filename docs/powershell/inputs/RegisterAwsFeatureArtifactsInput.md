### RegisterAwsFeatureArtifactsInput
Input to register external artifacts for AWS account.

- awsArtifacts: list of AwsAccountFeatureArtifacts
  - List of external Artifacts and features to be registered for AWS native account.
- roleChainingAccountId: System.String
  - UUID of the AWS account to be used for role chaining.
- cloudType: AwsCloudType
  - Cloud type (Standard/China) for the cloud account.
